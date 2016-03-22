
CREATE PROCEDURE spCheckInfo
AS
BEGIN
	SELECT TOP 1 ch.Id as id, ch.SumOverall as total, ch.DateStatement as [date],
	s.Name as name, s.Surname as surname FROM tblCheck as ch
	INNER JOIN tblSeller as s ON
	s.Id = ch.SellerId
	WHERE ch.Id = (SELECT TOP 1 ch.Id FROM tblCheck ORDER BY ch.Id DESC);
END
