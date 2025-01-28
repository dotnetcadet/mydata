CREATE TABLE [core].[CountriesSubregions]
(
  [Id]                INT IDENTITY(1,1) NOT NULL,
  [Name]              NVARCHAR(100) NOT NULL,
  [RegionId]          INT NOT NULL,
  [ReferenceSource]   NVARCHAR(MAX) NULL,
  [ReferenceLink]     NVARCHAR(1000) NULL,

  CONSTRAINT [PrimaryKeyCountriesSubregions] PRIMARY KEY ([Id]),
  CONSTRAINT [ForeignKeyCountriesSubregionsToCountriesRegions] FOREIGN KEY ([RegionId]) REFERENCES [core].[CountriesRegions]([Id])
)
