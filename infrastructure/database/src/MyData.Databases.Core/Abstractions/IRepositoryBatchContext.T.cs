using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyData.Databases;

public interface IRepositoryBatchContext<T>
    where T : Entity, new()
{
    Task CreateAsync(T entity);
    Task DeleteAsync(object[] keys);
    Task UpdateAsync(object[] keys, Action<T> entity);
    Task<IEnumerable<IBatchResult<T>>> ExecuteAsync();
}
