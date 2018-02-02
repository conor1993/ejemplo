' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de febrero de 2018 11:54:43
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
	''' Implements the Shared Relations variant for the entity: MotivoCancelacion.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class MotivoCancelacionRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between MotivoCancelacionEntity and MotivoCancelacionDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' MotivoCancelacion.IdMotivo - MotivoCancelacionDetalle.Idmotivo
		''' </summary>
		Public Overridable ReadOnly Property MotivoCancelacionDetalleEntityUsingIdmotivo() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MotivoCancelacionFieldIndex.IdMotivo), EntityFieldFactory.Create(MotivoCancelacionDetalleFieldIndex.Idmotivo))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MotivoCancelacionEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MotivoCancelacionDetalleEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MotivoCancelacionEntity and MonedaEntity over the 1:n relation they have, using the relation between the fields:
		''' MotivoCancelacion.IdMotivo - Moneda.MotivoCancelacionId
		''' </summary>
		Public Overridable ReadOnly Property MonedaEntityUsingMotivoCancelacionId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MotivoCancelacionFieldIndex.IdMotivo), EntityFieldFactory.Create(MonedaFieldIndex.MotivoCancelacionId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MotivoCancelacionEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MonedaEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MotivoCancelacionEntity and PresupuestoEntity over the 1:n relation they have, using the relation between the fields:
		''' MotivoCancelacion.IdMotivo - Presupuesto.MotivoCancelacionId
		''' </summary>
		Public Overridable ReadOnly Property PresupuestoEntityUsingMotivoCancelacionId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MotivoCancelacionFieldIndex.IdMotivo), EntityFieldFactory.Create(PresupuestoFieldIndex.MotivoCancelacionId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MotivoCancelacionEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PresupuestoEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MotivoCancelacionEntity and RecepcionOrdenCompraEntity over the 1:n relation they have, using the relation between the fields:
		''' MotivoCancelacion.IdMotivo - RecepcionOrdenCompra.MotivoCancelacionId
		''' </summary>
		Public Overridable ReadOnly Property RecepcionOrdenCompraEntityUsingMotivoCancelacionId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MotivoCancelacionFieldIndex.IdMotivo), EntityFieldFactory.Create(RecepcionOrdenCompraFieldIndex.MotivoCancelacionId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MotivoCancelacionEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecepcionOrdenCompraEntity", False)
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
