USE MusicStore;
GO

--Shows all albums, which are available to buy now.
CREATE PROCEDURE sp_DistributorAlbums_noFilters
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
CREATE PROCEDURE sp_DistributorAlbums_Filters
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

