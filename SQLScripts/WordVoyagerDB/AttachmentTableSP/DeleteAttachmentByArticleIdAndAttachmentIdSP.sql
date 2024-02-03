--Stored Procedure for deleting attachment by ArticleId and AttachmentId
--UseCase: When deleting an Attachment attached to an Article
CREATE PROCEDURE uspDeleteAttachmentByArticleIdAndAttchmentId
	@ArticleId int,
	@AttachmentId int
AS
BEGIN
	Delete FROM Attachment
	WHERE ArticleId = @ArticleId AND AttachmentId =  @AttachmentId;
END

--Executing DeleteAttachmentByArticleIdAndAttchmentId Stored Procedure 
EXECUTE uspDeleteAttachmentByArticleIdAndAttchmentId 1, 5;

--Deleting DeleteAttachmentByArticleIdAndAttchmentId Stored Procedure
DROP PROCEDURE uspDeleteAttachmentByArticleIdAndAttchmentId;