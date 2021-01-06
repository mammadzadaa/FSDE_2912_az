SELECT * FROM Students;

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students;

SELECT FirstName + ' ' + SecondName AS FullName, BirthDate, Grand, Email
FROM Students;

SELECT FirstName + ' ' + SecondName AS FullName, BirthDate, 
Grand, Grand * 1.2 AS [Plus 20 Percent], Email
FROM Students;

SELECT FirstName + ' ' + SecondName + ' ' + Grand AS [Full Name and Grand], BirthDate, Email
FROM Students;

SELECT FirstName + ' ' + SecondName + ' ' + CAST(Grand AS nvarchar(10))
AS [Full Name and Grand], BirthDate, Email
FROM Students;

SELECT FirstName + ' ' + SecondName + ' ' + CONVERT(nvarchar(10),Grand)
AS [Full Name and Grand], BirthDate, Email
FROM Students;

SELECT TOP 2 FirstName + ' ' + SecondName + ' ' + CONVERT(nvarchar(10),Grand)
AS [Full Name and Grand], BirthDate, Email
FROM Students;

SELECT TOP 50 PERCENT FirstName + ' ' + SecondName + ' ' + CONVERT(nvarchar(10),Grand)
AS [Full Name and Grand], BirthDate, Email
FROM Students;

SELECT DISTINCT FirstName FROM Students;

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students
WHERE Grand > 1000;

/*

  =  - bərabərdir
  <> - beraber deyil
  >,<,>=,<= - C# la eyni menada
  !> - boyu deyil
  !< - kichik deyil

*/

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students
WHERE Grand = 1000;

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students
WHERE LEN(FirstName) !> 5;

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students
WHERE MONTH(BirthDate) > 2
AND MONTH(BirthDate) < 6;

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students
WHERE YEAR(BirthDate) % 2 <> 0
OR DAY(BirthDate) % 2 <> 0;

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students
WHERE NOT FirstName = 'Konul';

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students
WHERE SecondName IS NULL;

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students
WHERE SecondName IS NOT NULL;

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students
WHERE SecondName IS NOT NULL
ORDER BY Grand;

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students
WHERE SecondName IS NOT NULL
ORDER BY Grand DESC;

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students
WHERE SecondName IS NOT NULL
ORDER BY FirstName DESC, BirthDate ASC;

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students
WHERE FirstName = 'Konul' OR FirstName = 'Azer' OR FirstName = 'Tural';

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students
WHERE FirstName IN ('Konul','Azer', 'Tural');

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students
WHERE BirthDate >= '1990-01-01'
AND BirthDate <= '1999-12-31';

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students
WHERE BirthDate BETWEEN '1990-01-01' AND '1999-12-31';

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students
WHERE FirstName NOT BETWEEN 'K' AND 'O';

/*
	% - 0 dan istenilen sayda simvol
	_ - istenilen bir simvol
	[] - birnece simvol ve ya araliq
	[^] - birnece simvol ve ya araliq daxil olmayan
*/ 

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students
WHERE FirstName LIKE 'A%';

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students
WHERE FirstName LIKE '%_am%';

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students
WHERE FirstName LIKE '_[auo]%';

SELECT FirstName, SecondName, BirthDate, Grand, Email
FROM StepITAcademy.dbo.Students
WHERE FirstName LIKE '_[^auo]%';

INSERT INTO Students(BirthDate, FirstName, SecondName,  Grand, Email)
VALUES('1975-11-12', 'Famile','Iskenderova',1320,'famile@outlook.com');

INSERT INTO Students
VALUES('Kamile','Iskenderova','1975-12-12', 140,'kamile@outlook.com');

SELECT * FROM Students;

INSERT INTO Temp(Name, Surname)
SELECT FirstName, SecondName
FROM Students
WHERE YEAR(BirthDate) < 1990;

SELECT * FROM Temp;

SELECT FirstName, Grand
INTO HighFinanciedStudents
FROM Students
WHERE Grand > 500;

SELECT * FROM HighFinanciedStudents;

UPDATE Students
SET Grand += 500
WHERE Grand < 500;

DELETE FROM Students
WHERE SecondName IS NULL;

SELECT * FROM Students;