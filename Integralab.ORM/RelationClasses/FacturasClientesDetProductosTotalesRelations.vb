﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 12 de julio de 2018 17:42:59
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
	''' Implements the Shared Relations variant for the entity: FacturasClientesDetProductosTotales.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class FacturasClientesDetProductosTotalesRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between FacturasClientesDetProductosTotalesEntity and FacturasClientesCabEntity over the m:1 relation they have, using the relation between the fields:
		''' FacturasClientesDetProductosTotales.SerieFactura - FacturasClientesCab.Serie
		''' FacturasClientesDetProductosTotales.NoFactura - FacturasClientesCab.NoFactura
		''' </summary>
		Public Overridable  ReadOnly Property FacturasClientesCabEntityUsingSerieFacturaNoFactura() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(FacturasClientesCabFieldIndex.Serie), EntityFieldFactory.Create(FacturasClientesDetProductosTotalesFieldIndex.SerieFactura))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(FacturasClientesCabFieldIndex.NoFactura), EntityFieldFactory.Create(FacturasClientesDetProductosTotalesFieldIndex.NoFactura))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FacturasClientesCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FacturasClientesDetProductosTotalesEntity", True)
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
