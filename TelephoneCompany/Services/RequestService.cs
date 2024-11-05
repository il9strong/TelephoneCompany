using TelephoneCompany.Entities;
using TelephoneCompany.Interfaces.Repositories;
using TelephoneCompany.Interfaces.Services;

namespace TelephoneCompany.Services
{
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository _requestRepository;

        public RequestService(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public async Task<Request> GetRequestById(int id)
        {
            return await _requestRepository.GetRequestById(id);
        }

        public async Task<IEnumerable<Request>> GetAllRequests()
        {
            return await _requestRepository.GetAllRequests();
        }

        public async Task AddRequest(Request request)
        {
            await _requestRepository.AddRequest(request);
        }

        public async Task UpdateRequest(Request request)
        {
            await _requestRepository.UpdateRequest(request);
        }

        public async Task DeleteRequest(int id)
        {
            await _requestRepository.DeleteRequest(id);
        }
    }
}
