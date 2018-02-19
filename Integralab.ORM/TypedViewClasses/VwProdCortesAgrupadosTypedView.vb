' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: domingo, 18 de febrero de 2018 17:53:01
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
	''' Typed datatable for the view 'VwProdCortesAgrupados'.<br/><br/>
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
	Public Class VwProdCortesAgrupadosTypedView 
#Else
	Public Class VwProdCortesAgrupadosTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnLoteCorte As DataColumn
		Private _columnLoteSacrificio As DataColumn
		Private _columnFechaCorte As DataColumn
		Private _columnFechaCad As DataColumn
		Private _columnIdCliente As DataColumn
		Private _columnNombre As DataColumn
		Private _columnEstatus As DataColumn
		Private _columnTotalPiezas As DataColumn
		Private _columnPiezasExistentes As DataColumn
		Private _columnPiezasEmbarcadas As DataColumn
		Private _columnTotalKilos As DataColumn
		Private _columnKilosExistentes As DataColumn
		Private _columnKilosEmbarcados As DataColumn
		Private _columnTotalCajas As DataColumn
		Private _columnCajasExistentes As DataColumn
		Private _columnCajasEmbarcadas As DataColumn
		Private _columnCajasCanceladas As DataColumn
		Private _columnCanalesAcorte As DataColumn
		Private _columnKilosAcorte As DataColumn
		Private _columnPiezasCanceladas As DataColumn
		Private _columnKilosCancelados As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 21
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
			MyBase.New("VwProdCortesAgrupados")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwProdCortesAgrupadosTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwProdCortesAgrupadosTypedView)
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
			Return New VwProdCortesAgrupadosRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnLoteCorte = New DataColumn("LoteCorte", GetType(System.String), Nothing, MappingType.Element)
			_columnLoteCorte.ReadOnly = True
			_columnLoteCorte.Caption = "LoteCorte"
			Me.Columns.Add(_columnLoteCorte)

			_columnLoteSacrificio = New DataColumn("LoteSacrificio", GetType(System.String), Nothing, MappingType.Element)
			_columnLoteSacrificio.ReadOnly = True
			_columnLoteSacrificio.Caption = "LoteSacrificio"
			Me.Columns.Add(_columnLoteSacrificio)

			_columnFechaCorte = New DataColumn("FechaCorte", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaCorte.ReadOnly = True
			_columnFechaCorte.Caption = "FechaCorte"
			Me.Columns.Add(_columnFechaCorte)

			_columnFechaCad = New DataColumn("FechaCad", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaCad.ReadOnly = True
			_columnFechaCad.Caption = "FechaCad"
			Me.Columns.Add(_columnFechaCad)

			_columnIdCliente = New DataColumn("IdCliente", GetType(System.String), Nothing, MappingType.Element)
			_columnIdCliente.ReadOnly = True
			_columnIdCliente.Caption = "IdCliente"
			Me.Columns.Add(_columnIdCliente)

			_columnNombre = New DataColumn("Nombre", GetType(System.String), Nothing, MappingType.Element)
			_columnNombre.ReadOnly = True
			_columnNombre.Caption = "Nombre"
			Me.Columns.Add(_columnNombre)

			_columnEstatus = New DataColumn("Estatus", GetType(System.String), Nothing, MappingType.Element)
			_columnEstatus.ReadOnly = True
			_columnEstatus.Caption = "Estatus"
			Me.Columns.Add(_columnEstatus)

			_columnTotalPiezas = New DataColumn("TotalPiezas", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnTotalPiezas.ReadOnly = True
			_columnTotalPiezas.Caption = "TotalPiezas"
			Me.Columns.Add(_columnTotalPiezas)

			_columnPiezasExistentes = New DataColumn("PiezasExistentes", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnPiezasExistentes.ReadOnly = True
			_columnPiezasExistentes.Caption = "PiezasExistentes"
			Me.Columns.Add(_columnPiezasExistentes)

			_columnPiezasEmbarcadas = New DataColumn("PiezasEmbarcadas", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnPiezasEmbarcadas.ReadOnly = True
			_columnPiezasEmbarcadas.Caption = "PiezasEmbarcadas"
			Me.Columns.Add(_columnPiezasEmbarcadas)

			_columnTotalKilos = New DataColumn("TotalKilos", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnTotalKilos.ReadOnly = True
			_columnTotalKilos.Caption = "TotalKilos"
			Me.Columns.Add(_columnTotalKilos)

			_columnKilosExistentes = New DataColumn("KilosExistentes", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnKilosExistentes.ReadOnly = True
			_columnKilosExistentes.Caption = "KilosExistentes"
			Me.Columns.Add(_columnKilosExistentes)

			_columnKilosEmbarcados = New DataColumn("KilosEmbarcados", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnKilosEmbarcados.ReadOnly = True
			_columnKilosEmbarcados.Caption = "KilosEmbarcados"
			Me.Columns.Add(_columnKilosEmbarcados)

			_columnTotalCajas = New DataColumn("TotalCajas", GetType(System.Int32), Nothing, MappingType.Element)
			_columnTotalCajas.ReadOnly = True
			_columnTotalCajas.Caption = "TotalCajas"
			Me.Columns.Add(_columnTotalCajas)

			_columnCajasExistentes = New DataColumn("CajasExistentes", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCajasExistentes.ReadOnly = True
			_columnCajasExistentes.Caption = "CajasExistentes"
			Me.Columns.Add(_columnCajasExistentes)

			_columnCajasEmbarcadas = New DataColumn("CajasEmbarcadas", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCajasEmbarcadas.ReadOnly = True
			_columnCajasEmbarcadas.Caption = "CajasEmbarcadas"
			Me.Columns.Add(_columnCajasEmbarcadas)

			_columnCajasCanceladas = New DataColumn("CajasCanceladas", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCajasCanceladas.ReadOnly = True
			_columnCajasCanceladas.Caption = "CajasCanceladas"
			Me.Columns.Add(_columnCajasCanceladas)

			_columnCanalesAcorte = New DataColumn("CanalesAcorte", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCanalesAcorte.ReadOnly = True
			_columnCanalesAcorte.Caption = "CanalesAcorte"
			Me.Columns.Add(_columnCanalesAcorte)

			_columnKilosAcorte = New DataColumn("KilosAcorte", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnKilosAcorte.ReadOnly = True
			_columnKilosAcorte.Caption = "KilosAcorte"
			Me.Columns.Add(_columnKilosAcorte)

			_columnPiezasCanceladas = New DataColumn("PiezasCanceladas", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnPiezasCanceladas.ReadOnly = True
			_columnPiezasCanceladas.Caption = "PiezasCanceladas"
			Me.Columns.Add(_columnPiezasCanceladas)

			_columnKilosCancelados = New DataColumn("KilosCancelados", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnKilosCancelados.ReadOnly = True
			_columnKilosCancelados.Caption = "KilosCancelados"
			Me.Columns.Add(_columnKilosCancelados)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnLoteCorte = Me.Columns("LoteCorte")
			_columnLoteSacrificio = Me.Columns("LoteSacrificio")
			_columnFechaCorte = Me.Columns("FechaCorte")
			_columnFechaCad = Me.Columns("FechaCad")
			_columnIdCliente = Me.Columns("IdCliente")
			_columnNombre = Me.Columns("Nombre")
			_columnEstatus = Me.Columns("Estatus")
			_columnTotalPiezas = Me.Columns("TotalPiezas")
			_columnPiezasExistentes = Me.Columns("PiezasExistentes")
			_columnPiezasEmbarcadas = Me.Columns("PiezasEmbarcadas")
			_columnTotalKilos = Me.Columns("TotalKilos")
			_columnKilosExistentes = Me.Columns("KilosExistentes")
			_columnKilosEmbarcados = Me.Columns("KilosEmbarcados")
			_columnTotalCajas = Me.Columns("TotalCajas")
			_columnCajasExistentes = Me.Columns("CajasExistentes")
			_columnCajasEmbarcadas = Me.Columns("CajasEmbarcadas")
			_columnCajasCanceladas = Me.Columns("CajasCanceladas")
			_columnCanalesAcorte = Me.Columns("CanalesAcorte")
			_columnKilosAcorte = Me.Columns("KilosAcorte")
			_columnPiezasCanceladas = Me.Columns("PiezasCanceladas")
			_columnKilosCancelados = Me.Columns("KilosCancelados")
			
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

			_fieldsCustomProperties.Add("LoteCorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("LoteSacrificio", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaCorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("FechaCad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdCliente", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Nombre", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TotalPiezas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PiezasExistentes", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PiezasEmbarcadas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TotalKilos", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("KilosExistentes", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("KilosEmbarcados", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("TotalCajas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CajasExistentes", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CajasEmbarcadas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CajasCanceladas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CanalesAcorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("KilosAcorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PiezasCanceladas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("KilosCancelados", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwProdCortesAgrupadosRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwProdCortesAgrupadosTypedView = CType(MyBase.Clone(), VwProdCortesAgrupadosTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwProdCortesAgrupadosTypedView()
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
				Return VwProdCortesAgrupadosTypedView.CustomProperties
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
				Return VwProdCortesAgrupadosTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwProdCortesAgrupadosRow
			Get 
				Return CType(Me.Rows(index), VwProdCortesAgrupadosRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field LoteCorte
		''' </summary>
		ReadOnly Friend Property LoteCorteColumn As DataColumn
			Get 
				Return _columnLoteCorte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field LoteSacrificio
		''' </summary>
		ReadOnly Friend Property LoteSacrificioColumn As DataColumn
			Get 
				Return _columnLoteSacrificio 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FechaCorte
		''' </summary>
		ReadOnly Friend Property FechaCorteColumn As DataColumn
			Get 
				Return _columnFechaCorte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field FechaCad
		''' </summary>
		ReadOnly Friend Property FechaCadColumn As DataColumn
			Get 
				Return _columnFechaCad 
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
		''' Returns the column Object belonging to the TypedView field Estatus
		''' </summary>
		ReadOnly Friend Property EstatusColumn As DataColumn
			Get 
				Return _columnEstatus 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field TotalPiezas
		''' </summary>
		ReadOnly Friend Property TotalPiezasColumn As DataColumn
			Get 
				Return _columnTotalPiezas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PiezasExistentes
		''' </summary>
		ReadOnly Friend Property PiezasExistentesColumn As DataColumn
			Get 
				Return _columnPiezasExistentes 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PiezasEmbarcadas
		''' </summary>
		ReadOnly Friend Property PiezasEmbarcadasColumn As DataColumn
			Get 
				Return _columnPiezasEmbarcadas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field TotalKilos
		''' </summary>
		ReadOnly Friend Property TotalKilosColumn As DataColumn
			Get 
				Return _columnTotalKilos 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field KilosExistentes
		''' </summary>
		ReadOnly Friend Property KilosExistentesColumn As DataColumn
			Get 
				Return _columnKilosExistentes 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field KilosEmbarcados
		''' </summary>
		ReadOnly Friend Property KilosEmbarcadosColumn As DataColumn
			Get 
				Return _columnKilosEmbarcados 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field TotalCajas
		''' </summary>
		ReadOnly Friend Property TotalCajasColumn As DataColumn
			Get 
				Return _columnTotalCajas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CajasExistentes
		''' </summary>
		ReadOnly Friend Property CajasExistentesColumn As DataColumn
			Get 
				Return _columnCajasExistentes 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CajasEmbarcadas
		''' </summary>
		ReadOnly Friend Property CajasEmbarcadasColumn As DataColumn
			Get 
				Return _columnCajasEmbarcadas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CajasCanceladas
		''' </summary>
		ReadOnly Friend Property CajasCanceladasColumn As DataColumn
			Get 
				Return _columnCajasCanceladas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CanalesAcorte
		''' </summary>
		ReadOnly Friend Property CanalesAcorteColumn As DataColumn
			Get 
				Return _columnCanalesAcorte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field KilosAcorte
		''' </summary>
		ReadOnly Friend Property KilosAcorteColumn As DataColumn
			Get 
				Return _columnKilosAcorte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PiezasCanceladas
		''' </summary>
		ReadOnly Friend Property PiezasCanceladasColumn As DataColumn
			Get 
				Return _columnPiezasCanceladas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field KilosCancelados
		''' </summary>
		ReadOnly Friend Property KilosCanceladosColumn As DataColumn
			Get 
				Return _columnKilosCancelados 
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
	''' Typed datarow for the typed datatable VwProdCortesAgrupados
	''' </summary>
	Public Class VwProdCortesAgrupadosRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwProdCortesAgrupadosTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwProdCortesAgrupadosTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field LoteCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdCortesAgrupados"."LoteCorte"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 10
		''' </remarks>
		Public Property [LoteCorte]() As System.String
			Get 
				If IsLoteCorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.LoteCorteColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.LoteCorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field LoteCorte is NULL, False otherwise.
		''' </summary>
		Public Function IsLoteCorteNull() As Boolean
			Return IsNull(_parent.LoteCorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field LoteCorte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetLoteCorteNull() 
			Me(_parent.LoteCorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field LoteSacrificio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdCortesAgrupados"."LoteSacrificio"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 11
		''' </remarks>
		Public Property [LoteSacrificio]() As System.String
			Get 
				If IsLoteSacrificioNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.LoteSacrificioColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.LoteSacrificioColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field LoteSacrificio is NULL, False otherwise.
		''' </summary>
		Public Function IsLoteSacrificioNull() As Boolean
			Return IsNull(_parent.LoteSacrificioColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field LoteSacrificio to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetLoteSacrificioNull() 
			Me(_parent.LoteSacrificioColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdCortesAgrupados"."FechaCorte"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaCorte]() As System.DateTime
			Get 
				If IsFechaCorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaCorteColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaCorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaCorte is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaCorteNull() As Boolean
			Return IsNull(_parent.FechaCorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaCorte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaCorteNull() 
			Me(_parent.FechaCorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field FechaCad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdCortesAgrupados"."FechaCad"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [FechaCad]() As System.DateTime
			Get 
				If IsFechaCadNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.FechaCadColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.FechaCadColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field FechaCad is NULL, False otherwise.
		''' </summary>
		Public Function IsFechaCadNull() As Boolean
			Return IsNull(_parent.FechaCadColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field FechaCad to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetFechaCadNull() 
			Me(_parent.FechaCadColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdCliente<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdCortesAgrupados"."IdCliente"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 4
		''' </remarks>
		Public Property [IdCliente]() As System.String
			Get 
				If IsIdClienteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.IdClienteColumn), System.String)
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
		''' Mapped on view field: "vwProdCortesAgrupados"."Nombre"<br/>
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
		''' Gets / sets the value of the TypedView field Estatus<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdCortesAgrupados"."Estatus"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 7
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
		''' Gets / sets the value of the TypedView field TotalPiezas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdCortesAgrupados"."TotalPiezas"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [TotalPiezas]() As System.Decimal
			Get 
				If IsTotalPiezasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.TotalPiezasColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.TotalPiezasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TotalPiezas is NULL, False otherwise.
		''' </summary>
		Public Function IsTotalPiezasNull() As Boolean
			Return IsNull(_parent.TotalPiezasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TotalPiezas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTotalPiezasNull() 
			Me(_parent.TotalPiezasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PiezasExistentes<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdCortesAgrupados"."PiezasExistentes"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [PiezasExistentes]() As System.Decimal
			Get 
				If IsPiezasExistentesNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.PiezasExistentesColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.PiezasExistentesColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PiezasExistentes is NULL, False otherwise.
		''' </summary>
		Public Function IsPiezasExistentesNull() As Boolean
			Return IsNull(_parent.PiezasExistentesColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PiezasExistentes to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPiezasExistentesNull() 
			Me(_parent.PiezasExistentesColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PiezasEmbarcadas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdCortesAgrupados"."PiezasEmbarcadas"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [PiezasEmbarcadas]() As System.Decimal
			Get 
				If IsPiezasEmbarcadasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.PiezasEmbarcadasColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.PiezasEmbarcadasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PiezasEmbarcadas is NULL, False otherwise.
		''' </summary>
		Public Function IsPiezasEmbarcadasNull() As Boolean
			Return IsNull(_parent.PiezasEmbarcadasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PiezasEmbarcadas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPiezasEmbarcadasNull() 
			Me(_parent.PiezasEmbarcadasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field TotalKilos<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdCortesAgrupados"."TotalKilos"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [TotalKilos]() As System.Decimal
			Get 
				If IsTotalKilosNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.TotalKilosColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.TotalKilosColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TotalKilos is NULL, False otherwise.
		''' </summary>
		Public Function IsTotalKilosNull() As Boolean
			Return IsNull(_parent.TotalKilosColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TotalKilos to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTotalKilosNull() 
			Me(_parent.TotalKilosColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field KilosExistentes<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdCortesAgrupados"."KilosExistentes"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [KilosExistentes]() As System.Decimal
			Get 
				If IsKilosExistentesNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.KilosExistentesColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.KilosExistentesColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field KilosExistentes is NULL, False otherwise.
		''' </summary>
		Public Function IsKilosExistentesNull() As Boolean
			Return IsNull(_parent.KilosExistentesColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field KilosExistentes to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetKilosExistentesNull() 
			Me(_parent.KilosExistentesColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field KilosEmbarcados<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdCortesAgrupados"."KilosEmbarcados"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [KilosEmbarcados]() As System.Decimal
			Get 
				If IsKilosEmbarcadosNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.KilosEmbarcadosColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.KilosEmbarcadosColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field KilosEmbarcados is NULL, False otherwise.
		''' </summary>
		Public Function IsKilosEmbarcadosNull() As Boolean
			Return IsNull(_parent.KilosEmbarcadosColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field KilosEmbarcados to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetKilosEmbarcadosNull() 
			Me(_parent.KilosEmbarcadosColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field TotalCajas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdCortesAgrupados"."TotalCajas"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [TotalCajas]() As System.Int32
			Get 
				If IsTotalCajasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.TotalCajasColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.TotalCajasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field TotalCajas is NULL, False otherwise.
		''' </summary>
		Public Function IsTotalCajasNull() As Boolean
			Return IsNull(_parent.TotalCajasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field TotalCajas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetTotalCajasNull() 
			Me(_parent.TotalCajasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CajasExistentes<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdCortesAgrupados"."CajasExistentes"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CajasExistentes]() As System.Int32
			Get 
				If IsCajasExistentesNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CajasExistentesColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CajasExistentesColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CajasExistentes is NULL, False otherwise.
		''' </summary>
		Public Function IsCajasExistentesNull() As Boolean
			Return IsNull(_parent.CajasExistentesColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CajasExistentes to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCajasExistentesNull() 
			Me(_parent.CajasExistentesColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CajasEmbarcadas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdCortesAgrupados"."CajasEmbarcadas"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CajasEmbarcadas]() As System.Int32
			Get 
				If IsCajasEmbarcadasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CajasEmbarcadasColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CajasEmbarcadasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CajasEmbarcadas is NULL, False otherwise.
		''' </summary>
		Public Function IsCajasEmbarcadasNull() As Boolean
			Return IsNull(_parent.CajasEmbarcadasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CajasEmbarcadas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCajasEmbarcadasNull() 
			Me(_parent.CajasEmbarcadasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CajasCanceladas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdCortesAgrupados"."CajasCanceladas"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CajasCanceladas]() As System.Int32
			Get 
				If IsCajasCanceladasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CajasCanceladasColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CajasCanceladasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CajasCanceladas is NULL, False otherwise.
		''' </summary>
		Public Function IsCajasCanceladasNull() As Boolean
			Return IsNull(_parent.CajasCanceladasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CajasCanceladas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCajasCanceladasNull() 
			Me(_parent.CajasCanceladasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CanalesAcorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdCortesAgrupados"."CanalesACorte"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CanalesAcorte]() As System.Int32
			Get 
				If IsCanalesAcorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CanalesAcorteColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CanalesAcorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CanalesAcorte is NULL, False otherwise.
		''' </summary>
		Public Function IsCanalesAcorteNull() As Boolean
			Return IsNull(_parent.CanalesAcorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CanalesAcorte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCanalesAcorteNull() 
			Me(_parent.CanalesAcorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field KilosAcorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdCortesAgrupados"."KilosACorte"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [KilosAcorte]() As System.Decimal
			Get 
				If IsKilosAcorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.KilosAcorteColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.KilosAcorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field KilosAcorte is NULL, False otherwise.
		''' </summary>
		Public Function IsKilosAcorteNull() As Boolean
			Return IsNull(_parent.KilosAcorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field KilosAcorte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetKilosAcorteNull() 
			Me(_parent.KilosAcorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PiezasCanceladas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdCortesAgrupados"."PiezasCanceladas"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [PiezasCanceladas]() As System.Decimal
			Get 
				If IsPiezasCanceladasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.PiezasCanceladasColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.PiezasCanceladasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PiezasCanceladas is NULL, False otherwise.
		''' </summary>
		Public Function IsPiezasCanceladasNull() As Boolean
			Return IsNull(_parent.PiezasCanceladasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PiezasCanceladas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPiezasCanceladasNull() 
			Me(_parent.PiezasCanceladasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field KilosCancelados<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdCortesAgrupados"."KilosCancelados"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [KilosCancelados]() As System.Decimal
			Get 
				If IsKilosCanceladosNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.KilosCanceladosColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.KilosCanceladosColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field KilosCancelados is NULL, False otherwise.
		''' </summary>
		Public Function IsKilosCanceladosNull() As Boolean
			Return IsNull(_parent.KilosCanceladosColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field KilosCancelados to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetKilosCanceladosNull() 
			Me(_parent.KilosCanceladosColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
