/*
   Martes, 06 de Octubre de 200901:41:17 p.m.
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
COMMIT
select Has_Perms_By_Name(N'dbo.MInvMovimientosAlmacen', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MInvMovimientosAlmacen', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MInvMovimientosAlmacen', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MCECatCorralesCab', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MCECatCorralesCab', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MCECatCorralesCab', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MCECatLotesCab', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MCECatLotesCab', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MCECatLotesCab', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MCatCompProductos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MCatCompProductos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MCatCompProductos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.CabAplFor
	DROP CONSTRAINT DF_CabAplFor_Fol_Mov
GO
ALTER TABLE dbo.CabAplFor
	DROP CONSTRAINT DF_CabAplFor_Cve_Corral
GO
ALTER TABLE dbo.CabAplFor
	DROP CONSTRAINT DF_CabAplFor_Cve_Formula
GO
ALTER TABLE dbo.CabAplFor
	DROP CONSTRAINT DF_CabAplFor_Cve_Renglon
GO
ALTER TABLE dbo.CabAplFor
	DROP CONSTRAINT DF_CabAplFor_Fec_AplF
GO
ALTER TABLE dbo.CabAplFor
	DROP CONSTRAINT DF_CabAplFor_CantServ1
GO
ALTER TABLE dbo.CabAplFor
	DROP CONSTRAINT DF_CabAplFor_CantServ2
GO
ALTER TABLE dbo.CabAplFor
	DROP CONSTRAINT DF_CabAplFor_CantServ3
GO
ALTER TABLE dbo.CabAplFor
	DROP CONSTRAINT DF_CabAplFor_CantServ4
GO
ALTER TABLE dbo.CabAplFor
	DROP CONSTRAINT DF_CabAplFor_CabezasXCorral
GO
ALTER TABLE dbo.CabAplFor
	DROP CONSTRAINT DF_CabAplFor_Fec_Conta
GO
ALTER TABLE dbo.CabAplFor
	DROP CONSTRAINT DF_CabAplFor_Fol_Poliza
GO
ALTER TABLE dbo.CabAplFor
	DROP CONSTRAINT DF_CabAplFor_costo
GO
CREATE TABLE dbo.Tmp_CabAplFor
	(
	Fol_AplF char(8) NOT NULL,
	FechaAplicacion datetime NOT NULL,
	FechaContabilizacion datetime NOT NULL,
	Fol_Poliza char(8) NOT NULL,
	Costo money NOT NULL,
	IdUsuarioAlta int NOT NULL,
	IdUsuarioCancelacion int NULL,
	FechaCaptura datetime NOT NULL,
	FechaCancelacion datetime NULL,
	Estatus smallint NULL,
	Cabezas int NOT NULL,
	FolioMovimientoAlmacen varchar(20) NOT NULL,
	FolioMovimientoAlmacenCancelacion varchar(20) NULL,
	IdAlmacen int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_CabAplFor ADD CONSTRAINT
	DF_CabAplFor_Fol_Mov DEFAULT (' ') FOR Fol_AplF
GO
ALTER TABLE dbo.Tmp_CabAplFor ADD CONSTRAINT
	DF_CabAplFor_Fec_AplF DEFAULT ('1900-01-01') FOR FechaAplicacion
GO
ALTER TABLE dbo.Tmp_CabAplFor ADD CONSTRAINT
	DF_CabAplFor_Fec_Conta DEFAULT ('1900-01-01') FOR FechaContabilizacion
GO
ALTER TABLE dbo.Tmp_CabAplFor ADD CONSTRAINT
	DF_CabAplFor_Fol_Poliza DEFAULT (' ') FOR Fol_Poliza
GO
ALTER TABLE dbo.Tmp_CabAplFor ADD CONSTRAINT
	DF_CabAplFor_costo DEFAULT ((0)) FOR Costo
GO
IF EXISTS(SELECT * FROM dbo.CabAplFor)
	 EXEC('INSERT INTO dbo.Tmp_CabAplFor (Fol_AplF, FechaAplicacion, FechaContabilizacion, Fol_Poliza, Costo)
		SELECT Fol_AplF, Fec_AplF, Fec_Conta, Fol_Poliza, costo FROM dbo.CabAplFor WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.CabAplFor
GO
EXECUTE sp_rename N'dbo.Tmp_CabAplFor', N'CabAplFor', 'OBJECT' 
GO
ALTER TABLE dbo.CabAplFor ADD CONSTRAINT
	PK_CabAplFor_1 PRIMARY KEY CLUSTERED 
	(
	Fol_AplF
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.CabAplFor ADD CONSTRAINT
	FK_CabAplFor_MInvMovimientosAlmacen FOREIGN KEY
	(
	IdAlmacen,
	FolioMovimientoAlmacen
	) REFERENCES dbo.MInvMovimientosAlmacen
	(
	AlmacenId,
	FolioMovimiento
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.CabAplFor WITH NOCHECK ADD CONSTRAINT
	FK_CabAplFor_MInvMovimientosAlmacen1 FOREIGN KEY
	(
	IdAlmacen,
	FolioMovimientoAlmacenCancelacion
	) REFERENCES dbo.MInvMovimientosAlmacen
	(
	AlmacenId,
	FolioMovimiento
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	 NOT FOR REPLICATION

GO
ALTER TABLE dbo.CabAplFor
	NOCHECK CONSTRAINT FK_CabAplFor_MInvMovimientosAlmacen1
GO
COMMIT
select Has_Perms_By_Name(N'dbo.CabAplFor', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.CabAplFor', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.CabAplFor', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.DetAplFor
	DROP CONSTRAINT DF_DetAplFor_Fol_AplF
GO
ALTER TABLE dbo.DetAplFor
	DROP CONSTRAINT DF_DetAplFor_Cve_Lote
GO
ALTER TABLE dbo.DetAplFor
	DROP CONSTRAINT DF_DetAplFor_Cve_Corral
GO
ALTER TABLE dbo.DetAplFor
	DROP CONSTRAINT DF_DetAplFor_Cve_Renglon
GO
ALTER TABLE dbo.DetAplFor
	DROP CONSTRAINT DF_DetAplFor_Cve_Formula
GO
ALTER TABLE dbo.DetAplFor
	DROP CONSTRAINT DF_DetAplFor_Fec_AplF_1
GO
ALTER TABLE dbo.DetAplFor
	DROP CONSTRAINT DF_DetAplFor_Cabezas
GO
ALTER TABLE dbo.DetAplFor
	DROP CONSTRAINT DF_DetAplFor_Kilos
GO
CREATE TABLE dbo.Tmp_DetAplFor
	(
	Fol_AplF char(8) NOT NULL,
	Cve_Lote int NOT NULL,
	Cve_Corral varchar(5) NOT NULL,
	Cve_Renglon smallint NOT NULL,
	Cve_Formula int NOT NULL,
	Cabezas smallint NOT NULL,
	KilosxLote money NOT NULL,
	CantServ1 smallmoney NOT NULL,
	CantServ2 smallmoney NOT NULL,
	CantServ3 smallmoney NOT NULL,
	CantServ4 smallmoney NOT NULL,
	Costo money NOT NULL,
	Importe nchar(10) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_DetAplFor ADD CONSTRAINT
	DF_DetAplFor_Fol_AplF DEFAULT (' ') FOR Fol_AplF
GO
ALTER TABLE dbo.Tmp_DetAplFor ADD CONSTRAINT
	DF_DetAplFor_Cve_Lote DEFAULT ((0)) FOR Cve_Lote
GO
ALTER TABLE dbo.Tmp_DetAplFor ADD CONSTRAINT
	DF_DetAplFor_Cve_Corral DEFAULT (' ') FOR Cve_Corral
GO
ALTER TABLE dbo.Tmp_DetAplFor ADD CONSTRAINT
	DF_DetAplFor_Cve_Renglon DEFAULT ((0)) FOR Cve_Renglon
GO
ALTER TABLE dbo.Tmp_DetAplFor ADD CONSTRAINT
	DF_DetAplFor_Cve_Formula DEFAULT ((0)) FOR Cve_Formula
GO
ALTER TABLE dbo.Tmp_DetAplFor ADD CONSTRAINT
	DF_DetAplFor_Cabezas DEFAULT ((0)) FOR Cabezas
GO
ALTER TABLE dbo.Tmp_DetAplFor ADD CONSTRAINT
	DF_DetAplFor_Kilos DEFAULT ((0)) FOR KilosxLote
GO
ALTER TABLE dbo.Tmp_DetAplFor ADD CONSTRAINT
	DF_DetAplFor_CantServ1 DEFAULT ((0)) FOR CantServ1
GO
ALTER TABLE dbo.Tmp_DetAplFor ADD CONSTRAINT
	DF_DetAplFor_CantServ2 DEFAULT ((0)) FOR CantServ2
GO
ALTER TABLE dbo.Tmp_DetAplFor ADD CONSTRAINT
	DF_DetAplFor_CantServ3 DEFAULT ((0)) FOR CantServ3
GO
ALTER TABLE dbo.Tmp_DetAplFor ADD CONSTRAINT
	DF_DetAplFor_CantServ4 DEFAULT ((0)) FOR CantServ4
GO
IF EXISTS(SELECT * FROM dbo.DetAplFor)
	 EXEC('INSERT INTO dbo.Tmp_DetAplFor (Fol_AplF, Cve_Lote, Cve_Corral, Cve_Renglon, Cve_Formula, Cabezas, KilosxLote)
		SELECT Fol_AplF, Cve_Lote, CONVERT(varchar(5), Cve_Corral), Cve_Renglon, CONVERT(int, Cve_Formula), Cabezas, KilosxLote FROM dbo.DetAplFor WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.DetAplFor
GO
EXECUTE sp_rename N'dbo.Tmp_DetAplFor', N'DetAplFor', 'OBJECT' 
GO
ALTER TABLE dbo.DetAplFor ADD CONSTRAINT
	PK_DetAplFor PRIMARY KEY NONCLUSTERED 
	(
	Fol_AplF,
	Cve_Lote,
	Cve_Corral,
	Cve_Renglon,
	Cve_Formula
	) WITH( PAD_INDEX = OFF, FILLFACTOR = 90, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.DetAplFor ADD CONSTRAINT
	FK_DetAplFor_MCECatLotesCab FOREIGN KEY
	(
	Cve_Lote
	) REFERENCES dbo.MCECatLotesCab
	(
	IdLote
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.DetAplFor ADD CONSTRAINT
	FK_DetAplFor_CabAplFor FOREIGN KEY
	(
	Fol_AplF
	) REFERENCES dbo.CabAplFor
	(
	Fol_AplF
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.DetAplFor ADD CONSTRAINT
	FK_DetAplFor_MCECatCorralesCab FOREIGN KEY
	(
	Cve_Corral
	) REFERENCES dbo.MCECatCorralesCab
	(
	IdCorral
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.DetAplFor ADD CONSTRAINT
	FK_DetAplFor_MCatCompProductos FOREIGN KEY
	(
	Cve_Formula
	) REFERENCES dbo.MCatCompProductos
	(
	PdIdProducto
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.DetAplFor', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.DetAplFor', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.DetAplFor', 'Object', 'CONTROL') as Contr_Per 