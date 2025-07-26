/* Write your T-SQL query statement below */
SELECT employee_id, department_id
FROM Employee e
WHERE primary_flag = 'Y'

UNION

SELECT employee_id, department_id
FROM Employee e
WHERE employee_id NOT IN (
    SELECT employee_id FROM Employee WHERE primary_flag = 'Y'
)
ORDER BY employee_id;
