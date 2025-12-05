using Microsoft.AspNetCore.Identity;
using SporSalonuYonetim_web.Models;
using Microsoft.Extensions.DependencyInjection;

namespace SporSalonuYonetim_web.Data
{
    public static class DbSeeder
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (!await roleManager.RoleExistsAsync("Admin"))
                await roleManager.CreateAsync(new IdentityRole("Admin"));

            if (!await roleManager.RoleExistsAsync("Uye"))
                await roleManager.CreateAsync(new IdentityRole("Uye"));

            string adminEmail = "g231210038@sakarya.edu.tr";

            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                var user = new AppUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    Ad = "Admin",
                    Soyad = "Yonetici",
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, "sau");

                if(result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Admin");
                }
            }
        }
    }
}
