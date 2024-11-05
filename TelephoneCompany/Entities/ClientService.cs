namespace TelephoneCompany.Entities
{
    public class ClientService
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client? Client { get; set; }
        public int ServiceId { get; set; }
        public Service? Service { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
