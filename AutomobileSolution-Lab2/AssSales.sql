USE [master]

--Use this query when error "Cannot drop database because it is currently in use."
ALTER DATABASE AssSales SET SINGLE_USER WITH ROLLBACK IMMEDIATE

GO
DROP DATABASE IF EXISTS AssSales

GO
CREATE DATABASE AssSales

GO
USE AssSales

GO
CREATE TABLE Member (
	MemberId INT IDENTITY (1, 1) NOT NULL,
	Email VARCHAR(100) NOT NULL,
	CompanyName VARCHAR(40) NOT NULL,
	City VARCHAR(15) NOT NULL,
	Country VARCHAR(15) NOT NULL,
	[Password] VARCHAR(30) NOT NULL,

	CONSTRAINT PK_Member PRIMARY KEY (MemberId)
)

INSERT INTO Member VALUES(N'admin@fstore.com', N'FPT', N'Ho Chi Minh', N'Vietnam', N'admin@@')
INSERT INTO Member VALUES(N'customer@gmail.com', N'Earth', N'Ho Chi Minh', N'Vietnam', N'123456')

GO
CREATE TABLE [Order] (
	OrderId INT IDENTITY (1, 1) NOT NULL,
	MemberId INT NOT NULL REFERENCES Member(MemberId) on delete cascade on update cascade,
	OrderDate DATETIME NOT NULL,
	RequiredDate DATETIME,
	ShippedDate DATETIME,
	Freight MONEY,

	CONSTRAINT PK_Order PRIMARY KEY (OrderId)
)

INSERT INTO [Order] VALUES (1, GETDATE(), null, null, 100)
INSERT INTO [Order] VALUES (2, GETDATE(), null, null, 600)

GO
CREATE TABLE Product(
	ProductId INT IDENTITY (1, 1) NOT NULL,
	ProductName VARCHAR(40) NOT NULL,
	[Weight] VARCHAR(20) NOT NULL,
	UnitPrice MONEY NOT NULL,
	UnitsInStock INT NOT NULL,

	CONSTRAINT PK_Product PRIMARY KEY (ProductId)
)

INSERT INTO Product VALUES (N'Samsung Galaxy 123', N'10', 100, 999)
INSERT INTO Product VALUES (N'IPhone Infinity', N'10', 200, 9999)

GO
CREATE TABLE OrderDetail (
	OrderId INT NOT NULL REFERENCES [Order](OrderId) on delete cascade on update cascade,
	ProductId INT NOT NULL REFERENCES Product(ProductId) on delete cascade on update cascade,
	UnitPrice MONEY NOT NULL,
	Quantity INT NOT NULL,
	Discount FLOAT NOT NULL

	CONSTRAINT PK_OrderDetail PRIMARY KEY (OrderId, ProductId)
)

INSERT INTO OrderDetail VALUES (1, 1, 100, 1, 0)
INSERT INTO OrderDetail VALUES (2, 2, 200, 3, 0)