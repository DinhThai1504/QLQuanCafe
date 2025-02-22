CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO
-- Food
-- Table

-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Trống || Có người
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'VINH',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán
	
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO
--chuc nang dang nhap
go
CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO
select * from dbo.Account where UserName = N'v' AND PassWord = N'1'
go
exec dbo.USP_GetAccountByUserName @userName = N'v' 

INSERT INTO dbo.Account
        ( UserName ,
          DisplayName ,
          PassWord ,
          Type
        )
VALUES  ( N'v' , -- UserName - nvarchar(100)
          N'LeCongVinh' , -- DisplayName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(1000)
          1  -- Type - int
        )
INSERT INTO dbo.Account
        ( UserName ,
          DisplayName ,
          PassWord ,
          Type
        )
VALUES  ( N'T' , -- UserName - nvarchar(100)
          N'Thai' , -- DisplayName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(1000)
          0  -- Type - int
        )
GO

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO
EXEC dbo.USP_GetAccountByUserName @userName = N'VINH' -- nvarchar(100)


--tao danh sach ban

DECLARE @i INT = 1

WHILE @i <= 20
BEGIN
	INSERT dbo.TableFood ( name)VALUES  ( N'Bàn ' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END


go
create proc USP_GetTableList
as select * from dbo.TableFood
go
exec dbo.USP_GetTableList

exec dbo.USP_GetTableList



update dbo.TableFood set status = N'Có người 'where id = 2

UPDATE dbo.TableFood 
SET status = N'Trống';


--các lệnh ngoài
DELETE TableFood
DBCC CHECKIDENT ('TableFood', RESEED, 0);
DELETE FROM dbo.FoodCategory;
DBCC CHECKIDENT ('dbo.FoodCategory', RESEED, 0);
DELETE FROM dbo.Food;
DBCC CHECKIDENT ('dbo.Food', RESEED, 0);
DELETE FROM dbo.Bill;
DBCC CHECKIDENT ('dbo.Bill', RESEED, 0);

DELETE FROM dbo.BillInfo;
DBCC CHECKIDENT ('dbo.BillInfo', RESEED, 0);

DELETE FROM dbo.Food;
DBCC CHECKIDENT ('dbo.Food', RESEED, 0);
select * from dbo.Food
-----------------


--thêm loại đồ uống

INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Cà Phê'  -- name - nvarchar(100)
          )

INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Trà' )

INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Thức uống nóng' )

INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Nước ngọt' )

INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Bánh' )

---foodcategory
-- thêm danh sách Cà phê
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Cà phê đen đá', -- name - nvarchar(100)
          1, -- idCategory - int
          25000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Cà phê sữa', 1, 25000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Cà phê muối', 1, 25000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Cà phê sữa dừa', 1, 25000)


--thêm danh sách trà

INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Trà dâu anh đào', 2, 25000)

INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Trà Lipton', 2, 25000)

INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Trà vải', 2, 30000)

INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Trà đào cam sả', 2, 25000)



--thêm danh sách nước ép

INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Cà phê sữa nóng', 3, 20000)

INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Americano', 3, 20000)

INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Cappuccino', 3, 20000)

INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Cacao', 3, 20000)



-- thêm danh sách nước ngọt

INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Coca', 4, 12000)

INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Pepsi', 4, 12000)



--danh sach banh

INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Bánh Croissant', 5, 18000)

INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Bánh Tiramisu', 5, 18000)



--them bill
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )

VALUES  ( GETDATE() , -- DateCheckIn - date
          NULL , -- DateCheckOut - date
          2 , -- idTable - int
          0  -- status - int
        )
        
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETDATE() , -- DateCheckIn - date
          NULL , -- DateCheckOut - date
          3, -- idTable - int
          0  -- status - int
        )
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETDATE() , -- DateCheckIn - date
          GETDATE() , -- DateCheckOut - date
          4 , -- idTable - int
          1  -- status - int
        )



-- thêm bill info
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 2, -- idBill - int
          1, -- idFood - int
          1  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 1, -- idBill - int
          3, -- idFood - int
          1  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  (1, -- idBill - int
          5, -- idFood - int
          1  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 1, -- idBill - int
          6, -- idFood - int
          1  -- count - int
          )
		  select * from dbo.bill
