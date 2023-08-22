SELECT product_name, year, price
FROM Product AS p
  INNER JOIN Sales AS s ON p.product_id = s.product_id;