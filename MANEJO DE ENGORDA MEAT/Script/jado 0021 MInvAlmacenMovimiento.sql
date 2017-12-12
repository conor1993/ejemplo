/*
   Jueves, 12 de Noviembre de 200906:58:38 p.m.
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
ALTER TABLE dbo.MInvMovimientosAlmacenDetalles ADD
	CantidadUsada decimal(18, 4) NOT NULL CONSTRAINT DF_MInvMovimientosAlmacenDetalles_CantidadUsada DEFAULT 0.0
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MInvMovimientosAlmacenDetalles', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MInvMovimientosAlmacenDetalles', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MInvMovimientosAlmacenDetalles', 'Object', 'CONTROL') as Contr_Per 