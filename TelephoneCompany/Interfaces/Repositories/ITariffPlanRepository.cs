using TelephoneCompany.Entities;

namespace TelephoneCompany.Interfaces.Repositories
{
    public interface ITariffPlanRepository
    {
        Task<TariffPlan> GetTariffPlanById(int id);
        Task<IEnumerable<TariffPlan>> GetAllTariffPlans();
        Task AddTariffPlan(TariffPlan tariffPlan);
        Task UpdateTariffPlan(TariffPlan tariffPlan);
        Task DeleteTariffPlan(int id);
    }
}
