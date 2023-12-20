create table stores (stores_id int identity(1,1) primary key, storesname varchar (255) not null, phone varchar(255),email varchar(255),street varchar(255),city varchar(255),state varchar(255),zipcode varchar(255))
insert into stores values ('maha','1234567890','piya@gmail.com', 'matre','akola','maharastra',4400)
insert into stores values ('maha','1234567890','piya@gmail.com', 'matre','akola','maharastra',4400)
insert into stores values ('maha','1234567890','piya@gmail.com', 'matre','akola','maharastra',4400)
select * from stores


create table staffs (staff_id int identity (1,1) primary  key, 
               firstname varchar(255),
			   lastname varchar(255),
			   email varchar(255),
			   phone varchar(255),
			   store_id int not null,
			   foreign key(store_id) references stores (stores_id))
			  
insert into staffs values ('mitali','rathod','priya@gmail.com','1234567890',1)
insert into staffs values ('priya','matre','sware@gmail.com','1234567890',2)
insert into staffs values ('yashu','mohite','yashu@gmail.com','123456789',3)
			   
			   select * from staffs
drop table staffs
