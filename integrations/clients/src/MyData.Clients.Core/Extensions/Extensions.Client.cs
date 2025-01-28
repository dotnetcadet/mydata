using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyData.Clients;

using Internal;

public static class ClientExtensions
{
    public static async Task<Either<ClientSuccess, ClientError>> SendEitherAsync(
        this Client client,
        IClientRequest request,
        CancellationToken cancellationToken = default) => (await client.SendAsync(request)) switch
        {
            ClientSuccessDefault success => success,
            ClientError error => error,

            _ => throw new Exception()
        };
}
