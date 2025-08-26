/* Write your T-SQL query statement below */
select firstName, lastName, city, state
from Person as p
left join Address as a
 on p.personId = a.personId;