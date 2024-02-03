--Stored Procedure for Inserting into Article table
--UseCase: When an Author publishes a new Article
CREATE PROCEDURE uspInsertArticle
	@Title NVARCHAR(100),
	@Content NVARCHAR(100),
	@AuthorId int,
	@CategoryId int
AS
BEGIN
	INSERT INTO Article(Title, Content, PublishedDate, LastModifiedDate, AuthorId, CategoryId)
	VALUES(@Title, @Content, GETDATE(), GETDATE(), @AuthorId, @CategoryId);
END

--Executing InsertArticle Stored Procedure
EXECUTE uspInsertArticle "Home cooking: Good for your health", "Can you imagine if you went to your primary care doctor's office for cooking classes? What if your visit...", 4, 1;

--Deleting InsertArticle Stored Procedure
DROP PROCEDURE uspInsertArticle;

