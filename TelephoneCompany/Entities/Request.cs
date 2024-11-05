using System.ComponentModel.DataAnnotations.Schema;

namespace TelephoneCompany.Entities
{
    public class Request
    {
        public int RequestId { get; set; }
        public string RequestType { get; set; }
        public int ClientId { get; set; }
        public Client? Client { get; set; }
        public int? ServiceId { get; set; }
        public Service? Service { get; set; }
        [ForeignKey("TariffPlan")]
        public int? PlanId { get; set; }
        public TariffPlan? TariffPlan { get; set; }
        public DateTime? RequestDate { get; set; }
        public string Status { get; set; }
    }
}
