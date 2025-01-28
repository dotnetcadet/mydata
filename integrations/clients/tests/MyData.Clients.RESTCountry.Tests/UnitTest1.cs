namespace MyData.Clients.RESTCountry.Tests;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        using var httpClient = new HttpClient();
        using var client = new RESTCountryClient(new(), httpClient);

        var response = await client.GetAllCountriesAsync();
    }
}
