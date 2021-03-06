/*
   Domingo, 11 de Octubre de 200909:03:57 a.m.
   Usuario: sa
   Servidor: 192.168.0.13\SQLEXPRESS
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
COMMIT
select Has_Perms_By_Name(N'dbo.MCatGenPoblaciones', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MCatGenPoblaciones', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MCatGenPoblaciones', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.MCGCatCompradoresdeGanado
	DROP CONSTRAINT DF_MCGCatCompradoresdeGanado_Nombre
GO
ALTER TABLE dbo.MCGCatCompradoresdeGanado
	DROP CONSTRAINT DF_MCGCatCompradoresdeGanado_ApellidoPaterno
GO
ALTER TABLE dbo.MCGCatCompradoresdeGanado
	DROP CONSTRAINT DF_MCGCatCompradoresdeGanado_ApellidoMaterno
GO
ALTER TABLE dbo.MCGCatCompradoresdeGanado
	DROP CONSTRAINT DF_MCGCatCompradoresdeGanado_RFC
GO
ALTER TABLE dbo.MCGCatCompradoresdeGanado
	DROP CONSTRAINT DF_MCGCatCompradoresdeGanado_CalleyNumero
GO
ALTER TABLE dbo.MCGCatCompradoresdeGanado
	DROP CONSTRAINT DF_MCGCatCompradoresdeGanado_Colonia
GO
ALTER TABLE dbo.MCGCatCompradoresdeGanado
	DROP CONSTRAINT DF_MCGCatCompradoresdeGanado_Estado
GO
ALTER TABLE dbo.MCGCatCompradoresdeGanado
	DROP CONSTRAINT DF_MCGCatCompradoresdeGanado_Ciudad
GO
ALTER TABLE dbo.MCGCatCompradoresdeGanado
	DROP CONSTRAINT DF_MCGCatCompradoresdeGanado_Poblacion
GO
ALTER TABLE dbo.MCGCatCompradoresdeGanado
	DROP CONSTRAINT DF_MCGCatCompradoresdeGanado_PagarComision
GO
ALTER TABLE dbo.MCGCatCompradoresdeGanado
	DROP CONSTRAINT DF_MCGCatCompradoresdeGanado_ComisionxCabeza
GO
ALTER TABLE dbo.MCGCatCompradoresdeGanado
	DROP CONSTRAINT DF_MCGCatCompradoresdeGanado_CtaMay
GO
ALTER TABLE dbo.MCGCatCompradoresdeGanado
	DROP CONSTRAINT DF_MCGCatCompradoresdeGanado_SubCta
GO
ALTER TABLE dbo.MCGCatCompradoresdeGanado
	DROP CONSTRAINT DF_MCGCatCompradoresdeGanado_SsbCta
GO
ALTER TABLE dbo.MCGCatCompradoresdeGanado
	DROP CONSTRAINT DF_MCGCatCompradoresdeGanado_SssCta
GO
ALTER TABLE dbo.MCGCatCompradoresdeGanado
	DROP CONSTRAINT DF_MCGCatCompradoresdeGanado_Estatus
GO
ALTER TABLE dbo.MCGCatCompradoresdeGanado
	DROP CONSTRAINT DF_MCGCatCompradoresdeGanado_FechaAlta
GO
ALTER TABLE dbo.MCGCatCompradoresdeGanado
	DROP CONSTRAINT DF_MCGCatCompradoresdeGanado_FechaBaja
GO
CREATE TABLE dbo.Tmp_MCGCatCompradoresdeGanado
	(
	IdComprador int NOT NULL IDENTITY (1, 1),
	Nombre varchar(40) NOT NULL,
	ApellidoPaterno varchar(20) NOT NULL,
	ApellidoMaterno varchar(20) NOT NULL,
	RFC char(15) NOT NULL,
	CalleyNumero varchar(120) NOT NULL,
	Colonia varchar(60) NOT NULL,
	IdPoblacion int NOT NULL,
	PagarComision bit NOT NULL,
	ComisionxCabeza smallmoney NOT NULL,
	Estatus smallint NOT NULL,
	FechaAlta datetime NOT NULL,
	FechaBaja datetime NOT NULL,
	IdCuentaContable int NOT NULL,
	ComisionXKilo decimal(18, 3) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_MCGCatCompradoresdeGanado ADD CONSTRAINT
	DF_MCGCatCompradoresdeGanado_Nombre DEFAULT ('') FOR Nombre
GO
ALTER TABLE dbo.Tmp_MCGCatCompradoresdeGanado ADD CONSTRAINT
	DF_MCGCatCompradoresdeGanado_ApellidoPaterno DEFAULT ('') FOR ApellidoPaterno
GO
ALTER TABLE dbo.Tmp_MCGCatCompradoresdeGanado ADD CONSTRAINT
	DF_MCGCatCompradoresdeGanado_ApellidoMaterno DEFAULT ('') FOR ApellidoMaterno
GO
ALTER TABLE dbo.Tmp_MCGCatCompradoresdeGanado ADD CONSTRAINT
	DF_MCGCatCompradoresdeGanado_RFC DEFAULT ('') FOR RFC
GO
ALTER TABLE dbo.Tmp_MCGCatCompradoresdeGanado ADD CONSTRAINT
	DF_MCGCatCompradoresdeGanado_CalleyNumero DEFAULT ('') FOR CalleyNumero
GO
ALTER TABLE dbo.Tmp_MCGCatCompradoresdeGanado ADD CONSTRAINT
	DF_MCGCatCompradoresdeGanado_Colonia DEFAULT ('') FOR Colonia
GO
ALTER TABLE dbo.Tmp_MCGCatCompradoresdeGanado ADD CONSTRAINT
	DF_MCGCatCompradoresdeGanado_Poblacion DEFAULT ((0)) FOR IdPoblacion
GO
ALTER TABLE dbo.Tmp_MCGCatCompradoresdeGanado ADD CONSTRAINT
	DF_MCGCatCompradoresdeGanado_PagarComision DEFAULT ((0)) FOR PagarComision
GO
ALTER TABLE dbo.Tmp_MCGCatCompradoresdeGanado ADD CONSTRAINT
	DF_MCGCatCompradoresdeGanado_ComisionxCabeza DEFAULT ((0)) FOR ComisionxCabeza
GO
ALTER TABLE dbo.Tmp_MCGCatCompradoresdeGanado ADD CONSTRAINT
	DF_MCGCatCompradoresdeGanado_Estatus DEFAULT ('V') FOR Estatus
GO
ALTER TABLE dbo.Tmp_MCGCatCompradoresdeGanado ADD CONSTRAINT
	DF_MCGCatCompradoresdeGanado_FechaAlta DEFAULT ('01-01-1900') FOR FechaAlta
GO
ALTER TABLE dbo.Tmp_MCGCatCompradoresdeGanado ADD CONSTRAINT
	DF_MCGCatCompradoresdeGanado_FechaBaja DEFAULT ('01-01-1900') FOR FechaBaja
GO
ALTER TABLE dbo.Tmp_MCGCatCompradoresdeGanado ADD CONSTRAINT
	DF_MCGCatCompradoresdeGanado_ComisionXKilo_1 DEFAULT ((0)) FOR ComisionXKilo
GO
SET IDENTITY_INSERT dbo.Tmp_MCGCatCompradoresdeGanado ON
GO
IF EXISTS(SELECT * FROM dbo.MCGCatCompradoresdeGanado)
	 EXEC('INSERT INTO dbo.Tmp_MCGCatCompradoresdeGanado (IdComprador, Nombre, ApellidoPaterno, ApellidoMaterno, RFC, CalleyNumero, Colonia, IdPoblacion, PagarComision, ComisionxCabeza, Estatus, FechaAlta, FechaBaja)
		SELECT IdComprador, Nombre, ApellidoPaterno, ApellidoMaterno, RFC, CalleyNumero, Colonia, IdPoblacion, PagarComision, ComisionxCabeza, CONVERT(smallint, Estatus), FechaAlta, FechaBaja FROM dbo.MCGCatCompradoresdeGanado WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_MCGCatCompradoresdeGanado OFF
GO
ALTER TABLE dbo.CabRegCom
	DROP CONSTRAINT FK_CabRegCom_MCGCatCompradoresdeGanado
GO
DROP TABLE dbo.MCGCatCompradoresdeGanado
GO
EXECUTE sp_rename N'dbo.Tmp_MCGCatCompradoresdeGanado', N'MCGCatCompradoresdeGanado', 'OBJECT' 
GO
ALTER TABLE dbo.MCGCatCompradoresdeGanado ADD CONSTRAINT
	PK_MCGCatCompradoresdeGanado PRIMARY KEY CLUSTERED 
	(
	IdComprador
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.MCGCatCompradoresdeGanado ADD CONSTRAINT
	FK_MCGCatCompradoresdeGanado_MCatGenPoblaciones FOREIGN KEY
	(
	IdPoblacion
	) REFERENCES dbo.MCatGenPoblaciones
	(
	PIdPoblacion
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MCGCatCompradoresdeGanado', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MCGCatCompradoresdeGanado', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MCGCatCompradoresdeGanado', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.CabRegCom ADD CONSTRAINT
	FK_CabRegCom_MCGCatCompradoresdeGanado FOREIGN KEY
	(
	Cve_ComiGan
	) REFERENCES dbo.MCGCatCompradoresdeGanado
	(
	IdComprador
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.CabRegCom', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.CabRegCom', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.CabRegCom', 'Object', 'CONTROL') as Contr_Per 