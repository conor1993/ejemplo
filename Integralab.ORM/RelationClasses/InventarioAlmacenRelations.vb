' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 11 de enero de 2018 10:37:31
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
	''' Implements the Shared Relations variant for the entity: InventarioAlmacen.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class InventarioAlmacenRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between InventarioAlmacenEntity and inventarioAlmacenLotesEntity over the 1:n relation they have, using the relation between the fields:
		''' InventarioAlmacen.AlmacenId - inventarioAlmacenLotes.AlmacenId
		''' InventarioAlmacen.ProductoId - inventarioAlmacenLotes.ProductoId
		''' InventarioAlmacen.Año - inventarioAlmacenLotes.Año
		''' InventarioAlmacen.Mes - inventarioAlmacenLotes.Mes
		''' </summary>
		Public Overridable ReadOnly Property inventarioAlmacenLotesEntityUsingAlmacenIdProductoIdAñoMes() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(inventarioAlmacenLotesFieldIndex.AlmacenId))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioAlmacenFieldIndex.ProductoId), EntityFieldFactory.Create(inventarioAlmacenLotesFieldIndex.ProductoId))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioAlmacenFieldIndex.Año), EntityFieldFactory.Create(inventarioAlmacenLotesFieldIndex.Año))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioAlmacenFieldIndex.Mes), EntityFieldFactory.Create(inventarioAlmacenLotesFieldIndex.Mes))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioAlmacenEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("inventarioAlmacenLotesEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between InventarioAlmacenEntity and AlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' InventarioAlmacen.AlmacenId - Almacen.AlmacenId
		''' </summary>
		Public Overridable  ReadOnly Property AlmacenEntityUsingAlmacenId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(InventarioAlmacenFieldIndex.AlmacenId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioAlmacenEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between InventarioAlmacenEntity and ProductoEntity over the m:1 relation they have, using the relation between the fields:
		''' InventarioAlmacen.ProductoId - Producto.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property ProductoEntityUsingProductoId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(InventarioAlmacenFieldIndex.ProductoId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioAlmacenEntity", True)
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
