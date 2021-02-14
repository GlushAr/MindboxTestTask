SELECT Products.Name, Categories.Name
FROM Relations
JOIN Products
ON Relations.Product_Id = Products.Product_Id
JOIN Categories
ON Relations.Category_Id = Categories.Category_Id