' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 12 de julio de 2018 16:37:53
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
	''' Typed datatable for the view 'VwBusquedaProveedor'.<br/><br/>
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
	Public Class VwBusquedaProveedorTypedView 
#Else
	Public Class VwBusquedaProveedorTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnIdProveedor As DataColumn
		Private _columnPrRfc As DataColumn
		Private _columnPrRazSocial As DataColumn
		Private _columnPrBeneficiario As DataColumn
		Private _columnPrContacto As DataColumn
		Private _columnPrRepLegal As DataColumn
		Private _columnPrEstatus As DataColumn
		Private _columnPrDomicilio As DataColumn
		Private _columnPrColonia As DataColumn
		Private _columnCodigoPostal As DataColumn
		Private _columnIdPoblacion As DataColumn
		Private _columnPrIdUsuarioAlta As DataColumn
		Private _columnPrFechaAlta As DataColumn
		Private _columnPrIdUsuarioBaja As DataColumn
		Private _columnPrFechaBaja As DataColumn
		Private _columnPrIdMotivoBaja As DataColumn
		Private _columnPrObservacionesBaja As DataColumn
		Private _columnPrCuentaContId As DataColumn
		Private _columnPrCuentaAnt As DataColumn
		Private _columnPoblacion As DataColumn
		Private _columnEstatusCad As DataColumn
		Private _columnEsdeGanado As DataColumn
		
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
			MyBase.New("VwBusquedaProveedor")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaProveedorTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwBusquedaProveedorTypedView)
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
			Return New VwBusquedaProveedorRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnIdProveedor = New DataColumn("IdProveedor", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdProveedor.ReadOnly = True
			_columnIdProveedor.Caption = "IdProveedor"
			Me.Columns.Add(_columnIdProveedor)

			_columnPrRfc = New DataColumn("PrRfc", GetType(System.String), Nothing, MappingType.Element)
			_columnPrRfc.ReadOnly = True
			_columnPrRfc.Caption = "PrRfc"
			Me.Columns.Add(_columnPrRfc)

			_columnPrRazSocial = New DataColumn("PrRazSocial", GetType(System.String), Nothing, MappingType.Element)
			_columnPrRazSocial.ReadOnly = True
			_columnPrRazSocial.Caption = "PrRazSocial"
			Me.Columns.Add(_columnPrRazSocial)

			_columnPrBeneficiario = New DataColumn("PrBeneficiario", GetType(System.String), Nothing, MappingType.Element)
			_columnPrBeneficiario.ReadOnly = True
			_columnPrBeneficiario.Caption = "PrBeneficiario"
			Me.Columns.Add(_columnPrBeneficiario)

			_columnPrContacto = New DataColumn("PrContacto", GetType(System.String), Nothing, MappingType.Element)
			_columnPrContacto.ReadOnly = True
			_columnPrContacto.Caption = "PrContacto"
			Me.Columns.Add(_columnPrContacto)

			_columnPrRepLegal = New DataColumn("PrRepLegal", GetType(System.String), Nothing, MappingType.Element)
			_columnPrRepLegal.ReadOnly = True
			_columnPrRepLegal.Caption = "PrRepLegal"
			Me.Columns.Add(_columnPrRepLegal)

			_columnPrEstatus = New DataColumn("PrEstatus", GetType(System.Int16), Nothing, MappingType.Element)
			_columnPrEstatus.ReadOnly = True
			_columnPrEstatus.Caption = "PrEstatus"
			Me.Columns.Add(_columnPrEstatus)

			_columnPrDomicilio = New DataColumn("PrDomicilio", GetType(System.String), Nothing, MappingType.Element)
			_columnPrDomicilio.ReadOnly = True
			_columnPrDomicilio.Caption = "PrDomicilio"
			Me.Columns.Add(_columnPrDomicilio)

			_columnPrColonia = New DataColumn("PrColonia", GetType(System.String), Nothing, MappingType.Element)
			_columnPrColonia.ReadOnly = True
			_columnPrColonia.Caption = "PrColonia"
			Me.Columns.Add(_columnPrColonia)

			_columnCodigoPostal = New DataColumn("CodigoPostal", GetType(System.String), Nothing, MappingType.Element)
			_columnCodigoPostal.ReadOnly = True
			_columnCodigoPostal.Caption = "CodigoPostal"
			Me.Columns.Add(_columnCodigoPostal)

			_columnIdPoblacion = New DataColumn("IdPoblacion", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdPoblacion.ReadOnly = True
			_columnIdPoblacion.Caption = "IdPoblacion"
			Me.Columns.Add(_columnIdPoblacion)

			_columnPrIdUsuarioAlta = New DataColumn("PrIdUsuarioAlta", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPrIdUsuarioAlta.ReadOnly = True
			_columnPrIdUsuarioAlta.Caption = "PrIdUsuarioAlta"
			Me.Columns.Add(_columnPrIdUsuarioAlta)

			_columnPrFechaAlta = New DataColumn("PrFechaAlta", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnPrFechaAlta.ReadOnly = True
			_columnPrFechaAlta.Caption = "PrFechaAlta"
			Me.Columns.Add(_columnPrFechaAlta)

			_columnPrIdUsuarioBaja = New DataColumn("PrIdUsuarioBaja", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPrIdUsuarioBaja.ReadOnly = True
			_columnPrIdUsuarioBaja.Caption = "PrIdUsuarioBaja"
			Me.Columns.Add(_columnPrIdUsuarioBaja)

			_columnPrFechaBaja = New DataColumn("PrFechaBaja", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnPrFechaBaja.ReadOnly = True
			_columnPrFechaBaja.Caption = "PrFechaBaja"
			Me.Columns.Add(_columnPrFechaBaja)

			_columnPrIdMotivoBaja = New DataColumn("PrIdMotivoBaja", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPrIdMotivoBaja.ReadOnly = True
			_columnPrIdMotivoBaja.Caption = "PrIdMotivoBaja"
			Me.Columns.Add(_columnPrIdMotivoBaja)

			_columnPrObservacionesBaja = New DataColumn("PrObservacionesBaja", GetType(System.String), Nothing, MappingType.Element)
			_columnPrObservacionesBaja.ReadOnly = True
			_columnPrObservacionesBaja.Caption = "PrObservacionesBaja"
			Me.Columns.Add(_columnPrObservacionesBaja)

			_columnPrCuentaContId = New DataColumn("PrCuentaContId", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPrCuentaContId.ReadOnly = True
			_columnPrCuentaContId.Caption = "PrCuentaContId"
			Me.Columns.Add(_columnPrCuentaContId)

			_columnPrCuentaAnt = New DataColumn("PrCuentaAnt", GetType(System.Int32), Nothing, MappingType.Element)
			_columnPrCuentaAnt.ReadOnly = True
			_columnPrCuentaAnt.Caption = "PrCuentaAnt"
			Me.Columns.Add(_columnPrCuentaAnt)

			_columnPoblacion = New DataColumn("Poblacion", GetType(System.String), Nothing, MappingType.Element)
			_columnPoblacion.ReadOnly = True
			_columnPoblacion.Caption = "Poblacion"
			Me.Columns.Add(_columnPoblacion)

			_columnEstatusCad = New DataColumn("EstatusCad", GetType(System.String), Nothing, MappingType.Element)
			_columnEstatusCad.ReadOnly = True
			_columnEstatusCad.Caption = "EstatusCad"
			Me.Columns.Add(_columnEstatusCad)

			_columnEsdeGanado = New DataColumn("EsdeGanado", GetType(System.Boolean), Nothing, MappingType.Element)
			_columnEsdeGanado.ReadOnly = True
			_columnEsdeGanado.Caption = "EsdeGanado"
			Me.Columns.Add(_columnEsdeGanado)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnIdProveedor = Me.Columns("IdProveedor")
			_columnPrRfc = Me.Columns("PrRfc")
			_columnPrRazSocial = Me.Columns("PrRazSocial")
			_columnPrBeneficiario = Me.Columns("PrBeneficiario")
			_columnPrContacto = Me.Columns("PrContacto")
			_columnPrRepLegal = Me.Columns("PrRepLegal")
			_columnPrEstatus = Me.Columns("PrEstatus")
			_columnPrDomicilio = Me.Columns("PrDomicilio")
			_columnPrColonia = Me.Columns("PrColonia")
			_columnCodigoPostal = Me.Columns("CodigoPostal")
			_columnIdPoblacion = Me.Columns("IdPoblacion")
			_columnPrIdUsuarioAlta = Me.Columns("PrIdUsuarioAlta")
			_columnPrFechaAlta = Me.Columns("PrFechaAlta")
			_columnPrIdUsuarioBaja = Me.Columns("PrIdUsuarioBaja")
			_columnPrFechaBaja = Me.Columns("PrFechaBaja")
			_columnPrIdMotivoBaja = Me.Columns("PrIdMotivoBaja")
			_columnPrObservacionesBaja = Me.Columns("PrObservacionesBaja")
			_columnPrCuentaContId = Me.Columns("PrCuentaContId")
			_columnPrCuentaAnt = Me.Columns("PrCuentaAnt")
			_columnPoblacion = Me.Columns("Poblacion")
			_columnEstatusCad = Me.Columns("EstatusCad")
			_columnEsdeGanado = Me.Columns("EsdeGanado")
			
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

			_fieldsCustomProperties.Add("IdProveedor", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrRfc", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrRazSocial", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrBeneficiario", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrContacto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrRepLegal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrEstatus", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrDomicilio", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrColonia", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CodigoPostal", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdPoblacion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrIdUsuarioAlta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrFechaAlta", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrIdUsuarioBaja", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrFechaBaja", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrIdMotivoBaja", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrObservacionesBaja", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrCuentaContId", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PrCuentaAnt", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Poblacion", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("EstatusCad", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("EsdeGanado", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwBusquedaProveedorRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwBusquedaProveedorTypedView = CType(MyBase.Clone(), VwBusquedaProveedorTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwBusquedaProveedorTypedView()
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
				Return VwBusquedaProveedorTypedView.CustomProperties
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
				Return VwBusquedaProveedorTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwBusquedaProveedorRow
			Get 
				Return CType(Me.Rows(index), VwBusquedaProveedorRow)
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
		''' Returns the column Object belonging to the TypedView field PrRfc
		''' </summary>
		ReadOnly Friend Property PrRfcColumn As DataColumn
			Get 
				Return _columnPrRfc 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PrRazSocial
		''' </summary>
		ReadOnly Friend Property PrRazSocialColumn As DataColumn
			Get 
				Return _columnPrRazSocial 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PrBeneficiario
		''' </summary>
		ReadOnly Friend Property PrBeneficiarioColumn As DataColumn
			Get 
				Return _columnPrBeneficiario 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PrContacto
		''' </summary>
		ReadOnly Friend Property PrContactoColumn As DataColumn
			Get 
				Return _columnPrContacto 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PrRepLegal
		''' </summary>
		ReadOnly Friend Property PrRepLegalColumn As DataColumn
			Get 
				Return _columnPrRepLegal 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PrEstatus
		''' </summary>
		ReadOnly Friend Property PrEstatusColumn As DataColumn
			Get 
				Return _columnPrEstatus 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PrDomicilio
		''' </summary>
		ReadOnly Friend Property PrDomicilioColumn As DataColumn
			Get 
				Return _columnPrDomicilio 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PrColonia
		''' </summary>
		ReadOnly Friend Property PrColoniaColumn As DataColumn
			Get 
				Return _columnPrColonia 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CodigoPostal
		''' </summary>
		ReadOnly Friend Property CodigoPostalColumn As DataColumn
			Get 
				Return _columnCodigoPostal 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field IdPoblacion
		''' </summary>
		ReadOnly Friend Property IdPoblacionColumn As DataColumn
			Get 
				Return _columnIdPoblacion 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PrIdUsuarioAlta
		''' </summary>
		ReadOnly Friend Property PrIdUsuarioAltaColumn As DataColumn
			Get 
				Return _columnPrIdUsuarioAlta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PrFechaAlta
		''' </summary>
		ReadOnly Friend Property PrFechaAltaColumn As DataColumn
			Get 
				Return _columnPrFechaAlta 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PrIdUsuarioBaja
		''' </summary>
		ReadOnly Friend Property PrIdUsuarioBajaColumn As DataColumn
			Get 
				Return _columnPrIdUsuarioBaja 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PrFechaBaja
		''' </summary>
		ReadOnly Friend Property PrFechaBajaColumn As DataColumn
			Get 
				Return _columnPrFechaBaja 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PrIdMotivoBaja
		''' </summary>
		ReadOnly Friend Property PrIdMotivoBajaColumn As DataColumn
			Get 
				Return _columnPrIdMotivoBaja 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PrObservacionesBaja
		''' </summary>
		ReadOnly Friend Property PrObservacionesBajaColumn As DataColumn
			Get 
				Return _columnPrObservacionesBaja 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PrCuentaContId
		''' </summary>
		ReadOnly Friend Property PrCuentaContIdColumn As DataColumn
			Get 
				Return _columnPrCuentaContId 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PrCuentaAnt
		''' </summary>
		ReadOnly Friend Property PrCuentaAntColumn As DataColumn
			Get 
				Return _columnPrCuentaAnt 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field Poblacion
		''' </summary>
		ReadOnly Friend Property PoblacionColumn As DataColumn
			Get 
				Return _columnPoblacion 
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
		''' Returns the column Object belonging to the TypedView field EsdeGanado
		''' </summary>
		ReadOnly Friend Property EsdeGanadoColumn As DataColumn
			Get 
				Return _columnEsdeGanado 
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
	''' Typed datarow for the typed datatable VwBusquedaProveedor
	''' </summary>
	Public Class VwBusquedaProveedorRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwBusquedaProveedorTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwBusquedaProveedorTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field IdProveedor<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."IdProveedor"<br/>
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
		''' Gets / sets the value of the TypedView field PrRfc<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."PrRFC"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 15
		''' </remarks>
		Public Property [PrRfc]() As System.String
			Get 
				If IsPrRfcNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PrRfcColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PrRfcColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PrRfc is NULL, False otherwise.
		''' </summary>
		Public Function IsPrRfcNull() As Boolean
			Return IsNull(_parent.PrRfcColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PrRfc to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrRfcNull() 
			Me(_parent.PrRfcColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PrRazSocial<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."PrRazSocial"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 150
		''' </remarks>
		Public Property [PrRazSocial]() As System.String
			Get 
				If IsPrRazSocialNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PrRazSocialColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PrRazSocialColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PrRazSocial is NULL, False otherwise.
		''' </summary>
		Public Function IsPrRazSocialNull() As Boolean
			Return IsNull(_parent.PrRazSocialColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PrRazSocial to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrRazSocialNull() 
			Me(_parent.PrRazSocialColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PrBeneficiario<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."PrBeneficiario"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 150
		''' </remarks>
		Public Property [PrBeneficiario]() As System.String
			Get 
				If IsPrBeneficiarioNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PrBeneficiarioColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PrBeneficiarioColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PrBeneficiario is NULL, False otherwise.
		''' </summary>
		Public Function IsPrBeneficiarioNull() As Boolean
			Return IsNull(_parent.PrBeneficiarioColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PrBeneficiario to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrBeneficiarioNull() 
			Me(_parent.PrBeneficiarioColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PrContacto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."PrContacto"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 150
		''' </remarks>
		Public Property [PrContacto]() As System.String
			Get 
				If IsPrContactoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PrContactoColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PrContactoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PrContacto is NULL, False otherwise.
		''' </summary>
		Public Function IsPrContactoNull() As Boolean
			Return IsNull(_parent.PrContactoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PrContacto to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrContactoNull() 
			Me(_parent.PrContactoColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PrRepLegal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."PrRepLegal"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 150
		''' </remarks>
		Public Property [PrRepLegal]() As System.String
			Get 
				If IsPrRepLegalNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PrRepLegalColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PrRepLegalColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PrRepLegal is NULL, False otherwise.
		''' </summary>
		Public Function IsPrRepLegalNull() As Boolean
			Return IsNull(_parent.PrRepLegalColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PrRepLegal to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrRepLegalNull() 
			Me(_parent.PrRepLegalColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PrEstatus<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."PrEstatus"<br/>
		''' View field characteristics (type, precision, scale, length): SmallInt, 5, 0, 0
		''' </remarks>
		Public Property [PrEstatus]() As System.Int16
			Get 
				If IsPrEstatusNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int16)), System.Int16)
				Else
					Return CType(Me(_parent.PrEstatusColumn), System.Int16)
				End If
			End Get
			Set 
				Me(_parent.PrEstatusColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PrEstatus is NULL, False otherwise.
		''' </summary>
		Public Function IsPrEstatusNull() As Boolean
			Return IsNull(_parent.PrEstatusColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PrEstatus to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrEstatusNull() 
			Me(_parent.PrEstatusColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PrDomicilio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."PrDomicilio"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
		Public Property [PrDomicilio]() As System.String
			Get 
				If IsPrDomicilioNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PrDomicilioColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PrDomicilioColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PrDomicilio is NULL, False otherwise.
		''' </summary>
		Public Function IsPrDomicilioNull() As Boolean
			Return IsNull(_parent.PrDomicilioColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PrDomicilio to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrDomicilioNull() 
			Me(_parent.PrDomicilioColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PrColonia<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."PrColonia"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 50
		''' </remarks>
		Public Property [PrColonia]() As System.String
			Get 
				If IsPrColoniaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PrColoniaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PrColoniaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PrColonia is NULL, False otherwise.
		''' </summary>
		Public Function IsPrColoniaNull() As Boolean
			Return IsNull(_parent.PrColoniaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PrColonia to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrColoniaNull() 
			Me(_parent.PrColoniaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CodigoPostal<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."CodigoPostal"<br/>
		''' View field characteristics (type, precision, scale, length): Char, 0, 0, 5
		''' </remarks>
		Public Property [CodigoPostal]() As System.String
			Get 
				If IsCodigoPostalNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.CodigoPostalColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.CodigoPostalColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CodigoPostal is NULL, False otherwise.
		''' </summary>
		Public Function IsCodigoPostalNull() As Boolean
			Return IsNull(_parent.CodigoPostalColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CodigoPostal to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCodigoPostalNull() 
			Me(_parent.CodigoPostalColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field IdPoblacion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."IdPoblacion"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [IdPoblacion]() As System.Int32
			Get 
				If IsIdPoblacionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.IdPoblacionColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.IdPoblacionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field IdPoblacion is NULL, False otherwise.
		''' </summary>
		Public Function IsIdPoblacionNull() As Boolean
			Return IsNull(_parent.IdPoblacionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field IdPoblacion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetIdPoblacionNull() 
			Me(_parent.IdPoblacionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PrIdUsuarioAlta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."PrIdUsuarioAlta"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PrIdUsuarioAlta]() As System.Int32
			Get 
				If IsPrIdUsuarioAltaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PrIdUsuarioAltaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PrIdUsuarioAltaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PrIdUsuarioAlta is NULL, False otherwise.
		''' </summary>
		Public Function IsPrIdUsuarioAltaNull() As Boolean
			Return IsNull(_parent.PrIdUsuarioAltaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PrIdUsuarioAlta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrIdUsuarioAltaNull() 
			Me(_parent.PrIdUsuarioAltaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PrFechaAlta<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."PrFechaAlta"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [PrFechaAlta]() As System.DateTime
			Get 
				If IsPrFechaAltaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.PrFechaAltaColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.PrFechaAltaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PrFechaAlta is NULL, False otherwise.
		''' </summary>
		Public Function IsPrFechaAltaNull() As Boolean
			Return IsNull(_parent.PrFechaAltaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PrFechaAlta to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrFechaAltaNull() 
			Me(_parent.PrFechaAltaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PrIdUsuarioBaja<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."PrIdUsuarioBaja"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PrIdUsuarioBaja]() As System.Int32
			Get 
				If IsPrIdUsuarioBajaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PrIdUsuarioBajaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PrIdUsuarioBajaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PrIdUsuarioBaja is NULL, False otherwise.
		''' </summary>
		Public Function IsPrIdUsuarioBajaNull() As Boolean
			Return IsNull(_parent.PrIdUsuarioBajaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PrIdUsuarioBaja to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrIdUsuarioBajaNull() 
			Me(_parent.PrIdUsuarioBajaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PrFechaBaja<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."PrFechaBaja"<br/>
		''' View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0
		''' </remarks>
		Public Property [PrFechaBaja]() As System.DateTime
			Get 
				If IsPrFechaBajaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.DateTime)), System.DateTime)
				Else
					Return CType(Me(_parent.PrFechaBajaColumn), System.DateTime)
				End If
			End Get
			Set 
				Me(_parent.PrFechaBajaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PrFechaBaja is NULL, False otherwise.
		''' </summary>
		Public Function IsPrFechaBajaNull() As Boolean
			Return IsNull(_parent.PrFechaBajaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PrFechaBaja to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrFechaBajaNull() 
			Me(_parent.PrFechaBajaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PrIdMotivoBaja<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."PrIdMotivoBaja"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PrIdMotivoBaja]() As System.Int32
			Get 
				If IsPrIdMotivoBajaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PrIdMotivoBajaColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PrIdMotivoBajaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PrIdMotivoBaja is NULL, False otherwise.
		''' </summary>
		Public Function IsPrIdMotivoBajaNull() As Boolean
			Return IsNull(_parent.PrIdMotivoBajaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PrIdMotivoBaja to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrIdMotivoBajaNull() 
			Me(_parent.PrIdMotivoBajaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PrObservacionesBaja<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."PrObservacionesBaja"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 250
		''' </remarks>
		Public Property [PrObservacionesBaja]() As System.String
			Get 
				If IsPrObservacionesBajaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PrObservacionesBajaColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PrObservacionesBajaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PrObservacionesBaja is NULL, False otherwise.
		''' </summary>
		Public Function IsPrObservacionesBajaNull() As Boolean
			Return IsNull(_parent.PrObservacionesBajaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PrObservacionesBaja to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrObservacionesBajaNull() 
			Me(_parent.PrObservacionesBajaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PrCuentaContId<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."PrCuentaContId"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PrCuentaContId]() As System.Int32
			Get 
				If IsPrCuentaContIdNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PrCuentaContIdColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PrCuentaContIdColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PrCuentaContId is NULL, False otherwise.
		''' </summary>
		Public Function IsPrCuentaContIdNull() As Boolean
			Return IsNull(_parent.PrCuentaContIdColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PrCuentaContId to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrCuentaContIdNull() 
			Me(_parent.PrCuentaContIdColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PrCuentaAnt<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."PrCuentaAnt"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [PrCuentaAnt]() As System.Int32
			Get 
				If IsPrCuentaAntNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.PrCuentaAntColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.PrCuentaAntColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PrCuentaAnt is NULL, False otherwise.
		''' </summary>
		Public Function IsPrCuentaAntNull() As Boolean
			Return IsNull(_parent.PrCuentaAntColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PrCuentaAnt to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPrCuentaAntNull() 
			Me(_parent.PrCuentaAntColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Poblacion<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."Poblacion"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 80
		''' </remarks>
		Public Property [Poblacion]() As System.String
			Get 
				If IsPoblacionNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.PoblacionColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.PoblacionColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Poblacion is NULL, False otherwise.
		''' </summary>
		Public Function IsPoblacionNull() As Boolean
			Return IsNull(_parent.PoblacionColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Poblacion to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPoblacionNull() 
			Me(_parent.PoblacionColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field EstatusCad<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."EstatusCad"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 8
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
		''' Gets / sets the value of the TypedView field EsdeGanado<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwBusquedaProveedor"."EsdeGanado"<br/>
		''' View field characteristics (type, precision, scale, length): Bit, 0, 0, 0
		''' </remarks>
		Public Property [EsdeGanado]() As System.Boolean
			Get 
				If IsEsdeGanadoNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Boolean)), System.Boolean)
				Else
					Return CType(Me(_parent.EsdeGanadoColumn), System.Boolean)
				End If
			End Get
			Set 
				Me(_parent.EsdeGanadoColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field EsdeGanado is NULL, False otherwise.
		''' </summary>
		Public Function IsEsdeGanadoNull() As Boolean
			Return IsNull(_parent.EsdeGanadoColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field EsdeGanado to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetEsdeGanadoNull() 
			Me(_parent.EsdeGanadoColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
