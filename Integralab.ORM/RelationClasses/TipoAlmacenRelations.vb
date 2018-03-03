' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de marzo de 2018 16:12:30
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
	''' Implements the Shared Relations variant for the entity: TipoAlmacen.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class TipoAlmacenRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between TipoAlmacenEntity and ConfigGanEntity over the 1:n relation they have, using the relation between the fields:
		''' TipoAlmacen.Codigo - ConfigGan.IdTipoAlmacenFormula
		''' </summary>
		Public Overridable ReadOnly Property ConfigGanEntityUsingIdTipoAlmacenFormula() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoAlmacenFieldIndex.Codigo), EntityFieldFactory.Create(ConfigGanFieldIndex.IdTipoAlmacenFormula))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoAlmacenEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ConfigGanEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between TipoAlmacenEntity and ConfigGanEntity over the 1:n relation they have, using the relation between the fields:
		''' TipoAlmacen.Codigo - ConfigGan.IdTipoAlmacenMedicamento
		''' </summary>
		Public Overridable ReadOnly Property ConfigGanEntityUsingIdTipoAlmacenMedicamento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoAlmacenFieldIndex.Codigo), EntityFieldFactory.Create(ConfigGanFieldIndex.IdTipoAlmacenMedicamento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoAlmacenEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ConfigGanEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between TipoAlmacenEntity and ConfigGanEntity over the 1:n relation they have, using the relation between the fields:
		''' TipoAlmacen.Codigo - ConfigGan.IdTipoAlmacenRolado
		''' </summary>
		Public Overridable ReadOnly Property ConfigGanEntityUsingIdTipoAlmacenRolado() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoAlmacenFieldIndex.Codigo), EntityFieldFactory.Create(ConfigGanFieldIndex.IdTipoAlmacenRolado))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoAlmacenEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ConfigGanEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between TipoAlmacenEntity and AlmacenEntity over the 1:n relation they have, using the relation between the fields:
		''' TipoAlmacen.Codigo - Almacen.TipoAlmacen
		''' </summary>
		Public Overridable ReadOnly Property AlmacenEntityUsingTipoAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoAlmacenFieldIndex.Codigo), EntityFieldFactory.Create(AlmacenFieldIndex.TipoAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoAlmacenEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AlmacenEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between TipoAlmacenEntity and UsrProdConfiguracionEntity over the 1:n relation they have, using the relation between the fields:
		''' TipoAlmacen.Codigo - UsrProdConfiguracion.IdTipoAlmacen
		''' </summary>
		Public Overridable ReadOnly Property UsrProdConfiguracionEntityUsingIdTipoAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoAlmacenFieldIndex.Codigo), EntityFieldFactory.Create(UsrProdConfiguracionFieldIndex.IdTipoAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoAlmacenEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrProdConfiguracionEntity", False)
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
