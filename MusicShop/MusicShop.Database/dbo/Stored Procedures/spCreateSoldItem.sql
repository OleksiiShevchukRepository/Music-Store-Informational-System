
CREATE PROCEDURE spCreateSoldItem
	@AlbumId INT,
	@Amount INT,
	@Price DECIMAL(19, 2)
AS
BEGIN
	DECLARE @CheckID INT;
	DECLARE	@CheckDate DATETIME;
	SET @CheckID = (SELECT TOP 1 Id FROM tblCheck ORDER BY Id DESC);
	SET @CheckDate = (SELECT TOP 1 DateStatement FROM tblCheck ORDER BY DateStatement DESC)
	INSERT INTO tblSoldItem (AlbumId, CheckId, SellDate, Amount, SumItems)
	VALUES (@AlbumId, @CheckID, @CheckDate, @Amount, @Price);
END
