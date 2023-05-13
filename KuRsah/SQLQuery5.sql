Select Name,
LEN (Name) AS [Длина названия],
LEFT (Name,3) AS [Первые 3 символова],
RIGHT (Name,3) AS [Помледние 3 символова]
from Customers1
