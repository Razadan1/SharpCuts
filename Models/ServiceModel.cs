using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharpCuts.Models
{
    public class ServiceModel
    {
        [Key]
        public int ServiceID { get; set; }
        [Column(TypeName = "varchar(50)")]

        public required string ServiceName { get; set; }
        public string Image { get; set; } = default!;

        public required string Description { get; set; }
        [Column(TypeName = "decimal(10,2)")]

        public decimal Price { get; set; }
    }
}