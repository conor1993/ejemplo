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
	''' Implements the Shared Relations variant for the entity: ProductoCostoIndirecto.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class ProductoCostoIndirectoRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoCostoIndirectoEntity and CostoIndirectoEntity over the m:1 relation they have, using the relation between the fields:
		''' ProductoCostoIndirecto.CodigoCostoIndirecto - CostoIndirecto.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property CostoIndirectoEntityUsingCodigoCostoIndirecto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CostoIndirectoFieldIndex.Codigo), EntityFieldFactory.Create(ProductoCostoIndirectoFieldIndex.CodigoCostoIndirecto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CostoIndirectoEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoCostoIndirectoEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ProductoCostoIndirectoEntity and ProductoEntity over the m:1 relation they have, using the relation between the fields:
		''' ProductoCostoIndirecto.CodigoProducto - Producto.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property ProductoEntityUsingCodigoProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(ProductoCostoIndirectoFieldIndex.CodigoProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoCostoIndirectoEntity", True)
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
