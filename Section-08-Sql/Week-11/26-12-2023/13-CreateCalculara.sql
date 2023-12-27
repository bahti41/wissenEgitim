
use Northwind
go

drop function if exists fnCalculateAge
go 

create function fnCalculateAge
	(@birthDay date)
	returns int
begin
	declare @result int
	declare @today date
	set @today = GETDATE()
	set @result = DATEDÝFF(year,@birthDay,@today)
	return @result

end
go

select dbo.fnCalculateAge('1997-2-2')
go