' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de marzo de 2018 16:12:30
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
	''' Implements the Shared Relations variant for the entity: MfacCatClientes.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class MfacCatClientesRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between MfacCatClientesEntity and RecepcionGanadoEntity over the 1:n relation they have, using the relation between the fields:
		''' MfacCatClientes.IdCliente - RecepcionGanado.IdCliente
		''' </summary>
		Public Overridable ReadOnly Property RecepcionGanadoEntityUsingIdCliente() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MfacCatClientesFieldIndex.IdCliente), EntityFieldFactory.Create(RecepcionGanadoFieldIndex.IdCliente))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecepcionGanadoEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MfacCatClientesEntity and ChequeDevueltoEntity over the 1:n relation they have, using the relation between the fields:
		''' MfacCatClientes.IdCliente - ChequeDevuelto.IdCliente
		''' </summary>
		Public Overridable ReadOnly Property ChequeDevueltoEntityUsingIdCliente() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MfacCatClientesFieldIndex.IdCliente), EntityFieldFactory.Create(ChequeDevueltoFieldIndex.IdCliente))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChequeDevueltoEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MfacCatClientesEntity and ChequesPosEntity over the 1:n relation they have, using the relation between the fields:
		''' MfacCatClientes.IdCliente - ChequesPos.CveCliente
		''' </summary>
		Public Overridable ReadOnly Property ChequesPosEntityUsingCveCliente() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MfacCatClientesFieldIndex.IdCliente), EntityFieldFactory.Create(ChequesPosFieldIndex.CveCliente))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChequesPosEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MfacCatClientesEntity and FacturasClientesCabEntity over the 1:n relation they have, using the relation between the fields:
		''' MfacCatClientes.IdCliente - FacturasClientesCab.IdCliente
		''' </summary>
		Public Overridable ReadOnly Property FacturasClientesCabEntityUsingIdCliente() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MfacCatClientesFieldIndex.IdCliente), EntityFieldFactory.Create(FacturasClientesCabFieldIndex.IdCliente))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FacturasClientesCabEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MfacCatClientesEntity and FacturasClientesCabEntity over the 1:n relation they have, using the relation between the fields:
		''' MfacCatClientes.IdCliente - FacturasClientesCab.IdClienteCargo
		''' </summary>
		Public Overridable ReadOnly Property FacturasClientesCabEntityUsingIdClienteCargo() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MfacCatClientesFieldIndex.IdCliente), EntityFieldFactory.Create(FacturasClientesCabFieldIndex.IdClienteCargo))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FacturasClientesCabEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MfacCatClientesEntity and MfacEmbarquesCabEntity over the 1:n relation they have, using the relation between the fields:
		''' MfacCatClientes.IdCliente - MfacEmbarquesCab.IdCliente
		''' </summary>
		Public Overridable ReadOnly Property MfacEmbarquesCabEntityUsingIdCliente() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MfacCatClientesFieldIndex.IdCliente), EntityFieldFactory.Create(MfacEmbarquesCabFieldIndex.IdCliente))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacEmbarquesCabEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MfacCatClientesEntity and MfacEmbarquesCabEntity over the 1:n relation they have, using the relation between the fields:
		''' MfacCatClientes.IdCliente - MfacEmbarquesCab.IdClienteAsignado
		''' </summary>
		Public Overridable ReadOnly Property MfacEmbarquesCabEntityUsingIdClienteAsignado() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MfacCatClientesFieldIndex.IdCliente), EntityFieldFactory.Create(MfacEmbarquesCabFieldIndex.IdClienteAsignado))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacEmbarquesCabEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MfacCatClientesEntity and MgralcatPuntosEntregaEntity over the 1:n relation they have, using the relation between the fields:
		''' MfacCatClientes.IdCliente - MgralcatPuntosEntrega.IdCliente
		''' </summary>
		Public Overridable ReadOnly Property MgralcatPuntosEntregaEntityUsingIdCliente() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MfacCatClientesFieldIndex.IdCliente), EntityFieldFactory.Create(MgralcatPuntosEntregaFieldIndex.IdCliente))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MgralcatPuntosEntregaEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MfacCatClientesEntity and DevolucionProductosEntity over the 1:n relation they have, using the relation between the fields:
		''' MfacCatClientes.IdCliente - DevolucionProductos.IdCliente
		''' </summary>
		Public Overridable ReadOnly Property DevolucionProductosEntityUsingIdCliente() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MfacCatClientesFieldIndex.IdCliente), EntityFieldFactory.Create(DevolucionProductosFieldIndex.IdCliente))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DevolucionProductosEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MfacCatClientesEntity and MscrelacionCortesClientesEntity over the 1:n relation they have, using the relation between the fields:
		''' MfacCatClientes.IdCliente - MscrelacionCortesClientes.CodCliente
		''' </summary>
		Public Overridable ReadOnly Property MscrelacionCortesClientesEntityUsingCodCliente() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MfacCatClientesFieldIndex.IdCliente), EntityFieldFactory.Create(MscrelacionCortesClientesFieldIndex.CodCliente))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscrelacionCortesClientesEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MfacCatClientesEntity and NotaCreditoCabEntity over the 1:n relation they have, using the relation between the fields:
		''' MfacCatClientes.IdCliente - NotaCreditoCab.IdCliente
		''' </summary>
		Public Overridable ReadOnly Property NotaCreditoCabEntityUsingIdCliente() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MfacCatClientesFieldIndex.IdCliente), EntityFieldFactory.Create(NotaCreditoCabFieldIndex.IdCliente))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("NotaCreditoCabEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MfacCatClientesEntity and PagoDeCtesEntity over the 1:n relation they have, using the relation between the fields:
		''' MfacCatClientes.IdCliente - PagoDeCtes.CveCliente
		''' </summary>
		Public Overridable ReadOnly Property PagoDeCtesEntityUsingCveCliente() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MfacCatClientesFieldIndex.IdCliente), EntityFieldFactory.Create(PagoDeCtesFieldIndex.CveCliente))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PagoDeCtesEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MfacCatClientesEntity and ServiciosXembarqueEntity over the 1:n relation they have, using the relation between the fields:
		''' MfacCatClientes.IdCliente - ServiciosXembarque.IdCliente
		''' </summary>
		Public Overridable ReadOnly Property ServiciosXembarqueEntityUsingIdCliente() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MfacCatClientesFieldIndex.IdCliente), EntityFieldFactory.Create(ServiciosXembarqueFieldIndex.IdCliente))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiciosXembarqueEntity", False)
				Return relation
			End Get
		End Property
	
	
		''' <summary>Returns a new IEntityRelation Object, between MfacCatClientesEntity and AlmacenEntity over the 1:1 relation they have, using the relation between the fields:
		''' MfacCatClientes.IdCliente - Almacen.AlmacenId
		''' </summary>
		Public Overridable  ReadOnly Property AlmacenEntityUsingAlmacenId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne)
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MfacCatClientesFieldIndex.IdCliente), EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId))



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AlmacenEntity", False)
				relation.StartEntityIsPkSide = True
				Return relation
			End Get
		End Property
	
	
		''' <summary>Returns a new IEntityRelation Object, between MfacCatClientesEntity and ComicionistaEntity over the m:1 relation they have, using the relation between the fields:
		''' MfacCatClientes.IdVendedor - Comicionista.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property ComicionistaEntityUsingIdVendedor() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ComicionistaFieldIndex.Codigo), EntityFieldFactory.Create(MfacCatClientesFieldIndex.IdVendedor))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ComicionistaEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MfacCatClientesEntity and CuentaContableEntity over the m:1 relation they have, using the relation between the fields:
		''' MfacCatClientes.CuentaContId - CuentaContable.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property CuentaContableEntityUsingCuentaContId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), EntityFieldFactory.Create(MfacCatClientesFieldIndex.CuentaContId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CuentaContableEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MfacCatClientesEntity and CuentaContableEntity over the m:1 relation they have, using the relation between the fields:
		''' MfacCatClientes.CuentaAnticipoId - CuentaContable.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property CuentaContableEntityUsingCuentaAnticipoId() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), EntityFieldFactory.Create(MfacCatClientesFieldIndex.CuentaAnticipoId))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CuentaContableEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", True)
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
