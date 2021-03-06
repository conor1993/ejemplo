/*
   Domingo, 11 de Octubre de 200901:36:25 p.m.
   Usuario: sa
   Servidor: 192.168.0.13\SQLEXPRESS
   Base de datos: AgroJs
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
ALTER TABLE dbo.MCGCatTiposdeGanado
	DROP CONSTRAINT DF_MCGCatTiposdeGanado_Descripcion
GO
ALTER TABLE dbo.MCGCatTiposdeGanado
	DROP CONSTRAINT DF_MCGCatTiposdeGanado_DescCorta
GO
ALTER TABLE dbo.MCGCatTiposdeGanado
	DROP CONSTRAINT DF_MCGCatTiposdeGanado_Observaciones
GO
ALTER TABLE dbo.MCGCatTiposdeGanado
	DROP CONSTRAINT DF_MCGCatTiposdeGanado_AcumCabezas
GO
ALTER TABLE dbo.MCGCatTiposdeGanado
	DROP CONSTRAINT DF_MCGCatTiposdeGanado_AcumKilos
GO
ALTER TABLE dbo.MCGCatTiposdeGanado
	DROP CONSTRAINT DF_MCGCatTiposdeGanado_FechaUltimaEntrada
GO
ALTER TABLE dbo.MCGCatTiposdeGanado
	DROP CONSTRAINT DF_MCGCatTiposdeGanado_FechaUltimaSalida
GO
ALTER TABLE dbo.MCGCatTiposdeGanado
	DROP CONSTRAINT DF_MCGCatTiposdeGanado_Estatus
GO
ALTER TABLE dbo.MCGCatTiposdeGanado
	DROP CONSTRAINT DF_MCGCatTiposdeGanado_Lados
GO
CREATE TABLE dbo.Tmp_MCGCatTiposdeGanado
	(
	IdTipoGanado int NOT NULL IDENTITY (1, 1),
	Descripcion varchar(60) NOT NULL,
	DescCorta varchar(6) NOT NULL,
	Observaciones varchar(500) NOT NULL,
	AcumuladoCabezas int NOT NULL,
	AcumuladoKilos money NOT NULL,
	FechaUltimaEntrada datetime NOT NULL,
	FechaUltimaSalida datetime NOT NULL,
	Estatus smallint NOT NULL,
	Lados smallint NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_MCGCatTiposdeGanado ADD CONSTRAINT
	DF_MCGCatTiposdeGanado_Descripcion DEFAULT ('') FOR Descripcion
GO
ALTER TABLE dbo.Tmp_MCGCatTiposdeGanado ADD CONSTRAINT
	DF_MCGCatTiposdeGanado_DescCorta DEFAULT ('') FOR DescCorta
GO
ALTER TABLE dbo.Tmp_MCGCatTiposdeGanado ADD CONSTRAINT
	DF_MCGCatTiposdeGanado_Observaciones DEFAULT ('') FOR Observaciones
GO
ALTER TABLE dbo.Tmp_MCGCatTiposdeGanado ADD CONSTRAINT
	DF_MCGCatTiposdeGanado_AcumCabezas DEFAULT ((0)) FOR AcumuladoCabezas
GO
ALTER TABLE dbo.Tmp_MCGCatTiposdeGanado ADD CONSTRAINT
	DF_MCGCatTiposdeGanado_AcumKilos DEFAULT ((0)) FOR AcumuladoKilos
GO
ALTER TABLE dbo.Tmp_MCGCatTiposdeGanado ADD CONSTRAINT
	DF_MCGCatTiposdeGanado_FechaUltimaEntrada DEFAULT ('01-01-1900') FOR FechaUltimaEntrada
GO
ALTER TABLE dbo.Tmp_MCGCatTiposdeGanado ADD CONSTRAINT
	DF_MCGCatTiposdeGanado_FechaUltimaSalida DEFAULT ('01-01-1900') FOR FechaUltimaSalida
GO
ALTER TABLE dbo.Tmp_MCGCatTiposdeGanado ADD CONSTRAINT
	DF_MCGCatTiposdeGanado_Lados DEFAULT ((2)) FOR Lados
GO
SET IDENTITY_INSERT dbo.Tmp_MCGCatTiposdeGanado ON
GO
IF EXISTS(SELECT * FROM dbo.MCGCatTiposdeGanado)
	 EXEC('INSERT INTO dbo.Tmp_MCGCatTiposdeGanado (IdTipoGanado, Descripcion, DescCorta, Observaciones, AcumuladoCabezas, AcumuladoKilos, FechaUltimaEntrada, FechaUltimaSalida, Estatus, Lados)
		SELECT IdTipoGanado, Descripcion, DescCorta, Observaciones, AcumuladoCabezas, AcumuladoKilos, FechaUltimaEntrada, FechaUltimaSalida, CONVERT(smallint, Estatus), Lados FROM dbo.MCGCatTiposdeGanado WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_MCGCatTiposdeGanado OFF
GO
ALTER TABLE dbo.UsrProdRecepcionDetalle
	DROP CONSTRAINT FK_UsrProdRecepcionDetalle_MCGCatTiposdeGanado
GO
ALTER TABLE dbo.usrProdRecepcionGanado
	DROP CONSTRAINT FK_usrProdRecepcionGanado_MCGCatTiposdeGanado
GO
ALTER TABLE dbo.MCECatCorralesDet
	DROP CONSTRAINT FK_MCECatCorralesDet_MCGCatTiposdeGanado
GO
ALTER TABLE dbo.MCECatLotesDet
	DROP CONSTRAINT FK_MCECatLotesDet_MCGCatTiposdeGanado
GO
ALTER TABLE dbo.DetMovGan
	DROP CONSTRAINT FK_DetMovGan_MCGCatTiposdeGanado
GO
ALTER TABLE dbo.DetRegCom
	DROP CONSTRAINT FK_DetRegCom_MCGCatTiposdeGanado
GO
DROP TABLE dbo.MCGCatTiposdeGanado
GO
EXECUTE sp_rename N'dbo.Tmp_MCGCatTiposdeGanado', N'MCGCatTiposdeGanado', 'OBJECT' 
GO
ALTER TABLE dbo.MCGCatTiposdeGanado ADD CONSTRAINT
	PK_MCGCatTiposdeGanado PRIMARY KEY CLUSTERED 
	(
	IdTipoGanado
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.MCGCatTiposdeGanado', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MCGCatTiposdeGanado', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MCGCatTiposdeGanado', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.DetRegCom ADD CONSTRAINT
	FK_DetRegCom_MCGCatTiposdeGanado FOREIGN KEY
	(
	Cve_Ganado
	) REFERENCES dbo.MCGCatTiposdeGanado
	(
	IdTipoGanado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.DetRegCom', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.DetRegCom', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.DetRegCom', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.DetMovGan ADD CONSTRAINT
	FK_DetMovGan_MCGCatTiposdeGanado FOREIGN KEY
	(
	Cve_Ganado
	) REFERENCES dbo.MCGCatTiposdeGanado
	(
	IdTipoGanado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.DetMovGan', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.DetMovGan', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.DetMovGan', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
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
select Has_Perms_By_Name(N'dbo.MCECatLotesDet', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MCECatLotesDet', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MCECatLotesDet', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.MCECatCorralesDet ADD CONSTRAINT
	FK_MCECatCorralesDet_MCGCatTiposdeGanado FOREIGN KEY
	(
	IdTipoGanado
	) REFERENCES dbo.MCGCatTiposdeGanado
	(
	IdTipoGanado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MCECatCorralesDet', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MCECatCorralesDet', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MCECatCorralesDet', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.usrProdRecepcionGanado WITH NOCHECK ADD CONSTRAINT
	FK_usrProdRecepcionGanado_MCGCatTiposdeGanado FOREIGN KEY
	(
	IdTipoGanado
	) REFERENCES dbo.MCGCatTiposdeGanado
	(
	IdTipoGanado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.usrProdRecepcionGanado', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.usrProdRecepcionGanado', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.usrProdRecepcionGanado', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.UsrProdRecepcionDetalle ADD CONSTRAINT
	FK_UsrProdRecepcionDetalle_MCGCatTiposdeGanado FOREIGN KEY
	(
	IdTipoGanado
	) REFERENCES dbo.MCGCatTiposdeGanado
	(
	IdTipoGanado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.UsrProdRecepcionDetalle', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.UsrProdRecepcionDetalle', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.UsrProdRecepcionDetalle', 'Object', 'CONTROL') as Contr_Per 