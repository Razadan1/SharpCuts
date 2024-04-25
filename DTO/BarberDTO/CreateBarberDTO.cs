using System.ComponentModel.DataAnnotations;

namespace SharpCuts.DTO.BarberDTO;

public record class CreateBarberDTo(
    int Id, 
    [StringLength(50)] string FirstName, 
    [StringLength(50)] string LastName, 
    string Bio
);
