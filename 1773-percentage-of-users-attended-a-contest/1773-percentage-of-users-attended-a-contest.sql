/* Write your T-SQL query statement below */
select r.contest_id, 
round(count(r.user_id)*100.0/cast((select count(*) from Users)as float),2) 
as percentage 
from Register r
group by r.contest_id
order by percentage desc, r.contest_id asc;
