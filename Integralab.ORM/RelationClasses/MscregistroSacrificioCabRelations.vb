' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 23 de abril de 2018 15:21:55
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
	''' Implements the Shared Relations variant for the entity: MscregistroSacrificioCab.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class MscregistroSacrificioCabRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between MscregistroSacrificioCabEntity and RegistroSacrificiosDecomisosEntity over the 1:n relation they have, using the relation between the fields:
		''' MscregistroSacrificioCab.IdFolioSacrificio - RegistroSacrificiosDecomisos.LoteSacrificio
		''' </summary>
		Public Overridable ReadOnly Property RegistroSacrificiosDecomisosEntityUsingLoteSacrificio() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscregistroSacrificioCabFieldIndex.IdFolioSacrificio), EntityFieldFactory.Create(RegistroSacrificiosDecomisosFieldIndex.LoteSacrificio))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscregistroSacrificioCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RegistroSacrificiosDecomisosEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MscregistroSacrificioCabEntity and MscrecepcionCanalesCabEntity over the 1:n relation they have, using the relation between the fields:
		''' MscregistroSacrificioCab.IdFolioSacrificio - MscrecepcionCanalesCab.FolioSacrificio
		''' </summary>
		Public Overridable ReadOnly Property MscrecepcionCanalesCabEntityUsingFolioSacrificio() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscregistroSacrificioCabFieldIndex.IdFolioSacrificio), EntityFieldFactory.Create(MscrecepcionCanalesCabFieldIndex.FolioSacrificio))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscregistroSacrificioCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscrecepcionCanalesCabEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MscregistroSacrificioCabEntity and UsrProdRecepcionGanadoDetEntity over the 1:n relation they have, using the relation between the fields:
		''' MscregistroSacrificioCab.IdFolioSacrificio - UsrProdRecepcionGanadoDet.LoteSacrificio
		''' </summary>
		Public Overridable ReadOnly Property UsrProdRecepcionGanadoDetEntityUsingLoteSacrificio() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscregistroSacrificioCabFieldIndex.IdFolioSacrificio), EntityFieldFactory.Create(UsrProdRecepcionGanadoDetFieldIndex.LoteSacrificio))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscregistroSacrificioCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrProdRecepcionGanadoDetEntity", False)
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
