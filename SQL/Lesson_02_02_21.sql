PRINT 'Begin!'

GOTO afti

PRINT 'Wont show up'

afti:

PRINT 'END'

SELECT * FROM Products;
INSERT INTO Products
VALUES('airpods',270,0),
('airpods2',300,0),
('airpodspro',500,0)

SELECT * FROM Orders

DECLARE @i int 
SET @i=1

DECLARE @count int
SET @count = (SELECT TOP 1 ID FROM Products 
				ORDER BY ID DESC)

WHILE (@i<=@count)
	BEGIN
	Delete From Products
	Where Id=@i AND Quantity=0
	SET @i+=1	
	END 

CREATE TRIGGER AddOrder
ON Orders
After INSERT  
AS 
BEGIN

DECLARE @id  INT 
SET @id=(
SELECT TOP 1 Id FROM Orders 
ORDER BY Id Desc )

DECLARE @productId  INT 
SET @productId=(
SELECT ProductId FROM Orders 
WHERE @id=Id )

DECLARE @productQuantity INT 
SET @productQuantity=(
SELECT Quantity FROM Orders
WHERE @id=Id )

DECLARE @Quantity INT 
SET @Quantity=(
SELECT Quantity FROM Products
WHERE @productId=Id )

IF(@Quantity>0)
	BEGIN
		UPDATE Products 
		SET Quantity-=@productQuantity
		WHERE Products.Id=@productId
		
SET @Quantity=(
SELECT Quantity FROM Products
WHERE @productId=Id )
	END

IF(@Quantity=0)
	BEGIN
		DELETE FROM Products
		WHERE Id=@productId
	END
END 

SELECT * FROM Orders;
SELECT * FROM Products;


INSERT INTO Orders VAlues (1,4,1,25,16000,GetDATE())

DROP TRIGGER AddOrder



