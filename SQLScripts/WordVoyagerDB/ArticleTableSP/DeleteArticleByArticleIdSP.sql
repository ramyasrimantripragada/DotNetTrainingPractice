--Creating a new Stored Procedure for deleting article by ArticleId
CREATE PROCEDURE uspDeleteArticleByArticleId
	@ArticleId int
AS
BEGIN
	DELETE FROM Article WHERE ArticleId =  @ArticleId;
END
GO

--Executing DeleteArticleByArticleId Stored Procedure
EXECUTE uspDeleteArticleByArticleId 1;
GO

--Deleting DeleteArticleByArticleId Stored Procedure
DROP PROCEDURE uspDeleteArticleByArticleId;
GO