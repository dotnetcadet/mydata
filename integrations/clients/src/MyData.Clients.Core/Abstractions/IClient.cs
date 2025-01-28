using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyData.Clients;

public interface IClient : IDisposable
{
    /// <summary>
    ///
    /// </summary>
    string Name { get; }

    /// <summary>
    /// 
    /// </summary>
    Uri Endpoint { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<IClientResponse> SendAsync(IClientRequest request, CancellationToken cancellationToken = default);
}