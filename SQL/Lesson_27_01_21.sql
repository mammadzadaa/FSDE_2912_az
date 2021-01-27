CREATE DATABASE OnlineShop;

CREATE TABLE Customers
(
Id int identity(1,1) NOT NULL,
FirstName nvarchar(30) NOT NULL,
LastName nvarchar(30) NOT NULL,
Number nvarchar(20) Not NULL,
Email nvarchar(30) NOT NULL,
CartNumber nvarchar(16),
Adress nvarchar(30),
PRIMARY KEY(Id),
UNIQUE(Number),
UNIQUE(Email)
)

CREATE TABLE Products
(
Id int NOT NULL identity(1,1),
[Name] nvarchar(30) NOT NULL,
Priece money NOT NULL,
Quantity int NOT NULL,
PRIMARY KEY(Id)
)

CREATE TABLE Statuses
(
Id int NOT NULL identity(1,1),
[Name] nvarchar(30) NOT NULL,
PRIMARY KEY(Id)
)

INSERT INTO Statuses VALUES('Paid');
select * from Statuses

CREATE TABLE Orders
(
Id int NOT NULL,
CustomerId int FOREIGN KEY(CustomerId) references Customers(Id),
ProductId int FOREIGN KEY(ProductId) references Products(Id),
StatusId int FOREIGN KEY(StatusId) references Statuses(Id),
Quantity int NOT NULL,
TotalPriece money NOT NULL,
[Time] datetime NOT NULL,
PRIMARY KEY(Id)
)


SELECT* FROM Customers;
INSERT INTO Customers VALUES
('Aynur','Qasimli','0506894512','aynur@gmail.com','7845125478512','Baku.Nerimanov ray')


SELECT * FROM Products;
INSERT INTO Products VALUES('Ipad mini', 1650,16);

CREATE TABLE LogStatus
(
Id int identity(1,1) NOT NULL,
[Name] nvarchar(30) NOT NULL,
PRIMARY KEY(Id)
)

INSERT INTO LogStatus VALUES('OrderStatusUpdated')

CREATE TABLE OrdersLog
(
Id int identity(1,1) NOT NULL,
OrderId INT FOREIGN KEY(OrderId) references Orders(Id),
StatusId int FOREIGN KEY(StatusId) references LogStatus(Id),
[Time] datetime NOT NULL,
PRIMARY KEY(Id)
)

SELECT * FROM OrdersLog

CREATE TRIGGER AddedOrderLog
ON Orders AFTER INSERT
AS
BEGIN

INSERT INTO OrdersLog VALUES((SELECT TOP 1 Id 
							 FROM Orders
							 ORDER BY Id DESC),1,GETDATE())

END


INSERT INTO Orders VALUES(1,1,1,1,1,2000,GETDATE())
SELECT*FROM OrdersLog;
SELECT* FROM Orders;
SELECT* FROM Customers;
SELECT* FROM Products;
