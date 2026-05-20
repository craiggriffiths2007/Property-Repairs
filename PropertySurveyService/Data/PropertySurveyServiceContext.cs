using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertySurveyService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;


namespace PropertySurveyService.Data
{
    public class AppDBContext : IdentityDbContext<AppUser>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public DbSet<PropertySurveyService.Models.Job> Job { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.Customer> Customer { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.Contract> Contract { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.Agent> Agent { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.JobHeader> JobHeader { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.Aluminium> Aluminium { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.Bifolding> Bifolding { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.Composite> Composite { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.Conservatory> Conservatory { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.Garage> Garage { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.Glass> Glass { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.Greenhouse> Greenhouse { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.Lockmech> Lockmech { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.Panel> Panel { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.Timber> Timber { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.UPVC> UPVC { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.Frame> Frame { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.PhotoImage> Images { get; set; } = default!;

        public DbSet<PropertySurveyService.Models.Branch> Branches { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.Vehicle> Vehicles { get; set; } = default!;

        public DbSet<PropertySurveyService.Models.VehicleCheckHeader> VehicleCheckHeaders { get; set; } = default!;

        public DbSet<PropertySurveyService.Models.DeliveryVan> DeliveryVans { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.DeliveryHGV> DeliveryHGVs { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.FitterVan> FitterVans { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.SalesCar> SalesCars { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.VAccident> VAccidents { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.Whitness> Whitnesses { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.FAccident> FAccidents { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.ToolCheck> ToolChecks { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.MileageSheet> MileageSheets { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.LadderCheck> LadderChecks { get; set; } = default!;
        public DbSet<PropertySurveyService.Models.SpotCheck> SpotChecks { get; set; } = default;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            var decimalProps = builder.Model
            .GetEntityTypes()
            .SelectMany(t => t.GetProperties())
            .Where(p => (System.Nullable.GetUnderlyingType(p.ClrType) ?? p.ClrType) == typeof(decimal));

            //builder.Entity<DeliveryVan>();
            //builder.Entity<DeliveryHGV>();
            //builder.Entity<FitterVan>();
            //builder.Entity<SalesCar>();

            foreach (var property in decimalProps)
            {
                property.SetPrecision(18);
                property.SetScale(2);
            }


            builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        }
        public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<AppUser>
        {
            public void Configure(EntityTypeBuilder<AppUser> builder)
            {
                builder.Property(u => u.FirstName).HasMaxLength(255);
                builder.Property(u => u.LastName).HasMaxLength(255);
            }
        }

    }
}
