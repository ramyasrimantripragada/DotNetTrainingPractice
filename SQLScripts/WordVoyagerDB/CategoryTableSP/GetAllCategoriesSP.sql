--Stored Procedure for fetching all categories
--UseCase: When displaying all Categories available
CREATE PROCEDURE uspGetAllCategories
AS
BEGIN
	SELECT * FROM Category;
END

--Executing GetAllCategories Stored Procedure
EXECUTE uspGetAllCategories;

--Deleting GetAllCategories Stored Procedure
DROP PROCEDURE uspGetAllCategories;
