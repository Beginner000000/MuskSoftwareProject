CREATE TABLE [dbo].[Report]
(
	[Date] DATETIME NOT NULL PRIMARY KEY, 
    [Report Description] TEXT NOT NULL, 
    [Incident Level] TEXT NOT NULL, 
    [Comments] TEXT NOT NULL
)
