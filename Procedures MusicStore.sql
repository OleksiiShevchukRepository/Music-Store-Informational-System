USE MusicStore;
GO

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
GO

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
GO


CREATE PROCEDURE spSelectAllFromGenre
AS
BEGIN
	SELECT Id, Name FROM tblGenre
END
GO

CREATE PROCEDURE spCreateCheck
	@SellerId INT,
	@TotalSum DECIMAL(19, 2)
AS
BEGIN
	INSERT INTO tblCheck (SellerId, SumOverall, DateStatement)
	VALUES (@SellerId, @TotalSum, GETDATE())
END
GO

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
GO

CREATE PROCEDURE spCheckInfo
AS
BEGIN
	SELECT TOP 1 ch.Id as id, ch.SumOverall as total, ch.DateStatement as [date],
	s.Name as name, s.Surname as surname FROM tblCheck as ch
	INNER JOIN tblSeller as s ON
	s.Id = ch.SellerId
	WHERE ch.Id = (SELECT TOP 1 ch.Id FROM tblCheck ORDER BY ch.Id DESC);
END
GO