CREATE DATABASE TestEntity
GO

USE TestEntity
GO

CREATE TABLE Class
(
	ID INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) DEFAULT N'Hello Class'
)
GO

CREATE TABLE Students
(	
	ID INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) DEFAULT N'Hello Name',
	IDClass INT NOT NULL,
	FOREIGN KEY (IDClass) REFERENCES dbo.Class(ID)
)
GO

INSERT INTO Class
			(Name)
VALUES (N'Hello Class 1')
INSERT INTO dbo.Class
			(Name)
VALUES (N'Hello Class 2')
INSERT INTO dbo.Class
			(Name)
VALUES (N'Hello Class 3')
INSERT INTO dbo.Class
			(Name)
VALUES (N'Hello Class 4')

INSERT INTO dbo.Students
			(Name, IDClass)
VALUES	(N'Stu 1', 1)

INSERT INTO dbo.Students
			(Name, IDClass)
VALUES	(N'Stu 2', 1)

INSERT dbo.Students
		(Name, IDClass)
VALUES	(N'Stu 3', 1)

INSERT dbo.Students
		(Name, IDClass)
VALUES	(N'Stu 4', 1)


INSERT INTO dbo.Students
			(Name, IDClass)
VALUES	(N'Stu 1', 2)

INSERT INTO dbo.Students
			(Name, IDClass)
VALUES	(N'Stu 2', 2)

INSERT dbo.Students
		(Name, IDClass)
VALUES	(N'Stu 3', 2)

INSERT dbo.Students
		(Name, IDClass)
VALUES	(N'Stu 4', 2)


INSERT INTO dbo.Students
			(Name, IDClass)
VALUES	(N'Stu 1', 3)

INSERT INTO dbo.Students
			(Name, IDClass)
VALUES	(N'Stu 2', 3)

INSERT dbo.Students
		(Name, IDClass)
VALUES	(N'Stu 3', 3)

INSERT dbo.Students
		(Name, IDClass)
VALUES	(N'Stu 4', 3)


INSERT INTO dbo.Students
			(Name, IDClass)
VALUES	(N'Stu 1', 4)

INSERT INTO dbo.Students
			(Name, IDClass)
VALUES	(N'Stu 2', 4)

INSERT dbo.Students
		(Name, IDClass)
VALUES	(N'Stu 3', 4)

INSERT dbo.Students
		(Name, IDClass)
VALUES	(N'Stu 4', 4)