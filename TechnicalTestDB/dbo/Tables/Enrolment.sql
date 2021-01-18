CREATE TABLE [dbo].[Enrolment]
(
	[EnrolmentID] NVARCHAR(MAX) NOT NULL PRIMARY KEY, 
    [MemberID] NVARCHAR(MAX) NOT NULL, 
    [MembershipID] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [FK_Enrolment_Member] FOREIGN KEY ([MemberID]) REFERENCES [Member]([MemberID]),
    CONSTRAINT [FK_Enrolment_Membership] FOREIGN KEY ([MembershipID]) REFERENCES [Membership]([MembershipID])
)
