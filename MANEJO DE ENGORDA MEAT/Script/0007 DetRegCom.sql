/****** Objeto:  Table [dbo].[DetRegCom]    Fecha de la secuencia de comandos: 09/09/2009 10:24:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetRegCom](
	[Fol_Recep] [char](10) NOT NULL CONSTRAINT [DF_DetRegCom_Fol_Recep]  DEFAULT (' '),
	[Cve_Renglon] [smallint] NOT NULL CONSTRAINT [DF_DetRegCom_Cve_Renglon]  DEFAULT ((0)),
	[Cve_Ganado] [int] NOT NULL CONSTRAINT [DF_DetRegCom_Cve_Ganado]  DEFAULT (' '),
	[CantCabezas] [smallint] NOT NULL CONSTRAINT [DF_DetRegCom_CantCabezas]  DEFAULT ((0)),
	[CantKilos] [money] NOT NULL CONSTRAINT [DF_DetRegCom_CantKilos]  DEFAULT ((0)),
	[PrecioXKilo] [smallmoney] NOT NULL CONSTRAINT [DF_DetRegCom_PrecioXKilo]  DEFAULT ((0)),
	[CantKilosRecibidos] [decimal](18, 3) NOT NULL CONSTRAINT [DF_DetRegCom_CantKilosRecibidos]  DEFAULT ((0)),
	[Importe]  AS ([cantkilos]*[precioxkilo]),
 CONSTRAINT [PK_DetRegCom] PRIMARY KEY NONCLUSTERED 
(
	[Fol_Recep] ASC,
	[Cve_Renglon] ASC,
	[Cve_Ganado] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[DetRegCom]  WITH CHECK ADD  CONSTRAINT [FK_DetRegCom_CabRegCom] FOREIGN KEY([Fol_Recep])
REFERENCES [dbo].[CabRegCom] ([Fol_Recep])
GO
ALTER TABLE [dbo].[DetRegCom] CHECK CONSTRAINT [FK_DetRegCom_CabRegCom]
GO
ALTER TABLE [dbo].[DetRegCom]  WITH CHECK ADD  CONSTRAINT [FK_DetRegCom_MCGCatTiposdeGanado] FOREIGN KEY([Cve_Ganado])
REFERENCES [dbo].[MCGCatTiposdeGanado] ([IdTipoGanado])
GO
ALTER TABLE [dbo].[DetRegCom] CHECK CONSTRAINT [FK_DetRegCom_MCGCatTiposdeGanado]