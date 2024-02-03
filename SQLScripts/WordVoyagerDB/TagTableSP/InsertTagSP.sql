--Stored Procedure for Creating a new Tag
--UseCase: When creating a new Tag
CREATE PROCEDURE uspInsertTag
	@Name nvarchar(100)
AS
BEGIN
	INSERT INTO Tag(Name)
	VALUES(@Name);
END

--Executing InsertTag Stored Procedure
EXECUTE uspInsertTag "Lifestyle";

--Deleting InsertTag Stored Procedure
DROP PROCEDURE uspInsertTag;
