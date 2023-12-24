--Hangi kategoride, ka� film var?
--use MoviesDb
--go

--select
--	c.Name as [Film],
--	count(f.Id) as [Film Adedi]
--from Films f right join Categories c
--	on f.CategoryId=c.ID
--group by c.Name
--order by [Film Adedi] desc

--Hangi y�netmenin ka� adet filmi var?
--Not: filmi olmayan y�netmenler de g�sterilsin
--�neri: �nce y�netmen-film adedi 

--select
--	d.Name as [Y�netmen],
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

--Hangi kategoriden ka� paral�k sat�� yapm���z?
--select
--	c.CategoryName as [Kategori],
--	sum(od.UnitPrice * od.Quantity) as [Tutar]
--from Categories c join Products p
--		on c.CategoryID=p.CategoryID join OrderDetails od
--			on p.ProductID=od.ProductID
--group by c.CategoryName	

--Hangi �r�nden ka� adet sat�lm��t�r?
--Not: Sat��� yap�lmam�� �r�n varsa o da listelensin.

--select
--	p.ProductName as [�r�n],
--	sum(od.Quantity) as [Adet]
--from Products p left join OrderDetails od
--	on p.ProductID=od.ProductID
--group by p.ProductName
--order by [Adet] asc

--select
--	p.ProductName as [�r�n]
--from Products p left join OrderDetails od
--	on p.ProductID=od.ProductID
--group by p.ProductName
--having SUM(od.Quantity) Is Null

--En �ok ciro yap�lan �� �r�n hangisidir? Cirolar�yla birlikte listeleyeniz.
--select top(3)
--	p.ProductName as [�r�n],
--	sum(od.UnitPrice * od.Quantity) as [Ciro]
--from Products p join OrderDetails od
--	on p.ProductID=od.ProductID
--group by p.ProductName
--order by [Ciro] desc

--Hangi m��teriye, ne kadarl�k sat�� yap�lm��t�r? Sat�� tutar�na g�re b�y�kten k����e s�ral� �ekilde listeleyiniz.
--select
--	c.CompanyName as [M��teri],
--	sum(od.UnitPrice*od.Quantity) as [Tutar]
--from Customers c join Orders o
--	on c.CustomerID=o.CustomerID join OrderDetails od
--		on od.OrderID=o.OrderID
--group by c.CompanyName
--order by [Tutar] desc

--Hangi b�lgede, hangi �r�nden, ne kadarl�k sat�� yap�lm��t�r?
select
	r.RegionDescription as [B�lge],
	p.ProductName as [�r�n],
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
