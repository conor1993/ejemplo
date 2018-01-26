' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 25 de enero de 2018 11:40:25
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
	''' Implements the Shared Relations variant for the entity: MinvTransferenciaAlmacenEntradaDetalle.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class MinvTransferenciaAlmacenEntradaDetalleRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between MinvTransferenciaAlmacenEntradaDetalleEntity and ProductoEntity over the m:1 relation they have, using the relation between the fields:
		''' MinvTransferenciaAlmacenEntradaDetalle.IdProducto - Producto.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property ProductoEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(MinvTransferenciaAlmacenEntradaDetalleFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenEntradaDetalleEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MinvTransferenciaAlmacenEntradaDetalleEntity and MinvTransferenciaAlmacenEntradaEntity over the m:1 relation they have, using the relation between the fields:
		''' MinvTransferenciaAlmacenEntradaDetalle.FolioTransferencia - MinvTransferenciaAlmacenEntrada.FolioTransferencia
		''' </summary>
		Public Overridable  ReadOnly Property MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferencia() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MinvTransferenciaAlmacenEntradaFieldIndex.FolioTransferencia), EntityFieldFactory.Create(MinvTransferenciaAlmacenEntradaDetalleFieldIndex.FolioTransferencia))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenEntradaEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenEntradaDetalleEntity", True)
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
