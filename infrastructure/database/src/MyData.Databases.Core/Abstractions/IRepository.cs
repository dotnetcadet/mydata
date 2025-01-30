using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MyData.Databases;

public interface IRepository
{
    Task<Entity> GetAsync(object[] keys, CancellationToken cancellationToken = default);
    Task<Entity> DeleteAsync(object[] keys, CancellationToken cancellationToken = default);
    Task<Entity> UpdateAsync(object[] keys, Action<Entity> configure, CancellationToken cancellationToken = default);
    Task<Entity> CreateAsync(object entity, CancellationToken cancellationToken = default);
    //Task<Entity> UpcertAsync(object entity, CancellationToken cancellationToken = default);
}
