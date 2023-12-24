--Hangi kategoride, kaç film var?
--use MoviesDb
--go

--select
--	c.Name as [Film],
--	count(f.Id) as [Film Adedi]
--from Films f right join Categories c
--	on f.CategoryId=c.ID
--group by c.Name
--order by [Film Adedi] desc

--Hangi yönetmenin kaç adet filmi var?
--Not: filmi olmayan yönetmenler de gösterilsin
--öneri: önce yönetmen-film adedi 

--select
--	d.Name as [Yönetmen],
--	count(f.Id) as [Adet]
--from Directories d left join Films f
--	on d.Id=f.DirectorId 
--group by d.Name

--hangi filmlerin oyuncusu yoktur?
--select
--	f.Name
--from Films f  left outer join FilmsStars fs
--	on f.Id=fs.FilmId left outer join Stars s
--		on fs.StarId=s.Id
--group by f.Name
--having count(s.Id)=0


use Northwind
go

--Hangi kategoriden kaç paralýk satýþ yapmýþýz?
--select
--	c.CategoryName as [Kategori],
--	sum(od.UnitPrice * od.Quantity) as [Tutar]
--from Categories c join Products p
--		on c.CategoryID=p.CategoryID join OrderDetails od
--			on p.ProductID=od.ProductID
--group by c.CategoryName	

--Hangi üründen kaç adet satýlmýþtýr?
--Not: Satýþý yapýlmamýþ ürün varsa o da listelensin.

--select
--	p.ProductName as [Ürün],
--	sum(od.Quantity) as [Adet]
--from Products p left join OrderDetails od
--	on p.ProductID=od.ProductID
--group by p.ProductName
--order by [Adet] asc

--select
--	p.ProductName as [Ürün]
--from Products p left join OrderDetails od
--	on p.ProductID=od.ProductID
--group by p.ProductName
--having SUM(od.Quantity) Is Null

--En çok ciro yapýlan üç ürün hangisidir? Cirolarýyla birlikte listeleyeniz.
--select top(3)
--	p.ProductName as [Ürün],
--	sum(od.UnitPrice * od.Quantity) as [Ciro]
--from Products p join OrderDetails od
--	on p.ProductID=od.ProductID
--group by p.ProductName
--order by [Ciro] desc

--Hangi müþteriye, ne kadarlýk satýþ yapýlmýþtýr? Satýþ tutarýna göre büyükten küçüðe sýralý þekilde listeleyiniz.
--select
--	c.CompanyName as [Müþteri],
--	sum(od.UnitPrice*od.Quantity) as [Tutar]
--from Customers c join Orders o
--	on c.CustomerID=o.CustomerID join OrderDetails od
--		on od.OrderID=o.OrderID
--group by c.CompanyName
--order by [Tutar] desc

--Hangi bölgede, hangi üründen, ne kadarlýk satýþ yapýlmýþtýr?
select
	r.RegionDescription as [Bölge],
	p.ProductName as [Ürün],
	sum(od.UnitPrice*od.Quantity) as [Tutar]
from Region r join Territories t
	on r.RegionID=t.RegionID join EmployeeTerritories et
		on t.TerritoryID=et.TerritoryID join Employees e
			on et.EmployeeID=e.EmployeeID join Orders o
				on e.EmployeeID=o.EmployeeID join OrderDetails od
					on o.OrderID=od.OrderID join Products p
						on od.ProductID=p.ProductID
group by r.RegionDescription, p.ProductName
--having SUM(od.UnitPrice*od.Quantity)>=100000
order by r.RegionDescription, p.ProductName
