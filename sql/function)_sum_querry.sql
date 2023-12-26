create table fees (rno int, fdate date,amount int)
insert into fees (rno, fdate, amount)values 
                (12,'2022-2-4','1200')
select * from fees 
select rno, sum (amount)from fees group by rno
