using SharpCuts.DAL.Contracts;
using SharpCuts.Models;

namespace SharpCuts.DAL.Repo;

public class ClientRepo : IClient
{
    public Task CreateAsync(ClientModel entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ClientModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ClientModel?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(ClientModel entity)
    {
        throw new NotImplementedException();
    }
}
