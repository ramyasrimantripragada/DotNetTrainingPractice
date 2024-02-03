--Stored Procedure to Get Specific User by UserId
--UseCase: When displaying details of a Specific User
CREATE PROCEDURE uspGetUserByUserId
	@UserId int
AS 
BEGIN
	SELECT * FROM [User] WHERE UserId = @UserId;
END

--Executing GetUserByUserId Stored Procedure
EXECUTE uspGetUserByUserId 3;

--Deleting GetUserByUserId Stored Procedure
DROP PROCEDURE uspGetUserByUserId;


