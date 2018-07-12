' ////////////////////////////////////////////////////////////////////////////////////////////////////////
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
	''' Implements the Shared Relations variant for the entity: NotaCreditoDet.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class NotaCreditoDetRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between NotaCreditoDetEntity and FacturasClientesCabEntity over the m:1 relation they have, using the relation between the fields:
		''' NotaCreditoDet.SerieFactura - FacturasClientesCab.Serie
		''' NotaCreditoDet.FolFactura - FacturasClientesCab.NoFactura
		''' </summary>
		Public Overridable  ReadOnly Property FacturasClientesCabEntityUsingSerieFacturaFolFactura() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(FacturasClientesCabFieldIndex.Serie), EntityFieldFactory.Create(NotaCreditoDetFieldIndex.SerieFactura))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(FacturasClientesCabFieldIndex.NoFactura), EntityFieldFactory.Create(NotaCreditoDetFieldIndex.FolFactura))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FacturasClientesCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NotaCreditoDetEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between NotaCreditoDetEntity and NotaCreditoCabEntity over the m:1 relation they have, using the relation between the fields:
		''' NotaCreditoDet.FolNota - NotaCreditoCab.FolNota
		''' </summary>
		Public Overridable  ReadOnly Property NotaCreditoCabEntityUsingFolNota() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(NotaCreditoCabFieldIndex.FolNota), EntityFieldFactory.Create(NotaCreditoDetFieldIndex.FolNota))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NotaCreditoCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NotaCreditoDetEntity", True)
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
