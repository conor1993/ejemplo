' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 15 de marzo de 2018 11:59:59
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
	''' Implements the Shared Relations variant for the entity: CabRegCom.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class CabRegComRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between CabRegComEntity and DetRegComEntity over the 1:n relation they have, using the relation between the fields:
		''' CabRegCom.FolRecep - DetRegCom.FolRecep
		''' </summary>
		Public Overridable ReadOnly Property DetRegComEntityUsingFolRecep() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CabRegComFieldIndex.FolRecep), EntityFieldFactory.Create(DetRegComFieldIndex.FolRecep))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabRegComEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetRegComEntity", False)
				Return relation
			End Get
		End Property
	
	
		''' <summary>Returns a new IEntityRelation Object, between CabRegComEntity and CabGasTransEntity over the 1:1 relation they have, using the relation between the fields:
		''' CabRegCom.FolRecep - CabGasTrans.FolRecep
		''' </summary>
		Public Overridable  ReadOnly Property CabGasTransEntityUsingFolRecep() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne)
				


				relation.AddEntityFieldPair(EntityFieldFactory.Create(CabGasTransFieldIndex.FolRecep), EntityFieldFactory.Create(CabRegComFieldIndex.FolRecep))

				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabGasTransEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabRegComEntity", True)
				relation.StartEntityIsPkSide = False
				Return relation
			End Get
		End Property
	
	
		''' <summary>Returns a new IEntityRelation Object, between CabRegComEntity and CabMovGanEntity over the m:1 relation they have, using the relation between the fields:
		''' CabRegCom.FolioMovimientoGanado - CabMovGan.FolMovGan
		''' </summary>
		Public Overridable  ReadOnly Property CabMovGanEntityUsingFolioMovimientoGanado() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), EntityFieldFactory.Create(CabRegComFieldIndex.FolioMovimientoGanado))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabMovGanEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabRegComEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between CabRegComEntity and CabMovGanEntity over the m:1 relation they have, using the relation between the fields:
		''' CabRegCom.FolioMovimientoGanadoCancelacion - CabMovGan.FolMovGan
		''' </summary>
		Public Overridable  ReadOnly Property CabMovGanEntityUsingFolioMovimientoGanadoCancelacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), EntityFieldFactory.Create(CabRegComFieldIndex.FolioMovimientoGanadoCancelacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabMovGanEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabRegComEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between CabRegComEntity and CatLugaresDeCompraEntity over the m:1 relation they have, using the relation between the fields:
		''' CabRegCom.CveLugCom - CatLugaresDeCompra.IdLugarCompra
		''' </summary>
		Public Overridable  ReadOnly Property CatLugaresDeCompraEntityUsingCveLugCom() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CatLugaresDeCompraFieldIndex.IdLugarCompra), EntityFieldFactory.Create(CabRegComFieldIndex.CveLugCom))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CatLugaresDeCompraEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabRegComEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between CabRegComEntity and ProveedorEntity over the m:1 relation they have, using the relation between the fields:
		''' CabRegCom.CveProveGan - Proveedor.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property ProveedorEntityUsingCveProveGan() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), EntityFieldFactory.Create(CabRegComFieldIndex.CveProveGan))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProveedorEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabRegComEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between CabRegComEntity and McecatCorralesCabEntity over the m:1 relation they have, using the relation between the fields:
		''' CabRegCom.CveCorral - McecatCorralesCab.IdCorral
		''' </summary>
		Public Overridable  ReadOnly Property McecatCorralesCabEntityUsingCveCorral() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), EntityFieldFactory.Create(CabRegComFieldIndex.CveCorral))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McecatCorralesCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabRegComEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between CabRegComEntity and McgcatCompradoresdeGanadoEntity over the m:1 relation they have, using the relation between the fields:
		''' CabRegCom.CveComiGan - McgcatCompradoresdeGanado.IdComprador
		''' </summary>
		Public Overridable  ReadOnly Property McgcatCompradoresdeGanadoEntityUsingCveComiGan() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McgcatCompradoresdeGanadoFieldIndex.IdComprador), EntityFieldFactory.Create(CabRegComFieldIndex.CveComiGan))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McgcatCompradoresdeGanadoEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabRegComEntity", True)
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
