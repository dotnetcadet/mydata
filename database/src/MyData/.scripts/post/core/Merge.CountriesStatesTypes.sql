SET IDENTITY_INSERT [core].[CountriesStatesTypes] ON;
BEGIN TRY
MERGE INTO [core].[CountriesStatesTypes] AS [target]
USING (
    VALUES
    (1, N'region'),
    (2, N'administration'),
    (3, N'municipality'),
    (4, N'local council'),
    (5, N'province'),
    (6, N'capital city'),
    (7, N'county'),
    (8, N'district'),
    (9, N'city'),
    (10, N'special municipality'),
    (11, N'state'),
    (12, N'capital territory'),
    (13, N'commune'),
    (14, N'canton'),
    (15, N'entity'),
    (16, N'parish'),
    (17, N'autonomous republic'),
    (18, N'division'),
    (19, N'prefecture'),
    (20, N'territory'),
    (21, N'area'),
    (22, N'department'),
    (23, N'autonomous region'),
    (24, N'governorate'),
    (25, N'arctic region'),
    (26, N'city with county rights'),
    (27, N'economic prefecture'),
    (28, N'indigenous region'),
    (29, N'islands / groups of islands'),
    (30, N'outlying area'),
    (31, N'district municipality'),
    (32, N'voivodship'),
    (33, N'free municipal consortium'),
    (34, N'decentralized regional entity'),
    (35, N'capital district'),
    (36, N'Special region'),
    (37, N'island'),
    (38, N'administrative territory'),
    (39, N'administrative region'),
    (40, N'autonomous city'),
    (41, N'autonomous district'),
    (42, N'republic'),
    (43, N'dependency'),
    (44, N'federal territory'),
    (45, N'federal district'),
    (46, N'federal dependency'),
    (47, N'regional unit'),
    (48, N'union territory'),
    (49, N'special administrative region'),
    (50, N'unitary authority'),
    (51, N'metropolitan district'),
    (52, N'london borough'),
    (53, N'two-tier county'),
    (54, N'council area'),
    (55, N'district council'),
    (56, N'borough council'),
    (57, N'country'),
    (58, N'city corporation'),
    (59, N'chain'),
    (60, N'administrative atoll'),
    (61, N'oblast'),
    (62, N'popularate'),
    (63, N'geographical region'),
    (64, N'land'),
    (65, N'federal capital territory'),
    (66, N'administered area'),
    (67, N'borough'),
    (68, N'emirate'),
    (69, N'districts under republic administration'),
    (70, N'metropolitan administration'),
    (71, N'metropolitan city'),
    (72, N'special city'),
    (73, N'special self-governing province'),
    (74, N'special self-governing city'),
    (75, N'island council'),
    (76, N'town council'),
    (77, N'autonomous municipality'),
    (78, N'special island authority'),
    (79, N'urban municipality'),
    (80, N'autonomous territorial unit'),
    (81, N'territorial unit'),
    (82, N'state city'),
    (83, N'overseas collectivity'),
    (84, N'metropolitan region'),
    (85, N'overseas region'),
    (86, N'metropolitan collectivity with special status'),
    (87, N'European collectivity'),
    (88, N'quarter'),
    (89, N'metropolitan department'),
    (90, N'overseas territory'),
    (91, N'municipalities'),
    (92, N'capital'),
    (93, N'autonomous community'),
    (94, N'autonomous city in North Africa'),
    (96, N'village'),
    (97, N'sheadings')
    ) AS [source] (
        Id, 
        Type
    )
    ON [target].[Id] = [source].[Id]
WHEN MATCHED
    THEN
        UPDATE
        SET Type = [source].[Type]
WHEN NOT MATCHED BY TARGET
    THEN
        INSERT ([Id], [Type])
        VALUES ([Id], [Type])
OUTPUT $action
INTO @Changes;
END TRY
BEGIN CATCH
    PRINT N'Regions was unable to be updated'
END CATCH
SET IDENTITY_INSERT [core].[CountriesStatesTypes] OFF;