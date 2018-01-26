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
	''' Implements the Shared Relations variant for the entity: PagoDeCtes.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class PagoDeCtesRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between PagoDeCtesEntity and FacturasClientesCabEntity over the m:1 relation they have, using the relation between the fields:
		''' PagoDeCtes.SerieFactura - FacturasClientesCab.Serie
		''' PagoDeCtes.FolFactura - FacturasClientesCab.NoFactura
		''' </summary>
		Public Overridable  ReadOnly Property FacturasClientesCabEntityUsingSerieFacturaFolFactura() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(FacturasClientesCabFieldIndex.Serie), EntityFieldFactory.Create(PagoDeCtesFieldIndex.SerieFactura))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(FacturasClientesCabFieldIndex.NoFactura), EntityFieldFactory.Create(PagoDeCtesFieldIndex.FolFactura))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FacturasClientesCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PagoDeCtesEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PagoDeCtesEntity and MfacCatClientesEntity over the m:1 relation they have, using the relation between the fields:
		''' PagoDeCtes.CveCliente - MfacCatClientes.IdCliente
		''' </summary>
		Public Overridable  ReadOnly Property MfacCatClientesEntityUsingCveCliente() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MfacCatClientesFieldIndex.IdCliente), EntityFieldFactory.Create(PagoDeCtesFieldIndex.CveCliente))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PagoDeCtesEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PagoDeCtesEntity and PolizaEntity over the m:1 relation they have, using the relation between the fields:
		''' PagoDeCtes.IdPoliza - Poliza.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property PolizaEntityUsingIdPoliza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), EntityFieldFactory.Create(PagoDeCtesFieldIndex.IdPoliza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PolizaEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PagoDeCtesEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PagoDeCtesEntity and PolizaEntity over the m:1 relation they have, using the relation between the fields:
		''' PagoDeCtes.IdPolizaCancelacion - Poliza.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property PolizaEntityUsingIdPolizaCancelacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), EntityFieldFactory.Create(PagoDeCtesFieldIndex.IdPolizaCancelacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PolizaEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PagoDeCtesEntity", True)
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
