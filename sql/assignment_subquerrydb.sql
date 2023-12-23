8- create a table users having column userid, username, password1,emailid,gender,city,country
create table users(user_id int primary key,
                    user_name varchar (50)not null,
				    password varchar(50)not null,
				    gender varchar (50) not null,
				    city varchar (40) not null,
				    country varchar (50) not null)
				    
insert into users values (12,'priya','qqqq','female','akola','Maharastre')
insert into users values (13,'pooja','pppp','male','mumbai','maharastre')
insert into users values (14,'payal','qqqq','female','pune','maharastre')
insert into users values (17,'pragati','ggggg','male','goa','Maharastre')
insert into users values (19,' vrushali','llll','female','ahmedbad','maharastre')
select * from users
drop table users