﻿CREATE PROCEDURE [dbo].[spCustomer_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@ChildsName nvarchar(50),
	@ChildsAge int,
	@HairCutStyle nvarchar(max),
	@PhoneNumber nvarchar(50)
 AS 
 begin 
	insert into dbo.[Customer] (FirstName, LastName, ChildsName, ChildsAge, HairCutStyle, PhoneNumber)
	values (@FirstName, @LastName, @ChildsName, @ChildsAge, @HairCutStyle, @PhoneNumber);
end
