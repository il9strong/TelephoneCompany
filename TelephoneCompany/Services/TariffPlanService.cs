using TelephoneCompany.Entities;
using TelephoneCompany.Interfaces.Repositories;
using TelephoneCompany.Interfaces.Services;

namespace TelephoneCompany.Services
{
    public class TariffPlanService : ITariffPlanService
    {
        private readonly ITariffPlanRepository _tariffPlanRepository;

        public TariffPlanService(ITariffPlanRepository tariffPlanRepository)
        {
            _tariffPlanRepository = tariffPlanRepository;
        }

        public async Task<TariffPlan> GetTariffPlanById(int id)
        {
            return await _tariffPlanRepository.GetTariffPlanById(id);
        }

        public async Task<IEnumerable<TariffPlan>> GetAllTariffPlans()
        {
            return await _tariffPlanRepository.GetAllTariffPlans();
        }

        public async Task AddTariffPlan(TariffPlan tariffPlan)
        {
            await _tariffPlanRepository.AddTariffPlan(tariffPlan);
        }

        public async Task UpdateTariffPlan(TariffPlan tariffPlan)
        {
            await _tariffPlanRepository.UpdateTariffPlan(tariffPlan);
        }

        public async Task DeleteTariffPlan(int id)
        {
            await _tariffPlanRepository.DeleteTariffPlan(id);
        }
    }
}
