SELECT ROUND(COUNT(DISTINCT a2.player_id) / COUNT(DISTINCT a1.player_id), 2) AS fraction
FROM (
  SELECT player_id, MIN(event_date) AS event_date
  FROM Activity
  GROUP BY player_id
) AS a1
LEFT JOIN Activity As a2 on a1.player_id = a2.player_id
  AND DATEDIFF(a2.event_date, a1.event_date) = 1;