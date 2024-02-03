--Stored Procedure for fetching all Articles 
--UseCase: When all the articles need to be displayed
CREATE PROCEDURE uspGetAllArticles
AS
BEGIN
	SELECT * FROM Article;
END

--Executing GetAllArticles Stored Procedure
EXECUTE uspGetAllArticles;

--Deleting GetAllArticles Stored Procedure
DROP PROCEDURE uspGetAllArticles;
