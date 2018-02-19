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
	''' Implements the Shared Relations variant for the entity: ConCfgCtas.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class ConCfgCtasRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
		''' <summary>Returns a new IEntityRelation Object, between ConCfgCtasEntity and CfgCtrlCtasEntity over the 1:1 relation they have, using the relation between the fields:
		''' ConCfgCtas.IdConCfgCtas - CfgCtrlCtas.IdConCfgCtas
		''' </summary>
		Public Overridable  ReadOnly Property CfgCtrlCtasEntityUsingIdConCfgCtas() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne)
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ConCfgCtasFieldIndex.IdConCfgCtas), EntityFieldFactory.Create(CfgCtrlCtasFieldIndex.IdConCfgCtas))



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ConCfgCtasEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CfgCtrlCtasEntity", False)
				relation.StartEntityIsPkSide = True
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
