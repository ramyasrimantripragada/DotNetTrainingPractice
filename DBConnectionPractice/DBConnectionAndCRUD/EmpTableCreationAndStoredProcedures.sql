--Creating EMPLOYEE Table under WordVoyager for working with DB from Project
CREATE TABLE EMPLOYEE(
	EmployeeId INT PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(100) NOT NULL,
	Designation NVARCHAR(100) NOT NULL,
	Department NVARCHAR(100) NOT NULL,
	JoiningDate DATETIME DEFAULT GETDATE()
);

--Inserting Employee Record
CREATE PROCEDURE uspInsertEmployee
	@Name nvarchar(100),
	@Designation nvarchar(100),
	@Department nvarchar(100),
	@EmployeeId int OUT

AS
BEGIN
	INSERT INTO EMPLOYEE(Name, Designation, Department, JoiningDate)
	VALUES(@Name, @Designation, @Department, GETDATE())
	SET @EmployeeId = SCOPE_IDENTITY()
END


--Displaying Employee Records
CREATE PROCEDURE uspGetEmployeeRecords
AS
BEGIN
	SELECT * FROM EMPLOYEE;
END

--Deleting Employee Record by EmpId
CREATE PROCEDURE uspDeleteEmployee
	@EmployeeId int
AS
BEGIN
	DELETE FROM EMPLOYEE WHERE EmployeeId=@EmployeeId;
END

--Updating Employee Name
CREATE PROCEDURE uspUpdateEmployeeName
	@EmployeeId int,
	@Name nvarchar(100)
AS
BEGIN
	UPDATE EMPLOYEE
	SET Name=@Name
	WHERE EmployeeId=@EmployeeId
END

--Updating Employee Designation
CREATE PROCEDURE uspUpdateEmployeeDesignation
	@EmployeeId int,
	@Designation nvarchar(100)
AS
BEGIN
	UPDATE EMPLOYEE
	SET Designation=@Designation
	WHERE EmployeeId=@EmployeeId
END

--Updating Employee Department
CREATE PROCEDURE uspUpdateEmployeeDepartment
	@EmployeeId int,
	@Department nvarchar(100)
AS
BEGIN
	UPDATE EMPLOYEE
	SET Department=@Department
	WHERE EmployeeId=@EmployeeId
END


