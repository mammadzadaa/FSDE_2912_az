SELECT * FROM StepGroups;

SELECT * FROM Teachers;

INSERT INTO Teachers VALUES('Israfil','Huseynov');

INSERT INTO TeacherGroups VALUES(2,2);


SELECT * FROM TeacherGroups;


INSERT INTO GroupsTeachers VALUES(2,2);

SELECT * FROM TeacherGroup;

INSERT INTO TeacherGroup VALUES(2,3);

SELECT T.Name + ' ' + Surname AS FullName, G.Name
FROM Teachers AS T, StepGroups AS G, TeacherGroup AS TG
WHERE TG.GroupId = G.Id 
AND TG.TeacherId = T.Id;


/*
	COUNT()
	AVG()
	SUM()
	MIN()
	MAX()
*/

SELECT COUNT(*) AS [All rows]
FROM StudentsInformative;

SELECT COUNT(Grants) AS [How many has grants]
FROM StudentsInformative;

SELECT COUNT(DISTINCT Grants) AS [How many unique grants]
FROM StudentsInformative;

SELECT AVG(Grants) AS [Avarage grants]
FROM StudentsInformative;

SELECT AVG(DATEDIFF(yyyy,BirthDate,GETDATE())) AS [Aveage age]
FROM StudentsInformative;

SELECT SUM(Grants) AS [Sum of grants]
FROM StudentsInformative;

SELECT MIN(BirthDate) AS [Minimum BD]
FROM StudentsInformative;

SELECT MAX(LastName) AS [Last Name]
FROM StudentsInformative;

SELECT COUNT(*) AS [Number of rows woth condition]
FROM StudentsInformative
WHERE FirstName LIKE 'J%';

SELECT * FROM StudentsInformative;

SELECT Grants, COUNT(GroupId) AS [Number of students] FROM StudentsInformative
GROUP BY Grants;
