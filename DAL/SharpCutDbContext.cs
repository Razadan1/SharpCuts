using Microsoft.EntityFrameworkCore;
using SharpCuts.Models;

namespace Desktop;

public class SharpCutDbContext(DbContextOptions<SharpCutDbContext> options) : DbContext(options)
{
    public DbSet<ClientModel> Clients  => Set<ClientModel>();
        public DbSet<ClientModel> Barbers  => Set<ClientModel>();
    public DbSet<ClientModel> Appointments  => Set<ClientModel>();
    public DbSet<ServiceModel> Services  => Set<ServiceModel>();


}
