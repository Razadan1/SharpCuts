using Microsoft.EntityFrameworkCore;
using SharpCuts.Models;

namespace Desktop;

public class SharpCutDbContext(DbContextOptions<SharpCutDbContext> options) : DbContext(options)
{
    public DbSet<ClientModel> Clients  => Set<ClientModel>();
        public DbSet<ClientModel> Barbers  => Set<BarbersModel>();
    public DbSet<ClientModel> Appointments  => Set<AppointmentsModel>();
    public DbSet<ServiceModel> Services  => Set<ServiceModel>();


}
