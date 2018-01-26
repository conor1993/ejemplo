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
	''' Typed datatable for the view 'VwBusquedaComprasdeGanado'.<br/><br/>
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
	Public Class VwBusquedaComprasdeGanadoTypedView 
#Else
	Public Class VwBusquedaComprasdeGanadoTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnFolioRecepcionCompra As DataColumn
		Private _columnFechaRecepcionCompra As DataColumn
		Private _columnIdProveedor As DataColumn
		Private _columnProveedor As DataColumn
		Private _columnIdLugarCompra As DataColumn
		Private _columnLugarCompra As DataColumn
		Private _columnIdCompradorGanado As DataColumn
		Private _columnCompradorGanado As DataColumn
		Private _columnIdCorral As DataColumn
		Private _columnCorral As DataColumn
		Private _columnNumGuias As DataColumn
		Private _columnImpteXguia As DataColumn
		Private _columnCabezasComp As DataColumn
		Private _columnKilosComp As DataColumn
		Private _columnImpteComp As DataColumn
		Private _columnStaCerrado As DataColumn
		Private _columnStatus As DataColumn
		Private _columnCostosIndi As DataColumn
		Private _columnPesoEntReal As DataColumn
		Private _columnEstatusStr As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 20
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
			MyBase.New("VwBusquedaComprasdeGanado")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaComprasdeGanadoTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaComprasdeGanadoTypedView)
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
			Return New VwBusquedaComprasdeGanadoRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnFolioRecepcionCompra = New DataColumn("FolioRecepcionCompra", GetType(System.String), Nothing, MappingType.Element)
			_columnFolioRecepcionCompra.ReadOnly = True
			_columnFolioRecepcionCompra.Caption = "FolioRecepcionCompra"
			Me.Columns.Add(_columnFolioRecepcionCompra)

			_columnFechaRecepcionCompra = New DataColumn("FechaRecepcionCompra", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaRecepcionCompra.ReadOnly = True
			_columnFechaRecepcionCompra.Caption = "FechaRecepcionCompra"
			Me.Columns.Add(_columnFechaRecepcionCompra)

			_columnIdProveedor = New DataColumn("IdProveedor", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdProveedor.ReadOnly = True
			_columnIdProveedor.Caption = "IdProveedor"
			Me.Columns.Add(_columnIdProveedor)

			_columnProveedor = New DataColumn("Proveedor", GetType(System.String), Nothing, MappingType.Element)
			_columnProveedor.ReadOnly = True
			_columnProveedor.Caption = "Proveedor"
			Me.Columns.Add(_columnProveedor)

			_columnIdLugarCompra = New DataColumn("IdLugarCompra", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdLugarCompra.ReadOnly = True
			_columnIdLugarCompra.Caption = "IdLugarCompra"
			Me.Columns.Add(_columnIdLugarCompra)

			_columnLugarCompra = New DataColumn("LugarCompra", GetType(System.String), Nothing, MappingType.Element)
			_columnLugarCompra.ReadOnly = True
			_columnLugarCompra.Caption = "LugarCompra"
			Me.Columns.Add(_columnLugarCompra)

			_columnIdCompradorGanado = New DataColumn("IdCompradorGanado", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdCompradorGanado.ReadOnly = True
			_columnIdCompradorGanado.Caption = "IdCompradorGanado"
			Me.Columns.Add(_columnIdCompradorGanado)

			_columnCompradorGanado = New DataColumn("CompradorGanado", GetType(System.String), Nothing, MappingType.Element)
			_columnCompradorGanado.ReadOnly = True
			_columnCompradorGanado.Caption = "CompradorGanado"
			Me.Columns.Add(_columnCompradorGanado)

			_columnIdCorral = New DataColumn("IdCorral", GetType(System.String), Nothing, MappingType.Element)
			_columnIdCorral.ReadOnly = True
			_columnIdCorral.Caption = "IdCorral"
			Me.Columns.Add(_columnIdCorral)

			_columnCorral = New DataColumn("Corral", GetType(System.String), Nothing, MappingType.Element)
			_columnCorral.ReadOnly = True
			_columnCorral.Caption = "Corral"
			Me.Columns.Add(_columnCorral)

			_columnNumGuias = New DataColumn("NumGuias", GetType(System.Int16), Nothing, MappingType.Element)
			_columnNumGuias.ReadOnly = True
			_columnNumGuias.Caption = "NumGuias"
			Me.Columns.Add(_columnNumGuias)

			_columnImpteXguia = New DataColumn("ImpteXguia", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnImpteXguia.ReadOnly = True
			_columnImpteXguia.Caption = "ImpteXguia"
			Me.Columns.Add(_columnImpteXguia)

			_columnCabezasComp = New DataColumn("CabezasComp", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCabezasComp.ReadOnly = True
			_columnCabezasComp.Caption = "CabezasComp"
			Me.Columns.Add(_columnCabezasComp)

			_columnKilosComp = New DataColumn("KilosComp", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnKilosComp.ReadOnly = True
			_columnKilosComp.Caption = "KilosComp"
			Me.Columns.Add(_columnKilosComp)

			_columnImpteComp = New DataColumn("ImpteComp", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnImpteComp.ReadOnly = True
			_columnImpteComp.Caption = "ImpteComp"
			Me.Columns.Add(_columnImpteComp)

			_columnStaCerrado = New DataColumn("StaCerrado", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnStaCerrado.ReadOnly = True
			_columnStaCerrado.Caption = "StaCerrado"
			Me.Columns.Add(_columnStaCerrado)

			_columnStatus = New DataColumn("Status", GetType(System.String), Nothing, MappingType.Element)
			_columnStatus.ReadOnly = True
			_columnStatus.Caption = "Status"
			Me.Columns.Add(_columnStatus)

			_columnCostosIndi = New DataColumn("CostosIndi", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnCostosIndi.ReadOnly = True
			_columnCostosIndi.Caption = "CostosIndi"
			Me.Columns.Add(_columnCostosIndi)

			_columnPesoEntReal = New DataColumn("PesoEntReal", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnPesoEntReal.ReadOnly = True
			_columnPesoEntReal.Caption = "PesoEntReal"
			Me.Columns.Add(_columnPesoEntReal)

			_columnEstatusStr = New DataColumn("EstatusStr", GetType(System.String), Nothing, MappingType.Element)
			_columnEstatusStr.ReadOnly = True
			_columnEstatusStr.Caption = "EstatusStr"
			Me.Columns.Add(_columnEstatusStr)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnFolioRecepcionCompra = Me.Columns("FolioRecepcionCompra")
			_columnFechaRecepcionCompra = Me.Columns("FechaRecepcionCompra")
			_columnIdProveedor = Me.Columns("IdProveedor")
			_columnProveedor = Me.Columns("Proveedor")
			_columnIdLugarCompra = Me.Columns("IdLugarCompra")
			_columnLugarCompra = Me.Columns("LugarCompra")
			_columnIdCompradorGanado = Me.Columns("IdCompradorGanado")
			_columnCompradorGanado = Me.Columns("CompradorGanado")
			_columnIdCorral = Me.Columns("IdCorral")
			_columnCorral = Me.Columns("Corral")
			_columnNumGuias = Me.Columns("NumGuias")
			_columnImpteXguia = Me.Columns("ImpteXguia")
			_columnCabezasComp = Me.Columns("CabezasComp")
			_columnKilosComp = Me.Columns("KilosComp")
			_columnImpteComp = Me.Columns("ImpteComp")
			_columnStaCerrado = Me.Columns("StaCerrado")
			_columnStatus = Me.Columns("Status")
			_columnCostosIndi = Me.Columns("CostosIndi")
			_columnPesoEntReal = Me.Columns("PesoEntReal")
			_columnEstatusStr = Me.Columns("EstatusStr")
			
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

			_fieldsCustomProperties.Add("FechaRecepcionCompra", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdProveedor", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Proveedor", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdLugarCompra", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("LugarCompra", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdCompradorGanado", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CompradorGanado", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdCorral", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Corral", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("NumGuias", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ImpteXguia", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CabezasComp", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("KilosComp", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ImpteComp", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("StaCerrado", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Status", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CostosIndi", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PesoEntReal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("EstatusStr", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwBusquedaComprasdeGanadoRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwBusquedaComprasdeGanadoTypedView = CType(MyBase.Clone(), VwBusquedaComprasdeGanadoTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwBusquedaComprasdeGanadoTypedView()
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
				Return VwBusquedaComprasdeGanadoTypedView.CustomProperties
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
				Return VwBusquedaComprasdeGanadoTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwBusquedaComprasdeGanadoRow
			Get 
				Return CType(Me.Rows(index), VwBusquedaComprasdeGanadoRow)
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
		''' Returns the column Object belonging to the TypedView field FechaRecepcionCompra
		''' </summary>
		ReadOnly Friend Property FechaRecepcionCompraColumn As DataColumn
			Get 
				Return _columnFechaRecepcionCompra 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdProveedor
		''' </summary>
		ReadOnly Friend Property IdProveedorColumn As DataColumn
			Get 
				Return _columnIdProveedor 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Proveedor
		''' </summary>
		ReadOnly Friend Property ProveedorColumn As DataColumn
			Get 
				Return _columnProveedor 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdLugarCompra
		''' </summary>
		ReadOnly Friend Property IdLugarCompraColumn As DataColumn
			Get 
				Return _columnIdLugarCompra 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field LugarCompra
		''' </summary>
		ReadOnly Friend Property LugarCompraColumn As DataColumn
			Get 
				Return _columnLugarCompra 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdCompradorGanado
		''' </summary>
		ReadOnly Friend Property IdCompradorGanadoColumn As DataColumn
			Get 
				Return _columnIdCompradorGanado 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CompradorGanado
		''' </summary>
		ReadOnly Friend Property CompradorGanadoColumn As DataColumn
			Get 
				Return _columnCompradorGanado 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdCorral
		''' </summary>
		ReadOnly Friend Property IdCorralColumn As DataColumn
			Get 
				Return _columnIdCorral 
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
		''' Returns the column Object belonging to the TypedView field NumGuias
		''' </summary>
		ReadOnly Friend Property NumGuiasColumn As DataColumn
			Get 
				Return _columnNumGuias 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field ImpteXguia
		''' </summary>
		ReadOnly Friend Property ImpteXguiaColumn As DataColumn
			Get 
				Return _columnImpteXguia 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CabezasComp
		''' </summary>
		ReadOnly Friend Property CabezasCompColumn As DataColumn
			Get 
				Return _columnCabezasComp 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field KilosComp
		''' </summary>
		ReadOnly Friend Property KilosCompColumn As DataColumn
			Get 
				Return _columnKilosComp 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field ImpteComp
		''' </summary>
		ReadOnly Friend Property ImpteCompColumn As DataColumn
			Get 
				Return _columnImpteComp 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field StaCerrado
		''' </summary>
		ReadOnly Friend Property StaCerradoColumn As DataColumn
			Get 
				Return _columnStaCerrado 
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
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CostosIndi
		''' </summary>
		ReadOnly Friend Property CostosIndiColumn As DataColumn
			Get 
				Return _columnCostosIndi 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PesoEntReal
		''' </summary>
		ReadOnly Friend Property PesoEntRealColumn As DataColumn
			Get 
				Return _columnPesoEntReal 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field EstatusStr
		''' </summary>
		ReadOnly Friend Property EstatusStrColumn As DataColumn
			Get 
				Return _columnEstatusStr 
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
	''' Typed datarow for the typed datatable VwBusquedaComprasdeGanado
	''' </summary>
	Public Class VwBusquedaComprasdeGanadoRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwBusquedaComprasdeGanadoTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwBusquedaComprasdeGanadoTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field FolioRecepcionCompra<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasdeGanado"."FolioRecepcionCompra"<br/>
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
		''' Gets / sets the value of the TypedView field FechaRecepcionCompra<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasdeGanado"."FechaRecepcionCompra"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaRecepcionCompra]() As System.DateTime
			Get 
				If IsFechaRecepcionCompraNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaRecepcionCompraColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaRecepcionCompraColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaRecepcionCompra is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaRecepcionCompraNull() As Boolean
			Return IsNull(_parent.FechaRecepcionCompraColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaRecepcionCompra to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaRecepcionCompraNull() 
			Me(_parent.FechaRecepcionCompraColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdProveedor<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasdeGanado"."IdProveedor"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdProveedor]() As System.Int32
			Get 
				If IsIdProveedorNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdProveedorColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdProveedorColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdProveedor is NULL, False otherwise.
		''' </summary>
		Public Function IsIdProveedorNull() As Boolean
			Return IsNull(_parent.IdProveedorColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdProveedor to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdProveedorNull() 
			Me(_parent.IdProveedorColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Proveedor<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasdeGanado"."Proveedor"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 150
		''' </remarks>
		Public Property [Proveedor]() As System.String
			Get 
				If IsProveedorNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.ProveedorColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.ProveedorColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Proveedor is NULL, False otherwise.
		''' </summary>
		Public Function IsProveedorNull() As Boolean
			Return IsNull(_parent.ProveedorColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Proveedor to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetProveedorNull() 
			Me(_parent.ProveedorColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdLugarCompra<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasdeGanado"."IdLugarCompra"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdLugarCompra]() As System.Int32
			Get 
				If IsIdLugarCompraNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdLugarCompraColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdLugarCompraColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdLugarCompra is NULL, False otherwise.
		''' </summary>
		Public Function IsIdLugarCompraNull() As Boolean
			Return IsNull(_parent.IdLugarCompraColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdLugarCompra to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdLugarCompraNull() 
			Me(_parent.IdLugarCompraColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field LugarCompra<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasdeGanado"."LugarCompra"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
		Public Property [LugarCompra]() As System.String
			Get 
				If IsLugarCompraNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.LugarCompraColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.LugarCompraColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field LugarCompra is NULL, False otherwise.
		''' </summary>
		Public Function IsLugarCompraNull() As Boolean
			Return IsNull(_parent.LugarCompraColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field LugarCompra to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetLugarCompraNull() 
			Me(_parent.LugarCompraColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdCompradorGanado<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasdeGanado"."IdCompradorGanado"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdCompradorGanado]() As System.Int32
			Get 
				If IsIdCompradorGanadoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdCompradorGanadoColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdCompradorGanadoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdCompradorGanado is NULL, False otherwise.
		''' </summary>
		Public Function IsIdCompradorGanadoNull() As Boolean
			Return IsNull(_parent.IdCompradorGanadoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdCompradorGanado to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdCompradorGanadoNull() 
			Me(_parent.IdCompradorGanadoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CompradorGanado<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasdeGanado"."CompradorGanado"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 82
		''' </remarks>
		Public Property [CompradorGanado]() As System.String
			Get 
				If IsCompradorGanadoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.CompradorGanadoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.CompradorGanadoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CompradorGanado is NULL, False otherwise.
		''' </summary>
		Public Function IsCompradorGanadoNull() As Boolean
			Return IsNull(_parent.CompradorGanadoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CompradorGanado to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCompradorGanadoNull() 
			Me(_parent.CompradorGanadoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdCorral<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasdeGanado"."IdCorral"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 5
		''' </remarks>
		Public Property [IdCorral]() As System.String
			Get 
				If IsIdCorralNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.IdCorralColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.IdCorralColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdCorral is NULL, False otherwise.
		''' </summary>
		Public Function IsIdCorralNull() As Boolean
			Return IsNull(_parent.IdCorralColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdCorral to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdCorralNull() 
			Me(_parent.IdCorralColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Corral<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasdeGanado"."Corral"<br/>
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
		''' Gets / sets the value of the TypedView field NumGuias<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasdeGanado"."NumGuias"<br/>
		''' View field characteristics (type, precision, scale, length): SmallInt, 5, 0, 0
		''' </remarks>
		Public Property [NumGuias]() As System.Int16
			Get 
				If IsNumGuiasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int16)), System.Int16)
				Else
					Return CType(Me(_parent.NumGuiasColumn), System.Int16)
				End If
			End Get
			Set 
				Me(_parent.NumGuiasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field NumGuias is NULL, False otherwise.
		''' </summary>
		Public Function IsNumGuiasNull() As Boolean
			Return IsNull(_parent.NumGuiasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field NumGuias to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetNumGuiasNull() 
			Me(_parent.NumGuiasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field ImpteXguia<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasdeGanado"."ImpteXGuia"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [ImpteXguia]() As System.Decimal
			Get 
				If IsImpteXguiaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.ImpteXguiaColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.ImpteXguiaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field ImpteXguia is NULL, False otherwise.
		''' </summary>
		Public Function IsImpteXguiaNull() As Boolean
			Return IsNull(_parent.ImpteXguiaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ImpteXguia to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetImpteXguiaNull() 
			Me(_parent.ImpteXguiaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CabezasComp<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasdeGanado"."CabezasComp"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CabezasComp]() As System.Int32
			Get 
				If IsCabezasCompNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CabezasCompColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CabezasCompColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CabezasComp is NULL, False otherwise.
		''' </summary>
		Public Function IsCabezasCompNull() As Boolean
			Return IsNull(_parent.CabezasCompColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CabezasComp to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCabezasCompNull() 
			Me(_parent.CabezasCompColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field KilosComp<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasdeGanado"."KilosComp"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [KilosComp]() As System.Decimal
			Get 
				If IsKilosCompNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.KilosCompColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.KilosCompColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field KilosComp is NULL, False otherwise.
		''' </summary>
		Public Function IsKilosCompNull() As Boolean
			Return IsNull(_parent.KilosCompColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field KilosComp to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetKilosCompNull() 
			Me(_parent.KilosCompColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field ImpteComp<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasdeGanado"."ImpteComp"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [ImpteComp]() As System.Decimal
			Get 
				If IsImpteCompNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.ImpteCompColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.ImpteCompColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field ImpteComp is NULL, False otherwise.
		''' </summary>
		Public Function IsImpteCompNull() As Boolean
			Return IsNull(_parent.ImpteCompColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ImpteComp to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetImpteCompNull() 
			Me(_parent.ImpteCompColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field StaCerrado<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasdeGanado"."Sta_Cerrado"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [StaCerrado]() As System.Boolean
			Get 
				If IsStaCerradoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.StaCerradoColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.StaCerradoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field StaCerrado is NULL, False otherwise.
		''' </summary>
		Public Function IsStaCerradoNull() As Boolean
			Return IsNull(_parent.StaCerradoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field StaCerrado to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetStaCerradoNull() 
			Me(_parent.StaCerradoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Status<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasdeGanado"."Status"<br/>
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

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CostosIndi<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasdeGanado"."CostosIndi"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [CostosIndi]() As System.Decimal
			Get 
				If IsCostosIndiNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.CostosIndiColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.CostosIndiColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CostosIndi is NULL, False otherwise.
		''' </summary>
		Public Function IsCostosIndiNull() As Boolean
			Return IsNull(_parent.CostosIndiColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CostosIndi to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCostosIndiNull() 
			Me(_parent.CostosIndiColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PesoEntReal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasdeGanado"."PesoEntReal"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [PesoEntReal]() As System.Decimal
			Get 
				If IsPesoEntRealNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.PesoEntRealColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.PesoEntRealColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PesoEntReal is NULL, False otherwise.
		''' </summary>
		Public Function IsPesoEntRealNull() As Boolean
			Return IsNull(_parent.PesoEntRealColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PesoEntReal to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPesoEntRealNull() 
			Me(_parent.PesoEntRealColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field EstatusStr<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaComprasdeGanado"."EstatusStr"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 9
		''' </remarks>
		Public Property [EstatusStr]() As System.String
			Get 
				If IsEstatusStrNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.EstatusStrColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.EstatusStrColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field EstatusStr is NULL, False otherwise.
		''' </summary>
		Public Function IsEstatusStrNull() As Boolean
			Return IsNull(_parent.EstatusStrColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field EstatusStr to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEstatusStrNull() 
			Me(_parent.EstatusStrColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
