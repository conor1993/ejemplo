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
	''' Typed datatable for the view 'VwReporteExistenciaSubProductos'.<br/><br/>
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
	Public Class VwReporteExistenciaSubProductosTypedView 
#Else
	Public Class VwReporteExistenciaSubProductosTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnFolioSacrificio As DataColumn
		Private _columnIdProducto As DataColumn
		Private _columnPiezas As DataColumn
		Private _columnKilos As DataColumn
		Private _columnKilosSalida As DataColumn
		Private _columnPiezasSalida As DataColumn
		Private _columnNombre As DataColumn
		Private _columnDescripcion As DataColumn
		Private _columnIdCodCliente As DataColumn
		Private _columnExistenciaPiezas As DataColumn
		Private _columnExistenciaKilos As DataColumn
		Private _columnFechaSacrificio As DataColumn
		Private _columnNomDecomiso As DataColumn
		Private _columnDecomiso As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 14
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
			MyBase.New("VwReporteExistenciaSubProductos")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwReporteExistenciaSubProductosTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwReporteExistenciaSubProductosTypedView)
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
			Return New VwReporteExistenciaSubProductosRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnFolioSacrificio = New DataColumn("FolioSacrificio", GetType(System.String), Nothing, MappingType.Element)
			_columnFolioSacrificio.ReadOnly = True
			_columnFolioSacrificio.Caption = "FolioSacrificio"
			Me.Columns.Add(_columnFolioSacrificio)

			_columnIdProducto = New DataColumn("IdProducto", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdProducto.ReadOnly = True
			_columnIdProducto.Caption = "IdProducto"
			Me.Columns.Add(_columnIdProducto)

			_columnPiezas = New DataColumn("Piezas", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPiezas.ReadOnly = True
			_columnPiezas.Caption = "Piezas"
			Me.Columns.Add(_columnPiezas)

			_columnKilos = New DataColumn("Kilos", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnKilos.ReadOnly = True
			_columnKilos.Caption = "Kilos"
			Me.Columns.Add(_columnKilos)

			_columnKilosSalida = New DataColumn("KilosSalida", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnKilosSalida.ReadOnly = True
			_columnKilosSalida.Caption = "KilosSalida"
			Me.Columns.Add(_columnKilosSalida)

			_columnPiezasSalida = New DataColumn("PiezasSalida", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPiezasSalida.ReadOnly = True
			_columnPiezasSalida.Caption = "PiezasSalida"
			Me.Columns.Add(_columnPiezasSalida)

			_columnNombre = New DataColumn("Nombre", GetType(System.String), Nothing, MappingType.Element)
			_columnNombre.ReadOnly = True
			_columnNombre.Caption = "Nombre"
			Me.Columns.Add(_columnNombre)

			_columnDescripcion = New DataColumn("Descripcion", GetType(System.String), Nothing, MappingType.Element)
			_columnDescripcion.ReadOnly = True
			_columnDescripcion.Caption = "Descripcion"
			Me.Columns.Add(_columnDescripcion)

			_columnIdCodCliente = New DataColumn("IdCodCliente", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdCodCliente.ReadOnly = True
			_columnIdCodCliente.Caption = "IdCodCliente"
			Me.Columns.Add(_columnIdCodCliente)

			_columnExistenciaPiezas = New DataColumn("ExistenciaPiezas", GetType(System.Int32), Nothing, MappingType.Element)
			_columnExistenciaPiezas.ReadOnly = True
			_columnExistenciaPiezas.Caption = "ExistenciaPiezas"
			Me.Columns.Add(_columnExistenciaPiezas)

			_columnExistenciaKilos = New DataColumn("ExistenciaKilos", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnExistenciaKilos.ReadOnly = True
			_columnExistenciaKilos.Caption = "ExistenciaKilos"
			Me.Columns.Add(_columnExistenciaKilos)

			_columnFechaSacrificio = New DataColumn("FechaSacrificio", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaSacrificio.ReadOnly = True
			_columnFechaSacrificio.Caption = "FechaSacrificio"
			Me.Columns.Add(_columnFechaSacrificio)

			_columnNomDecomiso = New DataColumn("NomDecomiso", GetType(System.String), Nothing, MappingType.Element)
			_columnNomDecomiso.ReadOnly = True
			_columnNomDecomiso.Caption = "NomDecomiso"
			Me.Columns.Add(_columnNomDecomiso)

			_columnDecomiso = New DataColumn("Decomiso", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnDecomiso.ReadOnly = True
			_columnDecomiso.Caption = "Decomiso"
			Me.Columns.Add(_columnDecomiso)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnFolioSacrificio = Me.Columns("FolioSacrificio")
			_columnIdProducto = Me.Columns("IdProducto")
			_columnPiezas = Me.Columns("Piezas")
			_columnKilos = Me.Columns("Kilos")
			_columnKilosSalida = Me.Columns("KilosSalida")
			_columnPiezasSalida = Me.Columns("PiezasSalida")
			_columnNombre = Me.Columns("Nombre")
			_columnDescripcion = Me.Columns("Descripcion")
			_columnIdCodCliente = Me.Columns("IdCodCliente")
			_columnExistenciaPiezas = Me.Columns("ExistenciaPiezas")
			_columnExistenciaKilos = Me.Columns("ExistenciaKilos")
			_columnFechaSacrificio = Me.Columns("FechaSacrificio")
			_columnNomDecomiso = Me.Columns("NomDecomiso")
			_columnDecomiso = Me.Columns("Decomiso")
			
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

			_fieldsCustomProperties.Add("FolioSacrificio", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdProducto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Piezas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Kilos", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("KilosSalida", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PiezasSalida", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Nombre", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdCodCliente", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ExistenciaPiezas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ExistenciaKilos", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaSacrificio", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("NomDecomiso", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Decomiso", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwReporteExistenciaSubProductosRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwReporteExistenciaSubProductosTypedView = CType(MyBase.Clone(), VwReporteExistenciaSubProductosTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwReporteExistenciaSubProductosTypedView()
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
				Return VwReporteExistenciaSubProductosTypedView.CustomProperties
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
				Return VwReporteExistenciaSubProductosTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwReporteExistenciaSubProductosRow
			Get 
				Return CType(Me.Rows(index), VwReporteExistenciaSubProductosRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FolioSacrificio
		''' </summary>
		ReadOnly Friend Property FolioSacrificioColumn As DataColumn
			Get 
				Return _columnFolioSacrificio 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdProducto
		''' </summary>
		ReadOnly Friend Property IdProductoColumn As DataColumn
			Get 
				Return _columnIdProducto 
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
		''' Returns the column Object belonging to the TypedView field KilosSalida
		''' </summary>
		ReadOnly Friend Property KilosSalidaColumn As DataColumn
			Get 
				Return _columnKilosSalida 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PiezasSalida
		''' </summary>
		ReadOnly Friend Property PiezasSalidaColumn As DataColumn
			Get 
				Return _columnPiezasSalida 
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
		''' Returns the column Object belonging to the TypedView field Descripcion
		''' </summary>
		ReadOnly Friend Property DescripcionColumn As DataColumn
			Get 
				Return _columnDescripcion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdCodCliente
		''' </summary>
		ReadOnly Friend Property IdCodClienteColumn As DataColumn
			Get 
				Return _columnIdCodCliente 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field ExistenciaPiezas
		''' </summary>
		ReadOnly Friend Property ExistenciaPiezasColumn As DataColumn
			Get 
				Return _columnExistenciaPiezas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field ExistenciaKilos
		''' </summary>
		ReadOnly Friend Property ExistenciaKilosColumn As DataColumn
			Get 
				Return _columnExistenciaKilos 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FechaSacrificio
		''' </summary>
		ReadOnly Friend Property FechaSacrificioColumn As DataColumn
			Get 
				Return _columnFechaSacrificio 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field NomDecomiso
		''' </summary>
		ReadOnly Friend Property NomDecomisoColumn As DataColumn
			Get 
				Return _columnNomDecomiso 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Decomiso
		''' </summary>
		ReadOnly Friend Property DecomisoColumn As DataColumn
			Get 
				Return _columnDecomiso 
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
	''' Typed datarow for the typed datatable VwReporteExistenciaSubProductos
	''' </summary>
	Public Class VwReporteExistenciaSubProductosRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwReporteExistenciaSubProductosTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwReporteExistenciaSubProductosTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field FolioSacrificio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteExistenciaSubProductos"."FolioSacrificio"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 11
		''' </remarks>
		Public Property [FolioSacrificio]() As System.String
			Get 
				If IsFolioSacrificioNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FolioSacrificioColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FolioSacrificioColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FolioSacrificio is NULL, False otherwise.
		''' </summary>
		Public Function IsFolioSacrificioNull() As Boolean
			Return IsNull(_parent.FolioSacrificioColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FolioSacrificio to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolioSacrificioNull() 
			Me(_parent.FolioSacrificioColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdProducto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteExistenciaSubProductos"."IdProducto"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdProducto]() As System.Int32
			Get 
				If IsIdProductoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdProductoColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdProductoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdProducto is NULL, False otherwise.
		''' </summary>
		Public Function IsIdProductoNull() As Boolean
			Return IsNull(_parent.IdProductoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdProducto to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdProductoNull() 
			Me(_parent.IdProductoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Piezas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteExistenciaSubProductos"."Piezas"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [Piezas]() As System.Int32
			Get 
				If IsPiezasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PiezasColumn), System.Int32)
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
		''' Mapped on view field: "VwReporteExistenciaSubProductos"."Kilos"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
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
		''' Gets / sets the value of the TypedView field KilosSalida<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteExistenciaSubProductos"."KilosSalida"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [KilosSalida]() As System.Decimal
			Get 
				If IsKilosSalidaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.KilosSalidaColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.KilosSalidaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field KilosSalida is NULL, False otherwise.
		''' </summary>
		Public Function IsKilosSalidaNull() As Boolean
			Return IsNull(_parent.KilosSalidaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field KilosSalida to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetKilosSalidaNull() 
			Me(_parent.KilosSalidaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PiezasSalida<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteExistenciaSubProductos"."PiezasSalida"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PiezasSalida]() As System.Int32
			Get 
				If IsPiezasSalidaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PiezasSalidaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PiezasSalidaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PiezasSalida is NULL, False otherwise.
		''' </summary>
		Public Function IsPiezasSalidaNull() As Boolean
			Return IsNull(_parent.PiezasSalidaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PiezasSalida to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPiezasSalidaNull() 
			Me(_parent.PiezasSalidaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Nombre<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteExistenciaSubProductos"."Nombre"<br/>
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
		''' Gets / sets the value of the TypedView field Descripcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteExistenciaSubProductos"."Descripcion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
		Public Property [Descripcion]() As System.String
			Get 
				If IsDescripcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.DescripcionColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.DescripcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Descripcion is NULL, False otherwise.
		''' </summary>
		Public Function IsDescripcionNull() As Boolean
			Return IsNull(_parent.DescripcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Descripcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetDescripcionNull() 
			Me(_parent.DescripcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdCodCliente<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteExistenciaSubProductos"."IdCodCliente"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdCodCliente]() As System.Int32
			Get 
				If IsIdCodClienteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdCodClienteColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdCodClienteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdCodCliente is NULL, False otherwise.
		''' </summary>
		Public Function IsIdCodClienteNull() As Boolean
			Return IsNull(_parent.IdCodClienteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdCodCliente to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdCodClienteNull() 
			Me(_parent.IdCodClienteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field ExistenciaPiezas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteExistenciaSubProductos"."ExistenciaPiezas"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [ExistenciaPiezas]() As System.Int32
			Get 
				If IsExistenciaPiezasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.ExistenciaPiezasColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.ExistenciaPiezasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field ExistenciaPiezas is NULL, False otherwise.
		''' </summary>
		Public Function IsExistenciaPiezasNull() As Boolean
			Return IsNull(_parent.ExistenciaPiezasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ExistenciaPiezas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetExistenciaPiezasNull() 
			Me(_parent.ExistenciaPiezasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field ExistenciaKilos<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteExistenciaSubProductos"."ExistenciaKilos"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [ExistenciaKilos]() As System.Decimal
			Get 
				If IsExistenciaKilosNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.ExistenciaKilosColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.ExistenciaKilosColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field ExistenciaKilos is NULL, False otherwise.
		''' </summary>
		Public Function IsExistenciaKilosNull() As Boolean
			Return IsNull(_parent.ExistenciaKilosColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ExistenciaKilos to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetExistenciaKilosNull() 
			Me(_parent.ExistenciaKilosColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaSacrificio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteExistenciaSubProductos"."FechaSacrificio"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaSacrificio]() As System.DateTime
			Get 
				If IsFechaSacrificioNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaSacrificioColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaSacrificioColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaSacrificio is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaSacrificioNull() As Boolean
			Return IsNull(_parent.FechaSacrificioColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaSacrificio to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaSacrificioNull() 
			Me(_parent.FechaSacrificioColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field NomDecomiso<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteExistenciaSubProductos"."NomDecomiso"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 80
		''' </remarks>
		Public Property [NomDecomiso]() As System.String
			Get 
				If IsNomDecomisoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.NomDecomisoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.NomDecomisoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field NomDecomiso is NULL, False otherwise.
		''' </summary>
		Public Function IsNomDecomisoNull() As Boolean
			Return IsNull(_parent.NomDecomisoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field NomDecomiso to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetNomDecomisoNull() 
			Me(_parent.NomDecomisoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Decomiso<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwReporteExistenciaSubProductos"."Decomiso"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [Decomiso]() As System.Boolean
			Get 
				If IsDecomisoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.DecomisoColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.DecomisoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Decomiso is NULL, False otherwise.
		''' </summary>
		Public Function IsDecomisoNull() As Boolean
			Return IsNull(_parent.DecomisoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Decomiso to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetDecomisoNull() 
			Me(_parent.DecomisoColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
