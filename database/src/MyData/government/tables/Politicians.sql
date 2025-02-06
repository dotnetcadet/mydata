CREATE TABLE [government].[Politicians]
(
  [Id]          INT NOT NULL PRIMARY KEY,
  [Surname]     NVARCHAR(255) NOT NULL,
  [GivenName]   NVARCHAR(255) NOT NULL,
  [Suffix]      NVARCHAR(55),
  [Birthdate]   DATETIME2,
)
