USE [master]
GO
/****** Object:  Database [Ayuntamiento]    Script Date: 14/01/2016 10:34:33 ******/
CREATE DATABASE [Ayuntamiento]
GO

USE [Ayuntamiento]
GO
/****** Object:  Table [dbo].[tConcejal]    Script Date: 14/01/2016 10:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tConcejal](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[siglas] [varchar](10) NOT NULL,
	[nombre] [varchar](80) NOT NULL,
 CONSTRAINT [PK_tConcejal_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tPartido]    Script Date: 14/01/2016 10:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tPartido](
	[siglas] [varchar](10) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_tPartido] PRIMARY KEY CLUSTERED 
(
	[siglas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tConcejal]  WITH CHECK ADD  CONSTRAINT [FK_tConcejal_tPartido] FOREIGN KEY([siglas])
REFERENCES [dbo].[tPartido] ([siglas])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tConcejal] CHECK CONSTRAINT [FK_tConcejal_tPartido]
GO

INSERT INTO tPartido VALUES('PP','Partido Popular');
INSERT INTO tPartido VALUES('PSOE','Partido Socialista Obrero Español');
INSERT INTO tPartido VALUES('CS','Ciudadanos');
INSERT INTO tPartido VALUES('MA','Málaga Ahora');
INSERT INTO tPartido VALUES('IU','IULV-CA-CLI-AS-ALTER-Málaga para la Gente');
GO


INSERT INTO tConcejal VALUES('PP','Francisco Manuel de la Torre Prados');
INSERT INTO tConcejal VALUES('PP','Elías Bendodo Benasayag');
INSERT INTO tConcejal VALUES('PP','Elvira Maeso González');
INSERT INTO tConcejal VALUES('PP','Mario Cortés Carballo');
INSERT INTO tConcejal VALUES('PP','María. del Mar Martín Rojo');
INSERT INTO tConcejal VALUES('PP','María. Teresa Porras Teruel');
INSERT INTO tConcejal VALUES('PP','Francisco Javier Pomares Fuertes');
INSERT INTO tConcejal VALUES('PP','Julio Andrade Ruiz');
INSERT INTO tConcejal VALUES('PP','Raúl Jiménez Jiménez');
INSERT INTO tConcejal VALUES('PP','Francisca Bazalo Gallego');
INSERT INTO tConcejal VALUES('PP','Elisa Pérez de Siles Calvo');
INSERT INTO tConcejal VALUES('PP','Gemma del Corral Parra');
INSERT INTO tConcejal VALUES('PP','Carlos María Conde O’Donnell');
INSERT INTO tConcejal VALUES('PSOE','María Gámez Gámez');
INSERT INTO tConcejal VALUES('PSOE','Francisco Javier Conejo Rueda');
INSERT INTO tConcejal VALUES('PSOE','Estefanía Martín Palop');
INSERT INTO tConcejal VALUES('PSOE','Daniel Pérez Morales');
INSERT INTO tConcejal VALUES('PSOE','María del Carmen Moreno Sánchez');
INSERT INTO tConcejal VALUES('PSOE','José Carlos Durán Peralta');
INSERT INTO tConcejal VALUES('PSOE','Lorena Doña Morales');
INSERT INTO tConcejal VALUES('PSOE','Rafael Francisco Gálvez Chica');
INSERT INTO tConcejal VALUES('PSOE','María. Begoña Medina Sánchez');
INSERT INTO tConcejal VALUES('CS','Juan Cassá Lombardía');
INSERT INTO tConcejal VALUES('CS','Gonzalo Manuel Sichar Moreno');
INSERT INTO tConcejal VALUES('CS','Alejandro Damián Carballo Gutiérrez');
INSERT INTO tConcejal VALUES('MA','Ysabel de los Ángeles Torralbo Calzado');
INSERT INTO tConcejal VALUES('MA','Isabel Jiménez Santaella');
INSERT INTO tConcejal VALUES('MA','Juan José Espinosa Sampedro');
INSERT INTO tConcejal VALUES('MA','María Rosa Galindo González');
INSERT INTO tConcejal VALUES('IU','Eduardo Esteban Zorrilla Díaz');
INSERT INTO tConcejal VALUES('IU','Remedios Ramos Sánchez');

GO