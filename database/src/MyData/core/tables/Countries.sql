CREATE TABLE [core].[Countries]
(
  [Id] INT IDENTITY(1,1) PRIMARY KEY,
  [Name] NVARCHAR(100) NOT NULL,
  [Code] NCHAR(3) NULL,
  [ISO3] NCHAR(3) NULL,
  [ISO2] NCHAR(2) NULL,
  [PhoneCore] NVARCHAR(255) NULL,
  [Capital] NVARCHAR(255) NULL,
  [Currency] NVARCHAR(255) NULL,
  [CurrencyName] NVARCHAR(255) NULL,
  [CurrencySymbol] NVARCHAR(255) NULL,
  tld NVARCHAR(255) NULL,
  native NVARCHAR(255) NULL,
  [RegionId] INT NULL,
  [SubregionId] INT NULL,
  nationality NVARCHAR(255) NULL,
  [Timezones] NVARCHAR(MAX),
  translations NVARCHAR(MAX),
  [Latitude] DECIMAL(10,8) NULL,
  [Longitude] DECIMAL(11,8) NULL,
  emoji NVARCHAR(191) NULL,
  emojiU NVARCHAR(191) NULL,
  [CreatedAt]   DATETIME2           NULL,
  [UpdatedAt]   DATETIME2           NOT NULL DEFAULT GETDATE(),

  CONSTRAINT [ForeignKeyRegions] FOREIGN KEY ([RegionId]) REFERENCES [core].[Regions]([Id]),
  CONSTRAINT [ForeignKeySubRegions] FOREIGN KEY ([SubregionId]) REFERENCES [core].[Subregions]([Id])

)
