' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 23 de abril de 2018 15:21:55
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
	''' Implements the Shared Relations variant for the entity: CotizacionServicio.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class CotizacionServicioRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between CotizacionServicioEntity and CotizacionServicioDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' CotizacionServicio.Folio - CotizacionServicioDetalle.FolioCotizacion
		''' </summary>
		Public Overridable ReadOnly Property CotizacionServicioDetalleEntityUsingFolioCotizacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CotizacionServicioFieldIndex.Folio), EntityFieldFactory.Create(CotizacionServicioDetalleFieldIndex.FolioCotizacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CotizacionServicioEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CotizacionServicioDetalleEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between CotizacionServicioEntity and ProveedorEntity over the m:1 relation they have, using the relation between the fields:
		''' CotizacionServicio.ProveedorId - Proveedor.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property ProveedorEntityUsingProveedorId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), EntityFieldFactory.Create(CotizacionServicioFieldIndex.ProveedorId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProveedorEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CotizacionServicioEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between CotizacionServicioEntity and SucursalEntity over the m:1 relation they have, using the relation between the fields:
		''' CotizacionServicio.SucursalId - Sucursal.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property SucursalEntityUsingSucursalId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SucursalFieldIndex.Codigo), EntityFieldFactory.Create(CotizacionServicioFieldIndex.SucursalId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SucursalEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CotizacionServicioEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between CotizacionServicioEntity and TipoMonedaEntity over the m:1 relation they have, using the relation between the fields:
		''' CotizacionServicio.TipoMonedaId - TipoMoneda.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property TipoMonedaEntityUsingTipoMonedaId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), EntityFieldFactory.Create(CotizacionServicioFieldIndex.TipoMonedaId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoMonedaEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CotizacionServicioEntity", True)
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
