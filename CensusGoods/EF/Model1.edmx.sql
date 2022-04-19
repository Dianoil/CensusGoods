
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/19/2022 14:36:28
-- Generated from EDMX file: C:\Users\a539u\source\repos\Dianoil\CensusGoods\CensusGoods\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CensusGoods];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Company__City__2E1BDC42]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Company] DROP CONSTRAINT [FK__Company__City__2E1BDC42];
GO
IF OBJECT_ID(N'[dbo].[FK__Company__Contact__2F10007B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Company] DROP CONSTRAINT [FK__Company__Contact__2F10007B];
GO
IF OBJECT_ID(N'[dbo].[FK__Company__Control__30F848ED]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Company] DROP CONSTRAINT [FK__Company__Control__30F848ED];
GO
IF OBJECT_ID(N'[dbo].[FK__Company__TypeMag__31EC6D26]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Company] DROP CONSTRAINT [FK__Company__TypeMag__31EC6D26];
GO
IF OBJECT_ID(N'[dbo].[FK__Company__Valute__300424B4]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Company] DROP CONSTRAINT [FK__Company__Valute__300424B4];
GO
IF OBJECT_ID(N'[dbo].[FK__OrderInfo__IdOrd__5070F446]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderInfo] DROP CONSTRAINT [FK__OrderInfo__IdOrd__5070F446];
GO
IF OBJECT_ID(N'[dbo].[FK__OrderInfo__IdPro__4F7CD00D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderInfo] DROP CONSTRAINT [FK__OrderInfo__IdPro__4F7CD00D];
GO
IF OBJECT_ID(N'[dbo].[FK__Ordery__IdSector__46E78A0C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ordery] DROP CONSTRAINT [FK__Ordery__IdSector__46E78A0C];
GO
IF OBJECT_ID(N'[dbo].[FK__Ordery__TypePaym__47DBAE45]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ordery] DROP CONSTRAINT [FK__Ordery__TypePaym__47DBAE45];
GO
IF OBJECT_ID(N'[dbo].[FK__ProductIn__IdCom__4BAC3F29]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductInfo] DROP CONSTRAINT [FK__ProductIn__IdCom__4BAC3F29];
GO
IF OBJECT_ID(N'[dbo].[FK__ProductIn__IdPro__4AB81AF0]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductInfo] DROP CONSTRAINT [FK__ProductIn__IdPro__4AB81AF0];
GO
IF OBJECT_ID(N'[dbo].[FK__SectorPro__IdPro__412EB0B6]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SectorProduct] DROP CONSTRAINT [FK__SectorPro__IdPro__412EB0B6];
GO
IF OBJECT_ID(N'[dbo].[FK__SectorPro__IdSec__4222D4EF]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SectorProduct] DROP CONSTRAINT [FK__SectorPro__IdSec__4222D4EF];
GO
IF OBJECT_ID(N'[dbo].[FK__Supply__IdCompan__37A5467C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Supply] DROP CONSTRAINT [FK__Supply__IdCompan__37A5467C];
GO
IF OBJECT_ID(N'[dbo].[FK__SupplyInf__IdPro__3C69FB99]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SupplyInfo] DROP CONSTRAINT [FK__SupplyInf__IdPro__3C69FB99];
GO
IF OBJECT_ID(N'[dbo].[FK__SupplyInf__IdSup__3B75D760]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SupplyInfo] DROP CONSTRAINT [FK__SupplyInf__IdSup__3B75D760];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[City]', 'U') IS NOT NULL
    DROP TABLE [dbo].[City];
GO
IF OBJECT_ID(N'[dbo].[Company]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Company];
GO
IF OBJECT_ID(N'[dbo].[Contacts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contacts];
GO
IF OBJECT_ID(N'[dbo].[ControlQuestion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ControlQuestion];
GO
IF OBJECT_ID(N'[dbo].[OrderInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderInfo];
GO
IF OBJECT_ID(N'[dbo].[Ordery]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ordery];
GO
IF OBJECT_ID(N'[dbo].[Product]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Product];
GO
IF OBJECT_ID(N'[dbo].[ProductInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductInfo];
GO
IF OBJECT_ID(N'[dbo].[Sector]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sector];
GO
IF OBJECT_ID(N'[dbo].[SectorProduct]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SectorProduct];
GO
IF OBJECT_ID(N'[dbo].[Supply]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Supply];
GO
IF OBJECT_ID(N'[dbo].[SupplyInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SupplyInfo];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[TypeMagazin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeMagazin];
GO
IF OBJECT_ID(N'[dbo].[TypePayment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypePayment];
GO
IF OBJECT_ID(N'[dbo].[Valute]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Valute];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'City'
CREATE TABLE [dbo].[City] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Company'
CREATE TABLE [dbo].[Company] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NOT NULL,
    [Inn] nvarchar(12)  NOT NULL,
    [Ogrn] nvarchar(13)  NOT NULL,
    [City] int  NOT NULL,
    [Contacts] int  NOT NULL,
    [Login] nvarchar(100)  NOT NULL,
    [Password] nvarchar(100)  NOT NULL,
    [Valute] int  NULL,
    [ControlQuestion] int  NULL,
    [Answer] nvarchar(100)  NULL,
    [TypeMagazin] int  NULL
);
GO

-- Creating table 'Contacts'
CREATE TABLE [dbo].[Contacts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FioContastFace] nvarchar(100)  NULL,
    [NumberContactFace] nvarchar(22)  NULL,
    [EmailContactFace] nvarchar(100)  NULL
);
GO

-- Creating table 'ControlQuestion'
CREATE TABLE [dbo].[ControlQuestion] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'OrderInfo'
CREATE TABLE [dbo].[OrderInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdOrder] int  NOT NULL,
    [IdProduct] int  NOT NULL,
    [Comment] nvarchar(200)  NULL,
    [Quantity] int  NOT NULL
);
GO

-- Creating table 'Ordery'
CREATE TABLE [dbo].[Ordery] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdSector] int  NOT NULL,
    [TypePayment] int  NOT NULL,
    [OrdDate] datetime  NOT NULL
);
GO

-- Creating table 'Product'
CREATE TABLE [dbo].[Product] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NOT NULL,
    [Price] decimal(18,0)  NOT NULL,
    [Comment] nvarchar(200)  NULL,
    [Image] nvarchar(100)  NULL
);
GO

-- Creating table 'ProductInfo'
CREATE TABLE [dbo].[ProductInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdCompany] int  NOT NULL,
    [IdProduct] int  NOT NULL
);
GO

-- Creating table 'Sector'
CREATE TABLE [dbo].[Sector] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CellSector] int  NOT NULL,
    [RangeSector] int  NOT NULL,
    [NameSector] nvarchar(10)  NULL
);
GO

-- Creating table 'SectorProduct'
CREATE TABLE [dbo].[SectorProduct] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdProduct] int  NOT NULL,
    [IdSector] int  NOT NULL
);
GO

-- Creating table 'Supply'
CREATE TABLE [dbo].[Supply] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdCompany] int  NOT NULL,
    [DateSuppl] datetime  NOT NULL
);
GO

-- Creating table 'SupplyInfo'
CREATE TABLE [dbo].[SupplyInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdSupply] int  NOT NULL,
    [IdProduct] int  NOT NULL,
    [Quantity] int  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'TypeMagazin'
CREATE TABLE [dbo].[TypeMagazin] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NULL
);
GO

-- Creating table 'TypePayment'
CREATE TABLE [dbo].[TypePayment] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NULL
);
GO

-- Creating table 'Valute'
CREATE TABLE [dbo].[Valute] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'City'
ALTER TABLE [dbo].[City]
ADD CONSTRAINT [PK_City]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Company'
ALTER TABLE [dbo].[Company]
ADD CONSTRAINT [PK_Company]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Contacts'
ALTER TABLE [dbo].[Contacts]
ADD CONSTRAINT [PK_Contacts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ControlQuestion'
ALTER TABLE [dbo].[ControlQuestion]
ADD CONSTRAINT [PK_ControlQuestion]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OrderInfo'
ALTER TABLE [dbo].[OrderInfo]
ADD CONSTRAINT [PK_OrderInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Ordery'
ALTER TABLE [dbo].[Ordery]
ADD CONSTRAINT [PK_Ordery]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Product'
ALTER TABLE [dbo].[Product]
ADD CONSTRAINT [PK_Product]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProductInfo'
ALTER TABLE [dbo].[ProductInfo]
ADD CONSTRAINT [PK_ProductInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sector'
ALTER TABLE [dbo].[Sector]
ADD CONSTRAINT [PK_Sector]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SectorProduct'
ALTER TABLE [dbo].[SectorProduct]
ADD CONSTRAINT [PK_SectorProduct]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Supply'
ALTER TABLE [dbo].[Supply]
ADD CONSTRAINT [PK_Supply]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SupplyInfo'
ALTER TABLE [dbo].[SupplyInfo]
ADD CONSTRAINT [PK_SupplyInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [Id] in table 'TypeMagazin'
ALTER TABLE [dbo].[TypeMagazin]
ADD CONSTRAINT [PK_TypeMagazin]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TypePayment'
ALTER TABLE [dbo].[TypePayment]
ADD CONSTRAINT [PK_TypePayment]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Valute'
ALTER TABLE [dbo].[Valute]
ADD CONSTRAINT [PK_Valute]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [City] in table 'Company'
ALTER TABLE [dbo].[Company]
ADD CONSTRAINT [FK__Company__City__2E1BDC42]
    FOREIGN KEY ([City])
    REFERENCES [dbo].[City]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Company__City__2E1BDC42'
CREATE INDEX [IX_FK__Company__City__2E1BDC42]
ON [dbo].[Company]
    ([City]);
GO

-- Creating foreign key on [Contacts] in table 'Company'
ALTER TABLE [dbo].[Company]
ADD CONSTRAINT [FK__Company__Contact__2F10007B]
    FOREIGN KEY ([Contacts])
    REFERENCES [dbo].[Contacts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Company__Contact__2F10007B'
CREATE INDEX [IX_FK__Company__Contact__2F10007B]
ON [dbo].[Company]
    ([Contacts]);
GO

-- Creating foreign key on [ControlQuestion] in table 'Company'
ALTER TABLE [dbo].[Company]
ADD CONSTRAINT [FK__Company__Control__30F848ED]
    FOREIGN KEY ([ControlQuestion])
    REFERENCES [dbo].[ControlQuestion]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Company__Control__30F848ED'
CREATE INDEX [IX_FK__Company__Control__30F848ED]
ON [dbo].[Company]
    ([ControlQuestion]);
GO

-- Creating foreign key on [TypeMagazin] in table 'Company'
ALTER TABLE [dbo].[Company]
ADD CONSTRAINT [FK__Company__TypeMag__31EC6D26]
    FOREIGN KEY ([TypeMagazin])
    REFERENCES [dbo].[TypeMagazin]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Company__TypeMag__31EC6D26'
CREATE INDEX [IX_FK__Company__TypeMag__31EC6D26]
ON [dbo].[Company]
    ([TypeMagazin]);
GO

-- Creating foreign key on [Valute] in table 'Company'
ALTER TABLE [dbo].[Company]
ADD CONSTRAINT [FK__Company__Valute__300424B4]
    FOREIGN KEY ([Valute])
    REFERENCES [dbo].[Valute]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Company__Valute__300424B4'
CREATE INDEX [IX_FK__Company__Valute__300424B4]
ON [dbo].[Company]
    ([Valute]);
GO

-- Creating foreign key on [IdCompany] in table 'ProductInfo'
ALTER TABLE [dbo].[ProductInfo]
ADD CONSTRAINT [FK__ProductIn__IdCom__4BAC3F29]
    FOREIGN KEY ([IdCompany])
    REFERENCES [dbo].[Company]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ProductIn__IdCom__4BAC3F29'
CREATE INDEX [IX_FK__ProductIn__IdCom__4BAC3F29]
ON [dbo].[ProductInfo]
    ([IdCompany]);
GO

-- Creating foreign key on [IdCompany] in table 'Supply'
ALTER TABLE [dbo].[Supply]
ADD CONSTRAINT [FK__Supply__IdCompan__37A5467C]
    FOREIGN KEY ([IdCompany])
    REFERENCES [dbo].[Company]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Supply__IdCompan__37A5467C'
CREATE INDEX [IX_FK__Supply__IdCompan__37A5467C]
ON [dbo].[Supply]
    ([IdCompany]);
GO

-- Creating foreign key on [IdOrder] in table 'OrderInfo'
ALTER TABLE [dbo].[OrderInfo]
ADD CONSTRAINT [FK__OrderInfo__IdOrd__5070F446]
    FOREIGN KEY ([IdOrder])
    REFERENCES [dbo].[Ordery]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__OrderInfo__IdOrd__5070F446'
CREATE INDEX [IX_FK__OrderInfo__IdOrd__5070F446]
ON [dbo].[OrderInfo]
    ([IdOrder]);
GO

-- Creating foreign key on [IdProduct] in table 'OrderInfo'
ALTER TABLE [dbo].[OrderInfo]
ADD CONSTRAINT [FK__OrderInfo__IdPro__4F7CD00D]
    FOREIGN KEY ([IdProduct])
    REFERENCES [dbo].[Product]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__OrderInfo__IdPro__4F7CD00D'
CREATE INDEX [IX_FK__OrderInfo__IdPro__4F7CD00D]
ON [dbo].[OrderInfo]
    ([IdProduct]);
GO

-- Creating foreign key on [IdSector] in table 'Ordery'
ALTER TABLE [dbo].[Ordery]
ADD CONSTRAINT [FK__Ordery__IdSector__46E78A0C]
    FOREIGN KEY ([IdSector])
    REFERENCES [dbo].[Sector]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Ordery__IdSector__46E78A0C'
CREATE INDEX [IX_FK__Ordery__IdSector__46E78A0C]
ON [dbo].[Ordery]
    ([IdSector]);
GO

-- Creating foreign key on [TypePayment] in table 'Ordery'
ALTER TABLE [dbo].[Ordery]
ADD CONSTRAINT [FK__Ordery__TypePaym__47DBAE45]
    FOREIGN KEY ([TypePayment])
    REFERENCES [dbo].[TypePayment]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Ordery__TypePaym__47DBAE45'
CREATE INDEX [IX_FK__Ordery__TypePaym__47DBAE45]
ON [dbo].[Ordery]
    ([TypePayment]);
GO

-- Creating foreign key on [IdProduct] in table 'ProductInfo'
ALTER TABLE [dbo].[ProductInfo]
ADD CONSTRAINT [FK__ProductIn__IdPro__4AB81AF0]
    FOREIGN KEY ([IdProduct])
    REFERENCES [dbo].[Product]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ProductIn__IdPro__4AB81AF0'
CREATE INDEX [IX_FK__ProductIn__IdPro__4AB81AF0]
ON [dbo].[ProductInfo]
    ([IdProduct]);
GO

-- Creating foreign key on [IdProduct] in table 'SectorProduct'
ALTER TABLE [dbo].[SectorProduct]
ADD CONSTRAINT [FK__SectorPro__IdPro__412EB0B6]
    FOREIGN KEY ([IdProduct])
    REFERENCES [dbo].[Product]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SectorPro__IdPro__412EB0B6'
CREATE INDEX [IX_FK__SectorPro__IdPro__412EB0B6]
ON [dbo].[SectorProduct]
    ([IdProduct]);
GO

-- Creating foreign key on [IdProduct] in table 'SupplyInfo'
ALTER TABLE [dbo].[SupplyInfo]
ADD CONSTRAINT [FK__SupplyInf__IdPro__3C69FB99]
    FOREIGN KEY ([IdProduct])
    REFERENCES [dbo].[Product]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SupplyInf__IdPro__3C69FB99'
CREATE INDEX [IX_FK__SupplyInf__IdPro__3C69FB99]
ON [dbo].[SupplyInfo]
    ([IdProduct]);
GO

-- Creating foreign key on [IdSector] in table 'SectorProduct'
ALTER TABLE [dbo].[SectorProduct]
ADD CONSTRAINT [FK__SectorPro__IdSec__4222D4EF]
    FOREIGN KEY ([IdSector])
    REFERENCES [dbo].[Sector]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SectorPro__IdSec__4222D4EF'
CREATE INDEX [IX_FK__SectorPro__IdSec__4222D4EF]
ON [dbo].[SectorProduct]
    ([IdSector]);
GO

-- Creating foreign key on [IdSupply] in table 'SupplyInfo'
ALTER TABLE [dbo].[SupplyInfo]
ADD CONSTRAINT [FK__SupplyInf__IdSup__3B75D760]
    FOREIGN KEY ([IdSupply])
    REFERENCES [dbo].[Supply]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SupplyInf__IdSup__3B75D760'
CREATE INDEX [IX_FK__SupplyInf__IdSup__3B75D760]
ON [dbo].[SupplyInfo]
    ([IdSupply]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------