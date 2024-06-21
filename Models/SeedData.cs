using Applelicious_Ventures.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Drawing;
using System.Linq;


namespace Applelicious_Ventures.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ApplicationDbContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ApplicationDbContext>>()))
        {
            // Look for any movies.
            if (context.Apple.Any())
            {
                return;   // DB has been seeded
            }
            context.Apple.AddRange(
                new Apple
                {
                    Origin = "India",
                    ImportDate = DateTime.Parse("2024-2-12"),
                    Color = "Romantic Red",
                    Price = 7.99M,
                    Nutrients = "High",
                    Shape = "Normal",



                },
                 new Apple
                 {
                     Origin = "Iran",
                     ImportDate = DateTime.Parse("2024-2-01"),
                     Color = "Brown",
                     Price = 3.99M,
                     Nutrients = "Medium",
                     Shape = "Unique",



                 },
                  new Apple
                  {
                      Origin = "Thailand",
                      ImportDate = DateTime.Parse("2024-2-03"),
                      Color = "Brown Light",
                      Price = 6.99M,
                      Nutrients = "Low",
                      Shape = "Apple Pie",



                  },
                   new Apple
                   {
                       Origin = "NZ",
                       ImportDate = DateTime.Parse("2024-2-04"),
                       Color = "Red Purple",
                       Price = 2.99M,
                       Nutrients = "High",
                       Shape = "Normal",



                   },
                    new Apple
                    {
                        Origin = "Ireland",
                        ImportDate = DateTime.Parse("2024-2-03"),
                        Color = "Fetish Pink",
                        Price = 15.99M,
                        Nutrients = "High",
                        Shape = "Unique",


                    },
                 new Apple
                 {
                     Origin = "UK",
                     ImportDate = DateTime.Parse("2024-2-11"),
                     Color = "Red",
                     Price = 6.99M,
                     Nutrients = "Low",
                     Shape = "Normal",



                 },
                  new Apple
                  {
                      Origin = "Switzerland",
                      ImportDate = DateTime.Parse("2024-2-10"),
                      Color = "Fetish Red",
                      Price = 5.99M,
                      Nutrients = "Medium",
                      Shape = "Apple Pie",



                  },
                   new Apple
                   {
                       Origin = "Estonia",
                       ImportDate = DateTime.Parse("2024-2-09"),
                       Color = "Childish Red",
                       Price = 8.99M,
                       Nutrients = "High",
                       Shape = "Unique",



                   },
                new Apple
                {
                    Origin = "Lithuania",
                    ImportDate = DateTime.Parse("1989-2-08"),
                    Color = "Green Apple",
                    Price = 9.99M,
                    Nutrients = "Low",
                    Shape = "Unique",
                },
                new Apple
                {
                    Origin = "Nepal",
                    ImportDate = DateTime.Parse("2024-2-07"),
                    Color = "Light Green",
                    Price = 8.99M,
                    Nutrients = "High",
                    Shape = "Apple Pie",
                },
                new Apple
                {
                    Origin = "Latvia",
                    ImportDate = DateTime.Parse("2024-2-06"),
                    Color = "Romantic Pink",
                    Price = 11.99M,
                    Nutrients = "Medium",
                    Shape = "Low",
                }

            );
            context.SaveChanges();
        }
    }
}