namespace TelephoneCompany.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public string? Adress { get; set; }
        public string Phonenumber { get; set; }
        public decimal Balance { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
