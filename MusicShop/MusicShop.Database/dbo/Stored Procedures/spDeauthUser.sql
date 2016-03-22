
CREATE PROCEDURE spDeauthUser
	@Id INT
AS
BEGIN
	UPDATE tblSellerAuth
	SET Disabled = 0
	WHERE @Id = Id
END
