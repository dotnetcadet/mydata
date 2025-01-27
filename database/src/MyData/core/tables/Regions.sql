CREATE TABLE [core].[Regions]
(
  [Id]          INT IDENTITY(1,1),
  [Name]        NVARCHAR(100)       NOT NULL,
  [CreatedAt]   DATETIME2           NULL,
  [UpdatedAt]   DATETIME2           NOT NULL DEFAULT GETDATE(),

  CONSTRAINT [PrimaryKeyRegions] PRIMARY KEY([Id])
)
