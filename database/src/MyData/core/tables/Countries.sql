CREATE TABLE [core].[Countries]
(
  [Id]                INT NOT NULL IDENTITY(1,1),
  [Name]              NVARCHAR(100) NOT NULL,
  [Code]              NCHAR(3) NULL,
  [ISO2]              NCHAR(2) NULL,
  [ISO3]              NCHAR(3) NULL,
  [Capital]           NVARCHAR(255) NULL,
  -- [Currency]          NVARCHAR(255) NULL,
  -- [CurrencyName]      NVARCHAR(255) NULL,
  -- [CurrencySymbol]    NVARCHAR(255) NULL,
  [RegionId]          INT NULL,
  [SubregionId]       INT NULL,
  [ReferenceSource]   VARCHAR(MAX) NULL,
  [ReferenceLink]     VARCHAR(1000) NULL,
  [ReferenceType]     VARCHAR(55) NULL,

  CONSTRAINT [PrimaryKeyCountries] PRIMARY KEY ([Id]),
  CONSTRAINT [ForeignKeyCountriesToCountriesRegions] FOREIGN KEY ([RegionId]) REFERENCES [core].[CountriesRegions]([Id]),
  CONSTRAINT [ForeignKeyCountriesToCountriesSubregions] FOREIGN KEY ([SubregionId]) REFERENCES [core].[CountriesSubregions]([Id])
)
