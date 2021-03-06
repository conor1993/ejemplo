/*
   Miércoles, 07 de Octubre de 200906:58:35 p.m.
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
ALTER TABLE dbo.MCatCompProductosMezclas
	DROP CONSTRAINT FK_MCatCompProductosMezclas_MCatCompProductos
GO
ALTER TABLE dbo.MCatCompProductosMezclas
	DROP CONSTRAINT FK_MCatCompProductosMezclas_MCatCompProductos1
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MCatCompProductos', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MCatCompProductos', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MCatCompProductos', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_MCatCompProductosMezclas
	(
	PdIdProducto int NOT NULL,
	PdIdIngrediente int NOT NULL,
	PdPorcentaje decimal(18, 4) NOT NULL
	)  ON [PRIMARY]
GO
IF EXISTS(SELECT * FROM dbo.MCatCompProductosMezclas)
	 EXEC('INSERT INTO dbo.Tmp_MCatCompProductosMezclas (PdIdProducto, PdIdIngrediente, PdPorcentaje)
		SELECT PdIdProducto, PdIdIngrediente, PdPorcentaje FROM dbo.MCatCompProductosMezclas WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.MCatCompProductosMezclas
GO
EXECUTE sp_rename N'dbo.Tmp_MCatCompProductosMezclas', N'MCatCompProductosMezclas', 'OBJECT' 
GO
ALTER TABLE dbo.MCatCompProductosMezclas ADD CONSTRAINT
	PK_MCatCompProductosMezclas PRIMARY KEY CLUSTERED 
	(
	PdIdProducto,
	PdIdIngrediente
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.MCatCompProductosMezclas WITH NOCHECK ADD CONSTRAINT
	FK_MCatCompProductosMezclas_MCatCompProductos FOREIGN KEY
	(
	PdIdProducto
	) REFERENCES dbo.MCatCompProductos
	(
	PdIdProducto
	) ON UPDATE  NO ACTION 
	 ON DELETE  CASCADE 
	 NOT FOR REPLICATION

GO
ALTER TABLE dbo.MCatCompProductosMezclas WITH NOCHECK ADD CONSTRAINT
	FK_MCatCompProductosMezclas_MCatCompProductos1 FOREIGN KEY
	(
	PdIdIngrediente
	) REFERENCES dbo.MCatCompProductos
	(
	PdIdProducto
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	 NOT FOR REPLICATION

GO
ALTER TABLE dbo.MCatCompProductosMezclas
	NOCHECK CONSTRAINT FK_MCatCompProductosMezclas_MCatCompProductos1
GO
COMMIT
select Has_Perms_By_Name(N'dbo.MCatCompProductosMezclas', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.MCatCompProductosMezclas', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.MCatCompProductosMezclas', 'Object', 'CONTROL') as Contr_Per 