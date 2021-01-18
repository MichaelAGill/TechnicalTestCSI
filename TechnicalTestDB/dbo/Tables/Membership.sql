CREATE TABLE [dbo].[Membership]
(
	[MembershipID] NVARCHAR(MAX) NOT NULL , 
    [MembershipType] NCHAR(10) NOT NULL, 
    [Discount] TINYINT NOT NULL, 
    [Balance] FLOAT NOT NULL, 
    PRIMARY KEY ([MembershipID]) 
)
