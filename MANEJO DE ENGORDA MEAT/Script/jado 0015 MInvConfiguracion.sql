/*
   Miércoles, 21 de Octubre de 200906:59:33 p.m.
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
ALTER TABLE dbo.MInvConfiguracion ADD
	EXMedicamento int NULL,
	EXProcesoGranoRolado int NULL,
	EXCancelacionSalidaGranoRolado int NULL,
	EXRegresoMedicamento int NULL,
	EXCancelacionAplicacionFormula int NULL,
	EXCancelacionAplicacionMedicamento int NULL,
	SXAplicacionFormula int NULL,
	SXAplicacionMedicamento int NULL,
	SXCancelacionEntradaMedicamento int NULL,
	SXCancelacionEntradaProcesoGranoRolado int NULL,
	SXProcesoGranoRolado int NULL,
	SXCancelacionRegresoMedicamento int NULL
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MInvConfiguracion', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MInvConfiguracion', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MInvConfiguracion', 'Object', 'CONTROL') as Contr_Per 