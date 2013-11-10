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

create table SystemUser
(
	id					int not null primary key identity,
	UserName			nvarchar(100) null,
	UserPassword		nvarchar(100) null
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
	@newContent		text,
	@newDate		nvarchar(100)
)
as

begin
insert CompanyNews(newTittle,newContent,newDate) values(@newTittle,@newContent,@newDate)
end

Go

create proc [dbo].[GetCompanyNews]
(
	@index		nvarchar(100)
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
declare		@showrow	int=10
begin
select case when MAX(rNo)%@showrow=0 then MAX(rNo)/@showrow else MAX(rNo)/@showrow+1 end as rIndex from (select ROW_NUMBER()over(order by id) as rNo from CompanyNews)t
end

GO

create proc [dbo].[UpdCompanyNewsById]
(
	@id				nvarchar(100),
	@newTittle		nvarchar(100),
	@newContent		text
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
delete from CompanyNews where id=@id
end

----------CompanyNews----------
Go
----------JoinUs----------
create proc [dbo].[AddJoinUs]
(
	@position		nvarchar(100),
	@positionContent		text
)
as

begin
if not exists (select position from JoinUs where position=@position) insert into JoinUs(position,positionContent) values(@position,@positionContent)
end

Go

create proc [dbo].[GetJoinUs]

as
begin
select id,position from JoinUs order by position
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

create proc [dbo].[UpdJoinUsById]
(
	@id						nvarchar(100),
	@position				nvarchar(100),
	@positionContent		text
)
as

begin
update JoinUs set position=@position,positionContent=@positionContent where id=@id
end

Go

create proc [dbo].[DelJoinUsById]
(
	@id		nvarchar(100)
)
as

begin
delete from JoinUs where id=@id
end
----------JoinUs----------

Go

----------SoftWare----------
create proc [dbo].[AddSoftWare]
(
	@softWareType		nvarchar(100),
	@softWareName		nvarchar(100),
	@softWarePhoto		nvarchar(100),
	@softWareContent	text
)
as
begin
insert into SoftWare(softWareType,softWareName,softWarePhoto,softWareContent) values (@softWareType,@softWareName,@softWarePhoto,@softWareContent)
end

Go

create proc [dbo].[GetSoftWareType]

as
begin
select softWareType from SoftWare group by softWareType order by softWareType
end

GO

create proc [dbo].[GetSoftWare]
(
	@softWareType	nvarchar(100),
	@index			nvarchar(100)
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
(
	@softWareType	nvarchar(100)
)
as
declare		@showrow	int=9
begin
select case when MAX(rNo)%@showrow=0 then MAX(rNo)/@showrow else MAX(rNo)/@showrow+1 end as rIndex from (select ROW_NUMBER()over(order by id) as rNo from SoftWare where softWareType=@softWareType)t
end

Go

create proc [dbo].[GetSoftWareById]
(
	@id	nvarchar(100)
)
as
begin
select softWareType,softWareName,softWarePhoto,softWareContent from SoftWare where id=@id
end

Go

create proc [dbo].[GetAllSoftWare]

as
begin
select id,softWareType,softWareName,softWarePhoto,softWareContent from SoftWare order by softWareType
end

Go

create proc [dbo].[UpdSoftWare]
(
	@id					nvarchar(100),
	@softWareType		nvarchar(100),
	@softWareName		nvarchar(100),
	@softWareContent	text
)
as
begin
update SoftWare set softWareType=@softWareType,softWareName=@softWareName,softWareContent=@softWareContent where id=@id
end

Go

create proc [dbo].[DelSoftWareById]
(
	@id		nvarchar(100)
)
as

begin
delete from SoftWare where id=@id
end
----------SoftWare----------

GO

----------HardWare----------
create proc [dbo].[AddHardWare]
(
	@hardWareType		nvarchar(100),
	@hardWareName		nvarchar(100),
	@hardWarePhoto		nvarchar(100),
	@hardWareContent	text
)
as
begin
insert into HardWare(hardWareType,hardWareName,hardWarePhoto,hardWareContent) values (@hardWareType,@hardWareName,@hardWarePhoto,@hardWareContent)
end

Go

create proc [dbo].[GetHardWareType]

as
begin
select hardWareType from HardWare group by hardWareType order by hardWareType
end

GO

create proc [dbo].[GetHardWare]
(
	@hardWareType	nvarchar(100),
	@index			nvarchar(100)
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
(
	@hardWareType	nvarchar(100)
)
as
declare		@showrow	int=9
begin
select case when MAX(rNo)%@showrow=0 then MAX(rNo)/@showrow else MAX(rNo)/@showrow+1 end as rIndex from (select ROW_NUMBER()over(order by id) as rNo from HardWare where hardWareType=@hardWareType)t
end

Go

create proc [dbo].[GetHardWareById]
(
	@id	nvarchar(100)
)
as
begin
select hardWareType,hardWareName,hardWarePhoto,hardWareContent from HardWare where id=@id
end

Go

create proc [dbo].[GetAllHardWare]

as
begin
select id,hardWareType,hardWareName,hardWarePhoto,hardWareContent from HardWare order by hardWareType
end

Go

create proc [dbo].[UpdHardWare]
(
	@id					nvarchar(100),
	@hardWareType		nvarchar(100),
	@hardWareName		nvarchar(100),
	@hardWareContent	text
)
as
begin
update HardWare set hardWareType=@hardWareType,hardWareName=@hardWareName,hardWareContent=@hardWareContent where id=@id
end

Go

create proc [dbo].[DelHardWareById]
(
	@id		nvarchar(100)
)
as

begin
delete from HardWare where id=@id
end
----------HardWare----------

Go

----------Services----------
create proc [dbo].[AddServices]
(
	@servicesType		nvarchar(100),
	@servicesName		nvarchar(100),
	@servicesPhoto		nvarchar(100),
	@servicesContent	text
)
as
begin
insert into [Services](servicesType,servicesName,servicesPhoto,servicesContent) values (@servicesType,@servicesName,@servicesPhoto,@servicesContent)
end

Go

create proc [dbo].[GetServicesType]

as
begin
select servicesType from [Services] group by servicesType order by servicesType
end

GO

create proc [dbo].[GetServices]
(
	@servicesType	nvarchar(100),
	@index			nvarchar(100)
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
(
	@servicesType	nvarchar(100)
)
as
declare		@showrow	int=9
begin
select case when MAX(rNo)%@showrow=0 then MAX(rNo)/@showrow else MAX(rNo)/@showrow+1 end as rIndex from (select ROW_NUMBER()over(order by id) as rNo from [Services] where servicesType=@servicesType)t
end

Go

create proc [dbo].[GetServicesById]
(
	@id	nvarchar(100)
)
as
begin
select servicesType,servicesName,servicesPhoto,servicesContent from [Services] where id=@id
end

Go

create proc [dbo].[GetAllServices]

as
begin
select id,servicesType,servicesName,servicesPhoto,servicesContent from [Services] order by servicesType
end

Go

create proc [dbo].[UpdServices]
(
	@id					nvarchar(100),
	@servicesType		nvarchar(100),
	@servicesName		nvarchar(100),
	@servicesContent	text
)
as
begin
update [Services] set servicesType=@servicesType,servicesName=@servicesName,servicesContent=@servicesContent where id=@id
end

Go

create proc [dbo].[DelServicesById]
(
	@id		nvarchar(100)
)
as

begin
delete from [Services] where id=@id
end
----------Services----------

Go

----------SuccessStories----------
create proc [dbo].[AddSuccessStories]
(
	@successStoriesName			nvarchar(100),
	@successStoriesContent		text,
	@successStoriesYear			nvarchar(100)
)
as

begin
if not exists (select successStoriesName from SuccessStories where successStoriesName=@successStoriesName) insert into SuccessStories(successStoriesName,successStoriesContent,successStoriesYear) values(@successStoriesName,@successStoriesContent,@successStoriesYear)
end

Go

create proc [dbo].[GetSuccessStories]

as
begin
select id,successStoriesName,successStoriesContent,successStoriesYear from SuccessStories  order by CONVERT(int,successStoriesYear)
end

GO

create proc [dbo].[GetSuccessStoriesById]
(
	@id		nvarchar(100)
)
as
begin
select successStoriesName,successStoriesContent,successStoriesYear from SuccessStories where id=@id
end

GO

create proc [dbo].[UpdSuccessStoriesById]
(
	@id							nvarchar(100),
	@successStoriesName			nvarchar(100),
	@successStoriesContent		text,
	@successStoriesYear			nvarchar(100)
)
as

begin
update SuccessStories set successStoriesName=@successStoriesName,successStoriesContent=@successStoriesContent,successStoriesYear=@successStoriesYear where id=@id
end

Go

create proc [dbo].[DelSuccessStoriesById]
(
	@id		nvarchar(100)
)
as

begin
delete from SuccessStories where id=@id
end
----------SuccessStories----------

Go

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

----------SystemUser----------
if not exists(select UserName from SystemUser where UserName='SystemIwooo') insert into SystemUser(UserName,UserPassword)values('SystemIwooo','SystemIwooo')
GO

create proc [dbo].[GetSystemUser]

as
begin
select UserName,UserPassword from SystemUser where UserName='SystemIwooo'
end

GO

create proc [dbo].[UpdSystemUser]
(
	@userName				nvarchar(100),
	@userPassword			nvarchar(100)
)
as

begin
update SystemUser set UserName=@userName,UserPassword=@userPassword
end

Go

----------SystemUser----------

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


