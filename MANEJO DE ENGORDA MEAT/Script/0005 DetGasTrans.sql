/****** Objeto:  Table [dbo].[DetGasTrans]    Fecha de la secuencia de comandos: 09/09/2009 10:15:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetGasTrans](
	[Fol_Recep] [char](10) NOT NULL CONSTRAINT [DF_DetGasTrans_Fol_Recep]  DEFAULT (' '),
	[Cve_Renglon] [smallint] NOT NULL CONSTRAINT [DF_DetGasTrans_Cve_Renglon]  DEFAULT ((0)),
	[Cve_Gasto] [int] NOT NULL CONSTRAINT [DF_DetGasTrans_Cve_Gasto]  DEFAULT ((0)),
	[Ptj_Iva] [smallmoney] NOT NULL CONSTRAINT [DF_DetGasTrans_Ptj_Iva]  DEFAULT ((0)),
	[Impte_Gasto] [money] NOT NULL CONSTRAINT [DF_DetGasTrans_Impte_Gasto]  DEFAULT ((0)),
 CONSTRAINT [PK_DetGasTrans] PRIMARY KEY NONCLUSTERED 
(
	[Fol_Recep] ASC,
	[Cve_Renglon] ASC,
	[Cve_Gasto] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[DetGasTrans]  WITH CHECK ADD  CONSTRAINT [FK_DetGasTrans_CabGasTrans] FOREIGN KEY([Fol_Recep])
REFERENCES [dbo].[CabGasTrans] ([Fol_Recep])
GO
ALTER TABLE [dbo].[DetGasTrans] CHECK CONSTRAINT [FK_DetGasTrans_CabGasTrans]
GO
ALTER TABLE [dbo].[DetGasTrans]  WITH CHECK ADD  CONSTRAINT [FK_DetGasTrans_MCGCatConcepGastos] FOREIGN KEY([Cve_Gasto])
REFERENCES [dbo].[MCGCatConcepGastos] ([IdConceptoGasto])
GO
ALTER TABLE [dbo].[DetGasTrans] CHECK CONSTRAINT [FK_DetGasTrans_MCGCatConcepGastos]