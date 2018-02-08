' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 8 de febrero de 2018 08:45:16
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
	''' Implements the Shared Relations variant for the entity: OrdenServicioDetalle.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class OrdenServicioDetalleRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between OrdenServicioDetalleEntity and OrdenServicioEntity over the m:1 relation they have, using the relation between the fields:
		''' OrdenServicioDetalle.Folio - OrdenServicio.Folio
		''' </summary>
		Public Overridable  ReadOnly Property OrdenServicioEntityUsingFolio() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(OrdenServicioFieldIndex.Folio), EntityFieldFactory.Create(OrdenServicioDetalleFieldIndex.Folio))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenServicioEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenServicioDetalleEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between OrdenServicioDetalleEntity and SolicitudServiciosDetalleEntity over the m:1 relation they have, using the relation between the fields:
		''' OrdenServicioDetalle.FolioDetalleSolicitud - SolicitudServiciosDetalle.Folio
		''' OrdenServicioDetalle.Indice - SolicitudServiciosDetalle.Indice
		''' </summary>
		Public Overridable  ReadOnly Property SolicitudServiciosDetalleEntityUsingFolioDetalleSolicitudIndice() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SolicitudServiciosDetalleFieldIndex.Folio), EntityFieldFactory.Create(OrdenServicioDetalleFieldIndex.FolioDetalleSolicitud))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SolicitudServiciosDetalleFieldIndex.Indice), EntityFieldFactory.Create(OrdenServicioDetalleFieldIndex.Indice))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SolicitudServiciosDetalleEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenServicioDetalleEntity", True)
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
