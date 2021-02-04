
 sp_addmessage @msgnum = 50005, @severity = 10, @msgtext = 'Out of stock'

 GO
 RAISERROR(50005,10,1);

 GO
 sp_dropmessage @msgnum = 50005;
 
 --RAISERROR('Out of Stock', 10, 1);
 
 --RAISERROR(N'This is message %s %d.', 10, 1, 'number', 5);

CREATE FUNCTION DayOfWeeks (@day datetime)
RETURNS NVARCHAR(15)
AS
BEGIN
	declare @wday nvarchar(15)

	if(DATEPART(DW,@day) = 5)
		BEGIN
		SET @wday = 'Cume axshami'
		END
	else
		BEGIN
		SET @wday = 'Bilinmeyen gun'
		END
	return @wday
END


SELECT dbo.DayOfWeeks(GETDATE());

DROP FUNCTION DayOfWeeks;



