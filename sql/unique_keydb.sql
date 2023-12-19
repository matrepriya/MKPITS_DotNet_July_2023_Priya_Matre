create table persons (personid int identity primary key, firstname varchar(20) not null, lastname varchar(100) not null,email varchar(255) unique)
insert into persons values ('priya','matre','priyamatre@gmail.com')
insert into persons values ('pooja','zilip','poojazilip@gmail.com')
select * from persons