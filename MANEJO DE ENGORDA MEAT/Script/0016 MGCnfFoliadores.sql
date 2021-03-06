/*
   Lunes, 28 de Septiembre de 200903:44:51 p.m.
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
ALTER TABLE dbo.MGCnfFoliadores
	DROP CONSTRAINT DF_MGFoliadores_Consecutivo
GO
CREATE TABLE dbo.Tmp_MGCnfFoliadores
	(
	Codigo int NOT NULL,
	Año char(4) NOT NULL,
	Mes char(2) NOT NULL,
	IdAlmacen int NOT NULL,
	Consecutivo int NOT NULL
	)  ON [PRIMARY]
GO
DECLARE @v sql_variant 
SET @v = N'Si no se usa almacenes donde se ocupa llevar el control de folios se deja -1'
EXECUTE sp_addextendedproperty N'MS_Description', @v, N'SCHEMA', N'dbo', N'TABLE', N'Tmp_MGCnfFoliadores', N'COLUMN', N'IdAlmacen'
GO
ALTER TABLE dbo.Tmp_MGCnfFoliadores ADD CONSTRAINT
	DF_MGCnfFoliadores_IdAlmacen_1 DEFAULT -1 FOR IdAlmacen
GO
ALTER TABLE dbo.Tmp_MGCnfFoliadores ADD CONSTRAINT
	DF_MGFoliadores_Consecutivo DEFAULT (0) FOR Consecutivo
GO
IF EXISTS(SELECT * FROM dbo.MGCnfFoliadores)
	 EXEC('INSERT INTO dbo.Tmp_MGCnfFoliadores (Codigo, Año, Mes, Consecutivo)
		SELECT Codigo, Año, Mes, Consecutivo FROM dbo.MGCnfFoliadores WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.MGCnfFoliadores
GO
EXECUTE sp_rename N'dbo.Tmp_MGCnfFoliadores', N'MGCnfFoliadores', 'OBJECT' 
GO
ALTER TABLE dbo.MGCnfFoliadores ADD CONSTRAINT
	PK_MGFoliadores PRIMARY KEY CLUSTERED 
	(
	Codigo,
	Año,
	Mes,
	IdAlmacen
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.MGCnfFoliadores', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MGCnfFoliadores', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MGCnfFoliadores', 'Object', 'CONTROL') as Contr_Per 