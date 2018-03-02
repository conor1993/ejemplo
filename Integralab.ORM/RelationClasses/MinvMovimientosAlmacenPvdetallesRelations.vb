' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de marzo de 2018 10:17:29
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
	''' Implements the Shared Relations variant for the entity: MinvMovimientosAlmacenPvdetalles.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class MinvMovimientosAlmacenPvdetallesRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between MinvMovimientosAlmacenPvdetallesEntity and AlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' MinvMovimientosAlmacenPvdetalles.AlmacenId - Almacen.AlmacenId
		''' </summary>
		Public Overridable  ReadOnly Property AlmacenEntityUsingAlmacenId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(MinvMovimientosAlmacenPvdetallesFieldIndex.AlmacenId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvMovimientosAlmacenPvdetallesEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MinvMovimientosAlmacenPvdetallesEntity and ProductoEntity over the m:1 relation they have, using the relation between the fields:
		''' MinvMovimientosAlmacenPvdetalles.ProductoId - Producto.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property ProductoEntityUsingProductoId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(MinvMovimientosAlmacenPvdetallesFieldIndex.ProductoId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvMovimientosAlmacenPvdetallesEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MinvMovimientosAlmacenPvdetallesEntity and MinvMovimientosAlmacenPvEntity over the m:1 relation they have, using the relation between the fields:
		''' MinvMovimientosAlmacenPvdetalles.AlmacenId - MinvMovimientosAlmacenPv.AlmacenId
		''' MinvMovimientosAlmacenPvdetalles.FolioMovimiento - MinvMovimientosAlmacenPv.FolioMovimiento
		''' </summary>
		Public Overridable  ReadOnly Property MinvMovimientosAlmacenPvEntityUsingAlmacenIdFolioMovimiento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MinvMovimientosAlmacenPvFieldIndex.AlmacenId), EntityFieldFactory.Create(MinvMovimientosAlmacenPvdetallesFieldIndex.AlmacenId))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MinvMovimientosAlmacenPvFieldIndex.FolioMovimiento), EntityFieldFactory.Create(MinvMovimientosAlmacenPvdetallesFieldIndex.FolioMovimiento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvMovimientosAlmacenPvEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvMovimientosAlmacenPvdetallesEntity", True)
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
