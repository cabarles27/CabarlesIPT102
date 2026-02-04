CREATE PROCEDURE [dbo].[GetPOS]

    @POSId INT
AS
BEGIN
    SELECT *
    FROM [dbo].[POS]
    WHERE Id = @POSId;
END