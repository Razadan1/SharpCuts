using Microsoft.EntityFrameworkCore;
using SharpCuts.Models;

namespace Desktop;

public class SharpCutDbContext(DbContextOptions<SharpCutDbContext> options) : DbContext(options)
{
    public DbSet<ClientModel> Clients  => Set<ClientModel>();
        public DbSet<BarbersModel> Barbers  => Set<BarbersModel>();
    public DbSet<AppointmentsModel> Appointments  => Set<AppointmentsModel>();
    public DbSet<ServiceModel> Services  => Set<ServiceModel>();


}
