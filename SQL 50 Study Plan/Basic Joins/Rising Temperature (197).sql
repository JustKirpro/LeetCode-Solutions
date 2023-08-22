SELECT w1.id
FROM Weather AS w1
  CROSS JOIN Weather AS w2 ON w1.temperature > w2.temperature
    AND DATEDIFF(w1.recordDate, w2.recordDate) = 1;