CREATE TABLE [core].[CountriesStatesTypes]
(
  [Id]                INT NOT NULL IDENTITY(1,1),
  [Type]              NVARCHAR(100) NOT NULL,
  [ReferenceSource]   VARCHAR(MAX) NULL,
  [ReferenceLink]     VARCHAR(1000) NULL,
  [ReferenceType]     VARCHAR(55) NULL,

  CONSTRAINT [PrimaryKeyCountriesStatesTypes] PRIMARY KEY ([Id])
)
