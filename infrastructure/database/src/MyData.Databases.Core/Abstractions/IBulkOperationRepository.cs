using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace MyData.Databases;

/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IBulkOperationRepository<T> : IRepository<T>
    where T : Entity<T>, new()
{
    /// <summary>
    /// Represents a delete operation with a predicate
    /// </summary>
    /// <param name="predicate"></param>
    /// <returns></returns>
    Task<int> DeleteAsync(Expression<Func<T, bool>> predicate);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="predicate"></param>
    /// <returns></returns>
    Task<int> UpdateAsync(Expression<Func<T, bool>> predicate);
    /// <summary>
    /// Executes a named operation to be performed on the data layer.
    /// </summary>
    /// <param name="operationName"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<int> ExecuteAsync(string operationName, object[]? arguments = default, CancellationToken cancellationToken = default);
}
