use Northwind
go

select
	e.firstName + '' + e.lastName as [Cal�san],
	dbo.fnCalculateAge(e.birthDate) as [yas]
from Employees e
order by [Yas]