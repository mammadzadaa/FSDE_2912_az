SELECT G.Name, COUNT(S.Id) AS [Number of students]
FROM Groups AS G, StudentsInformative AS S
WHERE G.Id = S.GroupId
GROUP BY G.Name;

SELECT * FROM StudentsInformative;

SELECT G.Name, Grants, COUNT(S.Id) AS [Number of students]
FROM Groups AS G, StudentsInformative AS S
WHERE G.Id = S.GroupId
GROUP BY G.Name, Grants
ORDER BY G.Name;

SELECT LastName, Grants
FROM StudentsInformative
GROUP BY LastName, Grants
HAVING AVG(Grants) <= 1200
ORDER BY LastName;

SELECT LastName, G.Name
FROM StudentsInformative, Groups AS G
WHERE StudentsInformative.GroupId = G.Id AND G.Name = 'FSDM_2922_ru'
GROUP BY LastName, G.Name
--HAVING G.Name = 'FSDM_2922_ru'
ORDER BY LastName;

SELECT * FROM Groups;

SELECT LastName, FirstName, G.Name, Grants
FROM StudentsInformative AS S, Groups AS G
WHERE G.Id = S.GroupId  AND Grants = (SELECT MAX(Grants)
FROM StudentsInformative);

SELECT LastName, FirstName, GroupId
FROM StudentsInformative
WHERE GroupId IN(	SELECT Id 
					FROM Groups
					WHERE Name LIKE '%1%');

SELECT * FROM StudentsTable;

SELECT AVG(MONTH(BirthDate))
FROM StudentsTable;

SELECT * FROM StudentsInformative ORDER BY FirstName, LastName;

SELECT * FROM Groups;

SELECT FirstName, LastName
FROM StudentsInformative
GROUP BY FirstName, LastName
HAVING AVG(MONTH(BirthDate)) > (SELECT AVG(MONTH(BirthDate))
								FROM StudentsTable)
ORDER BY FirstName, LastName;

SELECT Name
FROM Groups
WHERE Id IN (	SELECT GroupId
				FROM StudentsInformative
				WHERE Grants =(	SELECT MAX(Grants)
								FROM StudentsInformative));

SELECT MAX(Grants)
FROM StudentsInformative;

SELECT GroupId
FROM StudentsInformative
WHERE Grants =(	SELECT MAX(Grants)
				FROM StudentsInformative);