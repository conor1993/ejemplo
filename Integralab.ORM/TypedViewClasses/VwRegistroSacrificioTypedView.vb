' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 23 de abril de 2018 15:22:02
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
	''' Typed datatable for the view 'VwRegistroSacrificio'.<br/><br/>
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
	Public Class VwRegistroSacrificioTypedView 
#Else
	Public Class VwRegistroSacrificioTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnLoteRecepcion As DataColumn
		Private _columnLoteEngorda As DataColumn
		Private _columnFechaRecepcion As DataColumn
		Private _columnIdCliente As DataColumn
		Private _columnKilosRecibidos As DataColumn
		Private _columnCantCabezas As DataColumn
		Private _columnUnidad As DataColumn
		Private _columnConductor As DataColumn
		Private _columnPlacas As DataColumn
		Private _columnSumaCabezasDet As DataColumn
		Private _columnSumaCabezasMuertas As DataColumn
		Private _columnEstatus As DataColumn
		Private _columnKilosPromedio As DataColumn
		
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
			MyBase.New("VwRegistroSacrificio")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwRegistroSacrificioTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwRegistroSacrificioTypedView)
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
			Return New VwRegistroSacrificioRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnLoteRecepcion = New DataColumn("LoteRecepcion", GetType(System.String), Nothing, MappingType.Element)
			_columnLoteRecepcion.ReadOnly = True
			_columnLoteRecepcion.Caption = "LoteRecepcion"
			Me.Columns.Add(_columnLoteRecepcion)

			_columnLoteEngorda = New DataColumn("LoteEngorda", GetType(System.String), Nothing, MappingType.Element)
			_columnLoteEngorda.ReadOnly = True
			_columnLoteEngorda.Caption = "LoteEngorda"
			Me.Columns.Add(_columnLoteEngorda)

			_columnFechaRecepcion = New DataColumn("FechaRecepcion", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaRecepcion.ReadOnly = True
			_columnFechaRecepcion.Caption = "FechaRecepcion"
			Me.Columns.Add(_columnFechaRecepcion)

			_columnIdCliente = New DataColumn("IdCliente", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdCliente.ReadOnly = True
			_columnIdCliente.Caption = "IdCliente"
			Me.Columns.Add(_columnIdCliente)

			_columnKilosRecibidos = New DataColumn("KilosRecibidos", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnKilosRecibidos.ReadOnly = True
			_columnKilosRecibidos.Caption = "KilosRecibidos"
			Me.Columns.Add(_columnKilosRecibidos)

			_columnCantCabezas = New DataColumn("CantCabezas", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCantCabezas.ReadOnly = True
			_columnCantCabezas.Caption = "CantCabezas"
			Me.Columns.Add(_columnCantCabezas)

			_columnUnidad = New DataColumn("Unidad", GetType(System.String), Nothing, MappingType.Element)
			_columnUnidad.ReadOnly = True
			_columnUnidad.Caption = "Unidad"
			Me.Columns.Add(_columnUnidad)

			_columnConductor = New DataColumn("Conductor", GetType(System.String), Nothing, MappingType.Element)
			_columnConductor.ReadOnly = True
			_columnConductor.Caption = "Conductor"
			Me.Columns.Add(_columnConductor)

			_columnPlacas = New DataColumn("Placas", GetType(System.String), Nothing, MappingType.Element)
			_columnPlacas.ReadOnly = True
			_columnPlacas.Caption = "Placas"
			Me.Columns.Add(_columnPlacas)

			_columnSumaCabezasDet = New DataColumn("SumaCabezasDet", GetType(System.Int32), Nothing, MappingType.Element)
			_columnSumaCabezasDet.ReadOnly = True
			_columnSumaCabezasDet.Caption = "SumaCabezasDet"
			Me.Columns.Add(_columnSumaCabezasDet)

			_columnSumaCabezasMuertas = New DataColumn("SumaCabezasMuertas", GetType(System.Int32), Nothing, MappingType.Element)
			_columnSumaCabezasMuertas.ReadOnly = True
			_columnSumaCabezasMuertas.Caption = "SumaCabezasMuertas"
			Me.Columns.Add(_columnSumaCabezasMuertas)

			_columnEstatus = New DataColumn("Estatus", GetType(System.String), Nothing, MappingType.Element)
			_columnEstatus.ReadOnly = True
			_columnEstatus.Caption = "Estatus"
			Me.Columns.Add(_columnEstatus)

			_columnKilosPromedio = New DataColumn("KilosPromedio", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnKilosPromedio.ReadOnly = True
			_columnKilosPromedio.Caption = "KilosPromedio"
			Me.Columns.Add(_columnKilosPromedio)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnLoteRecepcion = Me.Columns("LoteRecepcion")
			_columnLoteEngorda = Me.Columns("LoteEngorda")
			_columnFechaRecepcion = Me.Columns("FechaRecepcion")
			_columnIdCliente = Me.Columns("IdCliente")
			_columnKilosRecibidos = Me.Columns("KilosRecibidos")
			_columnCantCabezas = Me.Columns("CantCabezas")
			_columnUnidad = Me.Columns("Unidad")
			_columnConductor = Me.Columns("Conductor")
			_columnPlacas = Me.Columns("Placas")
			_columnSumaCabezasDet = Me.Columns("SumaCabezasDet")
			_columnSumaCabezasMuertas = Me.Columns("SumaCabezasMuertas")
			_columnEstatus = Me.Columns("Estatus")
			_columnKilosPromedio = Me.Columns("KilosPromedio")
			
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

			_fieldsCustomProperties.Add("LoteRecepcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("LoteEngorda", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaRecepcion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdCliente", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("KilosRecibidos", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CantCabezas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Unidad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Conductor", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Placas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SumaCabezasDet", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SumaCabezasMuertas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("KilosPromedio", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwRegistroSacrificioRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwRegistroSacrificioTypedView = CType(MyBase.Clone(), VwRegistroSacrificioTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwRegistroSacrificioTypedView()
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
				Return VwRegistroSacrificioTypedView.CustomProperties
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
				Return VwRegistroSacrificioTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwRegistroSacrificioRow
			Get 
				Return CType(Me.Rows(index), VwRegistroSacrificioRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field LoteRecepcion
		''' </summary>
		ReadOnly Friend Property LoteRecepcionColumn As DataColumn
			Get 
				Return _columnLoteRecepcion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field LoteEngorda
		''' </summary>
		ReadOnly Friend Property LoteEngordaColumn As DataColumn
			Get 
				Return _columnLoteEngorda 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FechaRecepcion
		''' </summary>
		ReadOnly Friend Property FechaRecepcionColumn As DataColumn
			Get 
				Return _columnFechaRecepcion 
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
		''' Returns the column Object belonging to the TypedView field KilosRecibidos
		''' </summary>
		ReadOnly Friend Property KilosRecibidosColumn As DataColumn
			Get 
				Return _columnKilosRecibidos 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CantCabezas
		''' </summary>
		ReadOnly Friend Property CantCabezasColumn As DataColumn
			Get 
				Return _columnCantCabezas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Unidad
		''' </summary>
		ReadOnly Friend Property UnidadColumn As DataColumn
			Get 
				Return _columnUnidad 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Conductor
		''' </summary>
		ReadOnly Friend Property ConductorColumn As DataColumn
			Get 
				Return _columnConductor 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Placas
		''' </summary>
		ReadOnly Friend Property PlacasColumn As DataColumn
			Get 
				Return _columnPlacas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field SumaCabezasDet
		''' </summary>
		ReadOnly Friend Property SumaCabezasDetColumn As DataColumn
			Get 
				Return _columnSumaCabezasDet 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field SumaCabezasMuertas
		''' </summary>
		ReadOnly Friend Property SumaCabezasMuertasColumn As DataColumn
			Get 
				Return _columnSumaCabezasMuertas 
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
		''' Returns the column Object belonging to the TypedView field KilosPromedio
		''' </summary>
		ReadOnly Friend Property KilosPromedioColumn As DataColumn
			Get 
				Return _columnKilosPromedio 
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
	''' Typed datarow for the typed datatable VwRegistroSacrificio
	''' </summary>
	Public Class VwRegistroSacrificioRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwRegistroSacrificioTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwRegistroSacrificioTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field LoteRecepcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwRegistroSacrificio"."LoteRecepcion"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 10
		''' </remarks>
		Public Property [LoteRecepcion]() As System.String
			Get 
				If IsLoteRecepcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.LoteRecepcionColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.LoteRecepcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field LoteRecepcion is NULL, False otherwise.
		''' </summary>
		Public Function IsLoteRecepcionNull() As Boolean
			Return IsNull(_parent.LoteRecepcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field LoteRecepcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetLoteRecepcionNull() 
			Me(_parent.LoteRecepcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field LoteEngorda<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwRegistroSacrificio"."LoteEngorda"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 10
		''' </remarks>
		Public Property [LoteEngorda]() As System.String
			Get 
				If IsLoteEngordaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.LoteEngordaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.LoteEngordaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field LoteEngorda is NULL, False otherwise.
		''' </summary>
		Public Function IsLoteEngordaNull() As Boolean
			Return IsNull(_parent.LoteEngordaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field LoteEngorda to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetLoteEngordaNull() 
			Me(_parent.LoteEngordaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaRecepcion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwRegistroSacrificio"."FechaRecepcion"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaRecepcion]() As System.DateTime
			Get 
				If IsFechaRecepcionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaRecepcionColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaRecepcionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaRecepcion is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaRecepcionNull() As Boolean
			Return IsNull(_parent.FechaRecepcionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaRecepcion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaRecepcionNull() 
			Me(_parent.FechaRecepcionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdCliente<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwRegistroSacrificio"."IdCliente"<br/>
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
		''' Gets / sets the value of the TypedView field KilosRecibidos<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwRegistroSacrificio"."KilosRecibidos"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [KilosRecibidos]() As System.Decimal
			Get 
				If IsKilosRecibidosNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.KilosRecibidosColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.KilosRecibidosColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field KilosRecibidos is NULL, False otherwise.
		''' </summary>
		Public Function IsKilosRecibidosNull() As Boolean
			Return IsNull(_parent.KilosRecibidosColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field KilosRecibidos to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetKilosRecibidosNull() 
			Me(_parent.KilosRecibidosColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CantCabezas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwRegistroSacrificio"."CantCabezas"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CantCabezas]() As System.Int32
			Get 
				If IsCantCabezasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CantCabezasColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CantCabezasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CantCabezas is NULL, False otherwise.
		''' </summary>
		Public Function IsCantCabezasNull() As Boolean
			Return IsNull(_parent.CantCabezasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CantCabezas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantCabezasNull() 
			Me(_parent.CantCabezasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Unidad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwRegistroSacrificio"."Unidad"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 120
		''' </remarks>
		Public Property [Unidad]() As System.String
			Get 
				If IsUnidadNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.UnidadColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.UnidadColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Unidad is NULL, False otherwise.
		''' </summary>
		Public Function IsUnidadNull() As Boolean
			Return IsNull(_parent.UnidadColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Unidad to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetUnidadNull() 
			Me(_parent.UnidadColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Conductor<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwRegistroSacrificio"."Conductor"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 120
		''' </remarks>
		Public Property [Conductor]() As System.String
			Get 
				If IsConductorNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.ConductorColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.ConductorColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Conductor is NULL, False otherwise.
		''' </summary>
		Public Function IsConductorNull() As Boolean
			Return IsNull(_parent.ConductorColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Conductor to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetConductorNull() 
			Me(_parent.ConductorColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Placas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwRegistroSacrificio"."Placas"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 20
		''' </remarks>
		Public Property [Placas]() As System.String
			Get 
				If IsPlacasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PlacasColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PlacasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Placas is NULL, False otherwise.
		''' </summary>
		Public Function IsPlacasNull() As Boolean
			Return IsNull(_parent.PlacasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Placas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPlacasNull() 
			Me(_parent.PlacasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field SumaCabezasDet<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwRegistroSacrificio"."SumaCabezasDet"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [SumaCabezasDet]() As System.Int32
			Get 
				If IsSumaCabezasDetNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.SumaCabezasDetColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.SumaCabezasDetColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field SumaCabezasDet is NULL, False otherwise.
		''' </summary>
		Public Function IsSumaCabezasDetNull() As Boolean
			Return IsNull(_parent.SumaCabezasDetColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field SumaCabezasDet to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSumaCabezasDetNull() 
			Me(_parent.SumaCabezasDetColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field SumaCabezasMuertas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwRegistroSacrificio"."SumaCabezasMuertas"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [SumaCabezasMuertas]() As System.Int32
			Get 
				If IsSumaCabezasMuertasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.SumaCabezasMuertasColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.SumaCabezasMuertasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field SumaCabezasMuertas is NULL, False otherwise.
		''' </summary>
		Public Function IsSumaCabezasMuertasNull() As Boolean
			Return IsNull(_parent.SumaCabezasMuertasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field SumaCabezasMuertas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSumaCabezasMuertasNull() 
			Me(_parent.SumaCabezasMuertasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Estatus<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwRegistroSacrificio"."Estatus"<br/>
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
		''' Gets / sets the value of the TypedView field KilosPromedio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwRegistroSacrificio"."KilosPromedio"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [KilosPromedio]() As System.Decimal
			Get 
				If IsKilosPromedioNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.KilosPromedioColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.KilosPromedioColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field KilosPromedio is NULL, False otherwise.
		''' </summary>
		Public Function IsKilosPromedioNull() As Boolean
			Return IsNull(_parent.KilosPromedioColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field KilosPromedio to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetKilosPromedioNull() 
			Me(_parent.KilosPromedioColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
