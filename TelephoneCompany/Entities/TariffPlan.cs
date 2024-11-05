using System.ComponentModel.DataAnnotations;

namespace TelephoneCompany.Entities
{
    public class TariffPlan
    {
        [Key]
        public int PlanId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
