CREATE VIEW StudentInfo
AS
SELECT s.FirstName + s.LastName as FullName, s.Email
FROM StudentsInformative as s
WHERE s.Grants > 1000;

SELECT * FROM dbo.StudentInfo;

CREATE DATABASE CallTest

CREATE TABLE Customers(
 ID int identity(1,1) NOT NULL PRIMARY KEY(ID),
 [Name] nvarchar(30) NOT NULL,
 Surname nvarchar(30) NOT NULL,
 PhoneNumber nchar(20) NOT NULL Unique(PhoneNumber),
 Email nvarchar(50) NULL Unique(Email)
)

CREATE TABLE Operators(
ID int identity(1,1) NOT NULL PRIMARY KEY(ID),
[Name] nvarchar(30) NOT NULL,
Surname nvarchar(30) NOT NULL,
Position nvarchar(30) NOT NULL
)

CREATE TABLE CallStatus(
ID int identity(1,1) NOT NULL PRIMARY KEY(ID),
[Name] nvarchar(30) NOT NULL
)

CREATE TABLE Calls(
CustomerID int foreign key(CustomerID) references Customers(Id),
OperatorID int foreign key(OperatorID) references Operators(Id),
[Call Length] time,
CallStatusID int foreign key(CallStatusID) references CallStatus(Id),
[Time] datetime,
EvaluationScore int
)


CREATE VIEW PlannedCalls
AS
SELECT C.[Name], O.[Name] AS OperatorName, Cl.EvaluationScore
FROM Operators AS O, Customers AS C, Calls AS Cl
WHERE Cl.OperatorID = O.ID AND Cl.CustomerID = C.ID AND cl.CallStatusID = 1

