' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 26 de marzo de 2018 17:30:29
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
	''' Implements the Shared Relations variant for the entity: ListaPrecio.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class ListaPrecioRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between ListaPrecioEntity and ClienteEntity over the 1:n relation they have, using the relation between the fields:
		''' ListaPrecio.Codigo - Cliente.ListaPrecios
		''' </summary>
		Public Overridable ReadOnly Property ClienteEntityUsingListaPrecios() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ListaPrecioFieldIndex.Codigo), EntityFieldFactory.Create(ClienteFieldIndex.ListaPrecios))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListaPrecioEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ClienteEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ListaPrecioEntity and ListaPrecioEntity over the 1:n relation they have, using the relation between the fields:
		''' ListaPrecio.Codigo - ListaPrecio.ListaBase
		''' </summary>
		Public Overridable ReadOnly Property ListaPrecioEntityUsingListaBase() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ListaPrecioFieldIndex.Codigo), EntityFieldFactory.Create(ListaPrecioFieldIndex.ListaBase))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListaPrecioEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListaPrecioEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ListaPrecioEntity and ListaPrecioDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' ListaPrecio.Codigo - ListaPrecioDetalle.ListaPrecios
		''' </summary>
		Public Overridable ReadOnly Property ListaPrecioDetalleEntityUsingListaPrecios() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ListaPrecioFieldIndex.Codigo), EntityFieldFactory.Create(ListaPrecioDetalleFieldIndex.ListaPrecios))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListaPrecioEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListaPrecioDetalleEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between ListaPrecioEntity and PlazaEntity over the m:1 relation they have, using the relation between the fields:
		''' ListaPrecio.Plaza - Plaza.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property PlazaEntityUsingPlaza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), EntityFieldFactory.Create(ListaPrecioFieldIndex.Plaza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PlazaEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListaPrecioEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ListaPrecioEntity and TipoVentaEntity over the m:1 relation they have, using the relation between the fields:
		''' ListaPrecio.LpidTipoVenta - TipoVenta.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property TipoVentaEntityUsingLpidTipoVenta() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoVentaFieldIndex.Codigo), EntityFieldFactory.Create(ListaPrecioFieldIndex.LpidTipoVenta))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoVentaEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListaPrecioEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ListaPrecioEntity and ListaPrecioEntity over the m:1 relation they have, using the relation between the fields:
		''' ListaPrecio.ListaBase - ListaPrecio.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property ListaPrecioEntityUsingCodigoListaBase() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ListaPrecioFieldIndex.Codigo), EntityFieldFactory.Create(ListaPrecioFieldIndex.ListaBase))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListaPrecioEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListaPrecioEntity", True)
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
