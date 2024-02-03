--Stored Procedure for Updating Category date by CategoryId
--UseCase: When updating the details of an existing Category
CREATE PROCEDURE uspUpdateCategoryByCategoryId
	@CategoryId int,
	@Name nvarchar(100),
	@Description nvarchar(100)
AS
BEGIN
	UPDATE Category
	SET Name = @Name, Description = @Description
	WHERE CategoryId =  @CategoryId;
END

--Executing UpdateCategoryByCategoryId Stored Procedure
EXECUTE uspUpdateCategoryByCategoryId 1, "Fiction", "The fantasy genre involves world-building and characters who are supernatural, mythological, etc.";

--Deleting UpdateCategoryByCategoryId Stored Procedure
DROP PROCEDURE uspUpdateCategoryByCategoryId;

