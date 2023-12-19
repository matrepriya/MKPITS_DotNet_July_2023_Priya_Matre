create table products(produsts_id int identity primary key, productname varchar(255) NOT NULL, unit_price DEC(10,2)CHECK (unit_price >0))
insert into products values ('Mouse',120)
insert into products values ('keyboard',110)
insert into products values ('Memory',100)
insert into products values ('Location',120)
insert into products values ('mobile',0)
select * from products