SELECT DISTINCT l1.num AS ConsecutiveNums
FROM Logs AS l1
  INNER JOIN Logs AS l2 ON l1.num = l2.num
    AND l1.id = l2.id + 1
  INNER JOIN Logs AS l3 ON l2.num = l3.num
    AND l2.id = l3.id + 1;