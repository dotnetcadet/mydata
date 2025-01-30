using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyData.Clients.UsCensus;

public interface IUsDecennialCensusDemographicProfileRequestBuilder
{
    IUsDecennialCensusDemographicProfileRequestBuilder IncludeSexAndAgeCount();
    IUsDecennialCensusDemographicProfileRequestBuilder IncludeSexAndAgePercentage();
    IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialCountTotal(); // DP1_0076C
    IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialCountByWhite(); // DP1_0078C
    IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialCountByAffricanAmerican(); // DP1_0079C
    IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialCountByAmericanIndianAndAlaskaNative(); // DP1_0080C
    IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialCountByAsian(); //DP1_0081C
    IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialCountByNativeHawaiianAndOtherPacificIslander(); // DP1_0082C
    IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialCountByOtherRace(); // DP1_0083C

    IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialPercentagesTotal(); // DP1_0076P
    IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialPercentagesByWhite(); // DP1_0078P
    IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialPercentagesByAffricanAmerican(); // DP1_0079P
    IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialPercentagesByAmericanIndianAndAlaskaNative(); // DP1_0080P
    IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialPercentagesByAsian(); //DP1_0081P
    IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialPercentagesByNativeHawaiianAndOtherPacificIslander(); // DP1_0082P
    IUsDecennialCensusDemographicProfileRequestBuilder IncludeRacialPercentagesByOtherRace(); // DP1_0083P



    Task<Either<ClientSuccessObject<UsCensusDataTable>, ClientError>> GetByStateAsync(CancellationToken cancellationToken = default);
    Task<Either<ClientSuccessObject<UsCensusDataTable>, ClientError>> GetByCountryAsync(CancellationToken cancellationToken = default);
}
