--Creating a new procedure for Updating Category date by CategoryId
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
GO

--Executing UpdateCategoryByCategoryId Stored Procedure
EXECUTE uspUpdateCategoryByCategoryId 1, "Fiction", "The fantasy genre involves world-building and characters who are supernatural, mythological, etc.";
GO

--Deleting UpdateCategoryByCategoryId Stored Procedure
DROP PROCEDURE uspUpdateCategoryByCategoryId;
