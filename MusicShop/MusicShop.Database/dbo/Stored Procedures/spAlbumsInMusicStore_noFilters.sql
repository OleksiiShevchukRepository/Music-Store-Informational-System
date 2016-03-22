
--Shows all albums in music shop storage, no filters
CREATE PROCEDURE spAlbumsInMusicStore_noFilters
AS
BEGIN
	SELECT alb.Id as id, alb.Name as albName, art.Name as artName, ass.PriceRealisation as price,
	alb.RatingAllMusicCom as rateAllMusic, ass.Amount as amount FROM tblAlbum as alb
	LEFT JOIN tblArtist as art
	ON art.Id = alb.ArtistId
	INNER JOIN tblAlbumsInShopStorage as ass ON
	ass.AlbumID = alb.Id
END
