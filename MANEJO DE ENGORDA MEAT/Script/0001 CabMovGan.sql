/****** Objeto:  Table [dbo].[CabMovGan]    Fecha de la secuencia de comandos: 09/09/2009 10:14:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CabMovGan](
	[Fol_MovGan] [varchar](11) NOT NULL,
	[Fec_MovGan] [datetime] NOT NULL CONSTRAINT [DF_CabMovGan_Fec_MovGan]  DEFAULT ('1900-01-01'),
	[Cve_MovGan] [int] NOT NULL CONSTRAINT [DF_CabMovGan_Cve_MovGan]  DEFAULT (' '),
	[Cve_Ganadera] [tinyint] NULL CONSTRAINT [DF_CabMovGan_Cve_Ganadera]  DEFAULT ((0)),
	[Fec_Conta] [datetime] NULL CONSTRAINT [DF_CabMovGan_Fec_Conta]  DEFAULT ('1900-01-01'),
	[Fol_Poliza] [char](8) NULL CONSTRAINT [DF_CabMovGan_Fol_Poliza]  DEFAULT (' '),
	[Sta_Mov] [char](1) NULL CONSTRAINT [DF_CabMovGan_Sta_Mov]  DEFAULT (' '),
	[CostoTotal] [money] NOT NULL CONSTRAINT [DF_CabMovGan_CostoTotal]  DEFAULT ((0)),
	[Fol_Refere] [varchar](11) NOT NULL CONSTRAINT [DF_CabMovGan_Fol_Refere]  DEFAULT (' '),
 CONSTRAINT [PK_CabMovGan] PRIMARY KEY NONCLUSTERED 
(
	[Fol_MovGan] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[CabMovGan]  WITH CHECK ADD  CONSTRAINT [FK_CabMovGan_MCGCatMovGanado2] FOREIGN KEY([Cve_MovGan])
REFERENCES [dbo].[MCGCatMovGanado] ([IdMovGanado])
GO
ALTER TABLE [dbo].[CabMovGan] CHECK CONSTRAINT [FK_CabMovGan_MCGCatMovGanado2]