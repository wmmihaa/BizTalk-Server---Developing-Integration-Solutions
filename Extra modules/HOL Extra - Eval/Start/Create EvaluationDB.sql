USE [master]
GO

/****** Object:  Database [EvaluationDb]    Script Date: 05/26/2011 23:56:14 ******/
CREATE DATABASE [EvaluationDb] ON  PRIMARY 
( NAME = N'EvaluationDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\EvaluationDb.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EvaluationDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\EvaluationDb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [EvaluationDb] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EvaluationDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [EvaluationDb] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [EvaluationDb] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [EvaluationDb] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [EvaluationDb] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [EvaluationDb] SET ARITHABORT OFF 
GO

ALTER DATABASE [EvaluationDb] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [EvaluationDb] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [EvaluationDb] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [EvaluationDb] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [EvaluationDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [EvaluationDb] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [EvaluationDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [EvaluationDb] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [EvaluationDb] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [EvaluationDb] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [EvaluationDb] SET  DISABLE_BROKER 
GO

ALTER DATABASE [EvaluationDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [EvaluationDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [EvaluationDb] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [EvaluationDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [EvaluationDb] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [EvaluationDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [EvaluationDb] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [EvaluationDb] SET  READ_WRITE 
GO

ALTER DATABASE [EvaluationDb] SET RECOVERY FULL 
GO

ALTER DATABASE [EvaluationDb] SET  MULTI_USER 
GO

ALTER DATABASE [EvaluationDb] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [EvaluationDb] SET DB_CHAINING OFF 
GO

USE [EvaluationDb]
GO

/****** Object:  Table [dbo].[Evals]    Script Date: 05/27/2011 08:17:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Evals](
	[ID] [uniqueidentifier] NULL,
	[Course] [nchar](10) NULL,
	[Student] [varchar](250) NULL,
	[Rating] [int] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


/****** Object:  StoredProcedure [dbo].[sp_AddEval]    Script Date: 05/26/2011 23:56:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_AddEval](@course char(10), @student varchar(250), @rating int) AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO [EvaluationDb].[dbo].[Evals]
           ([ID]
           ,[Course]
           ,[Student]
           ,[Rating])
     VALUES
           (newid(),
           @course,
           @student,
           @rating)

END


GO

