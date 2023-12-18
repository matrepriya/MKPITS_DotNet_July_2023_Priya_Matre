create table salesman(ord_no int primary key ,purch_amt varchar(20),ord_date varchar(20),customer_id varchar(20),salesman_id varchar(20) )
insert into salesman values (7001,150.5,'2012-10-05',3005,5002)
insert into salesman values (7009,270.65,'2012-09-05',3001,5005)
insert into salesman values (7002,65.26,'2012-10-05',3002,5001)
insert into salesman values (7004,110.5,'2012-o8-05',3009,5003)
insert into salesman values (7007,948.5,'2012-07-05',3005,5002)
insert into salesman values (7005,2400.5,'2012-07-05',3007,5001)
insert into salesman values (7008,5760.5,'2012-09-05',3002,5002)
select salesman_id,customer_id from salesman
