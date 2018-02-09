﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 8 de febrero de 2018 12:25:17
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
	''' Implements the Shared Relations variant for the entity: MscrecepcionCanalesDet.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class MscrecepcionCanalesDetRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between MscrecepcionCanalesDetEntity and MscmovtosAlmacenCabEntity over the m:1 relation they have, using the relation between the fields:
		''' MscrecepcionCanalesDet.IdFolioMovimiento - MscmovtosAlmacenCab.IdFolioMovimiento
		''' </summary>
		Public Overridable  ReadOnly Property MscmovtosAlmacenCabEntityUsingIdFolioMovimiento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), EntityFieldFactory.Create(MscrecepcionCanalesDetFieldIndex.IdFolioMovimiento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscrecepcionCanalesDetEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MscrecepcionCanalesDetEntity and MscmovtosAlmacenCabEntity over the m:1 relation they have, using the relation between the fields:
		''' MscrecepcionCanalesDet.IdFolioMovimientoCancela - MscmovtosAlmacenCab.IdFolioMovimiento
		''' </summary>
		Public Overridable  ReadOnly Property MscmovtosAlmacenCabEntityUsingIdFolioMovimientoCancela() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), EntityFieldFactory.Create(MscrecepcionCanalesDetFieldIndex.IdFolioMovimientoCancela))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscrecepcionCanalesDetEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MscrecepcionCanalesDetEntity and MscrecepcionCanalesCabEntity over the m:1 relation they have, using the relation between the fields:
		''' MscrecepcionCanalesDet.FolioMovimiento - MscrecepcionCanalesCab.FolioMovimiento
		''' MscrecepcionCanalesDet.FolioSacrificio - MscrecepcionCanalesCab.FolioSacrificio
		''' </summary>
		Public Overridable  ReadOnly Property MscrecepcionCanalesCabEntityUsingFolioMovimientoFolioSacrificio() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscrecepcionCanalesCabFieldIndex.FolioMovimiento), EntityFieldFactory.Create(MscrecepcionCanalesDetFieldIndex.FolioMovimiento))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscrecepcionCanalesCabFieldIndex.FolioSacrificio), EntityFieldFactory.Create(MscrecepcionCanalesDetFieldIndex.FolioSacrificio))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscrecepcionCanalesCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscrecepcionCanalesDetEntity", True)
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
