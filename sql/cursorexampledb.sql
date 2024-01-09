create table product (productname varchar (500),id int primary key, lisprice int not null,brandid int,modelyear int);
insert into product (productname,id,lisprice,brandid,modelyear)values
                    ('laptop',123,550,741,2001),
					('mouse',223,445,543,3002),
					('laptop',333,123,654,3005),
					('pendrive',343,434,766,3009);
select * from product