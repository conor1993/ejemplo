' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 1 de diciembre de 2017 15:44:37
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
	''' Typed datatable for the view 'VwBusquedaComprasGanadoDetalle'.<br/><br/>
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
	Public Class VwBusquedaComprasGanadoDetalleTypedView 
#Else
	Public Class VwBusquedaComprasGanadoDetalleTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnFolioRecepcionCompra As DataColumn
		Private _columnIdTipoGanado As DataColumn
		Private _columnTipoGanado As DataColumn
		Private _columnCabezas As DataColumn
		Private _columnKilosComprados As DataColumn
		Private _columnPrecioXkilo As DataColumn
		Private _columnKilosRecibidos As DataColumn
		Private _columnImporte As DataColumn
		Private _columnKilosPromedioPorCabeza As DataColumn
		Private _columnCostoPromedioXcabeza As DataColumn
		Private _columnFecRecep As DataColumn
		Private _columnCveProveGan As DataColumn
		Private _columnCveLugCom As DataColumn
		Private _columnCveComiGan As DataColumn
		Private _columnCveCorral As DataColumn
		Private _columnStatus As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 16
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
			MyBase.New("VwBusquedaComprasGanadoDetalle")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaComprasGanadoDetalleTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaComprasGanadoDetalleTypedView)
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
			Return New VwBusquedaComprasGanadoDetalleRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnFolioRecepcionCompra = New DataColumn("FolioRecepcionCompra", GetType(System.String), Nothing, MappingType.Element)
			_columnFolioRecepcionCompra.ReadOnly = True
			_columnFolioRecepcionCompra.Caption = "FolioRecepcionCompra"
			Me.Columns.Add(_columnFolioRecepcionCompra)

			_columnIdTipoGanado = New DataColumn("IdTipoGanado", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdTipoGanado.ReadOnly = True
			_columnIdTipoGanado.Caption = "IdTipoGanado"
			Me.Columns.Add(_columnIdTipoGanado)

			_columnTipoGanado = New DataColumn("TipoGanado", GetType(System.String), Nothing, MappingType.Element)
			_columnTipoGanado.ReadOnly = True
			_columnTipoGanado.Caption = "TipoGanado"
			Me.Columns.Add(_columnTipoGanado)

			_columnCabezas = New DataColumn("Cabezas", GetType(System.Int16), Nothing, MappingType.Element)
			_columnCabezas.ReadOnly = True
			_columnCabezas.Caption = "Cabezas"
			Me.Columns.Add(_columnCabezas)

			_columnKilosComprados = New DataColumn("KilosComprados", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnKilosComprados.ReadOnly = True
			_columnKilosComprados.Caption = "KilosComprados"
			Me.Columns.Add(_columnKilosComprados)

			_columnPrecioXkilo = New DataColumn("PrecioXkilo", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnPrecioXkilo.ReadOnly = True
			_columnPrecioXkilo.Caption = "PrecioXkilo"
			Me.Columns.Add(_columnPrecioXkilo)

			_columnKilosRecibidos = New DataColumn("KilosRecibidos", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnKilosRecibidos.ReadOnly = True
			_columnKilosRecibidos.Caption = "KilosRecibidos"
			Me.Columns.Add(_columnKilosRecibidos)

			_columnImporte = New DataColumn("Importe", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnImporte.ReadOnly = True
			_columnImporte.Caption = "Importe"
			Me.Columns.Add(_columnImporte)

			_columnKilosPromedioPorCabeza = New DataColumn("KilosPromedioPorCabeza", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnKilosPromedioPorCabeza.ReadOnly = True
			_columnKilosPromedioPorCabeza.Caption = "KilosPromedioPorCabeza"
			Me.Columns.Add(_columnKilosPromedioPorCabeza)

			_columnCostoPromedioXcabeza = New DataColumn("CostoPromedioXcabeza", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCostoPromedioXcabeza.ReadOnly = True
			_columnCostoPromedioXcabeza.Caption = "CostoPromedioXcabeza"
			Me.Columns.Add(_columnCostoPromedioXcabeza)

			_columnFecRecep = New DataColumn("FecRecep", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFecRecep.ReadOnly = True
			_columnFecRecep.Caption = "FecRecep"
			Me.Columns.Add(_columnFecRecep)

			_columnCveProveGan = New DataColumn("CveProveGan", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCveProveGan.ReadOnly = True
			_columnCveProveGan.Caption = "CveProveGan"
			Me.Columns.Add(_columnCveProveGan)

			_columnCveLugCom = New DataColumn("CveLugCom", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCveLugCom.ReadOnly = True
			_columnCveLugCom.Caption = "CveLugCom"
			Me.Columns.Add(_columnCveLugCom)

			_columnCveComiGan = New DataColumn("CveComiGan", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCveComiGan.ReadOnly = True
			_columnCveComiGan.Caption = "CveComiGan"
			Me.Columns.Add(_columnCveComiGan)

			_columnCveCorral = New DataColumn("CveCorral", GetType(System.String), Nothing, MappingType.Element)
			_columnCveCorral.ReadOnly = True
			_columnCveCorral.Caption = "CveCorral"
			Me.Columns.Add(_columnCveCorral)

			_columnStatus = New DataColumn("Status", GetType(System.String), Nothing, MappingType.Element)
			_columnStatus.ReadOnly = True
			_columnStatus.Caption = "Status"
			Me.Columns.Add(_columnStatus)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnFolioRecepcionCompra = Me.Columns("FolioRecepcionCompra")
			_columnIdTipoGanado = Me.Columns("IdTipoGanado")
			_columnTipoGanado = Me.Columns("TipoGanado")
			_columnCabezas = Me.Columns("Cabezas")
			_columnKilosComprados = Me.Columns("KilosComprados")
			_columnPrecioXkilo = Me.Columns("PrecioXkilo")
			_columnKilosRecibidos = Me.Columns("KilosRecibidos")
			_columnImporte = Me.Columns("Importe")
			_columnKilosPromedioPorCabeza = Me.Columns("KilosPromedioPorCabeza")
			_columnCostoPromedioXcabeza = Me.Columns("CostoPromedioXcabeza")
			_columnFecRecep = Me.Columns("FecRecep")
			_columnCveProveGan = Me.Columns("CveProveGan")
			_columnCveLugCom = Me.Columns("CveLugCom")
			_columnCveComiGan = Me.Columns("CveComiGan")
			_columnCveCorral = Me.Columns("CveCorral")
			_columnStatus = Me.Columns("Status")
			
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

			_fieldsCustomProperties.Add("FolioRecepcionCompra", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdTipoGanado", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TipoGanado", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Cabezas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("KilosComprados", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrecioXkilo", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("KilosRecibidos", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("KilosPromedioPorCabeza", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CostoPromedioXcabeza", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FecRecep", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CveProveGan", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CveLugCom", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CveComiGan", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CveCorral", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Status", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwBusquedaComprasGanadoDetalleRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwBusquedaComprasGanadoDetalleTypedView = CType(MyBase.Clone(), VwBusquedaComprasGanadoDetalleTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwBusquedaComprasGanadoDetalleTypedView()
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
				Return VwBusquedaComprasGanadoDetalleTypedView.CustomProperties
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
				Return VwBusquedaComprasGanadoDetalleTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwBusquedaComprasGanadoDetalleRow
			Get 
				Return CType(Me.Rows(index), VwBusquedaComprasGanadoDetalleRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FolioRecepcionCompra
		''' </summary>
		ReadOnly Friend Property FolioRecepcionCompraColumn As DataColumn
			Get 
				Return _columnFolioRecepcionCompra 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdTipoGanado
		''' </summary>
		ReadOnly Friend Property IdTipoGanadoColumn As DataColumn
			Get 
				Return _columnIdTipoGanado 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field TipoGanado
		''' </summary>
		ReadOnly Friend Property TipoGanadoColumn As DataColumn
			Get 
				Return _columnTipoGanado 
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
		''' Returns the column Object belonging to the TypedView field KilosComprados
		''' </summary>
		ReadOnly Friend Property KilosCompradosColumn As DataColumn
			Get 
				Return _columnKilosComprados 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PrecioXkilo
		''' </summary>
		ReadOnly Friend Property PrecioXkiloColumn As DataColumn
			Get 
				Return _columnPrecioXkilo 
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
		''' Returns the column Object belonging to the TypedView field Importe
		''' </summary>
		ReadOnly Friend Property ImporteColumn As DataColumn
			Get 
				Return _columnImporte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field KilosPromedioPorCabeza
		''' </summary>
		ReadOnly Friend Property KilosPromedioPorCabezaColumn As DataColumn
			Get 
				Return _columnKilosPromedioPorCabeza 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CostoPromedioXcabeza
		''' </summary>
		ReadOnly Friend Property CostoPromedioXcabezaColumn As DataColumn
			Get 
				Return _columnCostoPromedioXcabeza 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FecRecep
		''' </summary>
		ReadOnly Friend Property FecRecepColumn As DataColumn
			Get 
				Return _columnFecRecep 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CveProveGan
		''' </summary>
		ReadOnly Friend Property CveProveGanColumn As DataColumn
			Get 
				Return _columnCveProveGan 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CveLugCom
		''' </summary>
		ReadOnly Friend Property CveLugComColumn As DataColumn
			Get 
				Return _columnCveLugCom 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CveComiGan
		''' </summary>
		ReadOnly Friend Property CveComiGanColumn As DataColumn
			Get 
				Return _columnCveComiGan 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CveCorral
		''' </summary>
		ReadOnly Friend Property CveCorralColumn As DataColumn
			Get 
				Return _columnCveCorral 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Status
		''' </summary>
		ReadOnly Friend Property StatusColumn As DataColumn
			Get 
				Return _columnStatus 
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
	''' Typed datarow for the typed datatable VwBusquedaComprasGanadoDetalle
	''' </summary>
	Public Class VwBusquedaComprasGanadoDetalleRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwBusquedaComprasGanadoDetalleTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwBusquedaComprasGanadoDetalleTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field FolioRecepcionCompra<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasGanadoDetalle"."FolioRecepcionCompra"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 10
		''' </remarks>
		Public Property [FolioRecepcionCompra]() As System.String
			Get 
				If IsFolioRecepcionCompraNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.FolioRecepcionCompraColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.FolioRecepcionCompraColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FolioRecepcionCompra is NULL, False otherwise.
		''' </summary>
		Public Function IsFolioRecepcionCompraNull() As Boolean
			Return IsNull(_parent.FolioRecepcionCompraColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FolioRecepcionCompra to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFolioRecepcionCompraNull() 
			Me(_parent.FolioRecepcionCompraColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdTipoGanado<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasGanadoDetalle"."IdTipoGanado"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdTipoGanado]() As System.Int32
			Get 
				If IsIdTipoGanadoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdTipoGanadoColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdTipoGanadoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdTipoGanado is NULL, False otherwise.
		''' </summary>
		Public Function IsIdTipoGanadoNull() As Boolean
			Return IsNull(_parent.IdTipoGanadoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdTipoGanado to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdTipoGanadoNull() 
			Me(_parent.IdTipoGanadoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field TipoGanado<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasGanadoDetalle"."TipoGanado"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 60
		''' </remarks>
		Public Property [TipoGanado]() As System.String
			Get 
				If IsTipoGanadoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.TipoGanadoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.TipoGanadoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TipoGanado is NULL, False otherwise.
		''' </summary>
		Public Function IsTipoGanadoNull() As Boolean
			Return IsNull(_parent.TipoGanadoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TipoGanado to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTipoGanadoNull() 
			Me(_parent.TipoGanadoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Cabezas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasGanadoDetalle"."Cabezas"<br/>
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
		''' Gets / sets the value of the TypedView field KilosComprados<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasGanadoDetalle"."KilosComprados"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [KilosComprados]() As System.Decimal
			Get 
				If IsKilosCompradosNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.KilosCompradosColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.KilosCompradosColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field KilosComprados is NULL, False otherwise.
		''' </summary>
		Public Function IsKilosCompradosNull() As Boolean
			Return IsNull(_parent.KilosCompradosColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field KilosComprados to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetKilosCompradosNull() 
			Me(_parent.KilosCompradosColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PrecioXkilo<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasGanadoDetalle"."PrecioXKilo"<br/>
		''' View field characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0
		''' </remarks>
		Public Property [PrecioXkilo]() As System.Decimal
			Get 
				If IsPrecioXkiloNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.PrecioXkiloColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.PrecioXkiloColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PrecioXkilo is NULL, False otherwise.
		''' </summary>
		Public Function IsPrecioXkiloNull() As Boolean
			Return IsNull(_parent.PrecioXkiloColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PrecioXkilo to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrecioXkiloNull() 
			Me(_parent.PrecioXkiloColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field KilosRecibidos<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasGanadoDetalle"."KilosRecibidos"<br/>
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
		''' Gets / sets the value of the TypedView field Importe<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasGanadoDetalle"."Importe"<br/>
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
		''' Gets / sets the value of the TypedView field KilosPromedioPorCabeza<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasGanadoDetalle"."KilosPromedioPorCabeza"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [KilosPromedioPorCabeza]() As System.Decimal
			Get 
				If IsKilosPromedioPorCabezaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.KilosPromedioPorCabezaColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.KilosPromedioPorCabezaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field KilosPromedioPorCabeza is NULL, False otherwise.
		''' </summary>
		Public Function IsKilosPromedioPorCabezaNull() As Boolean
			Return IsNull(_parent.KilosPromedioPorCabezaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field KilosPromedioPorCabeza to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetKilosPromedioPorCabezaNull() 
			Me(_parent.KilosPromedioPorCabezaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CostoPromedioXcabeza<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasGanadoDetalle"."CostoPromedioXCabeza"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [CostoPromedioXcabeza]() As System.Decimal
			Get 
				If IsCostoPromedioXcabezaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CostoPromedioXcabezaColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CostoPromedioXcabezaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CostoPromedioXcabeza is NULL, False otherwise.
		''' </summary>
		Public Function IsCostoPromedioXcabezaNull() As Boolean
			Return IsNull(_parent.CostoPromedioXcabezaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CostoPromedioXcabeza to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCostoPromedioXcabezaNull() 
			Me(_parent.CostoPromedioXcabezaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FecRecep<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasGanadoDetalle"."Fec_Recep"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FecRecep]() As System.DateTime
			Get 
				If IsFecRecepNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FecRecepColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FecRecepColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FecRecep is NULL, False otherwise.
		''' </summary>
		Public Function IsFecRecepNull() As Boolean
			Return IsNull(_parent.FecRecepColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FecRecep to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFecRecepNull() 
			Me(_parent.FecRecepColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CveProveGan<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasGanadoDetalle"."Cve_ProveGan"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CveProveGan]() As System.Int32
			Get 
				If IsCveProveGanNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CveProveGanColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CveProveGanColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CveProveGan is NULL, False otherwise.
		''' </summary>
		Public Function IsCveProveGanNull() As Boolean
			Return IsNull(_parent.CveProveGanColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CveProveGan to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCveProveGanNull() 
			Me(_parent.CveProveGanColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CveLugCom<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasGanadoDetalle"."Cve_LugCom"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CveLugCom]() As System.Int32
			Get 
				If IsCveLugComNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CveLugComColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CveLugComColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CveLugCom is NULL, False otherwise.
		''' </summary>
		Public Function IsCveLugComNull() As Boolean
			Return IsNull(_parent.CveLugComColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CveLugCom to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCveLugComNull() 
			Me(_parent.CveLugComColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CveComiGan<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasGanadoDetalle"."Cve_ComiGan"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CveComiGan]() As System.Int32
			Get 
				If IsCveComiGanNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CveComiGanColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CveComiGanColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CveComiGan is NULL, False otherwise.
		''' </summary>
		Public Function IsCveComiGanNull() As Boolean
			Return IsNull(_parent.CveComiGanColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CveComiGan to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCveComiGanNull() 
			Me(_parent.CveComiGanColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CveCorral<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasGanadoDetalle"."Cve_Corral"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 5
		''' </remarks>
		Public Property [CveCorral]() As System.String
			Get 
				If IsCveCorralNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.CveCorralColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.CveCorralColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CveCorral is NULL, False otherwise.
		''' </summary>
		Public Function IsCveCorralNull() As Boolean
			Return IsNull(_parent.CveCorralColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CveCorral to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCveCorralNull() 
			Me(_parent.CveCorralColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Status<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasGanadoDetalle"."Status"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 1
		''' </remarks>
		Public Property [Status]() As System.String
			Get 
				If IsStatusNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.StatusColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.StatusColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Status is NULL, False otherwise.
		''' </summary>
		Public Function IsStatusNull() As Boolean
			Return IsNull(_parent.StatusColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Status to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetStatusNull() 
			Me(_parent.StatusColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
