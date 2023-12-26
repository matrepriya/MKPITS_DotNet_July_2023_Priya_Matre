create table departments(departmentid int, departmentname varchar (50),departmentcity varchar(50))
insert into departments (departmentid,departmentname,departmentcity)values
                       (123,'cs','akola'),
					   (111,'it','mumbai'),
					   (124,'ext','ahmedbad');
select * from departments

create procedure p3(@id as int)
as begin
select * from departments where departmentid = @id
end;
exec p3 123 
drop table departments
