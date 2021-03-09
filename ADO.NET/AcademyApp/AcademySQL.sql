﻿CREATE DATABASE Academy;
USE Academy;
GO;

--Student Table
CREATE TABLE Students
(
	Id INT PRIMARY KEY(Id) IDENTITY(1,1),
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	Coins INT NOT NULL DEFAULT(0),
	[Login] NVARCHAR(255) NOT NULL UNIQUE,
	PasswordHash VARCHAR(255) NOT NULL,
	Salt VARCHAR(50) NOT NULL,
	
	CONSTRAINT CK_Coins CHECK(Coins >= 0)
);

--Products Table
CREATE TABLE Products
(
	Id INT PRIMARY KEY(Id) IDENTITY(1,1),
	Title NVARCHAR(255) NOT NULL,
	Price INT NOT NULL,
	Quantity INT NOT NULL DEFAULT (0),

	CONSTRAINT CK_Price CHECK(Price > 0),
	CONSTRAINT CK_Quantity CHECK(Quantity >= 0)
);