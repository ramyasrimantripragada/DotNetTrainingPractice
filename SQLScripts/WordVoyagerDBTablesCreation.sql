CREATE TABLE [User] (
	UserId	INT PRIMARY KEY,
	UserName NVARCHAR(100) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	PasswordHash NVARCHAR(100) NOT NULL,
	RegistrationDate DATETIME NOT NULL
);

CREATE TABLE Category (
	CategoryId INT PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL,
	Description TEXT
);

CREATE TABLE Article (
	ArticleId INT PRIMARY KEY,
	Title NVARCHAR(100) NOT NULL,
	Content TEXT,
	PublishedDate DATETIME NOT NULL,
	LastModifiedDate DATETIME NOT NULL,
	AuthorId INT REFERENCES [User](UserId),
	CategoryId INT REFERENCES Category(CategoryId)
);

CREATE TABLE Comment (
	CommentId INT PRIMARY KEY,
	ArticleId INT REFERENCES Article(ArticleId),
	UserId INT REFERENCES [User](UserId),
	Content TEXT NOT NULL,
	CommentDate DATETIME NOT NULL
);

CREATE TABLE Tag (
	TagId INT PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL
);

CREATE TABLE ArticleTag (
	ArticleId INT REFERENCES Article(ArticleId),
	TagId INT REFERENCES Tag(TagId)
);

CREATE TABLE Attachment (
	AttachmentId INT PRIMARY KEY,
	ArticleId INT REFERENCES Article(ArticleId),
	FileName NVARCHAR(100) NOT NULL,
	FileType NVARCHAR(100) NOT NULL,
	FilePath NVARCHAR(100) NOT NULL,
	UploadDate DATETIME NOT NULL
);