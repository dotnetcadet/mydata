namespace MyData.Clients.RESTCountry.Tests;

using Models;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        using var httpClient = new HttpClient();
        using var client = RESTCountryClient.Create(httpClient);

        var response = await client.GetAllCountriesAsync();

        if (response.If(out ClientError error, out ClientSuccessCollection<RESTCountry> success))
        {

        }
        else
        {
            var data = success.Data;
            
            data.First().
        }


    }
}
