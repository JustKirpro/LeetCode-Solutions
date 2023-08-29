SELECT c1.visited_on, SUM(c2.amount) AS amount, ROUND(SUM(c2.amount) / 7, 2) AS average_amount
FROM (SELECT visited_on, SUM(amount) AS amount FROM Customer GROUP BY visited_on) AS c1
  CROSS JOIN (SELECT visited_on, SUM(amount) AS amount FROM Customer GROUP BY visited_on) AS c2 
WHERE DATEDIFF(c1.visited_on, c2.visited_on) BETWEEN 0 AND 6
  AND c1.visited_on - 6 >= (
    SELECT MIN(visited_on)
    FROM Customer
  )
GROUP BY c1.visited_on
ORDER BY c1.visited_on;