IF OBJECT_ID('dbo.BillInfo', 'U') IS NOT NULL DROP TABLE dbo.BillInfo;
IF OBJECT_ID('dbo.Bill', 'U') IS NOT NULL DROP TABLE dbo.Bill;
IF OBJECT_ID('dbo.Food', 'U') IS NOT NULL DROP TABLE dbo.Food;
IF OBJECT_ID('dbo.FoodCategory', 'U') IS NOT NULL DROP TABLE dbo.FoodCategory;
IF OBJECT_ID('dbo.TableFood', 'U') IS NOT NULL DROP TABLE dbo.TableFood;
IF OBJECT_ID('dbo.Account', 'U') IS NOT NULL DROP TABLE dbo.Account;

GO

create table TableFood(
	Id INT IDENTITY primary key,
	Name nvarchar(100) NOT NULL,
	status nvarchar(100) NOT NULL -- 0:empty || 1:occupied
)
Go

create table Account(
	Id INT IDENTITY primary key,
	DisplayName nvarchar(100) NOT NULL,
	UserName nvarchar(100) NOT NULL DEFAULT N'JDDev',
	Password nvarchar(100) NOT NULL
)
Go

create table FoodCategory(
	Id INT IDENTITY primary key,
	Name nvarchar(100) NOT NULL DEFAULT N'Non-Name',
)
Go

create table Bill(
	Id INT IDENTITY primary key,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut Date,
	IdTable INT NOT NULL,
	Status INT NOT NULL -- 1: Has paid || 0: Not paid

	FOREIGN KEY (IdTable) REFERENCES dbo.TableFood(id)
)
Go

create table Food(
 Id INT IDENTITY PRIMARY KEY,
 Name varchar(100) NOT NULL DEFAULT N'Unnamed',
 IdCategory INT NOT NULL,
 Price FLOAT NOT NULL DEFAULT 0

 FOREIGN KEY (IdCategory) REFERENCES dbo.FoodCategory(Id)
)
GO

create table BillInfo(
	Id INT IDENTITY PRIMARY KEY,
	IdBill INT NOT NULL,
	IdFood INT NOT NULL,
	Count INT DEFAULT 0

	FOREIGN KEY (IdBill) REFERENCES dbo.Bill(Id),
	FOREIGN KEY (IdFood) REFERENCES dbo.Food(Id)
)
Go
