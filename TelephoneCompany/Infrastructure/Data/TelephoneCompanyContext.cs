using Microsoft.EntityFrameworkCore;
using TelephoneCompany.Entities;

namespace TelephoneCompany.Infrastructure.Data
{
    public class TelephoneCompanyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<TariffPlan> TariffPlans { get; set; }
        public DbSet<ClientService> ClientServices { get; set; }
        public DbSet<ClientTariffPlan> ClientTariffPlans { get; set; }
        public DbSet<Request> Requests { get; set; }

        public TelephoneCompanyContext(DbContextOptions<TelephoneCompanyContext> options)
        : base(options)
        {
        }
    }

}
