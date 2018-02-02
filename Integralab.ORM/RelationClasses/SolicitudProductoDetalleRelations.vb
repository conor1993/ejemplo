' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de febrero de 2018 11:54:43
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
	''' Implements the Shared Relations variant for the entity: SolicitudProductoDetalle.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class SolicitudProductoDetalleRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between SolicitudProductoDetalleEntity and McomCotizacionCompraProveedorDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' SolicitudProductoDetalle.IdSolicitud - McomCotizacionCompraProveedorDetalle.IdSolicitud
		''' SolicitudProductoDetalle.IdProducto - McomCotizacionCompraProveedorDetalle.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property McomCotizacionCompraProveedorDetalleEntityUsingIdSolicitudIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SolicitudProductoDetalleFieldIndex.IdSolicitud), EntityFieldFactory.Create(McomCotizacionCompraProveedorDetalleFieldIndex.IdSolicitud))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SolicitudProductoDetalleFieldIndex.IdProducto), EntityFieldFactory.Create(McomCotizacionCompraProveedorDetalleFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SolicitudProductoDetalleEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McomCotizacionCompraProveedorDetalleEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between SolicitudProductoDetalleEntity and ProductoEntity over the m:1 relation they have, using the relation between the fields:
		''' SolicitudProductoDetalle.IdProducto - Producto.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property ProductoEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(SolicitudProductoDetalleFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SolicitudProductoDetalleEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between SolicitudProductoDetalleEntity and SolicitudProductoEntity over the m:1 relation they have, using the relation between the fields:
		''' SolicitudProductoDetalle.IdSolicitud - SolicitudProducto.IdSolicitud
		''' </summary>
		Public Overridable  ReadOnly Property SolicitudProductoEntityUsingIdSolicitud() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SolicitudProductoFieldIndex.IdSolicitud), EntityFieldFactory.Create(SolicitudProductoDetalleFieldIndex.IdSolicitud))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SolicitudProductoEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SolicitudProductoDetalleEntity", True)
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
