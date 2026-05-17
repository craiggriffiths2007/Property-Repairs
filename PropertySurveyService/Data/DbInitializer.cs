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
            /*
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
            }*/
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
                new Customer{Name="Billy Bob",Add1="45 Low Road",Add2="",Add3="Salford",Postcode="SA11ER",Phone1="07376478888",Phone2="",Phone3=""},
                new Customer{Name="Sarah Williams",Add1="12 Oak Avenue",Add2="Prestwich",Add3="Manchester",Postcode="M251AB",Phone1="07400112233",Phone2="",Phone3=""},
                new Customer{Name="Emily Carter",Add1="78 Maple Street",Add2="",Add3="Liverpool",Postcode="L181XY",Phone1="07555444333",Phone2="",Phone3=""},
                new Customer{Name="Michael Brown",Add1="23 Pine Crescent",Add2="Heaton",Add3="Bolton",Postcode="BL23CD",Phone1="07788990011",Phone2="",Phone3=""},
                new Customer{Name="Jessica Smith",Add1="9 Willow Lane",Add2="",Add3="Stockport",Postcode="SK41ZZ",Phone1="07333334444",Phone2="",Phone3=""},
                new Customer{Name="David Johnson",Add1="34 Cedar Road",Add2="Eccles",Add3="Manchester",Postcode="M309GH",Phone1="07987654321",Phone2="",Phone3=""},
                new Customer{Name="Linda Green",Add1="67 Birch Close",Add2="",Add3="Wigan",Postcode="WN12EF",Phone1="07812345678",Phone2="",Phone3=""},
                new Customer{Name="Robert White",Add1="88 Elm Drive",Add2="Swinton",Add3="Salford",Postcode="M275JK",Phone1="07654321987",Phone2="",Phone3=""}
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
                new Branch{ Code = "LIVR",  Name = "Liverpool", Description = "Liverpool Branch" },
                new Branch{ Code = "LEED",  Name = "Leeds", Description = "Leeds Branch" },
                new Branch{ Code = "MNCH",  Name = "Manchester", Description = "Manchester Branch" },
                new Branch{ Code = "LOND",  Name = "London", Description = "London Branch" },
                new Branch{ Code = "BIRM",  Name = "Birmingham", Description = "Birmingham Branch" },
                new Branch{ Code = "CARD",  Name = "Cardiff", Description = "Cardiff Branch" },
                new Branch{ Code = "EDIN",  Name = "Edinburgh", Description = "Edinburgh Branch" }
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
                 new Vehicle{ Type = enum_vehicle_type.sales_car, BranchId = branches[2].Id, Name = "City Runner", Registration="GLA 123", Description="Ford Focus" },
                 new Vehicle{ Type = enum_vehicle_type.sales_car, BranchId = branches[3].Id, Name = "Mersey Cruiser", Registration="LIV 456", Description="Vauxhall Astra" },
                 new Vehicle{ Type = enum_vehicle_type.delivery_hgv, BranchId = branches[4].Id, Name = "Yorkshire Hauler", Registration="LEE 789", Description="Scania R Series" },
                 new Vehicle{ Type = enum_vehicle_type.delivery_van, BranchId = branches[5].Id, Name = "Northern Express", Registration="MAN 321", Description="Peugeot Boxer" },
                 new Vehicle{ Type = enum_vehicle_type.fitter_van, BranchId = branches[6].Id, Name = "London Fitter", Registration="LON 654", Description="Citroën Relay" },
                 new Vehicle{ Type = enum_vehicle_type.fitter_van, BranchId = branches[7].Id, Name = "Brum Fitter", Registration="BIR 987", Description="Ford Transit" },
                 new Vehicle{ Type = enum_vehicle_type.delivery_hgv, BranchId = branches[8].Id, Name = "Welsh Dragon", Registration="CAR 246", Description="DAF XF" },
                 new Vehicle{ Type = enum_vehicle_type.sales_car, BranchId = branches[9].Id, Name = "Edinburgh Flyer", Registration="EDI 135", Description="Toyota Corolla" },
                 new Vehicle{ Type = enum_vehicle_type.delivery_van, BranchId = branches[2].Id, Name = "Glasgow Van", Registration="GLA 246", Description="Mercedes Vito" },
                 new Vehicle{ Type = enum_vehicle_type.fitter_van, BranchId = branches[3].Id, Name = "Liverpool Fitter", Registration="LIV 357", Description="Volkswagen Crafter" },
            };
            foreach (Vehicle c in vehicles)
            {
                context.Add(c);
            }
            
            var contracts = new Contract[]
            {
                new Contract{ ContractCode="00000321" , CustomerId= customers[0].Id, DamageDescription ="Vehicle damage to upstairs window", IncidentAdded = DateTime.Now },
                new Contract{ ContractCode="00000505" , CustomerId= customers[1].Id, DamageDescription ="Gas explosion next door", IncidentAdded = DateTime.Now.AddMonths(-1) },
                new Contract{ ContractCode="00000678" , CustomerId= customers[2].Id, DamageDescription ="Fire damage to garage", IncidentAdded = DateTime.Now.AddMonths(-2) },
                new Contract{ ContractCode="00000890" , CustomerId= customers[3].Id, DamageDescription ="Water damage to kitchen", IncidentAdded = DateTime.Now.AddMonths(-3) },
                new Contract{ ContractCode="00000987" , CustomerId= customers[4].Id, DamageDescription ="Storm damage to roof", IncidentAdded = DateTime.Now.AddMonths(-4) },
                new Contract{ ContractCode="00001012" , CustomerId= customers[5].Id, DamageDescription ="Flooded basement", IncidentAdded = DateTime.Now.AddMonths(-5) },
                new Contract{ ContractCode="00001123" , CustomerId= customers[6].Id, DamageDescription ="Broken front door", IncidentAdded = DateTime.Now.AddMonths(-6) },
                new Contract{ ContractCode="00001234" , CustomerId= customers[7].Id, DamageDescription ="Subsidence in living room", IncidentAdded = DateTime.Now.AddMonths(-7) },
                new Contract{ ContractCode="00001345" , CustomerId= customers[8].Id, DamageDescription ="Vandalism to garden fence", IncidentAdded = DateTime.Now.AddMonths(-8) },
                new Contract{ ContractCode="00001456" , CustomerId= customers[9].Id, DamageDescription ="Electrical fire in attic", IncidentAdded = DateTime.Now.AddMonths(-9) },
                new Contract{ ContractCode="00001567" , CustomerId= customers[0].Id, DamageDescription ="Leaking roof", IncidentAdded = DateTime.Now.AddMonths(-10) },
                new Contract{ ContractCode="00001678" , CustomerId= customers[1].Id, DamageDescription ="Collapsed ceiling", IncidentAdded = DateTime.Now.AddMonths(-11) },
                new Contract{ ContractCode="00001789" , CustomerId= customers[2].Id, DamageDescription ="Burst water pipe", IncidentAdded = DateTime.Now.AddMonths(-12) },
                new Contract{ ContractCode="00001890" , CustomerId= customers[3].Id, DamageDescription ="Mold in bathroom", IncidentAdded = DateTime.Now.AddMonths(-13) },
                new Contract{ ContractCode="00001901" , CustomerId= customers[4].Id, DamageDescription ="Damaged driveway", IncidentAdded = DateTime.Now.AddMonths(-14) },
            };
            foreach (Contract c in contracts)
            {
                context.Add(c);
            }

            var agents = new Agent[]
            {
                new Agent{Name="James Dean", Code="H1",Type=agent_type.Surveyor },
                new Agent{Name="Steven Smith", Code="H2",Type=agent_type.Surveyor },
                new Agent{Name="Paul Moore", Code="H01",Type=agent_type.Fitter },
                new Agent{Name="Andy Mason", Code="H02",Type=agent_type.Fitter },
                new Agent{Name="Alex Polowski", Code="HH08",Type=agent_type.Satellite },
                new Agent{Name="Samantha Carter", Code="H03",Type=agent_type.Surveyor },
                new Agent{Name="Rachel Green", Code="H04",Type=agent_type.Surveyor },
                new Agent{Name="Tommy Lee", Code="H05",Type=agent_type.Fitter },
                new Agent{Name="Linda Evans", Code="H06",Type=agent_type.Fitter },
                new Agent{Name="Chris Johnson", Code="HH09",Type=agent_type.Satellite },
                new Agent{Name="Patricia Brown", Code="HH10",Type=agent_type.Satellite },
                new Agent{Name="Michael Scott", Code="H07",Type=agent_type.Surveyor },
                new Agent{Name="Angela Martin", Code="H08",Type=agent_type.Fitter },
                new Agent{Name="Oscar Martinez", Code="H09",Type=agent_type.Fitter },
                new Agent{Name="Kevin Malone", Code="HH11",Type=agent_type.Satellite }
            };
            foreach (Agent s in agents)
            {
                context.Add(s);
            }
            
            context.SaveChanges();

        }
    }
}
