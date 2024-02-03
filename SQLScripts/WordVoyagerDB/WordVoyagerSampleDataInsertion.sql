--Inserting Sample Data into tables of WordVoyager DB

-- Inserting values into WordVoyager.User table
INSERT INTO [User] (Username, Email, PasswordHash, RegistrationDate)
VALUES 
('JohnDoe', 'john.doe@example.com', 'hashedpassword1', '2024-01-31 12:00:00'),
('JaneSmith', 'jane.smith@example.com', 'hashedpassword2', '2024-01-31 12:15:00'),
('AliceWonder', 'alice.wonder@example.com', 'hashedpassword3', '2024-01-31 12:30:00'),
('BobExplorer', 'bob.explorer@example.com', 'hashedpassword4', '2024-01-31 12:45:00'),
('EveReader', 'eve.reader@example.com', 'hashedpassword5', '2024-01-31 13:00:00');

-- Inserting values into WordVoyager.Category table
INSERT INTO Category (Name, Description)
VALUES 
('Technology', 'Articles related to the latest technological advancements.'),
('Science', 'Explore the wonders of science.'),
('Travel', 'Journey through different places and cultures.'),
('Health', 'Tips for a healthy lifestyle.'),
('Literature', 'Dive into the world of literature and books.');

-- Inserting values into WordVoyager.Article table
INSERT INTO Article (Title, Content, PublishedDate, LastModifiedDate, AuthorId, CategoryId)
VALUES 
('Introduction to AI', 'Artificial Intelligence is revolutionizing...', '2024-01-31 13:30:00', '2024-01-31 13:30:00', 1, 1),
('Exploring Space', 'Discovering new galaxies and cosmic phenomena...', '2024-01-31 14:00:00', '2024-01-31 14:00:00', 2, 2),
('Hidden Gems of Europe', 'Uncovering lesser-known destinations in Europe...', '2024-01-31 14:30:00', '2024-01-31 14:30:00', 3, 3),
('Healthy Eating Habits', 'Tips for maintaining a balanced and healthy diet...', '2024-01-31 15:00:00', '2024-01-31 15:00:00', 4, 4),
('Classic Literature Must-Reads', 'Timeless literary masterpieces that you should read...', '2024-01-31 15:30:00', '2024-01-31 15:30:00', 5, 5);

-- Inserting values into WordVoyager.Comment table
INSERT INTO Comment (ArticleId, UserId, Content, CommentDate)
VALUES 
(1, 2, 'Great article! AI is indeed fascinating.', '2024-01-31 14:15:00'),
(3, 1, 'I never knew about these hidden gems. Thanks for sharing!', '2024-01-31 14:45:00'),
(4, 3, 'The tips on healthy eating are very practical. I will try them!', '2024-01-31 15:15:00'),
(2, 4, 'Space exploration is crucial for our understanding of the universe.', '2024-01-31 15:45:00'),
(5, 5, 'These classic literature recommendations are excellent. I have read a few already!', '2024-01-31 16:00:00');

-- Inserting values into WordVoyager.Tag table
INSERT INTO Tag (Name)
VALUES 
('Artificial Intelligence'),
('Space Exploration'),
('Europe Travel'),
('Healthy Living'),
('Classic Literature');

-- Inserting values into WordVoyager.ArticleTag table
INSERT INTO ArticleTag (ArticleId, TagId)
VALUES 
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);

-- Inserting values into WordVoyager.Attachment table
INSERT INTO Attachment (ArticleId, FileName, FileType, FilePath, UploadDate)
VALUES 
(1, 'ai_image.jpg', 'Image', '/attachments/ai_image.jpg', '2024-01-31 16:30:00'),
(3, 'europe_map.pdf', 'PDF', '/attachments/europe_map.pdf', '2024-01-31 16:45:00'),
(4, 'healthy_eating_infographic.png', 'Image', '/attachments/healthy_eating_infographic.png', '2024-01-31 17:00:00'),
(2, 'space_photo.jpg', 'Image', '/attachments/space_photo.jpg', '2024-01-31 17:15:00'),
(5, 'literature_quotes.txt', 'Text', '/attachments/literature_quotes.txt', '2024-01-31 17:30:00');
