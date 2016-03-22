
CREATE PROCEDURE spAuthUser
	@Id INT
AS
BEGIN
	UPDATE tblSellerAuth
	SET Disabled = 1
	WHERE @Id = Id
END
