' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 11 de diciembre de 2017 20:57:35
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
	''' Typed datatable for the view 'VwBusquedaDevoluciones'.<br/><br/>
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
	Public Class VwBusquedaDevolucionesTypedView 
#Else
	Public Class VwBusquedaDevolucionesTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END
			
	
#Region "Class Member Declarations"
		Private _columnFolio As DataColumn
		Private _columnEmbarque As DataColumn
		Private _columnIdCliente As DataColumn
		Private _columnNombre As DataColumn
		Private _columnIdPrecorte As DataColumn
		Private _columnPrecorte As DataColumn
		Private _columnIdCorte As DataColumn
		Private _columnCorte As DataColumn
		Private _columnEnCaja As DataColumn
		Private _columnUtilparaVenta As DataColumn
		Private _columnPiezas As DataColumn
		Private _columnKilos As DataColumn
		Private _columnEstatus As DataColumn
		Private _columnFechaCaptura As DataColumn
		Private _columnFolioMovimientoAlmacen As DataColumn
		Private _columnIdMotivoDevolucion As DataColumn
		Private _columnIdFolioEtiqueta As DataColumn
		Private _columnEstatusCad As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 18
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
			MyBase.New("VwBusquedaDevoluciones")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaDevolucionesTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaDevolucionesTypedView)
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
			Return New VwBusquedaDevolucionesRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnFolio = New DataColumn("Folio", GetType(System.String), Nothing, MappingType.Element)
			_columnFolio.ReadOnly = True
			_columnFolio.Caption = "Folio"
			Me.Columns.Add(_columnFolio)

			_columnEmbarque = New DataColumn("Embarque", GetType(System.String), Nothing, MappingType.Element)
			_columnEmbarque.ReadOnly = True
			_columnEmbarque.Caption = "Embarque"
			Me.Columns.Add(_columnEmbarque)

			_columnIdCliente = New DataColumn("IdCliente", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdCliente.ReadOnly = True
			_columnIdCliente.Caption = "IdCliente"
			Me.Columns.Add(_columnIdCliente)

			_columnNombre = New DataColumn("Nombre", GetType(System.String), Nothing, MappingType.Element)
			_columnNombre.ReadOnly = True
			_columnNombre.Caption = "Nombre"
			Me.Columns.Add(_columnNombre)

			_columnIdPrecorte = New DataColumn("IdPrecorte", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdPrecorte.ReadOnly = True
			_columnIdPrecorte.Caption = "IdPrecorte"
			Me.Columns.Add(_columnIdPrecorte)

			_columnPrecorte = New DataColumn("Precorte", GetType(System.String), Nothing, MappingType.Element)
			_columnPrecorte.ReadOnly = True
			_columnPrecorte.Caption = "Precorte"
			Me.Columns.Add(_columnPrecorte)

			_columnIdCorte = New DataColumn("IdCorte", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdCorte.ReadOnly = True
			_columnIdCorte.Caption = "IdCorte"
			Me.Columns.Add(_columnIdCorte)

			_columnCorte = New DataColumn("Corte", GetType(System.String), Nothing, MappingType.Element)
			_columnCorte.ReadOnly = True
			_columnCorte.Caption = "Corte"
			Me.Columns.Add(_columnCorte)

			_columnEnCaja = New DataColumn("EnCaja", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnEnCaja.ReadOnly = True
			_columnEnCaja.Caption = "EnCaja"
			Me.Columns.Add(_columnEnCaja)

			_columnUtilparaVenta = New DataColumn("UtilparaVenta", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnUtilparaVenta.ReadOnly = True
			_columnUtilparaVenta.Caption = "UtilparaVenta"
			Me.Columns.Add(_columnUtilparaVenta)

			_columnPiezas = New DataColumn("Piezas", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnPiezas.ReadOnly = True
			_columnPiezas.Caption = "Piezas"
			Me.Columns.Add(_columnPiezas)

			_columnKilos = New DataColumn("Kilos", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnKilos.ReadOnly = True
			_columnKilos.Caption = "Kilos"
			Me.Columns.Add(_columnKilos)

			_columnEstatus = New DataColumn("Estatus", GetType(System.Int16), Nothing, MappingType.Element)
			_columnEstatus.ReadOnly = True
			_columnEstatus.Caption = "Estatus"
			Me.Columns.Add(_columnEstatus)

			_columnFechaCaptura = New DataColumn("FechaCaptura", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaCaptura.ReadOnly = True
			_columnFechaCaptura.Caption = "FechaCaptura"
			Me.Columns.Add(_columnFechaCaptura)

			_columnFolioMovimientoAlmacen = New DataColumn("FolioMovimientoAlmacen", GetType(System.String), Nothing, MappingType.Element)
			_columnFolioMovimientoAlmacen.ReadOnly = True
			_columnFolioMovimientoAlmacen.Caption = "FolioMovimientoAlmacen"
			Me.Columns.Add(_columnFolioMovimientoAlmacen)

			_columnIdMotivoDevolucion = New DataColumn("IdMotivoDevolucion", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdMotivoDevolucion.ReadOnly = True
			_columnIdMotivoDevolucion.Caption = "IdMotivoDevolucion"
			Me.Columns.Add(_columnIdMotivoDevolucion)

			_columnIdFolioEtiqueta = New DataColumn("IdFolioEtiqueta", GetType(System.String), Nothing, MappingType.Element)
			_columnIdFolioEtiqueta.ReadOnly = True
			_columnIdFolioEtiqueta.Caption = "IdFolioEtiqueta"
			Me.Columns.Add(_columnIdFolioEtiqueta)

			_columnEstatusCad = New DataColumn("EstatusCad", GetType(System.String), Nothing, MappingType.Element)
			_columnEstatusCad.ReadOnly = True
			_columnEstatusCad.Caption = "EstatusCad"
			Me.Columns.Add(_columnEstatusCad)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
			
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnFolio = Me.Columns("Folio")
			_columnEmbarque = Me.Columns("Embarque")
			_columnIdCliente = Me.Columns("IdCliente")
			_columnNombre = Me.Columns("Nombre")
			_columnIdPrecorte = Me.Columns("IdPrecorte")
			_columnPrecorte = Me.Columns("Precorte")
			_columnIdCorte = Me.Columns("IdCorte")
			_columnCorte = Me.Columns("Corte")
			_columnEnCaja = Me.Columns("EnCaja")
			_columnUtilparaVenta = Me.Columns("UtilparaVenta")
			_columnPiezas = Me.Columns("Piezas")
			_columnKilos = Me.Columns("Kilos")
			_columnEstatus = Me.Columns("Estatus")
			_columnFechaCaptura = Me.Columns("FechaCaptura")
			_columnFolioMovimientoAlmacen = Me.Columns("FolioMovimientoAlmacen")
			_columnIdMotivoDevolucion = Me.Columns("IdMotivoDevolucion")
			_columnIdFolioEtiqueta = Me.Columns("IdFolioEtiqueta")
			_columnEstatusCad = Me.Columns("EstatusCad")
			
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

			_fieldsCustomProperties.Add("Folio", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Embarque", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdCliente", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Nombre", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdPrecorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Precorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdCorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Corte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("EnCaja", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("UtilparaVenta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Piezas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Kilos", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FolioMovimientoAlmacen", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdMotivoDevolucion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdFolioEtiqueta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("EstatusCad", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwBusquedaDevolucionesRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwBusquedaDevolucionesTypedView = CType(MyBase.Clone(), VwBusquedaDevolucionesTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwBusquedaDevolucionesTypedView()
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
				Return VwBusquedaDevolucionesTypedView.CustomProperties
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
				Return VwBusquedaDevolucionesTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwBusquedaDevolucionesRow
			Get 
				Return CType(Me.Rows(index), VwBusquedaDevolucionesRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Folio
		''' </summary>
		ReadOnly Friend Property FolioColumn As DataColumn
			Get 
				Return _columnFolio 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Embarque
		''' </summary>
		ReadOnly Friend Property EmbarqueColumn As DataColumn
			Get 
				Return _columnEmbarque 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdCliente
		''' </summary>
		ReadOnly Friend Property IdClienteColumn As DataColumn
			Get 
				Return _columnIdCliente 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Nombre
		''' </summary>
		ReadOnly Friend Property NombreColumn As DataColumn
			Get 
				Return _columnNombre 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdPrecorte
		''' </summary>
		ReadOnly Friend Property IdPrecorteColumn As DataColumn
			Get 
				Return _columnIdPrecorte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Precorte
		''' </summary>
		ReadOnly Friend Property PrecorteColumn As DataColumn
			Get 
				Return _columnPrecorte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdCorte
		''' </summary>
		ReadOnly Friend Property IdCorteColumn As DataColumn
			Get 
				Return _columnIdCorte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Corte
		''' </summary>
		ReadOnly Friend Property CorteColumn As DataColumn
			Get 
				Return _columnCorte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field EnCaja
		''' </summary>
		ReadOnly Friend Property EnCajaColumn As DataColumn
			Get 
				Return _columnEnCaja 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field UtilparaVenta
		''' </summary>
		ReadOnly Friend Property UtilparaVentaColumn As DataColumn
			Get 
				Return _columnUtilparaVenta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Piezas
		''' </summary>
		ReadOnly Friend Property PiezasColumn As DataColumn
			Get 
				Return _columnPiezas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Kilos
		''' </summary>
		ReadOnly Friend Property KilosColumn As DataColumn
			Get 
				Return _columnKilos 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Estatus
		''' </summary>
		ReadOnly Friend Property EstatusColumn As DataColumn
			Get 
				Return _columnEstatus 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FechaCaptura
		''' </summary>
		ReadOnly Friend Property FechaCapturaColumn As DataColumn
			Get 
				Return _columnFechaCaptura 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FolioMovimientoAlmacen
		''' </summary>
		ReadOnly Friend Property FolioMovimientoAlmacenColumn As DataColumn
			Get 
				Return _columnFolioMovimientoAlmacen 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdMotivoDevolucion
		''' </summary>
		ReadOnly Friend Property IdMotivoDevolucionColumn As DataColumn
			Get 
				Return _columnIdMotivoDevolucion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdFolioEtiqueta
		''' </summary>
		ReadOnly Friend Property IdFolioEtiquetaColumn As DataColumn
			Get 
				Return _columnIdFolioEtiqueta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field EstatusCad
		''' </summary>
		ReadOnly Friend Property EstatusCadColumn As DataColumn
			Get 
				Return _columnEstatusCad 
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
	''' Typed datarow for the typed datatable VwBusquedaDevoluciones
	''' </summary>
	Public Class VwBusquedaDevolucionesRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END
			


#Region "Class Member Declarations"
		Private _parent As VwBusquedaDevolucionesTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwBusquedaDevolucionesTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field Folio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaDevoluciones"."Folio"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 10
		''' </remarks>
		Public Property [Folio]() As System.String
			Get 
				If IsFolioNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FolioColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FolioColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Folio is NULL, False otherwise.
		''' </summary>
		Public Function IsFolioNull() As Boolean
			Return IsNull(_parent.FolioColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Folio to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolioNull() 
			Me(_parent.FolioColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Embarque<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaDevoluciones"."Embarque"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 10
		''' </remarks>
		Public Property [Embarque]() As System.String
			Get 
				If IsEmbarqueNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.EmbarqueColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.EmbarqueColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Embarque is NULL, False otherwise.
		''' </summary>
		Public Function IsEmbarqueNull() As Boolean
			Return IsNull(_parent.EmbarqueColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Embarque to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEmbarqueNull() 
			Me(_parent.EmbarqueColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdCliente<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaDevoluciones"."IdCliente"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdCliente]() As System.Int32
			Get 
				If IsIdClienteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdClienteColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdClienteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdCliente is NULL, False otherwise.
		''' </summary>
		Public Function IsIdClienteNull() As Boolean
			Return IsNull(_parent.IdClienteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdCliente to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdClienteNull() 
			Me(_parent.IdClienteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Nombre<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaDevoluciones"."Nombre"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 120
		''' </remarks>
		Public Property [Nombre]() As System.String
			Get 
				If IsNombreNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.NombreColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.NombreColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Nombre is NULL, False otherwise.
		''' </summary>
		Public Function IsNombreNull() As Boolean
			Return IsNull(_parent.NombreColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Nombre to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetNombreNull() 
			Me(_parent.NombreColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdPrecorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaDevoluciones"."IdPrecorte"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdPrecorte]() As System.Int32
			Get 
				If IsIdPrecorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdPrecorteColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdPrecorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdPrecorte is NULL, False otherwise.
		''' </summary>
		Public Function IsIdPrecorteNull() As Boolean
			Return IsNull(_parent.IdPrecorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdPrecorte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdPrecorteNull() 
			Me(_parent.IdPrecorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Precorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaDevoluciones"."Precorte"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
		Public Property [Precorte]() As System.String
			Get 
				If IsPrecorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PrecorteColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PrecorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Precorte is NULL, False otherwise.
		''' </summary>
		Public Function IsPrecorteNull() As Boolean
			Return IsNull(_parent.PrecorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Precorte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrecorteNull() 
			Me(_parent.PrecorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaDevoluciones"."IdCorte"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdCorte]() As System.Int32
			Get 
				If IsIdCorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdCorteColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdCorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdCorte is NULL, False otherwise.
		''' </summary>
		Public Function IsIdCorteNull() As Boolean
			Return IsNull(_parent.IdCorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdCorte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdCorteNull() 
			Me(_parent.IdCorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Corte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaDevoluciones"."Corte"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
		Public Property [Corte]() As System.String
			Get 
				If IsCorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.CorteColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.CorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Corte is NULL, False otherwise.
		''' </summary>
		Public Function IsCorteNull() As Boolean
			Return IsNull(_parent.CorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Corte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCorteNull() 
			Me(_parent.CorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field EnCaja<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaDevoluciones"."EnCaja"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [EnCaja]() As System.Boolean
			Get 
				If IsEnCajaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.EnCajaColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.EnCajaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field EnCaja is NULL, False otherwise.
		''' </summary>
		Public Function IsEnCajaNull() As Boolean
			Return IsNull(_parent.EnCajaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field EnCaja to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEnCajaNull() 
			Me(_parent.EnCajaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field UtilparaVenta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaDevoluciones"."UtilparaVenta"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [UtilparaVenta]() As System.Boolean
			Get 
				If IsUtilparaVentaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.UtilparaVentaColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.UtilparaVentaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field UtilparaVenta is NULL, False otherwise.
		''' </summary>
		Public Function IsUtilparaVentaNull() As Boolean
			Return IsNull(_parent.UtilparaVentaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field UtilparaVenta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetUtilparaVentaNull() 
			Me(_parent.UtilparaVentaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Piezas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaDevoluciones"."Piezas"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 18, 0, 0
		''' </remarks>
		Public Property [Piezas]() As System.Decimal
			Get 
				If IsPiezasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.PiezasColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.PiezasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Piezas is NULL, False otherwise.
		''' </summary>
		Public Function IsPiezasNull() As Boolean
			Return IsNull(_parent.PiezasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Piezas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPiezasNull() 
			Me(_parent.PiezasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Kilos<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaDevoluciones"."Kilos"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 18, 0, 0
		''' </remarks>
		Public Property [Kilos]() As System.Decimal
			Get 
				If IsKilosNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.KilosColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.KilosColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Kilos is NULL, False otherwise.
		''' </summary>
		Public Function IsKilosNull() As Boolean
			Return IsNull(_parent.KilosColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Kilos to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetKilosNull() 
			Me(_parent.KilosColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Estatus<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaDevoluciones"."Estatus"<br/>
		''' View field characteristics (type, precision, scale, length): SmallInt, 5, 0, 0
		''' </remarks>
		Public Property [Estatus]() As System.Int16
			Get 
				If IsEstatusNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int16)), System.Int16)
				Else
					Return CType(Me(_parent.EstatusColumn), System.Int16)
				End If
			End Get
			Set 
				Me(_parent.EstatusColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Estatus is NULL, False otherwise.
		''' </summary>
		Public Function IsEstatusNull() As Boolean
			Return IsNull(_parent.EstatusColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Estatus to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEstatusNull() 
			Me(_parent.EstatusColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaCaptura<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaDevoluciones"."FechaCaptura"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaCaptura]() As System.DateTime
			Get 
				If IsFechaCapturaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaCapturaColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaCapturaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaCaptura is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaCapturaNull() As Boolean
			Return IsNull(_parent.FechaCapturaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaCaptura to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaCapturaNull() 
			Me(_parent.FechaCapturaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FolioMovimientoAlmacen<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaDevoluciones"."FolioMovimientoAlmacen"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 12
		''' </remarks>
		Public Property [FolioMovimientoAlmacen]() As System.String
			Get 
				If IsFolioMovimientoAlmacenNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FolioMovimientoAlmacenColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FolioMovimientoAlmacenColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FolioMovimientoAlmacen is NULL, False otherwise.
		''' </summary>
		Public Function IsFolioMovimientoAlmacenNull() As Boolean
			Return IsNull(_parent.FolioMovimientoAlmacenColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FolioMovimientoAlmacen to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolioMovimientoAlmacenNull() 
			Me(_parent.FolioMovimientoAlmacenColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdMotivoDevolucion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaDevoluciones"."IdMotivoDevolucion"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdMotivoDevolucion]() As System.Int32
			Get 
				If IsIdMotivoDevolucionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdMotivoDevolucionColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdMotivoDevolucionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdMotivoDevolucion is NULL, False otherwise.
		''' </summary>
		Public Function IsIdMotivoDevolucionNull() As Boolean
			Return IsNull(_parent.IdMotivoDevolucionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdMotivoDevolucion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdMotivoDevolucionNull() 
			Me(_parent.IdMotivoDevolucionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdFolioEtiqueta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaDevoluciones"."IdFolioEtiqueta"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 14
		''' </remarks>
		Public Property [IdFolioEtiqueta]() As System.String
			Get 
				If IsIdFolioEtiquetaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.IdFolioEtiquetaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.IdFolioEtiquetaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdFolioEtiqueta is NULL, False otherwise.
		''' </summary>
		Public Function IsIdFolioEtiquetaNull() As Boolean
			Return IsNull(_parent.IdFolioEtiquetaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdFolioEtiqueta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdFolioEtiquetaNull() 
			Me(_parent.IdFolioEtiquetaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field EstatusCad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaDevoluciones"."EstatusCad"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 9
		''' </remarks>
		Public Property [EstatusCad]() As System.String
			Get 
				If IsEstatusCadNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.EstatusCadColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.EstatusCadColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field EstatusCad is NULL, False otherwise.
		''' </summary>
		Public Function IsEstatusCadNull() As Boolean
			Return IsNull(_parent.EstatusCadColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field EstatusCad to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEstatusCadNull() 
			Me(_parent.EstatusCadColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
	
#End Region

	End Class
End Namespace
