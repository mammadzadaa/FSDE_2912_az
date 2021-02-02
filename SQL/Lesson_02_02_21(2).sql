CREATE TABLE Reqem(
id int identity(1,1) PRIMARY KEY(id),
eded int NOT NULL
)

SELECT *
FROM Reqem

INSERT INTO Reqem
VALUES(5)

declare @i int;
SET @i = 0;

WHILE(@i < 10)
  BEGIN
    INSERT INTO Reqem
	VALUES((SELECT RAND() * (100)))
    --SET eded = CONVERT(int,RAND(100))
	SET @i +=1;
  END

  declare @boyuk int;
  SET @boyuk = 
  (SELECT Top 1 eded
  FROM Reqem
  WHERE eded / eded = 1

  ORDER BY eded DESC);

  PRINT 'En boyuk cut eded ' + CONVERT(char(10), @boyuk)