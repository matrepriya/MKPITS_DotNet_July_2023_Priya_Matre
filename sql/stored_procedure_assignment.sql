create table employees (empid int ,empname varchar(50),empcity varchar(50))
insert into employees  (empid,empname,empcity)values
                      (123 ,'priya','murtizapur'),
					  (321,'sware','pinajare');
 select * from employees
 

 create procedure p2
 as begin
 select * from employees
 end;
 exec p2 select count(empid)as "total employee employee count"from employees