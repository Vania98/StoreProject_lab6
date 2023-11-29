
using OcelotProject.Model;

namespace OcelotProject.Services
{
    public interface IStore_1Service
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<IEnumerable<Seller>> GetSeller();
    }
}
