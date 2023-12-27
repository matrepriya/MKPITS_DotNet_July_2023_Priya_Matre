create table customer (customerid int,
                      custname varchar(50),
					  city varchar (50),
					  phone varchar)
insert into customer (customerid, custname,city,phone)values
                      (12,'priya','Nagpur',6699), 
					   (13,'vrushali','arvi',4450),
					   (14,'pooja','mumbai',2332),
					   (15,'mayuri','akola',3333),
					   (16,'pragati','pune',1234);
select * from customer
drop table customer
DECLARE 
    @customerid int, 
    @custname varchar(20),
	@city varchar(20),
	@phone varchar(20);

DECLARE cursor_customer CURSOR
FOR SELECT 
        customerid,
		custname,
		city,
		phone
    FROM 
        customer;

OPEN cursor_customer;

FETCH NEXT FROM cursor_customer INTO 
    @customerid, 
    @custname,
	@city,
	@phone;

WHILE @@FETCH_STATUS = 0
    BEGIN
	PRINT @custname + CAST(@customerid AS varchar) + cast (@city as varchar) + cast (@phone as varchar);
       
        FETCH NEXT FROM cursor_customer INTO 
            @customerid, 
    @custname,
	@city,
	@phone;
            
         end;

CLOSE cursor_product2;

DEALLOCATE cursor_product2;
