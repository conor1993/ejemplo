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
	''' Implements the Shared Relations variant for the entity: SolicitudServiciosDetalle.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class SolicitudServiciosDetalleRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between SolicitudServiciosDetalleEntity and CotizacionServicioDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' SolicitudServiciosDetalle.Folio - CotizacionServicioDetalle.FolioSolicitud
		''' SolicitudServiciosDetalle.Indice - CotizacionServicioDetalle.Indice
		''' </summary>
		Public Overridable ReadOnly Property CotizacionServicioDetalleEntityUsingFolioSolicitudIndice() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SolicitudServiciosDetalleFieldIndex.Folio), EntityFieldFactory.Create(CotizacionServicioDetalleFieldIndex.FolioSolicitud))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SolicitudServiciosDetalleFieldIndex.Indice), EntityFieldFactory.Create(CotizacionServicioDetalleFieldIndex.Indice))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SolicitudServiciosDetalleEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CotizacionServicioDetalleEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between SolicitudServiciosDetalleEntity and OrdenServicioDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' SolicitudServiciosDetalle.Folio - OrdenServicioDetalle.FolioDetalleSolicitud
		''' SolicitudServiciosDetalle.Indice - OrdenServicioDetalle.Indice
		''' </summary>
		Public Overridable ReadOnly Property OrdenServicioDetalleEntityUsingFolioDetalleSolicitudIndice() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SolicitudServiciosDetalleFieldIndex.Folio), EntityFieldFactory.Create(OrdenServicioDetalleFieldIndex.FolioDetalleSolicitud))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SolicitudServiciosDetalleFieldIndex.Indice), EntityFieldFactory.Create(OrdenServicioDetalleFieldIndex.Indice))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SolicitudServiciosDetalleEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenServicioDetalleEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between SolicitudServiciosDetalleEntity and SolicitudServiciosEntity over the m:1 relation they have, using the relation between the fields:
		''' SolicitudServiciosDetalle.Folio - SolicitudServicios.Folio
		''' </summary>
		Public Overridable  ReadOnly Property SolicitudServiciosEntityUsingFolio() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SolicitudServiciosFieldIndex.Folio), EntityFieldFactory.Create(SolicitudServiciosDetalleFieldIndex.Folio))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SolicitudServiciosEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SolicitudServiciosDetalleEntity", True)
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
