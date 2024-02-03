--Stored Procedure for fetching Category by CategoryId
--UseCase: When fetching a specific Category Details
CREATE PROCEDURE uspGetCategoryByCategoryId
	@CategoryId int
AS
BEGIN
	SELECT * FROM Category WHERE CategoryId = @CategoryId;
END

--Executing GetCategoryByCategoryId Stored Procedure
EXECUTE uspGetCategoryByCategoryId 4;

--Deleting GetCategoryByCategoryId Stored Procedure
DROP PROCEDURE uspGetCategoryByCategoryId;

