CREATE TABLE [core].[CountriesSubregions]
(
  [Id]                INT NOT NULL IDENTITY(1,1),
  [Name]              NVARCHAR(100) NOT NULL,
  [RegionId]          INT NOT NULL,
  [ReferenceSource]   VARCHAR(MAX) NULL,
  [ReferenceLink]     VARCHAR(1000) NULL,
  [ReferenceType]     VARCHAR(55) NULL,

  CONSTRAINT [PrimaryKeyCountriesSubregions] PRIMARY KEY ([Id]),
  CONSTRAINT [ForeignKeyCountriesSubregionsToCountriesRegions] FOREIGN KEY ([RegionId]) REFERENCES [core].[CountriesRegions]([Id])
)
