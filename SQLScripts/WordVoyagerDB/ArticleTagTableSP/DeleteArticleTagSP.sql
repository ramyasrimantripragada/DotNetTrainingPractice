--Stored Procedure for deleting ArticleTag by ArticleId and TagId
--UseCase: When deleting a tag attached to an Article
CREATE PROCEDURE uspDeleteArticleTag
	@ArticleId int,
	@TagId int
AS
BEGIN
	DELETE FROM ArticleTag 
	WHERE ArticleId = @ArticleId AND TagId =  @TagId;
END

--Executing DeleteArticleTag Stored Procedure
EXECUTE uspDeleteArticleTag 1,5;

--Deleting DeleteArticleTag Stored Procedure
DROP PROCEDURE uspDeleteArticleTag;