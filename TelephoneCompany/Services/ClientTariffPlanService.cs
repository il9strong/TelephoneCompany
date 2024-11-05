using TelephoneCompany.Entities;
using TelephoneCompany.Interfaces.Repositories;
using TelephoneCompany.Interfaces.Services;

namespace TelephoneCompany.Services
{
    public class ClientTariffPlanService : IClientTariffPlanService
    {
        private readonly IClientTariffPlanRepository _clientTariffPlanRepository;

        public ClientTariffPlanService(IClientTariffPlanRepository clientTariffPlanRepository)
        {
            _clientTariffPlanRepository = clientTariffPlanRepository;
        }

        public async Task<ClientTariffPlan> GetClientTariffPlanById(int id)
        {
            return await _clientTariffPlanRepository.GetClientTariffPlanById(id);
        }

        public async Task<IEnumerable<ClientTariffPlan>> GetAllClientTariffPlans()
        {
            return await _clientTariffPlanRepository.GetAllClientTariffPlans();
        }

        public async Task AddClientTariffPlan(ClientTariffPlan clientTariffPlan)
        {
            await _clientTariffPlanRepository.AddClientTariffPlan(clientTariffPlan);
        }

        public async Task UpdateClientTariffPlan(ClientTariffPlan clientTariffPlan)
        {
            await _clientTariffPlanRepository.UpdateClientTariffPlan(clientTariffPlan);
        }

        public async Task DeleteClientTariffPlan(int id)
        {
            await _clientTariffPlanRepository.DeleteClientTariffPlan(id);
        }
    }
}
