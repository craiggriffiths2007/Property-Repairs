using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PropertyRepairs.Data;
using PropertyRepairs.Models;
using Microsoft.AspNetCore.Identity;
using PropertyRepairs.Data;
using PropertyRepairs;
using Microsoft.AspNetCore.StaticFiles;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.Razor;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PropertyRepairs.Data.AppDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PropertyRepairsContext") ?? throw new InvalidOperationException("Connection string 'PropertyRepairsContext' not found.")));

//builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<AppDBContext>();

//builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = false)
//    .AddEntityFrameworkStores<PropertyRepairs.Data.AppDBContext>();

builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.User.RequireUniqueEmail = true;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;

})
           .AddDefaultTokenProviders()
           .AddDefaultUI()
           .AddRoles<IdentityRole>()
           .AddEntityFrameworkStores<AppDBContext>();




// swagger
builder.Services.AddEndpointsApiExplorer();
/*
builder.Services.AddControllers()
        .AddNewtonsoftJson(options =>
        {
            // Configure Newtonsoft.Json options here
            options.SerializerSettings.TypeNameHandling = TypeNameHandling.Auto;
            options.SerializerSettings.Formatting = Formatting.Indented;
            options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
        });
*/
builder.Services.AddScoped<Repo>();


builder.Services.Configure<RazorViewEngineOptions>(options =>
{
    options.ViewLocationExpanders.Add(new CustomViewLocationExpander());
});

builder.Services.AddControllersWithViews();

var app = builder.Build();

var provider = new FileExtensionContentTypeProvider();

provider.Mappings[".glb"] = "model/gltf-binary";

app.UseStaticFiles(new StaticFileOptions
{
    ContentTypeProvider = provider
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseHttpsRedirection();
}
app.UseStaticFiles();

app.UseRouting();

app.UseSwagger();

app.UseSwaggerUI(c => // should open variable type information automatically but dont think it does
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");

    // Shows the model schemas (data types) by default
    c.DefaultModelRendering(Swashbuckle.AspNetCore.SwaggerUI.ModelRendering.Model);

    // Pre-expands the nested fields inside the endpoints
    c.DefaultModelExpandDepth(3);
});

// Register endpoints from the extension method
app.MapAPIEndpoints();


app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

// Seeding user roles
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var loggerFactory = services.GetRequiredService<ILoggerFactory>();
    try
    {
        var context = services.GetRequiredService<AppDBContext>();
        var userManager = services.GetRequiredService<UserManager<AppUser>>();
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
        await DbInitializer.SeedRolesAsync(userManager, roleManager);
        await DbInitializer.SeedSuperAdminAsync(userManager, roleManager);
    }
    catch (Exception ex)
    {
        var logger = loggerFactory.CreateLogger<Program>();
        logger.LogError(ex, "An error occurred seeding the DB.");
    }
}

app.UseSwaggerUI();

app.Run();

