CREATE TABLE [core].[TimeZones]
(
  [Id]                INT NOT NULL,
  [Name]              NVARCHAR(255) NOT NULL,
  [ReferenceSource]   VARCHAR(MAX) NULL,
  [ReferenceLink]     VARCHAR(1000) NULL,
  [ReferenceType]     VARCHAR(55) NULL,

  CONSTRAINT [PrimaryKeyTimeZones] PRIMARY KEY ([Id])
)
