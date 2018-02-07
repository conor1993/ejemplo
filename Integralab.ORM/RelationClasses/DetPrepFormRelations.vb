' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 7 de febrero de 2018 11:23:27
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
	''' Implements the Shared Relations variant for the entity: DetPrepForm.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class DetPrepFormRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between DetPrepFormEntity and DetPrepFormLoteEntity over the 1:n relation they have, using the relation between the fields:
		''' DetPrepForm.FolPrepForm - DetPrepFormLote.FolPrepForm
		''' DetPrepForm.CveProducto - DetPrepFormLote.CveProducto
		''' DetPrepForm.IdPlaza - DetPrepFormLote.IdPlaza
		''' </summary>
		Public Overridable ReadOnly Property DetPrepFormLoteEntityUsingFolPrepFormCveProductoIdPlaza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(DetPrepFormFieldIndex.FolPrepForm), EntityFieldFactory.Create(DetPrepFormLoteFieldIndex.FolPrepForm))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(DetPrepFormFieldIndex.CveProducto), EntityFieldFactory.Create(DetPrepFormLoteFieldIndex.CveProducto))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(DetPrepFormFieldIndex.IdPlaza), EntityFieldFactory.Create(DetPrepFormLoteFieldIndex.IdPlaza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetPrepFormEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetPrepFormLoteEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between DetPrepFormEntity and CabPrepFormEntity over the m:1 relation they have, using the relation between the fields:
		''' DetPrepForm.FolPrepForm - CabPrepForm.FolPrepForm
		''' DetPrepForm.IdPlaza - CabPrepForm.IdPlaza
		''' </summary>
		Public Overridable  ReadOnly Property CabPrepFormEntityUsingFolPrepFormIdPlaza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CabPrepFormFieldIndex.FolPrepForm), EntityFieldFactory.Create(DetPrepFormFieldIndex.FolPrepForm))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CabPrepFormFieldIndex.IdPlaza), EntityFieldFactory.Create(DetPrepFormFieldIndex.IdPlaza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabPrepFormEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetPrepFormEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between DetPrepFormEntity and ProductoEntity over the m:1 relation they have, using the relation between the fields:
		''' DetPrepForm.CveProducto - Producto.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property ProductoEntityUsingCveProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), EntityFieldFactory.Create(DetPrepFormFieldIndex.CveProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetPrepFormEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between DetPrepFormEntity and PlazaEntity over the m:1 relation they have, using the relation between the fields:
		''' DetPrepForm.IdPlaza - Plaza.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property PlazaEntityUsingIdPlaza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), EntityFieldFactory.Create(DetPrepFormFieldIndex.IdPlaza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PlazaEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetPrepFormEntity", True)
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
