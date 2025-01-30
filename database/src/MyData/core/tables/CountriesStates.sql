CREATE TABLE [core].[CountriesStates]
(
  [Id]                INT NOT NULL IDENTITY(1,1),
  [Name]              NVARCHAR(255) NOT NULL,
  [CountryId]         INT NOT NULL,
  [Code]              NVARCHAR(255) NULL,
  [TypeId]            INT NULL,
  [ReferenceSource]   VARCHAR(MAX) NULL,
  [ReferenceLink]     VARCHAR(1000) NULL,
  [ReferenceType]     VARCHAR(55) NULL,

  CONSTRAINT [PrimaryKeyCountriesStates] PRIMARY KEY ([Id]),
  CONSTRAINT [ForeignKeyCountriesStatesToCountries] FOREIGN KEY ([CountryId]) REFERENCES [core].[Countries]([Id]),
  CONSTRAINT [ForeignKeyCountriesStatesToCountriesStatesTypes] FOREIGN KEY ([TypeId]) REFERENCES [core].[CountriesStatesTypes]([Id])
)
