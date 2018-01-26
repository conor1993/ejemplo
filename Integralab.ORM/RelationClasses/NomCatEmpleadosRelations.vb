' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 26 de enero de 2018 13:41:27
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
	''' Implements the Shared Relations variant for the entity: NomCatEmpleados.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class NomCatEmpleadosRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between NomCatEmpleadosEntity and CatDeptosEntity over the m:1 relation they have, using the relation between the fields:
		''' NomCatEmpleados.IdDepartamento - CatDeptos.CveDepto
		''' </summary>
		Public Overridable  ReadOnly Property CatDeptosEntityUsingIdDepartamento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CatDeptosFieldIndex.CveDepto), EntityFieldFactory.Create(NomCatEmpleadosFieldIndex.IdDepartamento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CatDeptosEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NomCatEmpleadosEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between NomCatEmpleadosEntity and NomCatPuestosEntity over the m:1 relation they have, using the relation between the fields:
		''' NomCatEmpleados.IdPuesto - NomCatPuestos.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property NomCatPuestosEntityUsingIdPuesto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(NomCatPuestosFieldIndex.Codigo), EntityFieldFactory.Create(NomCatEmpleadosFieldIndex.IdPuesto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NomCatPuestosEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NomCatEmpleadosEntity", True)
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
