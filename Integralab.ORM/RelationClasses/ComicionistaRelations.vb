' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 9 de febrero de 2018 17:51:04
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
	''' Implements the Shared Relations variant for the entity: Comicionista.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class ComicionistaRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between ComicionistaEntity and MfacCatClientesEntity over the 1:n relation they have, using the relation between the fields:
		''' Comicionista.Codigo - MfacCatClientes.IdVendedor
		''' </summary>
		Public Overridable ReadOnly Property MfacCatClientesEntityUsingIdVendedor() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ComicionistaFieldIndex.Codigo), EntityFieldFactory.Create(MfacCatClientesFieldIndex.IdVendedor))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ComicionistaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between ComicionistaEntity and TipoComicionistaEntity over the m:1 relation they have, using the relation between the fields:
		''' Comicionista.TipoComisionista - TipoComicionista.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property TipoComicionistaEntityUsingTipoComisionista() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoComicionistaFieldIndex.Codigo), EntityFieldFactory.Create(ComicionistaFieldIndex.TipoComisionista))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoComicionistaEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ComicionistaEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ComicionistaEntity and PlazaEntity over the m:1 relation they have, using the relation between the fields:
		''' Comicionista.Plaza - Plaza.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property PlazaEntityUsingPlaza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), EntityFieldFactory.Create(ComicionistaFieldIndex.Plaza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PlazaEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ComicionistaEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ComicionistaEntity and CuentaContableEntity over the m:1 relation they have, using the relation between the fields:
		''' Comicionista.IdCuentaContable - CuentaContable.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property CuentaContableEntityUsingIdCuentaContable() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), EntityFieldFactory.Create(ComicionistaFieldIndex.IdCuentaContable))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CuentaContableEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ComicionistaEntity", True)
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
