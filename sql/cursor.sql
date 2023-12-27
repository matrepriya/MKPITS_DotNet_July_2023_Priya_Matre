create table products (productname varchar(50),
                       id int primary key,
                      list_price int not null,
					  brand_id int,
					  model_year int);
insert into products (productname, id ,list_price,brand_id,model_year)values
                    ('laptop', 123,550,741,2001),
					('Mouse',111,450,621,2003),
					('pendrive',222,350,543,2004),
					('ssd',343,236,623,2008);
declare
@productname varchar(50),
@list_price int;

declare cursor2 cursor
for select
productname,
list_price
from
products;

open cursor2;

fetch next from cursor2 into 
@productname,
@list_price;

while @@FETCH_STATUS=0
 begin
 print @productname + cast (@list_price as varchar)
 fetch next from cursor2 into
 @productname, 
 @list_price;
 
 end;
 close cursor2
 deallocate cursor2;



