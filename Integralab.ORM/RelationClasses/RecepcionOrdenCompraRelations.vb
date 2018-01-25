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
	''' Implements the Shared Relations variant for the entity: RecepcionOrdenCompra.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class RecepcionOrdenCompraRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between RecepcionOrdenCompraEntity and McomRecepcionOrdenCompraDetEntity over the 1:n relation they have, using the relation between the fields:
		''' RecepcionOrdenCompra.IdRecepcionOrdenCompra - McomRecepcionOrdenCompraDet.IdRecepcionOrdenCompra
		''' </summary>
		Public Overridable ReadOnly Property McomRecepcionOrdenCompraDetEntityUsingIdRecepcionOrdenCompra() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(RecepcionOrdenCompraFieldIndex.IdRecepcionOrdenCompra), EntityFieldFactory.Create(McomRecepcionOrdenCompraDetFieldIndex.IdRecepcionOrdenCompra))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecepcionOrdenCompraEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McomRecepcionOrdenCompraDetEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between RecepcionOrdenCompraEntity and UsrCxpfacturasDetRecepcionesEntity over the 1:n relation they have, using the relation between the fields:
		''' RecepcionOrdenCompra.IdRecepcionOrdenCompra - UsrCxpfacturasDetRecepciones.IdRecepcionOrdenCompra
		''' </summary>
		Public Overridable ReadOnly Property UsrCxpfacturasDetRecepcionesEntityUsingIdRecepcionOrdenCompra() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(RecepcionOrdenCompraFieldIndex.IdRecepcionOrdenCompra), EntityFieldFactory.Create(UsrCxpfacturasDetRecepcionesFieldIndex.IdRecepcionOrdenCompra))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecepcionOrdenCompraEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrCxpfacturasDetRecepcionesEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between RecepcionOrdenCompraEntity and AlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' RecepcionOrdenCompra.AlmacenId - Almacen.AlmacenId
		''' </summary>
		Public Overridable  ReadOnly Property AlmacenEntityUsingAlmacenId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(RecepcionOrdenCompraFieldIndex.AlmacenId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecepcionOrdenCompraEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between RecepcionOrdenCompraEntity and MotivoCancelacionEntity over the m:1 relation they have, using the relation between the fields:
		''' RecepcionOrdenCompra.MotivoCancelacionId - MotivoCancelacion.IdMotivo
		''' </summary>
		Public Overridable  ReadOnly Property MotivoCancelacionEntityUsingMotivoCancelacionId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MotivoCancelacionFieldIndex.IdMotivo), EntityFieldFactory.Create(RecepcionOrdenCompraFieldIndex.MotivoCancelacionId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MotivoCancelacionEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecepcionOrdenCompraEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between RecepcionOrdenCompraEntity and SucursalEntity over the m:1 relation they have, using the relation between the fields:
		''' RecepcionOrdenCompra.IdSucursal - Sucursal.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property SucursalEntityUsingIdSucursal() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SucursalFieldIndex.Codigo), EntityFieldFactory.Create(RecepcionOrdenCompraFieldIndex.IdSucursal))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SucursalEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecepcionOrdenCompraEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between RecepcionOrdenCompraEntity and OrdenCompraEntity over the m:1 relation they have, using the relation between the fields:
		''' RecepcionOrdenCompra.IdOrdenCompra - OrdenCompra.IdOrdenCompra
		''' </summary>
		Public Overridable  ReadOnly Property OrdenCompraEntityUsingIdOrdenCompra() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(OrdenCompraFieldIndex.IdOrdenCompra), EntityFieldFactory.Create(RecepcionOrdenCompraFieldIndex.IdOrdenCompra))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenCompraEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecepcionOrdenCompraEntity", True)
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
