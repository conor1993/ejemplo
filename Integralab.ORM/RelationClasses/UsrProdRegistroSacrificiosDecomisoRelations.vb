' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: martes, 26 de diciembre de 2017 16:41:26
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
	''' Implements the Shared Relations variant for the entity: UsrProdRegistroSacrificiosDecomiso.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class UsrProdRegistroSacrificiosDecomisoRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between UsrProdRegistroSacrificiosDecomisoEntity and MsccatDecomisosEntity over the m:1 relation they have, using the relation between the fields:
		''' UsrProdRegistroSacrificiosDecomiso.IdDecomiso - MsccatDecomisos.IdDecomiso
		''' </summary>
		Public Overridable  ReadOnly Property MsccatDecomisosEntityUsingIdDecomiso() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatDecomisosFieldIndex.IdDecomiso), EntityFieldFactory.Create(UsrProdRegistroSacrificiosDecomisoFieldIndex.IdDecomiso))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatDecomisosEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrProdRegistroSacrificiosDecomisoEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between UsrProdRegistroSacrificiosDecomisoEntity and MsccatProductosEntity over the m:1 relation they have, using the relation between the fields:
		''' UsrProdRegistroSacrificiosDecomiso.IdProducto - MsccatProductos.IdProducto
		''' </summary>
		Public Overridable  ReadOnly Property MsccatProductosEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(UsrProdRegistroSacrificiosDecomisoFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrProdRegistroSacrificiosDecomisoEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between UsrProdRegistroSacrificiosDecomisoEntity and MscmovtosAlmacenCabEntity over the m:1 relation they have, using the relation between the fields:
		''' UsrProdRegistroSacrificiosDecomiso.FolioMovAlmacen - MscmovtosAlmacenCab.IdFolioMovimiento
		''' </summary>
		Public Overridable  ReadOnly Property MscmovtosAlmacenCabEntityUsingFolioMovAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), EntityFieldFactory.Create(UsrProdRegistroSacrificiosDecomisoFieldIndex.FolioMovAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrProdRegistroSacrificiosDecomisoEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between UsrProdRegistroSacrificiosDecomisoEntity and MscmovtosAlmacenCabEntity over the m:1 relation they have, using the relation between the fields:
		''' UsrProdRegistroSacrificiosDecomiso.FolioCancelAlmacen - MscmovtosAlmacenCab.IdFolioMovimiento
		''' </summary>
		Public Overridable  ReadOnly Property MscmovtosAlmacenCabEntityUsingFolioCancelAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), EntityFieldFactory.Create(UsrProdRegistroSacrificiosDecomisoFieldIndex.FolioCancelAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrProdRegistroSacrificiosDecomisoEntity", True)
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
