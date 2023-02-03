CREATE PROCEDURE [dbo].[spCustomer_GetAll]
AS
begin
	select Id, FirstName, LastName, ChildsName, ChildsAge, HairCutStyle
	from dbo.[Customer];
end