--Stored Procedure for Fetching comments by ArticleId
--UseCase: When displaying all the Comments related to an Article
CREATE PROCEDURE uspGetCommentsByArticleId
	@ArticleId int
AS
BEGIN
	SELECT * FROM Comment WHERE ArticleId = @ArticleId;
END

--Executing GetCommentsByArticleId Stored Procedure
EXECUTE uspGetCommentsByArticleId 4;

--Deleting GetCommentsByArticleId Stored Procedure
DROP PROCEDURE uspGetCommentsByArticleId;
