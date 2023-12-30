create table TableNation1(Nationid int primary key,
                        Nationname varchar(500))
insert into TableNation1(Nationid,Nationname)values
                        (12,'Japan'),
						(13,'Indonse'),
						(14,'bhaire'),
						(15,'china'),
						(16,'japan');
select * from TableNation1

create table Tablestate11 (stateid int primary key,
                         Nationid int,
						 statename varchar (500),
						 constraint fk11 
						 foreign key (Nationid)
						 references TableNation1(Nationid));
insert into Tablestate11(stateid,Nationid,statename)values
                         (111,12,'maharastre'),
						 (222,13,'bhaghate'),
						 (333,14,'northland');
select * from Tablestate11
create table TableregDetail(course int primary key,
                           cateogory int ,
						   fullName varchar (1500),
						   Genderid int);
insert into TableregDetail(course,cateogory,fullName,Genderid)values
                           (12,23,'priya matre',123);
select * from TableregDetail
						   


          
