' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de marzo de 2018 16:12:33
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
	''' Implements the Shared Relations variant for the entity: PagoCheDevueltoDet.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class PagoCheDevueltoDetRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between PagoCheDevueltoDetEntity and ChequeDevueltoEntity over the m:1 relation they have, using the relation between the fields:
		''' PagoCheDevueltoDet.IdChequeDevuelto - ChequeDevuelto.IdChequeDevuelto
		''' </summary>
		Public Overridable  ReadOnly Property ChequeDevueltoEntityUsingIdChequeDevuelto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ChequeDevueltoFieldIndex.IdChequeDevuelto), EntityFieldFactory.Create(PagoCheDevueltoDetFieldIndex.IdChequeDevuelto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChequeDevueltoEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PagoCheDevueltoDetEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PagoCheDevueltoDetEntity and PagoCheDevueltoCabEntity over the m:1 relation they have, using the relation between the fields:
		''' PagoCheDevueltoDet.IdPagoCheDevueltoCab - PagoCheDevueltoCab.IdPagoCheDevueltoCab
		''' </summary>
		Public Overridable  ReadOnly Property PagoCheDevueltoCabEntityUsingIdPagoCheDevueltoCab() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PagoCheDevueltoCabFieldIndex.IdPagoCheDevueltoCab), EntityFieldFactory.Create(PagoCheDevueltoDetFieldIndex.IdPagoCheDevueltoCab))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PagoCheDevueltoCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PagoCheDevueltoDetEntity", True)
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
