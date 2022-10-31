 
 
 IF OBJECT_ID('[dbo].[Product]', 'U') IS NULL
 BEGIN
 CREATE TABLE Product(
 [ProductId] INT IDENTITY(1,1),
 [ProductName] NVARCHAR(255) NOT NULL,
 [Price] DECIMAL NOT NULL,
 [ReleaseDate] DATETIME NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY ([ProductId] ASC)
);
END
GO

 IF OBJECT_ID('[dbo].[ProductComment]', 'U') IS NULL
 BEGIN
CREATE TABLE ProductComment(
 [ProductCommentId] INT IDENTITY(1,1) NOT NULL,
 [ProductComment] NVARCHAR(MAX) NOT NULL,
 [Email] NVARCHAR(256) NOT NULL,
 [DateOfComment] DATETIME NOT NULL,
 [ProductId] INT NOT NULL,
 CONSTRAINT [FK_ProductComment_Product] FOREIGN KEY ([ProductId]) REFERENCES [Product]([ProductId]),
 CONSTRAINT [PK_DataCycleNotes] PRIMARY KEY ([ProductCommentId] ASC)
);
END
GO