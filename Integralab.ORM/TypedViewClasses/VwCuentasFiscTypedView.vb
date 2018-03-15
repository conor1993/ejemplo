' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 15 de marzo de 2018 12:00:18
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
	''' Typed datatable for the view 'VwCuentasFisc'.<br/><br/>
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
	Public Class VwCuentasFiscTypedView 
#Else
	Public Class VwCuentasFiscTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnCuentaContable As DataColumn
		Private _columnNombreCuenta As DataColumn
		Private _columnNaturaleza As DataColumn
		Private _columnSaldoAñoAnterior As DataColumn
		Private _columnSaldoInicioEjercicio As DataColumn
		Private _columnAfectable As DataColumn
		Private _columnInactiva As DataColumn
		Private _columnCodigo As DataColumn
		Private _columnNaturalezaCad As DataColumn
		Private _columnBancos As DataColumn
		Private _columnDepartamentalizable As DataColumn
		Private _columnPresupuesto As DataColumn
		Private _columnResultados As DataColumn
		Private _columnCta As DataColumn
		Private _columnSubCta As DataColumn
		Private _columnSsubCta As DataColumn
		Private _columnSssubCta As DataColumn
		Private _columnBancosCad As DataColumn
		Private _columnPresupuestoCad As DataColumn
		Private _columnDepartamentalizableCad As DataColumn
		Private _columnResultadosCad As DataColumn
		Private _columnAfectableCad As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 22
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
			MyBase.New("VwCuentasFisc")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwCuentasFiscTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwCuentasFiscTypedView)
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
			Return New VwCuentasFiscRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnCuentaContable = New DataColumn("CuentaContable", GetType(System.String), Nothing, MappingType.Element)
			_columnCuentaContable.ReadOnly = True
			_columnCuentaContable.Caption = "CuentaContable"
			Me.Columns.Add(_columnCuentaContable)

			_columnNombreCuenta = New DataColumn("NombreCuenta", GetType(System.String), Nothing, MappingType.Element)
			_columnNombreCuenta.ReadOnly = True
			_columnNombreCuenta.Caption = "NombreCuenta"
			Me.Columns.Add(_columnNombreCuenta)

			_columnNaturaleza = New DataColumn("Naturaleza", GetType(System.String), Nothing, MappingType.Element)
			_columnNaturaleza.ReadOnly = True
			_columnNaturaleza.Caption = "Naturaleza"
			Me.Columns.Add(_columnNaturaleza)

			_columnSaldoAñoAnterior = New DataColumn("SaldoAñoAnterior", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnSaldoAñoAnterior.ReadOnly = True
			_columnSaldoAñoAnterior.Caption = "SaldoAñoAnterior"
			Me.Columns.Add(_columnSaldoAñoAnterior)

			_columnSaldoInicioEjercicio = New DataColumn("SaldoInicioEjercicio", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnSaldoInicioEjercicio.ReadOnly = True
			_columnSaldoInicioEjercicio.Caption = "SaldoInicioEjercicio"
			Me.Columns.Add(_columnSaldoInicioEjercicio)

			_columnAfectable = New DataColumn("Afectable", GetType(System.String), Nothing, MappingType.Element)
			_columnAfectable.ReadOnly = True
			_columnAfectable.Caption = "Afectable"
			Me.Columns.Add(_columnAfectable)

			_columnInactiva = New DataColumn("Inactiva", GetType(System.String), Nothing, MappingType.Element)
			_columnInactiva.ReadOnly = True
			_columnInactiva.Caption = "Inactiva"
			Me.Columns.Add(_columnInactiva)

			_columnCodigo = New DataColumn("Codigo", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCodigo.ReadOnly = True
			_columnCodigo.Caption = "Codigo"
			Me.Columns.Add(_columnCodigo)

			_columnNaturalezaCad = New DataColumn("NaturalezaCad", GetType(System.String), Nothing, MappingType.Element)
			_columnNaturalezaCad.ReadOnly = True
			_columnNaturalezaCad.Caption = "NaturalezaCad"
			Me.Columns.Add(_columnNaturalezaCad)

			_columnBancos = New DataColumn("Bancos", GetType(System.String), Nothing, MappingType.Element)
			_columnBancos.ReadOnly = True
			_columnBancos.Caption = "Bancos"
			Me.Columns.Add(_columnBancos)

			_columnDepartamentalizable = New DataColumn("Departamentalizable", GetType(System.String), Nothing, MappingType.Element)
			_columnDepartamentalizable.ReadOnly = True
			_columnDepartamentalizable.Caption = "Departamentalizable"
			Me.Columns.Add(_columnDepartamentalizable)

			_columnPresupuesto = New DataColumn("Presupuesto", GetType(System.String), Nothing, MappingType.Element)
			_columnPresupuesto.ReadOnly = True
			_columnPresupuesto.Caption = "Presupuesto"
			Me.Columns.Add(_columnPresupuesto)

			_columnResultados = New DataColumn("Resultados", GetType(System.String), Nothing, MappingType.Element)
			_columnResultados.ReadOnly = True
			_columnResultados.Caption = "Resultados"
			Me.Columns.Add(_columnResultados)

			_columnCta = New DataColumn("Cta", GetType(System.String), Nothing, MappingType.Element)
			_columnCta.ReadOnly = True
			_columnCta.Caption = "Cta"
			Me.Columns.Add(_columnCta)

			_columnSubCta = New DataColumn("SubCta", GetType(System.String), Nothing, MappingType.Element)
			_columnSubCta.ReadOnly = True
			_columnSubCta.Caption = "SubCta"
			Me.Columns.Add(_columnSubCta)

			_columnSsubCta = New DataColumn("SsubCta", GetType(System.String), Nothing, MappingType.Element)
			_columnSsubCta.ReadOnly = True
			_columnSsubCta.Caption = "SsubCta"
			Me.Columns.Add(_columnSsubCta)

			_columnSssubCta = New DataColumn("SssubCta", GetType(System.String), Nothing, MappingType.Element)
			_columnSssubCta.ReadOnly = True
			_columnSssubCta.Caption = "SssubCta"
			Me.Columns.Add(_columnSssubCta)

			_columnBancosCad = New DataColumn("BancosCad", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnBancosCad.ReadOnly = True
			_columnBancosCad.Caption = "BancosCad"
			Me.Columns.Add(_columnBancosCad)

			_columnPresupuestoCad = New DataColumn("PresupuestoCad", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnPresupuestoCad.ReadOnly = True
			_columnPresupuestoCad.Caption = "PresupuestoCad"
			Me.Columns.Add(_columnPresupuestoCad)

			_columnDepartamentalizableCad = New DataColumn("DepartamentalizableCad", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnDepartamentalizableCad.ReadOnly = True
			_columnDepartamentalizableCad.Caption = "DepartamentalizableCad"
			Me.Columns.Add(_columnDepartamentalizableCad)

			_columnResultadosCad = New DataColumn("ResultadosCad", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnResultadosCad.ReadOnly = True
			_columnResultadosCad.Caption = "ResultadosCad"
			Me.Columns.Add(_columnResultadosCad)

			_columnAfectableCad = New DataColumn("AfectableCad", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnAfectableCad.ReadOnly = True
			_columnAfectableCad.Caption = "AfectableCad"
			Me.Columns.Add(_columnAfectableCad)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnCuentaContable = Me.Columns("CuentaContable")
			_columnNombreCuenta = Me.Columns("NombreCuenta")
			_columnNaturaleza = Me.Columns("Naturaleza")
			_columnSaldoAñoAnterior = Me.Columns("SaldoAñoAnterior")
			_columnSaldoInicioEjercicio = Me.Columns("SaldoInicioEjercicio")
			_columnAfectable = Me.Columns("Afectable")
			_columnInactiva = Me.Columns("Inactiva")
			_columnCodigo = Me.Columns("Codigo")
			_columnNaturalezaCad = Me.Columns("NaturalezaCad")
			_columnBancos = Me.Columns("Bancos")
			_columnDepartamentalizable = Me.Columns("Departamentalizable")
			_columnPresupuesto = Me.Columns("Presupuesto")
			_columnResultados = Me.Columns("Resultados")
			_columnCta = Me.Columns("Cta")
			_columnSubCta = Me.Columns("SubCta")
			_columnSsubCta = Me.Columns("SsubCta")
			_columnSssubCta = Me.Columns("SssubCta")
			_columnBancosCad = Me.Columns("BancosCad")
			_columnPresupuestoCad = Me.Columns("PresupuestoCad")
			_columnDepartamentalizableCad = Me.Columns("DepartamentalizableCad")
			_columnResultadosCad = Me.Columns("ResultadosCad")
			_columnAfectableCad = Me.Columns("AfectableCad")
			
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

			_fieldsCustomProperties.Add("CuentaContable", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("NombreCuenta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Naturaleza", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SaldoAñoAnterior", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SaldoInicioEjercicio", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Afectable", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Inactiva", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Codigo", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("NaturalezaCad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Bancos", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Departamentalizable", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Presupuesto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Resultados", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Cta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SubCta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SsubCta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("SssubCta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("BancosCad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PresupuestoCad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("DepartamentalizableCad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("ResultadosCad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("AfectableCad", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwCuentasFiscRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwCuentasFiscTypedView = CType(MyBase.Clone(), VwCuentasFiscTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwCuentasFiscTypedView()
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
				Return VwCuentasFiscTypedView.CustomProperties
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
				Return VwCuentasFiscTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwCuentasFiscRow
			Get 
				Return CType(Me.Rows(index), VwCuentasFiscRow)
			End Get
		End Property

	
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CuentaContable
		''' </summary>
		ReadOnly Friend Property CuentaContableColumn As DataColumn
			Get 
				Return _columnCuentaContable 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field NombreCuenta
		''' </summary>
		ReadOnly Friend Property NombreCuentaColumn As DataColumn
			Get 
				Return _columnNombreCuenta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Naturaleza
		''' </summary>
		ReadOnly Friend Property NaturalezaColumn As DataColumn
			Get 
				Return _columnNaturaleza 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field SaldoAñoAnterior
		''' </summary>
		ReadOnly Friend Property SaldoAñoAnteriorColumn As DataColumn
			Get 
				Return _columnSaldoAñoAnterior 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field SaldoInicioEjercicio
		''' </summary>
		ReadOnly Friend Property SaldoInicioEjercicioColumn As DataColumn
			Get 
				Return _columnSaldoInicioEjercicio 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Afectable
		''' </summary>
		ReadOnly Friend Property AfectableColumn As DataColumn
			Get 
				Return _columnAfectable 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Inactiva
		''' </summary>
		ReadOnly Friend Property InactivaColumn As DataColumn
			Get 
				Return _columnInactiva 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Codigo
		''' </summary>
		ReadOnly Friend Property CodigoColumn As DataColumn
			Get 
				Return _columnCodigo 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field NaturalezaCad
		''' </summary>
		ReadOnly Friend Property NaturalezaCadColumn As DataColumn
			Get 
				Return _columnNaturalezaCad 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Bancos
		''' </summary>
		ReadOnly Friend Property BancosColumn As DataColumn
			Get 
				Return _columnBancos 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Departamentalizable
		''' </summary>
		ReadOnly Friend Property DepartamentalizableColumn As DataColumn
			Get 
				Return _columnDepartamentalizable 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Presupuesto
		''' </summary>
		ReadOnly Friend Property PresupuestoColumn As DataColumn
			Get 
				Return _columnPresupuesto 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Resultados
		''' </summary>
		ReadOnly Friend Property ResultadosColumn As DataColumn
			Get 
				Return _columnResultados 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Cta
		''' </summary>
		ReadOnly Friend Property CtaColumn As DataColumn
			Get 
				Return _columnCta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field SubCta
		''' </summary>
		ReadOnly Friend Property SubCtaColumn As DataColumn
			Get 
				Return _columnSubCta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field SsubCta
		''' </summary>
		ReadOnly Friend Property SsubCtaColumn As DataColumn
			Get 
				Return _columnSsubCta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field SssubCta
		''' </summary>
		ReadOnly Friend Property SssubCtaColumn As DataColumn
			Get 
				Return _columnSssubCta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field BancosCad
		''' </summary>
		ReadOnly Friend Property BancosCadColumn As DataColumn
			Get 
				Return _columnBancosCad 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PresupuestoCad
		''' </summary>
		ReadOnly Friend Property PresupuestoCadColumn As DataColumn
			Get 
				Return _columnPresupuestoCad 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field DepartamentalizableCad
		''' </summary>
		ReadOnly Friend Property DepartamentalizableCadColumn As DataColumn
			Get 
				Return _columnDepartamentalizableCad 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field ResultadosCad
		''' </summary>
		ReadOnly Friend Property ResultadosCadColumn As DataColumn
			Get 
				Return _columnResultadosCad 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field AfectableCad
		''' </summary>
		ReadOnly Friend Property AfectableCadColumn As DataColumn
			Get 
				Return _columnAfectableCad 
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
	''' Typed datarow for the typed datatable VwCuentasFisc
	''' </summary>
	Public Class VwCuentasFiscRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwCuentasFiscTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwCuentasFiscTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field CuentaContable<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."CuentaContable"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 203
		''' </remarks>
		Public Property [CuentaContable]() As System.String
			Get 
				If IsCuentaContableNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.CuentaContableColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.CuentaContableColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CuentaContable is NULL, False otherwise.
		''' </summary>
		Public Function IsCuentaContableNull() As Boolean
			Return IsNull(_parent.CuentaContableColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CuentaContable to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCuentaContableNull() 
			Me(_parent.CuentaContableColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field NombreCuenta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."NombreCuenta"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
		Public Property [NombreCuenta]() As System.String
			Get 
				If IsNombreCuentaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.NombreCuentaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.NombreCuentaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field NombreCuenta is NULL, False otherwise.
		''' </summary>
		Public Function IsNombreCuentaNull() As Boolean
			Return IsNull(_parent.NombreCuentaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field NombreCuenta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetNombreCuentaNull() 
			Me(_parent.NombreCuentaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Naturaleza<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."Naturaleza"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 10
		''' </remarks>
		Public Property [Naturaleza]() As System.String
			Get 
				If IsNaturalezaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.NaturalezaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.NaturalezaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Naturaleza is NULL, False otherwise.
		''' </summary>
		Public Function IsNaturalezaNull() As Boolean
			Return IsNull(_parent.NaturalezaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Naturaleza to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetNaturalezaNull() 
			Me(_parent.NaturalezaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field SaldoAñoAnterior<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."SaldoAñoAnterior"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [SaldoAñoAnterior]() As System.Decimal
			Get 
				If IsSaldoAñoAnteriorNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.SaldoAñoAnteriorColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.SaldoAñoAnteriorColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field SaldoAñoAnterior is NULL, False otherwise.
		''' </summary>
		Public Function IsSaldoAñoAnteriorNull() As Boolean
			Return IsNull(_parent.SaldoAñoAnteriorColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field SaldoAñoAnterior to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSaldoAñoAnteriorNull() 
			Me(_parent.SaldoAñoAnteriorColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field SaldoInicioEjercicio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."SaldoInicioEjercicio"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [SaldoInicioEjercicio]() As System.Decimal
			Get 
				If IsSaldoInicioEjercicioNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.SaldoInicioEjercicioColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.SaldoInicioEjercicioColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field SaldoInicioEjercicio is NULL, False otherwise.
		''' </summary>
		Public Function IsSaldoInicioEjercicioNull() As Boolean
			Return IsNull(_parent.SaldoInicioEjercicioColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field SaldoInicioEjercicio to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSaldoInicioEjercicioNull() 
			Me(_parent.SaldoInicioEjercicioColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Afectable<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."Afectable"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 2
		''' </remarks>
		Public Property [Afectable]() As System.String
			Get 
				If IsAfectableNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.AfectableColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.AfectableColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Afectable is NULL, False otherwise.
		''' </summary>
		Public Function IsAfectableNull() As Boolean
			Return IsNull(_parent.AfectableColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Afectable to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetAfectableNull() 
			Me(_parent.AfectableColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Inactiva<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."Inactiva"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 2
		''' </remarks>
		Public Property [Inactiva]() As System.String
			Get 
				If IsInactivaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.InactivaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.InactivaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Inactiva is NULL, False otherwise.
		''' </summary>
		Public Function IsInactivaNull() As Boolean
			Return IsNull(_parent.InactivaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Inactiva to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetInactivaNull() 
			Me(_parent.InactivaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Codigo<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."codigo"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [Codigo]() As System.Int32
			Get 
				If IsCodigoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CodigoColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CodigoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Codigo is NULL, False otherwise.
		''' </summary>
		Public Function IsCodigoNull() As Boolean
			Return IsNull(_parent.CodigoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Codigo to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCodigoNull() 
			Me(_parent.CodigoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field NaturalezaCad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."NaturalezaCad"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 1
		''' </remarks>
		Public Property [NaturalezaCad]() As System.String
			Get 
				If IsNaturalezaCadNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.NaturalezaCadColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.NaturalezaCadColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field NaturalezaCad is NULL, False otherwise.
		''' </summary>
		Public Function IsNaturalezaCadNull() As Boolean
			Return IsNull(_parent.NaturalezaCadColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field NaturalezaCad to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetNaturalezaCadNull() 
			Me(_parent.NaturalezaCadColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Bancos<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."Bancos"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 2
		''' </remarks>
		Public Property [Bancos]() As System.String
			Get 
				If IsBancosNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.BancosColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.BancosColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Bancos is NULL, False otherwise.
		''' </summary>
		Public Function IsBancosNull() As Boolean
			Return IsNull(_parent.BancosColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Bancos to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetBancosNull() 
			Me(_parent.BancosColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Departamentalizable<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."Departamentalizable"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 2
		''' </remarks>
		Public Property [Departamentalizable]() As System.String
			Get 
				If IsDepartamentalizableNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.DepartamentalizableColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.DepartamentalizableColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Departamentalizable is NULL, False otherwise.
		''' </summary>
		Public Function IsDepartamentalizableNull() As Boolean
			Return IsNull(_parent.DepartamentalizableColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Departamentalizable to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetDepartamentalizableNull() 
			Me(_parent.DepartamentalizableColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Presupuesto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."Presupuesto"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 2
		''' </remarks>
		Public Property [Presupuesto]() As System.String
			Get 
				If IsPresupuestoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PresupuestoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PresupuestoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Presupuesto is NULL, False otherwise.
		''' </summary>
		Public Function IsPresupuestoNull() As Boolean
			Return IsNull(_parent.PresupuestoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Presupuesto to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPresupuestoNull() 
			Me(_parent.PresupuestoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Resultados<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."Resultados"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 2
		''' </remarks>
		Public Property [Resultados]() As System.String
			Get 
				If IsResultadosNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.ResultadosColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.ResultadosColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Resultados is NULL, False otherwise.
		''' </summary>
		Public Function IsResultadosNull() As Boolean
			Return IsNull(_parent.ResultadosColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Resultados to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetResultadosNull() 
			Me(_parent.ResultadosColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Cta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."Cta"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 50
		''' </remarks>
		Public Property [Cta]() As System.String
			Get 
				If IsCtaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.CtaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.CtaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Cta is NULL, False otherwise.
		''' </summary>
		Public Function IsCtaNull() As Boolean
			Return IsNull(_parent.CtaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Cta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCtaNull() 
			Me(_parent.CtaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field SubCta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."SubCta"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 50
		''' </remarks>
		Public Property [SubCta]() As System.String
			Get 
				If IsSubCtaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.SubCtaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.SubCtaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field SubCta is NULL, False otherwise.
		''' </summary>
		Public Function IsSubCtaNull() As Boolean
			Return IsNull(_parent.SubCtaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field SubCta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSubCtaNull() 
			Me(_parent.SubCtaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field SsubCta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."SSubCta"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 50
		''' </remarks>
		Public Property [SsubCta]() As System.String
			Get 
				If IsSsubCtaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.SsubCtaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.SsubCtaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field SsubCta is NULL, False otherwise.
		''' </summary>
		Public Function IsSsubCtaNull() As Boolean
			Return IsNull(_parent.SsubCtaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field SsubCta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSsubCtaNull() 
			Me(_parent.SsubCtaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field SssubCta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."SSSubCta"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 50
		''' </remarks>
		Public Property [SssubCta]() As System.String
			Get 
				If IsSssubCtaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.SssubCtaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.SssubCtaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field SssubCta is NULL, False otherwise.
		''' </summary>
		Public Function IsSssubCtaNull() As Boolean
			Return IsNull(_parent.SssubCtaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field SssubCta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetSssubCtaNull() 
			Me(_parent.SssubCtaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field BancosCad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."BancosCad"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [BancosCad]() As System.Boolean
			Get 
				If IsBancosCadNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.BancosCadColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.BancosCadColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field BancosCad is NULL, False otherwise.
		''' </summary>
		Public Function IsBancosCadNull() As Boolean
			Return IsNull(_parent.BancosCadColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field BancosCad to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetBancosCadNull() 
			Me(_parent.BancosCadColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PresupuestoCad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."PresupuestoCad"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [PresupuestoCad]() As System.Boolean
			Get 
				If IsPresupuestoCadNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.PresupuestoCadColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.PresupuestoCadColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PresupuestoCad is NULL, False otherwise.
		''' </summary>
		Public Function IsPresupuestoCadNull() As Boolean
			Return IsNull(_parent.PresupuestoCadColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PresupuestoCad to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPresupuestoCadNull() 
			Me(_parent.PresupuestoCadColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field DepartamentalizableCad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."DepartamentalizableCad"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [DepartamentalizableCad]() As System.Boolean
			Get 
				If IsDepartamentalizableCadNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.DepartamentalizableCadColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.DepartamentalizableCadColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field DepartamentalizableCad is NULL, False otherwise.
		''' </summary>
		Public Function IsDepartamentalizableCadNull() As Boolean
			Return IsNull(_parent.DepartamentalizableCadColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field DepartamentalizableCad to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetDepartamentalizableCadNull() 
			Me(_parent.DepartamentalizableCadColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field ResultadosCad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."ResultadosCad"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [ResultadosCad]() As System.Boolean
			Get 
				If IsResultadosCadNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.ResultadosCadColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.ResultadosCadColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field ResultadosCad is NULL, False otherwise.
		''' </summary>
		Public Function IsResultadosCadNull() As Boolean
			Return IsNull(_parent.ResultadosCadColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field ResultadosCad to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetResultadosCadNull() 
			Me(_parent.ResultadosCadColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field AfectableCad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "VwCuentasFisc"."AfectableCad"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [AfectableCad]() As System.Boolean
			Get 
				If IsAfectableCadNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.AfectableCadColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.AfectableCadColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field AfectableCad is NULL, False otherwise.
		''' </summary>
		Public Function IsAfectableCadNull() As Boolean
			Return IsNull(_parent.AfectableCadColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field AfectableCad to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetAfectableCadNull() 
			Me(_parent.AfectableCadColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
