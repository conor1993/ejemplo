' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 15 de marzo de 2018 11:59:59
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
	''' Implements the Shared Relations variant for the entity: ServiciosXembarque.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class ServiciosXembarqueRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between ServiciosXembarqueEntity and ServiciosEntity over the m:1 relation they have, using the relation between the fields:
		''' ServiciosXembarque.IdServicio - Servicios.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property ServiciosEntityUsingIdServicio() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ServiciosFieldIndex.Codigo), EntityFieldFactory.Create(ServiciosXembarqueFieldIndex.IdServicio))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiciosEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiciosXembarqueEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ServiciosXembarqueEntity and MfacCatClientesEntity over the m:1 relation they have, using the relation between the fields:
		''' ServiciosXembarque.IdCliente - MfacCatClientes.IdCliente
		''' </summary>
		Public Overridable  ReadOnly Property MfacCatClientesEntityUsingIdCliente() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MfacCatClientesFieldIndex.IdCliente), EntityFieldFactory.Create(ServiciosXembarqueFieldIndex.IdCliente))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacCatClientesEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiciosXembarqueEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between ServiciosXembarqueEntity and MfacEmbarquesCabEntity over the m:1 relation they have, using the relation between the fields:
		''' ServiciosXembarque.FoloEmbarque - MfacEmbarquesCab.IdFolioEmbarque
		''' </summary>
		Public Overridable  ReadOnly Property MfacEmbarquesCabEntityUsingFoloEmbarque() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MfacEmbarquesCabFieldIndex.IdFolioEmbarque), EntityFieldFactory.Create(ServiciosXembarqueFieldIndex.FoloEmbarque))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacEmbarquesCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiciosXembarqueEntity", True)
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
