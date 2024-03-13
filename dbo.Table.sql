CREATE TABLE [dbo].[user]
(
	[username] VARCHAR(MAX) NOT NULL PRIMARY KEY, 
    [email] VARCHAR(MAX) NOT NULL, 
    [password] VARCHAR(MAX) NOT NULL, 
    [name] VARCHAR(MAX) NOT NULL
)
