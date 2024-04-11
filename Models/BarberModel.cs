// TODO:Shittu
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharpCuts.Models
{
    public class BarberModel
    {
        [Key]
        public int BarberId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public required string FirstName { get; set; }
        [Column(TypeName = "varchar(50)")]

        public string Image { get; set; } = default!;
        public required string LastName { get; set; }
        public required string Bio { get; set; }
    }
}