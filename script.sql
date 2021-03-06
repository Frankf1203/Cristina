USE [master]
GO
/****** Object:  Database [EncomiendaCristinaBD]    Script Date: 10/28/2018 3:27:54 PM ******/
CREATE DATABASE [EncomiendaCristinaBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EncomiendaCristinaBD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\EncomiendaCristinaBD.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EncomiendaCristinaBD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\EncomiendaCristinaBD_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EncomiendaCristinaBD] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EncomiendaCristinaBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EncomiendaCristinaBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET  MULTI_USER 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EncomiendaCristinaBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [EncomiendaCristinaBD] SET DELAYED_DURABILITY = DISABLED 
GO
USE [EncomiendaCristinaBD]
GO
/****** Object:  Table [dbo].[Arqueo_de_Caja]    Script Date: 10/28/2018 3:27:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Arqueo_de_Caja](
	[Codigo_Arqueo] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Monto_Inicial] [float] NOT NULL,
	[Monto_Final] [float] NOT NULL,
	[Codigo_Usuario] [int] NOT NULL,
	[Codigo_Estado] [int] NOT NULL,
 CONSTRAINT [PK_Arqueo_de_Caja] PRIMARY KEY CLUSTERED 
(
	[Codigo_Arqueo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Buses]    Script Date: 10/28/2018 3:27:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buses](
	[Placa_Bus] [nvarchar](50) NOT NULL,
	[Marca_Bus] [nvarchar](50) NOT NULL,
	[Modelo_Bus] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Buses] PRIMARY KEY CLUSTERED 
(
	[Placa_Bus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Buses_Ciudades]    Script Date: 10/28/2018 3:27:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buses_Ciudades](
	[Placa_Bus] [nvarchar](50) NOT NULL,
	[Codigo_Ciudad] [int] NOT NULL,
 CONSTRAINT [PK_Buses_Ciudades] PRIMARY KEY CLUSTERED 
(
	[Placa_Bus] ASC,
	[Codigo_Ciudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ciudad]    Script Date: 10/28/2018 3:27:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudad](
	[Codigo_Ciudad] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Ciudad] [nvarchar](50) NOT NULL,
	[Nombre_Corto] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ciudad] PRIMARY KEY CLUSTERED 
(
	[Codigo_Ciudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 10/28/2018 3:27:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Identidad_Cliente] [nvarchar](50) NOT NULL,
	[Nombre_Cliente] [nvarchar](50) NOT NULL,
	[Apellido_Cliente] [nvarchar](50) NOT NULL,
	[Celular] [int] NOT NULL,
	[RTN] [nvarchar](50) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Identidad_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 10/28/2018 3:27:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Codigo_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Identidad_Empleado] [nvarchar](50) NOT NULL,
	[Nombre_Empleado] [nvarchar](50) NOT NULL,
	[Apellido_Empleado] [nvarchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[Telefono] [int] NULL,
	[Celular] [int] NULL,
	[Usuario] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
	[Codigo_Puesto] [int] NOT NULL,
	[Codigo_Estado] [int] NOT NULL,
	[Intentos] [int] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[Codigo_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Encomienda]    Script Date: 10/28/2018 3:27:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Encomienda](
	[Numero_Guia] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion_Encomienda] [nvarchar](50) NOT NULL,
	[Codigo_Tipo_Encomienda] [int] NOT NULL,
	[Codigo_Ciudad] [int] NOT NULL,
	[Codigo_Estado] [int] NOT NULL,
 CONSTRAINT [PK_Encomienda] PRIMARY KEY CLUSTERED 
(
	[Numero_Guia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Estados]    Script Date: 10/28/2018 3:27:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estados](
	[Codigo_Estado] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion_Estado] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED 
(
	[Codigo_Estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Factura_Encomienda]    Script Date: 10/28/2018 3:27:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura_Encomienda](
	[Codigo_Factura_Envio] [int] IDENTITY(1,1) NOT NULL,
	[Numero_Guia] [int] NOT NULL,
	[Fecha_Emision] [date] NOT NULL,
	[Codigo_Usuario] [int] NOT NULL,
	[Identidad_Cliente] [nvarchar](50) NOT NULL,
	[Destinatario] [nvarchar](50) NOT NULL,
	[Precio] [float] NOT NULL,
 CONSTRAINT [PK_Factura_Encomienda] PRIMARY KEY CLUSTERED 
(
	[Codigo_Factura_Envio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Preguntas]    Script Date: 10/28/2018 3:27:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Preguntas](
	[Codigo_Pregunta] [int] IDENTITY(1,1) NOT NULL,
	[Pregunta] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Preguntas] PRIMARY KEY CLUSTERED 
(
	[Codigo_Pregunta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Puesto]    Script Date: 10/28/2018 3:27:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Puesto](
	[Codigo_Puesto] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion_Puesto] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[Codigo_Puesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Respuestas]    Script Date: 10/28/2018 3:27:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Respuestas](
	[Codigo_Usuario] [int] NOT NULL,
	[Cod_Pregunta] [int] NOT NULL,
	[Respuesta] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Respuestas] PRIMARY KEY CLUSTERED 
(
	[Codigo_Usuario] ASC,
	[Cod_Pregunta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tipo_Encomienda]    Script Date: 10/28/2018 3:27:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Encomienda](
	[Codigo_Tipo_Encomienda] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion_Tipo_Encomienda] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tipo_Encomienda] PRIMARY KEY CLUSTERED 
(
	[Codigo_Tipo_Encomienda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Arqueo_de_Caja]  WITH CHECK ADD  CONSTRAINT [FK_Arqueo_de_Caja_Empleados] FOREIGN KEY([Codigo_Usuario])
REFERENCES [dbo].[Empleados] ([Codigo_Usuario])
GO
ALTER TABLE [dbo].[Arqueo_de_Caja] CHECK CONSTRAINT [FK_Arqueo_de_Caja_Empleados]
GO
ALTER TABLE [dbo].[Arqueo_de_Caja]  WITH CHECK ADD  CONSTRAINT [FK_Arqueo_de_Caja_Estados] FOREIGN KEY([Codigo_Estado])
REFERENCES [dbo].[Estados] ([Codigo_Estado])
GO
ALTER TABLE [dbo].[Arqueo_de_Caja] CHECK CONSTRAINT [FK_Arqueo_de_Caja_Estados]
GO
ALTER TABLE [dbo].[Buses_Ciudades]  WITH CHECK ADD  CONSTRAINT [FK_Buses_Ciudades_Buses] FOREIGN KEY([Placa_Bus])
REFERENCES [dbo].[Buses] ([Placa_Bus])
GO
ALTER TABLE [dbo].[Buses_Ciudades] CHECK CONSTRAINT [FK_Buses_Ciudades_Buses]
GO
ALTER TABLE [dbo].[Buses_Ciudades]  WITH CHECK ADD  CONSTRAINT [FK_Buses_Ciudades_Ciudad] FOREIGN KEY([Codigo_Ciudad])
REFERENCES [dbo].[Ciudad] ([Codigo_Ciudad])
GO
ALTER TABLE [dbo].[Buses_Ciudades] CHECK CONSTRAINT [FK_Buses_Ciudades_Ciudad]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Estados] FOREIGN KEY([Codigo_Estado])
REFERENCES [dbo].[Estados] ([Codigo_Estado])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Estados]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Puesto] FOREIGN KEY([Codigo_Puesto])
REFERENCES [dbo].[Puesto] ([Codigo_Puesto])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Puesto]
GO
ALTER TABLE [dbo].[Encomienda]  WITH CHECK ADD  CONSTRAINT [FK_Encomienda_Ciudad] FOREIGN KEY([Codigo_Ciudad])
REFERENCES [dbo].[Ciudad] ([Codigo_Ciudad])
GO
ALTER TABLE [dbo].[Encomienda] CHECK CONSTRAINT [FK_Encomienda_Ciudad]
GO
ALTER TABLE [dbo].[Encomienda]  WITH CHECK ADD  CONSTRAINT [FK_Encomienda_Estados] FOREIGN KEY([Codigo_Estado])
REFERENCES [dbo].[Estados] ([Codigo_Estado])
GO
ALTER TABLE [dbo].[Encomienda] CHECK CONSTRAINT [FK_Encomienda_Estados]
GO
ALTER TABLE [dbo].[Encomienda]  WITH CHECK ADD  CONSTRAINT [FK_Encomienda_Tipo_Encomienda] FOREIGN KEY([Codigo_Tipo_Encomienda])
REFERENCES [dbo].[Tipo_Encomienda] ([Codigo_Tipo_Encomienda])
GO
ALTER TABLE [dbo].[Encomienda] CHECK CONSTRAINT [FK_Encomienda_Tipo_Encomienda]
GO
ALTER TABLE [dbo].[Factura_Encomienda]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Encomienda_Clientes] FOREIGN KEY([Identidad_Cliente])
REFERENCES [dbo].[Clientes] ([Identidad_Cliente])
GO
ALTER TABLE [dbo].[Factura_Encomienda] CHECK CONSTRAINT [FK_Factura_Encomienda_Clientes]
GO
ALTER TABLE [dbo].[Factura_Encomienda]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Encomienda_Empleados] FOREIGN KEY([Codigo_Usuario])
REFERENCES [dbo].[Empleados] ([Codigo_Usuario])
GO
ALTER TABLE [dbo].[Factura_Encomienda] CHECK CONSTRAINT [FK_Factura_Encomienda_Empleados]
GO
ALTER TABLE [dbo].[Factura_Encomienda]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Encomienda_Encomienda] FOREIGN KEY([Numero_Guia])
REFERENCES [dbo].[Encomienda] ([Numero_Guia])
GO
ALTER TABLE [dbo].[Factura_Encomienda] CHECK CONSTRAINT [FK_Factura_Encomienda_Encomienda]
GO
USE [master]
GO
ALTER DATABASE [EncomiendaCristinaBD] SET  READ_WRITE 
GO
