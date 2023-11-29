using Newtonsoft.Json;
using Aggregation.Model;
using Microsoft.AspNetCore.Mvc;

namespace Aggregation.Services
{
    public class StoreProgram_Service : IStoreProgram_Service
    {
        private readonly HttpClient _httpClient;

        public StoreProgram_Service(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(_httpClient));
        }
        public async Task<IEnumerable<Basket>> GetBaskets()
        {
            var response = await _httpClient.GetAsync("/api/Basket/GetAll");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var baskets = JsonConvert.DeserializeObject<List<Basket>>(jsonData);
                return baskets;
            }
            return null;
        }

        public async Task<IEnumerable<Client>> GetClients()
        {
            var response = await _httpClient.GetAsync("api/Client/GetAll");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var clients = JsonConvert.DeserializeObject<List<Client>>(jsonData);
                return clients;
            }
            return null;
        }
    }
}
