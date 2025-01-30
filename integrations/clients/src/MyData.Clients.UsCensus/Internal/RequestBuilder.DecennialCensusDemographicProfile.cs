using System;
using System.Threading;
using System.Threading.Tasks;
using static System.Text.Json.JsonSerializer;

namespace MyData.Clients.UsCensus.Internal;

internal class DecennialCensusDemographicProfileRequestBuilder : RequestBuilderBase,
    IUsDecennialCensusDemographicProfileRequestBuilder
{
    public IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialCountTotal() => Include("DP1_0076C", "CountTotal");
    public IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialCountByWhite() => Include("DP1_0078C", "CountByWhite");
    public IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialCountByAffricanAmerican() => Include("DP1_0079C", "CountByAffricanAmerican");
    public IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialCountByAmericanIndianAndAlaskaNative() => Include("DP1_0080C", "CountByAmericanIndianAndAlaskaNative");
    public IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialCountByAsian() => Include("DP1_0081C", "CountByAsian");
    public IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialCountByNativeHawaiianAndOtherPacificIslander() => Include("DP1_0082C", "CountByNativeHawaiianAndOtherPacificIslander");
    public IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialCountByOtherRace() => Include("DP1_0083C", "CountByOtherRace");
    public IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialPercentagesTotal() => Include("DP1_0076P", "PercentagesTotal");
    public IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialPercentagesByWhite() => Include("DP1_0078P", "PercentagesByWhite");
    public IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialPercentagesByAffricanAmerican() => Include("DP1_0079P", "PercentagesByAffricanAmerican");
    public IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialPercentagesByAmericanIndianAndAlaskaNative() => Include("DP1_0080P", "PercentagesByAmericanIndianAndAlaskaNative");
    public IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialPercentagesByAsian() => Include("P1_0081P", "PercentagesByAsian");
    public IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialPercentagesByNativeHawaiianAndOtherPacificIslander() => Include("DP1_0082P", "PercentagesByNativeHawaiianAndOtherPacificIslander");
    public IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialPercentagesByOtherRace() => Include("DP1_0083P", "PercentagesByOtherRace");
    private IUsDecennialCensusDemographicProfileRequestBuilder Include(string value, string? columnName = null)
    {
        Variables.Add(value);

        if (string.IsNullOrEmpty(columnName))
        {
            VariableMaps.Add(value, value);
        }
        else
        {
            VariableMaps.Add(value, columnName);
        }

        return this;
    }

    public async Task<Either<ClientSuccessObject<UsCensusDataTable>, ClientError>> GetByStateAsync(CancellationToken cancellationToken = default)
    {
        Request.Queries.Add("get", string.Join(',', Variables));
        Request.Queries.Add("for", "state:*");

        var response = await Client.SendEitherAsync(Request, cancellationToken);

        if (response.If(out ClientError error, out ClientSuccess success))
        {
            return error;
        }
        else
        {
            var stream = success.Body;
            var data = await DeserializeAsync<UsCensusDataTable>(stream);
            var obj = new ClientSuccessObject<UsCensusDataTable>()
            {
                StatusCode = success.StatusCode,
                Body = stream,
                Data = data
            };

            foreach (var column in data.Columns)
            {
                column.Name = VariableMaps[column.Name];
            }

            obj.Meta.Add("Source", $"GET {Request.Uri}");

            return obj;
        }
    }
    public async Task<Either<ClientSuccessObject<UsCensusDataTable>, ClientError>> GetByCountryAsync(CancellationToken cancellationToken = default)
    {
        Request.Queries.Add("get", string.Join(',', Variables));
        Request.Queries.Add("for", "us:*");

        var response = await Client.SendEitherAsync(Request, cancellationToken);

        if (response.If(out ClientError error, out ClientSuccess success))
        {
            return error;
        }
        else
        {
            var stream = success.Body;
            var data = await DeserializeAsync<UsCensusDataTable>(stream);
            var obj = new ClientSuccessObject<UsCensusDataTable>()
            {
                StatusCode = success.StatusCode,
                Body = stream,
                Data = data
            };

            foreach (var column in data.Columns)
            {
                column.Name = VariableMaps[column.Name];
            }

            obj.Meta.Add("Source", $"GET {Request.Uri}");

            return obj;
        }
    }


}
