using TelephoneCompany.Entities;

namespace TelephoneCompany.Interfaces.Services
{
    public interface IRequestService
    {
        Task<Request> GetRequestById(int id);
        Task<IEnumerable<Request>> GetAllRequests();
        Task AddRequest(Request request);
        Task UpdateRequest(Request request);
        Task DeleteRequest(int id);
    }
}
