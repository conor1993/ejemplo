/*
   Viernes, 23 de Octubre de 200905:58:32 p.m.
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
ALTER TABLE dbo.DetAplFor
	DROP CONSTRAINT FK_DetAplFor_MCECatLotesCab
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MCECatLotesCab', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MCECatLotesCab', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MCECatLotesCab', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.DetAplFor WITH NOCHECK ADD CONSTRAINT
	FK_DetAplFor_MCECatLotesCab FOREIGN KEY
	(
	Cve_Lote
	) REFERENCES dbo.MCECatLotesCab
	(
	IdLote
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	 NOT FOR REPLICATION

GO
ALTER TABLE dbo.DetAplFor
	NOCHECK CONSTRAINT FK_DetAplFor_MCECatLotesCab
GO
COMMIT
select Has_Perms_By_Name(N'dbo.DetAplFor', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.DetAplFor', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.DetAplFor', 'Object', 'CONTROL') as Contr_Per 