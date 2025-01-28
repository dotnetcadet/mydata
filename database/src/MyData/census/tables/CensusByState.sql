CREATE TABLE [census].[CensusByState]
(
  [Year]                INT NOT NULL,
  [StateId]             INT NOT NULL,
  [Population]          BIGINT NOT NULL,
  [ReferenceSource]     NVARCHAR(MAX) NULL,
  [ReferenceLink]       NVARCHAR(1000) NULL,
  
  CONSTRAINT [PrimaryKeyCensusByState] PRIMARY KEY ([StateId], [Year]),
  CONSTRAINT [ForeignKeyCensusByStateToStates] FOREIGN KEY ([StateId]) REFERENCES [core].[CountriesStates]([Id])
)
