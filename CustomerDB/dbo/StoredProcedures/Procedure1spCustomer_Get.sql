CREATE PROCEDURE [dbo].[spCustomer_Get]
@Id int
AS
begin
	select Id, FirstName, LastName, ChildsName, ChildsAge, HairCutStyle
	from dbo.[Customer]
	where Id = @Id;
end