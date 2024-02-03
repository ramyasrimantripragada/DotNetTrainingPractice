--Stored Procedure for Inserting a new Comment
--UseCase: When a User comments on an Article
CREATE PROCEDURE uspInsertComment
	@ArticleId int,
	@UserId int,
	@Content text
AS
BEGIN 
	INSERT INTO Comment(ArticleId, UserId, Content, CommentDate)
	VALUES(@ArticleId, @UserId, @Content, GETDATE());
END

--Executing InsertComment Stored Procedure
EXECUTE uspInsertComment 4, 4, "Very helpful, thanks";

--Deleting InsertComment Stored Procedure
DROP PROCEDURE uspInsertComment;