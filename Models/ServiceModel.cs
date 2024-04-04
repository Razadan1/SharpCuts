namespace SharpCuts.Models
{
    public class ServiceModel
    {
        public int ServiceID { get; set; }
        public required string ServiceName { get; set; }
        public required string Description { get; set; }

        public decimal Price { get; set; }
    }
}