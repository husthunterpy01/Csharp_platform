CREATE PROC USP_GetTableList
AS
BEGIN 
SELECT * FROM dbo.TableFood
END

UPDATE dbo.TableFood SET Status = N'Occupied' WHERE Id = 4

DECLARE @i INT = 1;
WHILE @i <= 10
BEGIN 
	INSERT INTO TableFood (Name, status) VALUES (N'Table ' + CAST(@i AS nvarchar(100)), N'Empty');
	SET @i = @i + 1;
END
GO



UPDATE dbo.TableFood 
SET Status = N'Occupied' 
WHERE Id >= 1 AND Id <= 5;

SELECT * FROM FoodCategory
INSERT INTO FoodCategory (Name) 
VALUES 
(N'Beef'), 
(N'Ice Cream'), 
(N'Water'), 
(N'Beer'), 
(N'Ramen');


INSERT INTO Food(Name, IdCategory, Price)
VALUES (N'Medium Rare Australian', 1, 1200000),
	(N'Japan Well', 1, 1500000),
	(N'UK Well Done', 1, 2000000)

INSERT INTO Food(Name, IdCategory, Price)
VALUES (N'Chocolate Merino', 2, 10000),
	(N'Swensen Cream Tower', 2, 30000),
	(N'Mochi Cream', 2, 25000)

INSERT INTO Food(Name, IdCategory, Price)
VALUES (N'Sparkle Water', 3, 10000),
	(N'Lavie', 3, 5000),
	(N'Fountain', 3, 7000)

INSERT INTO Food(Name, IdCategory, Price)
VALUES (N'333', 4, 7000),
	(N'Tiger', 4, 8000),
	(N'Heineken', 4, 10000)

INSERT INTO Food(Name, IdCategory, Price)
VALUES (N'Miso Ramen', 5, 100000),
	(N'Tantanmen', 5, 250000),
	(N'Beef fried ramen', 5, 300000)

select * from Food

select * from Bill
INSERT INTO Bill (DateCheckIn, DateCheckOut, IdTable, Status)
VALUES 
(GETDATE(), GETDATE(), 2, 0),
(GETDATE(), GETDATE(), 1, 1),
(GETDATE(), GETDATE(), 3, 0),
(GETDATE(), GETDATE(), 4, 0),
(GETDATE(), GETDATE(), 5, 1),
(GETDATE(), GETDATE(), 6, 0),
(GETDATE(), GETDATE(), 7, 0),
(GETDATE(), GETDATE(), 8, 1),
(GETDATE(), GETDATE(), 9, 0);

select * from BillInfo
insert into BillInfo (IdBill, IdFood, [Count])
Values (3,5,2);

insert into BillInfo (IdBill, IdFood, [Count])
values (2,1,6);