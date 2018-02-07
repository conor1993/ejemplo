' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 7 de febrero de 2018 11:23:26
' // Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
' // Templates vendor: Solutions Design.
' // Templates version: 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
Imports System

Imports Integralab.ORM
Imports Integralab.ORM.FactoryClasses
Imports Integralab.ORM.HelperClasses

Imports SD.LLBLGen.Pro.ORMSupportClasses

Namespace Integralab.ORM.RelationClasses
	''' <summary>
	''' Implements the Shared Relations variant for the entity: Producto.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class ProductoRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and AplicMediDetEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - AplicMediDet.IdMedicamento
		''' </summary>
		Public Overridable ReadOnly Property AplicMediDetEntityUsingIdMedicamento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(AplicMediDetFieldIndex.IdMedicamento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AplicMediDetEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and AplicMediDetDetEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - AplicMediDetDet.IdMedicamento
		''' </summary>
		Public Overridable ReadOnly Property AplicMediDetDetEntityUsingIdMedicamento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(AplicMediDetDetFieldIndex.IdMedicamento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AplicMediDetDetEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and CabPrepFormEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - CabPrepForm.CveFormula
		''' </summary>
		Public Overridable ReadOnly Property CabPrepFormEntityUsingCveFormula() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(CabPrepFormFieldIndex.CveFormula))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabPrepFormEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and CabPrepFormEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - CabPrepForm.IdEnvase
		''' </summary>
		Public Overridable ReadOnly Property CabPrepFormEntityUsingIdEnvase() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(CabPrepFormFieldIndex.IdEnvase))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabPrepFormEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and DetAlimentosEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - DetAlimentos.CveAlimento
		''' </summary>
		Public Overridable ReadOnly Property DetAlimentosEntityUsingCveAlimento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(DetAlimentosFieldIndex.CveAlimento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetAlimentosEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and DetalleKitPvEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - DetalleKitPv.IdKit
		''' </summary>
		Public Overridable ReadOnly Property DetalleKitPvEntityUsingIdKit() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(DetalleKitPvFieldIndex.IdKit))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetalleKitPvEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and DetalleKitPvEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - DetalleKitPv.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property DetalleKitPvEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(DetalleKitPvFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetalleKitPvEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and DetAplForEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - DetAplFor.CveFormula
		''' </summary>
		Public Overridable ReadOnly Property DetAplForEntityUsingCveFormula() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(DetAplForFieldIndex.CveFormula))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetAplForEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and DetDproMedEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - DetDproMed.IdMedicamento
		''' </summary>
		Public Overridable ReadOnly Property DetDproMedEntityUsingIdMedicamento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(DetDproMedFieldIndex.IdMedicamento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetDproMedEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and DetPrepFormEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - DetPrepForm.CveProducto
		''' </summary>
		Public Overridable ReadOnly Property DetPrepFormEntityUsingCveProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(DetPrepFormFieldIndex.CveProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetPrepFormEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and DetPrepFormLoteEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - DetPrepFormLote.CveProducto
		''' </summary>
		Public Overridable ReadOnly Property DetPrepFormLoteEntityUsingCveProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(DetPrepFormLoteFieldIndex.CveProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetPrepFormLoteEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and DetProMedEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - DetProMed.IdMedicamento
		''' </summary>
		Public Overridable ReadOnly Property DetProMedEntityUsingIdMedicamento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(DetProMedFieldIndex.IdMedicamento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetProMedEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and InvHistorialPvEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - InvHistorialPv.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property InvHistorialPvEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(InvHistorialPvFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InvHistorialPvEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and CostoProductoProveedorEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - CostoProductoProveedor.Producto
		''' </summary>
		Public Overridable ReadOnly Property CostoProductoProveedorEntityUsingProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(CostoProductoProveedorFieldIndex.Producto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CostoProductoProveedorEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and ProductoCostoIndirectoEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - ProductoCostoIndirecto.CodigoProducto
		''' </summary>
		Public Overridable ReadOnly Property ProductoCostoIndirectoEntityUsingCodigoProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(ProductoCostoIndirectoFieldIndex.CodigoProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoCostoIndirectoEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and ProductoMezclaEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - ProductoMezcla.CodigoProducto
		''' </summary>
		Public Overridable ReadOnly Property ProductoMezclaEntityUsingCodigoProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(ProductoMezclaFieldIndex.CodigoProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoMezclaEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and ProductoMezclaEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - ProductoMezcla.CodigoIngrediente
		''' </summary>
		Public Overridable ReadOnly Property ProductoMezclaEntityUsingCodigoIngrediente() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(ProductoMezclaFieldIndex.CodigoIngrediente))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoMezclaEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and ListaPrecioDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - ListaPrecioDetalle.Producto
		''' </summary>
		Public Overridable ReadOnly Property ListaPrecioDetalleEntityUsingProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(ListaPrecioDetalleFieldIndex.Producto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListaPrecioDetalleEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and McecatLotesCabForEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - McecatLotesCabFor.IdFormula
		''' </summary>
		Public Overridable ReadOnly Property McecatLotesCabForEntityUsingIdFormula() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(McecatLotesCabForFieldIndex.IdFormula))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McecatLotesCabForEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and McomCotizacionCompraProveedorDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - McomCotizacionCompraProveedorDetalle.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property McomCotizacionCompraProveedorDetalleEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(McomCotizacionCompraProveedorDetalleFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McomCotizacionCompraProveedorDetalleEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and OrdenCompraDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - OrdenCompraDetalle.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property OrdenCompraDetalleEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(OrdenCompraDetalleFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenCompraDetalleEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and PresupuestoCompraDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - PresupuestoCompraDetalle.ProductoId
		''' </summary>
		Public Overridable ReadOnly Property PresupuestoCompraDetalleEntityUsingProductoId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(PresupuestoCompraDetalleFieldIndex.ProductoId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PresupuestoCompraDetalleEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and McomRecepcionOrdenCompraDetEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - McomRecepcionOrdenCompraDet.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property McomRecepcionOrdenCompraDetEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(McomRecepcionOrdenCompraDetFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McomRecepcionOrdenCompraDetEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and SolicitudProductoDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - SolicitudProductoDetalle.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property SolicitudProductoDetalleEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(SolicitudProductoDetalleFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SolicitudProductoDetalleEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and InventarioAlmacenEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - InventarioAlmacen.ProductoId
		''' </summary>
		Public Overridable ReadOnly Property InventarioAlmacenEntityUsingProductoId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(InventarioAlmacenFieldIndex.ProductoId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioAlmacenEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and inventarioAlmacenLotesEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - inventarioAlmacenLotes.ProductoId
		''' </summary>
		Public Overridable ReadOnly Property inventarioAlmacenLotesEntityUsingProductoId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(inventarioAlmacenLotesFieldIndex.ProductoId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("inventarioAlmacenLotesEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and InventarioMovimientoAlmacenDetallesEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - InventarioMovimientoAlmacenDetalles.ProductoId
		''' </summary>
		Public Overridable ReadOnly Property InventarioMovimientoAlmacenDetallesEntityUsingProductoId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(InventarioMovimientoAlmacenDetallesFieldIndex.ProductoId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenDetallesEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and MinvMovimientosAlmacenPvdetallesEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - MinvMovimientosAlmacenPvdetalles.ProductoId
		''' </summary>
		Public Overridable ReadOnly Property MinvMovimientosAlmacenPvdetallesEntityUsingProductoId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(MinvMovimientosAlmacenPvdetallesFieldIndex.ProductoId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvMovimientosAlmacenPvdetallesEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and MinvTransferenciaAlmacenEntradaDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - MinvTransferenciaAlmacenEntradaDetalle.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property MinvTransferenciaAlmacenEntradaDetalleEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(MinvTransferenciaAlmacenEntradaDetalleFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenEntradaDetalleEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and MinvTransferenciaAlmacenSalidaDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - MinvTransferenciaAlmacenSalidaDetalle.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property MinvTransferenciaAlmacenSalidaDetalleEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(MinvTransferenciaAlmacenSalidaDetalleFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenSalidaDetalleEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and NotaVentaDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - NotaVentaDetalle.Producto
		''' </summary>
		Public Overridable ReadOnly Property NotaVentaDetalleEntityUsingProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(NotaVentaDetalleFieldIndex.Producto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NotaVentaDetalleEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and InventarioFisicoEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - InventarioFisico.ProductoId
		''' </summary>
		Public Overridable ReadOnly Property InventarioFisicoEntityUsingProductoId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(InventarioFisicoFieldIndex.ProductoId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioFisicoEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and UsrProdRecepcionDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' Producto.Codigo - UsrProdRecepcionDetalle.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property UsrProdRecepcionDetalleEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(UsrProdRecepcionDetalleFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrProdRecepcionDetalleEntity", False)
				Return relation
			End Get
		End Property
	
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and CabMediReimEntity over the 1:1 relation they have, using the relation between the fields:
		''' Producto.Codigo - CabMediReim.CveMedi
		''' </summary>
		Public Overridable  ReadOnly Property CabMediReimEntityUsingCveMedi() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne)
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(CabMediReimFieldIndex.CveMedi))



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabMediReimEntity", False)
				relation.StartEntityIsPkSide = True
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and CabMediTrabEntity over the 1:1 relation they have, using the relation between the fields:
		''' Producto.Codigo - CabMediTrab.CveMedi
		''' </summary>
		Public Overridable  ReadOnly Property CabMediTrabEntityUsingCveMedi() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne)
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(CabMediTrabFieldIndex.CveMedi))



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabMediTrabEntity", False)
				relation.StartEntityIsPkSide = True
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and CostoProductoEntity over the 1:1 relation they have, using the relation between the fields:
		''' Producto.Codigo - CostoProducto.ProductoId
		''' </summary>
		Public Overridable  ReadOnly Property CostoProductoEntityUsingProductoId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne)
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(CostoProductoFieldIndex.ProductoId))



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CostoProductoEntity", False)
				relation.StartEntityIsPkSide = True
				Return relation
			End Get
		End Property
	
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and LineaEntity over the m:1 relation they have, using the relation between the fields:
		''' Producto.PdIdLinea - Linea.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property LineaEntityUsingPdIdLinea() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(LineaFieldIndex.Codigo), EntityFieldFactory.Create(ProductoFieldIndex.PdIdLinea))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LineaEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and PresentacionEntity over the m:1 relation they have, using the relation between the fields:
		''' Producto.CodigoPresentacion - Presentacion.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property PresentacionEntityUsingCodigoPresentacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PresentacionFieldIndex.Codigo), EntityFieldFactory.Create(ProductoFieldIndex.CodigoPresentacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PresentacionEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and TipoProductoEntity over the m:1 relation they have, using the relation between the fields:
		''' Producto.CodigoTipoProducto - TipoProducto.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property TipoProductoEntityUsingCodigoTipoProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoProductoFieldIndex.Codigo), EntityFieldFactory.Create(ProductoFieldIndex.CodigoTipoProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoProductoEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and UnidadMedidaEntity over the m:1 relation they have, using the relation between the fields:
		''' Producto.CodigoUnidadMedida - UnidadMedida.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property UnidadMedidaEntityUsingCodigoUnidadMedida() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(UnidadMedidaFieldIndex.Codigo), EntityFieldFactory.Create(ProductoFieldIndex.CodigoUnidadMedida))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UnidadMedidaEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoEntity and MarcaEntity over the m:1 relation they have, using the relation between the fields:
		''' Producto.CodigoMarca - Marca.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property MarcaEntityUsingCodigoMarca() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MarcaFieldIndex.Codigo), EntityFieldFactory.Create(ProductoFieldIndex.CodigoMarca))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MarcaEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", True)
				Return relation
			End Get
		End Property
	
		
		''' <summary>stub, not used In this entity, only For TargetPerEntity entities.</summary>
		Public Overridable Function GetSubTypeRelation(subTypeEntityName As String) As IEntityRelation 
			Return Nothing
		End Function
		''' <summary>stub, not used In this entity, only For TargetPerEntity entities.</summary>
		Public Overridable Function GetSuperTypeRelation() As IEntityRelation 
			Return Nothing
		End Function

#End Region

#Region "Included Code"

#End Region
	End Class
End Namespace
