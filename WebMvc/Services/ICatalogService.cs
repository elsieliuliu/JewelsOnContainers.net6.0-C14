using Microsoft.AspNetCore.Mvc.Rendering;
using WebMvc.Models;

namespace WebMvc.Services
{
    public interface ICatalogService
    {
        Task<Catalog> GetCatalogItemsAsync(int page, int size);
        Task<IEnumerable<SelectListItem>> GetBrandsAsync();
        Task<IEnumerable<SelectListItem>> GetTypesAsync();
    }
}
