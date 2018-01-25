' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 25 de enero de 2018 09:23:53
' // Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
' // Templates vendor: Solutions Design.
' // Templates version: 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Collections
#If Not CF Then
Imports System.Runtime.Serialization
#End If

Imports Integralab.ORM
Imports Integralab.ORM.HelperClasses
Imports Integralab.ORM.DaoClasses
Imports Integralab.ORM.EntityClasses
Imports Integralab.ORM.FactoryClasses

Imports SD.LLBLGen.Pro.ORMSupportClasses

' __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
' __LLBLGENPRO_USER_CODE_REGION_END
Namespace Integralab.ORM.TypedViewClasses
	''' <summary>
	''' Typed datatable for the view 'VwProductosGenerales'.<br/><br/>
	''' 
	''' </summary>
	''' <remarks>
	''' It embeds a fill method which accepts a filter.
	''' The code doesn't support any changing of data. Users who do that are on their own.
	''' It also doesn't support any event throwing. This view should be used as a base for readonly databinding
	''' or dataview construction.
	''' </remarks>
#If Not CF Then	
	<Serializable(), System.ComponentModel.DesignerCategory("Code"), ToolboxItem(True), DesignTimeVisible(True)> _
	Public Class VwProductosGeneralesTypedView 
#Else
	Public Class VwProductosGeneralesTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnPdIdProducto As DataColumn
		Private _columnPdDescripcion As DataColumn
		Private _columnPdDescrpcionCorta As DataColumn
		Private _columnPdIdLinea As DataColumn
		Private _columnPdIdUnidadMedida As DataColumn
		Private _columnPdIdMarca As DataColumn
		Private _columnPdIdPresentacion As DataColumn
		Private _columnPdSeFactura As DataColumn
		Private _columnPdSeRecibeParcial As DataColumn
		Private _columnPdSeObtieneMermas As DataColumn
		Private _columnPdSeRecibeSinFactura As DataColumn
		Private _columnPdSeFacturaSinExistencia As DataColumn
		Private _columnPdSeManejaPorLotes As DataColumn
		Private _columnPdProductoGeneral As DataColumn
		Private _columnPdMezcla As DataColumn
		Private _columnPdIngrediente As DataColumn
		Private _columnPdMaterialEnvase As DataColumn
		Private _columnPdDiasMaxCaducidad As DataColumn
		Private _columnPdPiezas As DataColumn
		Private _columnPdIdUsuarioAlta As DataColumn
		Private _columnPdFechaAlta As DataColumn
		Private _columnPdIdUsuarioBaja As DataColumn
		Private _columnPdFechaBaja As DataColumn
		Private _columnPdIdMotivoBaja As DataColumn
		Private _columnPdObservacionBaja As DataColumn
		Private _columnPdEstatus As DataColumn
		Private _columnPdCodigoRelacionado As DataColumn
		Private _columnPdTipoProducto As DataColumn
		Private _columnPdCaduca As DataColumn
		Private _columnPdSeAplicaIva As DataColumn
		Private _columnFactorConver As DataColumn
		Private _columnFechaUltimaCompra As DataColumn
		Private _columnCantidadUltimaCompra As DataColumn
		Private _columnImporteUltimaCompra As DataColumn
		Private _columnUltimoCosto As DataColumn
		Private _columnArtPuntoVenta As DataColumn
		Private _columnArtMeat As DataColumn
		Private _columnCodigoBarra As DataColumn
		Private _columnPorcIeps As DataColumn
		Private _columnPdEsKit As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 40
#End Region
		
		''' <summary>
		''' Static CTor for setting up custom property hashtables. Is executed before the first instance of this
		''' class or derived classes is constructed. 
		''' </summary>
		Shared Sub New()
			SetupCustomPropertyHashtables()
		End Sub
		

		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
			MyBase.New("VwProductosGenerales")
			InitClass()
		End Sub


