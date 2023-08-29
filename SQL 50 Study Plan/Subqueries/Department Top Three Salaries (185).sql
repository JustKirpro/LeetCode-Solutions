SELECT d.name AS Department, e.name AS Employee, e.salary AS Salary
FROM Employee AS e
  INNER JOIN Department AS d ON e.departmentId = d.id
WHERE 3 > (
  SELECT COUNT(DISTINCT salary)
  FROM Employee
  WHERE departmentId = e.departmentId
    AND salary > e.salary
);