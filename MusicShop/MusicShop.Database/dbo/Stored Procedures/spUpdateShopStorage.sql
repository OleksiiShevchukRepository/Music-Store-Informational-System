
CREATE PROCEDURE spUpdateShopStorage
	@AlbumId INT,
	@Price DECIMAL (19, 2),
	@Amount INT
AS
BEGIN
	IF (SELECT ass.Amount
		FROM tblAlbumsInShopStorage AS ass
		WHERE ass.AlbumId = @AlbumId AND ass.PriceRealisation = @Price) < @Amount
		BEGIN
		THROW 15600, 'Data mismatch. Refresh table', 1;
		END
	UPDATE tblAlbumsInShopStorage
	SET Amount = Amount - @Amount
	WHERE AlbumId = @AlbumId AND PriceRealisation = @Price;
END
