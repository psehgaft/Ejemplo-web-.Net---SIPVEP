
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/30/2015 17:01:03
-- Generated from EDMX file: C:\SIPVEP\SIPVEP\SIPVEP.CapaDatos\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Papeleria];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ArticuloArticulo_Provedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Articulo_ProvedorSet] DROP CONSTRAINT [FK_ArticuloArticulo_Provedor];
GO
IF OBJECT_ID(N'[dbo].[FK_ProvedorArticulo_Provedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Articulo_ProvedorSet] DROP CONSTRAINT [FK_ProvedorArticulo_Provedor];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ArticuloSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ArticuloSet];
GO
IF OBJECT_ID(N'[dbo].[ProvedorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProvedorSet];
GO
IF OBJECT_ID(N'[dbo].[Articulo_ProvedorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Articulo_ProvedorSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ArticuloSet'
CREATE TABLE [dbo].[ArticuloSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [sku] nvarchar(20)  NOT NULL,
    [nombre] nvarchar(50)  NOT NULL,
    [descripcion] nvarchar(200)  NULL,
    [precio_compra] float  NOT NULL,
    [precio_venta] float  NOT NULL,
    [stock] int  NOT NULL
);
GO

-- Creating table 'ProvedorSet'
CREATE TABLE [dbo].[ProvedorSet] (
    [Id_provedor] int IDENTITY(1,1) NOT NULL,
    [rfc] nvarchar(max)  NOT NULL,
    [razon_social] nvarchar(max)  NOT NULL,
    [direccion_fiscal] nvarchar(max)  NOT NULL,
    [cp_fiscal] nvarchar(max)  NOT NULL,
    [ciudad_fiscal] nvarchar(max)  NOT NULL,
    [estado_fiscal] nvarchar(max)  NOT NULL,
    [nombre_alias] nvarchar(max)  NOT NULL,
    [correo_fiscal] nvarchar(max)  NOT NULL,
    [direccion] nvarchar(max)  NOT NULL,
    [telefono] nvarchar(max)  NOT NULL,
    [correo_contacto] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Articulo_ProvedorSet'
CREATE TABLE [dbo].[Articulo_ProvedorSet] (
    [precio] nvarchar(max)  NOT NULL,
    [id] int IDENTITY(1,1) NOT NULL,
    [Articulo_Id] int  NOT NULL,
    [Provedor_Id_provedor] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ArticuloSet'
ALTER TABLE [dbo].[ArticuloSet]
ADD CONSTRAINT [PK_ArticuloSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id_provedor] in table 'ProvedorSet'
ALTER TABLE [dbo].[ProvedorSet]
ADD CONSTRAINT [PK_ProvedorSet]
    PRIMARY KEY CLUSTERED ([Id_provedor] ASC);
GO

-- Creating primary key on [id] in table 'Articulo_ProvedorSet'
ALTER TABLE [dbo].[Articulo_ProvedorSet]
ADD CONSTRAINT [PK_Articulo_ProvedorSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Articulo_Id] in table 'Articulo_ProvedorSet'
ALTER TABLE [dbo].[Articulo_ProvedorSet]
ADD CONSTRAINT [FK_ArticuloArticulo_Provedor]
    FOREIGN KEY ([Articulo_Id])
    REFERENCES [dbo].[ArticuloSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArticuloArticulo_Provedor'
CREATE INDEX [IX_FK_ArticuloArticulo_Provedor]
ON [dbo].[Articulo_ProvedorSet]
    ([Articulo_Id]);
GO

-- Creating foreign key on [Provedor_Id_provedor] in table 'Articulo_ProvedorSet'
ALTER TABLE [dbo].[Articulo_ProvedorSet]
ADD CONSTRAINT [FK_ProvedorArticulo_Provedor]
    FOREIGN KEY ([Provedor_Id_provedor])
    REFERENCES [dbo].[ProvedorSet]
        ([Id_provedor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProvedorArticulo_Provedor'
CREATE INDEX [IX_FK_ProvedorArticulo_Provedor]
ON [dbo].[Articulo_ProvedorSet]
    ([Provedor_Id_provedor]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------