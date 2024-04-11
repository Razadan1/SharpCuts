using SharpCuts.Models;

namespace SharpCuts.DTO.BarberDTO;

public class BarberDTO
{
public string? Name { get; set; }
public IEnumerable<BarberModel> barbers;

public BarberDTO(IEnumerable<BarberModel> barbers)
{
    this.barbers = barbers;
}
}
