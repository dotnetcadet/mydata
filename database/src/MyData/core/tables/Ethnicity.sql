CREATE TABLE [core].[Ethnicity]
(
  [Id]                INT NOT NULL IDENTITY(1,1),
  [Name]              VARCHAR(255) NOT NULL,
  [ReferenceSource]   VARCHAR(MAX) NULL,
  [ReferenceLink]     VARCHAR(1000) NULL,
  [ReferenceType]     VARCHAR(55) NULL,

  CONSTRAINT [PrimaryKeyEthnicity] PRIMARY KEY ([Id])
)
