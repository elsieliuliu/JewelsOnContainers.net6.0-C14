using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using WebMvc.Infrastructure;
using WebMvc.Models;

namespace WebMvc.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly IHttpClient _httpClient;
        private readonly string _baseUrl;
        public CatalogService(IConfiguration config, IHttpClient client)
        {
            _httpClient = client;
            _baseUrl = $"{config["CatalogUrl"]}/api/catalog";
        }
        public Task<IEnumerable<SelectListItem>> GetBrandsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Catalog> GetCatalogItemsAsync(int page, int size)
        {
            var catalogItemsUri = APIPaths.Catalog.GetAllCatalogItems(_baseUrl, page, size);
            var dataString = await _httpClient.GetStringAsync(catalogItemsUri);
            return JsonConvert.DeserializeObject<Catalog>(dataString);
        }

        public Task<IEnumerable<SelectListItem>> GetTypesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
