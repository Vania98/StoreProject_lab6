using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OcelotProject.Model;

namespace OcelotProject.Services
{
    public class Store_1Service : IStore_1Service
    {
        private readonly HttpClient _httpClient;

        public Store_1Service(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var response = await _httpClient.GetAsync("/api/Product/GetAll");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var products = JsonConvert.DeserializeObject<List<Product>>(jsonData);
                return products;
            }
            return null;
        }

        public async Task<IEnumerable<Seller>> GetSeller()
        {
            var response = await _httpClient.GetAsync("/api/Seller/GetAll");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var sellers = JsonConvert.DeserializeObject<List<Seller>>(jsonData);
                return sellers;
            }
            return null;
        }
    }
}
