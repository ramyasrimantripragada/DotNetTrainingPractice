--Stored Procedure for Deleting tag by TagId
--UseCase: When deleting an existing Tag
CREATE PROCEDURE uspDeleteTagByTagId
	@TagId int
AS
BEGIN
	DELETE FROM Tag WHERE TagId = @TagId;
END

--Executing DeleteTagByTagId Stored Procedure
EXECUTE uspDeleteTagByTagId 4;

--Deleting DeleteTagByTagId Stored Procedure
DROP PROCEDURE uspDeleteTagByTagId;
