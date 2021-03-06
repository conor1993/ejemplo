/*
   Martes, 06 de Octubre de 200906:57:08 p.m.
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
ALTER TABLE dbo.CabAplFor
	DROP CONSTRAINT FK_CabAplFor_MInvMovimientosAlmacen
GO
ALTER TABLE dbo.CabAplFor
	DROP CONSTRAINT FK_CabAplFor_MInvMovimientosAlmacen1
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MInvMovimientosAlmacen', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MInvMovimientosAlmacen', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MInvMovimientosAlmacen', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.CabAplFor
	DROP CONSTRAINT DF_CabAplFor_Fol_Mov
GO
ALTER TABLE dbo.CabAplFor
	DROP CONSTRAINT DF_CabAplFor_Fec_AplF
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
	IdAlmacen int NOT NULL,
	TotalServidas int NOT NULL
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
	 EXEC('INSERT INTO dbo.Tmp_CabAplFor (Fol_AplF, FechaAplicacion, FechaContabilizacion, Fol_Poliza, Costo, IdUsuarioAlta, IdUsuarioCancelacion, FechaCaptura, FechaCancelacion, Estatus, Cabezas, FolioMovimientoAlmacen, FolioMovimientoAlmacenCancelacion, IdAlmacen)
		SELECT Fol_AplF, FechaAplicacion, FechaContabilizacion, Fol_Poliza, Costo, IdUsuarioAlta, IdUsuarioCancelacion, FechaCaptura, FechaCancelacion, Estatus, Cabezas, FolioMovimientoAlmacen, FolioMovimientoAlmacenCancelacion, IdAlmacen FROM dbo.CabAplFor WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.DetAplFor
	DROP CONSTRAINT FK_DetAplFor_CabAplFor
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
COMMIT
select Has_Perms_By_Name(N'dbo.DetAplFor', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.DetAplFor', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.DetAplFor', 'Object', 'CONTROL') as Contr_Per 