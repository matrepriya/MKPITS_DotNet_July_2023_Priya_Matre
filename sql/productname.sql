create table product1 (productname varchar(20),price bigint)
insert into product1 values ('keyboard','4000')
insert into product1 values ('mouse','500')
insert into product1 values ('laptop','600')
insert into product1 values ('ssd','7000')
insert into product1 values ('memory','7000')
select *from product1
select top 2 productname,price from product1 order by price 




