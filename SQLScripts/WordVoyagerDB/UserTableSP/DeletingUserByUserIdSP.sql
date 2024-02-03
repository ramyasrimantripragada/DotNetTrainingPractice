--Stored Procedure to delete User by UserId
--UseCase: When a User deletes his Account
CREATE PROCEDURE uspDeleteUserByUserId 
	@UserId int
AS
BEGIN
	DELETE FROM [User] WHERE UserId = @UserId;
END

--Executing DeleteUserByUserId
EXECUTE uspDeleteUserByUserId 1;

--Deleting DeleteUserByUserId stored procedure
DROP PROCEDURE uspDeleteUserByUserId;
