using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPages.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesContext>>()))
            {
                // Look for any movies.
                if (context.Flats.Any())
                {
                    return;   // DB has been seeded
                }

                context.Flats.AddRange(
                    new Flats
                    {
                        Name = "When Harry Met Sally",
                        Type="Жилье",
                        Region="Almaty",
                        Organization="Bazis",
                        Since = DateTime.Parse("1989-2-12"),
                        End = DateTime.Parse("1995-2-12"),
                        Status = "Sale",
                        Price = 7.99M
                    },

                    new Flats
                    {
                        Name = "Ghostbusters ",
                        Type = "Жилье",
                        Region = "Almaty",
                        Organization = "Bazis2",
                        Since = DateTime.Parse("1984-3-13"),
                        End = DateTime.Parse("1990-3-13"),
                        Status = "Comedy",
                        Price = 8.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
