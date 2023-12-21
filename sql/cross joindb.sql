create table student (id int, firstname varchar(50),lastname varchar(50),amountpaid int)
 insert into student (id,firstname,lastname,amountpaid)values
                     (123,'priya','Matre',2000)
create table fee (id int , firstname varchar(50), lastname varchar (50),amountpaid int)
insert into student (id,firstname,lastname,amountpaid)values
                     (123,'pooja','kale',4000)

	select *from student
	cross join fee
	where student. firstname = student.firstname;



 