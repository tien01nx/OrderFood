
ALTER  PROCEDURE sp_GetOrderUser
    @TargetDate DATE,
    @UserName NVARCHAR(256),
    @ProductTile NVARCHAR(MAX) 
AS
BEGIN
  
    SELECT 
        U.UserName,
        C.ProductId,
        C.OrderId,
        COALESCE(P.Title, 'N/A') AS Title,
        SUM(ISNULL((C.Count * P.Price), 0)) AS TotalPrice,
        SUM(ISNULL(C.Count, 0)) AS TotalQuantity
    FROM 
        [dbo].[AspNetUsers] U
    LEFT JOIN 
        [dbo].[Carts] C ON U.Id = C.UserId AND CAST(C.CreateDate AS DATE) = @TargetDate
    LEFT JOIN 
        [dbo].[Products] P ON C.ProductId = P.Id
    WHERE 
        U.UserName LIKE '%' + @UserName + '%' 
        OR P.Title LIKE '%' + @ProductTile + '%'
    GROUP BY 
        U.UserName, C.ProductId, C.OrderId, P.Title
END


EXEC sp_GetOrderUser'2023-10-04','',''



-- thông tin người dùng mua hàng theo useid
Go
CREATE PROCEDURE sp_GetUserCartDetailsByDateAndUserId
    @UserId nvarchar(450),
    @Date date
AS
BEGIN
    SELECT 
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
        U.UserName, C.ProductId, C.OrderId, P.Title
END


EXEC sp_GetUserCartDetailsByDateAndUserId 2,'2023-10-04'