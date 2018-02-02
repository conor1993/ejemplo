' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de febrero de 2018 11:54:44
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
	''' Implements the Shared Relations variant for the entity: UsrCxpfacturasDet.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class UsrCxpfacturasDetRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between UsrCxpfacturasDetEntity and CuentaContableEntity over the m:1 relation they have, using the relation between the fields:
		''' UsrCxpfacturasDet.CuentaContableId - CuentaContable.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property CuentaContableEntityUsingCuentaContableId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), EntityFieldFactory.Create(UsrCxpfacturasDetFieldIndex.CuentaContableId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CuentaContableEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrCxpfacturasDetEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between UsrCxpfacturasDetEntity and UsrCxpfacturasCabEntity over the m:1 relation they have, using the relation between the fields:
		''' UsrCxpfacturasDet.EmpresaId - UsrCxpfacturasCab.EmpresaId
		''' UsrCxpfacturasDet.IdProveedor - UsrCxpfacturasCab.IdProveedor
		''' UsrCxpfacturasDet.NoFactura - UsrCxpfacturasCab.NoFactura
		''' </summary>
		Public Overridable  ReadOnly Property UsrCxpfacturasCabEntityUsingEmpresaIdIdProveedorNoFactura() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(UsrCxpfacturasCabFieldIndex.EmpresaId), EntityFieldFactory.Create(UsrCxpfacturasDetFieldIndex.EmpresaId))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(UsrCxpfacturasCabFieldIndex.IdProveedor), EntityFieldFactory.Create(UsrCxpfacturasDetFieldIndex.IdProveedor))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(UsrCxpfacturasCabFieldIndex.NoFactura), EntityFieldFactory.Create(UsrCxpfacturasDetFieldIndex.NoFactura))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrCxpfacturasCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrCxpfacturasDetEntity", True)
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
