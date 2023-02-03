if not exists (select 1 from dbo.[Customer])
begin
	insert into dbo.[Customer] (FirstName, LastName, ChildsName, ChildsAge, HairCutStyle)
	values ('Robert','Miller', 'Robby', 4, 'fade with scissor cut on top'),
	('Grace', 'Potter', 'Vincent', 2, 'Scissor cut trim all around'),
	('John', 'Doe', 'James', 3, '1 on sides, mohawk on top'),
	('Jane', 'Doe', 'Timmy', 12, 'bald fade');
	end