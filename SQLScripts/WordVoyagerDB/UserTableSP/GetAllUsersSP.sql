--Creating a new Stored Procedure for Reading/Displaying rows of User Table. 
CREATE PROCEDURE uspGetAllUsers 
AS
BEGIN
	SELECT * FROM [User];
END
GO

--Executing GetAllUsers Stored Procedure
EXECUTE uspGetAllUsers;
GO

--Deleting GetAllUsers Stored Procedure
DROP PROCEDURE uspGetAllUsers;
GO