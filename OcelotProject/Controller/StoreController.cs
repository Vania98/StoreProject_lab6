using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OcelotProject.Model;
using OcelotProject.Services;

namespace OcelotProject.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStore_1Service _store_1Service;
        private readonly IStoreProgram_Service _storeProgram_Service;

        public StoreController(IStore_1Service store_1Service, IStoreProgram_Service storeProgram_Service)
        {
            _store_1Service = store_1Service;
            _storeProgram_Service = storeProgram_Service;
        }
        [HttpGet("GetAll")]
        public async Task<GetAllModel> GetAll()
        {
            var products = await _store_1Service.GetProducts();
            var sellers = await _store_1Service.GetSeller();
            var baskets = await _storeProgram_Service.GetBaskets();
            var clients = await _storeProgram_Service.GetClients();

            // Створюємо об'єкт GetAllModel та заповнюємо його даними
            var result = new GetAllModel
            {
                Product = products,
                Seller = sellers,
                Basket = baskets,
                Client = clients
            };

            return result;
        }

    }
}
