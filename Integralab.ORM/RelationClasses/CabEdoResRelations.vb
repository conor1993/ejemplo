' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 30 de abril de 2018 09:07:29
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
	''' Implements the Shared Relations variant for the entity: CabEdoRes.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class CabEdoResRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between CabEdoResEntity and DetEdoResEntity over the 1:n relation they have, using the relation between the fields:
		''' CabEdoRes.CveEdoRes - DetEdoRes.CveEdoRes
		''' </summary>
		Public Overridable ReadOnly Property DetEdoResEntityUsingCveEdoRes() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CabEdoResFieldIndex.CveEdoRes), EntityFieldFactory.Create(DetEdoResFieldIndex.CveEdoRes))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabEdoResEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetEdoResEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between CabEdoResEntity and CatAgrupadoresBalGralEdoResEntity over the m:1 relation they have, using the relation between the fields:
		''' CabEdoRes.IdAgrupador - CatAgrupadoresBalGralEdoRes.Código
		''' </summary>
		Public Overridable  ReadOnly Property CatAgrupadoresBalGralEdoResEntityUsingIdAgrupador() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CatAgrupadoresBalGralEdoResFieldIndex.Código), EntityFieldFactory.Create(CabEdoResFieldIndex.IdAgrupador))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CatAgrupadoresBalGralEdoResEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabEdoResEntity", True)
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
