
CREATE PROCEDURE spClearStorage
AS
BEGIN
	DELETE FROM tblAlbumsInShopStorage
	WHERE Amount = 0;
END
