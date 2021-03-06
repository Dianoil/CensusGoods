USE [master]
GO
/****** Object:  Database [CensusGoods]    Script Date: 15.06.2022 10:05:35 ******/
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
ALTER DATABASE [CensusGoods] SET  DISABLE_BROKER 
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
/****** Object:  Table [dbo].[InfoUserCompany]    Script Date: 15.06.2022 10:05:36 ******/
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
/****** Object:  Table [dbo].[Role]    Script Date: 15.06.2022 10:05:36 ******/
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
/****** Object:  Table [dbo].[User]    Script Date: 15.06.2022 10:05:36 ******/
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
/****** Object:  Table [dbo].[Company]    Script Date: 15.06.2022 10:05:36 ******/
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
/****** Object:  Table [dbo].[Receipt]    Script Date: 15.06.2022 10:05:36 ******/
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
/****** Object:  Table [dbo].[Tariff]    Script Date: 15.06.2022 10:05:36 ******/
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
/****** Object:  View [dbo].[Vm_DirComp]    Script Date: 15.06.2022 10:05:36 ******/
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
t.[name] as 'Тариф компании'

from [User] m
left join InfoUserCompany i on m.id = i.idUser
left join Company c on c.id = i.idCompany
left join [Role] tm on m.idRole = tm.id
left join [Receipt] r on c.id = r.idCompany
left join [Receipt] on c.id = r.idTariff
left join Tariff t on t.id = r.idTariff

where (m.fioContastFace = m.fioContastFace and m.idRole = 2)

group by m.fioContastFace, c.[name], m.numberContactFace, c.discount, t.[name]
GO
/****** Object:  View [dbo].[Vm_User]    Script Date: 15.06.2022 10:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE View [dbo].[Vm_User]
as
select top 100 m.fioContastFace as 'ФИО Работника',
m.numberContactFace as 'Номер телефона работника',
m.emailContactFace as 'Почта работника',
c.[name] as 'Компания'


from [User] m
left join InfoUserCompany i on m.id = i.idUser
left join Company c on c.id = i.idCompany
left join [Role] tm on m.idRole = tm.id


where (m.fioContastFace = m.fioContastFace and m.idRole = 1)

group by m.fioContastFace, m.emailContactFace, m.numberContactFace, c.[name]
GO
/****** Object:  View [dbo].[Vm_DirGoods]    Script Date: 15.06.2022 10:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE View [dbo].[Vm_DirGoods]
as
select top 100 m.fioContastFace as 'Директор склада',
c.[name] as 'Название компании',
m.numberContactFace as 'Номер телефона компании',
m.emailContactFace as 'Почта директора'

from [User] m
left join InfoUserCompany i on m.id = i.idUser
left join Company c on c.id = i.idCompany
left join [Role] tm on m.idRole = tm.id
left join [Receipt] r on c.id = r.idCompany
left join [Receipt] on c.id = r.idTariff
left join Tariff t on t.id = r.idTariff

where (m.fioContastFace = m.fioContastFace and m.idRole = 3)

group by m.fioContastFace, c.[name], m.numberContactFace, c.discount, t.[name], m.emailContactFace
GO
/****** Object:  Table [dbo].[Container]    Script Date: 15.06.2022 10:05:36 ******/
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
	[name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InfoContainer]    Script Date: 15.06.2022 10:05:36 ******/
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
	[title] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 15.06.2022 10:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[image] [nvarchar](500) NULL,
	[description] [nvarchar](250) NULL,
 CONSTRAINT [PK__Product__3213E83FAB32894A] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Vm_InfoContainer]    Script Date: 15.06.2022 10:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE View [dbo].[Vm_InfoContainer]
as
select top 100
c.[name] as 'Название контейнера',
p.[name] as 'Название продукта',
comp.[name] as 'Название компании',
ic.available as 'Доступность'

from Receipt r
 join InfoContainer ic on r.infoContainer = ic.id
 join Container c on ic.idContainer = c.id
 join Product p on ic.idProduct = p.id
 join Company comp on r.idCompany = comp.id

group by c.[name], p.[name], ic.available, comp.[name]
GO
/****** Object:  View [dbo].[Vm_TotalReceipt]    Script Date: 15.06.2022 10:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE View [dbo].[Vm_TotalReceipt]
as
select top 100
c.[name] as 'Название контейнера',
comp.[name] as 'Название компании',
t.[name] as 'Тариф',
comp.discount as 'Скидка компании',
r.[delay] as 'Задолжность'

from InfoContainer ic
 join Container c on ic.idContainer = c.id
 join Receipt r on c.id = r.infoContainer
 join Company comp on r.idCompany = comp.id
 join Tariff t on t.id = r.idTariff

group by c.[name], comp.[name], t.[name], comp.discount, r.[delay]
GO
/****** Object:  Table [dbo].[City]    Script Date: 15.06.2022 10:05:36 ******/
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
/****** Object:  Table [dbo].[Sector]    Script Date: 15.06.2022 10:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sector](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cellSector] [nvarchar](50) NOT NULL,
	[nameSector] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK__Sector__3213E83FF8E4AF27] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Support]    Script Date: 15.06.2022 10:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Support](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[question] [nvarchar](150) NULL,
	[appeal] [nvarchar](500) NULL,
 CONSTRAINT [PK_Support] PRIMARY KEY CLUSTERED 
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
ALTER TABLE [dbo].[Container]  WITH CHECK ADD  CONSTRAINT [FK__Container__idSec__34C8D9D1] FOREIGN KEY([idSector])
REFERENCES [dbo].[Sector] ([id])
GO
ALTER TABLE [dbo].[Container] CHECK CONSTRAINT [FK__Container__idSec__34C8D9D1]
GO
ALTER TABLE [dbo].[InfoContainer]  WITH CHECK ADD FOREIGN KEY([idContainer])
REFERENCES [dbo].[Container] ([id])
GO
ALTER TABLE [dbo].[InfoContainer]  WITH CHECK ADD  CONSTRAINT [FK__InfoConta__idPro__3B75D760] FOREIGN KEY([idProduct])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[InfoContainer] CHECK CONSTRAINT [FK__InfoConta__idPro__3B75D760]
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
ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD  CONSTRAINT [FK_Receipt_InfoContainer] FOREIGN KEY([infoContainer])
REFERENCES [dbo].[InfoContainer] ([id])
GO
ALTER TABLE [dbo].[Receipt] CHECK CONSTRAINT [FK_Receipt_InfoContainer]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD FOREIGN KEY([idRole])
REFERENCES [dbo].[Role] ([id])
GO
USE [master]
GO
ALTER DATABASE [CensusGoods] SET  READ_WRITE 
GO
