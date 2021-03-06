/****** Objeto:  Table [dbo].[DetAplFor]    Fecha de la secuencia de comandos: 10/06/2009 10:43:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetAplFor](
	[Fol_AplF] [char](8)  NOT NULL CONSTRAINT [DF_DetAplFor_Fol_AplF]  DEFAULT (' '),
	[Cve_Lote] [int] NOT NULL CONSTRAINT [DF_DetAplFor_Cve_Lote]  DEFAULT (0),
	[Cve_Corral] [char](5) NOT NULL CONSTRAINT [DF_DetAplFor_Cve_Corral]  DEFAULT (' '),
	[Cve_Renglon] [smallint] NOT NULL CONSTRAINT [DF_DetAplFor_Cve_Renglon]  DEFAULT (0),
	[Cve_Formula] [smallint] NOT NULL CONSTRAINT [DF_DetAplFor_Cve_Formula]  DEFAULT (0),
	[Fec_AplF] [datetime] NOT NULL CONSTRAINT [DF_DetAplFor_Fec_AplF_1]  DEFAULT ('1900-01-01'),
	[Cabezas] [smallint] NOT NULL CONSTRAINT [DF_DetAplFor_Cabezas]  DEFAULT (0),
	[KilosxLote] [money] NOT NULL CONSTRAINT [DF_DetAplFor_Kilos]  DEFAULT (0),
 CONSTRAINT [PK_DetAplFor] PRIMARY KEY NONCLUSTERED 
(
	[Fol_AplF] ASC,
	[Cve_Lote] ASC,
	[Cve_Corral] ASC,
	[Cve_Renglon] ASC,
	[Cve_Formula] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF