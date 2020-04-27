
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/23/2020 21:13:32
-- Generated from EDMX file: E:\TSPNET\EntitiFrameworkProject1\EntitiFrameworkProject1\DB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DBProject1];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[MediaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MediaSet];
GO
IF OBJECT_ID(N'[dbo].[PersonSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'MediaSet'
CREATE TABLE [dbo].[MediaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [path] nvarchar(max)  NOT NULL,
    [place] nvarchar(max)  NOT NULL,
    [type] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PersonSet'
CREATE TABLE [dbo].[PersonSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [MediaId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'MediaSet'
ALTER TABLE [dbo].[MediaSet]
ADD CONSTRAINT [PK_MediaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [PK_PersonSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MediaId] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [FK_MediaPerson]
    FOREIGN KEY ([MediaId])
    REFERENCES [dbo].[MediaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MediaPerson'
CREATE INDEX [IX_FK_MediaPerson]
ON [dbo].[PersonSet]
    ([MediaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------