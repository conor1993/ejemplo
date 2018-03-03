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
	''' Implements the Shared Relations variant for the entity: MscrecepcionCanalesCab.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class MscrecepcionCanalesCabRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between MscrecepcionCanalesCabEntity and MscrecepcionCanalesDetEntity over the 1:n relation they have, using the relation between the fields:
		''' MscrecepcionCanalesCab.FolioMovimiento - MscrecepcionCanalesDet.FolioMovimiento
		''' MscrecepcionCanalesCab.FolioSacrificio - MscrecepcionCanalesDet.FolioSacrificio
		''' </summary>
		Public Overridable ReadOnly Property MscrecepcionCanalesDetEntityUsingFolioMovimientoFolioSacrificio() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscrecepcionCanalesCabFieldIndex.FolioMovimiento), EntityFieldFactory.Create(MscrecepcionCanalesDetFieldIndex.FolioMovimiento))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscrecepcionCanalesCabFieldIndex.FolioSacrificio), EntityFieldFactory.Create(MscrecepcionCanalesDetFieldIndex.FolioSacrificio))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscrecepcionCanalesCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscrecepcionCanalesDetEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between MscrecepcionCanalesCabEntity and MscregistroSacrificioCabEntity over the m:1 relation they have, using the relation between the fields:
		''' MscrecepcionCanalesCab.FolioSacrificio - MscregistroSacrificioCab.IdFolioSacrificio
		''' </summary>
		Public Overridable  ReadOnly Property MscregistroSacrificioCabEntityUsingFolioSacrificio() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscregistroSacrificioCabFieldIndex.IdFolioSacrificio), EntityFieldFactory.Create(MscrecepcionCanalesCabFieldIndex.FolioSacrificio))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscregistroSacrificioCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscrecepcionCanalesCabEntity", True)
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
