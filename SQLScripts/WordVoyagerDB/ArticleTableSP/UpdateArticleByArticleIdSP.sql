--Creating a new Stored Procedure for Updating Article using ArticleId
CREATE PROCEDURE uspUpdateArticleByArticleId
	@ArticleId int,
	@Title NVARCHAR(100),
	@Content NVARCHAR(100),
	@CategoryId int
AS
BEGIN
	UPDATE Article
	SET Title = @Title, Content = @Content, LastModifiedDate = GETDATE(), CategoryId = @CategoryId
	WHERE ArticleId = @ArticleId;
END
GO

--Executing UpdateArticleByArticleId Stored Procedure
EXECUTE uspUpdateArticleByArticleId 2, "Home cooking: Good for your health", "Can you imagine if you went to your primary care doctor's office for cooking classes? What if your visit...", 3;
GO

--Deleting UpdateArticleByArticleId Stored Procedure
DROP PROCEDURE uspUpdateArticleByArticleId;
GO
