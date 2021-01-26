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

INSERT INTO Customers VALUES('Ali','Mammadzada','0516849282','ali96@mail.ru')

CREATE TABLE Operators(
ID int identity(1,1) NOT NULL PRIMARY KEY(ID),
[Name] nvarchar(30) NOT NULL,
Surname nvarchar(30) NOT NULL,
Position nvarchar(30) NOT NULL
)

INSERT INTO Operators VALUES('Mais','Guliyev','OnGoing')

UPDATE Operators
SET Position='Senior'
WHERE Position='Done'

SELECT*FROM Operators

CREATE TABLE CallStatus(
ID int identity(1,1) NOT NULL PRIMARY KEY(ID),
[Name] nvarchar(30) NOT NULL
)

INSERT INTO CallStatus VALUES('Done')

SELECT*FROM CallStatus;
SELECT*FROM Customers; 
SELECT*FROM Operators;
SELECT * FROM Calls;

CREATE TABLE Calls(
CustomerID int foreign key(CustomerID) references Customers(Id),
OperatorID int foreign key(OperatorID) references Operators(Id),
[Call Length] time,
CallStatusID int foreign key(CallStatusID) references CallStatus(Id),
[Time] datetime,
EvaluationScore int
)

CREATE TABLE CallsCount(
NumberOfCalls Int  Not Null
)

INSERT INTO CallsCount
VALUES(
(SELECT COUNT(Calls.CustomerID) FROM Calls )
)













CREATE TRIGGER CounterTrigger 
ON Calls AFTER INSERT 
AS 
BEGIN 
	UPDATE   CallsCount 
	 SET NumberOfCalls +=1 
END

SELECT * FROM Calls;
SELECT * FROM CallsCount;

INSERT INTO Calls VALUES(
2,3,'00:01:43',3,'2021-01-23',3
);












SELECT * FROM Calls
INSERT INTO Calls VALUES(4,5,'00:00:40',1, '2021-01-15', 5)

SELECT*FROM Calls
SELECT*FROM PlannedCalls

CREATE VIEW PlannedCalls
AS
SELECT C.[Name], O.[Name] AS OperatorName, Cl.EvaluationScore
FROM Operators AS O, Customers AS C, Calls AS Cl
WHERE Cl.OperatorID = O.ID AND
Cl.CustomerID = C.ID AND 
cl.CallStatusID = 1

CREATE VIEW CustomersEvalution
AS
SELECT Customers.Name+' '+Customers.Surname AS [Fullname], Calls.EvaluationScore
FROM Calls, Customers
WHERE Calls.EvaluationScore<3

ALTER VIEW CustomersEvalution
AS
SELECT Customers.Name+' '+Customers.Surname AS [Fullname], Calls.EvaluationScore, Operators.Name
FROM Calls, Customers,Operators
WHERE Calls.EvaluationScore<=3 AND Operators.ID=Calls.OperatorID

SELECT*FROM Calls

SELECT Calls.OperatorID, Operators.Name+'  '+ Operators.Surname AS Fullname, AVG(Calls.EvaluationScore) 
AS [Evalution of Average]
FROM Calls, Operators
WHERE Operators.ID=Calls.OperatorID
GROUP BY Calls.OperatorID, Operators.Name, Operators.Surname


