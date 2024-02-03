--Stored Procedure for fetching all Tags
--UseCase: When displaying all available Tags
CREATE PROCEDURE uspGetAllTags
AS
BEGIN
	SELECT * FROM Tag;
END

--Executing GetAllTags Stored Procedure
EXECUTE uspGetAllTags;

--Deleting GetAllTags Stored Procedure
DROP PROCEDURE uspGetAllTags;