--Stored Procedure to Insert a row into User Table.
--UseCase: When User wants to create a New User Account
CREATE PROCEDURE uspInsertUser 
	@UserName nvarchar(100),
	@Email nvarchar(100),
	@PasswordHash nvarchar(100)
AS
BEGIN
	INSERT INTO [User](UserName, Email, PasswordHash, RegistrationDate)
	VALUES(@UserName, @Email, @PasswordHash, GETDATE());
END

--Executing InsertUser Stored Procedure.
EXECUTE uspInsertUser 'Ramya Sri', 'ramya_mantripragada@epam.com', 'password@123';
GO 2; --Executes the above command 2 times

--Deleting InsertUser Stored Procedure
DROP PROCEDURE uspInsertUser;
