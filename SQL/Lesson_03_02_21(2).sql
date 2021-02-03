
DECLARE @i INT;
SET @i = 0;
DECLARE @str nvarchar(50);

SET @str = CASE 
	WHEN @i > 0 THEN 'Positive Number'
	WHEN @i < 0 THEN 'Negative Number'
	WHEN @i = 0 THEN 'Zero'
END

PRINT 'Your number is ' + @str;


