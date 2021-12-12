CREATE TABLE [dbo].[Staff]
(
	[ Staff ID] INT NOT NULL PRIMARY KEY, 
    [First Name] NCHAR(20) NOT NULL, 
    [Last Name] NCHAR(20) NOT NULL, 
    [Username] NVARCHAR(50) NOT NULL, 
    [password] TEXT NOT NULL
)
