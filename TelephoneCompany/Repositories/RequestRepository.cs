using Microsoft.EntityFrameworkCore;
using TelephoneCompany.Entities;
using TelephoneCompany.Infrastructure.Data;
using TelephoneCompany.Interfaces.Repositories;

namespace TelephoneCompany.Repositories
{
    public class RequestRepository : IRequestRepository
    {
        private readonly TelephoneCompanyContext _context;

        public RequestRepository(TelephoneCompanyContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Request>> GetAllRequests()
        {
            return await _context.Requests.ToListAsync();
        }
        public async Task<Request> GetRequestById(int id)
        {
            return await _context.Requests.FindAsync(id);
        }

        public async Task AddRequest(Request request)
        {
            _context.Requests.Add(request);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRequest(Request request)
        {
            _context.Requests.Update(request);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRequest(int id)
        {
            var request = await _context.Requests.FindAsync(id);
            _context.Requests.Remove(request);
            await _context.SaveChangesAsync();
        }
    }
}
