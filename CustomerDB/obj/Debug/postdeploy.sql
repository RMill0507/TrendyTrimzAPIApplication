if not exists (select 1 from dbo.[Customer])
begin
	insert into dbo.[Customer] (FirstName, LastName, ChildsName, ChildsAge, HairCutStyle, PhoneNumber)
	values ('Robert','Miller', 'Robby', 4, 'fade with scissor cut on top', '123-456-7890'),
	('Grace', 'Potter', 'Vincent', 2, 'Scissor cut trim all around', '123-456-7890'),
	('John', 'Doe', 'James', 3, '1 on sides, mohawk on top', '123-456-7890'),
	('Jane', 'Doe', 'Timmy', 12, 'bald fade', '123-456-7890');
	end
GO
