--Creating a new Stored Procedure for fetching all Articles 
CREATE PROCEDURE uspGetAllArticles
AS
BEGIN
	SELECT * FROM Article;
END
GO

--Executing GetAllArticles Stored Procedure
EXECUTE uspGetAllArticles;
GO

--Deleting GetAllArticles Stored Procedure
DROP PROCEDURE uspGetAllArticles;
GO