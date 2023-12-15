create   table orders (orderid int , custname varchar (20),productname varchar(20),quantity int,ordersdate date)
insert into orders values(1,'priya','mouse', 4, '2022- 9-7')
insert into orders values(1,'payal','keyboard', 5, '2023- 6-7')
insert into orders values(1,'pragati','laptop', 6, '2024- 9-20')
insert into orders values(1,'swati','ssd', 9, '2025- 4-7')
insert into orders values(1,'sware','mouse', 3, '2026- 7-18')
insert into orders values(1,'shoma','memory', 6, '2027- 6-7')
insert into orders values(1,'shweeta','powder', 7, '2028- 8-7')
select  * from orders where ordersdate between '2022-9-7' and '2024 -9-20'