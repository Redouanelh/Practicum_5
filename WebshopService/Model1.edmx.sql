
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/04/2020 23:49:04
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


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
    [Payments_PaymentId] int  NOT NULL,
    [Product_ProductId] int  NOT NULL
);
GO

-- Creating table 'Payments'
CREATE TABLE [dbo].[Payments] (
    [PaymentId] int IDENTITY(1,1) NOT NULL,
    [PaymentDate] datetime  NOT NULL,
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

-- Creating primary key on [PaymentId] in table 'Payments'
ALTER TABLE [dbo].[Payments]
ADD CONSTRAINT [PK_Payments]
    PRIMARY KEY CLUSTERED ([PaymentId] ASC);
GO

-- Creating primary key on [CustomerId] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([CustomerId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Payments_PaymentId] in table 'PaymentRules'
ALTER TABLE [dbo].[PaymentRules]
ADD CONSTRAINT [FK_PaymentRulePayment]
    FOREIGN KEY ([Payments_PaymentId])
    REFERENCES [dbo].[Payments]
        ([PaymentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PaymentRulePayment'
CREATE INDEX [IX_FK_PaymentRulePayment]
ON [dbo].[PaymentRules]
    ([Payments_PaymentId]);
GO

-- Creating foreign key on [Customers_CustomerId] in table 'Payments'
ALTER TABLE [dbo].[Payments]
ADD CONSTRAINT [FK_PaymentCustomer]
    FOREIGN KEY ([Customers_CustomerId])
    REFERENCES [dbo].[Customers]
        ([CustomerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PaymentCustomer'
CREATE INDEX [IX_FK_PaymentCustomer]
ON [dbo].[Payments]
    ([Customers_CustomerId]);
GO

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

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------