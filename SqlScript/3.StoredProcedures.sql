
IF EXISTS (
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'spGetProductsList'
)

DROP PROCEDURE [dbo].[spGetProductsList]
GO

CREATE PROCEDURE [dbo].[spGetProductsList]  
AS  
BEGIN  
	SELECT  [ProductId],[ProductName],[Price],[ReleaseDate]
	FROM [dbo].[Product]
END 
GO

IF EXISTS (
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'spGetProductByProductId'
)

DROP PROCEDURE [dbo].[spGetProductByProductId]
GO

CREATE PROCEDURE [dbo].[spGetProductByProductId] 
@ProductId INT
AS  
BEGIN  
	SELECT  [ProductId],[ProductName],[Price],[ReleaseDate]
	FROM [dbo].[Product]
	WHERE [ProductId] = @ProductId
END 
GO

IF EXISTS (
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'spAddProduct'
)

DROP PROCEDURE [dbo].[spAddProduct]
GO

CREATE PROCEDURE [dbo].[spAddProduct]  
@ProductName NVARCHAR(250),
@Price DECIMAL,
@ReleaseDate DATETIME
AS  
BEGIN  
SET NOCOUNT ON;
INSERT INTO Product([ProductName],[Price],[ReleaseDate])
VALUES(@ProductName,@Price,@ReleaseDate)
END 
GO


IF EXISTS (
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'spUpdateProduct'
)

DROP PROCEDURE [dbo].[spUpdateProduct]
GO

CREATE PROCEDURE [dbo].[spUpdateProduct]  
@ProductId INT,
@ProductName NVARCHAR(250),
@Price DECIMAL,
@ReleaseDate DATETIME
AS  
BEGIN  
SET NOCOUNT ON;
UPDATE Product SET [ProductName]=@ProductName,[Price]=@Price,[ReleaseDate]=@ReleaseDate
WHERE ProductId = @ProductId
END
GO

IF EXISTS (
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'spDeleteProduct'
)

DROP PROCEDURE [dbo].[spDeleteProduct]
GO

CREATE PROCEDURE [dbo].[spDeleteProduct]  
@ProductId INT
AS  
BEGIN  
SET NOCOUNT ON;
DELETE FROM Product WHERE ProductId = @ProductId
END
GO

--Product Comment Stored Procedure

IF EXISTS (
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'spGetCommentsByProductId'
)

DROP PROCEDURE [dbo].[spGetCommentsByProductId]
GO

CREATE PROCEDURE [dbo].[spGetCommentsByProductId]  
@ProductId INT
AS  
BEGIN  
	SELECT  pc.[ProductCommentId],pc.[ProductComment],pc.[Email],pc.[DateOfComment],p.[ProductName]
	FROM [dbo].[ProductComment] pc
	INNER JOIN [dbo].[Product] p ON p.[ProductId] = pc.[ProductId]
	WHERE pc.[ProductId] = @ProductId
END 
GO

IF EXISTS (
SELECT *
FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'spAddProductComment'
)

DROP PROCEDURE [dbo].[spAddProductComment]
GO

CREATE PROCEDURE [dbo].[spAddProductComment] 
@ProductComment NVARCHAR(MAX),
@Email NVARCHAR(255),
@DateOfComment DATETIME,
@ProductId INT
AS
BEGIN  
SET NOCOUNT ON;
INSERT INTO [dbo].[ProductComment]([ProductComment],[Email],[DateOfComment],[ProductId])
VALUES(@ProductComment,@Email,@DateOfComment,@ProductId)
END 
GO
