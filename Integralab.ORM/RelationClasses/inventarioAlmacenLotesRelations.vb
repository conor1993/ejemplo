' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 15 de marzo de 2018 11:59:57
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
	''' Implements the Shared Relations variant for the entity: inventarioAlmacenLotes.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class inventarioAlmacenLotesRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between inventarioAlmacenLotesEntity and AlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' inventarioAlmacenLotes.AlmacenId - Almacen.AlmacenId
		''' </summary>
		Public Overridable  ReadOnly Property AlmacenEntityUsingAlmacenId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(inventarioAlmacenLotesFieldIndex.AlmacenId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("inventarioAlmacenLotesEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between inventarioAlmacenLotesEntity and ProductoEntity over the m:1 relation they have, using the relation between the fields:
		''' inventarioAlmacenLotes.ProductoId - Producto.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property ProductoEntityUsingProductoId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(inventarioAlmacenLotesFieldIndex.ProductoId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("inventarioAlmacenLotesEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between inventarioAlmacenLotesEntity and InventarioAlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' inventarioAlmacenLotes.AlmacenId - InventarioAlmacen.AlmacenId
		''' inventarioAlmacenLotes.ProductoId - InventarioAlmacen.ProductoId
		''' inventarioAlmacenLotes.Año - InventarioAlmacen.Año
		''' inventarioAlmacenLotes.Mes - InventarioAlmacen.Mes
		''' </summary>
		Public Overridable  ReadOnly Property InventarioAlmacenEntityUsingAlmacenIdProductoIdAñoMes() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(inventarioAlmacenLotesFieldIndex.AlmacenId))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioAlmacenFieldIndex.ProductoId), EntityFieldFactory.Create(inventarioAlmacenLotesFieldIndex.ProductoId))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioAlmacenFieldIndex.Año), EntityFieldFactory.Create(inventarioAlmacenLotesFieldIndex.Año))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioAlmacenFieldIndex.Mes), EntityFieldFactory.Create(inventarioAlmacenLotesFieldIndex.Mes))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioAlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("inventarioAlmacenLotesEntity", True)
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
