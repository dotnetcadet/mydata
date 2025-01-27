using System.Threading;
using System.Threading.Tasks;

namespace MyData.Databases;

public interface IBulkOperation
{
    /// <summary>
    /// The name of the operation to be executed
    /// </summary>
    string Name { get; }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    Task<int> InvokeAsync(object[]? args = default, CancellationToken cancellationToken = default);
}
