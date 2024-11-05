using TelephoneCompany.Entities;

namespace TelephoneCompany.Interfaces.Repositories
{
    public interface IServiceRepository
    {
        Task<Service> GetServiceById(int id);
        Task<IEnumerable<Service>> GetAllServices();
        Task AddService(Service service);
        Task UpdateService(Service service);
        Task DeleteService(int id);
    }
}
