/* Write your T-SQL query statement below */
select machine_id, round(avg(end_time-start_time),3) as processing_time from (select a.machine_id,
 a.process_id, max(case when activity_type = 'start' then timestamp end)as start_time,
               max(case when activity_type = 'end' then timestamp end) as end_time 
               from Activity a
               group by a.machine_id, a.process_id )t group by machine_id;