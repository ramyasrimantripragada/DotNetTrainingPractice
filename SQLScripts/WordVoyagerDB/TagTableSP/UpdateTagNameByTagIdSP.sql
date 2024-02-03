--Stored Procedure for Updating Name by TagId
--UseCase: When updating an existing Tag Details
CREATE PROCEDURE uspUpdateTagNameByTagId
	@TagId int,
	@Name nvarchar(100)
AS
BEGIN
	UPDATE Tag
	SET Name = @Name
	WHERE TagId = @TagId;
END

--Executing UpdateTagNameByTagId Stored Procedure
EXECUTE uspUpdateTagNameByTagId 1, "Horror";

--Deleting UpdateTagNameByTagId Stored Procedure
DROP PROCEDURE uspUpdateTagNameByTagId;
