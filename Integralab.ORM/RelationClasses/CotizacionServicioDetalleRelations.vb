' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 8 de febrero de 2018 08:45:15
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
	''' Implements the Shared Relations variant for the entity: CotizacionServicioDetalle.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class CotizacionServicioDetalleRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between CotizacionServicioDetalleEntity and CotizacionServicioEntity over the m:1 relation they have, using the relation between the fields:
		''' CotizacionServicioDetalle.FolioCotizacion - CotizacionServicio.Folio
		''' </summary>
		Public Overridable  ReadOnly Property CotizacionServicioEntityUsingFolioCotizacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CotizacionServicioFieldIndex.Folio), EntityFieldFactory.Create(CotizacionServicioDetalleFieldIndex.FolioCotizacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CotizacionServicioEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CotizacionServicioDetalleEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between CotizacionServicioDetalleEntity and SolicitudServiciosDetalleEntity over the m:1 relation they have, using the relation between the fields:
		''' CotizacionServicioDetalle.FolioSolicitud - SolicitudServiciosDetalle.Folio
		''' CotizacionServicioDetalle.Indice - SolicitudServiciosDetalle.Indice
		''' </summary>
		Public Overridable  ReadOnly Property SolicitudServiciosDetalleEntityUsingFolioSolicitudIndice() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SolicitudServiciosDetalleFieldIndex.Folio), EntityFieldFactory.Create(CotizacionServicioDetalleFieldIndex.FolioSolicitud))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SolicitudServiciosDetalleFieldIndex.Indice), EntityFieldFactory.Create(CotizacionServicioDetalleFieldIndex.Indice))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SolicitudServiciosDetalleEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CotizacionServicioDetalleEntity", True)
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
