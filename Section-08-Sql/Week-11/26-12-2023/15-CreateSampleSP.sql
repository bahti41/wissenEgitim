/*
	Stored Procedure
	Server üzerinde çalýþtýrýlan kod parçalarýdýr.
	Function'lara göre daha güvenli ve hýzlý çalýþýrlar.
	Bu yüzden de daha çok tercih edilirler.
*/
use Northwind
go

drop procedure if exists spSample
go

create procedure spSample
as
	select *
	from Products p
	where p.CategoryID=1
	order by p.UnitPrice desc
go
execute spSample
go
