// TODO:Shittu

using System.ComponentModel.DataAnnotations;

namespace SharpCuts.Models
{
    public class AppointmentModel
    {
        [Key]
        public int AppointmentId { get; set; }
        public int ClientID { get; set; }
        public required ClientModel Client { get; set; } //Navigation prop
        public int ServiceID { get; set; }
        public required ServiceModel Service { get; set; } //Navigation prop
        public DateTime DateTime { get; set; }
    }
}