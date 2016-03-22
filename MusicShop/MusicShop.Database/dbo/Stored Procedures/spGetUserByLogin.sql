
CREATE PROCEDURE spGetUserByLogin
	@Login NVARCHAR(50),
	@Password VARCHAR(200)
AS
BEGIN
	SELECT s.Id, s.Name, s.Surname, sa.[Disabled]
	FROM tblSeller as s
	INNER JOIN tblSellerAuth as sa ON
	sa.Id = s.Id
	WHERE @Login = sa.[Login] AND @Password = sa.[Password] AND sa.[DISABLED] <> 1
END
