using System;
using System.Text;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MyData.Clients;

using Internal;

[DebuggerDisplay("{Name}: {Endpoint}")]
public abstract class Client : IClient
{
    protected Client(HttpClient httpClient)
    {
        ArgumentNullException.ThrowIfNull(httpClient, nameof(httpClient));

        HttpClient = httpClient;
    }


    protected virtual HttpClient HttpClient { get; }
    public abstract string Name { get; }
    public abstract Uri Endpoint { get; }

    public virtual async Task<IClientResponse> SendAsync(IClientRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            // Build request URI
            Uri uri = default;

            if (request is ClientRequest clientRequest)
            {
                uri = clientRequest.Uri;
            }
            else
            {
                var uriBuilder = new UriBuilder(Endpoint);

                uriBuilder.Path = request.Path;
                uriBuilder.Query = string.Join('&', request.Queries.Select((key, value) => string.Join('=', key, value)));

                uri = uriBuilder.Uri;
            }

            // Create HTTP Request
            var httpRequestMessage = new HttpRequestMessage()
            {
                RequestUri = uri,
                Method = request.Method switch
                {
                    ClientRequestMethod.Get => HttpMethod.Get,
                    ClientRequestMethod.Put => HttpMethod.Put,
                    ClientRequestMethod.Post => HttpMethod.Post,
                    ClientRequestMethod.Patch => HttpMethod.Patch,
                    ClientRequestMethod.Delete => HttpMethod.Delete,

                    _ => throw new ClientException("Invalid 'ClientRequestMethod' was provided.")
                },
            };

            // Apply Headers
            foreach (var (key, value) in request.Headers)
            {
                if (key.Equals("authorization", StringComparison.OrdinalIgnoreCase))
                {
                    var splits = value.Split(' ');
                    var scheme = splits[0];
                    var token = splits[1];

                    httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue(scheme, token);
                }
                else
                {
                    httpRequestMessage.Headers.Add(key, value);
                }
            }

            // Apply Body
            if (request.Body.Length > 0)
            {

                var stream = request.Body;
                var encoding = Encoding.UTF8;
                var buffer = new byte[stream.Length];

                stream.ReadExactly(buffer);

                httpRequestMessage.Content = new StringContent(encoding.GetString(buffer));
            }

            var httpResponseMessage = await HttpClient.SendAsync(httpRequestMessage, cancellationToken);

            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                var content = await httpResponseMessage.Content.ReadAsStringAsync();

                if (string.IsNullOrEmpty(content))
                {
                    return new ClientErrorDefault(
                        "The server returned a error status code.",
                        (int)httpResponseMessage.StatusCode);
                }
                else
                {
                    return new ClientErrorDefault(
                        content, 
                        (int)httpResponseMessage.StatusCode);
                }
            }

            return new ClientSuccessDefault()
            {
                StatusCode = (int)httpResponseMessage.StatusCode,
                Body = await httpResponseMessage.Content.ReadAsStreamAsync(cancellationToken)
            };
        }
        catch (Exception exception)
        {
            throw new ClientException("An unknown error occurred within Client", exception);
        }
    }
    public void Dispose()
    {
        HttpClient.Dispose();
    }
}
