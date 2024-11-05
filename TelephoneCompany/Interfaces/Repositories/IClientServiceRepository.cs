using TelephoneCompany.Entities;

namespace TelephoneCompany.Interfaces.Repositories
{
    public interface IClientServiceRepository
    {
        Task<ClientService> GetClientServiceById(int id);
        Task<IEnumerable<ClientService>> GetAllClientServices();
        Task AddClientService(ClientService clientService);
        Task UpdateClientService(ClientService clientService);
        Task DeleteClientService(int id);
    }
}
