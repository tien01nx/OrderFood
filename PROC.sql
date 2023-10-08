ALTER PROCEDURE sp_GetUserOrderDetails 
    @StartDate NVARCHAR(20) = NULL,
    @EndDate NVARCHAR(20) = NULL,
    @UserName NVARCHAR(255) = NULL,
    @Restaurants INT = NULL,
    @ProductName NVARCHAR(255) = NULL
AS
BEGIN
    SELECT 
        U.UserName AS UserName,
		 ISNULL(OD.Id, '0') AS 'OrderDetailID',
        ISNULL(P.ProductName, '0') AS ProductName,
        ISNULL(P.Id, '0') AS ProductId,
        SUM(ISNULL(OD.Count, 0)) AS 'TotalQuantity',
        SUM(ISNULL(OD.Price, 0)) AS 'TotalPrice'
    FROM 
        dbo.AspNetUsers AS U
    LEFT JOIN 
        dbo.OrderDetails AS OD ON U.Id = OD.UserId
        AND ( 
            ( @StartDate IS NOT NULL AND @EndDate IS NULL AND CAST(OD.CreateDate AS DATE) = @StartDate ) OR 
            ( @StartDate IS NOT NULL AND @EndDate IS NOT NULL AND CAST(OD.CreateDate AS DATE) BETWEEN @StartDate AND @EndDate ) OR
            ( @StartDate IS NULL AND @EndDate IS NULL )
        )
    LEFT JOIN 
        Orders ON Orders.Id = OD.OrderId
    LEFT JOIN 
        dbo.Products AS P ON OD.ProductId = P.Id
    LEFT JOIN 
        Restaurants ON Orders.RestaurantId = Restaurants.Id
    WHERE
        ( 
            ( Restaurants.Id = ISNULL(@Restaurants, Restaurants.Id) ) OR 
            Restaurants.Id IS NULL 
		
        )
        AND ( @UserName IS NULL OR U.UserName LIKE '%' + @UserName + '%' )
        AND ( @ProductName IS NULL OR P.ProductName LIKE '%' + @ProductName + '%' )

		
    GROUP BY
        U.UserName,
		ISNULL(OD.Id, '0'),
        ISNULL(P.ProductName, '0'),
        ISNULL(P.Id, '0');
END


EXEC sp_GetUserOrderDetails 
@StartDate = '2023-10-08',
@EndDate = null,
@UserName = null,
@Restaurants = null,
@ProductName = null;


-- lấy ra đơn hàng của hàng hiện tại và prodct
ALTER PROCEDURE sp_GetProductsByOrderDate 
    @OrderDate NVARCHAR(50) 
AS
BEGIN
    SELECT DISTINCT Products.*
    FROM Orders 
    JOIN Restaurants ON Orders.RestaurantId = Restaurants.Id
    JOIN Products ON Restaurants.Id = Products.RestaurantID
   
    WHERE Orders.CreateDate = CAST(@OrderDate AS DATE)
END



EXEC sp_GetProductsByOrderDate @OrderDate = '2023-10-08'
