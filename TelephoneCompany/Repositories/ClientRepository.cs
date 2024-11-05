using System;
using Microsoft.EntityFrameworkCore;
using TelephoneCompany.Entities;
using TelephoneCompany.Infrastructure.Data;
using TelephoneCompany.Interfaces.Repositories;

namespace TelephoneCompany.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly TelephoneCompanyContext _context;

        public ClientRepository(TelephoneCompanyContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Client>> GetAllClients()
        {
            return await _context.Clients.ToListAsync();
        }
        public async Task<Client> GetClientById(int id)
        {
            return await _context.Clients.FindAsync(id);
        }

        public async Task AddClient(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateClient(Client client)
        {
            _context.Clients.Update(client);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteClient(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
        }
    }
}
