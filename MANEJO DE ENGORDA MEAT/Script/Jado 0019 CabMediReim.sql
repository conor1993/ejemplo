USE [Ganadera]
GO
/****** Objeto:  Table [dbo].[CabMediReim]    Fecha de la secuencia de comandos: 11/09/2009 18:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CabMediReim](
	[Cve_Medi] [int] NOT NULL CONSTRAINT [DF_CabMediReim_Cve_Medi]  DEFAULT ((0)),
	[Nom_Medi] [varchar](250) COLLATE Modern_Spanish_CI_AS NOT NULL CONSTRAINT [DF_CabMediReim_Nom_Medi]  DEFAULT (' '),
	[Boo_XCab] [bit] NOT NULL CONSTRAINT [DF_CabMediReim_Boo_XCab]  DEFAULT ('N'),
	[Boo_XKilo] [bit] NOT NULL CONSTRAINT [DF_CabMediReim_Boo_XKilo]  DEFAULT ('N'),
	[Unidad] [char](3) COLLATE Modern_Spanish_CI_AS NOT NULL CONSTRAINT [DF_CabMediReim_Unidad_1]  DEFAULT (' '),
	[Unidades] [smallmoney] NOT NULL CONSTRAINT [DF_CabMediReim_Unidades]  DEFAULT ((0)),
	[UniXKilo] [smallmoney] NOT NULL CONSTRAINT [DF_CabMediReim_UniXKilo]  DEFAULT ((0)),
 CONSTRAINT [PK_CabMediReim] PRIMARY KEY NONCLUSTERED 
(
	[Cve_Medi] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF