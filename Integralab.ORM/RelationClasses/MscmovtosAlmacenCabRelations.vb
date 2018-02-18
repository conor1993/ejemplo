' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: domingo, 18 de febrero de 2018 11:55:38
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
	''' Implements the Shared Relations variant for the entity: MscmovtosAlmacenCab.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class MscmovtosAlmacenCabRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between MscmovtosAlmacenCabEntity and MfacEmbarquesDetEntity over the 1:n relation they have, using the relation between the fields:
		''' MscmovtosAlmacenCab.IdFolioMovimiento - MfacEmbarquesDet.IdFolioMovimientoAlmacen
		''' </summary>
		Public Overridable ReadOnly Property MfacEmbarquesDetEntityUsingIdFolioMovimientoAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), EntityFieldFactory.Create(MfacEmbarquesDetFieldIndex.IdFolioMovimientoAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacEmbarquesDetEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MscmovtosAlmacenCabEntity and MscdetCanalAcorteEntity over the 1:n relation they have, using the relation between the fields:
		''' MscmovtosAlmacenCab.IdFolioMovimiento - MscdetCanalAcorte.IdFolioMovimientoAlmacen
		''' </summary>
		Public Overridable ReadOnly Property MscdetCanalAcorteEntityUsingIdFolioMovimientoAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), EntityFieldFactory.Create(MscdetCanalAcorteFieldIndex.IdFolioMovimientoAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscdetCanalAcorteEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MscmovtosAlmacenCabEntity and MscdetCanalAcorteEntity over the 1:n relation they have, using the relation between the fields:
		''' MscmovtosAlmacenCab.IdFolioMovimiento - MscdetCanalAcorte.IdFolioMovimientoAlmacenCancelacion
		''' </summary>
		Public Overridable ReadOnly Property MscdetCanalAcorteEntityUsingIdFolioMovimientoAlmacenCancelacion() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), EntityFieldFactory.Create(MscdetCanalAcorteFieldIndex.IdFolioMovimientoAlmacenCancelacion))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscdetCanalAcorteEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MscmovtosAlmacenCabEntity and MscloteCortesDetEntity over the 1:n relation they have, using the relation between the fields:
		''' MscmovtosAlmacenCab.IdFolioMovimiento - MscloteCortesDet.IdFolioMovimiento
		''' </summary>
		Public Overridable ReadOnly Property MscloteCortesDetEntityUsingIdFolioMovimiento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), EntityFieldFactory.Create(MscloteCortesDetFieldIndex.IdFolioMovimiento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscloteCortesDetEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MscmovtosAlmacenCabEntity and MscmovtosAlmacenDetEntity over the 1:n relation they have, using the relation between the fields:
		''' MscmovtosAlmacenCab.IdFolioMovimiento - MscmovtosAlmacenDet.IdFolioMovimiento
		''' </summary>
		Public Overridable ReadOnly Property MscmovtosAlmacenDetEntityUsingIdFolioMovimiento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), EntityFieldFactory.Create(MscmovtosAlmacenDetFieldIndex.IdFolioMovimiento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenDetEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MscmovtosAlmacenCabEntity and MscrecepcionCanalesDetEntity over the 1:n relation they have, using the relation between the fields:
		''' MscmovtosAlmacenCab.IdFolioMovimiento - MscrecepcionCanalesDet.IdFolioMovimiento
		''' </summary>
		Public Overridable ReadOnly Property MscrecepcionCanalesDetEntityUsingIdFolioMovimiento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), EntityFieldFactory.Create(MscrecepcionCanalesDetFieldIndex.IdFolioMovimiento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscrecepcionCanalesDetEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MscmovtosAlmacenCabEntity and MscrecepcionCanalesDetEntity over the 1:n relation they have, using the relation between the fields:
		''' MscmovtosAlmacenCab.IdFolioMovimiento - MscrecepcionCanalesDet.IdFolioMovimientoCancela
		''' </summary>
		Public Overridable ReadOnly Property MscrecepcionCanalesDetEntityUsingIdFolioMovimientoCancela() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), EntityFieldFactory.Create(MscrecepcionCanalesDetFieldIndex.IdFolioMovimientoCancela))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscrecepcionCanalesDetEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MscmovtosAlmacenCabEntity and UsrProdRegistroSacrificiosDecomisoEntity over the 1:n relation they have, using the relation between the fields:
		''' MscmovtosAlmacenCab.IdFolioMovimiento - UsrProdRegistroSacrificiosDecomiso.FolioMovAlmacen
		''' </summary>
		Public Overridable ReadOnly Property UsrProdRegistroSacrificiosDecomisoEntityUsingFolioMovAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), EntityFieldFactory.Create(UsrProdRegistroSacrificiosDecomisoFieldIndex.FolioMovAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrProdRegistroSacrificiosDecomisoEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MscmovtosAlmacenCabEntity and UsrProdRegistroSacrificiosDecomisoEntity over the 1:n relation they have, using the relation between the fields:
		''' MscmovtosAlmacenCab.IdFolioMovimiento - UsrProdRegistroSacrificiosDecomiso.FolioCancelAlmacen
		''' </summary>
		Public Overridable ReadOnly Property UsrProdRegistroSacrificiosDecomisoEntityUsingFolioCancelAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), EntityFieldFactory.Create(UsrProdRegistroSacrificiosDecomisoFieldIndex.FolioCancelAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrProdRegistroSacrificiosDecomisoEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MscmovtosAlmacenCabEntity and RegistroSacrificiosDecomisosEntity over the 1:n relation they have, using the relation between the fields:
		''' MscmovtosAlmacenCab.IdFolioMovimiento - RegistroSacrificiosDecomisos.FolioMovAlmacen
		''' </summary>
		Public Overridable ReadOnly Property RegistroSacrificiosDecomisosEntityUsingFolioMovAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), EntityFieldFactory.Create(RegistroSacrificiosDecomisosFieldIndex.FolioMovAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RegistroSacrificiosDecomisosEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MscmovtosAlmacenCabEntity and RegistroSacrificiosDecomisosEntity over the 1:n relation they have, using the relation between the fields:
		''' MscmovtosAlmacenCab.IdFolioMovimiento - RegistroSacrificiosDecomisos.FolioCancelAlmacen
		''' </summary>
		Public Overridable ReadOnly Property RegistroSacrificiosDecomisosEntityUsingFolioCancelAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), EntityFieldFactory.Create(RegistroSacrificiosDecomisosFieldIndex.FolioCancelAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenCabEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RegistroSacrificiosDecomisosEntity", False)
				Return relation
			End Get
		End Property
	
	
	
		''' <summary>Returns a new IEntityRelation Object, between MscmovtosAlmacenCabEntity and AlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' MscmovtosAlmacenCab.IdCodAlmacen - Almacen.AlmacenId
		''' </summary>
		Public Overridable  ReadOnly Property AlmacenEntityUsingIdCodAlmacen() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdCodAlmacen))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenCabEntity", True)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MscmovtosAlmacenCabEntity and TipoMovimientoAlmacenEntity over the m:1 relation they have, using the relation between the fields:
		''' MscmovtosAlmacenCab.IdCodMovimiento - TipoMovimientoAlmacen.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property TipoMovimientoAlmacenEntityUsingIdCodMovimiento() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoMovimientoAlmacenFieldIndex.Codigo), EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdCodMovimiento))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoMovimientoAlmacenEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenCabEntity", True)
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
