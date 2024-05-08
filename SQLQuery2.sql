create proc [dbo].[createcardNo]
as
declare @newcardNo varchar(20)
select @newcardNo = (select top 1 cardNo from memberCard where convert(varchar(8),getdate(),112)=substring(cardNo,1,8)order by cardNo desc)
if (@newcardNo is null)
	begin
	set @newcardNo=convert(varchar(8),getdate(),112)+'00001'
	end
else
	begin
	declare @len int, @lastNo int, @strLastNo varchar(5),@n int, @tempNo varchar(5)
	set @lastNo=convert(int, substring(@newcardNo,9,5))+1
set @len=len(@lastNo)
set @tempNo=@lastNo
set @n=0;
while @n<(5-@len)
begin
	set @tempNo='0' + convert(varchar, @tempNo);
	set @n=@n+1
end
set @strLastNo=@tempNo
	set @newcardNo=convert(varchar(8),getdate(),112)+@strLastNo
	end
	select @newcardNo