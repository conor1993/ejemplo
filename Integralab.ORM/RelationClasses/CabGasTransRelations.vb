﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: martes, 26 de diciembre de 2017 16:41:26
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
	''' Implements the Shared Relations variant for the entity: CabGasTrans.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class CabGasTransRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between CabGasTransEntity and DetGasTransEntity over the 1:n relation they have, using the relation between the fields:
		''' CabGasTrans.FolRecep - DetGasTrans.FolRecep
		''' </summary>
		Public Overridable ReadOnly Property DetGasTransEntityUsingFolRecep() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CabGasTransFieldIndex.FolRecep), EntityFieldFactory.Create(DetGasTransFieldIndex.FolRecep))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabGasTransEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetGasTransEntity", False)
				Return relation
			End Get
		End Property
	
	
		''' <summary>Returns a new IEntityRelation Object, between CabGasTransEntity and CabRegComEntity over the 1:1 relation they have, using the relation between the fields:
		''' CabGasTrans.FolRecep - CabRegCom.FolRecep
		''' </summary>
		Public Overridable  ReadOnly Property CabRegComEntityUsingFolRecep() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne)
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CabGasTransFieldIndex.FolRecep), EntityFieldFactory.Create(CabRegComFieldIndex.FolRecep))



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabGasTransEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabRegComEntity", False)
				relation.StartEntityIsPkSide = True
				Return relation
			End Get
		End Property
	
	
		''' <summary>Returns a new IEntityRelation Object, between CabGasTransEntity and McgcatChoferesEntity over the m:1 relation they have, using the relation between the fields:
		''' CabGasTrans.CveChofer - McgcatChoferes.IdChofer
		''' </summary>
		Public Overridable  ReadOnly Property McgcatChoferesEntityUsingCveChofer() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McgcatChoferesFieldIndex.IdChofer), EntityFieldFactory.Create(CabGasTransFieldIndex.CveChofer))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McgcatChoferesEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabGasTransEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between CabGasTransEntity and McgcatVehiculosEntity over the m:1 relation they have, using the relation between the fields:
		''' CabGasTrans.CveVehiculo - McgcatVehiculos.IdVehiculo
		''' </summary>
		Public Overridable  ReadOnly Property McgcatVehiculosEntityUsingCveVehiculo() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McgcatVehiculosFieldIndex.IdVehiculo), EntityFieldFactory.Create(CabGasTransFieldIndex.CveVehiculo))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McgcatVehiculosEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabGasTransEntity", True)
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
