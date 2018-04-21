/*
We do have 2 tables in a relational database: 
∙ Clients (client_id(PK), client_name) 
∙ Orders (order_id(PK), client_id, order_sum, order_date) 
Please write the following SQL queries: 
  a- list of clients, which have an order with order_sum > 50 
  b- clients, whose total sum of orders exceeds 100 
*/

select c.* 
from Clients c
where c.client_id in (select o.client_id from orders o where o.order_sum > 50)

select c.* 
from Clients c, 
    (
        select client_id, sum(order_sum) total_sum
        from orders 
        group by client_id 
    ) temp
where c.client_id = temp.client_id
  and temp.total_sum > 100

