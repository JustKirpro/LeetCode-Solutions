SELECT id,
  CASE
    WHEN id % 2 = 1 
      AND s.id <> (SELECT MAX(id) FROM Seat)
    THEN (SELECT student FROM Seat WHERE id = s.id + 1)
    WHEN id % 2 = 1
    THEN s.student
    WHEN id % 2 = 0
    THEN (SELECT student FROM Seat WHERE id = s.id - 1)
  END AS student
FROM Seat AS s
ORDER BY id;