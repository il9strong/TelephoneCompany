using TelephoneCompany.Entities;

namespace TelephoneCompany.Interfaces.Services
{
    public interface IServiceService
    {
        Task<Service> GetServiceById(int id);
        Task<IEnumerable<Service>> GetAllServices();
        Task AddService(Service service);
        Task UpdateService(Service service);
        Task DeleteService(int id);
    }
}
