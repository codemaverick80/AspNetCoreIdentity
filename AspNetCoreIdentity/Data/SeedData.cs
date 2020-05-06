using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using AspNetCoreIdentity.Models;
using Microsoft.AspNetCore.Identity;

namespace AspNetCoreIdentity.Data
{
    public class SeedData
    {
        public static async Task Initialize(
            ApplicationDbContext context, 
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();

            const string adminRole = "Admin";
            const string userRole = "User";
            const string password = "Password@3";


            #region "Creating Roles"
            
            if (await roleManager.FindByNameAsync(adminRole) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(adminRole, "This is the administrator role for the app",
                    DateTime.Now));
            }

            if (await roleManager.FindByNameAsync(userRole) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(userRole, "This is the User role for the app",
                    DateTime.Now));
            }



            #endregion


            #region "Create Users

            if (await userManager.FindByNameAsync("john@identity.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "john@identity.com",
                    Email = "john@identity.com",
                    FirstName = "John",
                    LastName = "Doe"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, userRole);
                }
            }

            if (await userManager.FindByNameAsync("tony@identity.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "tony@identity.com",
                    Email = "tony@identity.com",
                    FirstName = "Tony",
                    LastName = "Stark"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, adminRole);
                }
            }

            if (await userManager.FindByNameAsync("bruce@identity.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "bruce@identity.com",
                    Email = "bruce@identity.com",
                    FirstName = "Bruce",
                    LastName = "Wayne"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, adminRole);
                }
            }
            
            #endregion

        }

    }
}
