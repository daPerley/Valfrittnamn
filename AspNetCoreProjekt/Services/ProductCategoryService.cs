using AspNetCoreProjekt.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace AspNetCoreProjekt.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly ApplicationDbContext _context;

        // Or should IHttpContextAccesor be used instead?
        public ProductCategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public SelectList GetSelectList()
        {
            return new SelectList(_context.ProductCategories.ToList(), "Id", "Name");
        }
    }
}
