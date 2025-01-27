using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MyData.Databases;

public interface IRepository
{
    Task<object> GetAsync(object[] keys, CancellationToken cancellationToken = default);
    Task<object> DeleteAsync(object[] keys, CancellationToken cancellationToken = default);
    Task<object> UpdateAsync(object[] keys, Action<object> configure, CancellationToken cancellationToken = default);
    Task<object> CreateAsync(object entity, CancellationToken cancellationToken = default);
}
