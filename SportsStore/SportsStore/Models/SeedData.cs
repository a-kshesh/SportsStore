using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product { Name = "Kayak", Description="A boat for one person",Category="Watersports",Price = 257 },
                    new Product { Name = "Lifejacket", Description = "Protective and fasionable", Category = "Watersports", Price = 79M },
                    new Product { Name = "Running shoes", Description = "Shoes for running", Category = "Shoes", Price = 95M },
                    new Product { Name = "Running shoes", Description = "Shoes for running", Category = "Shoes", Price = 95M },
                    new Product { Name = "Running shoes", Description = "Shoes for running", Category = "Shoes", Price = 95M },
                    new Product { Name = "Running shoes", Description = "Shoes for running", Category = "Shoes", Price = 95M },
                    new Product { Name = "Running shoes", Description = "Shoes for running", Category = "Shoes", Price = 95M },
                    new Product { Name = "Running shoes", Description = "Shoes for running", Category = "Shoes", Price = 95M }
                );
                context.SaveChanges();
            }
        }
    }
}
