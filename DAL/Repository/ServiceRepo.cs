using SharpCuts.DAL.Contracts;
using SharpCuts.Models;

namespace SharpCuts.DAL.Repo;

public class ServiceRepo : IService
{
    public Task CreateAsync(ServiceModel entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ServiceModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ServiceModel?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(ServiceModel entity)
    {
        throw new NotImplementedException();
    }
}
