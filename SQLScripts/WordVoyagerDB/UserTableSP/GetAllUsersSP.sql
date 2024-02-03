--Stored Procedure for Reading/Displaying rows of User Table.
--UseCase: When fetching details of all available Users
CREATE PROCEDURE uspGetAllUsers 
AS
BEGIN
	SELECT * FROM [User];
END

--Executing GetAllUsers Stored Procedure
EXECUTE uspGetAllUsers;

--Deleting GetAllUsers Stored Procedure
DROP PROCEDURE uspGetAllUsers;
