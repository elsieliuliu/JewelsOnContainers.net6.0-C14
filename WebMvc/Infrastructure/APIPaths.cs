namespace WebMvc.Infrastructure
{
    public static class APIPaths
    {
        public static class Catalog
        {
            public static string GetAllTypes(string baseUrl)
            {
                return $"{baseUrl}/catalogtypes";
            }
            public static string GetAllBrands(string baseUrl)
            {
                return $"{baseUrl}/catalogbrands";
            }
            public static string GetAllCatalogItems(string baseUrl, int page, int take)
            {
                return $"{baseUrl}/items?pageIndex={page}&pageSize={take}";
            }

        }
    }
}
