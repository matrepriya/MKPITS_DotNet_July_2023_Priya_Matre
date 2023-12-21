create table student (studentid int primary key,
                       admission_no int  not null,
                       first_name varchar (45) not null,
                       last_name varchar(45) not null,
                        age int,
                        city varchar (45) not null)
   
insert into student values(3353, 123,'vrushali','mohod',20,'nagpur')
insert into student values(3354, 123,'mayuri','kale',23,'mumbai')
insert into student values(3456,456,'priya ','matre',25,'pune')
select * from student

select * from fee4

drop table student

create table fee4 (admission_no int null,
                 course varchar(45)not null,
				 amount_paid int not null)
insert into fee4 values (3354,'java',2000)
insert into fee4 values	(3353,'dotnet',3000)
select * from student inner join fee4 on student.admission_no = fee4.admission_no
drop table fee4
