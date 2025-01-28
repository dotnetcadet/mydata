CREATE TABLE [core].[CountriesStatesTypes]
(
  [Id]                INT NOT NULL IDENTITY(1,1),
  [Type]              NVARCHAR(100) NOT NULL,
  [ReferenceSource]   NVARCHAR(MAX) NULL,
  [ReferenceLink]     NVARCHAR(1000) NULL,

  CONSTRAINT [PrimaryKeyCountriesStatesTypes] PRIMARY KEY ([Id])
)
