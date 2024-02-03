--Stored Procedure for Updating in User table using UserId
--UseCase: When Users wants to edit/update their details
CREATE PROCEDURE uspUpdateUserByUserId 
	@UserId int,
	@UserName nvarchar(100),
	@Email nvarchar(100),
	@PasswordHash nvarchar(100)
AS
BEGIN
	UPDATE [User]
	SET UserName = @UserName, Email = @Email, PasswordHash = @PasswordHash
	WHERE UserId = @UserId;	
END 

--Executing UpdateUserByUserId Stored Procedure
EXECUTE uspUpdateUserByUserId 1, "Ramya Sri", "ramya@gmail.com", "pass@789";

--Deleting UpdateUserByUserId Stored Procedure
DROP PROCEDURE uspUpdateUserByUserId;