create table students (studentid int primary key,
                      rollno int ,
					  percentage int,
					  attendancename varchar (500));
insert into students (studentid, rollno, percentage,attendancename)values
                      (12,23,57,'priya'),
					  (13,24,58,'sonu'),
					  (14,25,59,'pragati'),
					  (15,26,30,'payal');
select * from students