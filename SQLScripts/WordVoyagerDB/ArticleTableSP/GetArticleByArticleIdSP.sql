--Stored Procedure for fetching Article by ArticleId
--UseCase: When only a particular Article needs to be displayed
CREATE PROCEDURE uspGetArticleByArticleId
	@ArticleId int
AS
BEGIN
	SELECT * FROM Article WHERE ArticleId = @ArticleId;
END

--Executing GetArticleByArticleId Stored Procedure
EXECUTE uspGetArticleByArticleId 1;

--Deleting GetArticleByArticleId Stored Procedure
DROP PROCEDURE uspGetArticleByArticleId;

