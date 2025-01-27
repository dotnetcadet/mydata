SET IDENTITY_INSERT [core].[Regions] ON;

INSERT INTO [core].[Regions] 
(
    [Id], 
    [Name]
) 
VALUES
    (1, N'Africa'),
    (2, N'Americas'),
    (3, N'Asia'),
    (4, N'Europe'),
    (5, N'Oceania'),
    (6, N'Polar')

SET IDENTITY_INSERT [core].[Regions] OFF;