create table TableNation (Nation int primary key, Nation_name varchar(500))
insert into TableNation (Nation,Nation_name)values
                        (963,'japan'),
						(453,'china'),
						(443,'indonese'),
						(223,'bhahre'),
						(232,'japan');
select * from TableNation

create table TableState (stateId int primary key,nation_id int, statename varchar (500))
insert into TableState (StateId,nation_id,statename)values
                       (11,23 ,'New york'),
					   (12,24,'califore'),
					   (10,25,'New jesery'),
					   (14,22,'taxces');
select * from TableState

create table Tablecity (cityID int primary key,state_id int,cityname varchar (500))
insert  into Tablecity (cityId,state_id,cityname)values
                       (11,23,'Delhi'),
					   (12,24,'Mumbai'),
					   (13,24,'kolkate'),
					   (14,25,'bangolre');
select * from Tablecity

create table TablecourseRegDetail(course int primary key,category int,fullname varchar (1500),Gender int)
insert into TablecourseRegDetail(course,category,fullname,Gender)values
                                (1,22,'priya matre',1),
								(2,23,'pooja zilip',2),
								(3,24,'akansha chapke',3),
								(4,25,'vrushali mohite',4),
								(5,26,'mayuri kale',5);
select * from TablecourseRegDetail

create table TableRegAddress (RegAddress int primary key,CourseId int,NationId int,stateId int,cityId int)
insert into TableRegAddress (RegAddress,CourseId,NationId,StateId ,cityId)values
                             (12,23,22,24,244),
							 (13,24,33,25,255),
							 (14,25,34,26,267),
							 (15,26,35,27,268);
select * from TableRegAddress 

create table TablefeeDetail(feeId int,courseId int,TotalAmount Decimal, miner Decimal,paidAmount Decimal,BalAmount Decimal,paidDate Datetime,)
insert into TablefeeDetail(feeid, courseId, TotalAmount,miner,PaidAmount,BalAmount,paidDate)values
                          (12,23,2000,400,3000,5000,'2017'),
						  (13,24,3000,500,400,600,'2016'),
						  (14,26,4000,6000,5000,700,'2018');
select * from TablefeeDetail






