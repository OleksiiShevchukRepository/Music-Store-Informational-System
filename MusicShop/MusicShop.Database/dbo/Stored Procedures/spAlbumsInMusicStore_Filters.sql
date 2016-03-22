
--Shows all albums of selected genre in music shop storage, no filters
CREATE PROCEDURE spAlbumsInMusicStore_Filters
	@GenreId INT
AS
BEGIN
	SELECT alb.Id as id, alb.Name as albName, art.Name as artName, g.Name as genre, ass.PriceRealisation as price,
	alb.RatingAllMusicCom as rateAllmusic, ass.Amount as amount FROM tblAlbum as alb
	LEFT JOIN tblArtist as art
	ON art.Id = alb.ArtistId
	INNER JOIN tblAlbumsInShopStorage as ass
	ON ass.AlbumID = alb.Id
	LEFT JOIN tblAlbumGenre as ag
	ON alb.Id = ag.AlbumId
	INNER JOIN tblGenre as g
	ON ag.GenreID = g.Id
	WHERE g.Id = @GenreId
END
