using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyData.Databases;

public interface IRepository<T> : IRepository
    where T : Entity, new()
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="keys"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    new Task<T> GetAsync(object[] keys, CancellationToken cancellationToken = default);
    new Task<T> DeleteAsync(object[] keys, CancellationToken cancellationToken = default);
    Task<T> UpdateAsync(object[] keys, Action<T> configure, CancellationToken cancellationToken = default);
    Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default);
   // Task<T> UpcertAsync(T entity, CancellationToken cancellationToken = default);
    IRepositoryBatchContext<T> CreateBatchContext();
}