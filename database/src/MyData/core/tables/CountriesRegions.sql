CREATE TABLE [core].[CountriesRegions]
(
  [Id]                INT IDENTITY(1,1) NOT NULL,
  [Name]              NVARCHAR(100) NOT NULL,
  [ReferenceSource]   NVARCHAR(MAX) NULL,
  [ReferenceLink]     NVARCHAR(1000) NULL,

  CONSTRAINT [PrimaryKeyRegions]    PRIMARY KEY([Id]),
  CONSTRAINT [UniqueRegionName]     UNIQUE ([Name])
)
