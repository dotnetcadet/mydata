namespace MyData.Clients.UsCensus.IntgTests;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        var client = UsCensusClient.Create(new HttpClient(), options =>
        {

        });


        var table = await client.UseDecennialCensus(UsCensusYear.Y2020)
            .WithDemographicProfile()
            .IncludeRacialCountByAffricanAmerican()
            .IncludeRacialPercentagesByAffricanAmerican()
            .GetByStateAsync();
    }
}
