/* Write your T-SQL query statement below */
SELECT 
    e.name,
    eu.unique_id
FROM 
    Employees e
LEFT JOIN 
    EmployeeUNI eu
ON 
    e.id = eu.id;