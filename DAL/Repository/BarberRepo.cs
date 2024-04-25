using Microsoft.EntityFrameworkCore;
using SharpCuts.DAL.Contracts;
using SharpCuts.DAL.MyAppDbContext;
using SharpCuts.Models;

namespace SharpCuts.DAL.Repo;

public class BarberRepo(SharpCutDbContext dbContext) : IBarber
{
    private readonly SharpCutDbContext _sharpCutDb = dbContext;

    public async Task CreateAsync(BarberModel entity)
    {
        await _sharpCutDb.Barbers.AddAsync(entity);
        _sharpCutDb.SaveChanges();
    }

    public async Task DeleteAsync(int id)
    {
        await _sharpCutDb.Barbers.Where(e => e.BarberId == id).ExecuteDeleteAsync();
    }

    public async Task<IEnumerable<BarberModel>> GetAllAsync()
    {
        var result = await _sharpCutDb.Barbers.AsNoTracking().ToListAsync();
        return result;
    }

    public async Task<BarberModel?> GetByIdAsync(int id)
    {
        BarberModel? barber = await _sharpCutDb.Barbers.FirstOrDefaultAsync(e => e.BarberId == id);
        return barber;
    }

    public async Task UpdateAsync(BarberModel entity)
    {
        var barber =  _sharpCutDb.Barbers.FirstOrDefault(e=> e.BarberId == entity.BarberId);
        barber!.FirstName = entity.FirstName;
        barber.LastName = entity.LastName;
        barber.Bio = entity.Bio;
        await _sharpCutDb.SaveChangesAsync();
    }
}
