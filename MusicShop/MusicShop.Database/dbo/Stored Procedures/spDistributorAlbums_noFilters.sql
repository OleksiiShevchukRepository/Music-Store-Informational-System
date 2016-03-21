
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
