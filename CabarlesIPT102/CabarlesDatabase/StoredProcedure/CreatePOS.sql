CREATE PROCEDURE [dbo].[CreatePOS]
 @Id NVARCHAR(100),
    @ProductName NVARCHAR(100),
    @Price INT,
    @Quantity NVARCHAR(100),
    @TotalAmount INT
AS
BEGIN
    INSERT INTO [dbo].[POS] (Id, ProductName, Price, Quantity, TotalAmount)
    VALUES (@Id, @ProductName, @Price, @Quantity, @TotalAmount);
    
    SELECT SCOPE_IDENTITY() AS POSId;
END