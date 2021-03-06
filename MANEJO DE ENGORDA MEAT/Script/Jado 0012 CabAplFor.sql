/*
   Jueves, 15 de Octubre de 200909:53:15 a.m.
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
select Has_Perms_By_Name(N'dbo.MCatAlmacenes', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MCatAlmacenes', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MCatAlmacenes', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.CabAplFor ADD CONSTRAINT
	FK_CabAplFor_MCatAlmacenes FOREIGN KEY
	(
	IdAlmacen
	) REFERENCES dbo.MCatAlmacenes
	(
	Codigo
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.CabAplFor', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.CabAplFor', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.CabAplFor', 'Object', 'CONTROL') as Contr_Per 