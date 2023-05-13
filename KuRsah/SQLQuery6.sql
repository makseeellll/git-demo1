/* Select Name,        MIN (СustomerСard) AS [Мин],
                    AVG (СustomerСard) AS [Ср],
               MAX (СustomerСard) AS [Макс],
           Sum (СustomerСard) AS [Сумма]
        From Customers
        Group BY Name
        Order By [Cумма] desc  */