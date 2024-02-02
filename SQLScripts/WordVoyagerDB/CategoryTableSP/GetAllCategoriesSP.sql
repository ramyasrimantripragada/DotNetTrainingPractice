--Creating a new procedure for fetching all categories
CREATE PROCEDURE uspGetAllCategories
AS
BEGIN
	SELECT * FROM Category;
END
GO

--Executing GetAllCategories Stored Procedure
EXECUTE uspGetAllCategories;
GO

--Deleting GetAllCategories Stored Procedure
DROP PROCEDURE uspGetAllCategories;
GO