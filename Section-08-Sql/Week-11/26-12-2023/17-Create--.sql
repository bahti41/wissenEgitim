use Northwind
go

drop proc id exists spGetProductsByCategoryName
go

create proc spGetProductsByCategoryName
	@categoryName nvarchar(15)
	
as

	select
		p.ProductID as [�r�n seri no],
		p.ProductName as [�r�n],
		p.UnitPrice as [Fiyat],
		p.CategoryName as [test katogari ad�]
	from Products p join Categories c
		on p.CategoryID=c.CategoryID
	where c.CategoryName=@categoryName
	order by [Fiyat] desc
go


--exec spGetProductsByCategoryName 'beverages'
exec spGetProductsByCategoryName='beverages'