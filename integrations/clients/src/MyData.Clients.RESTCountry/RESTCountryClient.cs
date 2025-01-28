using MyData.Clients.RESTCountry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyData.Clients.RESTCountry;

public class RESTCountryClient : IRESTCountryClient
{
    public RESTCountryClient(RESTCountryClientOptions options, HttpClient client)
    {
        Endpoint = options.Endpoint;
        Version = options.Version;
        Client = client;
    }

    public string Name => nameof(RESTCountryClient);
    public Uri Endpoint { get; }
    public Version Version { get;}
    public HttpClient Client { get; }

    public void Dispose()
    {
        Client.Dispose();
    }

    public Task<RESTCountryClientResponse<IEnumerable<Country>>> GetAllCountriesAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<IEnumerable<Country>>(new RESTCountryClientRequest()
        {
            Path = "all",
            Version = Version.ToString(),
            Endpoint = Endpoint.ToString().TrimEnd('/')

        }, cancellationToken);
    }

    async Task<RESTCountryClientResponse<T>> SendAsync<T>(RESTCountryClientRequest request, CancellationToken cancellationToken = default)
    {
        var response = await Client.SendAsync(new HttpRequestMessage()
        {
            RequestUri = request.Uri,
            Method = HttpMethod.Get
        }, cancellationToken);

        if (!response.IsSuccessStatusCode)
        {

        }

        using (var stream = await response.Content.ReadAsStreamAsync())
        {
            var data = await JsonSerializer.DeserializeAsync<T>(
                stream, 
                cancellationToken: cancellationToken);

            return new() { Data = data! };
        }
    }
    async Task<IClientResponse> IClient.SendAsync(IClientRequest request, CancellationToken cancellationToken = default)
    {
        if (request is not RESTCountryClientRequest)
        {
            throw new Exception();
        }


        throw new NotImplementedException();
    }
}
