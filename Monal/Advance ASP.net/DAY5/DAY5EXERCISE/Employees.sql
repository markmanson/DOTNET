
USE [Northwind_Monal]
GO

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE ID = OBJECT_ID('proc_EmployeeEmployeesLoadByPrimaryKey') AND sysstat & 0xf = 4)
    DROP PROCEDURE [proc_EmployeeEmployeesLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_EmployeeEmployeesLoadByPrimaryKey]
(
	@EmployeeID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[EmployeeID],
		[LastName],
		[FirstName],
		[Title],
		[TitleOfCourtesy],
		[BirthDate],
		[HireDate],
		[Address],
		[City],
		[Region],
		[PostalCode],
		[Country],
		[HomePhone],
		[Extension],
		[Photo],
		[Notes],
		[ReportsTo],
		[PhotoPath]
	FROM [dbo].[Employees]
	WHERE
		([EmployeeID] = @EmployeeID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_EmployeeEmployeesLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_EmployeeEmployeesLoadByPrimaryKey Error on Creation'
GO

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE ID = OBJECT_ID('proc_EmployeeEmployeesLoadAll') AND sysstat & 0xf = 4)
    DROP PROCEDURE [proc_EmployeeEmployeesLoadAll];
GO

CREATE PROCEDURE [proc_EmployeeEmployeesLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[EmployeeID],
		[LastName],
		[FirstName],
		[Title],
		[TitleOfCourtesy],
		[BirthDate],
		[HireDate],
		[Address],
		[City],
		[Region],
		[PostalCode],
		[Country],
		[HomePhone],
		[Extension],
		[Photo],
		[Notes],
		[ReportsTo],
		[PhotoPath]
	FROM [dbo].[Employees]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_EmployeeEmployeesLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_EmployeeEmployeesLoadAll Error on Creation'
GO

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE ID = OBJECT_ID('proc_EmployeeEmployeesUpdate') AND sysstat & 0xf = 4)
    DROP PROCEDURE [proc_EmployeeEmployeesUpdate];
GO

CREATE PROCEDURE [proc_EmployeeEmployeesUpdate]
(
	@EmployeeID int,
	@LastName nvarchar(20),
	@FirstName nvarchar(10),
	@Title nvarchar(30) = NULL,
	@TitleOfCourtesy nvarchar(25) = NULL,
	@BirthDate datetime = NULL,
	@HireDate datetime = NULL,
	@Address nvarchar(60) = NULL,
	@City nvarchar(15) = NULL,
	@Region nvarchar(15) = NULL,
	@PostalCode nvarchar(10) = NULL,
	@Country nvarchar(15) = NULL,
	@HomePhone nvarchar(24) = NULL,
	@Extension nvarchar(4) = NULL,
	@Photo image = NULL,
	@Notes ntext = NULL,
	@ReportsTo int = NULL,
	@PhotoPath nvarchar(255) = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [dbo].[Employees]
	SET
		[LastName] = @LastName,
		[FirstName] = @FirstName,
		[Title] = @Title,
		[TitleOfCourtesy] = @TitleOfCourtesy,
		[BirthDate] = @BirthDate,
		[HireDate] = @HireDate,
		[Address] = @Address,
		[City] = @City,
		[Region] = @Region,
		[PostalCode] = @PostalCode,
		[Country] = @Country,
		[HomePhone] = @HomePhone,
		[Extension] = @Extension,
		[Photo] = @Photo,
		[Notes] = @Notes,
		[ReportsTo] = @ReportsTo,
		[PhotoPath] = @PhotoPath
	WHERE
		[EmployeeID] = @EmployeeID


	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_EmployeeEmployeesUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_EmployeeEmployeesUpdate Error on Creation'
GO




IF EXISTS (SELECT * FROM SYSOBJECTS WHERE ID = OBJECT_ID('proc_EmployeeEmployeesInsert') AND sysstat & 0xf = 4)
    DROP PROCEDURE [proc_EmployeeEmployeesInsert];
GO

CREATE PROCEDURE [proc_EmployeeEmployeesInsert]
(
	@EmployeeID int = NULL OUTPUT,
	@LastName nvarchar(20),
	@FirstName nvarchar(10),
	@Title nvarchar(30) = NULL,
	@TitleOfCourtesy nvarchar(25) = NULL,
	@BirthDate datetime = NULL,
	@HireDate datetime = NULL,
	@Address nvarchar(60) = NULL,
	@City nvarchar(15) = NULL,
	@Region nvarchar(15) = NULL,
	@PostalCode nvarchar(10) = NULL,
	@Country nvarchar(15) = NULL,
	@HomePhone nvarchar(24) = NULL,
	@Extension nvarchar(4) = NULL,
	@Photo image = NULL,
	@Notes ntext = NULL,
	@ReportsTo int = NULL,
	@PhotoPath nvarchar(255) = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [dbo].[Employees]
	(
		[LastName],
		[FirstName],
		[Title],
		[TitleOfCourtesy],
		[BirthDate],
		[HireDate],
		[Address],
		[City],
		[Region],
		[PostalCode],
		[Country],
		[HomePhone],
		[Extension],
		[Photo],
		[Notes],
		[ReportsTo],
		[PhotoPath]
	)
	VALUES
	(
		@LastName,
		@FirstName,
		@Title,
		@TitleOfCourtesy,
		@BirthDate,
		@HireDate,
		@Address,
		@City,
		@Region,
		@PostalCode,
		@Country,
		@HomePhone,
		@Extension,
		@Photo,
		@Notes,
		@ReportsTo,
		@PhotoPath
	)

	SET @Err = @@Error
	SELECT @EmployeeID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_EmployeeEmployeesInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_EmployeeEmployeesInsert Error on Creation'
GO

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE ID = OBJECT_ID('proc_EmployeeEmployeesDelete') AND sysstat & 0xf = 4)
    DROP PROCEDURE [proc_EmployeeEmployeesDelete];
GO

CREATE PROCEDURE [proc_EmployeeEmployeesDelete]
(
	@EmployeeID int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [dbo].[Employees]
	WHERE
		[EmployeeID] = @EmployeeID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_EmployeeEmployeesDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_EmployeeEmployeesDelete Error on Creation'
GO
