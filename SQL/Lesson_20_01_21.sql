CREATE TABLE  TestStudents
(
	Id int NOT NULL IDENTITY(1,1),
	[Name] nvarchar(50),
	Surname nvarchar(50),
	BirthDate date,
	PhoneNumber nvarchar(12),
	GroupId int
);

CREATE TABLE TestTeachers(
	Id int NOT NULL IDENTITY(1,1) Primary Key(Id),
	[Name] nvarchar(50),
	Surname nvarchar(50),
	BirthDate date,
	PhoneNumber nvarchar(12)
);
CREATE TABLE TestGroups(
	Id int NOT NULL IDENTITY(1,1) Primary Key(Id),
	[Name] nvarchar(50),
);


CREATE TABLE TestTeacherGroups(
TeacherID int Foreign Key(TeacherID) References TestTeachers(Id), 
GroupID int Foreign Key(GroupID) References TestGroups(Id), 
Primary Key(TeacherID, GroupID)
);

SELECT *FROM TestStudents;

INSERT INTO TestGroups([Name])
VALUES('FSDM1912');

INSERT INTO TestGroups
VALUES('FSDM2028');

INSERT INTO TestTeachers
VALUES('Zabil','Quliyev','2001-02-28','0506321458');

INSERT INTO TestTeacherGroups
VALUES(2,1);


SELECT*FROM TestTeacherGroups;

INSERT INTO TestStudents
VALUES('Qurban', 'Quliyev','1999-5-9','0554268596',1),
('ELi', 'AGayev','2000-5-9','0516987456',1),
('Rza', 'Qasimov','2002-5-9','070546895',2),
('Xeyal', 'Quliyev','2003-5-9','0554789632',2);

SELECT TestTeachers.Name, TestGroups.Name, Count(TestStudents.Id)
FROM TestTeachers,TestGroups,TestStudents
WHERE TestTeachers.Id IN(	SELECT TeacherID
							FROM TestTeacherGroups
WHERE TestTeachers.Id=TestTeacherGroups.TeacherID) AND
TestStudents.GroupId IN (	SELECT TestTeacherGroups.GroupID 
							FROM TestTeacherGroups
			WHERE TestStudents.GroupId=TestTeacherGroups.GroupID);
;

