' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 24 de enero de 2018 11:05:24
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
	''' Typed datatable for the view 'VwPagoClientes'.<br/><br/>
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
	Public Class VwPagoClientesTypedView 
#Else
	Public Class VwPagoClientesTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnFolIngreso As DataColumn
		Private _columnCveCliente As DataColumn
		Private _columnFecIngreso As DataColumn
		Private _columnNombre As DataColumn
		Private _columnImporte As DataColumn
		Private _columnEstatus As DataColumn
		Private _columnEstatusCad As DataColumn
		Private _columnFolFactura As DataColumn
		Private _columnCuenta As DataColumn
		Private _columnBncDescripcion As DataColumn
		Private _columnTipoFactura As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 11
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
			MyBase.New("VwPagoClientes")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwPagoClientesTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwPagoClientesTypedView)
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
			Return New VwPagoClientesRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnFolIngreso = New DataColumn("FolIngreso", GetType(System.String), Nothing, MappingType.Element)
			_columnFolIngreso.ReadOnly = True
			_columnFolIngreso.Caption = "FolIngreso"
			Me.Columns.Add(_columnFolIngreso)

			_columnCveCliente = New DataColumn("CveCliente", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCveCliente.ReadOnly = True
			_columnCveCliente.Caption = "CveCliente"
			Me.Columns.Add(_columnCveCliente)

			_columnFecIngreso = New DataColumn("FecIngreso", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFecIngreso.ReadOnly = True
			_columnFecIngreso.Caption = "FecIngreso"
			Me.Columns.Add(_columnFecIngreso)

			_columnNombre = New DataColumn("Nombre", GetType(System.String), Nothing, MappingType.Element)
			_columnNombre.ReadOnly = True
			_columnNombre.Caption = "Nombre"
			Me.Columns.Add(_columnNombre)

			_columnImporte = New DataColumn("Importe", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnImporte.ReadOnly = True
			_columnImporte.Caption = "Importe"
			Me.Columns.Add(_columnImporte)

			_columnEstatus = New DataColumn("Estatus", GetType(System.String), Nothing, MappingType.Element)
			_columnEstatus.ReadOnly = True
			_columnEstatus.Caption = "Estatus"
			Me.Columns.Add(_columnEstatus)

			_columnEstatusCad = New DataColumn("EstatusCad", GetType(System.String), Nothing, MappingType.Element)
			_columnEstatusCad.ReadOnly = True
			_columnEstatusCad.Caption = "EstatusCad"
			Me.Columns.Add(_columnEstatusCad)

			_columnFolFactura = New DataColumn("FolFactura", GetType(System.String), Nothing, MappingType.Element)
			_columnFolFactura.ReadOnly = True
			_columnFolFactura.Caption = "FolFactura"
			Me.Columns.Add(_columnFolFactura)

			_columnCuenta = New DataColumn("Cuenta", GetType(System.String), Nothing, MappingType.Element)
			_columnCuenta.ReadOnly = True
			_columnCuenta.Caption = "Cuenta"
			Me.Columns.Add(_columnCuenta)

			_columnBncDescripcion = New DataColumn("BncDescripcion", GetType(System.String), Nothing, MappingType.Element)
			_columnBncDescripcion.ReadOnly = True
			_columnBncDescripcion.Caption = "BncDescripcion"
			Me.Columns.Add(_columnBncDescripcion)

			_columnTipoFactura = New DataColumn("TipoFactura", GetType(System.String), Nothing, MappingType.Element)
			_columnTipoFactura.ReadOnly = True
			_columnTipoFactura.Caption = "TipoFactura"
			Me.Columns.Add(_columnTipoFactura)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnFolIngreso = Me.Columns("FolIngreso")
			_columnCveCliente = Me.Columns("CveCliente")
			_columnFecIngreso = Me.Columns("FecIngreso")
			_columnNombre = Me.Columns("Nombre")
			_columnImporte = Me.Columns("Importe")
			_columnEstatus = Me.Columns("Estatus")
			_columnEstatusCad = Me.Columns("EstatusCad")
			_columnFolFactura = Me.Columns("FolFactura")
			_columnCuenta = Me.Columns("Cuenta")
			_columnBncDescripcion = Me.Columns("BncDescripcion")
			_columnTipoFactura = Me.Columns("TipoFactura")
			
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

			_fieldsCustomProperties.Add("FolIngreso", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CveCliente", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FecIngreso", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Nombre", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("EstatusCad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FolFactura", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Cuenta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("BncDescripcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TipoFactura", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwPagoClientesRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwPagoClientesTypedView = CType(MyBase.Clone(), VwPagoClientesTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwPagoClientesTypedView()
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
				Return VwPagoClientesTypedView.CustomProperties
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
				Return VwPagoClientesTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwPagoClientesRow
			Get 
				Return CType(Me.Rows(index), VwPagoClientesRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FolIngreso
		''' </summary>
		ReadOnly Friend Property FolIngresoColumn As DataColumn
			Get 
				Return _columnFolIngreso 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CveCliente
		''' </summary>
		ReadOnly Friend Property CveClienteColumn As DataColumn
			Get 
				Return _columnCveCliente 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FecIngreso
		''' </summary>
		ReadOnly Friend Property FecIngresoColumn As DataColumn
			Get 
				Return _columnFecIngreso 
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
		''' Returns the column Object belonging to the TypedView field Importe
		''' </summary>
		ReadOnly Friend Property ImporteColumn As DataColumn
			Get 
				Return _columnImporte 
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
		''' Returns the column Object belonging to the TypedView field FolFactura
		''' </summary>
		ReadOnly Friend Property FolFacturaColumn As DataColumn
			Get 
				Return _columnFolFactura 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Cuenta
		''' </summary>
		ReadOnly Friend Property CuentaColumn As DataColumn
			Get 
				Return _columnCuenta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field BncDescripcion
		''' </summary>
		ReadOnly Friend Property BncDescripcionColumn As DataColumn
			Get 
				Return _columnBncDescripcion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field TipoFactura
		''' </summary>
		ReadOnly Friend Property TipoFacturaColumn As DataColumn
			Get 
				Return _columnTipoFactura 
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
	''' Typed datarow for the typed datatable VwPagoClientes
	''' </summary>
	Public Class VwPagoClientesRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwPagoClientesTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwPagoClientesTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field FolIngreso<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwPagoClientes"."Fol_Ingreso"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 8
		''' </remarks>
		Public Property [FolIngreso]() As System.String
			Get 
				If IsFolIngresoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FolIngresoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FolIngresoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FolIngreso is NULL, False otherwise.
		''' </summary>
		Public Function IsFolIngresoNull() As Boolean
			Return IsNull(_parent.FolIngresoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FolIngreso to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolIngresoNull() 
			Me(_parent.FolIngresoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CveCliente<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwPagoClientes"."Cve_Cliente"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CveCliente]() As System.Int32
			Get 
				If IsCveClienteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CveClienteColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CveClienteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CveCliente is NULL, False otherwise.
		''' </summary>
		Public Function IsCveClienteNull() As Boolean
			Return IsNull(_parent.CveClienteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CveCliente to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCveClienteNull() 
			Me(_parent.CveClienteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FecIngreso<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwPagoClientes"."Fec_Ingreso"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FecIngreso]() As System.DateTime
			Get 
				If IsFecIngresoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FecIngresoColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FecIngresoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FecIngreso is NULL, False otherwise.
		''' </summary>
		Public Function IsFecIngresoNull() As Boolean
			Return IsNull(_parent.FecIngresoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FecIngreso to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFecIngresoNull() 
			Me(_parent.FecIngresoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Nombre<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwPagoClientes"."Nombre"<br/>
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
		''' Gets / sets the value of the TypedView field Importe<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwPagoClientes"."Importe"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [Importe]() As System.Decimal
			Get 
				If IsImporteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.ImporteColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.ImporteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Importe is NULL, False otherwise.
		''' </summary>
		Public Function IsImporteNull() As Boolean
			Return IsNull(_parent.ImporteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Importe to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetImporteNull() 
			Me(_parent.ImporteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Estatus<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwPagoClientes"."Estatus"<br/>
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
		''' Mapped on view field: "VwPagoClientes"."EstatusCad"<br/>
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
		''' Gets / sets the value of the TypedView field FolFactura<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwPagoClientes"."Fol_Factura"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 20
		''' </remarks>
		Public Property [FolFactura]() As System.String
			Get 
				If IsFolFacturaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FolFacturaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FolFacturaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FolFactura is NULL, False otherwise.
		''' </summary>
		Public Function IsFolFacturaNull() As Boolean
			Return IsNull(_parent.FolFacturaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FolFactura to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolFacturaNull() 
			Me(_parent.FolFacturaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Cuenta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwPagoClientes"."Cuenta"<br/>
		''' View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 50
		''' </remarks>
		Public Property [Cuenta]() As System.String
			Get 
				If IsCuentaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.CuentaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.CuentaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Cuenta is NULL, False otherwise.
		''' </summary>
		Public Function IsCuentaNull() As Boolean
			Return IsNull(_parent.CuentaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Cuenta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCuentaNull() 
			Me(_parent.CuentaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field BncDescripcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwPagoClientes"."BncDescripcion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 255
		''' </remarks>
		Public Property [BncDescripcion]() As System.String
			Get 
				If IsBncDescripcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.BncDescripcionColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.BncDescripcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field BncDescripcion is NULL, False otherwise.
		''' </summary>
		Public Function IsBncDescripcionNull() As Boolean
			Return IsNull(_parent.BncDescripcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field BncDescripcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetBncDescripcionNull() 
			Me(_parent.BncDescripcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field TipoFactura<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwPagoClientes"."TipoFactura"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 7
		''' </remarks>
		Public Property [TipoFactura]() As System.String
			Get 
				If IsTipoFacturaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.TipoFacturaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.TipoFacturaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TipoFactura is NULL, False otherwise.
		''' </summary>
		Public Function IsTipoFacturaNull() As Boolean
			Return IsNull(_parent.TipoFacturaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TipoFactura to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTipoFacturaNull() 
			Me(_parent.TipoFacturaColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
