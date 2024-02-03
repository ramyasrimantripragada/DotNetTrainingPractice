--Stored Procedure for inserting Article Tag
--Usecase: When attaching a Tag to an Article
CREATE PROCEDURE uspInsertArticleTag
	@ArticleId int,
	@TagId int
AS
BEGIN
	INSERT INTO ArticleTag(ArticleId, TagId)
	VALUES(@ArticleId, @TagId);
END


--Executing InsertArticleTag Stored Procedure
EXECUTE uspInsertArticleTag 3, 2;


--Deleting InsertArticleTag Stored Procedure
DROP PROCEDURE uspInsertArticleTag;
