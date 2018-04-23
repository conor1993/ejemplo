' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 23 de abril de 2018 15:21:55
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
	''' Implements the Shared Relations variant for the entity: AplicMediDetDet.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class AplicMediDetDetRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between AplicMediDetDetEntity and AplicMediEntity over the m:1 relation they have, using the relation between the fields:
		''' AplicMediDetDet.FolioAplicacionMedicamento - AplicMedi.FolAplicMedi
		''' </summary>
		Public Overridable  ReadOnly Property AplicMediEntityUsingFolioAplicacionMedicamento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AplicMediFieldIndex.FolAplicMedi), EntityFieldFactory.Create(AplicMediDetDetFieldIndex.FolioAplicacionMedicamento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AplicMediEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AplicMediDetDetEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between AplicMediDetDetEntity and AplicMediDetEntity over the m:1 relation they have, using the relation between the fields:
		''' AplicMediDetDet.FolioAplicacionMedicamento - AplicMediDet.FolioAplicacionMedicamento
		''' AplicMediDetDet.IdLote - AplicMediDet.IdLote
		''' AplicMediDetDet.IdMedicamento - AplicMediDet.IdMedicamento
		''' AplicMediDetDet.IdCorral - AplicMediDet.IdCorral
		''' </summary>
		Public Overridable  ReadOnly Property AplicMediDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AplicMediDetFieldIndex.FolioAplicacionMedicamento), EntityFieldFactory.Create(AplicMediDetDetFieldIndex.FolioAplicacionMedicamento))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AplicMediDetFieldIndex.IdLote), EntityFieldFactory.Create(AplicMediDetDetFieldIndex.IdLote))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AplicMediDetFieldIndex.IdMedicamento), EntityFieldFactory.Create(AplicMediDetDetFieldIndex.IdMedicamento))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AplicMediDetFieldIndex.IdCorral), EntityFieldFactory.Create(AplicMediDetDetFieldIndex.IdCorral))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AplicMediDetEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AplicMediDetDetEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between AplicMediDetDetEntity and ProductoEntity over the m:1 relation they have, using the relation between the fields:
		''' AplicMediDetDet.IdMedicamento - Producto.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property ProductoEntityUsingIdMedicamento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(AplicMediDetDetFieldIndex.IdMedicamento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AplicMediDetDetEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between AplicMediDetDetEntity and McecatCorralesCabEntity over the m:1 relation they have, using the relation between the fields:
		''' AplicMediDetDet.IdCorral - McecatCorralesCab.IdCorral
		''' </summary>
		Public Overridable  ReadOnly Property McecatCorralesCabEntityUsingIdCorral() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), EntityFieldFactory.Create(AplicMediDetDetFieldIndex.IdCorral))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McecatCorralesCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AplicMediDetDetEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between AplicMediDetDetEntity and McecatLotesCabEntity over the m:1 relation they have, using the relation between the fields:
		''' AplicMediDetDet.IdLote - McecatLotesCab.IdLote
		''' </summary>
		Public Overridable  ReadOnly Property McecatLotesCabEntityUsingIdLote() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), EntityFieldFactory.Create(AplicMediDetDetFieldIndex.IdLote))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McecatLotesCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AplicMediDetDetEntity", True)
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
