CREATE TABLE [core].[Industries]
(
  [Id]                INT NOT NULL,
  [Name]              VARCHAR(255) NOT NULL,
  [ReferenceSource]   VARCHAR(MAX) NULL,
  [ReferenceLink]     VARCHAR(1000) NULL,
  [ReferenceType]     VARCHAR(55) NULL,
  
  CONSTRAINT [PrimaryKeyIndustries] PRIMARY KEY ([Id])
)
