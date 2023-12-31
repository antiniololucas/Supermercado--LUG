USE [master]
GO
/****** Object:  Database [Supermercado-LUG]    Script Date: 27/11/2023 13:01:47 ******/
CREATE DATABASE [Supermercado-LUG]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Supermercado-LUG', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Supermercado-LUG.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Supermercado-LUG_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Supermercado-LUG_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Supermercado-LUG] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Supermercado-LUG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Supermercado-LUG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET ARITHABORT OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Supermercado-LUG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Supermercado-LUG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Supermercado-LUG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Supermercado-LUG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET RECOVERY FULL 
GO
ALTER DATABASE [Supermercado-LUG] SET  MULTI_USER 
GO
ALTER DATABASE [Supermercado-LUG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Supermercado-LUG] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Supermercado-LUG] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Supermercado-LUG] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Supermercado-LUG] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Supermercado-LUG] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Supermercado-LUG', N'ON'
GO
ALTER DATABASE [Supermercado-LUG] SET QUERY_STORE = ON
GO
ALTER DATABASE [Supermercado-LUG] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Supermercado-LUG]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[id] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[dni] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[telefono] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[id] [int] NOT NULL,
	[nro_venta] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[cant_producto] [int] NOT NULL,
	[subtotal] [int] NOT NULL,
 CONSTRAINT [PK_DetalleVenta_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginUser]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginUser](
	[user_id] [int] NOT NULL,
	[password] [nvarchar](max) NOT NULL,
	[id_cliente] [int] NULL,
	[admin] [bit] NOT NULL,
 CONSTRAINT [PK_LoginUser] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedioDePago]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedioDePago](
	[id_cliente] [int] NOT NULL,
	[id_tipo_tarjeta] [int] NOT NULL,
	[nro_tarjeta] [int] NOT NULL,
	[fecha_caducidad] [datetime] NOT NULL,
	[cvv] [int] NOT NULL,
 CONSTRAINT [PK_MedioDePago] PRIMARY KEY CLUSTERED 
(
	[nro_tarjeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](150) NOT NULL,
	[id_categoria] [int] NOT NULL,
	[precio] [money] NOT NULL,
	[stock] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoTarjeta]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoTarjeta](
	[id] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TipoTarjeta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[nro_venta] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[total] [money] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[nro_tarjeta] [int] NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[nro_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Categoria] ([id], [nombre], [descripcion]) VALUES (1, N'Pastas', N'Harina')
INSERT [dbo].[Categoria] ([id], [nombre], [descripcion]) VALUES (3, N'Lacteos', N'La Serenisima')
INSERT [dbo].[Categoria] ([id], [nombre], [descripcion]) VALUES (4, N'Carne', N'Frigorifico')
INSERT [dbo].[Categoria] ([id], [nombre], [descripcion]) VALUES (7, N'Frutos Secos', N'Dietetica')
GO
INSERT [dbo].[Cliente] ([dni], [nombre], [apellido], [telefono]) VALUES (1, N'Lucas', N'Antiñolo', N'123')
INSERT [dbo].[Cliente] ([dni], [nombre], [apellido], [telefono]) VALUES (2, N'Tomas', N'Juarez', N'321')
INSERT [dbo].[Cliente] ([dni], [nombre], [apellido], [telefono]) VALUES (3, N'Pedro', N'Perez', N'456')
INSERT [dbo].[Cliente] ([dni], [nombre], [apellido], [telefono]) VALUES (123456, N'Jorge', N'Roda', N'123456789')
INSERT [dbo].[Cliente] ([dni], [nombre], [apellido], [telefono]) VALUES (44891735, N'Tomas Agustin', N'Juarez Iglesias', N'1154984213')
INSERT [dbo].[Cliente] ([dni], [nombre], [apellido], [telefono]) VALUES (45225577, N'Lucas Pablo', N'Antiñolo', N'1135875457')
GO
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (1, 1, 6, 3, 3)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (2, 2, 6, 2, 2)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (3, 2, 2, 4, 200)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (4, 2, 9, 5, 2250)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (5, 3, 2, 5, 250)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (6, 3, 5, 5, 125)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (7, 3, 8, 4, 4)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (8, 4, 5, 7, 175)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (9, 5, 5, 4, 100)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (10, 5, 1, 3, 3)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (11, 5, 8, 4, 4)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (12, 6, 4, 4, 40)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (13, 6, 1, 2, 2)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (14, 6, 6, 4, 4)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (15, 6, 9, 5, 2250)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (16, 7, 4, 4, 40)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (17, 7, 8, 6, 6)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (18, 7, 9, 8, 3600)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (19, 8, 2, 3, 150)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (20, 8, 5, 4, 100)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (21, 8, 4, 2, 20)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (22, 8, 4, 5, 50)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (23, 9, 4, 3, 30)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (24, 9, 6, 4, 4)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (25, 10, 2, 3, 150)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (26, 10, 8, 3, 3)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (27, 11, 2, 2, 20)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (28, 11, 5, 2, 50)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (29, 12, 4, 2, 20)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (30, 13, 6, 1, 1)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (31, 13, 5, 12, 300)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (32, 13, 8, 1, 1)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (33, 14, 4, 3, 30)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (34, 14, 9, 2, 900)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (35, 14, 1, 1, 121)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (36, 15, 1, 3, 540)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (37, 15, 4, 3, 30)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (38, 16, 1, 3, 270)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (39, 17, 1, 4, 360)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (40, 17, 5, 4, 100)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (41, 17, 4, 3, 30)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (42, 17, 5, 1, 25)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (43, 17, 6, 3, 270)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (44, 18, 2, 3, 270)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (45, 18, 4, 1, 10)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (46, 18, 8, 3, 270)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (47, 18, 10, 3, 270)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (48, 18, 9, 3, 1350)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (49, 20, 9, 4, 1800)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (50, 21, 9, 3, 1350)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (51, 22, 9, 5, 2250)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (52, 22, 4, 3, 204)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (53, 23, 9, 3, 1350)
INSERT [dbo].[DetalleVenta] ([id], [nro_venta], [id_producto], [cant_producto], [subtotal]) VALUES (54, 23, 4, 3, 204)
GO
INSERT [dbo].[LoginUser] ([user_id], [password], [id_cliente], [admin]) VALUES (0, N'8cc6cc816b1d23db06ea623f458ef3a696ebc41cac5445de1d5708e38ec498e2', 44891735, 1)
INSERT [dbo].[LoginUser] ([user_id], [password], [id_cliente], [admin]) VALUES (1, N'25bf8bed34cd760f1f5ca3c1a6cde0678c6af3deab16c588d864fbf0e94d06a8', 45225577, 1)
INSERT [dbo].[LoginUser] ([user_id], [password], [id_cliente], [admin]) VALUES (2, N'3640b3939687c891f3a7c88a48db3b99aa3cbfdf04bc3986e5ad0417df1a5715', 123456, 0)
GO
INSERT [dbo].[MedioDePago] ([id_cliente], [id_tipo_tarjeta], [nro_tarjeta], [fecha_caducidad], [cvv]) VALUES (1, 1, 23, CAST(N'2023-10-08T18:55:15.433' AS DateTime), 234)
INSERT [dbo].[MedioDePago] ([id_cliente], [id_tipo_tarjeta], [nro_tarjeta], [fecha_caducidad], [cvv]) VALUES (2, 2, 34, CAST(N'2023-09-25T10:09:33.000' AS DateTime), 132)
INSERT [dbo].[MedioDePago] ([id_cliente], [id_tipo_tarjeta], [nro_tarjeta], [fecha_caducidad], [cvv]) VALUES (1, 2, 1323, CAST(N'2023-10-09T16:18:59.457' AS DateTime), 21)
INSERT [dbo].[MedioDePago] ([id_cliente], [id_tipo_tarjeta], [nro_tarjeta], [fecha_caducidad], [cvv]) VALUES (2, 2, 5786, CAST(N'2023-10-27T11:12:59.547' AS DateTime), 178)
INSERT [dbo].[MedioDePago] ([id_cliente], [id_tipo_tarjeta], [nro_tarjeta], [fecha_caducidad], [cvv]) VALUES (123456, 1, 51174011, CAST(N'2023-11-27T11:27:39.620' AS DateTime), 123)
GO
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [id_categoria], [precio], [stock]) VALUES (1, N'Churrasco', N'...', 4, 90.0000, 0)
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [id_categoria], [precio], [stock]) VALUES (2, N'Arroz', N'...', 1, 90.0000, 0)
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [id_categoria], [precio], [stock]) VALUES (4, N'Gnoque', N'....', 1, 68.0000, 34)
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [id_categoria], [precio], [stock]) VALUES (5, N'Fideos', N'Tirabuzon', 1, 25.0000, 981)
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [id_categoria], [precio], [stock]) VALUES (6, N'Moñito', N'...', 7, 90.0000, 0)
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [id_categoria], [precio], [stock]) VALUES (8, N'Picles', N'...', 7, 90.0000, 1)
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [id_categoria], [precio], [stock]) VALUES (9, N'Suprema', N'Pollo', 4, 450.0000, 67)
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [id_categoria], [precio], [stock]) VALUES (10, N'Tallarin', N'...', 1, 90.0000, 7)
GO
INSERT [dbo].[TipoTarjeta] ([id], [nombre]) VALUES (1, N'MasterCard')
INSERT [dbo].[TipoTarjeta] ([id], [nombre]) VALUES (2, N'Visa')
INSERT [dbo].[TipoTarjeta] ([id], [nombre]) VALUES (3, N'American Express')
GO
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (1, 2, 3.0000, CAST(N'2023-10-09T16:29:03.377' AS DateTime), 34)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (2, 2, 2656.0000, CAST(N'2023-10-10T15:56:30.357' AS DateTime), 34)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (3, 1, 1004.0000, CAST(N'2023-10-10T16:08:19.950' AS DateTime), 1323)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (4, 1, 175.0000, CAST(N'2023-10-10T16:16:24.290' AS DateTime), 23)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (5, 1, 310.0000, CAST(N'2023-10-10T19:04:24.890' AS DateTime), 1323)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (6, 1, 2424.0000, CAST(N'2023-10-10T19:11:00.497' AS DateTime), 1323)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (7, 1, 3732.0000, CAST(N'2023-10-26T14:26:24.503' AS DateTime), 1323)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (8, 2, 320.0000, CAST(N'2023-10-27T11:08:35.617' AS DateTime), 34)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (9, 2, 34.0000, CAST(N'2023-10-27T11:09:20.377' AS DateTime), 34)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (10, 2, 153.0000, CAST(N'2023-10-27T11:10:31.503' AS DateTime), 34)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (11, 1, 70.0000, CAST(N'2023-10-27T11:23:24.500' AS DateTime), 23)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (12, 2, 20.0000, CAST(N'2023-10-27T11:28:22.940' AS DateTime), 34)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (13, 2, 302.0000, CAST(N'2023-10-30T10:47:18.950' AS DateTime), 5786)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (14, 1, 1051.0000, CAST(N'2023-11-06T10:33:16.893' AS DateTime), 23)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (15, 1, 570.0000, CAST(N'2023-11-06T10:35:33.790' AS DateTime), 23)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (16, 2, 270.0000, CAST(N'2023-11-06T10:50:54.607' AS DateTime), 34)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (17, 1, 785.0000, CAST(N'2023-11-06T11:18:57.973' AS DateTime), 1323)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (18, 2, 2170.0000, CAST(N'2023-11-08T11:57:29.730' AS DateTime), 34)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (19, 2, 0.0000, CAST(N'2023-11-25T13:45:06.903' AS DateTime), 5786)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (20, 123456, 1800.0000, CAST(N'2023-11-27T11:31:06.137' AS DateTime), 51174011)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (21, 123456, 1350.0000, CAST(N'2023-11-27T12:11:28.593' AS DateTime), 51174011)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (22, 123456, 2454.0000, CAST(N'2023-11-27T12:39:47.593' AS DateTime), 51174011)
INSERT [dbo].[Venta] ([nro_venta], [id_cliente], [total], [fecha], [nro_tarjeta]) VALUES (23, 123456, 1554.0000, CAST(N'2023-11-27T12:48:57.517' AS DateTime), 51174011)
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Producto] ([id])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_Producto]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Venta] FOREIGN KEY([nro_venta])
REFERENCES [dbo].[Venta] ([nro_venta])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_Venta]
GO
ALTER TABLE [dbo].[LoginUser]  WITH CHECK ADD  CONSTRAINT [FK_LoginUser_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([dni])
GO
ALTER TABLE [dbo].[LoginUser] CHECK CONSTRAINT [FK_LoginUser_Cliente]
GO
ALTER TABLE [dbo].[MedioDePago]  WITH CHECK ADD  CONSTRAINT [FK_MedioDePago_TipoTarjeta] FOREIGN KEY([id_tipo_tarjeta])
REFERENCES [dbo].[TipoTarjeta] ([id])
GO
ALTER TABLE [dbo].[MedioDePago] CHECK CONSTRAINT [FK_MedioDePago_TipoTarjeta]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categoria] ([id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([dni])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cliente]
GO
/****** Object:  StoredProcedure [dbo].[delete_categoria]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[delete_categoria]
 @In_id int
 as
 begin
 delete Categoria where id = @In_id
 end
GO
/****** Object:  StoredProcedure [dbo].[delete_cliente]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[delete_cliente]
@In_dni int
as
begin
delete Cliente
where dni = @In_dni
end
GO
/****** Object:  StoredProcedure [dbo].[delete_medio_pago]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[delete_medio_pago]
@In_nro_tarjeta int
as
begin
delete from MedioDePago where nro_tarjeta = @In_nro_tarjeta
end
GO
/****** Object:  StoredProcedure [dbo].[delete_producto]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[delete_producto]
@In_id int
as
begin
delete from Producto where id = @In_id
end
GO
/****** Object:  StoredProcedure [dbo].[getIdVenta]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getIdVenta]
as
begin
DECLARE @last_id int;
	SET @last_id = (SELECT COALESCE(MAX(nro_venta), 0) + 1 FROM Venta)
select @last_id
end
GO
/****** Object:  StoredProcedure [dbo].[insert_categoria]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insert_categoria]
	@In_nombre nvarchar(50) ,
	@In_descripcion nvarchar(150)
as
begin
	DECLARE @last_id int;
	SET @last_id = (SELECT COALESCE(MAX(id), 0) + 1 FROM Categoria)
	insert into Categoria (id, nombre , descripcion) 
	values ( @last_id , @In_nombre , @In_descripcion)
end
GO
/****** Object:  StoredProcedure [dbo].[insert_cliente]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insert_cliente]
@In_dni int, 
@In_nombre nvarchar(50),
@In_apellido nvarchar(50),
@In_telefono nvarchar(50)
as
begin
insert into Cliente (dni , nombre, apellido , telefono )
values
(@In_dni , @In_nombre , @In_apellido , @In_telefono )
end
GO
/****** Object:  StoredProcedure [dbo].[insert_detail]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insert_detail]
@In_nro_venta int,
@In_id_producto int ,
@In_cant_producto money,
@In_subtotal int
as 
begin
declare @last_id int;
set @last_id = (select COALESCE(MAX(id), 0 ) +1 FROM DetalleVenta)
insert into DetalleVenta
(id ,nro_venta , id_producto , cant_producto , subtotal)
values
(@last_id , @In_nro_venta , @In_id_producto , @In_cant_producto , @In_subtotal)
end

select * from Venta
GO
/****** Object:  StoredProcedure [dbo].[insert_medio_pago]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insert_medio_pago]
@In_id_cliente int,
@In_tipo_tarjeta int,
@In_nro_tarjeta int,
@In_fecha_caducidad datetime,
@In_cvv int
as
begin
insert into MedioDePago 
(id_cliente , id_tipo_tarjeta , nro_tarjeta , fecha_caducidad ,cvv)
values
(@In_id_cliente, 
@In_tipo_tarjeta , 
@In_nro_tarjeta ,
@In_fecha_caducidad ,
@In_cvv)
end
GO
/****** Object:  StoredProcedure [dbo].[insert_producto]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insert_producto]
(
	@In_nombre nvarchar(50),
	@In_descripcion nvarchar(150),
	@In_id_categoria int,
	@In_precio money,
	@In_stock int
)
AS 
BEGIN

	DECLARE @last_id int;
	SET @last_id = (SELECT COALESCE(MAX(id), 0) + 1 FROM Producto)
	INSERT INTO Producto (id, nombre, descripcion, id_categoria, precio, stock)
	VALUES (@last_id, @In_nombre, @In_descripcion, @In_id_categoria, @In_precio, @In_stock)

END
GO
/****** Object:  StoredProcedure [dbo].[insert_venta]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insert_venta]
@In_nro_venta int,
@In_id_cliente int ,
@In_total money,
@In_fecha datetime,
@In_nro_tarjeta int
as 
begin

insert into Venta 
(nro_venta , id_cliente , total , fecha , nro_tarjeta)
values
( @In_nro_venta , @In_id_cliente , @In_total , @In_fecha , @In_nro_tarjeta)
end
GO
/****** Object:  StoredProcedure [dbo].[select_categoria]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[select_categoria]
(
	@In_id int = NULL
)
as
begin
select * from Categoria WHERE id = @In_id OR @In_id IS NULL
end
GO
/****** Object:  StoredProcedure [dbo].[select_cliente]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[select_cliente]

as
begin
select * from Cliente
end
GO
/****** Object:  StoredProcedure [dbo].[select_detalles]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[select_detalles]
@In_nro_Venta int
as
begin
select * from DetalleVenta where nro_venta = @In_nro_Venta
end
GO
/****** Object:  StoredProcedure [dbo].[select_id_categoria]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[select_id_categoria]
@In_nombre nvarchar(50)
as
begin
select id from Categoria where nombre = @In_nombre
end
GO
/****** Object:  StoredProcedure [dbo].[select_last_venta]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[select_last_venta]
as
begin
declare @last_id int;
set @last_id = (select MAX(nro_venta) FROM Venta);
select * from Venta where nro_venta = @last_id
end
GO
/****** Object:  StoredProcedure [dbo].[select_medio_pago]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[select_medio_pago]
as
begin
select * from MedioDePago
end
GO
/****** Object:  StoredProcedure [dbo].[select_productos]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[select_productos]
(
	@In_id int = NULL
)
AS 
BEGIN
	SELECT * FROM Producto WHERE id = @In_id OR @In_id IS NULL
END
GO
/****** Object:  StoredProcedure [dbo].[select_tipo_tarjeta]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[select_tipo_tarjeta]
as
begin
select * from TipoTarjeta
end
GO
/****** Object:  StoredProcedure [dbo].[select_tipos_tarjetas]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[select_tipos_tarjetas]

AS 
BEGIN
	SELECT * FROM TipoTarjeta
END
GO
/****** Object:  StoredProcedure [dbo].[select_ventas]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[select_ventas]
as
begin
select * from Venta
end
GO
/****** Object:  StoredProcedure [dbo].[sp_create_user]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_create_user]
(
	@In_dni int, 
	@In_nombre nvarchar(50),
	@In_apellido nvarchar(50),
	@In_telefono nvarchar(50),
	@In_password nvarchar(MAX)
)
AS 
BEGIN
	INSERT INTO Cliente (dni , nombre, apellido , telefono )
	VALUES
	(@In_dni , @In_nombre , @In_apellido , @In_telefono )

	DECLARE @last_userId INT = ISNULL((SELECT MAX(user_id) + 1 FROM LoginUser), 0)

	INSERT INTO LoginUser (user_id, id_cliente, password, admin)
	VALUES (@last_userId, @In_dni, @In_password, 0)

END
GO
/****** Object:  StoredProcedure [dbo].[sp_get_metricas_ultima_semana]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_get_metricas_ultima_semana]
AS
BEGIN	
	SELECT ISNULL(SUM(Ventas.total), 0) AS TotalRecaudado, ISNULL(SUM(Detalle.cant_producto), 0) AS CantidadProductoVendido 
	FROM Venta as Ventas
	JOIN DetalleVenta AS Detalle ON Ventas.nro_venta = Detalle.nro_venta
	WHERE fecha BETWEEN DATEADD(WEEK, -1, GETDATE()) AND GETDATE()
END
GO
/****** Object:  StoredProcedure [dbo].[sp_login]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_login]
(
	@In_password nvarchar(MAX),
	@In_id_cliente int
)
AS
BEGIN
	SELECT LoginUser.user_id, LoginUser.id_cliente, LoginUser.admin,
	Cliente.nombre, Cliente.apellido
	FROM LoginUser AS LoginUser
	JOIN Cliente AS Cliente ON Cliente.dni = Loginuser.id_cliente
	WHERE password = @In_password AND id_cliente = @In_id_cliente
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_venta_xml]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_select_venta_xml]
(
	@In_venta_id int 
)
AS
BEGIN
	SELECT Producto.nombre, Producto.precio, 
		VentaDetalle.cant_producto, VentaDetalle.subtotal
		FROM DetalleVenta VentaDetalle
		JOIN Venta Venta ON Venta.nro_venta = VentaDetalle.nro_venta
		JOIN Producto Producto ON Producto.id = VentaDetalle.id_producto
	WHERE Venta.nro_venta = @In_venta_id
END
GO
/****** Object:  StoredProcedure [dbo].[update_categoria]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[update_categoria]
@In_id int , @In_nombre nvarchar(50) , @In_descripcion nvarchar(150)
as
begin
update Categoria set
nombre = @In_nombre , descripcion = @In_descripcion
where id = @In_id
end
GO
/****** Object:  StoredProcedure [dbo].[update_cliente]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[update_cliente]
@In_dni int, 
@In_nombre nvarchar(50),
@In_apellido nvarchar(50),
@In_telefono nvarchar(50)
as
begin
update Cliente set 
nombre = @In_nombre ,
apellido = @In_apellido,
telefono = @In_telefono
where dni = @In_dni
end
GO
/****** Object:  StoredProcedure [dbo].[update_medio_pago]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[update_medio_pago]
@In_id_cliente int,
@In_tipo_tarjeta int,
@In_nro_tarjeta int,
@In_fecha_caducidad datetime,
@In_cvv int
as 
begin
update MedioDePago
set
id_cliente = @In_id_cliente,
id_tipo_tarjeta = @In_tipo_tarjeta,
fecha_caducidad = @In_fecha_caducidad ,
cvv = @In_cvv
where nro_tarjeta = @In_nro_tarjeta 
end
GO
/****** Object:  StoredProcedure [dbo].[update_producto]    Script Date: 27/11/2023 13:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[update_producto]
	@In_id int , 
	@In_nombre nvarchar(50),
	@In_descripcion nvarchar(150),
	@In_id_categoria int,
	@In_precio money,
	@In_stock int
as
begin
update Producto set nombre = @In_nombre,
					descripcion = @In_descripcion,
					id_categoria = @In_id_categoria,
					precio = @In_precio,
					stock = @In_stock
	where id = @In_id
end
GO
USE [master]
GO
ALTER DATABASE [Supermercado-LUG] SET  READ_WRITE 
GO
