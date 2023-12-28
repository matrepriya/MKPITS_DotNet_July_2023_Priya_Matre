create table teachers (teacher_id int primary key,
                       teacher_name varchar(20),
					   country varchar (20),
					   city varchar (20),
					   state varchar(20))
insert into teachers (teacher_id,teacher_name,country,city,state)values
                     (11,'pragati','india','nagpur','maharaste'),
					 (13,'pooja','india','mumbai','maharastre'),
					 (14,'pinky','india','nagpur','maharastre'),
					 (15,'payal','india','nagpur','maharstre'),
					 (16,'pinku','india','delhi','maharastre')


select * from teachers