USE [master]
GO
/****** Object:  Database [Nutricion]    Script Date: 17/05/2019 13:32:23 ******/
CREATE DATABASE [Nutricion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Nutricion', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Nutricion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Nutricion_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Nutricion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Nutricion] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Nutricion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Nutricion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Nutricion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Nutricion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Nutricion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Nutricion] SET ARITHABORT OFF 
GO
ALTER DATABASE [Nutricion] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Nutricion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Nutricion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Nutricion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Nutricion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Nutricion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Nutricion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Nutricion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Nutricion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Nutricion] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Nutricion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Nutricion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Nutricion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Nutricion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Nutricion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Nutricion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Nutricion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Nutricion] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Nutricion] SET  MULTI_USER 
GO
ALTER DATABASE [Nutricion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Nutricion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Nutricion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Nutricion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Nutricion] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Nutricion] SET QUERY_STORE = OFF
GO
USE [Nutricion]
GO
/****** Object:  Table [dbo].[Indice]    Script Date: 17/05/2019 13:32:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Indice](
	[imc] [varchar](50) NOT NULL,
	[contador] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nutricion]    Script Date: 17/05/2019 13:32:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nutricion](
	[nombre] [varchar](50) NOT NULL,
	[id_tipo] [varchar](50) NOT NULL,
	[id] [varchar](50) NOT NULL,
	[pais] [varchar](50) NOT NULL,
	[permanencia] [int] NOT NULL,
	[genero] [varchar](50) NOT NULL,
	[nacimiento] [date] NOT NULL,
	[estado] [varchar](50) NOT NULL,
	[hijos] [int] NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[barrio] [varchar](50) NOT NULL,
	[telefono] [varchar](50) NOT NULL,
	[ocupacion] [varchar](50) NOT NULL,
	[escolaridad] [varchar](50) NOT NULL,
	[eps] [varchar](50) NOT NULL,
	[regimen] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[contacto] [varchar](50) NOT NULL,
	[antecedentes] [varchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 17/05/2019 13:32:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[usuario] [varchar](50) NOT NULL,
	[contraseña] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Indice] ([imc], [contador]) VALUES (N'delgadez severa', 3)
INSERT [dbo].[Indice] ([imc], [contador]) VALUES (N'delgadez moderada', 0)
INSERT [dbo].[Indice] ([imc], [contador]) VALUES (N'delgadez aceptable', 0)
INSERT [dbo].[Indice] ([imc], [contador]) VALUES (N'Peso normal', 4)
INSERT [dbo].[Indice] ([imc], [contador]) VALUES (N'Sobrepeso', 0)
INSERT [dbo].[Indice] ([imc], [contador]) VALUES (N'Obeso tipo I', 1)
INSERT [dbo].[Indice] ([imc], [contador]) VALUES (N'Obeso tipo II', 0)
INSERT [dbo].[Indice] ([imc], [contador]) VALUES (N'Obeso tipo III', 1)
INSERT [dbo].[Nutricion] ([nombre], [id_tipo], [id], [pais], [permanencia], [genero], [nacimiento], [estado], [hijos], [direccion], [barrio], [telefono], [ocupacion], [escolaridad], [eps], [regimen], [email], [contacto], [antecedentes]) VALUES (N'sqs', N'Cedula', N'sqs', N'Colombia', 1, N'M', CAST(N'2019-05-15' AS Date), N'Soltero', 1, N'wsqs', N'qsq', N'sq', N'sqs', N'primaria', N'Sura', N'Sunsidiado', N'sqs', N'sqs', N'sqsq')
INSERT [dbo].[Nutricion] ([nombre], [id_tipo], [id], [pais], [permanencia], [genero], [nacimiento], [estado], [hijos], [direccion], [barrio], [telefono], [ocupacion], [escolaridad], [eps], [regimen], [email], [contacto], [antecedentes]) VALUES (N'sqs', N'Cedula', N'sqs', N'Colombia', 1, N'M', CAST(N'2019-05-15' AS Date), N'Soltero', 1, N'wsqs', N'qsq', N'sq', N'sqs', N'primaria', N'Sura', N'Sunsidiado', N'sqs', N'sqs', N'sqsq')
INSERT [dbo].[Nutricion] ([nombre], [id_tipo], [id], [pais], [permanencia], [genero], [nacimiento], [estado], [hijos], [direccion], [barrio], [telefono], [ocupacion], [escolaridad], [eps], [regimen], [email], [contacto], [antecedentes]) VALUES (N'prubea', N'Cedula', N'2323', N'Colombia', 230, N'M', CAST(N'2019-05-15' AS Date), N'Soltero', 2, N'medellin', N'cdc', N'232', N'323', N'primaria', N'Sura', N'Sunsidiado', N'dds', N'wewe', N'we')
INSERT [dbo].[Nutricion] ([nombre], [id_tipo], [id], [pais], [permanencia], [genero], [nacimiento], [estado], [hijos], [direccion], [barrio], [telefono], [ocupacion], [escolaridad], [eps], [regimen], [email], [contacto], [antecedentes]) VALUES (N'Camila', N'Cedula', N'2323', N'Colombia', 3, N'M', CAST(N'2019-05-15' AS Date), N'Soltero', 3, N'sds', N'sd', N'323', N'323', N'primaria', N'Sura', N'Sunsidiado', N'dwd', N'232', N'32323')
INSERT [dbo].[Nutricion] ([nombre], [id_tipo], [id], [pais], [permanencia], [genero], [nacimiento], [estado], [hijos], [direccion], [barrio], [telefono], [ocupacion], [escolaridad], [eps], [regimen], [email], [contacto], [antecedentes]) VALUES (N'Camila', N'Cedula', N'123456', N'Afganistán', 1, N'F', CAST(N'1996-06-13' AS Date), N'Soltero', 0, N'cra # 34 54', N'laureles', N'3434', N'abogado', N'Profesional', N'Sura', N'Contributivo', N'sjjdgmail.com', N'34535', N'ninguno')
INSERT [dbo].[Nutricion] ([nombre], [id_tipo], [id], [pais], [permanencia], [genero], [nacimiento], [estado], [hijos], [direccion], [barrio], [telefono], [ocupacion], [escolaridad], [eps], [regimen], [email], [contacto], [antecedentes]) VALUES (N'Maria', N'Cedula', N'23243', N'Colombia', 2, N'M', CAST(N'2019-05-15' AS Date), N'Soltero', 0, N'cra # 425', N'cordoba', N'2323', N'abogada', N'Primaria', N'Alians', N'Contributivo', N'dadka@hadj.com', N'2323', N'ninguno')
INSERT [dbo].[usuario] ([usuario], [contraseña]) VALUES (N'admin', N'admin')
USE [master]
GO
ALTER DATABASE [Nutricion] SET  READ_WRITE 
GO
