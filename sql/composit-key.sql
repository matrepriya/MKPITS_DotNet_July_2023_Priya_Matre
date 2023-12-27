create table student (rollnumber int, 
                      name varchar(30),
					  class varchar(40),
					  section varchar (1),
					  mobile varchar(10));
insert into student (rollnumber,name,class,section,mobile)values
                    (1,'priya','dotnet','i','1234567'),
					(2,'piya','java','j','12346'),
					(3,'pink','python','k','12345'),
					(4,'payal','developer','p','12345');
select * from student