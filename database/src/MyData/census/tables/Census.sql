CREATE TABLE [census].[Census]
(
  [CountryId]         INT NOT NULL,
  [Year]              INT NOT NULL,
  [Population]        BIGINT NOT NULL,
  [ReferenceSource]   NVARCHAR(MAX) NULL,
  [ReferenceLink]     NVARCHAR(1000) NULL,
)
