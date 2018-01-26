' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 25 de enero de 2018 11:40:25
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
	''' Implements the Shared Relations variant for the entity: UsrCxpfacturasDetRecepciones.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class UsrCxpfacturasDetRecepcionesRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between UsrCxpfacturasDetRecepcionesEntity and RecepcionOrdenCompraEntity over the m:1 relation they have, using the relation between the fields:
		''' UsrCxpfacturasDetRecepciones.IdRecepcionOrdenCompra - RecepcionOrdenCompra.IdRecepcionOrdenCompra
		''' </summary>
		Public Overridable  ReadOnly Property RecepcionOrdenCompraEntityUsingIdRecepcionOrdenCompra() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(RecepcionOrdenCompraFieldIndex.IdRecepcionOrdenCompra), EntityFieldFactory.Create(UsrCxpfacturasDetRecepcionesFieldIndex.IdRecepcionOrdenCompra))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecepcionOrdenCompraEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrCxpfacturasDetRecepcionesEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between UsrCxpfacturasDetRecepcionesEntity and UsrCxpfacturasCabEntity over the m:1 relation they have, using the relation between the fields:
		''' UsrCxpfacturasDetRecepciones.EmpresaId - UsrCxpfacturasCab.EmpresaId
		''' UsrCxpfacturasDetRecepciones.IdProveedor - UsrCxpfacturasCab.IdProveedor
		''' UsrCxpfacturasDetRecepciones.NoFactura - UsrCxpfacturasCab.NoFactura
		''' </summary>
		Public Overridable  ReadOnly Property UsrCxpfacturasCabEntityUsingEmpresaIdIdProveedorNoFactura() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(UsrCxpfacturasCabFieldIndex.EmpresaId), EntityFieldFactory.Create(UsrCxpfacturasDetRecepcionesFieldIndex.EmpresaId))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(UsrCxpfacturasCabFieldIndex.IdProveedor), EntityFieldFactory.Create(UsrCxpfacturasDetRecepcionesFieldIndex.IdProveedor))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(UsrCxpfacturasCabFieldIndex.NoFactura), EntityFieldFactory.Create(UsrCxpfacturasDetRecepcionesFieldIndex.NoFactura))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrCxpfacturasCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrCxpfacturasDetRecepcionesEntity", True)
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
