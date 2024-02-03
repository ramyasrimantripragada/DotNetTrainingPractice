--Stored Procedure for fetching ArticleTags by ArticleId
--UseCase: When fetching all the tags related to an Article
CREATE PROCEDURE uspGetArticleTagsByArticleId
	@ArticleId int
AS
BEGIN
	SELECT * FROM ArticleTag WHERE ArticleId =  @ArticleId;
END

--Executing GetArticleTagsByArticleId Stored Procedure
EXECUTE uspGetArticleTagsByArticleId 4;

--Deleting GetArticleTagsByArticleId Stored Procedure
DROP PROCEDURE uspGetArticleTagsByArticleId;