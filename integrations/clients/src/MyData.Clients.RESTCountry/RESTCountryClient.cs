using System;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using static System.Text.Json.JsonSerializer;

namespace MyData.Clients.RESTCountry;

public class RESTCountryClient : Client, IRESTCountryClient
{
    RESTCountryClient(RESTCountryClientOptions options, HttpClient httpClient) : base(httpClient)
    {
        Endpoint = options.Endpoint;
        Version = options.Version;
    }

    public override string Name => nameof(RESTCountryClient);
    public override Uri Endpoint { get; }
    public Version Version { get;}

    async Task<Either<ClientSuccessCollection<RESTCountry>, ClientError>> IRESTCountryClient.GetAllCountriesAsync(CancellationToken cancellationToken)
    {
        var request = new ClientRequest(Endpoint)
        {
            Method = ClientRequestMethod.Get,
            Path = $"v{Version}/all"
        };

        var response = await this.SendEitherAsync(request, cancellationToken);

        if (response.If(out ClientError error, out ClientSuccess success))
        {
            return error;
        }
        else
        {
            var stream = success.Body;
            var data = await DeserializeAsync<IList<RESTCountry>>(stream);

            var collection = new ClientSuccessCollection<RESTCountry>(data!)
            {
                StatusCode = success.StatusCode,
                Body = stream
            };

            collection.Meta.Add("Source", $"GET {request.Uri}");

            return collection;
        }
    }

    #region Helpers

    public static IRESTCountryClient Create(HttpClient client)
    {
        return new RESTCountryClient(new(), client);
    }

    public static IRESTCountryClient Create(HttpClient client, Action<RESTCountryClientOptions> configure)
    {
        var options = new RESTCountryClientOptions();

        configure.Invoke(options);

        return new RESTCountryClient(options, client);
    }

    #endregion
}
