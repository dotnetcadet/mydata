SET IDENTITY_INSERT [core].[CountriesRegions] ON;
BEGIN TRY
MERGE INTO [core].[CountriesRegions] AS [target]
USING (
    VALUES
    (1, N'Africa'),
    (2, N'Americas'),
    (3, N'Asia'),
    (4, N'Europe'),
    (5, N'Oceania'),
    (6, N'Polar')
    ) AS [source] (
        Id, 
        Name
    )
    ON [target].[Id] = [source].[Id]
WHEN MATCHED
    THEN
        UPDATE
        SET Name = [source].[Name]
WHEN NOT MATCHED BY TARGET
    THEN
        INSERT ([Id], [Name])
        VALUES ([Id], [Name])
OUTPUT $action
INTO @Changes;
END TRY
BEGIN CATCH
    PRINT N'Regions was unable to be updated'
END CATCH
SET IDENTITY_INSERT [core].[CountriesRegions] OFF;