/****** Objeto:  Table [dbo].[CabAplFor]    Fecha de la secuencia de comandos: 10/06/2009 10:42:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CabAplFor](
	[Fol_AplF] [char](8)  CONSTRAINT [DF_CabAplFor_Fol_Mov]  DEFAULT (' '),
	[Cve_Corral] [char](5)  NOT NULL CONSTRAINT [DF_CabAplFor_Cve_Corral]  DEFAULT (' '),
	[Cve_Formula] [smallint] NOT NULL CONSTRAINT [DF_CabAplFor_Cve_Formula]  DEFAULT (0),
	[Cve_Renglon] [smallint] NOT NULL CONSTRAINT [DF_CabAplFor_Cve_Renglon]  DEFAULT (0),
	[Fec_AplF] [datetime] NOT NULL CONSTRAINT [DF_CabAplFor_Fec_AplF]  DEFAULT ('1900-01-01'),
	[CantServ1] [smallmoney] NOT NULL CONSTRAINT [DF_CabAplFor_CantServ1]  DEFAULT (0),
	[CantServ2] [smallmoney] NOT NULL CONSTRAINT [DF_CabAplFor_CantServ2]  DEFAULT (0),
	[CantServ3] [smallmoney] NOT NULL CONSTRAINT [DF_CabAplFor_CantServ3]  DEFAULT (0),
	[CantServ4] [smallmoney] NOT NULL CONSTRAINT [DF_CabAplFor_CantServ4]  DEFAULT (0),
	[CabXCorral] [int] NOT NULL CONSTRAINT [DF_CabAplFor_CabezasXCorral]  DEFAULT (0),
	[Fec_Conta] [datetime] NOT NULL CONSTRAINT [DF_CabAplFor_Fec_Conta]  DEFAULT ('1900-01-01'),
	[Fol_Poliza] [char](8) NOT NULL CONSTRAINT [DF_CabAplFor_Fol_Poliza]  DEFAULT (' '),
	[costo] [money] NOT NULL CONSTRAINT [DF_CabAplFor_costo]  DEFAULT (0),
 CONSTRAINT [PK_CabAplFor] PRIMARY KEY NONCLUSTERED 
(
	[Fol_AplF] ASC,
	[Cve_Corral] ASC,
	[Cve_Formula] ASC,
	[Cve_Renglon] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF