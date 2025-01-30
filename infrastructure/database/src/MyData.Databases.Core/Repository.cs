using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace MyData.Databases;

public abstract class Repository<T> : IQueryableRepository<T>, IBulkOperationRepository<T>
    where T : Entity, new()
{
    public abstract Type ElementType { get; }
    public abstract Expression Expression { get; }
    public abstract IQueryProvider Provider { get; }
    public abstract IEnumerator<T> GetEnumerator();
    public abstract Task<T> GetAsync(object[] keys, CancellationToken cancellationToken = default);
    public abstract Task<T> DeleteAsync(object[] keys, CancellationToken cancellationToken = default);
    public abstract Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default);
    public abstract Task<T> UpdateAsync(object[] keys, Action<T> configure, CancellationToken cancellationToken = default);
    public abstract IRepositoryBatchContext<T> CreateBatchContext();
    public abstract Task<int> DeleteAsync(Expression<Func<T, bool>> predicate);
    public abstract Task<int> UpdateAsync(Expression<Func<T, bool>> predicate);
    public abstract Task<int> ExecuteAsync(string operationName, object[]? args = default, CancellationToken cancellationToken = default);


    #region Implicit Implementations
    async Task<Entity> IRepository.CreateAsync(object entity, CancellationToken cancellationToken = default)
    {
        return await CreateAsync((T)entity, cancellationToken).ConfigureAwait(false);
    }
    async Task<Entity> IRepository.UpdateAsync(object[] keys, Action<Entity> context, CancellationToken cancellationToken = default)
    {
        return await UpdateAsync(keys, (Action<T>)context, cancellationToken).ConfigureAwait(false);
    }
    async Task<Entity> IRepository.DeleteAsync(object[] keys, CancellationToken cancellationToken)
    {
        return await DeleteAsync(keys, cancellationToken).ConfigureAwait(false);
    }
    async Task<Entity> IRepository.GetAsync(object[] keys, CancellationToken cancellationToken)
    {
       return await GetAsync(keys, cancellationToken).ConfigureAwait(false);
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    #endregion
}
