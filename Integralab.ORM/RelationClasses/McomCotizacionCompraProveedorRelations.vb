' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 1 de diciembre de 2017 15:44:04
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
	''' Implements the Shared Relations variant for the entity: McomCotizacionCompraProveedor.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class McomCotizacionCompraProveedorRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between McomCotizacionCompraProveedorEntity and McomCotizacionCompraProveedorDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' McomCotizacionCompraProveedor.IdCotizacion - McomCotizacionCompraProveedorDetalle.IdCotizacion
		''' McomCotizacionCompraProveedor.IdProveedor - McomCotizacionCompraProveedorDetalle.IdProveedor
		''' </summary>
		Public Overridable ReadOnly Property McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacionIdProveedor() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McomCotizacionCompraProveedorFieldIndex.IdCotizacion), EntityFieldFactory.Create(McomCotizacionCompraProveedorDetalleFieldIndex.IdCotizacion))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McomCotizacionCompraProveedorFieldIndex.IdProveedor), EntityFieldFactory.Create(McomCotizacionCompraProveedorDetalleFieldIndex.IdProveedor))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McomCotizacionCompraProveedorEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McomCotizacionCompraProveedorDetalleEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between McomCotizacionCompraProveedorEntity and ProveedorEntity over the m:1 relation they have, using the relation between the fields:
		''' McomCotizacionCompraProveedor.IdProveedor - Proveedor.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property ProveedorEntityUsingIdProveedor() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), EntityFieldFactory.Create(McomCotizacionCompraProveedorFieldIndex.IdProveedor))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProveedorEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McomCotizacionCompraProveedorEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between McomCotizacionCompraProveedorEntity and McomCotizacionCompraEntity over the m:1 relation they have, using the relation between the fields:
		''' McomCotizacionCompraProveedor.IdCotizacion - McomCotizacionCompra.IdCotizacion
		''' </summary>
		Public Overridable  ReadOnly Property McomCotizacionCompraEntityUsingIdCotizacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McomCotizacionCompraFieldIndex.IdCotizacion), EntityFieldFactory.Create(McomCotizacionCompraProveedorFieldIndex.IdCotizacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McomCotizacionCompraEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McomCotizacionCompraProveedorEntity", True)
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
