' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 11 de diciembre de 2017 20:57:23
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
	''' Implements the Shared Relations variant for the entity: TipoMoneda.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class TipoMonedaRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between TipoMonedaEntity and McomCotizacionCompraProveedorDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' TipoMoneda.Codigo - McomCotizacionCompraProveedorDetalle.IdMoneda
		''' </summary>
		Public Overridable ReadOnly Property McomCotizacionCompraProveedorDetalleEntityUsingIdMoneda() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), EntityFieldFactory.Create(McomCotizacionCompraProveedorDetalleFieldIndex.IdMoneda))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoMonedaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McomCotizacionCompraProveedorDetalleEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between TipoMonedaEntity and OrdenCompraEntity over the 1:n relation they have, using the relation between the fields:
		''' TipoMoneda.Codigo - OrdenCompra.IdMoneda
		''' </summary>
		Public Overridable ReadOnly Property OrdenCompraEntityUsingIdMoneda() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), EntityFieldFactory.Create(OrdenCompraFieldIndex.IdMoneda))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoMonedaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenCompraEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between TipoMonedaEntity and OrdenCompraDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' TipoMoneda.Codigo - OrdenCompraDetalle.IdMoneda
		''' </summary>
		Public Overridable ReadOnly Property OrdenCompraDetalleEntityUsingIdMoneda() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), EntityFieldFactory.Create(OrdenCompraDetalleFieldIndex.IdMoneda))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoMonedaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenCompraDetalleEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between TipoMonedaEntity and CuentaEntity over the 1:n relation they have, using the relation between the fields:
		''' TipoMoneda.Codigo - Cuenta.TipomonedaId
		''' </summary>
		Public Overridable ReadOnly Property CuentaEntityUsingTipomonedaId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), EntityFieldFactory.Create(CuentaFieldIndex.TipomonedaId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoMonedaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CuentaEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between TipoMonedaEntity and TipoCambioEntity over the 1:n relation they have, using the relation between the fields:
		''' TipoMoneda.Codigo - TipoCambio.TipomonedaId
		''' </summary>
		Public Overridable ReadOnly Property TipoCambioEntityUsingTipomonedaId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), EntityFieldFactory.Create(TipoCambioFieldIndex.TipomonedaId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoMonedaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoCambioEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between TipoMonedaEntity and CotizacionServicioEntity over the 1:n relation they have, using the relation between the fields:
		''' TipoMoneda.Codigo - CotizacionServicio.TipoMonedaId
		''' </summary>
		Public Overridable ReadOnly Property CotizacionServicioEntityUsingTipoMonedaId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), EntityFieldFactory.Create(CotizacionServicioFieldIndex.TipoMonedaId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoMonedaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CotizacionServicioEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between TipoMonedaEntity and OrdenServicioEntity over the 1:n relation they have, using the relation between the fields:
		''' TipoMoneda.Codigo - OrdenServicio.MonedaId
		''' </summary>
		Public Overridable ReadOnly Property OrdenServicioEntityUsingMonedaId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), EntityFieldFactory.Create(OrdenServicioFieldIndex.MonedaId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoMonedaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdenServicioEntity", False)
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
