/****** Objeto:  Table [dbo].[DetMovGan]    Fecha de la secuencia de comandos: 09/09/2009 10:24:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetMovGan](
	[Fol_MovGan] [varchar](11) NOT NULL,
	[Fec_MovGan] [datetime] NOT NULL CONSTRAINT [DF_DetMovGan_Fec_MovGan]  DEFAULT ('1900-01-01'),
	[Cve_Ganado] [int] NOT NULL CONSTRAINT [DF_DetMovGan_Cve_Ganado]  DEFAULT (' '),
	[Cve_MovGan] [char](2) NULL CONSTRAINT [DF_DetMovGan_Cve_MovGan]  DEFAULT (' '),
	[Cve_Ganadera] [tinyint] NULL CONSTRAINT [DF_DetMovGan_Cve_Ganadera]  DEFAULT ((0)),
	[Cabezas] [int] NOT NULL CONSTRAINT [DF_DetMovGan_Cabezas]  DEFAULT ((0)),
	[Kilos] [decimal](18, 4) NOT NULL CONSTRAINT [DF_DetMovGan_Kilos]  DEFAULT ((0)),
	[CostoxKilo] [money] NOT NULL CONSTRAINT [DF_DetMovGan_CostoxKilo]  DEFAULT ((0)),
 CONSTRAINT [PK_DetMovGan] PRIMARY KEY NONCLUSTERED 
(
	[Fol_MovGan] ASC,
	[Cve_Ganado] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[DetMovGan]  WITH CHECK ADD  CONSTRAINT [FK_DetMovGan_CabMovGan2] FOREIGN KEY([Fol_MovGan])
REFERENCES [dbo].[CabMovGan] ([Fol_MovGan])
GO
ALTER TABLE [dbo].[DetMovGan] CHECK CONSTRAINT [FK_DetMovGan_CabMovGan2]
GO
ALTER TABLE [dbo].[DetMovGan]  WITH CHECK ADD  CONSTRAINT [FK_DetMovGan_MCGCatTiposdeGanado2] FOREIGN KEY([Cve_Ganado])
REFERENCES [dbo].[MCGCatTiposdeGanado] ([IdTipoGanado])
GO
ALTER TABLE [dbo].[DetMovGan] CHECK CONSTRAINT [FK_DetMovGan_MCGCatTiposdeGanado2]