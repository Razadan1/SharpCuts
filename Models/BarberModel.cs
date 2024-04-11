// TODO:Shittu
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharpCuts.Models
{
    public class BarberModel
    {
        // TODO:ADD images to everything
        [Key]
        public int BarberId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public required string FirstName { get; set; }
        [Column(TypeName = "varchar(50)")]

        public required string LastName { get; set; }
        public required string Bio { get; set; }
    }
}