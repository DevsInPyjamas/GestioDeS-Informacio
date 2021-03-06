USE [master]
GO
/****** Object:  Database [GI1819]    Script Date: 21/10/2018 16:12:51 ******/
CREATE DATABASE [GI1819]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GI1819', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\GI1819.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GI1819_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\GI1819_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GI1819] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GI1819].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GI1819] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GI1819] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GI1819] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GI1819] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GI1819] SET ARITHABORT OFF 
GO
ALTER DATABASE [GI1819] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GI1819] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GI1819] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GI1819] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GI1819] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GI1819] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GI1819] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GI1819] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GI1819] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GI1819] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GI1819] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GI1819] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GI1819] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GI1819] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GI1819] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GI1819] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GI1819] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GI1819] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GI1819] SET  MULTI_USER 
GO
ALTER DATABASE [GI1819] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GI1819] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GI1819] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GI1819] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [GI1819] SET DELAYED_DURABILITY = DISABLED 
GO
USE [GI1819]
GO
/****** Object:  UserDefinedFunction [dbo].[isAdministrator]    Script Date: 21/10/2018 16:12:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Samuel Jurado
-- Create date: 19/10/2018
-- Description:	given an username and a password, returns if the user is admin.
-- =============================================
CREATE FUNCTION [dbo].[isAdministrator] (@username varchar(50), @password varchar(50))
RETURNS BIT 
AS BEGIN
RETURN
(
	-- Add the SELECT statement with parameter references here
	SELECT r.admin FROM tRol r JOIN tUser u ON u.rolName=r.rolName WHERE u.name=@username AND u.password=@password
)
END

GO
/****** Object:  Table [dbo].[tPermision]    Script Date: 21/10/2018 16:12:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tPermision](
	[rolName] [varchar](50) NOT NULL,
	[screen] [varchar](50) NOT NULL,
	[access] [bit] NOT NULL,
	[modify] [bit] NOT NULL,
 CONSTRAINT [PK_tPermision] PRIMARY KEY CLUSTERED 
(
	[screen] ASC,
	[rolName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tRol]    Script Date: 21/10/2018 16:12:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tRol](
	[rolName] [varchar](50) NOT NULL,
	[rolDescription] [varchar](255) NULL,
	[admin] [bit] NOT NULL,
 CONSTRAINT [PK_tRol] PRIMARY KEY CLUSTERED 
(
	[rolName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tUser]    Script Date: 21/10/2018 16:12:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tUser](
	[name] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[rolName] [varchar](50) NULL,
 CONSTRAINT [PK_tUser] PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tPermision]  WITH CHECK ADD  CONSTRAINT [FK_tPermision_tRol] FOREIGN KEY([rolName])
REFERENCES [dbo].[tRol] ([rolName])
GO
ALTER TABLE [dbo].[tPermision] CHECK CONSTRAINT [FK_tPermision_tRol]
GO
ALTER TABLE [dbo].[tUser]  WITH CHECK ADD  CONSTRAINT [FK_tUser_tRol] FOREIGN KEY([rolName])
REFERENCES [dbo].[tRol] ([rolName])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tUser] CHECK CONSTRAINT [FK_tUser_tRol]
GO
/****** Object:  StoredProcedure [dbo].[insertUser]    Script Date: 21/10/2018 16:12:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[insertUser](
	@usernameAdmin varchar(50), @passwordAdmin varchar(50),
	@newUserName varchar(50), @newUserPassword varchar(50), @newUserRol varchar(50)
	)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @isAdmin BIT
	EXEC @isAdmin = isAdministrator @usernameAdmin, @passwordAdmin
	IF(@isAdmin = 1)
		INSERT INTO tUser (name, password, rolName) VALUES (@newUserName, @newUserPassword, @newUserRol)

END

GO
USE [master]
GO
ALTER DATABASE [GI1819] SET  READ_WRITE 
GO
