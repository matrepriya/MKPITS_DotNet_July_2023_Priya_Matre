create table Tableproduct (productid int primary key, producttypeid int ,productName varchar(50))
insert into Tableproduct (productid,producttypeid,productName)values
                         (112,23,'amazon'),
						 (113,24,'flipkart'),
						 (111,26,'mhytre');
select * from Tableproduct


create table Tableproductcateogory (productcategoryid int ,producttypename varchar (50),productGsctid int)
insert into Tableproductcateogory(productcategoryid,producttypename,productGSctid)values
                                  (123,'shampoo' ,123),
								  (124,'clin plus',124),
								  (125,'parleg',125);
select * from Tableproductcateogory
