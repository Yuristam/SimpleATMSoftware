namespace CoreBankingSystem.DAL.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public short? Apartment { get; set; }

        public ICollection<Client> Clients { get; set; }
    }
}
