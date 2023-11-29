using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using OcelotProject.Model;

namespace OcelotProject.Model
{
    public class GetAllModel
    {
        public IEnumerable<Basket> Basket { get; set; }
        public IEnumerable<Client> Client { get; set; }
        public IEnumerable<Product> Product { get; set; }
        public IEnumerable<Seller> Seller { get; set; }
    }
}
