using Microsoft.EntityFrameworkCore;
using SharpCuts.DAL.Contracts;
using SharpCuts.DAL.MyAppDbContext;
using SharpCuts.DAL.Repo;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("SharpCutsConnection");
builder.Services.AddDbContext<SharpCutDbContext>(options => { options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)); });
// Registering My repository for Dependency Injection
builder.Services.AddScoped<IService, ServiceRepo>()
.AddScoped<IBarber, BarberRepo>()
.AddScoped<IClient, ClientRepo>().
AddScoped<IAppointments, AppointementRepo>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
