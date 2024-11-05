using System.ComponentModel.DataAnnotations.Schema;

namespace TelephoneCompany.Entities
{
    public class ClientTariffPlan
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client? Client { get; set; }
        [ForeignKey("TariffPlan")]
        public int PlanId { get; set; }
        public TariffPlan? TariffPlan { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
