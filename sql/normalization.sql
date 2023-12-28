create table product (product_id int primary key,
                      product_name varchar(40),
					  price int,
					  quantity int );
insert into product  (product_id,product_name,price,quantity)values
                     (111,'laptop',10000,12),
					 (123,'mouse',20000,20),
					 (133,'speaker',3000,20),
					 (123,'mobile',4000,20);
                        
select *from product
					  
