using Microsoft.EntityFrameworkCore;
using TelephoneCompany.Entities;
using TelephoneCompany.Infrastructure.Data;
using TelephoneCompany.Interfaces.Repositories;

namespace TelephoneCompany.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly TelephoneCompanyContext _context;

        public ServiceRepository(TelephoneCompanyContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Service>> GetAllServices()
        {
            return await _context.Services.ToListAsync();
        }
        public async Task<Service> GetServiceById(int id)
        {
            return await _context.Services.FindAsync(id);
        }

        public async Task AddService(Service service)
        {
            _context.Services.Add(service);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateService(Service service)
        {
            _context.Services.Update(service);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteService(int id)
        {
            var service = await _context.Services.FindAsync(id);
            _context.Services.Remove(service);
            await _context.SaveChangesAsync();
        }
    }
}
