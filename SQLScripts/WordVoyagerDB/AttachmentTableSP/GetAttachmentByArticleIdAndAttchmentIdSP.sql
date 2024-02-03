--Stored Procedure for fetching an Attachment by ArticleId and AttachmentId
--UseCase: When fetching a specific Attachment of an Article
CREATE PROCEDURE uspGetAttachementByArticleIdAndAttachmentId
	@ArticleId int,
	@AttachmentId int
AS
BEGIN 
	SELECT * FROM Attachment
	WHERE ArticleId =  @ArticleId AND AttachmentId = @AttachmentId;
END

--Executing GetAllAttachementsByArticleId Stored Procedure
EXECUTE uspGetAttachementByArticleIdAndAttachmentId 1, 0;

--Deleting GetAllAttachementsByArticleId Stored Procedure
DROP PROCEDURE uspGetAttachementByArticleIdAndAttachmentId;