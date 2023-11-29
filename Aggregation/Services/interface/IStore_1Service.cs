
using Aggregation.Model;

namespace Aggregation.Services
{
    public interface IStore_1Service
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<IEnumerable<Seller>> GetSeller();
    }
}
