--Creating EMPLOYEE Table under WordVoyager for working with DB from Project
CREATE TABLE EMPLOYEE(
	EmployeeId INT PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(100) NOT NULL,
	Designation NVARCHAR(100) NOT NULL,
	Department NVARCHAR(100) NOT NULL,
	JoiningDate DATETIME DEFAULT GETDATE()
);