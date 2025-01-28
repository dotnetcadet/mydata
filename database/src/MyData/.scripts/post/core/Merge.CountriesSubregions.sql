SET IDENTITY_INSERT [core].[CountriesSubregions] ON;
BEGIN TRY
MERGE INTO [core].[CountriesSubregions] AS [target]
USING (
    VALUES
    (1, 1, N'Northern Africa'),
    (2, 1, N'Middle Africa'),
    (3, 1, N'Western Africa'),
    (4, 1, N'Eastern Africa'),
    (5, 1, N'Southern Africa'),
    (6, 2, N'Northern America'),
    (7, 2, N'Caribbean'),
    (8, 2, N'South America'),
    (9, 2, N'Central America'),
    (10, 3, N'Central Asia'),
    (11, 3, N'Western Asia'),
    (12, 3, N'Eastern Asia'),
    (13, 3, N'South-Eastern Asia'),
    (14, 3, N'Southern Asia'),
    (15, 4, N'Eastern Europe'),
    (16, 4, N'Southern Europe'),
    (17, 4, N'Western Europe'),
    (18, 4, N'Northern Europe'),
    (19, 5, N'Australia and New Zealand'),
    (20, 5, N'Melanesia'),
    (21, 5, N'Micronesia'),
    (22, 5, N'Polynesia')
    ) AS [Source] (
        Id,
        RegionId,
        Name
    )
    ON [target].[Id] = [source].[Id] 
WHEN MATCHED
    THEN
        UPDATE
        SET Name = [source].[Name], RegionId = [source].[RegionId]
WHEN NOT MATCHED BY TARGET
    THEN
        INSERT ([Id], [RegionId], [Name])
        VALUES ([Id], [RegionId], [Name])
OUTPUT $action
INTO @Changes;
END TRY
BEGIN CATCH
    PRINT N'Subregions was unable to be updated'
END CATCH
SET IDENTITY_INSERT [core].[CountriesSubregions] OFF;