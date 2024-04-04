using Microsoft.EntityFrameworkCore;
using SharpCuts.Models;

namespace Desktop;

public class SharpCutDbContext(DbContextOptions<SharpCutDbContext> options) : DbContext(options)
{
    public DbSet<ClientModel> Clients => Set<ClientModel>();
    public DbSet<BarberModel> Barbers => Set<BarberModel>();
    public DbSet<AppointmentModel> Appointments => Set<AppointmentModel>();
    public DbSet<ServiceModel> Services => Set<ServiceModel>();


}
