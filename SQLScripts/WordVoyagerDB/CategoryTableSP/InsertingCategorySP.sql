--Creating a new Stored Procedure for Inserting into Category Table
CREATE PROCEDURE uspInsertCategory
	@Name nvarchar(100),
	@Description nvarchar(100)
AS
BEGIN
	INSERT INTO Category(Name, Description)
	VALUES(@Name, @Description)
END
GO

--Executing InsertCategory Stored Procedure
EXECUTE uspInsertCategory "Cutlery & Cooking", "Related to cooking, for posting different recipes etc.";
GO

--Deleting InsertCategory Stored Procedure
DROP PROCEDURE uspInsertCategory;
GO