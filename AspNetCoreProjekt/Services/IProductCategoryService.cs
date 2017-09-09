using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetCoreProjekt.Services
{
    public interface IProductCategoryService
    {
        SelectList GetSelectList();
    }
}
