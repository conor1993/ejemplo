/*
   Jueves, 01 de Octubre de 200912:20:42 p.m.
   Usuario: sa
   Servidor: INTEGRA05\ALFREDODIAZ
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
ALTER TABLE dbo.FacturasClientesDetProductosTotales ADD
	PrecioKgrReal money NOT NULL CONSTRAINT DF_FacturasClientesDetProductosTotales_PrecioKgrReal_1 DEFAULT ((0)),
	IdUsuarioAutorizacionCambioPrecio int NULL,
	Piezas int NOT NULL CONSTRAINT DF_FacturasClientesDetProductosTotales_Piezas_1 DEFAULT ((0))
GO
COMMIT
select Has_Perms_By_Name(N'dbo.FacturasClientesDetProductosTotales', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.FacturasClientesDetProductosTotales', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.FacturasClientesDetProductosTotales', 'Object', 'CONTROL') as Contr_Per 