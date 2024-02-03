--Stored Procedure for Updating a comment
--UseCAse: When User wants to update an Existing Comment
CREATE PROCEDURE uspUpdateCommentByCommentId
	@CommentId int,
	@Content text
AS
BEGIN
	UPDATE Comment
	SET Content =  @Content
	WHERE CommentId = @CommentId
END

--Executing UpdateCommentByCommentId Stored Procedure
EXECUTE uspUpdateCommentByCommentId 1, "This articls gives 360 view of food habits";

--Deleting UpdateCommentByCommentId Stored Procedure
DROP PROCEDURE uspUpdateCommentByCommentId;