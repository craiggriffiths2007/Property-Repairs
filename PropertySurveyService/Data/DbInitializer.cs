  using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Models;
using System;
using System.Data;
using System.Linq;

namespace PropertySurveyService.Data
{
    public enum Roles
    {
        SuperAdmin,
        Admin,
        Moderator,
        Basic
    }
    public static class DbInitializer
    {
        public static async Task SeedRolesAsync(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Roles.SuperAdmin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Moderator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Basic.ToString()));
        }

        public static async Task SeedSuperAdminAsync(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {

            // Seed Craig Griffiths user
            var craigUser = new AppUser
            {
                UserName = "Superadmin",
                Email = "craig.griffiths2077@gmail.com",
                FirstName = "Super",
                LastName = "Admin",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            var craig = await userManager.FindByEmailAsync(craigUser.Email);
            if (craig == null)
            {
                var result = await userManager.CreateAsync(craigUser, "pass1+");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(craigUser, Roles.Basic.ToString());
                    await userManager.AddToRoleAsync(craigUser, Roles.Moderator.ToString());
                    await userManager.AddToRoleAsync(craigUser, Roles.Admin.ToString());
                    await userManager.AddToRoleAsync(craigUser, Roles.SuperAdmin.ToString());
                }
            }

            // Elevate all existing users to SuperAdmin (and all roles)
            var allUsers = userManager.Users.ToList();
            foreach (var u in allUsers)
            {
                foreach (var role in Enum.GetValues<Roles>())
                {
                    if (!await userManager.IsInRoleAsync(u, role.ToString()))
                    {
                        await userManager.AddToRoleAsync(u, role.ToString());
                    }
                }
            }
        }
        public static void Initialize(AppDBContext context)
        {
            context.Database.EnsureCreated();

            if (context.Customer.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
                new Customer{Name="Craig Griffiths",Add1="56 Sunny Road",Add2="Bolton",Add3="Lancashire",Postcode="BL14NN",Phone1="07376559088",Phone2="",Phone3=""},
                new Customer{Name="Jeffey Jones",Add1="100 Grass Road",Add2="",Add3="Leeds",Postcode="LE11ER",Phone1="07376475632",Phone2="",Phone3=""},

            };
            foreach (Customer c in customers)
            {
                context.Add(c);
            }

            var branches = new Branch[]
            {
                new Branch{ Code = "BOLT",  Name = "Bolton", Description = "Bolton Branch" },
                new Branch{ Code = "GLOU",  Name = "Gloucester", Description = "Gloucester Branch" },
                new Branch{ Code = "GLAS",  Name = "Glasgow", Description = "Glasgow Branch" },
            };
            foreach (Branch c in branches)
            {
                context.Add(c);
            }
            context.SaveChanges();


            var vehicles = new Vehicle[]
            {
                 new Vehicle{ Type = enum_vehicle_type.delivery_hgv, BranchId = branches[0].Id, Name = "Scotland", Registration="DAV 1D", Description="Volvo FH/FH16" },
                 new Vehicle{ Type = enum_vehicle_type.delivery_hgv, BranchId = branches[1].Id, Name = "Eastern", Registration="BUT 70N", Description="Mercedes-Benz Actros" },

                 new Vehicle{ Type = enum_vehicle_type.delivery_van, BranchId = branches[0].Id, Name = "North Western", Registration="PAM 314S", Description="Luton Box Van" },
                 new Vehicle{ Type = enum_vehicle_type.delivery_van, BranchId = branches[1].Id, Name = "Wales", Registration="EFD 678", Description="Luton Box Van" },

                 new Vehicle{ Type = enum_vehicle_type.fitter_van, BranchId = branches[0].Id, Name = "Fit1", Registration="R2 YAN", Description="Renault Master" },
                 new Vehicle{ Type = enum_vehicle_type.fitter_van, BranchId = branches[0].Id, Name = "Fit2", Registration="K4 MES", Description="Fiat Ducato" },
                 new Vehicle{ Type = enum_vehicle_type.fitter_van, BranchId = branches[1].Id, Name = "Fit3", Registration="B26 OMB", Description="Nissan Interstar" },
                 new Vehicle{ Type = enum_vehicle_type.fitter_van, BranchId = branches[1].Id, Name = "Fit4", Registration="P902 HLM", Description="Mercedes Sprinter" },

                 new Vehicle{ Type = enum_vehicle_type.sales_car, BranchId = branches[0].Id, Name = "Racer", Registration="F412 TSW", Description="Mazda MX-5 (ND)" },
                 new Vehicle{ Type = enum_vehicle_type.sales_car, BranchId = branches[1].Id, Name = "Double Glazing", Registration="1 CDW", Description="VW Golf GTI" },
            };
            foreach (Vehicle c in vehicles)
            {
                context.Add(c);
            }
            
            var contracts = new Contract[]
            {
                new Contract{ ContractCode="00000321" , CustomerId= customers[0].Id, DamageDescription ="Vehicle damage to upstairs window", IncidentAdded = DateTime.Now },
                new Contract{ ContractCode="00000505" , CustomerId= customers[1].Id, DamageDescription ="Gas explosion next door", IncidentAdded = DateTime.Now.AddMonths(-1) },

            };
            foreach (Contract c in contracts)
            {
                context.Add(c);
            }

            var agents = new Agent[]
            {
                new Agent{Name="James Dean", Code="H1",Type=agent_type.surveyor },
                new Agent{Name="Steven Smith", Code="H2",Type=agent_type.surveyor },
                new Agent{Name="Paul Moore", Code="H01",Type=agent_type.fitter },
                new Agent{Name="Andy Mason", Code="H02",Type=agent_type.fitter },
                new Agent{Name="Alex Polowski", Code="HH08",Type=agent_type.satellite },
            };
            foreach (Agent s in agents)
            {
                context.Add(s);
            }
            
            context.SaveChanges();

        }
    }
}
