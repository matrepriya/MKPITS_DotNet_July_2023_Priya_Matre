create table person (personid int identity primary key,
                    first_name varchar (20),
					last_name varchar(20),
					email varchar(100));
insert into person (personid, first_name,last_name,email)values
                   ('priya','matre','matrepr@gmail'),
				   ('nilesh','wamkhade','wankdeniles@gmai'),
				   ('pratish','lande','pratilan@gmail'),
				   ('senepati','kale','senepati@gmail')
select * from person