create table TableproductGstdetails (product_Gst_id int primary key,
                                    Gst_details_name  varchar (500),
									CGST Decimal ,
									SGST Decimal,
									IGST Decimal)
insert into TableproductGstdetails values (10,'laptop',9,9,9)
insert into TableproductGstdetails  values (20,'mobile',14,14,14)
insert into TableproductGstdetails values (30,'Tv',9,9,9)
insert into TableproductGstdetails values (40,'smart watch',6,6,6)
select * from TableproductGstdetails

--------------------------------------------------------------------------

create table Tableproductcategorys (product_category_id int  primary key 
                                   ,product_type_name varchar (500),
								   product_GST_ID int,
								   foreign key(product_Gst_ID)references TableproductGstdetails(product_Gst_iD)) 
insert into Tableproductcategorys values (1,'laptop',10)
insert into Tableproductcategorys values (2,'mobile',20)
insert into Tableproductcategorys values (3,'TV',30)
insert into Tableproductcategorys values (4,'SMART WATCH',40)
select * from Tableproductcategorys

------------------------------------------------------------------------
 
 create table Tableproduct2 (product_id int primary key,
                             product_cateogory_id int,
							 product_name  varchar (500),
							 price int,
							 foreign key (product_category_id)references Tableproductcategorys
                               (product_category_id))
insert into Tableproduct2 values (100,1,'hp',1000)
insert into Tableproduct2 values (101,1,'acer',2000)
insert into Tableproduct2 values (103,2,'realme',3000)
insert into Tableproduct2 values (104,2,'redmi',4000)
insert into Tableproduct2 values (105,3,'appe',5000)
select * from Tableproduct2