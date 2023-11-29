using OcelotProject.Model;

namespace OcelotProject.Services
{
    public interface IStoreProgram_Service
    {
        Task<IEnumerable<Basket>> GetBaskets();
        Task<IEnumerable<Client>> GetClients();
    }
}
