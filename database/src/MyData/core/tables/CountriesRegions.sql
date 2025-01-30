CREATE TABLE [core].[CountriesRegions]
(
  [Id]                INT NOT NULL IDENTITY(1,1),
  [Name]              NVARCHAR(100) NOT NULL,
  [ReferenceSource]   VARCHAR(MAX) NULL,
  [ReferenceLink]     VARCHAR(1000) NULL,
  [ReferenceType]     VARCHAR(55) NULL,

  CONSTRAINT [PrimaryKeyRegions]    PRIMARY KEY([Id]),
  CONSTRAINT [UniqueRegionName]     UNIQUE ([Name])
)
