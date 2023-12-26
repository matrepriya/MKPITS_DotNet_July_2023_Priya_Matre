create table salary (salary int, empname varchar(50),city varchar(50))
insert into salary (salary,empname,city)values
                   (2000,'sahil','nagpur'),
				   (30000,'sachin','ahmedbad'),
				   (4000,'sagar','nagpur'),
				   (5000,'sonu','kamte');
select * from salary
create procedure p4(@pp as int)
as begin
select * from  salary
where salary >@pp
end;
exec p4 4000