/*
   Jueves, 22 de Octubre de 200905:31:25 p.m.
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
ALTER TABLE dbo.DetAplFor ADD
	LoteAlmacen varchar(15) NULL
GO
COMMIT
select Has_Perms_By_Name(N'dbo.DetAplFor', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.DetAplFor', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.DetAplFor', 'Object', 'CONTROL') as Contr_Per 