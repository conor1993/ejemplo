' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 29 de enero de 2018 10:43:40
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
	''' Implements the Shared Relations variant for the entity: AplicMedi.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class AplicMediRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between AplicMediEntity and AplicMediDetEntity over the 1:n relation they have, using the relation between the fields:
		''' AplicMedi.FolAplicMedi - AplicMediDet.FolioAplicacionMedicamento
		''' </summary>
		Public Overridable ReadOnly Property AplicMediDetEntityUsingFolioAplicacionMedicamento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AplicMediFieldIndex.FolAplicMedi), EntityFieldFactory.Create(AplicMediDetFieldIndex.FolioAplicacionMedicamento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AplicMediEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AplicMediDetEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between AplicMediEntity and AplicMediDetDetEntity over the 1:n relation they have, using the relation between the fields:
		''' AplicMedi.FolAplicMedi - AplicMediDetDet.FolioAplicacionMedicamento
		''' </summary>
		Public Overridable ReadOnly Property AplicMediDetDetEntityUsingFolioAplicacionMedicamento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AplicMediFieldIndex.FolAplicMedi), EntityFieldFactory.Create(AplicMediDetDetFieldIndex.FolioAplicacionMedicamento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AplicMediEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AplicMediDetDetEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between AplicMediEntity and AlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' AplicMedi.IdAlmacen - Almacen.AlmacenId
		''' </summary>
		Public Overridable  ReadOnly Property AlmacenEntityUsingIdAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(AplicMediFieldIndex.IdAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AplicMediEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between AplicMediEntity and InventarioMovimientoAlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' AplicMedi.IdAlmacen - InventarioMovimientoAlmacen.AlmacenId
		''' AplicMedi.FolioMovimientoAlmacen - InventarioMovimientoAlmacen.FolioMovimiento
		''' </summary>
		Public Overridable  ReadOnly Property InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(AplicMediFieldIndex.IdAlmacen))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(AplicMediFieldIndex.FolioMovimientoAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AplicMediEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between AplicMediEntity and InventarioMovimientoAlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' AplicMedi.IdAlmacen - InventarioMovimientoAlmacen.AlmacenId
		''' AplicMedi.FolioMovimientoAlmacenCancelacion - InventarioMovimientoAlmacen.FolioMovimiento
		''' </summary>
		Public Overridable  ReadOnly Property InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(AplicMediFieldIndex.IdAlmacen))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(AplicMediFieldIndex.FolioMovimientoAlmacenCancelacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AplicMediEntity", True)
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
