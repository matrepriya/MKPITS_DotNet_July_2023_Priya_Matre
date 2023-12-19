create table products2 (productid int identity primary key, productname varchar(20) not null,unitprice DEC(10,2)Not Null)
insert into products2 values (1,'book',20)
select * from products2