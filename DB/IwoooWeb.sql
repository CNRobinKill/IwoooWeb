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
create table JoinUs
(
	id				int not null primary key identity,
	position		nvarchar(100) null,
	positionContent	text null
)

GO
create table SoftWare
(
	id					int not null primary key identity,
	softWareType		nvarchar(100) null,
	softWareName		nvarchar(100) null,
	softWarePhoto		nvarchar(100) null,
	softWareContent		text null
)

GO
create table HardWare
(
	id					int not null primary key identity,
	hardWareType		nvarchar(100) null,
	hardWareName		nvarchar(100) null,
	hardWarePhoto		nvarchar(100) null,
	hardWareContent		text null
)

GO
create table [Services]
(
	id					int not null primary key identity,
	servicesType		nvarchar(100) null,
	servicesName		nvarchar(100) null,
	servicesPhoto		nvarchar(100) null,
	servicesContent		text null
)

GO

create table SuccessStories
(
	id							int not null primary key identity,
	successStoriesName			nvarchar(100) null,
	successStoriesContent		text null,
	successStoriesYear			nvarchar(100) null
)

GO

create table Slider
(
	id					int not null primary key identity,
	sliderName			nvarchar(100) null,
	sliderContent		nvarchar(1000) null,
	sliderLink			nvarchar(1000) null,
	sliderPhoto			nvarchar(200) null,
	sliderOrder			int
)

GO

--create table UpLoad
--(
--	id					int not null primary key identity,
--	upLoadPath			nvarchar(100)
--)

--GO

-------InsertData--------

declare @n int
set @n=1
while @n<99
begin
insert CompanyNews(newTittle,newContent,newDate) values('新闻'+convert(nvarchar(5),@n),'标题'+convert(nvarchar(5),@n),'2013-12-10')
set @n=@n+1
end

GO

declare @n int
set @n=1
while @n<15
begin
insert JoinUs(position,positionContent) values('position'+convert(nvarchar(5),@n),'positionContent'+convert(nvarchar(5),@n))
set @n=@n+1
end

GO

declare @n int
set @n=1
while @n<99
begin
insert SoftWare(softWareType,softWareName,softWarePhoto,softWareContent) values('系统ERP','softWareName'+convert(nvarchar(5),@n),'img/photos/tn_1.jpg','hardWareContent'+convert(nvarchar(5),@n))
set @n=@n+1
end

GO

declare @n int
set @n=1
while @n<99
begin
insert HardWare(hardWareType,hardWareName,hardWarePhoto,hardWareContent) values('PC服务器','hardWareName'+convert(nvarchar(5),@n),'img/photos/tn_1.jpg','hardWareContent'+convert(nvarchar(5),@n))
set @n=@n+1
end

GO

declare @n int
set @n=1
while @n<99
begin
insert [Services](servicesType,servicesName,servicesPhoto,servicesContent) values('工程师外派','servicesName'+convert(nvarchar(5),@n),'img/photos/tn_1.jpg','servicesContent'+convert(nvarchar(5),@n))
set @n=@n+1
end

GO

declare @n int
set @n=1
while @n<10
begin
insert SuccessStories(successStoriesName,successStoriesContent,successStoriesYear) values('陆逊梯卡话务中心'+convert(nvarchar(5),@n),'陆逊梯卡话务中心'+convert(nvarchar(5),@n),'2013')
set @n=@n+1
end
-------InsertData--------

GO

----------CompanyNews----------
create proc [dbo].[AddCompanyNews]
(
	@newTittle		nvarchar(100),
	@newContent		nvarchar(100),
	@newDate		nvarchar(100)
)
as

begin
insert CompanyNews(newTittle,newContent,newDate) values(@newTittle,@newContent,@newDate)
end

Go

create proc [dbo].[GetCompanyNews]
(
	@index		nvarchar(50)
)
as
if @index!='All'
begin
declare		@showrow	int=10
set @index=CONVERT(int,@index)
select * from (select ROW_NUMBER()over(order by id desc) as row,id,newTittle,convert(nvarchar(12),newDate,120)as newDate from CompanyNews)n where n.row>@showrow*(@index-1) and n.row<@showrow*@index+1
end
else
begin
select ROW_NUMBER()over(order by id desc) as row,id,newTittle,convert(nvarchar(12),newDate,120)as newDate from CompanyNews
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

create proc [dbo].[GetNewContentById]
(
	@id		nvarchar(100)
)
as
begin
select newTittle,newContent from CompanyNews where id=@id
end

GO

create proc [dbo].[GetCompanyNewsIndex]

as
declare		@showrow	int=9
begin
select case when MAX(rNo)%@showrow=0 then MAX(rNo)/@showrow else MAX(rNo)/@showrow+1 end as rIndex from (select ROW_NUMBER()over(order by id) as rNo from CompanyNews)t
end

GO

create proc [dbo].[UpdCompanyNewsById]
(
	@id				nvarchar(100),
	@newTittle		nvarchar(100),
	@newContent		nvarchar(100)
)
as

begin
update CompanyNews set newTittle=@newTittle,newContent=@newContent where id=@id
end

Go

create proc [dbo].[DelCompanyNewsById]
(
	@id		nvarchar(100)
)
as

begin
delete CompanyNews where id=@id
end

