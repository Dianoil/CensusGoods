USE [master]
GO
/****** Object:  Database [CensusGoods]    Script Date: 11.05.2022 21:47:18 ******/
CREATE DATABASE [CensusGoods]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CensusGoods', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CensusGoods.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CensusGoods_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CensusGoods_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CensusGoods] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CensusGoods].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CensusGoods] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CensusGoods] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CensusGoods] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CensusGoods] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CensusGoods] SET ARITHABORT OFF 
GO
ALTER DATABASE [CensusGoods] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CensusGoods] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CensusGoods] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CensusGoods] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CensusGoods] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CensusGoods] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CensusGoods] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CensusGoods] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CensusGoods] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CensusGoods] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CensusGoods] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CensusGoods] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CensusGoods] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CensusGoods] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CensusGoods] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CensusGoods] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CensusGoods] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CensusGoods] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CensusGoods] SET  MULTI_USER 
GO
ALTER DATABASE [CensusGoods] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CensusGoods] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CensusGoods] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CensusGoods] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CensusGoods] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CensusGoods] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CensusGoods] SET QUERY_STORE = OFF
GO
USE [CensusGoods]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 11.05.2022 21:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 11.05.2022 21:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[fioContastFace] [nvarchar](100) NOT NULL,
	[numberContactFace] [nvarchar](28) NOT NULL,
	[emailContactFace] [nvarchar](100) NOT NULL,
	[idRole] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 11.05.2022 21:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[inn] [nvarchar](20) NOT NULL,
	[ogrn] [nvarchar](25) NOT NULL,
	[registrNum] [nvarchar](25) NOT NULL,
	[discount] [nvarchar](10) NULL,
	[city] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receipt]    Script Date: 11.05.2022 21:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receipt](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[infoContainer] [int] NOT NULL,
	[idCompany] [int] NOT NULL,
	[idTariff] [int] NOT NULL,
	[delay] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Vm_DirComp]    Script Date: 11.05.2022 21:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE View [dbo].[Vm_DirComp]
as
select top 100 m.fioContastFace as 'Директор компании',
c.[name] as 'Название компании',
m.numberContactFace as 'Номер телефона компании',
c.discount as 'Скидка компании',
r.idTariff as 'Тариф компании'





from Company c
left join [User] m on c.contacts = m.id
left join [Role] tm on m.idRole = tm.id
left join [Receipt] r on c.id = r.idCompany
left join [Receipt] on c.id = r.idTariff

where (m.fioContastFace = m.fioContastFace and m.idRole = 3)

group by m.fioContastFace, c.[name], m.numberContactFace, c.discount, r.idTariff
GO
/****** Object:  Table [dbo].[City]    Script Date: 11.05.2022 21:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Container]    Script Date: 11.05.2022 21:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Container](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idSector] [int] NOT NULL,
	[weight] [nvarchar](10) NOT NULL,
	[height] [nvarchar](10) NOT NULL,
	[status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InfoContainer]    Script Date: 11.05.2022 21:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InfoContainer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idContainer] [int] NOT NULL,
	[idProduct] [int] NOT NULL,
	[QuantityProduct] [nvarchar](20) NULL,
	[CargoWeight] [nvarchar](20) NULL,
	[dateStart] [datetime] NOT NULL,
	[available] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InfoUserCompany]    Script Date: 11.05.2022 21:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InfoUserCompany](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idCompany] [int] NOT NULL,
	[idUser] [int] NOT NULL,
 CONSTRAINT [PK_InfoUserCompany] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 11.05.2022 21:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[image] [nvarchar](100) NULL,
	[description] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sector]    Script Date: 11.05.2022 21:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sector](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cellSector] [int] NOT NULL,
	[nameSector] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tariff]    Script Date: 11.05.2022 21:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tariff](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[cost] [decimal](18, 0) NOT NULL,
	[available] [bit] NOT NULL,
 CONSTRAINT [PK__Tariff__3213E83FE6C7D4F3] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Container] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[InfoContainer] ADD  DEFAULT ((0)) FOR [available]
GO
ALTER TABLE [dbo].[Receipt] ADD  DEFAULT ((1)) FOR [idTariff]
GO
ALTER TABLE [dbo].[Receipt] ADD  DEFAULT ((0)) FOR [delay]
GO
ALTER TABLE [dbo].[Tariff] ADD  CONSTRAINT [DF__Tariff__availabl__2F10007B]  DEFAULT ((0)) FOR [available]
GO
ALTER TABLE [dbo].[Company]  WITH CHECK ADD FOREIGN KEY([city])
REFERENCES [dbo].[City] ([id])
GO
ALTER TABLE [dbo].[Container]  WITH CHECK ADD FOREIGN KEY([idSector])
REFERENCES [dbo].[Sector] ([id])
GO
ALTER TABLE [dbo].[InfoContainer]  WITH CHECK ADD FOREIGN KEY([idContainer])
REFERENCES [dbo].[Container] ([id])
GO
ALTER TABLE [dbo].[InfoContainer]  WITH CHECK ADD FOREIGN KEY([idProduct])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[InfoUserCompany]  WITH CHECK ADD  CONSTRAINT [FK_InfoUserCompany_Company] FOREIGN KEY([idCompany])
REFERENCES [dbo].[Company] ([id])
GO
ALTER TABLE [dbo].[InfoUserCompany] CHECK CONSTRAINT [FK_InfoUserCompany_Company]
GO
ALTER TABLE [dbo].[InfoUserCompany]  WITH CHECK ADD  CONSTRAINT [FK_InfoUserCompany_User] FOREIGN KEY([idUser])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[InfoUserCompany] CHECK CONSTRAINT [FK_InfoUserCompany_User]
GO
ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD FOREIGN KEY([idCompany])
REFERENCES [dbo].[Company] ([id])
GO
ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD  CONSTRAINT [FK__Receipt__idTarif__4222D4EF] FOREIGN KEY([idTariff])
REFERENCES [dbo].[Tariff] ([id])
GO
ALTER TABLE [dbo].[Receipt] CHECK CONSTRAINT [FK__Receipt__idTarif__4222D4EF]
GO
ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD FOREIGN KEY([infoContainer])
REFERENCES [dbo].[Container] ([id])
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD FOREIGN KEY([idRole])
REFERENCES [dbo].[Role] ([id])
GO
USE [master]
GO
ALTER DATABASE [CensusGoods] SET  READ_WRITE 
GO
