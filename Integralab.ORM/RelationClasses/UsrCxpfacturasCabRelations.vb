' ////////////////////////////////////////////////////////////////////////////////////////////////////////
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
	''' Implements the Shared Relations variant for the entity: UsrCxpfacturasCab.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class UsrCxpfacturasCabRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between UsrCxpfacturasCabEntity and UsrCxppagosProveedoresEntity over the 1:n relation they have, using the relation between the fields:
		''' UsrCxpfacturasCab.EmpresaId - UsrCxppagosProveedores.EmpresaId
		''' UsrCxpfacturasCab.IdProveedor - UsrCxppagosProveedores.IdProveedor
		''' UsrCxpfacturasCab.NoFactura - UsrCxppagosProveedores.NoFactura
		''' </summary>
		Public Overridable ReadOnly Property UsrCxppagosProveedoresEntityUsingEmpresaIdIdProveedorNoFactura() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(UsrCxpfacturasCabFieldIndex.EmpresaId), EntityFieldFactory.Create(UsrCxppagosProveedoresFieldIndex.EmpresaId))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(UsrCxpfacturasCabFieldIndex.IdProveedor), EntityFieldFactory.Create(UsrCxppagosProveedoresFieldIndex.IdProveedor))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(UsrCxpfacturasCabFieldIndex.NoFactura), EntityFieldFactory.Create(UsrCxppagosProveedoresFieldIndex.NoFactura))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrCxpfacturasCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrCxppagosProveedoresEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between UsrCxpfacturasCabEntity and UsrCxpfacturasDetEntity over the 1:n relation they have, using the relation between the fields:
		''' UsrCxpfacturasCab.EmpresaId - UsrCxpfacturasDet.EmpresaId
		''' UsrCxpfacturasCab.IdProveedor - UsrCxpfacturasDet.IdProveedor
		''' UsrCxpfacturasCab.NoFactura - UsrCxpfacturasDet.NoFactura
		''' </summary>
		Public Overridable ReadOnly Property UsrCxpfacturasDetEntityUsingEmpresaIdIdProveedorNoFactura() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(UsrCxpfacturasCabFieldIndex.EmpresaId), EntityFieldFactory.Create(UsrCxpfacturasDetFieldIndex.EmpresaId))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(UsrCxpfacturasCabFieldIndex.IdProveedor), EntityFieldFactory.Create(UsrCxpfacturasDetFieldIndex.IdProveedor))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(UsrCxpfacturasCabFieldIndex.NoFactura), EntityFieldFactory.Create(UsrCxpfacturasDetFieldIndex.NoFactura))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrCxpfacturasCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrCxpfacturasDetEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between UsrCxpfacturasCabEntity and UsrCxpfacturasDetRecepcionesEntity over the 1:n relation they have, using the relation between the fields:
		''' UsrCxpfacturasCab.EmpresaId - UsrCxpfacturasDetRecepciones.EmpresaId
		''' UsrCxpfacturasCab.IdProveedor - UsrCxpfacturasDetRecepciones.IdProveedor
		''' UsrCxpfacturasCab.NoFactura - UsrCxpfacturasDetRecepciones.NoFactura
		''' </summary>
		Public Overridable ReadOnly Property UsrCxpfacturasDetRecepcionesEntityUsingEmpresaIdIdProveedorNoFactura() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(UsrCxpfacturasCabFieldIndex.EmpresaId), EntityFieldFactory.Create(UsrCxpfacturasDetRecepcionesFieldIndex.EmpresaId))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(UsrCxpfacturasCabFieldIndex.IdProveedor), EntityFieldFactory.Create(UsrCxpfacturasDetRecepcionesFieldIndex.IdProveedor))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(UsrCxpfacturasCabFieldIndex.NoFactura), EntityFieldFactory.Create(UsrCxpfacturasDetRecepcionesFieldIndex.NoFactura))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrCxpfacturasCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrCxpfacturasDetRecepcionesEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between UsrCxpfacturasCabEntity and ProveedorEntity over the m:1 relation they have, using the relation between the fields:
		''' UsrCxpfacturasCab.IdProveedor - Proveedor.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property ProveedorEntityUsingIdProveedor() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), EntityFieldFactory.Create(UsrCxpfacturasCabFieldIndex.IdProveedor))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProveedorEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrCxpfacturasCabEntity", True)
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
