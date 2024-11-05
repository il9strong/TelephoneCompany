using TelephoneCompany.Entities;

namespace TelephoneCompany.Interfaces.Services
{
    public interface IClientService
    {
        Task<Client> GetClientById(int id);
        Task<IEnumerable<Client>> GetAllClients();
        Task AddClient(Client client);
        Task UpdateClient(Client client);
        Task DeleteClient(int id);
    }
}
