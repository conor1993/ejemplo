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
	''' Implements the Shared Relations variant for the entity: MinvTransferenciaAlmacenSalida.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class MinvTransferenciaAlmacenSalidaRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between MinvTransferenciaAlmacenSalidaEntity and MinvTransferenciaAlmacenEntradaEntity over the 1:n relation they have, using the relation between the fields:
		''' MinvTransferenciaAlmacenSalida.FolioTransferencia - MinvTransferenciaAlmacenEntrada.FolioTransferenciaSalida
		''' </summary>
		Public Overridable ReadOnly Property MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MinvTransferenciaAlmacenSalidaFieldIndex.FolioTransferencia), EntityFieldFactory.Create(MinvTransferenciaAlmacenEntradaFieldIndex.FolioTransferenciaSalida))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenSalidaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenEntradaEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MinvTransferenciaAlmacenSalidaEntity and MinvTransferenciaAlmacenSalidaDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' MinvTransferenciaAlmacenSalida.FolioTransferencia - MinvTransferenciaAlmacenSalidaDetalle.FolioTransferencia
		''' </summary>
		Public Overridable ReadOnly Property MinvTransferenciaAlmacenSalidaDetalleEntityUsingFolioTransferencia() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MinvTransferenciaAlmacenSalidaFieldIndex.FolioTransferencia), EntityFieldFactory.Create(MinvTransferenciaAlmacenSalidaDetalleFieldIndex.FolioTransferencia))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenSalidaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenSalidaDetalleEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between MinvTransferenciaAlmacenSalidaEntity and AlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' MinvTransferenciaAlmacenSalida.IdAlmacenDestino - Almacen.AlmacenId
		''' </summary>
		Public Overridable  ReadOnly Property AlmacenEntityUsingIdAlmacenDestino() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(MinvTransferenciaAlmacenSalidaFieldIndex.IdAlmacenDestino))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenSalidaEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MinvTransferenciaAlmacenSalidaEntity and AlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' MinvTransferenciaAlmacenSalida.IdAlmacenOrigen - Almacen.AlmacenId
		''' </summary>
		Public Overridable  ReadOnly Property AlmacenEntityUsingIdAlmacenOrigen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(MinvTransferenciaAlmacenSalidaFieldIndex.IdAlmacenOrigen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenSalidaEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MinvTransferenciaAlmacenSalidaEntity and InventarioMovimientoAlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' MinvTransferenciaAlmacenSalida.IdAlmacenOrigen - InventarioMovimientoAlmacen.AlmacenId
		''' MinvTransferenciaAlmacenSalida.FolioMovimiento - InventarioMovimientoAlmacen.FolioMovimiento
		''' </summary>
		Public Overridable  ReadOnly Property InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimiento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(MinvTransferenciaAlmacenSalidaFieldIndex.IdAlmacenOrigen))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(MinvTransferenciaAlmacenSalidaFieldIndex.FolioMovimiento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenSalidaEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MinvTransferenciaAlmacenSalidaEntity and InventarioMovimientoAlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' MinvTransferenciaAlmacenSalida.IdAlmacenOrigen - InventarioMovimientoAlmacen.AlmacenId
		''' MinvTransferenciaAlmacenSalida.FolioMovimientoCancelacion - InventarioMovimientoAlmacen.FolioMovimiento
		''' </summary>
		Public Overridable  ReadOnly Property InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(MinvTransferenciaAlmacenSalidaFieldIndex.IdAlmacenOrigen))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), EntityFieldFactory.Create(MinvTransferenciaAlmacenSalidaFieldIndex.FolioMovimientoCancelacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("InventarioMovimientoAlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenSalidaEntity", True)
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
