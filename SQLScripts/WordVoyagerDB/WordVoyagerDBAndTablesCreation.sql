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

/*
	User Table: Stores information about users who can be authors and/or readers.
	UserId (INT, PK): Unique identifier for the user.
	Username (NVARCHAR(100)): User's chosen username.
	Email (NVARCHAR(100)): User's email address.
	PasswordHash (NVARCHAR(100)): Hash of the user's password.
	RegistrationDate (DATETIME): Date and time the user registered.
*/
CREATE TABLE [User] (
	UserId	INT PRIMARY KEY IDENTITY(1,1),
	UserName NVARCHAR(100) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	PasswordHash NVARCHAR(100) NOT NULL,
	RegistrationDate DATETIME  DEFAULT GETDATE()
);


/*
	Category Table: Stores different categories for articles.
	CategoryId (INT, PK): Unique identifier for the category.
	Name (NVARCHAR(100)): Name of the category.
	Description (TEXT): Brief description of the category.
*/
CREATE TABLE Category (
	CategoryId INT PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(100) NOT NULL,
	Description TEXT
);


/*
	Article Table: Stores the articles published on the website.
	(INT, PK): Unique identifier for the article.
	Title (NVARCHAR(100)): Title of the article.
	Content (TEXT): Full text content of the article.
	PublishedDate (DATETIME): Date and time the article was published.
	LastModifiedDate (DATETIME): Date and time the article was last modified.
	AuthorId (INT, FK): References UserId in the User table.
	CategoryId (INT, FK): References CategoryId in the Category table.
*/
CREATE TABLE Article (
	ArticleId INT PRIMARY KEY IDENTITY(1,1),
	Title NVARCHAR(100) NOT NULL,
	Content TEXT NOT NULL,
	PublishedDate DATETIME DEFAULT GETDATE(),
	LastModifiedDate DATETIME DEFAULT GETDATE(),
	AuthorId INT FOREIGN KEY REFERENCES [User](UserId) ON DELETE CASCADE,
	CategoryId INT FOREIGN KEY REFERENCES Category(CategoryId) ON DELETE CASCADE
);


/*
	Comment Table: Stores comments made on articles.
	CommentId (INT, PK): Unique identifier for the comment.
	ArticleId (INT, FK): References ArticleId in the Article table.
	UserId (INT, FK): References UserId in the User table.
	Content (TEXT): Text content of the comment.
	CommentDate (DATETIME): Date and time the comment was posted.
*/
CREATE TABLE Comment (
	CommentId INT PRIMARY KEY IDENTITY(1,1),
	ArticleId INT FOREIGN KEY REFERENCES Article(ArticleId) ON DELETE CASCADE ,
	UserId INT FOREIGN KEY REFERENCES [User](UserId),
	Content TEXT NOT NULL,
	CommentDate DATETIME DEFAULT GETDATE()
);


/*
	Tag Table: Stores tags for articles.
	TagId (INT, PK): Unique identifier for the tag.
	Name (NVARCHAR(100)): Name of the tag.
*/
CREATE TABLE Tag (
	TagId INT PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(100) NOT NULL
);


/*
	ArticleTag Table: Manages the many-to-many relationship between articles and tags.
	ArticleId (INT, FK): References ArticleId in the Article table.
	TagId (INT, FK): References TagId in the Tag table.
*/
CREATE TABLE ArticleTag (
	ArticleId INT FOREIGN KEY REFERENCES Article(ArticleId) ON DELETE CASCADE,
	TagId INT FOREIGN KEY REFERENCES Tag(TagId) ON DELETE CASCADE,
	PRIMARY KEY(ArticleId, TagId)
);


/*
	Attachment Table: Stores attachments related to articles.
	AttachmentId (INT, PK): Unique identifier for the attachment.
	ArticleId (INT, FK): References ArticleId in the Article table.
	FileName (NVARCHAR(100)): Name of the attachment file.
	FileType (NVARCHAR(100)): Type of the attachment (e.g., image, PDF).
	FilePath (NVARCHAR(100)): Path to the stored attachment file.
	UploadDate (DATETIME): Date and time the attachment was uploaded.
*/
CREATE TABLE Attachment (
	AttachmentId INT PRIMARY KEY IDENTITY(1,1),
	ArticleId INT FOREIGN KEY REFERENCES Article(ArticleId) ON DELETE CASCADE,
	FileName NVARCHAR(100) NOT NULL,
	FileType NVARCHAR(100) NOT NULL,
	FilePath NVARCHAR(100) NOT NULL,
	UploadDate DATETIME DEFAULT GETDATE()
);               
