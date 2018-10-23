-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE insertUser(
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
