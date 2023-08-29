(
  SELECT u.name AS results
  FROM Users AS u
    INNER JOIN MovieRating AS mv ON u.user_id = mv.user_id
  GROUP BY u.name
  ORDER BY COUNT(*) DESC, u.name
  LIMIT 1
)
UNION ALL
(
  SELECT m.title As results
  FROM Movies AS m
    INNER JOIN MovieRating AS mv ON m.movie_id = mv.movie_id
  WHERE mv.created_at BETWEEN '2020-02-01' AND '2020-02-29'
  GROUP BY mv.movie_id
  ORDER BY AVG(mv.rating) DESC, m.title
  LIMIT 1
);