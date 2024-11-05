using Microsoft.EntityFrameworkCore;
using TelephoneCompany.Entities;
using TelephoneCompany.Infrastructure.Data;
using TelephoneCompany.Interfaces.Repositories;

namespace TelephoneCompany.Repositories
{
    public class ClientTariffPlanRepository : IClientTariffPlanRepository
    {
        private readonly TelephoneCompanyContext _context;

        public ClientTariffPlanRepository(TelephoneCompanyContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ClientTariffPlan>> GetAllClientTariffPlans()
        {
            return await _context.ClientTariffPlans.ToListAsync();
        }
        public async Task<ClientTariffPlan> GetClientTariffPlanById(int id)
        {
            return await _context.ClientTariffPlans.FindAsync(id);
        }

        public async Task AddClientTariffPlan(ClientTariffPlan clientTariffPlan)
        {
            _context.ClientTariffPlans.Add(clientTariffPlan);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateClientTariffPlan(ClientTariffPlan clientTariffPlan)
        {
            _context.ClientTariffPlans.Update(clientTariffPlan);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteClientTariffPlan(int id)
        {
            var clientTariffPlan = await _context.ClientTariffPlans.FindAsync(id);
            _context.ClientTariffPlans.Remove(clientTariffPlan);
            await _context.SaveChangesAsync();
        }
    }
}
