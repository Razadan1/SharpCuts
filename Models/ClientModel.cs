using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharpCuts.Models
{
    public class ClientModel
    {
        [Key]
        public int ClientID { get; set; }
        [Column(TypeName = "varchar(50)")]
        public required string FirstName { get; set; }
        [Column(TypeName = "varchar(50)")]

        public required string LastName { get; set; }
        [Column(TypeName = "varchar(100)")]

        public required string Email { get; set; }
        [Column(TypeName = "varchar(20)")]

        public required string PhoneNumber { get; set; }

    }
}