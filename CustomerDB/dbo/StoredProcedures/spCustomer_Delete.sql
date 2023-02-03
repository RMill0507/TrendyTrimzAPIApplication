CREATE PROCEDURE [dbo].[spCustomer_Delete]
	@Id int
AS
begin
	delete
	from dbo.[Customer]
	where Id = @Id;
end