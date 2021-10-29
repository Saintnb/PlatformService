using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PlatformServices.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app, bool isProd)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>(), isProd);
            }
        }

        public static void SeedData(AppDbContext context, bool isProd)
        {
            if (isProd)
            {
                Console.WriteLine(String.Format("--> Attemption to apply Migrations..."));
                try
                {
                    context.Database.Migrate();
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine($"--> Could not run Migrations: {ex.Message}");
                }
            }
            if (!context.Platsforms.Any())
            {
                Console.WriteLine(String.Format("--> Seeding Data..."));

                context.Platsforms.AddRange(
                    new Platform() { Name = "Dot Net", Publisher = "Microsoft", Cost = "Free" },
                    new Platform() { Name = "SQL Server Express", Publisher = "Microsoft", Cost = "Free" },
                    new Platform() { Name = "Kubernates", Publisher = "Clound Native Computing Fundation", Cost = "Free" }
                    );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine(String.Format("--> We Already have Data"));

            }
        }
    }
}