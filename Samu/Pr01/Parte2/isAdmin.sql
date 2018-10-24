-- ================================================
-- Template generated from Template Explorer using:
-- Create Inline Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Samuel Jurado
-- Create date: 19/10/2018
-- Description:	given an username and a password, returns if the user is admin.
-- =============================================
CREATE FUNCTION isAdministrator (@username varchar(50), @password varchar(50))
RETURNS BIT 
AS BEGIN
RETURN
(
	-- Add the SELECT statement with parameter references here
	SELECT r.admin FROM tRol r JOIN tUser u ON u.rolName=r.rolName WHERE u.name=@username AND u.password=@password
)
END
GO
