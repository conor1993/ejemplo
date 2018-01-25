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
	''' Implements the Shared Relations variant for the entity: MfacEmbarquesDet.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class MfacEmbarquesDetRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between MfacEmbarquesDetEntity and FacturasClientesCabEntity over the m:1 relation they have, using the relation between the fields:
		''' MfacEmbarquesDet.SerieFactura - FacturasClientesCab.Serie
		''' MfacEmbarquesDet.NoFactura - FacturasClientesCab.NoFactura
		''' </summary>
		Public Overridable  ReadOnly Property FacturasClientesCabEntityUsingSerieFacturaNoFactura() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(FacturasClientesCabFieldIndex.Serie), EntityFieldFactory.Create(MfacEmbarquesDetFieldIndex.SerieFactura))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(FacturasClientesCabFieldIndex.NoFactura), EntityFieldFactory.Create(MfacEmbarquesDetFieldIndex.NoFactura))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FacturasClientesCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacEmbarquesDetEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MfacEmbarquesDetEntity and MfacEmbarquesCabEntity over the m:1 relation they have, using the relation between the fields:
		''' MfacEmbarquesDet.IdFolioEmbarque - MfacEmbarquesCab.IdFolioEmbarque
		''' </summary>
		Public Overridable  ReadOnly Property MfacEmbarquesCabEntityUsingIdFolioEmbarque() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MfacEmbarquesCabFieldIndex.IdFolioEmbarque), EntityFieldFactory.Create(MfacEmbarquesDetFieldIndex.IdFolioEmbarque))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacEmbarquesCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacEmbarquesDetEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MfacEmbarquesDetEntity and MsccatProductosEntity over the m:1 relation they have, using the relation between the fields:
		''' MfacEmbarquesDet.IdProducto - MsccatProductos.IdProducto
		''' </summary>
		Public Overridable  ReadOnly Property MsccatProductosEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(MfacEmbarquesDetFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacEmbarquesDetEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MfacEmbarquesDetEntity and MscmovtosAlmacenCabEntity over the m:1 relation they have, using the relation between the fields:
		''' MfacEmbarquesDet.IdFolioMovimientoAlmacen - MscmovtosAlmacenCab.IdFolioMovimiento
		''' </summary>
		Public Overridable  ReadOnly Property MscmovtosAlmacenCabEntityUsingIdFolioMovimientoAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), EntityFieldFactory.Create(MfacEmbarquesDetFieldIndex.IdFolioMovimientoAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacEmbarquesDetEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MfacEmbarquesDetEntity and RegistroSacrificiosDecomisosEntity over the m:1 relation they have, using the relation between the fields:
		''' MfacEmbarquesDet.FolioSacrificio - RegistroSacrificiosDecomisos.LoteSacrificio
		''' MfacEmbarquesDet.IdProducto - RegistroSacrificiosDecomisos.IdProducto
		''' </summary>
		Public Overridable  ReadOnly Property RegistroSacrificiosDecomisosEntityUsingFolioSacrificioIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(RegistroSacrificiosDecomisosFieldIndex.LoteSacrificio), EntityFieldFactory.Create(MfacEmbarquesDetFieldIndex.FolioSacrificio))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(RegistroSacrificiosDecomisosFieldIndex.IdProducto), EntityFieldFactory.Create(MfacEmbarquesDetFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RegistroSacrificiosDecomisosEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacEmbarquesDetEntity", True)
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
