CREATE PROCEDURE [dbo].[spCustomer_Update]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@ChildsName nvarchar(50),
	@ChildsAge int,
	@HairCutStyle nvarchar(max),
	@PhoneNumber nvarchar(50)
AS
begin
	update dbo.[Customer]
	set FirstName = @FirstName, LastName = @LastName, @ChildsName = @ChildsName, @ChildsAge = ChildsAge,
	@HairCutStyle = HairCutStyle, @PhoneNumber = PhoneNumber
	where Id = @Id;
end