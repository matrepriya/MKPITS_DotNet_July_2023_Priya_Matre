create table student (rollno int , firstname varchar(100), lastname varchar (100),city varchar (100), state varchar(100))
insert into student values (2,'mayuri', 'kale', 'Nagpur','mah')
insert into student values (2,'prajact', 'matre', 'murtizapur','m.p')
insert into student values (3,'pooja', 'sangole', 'bander','mah')
insert into student values (4,'vrushali', 'mohod', 'akola','m.p')
insert into student values (5,'nikita', 'bharshake', 'panjare','mah')
insert into student values (6,'suwarana', 'matre', 'akola','m.p')
Select  ,COUNT (*) from student where city ='Nagpur' group by