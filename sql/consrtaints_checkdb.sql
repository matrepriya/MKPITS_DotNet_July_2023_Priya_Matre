create table products (products_id int identity primary key, product_name varchar(255)NOT NULL,unit_price DEC(10,2))
insert into products values ('book', 400.300)
insert into products values ('pencil',500.300)
select * from products