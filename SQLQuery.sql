SELECT p.Name, c.Name
	FROM Products AS p
	LEFT JOIN ProductsCategories AS PC ON p.Id = PC.ProductId
	LEFT JOIN Categories AS c ON c.Id = PC.CategoryId