#If Not CF Then		
		''' <summary>
		''' Protected constructor for deserialization. Empty, since there are no private members to be serialized also.
		''' </summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			InitMembers()
		End Sub
#End If		

		''' <summary>
		''' Fills itself with data. it builds a dynamic query and loads itself with that query. 
		''' Will use no sort filter, no select filter, will allow duplicate rows and will not limit the amount of rows returned
		''' </summary>
		''' <returns>True if fill succeeded, False otherwise</returns>
		Public Function Fill() As Boolean Implements ITypedView.Fill
			Return Fill(0, Nothing, True, Nothing, Nothing, Nothing, 0, 0)
		End Function


		''' <summary>
		''' Fills itself with data. it builds a dynamic query and loads itself with that query. 
		''' Will not use a filter, will allow duplicate rows.
		''' </summary>
		''' <param name="maxNumberOfItemsToReturn">The maximum amount of rows to Return. specifying 0 means all rows are returned</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When Nothing is specified, no sorting is applied.</param>
		''' <returns>True if fill succeeded, False otherwise</returns>
		Public Function Fill(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression) As Boolean Implements ITypedView.Fill
			Return Fill(maxNumberOfItemsToReturn, sortClauses, True, Nothing, Nothing, Nothing, 0, 0)
		End Function


		''' <summary>
		''' Fills itself with data. it builds a dynamic query and loads itself with that query. 
		''' Will not use a filter.
		''' </summary>
		''' <param name="maxNumberOfItemsToReturn">The maximum amount of rows to Return. specifying 0 means all rows are returned</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When Nothing is specified, no sorting is applied.</param>
		''' <param name="allowDuplicates">Flag to allow duplicate rows (True) or not (False)</param>
		''' <returns>True if fill succeeded, False otherwise</returns>
		Public Function Fill(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, allowDuplicates As Boolean) As Boolean Implements ITypedView.Fill
			Return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, Nothing, Nothing, Nothing, 0, 0)
		End Function


		''' <summary>
		''' Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter
		''' </summary>
		''' <param name="maxNumberOfItemsToReturn">The maximum amount of rows to Return. specifying 0 means all rows are returned</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When Nothing is specified, no sorting is applied.</param>
		''' <param name="allowDuplicates">Flag to allow duplicate rows (True) or not (False)</param>
		''' <param name="selectFilter">Predicate which is used to filter the rows to insert in this Typed List instance</param>
		''' <returns>True if fill succeeded, False otherwise</returns>
		Public Function Fill(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, allowDuplicates As Boolean, selectFilter As IPredicate) As Boolean Implements ITypedView.Fill
			Return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, selectFilter, Nothing, Nothing, 0, 0)
		End Function


		''' <summary>
		''' Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter
		''' </summary>
		''' <param name="maxNumberOfItemsToReturn">The maximum amount of rows to Return. specifying 0 means all rows are returned</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When Nothing is specified, no sorting is applied.</param>
		''' <param name="allowDuplicates">Flag to allow duplicate rows (True) or not (False)</param>
		''' <param name="selectFilter">Predicate which is used to filter the rows to insert in this Typed List instance</param>
		''' <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is
		''' used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		''' <returns>True if fill succeeded, False otherwise</returns>
		Public Function Fill(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, allowDuplicates As Boolean, selectFilter As IPredicate, transactionToUse As ITransaction) As Boolean Implements ITypedView.Fill
			Return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, selectFilter, transactionToUse, Nothing, 0, 0)
		End Function


		''' <summary>
		''' Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter
		''' </summary>
		''' <param name="maxNumberOfItemsToReturn">The maximum amount of rows to Return. specifying 0 means all rows are returned</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When Nothing is specified, no sorting is applied.</param>
		''' <param name="allowDuplicates">Flag to allow duplicate rows (True) or not (False)</param>
		''' <param name="selectFilter">Predicate which is used to filter the rows to insert in this Typed List instance</param>
		''' <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is
		''' used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		''' <param name="groupByClause">GroupByCollection with fields to group by on.</param>
		''' <returns>True if fill succeeded, False otherwise</returns>
		Public Function Fill(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, allowDuplicates As Boolean, selectFilter As IPredicate, transactionToUse As ITransaction, groupByClause As IGroupByCollection) As Boolean Implements ITypedView.Fill
			Return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, selectFilter, transactionToUse, groupByClause, 0, 0)
		End Function


		''' <summary>
		''' Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter
		''' </summary>
		''' <param name="maxNumberOfItemsToReturn">The maximum amount of rows to Return. specifying 0 means all rows are returned</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When Nothing is specified, no sorting is applied.</param>
		''' <param name="allowDuplicates">Flag to allow duplicate rows (True) or not (False)</param>
		''' <param name="selectFilter">Predicate which is used to filter the rows to insert in this Typed List instance</param>
		''' <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is
		''' used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		''' <param name="groupByClause">GroupByCollection with fields to group by on.</param>
		''' <param name="pageNumber">The page number to retrieve.</param>
		''' <param name="pageSize">The page size of the page to retrieve.</param>
		''' <returns>True if fill succeeded, False otherwise</returns>
		Overridable Public Function Fill(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression, allowDuplicates As Boolean, selectFilter As IPredicate, transactionToUse As ITransaction, groupByClause As IGroupByCollection, pageNumber As Integer, pageSize As Integer) As Boolean Implements ITypedView.Fill
			' Build resultset
			Dim fieldsInResultset As IEntityFields = GetFields()
			
			' __LLBLGENPRO_USER_CODE_REGION_START AdditionalFields
			' be sure To Call fieldsInResultset.Expand(number of New fields) first. 
			' __LLBLGENPRO_USER_CODE_REGION_END

			Dim dao As TypedListDAO = DAOFactory.CreateTypedListDAO()
			Return dao.GetMultiAsDataTable(fieldsInResultset, Me, maxNumberOfItemsToReturn, sortClauses, selectFilter, Nothing, True, groupByClause, transactionToUse, pageNumber, pageSize)
		End Function
		
		''' <summary>Gets the fields of this typed view</summary>
		''' <returns>IEntityFields Object</returns>
		Public Function GetFields() As IEntityFields Implements ITypedView.GetFields
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwProductosGeneralesTypedView)
		End Function

		''' <summary>
		''' Gets the amount of rows in the database for this typed view, not skipping duplicates
		''' </summary>
		''' <returns>the amount of objects found</returns>
		Public Function GetDbCount() As Integer Implements ITypedView.GetDbCount
			Return GetDbCount(True, Nothing, Nothing)
		End Function
		
		
		''' <summary>
		''' Gets the amount of rows in the database for this typed view.
		''' </summary>
		''' <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		''' <returns>the amount of objects found</returns>
		Public Function GetDbCount(allowDuplicates As Boolean) As Integer Implements ITypedView.GetDbCount
			Return GetDbCount(allowDuplicates, Nothing, Nothing)
		End Function


		''' <summary>
		''' Gets the amount of rows in the database for this typed view.
		''' </summary>
		''' <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		''' <param name="filter">The filter to apply for the count retrieval</param>
		''' <returns>the amount of objects found</returns>
		Public Function GetDbCount(allowDuplicates As Boolean, Filter As IPredicateExpression) As Integer Implements ITypedView.GetDbCount
			Return GetDbCount(allowDuplicates, filter, Nothing)
		End Function


		''' <summary>
		''' Gets the amount of rows In the database For this typed list.
		''' </summary>
		''' <param name="allowDuplicates">Flag To allow duplicate rows (True) Or Not (False)</param>
		''' <param name="filter">The filter To apply For the count retrieval</param>
		''' <param name="groupByClause">group by clause To embed In the query</param>
		''' <returns>the number of rows In the Set defined by the passed In query elements</returns>
		Public Overridable Function GetDbCount(allowDuplicates As Boolean, Filter As IPredicateExpression, groupByClause As GroupByCollection) As Integer Implements ITypedView.GetDbCount
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwProductosGeneralesTypedView)
			Dim dao As TypedListDAO = DAOFactory.CreateTypedListDAO()
			Return dao.GetDbCount(fieldsInResultset, Nothing, filter, Nothing, groupByClause, allowDuplicates)
		End Function


		''' <summary>
		''' Gets the enumerator for this class.
		''' </summary>
		''' <returns>Enumerator for this class.</returns>
		Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
			Return Me.Rows.GetEnumerator()
		End Function


		''' <summary>
		''' Creates a new typed row during the build of the datatable during a Fill session by a dataadapter.
		''' </summary>
		''' <param name="rowBuilder">supplied row builder to pass to the typed row</param>
		''' <returns>the new typed datarow</returns>
		Protected Overrides Function NewRowFromBuilder(rowBuilder As DataRowBuilder) As DataRow
			Return New VwProductosGeneralesRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnPdIdProducto = New DataColumn("PdIdProducto", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPdIdProducto.ReadOnly = True
			_columnPdIdProducto.Caption = "PdIdProducto"
			Me.Columns.Add(_columnPdIdProducto)

			_columnPdDescripcion = New DataColumn("PdDescripcion", GetType(System.String), Nothing, MappingType.Element)
			_columnPdDescripcion.ReadOnly = True
			_columnPdDescripcion.Caption = "PdDescripcion"
			Me.Columns.Add(_columnPdDescripcion)

			_columnPdDescrpcionCorta = New DataColumn("PdDescrpcionCorta", GetType(System.String), Nothing, MappingType.Element)
			_columnPdDescrpcionCorta.ReadOnly = True
			_columnPdDescrpcionCorta.Caption = "PdDescrpcionCorta"
			Me.Columns.Add(_columnPdDescrpcionCorta)

			_columnPdIdLinea = New DataColumn("PdIdLinea", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPdIdLinea.ReadOnly = True
			_columnPdIdLinea.Caption = "PdIdLinea"
			Me.Columns.Add(_columnPdIdLinea)

			_columnPdIdUnidadMedida = New DataColumn("PdIdUnidadMedida", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPdIdUnidadMedida.ReadOnly = True
			_columnPdIdUnidadMedida.Caption = "PdIdUnidadMedida"
			Me.Columns.Add(_columnPdIdUnidadMedida)

			_columnPdIdMarca = New DataColumn("PdIdMarca", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPdIdMarca.ReadOnly = True
			_columnPdIdMarca.Caption = "PdIdMarca"
			Me.Columns.Add(_columnPdIdMarca)

			_columnPdIdPresentacion = New DataColumn("PdIdPresentacion", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPdIdPresentacion.ReadOnly = True
			_columnPdIdPresentacion.Caption = "PdIdPresentacion"
			Me.Columns.Add(_columnPdIdPresentacion)

			_columnPdSeFactura = New DataColumn("PdSeFactura", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnPdSeFactura.ReadOnly = True
			_columnPdSeFactura.Caption = "PdSeFactura"
			Me.Columns.Add(_columnPdSeFactura)

			_columnPdSeRecibeParcial = New DataColumn("PdSeRecibeParcial", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnPdSeRecibeParcial.ReadOnly = True
			_columnPdSeRecibeParcial.Caption = "PdSeRecibeParcial"
			Me.Columns.Add(_columnPdSeRecibeParcial)

			_columnPdSeObtieneMermas = New DataColumn("PdSeObtieneMermas", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnPdSeObtieneMermas.ReadOnly = True
			_columnPdSeObtieneMermas.Caption = "PdSeObtieneMermas"
			Me.Columns.Add(_columnPdSeObtieneMermas)

			_columnPdSeRecibeSinFactura = New DataColumn("PdSeRecibeSinFactura", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnPdSeRecibeSinFactura.ReadOnly = True
			_columnPdSeRecibeSinFactura.Caption = "PdSeRecibeSinFactura"
			Me.Columns.Add(_columnPdSeRecibeSinFactura)

			_columnPdSeFacturaSinExistencia = New DataColumn("PdSeFacturaSinExistencia", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnPdSeFacturaSinExistencia.ReadOnly = True
			_columnPdSeFacturaSinExistencia.Caption = "PdSeFacturaSinExistencia"
			Me.Columns.Add(_columnPdSeFacturaSinExistencia)

			_columnPdSeManejaPorLotes = New DataColumn("PdSeManejaPorLotes", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnPdSeManejaPorLotes.ReadOnly = True
			_columnPdSeManejaPorLotes.Caption = "PdSeManejaPorLotes"
			Me.Columns.Add(_columnPdSeManejaPorLotes)

			_columnPdProductoGeneral = New DataColumn("PdProductoGeneral", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnPdProductoGeneral.ReadOnly = True
			_columnPdProductoGeneral.Caption = "PdProductoGeneral"
			Me.Columns.Add(_columnPdProductoGeneral)

			_columnPdMezcla = New DataColumn("PdMezcla", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnPdMezcla.ReadOnly = True
			_columnPdMezcla.Caption = "PdMezcla"
			Me.Columns.Add(_columnPdMezcla)

			_columnPdIngrediente = New DataColumn("PdIngrediente", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnPdIngrediente.ReadOnly = True
			_columnPdIngrediente.Caption = "PdIngrediente"
			Me.Columns.Add(_columnPdIngrediente)

			_columnPdMaterialEnvase = New DataColumn("PdMaterialEnvase", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnPdMaterialEnvase.ReadOnly = True
			_columnPdMaterialEnvase.Caption = "PdMaterialEnvase"
			Me.Columns.Add(_columnPdMaterialEnvase)

			_columnPdDiasMaxCaducidad = New DataColumn("PdDiasMaxCaducidad", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPdDiasMaxCaducidad.ReadOnly = True
			_columnPdDiasMaxCaducidad.Caption = "PdDiasMaxCaducidad"
			Me.Columns.Add(_columnPdDiasMaxCaducidad)

			_columnPdPiezas = New DataColumn("PdPiezas", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPdPiezas.ReadOnly = True
			_columnPdPiezas.Caption = "PdPiezas"
			Me.Columns.Add(_columnPdPiezas)

			_columnPdIdUsuarioAlta = New DataColumn("PdIdUsuarioAlta", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPdIdUsuarioAlta.ReadOnly = True
			_columnPdIdUsuarioAlta.Caption = "PdIdUsuarioAlta"
			Me.Columns.Add(_columnPdIdUsuarioAlta)

			_columnPdFechaAlta = New DataColumn("PdFechaAlta", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnPdFechaAlta.ReadOnly = True
			_columnPdFechaAlta.Caption = "PdFechaAlta"
			Me.Columns.Add(_columnPdFechaAlta)

			_columnPdIdUsuarioBaja = New DataColumn("PdIdUsuarioBaja", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPdIdUsuarioBaja.ReadOnly = True
			_columnPdIdUsuarioBaja.Caption = "PdIdUsuarioBaja"
			Me.Columns.Add(_columnPdIdUsuarioBaja)

			_columnPdFechaBaja = New DataColumn("PdFechaBaja", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnPdFechaBaja.ReadOnly = True
			_columnPdFechaBaja.Caption = "PdFechaBaja"
			Me.Columns.Add(_columnPdFechaBaja)

			_columnPdIdMotivoBaja = New DataColumn("PdIdMotivoBaja", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPdIdMotivoBaja.ReadOnly = True
			_columnPdIdMotivoBaja.Caption = "PdIdMotivoBaja"
			Me.Columns.Add(_columnPdIdMotivoBaja)

			_columnPdObservacionBaja = New DataColumn("PdObservacionBaja", GetType(System.String), Nothing, MappingType.Element)
			_columnPdObservacionBaja.ReadOnly = True
			_columnPdObservacionBaja.Caption = "PdObservacionBaja"
			Me.Columns.Add(_columnPdObservacionBaja)

			_columnPdEstatus = New DataColumn("PdEstatus", GetType(System.Int16), Nothing, MappingType.Element)
			_columnPdEstatus.ReadOnly = True
			_columnPdEstatus.Caption = "PdEstatus"
			Me.Columns.Add(_columnPdEstatus)

			_columnPdCodigoRelacionado = New DataColumn("PdCodigoRelacionado", GetType(System.String), Nothing, MappingType.Element)
			_columnPdCodigoRelacionado.ReadOnly = True
			_columnPdCodigoRelacionado.Caption = "PdCodigoRelacionado"
			Me.Columns.Add(_columnPdCodigoRelacionado)

			_columnPdTipoProducto = New DataColumn("PdTipoProducto", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPdTipoProducto.ReadOnly = True
			_columnPdTipoProducto.Caption = "PdTipoProducto"
			Me.Columns.Add(_columnPdTipoProducto)

			_columnPdCaduca = New DataColumn("PdCaduca", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnPdCaduca.ReadOnly = True
			_columnPdCaduca.Caption = "PdCaduca"
			Me.Columns.Add(_columnPdCaduca)

			_columnPdSeAplicaIva = New DataColumn("PdSeAplicaIva", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnPdSeAplicaIva.ReadOnly = True
			_columnPdSeAplicaIva.Caption = "PdSeAplicaIva"
			Me.Columns.Add(_columnPdSeAplicaIva)

			_columnFactorConver = New DataColumn("FactorConver", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnFactorConver.ReadOnly = True
			_columnFactorConver.Caption = "FactorConver"
			Me.Columns.Add(_columnFactorConver)

			_columnFechaUltimaCompra = New DataColumn("FechaUltimaCompra", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaUltimaCompra.ReadOnly = True
			_columnFechaUltimaCompra.Caption = "FechaUltimaCompra"
			Me.Columns.Add(_columnFechaUltimaCompra)

			_columnCantidadUltimaCompra = New DataColumn("CantidadUltimaCompra", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCantidadUltimaCompra.ReadOnly = True
			_columnCantidadUltimaCompra.Caption = "CantidadUltimaCompra"
			Me.Columns.Add(_columnCantidadUltimaCompra)

			_columnImporteUltimaCompra = New DataColumn("ImporteUltimaCompra", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnImporteUltimaCompra.ReadOnly = True
			_columnImporteUltimaCompra.Caption = "ImporteUltimaCompra"
			Me.Columns.Add(_columnImporteUltimaCompra)

			_columnUltimoCosto = New DataColumn("UltimoCosto", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnUltimoCosto.ReadOnly = True
			_columnUltimoCosto.Caption = "UltimoCosto"
			Me.Columns.Add(_columnUltimoCosto)

			_columnArtPuntoVenta = New DataColumn("ArtPuntoVenta", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnArtPuntoVenta.ReadOnly = True
			_columnArtPuntoVenta.Caption = "ArtPuntoVenta"
			Me.Columns.Add(_columnArtPuntoVenta)

			_columnArtMeat = New DataColumn("ArtMeat", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnArtMeat.ReadOnly = True
			_columnArtMeat.Caption = "ArtMeat"
			Me.Columns.Add(_columnArtMeat)

			_columnCodigoBarra = New DataColumn("CodigoBarra", GetType(System.String), Nothing, MappingType.Element)
			_columnCodigoBarra.ReadOnly = True
			_columnCodigoBarra.Caption = "CodigoBarra"
			Me.Columns.Add(_columnCodigoBarra)

			_columnPorcIeps = New DataColumn("PorcIeps", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnPorcIeps.ReadOnly = True
			_columnPorcIeps.Caption = "PorcIeps"
			Me.Columns.Add(_columnPorcIeps)

			_columnPdEsKit = New DataColumn("PdEsKit", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnPdEsKit.ReadOnly = True
			_columnPdEsKit.Caption = "PdEsKit"
			Me.Columns.Add(_columnPdEsKit)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnPdIdProducto = Me.Columns("PdIdProducto")
			_columnPdDescripcion = Me.Columns("PdDescripcion")
			_columnPdDescrpcionCorta = Me.Columns("PdDescrpcionCorta")
			_columnPdIdLinea = Me.Columns("PdIdLinea")
			_columnPdIdUnidadMedida = Me.Columns("PdIdUnidadMedida")
			_columnPdIdMarca = Me.Columns("PdIdMarca")
			_columnPdIdPresentacion = Me.Columns("PdIdPresentacion")
			_columnPdSeFactura = Me.Columns("PdSeFactura")
			_columnPdSeRecibeParcial = Me.Columns("PdSeRecibeParcial")
			_columnPdSeObtieneMermas = Me.Columns("PdSeObtieneMermas")
			_columnPdSeRecibeSinFactura = Me.Columns("PdSeRecibeSinFactura")
			_columnPdSeFacturaSinExistencia = Me.Columns("PdSeFacturaSinExistencia")
			_columnPdSeManejaPorLotes = Me.Columns("PdSeManejaPorLotes")
			_columnPdProductoGeneral = Me.Columns("PdProductoGeneral")
			_columnPdMezcla = Me.Columns("PdMezcla")
			_columnPdIngrediente = Me.Columns("PdIngrediente")
			_columnPdMaterialEnvase = Me.Columns("PdMaterialEnvase")
			_columnPdDiasMaxCaducidad = Me.Columns("PdDiasMaxCaducidad")
			_columnPdPiezas = Me.Columns("PdPiezas")
			_columnPdIdUsuarioAlta = Me.Columns("PdIdUsuarioAlta")
			_columnPdFechaAlta = Me.Columns("PdFechaAlta")
			_columnPdIdUsuarioBaja = Me.Columns("PdIdUsuarioBaja")
			_columnPdFechaBaja = Me.Columns("PdFechaBaja")
			_columnPdIdMotivoBaja = Me.Columns("PdIdMotivoBaja")
			_columnPdObservacionBaja = Me.Columns("PdObservacionBaja")
			_columnPdEstatus = Me.Columns("PdEstatus")
			_columnPdCodigoRelacionado = Me.Columns("PdCodigoRelacionado")
			_columnPdTipoProducto = Me.Columns("PdTipoProducto")
			_columnPdCaduca = Me.Columns("PdCaduca")
			_columnPdSeAplicaIva = Me.Columns("PdSeAplicaIva")
			_columnFactorConver = Me.Columns("FactorConver")
			_columnFechaUltimaCompra = Me.Columns("FechaUltimaCompra")
			_columnCantidadUltimaCompra = Me.Columns("CantidadUltimaCompra")
			_columnImporteUltimaCompra = Me.Columns("ImporteUltimaCompra")
			_columnUltimoCosto = Me.Columns("UltimoCosto")
			_columnArtPuntoVenta = Me.Columns("ArtPuntoVenta")
			_columnArtMeat = Me.Columns("ArtMeat")
			_columnCodigoBarra = Me.Columns("CodigoBarra")
			_columnPorcIeps = Me.Columns("PorcIeps")
			_columnPdEsKit = Me.Columns("PdEsKit")
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the hashtables for the TypedView type and TypedView field custom properties. 
		''' </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Hashtable()
			_fieldsCustomProperties = New Hashtable()

			' Add custom properties of this type

			' Add per Field a new Hashtable with its custom properties, indexed by the name of the field.
			Dim fieldHashtable As Hashtable = Nothing
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdIdProducto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdDescripcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdDescrpcionCorta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdIdLinea", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdIdUnidadMedida", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdIdMarca", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdIdPresentacion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdSeFactura", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdSeRecibeParcial", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdSeObtieneMermas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdSeRecibeSinFactura", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdSeFacturaSinExistencia", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdSeManejaPorLotes", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdProductoGeneral", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdMezcla", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdIngrediente", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdMaterialEnvase", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdDiasMaxCaducidad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdPiezas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdIdUsuarioAlta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdFechaAlta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdIdUsuarioBaja", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdFechaBaja", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdIdMotivoBaja", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdObservacionBaja", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdEstatus", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdCodigoRelacionado", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdTipoProducto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdCaduca", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdSeAplicaIva", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FactorConver", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaUltimaCompra", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantidadUltimaCompra", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ImporteUltimaCompra", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("UltimoCosto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ArtPuntoVenta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ArtMeat", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CodigoBarra", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PorcIeps", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PdEsKit", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwProductosGeneralesRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwProductosGeneralesTypedView = CType(MyBase.Clone(), VwProductosGeneralesTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwProductosGeneralesTypedView()
		End Function
#End If

#Region "Class Property Declarations"
		''' <summary>
		''' Returns the amount of rows in this typed view.
		''' </summary>
		<System.ComponentModel.Browsable(False)> _
		Public ReadOnly Property Count As Integer Implements ITypedView.Count
			Get 
				Return Me.Rows.Count
			End Get
		End Property
		
		''' <summary>
		''' The custom properties for this TypedView type.
		''' </summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public Shared ReadOnly Property CustomProperties() As Hashtable
			Get
				Return _customProperties
			End Get
		End Property

		''' <summary>
		''' The custom properties for the type of this TypedView instance.
		''' </summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<System.ComponentModel.Browsable(False)> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Hashtable
			Get
				Return VwProductosGeneralesTypedView.CustomProperties
			End Get
		End Property

		''' <summary>
		''' The custom properties for the fields of this TypedView type. The returned Hashtable contains per fieldname a hashtable of name-value
		''' pairs. 
		''' </summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public Shared ReadOnly Property FieldsCustomProperties() As Hashtable
			Get
				Return _fieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' The custom properties for the fields of the type of this TypedView instance. The returned Hashtable contains per fieldname a hashtable of name-value
		''' pairs. 
		''' </summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<System.ComponentModel.Browsable(False)> _
		Public Overridable ReadOnly Property FieldsCustomPropertiesOfType() As Hashtable
			Get
				Return VwProductosGeneralesTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwProductosGeneralesRow
			Get 
				Return CType(Me.Rows(index), VwProductosGeneralesRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdIdProducto
		''' </summary>
		ReadOnly Friend Property PdIdProductoColumn As DataColumn
			Get 
				Return _columnPdIdProducto 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdDescripcion
		''' </summary>
		ReadOnly Friend Property PdDescripcionColumn As DataColumn
			Get 
				Return _columnPdDescripcion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdDescrpcionCorta
		''' </summary>
		ReadOnly Friend Property PdDescrpcionCortaColumn As DataColumn
			Get 
				Return _columnPdDescrpcionCorta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdIdLinea
		''' </summary>
		ReadOnly Friend Property PdIdLineaColumn As DataColumn
			Get 
				Return _columnPdIdLinea 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdIdUnidadMedida
		''' </summary>
		ReadOnly Friend Property PdIdUnidadMedidaColumn As DataColumn
			Get 
				Return _columnPdIdUnidadMedida 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdIdMarca
		''' </summary>
		ReadOnly Friend Property PdIdMarcaColumn As DataColumn
			Get 
				Return _columnPdIdMarca 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdIdPresentacion
		''' </summary>
		ReadOnly Friend Property PdIdPresentacionColumn As DataColumn
			Get 
				Return _columnPdIdPresentacion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdSeFactura
		''' </summary>
		ReadOnly Friend Property PdSeFacturaColumn As DataColumn
			Get 
				Return _columnPdSeFactura 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdSeRecibeParcial
		''' </summary>
		ReadOnly Friend Property PdSeRecibeParcialColumn As DataColumn
			Get 
				Return _columnPdSeRecibeParcial 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdSeObtieneMermas
		''' </summary>
		ReadOnly Friend Property PdSeObtieneMermasColumn As DataColumn
			Get 
				Return _columnPdSeObtieneMermas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdSeRecibeSinFactura
		''' </summary>
		ReadOnly Friend Property PdSeRecibeSinFacturaColumn As DataColumn
			Get 
				Return _columnPdSeRecibeSinFactura 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdSeFacturaSinExistencia
		''' </summary>
		ReadOnly Friend Property PdSeFacturaSinExistenciaColumn As DataColumn
			Get 
				Return _columnPdSeFacturaSinExistencia 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdSeManejaPorLotes
		''' </summary>
		ReadOnly Friend Property PdSeManejaPorLotesColumn As DataColumn
			Get 
				Return _columnPdSeManejaPorLotes 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdProductoGeneral
		''' </summary>
		ReadOnly Friend Property PdProductoGeneralColumn As DataColumn
			Get 
				Return _columnPdProductoGeneral 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdMezcla
		''' </summary>
		ReadOnly Friend Property PdMezclaColumn As DataColumn
			Get 
				Return _columnPdMezcla 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdIngrediente
		''' </summary>
		ReadOnly Friend Property PdIngredienteColumn As DataColumn
			Get 
				Return _columnPdIngrediente 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdMaterialEnvase
		''' </summary>
		ReadOnly Friend Property PdMaterialEnvaseColumn As DataColumn
			Get 
				Return _columnPdMaterialEnvase 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdDiasMaxCaducidad
		''' </summary>
		ReadOnly Friend Property PdDiasMaxCaducidadColumn As DataColumn
			Get 
				Return _columnPdDiasMaxCaducidad 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdPiezas
		''' </summary>
		ReadOnly Friend Property PdPiezasColumn As DataColumn
			Get 
				Return _columnPdPiezas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdIdUsuarioAlta
		''' </summary>
		ReadOnly Friend Property PdIdUsuarioAltaColumn As DataColumn
			Get 
				Return _columnPdIdUsuarioAlta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdFechaAlta
		''' </summary>
		ReadOnly Friend Property PdFechaAltaColumn As DataColumn
			Get 
				Return _columnPdFechaAlta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdIdUsuarioBaja
		''' </summary>
		ReadOnly Friend Property PdIdUsuarioBajaColumn As DataColumn
			Get 
				Return _columnPdIdUsuarioBaja 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdFechaBaja
		''' </summary>
		ReadOnly Friend Property PdFechaBajaColumn As DataColumn
			Get 
				Return _columnPdFechaBaja 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdIdMotivoBaja
		''' </summary>
		ReadOnly Friend Property PdIdMotivoBajaColumn As DataColumn
			Get 
				Return _columnPdIdMotivoBaja 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdObservacionBaja
		''' </summary>
		ReadOnly Friend Property PdObservacionBajaColumn As DataColumn
			Get 
				Return _columnPdObservacionBaja 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdEstatus
		''' </summary>
		ReadOnly Friend Property PdEstatusColumn As DataColumn
			Get 
				Return _columnPdEstatus 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdCodigoRelacionado
		''' </summary>
		ReadOnly Friend Property PdCodigoRelacionadoColumn As DataColumn
			Get 
				Return _columnPdCodigoRelacionado 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdTipoProducto
		''' </summary>
		ReadOnly Friend Property PdTipoProductoColumn As DataColumn
			Get 
				Return _columnPdTipoProducto 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdCaduca
		''' </summary>
		ReadOnly Friend Property PdCaducaColumn As DataColumn
			Get 
				Return _columnPdCaduca 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdSeAplicaIva
		''' </summary>
		ReadOnly Friend Property PdSeAplicaIvaColumn As DataColumn
			Get 
				Return _columnPdSeAplicaIva 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FactorConver
		''' </summary>
		ReadOnly Friend Property FactorConverColumn As DataColumn
			Get 
				Return _columnFactorConver 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FechaUltimaCompra
		''' </summary>
		ReadOnly Friend Property FechaUltimaCompraColumn As DataColumn
			Get 
				Return _columnFechaUltimaCompra 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CantidadUltimaCompra
		''' </summary>
		ReadOnly Friend Property CantidadUltimaCompraColumn As DataColumn
			Get 
				Return _columnCantidadUltimaCompra 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field ImporteUltimaCompra
		''' </summary>
		ReadOnly Friend Property ImporteUltimaCompraColumn As DataColumn
			Get 
				Return _columnImporteUltimaCompra 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field UltimoCosto
		''' </summary>
		ReadOnly Friend Property UltimoCostoColumn As DataColumn
			Get 
				Return _columnUltimoCosto 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field ArtPuntoVenta
		''' </summary>
		ReadOnly Friend Property ArtPuntoVentaColumn As DataColumn
			Get 
				Return _columnArtPuntoVenta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field ArtMeat
		''' </summary>
		ReadOnly Friend Property ArtMeatColumn As DataColumn
			Get 
				Return _columnArtMeat 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CodigoBarra
		''' </summary>
		ReadOnly Friend Property CodigoBarraColumn As DataColumn
			Get 
				Return _columnCodigoBarra 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PorcIeps
		''' </summary>
		ReadOnly Friend Property PorcIepsColumn As DataColumn
			Get 
				Return _columnPorcIeps 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PdEsKit
		''' </summary>
		ReadOnly Friend Property PdEsKitColumn As DataColumn
			Get 
				Return _columnPdEsKit 
			End Get
		End Property
    
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalColumnProperties
		' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

#Region "Custom Typed View code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

#Region "Included Code"

#End Region
	End Class


	''' <summary>
	''' Typed datarow for the typed datatable VwProductosGenerales
	''' </summary>
	Public Class VwProductosGeneralesRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwProductosGeneralesTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwProductosGeneralesTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field PdIdProducto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdIdProducto"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PdIdProducto]() As System.Int32
			Get 
				If IsPdIdProductoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PdIdProductoColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PdIdProductoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdIdProducto is NULL, False otherwise.
		''' </summary>
		Public Function IsPdIdProductoNull() As Boolean
			Return IsNull(_parent.PdIdProductoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdIdProducto to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdIdProductoNull() 
			Me(_parent.PdIdProductoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdDescripcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdDescripcion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 250
		''' </remarks>
		Public Property [PdDescripcion]() As System.String
			Get 
				If IsPdDescripcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PdDescripcionColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PdDescripcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdDescripcion is NULL, False otherwise.
		''' </summary>
		Public Function IsPdDescripcionNull() As Boolean
			Return IsNull(_parent.PdDescripcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdDescripcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdDescripcionNull() 
			Me(_parent.PdDescripcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdDescrpcionCorta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdDescrpcionCorta"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 50
		''' </remarks>
		Public Property [PdDescrpcionCorta]() As System.String
			Get 
				If IsPdDescrpcionCortaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PdDescrpcionCortaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PdDescrpcionCortaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdDescrpcionCorta is NULL, False otherwise.
		''' </summary>
		Public Function IsPdDescrpcionCortaNull() As Boolean
			Return IsNull(_parent.PdDescrpcionCortaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdDescrpcionCorta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdDescrpcionCortaNull() 
			Me(_parent.PdDescrpcionCortaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdIdLinea<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdIdLinea"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PdIdLinea]() As System.Int32
			Get 
				If IsPdIdLineaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PdIdLineaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PdIdLineaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdIdLinea is NULL, False otherwise.
		''' </summary>
		Public Function IsPdIdLineaNull() As Boolean
			Return IsNull(_parent.PdIdLineaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdIdLinea to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdIdLineaNull() 
			Me(_parent.PdIdLineaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdIdUnidadMedida<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdIdUnidadMedida"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PdIdUnidadMedida]() As System.Int32
			Get 
				If IsPdIdUnidadMedidaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PdIdUnidadMedidaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PdIdUnidadMedidaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdIdUnidadMedida is NULL, False otherwise.
		''' </summary>
		Public Function IsPdIdUnidadMedidaNull() As Boolean
			Return IsNull(_parent.PdIdUnidadMedidaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdIdUnidadMedida to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdIdUnidadMedidaNull() 
			Me(_parent.PdIdUnidadMedidaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdIdMarca<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdIdMarca"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PdIdMarca]() As System.Int32
			Get 
				If IsPdIdMarcaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PdIdMarcaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PdIdMarcaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdIdMarca is NULL, False otherwise.
		''' </summary>
		Public Function IsPdIdMarcaNull() As Boolean
			Return IsNull(_parent.PdIdMarcaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdIdMarca to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdIdMarcaNull() 
			Me(_parent.PdIdMarcaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdIdPresentacion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdIdPresentacion"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PdIdPresentacion]() As System.Int32
			Get 
				If IsPdIdPresentacionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PdIdPresentacionColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PdIdPresentacionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdIdPresentacion is NULL, False otherwise.
		''' </summary>
		Public Function IsPdIdPresentacionNull() As Boolean
			Return IsNull(_parent.PdIdPresentacionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdIdPresentacion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdIdPresentacionNull() 
			Me(_parent.PdIdPresentacionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdSeFactura<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdSeFactura"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [PdSeFactura]() As System.Boolean
			Get 
				If IsPdSeFacturaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.PdSeFacturaColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.PdSeFacturaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdSeFactura is NULL, False otherwise.
		''' </summary>
		Public Function IsPdSeFacturaNull() As Boolean
			Return IsNull(_parent.PdSeFacturaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdSeFactura to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdSeFacturaNull() 
			Me(_parent.PdSeFacturaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdSeRecibeParcial<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdSeRecibeParcial"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [PdSeRecibeParcial]() As System.Boolean
			Get 
				If IsPdSeRecibeParcialNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.PdSeRecibeParcialColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.PdSeRecibeParcialColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdSeRecibeParcial is NULL, False otherwise.
		''' </summary>
		Public Function IsPdSeRecibeParcialNull() As Boolean
			Return IsNull(_parent.PdSeRecibeParcialColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdSeRecibeParcial to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdSeRecibeParcialNull() 
			Me(_parent.PdSeRecibeParcialColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdSeObtieneMermas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdSeObtieneMermas"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [PdSeObtieneMermas]() As System.Boolean
			Get 
				If IsPdSeObtieneMermasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.PdSeObtieneMermasColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.PdSeObtieneMermasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdSeObtieneMermas is NULL, False otherwise.
		''' </summary>
		Public Function IsPdSeObtieneMermasNull() As Boolean
			Return IsNull(_parent.PdSeObtieneMermasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdSeObtieneMermas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdSeObtieneMermasNull() 
			Me(_parent.PdSeObtieneMermasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdSeRecibeSinFactura<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdSeRecibeSinFactura"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [PdSeRecibeSinFactura]() As System.Boolean
			Get 
				If IsPdSeRecibeSinFacturaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.PdSeRecibeSinFacturaColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.PdSeRecibeSinFacturaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdSeRecibeSinFactura is NULL, False otherwise.
		''' </summary>
		Public Function IsPdSeRecibeSinFacturaNull() As Boolean
			Return IsNull(_parent.PdSeRecibeSinFacturaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdSeRecibeSinFactura to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdSeRecibeSinFacturaNull() 
			Me(_parent.PdSeRecibeSinFacturaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdSeFacturaSinExistencia<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdSeFacturaSinExistencia"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [PdSeFacturaSinExistencia]() As System.Boolean
			Get 
				If IsPdSeFacturaSinExistenciaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.PdSeFacturaSinExistenciaColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.PdSeFacturaSinExistenciaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdSeFacturaSinExistencia is NULL, False otherwise.
		''' </summary>
		Public Function IsPdSeFacturaSinExistenciaNull() As Boolean
			Return IsNull(_parent.PdSeFacturaSinExistenciaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdSeFacturaSinExistencia to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdSeFacturaSinExistenciaNull() 
			Me(_parent.PdSeFacturaSinExistenciaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdSeManejaPorLotes<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdSeManejaPorLotes"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [PdSeManejaPorLotes]() As System.Boolean
			Get 
				If IsPdSeManejaPorLotesNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.PdSeManejaPorLotesColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.PdSeManejaPorLotesColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdSeManejaPorLotes is NULL, False otherwise.
		''' </summary>
		Public Function IsPdSeManejaPorLotesNull() As Boolean
			Return IsNull(_parent.PdSeManejaPorLotesColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdSeManejaPorLotes to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdSeManejaPorLotesNull() 
			Me(_parent.PdSeManejaPorLotesColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdProductoGeneral<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdProductoGeneral"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [PdProductoGeneral]() As System.Boolean
			Get 
				If IsPdProductoGeneralNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.PdProductoGeneralColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.PdProductoGeneralColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdProductoGeneral is NULL, False otherwise.
		''' </summary>
		Public Function IsPdProductoGeneralNull() As Boolean
			Return IsNull(_parent.PdProductoGeneralColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdProductoGeneral to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdProductoGeneralNull() 
			Me(_parent.PdProductoGeneralColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdMezcla<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdMezcla"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [PdMezcla]() As System.Boolean
			Get 
				If IsPdMezclaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.PdMezclaColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.PdMezclaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdMezcla is NULL, False otherwise.
		''' </summary>
		Public Function IsPdMezclaNull() As Boolean
			Return IsNull(_parent.PdMezclaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdMezcla to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdMezclaNull() 
			Me(_parent.PdMezclaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdIngrediente<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdIngrediente"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [PdIngrediente]() As System.Boolean
			Get 
				If IsPdIngredienteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.PdIngredienteColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.PdIngredienteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdIngrediente is NULL, False otherwise.
		''' </summary>
		Public Function IsPdIngredienteNull() As Boolean
			Return IsNull(_parent.PdIngredienteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdIngrediente to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdIngredienteNull() 
			Me(_parent.PdIngredienteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdMaterialEnvase<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdMaterialEnvase"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [PdMaterialEnvase]() As System.Boolean
			Get 
				If IsPdMaterialEnvaseNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.PdMaterialEnvaseColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.PdMaterialEnvaseColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdMaterialEnvase is NULL, False otherwise.
		''' </summary>
		Public Function IsPdMaterialEnvaseNull() As Boolean
			Return IsNull(_parent.PdMaterialEnvaseColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdMaterialEnvase to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdMaterialEnvaseNull() 
			Me(_parent.PdMaterialEnvaseColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdDiasMaxCaducidad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdDiasMaxCaducidad"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PdDiasMaxCaducidad]() As System.Int32
			Get 
				If IsPdDiasMaxCaducidadNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PdDiasMaxCaducidadColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PdDiasMaxCaducidadColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdDiasMaxCaducidad is NULL, False otherwise.
		''' </summary>
		Public Function IsPdDiasMaxCaducidadNull() As Boolean
			Return IsNull(_parent.PdDiasMaxCaducidadColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdDiasMaxCaducidad to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdDiasMaxCaducidadNull() 
			Me(_parent.PdDiasMaxCaducidadColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdPiezas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdPiezas"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PdPiezas]() As System.Int32
			Get 
				If IsPdPiezasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PdPiezasColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PdPiezasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdPiezas is NULL, False otherwise.
		''' </summary>
		Public Function IsPdPiezasNull() As Boolean
			Return IsNull(_parent.PdPiezasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdPiezas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdPiezasNull() 
			Me(_parent.PdPiezasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdIdUsuarioAlta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdIdUsuarioAlta"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PdIdUsuarioAlta]() As System.Int32
			Get 
				If IsPdIdUsuarioAltaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PdIdUsuarioAltaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PdIdUsuarioAltaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdIdUsuarioAlta is NULL, False otherwise.
		''' </summary>
		Public Function IsPdIdUsuarioAltaNull() As Boolean
			Return IsNull(_parent.PdIdUsuarioAltaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdIdUsuarioAlta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdIdUsuarioAltaNull() 
			Me(_parent.PdIdUsuarioAltaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdFechaAlta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdFechaAlta"<br/>
		''' View field characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0
		''' </remarks>
		Public Property [PdFechaAlta]() As System.DateTime
			Get 
				If IsPdFechaAltaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.PdFechaAltaColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.PdFechaAltaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdFechaAlta is NULL, False otherwise.
		''' </summary>
		Public Function IsPdFechaAltaNull() As Boolean
			Return IsNull(_parent.PdFechaAltaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdFechaAlta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdFechaAltaNull() 
			Me(_parent.PdFechaAltaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdIdUsuarioBaja<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdIdUsuarioBaja"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PdIdUsuarioBaja]() As System.Int32
			Get 
				If IsPdIdUsuarioBajaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PdIdUsuarioBajaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PdIdUsuarioBajaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdIdUsuarioBaja is NULL, False otherwise.
		''' </summary>
		Public Function IsPdIdUsuarioBajaNull() As Boolean
			Return IsNull(_parent.PdIdUsuarioBajaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdIdUsuarioBaja to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdIdUsuarioBajaNull() 
			Me(_parent.PdIdUsuarioBajaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdFechaBaja<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdFechaBaja"<br/>
		''' View field characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0
		''' </remarks>
		Public Property [PdFechaBaja]() As System.DateTime
			Get 
				If IsPdFechaBajaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.PdFechaBajaColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.PdFechaBajaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdFechaBaja is NULL, False otherwise.
		''' </summary>
		Public Function IsPdFechaBajaNull() As Boolean
			Return IsNull(_parent.PdFechaBajaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdFechaBaja to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdFechaBajaNull() 
			Me(_parent.PdFechaBajaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdIdMotivoBaja<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdIdMotivoBaja"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PdIdMotivoBaja]() As System.Int32
			Get 
				If IsPdIdMotivoBajaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PdIdMotivoBajaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PdIdMotivoBajaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdIdMotivoBaja is NULL, False otherwise.
		''' </summary>
		Public Function IsPdIdMotivoBajaNull() As Boolean
			Return IsNull(_parent.PdIdMotivoBajaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdIdMotivoBaja to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdIdMotivoBajaNull() 
			Me(_parent.PdIdMotivoBajaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdObservacionBaja<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdObservacionBaja"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 50
		''' </remarks>
		Public Property [PdObservacionBaja]() As System.String
			Get 
				If IsPdObservacionBajaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PdObservacionBajaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PdObservacionBajaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdObservacionBaja is NULL, False otherwise.
		''' </summary>
		Public Function IsPdObservacionBajaNull() As Boolean
			Return IsNull(_parent.PdObservacionBajaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdObservacionBaja to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdObservacionBajaNull() 
			Me(_parent.PdObservacionBajaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdEstatus<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdEstatus"<br/>
		''' View field characteristics (type, precision, scale, length): SmallInt, 5, 0, 0
		''' </remarks>
		Public Property [PdEstatus]() As System.Int16
			Get 
				If IsPdEstatusNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int16)), System.Int16)
				Else
					Return CType(Me(_parent.PdEstatusColumn), System.Int16)
				End If
			End Get
			Set 
				Me(_parent.PdEstatusColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdEstatus is NULL, False otherwise.
		''' </summary>
		Public Function IsPdEstatusNull() As Boolean
			Return IsNull(_parent.PdEstatusColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdEstatus to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdEstatusNull() 
			Me(_parent.PdEstatusColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdCodigoRelacionado<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdCodigoRelacionado"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 50
		''' </remarks>
		Public Property [PdCodigoRelacionado]() As System.String
			Get 
				If IsPdCodigoRelacionadoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PdCodigoRelacionadoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PdCodigoRelacionadoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdCodigoRelacionado is NULL, False otherwise.
		''' </summary>
		Public Function IsPdCodigoRelacionadoNull() As Boolean
			Return IsNull(_parent.PdCodigoRelacionadoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdCodigoRelacionado to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdCodigoRelacionadoNull() 
			Me(_parent.PdCodigoRelacionadoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdTipoProducto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdTipoProducto"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PdTipoProducto]() As System.Int32
			Get 
				If IsPdTipoProductoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PdTipoProductoColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PdTipoProductoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdTipoProducto is NULL, False otherwise.
		''' </summary>
		Public Function IsPdTipoProductoNull() As Boolean
			Return IsNull(_parent.PdTipoProductoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdTipoProducto to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdTipoProductoNull() 
			Me(_parent.PdTipoProductoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdCaduca<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdCaduca"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [PdCaduca]() As System.Boolean
			Get 
				If IsPdCaducaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.PdCaducaColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.PdCaducaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdCaduca is NULL, False otherwise.
		''' </summary>
		Public Function IsPdCaducaNull() As Boolean
			Return IsNull(_parent.PdCaducaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdCaduca to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdCaducaNull() 
			Me(_parent.PdCaducaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdSeAplicaIva<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdSeAplicaIva"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [PdSeAplicaIva]() As System.Boolean
			Get 
				If IsPdSeAplicaIvaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.PdSeAplicaIvaColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.PdSeAplicaIvaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdSeAplicaIva is NULL, False otherwise.
		''' </summary>
		Public Function IsPdSeAplicaIvaNull() As Boolean
			Return IsNull(_parent.PdSeAplicaIvaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdSeAplicaIva to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdSeAplicaIvaNull() 
			Me(_parent.PdSeAplicaIvaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FactorConver<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."FactorConver"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [FactorConver]() As System.Decimal
			Get 
				If IsFactorConverNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.FactorConverColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.FactorConverColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FactorConver is NULL, False otherwise.
		''' </summary>
		Public Function IsFactorConverNull() As Boolean
			Return IsNull(_parent.FactorConverColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FactorConver to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFactorConverNull() 
			Me(_parent.FactorConverColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaUltimaCompra<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."FechaUltimaCompra"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaUltimaCompra]() As System.DateTime
			Get 
				If IsFechaUltimaCompraNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaUltimaCompraColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaUltimaCompraColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaUltimaCompra is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaUltimaCompraNull() As Boolean
			Return IsNull(_parent.FechaUltimaCompraColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaUltimaCompra to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaUltimaCompraNull() 
			Me(_parent.FechaUltimaCompraColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CantidadUltimaCompra<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."CantidadUltimaCompra"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [CantidadUltimaCompra]() As System.Decimal
			Get 
				If IsCantidadUltimaCompraNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CantidadUltimaCompraColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CantidadUltimaCompraColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CantidadUltimaCompra is NULL, False otherwise.
		''' </summary>
		Public Function IsCantidadUltimaCompraNull() As Boolean
			Return IsNull(_parent.CantidadUltimaCompraColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CantidadUltimaCompra to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantidadUltimaCompraNull() 
			Me(_parent.CantidadUltimaCompraColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field ImporteUltimaCompra<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."ImporteUltimaCompra"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [ImporteUltimaCompra]() As System.Decimal
			Get 
				If IsImporteUltimaCompraNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.ImporteUltimaCompraColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.ImporteUltimaCompraColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field ImporteUltimaCompra is NULL, False otherwise.
		''' </summary>
		Public Function IsImporteUltimaCompraNull() As Boolean
			Return IsNull(_parent.ImporteUltimaCompraColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ImporteUltimaCompra to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetImporteUltimaCompraNull() 
			Me(_parent.ImporteUltimaCompraColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field UltimoCosto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."UltimoCosto"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [UltimoCosto]() As System.Decimal
			Get 
				If IsUltimoCostoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.UltimoCostoColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.UltimoCostoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field UltimoCosto is NULL, False otherwise.
		''' </summary>
		Public Function IsUltimoCostoNull() As Boolean
			Return IsNull(_parent.UltimoCostoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field UltimoCosto to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetUltimoCostoNull() 
			Me(_parent.UltimoCostoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field ArtPuntoVenta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."ArtPuntoVenta"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [ArtPuntoVenta]() As System.Boolean
			Get 
				If IsArtPuntoVentaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.ArtPuntoVentaColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.ArtPuntoVentaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field ArtPuntoVenta is NULL, False otherwise.
		''' </summary>
		Public Function IsArtPuntoVentaNull() As Boolean
			Return IsNull(_parent.ArtPuntoVentaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ArtPuntoVenta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetArtPuntoVentaNull() 
			Me(_parent.ArtPuntoVentaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field ArtMeat<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."ArtMeat"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [ArtMeat]() As System.Boolean
			Get 
				If IsArtMeatNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.ArtMeatColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.ArtMeatColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field ArtMeat is NULL, False otherwise.
		''' </summary>
		Public Function IsArtMeatNull() As Boolean
			Return IsNull(_parent.ArtMeatColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ArtMeat to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetArtMeatNull() 
			Me(_parent.ArtMeatColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CodigoBarra<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."CodigoBarra"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 50
		''' </remarks>
		Public Property [CodigoBarra]() As System.String
			Get 
				If IsCodigoBarraNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.CodigoBarraColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.CodigoBarraColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CodigoBarra is NULL, False otherwise.
		''' </summary>
		Public Function IsCodigoBarraNull() As Boolean
			Return IsNull(_parent.CodigoBarraColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CodigoBarra to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCodigoBarraNull() 
			Me(_parent.CodigoBarraColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PorcIeps<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PorcIEPS"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [PorcIeps]() As System.Decimal
			Get 
				If IsPorcIepsNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.PorcIepsColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.PorcIepsColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PorcIeps is NULL, False otherwise.
		''' </summary>
		Public Function IsPorcIepsNull() As Boolean
			Return IsNull(_parent.PorcIepsColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PorcIeps to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPorcIepsNull() 
			Me(_parent.PorcIepsColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PdEsKit<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwProductosGenerales"."PdEsKit"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [PdEsKit]() As System.Boolean
			Get 
				If IsPdEsKitNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.PdEsKitColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.PdEsKitColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PdEsKit is NULL, False otherwise.
		''' </summary>
		Public Function IsPdEsKitNull() As Boolean
			Return IsNull(_parent.PdEsKitColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PdEsKit to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPdEsKitNull() 
			Me(_parent.PdEsKitColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
