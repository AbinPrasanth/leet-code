/* Write your T-SQL query statement below */
select (
     select top 1 salary
     from (
         select distinct salary 
         from Employee 
         where salary < (select max(salary) from Employee) 
       )as DistinctSalary 
        order by salary desc
    ) as SecondHighestSalary;