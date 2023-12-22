create table order6 (order_id int primary key,
                     customer_id int ,
					 order_status varchar (50) not null,
					 order_date date ,
					 required_date date,
					 store_id int,
					 staff_id int)
insert into order6 values (12,23,'delivery','2023-9-12','2024-6-14',23,23)
insert into order6 values (13,34,'free order','2024-5-14','2025-9-14',24,23)
select * from order6

create table customers1 (customer_id int primary key,
                        first_name varchar(50) not null,
						last_name varchar(50)not null,
						phone_no bigint,
						email_id varchar(20),
						street varchar (100) not null,
						customer_city varchar (50)not null,
						zip_code int);
insert into customers1 values (23,'priya','matre',8805439917, 'priya@gmail.com','swastik nagar','akola',444107)
select * from order6 where customer_id in(select customer_id from customers1 where customer_city='akola')

drop table customers1

drop table order6

