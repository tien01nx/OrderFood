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




EXEC sp_GetUserCartDetails 2,'2023-10-4'

Go
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



	Go
	ALTER PROCEDURE sp_GetUserOrderDetails 
    @StartDate NVARCHAR(20) = NULL,
    @EndDate NVARCHAR(20) = NULL,
    @UserName NVARCHAR(255) = NULL,
	@IdUser NVARCHAR(255) = NULL,
    @Restaurants INT = NULL,
    @ProductName NVARCHAR(255) = NULL
AS
BEGIN
    SELECT 
        U.UserName AS UserName,
		ISNULL(Restaurants.RestaurantName, 'N/A') AS 'RestaurantName',
        ISNULL(P.ProductName, '0') AS ProductName,
		SUM(ISNULL(OD.Count, 0)) AS 'TotalQuantity',
        SUM(ISNULL(OD.Price, 0)) AS 'TotalPrice',
		ISNULL(OD.Id, '0') AS 'OrderDetailID',
        ISNULL(P.Id, '0') AS ProductId,
		ISNULL(Orders.Id, '0') AS OrderId,
		ISNULL(Restaurants.Id, '0') AS 'RestaurantId'
        
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
        AND ( @IdUser IS NULL OR U.Id = @IdUser ) 
    GROUP BY
        U.UserName,
        ISNULL(OD.Id, '0'),
        ISNULL(P.ProductName, '0'),
		ISNULL(Orders.Id, '0'),
		ISNULL(Restaurants.RestaurantName, 'N/A'),
        ISNULL(P.Id, '0'),
		ISNULL(Restaurants.Id, '0');
END




EXEC sp_GetUserOrderDetails 
@StartDate = '2023-10-09',
@EndDate = null,
@UserName = null,
@IdUser =2,
@Restaurants = null,
@ProductName = null




Go
ALTER PROCEDURE SearchRestaurants
    @RestaurantName NVARCHAR(300),
    @FavoriteLevel TINYINT,
    @SearchTime TIME
AS
BEGIN
    SELECT *
    FROM [dbo].[Restaurants]
    WHERE 
        (CASE 
             WHEN @RestaurantName IS NOT NULL THEN 
                 CASE WHEN CHARINDEX(@RestaurantName, RestaurantName) > 0 THEN 1 ELSE 0 END
             ELSE 1
         END = 1)
    AND
        (CASE 
             WHEN @FavoriteLevel IS NOT NULL THEN 
                 CASE WHEN FavoriteLevel = @FavoriteLevel THEN 1 ELSE 0 END
             ELSE 1
         END = 1)
    AND
        (CASE 
             WHEN @SearchTime IS NOT NULL THEN 
                 CASE WHEN @SearchTime BETWEEN OpenTime AND CloseTime THEN 1 ELSE 0 END
             ELSE 1
         END = 1);
END;
GO


EXEC SearchRestaurants
    @RestaurantName = null,
    @FavoriteLevel = '4',
    @SearchTime = null;




Go
-- IF ELSE
ALTER PROCEDURE GetRestaurantData
    @RestaurantName nvarchar(300) = NULL
AS
BEGIN
    IF @RestaurantName IS NULL
    BEGIN

        SELECT ISNULL(Null, 'N/A') 'CategoryName', RestaurantName,Restaurants.Id AS 'RestaurantId'
        FROM Restaurants
    END
    ELSE
    BEGIN
        SELECT C.CategoryName, R.RestaurantName, R.Id as 'RestaurantId'
        FROM Restaurants R
        INNER JOIN Categories C ON R.Id = C.RestaurantID
        WHERE R.Id = @RestaurantName
    END
END


-- CASE when then 
Go
CREATE PROCEDURE GetRestaurantData
    @RestaurantName nvarchar(300) = NULL
AS
BEGIN
    SELECT C.*,R.RestaurantName
    FROM Restaurants R
    LEFT JOIN Categories C ON R.Id = C.RestaurantID
    WHERE 
        (CASE 
            WHEN @RestaurantName IS NULL THEN 1
            WHEN R.RestaurantName = @RestaurantName THEN 1
            ELSE 0
        END) = 1
END


exec GetRestaurantData '3'