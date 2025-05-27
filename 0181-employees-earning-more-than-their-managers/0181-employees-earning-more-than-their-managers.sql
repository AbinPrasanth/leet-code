/* Write your T-SQL query statement below */
select name as Employee from Employee
where salary > (
    select salary 
    from Employee
    as m 
    where 
    m.id = Employee.managerId);