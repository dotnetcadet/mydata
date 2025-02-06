SET IDENTITY_INSERT [core].[Ethnicity] ON;
BEGIN TRY
MERGE INTO [core].[Ethnicity] AS [target]
USING (
    VALUES
    (1, N'White', 'Internal', 'Script'),
    (2, N'Black', 'Internal', 'Script'),
    (3, N'Asian', 'Internal', 'Script'),
    (4, N'AmericanIndianOrAlaskan', 'Internal', 'Script'),
    (5, N'NativeHawaiianOrPacificIslander', 'Internal', 'Script')
    ) AS [source] (
        Id, 
        Name,
        ReferenceSource,
        ReferenceType
    )
    ON [target].[Id] = [source].[Id]
WHEN MATCHED
    THEN
        UPDATE
        SET 
            Name = [source].[Name],
            ReferenceSource = [source].[ReferenceSource],
            ReferenceType = [source].[ReferenceType]
WHEN NOT MATCHED BY TARGET
    THEN
        INSERT ([Id], [Name], [ReferenceSource], [ReferenceType])
        VALUES ([Id], [Name], [ReferenceSource], [ReferenceType])
OUTPUT $action
INTO @Changes;
END TRY
BEGIN CATCH
    PRINT N'Ethnicity was unable to be updated'
END CATCH
SET IDENTITY_INSERT [core].[Ethnicity] OFF;