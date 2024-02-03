--GetAllProducts
SELECT 
	p.ProductID as [Id], 
	p.ProductName as [Ürün], 
	c.CategoryName as [Kategori], 
	p.UnitPrice as [Fiyat], 
	p.UnitsInStock as [Stok]
FROM Products p JOIN Categories c
	ON p.CategoryID=c.CategoryID

--GetAllCategoryNames
SELECT
	c.CategoryID, c.CategoryName
FROM Categories c