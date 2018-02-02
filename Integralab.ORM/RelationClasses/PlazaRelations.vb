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
	''' Implements the Shared Relations variant for the entity: Plaza.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class PlazaRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between PlazaEntity and CabPrepFormEntity over the 1:n relation they have, using the relation between the fields:
		''' Plaza.Codigo - CabPrepForm.IdPlaza
		''' </summary>
		Public Overridable ReadOnly Property CabPrepFormEntityUsingIdPlaza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), EntityFieldFactory.Create(CabPrepFormFieldIndex.IdPlaza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PlazaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabPrepFormEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PlazaEntity and DetPrepFormEntity over the 1:n relation they have, using the relation between the fields:
		''' Plaza.Codigo - DetPrepForm.IdPlaza
		''' </summary>
		Public Overridable ReadOnly Property DetPrepFormEntityUsingIdPlaza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), EntityFieldFactory.Create(DetPrepFormFieldIndex.IdPlaza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PlazaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetPrepFormEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PlazaEntity and DetPrepFormLoteEntity over the 1:n relation they have, using the relation between the fields:
		''' Plaza.Codigo - DetPrepFormLote.IdPlaza
		''' </summary>
		Public Overridable ReadOnly Property DetPrepFormLoteEntityUsingIdPlaza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), EntityFieldFactory.Create(DetPrepFormLoteFieldIndex.IdPlaza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PlazaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetPrepFormLoteEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PlazaEntity and AlmacenEntity over the 1:n relation they have, using the relation between the fields:
		''' Plaza.Codigo - Almacen.Plaza
		''' </summary>
		Public Overridable ReadOnly Property AlmacenEntityUsingPlaza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), EntityFieldFactory.Create(AlmacenFieldIndex.Plaza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PlazaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AlmacenEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PlazaEntity and McatCentroCostosEntity over the 1:n relation they have, using the relation between the fields:
		''' Plaza.Codigo - McatCentroCostos.IdPlaza
		''' </summary>
		Public Overridable ReadOnly Property McatCentroCostosEntityUsingIdPlaza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), EntityFieldFactory.Create(McatCentroCostosFieldIndex.IdPlaza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PlazaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McatCentroCostosEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PlazaEntity and ComicionistaEntity over the 1:n relation they have, using the relation between the fields:
		''' Plaza.Codigo - Comicionista.Plaza
		''' </summary>
		Public Overridable ReadOnly Property ComicionistaEntityUsingPlaza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), EntityFieldFactory.Create(ComicionistaFieldIndex.Plaza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PlazaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ComicionistaEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PlazaEntity and SucursalEntity over the 1:n relation they have, using the relation between the fields:
		''' Plaza.Codigo - Sucursal.CodigoPlaza
		''' </summary>
		Public Overridable ReadOnly Property SucursalEntityUsingCodigoPlaza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), EntityFieldFactory.Create(SucursalFieldIndex.CodigoPlaza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PlazaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SucursalEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PlazaEntity and ClienteEntity over the 1:n relation they have, using the relation between the fields:
		''' Plaza.Codigo - Cliente.CodigoPlaza
		''' </summary>
		Public Overridable ReadOnly Property ClienteEntityUsingCodigoPlaza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), EntityFieldFactory.Create(ClienteFieldIndex.CodigoPlaza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PlazaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ClienteEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PlazaEntity and ListaPrecioEntity over the 1:n relation they have, using the relation between the fields:
		''' Plaza.Codigo - ListaPrecio.Plaza
		''' </summary>
		Public Overridable ReadOnly Property ListaPrecioEntityUsingPlaza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), EntityFieldFactory.Create(ListaPrecioFieldIndex.Plaza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PlazaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ListaPrecioEntity", False)
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
