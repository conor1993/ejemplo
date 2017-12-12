' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 11 de diciembre de 2017 20:57:26
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
	''' Implements the Shared Relations variant for the entity: CabAplFor.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class CabAplForRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between CabAplForEntity and DetAplForEntity over the 1:n relation they have, using the relation between the fields:
		''' CabAplFor.FolAplF - DetAplFor.FolAplF
		''' </summary>
		Public Overridable ReadOnly Property DetAplForEntityUsingFolAplF() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CabAplForFieldIndex.FolAplF), EntityFieldFactory.Create(DetAplForFieldIndex.FolAplF))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabAplForEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetAplForEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between CabAplForEntity and AlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' CabAplFor.IdAlmacen - Almacen.AlmacenId
		''' </summary>
		Public Overridable  ReadOnly Property AlmacenEntityUsingIdAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(CabAplForFieldIndex.IdAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabAplForEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between CabAplForEntity and InventarioMovimientoAlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' CabAplFor.IdAlmacen - InventarioMovimientoAlmacen.AlmacenId
		''' CabAplFor.FolioMovimientoAlmacen - InventarioMovimientoAlmacen.FolioMovimiento
		''' </summary>
		Public Overridable  ReadOnly Property InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(CabAplForFieldIndex.IdAlmacen))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(CabAplForFieldIndex.FolioMovimientoAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabAplForEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between CabAplForEntity and InventarioMovimientoAlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' CabAplFor.IdAlmacen - InventarioMovimientoAlmacen.AlmacenId
		''' CabAplFor.FolioMovimientoAlmacenCancelacion - InventarioMovimientoAlmacen.FolioMovimiento
		''' </summary>
		Public Overridable  ReadOnly Property InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(CabAplForFieldIndex.IdAlmacen))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(CabAplForFieldIndex.FolioMovimientoAlmacenCancelacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabAplForEntity", True)
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
