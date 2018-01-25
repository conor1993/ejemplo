' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 25 de enero de 2018 11:40:24
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
	''' Implements the Shared Relations variant for the entity: OrdenCompra.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class OrdenCompraRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between OrdenCompraEntity and OrdenCompraDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' OrdenCompra.IdOrdenCompra - OrdenCompraDetalle.IdOrdenCompra
		''' </summary>
		Public Overridable ReadOnly Property OrdenCompraDetalleEntityUsingIdOrdenCompra() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(OrdenCompraFieldIndex.IdOrdenCompra), EntityFieldFactory.Create(OrdenCompraDetalleFieldIndex.IdOrdenCompra))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenCompraEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenCompraDetalleEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between OrdenCompraEntity and RecepcionOrdenCompraEntity over the 1:n relation they have, using the relation between the fields:
		''' OrdenCompra.IdOrdenCompra - RecepcionOrdenCompra.IdOrdenCompra
		''' </summary>
		Public Overridable ReadOnly Property RecepcionOrdenCompraEntityUsingIdOrdenCompra() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(OrdenCompraFieldIndex.IdOrdenCompra), EntityFieldFactory.Create(RecepcionOrdenCompraFieldIndex.IdOrdenCompra))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenCompraEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecepcionOrdenCompraEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between OrdenCompraEntity and ProveedorEntity over the m:1 relation they have, using the relation between the fields:
		''' OrdenCompra.IdProveedor - Proveedor.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property ProveedorEntityUsingIdProveedor() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), EntityFieldFactory.Create(OrdenCompraFieldIndex.IdProveedor))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProveedorEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenCompraEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between OrdenCompraEntity and SucursalEntity over the m:1 relation they have, using the relation between the fields:
		''' OrdenCompra.IdSucursal - Sucursal.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property SucursalEntityUsingIdSucursal() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SucursalFieldIndex.Codigo), EntityFieldFactory.Create(OrdenCompraFieldIndex.IdSucursal))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SucursalEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenCompraEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between OrdenCompraEntity and TipoMonedaEntity over the m:1 relation they have, using the relation between the fields:
		''' OrdenCompra.IdMoneda - TipoMoneda.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property TipoMonedaEntityUsingIdMoneda() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), EntityFieldFactory.Create(OrdenCompraFieldIndex.IdMoneda))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoMonedaEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenCompraEntity", True)
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
