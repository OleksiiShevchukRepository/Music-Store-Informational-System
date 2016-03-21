CREATE PROCEDURE spAlbumsInMusicStore_noFilters
AS
BEGIN
	SELECT tblAlbum.Name as albName, tblArtist.Name as artName, tblAlbumsInShopStorage.PriceRealisation as price,
	tblAlbum.RatingAllMusicCom as rateAllMusic, tblAlbumsInShopStorage.Amount as amount, tblAlbum.LiquidRate as liquidity FROM tblAlbum
	LEFT JOIN tblArtist
	ON tblArtist.Id = tblAlbum.ArtistId
	INNER JOIN tblAlbumsInShopStorage ON
	tblAlbumsInShopStorage.AlbumID = tblAlbum.Id
END
