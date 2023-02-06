CREATE PROCEDURE [dbo].[spCustomer_GetAll]
AS
begin
	select Id, FirstName, LastName, ChildsName, ChildsAge, HairCutStyle, PhoneNumber
	from dbo.[Customer];
end