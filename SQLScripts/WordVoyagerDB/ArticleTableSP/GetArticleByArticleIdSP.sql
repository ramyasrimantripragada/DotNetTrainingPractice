--Creating a new Stored Procedure for fetching Article by ArticleId
CREATE PROCEDURE uspGetArticleByArticleId
	@ArticleId int
AS
BEGIN
	SELECT * FROM Article WHERE ArticleId = @ArticleId;
END
GO

--Executing GetArticleByArticleId Stored Procedure
EXECUTE uspGetArticleByArticleId 1;
GO

--Deleting GetArticleByArticleId Stored Procedure
DROP PROCEDURE uspGetArticleByArticleId;
GO
