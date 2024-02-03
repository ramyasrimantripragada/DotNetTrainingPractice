--Stored Procedure for Deleting Category by CategoryId
--UseCase: When deleting an existing Category
CREATE PROCEDURE uspDeleteCategoryByCategoryId
	@CategoryId int
AS
BEGIN
	DELETE FROM Category WHERE CategoryId = @CategoryId;
END

--Executing DeleteCategoryByCategoryId Stored Procedure
EXECUTE uspDeleteCategoryByCategoryId 2;

--Deleting DeleteCategoryByCategoryId Stored Procedure
DROP PROCEDURE uspDeleteCategoryByCategoryId;
