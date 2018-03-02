﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de marzo de 2018 10:17:28
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
	''' Implements the Shared Relations variant for the entity: RegistroSacrificiosCab.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class RegistroSacrificiosCabRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between RegistroSacrificiosCabEntity and RegistroSacrificiosDecomisosEntity over the 1:n relation they have, using the relation between the fields:
		''' RegistroSacrificiosCab.LoteSacrificio - RegistroSacrificiosDecomisos.LoteSacrificio
		''' </summary>
		Public Overridable ReadOnly Property RegistroSacrificiosDecomisosEntityUsingLoteSacrificio() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(RegistroSacrificiosCabFieldIndex.LoteSacrificio), EntityFieldFactory.Create(RegistroSacrificiosDecomisosFieldIndex.LoteSacrificio))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RegistroSacrificiosCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RegistroSacrificiosDecomisosEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between RegistroSacrificiosCabEntity and RegistroSacrificiosDetEntity over the 1:n relation they have, using the relation between the fields:
		''' RegistroSacrificiosCab.LoteSacrificio - RegistroSacrificiosDet.LoteSacrificio
		''' </summary>
		Public Overridable ReadOnly Property RegistroSacrificiosDetEntityUsingLoteSacrificio() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(RegistroSacrificiosCabFieldIndex.LoteSacrificio), EntityFieldFactory.Create(RegistroSacrificiosDetFieldIndex.LoteSacrificio))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RegistroSacrificiosCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RegistroSacrificiosDetEntity", False)
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
