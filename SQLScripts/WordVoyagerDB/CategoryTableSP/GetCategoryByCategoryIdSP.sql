--Creating a new Stored Procedure for fetching Category by CategoryId
CREATE PROCEDURE uspGetCategoryByCategoryId
	@CategoryId int
AS
BEGIN
	SELECT * FROM Category WHERE CategoryId = @CategoryId;
END
GO

--Executing GetCategoryByCategoryId Stored Procedure
EXECUTE uspGetCategoryByCategoryId 4;
GO

--Deleting GetCategoryByCategoryId Stored Procedure
DROP PROCEDURE uspGetCategoryByCategoryId;
GO
