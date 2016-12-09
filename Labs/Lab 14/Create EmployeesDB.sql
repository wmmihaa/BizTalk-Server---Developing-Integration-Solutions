USE [master]
GO

/****** Object:  Database [EmployeesDB]    Script Date: 05/26/2011 23:56:14 ******/
CREATE DATABASE [EmployeesDB] ON  PRIMARY 
( NAME = N'EmployeesDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\EmployeesDB.mdf' , SIZE = 5000KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EvaluationDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\EvaluationDb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [EmployeesDB] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EmployeesDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [EmployeesDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [EmployeesDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [EmployeesDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [EmployeesDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [EmployeesDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [EmployeesDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [EmployeesDB] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [EmployeesDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [EmployeesDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [EmployeesDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [EmployeesDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [EmployeesDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [EmployeesDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [EmployeesDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [EmployeesDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [EmployeesDB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [EmployeesDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [EmployeesDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [EmployeesDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [EmployeesDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [EmployeesDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [EmployeesDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [EmployeesDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [EmployeesDB] SET  READ_WRITE 
GO

ALTER DATABASE [EmployeesDB] SET RECOVERY FULL 
GO

ALTER DATABASE [EmployeesDB] SET  MULTI_USER 
GO

ALTER DATABASE [EmployeesDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [EmployeesDB] SET DB_CHAINING OFF 
GO

USE [EmployeesDB]
GO

/****** Object:  Table [dbo].[Evals]    Script Date: 05/27/2011 08:17:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Employees](
	[ID] [uniqueidentifier] NULL,
	[EmployeeNumber] [int] NULL,
	[FirstName] [varchar](250) NULL,
	[LastName] [varchar](250) NULL,
	[Department] [varchar](250) NULL,
	[Role] [varchar](250) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


/****** Object:  StoredProcedure [dbo].[sp_AddEval]    Script Date: 05/26/2011 23:56:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetEmployee](@employeeNumber varchar(255)) AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM Employees
	WHERE EmployeeNumber  = @employeeNumber

END
GO

CREATE PROCEDURE [dbo].[sp_GetEmployees] AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM Employees

END
GO

insert into Employees values(newid(),1, 'Jerome', 'Seinfeld', 'Sales', 'Manager')
GO
insert into Employees values(newid(),2, 'George', 'Costanza', 'Procurement', 'Importer/Exporter')
GO
insert into Employees values(newid(),3, 'Elaine', 'Benes', 'Sales', 'Manager')
GO
insert into Employees values(newid(),4, 'Cosmo', 'Kramer', 'Sales', 'Manager')
GO
