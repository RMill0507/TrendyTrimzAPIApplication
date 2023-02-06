CREATE PROCEDURE [dbo].[spCustomer_Get]
@Id int
AS
begin
	select Id, FirstName, LastName, ChildsName, ChildsAge, HairCutStyle, PhoneNumber
	from dbo.[Customer]
	where Id = @Id;
end