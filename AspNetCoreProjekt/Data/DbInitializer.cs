using AspNetCoreProjekt.Models;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCoreProjekt.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            var categories = new List<ProductCategory>
            {
                new ProductCategory{Name="TV"},
                new ProductCategory{Name="DVD"},
                new ProductCategory{Name="VHS"}
            };

            if (!context.ProductCategories.Any())
            {
                context.AddRange(categories);
                context.SaveChanges();
            }
        }
    }
}
