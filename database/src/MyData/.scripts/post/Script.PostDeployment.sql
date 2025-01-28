DECLARE @Changes TABLE (
    Change VARCHAR(20)
);

:r .\core\Merge.Countries.sql
:r .\core\Merge.CountriesRegions.sql
:r .\core\Merge.CountriesSubregions.sql
:r .\core\Merge.CountriesStates.sql
:r .\core\Merge.CountriesStatesTypes.sql