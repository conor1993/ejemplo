' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 12 de julio de 2018 16:37:29
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
	''' Implements the Shared Relations variant for the entity: InventarioMovimientoAlmacen.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class InventarioMovimientoAlmacenRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between InventarioMovimientoAlmacenEntity and AplicMediEntity over the 1:n relation they have, using the relation between the fields:
		''' InventarioMovimientoAlmacen.AlmacenId - AplicMedi.IdAlmacen
		''' InventarioMovimientoAlmacen.FolioMovimiento - AplicMedi.FolioMovimientoAlmacen
		''' </summary>
		Public Overridable ReadOnly Property AplicMediEntityUsingIdAlmacenFolioMovimientoAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(AplicMediFieldIndex.IdAlmacen))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(AplicMediFieldIndex.FolioMovimientoAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AplicMediEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between InventarioMovimientoAlmacenEntity and AplicMediEntity over the 1:n relation they have, using the relation between the fields:
		''' InventarioMovimientoAlmacen.AlmacenId - AplicMedi.IdAlmacen
		''' InventarioMovimientoAlmacen.FolioMovimiento - AplicMedi.FolioMovimientoAlmacenCancelacion
		''' </summary>
		Public Overridable ReadOnly Property AplicMediEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(AplicMediFieldIndex.IdAlmacen))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(AplicMediFieldIndex.FolioMovimientoAlmacenCancelacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AplicMediEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between InventarioMovimientoAlmacenEntity and CabAplForEntity over the 1:n relation they have, using the relation between the fields:
		''' InventarioMovimientoAlmacen.AlmacenId - CabAplFor.IdAlmacen
		''' InventarioMovimientoAlmacen.FolioMovimiento - CabAplFor.FolioMovimientoAlmacen
		''' </summary>
		Public Overridable ReadOnly Property CabAplForEntityUsingIdAlmacenFolioMovimientoAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(CabAplForFieldIndex.IdAlmacen))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(CabAplForFieldIndex.FolioMovimientoAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabAplForEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between InventarioMovimientoAlmacenEntity and CabAplForEntity over the 1:n relation they have, using the relation between the fields:
		''' InventarioMovimientoAlmacen.AlmacenId - CabAplFor.IdAlmacen
		''' InventarioMovimientoAlmacen.FolioMovimiento - CabAplFor.FolioMovimientoAlmacenCancelacion
		''' </summary>
		Public Overridable ReadOnly Property CabAplForEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(CabAplForFieldIndex.IdAlmacen))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(CabAplForFieldIndex.FolioMovimientoAlmacenCancelacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabAplForEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between InventarioMovimientoAlmacenEntity and CabPrepFormEntity over the 1:n relation they have, using the relation between the fields:
		''' InventarioMovimientoAlmacen.AlmacenId - CabPrepForm.CveAlmacen
		''' InventarioMovimientoAlmacen.FolioMovimiento - CabPrepForm.FolioMovimientoAlmacenEntradaFormula
		''' </summary>
		Public Overridable ReadOnly Property CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(CabPrepFormFieldIndex.CveAlmacen))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(CabPrepFormFieldIndex.FolioMovimientoAlmacenEntradaFormula))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabPrepFormEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between InventarioMovimientoAlmacenEntity and CabPrepFormEntity over the 1:n relation they have, using the relation between the fields:
		''' InventarioMovimientoAlmacen.AlmacenId - CabPrepForm.CveAlmacen
		''' InventarioMovimientoAlmacen.FolioMovimiento - CabPrepForm.FolioMovimientoAlmacenCancelacionEntradaFormula
		''' </summary>
		Public Overridable ReadOnly Property CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(CabPrepFormFieldIndex.CveAlmacen))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(CabPrepFormFieldIndex.FolioMovimientoAlmacenCancelacionEntradaFormula))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabPrepFormEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between InventarioMovimientoAlmacenEntity and CabPrepFormEntity over the 1:n relation they have, using the relation between the fields:
		''' InventarioMovimientoAlmacen.AlmacenId - CabPrepForm.CveAlmacen
		''' InventarioMovimientoAlmacen.FolioMovimiento - CabPrepForm.FolioMovimientoAlmacenSalidaIngredientes
		''' </summary>
		Public Overridable ReadOnly Property CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(CabPrepFormFieldIndex.CveAlmacen))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(CabPrepFormFieldIndex.FolioMovimientoAlmacenSalidaIngredientes))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabPrepFormEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between InventarioMovimientoAlmacenEntity and CabPrepFormEntity over the 1:n relation they have, using the relation between the fields:
		''' InventarioMovimientoAlmacen.AlmacenId - CabPrepForm.CveAlmacen
		''' InventarioMovimientoAlmacen.FolioMovimiento - CabPrepForm.FolioMovimientoAlmacenCancelacionSalidaIngredientes
		''' </summary>
		Public Overridable ReadOnly Property CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(CabPrepFormFieldIndex.CveAlmacen))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(CabPrepFormFieldIndex.FolioMovimientoAlmacenCancelacionSalidaIngredientes))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabPrepFormEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between InventarioMovimientoAlmacenEntity and CabProMedEntity over the 1:n relation they have, using the relation between the fields:
		''' InventarioMovimientoAlmacen.AlmacenId - CabProMed.IdAlmacen
		''' InventarioMovimientoAlmacen.FolioMovimiento - CabProMed.FolioMovimientoAlmacenSalida
		''' </summary>
		Public Overridable ReadOnly Property CabProMedEntityUsingIdAlmacenFolioMovimientoAlmacenSalida() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(CabProMedFieldIndex.IdAlmacen))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(CabProMedFieldIndex.FolioMovimientoAlmacenSalida))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabProMedEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between InventarioMovimientoAlmacenEntity and InventarioMovimientoAlmacenDetallesEntity over the 1:n relation they have, using the relation between the fields:
		''' InventarioMovimientoAlmacen.AlmacenId - InventarioMovimientoAlmacenDetalles.AlmacenId
		''' InventarioMovimientoAlmacen.FolioMovimiento - InventarioMovimientoAlmacenDetalles.FolioMovimiento
		''' </summary>
		Public Overridable ReadOnly Property InventarioMovimientoAlmacenDetallesEntityUsingAlmacenIdFolioMovimiento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(InventarioMovimientoAlmacenDetallesFieldIndex.AlmacenId))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(InventarioMovimientoAlmacenDetallesFieldIndex.FolioMovimiento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenDetallesEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between InventarioMovimientoAlmacenEntity and MinvTransferenciaAlmacenEntradaEntity over the 1:n relation they have, using the relation between the fields:
		''' InventarioMovimientoAlmacen.AlmacenId - MinvTransferenciaAlmacenEntrada.IdAlmacenDestino
		''' InventarioMovimientoAlmacen.FolioMovimiento - MinvTransferenciaAlmacenEntrada.FolioMovmientoAlmacen
		''' </summary>
		Public Overridable ReadOnly Property MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(MinvTransferenciaAlmacenEntradaFieldIndex.IdAlmacenDestino))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(MinvTransferenciaAlmacenEntradaFieldIndex.FolioMovmientoAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenEntradaEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between InventarioMovimientoAlmacenEntity and MinvTransferenciaAlmacenEntradaEntity over the 1:n relation they have, using the relation between the fields:
		''' InventarioMovimientoAlmacen.AlmacenId - MinvTransferenciaAlmacenEntrada.IdAlmacenDestino
		''' InventarioMovimientoAlmacen.FolioMovimiento - MinvTransferenciaAlmacenEntrada.FolioMovmientoAlmacenCancelacion
		''' </summary>
		Public Overridable ReadOnly Property MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(MinvTransferenciaAlmacenEntradaFieldIndex.IdAlmacenDestino))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(MinvTransferenciaAlmacenEntradaFieldIndex.FolioMovmientoAlmacenCancelacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenEntradaEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between InventarioMovimientoAlmacenEntity and MinvTransferenciaAlmacenSalidaEntity over the 1:n relation they have, using the relation between the fields:
		''' InventarioMovimientoAlmacen.AlmacenId - MinvTransferenciaAlmacenSalida.IdAlmacenOrigen
		''' InventarioMovimientoAlmacen.FolioMovimiento - MinvTransferenciaAlmacenSalida.FolioMovimiento
		''' </summary>
		Public Overridable ReadOnly Property MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigenFolioMovimiento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(MinvTransferenciaAlmacenSalidaFieldIndex.IdAlmacenOrigen))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(MinvTransferenciaAlmacenSalidaFieldIndex.FolioMovimiento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenSalidaEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between InventarioMovimientoAlmacenEntity and MinvTransferenciaAlmacenSalidaEntity over the 1:n relation they have, using the relation between the fields:
		''' InventarioMovimientoAlmacen.AlmacenId - MinvTransferenciaAlmacenSalida.IdAlmacenOrigen
		''' InventarioMovimientoAlmacen.FolioMovimiento - MinvTransferenciaAlmacenSalida.FolioMovimientoCancelacion
		''' </summary>
		Public Overridable ReadOnly Property MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(MinvTransferenciaAlmacenSalidaFieldIndex.IdAlmacenOrigen))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(MinvTransferenciaAlmacenSalidaFieldIndex.FolioMovimientoCancelacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenSalidaEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between InventarioMovimientoAlmacenEntity and AlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' InventarioMovimientoAlmacen.AlmacenId - Almacen.AlmacenId
		''' </summary>
		Public Overridable  ReadOnly Property AlmacenEntityUsingAlmacenId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between InventarioMovimientoAlmacenEntity and TipoMovimientoAlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' InventarioMovimientoAlmacen.TipoMovimientoId - TipoMovimientoAlmacen.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property TipoMovimientoAlmacenEntityUsingTipoMovimientoId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoMovimientoAlmacenFieldIndex.Codigo), EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.TipoMovimientoId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoMovimientoAlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", True)
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
