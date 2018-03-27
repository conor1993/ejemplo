' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 26 de marzo de 2018 17:30:31
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
	''' Implements the Shared Relations variant for the entity: McomCotizacionCompraProveedorDetalle.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class McomCotizacionCompraProveedorDetalleRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between McomCotizacionCompraProveedorDetalleEntity and ProductoEntity over the m:1 relation they have, using the relation between the fields:
		''' McomCotizacionCompraProveedorDetalle.IdProducto - Producto.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property ProductoEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(McomCotizacionCompraProveedorDetalleFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McomCotizacionCompraProveedorDetalleEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between McomCotizacionCompraProveedorDetalleEntity and SolicitudProductoDetalleEntity over the m:1 relation they have, using the relation between the fields:
		''' McomCotizacionCompraProveedorDetalle.IdSolicitud - SolicitudProductoDetalle.IdSolicitud
		''' McomCotizacionCompraProveedorDetalle.IdProducto - SolicitudProductoDetalle.IdProducto
		''' </summary>
		Public Overridable  ReadOnly Property SolicitudProductoDetalleEntityUsingIdSolicitudIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SolicitudProductoDetalleFieldIndex.IdSolicitud), EntityFieldFactory.Create(McomCotizacionCompraProveedorDetalleFieldIndex.IdSolicitud))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SolicitudProductoDetalleFieldIndex.IdProducto), EntityFieldFactory.Create(McomCotizacionCompraProveedorDetalleFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SolicitudProductoDetalleEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McomCotizacionCompraProveedorDetalleEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between McomCotizacionCompraProveedorDetalleEntity and ProveedorEntity over the m:1 relation they have, using the relation between the fields:
		''' McomCotizacionCompraProveedorDetalle.IdProveedor - Proveedor.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property ProveedorEntityUsingIdProveedor() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), EntityFieldFactory.Create(McomCotizacionCompraProveedorDetalleFieldIndex.IdProveedor))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProveedorEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McomCotizacionCompraProveedorDetalleEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between McomCotizacionCompraProveedorDetalleEntity and TipoMonedaEntity over the m:1 relation they have, using the relation between the fields:
		''' McomCotizacionCompraProveedorDetalle.IdMoneda - TipoMoneda.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property TipoMonedaEntityUsingIdMoneda() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), EntityFieldFactory.Create(McomCotizacionCompraProveedorDetalleFieldIndex.IdMoneda))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoMonedaEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McomCotizacionCompraProveedorDetalleEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between McomCotizacionCompraProveedorDetalleEntity and McomCotizacionCompraEntity over the m:1 relation they have, using the relation between the fields:
		''' McomCotizacionCompraProveedorDetalle.IdCotizacion - McomCotizacionCompra.IdCotizacion
		''' </summary>
		Public Overridable  ReadOnly Property McomCotizacionCompraEntityUsingIdCotizacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McomCotizacionCompraFieldIndex.IdCotizacion), EntityFieldFactory.Create(McomCotizacionCompraProveedorDetalleFieldIndex.IdCotizacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McomCotizacionCompraEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McomCotizacionCompraProveedorDetalleEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between McomCotizacionCompraProveedorDetalleEntity and McomCotizacionCompraProveedorEntity over the m:1 relation they have, using the relation between the fields:
		''' McomCotizacionCompraProveedorDetalle.IdCotizacion - McomCotizacionCompraProveedor.IdCotizacion
		''' McomCotizacionCompraProveedorDetalle.IdProveedor - McomCotizacionCompraProveedor.IdProveedor
		''' </summary>
		Public Overridable  ReadOnly Property McomCotizacionCompraProveedorEntityUsingIdCotizacionIdProveedor() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McomCotizacionCompraProveedorFieldIndex.IdCotizacion), EntityFieldFactory.Create(McomCotizacionCompraProveedorDetalleFieldIndex.IdCotizacion))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McomCotizacionCompraProveedorFieldIndex.IdProveedor), EntityFieldFactory.Create(McomCotizacionCompraProveedorDetalleFieldIndex.IdProveedor))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McomCotizacionCompraProveedorEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McomCotizacionCompraProveedorDetalleEntity", True)
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
