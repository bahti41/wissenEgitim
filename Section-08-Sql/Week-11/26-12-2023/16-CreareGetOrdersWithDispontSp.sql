use Northwind
go

drop proc Id exists spGetOrdersWithDiscount
go

create proc spGetOrdersWithDiscourt
as
	select
		od.OrderID as [Sta�� No],
		SUM(od UnitPrice * od.Quantity * (1-od.Discount)) as [Siparis Tutar�]
	from OrderDetails od
	group by od.OrderID
go


--Test
exec spGetOrdersWithDiscourt 
go
