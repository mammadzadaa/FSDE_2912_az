CREATE DEFAULT def_name AS 'No Name';

CREATE DEFAULT def_money AS $0.0;

DROP DEFAULT def_name;

CREATE RULE rule_name AS @name LIKE 'A%';

CREATE RULE rule_money AS @money BETWEEN $0.0 AND $1000.0;

SELECT * FROM NameMoney;

INSERT INTO NameMoney VALUES('Adil', $1000);

CREATE TYPE dbo.D_LastName FROM nvarchar(20) NOT NULL;

EXEC sp_bindefault def_name, 'dbo.D_LastName';
EXEC sp_bindrule rule_name, 'dbo.D_LastName';

EXEC sp_unbindefault 'dbo.D_LastName';
EXEC sp_unbindrule 'dbo.D_LastName';
EXEC sp_addtype d_birthdate, 'date','NOT NULL';
EXEC sp_rename 'd_birthdate', 'd_bdate';

CREATE TYPE D_table_type AS TABLE ([Name] nvarchar(10),Age int);