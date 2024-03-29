USE [master]
GO
/****** Object:  Database [PELUQUERIA_DB]    Script Date: 1/30/2024 3:44:53 PM ******/
CREATE DATABASE [PELUQUERIA_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PELUQUERIA_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLAS2022\MSSQL\DATA\PELUQUERIA_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PELUQUERIA_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLAS2022\MSSQL\DATA\PELUQUERIA_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PELUQUERIA_DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PELUQUERIA_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PELUQUERIA_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PELUQUERIA_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PELUQUERIA_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PELUQUERIA_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PELUQUERIA_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [PELUQUERIA_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PELUQUERIA_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PELUQUERIA_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PELUQUERIA_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PELUQUERIA_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PELUQUERIA_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PELUQUERIA_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PELUQUERIA_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PELUQUERIA_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PELUQUERIA_DB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PELUQUERIA_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PELUQUERIA_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PELUQUERIA_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PELUQUERIA_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PELUQUERIA_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PELUQUERIA_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PELUQUERIA_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PELUQUERIA_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [PELUQUERIA_DB] SET  MULTI_USER 
GO
ALTER DATABASE [PELUQUERIA_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PELUQUERIA_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PELUQUERIA_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PELUQUERIA_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PELUQUERIA_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PELUQUERIA_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PELUQUERIA_DB', N'ON'
GO
ALTER DATABASE [PELUQUERIA_DB] SET QUERY_STORE = OFF
GO
USE [PELUQUERIA_DB]
GO
/****** Object:  Table [dbo].[Corte]    Script Date: 1/30/2024 3:44:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Corte](
	[IdCorte] [int] IDENTITY(1,1) NOT NULL,
	[TipoCorte] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCorte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_cortes]    Script Date: 1/30/2024 3:44:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[fn_cortes]()
returns table
as
return
	Select IdCorte, TipoCorte from Corte
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 1/30/2024 3:44:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_empleados]    Script Date: 1/30/2024 3:44:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[fn_empleados]()
returns table
as
return
	Select IdEmpleado, Nombre from Empleado
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 1/30/2024 3:44:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turno](
	[IdTurno] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NULL,
	[NombreCliente] [varchar](50) NULL,
	[IdEmpleado] [int] NULL,
	[IdCorte] [int] NULL,
	[Importe] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTurno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_turnos]    Script Date: 1/30/2024 3:44:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[fn_turnos]()
returns table
as
return 
	Select t.IdTurno, t.Fecha, t.NombreCliente,
	c.IdCorte, c.TipoCorte, e.IdEmpleado, e.Nombre
	From Turno t
	inner join Corte c on c.IdCorte = t.IdCorte
	inner join Empleado e on e.IdEmpleado = t.IdEmpleado
GO
/****** Object:  UserDefinedFunction [dbo].[fn_turno]    Script Date: 1/30/2024 3:44:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[fn_turno](@idTurno int)
returns table
as
return 
	Select t.IdTurno, t.Fecha, t.NombreCliente,
	c.IdCorte, c.TipoCorte, e.IdEmpleado, e.Nombre
	From Turno t
	inner join Corte c on c.IdCorte = t.IdCorte
	inner join Empleado e on e.IdEmpleado = t.IdEmpleado
	where t.IdTurno = @idTurno
GO
/****** Object:  UserDefinedFunction [dbo].[fn_corte]    Script Date: 1/30/2024 3:44:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[fn_corte](@idCorte int)
returns table
as
return
	Select IdCorte, TipoCorte from Corte
	Where IdCorte = @idCorte
GO
/****** Object:  UserDefinedFunction [dbo].[fn_empleado]    Script Date: 1/30/2024 3:44:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[fn_empleado](@idEmpleado int)
returns table
as
return
	Select IdEmpleado, Nombre from Empleado
	Where IdEmpleado = @idEmpleado
GO
SET IDENTITY_INSERT [dbo].[Corte] ON 

INSERT [dbo].[Corte] ([IdCorte], [TipoCorte]) VALUES (1, N'BUZZ')
INSERT [dbo].[Corte] ([IdCorte], [TipoCorte]) VALUES (2, N'FADE')
INSERT [dbo].[Corte] ([IdCorte], [TipoCorte]) VALUES (3, N'MILITAR')
INSERT [dbo].[Corte] ([IdCorte], [TipoCorte]) VALUES (4, N'MOHICANO')
INSERT [dbo].[Corte] ([IdCorte], [TipoCorte]) VALUES (5, N'FRANCESA CLARA')
SET IDENTITY_INSERT [dbo].[Corte] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre]) VALUES (1, N'Arturo Mendez')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre]) VALUES (2, N'Franco Gonzales')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre]) VALUES (3, N'Juan Laje')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre]) VALUES (4, N'Facundo Ugarte')
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
SET IDENTITY_INSERT [dbo].[Turno] ON 

INSERT [dbo].[Turno] ([IdTurno], [Fecha], [NombreCliente], [IdEmpleado], [IdCorte], [Importe]) VALUES (1, CAST(N'2024-01-27' AS Date), N'Rodrigo Ruiz', 1, 1, CAST(2500.00 AS Decimal(10, 2)))
INSERT [dbo].[Turno] ([IdTurno], [Fecha], [NombreCliente], [IdEmpleado], [IdCorte], [Importe]) VALUES (3, CAST(N'2024-01-02' AS Date), N'Arturo', 3, 5, CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[Turno] ([IdTurno], [Fecha], [NombreCliente], [IdEmpleado], [IdCorte], [Importe]) VALUES (5, CAST(N'2024-01-29' AS Date), N'Felipe', 1, 3, CAST(0.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Turno] OFF
GO
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD FOREIGN KEY([IdCorte])
REFERENCES [dbo].[Corte] ([IdCorte])
GO
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
GO
/****** Object:  StoredProcedure [dbo].[sp_CrearCorte]    Script Date: 1/30/2024 3:44:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_CrearCorte](
@TipoCorte varchar(50)
)
as
begin
	Insert into Corte(TipoCorte)
	values(@TipoCorte)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_CrearEmpleado]    Script Date: 1/30/2024 3:44:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_CrearEmpleado](
@Nombre varchar(50)
)
as
begin
	Insert into Empleado(Nombre)
	values(@Nombre)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_CrearTurno]    Script Date: 1/30/2024 3:44:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_CrearTurno](
@Fecha date,
@NombreCliente varchar(50),
@IdEmpleado int,
@IdCorte int
)
as
begin
	set dateformat dmy
	Insert into Turno(Fecha, NombreCliente, IdEmpleado, IdCorte)
	values(@Fecha, @NombreCliente, @IdEmpleado, @IdCorte)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_EditarCorte]    Script Date: 1/30/2024 3:44:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_EditarCorte](
@IdCorte int,
@TipoCorte varchar(50)
)
as
begin
	Update Corte set
	TipoCorte = @TipoCorte
	Where IdCorte = @IdCorte
end
GO
/****** Object:  StoredProcedure [dbo].[sp_EditarEmpleado]    Script Date: 1/30/2024 3:44:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_EditarEmpleado](
@IdEmpleado int,
@Nombre varchar(50)
)
as
begin
	Update Empleado set
	Nombre = @Nombre
	Where IdEmpleado = @IdEmpleado
end
GO
/****** Object:  StoredProcedure [dbo].[sp_EditarTurno]    Script Date: 1/30/2024 3:44:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_EditarTurno](
@IdTurno int,
@Fecha date,
@NombreCliente varchar(50),
@IdEmpleado int,
@IdCorte int
)
as
begin
	set dateformat dmy
	Update Turno set
	Fecha = @Fecha, 
	NombreCliente = @NombreCliente, 
	IdEmpleado = @IdEmpleado,
	IdCorte = @IdCorte
	Where IdTurno = @IdTurno
end
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarCorte]    Script Date: 1/30/2024 3:44:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_EliminarCorte](
@IdCorte int
)
as
begin
	Delete from Corte
	Where IdCorte = @IdCorte
end
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarEmpleado]    Script Date: 1/30/2024 3:44:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_EliminarEmpleado](
@IdEmpleado int
)
as
begin
	Delete from Empleado
	Where IdEmpleado = @IdEmpleado
end
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarTurno]    Script Date: 1/30/2024 3:44:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_EliminarTurno](
@IdTurno int)
as
begin
	Delete from Turno
	Where IdTurno = @IdTurno
end
GO
USE [master]
GO
ALTER DATABASE [PELUQUERIA_DB] SET  READ_WRITE 
GO