----------CompanyNews----------
Go
----------JoinUs----------
create proc [dbo].[GetJoinUs]

as
begin
select position from JoinUs order by position
end

GO

create proc [dbo].[GetPositionContentByPosition]
(
	@position		nvarchar(100)
)
as
begin
select positionContent from JoinUs where position=@position
end

GO
----------JoinUs----------

----------SoftWare----------

create proc [dbo].[GetSoftWareType]

as
begin
select softWareType from SoftWare group by softWareType order by softWareType
end

GO

create proc [dbo].[GetSoftWare]
(
	@softWareType	nvarchar(50),
	@index			nvarchar(50)
)
as
declare		@showrow	int=9
set @index=CONVERT(int,@index)
begin
select * from (select ROW_NUMBER()over(order by softWareName) as row,softWareName,softWarePhoto from SoftWare where softWareType=@softWareType)n where n.row>@showrow*(@index-1) and n.row<@showrow*@index+1
end

GO

create proc [dbo].[GetSoftWareContentBySoftWareName]
(
	@softWareName		nvarchar(100)
)
as
begin
select softWareContent from SoftWare where softWareName=@softWareName
end

GO

create proc [dbo].[GetSoftWareIndex]

as
declare		@showrow	int=9
begin
select case when MAX(rNo)%@showrow=0 then MAX(rNo)/@showrow else MAX(rNo)/@showrow+1 end as rIndex from (select ROW_NUMBER()over(order by id) as rNo from SoftWare)t
end

Go
----------SoftWare----------

----------HardWare----------

create proc [dbo].[GetHardWareType]

as
begin
select hardWareType from HardWare group by hardWareType order by hardWareType
end

GO

create proc [dbo].[GetHardWare]
(
	@hardWareType	nvarchar(50),
	@index			nvarchar(50)
)
as
declare		@showrow	int=9
set @index=CONVERT(int,@index)
begin
select * from (select ROW_NUMBER()over(order by hardWareName) as row,hardWareName,hardWarePhoto from HardWare where hardWareType=@hardWareType)n where n.row>@showrow*(@index-1) and n.row<@showrow*@index+1
end

GO

create proc [dbo].[GetHardWareContentByHardWareName]
(
	@hardWareName		nvarchar(100)
)
as
begin
select hardWareContent from HardWare where hardWareName=@hardWareName
end

GO

create proc [dbo].[GetHardWareIndex]

as
declare		@showrow	int=9
begin
select case when MAX(rNo)%@showrow=0 then MAX(rNo)/@showrow else MAX(rNo)/@showrow+1 end as rIndex from (select ROW_NUMBER()over(order by id) as rNo from HardWare)t
end

Go
----------HardWare----------

----------Services----------

create proc [dbo].[GetServicesType]

as
begin
select servicesType from [Services] group by servicesType order by servicesType
end

GO

create proc [dbo].[GetServices]
(
	@servicesType	nvarchar(50),
	@index			nvarchar(50)
)
as
declare		@showrow	int=9
set @index=CONVERT(int,@index)
begin
select * from (select ROW_NUMBER()over(order by servicesName) as row,servicesName,servicesPhoto from [Services] where servicesType=@servicesType)n where n.row>@showrow*(@index-1) and n.row<@showrow*@index+1
end

GO

create proc [dbo].[GetServicesContentByServicesName]
(
	@servicesName		nvarchar(100)
)
as
begin
select servicesContent from [Services] where servicesName=@servicesName
end

GO

create proc [dbo].[GetServicesIndex]

as
declare		@showrow	int=9
begin
select case when MAX(rNo)%@showrow=0 then MAX(rNo)/@showrow else MAX(rNo)/@showrow+1 end as rIndex from (select ROW_NUMBER()over(order by id) as rNo from [Services])t
end

Go
----------Services----------

----------SuccessStories----------
create proc [dbo].[GetSuccessStories]

as
begin
select successStoriesName,successStoriesContent,successStoriesYear from SuccessStories  order by CONVERT(int,successStoriesYear)
end

GO
----------SuccessStories----------

----------Slider----------
create proc [dbo].[AddSlider]
(
	@sliderName				nvarchar(100),
	@sliderContent			nvarchar(500),
	@sliderLink				nvarchar(100),
	@sliderPhoto			nvarchar(200)
)
as
begin
declare @sliderOrder int
select @sliderOrder=count(id) from Slider
insert Slider(sliderName,sliderContent,sliderLink,sliderPhoto,sliderOrder) values(@sliderName,@sliderContent,@sliderLink,@sliderPhoto,@sliderOrder)
end

Go

create proc [dbo].[GetSlider]

as
begin
select id,sliderName,sliderContent,sliderLink,sliderPhoto from Slider  order by sliderOrder
end

Go

create proc [dbo].[DelSliderById]
(
	@id		nvarchar(100)
)
as

begin
declare @sliderOrder int
select @sliderOrder=sliderOrder from Slider where id=@id
delete Slider where id=@id
update Slider set sliderOrder=sliderOrder-1 where sliderOrder>@sliderOrder
end
----------Slider----------
Go
------------UpLoad----------
--create proc [dbo].[AddSlider]
--(
--	@upLoadPath				nvarchar(100)
--)
--as
--begin
--insert UpLoad(upLoadPath) values(@upLoadPath)
--end
--Go
------------UpLoad----------


