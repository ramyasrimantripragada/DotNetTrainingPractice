--Stored Procedure for Inserting Attachment
--UseCase: When attaching an Attachment file to an Article
CREATE PROCEDURE uspInsertAttachment
	@ArticleId int,
	@FileName nvarchar(100),
	@FileType nvarchar(100),
	@FilePath nvarchar(100)
AS
BEGIN
	INSERT INTO Attachment(ArticleId, FileName, FileType, FilePath, UploadDate)
	VALUES(@ArticleId, @FileName, @FileType, @FilePath, GETDATE());
END

--Executing InsertAttachment Stored Procedure
EXECUTE uspInsertAttachment 1, "Program.exe", "Executable File", "/attachments/Program.exe";

--Deleting InsertAttachment Stored Procedure
DROP PROCEDURE uspInsertAttachment;