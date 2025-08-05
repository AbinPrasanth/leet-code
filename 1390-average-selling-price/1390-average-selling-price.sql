/* Write your T-SQL query statement below */
select distinct p.product_id, round(COALESCE(sum(price * units * 1.0) / NULLIF(sum(units),0),0), 2) as 
average_price
from 
 Prices as p
left join 
 UnitsSold as u
on p.product_id = u.product_id and u.purchase_date between p.start_date and p.end_date 
group by p.product_id
order by p.product_id;