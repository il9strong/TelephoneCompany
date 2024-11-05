using TelephoneCompany.Entities;

namespace TelephoneCompany.Interfaces.Repositories
{
    public interface IClientTariffPlanRepository
    {
        Task<ClientTariffPlan> GetClientTariffPlanById(int id);
        Task<IEnumerable<ClientTariffPlan>> GetAllClientTariffPlans();
        Task AddClientTariffPlan(ClientTariffPlan clientTariffPlan);
        Task UpdateClientTariffPlan(ClientTariffPlan clientTariffPlan);
        Task DeleteClientTariffPlan(int id);
    }
}
