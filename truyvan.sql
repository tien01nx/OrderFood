-- UserOrderAll

ALTER PROCEDURE sp_GetOrderUser
    @TargetDate NVARCHAR(20) = NULL,
    @UserName NVARCHAR(256) = NULL,
    @ProductTile NVARCHAR(MAX) = NULL 
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)

    SET @SQL = '
        SELECT 
		 ISNULL(C.Id, 0) AS Id,
            U.UserName,
            ISNULL(C.ProductId, 0) AS ProductId,
            COALESCE(P.Title, ''N/A'') AS Title,
            SUM(ISNULL((C.Count * P.Price), 0)) AS TotalPrice,
            SUM(ISNULL(C.Count, 0)) AS TotalQuantity
        FROM 
            AspNetUsers U
        LEFT JOIN 
            Carts C ON U.Id = C.UserId '
    + CASE WHEN @TargetDate IS NOT NULL THEN 'AND CAST(C.CreateDate AS DATE) = @Date ' ELSE ' ' END +
    'LEFT JOIN 
            Products P ON C.ProductId = P.Id
        WHERE 
            1=1 '
    + CASE WHEN @UserName IS NOT NULL THEN 'AND U.UserName LIKE ''%'' + @User + ''%'' ' ELSE ' ' END +
    + CASE WHEN @ProductTile IS NOT NULL THEN 'AND P.Title LIKE ''%'' + @Product + ''%'' ' ELSE ' ' END +
    'GROUP BY 
            U.UserName, C.ProductId, P.Title'

    EXEC sp_executesql @SQL, N'@Date DATE, @User NVARCHAR(256), @Product NVARCHAR(MAX)', @Date = @TargetDate, @User = @UserName, @Product = @ProductTile
END



EXEC sp_GetOrderUser @TargetDate = '2023-10-04',@UserName= null,@ProductTile = null


select * from AspNetUsers 
Left join OrderDetails  on AspNetUsers.Id = OrderDetails.UserId
Left join Products on Products.Id = OrderDetails.ProductId
where OrderDetails.CreateDate ='2023-10-7'


-- thông tin người dùng mua hàng theo useid
Go
ALTER PROCEDURE sp_GetUserCartDetails
    @UserId nvarchar(450),
    @Date date
AS
BEGIN
    SELECT 
		C.Id,
        U.UserName,
        C.ProductId,
        C.OrderId,
        COALESCE(P.Title, 'N/A') AS Title,
        SUM(ISNULL((C.Count * P.Price), 0)) AS TotalPrice,
        SUM(ISNULL(C.Count, 0)) AS TotalQuantity
    FROM 
        [dbo].[AspNetUsers] U
    INNER JOIN 
        [dbo].[Carts] C ON U.Id = C.UserId
    INNER JOIN 
        [dbo].[Products] P ON C.ProductId = P.Id
    WHERE 
        CAST(C.CreateDate AS DATE) = @Date AND C.UserId = @UserId
    GROUP BY 
       C.Id, U.UserName, C.ProductId, C.OrderId, P.Title
END


EXEC sp_GetUserCartDetails 2,'2023-10-4'


use orderfood EXEC sp_changedbowner 'sa'



select * from Orders  join OrderDetails on Orders.Id = OrderDetails.OrderId



SELECT 
    U.UserName AS UserName,
    ISNULL(P.ProductName, '0') AS ProductName,
	ISNULL(P.Id, '0') AS ProductId,
    ISNULL(OD.Count, 0) AS Count,
    ISNULL(OD.Price, 0) AS Price

FROM 
    dbo.AspNetUsers AS U
LEFT JOIN 
    dbo.OrderDetails AS OD ON U.Id = OD.UserId
	And  
      OD.CreateDate = '2023-10-07'
Left join Orders on Orders.Id  = OD.OrderId
	And Orders.CreateDate    = '2023-10-07'
LEFT JOIN 
    dbo.Products AS P ON OD.ProductId = P.Id
Left join Restaurants on Orders.RestaurantId = Restaurants.Id
	and Orders.RestaurantId=3



SELECT 
    U.UserName AS UserName,
    ISNULL(P.ProductName, '0') AS ProductName,
    ISNULL(P.Id, '0') AS ProductId,
    SUM(ISNULL(OD.Count, 0)) AS 'Số lương',
    SUM(ISNULL(OD.Price,0)) AS 'Thành tiền'
FROM 
    dbo.AspNetUsers AS U
LEFT JOIN 
    dbo.OrderDetails AS OD ON U.Id = OD.UserId
    AND OD.CreateDate = '2023-10-07'
LEFT JOIN Orders ON Orders.Id = OD.OrderId
    AND Orders.CreateDate = '2023-10-07'
LEFT JOIN 
    dbo.Products AS P ON OD.ProductId = P.Id
Left  JOIN Restaurants ON Orders.RestaurantId = Restaurants.Id
    WHERE
    (Restaurants.Id = 3 OR Restaurants.Id IS NULL)
GROUP BY
    U.UserName,
    ISNULL(P.ProductName, '0'),
    ISNULL(P.Id, '0');




