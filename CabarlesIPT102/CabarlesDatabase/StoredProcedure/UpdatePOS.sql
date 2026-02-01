CREATE PROCEDURE [dbo].[UpdatePOS]

  @Id INT,
    @ProductName NVARCHAR(100),
    @Price NVARCHAR(100),
    @Quantity INT,
    @TotalAmount INT
AS
BEGIN
    UPDATE [dbo].[POS]
    SET
           ProductName = @ProductName,
        Price = @Price,
        Quantity = @Quantity,
        TotalAmount  = @TotalAmount
    WHERE Id = @Id;
END