--Stored Procedure for fetching Attachments related to an Article by ArticleId
--UseCase: When fetching all attachments attached to an Article
CREATE PROCEDURE uspGetAllAttachementsByArticleId
	@ArticleId int
AS
BEGIN 
	SELECT * FROM Attachment
	WHERE ArticleId =  @ArticleId;
END

--Executing GetAllAttachementsByArticleId Stored Procedure
EXECUTE uspGetAllAttachementsByArticleId 1;

--Deleting GetAllAttachementsByArticleId Stored Procedure
DROP PROCEDURE uspGetAllAttachementsByArticleId;