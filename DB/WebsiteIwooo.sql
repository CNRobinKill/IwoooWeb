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
IF DB_ID('WebsiteIwooo') IS NOT NULL DROP DATABASE WebsiteIwooo;

-- If database could not be created due to open connections, abort
IF @@ERROR = 3702
   RAISERROR('Database cannot be dropped because there are still open connections.', 127, 127) WITH NOWAIT, LOG;
  
-- Create Database
CREATE DATABASE WebsiteIwooo;
GO

USE WebsiteIwooo;
GO

--+---------------------------------------------+
-- Create Schemas								-
--+---------------------------------------------+

CREATE SCHEMA Production AUTHORIZATION dbo;
GO
CREATE SCHEMA Solution AUTHORIZATION dbo;
GO
CREATE SCHEMA Support AUTHORIZATION dbo;
GO
CREATE SCHEMA Information AUTHORIZATION dbo;
GO

--+---------------------------------------------+
-- Create Tables								-
--+---------------------------------------------+

--+*********************************************+
-- Create table Production.Categories
CREATE TABLE Production.Categories
(
  categoryid   INT            NOT NULL IDENTITY,
  categoryname NVARCHAR(200)  NOT NULL,
  description  NVARCHAR(300)  NULL,
  CONSTRAINT PK_Production_Categories PRIMARY KEY(categoryid)
);

CREATE INDEX categoryname ON Production.Categories(categoryname);

-- Create table Production.SubCategories
CREATE TABLE Production.SubCategories
(
  subcategoryid		INT				NOT NULL IDENTITY,
  subcategoryname	NVARCHAR(200)	NOT NULL,
  categoryid		INT				NOT NULL,
  description		NVARCHAR(300)   NULL,
  CONSTRAINT PK_Production_SubCategories PRIMARY KEY(subcategoryid),
  CONSTRAINT FK_Production_SubCategories FOREIGN KEY(categoryid) REFERENCES Production.Categories(categoryid)
);

CREATE INDEX subcategoryname ON Production.SubCategories(subcategoryname);


-- Create table Production.Products
CREATE TABLE  Production.Products
(
	productid		INT			  NOT NULL IDENTITY,
	productname		nvarchar(200) NOT NULL,
	description		text		  NULL,
	imagename		nvarchar(200) NULL,
	categoryid		INT			  NOT NULL,
	subcategoryid	INT			  NULL,	
	CONSTRAINT	PK_Production_Products PRIMARY KEY(productid),
	CONSTRAINT  FK_Products_Categories FOREIGN KEY(categoryid) REFERENCES Production.Categories(categoryid),
	CONSTRAINT  FK_Products_SubCategories FOREIGN KEY(subcategoryid) REFERENCES Production.SubCategories(subcategoryid)
);

CREATE NONCLUSTERED INDEX idx_nc_categoryid  ON Production.Products(categoryid);
CREATE NONCLUSTERED INDEX idx_nc_productname ON Production.Products(productname);

--+*********************************************+
-- Create table Solution.Categories
CREATE TABLE Solution.Categories
(
	categoryid		INT				NOT NULL IDENTITY,
	categoryname	nvarchar(200)	NOT NULL,
	description		nvarchar(300)	NULL,
	CONSTRAINT	PK_Solution_Categories PRIMARY KEY(categoryid)
);
CREATE INDEX solution_categories_categoryname ON Solution.Categories(categoryname)

-- Create table Solution.Solutions
CREATE TABLE Solution.Solutions
(
	solutionid		INT				NOT NULL IDENTITY,
	solutionname	nvarchar(200)	NOT NULL,
	description		text			NULL,
	categoryid		INT				NOT NULL,
	CONSTRAINT	PK_Solution_Solutions PRIMARY KEY(solutionid),
	CONSTRAINT  FK_Solutions_Categories FOREIGN KEY(categoryid) REFERENCES Solution.Categories(categoryid)
)
CREATE NONCLUSTERED INDEX idx_nc_solution_categoryid  ON Solution.Solutions(categoryid);
CREATE NONCLUSTERED INDEX idx_nc_solutionname ON Solution.Solutions(solutionname);

--+*********************************************+
-- Create table Support.Supports
CREATE TABLE Support.Supports
(
	supportid	INT				    NOT NULL IDENTITY,
	supportname	NVARCHAR(200)		NOT NULL,
	description	text				NULL,
	CONSTRAINT  PK_Support_Supports PRIMARY KEY(supportid)
)
CREATE INDEX supportname ON Support.Supports(supportname)


--+*********************************************+
-- Create table Information.Categories
CREATE TABLE Information.Categories
(
	categoryid		INT				NOT NULL IDENTITY,
	categoryname	NVARCHAR(200)	NOT NULL,
	description		NVARCHAR(300)	NULL,
	CONSTRAINT	PK_Information_Categories PRIMARY KEY(categoryid)
)
CREATE INDEX information_categories_categoryname ON Information.Categories(categoryname)

-- Create table Information.Informations
CREATE TABLE Information.Informations
(
	informationid	INT				NOT NULL IDENTITY,
	informationname	NVARCHAR(200)	NOT NULL,
	description		NVARCHAR(300)	NULL,
	categoryid		INT				NOT NULL,
	CONSTRAINT PK_Information_Informations PRIMARY KEY(informationid),
	CONSTRAINT FK_Informations_Categories FOREIGN KEY(categoryid) REFERENCES Information.Categories(categoryid)
)
CREATE NONCLUSTERED INDEX idx_nc_information_categoryid  ON Information.Informations(categoryid);
CREATE NONCLUSTERED INDEX idx_nc_informationname ON Information.Informations(informationname);


--+---------------------------------------------+
-- Populate table Tables						-
--+---------------------------------------------+