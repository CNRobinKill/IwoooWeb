--+---------------------------------------------+
-- Create Website Database of IWOOO				-
-- Support versions of SQL Server: 2008			-
--												-
-- Last Updated: 2013-09-05						-
--+---------------------------------------------+

--+---------------------------------------------+
-- Create Database								-
--+---------------------------------------------+


use master;

-- Drop Database
IF DB_ID('IwoooWeb') IS NOT NULL DROP DATABASE WebsiteIwooo;

-- If database could not be created due to open connections, abort
IF @@ERROR = 3702
   RAISERROR('Database cannot be dropped because there are still open connections.', 127, 127) WITH NOWAIT, LOG;
  
-- Create Database
CREATE DATABASE IwoooWeb;
GO

USE IwoooWeb;
GO

create table CompanyNews
(
	id			int not null primary key identity,
	newTittle	nvarchar(100) null,
	newContent	text null,
	newDate		date
)

GO

-------InsertData--------
declare @n int
set @n=1
while @n<99
begin
insert CompanyNews(newTittle,newContent,newDate) values('新闻'+convert(nvarchar(5),@n),'标题'+convert(nvarchar(5),@n),'2013-12-10')
set @n=@n+1
end
-------InsertData--------

GO

create proc [dbo].[GetCompanyNews]
(
	@index		nvarchar(50)
)
as
declare		@showrow	int=10
set @index=CONVERT(int,@index)
begin
select * from (select ROW_NUMBER()over(order by id desc) as row,newTittle,convert(nvarchar(12),newDate,120)as newDate from CompanyNews)n where n.row>@showrow*(@index-1) and n.row<@showrow*@index+1
end

GO

create proc [dbo].[GetNewContentByNewTittle]
(
	@newTittle		nvarchar(100)
)
as
begin
select newContent from CompanyNews where newTittle=@newTittle
end

GO

create proc [dbo].[GetCompanyNewsIndex]

as
begin
select case when MAX(rNo)%10=0 then MAX(rNo)/10 else MAX(rNo)/10+1 end as rIndex from (select ROW_NUMBER()over(order by id) as rNo from CompanyNews)t
end


