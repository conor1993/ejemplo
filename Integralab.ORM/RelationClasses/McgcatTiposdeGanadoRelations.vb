' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 1 de diciembre de 2017 15:43:59
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
	''' Implements the Shared Relations variant for the entity: McgcatTiposdeGanado.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class McgcatTiposdeGanadoRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between McgcatTiposdeGanadoEntity and DetFacturasEntity over the 1:n relation they have, using the relation between the fields:
		''' McgcatTiposdeGanado.IdTipoGanado - DetFacturas.CveGanado
		''' </summary>
		Public Overridable ReadOnly Property DetFacturasEntityUsingCveGanado() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McgcatTiposdeGanadoFieldIndex.IdTipoGanado), EntityFieldFactory.Create(DetFacturasFieldIndex.CveGanado))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McgcatTiposdeGanadoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetFacturasEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between McgcatTiposdeGanadoEntity and DetMovGanEntity over the 1:n relation they have, using the relation between the fields:
		''' McgcatTiposdeGanado.IdTipoGanado - DetMovGan.CveGanado
		''' </summary>
		Public Overridable ReadOnly Property DetMovGanEntityUsingCveGanado() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McgcatTiposdeGanadoFieldIndex.IdTipoGanado), EntityFieldFactory.Create(DetMovGanFieldIndex.CveGanado))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McgcatTiposdeGanadoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetMovGanEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between McgcatTiposdeGanadoEntity and DetRegComEntity over the 1:n relation they have, using the relation between the fields:
		''' McgcatTiposdeGanado.IdTipoGanado - DetRegCom.CveGanado
		''' </summary>
		Public Overridable ReadOnly Property DetRegComEntityUsingCveGanado() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McgcatTiposdeGanadoFieldIndex.IdTipoGanado), EntityFieldFactory.Create(DetRegComFieldIndex.CveGanado))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McgcatTiposdeGanadoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DetRegComEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between McgcatTiposdeGanadoEntity and McecatCorralesDetEntity over the 1:n relation they have, using the relation between the fields:
		''' McgcatTiposdeGanado.IdTipoGanado - McecatCorralesDet.IdTipoGanado
		''' </summary>
		Public Overridable ReadOnly Property McecatCorralesDetEntityUsingIdTipoGanado() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McgcatTiposdeGanadoFieldIndex.IdTipoGanado), EntityFieldFactory.Create(McecatCorralesDetFieldIndex.IdTipoGanado))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McgcatTiposdeGanadoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McecatCorralesDetEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between McgcatTiposdeGanadoEntity and McecatLotesDetEntity over the 1:n relation they have, using the relation between the fields:
		''' McgcatTiposdeGanado.IdTipoGanado - McecatLotesDet.IdTipoGanado
		''' </summary>
		Public Overridable ReadOnly Property McecatLotesDetEntityUsingIdTipoGanado() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McgcatTiposdeGanadoFieldIndex.IdTipoGanado), EntityFieldFactory.Create(McecatLotesDetFieldIndex.IdTipoGanado))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McgcatTiposdeGanadoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McecatLotesDetEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between McgcatTiposdeGanadoEntity and SalidaGanadoDetEntity over the 1:n relation they have, using the relation between the fields:
		''' McgcatTiposdeGanado.IdTipoGanado - SalidaGanadoDet.IdTipoGanado
		''' </summary>
		Public Overridable ReadOnly Property SalidaGanadoDetEntityUsingIdTipoGanado() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McgcatTiposdeGanadoFieldIndex.IdTipoGanado), EntityFieldFactory.Create(SalidaGanadoDetFieldIndex.IdTipoGanado))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McgcatTiposdeGanadoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalidaGanadoDetEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between McgcatTiposdeGanadoEntity and UsrProdRecepcionDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' McgcatTiposdeGanado.IdTipoGanado - UsrProdRecepcionDetalle.IdTipoGanado
		''' </summary>
		Public Overridable ReadOnly Property UsrProdRecepcionDetalleEntityUsingIdTipoGanado() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McgcatTiposdeGanadoFieldIndex.IdTipoGanado), EntityFieldFactory.Create(UsrProdRecepcionDetalleFieldIndex.IdTipoGanado))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McgcatTiposdeGanadoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrProdRecepcionDetalleEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between McgcatTiposdeGanadoEntity and RecepcionGanadoEntity over the 1:n relation they have, using the relation between the fields:
		''' McgcatTiposdeGanado.IdTipoGanado - RecepcionGanado.IdTipoGanado
		''' </summary>
		Public Overridable ReadOnly Property RecepcionGanadoEntityUsingIdTipoGanado() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(McgcatTiposdeGanadoFieldIndex.IdTipoGanado), EntityFieldFactory.Create(RecepcionGanadoFieldIndex.IdTipoGanado))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("McgcatTiposdeGanadoEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecepcionGanadoEntity", False)
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
