

CREATE FUNCTION foo (@num int) RETURNS int
AS 
BEGIN
	return @num + 10;
END

PRINT dbo.foo(100);

CREATE PROCEDURE pro
AS
BEGIN
	PRINT dbo.foo(100);
END

dbo.pro;

SELECT * FROM sys.server_principals;

CREATE LOGIN my WITH PASSWORD = '12345';

CREATE USER myuser FOR LOGIN my;

GRANT UPDATE ON Teachers TO myuser;

