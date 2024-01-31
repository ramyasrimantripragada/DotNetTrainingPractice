/* Creating DB with name 'WordVoyager' if it does not exist in System Databases. */
IF NOT EXISTS (
   SELECT name
   FROM sys.databases
   WHERE name = 'WordVoyager'
)
CREATE DATABASE WordVoyager
GO

/*Switching to DB WordVoyager. */
USE WordVoyager;

CREATE TABLE [User] (
	UserId	INT PRIMARY KEY,
	UserName NVARCHAR(100) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	PasswordHash NVARCHAR(100) NOT NULL,
	RegistrationDate DATETIME  DEFAULT GETDATE()
);

CREATE TABLE Category (
	CategoryId INT PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL,
	Description TEXT
);

CREATE TABLE Article (
	ArticleId INT PRIMARY KEY,
	Title NVARCHAR(100) NOT NULL,
	Content TEXT NOT NULL,
	PublishedDate DATETIME DEFAULT GETDATE(),
	LastModifiedDate DATETIME DEFAULT GETDATE(),
	AuthorId INT FOREIGN KEY REFERENCES [User](UserId) NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Category(CategoryId) NOT NULL
);

CREATE TABLE Comment (
	CommentId INT PRIMARY KEY,
	ArticleId INT FOREIGN KEY REFERENCES Article(ArticleId) NOT NULL,
	UserId INT FOREIGN KEY REFERENCES [User](UserId) NOT NULL,
	Content TEXT NOT NULL,
	CommentDate DATETIME DEFAULT GETDATE()
);

CREATE TABLE Tag (
	TagId INT PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL
);

CREATE TABLE ArticleTag (
	ArticleId INT FOREIGN KEY REFERENCES Article(ArticleId),
	TagId INT FOREIGN KEY REFERENCES Tag(TagId),
	PRIMARY KEY(ArticleId, TagId)
);

CREATE TABLE Attachment (
	AttachmentId INT PRIMARY KEY,
	ArticleId INT FOREIGN KEY REFERENCES Article(ArticleId) NOT NULL,
	FileName NVARCHAR(100) NOT NULL,
	FileType NVARCHAR(100) NOT NULL,
	FilePath NVARCHAR(100) NOT NULL,
	UploadDate DATETIME DEFAULT GETDATE()
);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      