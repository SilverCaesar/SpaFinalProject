using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SpaFinalProject.Components.Models;

namespace SpaFinalProject.Data
{
    public class DataSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new SpaFinalProjectContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SpaFinalProjectContext>>());

            // If we can't connect to the database, skip seeding instead of throwing.
            // This avoids transient startup failures while the connection/permissions are fixed.
            if (!context.Database.CanConnect())
            {
                Console.WriteLine("Database cannot be reached. Skipping seed. Verify connection string and login permissions for the configured user.");
                return;
            }

            if (!context.Service.Any())
            {
                context.Service.AddRange(
            new Service
            {
                Name = "Deep Tissue Massage",
                Description = "Focused, therapeutic work targeting chronic tension and muscle knots. Ideal for athletes or those with persistent aches.",
                Price = 55,
                Duration = 60
            },

            new Service
            {
                Name = "Scalp & Head Massage",
                Description = "A focused treatment to relieve tension, boost circulation, and leave you feeling clear-headed and refreshed.",
                Price = 35,
                Duration = 45
            },

            new Service
            {
                Name = "Anti-Aging Facial",
                Description = "Targets fine lines, dullness, and loss of elasticity with firming, brightening ingredients and advanced techniques.",
                Price = 40,
                Duration = 35
            }
                );
            }
        }
    }
}
