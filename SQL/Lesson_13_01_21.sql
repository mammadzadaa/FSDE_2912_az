SELECT * FROM StudentsInformative;

SELECT * FROM Achievements;

SELECT FirstName, LastName, BirthDate, Email
FROM StudentsInformative
WHERE EXISTS(	SELECT *
				FROM Achievements
				WHERE Achievements.StudentId = StudentsInformative.Id);

SELECT FirstName, LastName, BirthDate, Email
FROM StudentsInformative
WHERE NOT EXISTS(	SELECT *
				FROM Achievements
				WHERE Achievements.StudentId = StudentsInformative.Id);


SELECT FirstName, LastName, BirthDate, Email
FROM StudentsInformative
WHERE Id = ANY (	SELECT StudentId
					FROM Achievements
					WHERE Score > 8);


SELECT FirstName, LastName, BirthDate, Email
FROM StudentsInformative
WHERE Id = SOME (	SELECT StudentId
					FROM Achievements
					WHERE Score > 8);


SELECT FirstName, LastName, BirthDate, Email
FROM StudentsInformative
WHERE Id IN (	SELECT StudentId
					FROM Achievements
					WHERE Score > 8);

SELECT COUNT(*) AS [Count]
FROM StudentsInformative
WHERE MONTH(BirthDate) <= ANY (SELECT MIN(MONTH(BirthDate))
								FROM StudentsTable);

SELECT * FROM StudentsTable;

SELECT * FROM StudentsInformative;

SELECT FirstName, LastName, Score
FROM StudentsInformative AS S, Achievements AS A
WHERE StudentId = S.Id AND
Score > ANY (SELECT AVG(Score)
				FROM Achievements
				GROUP BY StudentId);

SELECT AVG(Score)
FROM Achievements
GROUP BY StudentId;

SELECT * FROM Achievements;

INSERT INTO Achievements VALUES(1,10);

SELECT FirstName + ' ' + LastName AS FullName, BirthDate
FROM StudentsInformative
WHERE MONTH(BirthDate) > 5
	AND MONTH(BirthDate) < 9
UNION
SELECT FirstName , BirthDate
FROM StudentsTable
WHERE MONTH(BirthDate) > 5
	AND MONTH(BirthDate) < 9
ORDER BY BirthDate;

SELECT * FROM StudentsTable;

SELECT * FROM StudentsInformative;


SELECT 'Spring' AS Season, COUNT(*)
							AS [Number of Students]
FROM StudentsInformative
WHERE MONTH(BirthDate) BETWEEN 3 AND 5
UNION ALL
SELECT 'Summer', COUNT(*)
FROM StudentsInformative
WHERE MONTH(BirthDate) BETWEEN 6 AND 8
UNION ALL
SELECT 'Autumn', COUNT(*)
FROM StudentsInformative
WHERE MONTH(BirthDate) BETWEEN 9 AND 11
UNION ALL
SELECT 'Winter', COUNT(*)
FROM StudentsInformative
WHERE MONTH(BirthDate) IN (12,1,2);