alter proc USP_InsertBill
@idTable int
as
begin
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )

VALUES  ( GETDATE() , -- DateCheckIn - date
          NULL , -- DateCheckOut - date
          @idTable , -- idTable - int
          0  -- status - int
        )
end
go

alter  PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT dbo.Bill 
	        ( DateCheckIn ,
	          DateCheckOut ,
	          idTable ,
	          status,
			  discount
	        )
	VALUES  ( GETDATE() , -- DateCheckIn - date
	          NULL , -- DateCheckOut - date
	          @idTable , -- idTable - int
	          0,
			  0-- status - int
			  
	        )
END
GO






CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	
	SELECT @isExitsBillInfo = id, @foodCount = b.count 
	FROM dbo.BillInfo AS b 
	WHERE idBill = @idBill AND idFood = @idFood

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.BillInfo	SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT	dbo.BillInfo
        ( idBill, idFood, count )
		VALUES  ( @idBill, -- idBill - int
          @idFood, -- idFood - int
          @count  -- count - int
          )
	END
END
GO

DELETE dbo.BillInfo

DELETE dbo.Bill



EXEC USP_InsertBillInfo @idBill = 1, @idFood = 2, @count = -1;
select * from dbo.Bill

EXEC USP_InsertBillInfo @idBill = 1, @idFood = 2, @count = -1;


DROP PROCEDURE IF EXISTS USP_InsertBillInfo;


CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = idBill FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0
	
	UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable
END
GO

CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = id FROM Inserted	
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0
	
	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO



SELECT MAX (id) FROM dbo.Bill

select DISTINCT f.name , bi.count, f.price , f.price*bi.count as totalPrice from dbo.Billinfo as bi,dbo.Food as f,dbo.bill as b 
where bi.idBill = b.id and bi.idFood = f.id and b.status = 0 and b.idTable = 4
UPDATE dbo.TableFood SET STATUS = N'Có người' WHERE id = 2



ALTER TABLE dbo.Bill
ADD discount int

update dbo.Bill set discount = 0 

select * from dbo

CREATE PROC USP_UpdateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE USERName = @userName AND PassWord = @password
	
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
	end
END
GO


--chuyển bàn
CREATE PROC USP_SwitchTabel
@idTable1 INT, @idTable2 int
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idFirstBill IS NULL)
	BEGIN
		PRINT '0000001'
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable1 , -- idTable - int
		          0  -- status - int
		        )
		        
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
		
	END
	
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idSeconrdBill IS NULL)
	BEGIN
		PRINT '0000002'
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable2 , -- idTable - int
		          0  -- status - int
		        )
		SELECT @idSeconrdBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	UPDATE dbo.BillInfo SET idBill = @idSeconrdBill WHERE idBill = @idFirstBill
	
	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
END
GO
go
-----
alter table dbo.Bill add totalPrice float

---chức năng doan thu
go
create proc USP_GetListBillByDate
@checkIn date , @checkOut date
as
begin
select  t.name as [Tên Bàn],  b.totalPrice as [Tổng tiền] ,DateCheckIn as [Ngày vào], DateCheckOut as [Ngày ra], discount as [Giảm giá]
	from dbo.Bill as b ,dbo.TableFood as t 
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut and b.status = 1
	and t.id = b.idTable 
	end
go


select * from dbo.Bill

delete dbo.Bill









CREATE PROC USP_GetListBillByDateAndPage
@checkIn date, @checkOut date, @page int
AS 
BEGIN
	DECLARE @pageRows INT = 10
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page - 1) * @pageRows
	
	;WITH BillShow AS( SELECT b.ID, t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount AS [Giảm giá]
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable)
	
	SELECT TOP (@selectRows) * FROM BillShow WHERE id NOT IN (SELECT TOP (@exceptRows) id FROM BillShow)
END
GO

CREATE PROC USP_GetNumBillByDate
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT COUNT(*)
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO


select * from TableFood

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Bill';
SELECT idTable, totalPrice, discount, DateCheckIn, DateCheckOut FROM dbo.Bill

