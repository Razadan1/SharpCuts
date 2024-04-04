namespace SharpCuts.Models
{
    public class ClientModel
    {
        public int ClientID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }

    }
}