create table TableproductGSTDetails (productGstid int primary key,GSTDetailName varchar(200),CGST Decimal, SGST Decimal,IGST Decimal)
insert into TableproductGSTDetails (productGstid,GSTDetailName,CGST,SGST,IGST)Values
                                     (123,'waneer',123,122,122)
select * from TableproductGSTDetails

create table Tableproductcateogory(productcategoryid int primary key,producttypeName varchar(500),productGSCTID int)
insert into Tableproductcateogory(productcategoryid, producttypeName,productGSCTID)values
                                  (111,' soap',122),
								  (123,'santoor',123),
								  (124,'shampoo',144);
select * from  Tableproductcateogory
								  
								  
									 

									