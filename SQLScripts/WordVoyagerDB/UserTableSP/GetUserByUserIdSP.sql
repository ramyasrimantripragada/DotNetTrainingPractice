--Stored Procedure to Get Specific User by UserId
CREATE PROCEDURE uspGetUserByUserId
	@UserId int
AS 
BEGIN
	SELECT * FROM [User] WHERE UserId = @UserId;
END
GO

--Executing GetUserByUserId
EXECUTE uspGetUserByUserId 3;

--Deleting GetUserByUserId
DROP PROCEDURE uspGetUserByUserId;


