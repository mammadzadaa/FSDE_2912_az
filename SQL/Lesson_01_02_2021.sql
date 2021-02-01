BEGIN

declare @age int;
SET @age = 20;
PRINT 'My age is ' + CONVERT(char(10),@age);
if(@age > 10)
	BEGIN
		PRINT 'My age is ' + CAST(@age AS char(10)) ;
	END

END

PRINT 'Hello';

SELECT * FROM Products;