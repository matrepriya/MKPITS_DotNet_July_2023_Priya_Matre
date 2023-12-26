create table employees (empname varchar(50),
                       empid int not null
					   )
create table emlog11(logid int identity(1,1)not null,empid int not null,operation nvarchar(10)not null,updated datetime not null) 


create trigger empu
on employees
after  update
as
insert into 
emlog11 (empid,operation,updated)
select 
empid,'update',getdate()from deleted;
insert into employees values ('priya',11)
insert into employees values ('sware',15)
update employees set empname ='vrush'where empid=11

select* from employees
select * from emlog11
