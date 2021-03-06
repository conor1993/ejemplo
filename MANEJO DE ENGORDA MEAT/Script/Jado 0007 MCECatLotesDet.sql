/*
   Miércoles, 07 de Octubre de 200902:00:38 p.m.
   Usuario: sa
   Servidor: integrasrv
   Base de datos: Ganadera
   Aplicación: 
*/

/* Para evitar posibles problemas de pérdida de datos, debe revisar esta secuencia de comandos detalladamente antes de ejecutarla fuera del contexto del diseñador de base de datos.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MCECatLotesDet
	DROP CONSTRAINT FK_MCECatLotesDet_MCGCatTiposdeGanado
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MCGCatTiposdeGanado', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MCGCatTiposdeGanado', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MCGCatTiposdeGanado', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.MCECatLotesDet
	DROP CONSTRAINT FK_MCECatLotesDet_MCECatLotesCab
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MCECatLotesCab', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MCECatLotesCab', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MCECatLotesCab', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.MCECatLotesDet
	DROP CONSTRAINT DF_MCECatLotesDet_CantCabezas
GO
ALTER TABLE dbo.MCECatLotesDet
	DROP CONSTRAINT DF_MCECatLotesDet_KilosEntrada
GO
ALTER TABLE dbo.MCECatLotesDet
	DROP CONSTRAINT DF_MCECatLotesDet_KilosSalida
GO
CREATE TABLE dbo.Tmp_MCECatLotesDet
	(
	IdLote int NOT NULL,
	IdTipoGanado int NOT NULL,
	AretePropio varchar(10) NOT NULL,
	AreteSiniiga varchar(10) NOT NULL,
	AreteTransporte varchar(10) NOT NULL,
	KilosEntrada money NOT NULL,
	KilosSalida money NOT NULL,
	FechaEntrada datetime NOT NULL,
	FechaSalida datetime NULL,
	KilosAlim money NOT NULL,
	ImpteAlim money NOT NULL,
	ImpteMed money NOT NULL,
	GDPIni money NOT NULL,
	GDP money NOT NULL,
	ECA money NOT NULL,
	CKI money NOT NULL,
	PesoEstimado money NOT NULL,
	SaldoCostoInd money NOT NULL,
	Impte money NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_MCECatLotesDet ADD CONSTRAINT
	DF_MCECatLotesDet_KilosEntrada DEFAULT (0) FOR KilosEntrada
GO
ALTER TABLE dbo.Tmp_MCECatLotesDet ADD CONSTRAINT
	DF_MCECatLotesDet_KilosSalida DEFAULT (0) FOR KilosSalida
GO
ALTER TABLE dbo.Tmp_MCECatLotesDet ADD CONSTRAINT
	DF_MCECatLotesDet_SaldoKilosAlim DEFAULT ((0)) FOR KilosAlim
GO
ALTER TABLE dbo.Tmp_MCECatLotesDet ADD CONSTRAINT
	DF_MCECatLotesDet_SaldoImpteAlim DEFAULT ((0)) FOR ImpteAlim
GO
ALTER TABLE dbo.Tmp_MCECatLotesDet ADD CONSTRAINT
	DF_MCECatLotesDet_SaldoImpteMed DEFAULT ((0)) FOR ImpteMed
GO
ALTER TABLE dbo.Tmp_MCECatLotesDet ADD CONSTRAINT
	DF_MCECatLotesDet_GDPIni DEFAULT ((0)) FOR GDPIni
GO
ALTER TABLE dbo.Tmp_MCECatLotesDet ADD CONSTRAINT
	DF_MCECatLotesDet_GDP DEFAULT ((0)) FOR GDP
GO
ALTER TABLE dbo.Tmp_MCECatLotesDet ADD CONSTRAINT
	DF_MCECatLotesDet_ECA DEFAULT ((0)) FOR ECA
GO
ALTER TABLE dbo.Tmp_MCECatLotesDet ADD CONSTRAINT
	DF_MCECatLotesDet_CKI DEFAULT ((0)) FOR CKI
GO
ALTER TABLE dbo.Tmp_MCECatLotesDet ADD CONSTRAINT
	DF_MCECatLotesDet_PesoEstimado DEFAULT ((0)) FOR PesoEstimado
GO
ALTER TABLE dbo.Tmp_MCECatLotesDet ADD CONSTRAINT
	DF_MCECatLotesDet_SaldoCostoInd DEFAULT ((0)) FOR SaldoCostoInd
GO
ALTER TABLE dbo.Tmp_MCECatLotesDet ADD CONSTRAINT
	DF_MCECatLotesDet_SaldoImpte DEFAULT ((0)) FOR Impte
GO
IF EXISTS(SELECT * FROM dbo.MCECatLotesDet)
	 EXEC('INSERT INTO dbo.Tmp_MCECatLotesDet (IdLote, IdTipoGanado, KilosEntrada, KilosSalida)
		SELECT IdLote, IdTipoGanado, KilosEntrada, KilosSalida FROM dbo.MCECatLotesDet WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.MCECatLotesDet
GO
EXECUTE sp_rename N'dbo.Tmp_MCECatLotesDet', N'MCECatLotesDet', 'OBJECT' 
GO
ALTER TABLE dbo.MCECatLotesDet ADD CONSTRAINT
	PK_MCECatLotesDet PRIMARY KEY CLUSTERED 
	(
	IdLote,
	IdTipoGanado,
	AretePropio
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.MCECatLotesDet ADD CONSTRAINT
	FK_MCECatLotesDet_MCECatLotesCab FOREIGN KEY
	(
	IdLote
	) REFERENCES dbo.MCECatLotesCab
	(
	IdLote
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.MCECatLotesDet ADD CONSTRAINT
	FK_MCECatLotesDet_MCGCatTiposdeGanado FOREIGN KEY
	(
	IdTipoGanado
	) REFERENCES dbo.MCGCatTiposdeGanado
	(
	IdTipoGanado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MCECatLotesDet', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MCECatLotesDet', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MCECatLotesDet', 'Object', 'CONTROL') as Contr_Per 