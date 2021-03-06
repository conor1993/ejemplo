/*
   Viernes, 09 de Octubre de 200904:46:15 p.m.
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
ALTER TABLE dbo.CabPrepForm
	DROP CONSTRAINT FK_CabPrepForm_MInvMovimientosAlmacen
GO
ALTER TABLE dbo.CabPrepForm
	DROP CONSTRAINT FK_CabPrepForm_MInvMovimientosAlmacen1
GO
ALTER TABLE dbo.CabPrepForm
	DROP CONSTRAINT FK_CabPrepForm_MInvMovimientosAlmacen2
GO
ALTER TABLE dbo.CabPrepForm
	DROP CONSTRAINT FK_CabPrepForm_MInvMovimientosAlmacen3
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MInvMovimientosAlmacen', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MInvMovimientosAlmacen', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MInvMovimientosAlmacen', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.CabPrepForm
	DROP CONSTRAINT FK_CabPrepForm_MCatGenPlazas
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MCatGenPlazas', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MCatGenPlazas', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MCatGenPlazas', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.CabPrepForm
	DROP CONSTRAINT FK_CabPrepForm_MCatCompProductos
GO
ALTER TABLE dbo.CabPrepForm
	DROP CONSTRAINT FK_CabPrepForm_MCatCompProductos1
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MCatCompProductos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MCatCompProductos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MCatCompProductos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.CabPrepForm
	DROP CONSTRAINT FK_CabPrepForm_MCatAlmacenes
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MCatAlmacenes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MCatAlmacenes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MCatAlmacenes', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_CabPrepForm
	(
	Fol_PrepForm char(8) NOT NULL,
	IdPlaza int NOT NULL,
	Fec_PrepForm datetime NOT NULL,
	Cve_Almacen int NOT NULL,
	Cve_Formula int NOT NULL,
	CantaPreparar money NOT NULL,
	CantRealaPrep money NOT NULL,
	Cve_MovAlm char(2) NULL,
	CostoTotal money NOT NULL,
	Observaciones varchar(250) NULL,
	Fec_Conta datetime NULL,
	NumPoliza char(8) NULL,
	Fec_Cancela datetime NULL,
	RefCancela char(11) NULL,
	Estatus smallint NOT NULL,
	FolioMovimientoAlmacenEntradaFormula varchar(20) NOT NULL,
	FolioMovimientoAlmacenCancelacionEntradaFormula varchar(20) NULL,
	IdEnvase int NULL,
	FolioMovimientoAlmacenSalidaIngredientes varchar(20) NOT NULL,
	FolioMovimientoAlmacenCancelacionSalidaIngredientes varchar(20) NULL,
	CantidadEnvase int NOT NULL,
	Lote varchar(15) NULL,
	FechaCaducidad datetime NULL,
	IdUsuarioAlta int NOT NULL,
	IdUsuarioCancelacion int NULL
	)  ON [PRIMARY]
GO
IF EXISTS(SELECT * FROM dbo.CabPrepForm)
	 EXEC('INSERT INTO dbo.Tmp_CabPrepForm (Fol_PrepForm, IdPlaza, Fec_PrepForm, Cve_Almacen, Cve_Formula, CantaPreparar, CantRealaPrep, Cve_MovAlm, CostoTotal, Observaciones, Fec_Conta, NumPoliza, Fec_Cancela, RefCancela, Estatus, FolioMovimientoAlmacenEntradaFormula, FolioMovimientoAlmacenCancelacionEntradaFormula, IdEnvase, FolioMovimientoAlmacenSalidaIngredientes, FolioMovimientoAlmacenCancelacionSalidaIngredientes, CantidadEnvase, Lote, FechaCaducidad, IdUsuarioAlta, IdUsuarioCancelacion)
		SELECT Fol_PrepForm, IdPlaza, Fec_PrepForm, Cve_Almacen, Cve_Formula, CantaPreparar, CantRealaPrep, Cve_MovAlm, CostoTotal, Observaciones, Fec_Conta, NumPoliza, Fec_Cancela, RefCancela, Estatus, FolioMovimientoAlmacenEntradaFormula, FolioMovimientoAlmacenCancelacionEntradaFormula, IdEnvase, FolioMovimientoAlmacenSalidaIngredientes, FolioMovimientoAlmacenCancelacionSalidaIngredientes, CantidadEnvase, Lote, FechaCaducidad, IdUsuarioAlta, IdUsuarioCancelacion FROM dbo.CabPrepForm WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.DetPrepFormLote
	DROP CONSTRAINT FK_DetPrepFormLote_CabPrepForm
GO
ALTER TABLE dbo.DetPrepForm
	DROP CONSTRAINT FK_DetPrepForm_CabPrepForm
GO
DROP TABLE dbo.CabPrepForm
GO
EXECUTE sp_rename N'dbo.Tmp_CabPrepForm', N'CabPrepForm', 'OBJECT' 
GO
ALTER TABLE dbo.CabPrepForm ADD CONSTRAINT
	PK___2__26 PRIMARY KEY CLUSTERED 
	(
	Fol_PrepForm,
	IdPlaza
	) WITH( PAD_INDEX = OFF, FILLFACTOR = 90, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.CabPrepForm ADD CONSTRAINT
	FK_CabPrepForm_MCatAlmacenes FOREIGN KEY
	(
	Cve_Almacen
	) REFERENCES dbo.MCatAlmacenes
	(
	Codigo
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.CabPrepForm ADD CONSTRAINT
	FK_CabPrepForm_MCatCompProductos FOREIGN KEY
	(
	Cve_Formula
	) REFERENCES dbo.MCatCompProductos
	(
	PdIdProducto
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.CabPrepForm WITH NOCHECK ADD CONSTRAINT
	FK_CabPrepForm_MCatCompProductos1 FOREIGN KEY
	(
	IdEnvase
	) REFERENCES dbo.MCatCompProductos
	(
	PdIdProducto
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	 NOT FOR REPLICATION

GO
ALTER TABLE dbo.CabPrepForm
	NOCHECK CONSTRAINT FK_CabPrepForm_MCatCompProductos1
GO
ALTER TABLE dbo.CabPrepForm ADD CONSTRAINT
	FK_CabPrepForm_MCatGenPlazas FOREIGN KEY
	(
	IdPlaza
	) REFERENCES dbo.MCatGenPlazas
	(
	PLIdPlaza
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.CabPrepForm ADD CONSTRAINT
	FK_CabPrepForm_MInvMovimientosAlmacen FOREIGN KEY
	(
	Cve_Almacen,
	FolioMovimientoAlmacenEntradaFormula
	) REFERENCES dbo.MInvMovimientosAlmacen
	(
	AlmacenId,
	FolioMovimiento
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.CabPrepForm WITH NOCHECK ADD CONSTRAINT
	FK_CabPrepForm_MInvMovimientosAlmacen1 FOREIGN KEY
	(
	Cve_Almacen,
	FolioMovimientoAlmacenCancelacionEntradaFormula
	) REFERENCES dbo.MInvMovimientosAlmacen
	(
	AlmacenId,
	FolioMovimiento
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	 NOT FOR REPLICATION

GO
ALTER TABLE dbo.CabPrepForm
	NOCHECK CONSTRAINT FK_CabPrepForm_MInvMovimientosAlmacen1
GO
ALTER TABLE dbo.CabPrepForm ADD CONSTRAINT
	FK_CabPrepForm_MInvMovimientosAlmacen2 FOREIGN KEY
	(
	Cve_Almacen,
	FolioMovimientoAlmacenSalidaIngredientes
	) REFERENCES dbo.MInvMovimientosAlmacen
	(
	AlmacenId,
	FolioMovimiento
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.CabPrepForm WITH NOCHECK ADD CONSTRAINT
	FK_CabPrepForm_MInvMovimientosAlmacen3 FOREIGN KEY
	(
	Cve_Almacen,
	FolioMovimientoAlmacenCancelacionSalidaIngredientes
	) REFERENCES dbo.MInvMovimientosAlmacen
	(
	AlmacenId,
	FolioMovimiento
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	 NOT FOR REPLICATION

GO
ALTER TABLE dbo.CabPrepForm
	NOCHECK CONSTRAINT FK_CabPrepForm_MInvMovimientosAlmacen3
GO
COMMIT
select Has_Perms_By_Name(N'dbo.CabPrepForm', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.CabPrepForm', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.CabPrepForm', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.DetPrepForm ADD CONSTRAINT
	FK_DetPrepForm_CabPrepForm FOREIGN KEY
	(
	Fol_PrepForm,
	IdPlaza
	) REFERENCES dbo.CabPrepForm
	(
	Fol_PrepForm,
	IdPlaza
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.DetPrepForm', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.DetPrepForm', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.DetPrepForm', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.DetPrepFormLote ADD CONSTRAINT
	FK_DetPrepFormLote_CabPrepForm FOREIGN KEY
	(
	Fol_PrepForm,
	IdPlaza
	) REFERENCES dbo.CabPrepForm
	(
	Fol_PrepForm,
	IdPlaza
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.DetPrepFormLote', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.DetPrepFormLote', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.DetPrepFormLote', 'Object', 'CONTROL') as Contr_Per 