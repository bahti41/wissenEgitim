use Northwind
go

drop proc id exists spGetProductsByCategoryName
go

create proc spGetProductsByCategoryName
	@categoryName nvarchar(15)
	
as

	select
		p.ProductID as [ürün seri no],
		p.ProductName as [ürün],
		p.UnitPrice as [Fiyat],
		p.CategoryName as [test katogari adý]
	from Products p join Categories c
		on p.CategoryID=c.CategoryID
	where c.CategoryName=@categoryName
	order by [Fiyat] desc
go


--exec spGetProductsByCategoryName 'beverages'
exec spGetProductsByCategoryName='beverages'