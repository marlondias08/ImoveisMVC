USE [ImoveisMVC.AspNetCore.NewDb]
GO

/****** Object: Table [dbo].[Imovel] Script Date: 02/06/2019 19:03:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Imovel] (
    [IdImovel]     INT             IDENTITY (1, 1) NOT NULL,
    [DscImovel]    NVARCHAR (100)  NOT NULL,
    [VlrImovel]    DECIMAL (18, 2) NOT NULL,
    [NumQrtImovel] INT             NOT NULL,
    [NumVagImovel] INT             NOT NULL,
    [TipImovel]    NVARCHAR (15)   NOT NULL,
    [RuaImovel]    NVARCHAR (100)  NOT NULL,
    [BroImovel]    NVARCHAR (30)   NOT NULL,
    [CddImovel]    NVARCHAR (30)   NOT NULL,
    [UFImovel]     NVARCHAR (20)   NOT NULL,
    [CEPImovel]    NVARCHAR (8)    NOT NULL
);


