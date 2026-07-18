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
        Basic,
        Contract,
        Branch,
        Vehicle,
        Staff
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
            await roleManager.CreateAsync(new IdentityRole(Roles.Contract.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Branch.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Vehicle.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Staff .ToString()));
        }

        public static async Task SeedSuperAdminAsync(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var imagePath = Path.Combine(Directory.GetCurrentDirectory(),
                                    "wwwroot", "img", "house.jpg");

            var imageBytes = await File.ReadAllBytesAsync(imagePath);

            // Seed Craig Griffiths user
            var craigUser = new AppUser
            {
                UserName = "Superadmin",
                Email = "craig.griffiths2077@gmail.com",
                FirstName = "Super",
                LastName = "Admin",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                ProfilePicture = imageBytes

            };
            var result = await userManager.CreateAsync(craigUser, "pass1+");
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(craigUser, Roles.Basic.ToString());
                await userManager.AddToRoleAsync(craigUser, Roles.Moderator.ToString());
                await userManager.AddToRoleAsync(craigUser, Roles.Admin.ToString());
                await userManager.AddToRoleAsync(craigUser, Roles.SuperAdmin.ToString());
            }
        }
        /*
        var craig = await userManager.FindByEmailAsync(craigUser.Email);
            if (craig == null)
            {
          */      
        //}
        public static void Initialize(AppDBContext context)
        {
            context.Database.EnsureCreated();

            if (context.Customer.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
                new Customer{Name="Craig Griffiths",Add1="56 Sunny Road",Add2="Bolton",Add3="Lancashire",Postcode="BL14NN",Phone1="077777777777",Phone2="",Phone3=""},
                new Customer{Name="Jeffey Jones",Add1="100 Grass Road",Add2="",Add3="Leeds",Postcode="LE11ER",Phone1="077777777777",Phone2="",Phone3=""},
                new Customer{Name="Billy Bob",Add1="45 Low Road",Add2="",Add3="Salford",Postcode="SA11ER",Phone1="077777777777",Phone2="",Phone3=""},
                new Customer{Name="Sarah Williams",Add1="12 Oak Avenue",Add2="Prestwich",Add3="Manchester",Postcode="M251AB",Phone1="077777777777",Phone2="",Phone3=""},
                new Customer{Name="Emily Carter",Add1="78 Maple Street",Add2="",Add3="Liverpool",Postcode="L181XY",Phone1="077777777777",Phone2="",Phone3=""},
                new Customer{Name="Michael Brown",Add1="23 Pine Crescent",Add2="Heaton",Add3="Bolton",Postcode="BL23CD",Phone1="077777777777",Phone2="",Phone3=""},
                new Customer{Name="Jessica Smith",Add1="9 Willow Lane",Add2="",Add3="Stockport",Postcode="SK41ZZ",Phone1="077777777777",Phone2="",Phone3=""},
                new Customer{Name="David Johnson",Add1="34 Cedar Road",Add2="Eccles",Add3="Manchester",Postcode="M309GH",Phone1="077777777777",Phone2="",Phone3=""},
                new Customer{Name="Linda Green",Add1="67 Birch Close",Add2="",Add3="Wigan",Postcode="WN12EF",Phone1="077777777777",Phone2="",Phone3=""},
                new Customer{Name="Robert White",Add1="88 Elm Drive",Add2="Swinton",Add3="Salford",Postcode="M275JK",Phone1="077777777777",Phone2="",Phone3=""},
                new Customer{Name="Oliver Taylor",Add1="14 Ash Grove",Add2="",Add3="Manchester",Postcode="M145PZ",Phone1="07123456789",Phone2="",Phone3=""},
                new Customer{Name="George Davies",Add1="32 High Street",Add2="Bury",Add3="Lancashire",Postcode="BL90EX",Phone1="07234567890",Phone2="01615550123",Phone3=""},
                new Customer{Name="Harry Evans",Add1="89 London Road",Add2="",Add3="Liverpool",Postcode="L35QA",Phone1="07345678901",Phone2="",Phone3=""},
                new Customer{Name="Noah Thomas",Add1="7 Church Lane",Add2="Altrincham",Add3="Cheshire",Postcode="WA141AA",Phone1="07456789012",Phone2="",Phone3=""},
                new Customer{Name="Jack Roberts",Add1="54 Park Avenue",Add2="",Add3="Leeds",Postcode="LS27EE",Phone1="07567890123",Phone2="",Phone3=""},
                new Customer{Name="Leo Wilson",Add1="112 Mill Lane",Add2="Rochdale",Add3="Greater Manchester",Postcode="OL161XN",Phone1="07678901234",Phone2="",Phone3=""},
                new Customer{Name="Arthur Lewis",Add1="3A Queen Street",Add2="",Add3="Chester",Postcode="CH12BA",Phone1="07789012345",Phone2="",Phone3=""},
                new Customer{Name="Oscar Robinson",Add1="65 Station Road",Add2="Farnworth",Add3="Bolton",Postcode="BL47NQ",Phone1="07890123456",Phone2="",Phone3=""},
                new Customer{Name="Charlie Walker",Add1="21 Victoria Road",Add2="",Add3="Salford",Postcode="M54WT",Phone1="07901234567",Phone2="",Phone3=""},
                new Customer{Name="Amelia Wood",Add1="77 New Road",Add2="Chorley",Add3="Lancashire",Postcode="PR71JU",Phone1="07912345678",Phone2="01257555019",Phone3=""},
                new Customer{Name="Olivia Thompson",Add1="42 Kings Road",Add2="",Add3="Sheffield",Postcode="S12GU",Phone1="07923456789",Phone2="",Phone3=""},
                new Customer{Name="Isla Hall",Add1="19 Grange Road",Add2="Stretford",Add3="Manchester",Postcode="M328RE",Phone1="07934567890",Phone2="",Phone3=""},
                new Customer{Name="Ava Green",Add1="8 The Drive",Add2="",Add3="Warrington",Postcode="WA42BB",Phone1="07945678901",Phone2="",Phone3=""},
                new Customer{Name="Mia Hughes",Add1="91 Stanley Road",Add2="Bootle",Add3="Liverpool",Postcode="L207AA",Phone1="07956789012",Phone2="",Phone3=""},
                new Customer{Name="Isabella Edwards",Add1="15 Richmond Close",Add2="",Add3="Blackburn",Postcode="BB24DH",Phone1="07967890123",Phone2="",Phone3=""},
                new Customer{Name="Sophia Harrison",Add1="60 Windermere Road",Add2="",Add3="Kendall",Postcode="LA95HG",Phone1="07978901234",Phone2="",Phone3=""},
                new Customer{Name="Grace Turner",Add1="28 Croft Lane",Add2="Horwich",Add3="Bolton",Postcode="BL66LL",Phone1="07989012345",Phone2="",Phone3=""},
                new Customer{Name="Lily Martin",Add1="44 Broadway",Add2="",Add3="Oldham",Postcode="OL90EL",Phone1="07990123456",Phone2="",Phone3=""},
                new Customer{Name="Freya Cooper",Add1="10 Market Street",Add2="Worsley",Add3="Manchester",Postcode="M282GU",Phone1="07111222333",Phone2="",Phone3=""},
                new Customer{Name="Thomas Cooper",Add1="5 Daisy Bank",Add2="",Add3="Halifax",Postcode="HX12BB",Phone1="07222333444",Phone2="",Phone3=""},
                new Customer{Name="James Ward",Add1="88 Foxglove Way",Add2="Westhoughton",Add3="Bolton",Postcode="BL53UU",Phone1="07333444555",Phone2="01942555111",Phone3="07333444556"},
                new Customer{Name="Charles Palmer",Add1="17 Manor Gardens",Add2="",Add3="Preston",Postcode="PR14AA",Phone1="07444555666",Phone2="",Phone3=""},
                new Customer{Name="William Holmes",Add1="62 Bridge Street",Add2="",Add3="Stockport",Postcode="SK11XR",Phone1="07555666777",Phone2="",Phone3=""},
                new Customer{Name="Lucas Rogers",Add1="31 Cross Lane",Add2="Radcliffe",Add3="Manchester",Postcode="M262RT",Phone1="07666777888",Phone2="",Phone3=""},
                new Customer{Name="Henry Matthews",Add1="94 York Road",Add2="",Add3="Leeds",Postcode="LS98LL",Phone1="07777888999",Phone2="",Phone3=""},
                new Customer{Name="Alexander Morgan",Add1="22 Boundary Road",Add2="St Helens",Add3="Merseyside",Postcode="WA102PP",Phone1="07888999000",Phone2="",Phone3=""},
                new Customer{Name="Edward Barker",Add1="50 Moor Lane",Add2="",Add3="Clitheroe",Postcode="BB71BA",Phone1="07999000111",Phone2="",Phone3=""},
                new Customer{Name="Jacob Cook",Add1="11 Albert Road",Add2="Levenshulme",Add3="Manchester",Postcode="M193PJ",Phone1="07123123123",Phone2="",Phone3=""},
                new Customer{Name="Louis Bailey",Add1="76 Chapel Street",Add2="",Add3="Chorley",Postcode="PR60AA",Phone1="07234234234",Phone2="",Phone3=""},
                new Customer{Name="Daniel Bell",Add1="8 Oakfield Drive",Add2="Little Lever",Add3="Bolton",Postcode="BL31EE",Phone1="07345345345",Phone2="",Phone3=""},
                new Customer{Name="Emily Cox",Add1="49 Spring Gardens",Add2="",Add3="Buxton",Postcode="SK176EE",Phone1="07456456456",Phone2="",Phone3=""},
                new Customer{Name="Charlotte Gray",Add1="103 School Lane",Add2="Didsbury",Add3="Manchester",Postcode="M206RE",Phone1="07567567567",Phone2="",Phone3=""},
                new Customer{Name="Hannah Rose",Add1="27 Bluebell Close",Add2="",Add3="Warrington",Postcode="WA20UU",Phone1="07678678678",Phone2="",Phone3=""},
                new Customer{Name="Florence Adam",Add1="90 Meadow View",Add2="",Add3="Blackpool",Postcode="FY15RR",Phone1="07789789789",Phone2="",Phone3=""},
                new Customer{Name="Daisy Webb",Add1="14 Holly Lane",Add2="Tyldesley",Add3="Manchester",Postcode="M298AA",Phone1="07890890890",Phone2="",Phone3=""},
                new Customer{Name="Phoebe West",Add1="66 Hillside Crescent",Add2="",Add3="Blackburn",Postcode="BB19NN",Phone1="07901901901",Phone2="",Phone3=""},
                new Customer{Name="Sienna Hunt",Add1="53 Park Road",Add2="Halliwell",Add3="Bolton",Postcode="BL13XX",Phone1="07112233445",Phone2="",Phone3=""},
                new Customer{Name="Alice Fisher",Add1="38 Copperfield Road",Add2="",Add3="Liverpool",Postcode="L84TT",Phone1="07223344556",Phone2="",Phone3=""},
                new Customer{Name="Ivy Preston",Add1="124 Smithy Lane",Add2="",Add3="Ormskirk",Postcode="L391AA",Phone1="07334455667",Phone2="",Phone3=""},
                new Customer{Name="Harper Murray",Add1="18 Well Street",Add2="Heywood",Add3="Lancashire",Postcode="OL104PP",Phone1="07445566778",Phone2="",Phone3=""},
                new Customer{Name="Isabel Jenkins",Add1="71 View Road",Add2="",Add3="Burnley",Postcode="BB113EE",Phone1="07556677889",Phone2="",Phone3=""},
                new Customer{Name="Josephine May",Add1="29 Highfield Drive",Add2="",Add3="Ashton-under-Lyne",Postcode="OL69LL",Phone1="07667788990",Phone2="",Phone3=""},
                new Customer{Name="Evelyn Grant",Add1="83 Low Meadows",Add2="Harwood",Add3="Bolton",Postcode="BL24JJ",Phone1="07778899001",Phone2="01204555987",Phone3=""},
                new Customer{Name="Lucy Jordan",Add1="41 Woodlands Way",Add2="",Add3="Macclesfield",Postcode="SK102QQ",Phone1="07889900112",Phone2="",Phone3=""},
                new Customer{Name="Sofia Perry",Add1="5 The Orchard",Add2="Sale",Add3="Manchester",Postcode="M334YY",Phone1="07990011223",Phone2="",Phone3=""},
                new Customer{Name="Ruby Butler",Add1="92 River Wood",Add2="",Add3="Lancaster",Postcode="LA13ZZ",Phone1="07111122223",Phone2="",Phone3=""},
                new Customer{Name="Elijah Ross",Add1="63 Valley View",Add2="",Add3="Rotherham",Postcode="S604AA",Phone1="07222233334",Phone2="",Phone3=""},
                new Customer{Name="Benjamin Long",Add1="10a Market Place",Add2="Leigh",Add3="Lancashire",Postcode="WN74BB",Phone1="07333344445",Phone2="",Phone3=""},
                new Customer{Name="Samuel Foster",Add1="74 Heather Bank",Add2="",Add3="Bradford",Postcode="BD15LL",Phone1="07444455556",Phone2="",Phone3=""},
                new Customer{Name="Mason Reynolds",Add1="151 Chester Road",Add2="Stretford",Add3="Manchester",Postcode="M320PA",Phone1="07555566667",Phone2="",Phone3=""}
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

            List<string> cod_list = new List<string>() { "Accidental Damage", "Bad Workmanship", "Claim inconsistency", "Domestic", "Fire", "Flood",
                                                        "Ground Movement", "Impact", "Loss of keys", "Malicious", "Storm Damage", "Theft", "Wear + Tear" };

            // Insurance company names to pick from randomly
            var insurers = new List<string>
            {
                "Acme Insurance Co.",
                "NorthStar Underwriters",
                "Guardian Mutual",
                "Pioneer Assurance",
                "Evergreen Insurance",
                "HarborView Insurers",
                "Summit Risk Ltd.",
                "Silverline Insurance",
                "Crown Protect",
                "Atlas Insurance Group"
            };

            var rnd = new Random();

            // Supplemental descriptions matched up to specific cod_list indexes for realism
            var descriptionsByCod = new Dictionary<int, string[]>
            {
                { 0, new[] { "Spilled paint on carpet", "Dropped TV during move", "Heater cracked tiled floor" } },
                { 1, new[] { "Leaking pipe behind new plaster", "Extension wall cracking", "Incorrectly wired fuse box" } },
                { 2, new[] { "Disputed kitchen fire damage", "Discrepancy in water leak source", "Conflicting roof assessment" } },
                { 3, new[] { "Internal plumbing burst", "Radiator leak in hallway", "Bathroom ceiling collapse" } },
                { 4, new[] { "Smoke damage in kitchen", "Electrical fire in loft", "Outbuilding completely burned" } },
                { 5, new[] { "River bank burst into garden", "Sewer backup in cellar", "Surface water flooded porch" } },
                { 6, new[] { "Subsidence in conservatory", "Cracked driveway from tree roots", "Leaning perimeter wall" } },
                { 7, new[] { "Delivery van hit brick pillar", "Fallen branch on greenhouse", "Bird flew into conservatory pane" } },
                { 8, new[] { "Lock snapped on patio doors", "Keys lost down drain", "Replaced front door barrels" } },
                { 9, new[] { "Vandalism to garden fence", "Graffiti on side brickwork", "Smashed security camera" } },
                { 10, new[] { "Tiles blown off main roof", "Fence destroyed by gales", "Guttering ripped down" } },
                { 11, new[] { "Stolen lead from roof", "Burglary via rear window", "Shed broken into overnight" } },
                { 12, new[] { "Corroded copper pipes", "Rotten wooden window frames", "Crumbled chimney pointing" } }
            };

            var excessAmounts = new[] { "50", "100", "150", "200", "250" };

            var contracts = new Contract[]
            {
                new Contract{ ContractCode="00000321" , CustomerId= customers[0].Id, DamageDescription ="Vehicle damage to upstairs window", IncidentDate = DateTime.Now, CauseOfDamage = cod_list[0], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "50", PolicyNumber="DFSO4356" } ,
                new Contract{ ContractCode="00000505" , CustomerId= customers[1].Id, DamageDescription ="Gas explosion next door", IncidentDate = DateTime.Now.AddMonths(-1), CauseOfDamage = cod_list[1], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "150", PolicyNumber="DFSO4356"  },
                new Contract{ ContractCode="00000678" , CustomerId= customers[2].Id, DamageDescription ="Fire damage to garage", IncidentDate = DateTime.Now.AddMonths(-2), CauseOfDamage = cod_list[2], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "50", PolicyNumber="DFSO4356"  },
                new Contract{ ContractCode="00000890" , CustomerId= customers[3].Id, DamageDescription ="Water damage to kitchen", IncidentDate = DateTime.Now.AddMonths(-3), CauseOfDamage = cod_list[3], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "250", PolicyNumber="DFSO4356"  },
                new Contract{ ContractCode="00000987" , CustomerId= customers[4].Id, DamageDescription ="Storm damage to roof", IncidentDate = DateTime.Now.AddMonths(-4), CauseOfDamage = cod_list[4], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "150", PolicyNumber="DFSO4356"  },
                new Contract{ ContractCode="00001012" , CustomerId= customers[5].Id, DamageDescription ="Flooded basement", IncidentDate = DateTime.Now.AddMonths(-5), CauseOfDamage = cod_list[5], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "250", PolicyNumber="DFSO4356"  },
                new Contract{ ContractCode="00001123" , CustomerId= customers[6].Id, DamageDescription ="Broken front door", IncidentDate = DateTime.Now.AddMonths(-6), CauseOfDamage = cod_list[6], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "100", PolicyNumber="DFSO4356"  },
                new Contract{ ContractCode="00001133" , CustomerId= customers[7].Id, DamageDescription ="Front window damaged", IncidentDate = DateTime.Now.AddMonths(-6), CauseOfDamage = cod_list[7], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "150", PolicyNumber="DFSO4356"  },
                new Contract{ ContractCode="00001223" , CustomerId= customers[8].Id, DamageDescription ="Glass Leading broken", IncidentDate = DateTime.Now.AddMonths(-6), CauseOfDamage = cod_list[8], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "50", PolicyNumber="DFSO4356"  },
                new Contract{ ContractCode="00001823" , CustomerId= customers[9].Id, DamageDescription ="Broken back window", IncidentDate = DateTime.Now.AddMonths(-6), CauseOfDamage = cod_list[9], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "150", PolicyNumber="DFSO4356"  },
                new Contract{ ContractCode="00001824" , CustomerId= customers[10].Id, DamageDescription ="Spilled paint on carpet", IncidentDate = DateTime.Now.AddDays(-12), CauseOfDamage = cod_list[0], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "50", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001825" , CustomerId= customers[11].Id, DamageDescription ="Extension wall cracking", IncidentDate = DateTime.Now.AddDays(-43), CauseOfDamage = cod_list[1], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "150", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001826" , CustomerId= customers[12].Id, DamageDescription ="Disputed kitchen fire damage", IncidentDate = DateTime.Now.AddDays(-5), CauseOfDamage = cod_list[2], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "250", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001827" , CustomerId= customers[13].Id, DamageDescription ="Internal plumbing burst", IncidentDate = DateTime.Now.AddDays(-19), CauseOfDamage = cod_list[3], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "100", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001828" , CustomerId= customers[14].Id, DamageDescription ="Smoke damage in kitchen", IncidentDate = DateTime.Now.AddDays(-88), CauseOfDamage = cod_list[4], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "200", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001829" , CustomerId= customers[15].Id, DamageDescription ="Sewer backup in cellar", IncidentDate = DateTime.Now.AddDays(-61), CauseOfDamage = cod_list[5], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "50", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001830" , CustomerId= customers[16].Id, DamageDescription ="Subsidence in conservatory", IncidentDate = DateTime.Now.AddDays(-2), CauseOfDamage = cod_list[6], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "250", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001831" , CustomerId= customers[17].Id, DamageDescription ="Delivery van hit brick pillar", IncidentDate = DateTime.Now.AddDays(-14), CauseOfDamage = cod_list[7], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "100", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001832" , CustomerId= customers[18].Id, DamageDescription ="Lock snapped on patio doors", IncidentDate = DateTime.Now.AddDays(-75), CauseOfDamage = cod_list[8], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "150", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001833" , CustomerId= customers[19].Id, DamageDescription ="Vandalism to garden fence", IncidentDate = DateTime.Now.AddDays(-32), CauseOfDamage = cod_list[9], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "50", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001834" , CustomerId= customers[20].Id, DamageDescription ="Tiles blown off main roof", IncidentDate = DateTime.Now.AddDays(-4), CauseOfDamage = cod_list[10], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "200", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001835" , CustomerId= customers[21].Id, DamageDescription ="Stolen lead from roof", IncidentDate = DateTime.Now.AddDays(-45), CauseOfDamage = cod_list[11], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "100", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001836" , CustomerId= customers[22].Id, DamageDescription ="Corroded copper pipes", IncidentDate = DateTime.Now.AddDays(-120), CauseOfDamage = cod_list[12], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "150", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001837" , CustomerId= customers[23].Id, DamageDescription ="Dropped TV during move", IncidentDate = DateTime.Now.AddDays(-60), CauseOfDamage = cod_list[0], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "50", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001838" , CustomerId= customers[24].Id, DamageDescription ="Leaking pipe behind new plaster", IncidentDate = DateTime.Now.AddDays(-9), CauseOfDamage = cod_list[1], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "250", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001839" , CustomerId= customers[25].Id, DamageDescription ="Discrepancy in water leak source", IncidentDate = DateTime.Now.AddDays(-15), CauseOfDamage = cod_list[2], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "150", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001840" , CustomerId= customers[26].Id, DamageDescription ="Radiator leak in hallway", IncidentDate = DateTime.Now.AddDays(-33), CauseOfDamage = cod_list[3], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "100", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001841" , CustomerId= customers[27].Id, DamageDescription ="Electrical fire in loft", IncidentDate = DateTime.Now.AddDays(-54), CauseOfDamage = cod_list[4], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "200", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001842" , CustomerId= customers[28].Id, DamageDescription ="River bank burst into garden", IncidentDate = DateTime.Now.AddDays(-72), CauseOfDamage = cod_list[5], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "250", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001843" , CustomerId= customers[29].Id, DamageDescription ="Cracked driveway from tree roots", IncidentDate = DateTime.Now.AddDays(-41), CauseOfDamage = cod_list[6], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "50", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001844" , CustomerId= customers[30].Id, DamageDescription ="Fallen branch on greenhouse", IncidentDate = DateTime.Now.AddDays(-23), CauseOfDamage = cod_list[7], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "100", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001845" , CustomerId= customers[31].Id, DamageDescription ="Keys lost down drain", IncidentDate = DateTime.Now.AddDays(-11), CauseOfDamage = cod_list[8], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "150", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001846" , CustomerId= customers[32].Id, DamageDescription ="Graffiti on side brickwork", IncidentDate = DateTime.Now.AddDays(-8), CauseOfDamage = cod_list[9], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "50", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001847" , CustomerId= customers[33].Id, DamageDescription ="Fence destroyed by gales", IncidentDate = DateTime.Now.AddDays(-90), CauseOfDamage = cod_list[10], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "200", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001848" , CustomerId= customers[34].Id, DamageDescription ="Burglary via rear window", IncidentDate = DateTime.Now.AddDays(-64), CauseOfDamage = cod_list[11], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "100", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001849" , CustomerId= customers[35].Id, DamageDescription ="Rotten wooden window frames", IncidentDate = DateTime.Now.AddDays(-110), CauseOfDamage = cod_list[12], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "150", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001850" , CustomerId= customers[36].Id, DamageDescription ="Heater cracked tiled floor", IncidentDate = DateTime.Now.AddDays(-17), CauseOfDamage = cod_list[0], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "250", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001851" , CustomerId= customers[37].Id, DamageDescription ="Incorrectly wired fuse box", IncidentDate = DateTime.Now.AddDays(-52), CauseOfDamage = cod_list[1], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "100", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001852" , CustomerId= customers[38].Id, DamageDescription ="Conflicting roof assessment", IncidentDate = DateTime.Now.AddDays(-36), CauseOfDamage = cod_list[2], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "150", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001853" , CustomerId= customers[39].Id, DamageDescription ="Bathroom ceiling collapse", IncidentDate = DateTime.Now.AddDays(-47), CauseOfDamage = cod_list[3], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "50", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001854" , CustomerId= customers[40].Id, DamageDescription ="Outbuilding completely burned", IncidentDate = DateTime.Now.AddDays(-99), CauseOfDamage = cod_list[4], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "200", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001855" , CustomerId= customers[41].Id, DamageDescription ="Surface water flooded porch", IncidentDate = DateTime.Now.AddDays(-13), CauseOfDamage = cod_list[5], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "250", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001856" , CustomerId= customers[42].Id, DamageDescription ="Leaning perimeter wall", IncidentDate = DateTime.Now.AddDays(-81), CauseOfDamage = cod_list[6], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "100", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001857" , CustomerId= customers[43].Id, DamageDescription ="Bird flew into conservatory pane", IncidentDate = DateTime.Now.AddDays(-22), CauseOfDamage = cod_list[7], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "50", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001858" , CustomerId= customers[44].Id, DamageDescription ="Replaced front door barrels", IncidentDate = DateTime.Now.AddDays(-30), CauseOfDamage = cod_list[8], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "150", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001859" , CustomerId= customers[45].Id, DamageDescription ="Smashed security camera", IncidentDate = DateTime.Now.AddDays(-6), CauseOfDamage = cod_list[9], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "100", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001860" , CustomerId= customers[46].Id, DamageDescription ="Guttering ripped down", IncidentDate = DateTime.Now.AddDays(-18), CauseOfDamage = cod_list[10], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "200", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001861" , CustomerId= customers[47].Id, DamageDescription ="Shed broken into overnight", IncidentDate = DateTime.Now.AddDays(-44), CauseOfDamage = cod_list[11], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "50", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001862" , CustomerId= customers[48].Id, DamageDescription ="Crumbled chimney pointing", IncidentDate = DateTime.Now.AddDays(-135), CauseOfDamage = cod_list[12], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "150", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001863" , CustomerId= customers[49].Id, DamageDescription ="Spilled paint on carpet", IncidentDate = DateTime.Now.AddDays(-26), CauseOfDamage = cod_list[0], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "100", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001864" , CustomerId= customers[50].Id, DamageDescription ="Extension wall cracking", IncidentDate = DateTime.Now.AddDays(-55), CauseOfDamage = cod_list[1], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "250", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001865" , CustomerId= customers[51].Id, DamageDescription ="Disputed kitchen fire damage", IncidentDate = DateTime.Now.AddDays(-62), CauseOfDamage = cod_list[2], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "150", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001866" , CustomerId= customers[52].Id, DamageDescription ="Internal plumbing burst", IncidentDate = DateTime.Now.AddDays(-14), CauseOfDamage = cod_list[3], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "50", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001867" , CustomerId= customers[53].Id, DamageDescription ="Smoke damage in kitchen", IncidentDate = DateTime.Now.AddDays(-77), CauseOfDamage = cod_list[4], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "200", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001868" , CustomerId= customers[54].Id, DamageDescription ="Sewer backup in cellar", IncidentDate = DateTime.Now.AddDays(-49), CauseOfDamage = cod_list[5], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "250", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001869" , CustomerId= customers[55].Id, DamageDescription ="Subsidence in conservatory", IncidentDate = DateTime.Now.AddDays(-34), CauseOfDamage = cod_list[6], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "100", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001870" , CustomerId= customers[56].Id, DamageDescription ="Delivery van hit brick pillar", IncidentDate = DateTime.Now.AddDays(-21), CauseOfDamage = cod_list[7], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "50", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001871" , CustomerId= customers[57].Id, DamageDescription ="Lock snapped on patio doors", IncidentDate = DateTime.Now.AddDays(-11), CauseOfDamage = cod_list[8], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "150", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001872" , CustomerId= customers[58].Id, DamageDescription ="Vandalism to garden fence", IncidentDate = DateTime.Now.AddDays(-40), CauseOfDamage = cod_list[9], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "100", PolicyNumber="POL" + rnd.Next(10000, 99999) },
                new Contract{ ContractCode="00001873" , CustomerId= customers[59].Id, DamageDescription ="Tiles blown off main roof", IncidentDate = DateTime.Now.AddDays(-69), CauseOfDamage = cod_list[10], InsuranceCompanyName = insurers[rnd.Next(insurers.Count)], Excess = "200", PolicyNumber="POL" + rnd.Next(10000, 99999) }
            };
            foreach (Contract c in contracts)
            {
                context.Add(c);
            }

            var agents = new Agent[]
            {
                new Agent{Name="Alex Polowski", Password="password1",Code="H1",Type=agent_type.Surveyor },
                new Agent{Name="Samantha Carter", Password="password2", Code="H2",Type=agent_type.Surveyor },
                new Agent{Name="Rachel Green", Password="password3", Code="H3",Type=agent_type.Surveyor },
                new Agent{Name="Tommy Lee", Password="password1", Code="H05",Type=agent_type.Satellite },
                new Agent{Name="Linda Evans", Password="password5", Code="H06",Type=agent_type.Fitter },
                new Agent{Name="Chris Johnson", Password="password6", Code="HH09",Type=agent_type.Fitter },
                new Agent{Name="Patricia Brown", Password="password7", Code="HH10",Type=agent_type.Satellite },
                new Agent{Name="Michael Scott", Password="password8", Code="H07",Type=agent_type.Surveyor },
                new Agent{Name="Angela Martin", Password="password9", Code="H08",Type=agent_type.Satellite },
                new Agent{Name="Oscar Martinez", Password="password10", Code="H09",Type=agent_type.Fitter },
                new Agent{Name="Kevin Malone", Password="password11", Code="HH11",Type=agent_type.Satellite },
                new Agent{Name="Jim Halpert", Password="password12", Code="H10", Type=agent_type.Surveyor },
                new Agent{Name="Pam Beesly", Password="password13", Code="H11", Type=agent_type.Satellite },
                new Agent{Name="Dwight Schrute", Password="password14", Code="H12", Type=agent_type.Fitter },
                new Agent{Name="Ryan Howard", Password="password15", Code="HH12", Type=agent_type.Satellite },
                new Agent{Name="Kelly Kapoor", Password="password16", Code="HH13", Type=agent_type.Fitter },
                new Agent{Name="Toby Flenderson", Password="password17", Code="H13", Type=agent_type.Surveyor },
                new Agent{Name="Stanley Hudson", Password="password18", Code="H14", Type=agent_type.Fitter },
                new Agent{Name="Phyllis Vance", Password="password19", Code="H15", Type=agent_type.Surveyor },
                new Agent{Name="Meredith Palmer", Password="password20", Code="HH14", Type=agent_type.Satellite },
                new Agent{Name="Creed Bratton", Password="password21", Code="HH15", Type=agent_type.Fitter },
                new Agent{Name="Andy Bernard", Password="password22", Code="H16", Type=agent_type.Surveyor },
                new Agent{Name="Erin Hannon", Password="password23", Code="H17", Type=agent_type.Satellite },
                new Agent{Name="Darryl Philbin", Password="password24", Code="H18", Type=agent_type.Fitter },
                new Agent{Name="Robert California", Password="password25", Code="HH16", Type=agent_type.Surveyor },
                new Agent{Name="Gabe Lewis", Password="password26", Code="HH17", Type=agent_type.Satellite },
                new Agent{Name="Clark Green", Password="password27", Code="H19", Type=agent_type.Fitter },
                new Agent{Name="Pete Miller", Password="password28", Code="H20", Type=agent_type.Surveyor },
                new Agent{Name="David Wallace", Password="password29", Code="H21", Type=agent_type.Satellite },
                new Agent{Name="Jan Levinson", Password="password30", Code="HH18", Type=agent_type.Surveyor },
                new Agent{Name="Roy Anderson", Password="password31", Code="HH19", Type=agent_type.Fitter },
                new Agent{Name="Holly Flax", Password="password32", Code="H22", Type=agent_type.Surveyor },
                new Agent{Name="Nellie Bertram", Password="password33", Code="H23", Type=agent_type.Satellite },
                new Agent{Name="Charles Miner", Password="password34", Code="H24", Type=agent_type.Fitter },
                new Agent{Name="Jo Bennett", Password="password35", Code="HH20", Type=agent_type.Surveyor },
                new Agent{Name="Danny Cordray", Password="password36", Code="HH21", Type=agent_type.Satellite },
                new Agent{Name="Karen Filippelli", Password="password37", Code="H25", Type=agent_type.Surveyor },
                new Agent{Name="Todd Packer", Password="password38", Code="H26", Type=agent_type.Fitter },
                new Agent{Name="Bob Vance", Password="password39", Code="H27", Type=agent_type.Satellite },
                new Agent{Name="Hank Tate", Password="password40", Code="HH22", Type=agent_type.Fitter },
                new Agent{Name="Mose Schrute", Password="password41", Code="HH23", Type=agent_type.Satellite },
                new Agent{Name="Administrator", Code="admin", Password="admin123", Type=agent_type.Satellite }
            };
            foreach (Agent s in agents)
            {
                context.Add(s);
            }

            var jobs = new Job[]
            {
                new Job{ContractId=1,ContractCode="00000321",JobType=enum_job_type.Survey,DiaryDate=DateTime.Today,Time=DateTime.Now,IncidentDate=DateTime.Today,CauseOfDamage="Wear + Tear",DamageDesc="Burst water pipe", Instructions="Check for damage",CustomerId=3,AgentId=1},
                //new Job{ContractId=4,ContractCode="00000505",JobType=enum_job_type.Fitting,DiaryDate=DateTime.Today,Time=DateTime.Now,IncidentDate=DateTime.Today,CauseOfDamage="Impact",DamageDesc="Subsidence in living room",Instructions="Check window frame",CustomerId=8,AgentId=1},
                //new Job{ContractId=6,ContractCode="00000678",JobType=enum_job_type.Remedial,DiaryDate=DateTime.Today,Time=DateTime.Now,IncidentDate=DateTime.Today,CauseOfDamage="Loss of keys",DamageDesc="Door smashed in",Instructions="Check type of door",CustomerId=4,AgentId=1},
            };
            foreach (Job j in jobs)
            {
                context.Add(j);
            }

            context.SaveChanges();

        }
    }
}
