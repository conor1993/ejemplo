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
	''' Implements the Shared Relations variant for the entity: MsccatProductos.
	''' This class is generated. Do not modify.
	''' </summary>
	Public Class MsccatProductosRelations
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub

#Region "Class Property Declarations"
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and MfacEmbarquesDetEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatProductos.IdProducto - MfacEmbarquesDet.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property MfacEmbarquesDetEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(MfacEmbarquesDetFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MfacEmbarquesDetEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and MinvTransferenciaAlmacenProdDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatProductos.IdProducto - MinvTransferenciaAlmacenProdDetalle.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property MinvTransferenciaAlmacenProdDetalleEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(MinvTransferenciaAlmacenProdDetalleFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MinvTransferenciaAlmacenProdDetalleEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and MsccatProductosDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatProductos.IdProducto - MsccatProductosDetalle.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property MsccatProductosDetalleEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(MsccatProductosDetalleFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosDetalleEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and MsccortesPreCortesEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatProductos.IdProducto - MsccortesPreCortes.IdPreCorte
		''' </summary>
		Public Overridable ReadOnly Property MsccortesPreCortesEntityUsingIdPreCorte() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(MsccortesPreCortesFieldIndex.IdPreCorte))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccortesPreCortesEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and DevolucionProductosEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatProductos.IdProducto - DevolucionProductos.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property DevolucionProductosEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(DevolucionProductosFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DevolucionProductosEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and MscinventarioProductoEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatProductos.IdProducto - MscinventarioProducto.IdCodProducto
		''' </summary>
		Public Overridable ReadOnly Property MscinventarioProductoEntityUsingIdCodProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(MscinventarioProductoFieldIndex.IdCodProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscinventarioProductoEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and MscloteCortesCabEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatProductos.IdProducto - MscloteCortesCab.Producto
		''' </summary>
		Public Overridable ReadOnly Property MscloteCortesCabEntityUsingProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(MscloteCortesCabFieldIndex.Producto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscloteCortesCabEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and MscloteCortesDetEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatProductos.IdProducto - MscloteCortesDet.IdCorte
		''' </summary>
		Public Overridable ReadOnly Property MscloteCortesDetEntityUsingIdCorte() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(MscloteCortesDetFieldIndex.IdCorte))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscloteCortesDetEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and MscloteCortesDetEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatProductos.IdProducto - MscloteCortesDet.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property MscloteCortesDetEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(MscloteCortesDetFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscloteCortesDetEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and MscloteCortesDetComparacionEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatProductos.IdProducto - MscloteCortesDetComparacion.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property MscloteCortesDetComparacionEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(MscloteCortesDetComparacionFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscloteCortesDetComparacionEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and MscmovtosAlmacenDetEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatProductos.IdProducto - MscmovtosAlmacenDet.IdCodProducto
		''' </summary>
		Public Overridable ReadOnly Property MscmovtosAlmacenDetEntityUsingIdCodProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(MscmovtosAlmacenDetFieldIndex.IdCodProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscmovtosAlmacenDetEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and MscrelacionCortesClientesEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatProductos.IdProducto - MscrelacionCortesClientes.CodCorte
		''' </summary>
		Public Overridable ReadOnly Property MscrelacionCortesClientesEntityUsingCodCorte() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(MscrelacionCortesClientesFieldIndex.CodCorte))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscrelacionCortesClientesEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and MscrelacionProductosRastrosEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatProductos.IdProducto - MscrelacionProductosRastros.CodProducto
		''' </summary>
		Public Overridable ReadOnly Property MscrelacionProductosRastrosEntityUsingCodProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(MscrelacionProductosRastrosFieldIndex.CodProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MscrelacionProductosRastrosEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and ProductoDerivadoEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatProductos.IdProducto - ProductoDerivado.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property ProductoDerivadoEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(ProductoDerivadoFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoDerivadoEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and ProductoDerivadoEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatProductos.IdProducto - ProductoDerivado.IdDerivado
		''' </summary>
		Public Overridable ReadOnly Property ProductoDerivadoEntityUsingIdDerivado() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(ProductoDerivadoFieldIndex.IdDerivado))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductoDerivadoEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and ReferenciaProductoDerivadoEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatProductos.IdProducto - ReferenciaProductoDerivado.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property ReferenciaProductoDerivadoEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(ReferenciaProductoDerivadoFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ReferenciaProductoDerivadoEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and UsrProdRecepcionDetalleEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatProductos.IdProducto - UsrProdRecepcionDetalle.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property UsrProdRecepcionDetalleEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(UsrProdRecepcionDetalleFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrProdRecepcionDetalleEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and UsrProdRegistroSacrificiosDecomisoEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatProductos.IdProducto - UsrProdRegistroSacrificiosDecomiso.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property UsrProdRegistroSacrificiosDecomisoEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(UsrProdRegistroSacrificiosDecomisoFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsrProdRegistroSacrificiosDecomisoEntity", False)
				Return relation
			End Get
		End Property
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and RegistroSacrificiosDecomisosEntity over the 1:n relation they have, using the relation between the fields:
		''' MsccatProductos.IdProducto - RegistroSacrificiosDecomisos.IdProducto
		''' </summary>
		Public Overridable ReadOnly Property RegistroSacrificiosDecomisosEntityUsingIdProducto() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
				relation.StartEntityIsPkSide = True
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(RegistroSacrificiosDecomisosFieldIndex.IdProducto))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RegistroSacrificiosDecomisosEntity", False)
				Return relation
			End Get
		End Property
	
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and MsccortesPreCortesEntity over the 1:1 relation they have, using the relation between the fields:
		''' MsccatProductos.IdProducto - MsccortesPreCortes.IdCorte
		''' </summary>
		Public Overridable  ReadOnly Property MsccortesPreCortesEntityUsingIdCorte() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne)
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), EntityFieldFactory.Create(MsccortesPreCortesFieldIndex.IdCorte))



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccortesPreCortesEntity", False)
				relation.StartEntityIsPkSide = True
				Return relation
			End Get
		End Property
	
	
		''' <summary>Returns a new IEntityRelation Object, between MsccatProductosEntity and CuentaContableEntity over the m:1 relation they have, using the relation between the fields:
		''' MsccatProductos.IdCeuntaContable - CuentaContable.Codigo
		''' </summary>
		Public Overridable  ReadOnly Property CuentaContableEntityUsingIdCeuntaContable() As IEntityRelation
			Get

				Dim relation As IEntityRelation = New EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
				relation.StartEntityIsPkSide = False
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), EntityFieldFactory.Create(MsccatProductosFieldIndex.IdCeuntaContable))
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CuentaContableEntity", False)
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MsccatProductosEntity", True)
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
