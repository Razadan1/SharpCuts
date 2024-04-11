using SharpCuts.DAL.Contracts;
using SharpCuts.Models;

namespace SharpCuts.DAL.Repo;

public class AppointementRepo : IAppointments
{
    public Task CreateAsync(AppointmentModel entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<AppointmentModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<AppointmentModel?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(AppointmentModel entity)
    {
        throw new NotImplementedException();
    }
}
