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
	''' Implements the Shared Relations variant for the entity: MinvTransferenciaAlmacenProdDetalle.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class MinvTransferenciaAlmacenProdDetalleRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between MinvTransferenciaAlmacenProdDetalleEntity and AlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' MinvTransferenciaAlmacenProdDetalle.IdAlmacenOrigen - Almacen.AlmacenId
		''' </summary>
		Public Overridable  ReadOnly Property AlmacenEntityUsingIdAlmacenOrigen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(MinvTransferenciaAlmacenProdDetalleFieldIndex.IdAlmacenOrigen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenProdDetalleEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MinvTransferenciaAlmacenProdDetalleEntity and MinvTransferenciaAlmacenProdEntity over the m:1 relation they have, using the relation between the fields:
		''' MinvTransferenciaAlmacenProdDetalle.FolioTransferencia - MinvTransferenciaAlmacenProd.FolioTransferencia
		''' </summary>
		Public Overridable  ReadOnly Property MinvTransferenciaAlmacenProdEntityUsingFolioTransferencia() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MinvTransferenciaAlmacenProdFieldIndex.FolioTransferencia), EntityFieldFactory.Create(MinvTransferenciaAlmacenProdDetalleFieldIndex.FolioTransferencia))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenProdEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenProdDetalleEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MinvTransferenciaAlmacenProdDetalleEntity and MsccatProductosEntity over the m:1 relation they have, using the relation between the fields:
		''' MinvTransferenciaAlmacenProdDetalle.IdProducto - MsccatProductos.IdProducto
		''' </summary>
		Public Overridable  ReadOnly Property MsccatProductosEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(MinvTransferenciaAlmacenProdDetalleFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenProdDetalleEntity", True)
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
