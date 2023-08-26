SELECT query_name, ROUND(AVG(rating / position), 2) AS quality,  ROUND(100 * SUM(IF(rating < 3, 1, 0)) / COUNT(rating), 2) AS poor_query_percentage
FROM Queries AS q
GROUP BY query_name;