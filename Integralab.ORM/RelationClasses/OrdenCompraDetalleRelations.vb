' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 15 de marzo de 2018 11:59:56
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
	''' Implements the Shared Relations variant for the entity: OrdenCompraDetalle.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class OrdenCompraDetalleRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between OrdenCompraDetalleEntity and ProductoEntity over the m:1 relation they have, using the relation between the fields:
		''' OrdenCompraDetalle.IdProducto - Producto.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property ProductoEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(OrdenCompraDetalleFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenCompraDetalleEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between OrdenCompraDetalleEntity and TipoMonedaEntity over the m:1 relation they have, using the relation between the fields:
		''' OrdenCompraDetalle.IdMoneda - TipoMoneda.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property TipoMonedaEntityUsingIdMoneda() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), EntityFieldFactory.Create(OrdenCompraDetalleFieldIndex.IdMoneda))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoMonedaEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenCompraDetalleEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between OrdenCompraDetalleEntity and McomCotizacionCompraEntity over the m:1 relation they have, using the relation between the fields:
		''' OrdenCompraDetalle.IdCotizacion - McomCotizacionCompra.IdCotizacion
		''' </summary>
		Public Overridable  ReadOnly Property McomCotizacionCompraEntityUsingIdCotizacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McomCotizacionCompraFieldIndex.IdCotizacion), EntityFieldFactory.Create(OrdenCompraDetalleFieldIndex.IdCotizacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McomCotizacionCompraEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenCompraDetalleEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between OrdenCompraDetalleEntity and OrdenCompraEntity over the m:1 relation they have, using the relation between the fields:
		''' OrdenCompraDetalle.IdOrdenCompra - OrdenCompra.IdOrdenCompra
		''' </summary>
		Public Overridable  ReadOnly Property OrdenCompraEntityUsingIdOrdenCompra() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(OrdenCompraFieldIndex.IdOrdenCompra), EntityFieldFactory.Create(OrdenCompraDetalleFieldIndex.IdOrdenCompra))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenCompraEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenCompraDetalleEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between OrdenCompraDetalleEntity and SolicitudProductoEntity over the m:1 relation they have, using the relation between the fields:
		''' OrdenCompraDetalle.IdSolicitud - SolicitudProducto.IdSolicitud
		''' </summary>
		Public Overridable  ReadOnly Property SolicitudProductoEntityUsingIdSolicitud() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SolicitudProductoFieldIndex.IdSolicitud), EntityFieldFactory.Create(OrdenCompraDetalleFieldIndex.IdSolicitud))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SolicitudProductoEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenCompraDetalleEntity", True)
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
