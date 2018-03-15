' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 15 de marzo de 2018 12:00:00
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
	''' Implements the Shared Relations variant for the entity: SalidaGanadoDet.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class SalidaGanadoDetRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between SalidaGanadoDetEntity and McecatLotesCabEntity over the m:1 relation they have, using the relation between the fields:
		''' SalidaGanadoDet.IdLote - McecatLotesCab.IdLote
		''' </summary>
		Public Overridable  ReadOnly Property McecatLotesCabEntityUsingIdLote() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), EntityFieldFactory.Create(SalidaGanadoDetFieldIndex.IdLote))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McecatLotesCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalidaGanadoDetEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between SalidaGanadoDetEntity and McecatLotesDetEntity over the m:1 relation they have, using the relation between the fields:
		''' SalidaGanadoDet.IdMcecatLotesDet - McecatLotesDet.IdMcecatLotesDet
		''' </summary>
		Public Overridable  ReadOnly Property McecatLotesDetEntityUsingIdMcecatLotesDet() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McecatLotesDetFieldIndex.IdMcecatLotesDet), EntityFieldFactory.Create(SalidaGanadoDetFieldIndex.IdMcecatLotesDet))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McecatLotesDetEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalidaGanadoDetEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between SalidaGanadoDetEntity and McgcatTiposdeGanadoEntity over the m:1 relation they have, using the relation between the fields:
		''' SalidaGanadoDet.IdTipoGanado - McgcatTiposdeGanado.IdTipoGanado
		''' </summary>
		Public Overridable  ReadOnly Property McgcatTiposdeGanadoEntityUsingIdTipoGanado() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McgcatTiposdeGanadoFieldIndex.IdTipoGanado), EntityFieldFactory.Create(SalidaGanadoDetFieldIndex.IdTipoGanado))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McgcatTiposdeGanadoEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalidaGanadoDetEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between SalidaGanadoDetEntity and SalidaGanadoCabEntity over the m:1 relation they have, using the relation between the fields:
		''' SalidaGanadoDet.IdSalidaGanadoCab - SalidaGanadoCab.IdSalidaGanadoCab
		''' </summary>
		Public Overridable  ReadOnly Property SalidaGanadoCabEntityUsingIdSalidaGanadoCab() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SalidaGanadoCabFieldIndex.IdSalidaGanadoCab), EntityFieldFactory.Create(SalidaGanadoDetFieldIndex.IdSalidaGanadoCab))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalidaGanadoCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalidaGanadoDetEntity", True)
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
