--Stored Procedure to delete User by UserId
CREATE PROCEDURE uspDeleteUserByUserId 
	@UserId int
AS
BEGIN
	DELETE FROM [User] WHERE UserId = @UserId;
END
GO

--Executing DeleteUserByUserId
EXECUTE uspDeleteUserByUserId 1;

--Deleting DeleteUserByUserId stored procedure
DROP PROCEDURE uspDeleteUserByUserId;
