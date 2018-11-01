USE [master]
GO
/****** Object:  Database [GI1819]    Script Date: 21/10/2018 16:47:21 ******/
CREATE DATABASE [GI1819]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GI1819', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\GI1819.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GI1819_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\GI1819_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
ALTER DATABASE [GI1819] SET AUTO_CLOSE ON 
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
ALTER DATABASE [GI1819] SET  ENABLE_BROKER 
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
/****** Object:  UserDefinedFunction [dbo].[esAdmin]    Script Date: 21/10/2018 16:47:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[esAdmin]
(
	@n varchar(50),
	@p varchar(50)
)
RETURNS bit
AS
BEGIN
	
	RETURN(SELECT R.admin FROM tRol R INNER JOIN tUsuario U ON R.rolName LIKE U.rolName WHERE U.nombre = @n AND U.password = @p) 

END

GO
/****** Object:  Table [dbo].[tPermiso]    Script Date: 21/10/2018 16:47:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tPermiso](
	[pantalla] [varchar](50) NOT NULL,
	[acceso] [bit] NOT NULL,
	[modificacion] [bit] NOT NULL,
	[rolName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tPermiso] PRIMARY KEY CLUSTERED 
(
	[pantalla] ASC,
	[rolName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tRol]    Script Date: 21/10/2018 16:47:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tRol](
	[rolName] [varchar](50) NOT NULL,
	[rolDes] [varchar](255) NOT NULL,
	[admin] [bit] NOT NULL,
 CONSTRAINT [PK_tRol] PRIMARY KEY CLUSTERED 
(
	[rolName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tUsuario]    Script Date: 21/10/2018 16:47:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tUsuario](
	[nombre] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[rolName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tUsuario] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tPermiso]  WITH CHECK ADD  CONSTRAINT [FK_tPermiso_tRol] FOREIGN KEY([rolName])
REFERENCES [dbo].[tRol] ([rolName])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tPermiso] CHECK CONSTRAINT [FK_tPermiso_tRol]
GO
ALTER TABLE [dbo].[tUsuario]  WITH CHECK ADD  CONSTRAINT [FK_tUsuario_tRol] FOREIGN KEY([rolName])
REFERENCES [dbo].[tRol] ([rolName])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tUsuario] CHECK CONSTRAINT [FK_tUsuario_tRol]
GO
/****** Object:  StoredProcedure [dbo].[InsertarUsuario]    Script Date: 21/10/2018 16:47:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertarUsuario] 
	(@u varchar(50), @p varchar(50), @u2 varchar(50), @p2 varchar(50), @r varchar(50))
	
AS
BEGIN
	
	IF (SELECT R.admin FROM tRol R INNER JOIN tUsuario U ON R.rolName LIKE U.rolName WHERE U.nombre = @u AND U.password = @p) = 1
		INSERT INTO tUsuario VALUES (@u2,@p2,@r)

END

GO
USE [master]
GO
ALTER DATABASE [GI1819] SET  READ_WRITE 
GO
