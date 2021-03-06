/****** Objeto:  Table [dbo].[CabRegCom]    Fecha de la secuencia de comandos: 09/09/2009 10:12:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CabRegCom](
	[Fol_Recep] [char](10) NOT NULL CONSTRAINT [DF_CabRegCom_Fol_Recep]  DEFAULT (' '),
	[Fec_Recep] [datetime] NOT NULL CONSTRAINT [DF_CabRegCom_Fec_Recep]  DEFAULT ('1900-01-01'),
	[Cve_ProveGan] [int] NOT NULL CONSTRAINT [DF_CabRegCom_Cve_ProveGan]  DEFAULT ((0)),
	[Cve_LugCom] [int] NOT NULL CONSTRAINT [DF_CabRegCom_Cve_LugCom]  DEFAULT ((0)),
	[Cve_ComiGan] [int] NOT NULL CONSTRAINT [DF_CabRegCom_Cve_ComiGan]  DEFAULT ((0)),
	[NumGuias] [smallint] NOT NULL CONSTRAINT [DF_CabRegCom_NumGuias]  DEFAULT ((0)),
	[ImpteXGuia] [money] NOT NULL CONSTRAINT [DF_CabRegCom_ImpteXGuia]  DEFAULT ((0)),
	[HorasViaje] [smallmoney] NOT NULL CONSTRAINT [DF_CabRegCom_HorasViaje]  DEFAULT ((0)),
	[ImptePredial] [money] NOT NULL CONSTRAINT [DF_CabRegCom_ImptePredial]  DEFAULT ((0)),
	[Boo_Predial] [bit] NOT NULL CONSTRAINT [DF_CabRegCom_Boo_Predial]  DEFAULT ('N '),
	[ImpteEduc] [money] NOT NULL CONSTRAINT [DF_CabRegCom_ImpteEduc]  DEFAULT ((0)),
	[Boo_Educ] [bit] NOT NULL CONSTRAINT [DF_CabRegCom_Boo_Educ]  DEFAULT ('N '),
	[PesoEntReal] [money] NOT NULL CONSTRAINT [DF_CabRegCom_PesoEntReal]  DEFAULT ((0)),
	[CabezasComp] [int] NOT NULL CONSTRAINT [DF_CabRegCom_CabezasComp]  DEFAULT ((0)),
	[KilosComp] [money] NOT NULL CONSTRAINT [DF_CabRegCom_KilosComp]  DEFAULT ((0)),
	[ImpteComp] [money] NOT NULL CONSTRAINT [DF_CabRegCom_ImpteComp]  DEFAULT ((0)),
	[Observaciones] [varchar](250) NULL CONSTRAINT [DF_CabRegCom_Observaciones]  DEFAULT (' '),
	[Sta_Cerrado] [bit] NULL CONSTRAINT [DF_CabRegCom_Sta_Cerrado]  DEFAULT (' '),
	[Cve_Corral] [varchar](5) NOT NULL CONSTRAINT [DF_CabRegCom_Cve_Corral]  DEFAULT (' '),
	[DiasCredito] [tinyint] NOT NULL CONSTRAINT [DF_CabRegCom_DiasCredito]  DEFAULT ((0)),
	[Fec_Pago] [datetime] NOT NULL CONSTRAINT [DF_CabRegCom_Fec_Pago]  DEFAULT ('1900-01-01'),
	[Num_Factura] [char](8) NOT NULL CONSTRAINT [DF_CabRegCom_Num_Factura]  DEFAULT (' '),
	[Nom_Banco] [char](50) NULL CONSTRAINT [DF_CabRegCom_Nom_Banco]  DEFAULT (' '),
	[Nom_Sucursal] [char](50) NULL CONSTRAINT [DF_CabRegCom_Nom_Sucursal]  DEFAULT (' '),
	[Num_Cuenta] [char](15) NULL CONSTRAINT [DF_CabRegCom_Num_Cuenta]  DEFAULT (' '),
	[Fec_Conta] [datetime] NULL CONSTRAINT [DF_CabRegCom_Fec_Conta]  DEFAULT ('1900-01-01'),
	[NumPoliza] [char](8) NULL CONSTRAINT [DF_CabRegCom_Fol_Poliza]  DEFAULT (' '),
	[ComiXCab] [smallmoney] NOT NULL CONSTRAINT [DF_CabRegCom_ComiXCab]  DEFAULT ((0)),
	[Status] [char](1) NOT NULL CONSTRAINT [DF_CabRegCom_Status]  DEFAULT (' '),
	[CostosIndi] [money] NOT NULL CONSTRAINT [DF_CabRegCom_CostosIndi]  DEFAULT ((0)),
	[Fol_Factura] [char](8) NOT NULL CONSTRAINT [DF_CabRegCom_Fol_Factura]  DEFAULT (''),
	[FechaCaptura] [datetime] NOT NULL CONSTRAINT [DF_CabRegCom_FechaCaptura]  DEFAULT (getdate()),
	[FolioRecepcionPesada] [varchar](50) NOT NULL CONSTRAINT [DF_CabRegCom_FolioRecepcionPesada]  DEFAULT (''),
	[FolioMovimientoGanado] [varchar](11) NOT NULL,
	[FolioMovimientoGanadoCancelacion] [varchar](11) NULL,
	[TipoComision] [smallint] NOT NULL,
 CONSTRAINT [PK_CabRegCom] PRIMARY KEY NONCLUSTERED 
(
	[Fol_Recep] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0=Ninguna, 1=Cabezas, 2=Kilos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CabRegCom', @level2type=N'COLUMN',@level2name=N'TipoComision'
GO
ALTER TABLE [dbo].[CabRegCom]  WITH NOCHECK ADD  CONSTRAINT [FK_CabRegCom_CabGasTrans] FOREIGN KEY([Fol_Recep])
REFERENCES [dbo].[CabGasTrans] ([Fol_Recep])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CabRegCom] NOCHECK CONSTRAINT [FK_CabRegCom_CabGasTrans]
GO
ALTER TABLE [dbo].[CabRegCom]  WITH CHECK ADD  CONSTRAINT [FK_CabRegCom_CabMovGan] FOREIGN KEY([FolioMovimientoGanado])
REFERENCES [dbo].[CabMovGan] ([Fol_MovGan])
GO
ALTER TABLE [dbo].[CabRegCom] CHECK CONSTRAINT [FK_CabRegCom_CabMovGan]
GO
ALTER TABLE [dbo].[CabRegCom]  WITH NOCHECK ADD  CONSTRAINT [FK_CabRegCom_CabMovGan1] FOREIGN KEY([FolioMovimientoGanadoCancelacion])
REFERENCES [dbo].[CabMovGan] ([Fol_MovGan])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CabRegCom] NOCHECK CONSTRAINT [FK_CabRegCom_CabMovGan1]
GO
ALTER TABLE [dbo].[CabRegCom]  WITH CHECK ADD  CONSTRAINT [FK_CabRegCom_CatLugaresDeCompra] FOREIGN KEY([Cve_LugCom])
REFERENCES [dbo].[CatLugaresDeCompra] ([IdLugarCompra])
GO
ALTER TABLE [dbo].[CabRegCom] CHECK CONSTRAINT [FK_CabRegCom_CatLugaresDeCompra]
GO
ALTER TABLE [dbo].[CabRegCom]  WITH CHECK ADD  CONSTRAINT [FK_CabRegCom_MCatCompProveedores] FOREIGN KEY([Cve_ProveGan])
REFERENCES [dbo].[MCatCompProveedores] ([PrIdProveedor])
GO
ALTER TABLE [dbo].[CabRegCom] CHECK CONSTRAINT [FK_CabRegCom_MCatCompProveedores]
GO
ALTER TABLE [dbo].[CabRegCom]  WITH CHECK ADD  CONSTRAINT [FK_CabRegCom_MCECatCorralesCab] FOREIGN KEY([Cve_Corral])
REFERENCES [dbo].[MCECatCorralesCab] ([IdCorral])
GO
ALTER TABLE [dbo].[CabRegCom] CHECK CONSTRAINT [FK_CabRegCom_MCECatCorralesCab]
GO
ALTER TABLE [dbo].[CabRegCom]  WITH CHECK ADD  CONSTRAINT [FK_CabRegCom_MCGCatCompradoresdeGanado] FOREIGN KEY([Cve_ComiGan])
REFERENCES [dbo].[MCGCatCompradoresdeGanado] ([IdComprador])
GO
ALTER TABLE [dbo].[CabRegCom] CHECK CONSTRAINT [FK_CabRegCom_MCGCatCompradoresdeGanado]