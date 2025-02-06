CREATE TABLE [dbo].[GdpByState]
(
  [StateId]           INT NOT NULL,
  [Year]              INT NOT NULL,
  [Quarter]           INT NOT NULL,
  [Percentage]        FLOAT NOT NULL,
  [ReferenceSource]   VARCHAR(MAX) NULL,
  [ReferenceLink]     VARCHAR(1000) NULL,
  [ReferenceType]     VARCHAR(55) NULL,

  CONSTRAINT [PrimaryKeyGdpByState] PRIMARY KEY ([StateId, Year, Quarter]),
  CONSTRAINT [ForeignKeyGdpToCountriesStates] FOREIGN KEY ([StateId]) REFERENCE [core].[CountriesStates]([Id]),
  CONSTRAINT [CheckGdpQuarter] CHECK (
    Quarter = 1 OR
    Quarter = 2 OR
    Quarter = 3 OR
    Quarter = 4
  )
)
