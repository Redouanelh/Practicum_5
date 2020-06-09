
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/09/2020 11:32:20
-- Generated from EDMX file: C:\Users\Redou\source\repos\Practicum_5\WebshopService\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [webshop];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ProductPaymentRule]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PaymentRules] DROP CONSTRAINT [FK_ProductPaymentRule];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[PaymentRules]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PaymentRules];
GO
IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [ProductId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Price] float  NOT NULL,
    [Stock] int  NOT NULL
);
GO

-- Creating table 'PaymentRules'
CREATE TABLE [dbo].[PaymentRules] (
    [PaymentRuleId] int IDENTITY(1,1) NOT NULL,
    [Amount] int  NOT NULL,
    [Product_ProductId] int  NOT NULL,
    [Customers_CustomerId] int  NOT NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [CustomerId] int IDENTITY(1,1) NOT NULL,
    [Balance] float  NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ProductId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([ProductId] ASC);
GO

-- Creating primary key on [PaymentRuleId] in table 'PaymentRules'
ALTER TABLE [dbo].[PaymentRules]
ADD CONSTRAINT [PK_PaymentRules]
    PRIMARY KEY CLUSTERED ([PaymentRuleId] ASC);
GO

-- Creating primary key on [CustomerId] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([CustomerId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Product_ProductId] in table 'PaymentRules'
ALTER TABLE [dbo].[PaymentRules]
ADD CONSTRAINT [FK_ProductPaymentRule]
    FOREIGN KEY ([Product_ProductId])
    REFERENCES [dbo].[Products]
        ([ProductId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductPaymentRule'
CREATE INDEX [IX_FK_ProductPaymentRule]
ON [dbo].[PaymentRules]
    ([Product_ProductId]);
GO

-- Creating foreign key on [Customers_CustomerId] in table 'PaymentRules'
ALTER TABLE [dbo].[PaymentRules]
ADD CONSTRAINT [FK_PaymentRuleCustomer]
    FOREIGN KEY ([Customers_CustomerId])
    REFERENCES [dbo].[Customers]
        ([CustomerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PaymentRuleCustomer'
CREATE INDEX [IX_FK_PaymentRuleCustomer]
ON [dbo].[PaymentRules]
    ([Customers_CustomerId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------