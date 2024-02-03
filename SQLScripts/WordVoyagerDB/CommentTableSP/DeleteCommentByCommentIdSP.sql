--Stored Procedure for Deleting Comment by Comment Id
--UseCase: When a User wants to delete a Comment
CREATE PROCEDURE uspDeleteCommentByCommentId
	@CommentId int
AS
BEGIN
	DELETE FROM Comment WHERE CommentId = @CommentId;
END

--Executing DeleteCommentByCommentId Stored Procedure 
EXECUTE uspDeleteCommentByCommentId 1;

--Deleting DeleteCommentByCommentId Stored Procedure 
DROP PROCEDURE uspDeleteCommentByCommentId;
