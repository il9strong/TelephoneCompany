using TelephoneCompany.Entities;
using TelephoneCompany.Interfaces.Repositories;
using TelephoneCompany.Interfaces.Services;

namespace TelephoneCompany.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Client> GetClientById(int id)
        {
            return await _clientRepository.GetClientById(id);
        }

        public async Task<IEnumerable<Client>> GetAllClients()
        {
            return await _clientRepository.GetAllClients();
        }

        public async Task AddClient(Client client)
        {
            await _clientRepository.AddClient(client);
        }

        public async Task UpdateClient(Client client)
        {
            await _clientRepository.UpdateClient(client);
        }

        public async Task DeleteClient(int id)
        {
            await _clientRepository.DeleteClient(id);
        }
    }
}
