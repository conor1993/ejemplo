/*
   Martes, 29 de Septiembre de 200901:00:05 p.m.
   Usuario: sa
   Servidor: INTEGRA05\ALFREDODIAZ
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
EXECUTE sp_rename N'dbo.usrSistAutorizaProcesos.CancelaContratoCompra', N'Tmp_CambiarPrecioFacturacion', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.usrSistAutorizaProcesos.CancelaFactura', N'Tmp_CancelarFactura_1', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.usrSistAutorizaProcesos.Tmp_CambiarPrecioFacturacion', N'CambiarPrecioFacturacion', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.usrSistAutorizaProcesos.Tmp_CancelarFactura_1', N'CancelarFactura', 'COLUMN' 
GO
ALTER TABLE dbo.usrSistAutorizaProcesos
	DROP CONSTRAINT DF_usrSistAutorizaProcesos_CambiarPrecio
GO
ALTER TABLE dbo.usrSistAutorizaProcesos
	DROP COLUMN CancelaContratoVenta, CancelaOrdenRetiro, CancelaOtrosProcesos, CambiaUbicacion, Contraseña, CambiarPrecio
GO
COMMIT
select Has_Perms_By_Name(N'dbo.usrSistAutorizaProcesos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.usrSistAutorizaProcesos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.usrSistAutorizaProcesos', 'Object', 'CONTROL') as Contr_Per 