﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 12 de julio de 2018 17:43:00
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
	''' Implements the Shared Relations variant for the entity: CabMovGan.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class CabMovGanRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between CabMovGanEntity and CabRegComEntity over the 1:n relation they have, using the relation between the fields:
		''' CabMovGan.FolMovGan - CabRegCom.FolioMovimientoGanado
		''' </summary>
		Public Overridable ReadOnly Property CabRegComEntityUsingFolioMovimientoGanado() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), EntityFieldFactory.Create(CabRegComFieldIndex.FolioMovimientoGanado))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabMovGanEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabRegComEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between CabMovGanEntity and CabRegComEntity over the 1:n relation they have, using the relation between the fields:
		''' CabMovGan.FolMovGan - CabRegCom.FolioMovimientoGanadoCancelacion
		''' </summary>
		Public Overridable ReadOnly Property CabRegComEntityUsingFolioMovimientoGanadoCancelacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), EntityFieldFactory.Create(CabRegComFieldIndex.FolioMovimientoGanadoCancelacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabMovGanEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabRegComEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between CabMovGanEntity and DetMovGanEntity over the 1:n relation they have, using the relation between the fields:
		''' CabMovGan.FolMovGan - DetMovGan.FolMovGan
		''' </summary>
		Public Overridable ReadOnly Property DetMovGanEntityUsingFolMovGan() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), EntityFieldFactory.Create(DetMovGanFieldIndex.FolMovGan))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabMovGanEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetMovGanEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between CabMovGanEntity and SalidaGanadoCabEntity over the 1:n relation they have, using the relation between the fields:
		''' CabMovGan.FolMovGan - SalidaGanadoCab.FolioMovimientoGanado
		''' </summary>
		Public Overridable ReadOnly Property SalidaGanadoCabEntityUsingFolioMovimientoGanado() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), EntityFieldFactory.Create(SalidaGanadoCabFieldIndex.FolioMovimientoGanado))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabMovGanEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalidaGanadoCabEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between CabMovGanEntity and McgcatMovGanadoEntity over the m:1 relation they have, using the relation between the fields:
		''' CabMovGan.CveMovGan - McgcatMovGanado.IdMovGanado
		''' </summary>
		Public Overridable  ReadOnly Property McgcatMovGanadoEntityUsingCveMovGan() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McgcatMovGanadoFieldIndex.IdMovGanado), EntityFieldFactory.Create(CabMovGanFieldIndex.CveMovGan))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McgcatMovGanadoEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabMovGanEntity", True)
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
