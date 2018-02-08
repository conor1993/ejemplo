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
	''' Typed datatable for the view 'VwProdRendimientosCortes'.<br/><br/>
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
	Public Class VwProdRendimientosCortesTypedView 
#Else
	Public Class VwProdRendimientosCortesTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnFolioSacrificio As DataColumn
		Private _columnFechaSacrificio As DataColumn
		Private _columnIdCodCliente As DataColumn
		Private _columnNombre As DataColumn
		Private _columnPorcientoEnviadoaCorte As DataColumn
		Private _columnKilosAcorte As DataColumn
		Private _columnCanalesAcorte As DataColumn
		Private _columnIdProducto As DataColumn
		Private _columnCorte As DataColumn
		Private _columnPiezas As DataColumn
		Private _columnKilos As DataColumn
		Private _columnRendimientoPorCorte As DataColumn
		Private _columnRendimientoPorPiezas As DataColumn
		Private _columnPiezasProducidas As DataColumn
		
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
			MyBase.New("VwProdRendimientosCortes")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwProdRendimientosCortesTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwProdRendimientosCortesTypedView)
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
			Return New VwProdRendimientosCortesRow(rowBuilder)
		End Function


		''' <summary>
		''' Initialize the datastructures.
		''' </summary>
		Private Sub InitClass()
			
			_columnFolioSacrificio = New DataColumn("FolioSacrificio", GetType(System.String), Nothing, MappingType.Element)
			_columnFolioSacrificio.ReadOnly = True
			_columnFolioSacrificio.Caption = "FolioSacrificio"
			Me.Columns.Add(_columnFolioSacrificio)

			_columnFechaSacrificio = New DataColumn("FechaSacrificio", GetType(System.DateTime), Nothing, MappingType.Element)
			_columnFechaSacrificio.ReadOnly = True
			_columnFechaSacrificio.Caption = "FechaSacrificio"
			Me.Columns.Add(_columnFechaSacrificio)

			_columnIdCodCliente = New DataColumn("IdCodCliente", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdCodCliente.ReadOnly = True
			_columnIdCodCliente.Caption = "IdCodCliente"
			Me.Columns.Add(_columnIdCodCliente)

			_columnNombre = New DataColumn("Nombre", GetType(System.String), Nothing, MappingType.Element)
			_columnNombre.ReadOnly = True
			_columnNombre.Caption = "Nombre"
			Me.Columns.Add(_columnNombre)

			_columnPorcientoEnviadoaCorte = New DataColumn("PorcientoEnviadoaCorte", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnPorcientoEnviadoaCorte.ReadOnly = True
			_columnPorcientoEnviadoaCorte.Caption = "PorcientoEnviadoaCorte"
			Me.Columns.Add(_columnPorcientoEnviadoaCorte)

			_columnKilosAcorte = New DataColumn("KilosAcorte", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnKilosAcorte.ReadOnly = True
			_columnKilosAcorte.Caption = "KilosAcorte"
			Me.Columns.Add(_columnKilosAcorte)

			_columnCanalesAcorte = New DataColumn("CanalesAcorte", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCanalesAcorte.ReadOnly = True
			_columnCanalesAcorte.Caption = "CanalesAcorte"
			Me.Columns.Add(_columnCanalesAcorte)

			_columnIdProducto = New DataColumn("IdProducto", GetType(System.Int32), Nothing, MappingType.Element)
			_columnIdProducto.ReadOnly = True
			_columnIdProducto.Caption = "IdProducto"
			Me.Columns.Add(_columnIdProducto)

			_columnCorte = New DataColumn("Corte", GetType(System.String), Nothing, MappingType.Element)
			_columnCorte.ReadOnly = True
			_columnCorte.Caption = "Corte"
			Me.Columns.Add(_columnCorte)

			_columnPiezas = New DataColumn("Piezas", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnPiezas.ReadOnly = True
			_columnPiezas.Caption = "Piezas"
			Me.Columns.Add(_columnPiezas)

			_columnKilos = New DataColumn("Kilos", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnKilos.ReadOnly = True
			_columnKilos.Caption = "Kilos"
			Me.Columns.Add(_columnKilos)

			_columnRendimientoPorCorte = New DataColumn("RendimientoPorCorte", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnRendimientoPorCorte.ReadOnly = True
			_columnRendimientoPorCorte.Caption = "RendimientoPorCorte"
			Me.Columns.Add(_columnRendimientoPorCorte)

			_columnRendimientoPorPiezas = New DataColumn("RendimientoPorPiezas", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnRendimientoPorPiezas.ReadOnly = True
			_columnRendimientoPorPiezas.Caption = "RendimientoPorPiezas"
			Me.Columns.Add(_columnRendimientoPorPiezas)

			_columnPiezasProducidas = New DataColumn("PiezasProducidas", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnPiezasProducidas.ReadOnly = True
			_columnPiezasProducidas.Caption = "PiezasProducidas"
			Me.Columns.Add(_columnPiezasProducidas)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnFolioSacrificio = Me.Columns("FolioSacrificio")
			_columnFechaSacrificio = Me.Columns("FechaSacrificio")
			_columnIdCodCliente = Me.Columns("IdCodCliente")
			_columnNombre = Me.Columns("Nombre")
			_columnPorcientoEnviadoaCorte = Me.Columns("PorcientoEnviadoaCorte")
			_columnKilosAcorte = Me.Columns("KilosAcorte")
			_columnCanalesAcorte = Me.Columns("CanalesAcorte")
			_columnIdProducto = Me.Columns("IdProducto")
			_columnCorte = Me.Columns("Corte")
			_columnPiezas = Me.Columns("Piezas")
			_columnKilos = Me.Columns("Kilos")
			_columnRendimientoPorCorte = Me.Columns("RendimientoPorCorte")
			_columnRendimientoPorPiezas = Me.Columns("RendimientoPorPiezas")
			_columnPiezasProducidas = Me.Columns("PiezasProducidas")
			
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

			_fieldsCustomProperties.Add("FechaSacrificio", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdCodCliente", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Nombre", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PorcientoEnviadoaCorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("KilosAcorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CanalesAcorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("IdProducto", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Corte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Piezas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Kilos", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("RendimientoPorCorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("RendimientoPorPiezas", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("PiezasProducidas", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwProdRendimientosCortesRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwProdRendimientosCortesTypedView = CType(MyBase.Clone(), VwProdRendimientosCortesTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwProdRendimientosCortesTypedView()
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
				Return VwProdRendimientosCortesTypedView.CustomProperties
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
				Return VwProdRendimientosCortesTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwProdRendimientosCortesRow
			Get 
				Return CType(Me.Rows(index), VwProdRendimientosCortesRow)
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
		''' Returns the column Object belonging to the TypedView field FechaSacrificio
		''' </summary>
		ReadOnly Friend Property FechaSacrificioColumn As DataColumn
			Get 
				Return _columnFechaSacrificio 
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
		''' Returns the column Object belonging to the TypedView field Nombre
		''' </summary>
		ReadOnly Friend Property NombreColumn As DataColumn
			Get 
				Return _columnNombre 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PorcientoEnviadoaCorte
		''' </summary>
		ReadOnly Friend Property PorcientoEnviadoaCorteColumn As DataColumn
			Get 
				Return _columnPorcientoEnviadoaCorte 
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
		''' Returns the column Object belonging to the TypedView field CanalesAcorte
		''' </summary>
		ReadOnly Friend Property CanalesAcorteColumn As DataColumn
			Get 
				Return _columnCanalesAcorte 
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
		''' Returns the column Object belonging to the TypedView field Corte
		''' </summary>
		ReadOnly Friend Property CorteColumn As DataColumn
			Get 
				Return _columnCorte 
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
		''' Returns the column Object belonging to the TypedView field RendimientoPorCorte
		''' </summary>
		ReadOnly Friend Property RendimientoPorCorteColumn As DataColumn
			Get 
				Return _columnRendimientoPorCorte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field RendimientoPorPiezas
		''' </summary>
		ReadOnly Friend Property RendimientoPorPiezasColumn As DataColumn
			Get 
				Return _columnRendimientoPorPiezas 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field PiezasProducidas
		''' </summary>
		ReadOnly Friend Property PiezasProducidasColumn As DataColumn
			Get 
				Return _columnPiezasProducidas 
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
	''' Typed datarow for the typed datatable VwProdRendimientosCortes
	''' </summary>
	Public Class VwProdRendimientosCortesRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwProdRendimientosCortesTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwProdRendimientosCortesTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field FolioSacrificio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRendimientosCortes"."FolioSacrificio"<br/>
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
		''' Gets / sets the value of the TypedView field FechaSacrificio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRendimientosCortes"."FechaSacrificio"<br/>
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
		''' Gets / sets the value of the TypedView field IdCodCliente<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRendimientosCortes"."IdCodCliente"<br/>
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
		''' Gets / sets the value of the TypedView field Nombre<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRendimientosCortes"."Nombre"<br/>
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
		''' Gets / sets the value of the TypedView field PorcientoEnviadoaCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRendimientosCortes"."PorcientoEnviadoaCorte"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [PorcientoEnviadoaCorte]() As System.Decimal
			Get 
				If IsPorcientoEnviadoaCorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.PorcientoEnviadoaCorteColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.PorcientoEnviadoaCorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PorcientoEnviadoaCorte is NULL, False otherwise.
		''' </summary>
		Public Function IsPorcientoEnviadoaCorteNull() As Boolean
			Return IsNull(_parent.PorcientoEnviadoaCorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PorcientoEnviadoaCorte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPorcientoEnviadoaCorteNull() 
			Me(_parent.PorcientoEnviadoaCorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field KilosAcorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRendimientosCortes"."KilosACorte"<br/>
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
		''' Gets / sets the value of the TypedView field CanalesAcorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRendimientosCortes"."CanalesACorte"<br/>
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
		''' Gets / sets the value of the TypedView field IdProducto<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRendimientosCortes"."IdProducto"<br/>
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
		''' Gets / sets the value of the TypedView field Corte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRendimientosCortes"."Corte"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 100
		''' </remarks>
		Public Property [Corte]() As System.String
			Get 
				If IsCorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.String)), System.String)
				Else
					Return CType(Me(_parent.CorteColumn), System.String)
				End If
			End Get
			Set 
				Me(_parent.CorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field Corte is NULL, False otherwise.
		''' </summary>
		Public Function IsCorteNull() As Boolean
			Return IsNull(_parent.CorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field Corte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCorteNull() 
			Me(_parent.CorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Piezas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRendimientosCortes"."Piezas"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [Piezas]() As System.Decimal
			Get 
				If IsPiezasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.PiezasColumn), System.Decimal)
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
		''' Mapped on view field: "vwProdRendimientosCortes"."Kilos"<br/>
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
		''' Gets / sets the value of the TypedView field RendimientoPorCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRendimientosCortes"."RendimientoPorCorte"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [RendimientoPorCorte]() As System.Decimal
			Get 
				If IsRendimientoPorCorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.RendimientoPorCorteColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.RendimientoPorCorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field RendimientoPorCorte is NULL, False otherwise.
		''' </summary>
		Public Function IsRendimientoPorCorteNull() As Boolean
			Return IsNull(_parent.RendimientoPorCorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field RendimientoPorCorte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetRendimientoPorCorteNull() 
			Me(_parent.RendimientoPorCorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field RendimientoPorPiezas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRendimientosCortes"."RendimientoPorPiezas"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [RendimientoPorPiezas]() As System.Decimal
			Get 
				If IsRendimientoPorPiezasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.RendimientoPorPiezasColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.RendimientoPorPiezasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field RendimientoPorPiezas is NULL, False otherwise.
		''' </summary>
		Public Function IsRendimientoPorPiezasNull() As Boolean
			Return IsNull(_parent.RendimientoPorPiezasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field RendimientoPorPiezas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetRendimientoPorPiezasNull() 
			Me(_parent.RendimientoPorPiezasColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field PiezasProducidas<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRendimientosCortes"."PiezasProducidas"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [PiezasProducidas]() As System.Decimal
			Get 
				If IsPiezasProducidasNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.PiezasProducidasColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.PiezasProducidasColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field PiezasProducidas is NULL, False otherwise.
		''' </summary>
		Public Function IsPiezasProducidasNull() As Boolean
			Return IsNull(_parent.PiezasProducidasColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field PiezasProducidas to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetPiezasProducidasNull() 
			Me(_parent.PiezasProducidasColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
