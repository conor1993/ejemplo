/*
   Domingo, 11 de Octubre de 200908:59:05 a.m.
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
ALTER TABLE dbo.MCGCatConcepGastos
	DROP CONSTRAINT DF_MCGCatConcepGastos_NombreConcepto
GO
ALTER TABLE dbo.MCGCatConcepGastos
	DROP CONSTRAINT DF_MCGCatConcepGastos_NomCorConcepto
GO
ALTER TABLE dbo.MCGCatConcepGastos
	DROP CONSTRAINT DF_MCGCatConcepGastos_AplicaIva
GO
ALTER TABLE dbo.MCGCatConcepGastos
	DROP CONSTRAINT DF_MCGCatConcepGastos_PorcentajeIva
GO
ALTER TABLE dbo.MCGCatConcepGastos
	DROP CONSTRAINT DF_MCGCatConcepGastos_Observaciones
GO
ALTER TABLE dbo.MCGCatConcepGastos
	DROP CONSTRAINT DF_MCGCatConcepGastos_Estatus
GO
CREATE TABLE dbo.Tmp_MCGCatConcepGastos
	(
	IdConceptoGasto int NOT NULL IDENTITY (1, 1),
	Descripcion varchar(60) NOT NULL,
	DescCorta varchar(6) NOT NULL,
	AplicaIva bit NOT NULL,
	PorcentajeIva money NOT NULL,
	Observaciones varchar(250) NULL,
	Estatus smallint NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_MCGCatConcepGastos ADD CONSTRAINT
	DF_MCGCatConcepGastos_NombreConcepto DEFAULT ('') FOR Descripcion
GO
ALTER TABLE dbo.Tmp_MCGCatConcepGastos ADD CONSTRAINT
	DF_MCGCatConcepGastos_NomCorConcepto DEFAULT ('') FOR DescCorta
GO
ALTER TABLE dbo.Tmp_MCGCatConcepGastos ADD CONSTRAINT
	DF_MCGCatConcepGastos_AplicaIva DEFAULT ('') FOR AplicaIva
GO
ALTER TABLE dbo.Tmp_MCGCatConcepGastos ADD CONSTRAINT
	DF_MCGCatConcepGastos_PorcentajeIva DEFAULT ((0)) FOR PorcentajeIva
GO
ALTER TABLE dbo.Tmp_MCGCatConcepGastos ADD CONSTRAINT
	DF_MCGCatConcepGastos_Observaciones DEFAULT ('') FOR Observaciones
GO
ALTER TABLE dbo.Tmp_MCGCatConcepGastos ADD CONSTRAINT
	DF_MCGCatConcepGastos_Estatus DEFAULT ((1)) FOR Estatus
GO
SET IDENTITY_INSERT dbo.Tmp_MCGCatConcepGastos ON
GO
IF EXISTS(SELECT * FROM dbo.MCGCatConcepGastos)
	 EXEC('INSERT INTO dbo.Tmp_MCGCatConcepGastos (IdConceptoGasto, Descripcion, DescCorta, AplicaIva, PorcentajeIva, Observaciones, Estatus)
		SELECT IdConceptoGasto, NombreConcepto, CONVERT(varchar(6), NomCorConcepto), AplicaIva, PorcentajeIva, Observaciones, Estatus FROM dbo.MCGCatConcepGastos WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_MCGCatConcepGastos OFF
GO
ALTER TABLE dbo.DetGasTrans
	DROP CONSTRAINT FK_DetGasTrans_MCGCatConcepGastos
GO
DROP TABLE dbo.MCGCatConcepGastos
GO
EXECUTE sp_rename N'dbo.Tmp_MCGCatConcepGastos', N'MCGCatConcepGastos', 'OBJECT' 
GO
ALTER TABLE dbo.MCGCatConcepGastos ADD CONSTRAINT
	PK_MCGCatConcepGastos PRIMARY KEY CLUSTERED 
	(
	IdConceptoGasto
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.MCGCatConcepGastos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MCGCatConcepGastos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MCGCatConcepGastos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.DetGasTrans ADD CONSTRAINT
	FK_DetGasTrans_MCGCatConcepGastos FOREIGN KEY
	(
	Cve_Gasto
	) REFERENCES dbo.MCGCatConcepGastos
	(
	IdConceptoGasto
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.DetGasTrans', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.DetGasTrans', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.DetGasTrans', 'Object', 'CONTROL') as Contr_Per 