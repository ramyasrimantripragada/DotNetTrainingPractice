--Stored Procedure for deleting article by ArticleId
--UseCase: When a user(Author) wants to delete an article
CREATE PROCEDURE uspDeleteArticleByArticleId
	@ArticleId int
AS
BEGIN
	DELETE FROM Article WHERE ArticleId =  @ArticleId;
END

--Executing DeleteArticleByArticleId Stored Procedure
EXECUTE uspDeleteArticleByArticleId 1;

--Deleting DeleteArticleByArticleId Stored Procedure
DROP PROCEDURE uspDeleteArticleByArticleId;
