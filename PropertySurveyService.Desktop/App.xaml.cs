using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PropertySurveyService.Data;
using System;
using System.IO;
using System.Windows;

namespace PropertySurveyService.Desktop
{
    public partial class App : Application
    {
        private IHost? _host;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            _host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    // load configuration from the web project's appsettings.json
                    var basePath = AppDomain.CurrentDomain.BaseDirectory;
                    var webAppSettings = Path.Combine(basePath, "..", "PropertySurveyService", "appsettings.json");
                    if (File.Exists(webAppSettings))
                    {
                        config.AddJsonFile(webAppSettings, optional: true, reloadOnChange: true);
                    }
                })
                .ConfigureServices((context, services) =>
                {
                    var configuration = context.Configuration;
                    // Prefer the web project's connection keys so the desktop reads the same database the web app uses.
                    // Log configuration diagnostics
                    try
                    {
                        var basePath = AppDomain.CurrentDomain.BaseDirectory;
                        var webAppSettings = Path.Combine(basePath, "..", "PropertySurveyService", "appsettings.json");
                        Console.WriteLine($"[Desktop] Computed web appsettings path: {webAppSettings}");
                        Console.WriteLine($"[Desktop] web appsettings exists: {File.Exists(webAppSettings)}");
                    }
                    catch { }

                    var conn = configuration.GetConnectionString("PropertySurveyServiceContext")
                               ?? configuration.GetConnectionString("AppDBContext")
                               ?? configuration.GetConnectionString("DefaultConnection");

                    // If Host configuration did not contain connection strings (e.g., web appsettings not found),
                    // try to locate the web project's appsettings.json by searching upward from base directory and parse it.
                    if (string.IsNullOrEmpty(conn))
                    {
                        try
                        {
                            var search = AppDomain.CurrentDomain.BaseDirectory;
                            string found = null!;
                            var dir = new DirectoryInfo(search);
                            for (int i = 0; i < 6 && dir != null; i++)
                            {
                                var candidate = Path.Combine(dir.FullName, "PropertySurveyService", "appsettings.json");
                                if (File.Exists(candidate))
                                {
                                    found = candidate;
                                    break;
                                }
                                dir = dir.Parent;
                            }
                            if (!string.IsNullOrEmpty(found) && File.Exists(found))
                            {
                                Console.WriteLine($"[Desktop] Found web appsettings at: {found}");
                                var json = File.ReadAllText(found);
                                using var doc = System.Text.Json.JsonDocument.Parse(json);
                                if (doc.RootElement.TryGetProperty("ConnectionStrings", out var cs))
                                {
                                    if (cs.TryGetProperty("PropertySurveyServiceContext", out var prop)) conn = prop.GetString();
                                    if (string.IsNullOrEmpty(conn) && cs.TryGetProperty("AppDBContext", out prop)) conn = prop.GetString();
                                    if (string.IsNullOrEmpty(conn) && cs.TryGetProperty("DefaultConnection", out prop)) conn = prop.GetString();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"[Desktop] Failed to read web appsettings.json: {ex.Message}");
                        }
                    }
                    Console.WriteLine($"[Desktop] Resolved connection strings: PropertySurveyServiceContext='{configuration.GetConnectionString("PropertySurveyServiceContext")}', AppDBContext='{configuration.GetConnectionString("AppDBContext")}', DefaultConnection='{configuration.GetConnectionString("DefaultConnection")}'");
                    if (!string.IsNullOrEmpty(conn))
                    {
                        // Register the shared AppDBContext so the desktop reads the same data as the web app.
                        services.AddDbContext<PropertySurveyService.Data.AppDBContext>(options => options.UseSqlServer(conn));
                        // Log chosen connection for diagnostics when running from CLI
                        Console.WriteLine($"[Desktop] Using connection string: {conn}");
                    }

                    services.AddTransient<MainViewModel>();
                    services.AddSingleton<MainWindow>();
                })
                .Build();

            // start host
            _host.Start();

            // Previously showed a modal diagnostic MessageBox here. Remove modal UI.
            // Keep a light-weight console diagnostic so developers can inspect logs if needed.
            try
            {
                using var diagScope = _host.Services.CreateScope();
                var db = diagScope.ServiceProvider.GetService<PropertySurveyService.Data.AppDBContext>();
                if (db != null)
                {
                    var customerCount = db.Customer.CountAsync().GetAwaiter().GetResult();
                    Console.WriteLine($"[Desktop] Connected to DB. Customer count: {customerCount}");
                }
                else
                {
                    Console.WriteLine("[Desktop] AppDBContext not registered or could not be resolved.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Desktop] Diagnostic query failed: {ex}");
            }

            var main = _host.Services.GetService<MainWindow>() ?? _host.Services.GetRequiredService<MainWindow>();
            main.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            _host?.StopAsync().GetAwaiter().GetResult();
            _host?.Dispose();
        }
    }
}
