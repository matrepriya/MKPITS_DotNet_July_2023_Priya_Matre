create table employee (empid int primary key,
                      empname varchar (20)) 
create table emplog (logid int identity (1,1)not null,empid int not null,operation nvarchar (10)not null,updated datetime not null)
create trigger tri
  on employee
  for insert 
  as 
  insert into emplog (empid, operation,updated)
  select
  empid,'insert ',getdate() from inserted;
  insert into employee values (11,'priya')
  select * from employee
  select *from emplog