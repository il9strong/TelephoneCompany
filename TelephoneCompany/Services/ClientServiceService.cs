using TelephoneCompany.Entities;
using TelephoneCompany.Interfaces.Repositories;
using TelephoneCompany.Interfaces.Services;

namespace TelephoneCompany.Services
{
    public class ClientServiceService : IClientServiceService
    {
        private readonly IClientServiceRepository _clientServiceRepository;

        public ClientServiceService(IClientServiceRepository clientServiceRepository)
        {
            _clientServiceRepository = clientServiceRepository;
        }

        public async Task<Entities.ClientService> GetClientServiceById(int id)
        {
            return await _clientServiceRepository.GetClientServiceById(id);
        }

        public async Task<IEnumerable<Entities.ClientService>> GetAllClientServices()
        {
            return await _clientServiceRepository.GetAllClientServices();
        }

        public async Task AddClientService(Entities.ClientService clientService)
        {
            await _clientServiceRepository.AddClientService(clientService);
        }

        public async Task UpdateClientService(Entities.ClientService clientService)
        {
            await _clientServiceRepository.UpdateClientService(clientService);
        }

        public async Task DeleteClientService(int id)
        {
            await _clientServiceRepository.DeleteClientService(id);
        }
    }
}
