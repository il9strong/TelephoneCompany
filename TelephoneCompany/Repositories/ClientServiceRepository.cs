using Microsoft.EntityFrameworkCore;
using TelephoneCompany.Entities;
using TelephoneCompany.Infrastructure.Data;
using TelephoneCompany.Interfaces.Repositories;

namespace TelephoneCompany.Repositories
{
    public class ClientServiceRepository : IClientServiceRepository
    {
        private readonly TelephoneCompanyContext _context;

        public ClientServiceRepository(TelephoneCompanyContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ClientService>> GetAllClientServices()
        {
            return await _context.ClientServices.ToListAsync();
        }
        public async Task<ClientService> GetClientServiceById(int id)
        {
            return await _context.ClientServices.FindAsync(id);
        }

        public async Task AddClientService(ClientService clientService)
        {
            _context.ClientServices.Add(clientService);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateClientService(ClientService clientService)
        {
            _context.ClientServices.Update(clientService);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteClientService(int id)
        {
            var clientService = await _context.ClientServices.FindAsync(id);
            _context.ClientServices.Remove(clientService);
            await _context.SaveChangesAsync();
        }
    }
}
