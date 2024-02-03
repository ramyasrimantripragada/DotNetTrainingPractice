--Stored Procedure for Inserting into Category Table
--UseCase: When creating a new Category of Article
CREATE PROCEDURE uspInsertCategory
	@Name nvarchar(100),
	@Description nvarchar(100)
AS
BEGIN
	INSERT INTO Category(Name, Description)
	VALUES(@Name, @Description)
END

--Executing InsertCategory Stored Procedure
EXECUTE uspInsertCategory "Cutlery & Cooking", "Related to cooking, for posting different recipes etc.";

--Deleting InsertCategory Stored Procedure
DROP PROCEDURE uspInsertCategory;