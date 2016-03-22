
CREATE PROCEDURE spCreateCheck
	@SellerId INT,
	@TotalSum DECIMAL(19, 2)
AS
BEGIN
	INSERT INTO tblCheck (SellerId, SumOverall, DateStatement)
	VALUES (@SellerId, @TotalSum, GETDATE())
END
