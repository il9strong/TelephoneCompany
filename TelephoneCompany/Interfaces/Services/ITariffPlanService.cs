using TelephoneCompany.Entities;

namespace TelephoneCompany.Interfaces.Services
{
    public interface ITariffPlanService
    {
        Task<TariffPlan> GetTariffPlanById(int id);
        Task<IEnumerable<TariffPlan>> GetAllTariffPlans();
        Task AddTariffPlan(TariffPlan tariffPlan);
        Task UpdateTariffPlan(TariffPlan tariffPlan);
        Task DeleteTariffPlan(int id);
    }
}
