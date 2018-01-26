' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 25 de enero de 2018 11:40:33
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
	''' Typed datatable for the view 'VwConsultaFacturas'.<br/><br/>
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
	Public Class VwConsultaFacturasTypedView 
#Else
	Public Class VwConsultaFacturasTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnNoFactura As DataColumn
		Private _columnIdCliente As DataColumn
		Private _columnNombre As DataColumn
		Private _columnFechaFactura As DataColumn
		Private _columnFechaCaptura As DataColumn
		Private _columnFechaVencimiento As DataColumn
		Private _columnContado As DataColumn
		Private _columnCredito As DataColumn
		Private _columnSubtotal As DataColumn
		Private _columnIva As DataColumn
		Private _columnTotal As DataColumn
		Private _columnEstatus As DataColumn
		Private _columnEstatusCad As DataColumn
		Private _columnObservaciones As DataColumn
		Private _columnRfc As DataColumn
		Private _columnIdFolioEmbarque As DataColumn
		Private _columnIdPoliza As DataColumn
		Private _columnDomicilio As DataColumn
		Private _columnIdClienteCargo As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 19
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
			MyBase.New("VwConsultaFacturas")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwConsultaFacturasTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwConsultaFacturasTypedView)
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
			Return New VwConsultaFacturasRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnNoFactura = New DataColumn("NoFactura", GetType(System.String), Nothing, MappingType.Element)
			_columnNoFactura.ReadOnly = True
			_columnNoFactura.Caption = "NoFactura"
			Me.Columns.Add(_columnNoFactura)

			_columnIdCliente = New DataColumn("IdCliente", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdCliente.ReadOnly = True
			_columnIdCliente.Caption = "IdCliente"
			Me.Columns.Add(_columnIdCliente)

			_columnNombre = New DataColumn("Nombre", GetType(System.String), Nothing, MappingType.Element)
			_columnNombre.ReadOnly = True
			_columnNombre.Caption = "Nombre"
			Me.Columns.Add(_columnNombre)

			_columnFechaFactura = New DataColumn("FechaFactura", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaFactura.ReadOnly = True
			_columnFechaFactura.Caption = "FechaFactura"
			Me.Columns.Add(_columnFechaFactura)

			_columnFechaCaptura = New DataColumn("FechaCaptura", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaCaptura.ReadOnly = True
			_columnFechaCaptura.Caption = "FechaCaptura"
			Me.Columns.Add(_columnFechaCaptura)

			_columnFechaVencimiento = New DataColumn("FechaVencimiento", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaVencimiento.ReadOnly = True
			_columnFechaVencimiento.Caption = "FechaVencimiento"
			Me.Columns.Add(_columnFechaVencimiento)

			_columnContado = New DataColumn("Contado", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnContado.ReadOnly = True
			_columnContado.Caption = "Contado"
			Me.Columns.Add(_columnContado)

			_columnCredito = New DataColumn("Credito", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnCredito.ReadOnly = True
			_columnCredito.Caption = "Credito"
			Me.Columns.Add(_columnCredito)

			_columnSubtotal = New DataColumn("Subtotal", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnSubtotal.ReadOnly = True
			_columnSubtotal.Caption = "Subtotal"
			Me.Columns.Add(_columnSubtotal)

			_columnIva = New DataColumn("Iva", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnIva.ReadOnly = True
			_columnIva.Caption = "Iva"
			Me.Columns.Add(_columnIva)

			_columnTotal = New DataColumn("Total", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnTotal.ReadOnly = True
			_columnTotal.Caption = "Total"
			Me.Columns.Add(_columnTotal)

			_columnEstatus = New DataColumn("Estatus", GetType(System.String), Nothing, MappingType.Element)
			_columnEstatus.ReadOnly = True
			_columnEstatus.Caption = "Estatus"
			Me.Columns.Add(_columnEstatus)

			_columnEstatusCad = New DataColumn("EstatusCad", GetType(System.String), Nothing, MappingType.Element)
			_columnEstatusCad.ReadOnly = True
			_columnEstatusCad.Caption = "EstatusCad"
			Me.Columns.Add(_columnEstatusCad)

			_columnObservaciones = New DataColumn("Observaciones", GetType(System.String), Nothing, MappingType.Element)
			_columnObservaciones.ReadOnly = True
			_columnObservaciones.Caption = "Observaciones"
			Me.Columns.Add(_columnObservaciones)

			_columnRfc = New DataColumn("Rfc", GetType(System.String), Nothing, MappingType.Element)
			_columnRfc.ReadOnly = True
			_columnRfc.Caption = "Rfc"
			Me.Columns.Add(_columnRfc)

			_columnIdFolioEmbarque = New DataColumn("IdFolioEmbarque", GetType(System.String), Nothing, MappingType.Element)
			_columnIdFolioEmbarque.ReadOnly = True
			_columnIdFolioEmbarque.Caption = "IdFolioEmbarque"
			Me.Columns.Add(_columnIdFolioEmbarque)

			_columnIdPoliza = New DataColumn("IdPoliza", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdPoliza.ReadOnly = True
			_columnIdPoliza.Caption = "IdPoliza"
			Me.Columns.Add(_columnIdPoliza)

			_columnDomicilio = New DataColumn("Domicilio", GetType(System.String), Nothing, MappingType.Element)
			_columnDomicilio.ReadOnly = True
			_columnDomicilio.Caption = "Domicilio"
			Me.Columns.Add(_columnDomicilio)

			_columnIdClienteCargo = New DataColumn("IdClienteCargo", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdClienteCargo.ReadOnly = True
			_columnIdClienteCargo.Caption = "IdClienteCargo"
			Me.Columns.Add(_columnIdClienteCargo)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnNoFactura = Me.Columns("NoFactura")
			_columnIdCliente = Me.Columns("IdCliente")
			_columnNombre = Me.Columns("Nombre")
			_columnFechaFactura = Me.Columns("FechaFactura")
			_columnFechaCaptura = Me.Columns("FechaCaptura")
			_columnFechaVencimiento = Me.Columns("FechaVencimiento")
			_columnContado = Me.Columns("Contado")
			_columnCredito = Me.Columns("Credito")
			_columnSubtotal = Me.Columns("Subtotal")
			_columnIva = Me.Columns("Iva")
			_columnTotal = Me.Columns("Total")
			_columnEstatus = Me.Columns("Estatus")
			_columnEstatusCad = Me.Columns("EstatusCad")
			_columnObservaciones = Me.Columns("Observaciones")
			_columnRfc = Me.Columns("Rfc")
			_columnIdFolioEmbarque = Me.Columns("IdFolioEmbarque")
			_columnIdPoliza = Me.Columns("IdPoliza")
			_columnDomicilio = Me.Columns("Domicilio")
			_columnIdClienteCargo = Me.Columns("IdClienteCargo")
			
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

			_fieldsCustomProperties.Add("NoFactura", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdCliente", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Nombre", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaFactura", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaVencimiento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Contado", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Credito", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Subtotal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Iva", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Total", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("EstatusCad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Rfc", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdFolioEmbarque", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdPoliza", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Domicilio", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdClienteCargo", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwConsultaFacturasRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwConsultaFacturasTypedView = CType(MyBase.Clone(), VwConsultaFacturasTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwConsultaFacturasTypedView()
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
				Return VwConsultaFacturasTypedView.CustomProperties
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
				Return VwConsultaFacturasTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwConsultaFacturasRow
			Get 
				Return CType(Me.Rows(index), VwConsultaFacturasRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field NoFactura
		''' </summary>
		ReadOnly Friend Property NoFacturaColumn As DataColumn
			Get 
				Return _columnNoFactura 
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
		''' Returns the column Object belonging to the TypedView field FechaFactura
		''' </summary>
		ReadOnly Friend Property FechaFacturaColumn As DataColumn
			Get 
				Return _columnFechaFactura 
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
		''' Returns the column Object belonging to the TypedView field FechaVencimiento
		''' </summary>
		ReadOnly Friend Property FechaVencimientoColumn As DataColumn
			Get 
				Return _columnFechaVencimiento 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Contado
		''' </summary>
		ReadOnly Friend Property ContadoColumn As DataColumn
			Get 
				Return _columnContado 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Credito
		''' </summary>
		ReadOnly Friend Property CreditoColumn As DataColumn
			Get 
				Return _columnCredito 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Subtotal
		''' </summary>
		ReadOnly Friend Property SubtotalColumn As DataColumn
			Get 
				Return _columnSubtotal 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Iva
		''' </summary>
		ReadOnly Friend Property IvaColumn As DataColumn
			Get 
				Return _columnIva 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Total
		''' </summary>
		ReadOnly Friend Property TotalColumn As DataColumn
			Get 
				Return _columnTotal 
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
		''' Returns the column Object belonging to the TypedView field EstatusCad
		''' </summary>
		ReadOnly Friend Property EstatusCadColumn As DataColumn
			Get 
				Return _columnEstatusCad 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Observaciones
		''' </summary>
		ReadOnly Friend Property ObservacionesColumn As DataColumn
			Get 
				Return _columnObservaciones 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Rfc
		''' </summary>
		ReadOnly Friend Property RfcColumn As DataColumn
			Get 
				Return _columnRfc 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdFolioEmbarque
		''' </summary>
		ReadOnly Friend Property IdFolioEmbarqueColumn As DataColumn
			Get 
				Return _columnIdFolioEmbarque 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdPoliza
		''' </summary>
		ReadOnly Friend Property IdPolizaColumn As DataColumn
			Get 
				Return _columnIdPoliza 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Domicilio
		''' </summary>
		ReadOnly Friend Property DomicilioColumn As DataColumn
			Get 
				Return _columnDomicilio 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdClienteCargo
		''' </summary>
		ReadOnly Friend Property IdClienteCargoColumn As DataColumn
			Get 
				Return _columnIdClienteCargo 
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
	''' Typed datarow for the typed datatable VwConsultaFacturas
	''' </summary>
	Public Class VwConsultaFacturasRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwConsultaFacturasTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwConsultaFacturasTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field NoFactura<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwConsultaFacturas"."NoFactura"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 20
		''' </remarks>
		Public Property [NoFactura]() As System.String
			Get 
				If IsNoFacturaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.NoFacturaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.NoFacturaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field NoFactura is NULL, False otherwise.
		''' </summary>
		Public Function IsNoFacturaNull() As Boolean
			Return IsNull(_parent.NoFacturaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field NoFactura to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetNoFacturaNull() 
			Me(_parent.NoFacturaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdCliente<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwConsultaFacturas"."IdCliente"<br/>
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
		''' Mapped on view field: "VwConsultaFacturas"."Nombre"<br/>
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
		''' Gets / sets the value of the TypedView field FechaFactura<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwConsultaFacturas"."FechaFactura"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaFactura]() As System.DateTime
			Get 
				If IsFechaFacturaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaFacturaColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaFacturaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaFactura is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaFacturaNull() As Boolean
			Return IsNull(_parent.FechaFacturaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaFactura to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaFacturaNull() 
			Me(_parent.FechaFacturaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaCaptura<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwConsultaFacturas"."FechaCaptura"<br/>
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
		''' Gets / sets the value of the TypedView field FechaVencimiento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwConsultaFacturas"."FechaVencimiento"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaVencimiento]() As System.DateTime
			Get 
				If IsFechaVencimientoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaVencimientoColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaVencimientoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaVencimiento is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaVencimientoNull() As Boolean
			Return IsNull(_parent.FechaVencimientoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaVencimiento to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaVencimientoNull() 
			Me(_parent.FechaVencimientoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Contado<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwConsultaFacturas"."Contado"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [Contado]() As System.Boolean
			Get 
				If IsContadoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.ContadoColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.ContadoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Contado is NULL, False otherwise.
		''' </summary>
		Public Function IsContadoNull() As Boolean
			Return IsNull(_parent.ContadoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Contado to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetContadoNull() 
			Me(_parent.ContadoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Credito<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwConsultaFacturas"."Credito"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [Credito]() As System.Boolean
			Get 
				If IsCreditoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.CreditoColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.CreditoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Credito is NULL, False otherwise.
		''' </summary>
		Public Function IsCreditoNull() As Boolean
			Return IsNull(_parent.CreditoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Credito to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCreditoNull() 
			Me(_parent.CreditoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Subtotal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwConsultaFacturas"."Subtotal"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [Subtotal]() As System.Decimal
			Get 
				If IsSubtotalNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.SubtotalColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.SubtotalColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Subtotal is NULL, False otherwise.
		''' </summary>
		Public Function IsSubtotalNull() As Boolean
			Return IsNull(_parent.SubtotalColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Subtotal to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSubtotalNull() 
			Me(_parent.SubtotalColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Iva<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwConsultaFacturas"."IVA"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [Iva]() As System.Decimal
			Get 
				If IsIvaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.IvaColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.IvaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Iva is NULL, False otherwise.
		''' </summary>
		Public Function IsIvaNull() As Boolean
			Return IsNull(_parent.IvaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Iva to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIvaNull() 
			Me(_parent.IvaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Total<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwConsultaFacturas"."Total"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [Total]() As System.Decimal
			Get 
				If IsTotalNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.TotalColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.TotalColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Total is NULL, False otherwise.
		''' </summary>
		Public Function IsTotalNull() As Boolean
			Return IsNull(_parent.TotalColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Total to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTotalNull() 
			Me(_parent.TotalColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Estatus<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwConsultaFacturas"."Estatus"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 1
		''' </remarks>
		Public Property [Estatus]() As System.String
			Get 
				If IsEstatusNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.EstatusColumn), System.String)
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
		''' Gets / sets the value of the TypedView field EstatusCad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwConsultaFacturas"."EstatusCad"<br/>
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

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Observaciones<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwConsultaFacturas"."Observaciones"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 500
		''' </remarks>
		Public Property [Observaciones]() As System.String
			Get 
				If IsObservacionesNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.ObservacionesColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.ObservacionesColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Observaciones is NULL, False otherwise.
		''' </summary>
		Public Function IsObservacionesNull() As Boolean
			Return IsNull(_parent.ObservacionesColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Observaciones to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetObservacionesNull() 
			Me(_parent.ObservacionesColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Rfc<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwConsultaFacturas"."RFC"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 15
		''' </remarks>
		Public Property [Rfc]() As System.String
			Get 
				If IsRfcNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.RfcColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.RfcColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Rfc is NULL, False otherwise.
		''' </summary>
		Public Function IsRfcNull() As Boolean
			Return IsNull(_parent.RfcColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Rfc to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetRfcNull() 
			Me(_parent.RfcColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdFolioEmbarque<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwConsultaFacturas"."IdFolioEmbarque"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 10
		''' </remarks>
		Public Property [IdFolioEmbarque]() As System.String
			Get 
				If IsIdFolioEmbarqueNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.IdFolioEmbarqueColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.IdFolioEmbarqueColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdFolioEmbarque is NULL, False otherwise.
		''' </summary>
		Public Function IsIdFolioEmbarqueNull() As Boolean
			Return IsNull(_parent.IdFolioEmbarqueColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdFolioEmbarque to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdFolioEmbarqueNull() 
			Me(_parent.IdFolioEmbarqueColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdPoliza<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwConsultaFacturas"."IdPoliza"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdPoliza]() As System.Int32
			Get 
				If IsIdPolizaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdPolizaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdPolizaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdPoliza is NULL, False otherwise.
		''' </summary>
		Public Function IsIdPolizaNull() As Boolean
			Return IsNull(_parent.IdPolizaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdPoliza to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdPolizaNull() 
			Me(_parent.IdPolizaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Domicilio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwConsultaFacturas"."Domicilio"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 160
		''' </remarks>
		Public Property [Domicilio]() As System.String
			Get 
				If IsDomicilioNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.DomicilioColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.DomicilioColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Domicilio is NULL, False otherwise.
		''' </summary>
		Public Function IsDomicilioNull() As Boolean
			Return IsNull(_parent.DomicilioColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Domicilio to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetDomicilioNull() 
			Me(_parent.DomicilioColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdClienteCargo<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwConsultaFacturas"."IdClienteCargo"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdClienteCargo]() As System.Int32
			Get 
				If IsIdClienteCargoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdClienteCargoColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdClienteCargoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdClienteCargo is NULL, False otherwise.
		''' </summary>
		Public Function IsIdClienteCargoNull() As Boolean
			Return IsNull(_parent.IdClienteCargoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdClienteCargo to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdClienteCargoNull() 
			Me(_parent.IdClienteCargoColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
