/****** Objeto:  Table [dbo].[ConfigGan]    Fecha de la secuencia de comandos: 10/11/2009 08:51:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ConfigGan](
	[IdConfiguracion] [int] IDENTITY(1,1) NOT NULL,
	[TipoCambio] [smallmoney] NOT NULL CONSTRAINT [DF_ConfigGan_TipoCambio]  DEFAULT ((0)),
	[FactorConver] [real] NOT NULL CONSTRAINT [DF_ConfigGan_FactorConver]  DEFAULT ((0)),
	[IdTipoAlmacenFormula] [int] NOT NULL CONSTRAINT [DF_ConfigGan_Cve_AlmFor]  DEFAULT ((0)),
	[IdTipoAlmacenRolado] [int] NOT NULL CONSTRAINT [DF_ConfigGan_Cve_AlmRol]  DEFAULT ((0)),
	[IdTipoAlmacenMedicamento] [int] NOT NULL CONSTRAINT [DF_ConfigGan_Cve_AlmMed]  DEFAULT ((0)),
	[GDPIni] [smallmoney] NOT NULL CONSTRAINT [DF_ConfigGan_GDPIni]  DEFAULT ((0)),
	[ImptePredial] [money] NOT NULL CONSTRAINT [DF_ConfigGan_ImptePredial]  DEFAULT ((0)),
	[Ptj_Educa] [smallmoney] NOT NULL CONSTRAINT [DF_ConfigGan_Ptj_Educa]  DEFAULT ((0)),
	[Fec_CieEng] [datetime] NOT NULL CONSTRAINT [DF_ConfigGan_Fec_CieEng]  DEFAULT ('1900-01-01'),
	[CosIndMen] [money] NOT NULL CONSTRAINT [DF_ConfigGan_CosIndMen]  DEFAULT ((0)),
	[MesCosInd] [tinyint] NOT NULL CONSTRAINT [DF_ConfigGan_MesCosInd]  DEFAULT ((0)),
	[Cve_DepGana] [smallint] NOT NULL CONSTRAINT [DF_ConfigGan_Cve_DepGna]  DEFAULT ((0)),
	[Cve_MovSalMat] [char](2) NOT NULL CONSTRAINT [DF_ConfigGan_Cve_MovSalMat]  DEFAULT (''),
 CONSTRAINT [PK_ConfigGan] PRIMARY KEY NONCLUSTERED 
(
	[IdConfiguracion] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[ConfigGan]  WITH NOCHECK ADD  CONSTRAINT [FK_ConfigGan_MCatTiposAlmacenes] FOREIGN KEY([IdTipoAlmacenFormula])
REFERENCES [dbo].[MCatTiposAlmacenes] ([Codigo])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ConfigGan] NOCHECK CONSTRAINT [FK_ConfigGan_MCatTiposAlmacenes]
GO
ALTER TABLE [dbo].[ConfigGan]  WITH NOCHECK ADD  CONSTRAINT [FK_ConfigGan_MCatTiposAlmacenes1] FOREIGN KEY([IdTipoAlmacenMedicamento])
REFERENCES [dbo].[MCatTiposAlmacenes] ([Codigo])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ConfigGan] NOCHECK CONSTRAINT [FK_ConfigGan_MCatTiposAlmacenes1]
GO
ALTER TABLE [dbo].[ConfigGan]  WITH NOCHECK ADD  CONSTRAINT [FK_ConfigGan_MCatTiposAlmacenes2] FOREIGN KEY([IdTipoAlmacenRolado])
REFERENCES [dbo].[MCatTiposAlmacenes] ([Codigo])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ConfigGan] NOCHECK CONSTRAINT [FK_ConfigGan_MCatTiposAlmacenes2]