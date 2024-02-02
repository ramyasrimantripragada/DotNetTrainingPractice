--Creating a new procedure for Updating in User table using UserId
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
GO