' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 5 de enero de 2018 17:48:18
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
	''' Implements the Shared Relations variant for the entity: SalidaGanadoCab.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class SalidaGanadoCabRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between SalidaGanadoCabEntity and CabFacturasEntity over the 1:n relation they have, using the relation between the fields:
		''' SalidaGanadoCab.IdSalidaGanadoCab - CabFacturas.Referencia
		''' </summary>
		Public Overridable ReadOnly Property CabFacturasEntityUsingReferencia() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SalidaGanadoCabFieldIndex.IdSalidaGanadoCab), EntityFieldFactory.Create(CabFacturasFieldIndex.Referencia))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalidaGanadoCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabFacturasEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between SalidaGanadoCabEntity and ConLotSacEntity over the 1:n relation they have, using the relation between the fields:
		''' SalidaGanadoCab.IdSalidaGanadoCab - ConLotSac.IdSalidaGanadoRastro
		''' </summary>
		Public Overridable ReadOnly Property ConLotSacEntityUsingIdSalidaGanadoRastro() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SalidaGanadoCabFieldIndex.IdSalidaGanadoCab), EntityFieldFactory.Create(ConLotSacFieldIndex.IdSalidaGanadoRastro))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalidaGanadoCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ConLotSacEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between SalidaGanadoCabEntity and ProrraRecEntity over the 1:n relation they have, using the relation between the fields:
		''' SalidaGanadoCab.IdSalidaGanadoCab - ProrraRec.IdSalidaGanadoCab
		''' </summary>
		Public Overridable ReadOnly Property ProrraRecEntityUsingIdSalidaGanadoCab() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SalidaGanadoCabFieldIndex.IdSalidaGanadoCab), EntityFieldFactory.Create(ProrraRecFieldIndex.IdSalidaGanadoCab))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalidaGanadoCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProrraRecEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between SalidaGanadoCabEntity and SalidaGanadoDetEntity over the 1:n relation they have, using the relation between the fields:
		''' SalidaGanadoCab.IdSalidaGanadoCab - SalidaGanadoDet.IdSalidaGanadoCab
		''' </summary>
		Public Overridable ReadOnly Property SalidaGanadoDetEntityUsingIdSalidaGanadoCab() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SalidaGanadoCabFieldIndex.IdSalidaGanadoCab), EntityFieldFactory.Create(SalidaGanadoDetFieldIndex.IdSalidaGanadoCab))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalidaGanadoCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalidaGanadoDetEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between SalidaGanadoCabEntity and CabMovGanEntity over the m:1 relation they have, using the relation between the fields:
		''' SalidaGanadoCab.FolioMovimientoGanado - CabMovGan.FolMovGan
		''' </summary>
		Public Overridable  ReadOnly Property CabMovGanEntityUsingFolioMovimientoGanado() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), EntityFieldFactory.Create(SalidaGanadoCabFieldIndex.FolioMovimientoGanado))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabMovGanEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalidaGanadoCabEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between SalidaGanadoCabEntity and McecatLotesCabEntity over the m:1 relation they have, using the relation between the fields:
		''' SalidaGanadoCab.IdLoteDestino - McecatLotesCab.IdLote
		''' </summary>
		Public Overridable  ReadOnly Property McecatLotesCabEntityUsingIdLoteDestino() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), EntityFieldFactory.Create(SalidaGanadoCabFieldIndex.IdLoteDestino))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McecatLotesCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalidaGanadoCabEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between SalidaGanadoCabEntity and McgcatCausasMuerteEntity over the m:1 relation they have, using the relation between the fields:
		''' SalidaGanadoCab.IdCausaMuerte - McgcatCausasMuerte.IdCausaMuerte
		''' </summary>
		Public Overridable  ReadOnly Property McgcatCausasMuerteEntityUsingIdCausaMuerte() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McgcatCausasMuerteFieldIndex.IdCausaMuerte), EntityFieldFactory.Create(SalidaGanadoCabFieldIndex.IdCausaMuerte))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McgcatCausasMuerteEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalidaGanadoCabEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between SalidaGanadoCabEntity and CatRastrosEntity over the m:1 relation they have, using the relation between the fields:
		''' SalidaGanadoCab.IdRastro - CatRastros.IdRastro
		''' </summary>
		Public Overridable  ReadOnly Property CatRastrosEntityUsingIdRastro() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CatRastrosFieldIndex.IdRastro), EntityFieldFactory.Create(SalidaGanadoCabFieldIndex.IdRastro))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CatRastrosEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalidaGanadoCabEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between SalidaGanadoCabEntity and McecatCorralesCabEntity over the m:1 relation they have, using the relation between the fields:
		''' SalidaGanadoCab.IdCorral - McecatCorralesCab.IdCorral
		''' </summary>
		Public Overridable  ReadOnly Property McecatCorralesCabEntityUsingIdCorral() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), EntityFieldFactory.Create(SalidaGanadoCabFieldIndex.IdCorral))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McecatCorralesCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalidaGanadoCabEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between SalidaGanadoCabEntity and PolizaEntity over the m:1 relation they have, using the relation between the fields:
		''' SalidaGanadoCab.IdPoliza - Poliza.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property PolizaEntityUsingIdPoliza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), EntityFieldFactory.Create(SalidaGanadoCabFieldIndex.IdPoliza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PolizaEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalidaGanadoCabEntity", True)
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
