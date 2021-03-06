USE [Ganadera]
GO
/****** Objeto:  Table [dbo].[CabMediTrab]    Fecha de la secuencia de comandos: 11/09/2009 18:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CabMediTrab](
	[Cve_Medi] [int] NOT NULL CONSTRAINT [DF_CabMediTrab_Cve_Medi]  DEFAULT ((0)),
	[Nom_Medi] [varchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Boo_XCab] [bit] NOT NULL CONSTRAINT [DF_CabMediTrab_Boo_XCab]  DEFAULT ((0)),
	[Boo_XKilo] [bit] NOT NULL CONSTRAINT [DF_CabMediTrab_Boo_XKilo]  DEFAULT ((0)),
	[Unidad] [char](3) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Unidades] [smallmoney] NOT NULL CONSTRAINT [DF_CabMediTrab_Unidades]  DEFAULT ((0.0)),
	[UniXKilo] [smallmoney] NOT NULL CONSTRAINT [DF_CabMediTrab_UniXKilo]  DEFAULT ((0.0)),
 CONSTRAINT [PK_CatMedicam] PRIMARY KEY NONCLUSTERED 
(
	[Cve_Medi] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF