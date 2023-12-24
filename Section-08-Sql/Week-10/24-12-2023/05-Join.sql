--Tüm filmleri listele kategori adlarýyla listele
use MoviesDb
go

--select
--	f.Id as [Id],
--	f.Name as [Film],
--	c.Name as [Kategori]
--from Films f join Categories c on f.CategoryId=c.Id

use Northwind
go

--select
--	p.ProductID as [Id],
--	p.ProductName as [Product],
--	p.UnitPrice as [Price],
--	c.CategoryName as [Category]
--from Products p join Categories c
--		on p.CategoryID=c.CategoryID

--select
--	p.ProductID as [Id],
--	p.ProductName as [Product],
--	p.UnitPrice as [Price],
--	c.CategoryName as [Category],
--	s.CompanyName as [Supplier]
--from Products p join Categories c
--		on p.CategoryID=c.CategoryID join Suppliers s
--			on p.SupplierID=s.SupplierID

--select
--	p.ProductID as [Id],
--	p.ProductName as [Product],
--	p.UnitPrice as [Price],
--	c.CategoryName as [Category],
--	s.CompanyName as [Supplier]
--from Products p join Categories c
--		on p.CategoryID=c.CategoryID join Suppliers s
--			on p.SupplierID=s.SupplierID
--where c.CategoryName='Condiments'

--USA'den tedarik edilen ürünleri listeleyin. (Ürün adý ve Tedarik ülkesi kolonlarý dönsün)
--select
--	p.ProductName,
--	s.Country
--from Products p join Suppliers s
--	on p.SupplierID=s.SupplierID
--where s.Country='USA'


--USA'den tedarik edilen ürünlere ait sipariþlerin toplam tutarý
--select top(5)
--	p.ProductName as [Product],
--	sum(od.UnitPrice*od.Quantity) as [Total]
--from Products p join Suppliers s
--	on p.SupplierID=s.SupplierID join OrderDetails od
--		on p.ProductID=od.ProductID
--where s.Country='USA'
--group by p.ProductName
--order by [Total] DESC

--Hangi çalýþan, bugüne kadar kaç adet sipariþ almýþ?
select 
	e.FirstName, 
	count(*) as [Total]
from Employees e join Orders o
		on e.EmployeeID=o.EmployeeID
group by e.FirstName
order by [Total] desc