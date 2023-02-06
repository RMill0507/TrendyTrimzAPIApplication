CREATE TABLE [dbo].[Customer]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [ChildsName] NVARCHAR(50) NOT NULL, 
    [ChildsAge] INT NOT NULL, 
    [HairCutStyle] NVARCHAR(MAX) NOT NULL, 
    [PhoneNumber] NVARCHAR(50) NOT NULL
)
