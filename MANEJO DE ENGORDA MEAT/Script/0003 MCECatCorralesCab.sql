/*
   Domingo, 11 de Octubre de 200908:31:14 a.m.
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
ALTER TABLE dbo.MCECatCorralesCab
	DROP CONSTRAINT DF_MCECatCorralesCab_NombreCorral
GO
ALTER TABLE dbo.MCECatCorralesCab
	DROP CONSTRAINT DF_MCECatCorralesCab_NomCorCorral
GO
ALTER TABLE dbo.MCECatCorralesCab
	DROP CONSTRAINT DF_MCECatCorralesCab_IdTipoCorral
GO
ALTER TABLE dbo.MCECatCorralesCab
	DROP CONSTRAINT DF_MCECatCorralesCab_Capacidad
GO
ALTER TABLE dbo.MCECatCorralesCab
	DROP CONSTRAINT DF_MCECatCorralesCab_Superficie
GO
ALTER TABLE dbo.MCECatCorralesCab
	DROP CONSTRAINT DF_MCECatCorralesCab_Observaciones
GO
ALTER TABLE dbo.MCECatCorralesCab
	DROP CONSTRAINT DF_MCECatCorralesCab_Estatus
GO
ALTER TABLE dbo.MCECatCorralesCab
	DROP CONSTRAINT DF_MCECatCorralesCab_FechaBaja
GO
ALTER TABLE dbo.MCECatCorralesCab
	DROP CONSTRAINT DF_MCECatCorralesCab_MotivoBaja
GO
ALTER TABLE dbo.MCECatCorralesCab
	DROP CONSTRAINT DF_MCECatCorralesCab_QuiendioBaja
GO
CREATE TABLE dbo.Tmp_MCECatCorralesCab
	(
	IdCorral varchar(5) NOT NULL,
	NombreCorral varchar(100) NOT NULL,
	NomCorCorral varchar(50) NOT NULL,
	IdTipoCorral int NOT NULL,
	Capacidad money NOT NULL,
	Superficie money NOT NULL,
	Observaciones varchar(250) NOT NULL,
	Estatus smallint NOT NULL,
	FechaBaja datetime NOT NULL,
	MotivoBaja varchar(250) NOT NULL,
	QuiendioBaja int NOT NULL,
	TipoCorral smallint NOT NULL
	)  ON [PRIMARY]
GO
DECLARE @v sql_variant 
SET @v = N'1=Engorda, 2=Enfermeria, 3=Reciba'
EXECUTE sp_addextendedproperty N'MS_Description', @v, N'SCHEMA', N'dbo', N'TABLE', N'Tmp_MCECatCorralesCab', N'COLUMN', N'TipoCorral'
GO
ALTER TABLE dbo.Tmp_MCECatCorralesCab ADD CONSTRAINT
	DF_MCECatCorralesCab_NombreCorral DEFAULT ('') FOR NombreCorral
GO
ALTER TABLE dbo.Tmp_MCECatCorralesCab ADD CONSTRAINT
	DF_MCECatCorralesCab_NomCorCorral DEFAULT ('''') FOR NomCorCorral
GO
ALTER TABLE dbo.Tmp_MCECatCorralesCab ADD CONSTRAINT
	DF_MCECatCorralesCab_IdTipoCorral DEFAULT ((0)) FOR IdTipoCorral
GO
ALTER TABLE dbo.Tmp_MCECatCorralesCab ADD CONSTRAINT
	DF_MCECatCorralesCab_Capacidad DEFAULT ((0)) FOR Capacidad
GO
ALTER TABLE dbo.Tmp_MCECatCorralesCab ADD CONSTRAINT
	DF_MCECatCorralesCab_Superficie DEFAULT ((0)) FOR Superficie
GO
ALTER TABLE dbo.Tmp_MCECatCorralesCab ADD CONSTRAINT
	DF_MCECatCorralesCab_Observaciones DEFAULT ('') FOR Observaciones
GO
ALTER TABLE dbo.Tmp_MCECatCorralesCab ADD CONSTRAINT
	DF_MCECatCorralesCab_Estatus DEFAULT ((1)) FOR Estatus
GO
ALTER TABLE dbo.Tmp_MCECatCorralesCab ADD CONSTRAINT
	DF_MCECatCorralesCab_FechaBaja DEFAULT ('1900-01-01') FOR FechaBaja
GO
ALTER TABLE dbo.Tmp_MCECatCorralesCab ADD CONSTRAINT
	DF_MCECatCorralesCab_MotivoBaja DEFAULT ('') FOR MotivoBaja
GO
ALTER TABLE dbo.Tmp_MCECatCorralesCab ADD CONSTRAINT
	DF_MCECatCorralesCab_QuiendioBaja DEFAULT ((0)) FOR QuiendioBaja
GO
ALTER TABLE dbo.Tmp_MCECatCorralesCab ADD CONSTRAINT
	DF_MCECatCorralesCab_TipoCorral_1 DEFAULT ((1)) FOR TipoCorral
GO
IF EXISTS(SELECT * FROM dbo.MCECatCorralesCab)
	 EXEC('INSERT INTO dbo.Tmp_MCECatCorralesCab (IdCorral, NombreCorral, NomCorCorral, IdTipoCorral, Capacidad, Superficie, Observaciones, Estatus, FechaBaja, MotivoBaja, QuiendioBaja)
		SELECT CONVERT(varchar(5), IdCorral), NombreCorral, NomCorCorral, IdTipoCorral, Capacidad, Superficie, Observaciones, Estatus, FechaBaja, MotivoBaja, QuiendioBaja FROM dbo.MCECatCorralesCab WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.MCECatCorralesCab
GO
EXECUTE sp_rename N'dbo.Tmp_MCECatCorralesCab', N'MCECatCorralesCab', 'OBJECT' 
GO
ALTER TABLE dbo.MCECatCorralesCab ADD CONSTRAINT
	PK_MCECatCorralesCab PRIMARY KEY CLUSTERED 
	(
	IdCorral
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.MCECatCorralesCab', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MCECatCorralesCab', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MCECatCorralesCab', 'Object', 'CONTROL') as Contr_Per 