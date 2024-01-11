create table tableproductcateogary(product_category_id int primary key,
                                  product_type_name varchar (500),
								  product_Gst_id int);
insert into tableproductcateogary(product_category_id,product_type_name,product_Gst_id)values
                                 (1001,'computers',602) ,
								 (1002,'mobile',604),
								 (1003,'printers',603),
								 (1004,'Ac and fridge',601);
select * from  tableproductcateogary
						
create table tableproduct(productid int primary key,
                         product_name varchar  (500),
						 product_category_id int,
						 productprice int);
insert into tableproduct(productid,product_name,product_category_id,productprice)values
                        (210,'apple',1002,4000),
						(211,'lenovo',1002,2500),
						(212,'samsung',1003,5000),
						(213,'IFB',1004,2000),
						(214,'LG','1004',30000),
						(215,'sony',1001,60000);
select * from tableproduct
						
create table tableproductgstdetails(product_GST_ID int primary key,
                                   Gst_details_name varchar (500),
								   CGST int,
								   SGST int,
								   IGST int);