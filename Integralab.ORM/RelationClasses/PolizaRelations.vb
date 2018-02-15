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
	''' Implements the Shared Relations variant for the entity: Poliza.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class PolizaRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between PolizaEntity and CabFacturasEntity over the 1:n relation they have, using the relation between the fields:
		''' Poliza.Codigo - CabFacturas.FolPoliza
		''' </summary>
		Public Overridable ReadOnly Property CabFacturasEntityUsingFolPoliza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), EntityFieldFactory.Create(CabFacturasFieldIndex.FolPoliza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PolizaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabFacturasEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PolizaEntity and CabFacturasEntity over the 1:n relation they have, using the relation between the fields:
		''' Poliza.Codigo - CabFacturas.FolCanPoliza
		''' </summary>
		Public Overridable ReadOnly Property CabFacturasEntityUsingFolCanPoliza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), EntityFieldFactory.Create(CabFacturasFieldIndex.FolCanPoliza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PolizaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CabFacturasEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PolizaEntity and FacturasClientesCabEntity over the 1:n relation they have, using the relation between the fields:
		''' Poliza.Codigo - FacturasClientesCab.IdPoliza
		''' </summary>
		Public Overridable ReadOnly Property FacturasClientesCabEntityUsingIdPoliza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), EntityFieldFactory.Create(FacturasClientesCabFieldIndex.IdPoliza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PolizaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FacturasClientesCabEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PolizaEntity and GastosDepartamentosEntity over the 1:n relation they have, using the relation between the fields:
		''' Poliza.Codigo - GastosDepartamentos.IdPoliza
		''' </summary>
		Public Overridable ReadOnly Property GastosDepartamentosEntityUsingIdPoliza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), EntityFieldFactory.Create(GastosDepartamentosFieldIndex.IdPoliza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PolizaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GastosDepartamentosEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PolizaEntity and MvtosBancariosCbEntity over the 1:n relation they have, using the relation between the fields:
		''' Poliza.Codigo - MvtosBancariosCb.NumeroPol
		''' </summary>
		Public Overridable ReadOnly Property MvtosBancariosCbEntityUsingNumeroPol() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), EntityFieldFactory.Create(MvtosBancariosCbFieldIndex.NumeroPol))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PolizaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MvtosBancariosCbEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PolizaEntity and PagoDeCtesEntity over the 1:n relation they have, using the relation between the fields:
		''' Poliza.Codigo - PagoDeCtes.IdPoliza
		''' </summary>
		Public Overridable ReadOnly Property PagoDeCtesEntityUsingIdPoliza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), EntityFieldFactory.Create(PagoDeCtesFieldIndex.IdPoliza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PolizaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PagoDeCtesEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PolizaEntity and PagoDeCtesEntity over the 1:n relation they have, using the relation between the fields:
		''' Poliza.Codigo - PagoDeCtes.IdPolizaCancelacion
		''' </summary>
		Public Overridable ReadOnly Property PagoDeCtesEntityUsingIdPolizaCancelacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), EntityFieldFactory.Create(PagoDeCtesFieldIndex.IdPolizaCancelacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PolizaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PagoDeCtesEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PolizaEntity and SalidaGanadoCabEntity over the 1:n relation they have, using the relation between the fields:
		''' Poliza.Codigo - SalidaGanadoCab.IdPoliza
		''' </summary>
		Public Overridable ReadOnly Property SalidaGanadoCabEntityUsingIdPoliza() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), EntityFieldFactory.Create(SalidaGanadoCabFieldIndex.IdPoliza))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PolizaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalidaGanadoCabEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PolizaEntity and ChequeEntity over the 1:n relation they have, using the relation between the fields:
		''' Poliza.Codigo - Cheque.PolizaId
		''' </summary>
		Public Overridable ReadOnly Property ChequeEntityUsingPolizaId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), EntityFieldFactory.Create(ChequeFieldIndex.PolizaId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PolizaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChequeEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PolizaEntity and ChequeEntity over the 1:n relation they have, using the relation between the fields:
		''' Poliza.Codigo - Cheque.PolizaIdCancelacion
		''' </summary>
		Public Overridable ReadOnly Property ChequeEntityUsingPolizaIdCancelacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), EntityFieldFactory.Create(ChequeFieldIndex.PolizaIdCancelacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PolizaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChequeEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PolizaEntity and UsrBanDepositosEntity over the 1:n relation they have, using the relation between the fields:
		''' Poliza.Codigo - UsrBanDepositos.PolizaIdCancelacion
		''' </summary>
		Public Overridable ReadOnly Property UsrBanDepositosEntityUsingPolizaIdCancelacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), EntityFieldFactory.Create(UsrBanDepositosFieldIndex.PolizaIdCancelacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PolizaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrBanDepositosEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PolizaEntity and UsrBanDepositosEntity over the 1:n relation they have, using the relation between the fields:
		''' Poliza.Codigo - UsrBanDepositos.PolizaId
		''' </summary>
		Public Overridable ReadOnly Property UsrBanDepositosEntityUsingPolizaId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), EntityFieldFactory.Create(UsrBanDepositosFieldIndex.PolizaId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PolizaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrBanDepositosEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PolizaEntity and PolizaDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' Poliza.Codigo - PolizaDetalle.PolizaId
		''' </summary>
		Public Overridable ReadOnly Property PolizaDetalleEntityUsingPolizaId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), EntityFieldFactory.Create(PolizaDetalleFieldIndex.PolizaId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PolizaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PolizaDetalleEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between PolizaEntity and UsrCxppagosProveedoresEntity over the 1:n relation they have, using the relation between the fields:
		''' Poliza.Codigo - UsrCxppagosProveedores.PolizaId
		''' </summary>
		Public Overridable ReadOnly Property UsrCxppagosProveedoresEntityUsingPolizaId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), EntityFieldFactory.Create(UsrCxppagosProveedoresFieldIndex.PolizaId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PolizaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrCxppagosProveedoresEntity", False)
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
