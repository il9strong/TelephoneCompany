﻿using TelephoneCompany.Entities;
using TelephoneCompany.Interfaces.Repositories;
using TelephoneCompany.Interfaces.Services;

namespace TelephoneCompany.Services
{
    public class ServiceService : IServiceService
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceService(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public async Task<Service> GetServiceById(int id)
        {
            return await _serviceRepository.GetServiceById(id);
        }

        public async Task<IEnumerable<Service>> GetAllServices()
        {
            return await _serviceRepository.GetAllServices();
        }

        public async Task AddService(Service service)
        {
            await _serviceRepository.AddService(service);
        }

        public async Task UpdateService(Service service)
        {
            await _serviceRepository.UpdateService(service);
        }

        public async Task DeleteService(int id)
        {
            await _serviceRepository.DeleteService(id);
        }
    }
}
