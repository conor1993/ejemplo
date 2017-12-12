' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 11 de diciembre de 2017 20:57:27
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
	''' Implements the Shared Relations variant for the entity: MinvMovimientosAlmacenPv.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class MinvMovimientosAlmacenPvRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between MinvMovimientosAlmacenPvEntity and MinvMovimientosAlmacenPvdetallesEntity over the 1:n relation they have, using the relation between the fields:
		''' MinvMovimientosAlmacenPv.AlmacenId - MinvMovimientosAlmacenPvdetalles.AlmacenId
		''' MinvMovimientosAlmacenPv.FolioMovimiento - MinvMovimientosAlmacenPvdetalles.FolioMovimiento
		''' </summary>
		Public Overridable ReadOnly Property MinvMovimientosAlmacenPvdetallesEntityUsingAlmacenIdFolioMovimiento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MinvMovimientosAlmacenPvFieldIndex.AlmacenId), EntityFieldFactory.Create(MinvMovimientosAlmacenPvdetallesFieldIndex.AlmacenId))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MinvMovimientosAlmacenPvFieldIndex.FolioMovimiento), EntityFieldFactory.Create(MinvMovimientosAlmacenPvdetallesFieldIndex.FolioMovimiento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvMovimientosAlmacenPvEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvMovimientosAlmacenPvdetallesEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between MinvMovimientosAlmacenPvEntity and CatMovimientosAlmacenPvEntity over the m:1 relation they have, using the relation between the fields:
		''' MinvMovimientosAlmacenPv.TipoMovimientoId - CatMovimientosAlmacenPv.IdMov
		''' </summary>
		Public Overridable  ReadOnly Property CatMovimientosAlmacenPvEntityUsingTipoMovimientoId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CatMovimientosAlmacenPvFieldIndex.IdMov), EntityFieldFactory.Create(MinvMovimientosAlmacenPvFieldIndex.TipoMovimientoId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CatMovimientosAlmacenPvEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvMovimientosAlmacenPvEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MinvMovimientosAlmacenPvEntity and AlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' MinvMovimientosAlmacenPv.AlmacenId - Almacen.AlmacenId
		''' </summary>
		Public Overridable  ReadOnly Property AlmacenEntityUsingAlmacenId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(MinvMovimientosAlmacenPvFieldIndex.AlmacenId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvMovimientosAlmacenPvEntity", True)
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
