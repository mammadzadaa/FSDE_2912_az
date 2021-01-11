SELECT * FROM StepStudents;

SELECT * FROM StepGroups;

INSERT INTO StepGroups VALUES('FSDE_2920_az');

INSERT INTO StepStudents VALUES('Emin','Mammadov',2);

DELETE FROM StepGroups WHERE Id = 2;

SELECT StepStudents.Name + ' ' + Surname AS FullName, StepGroups.Name
FROM StepStudents, StepGroups
WHERE StepStudents.GroupId = StepGroups.Id;

SELECT S.Name + ' ' + Surname AS FullName, G.Name
FROM StepStudents AS S, StepGroups AS G
WHERE S.GroupId = G.Id;

--SELECT S.Name + ' ' + Surname AS FullName, G.Name
--FROM StepStudents AS S, StepGroups AS G;  


/*
	NOT NULL
	DEFAULT
	CHECK
	UNIQUE
	PRIMARY KEY
	FOREIGN KEY
*/