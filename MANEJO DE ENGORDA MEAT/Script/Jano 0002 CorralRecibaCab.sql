/****** Object:  Table [dbo].[CorralRecibaDet]    Script Date: 10/22/2009 18:51:23 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CorralRecibaDet_CorralRecibaCab]') AND parent_object_id = OBJECT_ID(N'[dbo].[CorralRecibaDet]'))
ALTER TABLE [dbo].[CorralRecibaDet] DROP CONSTRAINT [FK_CorralRecibaDet_CorralRecibaCab]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CorralRecibaDet_MCECatCorralesCab]') AND parent_object_id = OBJECT_ID(N'[dbo].[CorralRecibaDet]'))
ALTER TABLE [dbo].[CorralRecibaDet] DROP CONSTRAINT [FK_CorralRecibaDet_MCECatCorralesCab]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CorralRecibaDet_MCECatCorralesCab1]') AND parent_object_id = OBJECT_ID(N'[dbo].[CorralRecibaDet]'))
ALTER TABLE [dbo].[CorralRecibaDet] DROP CONSTRAINT [FK_CorralRecibaDet_MCECatCorralesCab1]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CorralRecibaDet_MCECatLotesCab]') AND parent_object_id = OBJECT_ID(N'[dbo].[CorralRecibaDet]'))
ALTER TABLE [dbo].[CorralRecibaDet] DROP CONSTRAINT [FK_CorralRecibaDet_MCECatLotesCab]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RecibaDet_MCGCatTiposdeGanado]') AND parent_object_id = OBJECT_ID(N'[dbo].[CorralRecibaDet]'))
ALTER TABLE [dbo].[CorralRecibaDet] DROP CONSTRAINT [FK_RecibaDet_MCGCatTiposdeGanado]
GO

/****** Object:  Table [dbo].[CorralRecibaCab]    Script Date: 10/22/2009 18:48:01 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CorralRecibaCab_CabMovGan]') AND parent_object_id = OBJECT_ID(N'[dbo].[CorralRecibaCab]'))
ALTER TABLE [dbo].[CorralRecibaCab] DROP CONSTRAINT [FK_CorralRecibaCab_CabMovGan]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CorralRecibaCab_MCECatCorralesCab]') AND parent_object_id = OBJECT_ID(N'[dbo].[CorralRecibaCab]'))
ALTER TABLE [dbo].[CorralRecibaCab] DROP CONSTRAINT [FK_CorralRecibaCab_MCECatCorralesCab]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CorralRecibaCab_MCECatLotesCab]') AND parent_object_id = OBJECT_ID(N'[dbo].[CorralRecibaCab]'))
ALTER TABLE [dbo].[CorralRecibaCab] DROP CONSTRAINT [FK_CorralRecibaCab_MCECatLotesCab]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RecibaCab_CatRastros]') AND parent_object_id = OBJECT_ID(N'[dbo].[CorralRecibaCab]'))
ALTER TABLE [dbo].[CorralRecibaCab] DROP CONSTRAINT [FK_RecibaCab_CatRastros]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RecibaCab_MCECatCorralesCab]') AND parent_object_id = OBJECT_ID(N'[dbo].[CorralRecibaCab]'))
ALTER TABLE [dbo].[CorralRecibaCab] DROP CONSTRAINT [FK_RecibaCab_MCECatCorralesCab]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RecibaCab_usrContPolizas]') AND parent_object_id = OBJECT_ID(N'[dbo].[CorralRecibaCab]'))
ALTER TABLE [dbo].[CorralRecibaCab] DROP CONSTRAINT [FK_RecibaCab_usrContPolizas]
GO

/****** Object:  Table [dbo].[CorralRecibaCab]    Script Date: 10/22/2009 18:48:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CorralRecibaCab]') AND type in (N'U'))
DROP TABLE [dbo].[CorralRecibaCab]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CorralRecibaCab](
	[IdCorralReciba] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdCorral] [varchar](5) NOT NULL,
	[IdCorralDestino] [varchar](5) NULL,
	[IdLoteDestino] [int] NULL,
	[IdRastro] [int] NULL,
	[IdVenta] [int] NULL,
	[Cabezas] [smallint] NOT NULL,
	[Kilos] [money] NOT NULL,
	[CostoEntrada] [money] NOT NULL,
	[CostoAlimento] [money] NOT NULL,
	[KilosAlimento] [money] NOT NULL,
	[CostoMedicina] [money] NOT NULL,
	[CostoxKilo] [money] NOT NULL,
	[CostoMovto] [money] NULL,
	[Fec_Conta] [datetime] NULL,
	[IdPoliza] [int] NULL,
	[Estatus] [tinyint] NOT NULL,
	[IdTipoReciba] [tinyint] NOT NULL,
	[Aviso] [varchar](50) NULL,
	[IdCausaMuerte] [tinyint] NULL,
	[Recuperacion] [bit] NULL,
	[ImporteVenta] [money] NULL,
	[FolioMovimientoGanado] [varchar](11) NOT NULL,
 CONSTRAINT [PK_RecibaCab] PRIMARY KEY CLUSTERED 
(
	[IdCorralReciba] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0=CANCELADO, 1=VIGENTE' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CorralRecibaCab', @level2type=N'COLUMN',@level2name=N'Estatus'
GO
ALTER TABLE [dbo].[CorralRecibaCab]  WITH CHECK ADD  CONSTRAINT [FK_CorralRecibaCab_CabMovGan] FOREIGN KEY([FolioMovimientoGanado])
REFERENCES [dbo].[CabMovGan] ([Fol_MovGan])
GO
ALTER TABLE [dbo].[CorralRecibaCab] CHECK CONSTRAINT [FK_CorralRecibaCab_CabMovGan]
GO
ALTER TABLE [dbo].[CorralRecibaCab]  WITH CHECK ADD  CONSTRAINT [FK_CorralRecibaCab_MCECatCorralesCab] FOREIGN KEY([IdCorralDestino])
REFERENCES [dbo].[MCECatCorralesCab] ([IdCorral])
GO
ALTER TABLE [dbo].[CorralRecibaCab] CHECK CONSTRAINT [FK_CorralRecibaCab_MCECatCorralesCab]
GO
ALTER TABLE [dbo].[CorralRecibaCab]  WITH CHECK ADD  CONSTRAINT [FK_CorralRecibaCab_MCECatLotesCab] FOREIGN KEY([IdLoteDestino])
REFERENCES [dbo].[MCECatLotesCab] ([IdLote])
GO
ALTER TABLE [dbo].[CorralRecibaCab] CHECK CONSTRAINT [FK_CorralRecibaCab_MCECatLotesCab]
GO
ALTER TABLE [dbo].[CorralRecibaCab]  WITH CHECK ADD  CONSTRAINT [FK_RecibaCab_CatRastros] FOREIGN KEY([IdRastro])
REFERENCES [dbo].[CatRastros] ([IdRastro])
GO
ALTER TABLE [dbo].[CorralRecibaCab] CHECK CONSTRAINT [FK_RecibaCab_CatRastros]
GO
ALTER TABLE [dbo].[CorralRecibaCab]  WITH CHECK ADD  CONSTRAINT [FK_RecibaCab_MCECatCorralesCab] FOREIGN KEY([IdCorral])
REFERENCES [dbo].[MCECatCorralesCab] ([IdCorral])
GO
ALTER TABLE [dbo].[CorralRecibaCab] CHECK CONSTRAINT [FK_RecibaCab_MCECatCorralesCab]
GO
ALTER TABLE [dbo].[CorralRecibaCab]  WITH CHECK ADD  CONSTRAINT [FK_RecibaCab_usrContPolizas] FOREIGN KEY([IdPoliza])
REFERENCES [dbo].[usrContPolizas] ([Codigo])
GO
ALTER TABLE [dbo].[CorralRecibaCab] CHECK CONSTRAINT [FK_RecibaCab_usrContPolizas]

/****** Object:  Table [dbo].[CorralRecibaDet]    Script Date: 10/23/2009 10:14:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CorralRecibaDet]') AND type in (N'U'))
DROP TABLE [dbo].[CorralRecibaDet]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CorralRecibaDet](
	[IdCorralReciba] [int] NOT NULL,
	[IdTipoGanado] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Cabezas] [int] NOT NULL,
	[Kilos] [decimal](18, 4) NOT NULL,
	[CostoxKilo] [money] NOT NULL,
	[CostoEntrada] [money] NOT NULL,
	[CostoAlimento] [money] NOT NULL,
	[CostoMedicina] [money] NOT NULL,
	[KilosAlimento] [money] NOT NULL,
	[IdCorral] [varchar](5) NULL,
	[IdCorralDestino] [varchar](5) NULL,
	[IdLoteDestino] [int] NULL,
	[IdVenta] [int] NULL,
	[PrecioxKilo] [money] NULL,
 CONSTRAINT [PK_DetRecRas] PRIMARY KEY NONCLUSTERED 
(
	[IdCorralReciba] ASC,
	[IdTipoGanado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[CorralRecibaDet]  WITH CHECK ADD  CONSTRAINT [FK_CorralRecibaDet_CorralRecibaCab] FOREIGN KEY([IdCorralReciba])
REFERENCES [dbo].[CorralRecibaCab] ([IdCorralReciba])
GO
ALTER TABLE [dbo].[CorralRecibaDet] CHECK CONSTRAINT [FK_CorralRecibaDet_CorralRecibaCab]
GO
ALTER TABLE [dbo].[CorralRecibaDet]  WITH CHECK ADD  CONSTRAINT [FK_CorralRecibaDet_MCECatCorralesCab] FOREIGN KEY([IdCorral])
REFERENCES [dbo].[MCECatCorralesCab] ([IdCorral])
GO
ALTER TABLE [dbo].[CorralRecibaDet] CHECK CONSTRAINT [FK_CorralRecibaDet_MCECatCorralesCab]
GO
ALTER TABLE [dbo].[CorralRecibaDet]  WITH CHECK ADD  CONSTRAINT [FK_CorralRecibaDet_MCECatCorralesCab1] FOREIGN KEY([IdCorralDestino])
REFERENCES [dbo].[MCECatCorralesCab] ([IdCorral])
GO
ALTER TABLE [dbo].[CorralRecibaDet] CHECK CONSTRAINT [FK_CorralRecibaDet_MCECatCorralesCab1]
GO
ALTER TABLE [dbo].[CorralRecibaDet]  WITH CHECK ADD  CONSTRAINT [FK_CorralRecibaDet_MCECatLotesCab] FOREIGN KEY([IdLoteDestino])
REFERENCES [dbo].[MCECatLotesCab] ([IdLote])
GO
ALTER TABLE [dbo].[CorralRecibaDet] CHECK CONSTRAINT [FK_CorralRecibaDet_MCECatLotesCab]
GO
ALTER TABLE [dbo].[CorralRecibaDet]  WITH CHECK ADD  CONSTRAINT [FK_RecibaDet_MCGCatTiposdeGanado] FOREIGN KEY([IdTipoGanado])
REFERENCES [dbo].[MCGCatTiposdeGanado] ([IdTipoGanado])
GO
ALTER TABLE [dbo].[CorralRecibaDet] CHECK CONSTRAINT [FK_RecibaDet_MCGCatTiposdeGanado]