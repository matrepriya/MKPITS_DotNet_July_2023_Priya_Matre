create table results (rno int primary key, marks int check (marks >0))
insert into results values (1,0)
insert into results values (1,99)
select * from results