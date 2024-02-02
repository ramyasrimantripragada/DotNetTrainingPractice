--Creating a new Stored Procedure for Deleting Category by CategoryId
CREATE PROCEDURE uspDeleteCategoryByCategoryId
	@CategoryId int
AS
BEGIN
	DELETE FROM Category WHERE CategoryId = @CategoryId;
END
GO

--Executing DeleteCategoryByCategoryId Stored Procedure
EXECUTE uspDeleteCategoryByCategoryId 2;
GO

--Deleting DeleteCategoryByCategoryId Stored Procedure
DROP PROCEDURE uspDeleteCategoryByCategoryId;
GO