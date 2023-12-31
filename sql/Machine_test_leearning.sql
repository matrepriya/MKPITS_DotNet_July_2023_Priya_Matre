create table TableproductGSTdetails11(product_GSTID int primary key,
                                    GSTDetails_Name varchar (500),
									CGST Decimal,
									SGST Decimal,
									IGST Decimal);
insert into TableproductGSTdetails11(product_GSTID, GSTDetails_Name,CGST, SGST,IGST )values
                                          ( 123,'priya',121,123,124),
										  (124,'nilesh',122,124,125),
										  (125,'pooja',123,125,126);
 select *from TableproductGSTdetails11                                           