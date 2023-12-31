create table TableproductDetails (product_GSTID int primary key,
                                 GSTDetails_Name varchar (500),
								 CGST Decimal,
								 SGST Decimal,
								 IGST Decimal);
insert into TableproductDetails(product_GSTID,GSTDetails_Name,CGST ,SGST,IGST )values
                                (12,'priya',121,123,124),
								(13,'monika',122,124,125),
								(14,'nilesh',123,125,126),
								(15,'mona',124,126,127);
select * from TableproductDetails