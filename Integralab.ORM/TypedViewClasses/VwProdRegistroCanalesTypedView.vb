﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 12 de julio de 2018 17:43:14
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
	''' Typed datatable for the view 'VwProdRegistroCanales'.<br/><br/>
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
	Public Class VwProdRegistroCanalesTypedView 
#Else
	Public Class VwProdRegistroCanalesTypedView 
#End If	
		Inherits DataTable
		Implements IEnumerable, ITypedView
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		' __LLBLGENPRO_USER_CODE_REGION_END	
	
#Region "Class Member Declarations"
		Private _columnFolioSacrificio As DataColumn
		Private _columnFechaSacrificio As DataColumn
		Private _columnCantCanales As DataColumn
		Private _columnEstatus As DataColumn
		Private _columnKgrsBascula As DataColumn
		Private _columnCanalesEnCorte As DataColumn
		Private _columnKilosEnCorte As DataColumn
		Private _columnCanalesEnEmbarque As DataColumn
		Private _columnKilosEnEmbarque As DataColumn
		
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
		Private Shared _customProperties As Hashtable
		Private Shared _fieldsCustomProperties As Hashtable
#End Region

#Region "Class Constants"
		''' <summary>
		''' The amount of fields in the resultset.
		''' </summary>
		Private Const AmountOfFields As Integer = 9
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
			MyBase.New("VwProdRegistroCanales")
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
			Return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwProdRegistroCanalesTypedView)
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
			Dim fieldsInResultset As IEntityFields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.VwProdRegistroCanalesTypedView)
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
			Return New VwProdRegistroCanalesRow(rowBuilder)
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

			_columnCantCanales = New DataColumn("CantCanales", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCantCanales.ReadOnly = True
			_columnCantCanales.Caption = "CantCanales"
			Me.Columns.Add(_columnCantCanales)

			_columnEstatus = New DataColumn("Estatus", GetType(System.String), Nothing, MappingType.Element)
			_columnEstatus.ReadOnly = True
			_columnEstatus.Caption = "Estatus"
			Me.Columns.Add(_columnEstatus)

			_columnKgrsBascula = New DataColumn("KgrsBascula", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnKgrsBascula.ReadOnly = True
			_columnKgrsBascula.Caption = "KgrsBascula"
			Me.Columns.Add(_columnKgrsBascula)

			_columnCanalesEnCorte = New DataColumn("CanalesEnCorte", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCanalesEnCorte.ReadOnly = True
			_columnCanalesEnCorte.Caption = "CanalesEnCorte"
			Me.Columns.Add(_columnCanalesEnCorte)

			_columnKilosEnCorte = New DataColumn("KilosEnCorte", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnKilosEnCorte.ReadOnly = True
			_columnKilosEnCorte.Caption = "KilosEnCorte"
			Me.Columns.Add(_columnKilosEnCorte)

			_columnCanalesEnEmbarque = New DataColumn("CanalesEnEmbarque", GetType(System.Int32), Nothing, MappingType.Element)
			_columnCanalesEnEmbarque.ReadOnly = True
			_columnCanalesEnEmbarque.Caption = "CanalesEnEmbarque"
			Me.Columns.Add(_columnCanalesEnEmbarque)

			_columnKilosEnEmbarque = New DataColumn("KilosEnEmbarque", GetType(System.Decimal), Nothing, MappingType.Element)
			_columnKilosEnEmbarque.ReadOnly = True
			_columnKilosEnEmbarque.Caption = "KilosEnEmbarque"
			Me.Columns.Add(_columnKilosEnEmbarque)
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClass
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary>
		''' Initializes the members, after a clone action.
		''' </summary>
		Private Sub InitMembers()
			_columnFolioSacrificio = Me.Columns("FolioSacrificio")
			_columnFechaSacrificio = Me.Columns("FechaSacrificio")
			_columnCantCanales = Me.Columns("CantCanales")
			_columnEstatus = Me.Columns("Estatus")
			_columnKgrsBascula = Me.Columns("KgrsBascula")
			_columnCanalesEnCorte = Me.Columns("CanalesEnCorte")
			_columnKilosEnCorte = Me.Columns("KilosEnCorte")
			_columnCanalesEnEmbarque = Me.Columns("CanalesEnEmbarque")
			_columnKilosEnEmbarque = Me.Columns("KilosEnEmbarque")
			
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

			_fieldsCustomProperties.Add("CantCanales", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("KgrsBascula", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CanalesEnCorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("KilosEnCorte", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("CanalesEnEmbarque", fieldHashtable)
			
			fieldHashtable = New Hashtable()

			_fieldsCustomProperties.Add("KilosEnEmbarque", fieldHashtable)
			
		End Sub


		''' <summary>
		''' Return the type of the typed datarow
		''' </summary>
		''' <returns>returns the requested type</returns>
		Protected Overrides Function GetRowType() As Type
			Return GetType(VwProdRegistroCanalesRow)
		End Function


		''' <summary>
		''' Clones this instance.
		''' </summary>
		''' <returns>A clone of this instance</returns>
		Public Overrides Function Clone() As DataTable
			Dim cloneToReturn As VwProdRegistroCanalesTypedView = CType(MyBase.Clone(), VwProdRegistroCanalesTypedView)
			cloneToReturn.InitMembers()
			Return cloneToReturn
		End Function

#If Not CF Then
		''' <summary>
		''' Creates a new instance of the DataTable class.
		''' </summary>
		''' <returns>a new instance of a datatable with this schema.</returns>
		Protected Overrides Function CreateInstance() As DataTable
			Return New VwProdRegistroCanalesTypedView()
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
				Return VwProdRegistroCanalesTypedView.CustomProperties
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
				Return VwProdRegistroCanalesTypedView.FieldsCustomProperties
			End Get
		End Property

		''' <summary>
		''' Indexer of this strong typed view
		''' </summary>
		Default ReadOnly Public Property  Item(index As Integer) As VwProdRegistroCanalesRow
			Get 
				Return CType(Me.Rows(index), VwProdRegistroCanalesRow)
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
		''' Returns the column Object belonging to the TypedView field CantCanales
		''' </summary>
		ReadOnly Friend Property CantCanalesColumn As DataColumn
			Get 
				Return _columnCantCanales 
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
		''' Returns the column Object belonging to the TypedView field KgrsBascula
		''' </summary>
		ReadOnly Friend Property KgrsBasculaColumn As DataColumn
			Get 
				Return _columnKgrsBascula 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CanalesEnCorte
		''' </summary>
		ReadOnly Friend Property CanalesEnCorteColumn As DataColumn
			Get 
				Return _columnCanalesEnCorte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field KilosEnCorte
		''' </summary>
		ReadOnly Friend Property KilosEnCorteColumn As DataColumn
			Get 
				Return _columnKilosEnCorte 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field CanalesEnEmbarque
		''' </summary>
		ReadOnly Friend Property CanalesEnEmbarqueColumn As DataColumn
			Get 
				Return _columnCanalesEnEmbarque 
			End Get
		End Property
    
		''' <summary>
		''' Returns the column Object belonging to the TypedView field KilosEnEmbarque
		''' </summary>
		ReadOnly Friend Property KilosEnEmbarqueColumn As DataColumn
			Get 
				Return _columnKilosEnEmbarque 
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
	''' Typed datarow for the typed datatable VwProdRegistroCanales
	''' </summary>
	Public Class VwProdRegistroCanalesRow 
		Inherits DataRow
		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		' __LLBLGENPRO_USER_CODE_REGION_END	


#Region "Class Member Declarations"
		Private _parent As VwProdRegistroCanalesTypedView
#End Region

		''' <summary>
		''' CTor
		''' </summary>
		''' <param name="rowBuilder">Row builder Object to use when building this row</param>
		Friend Sub New(rowBuilder As DataRowBuilder)
			MyBase.New(rowBuilder) 
			_parent = CType(Me.Table, VwProdRegistroCanalesTypedView)
		End Sub


#Region "Class Property Declarations"
	
		''' <summary>
		''' Gets / sets the value of the TypedView field FolioSacrificio<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRegistroCanales"."FolioSacrificio"<br/>
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
		''' Mapped on view field: "vwProdRegistroCanales"."FechaSacrificio"<br/>
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
		''' Gets / sets the value of the TypedView field CantCanales<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRegistroCanales"."CantCanales"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CantCanales]() As System.Int32
			Get 
				If IsCantCanalesNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CantCanalesColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CantCanalesColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CantCanales is NULL, False otherwise.
		''' </summary>
		Public Function IsCantCanalesNull() As Boolean
			Return IsNull(_parent.CantCanalesColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CantCanales to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCantCanalesNull() 
			Me(_parent.CantCanalesColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field Estatus<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRegistroCanales"."Estatus"<br/>
		''' View field characteristics (type, precision, scale, length): VarChar, 0, 0, 9
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
		''' Gets / sets the value of the TypedView field KgrsBascula<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRegistroCanales"."KgrsBascula"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [KgrsBascula]() As System.Decimal
			Get 
				If IsKgrsBasculaNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.KgrsBasculaColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.KgrsBasculaColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field KgrsBascula is NULL, False otherwise.
		''' </summary>
		Public Function IsKgrsBasculaNull() As Boolean
			Return IsNull(_parent.KgrsBasculaColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field KgrsBascula to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetKgrsBasculaNull() 
			Me(_parent.KgrsBasculaColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CanalesEnCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRegistroCanales"."CanalesEnCorte"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CanalesEnCorte]() As System.Int32
			Get 
				If IsCanalesEnCorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CanalesEnCorteColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CanalesEnCorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CanalesEnCorte is NULL, False otherwise.
		''' </summary>
		Public Function IsCanalesEnCorteNull() As Boolean
			Return IsNull(_parent.CanalesEnCorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CanalesEnCorte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCanalesEnCorteNull() 
			Me(_parent.CanalesEnCorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field KilosEnCorte<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRegistroCanales"."KilosEnCorte"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [KilosEnCorte]() As System.Decimal
			Get 
				If IsKilosEnCorteNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.KilosEnCorteColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.KilosEnCorteColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field KilosEnCorte is NULL, False otherwise.
		''' </summary>
		Public Function IsKilosEnCorteNull() As Boolean
			Return IsNull(_parent.KilosEnCorteColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field KilosEnCorte to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetKilosEnCorteNull() 
			Me(_parent.KilosEnCorteColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field CanalesEnEmbarque<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRegistroCanales"."CanalesEnEmbarque"<br/>
		''' View field characteristics (type, precision, scale, length): Int, 10, 0, 0
		''' </remarks>
		Public Property [CanalesEnEmbarque]() As System.Int32
			Get 
				If IsCanalesEnEmbarqueNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Int32)), System.Int32)
				Else
					Return CType(Me(_parent.CanalesEnEmbarqueColumn), System.Int32)
				End If
			End Get
			Set 
				Me(_parent.CanalesEnEmbarqueColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field CanalesEnEmbarque is NULL, False otherwise.
		''' </summary>
		Public Function IsCanalesEnEmbarqueNull() As Boolean
			Return IsNull(_parent.CanalesEnEmbarqueColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field CanalesEnEmbarque to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetCanalesEnEmbarqueNull() 
			Me(_parent.CanalesEnEmbarqueColumn) = System.Convert.DBNull
		End Sub

	

		''' <summary>
		''' Gets / sets the value of the TypedView field KilosEnEmbarque<br/><br/>
		''' 
		''' </summary>
		''' <remarks>
		''' Mapped on view field: "vwProdRegistroCanales"."KilosEnEmbarque"<br/>
		''' View field characteristics (type, precision, scale, length): Money, 19, 4, 0
		''' </remarks>
		Public Property [KilosEnEmbarque]() As System.Decimal
			Get 
				If IsKilosEnEmbarqueNull() Then
					' return default value for this type.
					Return CType(TypeDefaultValue.GetDefaultValue(GetType(System.Decimal)), System.Decimal)
				Else
					Return CType(Me(_parent.KilosEnEmbarqueColumn), System.Decimal)
				End If
			End Get
			Set 
				Me(_parent.KilosEnEmbarqueColumn) = Value
			End Set
		End Property

		''' <summary>
		''' Returns True if the TypedView field KilosEnEmbarque is NULL, False otherwise.
		''' </summary>
		Public Function IsKilosEnEmbarqueNull() As Boolean
			Return IsNull(_parent.KilosEnEmbarqueColumn)
		End Function

		''' <summary>
		''' Sets the TypedView field KilosEnEmbarque to NULL. Not recommended a typed view should be used
		''' as a readonly Object.
		''' </summary>
    	Public Sub SetKilosEnEmbarqueNull() 
			Me(_parent.KilosEnEmbarqueColumn) = System.Convert.DBNull
		End Sub

	
#End Region

#Region "Custom TypedView Row code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

	End Class
End Namespace
