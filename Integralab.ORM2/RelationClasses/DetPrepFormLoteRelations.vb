' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 11 de diciembre de 2017 20:57:26
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
	''' Implements the Shared Relations variant for the entity: DetPrepFormLote.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class DetPrepFormLoteRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between DetPrepFormLoteEntity and CabPrepFormEntity over the m:1 relation they have, using the relation between the fields:
		''' DetPrepFormLote.FolPrepForm - CabPrepForm.FolPrepForm
		''' DetPrepFormLote.IdPlaza - CabPrepForm.IdPlaza
		''' </summary>
		Public Overridable  ReadOnly Property CabPrepFormEntityUsingFolPrepFormIdPlaza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CabPrepFormFieldIndex.FolPrepForm), EntityFieldFactory.Create(DetPrepFormLoteFieldIndex.FolPrepForm))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CabPrepFormFieldIndex.IdPlaza), EntityFieldFactory.Create(DetPrepFormLoteFieldIndex.IdPlaza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabPrepFormEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetPrepFormLoteEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between DetPrepFormLoteEntity and DetPrepFormEntity over the m:1 relation they have, using the relation between the fields:
		''' DetPrepFormLote.FolPrepForm - DetPrepForm.FolPrepForm
		''' DetPrepFormLote.CveProducto - DetPrepForm.CveProducto
		''' DetPrepFormLote.IdPlaza - DetPrepForm.IdPlaza
		''' </summary>
		Public Overridable  ReadOnly Property DetPrepFormEntityUsingFolPrepFormCveProductoIdPlaza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(DetPrepFormFieldIndex.FolPrepForm), EntityFieldFactory.Create(DetPrepFormLoteFieldIndex.FolPrepForm))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(DetPrepFormFieldIndex.CveProducto), EntityFieldFactory.Create(DetPrepFormLoteFieldIndex.CveProducto))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(DetPrepFormFieldIndex.IdPlaza), EntityFieldFactory.Create(DetPrepFormLoteFieldIndex.IdPlaza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetPrepFormEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetPrepFormLoteEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between DetPrepFormLoteEntity and ProductoEntity over the m:1 relation they have, using the relation between the fields:
		''' DetPrepFormLote.CveProducto - Producto.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property ProductoEntityUsingCveProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(DetPrepFormLoteFieldIndex.CveProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetPrepFormLoteEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between DetPrepFormLoteEntity and PlazaEntity over the m:1 relation they have, using the relation between the fields:
		''' DetPrepFormLote.IdPlaza - Plaza.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property PlazaEntityUsingIdPlaza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), EntityFieldFactory.Create(DetPrepFormLoteFieldIndex.IdPlaza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PlazaEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetPrepFormLoteEntity", True)
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
