' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 8 de febrero de 2018 08:45:24
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
	''' Typed datatable for the view 'VwBusquedaComparacionMedicamentos'.<br/><br/>
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
	Public Class VwBusquedaComparacionMedicamentosTypedView 
#Else
	Public Class VwBusquedaComparacionMedicamentosTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnFolioAplicacionMedicamento As DataColumn
		Private _columnFechaAplicacionMedicamento As DataColumn
		Private _columnMedicamento As DataColumn
		Private _columnUnidadMedida As DataColumn
		Private _columnLote As DataColumn
		Private _columnCorral As DataColumn
		Private _columnCosProm As DataColumn
		Private _columnCantidad As DataColumn
		Private _columnImporteReal As DataColumn
		Private _columnCantidadTeorica As DataColumn
		Private _columnDifPorc As DataColumn
		Private _columnCabezas As DataColumn
		Private _columnKilos As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 13
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
			MyBase.New("VwBusquedaComparacionMedicamentos")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaComparacionMedicamentosTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaComparacionMedicamentosTypedView)
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
			Return New VwBusquedaComparacionMedicamentosRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnFolioAplicacionMedicamento = New DataColumn("FolioAplicacionMedicamento", GetType(System.String), Nothing, MappingType.Element)
			_columnFolioAplicacionMedicamento.ReadOnly = True
			_columnFolioAplicacionMedicamento.Caption = "FolioAplicacionMedicamento"
			Me.Columns.Add(_columnFolioAplicacionMedicamento)

			_columnFechaAplicacionMedicamento = New DataColumn("FechaAplicacionMedicamento", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaAplicacionMedicamento.ReadOnly = True
			_columnFechaAplicacionMedicamento.Caption = "FechaAplicacionMedicamento"
			Me.Columns.Add(_columnFechaAplicacionMedicamento)

			_columnMedicamento = New DataColumn("Medicamento", GetType(System.String), Nothing, MappingType.Element)
			_columnMedicamento.ReadOnly = True
			_columnMedicamento.Caption = "Medicamento"
			Me.Columns.Add(_columnMedicamento)

			_columnUnidadMedida = New DataColumn("UnidadMedida", GetType(System.String), Nothing, MappingType.Element)
			_columnUnidadMedida.ReadOnly = True
			_columnUnidadMedida.Caption = "UnidadMedida"
			Me.Columns.Add(_columnUnidadMedida)

			_columnLote = New DataColumn("Lote", GetType(System.String), Nothing, MappingType.Element)
			_columnLote.ReadOnly = True
			_columnLote.Caption = "Lote"
			Me.Columns.Add(_columnLote)

			_columnCorral = New DataColumn("Corral", GetType(System.String), Nothing, MappingType.Element)
			_columnCorral.ReadOnly = True
			_columnCorral.Caption = "Corral"
			Me.Columns.Add(_columnCorral)

			_columnCosProm = New DataColumn("CosProm", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCosProm.ReadOnly = True
			_columnCosProm.Caption = "CosProm"
			Me.Columns.Add(_columnCosProm)

			_columnCantidad = New DataColumn("Cantidad", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCantidad.ReadOnly = True
			_columnCantidad.Caption = "Cantidad"
			Me.Columns.Add(_columnCantidad)

			_columnImporteReal = New DataColumn("ImporteReal", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnImporteReal.ReadOnly = True
			_columnImporteReal.Caption = "ImporteReal"
			Me.Columns.Add(_columnImporteReal)

			_columnCantidadTeorica = New DataColumn("CantidadTeorica", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCantidadTeorica.ReadOnly = True
			_columnCantidadTeorica.Caption = "CantidadTeorica"
			Me.Columns.Add(_columnCantidadTeorica)

			_columnDifPorc = New DataColumn("DifPorc", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnDifPorc.ReadOnly = True
			_columnDifPorc.Caption = "DifPorc"
			Me.Columns.Add(_columnDifPorc)

			_columnCabezas = New DataColumn("Cabezas", GetType(System.Int16), Nothing, MappingType.Element)
			_columnCabezas.ReadOnly = True
			_columnCabezas.Caption = "Cabezas"
			Me.Columns.Add(_columnCabezas)

			_columnKilos = New DataColumn("Kilos", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnKilos.ReadOnly = True
			_columnKilos.Caption = "Kilos"
			Me.Columns.Add(_columnKilos)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnFolioAplicacionMedicamento = Me.Columns("FolioAplicacionMedicamento")
			_columnFechaAplicacionMedicamento = Me.Columns("FechaAplicacionMedicamento")
			_columnMedicamento = Me.Columns("Medicamento")
			_columnUnidadMedida = Me.Columns("UnidadMedida")
			_columnLote = Me.Columns("Lote")
			_columnCorral = Me.Columns("Corral")
			_columnCosProm = Me.Columns("CosProm")
			_columnCantidad = Me.Columns("Cantidad")
			_columnImporteReal = Me.Columns("ImporteReal")
			_columnCantidadTeorica = Me.Columns("CantidadTeorica")
			_columnDifPorc = Me.Columns("DifPorc")
			_columnCabezas = Me.Columns("Cabezas")
			_columnKilos = Me.Columns("Kilos")
			
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

			_fieldsCustomProperties.Add("FolioAplicacionMedicamento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaAplicacionMedicamento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Medicamento", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("UnidadMedida", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Lote", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Corral", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CosProm", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Cantidad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ImporteReal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantidadTeorica", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("DifPorc", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Cabezas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Kilos", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwBusquedaComparacionMedicamentosRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwBusquedaComparacionMedicamentosTypedView = CType(MyBase.Clone(), VwBusquedaComparacionMedicamentosTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwBusquedaComparacionMedicamentosTypedView()
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
				Return VwBusquedaComparacionMedicamentosTypedView.CustomProperties
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
				Return VwBusquedaComparacionMedicamentosTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwBusquedaComparacionMedicamentosRow
			Get 
				Return CType(Me.Rows(index), VwBusquedaComparacionMedicamentosRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FolioAplicacionMedicamento
		''' </summary>
		ReadOnly Friend Property FolioAplicacionMedicamentoColumn As DataColumn
			Get 
				Return _columnFolioAplicacionMedicamento 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FechaAplicacionMedicamento
		''' </summary>
		ReadOnly Friend Property FechaAplicacionMedicamentoColumn As DataColumn
			Get 
				Return _columnFechaAplicacionMedicamento 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Medicamento
		''' </summary>
		ReadOnly Friend Property MedicamentoColumn As DataColumn
			Get 
				Return _columnMedicamento 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field UnidadMedida
		''' </summary>
		ReadOnly Friend Property UnidadMedidaColumn As DataColumn
			Get 
				Return _columnUnidadMedida 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Lote
		''' </summary>
		ReadOnly Friend Property LoteColumn As DataColumn
			Get 
				Return _columnLote 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Corral
		''' </summary>
		ReadOnly Friend Property CorralColumn As DataColumn
			Get 
				Return _columnCorral 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CosProm
		''' </summary>
		ReadOnly Friend Property CosPromColumn As DataColumn
			Get 
				Return _columnCosProm 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Cantidad
		''' </summary>
		ReadOnly Friend Property CantidadColumn As DataColumn
			Get 
				Return _columnCantidad 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field ImporteReal
		''' </summary>
		ReadOnly Friend Property ImporteRealColumn As DataColumn
			Get 
				Return _columnImporteReal 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CantidadTeorica
		''' </summary>
		ReadOnly Friend Property CantidadTeoricaColumn As DataColumn
			Get 
				Return _columnCantidadTeorica 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field DifPorc
		''' </summary>
		ReadOnly Friend Property DifPorcColumn As DataColumn
			Get 
				Return _columnDifPorc 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Cabezas
		''' </summary>
		ReadOnly Friend Property CabezasColumn As DataColumn
			Get 
				Return _columnCabezas 
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
	''' Typed datarow for the typed datatable VwBusquedaComparacionMedicamentos
	''' </summary>
	Public Class VwBusquedaComparacionMedicamentosRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwBusquedaComparacionMedicamentosTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwBusquedaComparacionMedicamentosTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field FolioAplicacionMedicamento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaComparacionMedicamentos"."FolioAplicacionMedicamento"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 8
		''' </remarks>
		Public Property [FolioAplicacionMedicamento]() As System.String
			Get 
				If IsFolioAplicacionMedicamentoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FolioAplicacionMedicamentoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FolioAplicacionMedicamentoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FolioAplicacionMedicamento is NULL, False otherwise.
		''' </summary>
		Public Function IsFolioAplicacionMedicamentoNull() As Boolean
			Return IsNull(_parent.FolioAplicacionMedicamentoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FolioAplicacionMedicamento to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolioAplicacionMedicamentoNull() 
			Me(_parent.FolioAplicacionMedicamentoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaAplicacionMedicamento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaComparacionMedicamentos"."FechaAplicacionMedicamento"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaAplicacionMedicamento]() As System.DateTime
			Get 
				If IsFechaAplicacionMedicamentoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaAplicacionMedicamentoColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaAplicacionMedicamentoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaAplicacionMedicamento is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaAplicacionMedicamentoNull() As Boolean
			Return IsNull(_parent.FechaAplicacionMedicamentoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaAplicacionMedicamento to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaAplicacionMedicamentoNull() 
			Me(_parent.FechaAplicacionMedicamentoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Medicamento<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaComparacionMedicamentos"."Medicamento"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 250
		''' </remarks>
		Public Property [Medicamento]() As System.String
			Get 
				If IsMedicamentoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.MedicamentoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.MedicamentoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Medicamento is NULL, False otherwise.
		''' </summary>
		Public Function IsMedicamentoNull() As Boolean
			Return IsNull(_parent.MedicamentoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Medicamento to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetMedicamentoNull() 
			Me(_parent.MedicamentoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field UnidadMedida<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaComparacionMedicamentos"."UnidadMedida"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 3
		''' </remarks>
		Public Property [UnidadMedida]() As System.String
			Get 
				If IsUnidadMedidaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.UnidadMedidaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.UnidadMedidaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field UnidadMedida is NULL, False otherwise.
		''' </summary>
		Public Function IsUnidadMedidaNull() As Boolean
			Return IsNull(_parent.UnidadMedidaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field UnidadMedida to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetUnidadMedidaNull() 
			Me(_parent.UnidadMedidaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Lote<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaComparacionMedicamentos"."Lote"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
		Public Property [Lote]() As System.String
			Get 
				If IsLoteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.LoteColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.LoteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Lote is NULL, False otherwise.
		''' </summary>
		Public Function IsLoteNull() As Boolean
			Return IsNull(_parent.LoteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Lote to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetLoteNull() 
			Me(_parent.LoteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Corral<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaComparacionMedicamentos"."Corral"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
		Public Property [Corral]() As System.String
			Get 
				If IsCorralNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.CorralColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.CorralColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Corral is NULL, False otherwise.
		''' </summary>
		Public Function IsCorralNull() As Boolean
			Return IsNull(_parent.CorralColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Corral to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCorralNull() 
			Me(_parent.CorralColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CosProm<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaComparacionMedicamentos"."CosProm"<br/>
		''' View field characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0
		''' </remarks>
		Public Property [CosProm]() As System.Decimal
			Get 
				If IsCosPromNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CosPromColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CosPromColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CosProm is NULL, False otherwise.
		''' </summary>
		Public Function IsCosPromNull() As Boolean
			Return IsNull(_parent.CosPromColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CosProm to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCosPromNull() 
			Me(_parent.CosPromColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Cantidad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaComparacionMedicamentos"."Cantidad"<br/>
		''' View field characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0
		''' </remarks>
		Public Property [Cantidad]() As System.Decimal
			Get 
				If IsCantidadNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CantidadColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CantidadColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Cantidad is NULL, False otherwise.
		''' </summary>
		Public Function IsCantidadNull() As Boolean
			Return IsNull(_parent.CantidadColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Cantidad to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantidadNull() 
			Me(_parent.CantidadColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field ImporteReal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaComparacionMedicamentos"."ImporteReal"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [ImporteReal]() As System.Decimal
			Get 
				If IsImporteRealNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.ImporteRealColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.ImporteRealColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field ImporteReal is NULL, False otherwise.
		''' </summary>
		Public Function IsImporteRealNull() As Boolean
			Return IsNull(_parent.ImporteRealColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ImporteReal to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetImporteRealNull() 
			Me(_parent.ImporteRealColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CantidadTeorica<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaComparacionMedicamentos"."CantidadTeorica"<br/>
		''' View field characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0
		''' </remarks>
		Public Property [CantidadTeorica]() As System.Decimal
			Get 
				If IsCantidadTeoricaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CantidadTeoricaColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CantidadTeoricaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CantidadTeorica is NULL, False otherwise.
		''' </summary>
		Public Function IsCantidadTeoricaNull() As Boolean
			Return IsNull(_parent.CantidadTeoricaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CantidadTeorica to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantidadTeoricaNull() 
			Me(_parent.CantidadTeoricaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field DifPorc<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaComparacionMedicamentos"."DifPorc"<br/>
		''' View field characteristics (type, precision, scale, length): Decimal, 22, 5, 0
		''' </remarks>
		Public Property [DifPorc]() As System.Decimal
			Get 
				If IsDifPorcNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.DifPorcColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.DifPorcColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field DifPorc is NULL, False otherwise.
		''' </summary>
		Public Function IsDifPorcNull() As Boolean
			Return IsNull(_parent.DifPorcColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field DifPorc to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetDifPorcNull() 
			Me(_parent.DifPorcColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Cabezas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaComparacionMedicamentos"."Cabezas"<br/>
		''' View field characteristics (type, precision, scale, length): SmallInt, 5, 0, 0
		''' </remarks>
		Public Property [Cabezas]() As System.Int16
			Get 
				If IsCabezasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int16)), System.Int16)
				Else
					Return CType(Me(_parent.CabezasColumn), System.Int16)
				End If
			End Get
			Set 
				Me(_parent.CabezasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Cabezas is NULL, False otherwise.
		''' </summary>
		Public Function IsCabezasNull() As Boolean
			Return IsNull(_parent.CabezasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Cabezas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCabezasNull() 
			Me(_parent.CabezasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Kilos<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwBusquedaComparacionMedicamentos"."Kilos"<br/>
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

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
