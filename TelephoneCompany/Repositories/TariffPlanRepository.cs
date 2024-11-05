using Microsoft.EntityFrameworkCore;
using TelephoneCompany.Entities;
using TelephoneCompany.Infrastructure.Data;
using TelephoneCompany.Interfaces.Repositories;

namespace TelephoneCompany.Repositories
{
    public class TariffPlanRepository : ITariffPlanRepository
    {
        private readonly TelephoneCompanyContext _context;

        public TariffPlanRepository(TelephoneCompanyContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TariffPlan>> GetAllTariffPlans()
        {
            return await _context.TariffPlans.ToListAsync();
        }
        public async Task<TariffPlan> GetTariffPlanById(int id)
        {
            return await _context.TariffPlans.FindAsync(id);
        }

        public async Task AddTariffPlan(TariffPlan tariffPlan)
        {
            _context.TariffPlans.Add(tariffPlan);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTariffPlan(TariffPlan tariffPlan)
        {
            _context.TariffPlans.Update(tariffPlan);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTariffPlan(int id)
        {
            var tariffplan = await _context.TariffPlans.FindAsync(id);
            _context.TariffPlans.Remove(tariffplan);
            await _context.SaveChangesAsync();
        }
    }
}
