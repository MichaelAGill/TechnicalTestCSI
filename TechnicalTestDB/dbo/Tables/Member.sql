CREATE TABLE [dbo].[Member]
(
    [MemberID] NVARCHAR(MAX) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [EmailAddress] NVARCHAR(MAX) NOT NULL, 
    PRIMARY KEY ([MemberID]) 
)
