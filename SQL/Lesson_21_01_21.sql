USE University;

CREATE TABLE MyTable
(
Id int identity not null,
Age int check(Age BETWEEN 0 AND 100) default 0,
FirstName nvarchar(20) not null,
LastName nvarchar(20) not null,
Salary money,
Tax as (Salary * 0.2),
PRIMARY KEY(Id), UNIQUE(FirstName, LastName)
)

--with (DATA_COMPRESSION = ROW)--
SELECT * FROM Groups;

INSERT INTO Groups Values('Test');

DELETE FROM MyTable WHERE FirstName = 'Azer';

DELETE FROM Groups WHERE Id = 6;

SELECT * FROM MyTable;

INSERT INTO MyTable VALUES(33,'Azer','Mah',2000,'+994 12 195',8);

ALTER TABLE MyTable ADD PhoneNumber char(15) default '+994000000000';

EXEC sp_rename 'MyTable.LastName','Surname', 'COLUMN'; 


ALTER TABLE MyTable DROP COLUMN GroupId;
ALTER TABLE MyTable ADD GroupId int default 0;


ALTER TABLE MyTable ADD CONSTRAINT fk_MyTable_Group 
foreign key (GroupId) references Groups(Id) ON DELETE SET DEFAULT;

 /*
 ON DELETE / ON UPDATE 
	NO ACTION | CASCADE | SET DEFAULT | SET NULL 
 */