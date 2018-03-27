' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 26 de marzo de 2018 17:30:30
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
	''' Implements the Shared Relations variant for the entity: MgralcatPuntosEntrega.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class MgralcatPuntosEntregaRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between MgralcatPuntosEntregaEntity and MscrelacionCortesClientesEntity over the 1:n relation they have, using the relation between the fields:
		''' MgralcatPuntosEntrega.IdPuntoEntrega - MscrelacionCortesClientes.IdDestino
		''' </summary>
		Public Overridable ReadOnly Property MscrelacionCortesClientesEntityUsingIdDestino() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MgralcatPuntosEntregaFieldIndex.IdPuntoEntrega), EntityFieldFactory.Create(MscrelacionCortesClientesFieldIndex.IdDestino))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MgralcatPuntosEntregaEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscrelacionCortesClientesEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between MgralcatPuntosEntregaEntity and EstadoEntity over the m:1 relation they have, using the relation between the fields:
		''' MgralcatPuntosEntrega.IdEstado - Estado.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property EstadoEntityUsingIdEstado() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(EstadoFieldIndex.Codigo), EntityFieldFactory.Create(MgralcatPuntosEntregaFieldIndex.IdEstado))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EstadoEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MgralcatPuntosEntregaEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MgralcatPuntosEntregaEntity and MfacCatClientesEntity over the m:1 relation they have, using the relation between the fields:
		''' MgralcatPuntosEntrega.IdCliente - MfacCatClientes.IdCliente
		''' </summary>
		Public Overridable  ReadOnly Property MfacCatClientesEntityUsingIdCliente() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MfacCatClientesFieldIndex.IdCliente), EntityFieldFactory.Create(MgralcatPuntosEntregaFieldIndex.IdCliente))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MgralcatPuntosEntregaEntity", True)
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
