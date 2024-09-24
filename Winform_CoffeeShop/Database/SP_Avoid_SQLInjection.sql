select * from dbo.Account

CREATE PROC USP_Login
@userName nvarchar(100), @password nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE DisplayName = @userName and Password = @password
END
Go

select * from dbo.Account where DisplayName = N'' OR 1=1; -- Sql Injection query to retrieve data