
/****** Objeto:  Table [dbo].[CabGasTrans]    Fecha de la secuencia de comandos: 09/09/2009 10:13:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CabGasTrans](
	[Fol_Recep] [char](10) NOT NULL CONSTRAINT [DF_CabGasTrans_Fol_Recep]  DEFAULT (' '),
	[Fec_Recep] [datetime] NOT NULL CONSTRAINT [DF_CabGasTrans_Fec_Recep]  DEFAULT ('1900-01-01'),
	[Cve_Chofer] [int] NOT NULL CONSTRAINT [DF_CabGasTrans_Cve_Chofer]  DEFAULT ((0)),
	[Cve_Vehiculo] [int] NOT NULL CONSTRAINT [DF_CabGasTrans_Cve_Vehiculo]  DEFAULT (' '),
	[ImpteIva] [money] NOT NULL CONSTRAINT [DF_CabGasTrans_ImpteIva]  DEFAULT ((0)),
	[ImpteTotal] [money] NOT NULL CONSTRAINT [DF_CabGasTrans_ImpteTotal]  DEFAULT ((0)),
	[Fec_Conta] [datetime] NOT NULL CONSTRAINT [DF_CabGasTrans_Fec_Conta]  DEFAULT ('1900-01-01'),
	[NumPoliza] [char](8) NOT NULL CONSTRAINT [DF_CabGasTrans_NumPoliza]  DEFAULT (' '),
	[Status] [char](1) NOT NULL CONSTRAINT [DF_CabGasTrans_Status]  DEFAULT (' '),
 CONSTRAINT [PK_CabGasTrans] PRIMARY KEY NONCLUSTERED 
(
	[Fol_Recep] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[CabGasTrans]  WITH CHECK ADD  CONSTRAINT [FK_CabGasTrans_MCGCatChoferes] FOREIGN KEY([Cve_Chofer])
REFERENCES [dbo].[MCGCatChoferes] ([IdChofer])
GO
ALTER TABLE [dbo].[CabGasTrans] CHECK CONSTRAINT [FK_CabGasTrans_MCGCatChoferes]
GO
ALTER TABLE [dbo].[CabGasTrans]  WITH CHECK ADD  CONSTRAINT [FK_CabGasTrans_MCGCatVehiculos] FOREIGN KEY([Cve_Vehiculo])
REFERENCES [dbo].[MCGCatVehiculos] ([IdVehiculo])
GO
ALTER TABLE [dbo].[CabGasTrans] CHECK CONSTRAINT [FK_CabGasTrans_MCGCatVehiculos]