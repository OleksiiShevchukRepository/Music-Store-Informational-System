
--Shows all albums of selected genre in music shop storage, no filters
CREATE PROCEDURE spAlbumsInMusicStore_Filters
	@GenreId INT
AS
BEGIN
	SELECT tblAlbum.Name, tblArtist.Name, tblGenre.Name, tblAlbumsInShopStorage.PriceRealisation, tblAlbum.RatingAllMusicCom, tblAlbum.LiquidRate FROM tblAlbum
	LEFT JOIN tblArtist
	ON tblArtist.Id = tblAlbum.ArtistId
	INNER JOIN tblAlbumsInShopStorage ON
	tblAlbumsInShopStorage.AlbumID = tblAlbum.Id
	LEFT JOIN tblAlbumGenre
	ON tblAlbum.Id = tblAlbumGenre.AlbumId
	INNER JOIN tblGenre
	ON tblAlbumGenre.GenreID = tblGenre.Id
	WHERE tblGenre.Id = @GenreId
END
