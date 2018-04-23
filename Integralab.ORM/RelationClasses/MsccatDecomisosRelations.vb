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
	''' Implements the Shared Relations variant for the entity: MsccatDecomisos.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class MsccatDecomisosRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatDecomisosEntity and MsccatProductosDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatDecomisos.IdDecomiso - MsccatProductosDetalle.IdDecomiso
		''' </summary>
		Public Overridable ReadOnly Property MsccatProductosDetalleEntityUsingIdDecomiso() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatDecomisosFieldIndex.IdDecomiso), EntityFieldFactory.Create(MsccatProductosDetalleFieldIndex.IdDecomiso))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatDecomisosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosDetalleEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatDecomisosEntity and UsrProdRegistroSacrificiosDecomisoEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatDecomisos.IdDecomiso - UsrProdRegistroSacrificiosDecomiso.IdDecomiso
		''' </summary>
		Public Overridable ReadOnly Property UsrProdRegistroSacrificiosDecomisoEntityUsingIdDecomiso() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatDecomisosFieldIndex.IdDecomiso), EntityFieldFactory.Create(UsrProdRegistroSacrificiosDecomisoFieldIndex.IdDecomiso))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatDecomisosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrProdRegistroSacrificiosDecomisoEntity", False)
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
