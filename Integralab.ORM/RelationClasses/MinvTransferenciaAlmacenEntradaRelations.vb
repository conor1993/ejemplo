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
	''' Implements the Shared Relations variant for the entity: MinvTransferenciaAlmacenEntrada.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class MinvTransferenciaAlmacenEntradaRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between MinvTransferenciaAlmacenEntradaEntity and MinvTransferenciaAlmacenEntradaDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' MinvTransferenciaAlmacenEntrada.FolioTransferencia - MinvTransferenciaAlmacenEntradaDetalle.FolioTransferencia
		''' </summary>
		Public Overridable ReadOnly Property MinvTransferenciaAlmacenEntradaDetalleEntityUsingFolioTransferencia() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MinvTransferenciaAlmacenEntradaFieldIndex.FolioTransferencia), EntityFieldFactory.Create(MinvTransferenciaAlmacenEntradaDetalleFieldIndex.FolioTransferencia))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenEntradaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenEntradaDetalleEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between MinvTransferenciaAlmacenEntradaEntity and AlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' MinvTransferenciaAlmacenEntrada.IdAlmacenDestino - Almacen.AlmacenId
		''' </summary>
		Public Overridable  ReadOnly Property AlmacenEntityUsingIdAlmacenDestino() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(MinvTransferenciaAlmacenEntradaFieldIndex.IdAlmacenDestino))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenEntradaEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MinvTransferenciaAlmacenEntradaEntity and AlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' MinvTransferenciaAlmacenEntrada.IdAlmacenOrigen - Almacen.AlmacenId
		''' </summary>
		Public Overridable  ReadOnly Property AlmacenEntityUsingIdAlmacenOrigen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(MinvTransferenciaAlmacenEntradaFieldIndex.IdAlmacenOrigen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenEntradaEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MinvTransferenciaAlmacenEntradaEntity and InventarioMovimientoAlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' MinvTransferenciaAlmacenEntrada.IdAlmacenDestino - InventarioMovimientoAlmacen.AlmacenId
		''' MinvTransferenciaAlmacenEntrada.FolioMovmientoAlmacen - InventarioMovimientoAlmacen.FolioMovimiento
		''' </summary>
		Public Overridable  ReadOnly Property InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(MinvTransferenciaAlmacenEntradaFieldIndex.IdAlmacenDestino))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(MinvTransferenciaAlmacenEntradaFieldIndex.FolioMovmientoAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenEntradaEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MinvTransferenciaAlmacenEntradaEntity and InventarioMovimientoAlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' MinvTransferenciaAlmacenEntrada.IdAlmacenDestino - InventarioMovimientoAlmacen.AlmacenId
		''' MinvTransferenciaAlmacenEntrada.FolioMovmientoAlmacenCancelacion - InventarioMovimientoAlmacen.FolioMovimiento
		''' </summary>
		Public Overridable  ReadOnly Property InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(MinvTransferenciaAlmacenEntradaFieldIndex.IdAlmacenDestino))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(MinvTransferenciaAlmacenEntradaFieldIndex.FolioMovmientoAlmacenCancelacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenEntradaEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MinvTransferenciaAlmacenEntradaEntity and MinvTransferenciaAlmacenSalidaEntity over the m:1 relation they have, using the relation between the fields:
		''' MinvTransferenciaAlmacenEntrada.FolioTransferenciaSalida - MinvTransferenciaAlmacenSalida.FolioTransferencia
		''' </summary>
		Public Overridable  ReadOnly Property MinvTransferenciaAlmacenSalidaEntityUsingFolioTransferenciaSalida() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MinvTransferenciaAlmacenSalidaFieldIndex.FolioTransferencia), EntityFieldFactory.Create(MinvTransferenciaAlmacenEntradaFieldIndex.FolioTransferenciaSalida))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenSalidaEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenEntradaEntity", True)
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
