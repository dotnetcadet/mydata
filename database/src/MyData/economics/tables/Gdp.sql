CREATE TABLE [economics].[Gdp]
(
  [CountryId]         INT NOT NULL,
  [Year]              INT NOT NULL,
  [Quarter]           INT NOT NULL,
  [Percentage]        FLOAT NOT NULL,
  [ReferenceSource]   VARCHAR(MAX) NULL,
  [ReferenceLink]     VARCHAR(1000) NULL,
  [ReferenceType]     VARCHAR(55) NULL,

  CONSTRAINT [PrimaryKeyGdp] PRIMARY KEY ([CountryId, Year, Quarter]),
  CONSTRAINT [ForeignKeyGdpToCountries] FOREIGN KEY ([CountryId]) REFERENCE [core].[Countries]([Id]),
  CONSTRAINT [CheckGdpQuarter] CHECK (
    Quarter = 1 OR
    Quarter = 2 OR
    Quarter = 3 OR
    Quarter = 4
  )
)
