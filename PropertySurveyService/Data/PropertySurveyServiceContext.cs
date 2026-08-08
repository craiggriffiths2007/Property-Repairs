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

        public DbSet<Job> Job { get; set; } = default!;
        public DbSet<Customer> Customer { get; set; } = default!;
        public DbSet<Contract> Contract { get; set; } = default!;
        public DbSet<ContractNote> ContractNotes { get; set; } = default!;
        public DbSet<Agent> Agent { get; set; } = default!;
        public DbSet<JobHeader> JobHeader { get; set; } = default!;
        public DbSet<GarageDoorMotor> GarageDoorMotor { get; set; } = default!;
        
        public DbSet<Aluminium> Aluminium { get; set; } = default!;
        public DbSet<Bifolding> Bifolding { get; set; } = default!;
        public DbSet<Composite> Composite { get; set; } = default!;
        public DbSet<Conservatory> Conservatory { get; set; } = default!;
        public DbSet<Garage> Garage { get; set; } = default!;
        public DbSet<Glass> Glass { get; set; } = default!;
        public DbSet<Greenhouse> Greenhouse { get; set; } = default!;
        public DbSet<Lockmech> Lockmech { get; set; } = default!;
        public DbSet<Panel> Panel { get; set; } = default!;
        public DbSet<Timber> Timber { get; set; } = default!;
        public DbSet<UPVC> UPVC { get; set; } = default!;
        public DbSet<Material> Frame { get; set; } = default!;
        public DbSet<PhotoImage> Images { get; set; } = default!;

        public DbSet<Branch> Branches { get; set; } = default!;
        public DbSet<Vehicle> Vehicles { get; set; } = default!;

        public DbSet<VehicleCheckHeader> VehicleCheckHeaders { get; set; } = default!;

        public DbSet<DeliveryVan> DeliveryVans { get; set; } = default!;
        public DbSet<DeliveryHGV> DeliveryHGVs { get; set; } = default!;
        public DbSet<FitterVan> FitterVans { get; set; } = default!;
        public DbSet<SalesCar> SalesCars { get; set; } = default!;
        public DbSet<VAccident> VAccidents { get; set; } = default!;
        public DbSet<Whitness> Whitnesses { get; set; } = default!;
        public DbSet<FAccident> FAccidents { get; set; } = default!;
        public DbSet<ToolCheck> ToolChecks { get; set; } = default!;
        public DbSet<MileageSheet> MileageSheets { get; set; } = default!;
        public DbSet<LadderCheck> LadderChecks { get; set; } = default!;
        public DbSet<SpotCheck> SpotChecks { get; set; } = default;
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

            builder.Entity<JobHeader>()
                    .HasOne(h => h.GarageDoorMotor)
                    .WithOne()
                    .HasForeignKey<GarageDoorMotor>(g => g.Id)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<GarageDoorMotor>()
                .Property(g => g.Id)
                .ValueGeneratedNever();


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
