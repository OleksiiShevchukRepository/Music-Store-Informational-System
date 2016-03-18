USE MusicStore;
GO

--Shows all albums, which are available to buy now.
CREATE PROCEDURE spDistributorAlbums_noFilters
AS
BEGIN
	SELECT tblAlbum.NAME, tblArtist.Name, tblDistributor.Name, tblDistributorAlbums.Price, tblAlbum.LiquidRate FROM tblAlbum
	LEFT JOIN tblArtist
	ON tblArtist.Id = tblAlbum.ArtistId
	INNER JOIN tblDistributorAlbums
	ON tblDistributorAlbums.AlbumId = tblAlbum.Id
	INNER JOIN tblDistributor
	ON tblDistributorAlbums.DistributorId = tblDistributor.Id;
	--ORDER BY tblAlbum.NAME
END
GO

--Shows all albums in select genre, which are available to buy now.
CREATE PROCEDURE spDistributorAlbums_Filters
	@GenreId INT
AS
BEGIN
	SELECT tblAlbum.NAME, tblArtist.Name, tblGenre.Name, tblDistributor.Name, tblDistributorAlbums.Price, tblAlbum.LiquidRate FROM tblAlbum
	LEFT JOIN tblAlbumGenre
	ON tblAlbum.Id = tblAlbumGenre.AlbumId
	LEFT JOIN tblArtist
	ON tblArtist.Id = tblAlbum.ArtistId
	INNER JOIN tblGenre
	ON tblAlbumGenre.GenreID = tblGenre.Id
	INNER JOIN tblDistributorAlbums
	ON tblDistributorAlbums.AlbumId = tblAlbum.Id
	INNER JOIN tblDistributor
	ON tblDistributorAlbums.DistributorId = tblDistributor.Id
	WHERE tblGenre.Id = @GenreId
	--ORDER BY tblAlbum.NAME
END
GO

--Shows all albums in music shop storage, no filters
CREATE PROCEDURE spAlbumsInMusicStore_noFilters
AS
BEGIN
	SELECT tblAlbum.Name, tblArtist.Name, tblAlbumsInShopStorage.PriceRealisation, tblAlbum.RatingAllMusicCom, tblAlbum.LiquidRate FROM tblAlbum
	LEFT JOIN tblArtist
	ON tblArtist.Id = tblAlbum.ArtistId
	INNER JOIN tblAlbumsInShopStorage ON
	tblAlbumsInShopStorage.AlbumID = tblAlbum.Id
END
GO

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
GO

