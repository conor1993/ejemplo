' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 29 de enero de 2018 16:36:31
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
	''' Implements the Shared Relations variant for the entity: RegistroSacrificiosDecomisos.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class RegistroSacrificiosDecomisosRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between RegistroSacrificiosDecomisosEntity and MfacEmbarquesDetEntity over the 1:n relation they have, using the relation between the fields:
		''' RegistroSacrificiosDecomisos.LoteSacrificio - MfacEmbarquesDet.FolioSacrificio
		''' RegistroSacrificiosDecomisos.IdProducto - MfacEmbarquesDet.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property MfacEmbarquesDetEntityUsingFolioSacrificioIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(RegistroSacrificiosDecomisosFieldIndex.LoteSacrificio), EntityFieldFactory.Create(MfacEmbarquesDetFieldIndex.FolioSacrificio))
				relation.AddEntityFieldPair(EntityFieldFactory.Create(RegistroSacrificiosDecomisosFieldIndex.IdProducto), EntityFieldFactory.Create(MfacEmbarquesDetFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RegistroSacrificiosDecomisosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacEmbarquesDetEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between RegistroSacrificiosDecomisosEntity and MscregistroSacrificioCabEntity over the m:1 relation they have, using the relation between the fields:
		''' RegistroSacrificiosDecomisos.LoteSacrificio - MscregistroSacrificioCab.IdFolioSacrificio
		''' </summary>
		Public Overridable  ReadOnly Property MscregistroSacrificioCabEntityUsingLoteSacrificio() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscregistroSacrificioCabFieldIndex.IdFolioSacrificio), EntityFieldFactory.Create(RegistroSacrificiosDecomisosFieldIndex.LoteSacrificio))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscregistroSacrificioCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RegistroSacrificiosDecomisosEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between RegistroSacrificiosDecomisosEntity and AlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' RegistroSacrificiosDecomisos.IdAlmacenProd - Almacen.AlmacenId
		''' </summary>
		Public Overridable  ReadOnly Property AlmacenEntityUsingIdAlmacenProd() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(RegistroSacrificiosDecomisosFieldIndex.IdAlmacenProd))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RegistroSacrificiosDecomisosEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between RegistroSacrificiosDecomisosEntity and MsccatProductosEntity over the m:1 relation they have, using the relation between the fields:
		''' RegistroSacrificiosDecomisos.IdProducto - MsccatProductos.IdProducto
		''' </summary>
		Public Overridable  ReadOnly Property MsccatProductosEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(RegistroSacrificiosDecomisosFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RegistroSacrificiosDecomisosEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between RegistroSacrificiosDecomisosEntity and MscmovtosAlmacenCabEntity over the m:1 relation they have, using the relation between the fields:
		''' RegistroSacrificiosDecomisos.FolioMovAlmacen - MscmovtosAlmacenCab.IdFolioMovimiento
		''' </summary>
		Public Overridable  ReadOnly Property MscmovtosAlmacenCabEntityUsingFolioMovAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), EntityFieldFactory.Create(RegistroSacrificiosDecomisosFieldIndex.FolioMovAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RegistroSacrificiosDecomisosEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between RegistroSacrificiosDecomisosEntity and MscmovtosAlmacenCabEntity over the m:1 relation they have, using the relation between the fields:
		''' RegistroSacrificiosDecomisos.FolioCancelAlmacen - MscmovtosAlmacenCab.IdFolioMovimiento
		''' </summary>
		Public Overridable  ReadOnly Property MscmovtosAlmacenCabEntityUsingFolioCancelAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), EntityFieldFactory.Create(RegistroSacrificiosDecomisosFieldIndex.FolioCancelAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenCabEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RegistroSacrificiosDecomisosEntity", True)
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
