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
                UserName = "craig.griffiths2007@gmail.com",
                Email = "craig.griffiths2007@gmail.com",
                FirstName = "Craig",
                LastName = "Griffiths",
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

            // Look for any students.
            if (context.Customer.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
                new Customer{Name="Craig Griffiths",Add1="56 Sunny Road",Add2="Bolton",Add3="Lancashire",Postcode="BL14NN",Phone1="07376559088",Phone2="",Phone3=""},
            };
            foreach (Customer c in customers)
            {
                context.Add(c);
            }

            var agents = new Agent[]
            {
                new Agent{Name="James Dean", AgentCode="H1"},
            };
            foreach (Agent s in agents)
            {
                context.Add(s);
            }

            context.SaveChanges();


        }
    }
}
