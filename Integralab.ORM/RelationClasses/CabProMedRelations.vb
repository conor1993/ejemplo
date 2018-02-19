' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: domingo, 18 de febrero de 2018 17:52:54
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
	''' Implements the Shared Relations variant for the entity: CabProMed.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class CabProMedRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between CabProMedEntity and DetDproMedEntity over the 1:n relation they have, using the relation between the fields:
		''' CabProMed.FolioProrrateoMedicamento - DetDproMed.FolioProrrateoMedicamento
		''' </summary>
		Public Overridable ReadOnly Property DetDproMedEntityUsingFolioProrrateoMedicamento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CabProMedFieldIndex.FolioProrrateoMedicamento), EntityFieldFactory.Create(DetDproMedFieldIndex.FolioProrrateoMedicamento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabProMedEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetDproMedEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between CabProMedEntity and DetProMedEntity over the 1:n relation they have, using the relation between the fields:
		''' CabProMed.FolioProrrateoMedicamento - DetProMed.FolioProrrateoMedicamento
		''' </summary>
		Public Overridable ReadOnly Property DetProMedEntityUsingFolioProrrateoMedicamento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CabProMedFieldIndex.FolioProrrateoMedicamento), EntityFieldFactory.Create(DetProMedFieldIndex.FolioProrrateoMedicamento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabProMedEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetProMedEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between CabProMedEntity and AlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' CabProMed.IdAlmacen - Almacen.AlmacenId
		''' </summary>
		Public Overridable  ReadOnly Property AlmacenEntityUsingIdAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(CabProMedFieldIndex.IdAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabProMedEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between CabProMedEntity and InventarioMovimientoAlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' CabProMed.IdAlmacen - InventarioMovimientoAlmacen.AlmacenId
		''' CabProMed.FolioMovimientoAlmacenSalida - InventarioMovimientoAlmacen.FolioMovimiento
		''' </summary>
		Public Overridable  ReadOnly Property InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenSalida() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(CabProMedFieldIndex.IdAlmacen))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(CabProMedFieldIndex.FolioMovimientoAlmacenSalida))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabProMedEntity", True)
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
