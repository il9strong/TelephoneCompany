using TelephoneCompany.Entities;

namespace TelephoneCompany.Interfaces.Repositories
{
    public interface IClientRepository
    {
        Task<Client> GetClientById(int id);
        Task<IEnumerable<Client>> GetAllClients();
        Task AddClient(Client client);
        Task UpdateClient(Client client);
        Task DeleteClient(int id);
    }
}
