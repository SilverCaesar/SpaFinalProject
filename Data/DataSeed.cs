using Microsoft.EntityFrameworkCore;
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
                // Replace object initializer syntax with constructor calls for Service
                if (!context.Service.Any())
                {
                    context.Service.AddRange(
                        new Service(
                            "Deep Tissue Massage",
                            "Focused, therapeutic work targeting chronic tension and muscle knots. Ideal for athletes or those with persistent aches.",
                            55,
                            60
                        ),
                        new Service(
                            "Scalp & Head Massage",
                            "A focused treatment to relieve tension, boost circulation, and leave you feeling clear-headed and refreshed.",
                            35,
                            45
                        ),
                        new Service(
                            "Anti-Aging Facial",
                            "Targets fine lines, dullness, and loss of elasticity with firming, brightening ingredients and advanced techniques.",
                            40,
                            35
                        )
                    );
                    context.SaveChanges();

                }
                context.SaveChanges();
            }
        }
    }
}
