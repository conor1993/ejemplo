﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 11 de diciembre de 2017 20:57:23
' // Code is generated using templates: SD.TemplateBindings.SqlServerSpecific.NET20
' // Templates vendor: Solutions Design.
' // Templates version: 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Configuration

Imports SD.LLBLGen.Pro.ORMSupportClasses

Namespace Integralab.ORM.HelperClasses
	''' <summary>
	''' General utility methods used for SqlServer usage by the framework. 
	''' </summary>
	Public Class DbUtils

#Region "Public Static Members"
		Public Shared ActualConnectionString As String = String.Empty
#End Region

#Region "Constants"
		Private Const connectionKeyString As String = "Main.ConnectionString"
#End Region

#Region "Class Member Declarations"
		Private Shared _commandTimeOut As Integer = 30
#End Region

		''' <summary>
		''' Private CTor, no instatiation possible
		''' </summary>
		Private Sub New()
		End Sub
		
		
		''' <summary>
		''' Sets the flag to signal the SqlServer DQE to generate SET ARITHABORT ON statements prior to INSERT, DELETE and UPDATE Queries.
		''' Keep this flag to false in normal usage, but set it to true if you need to write into a table which is part of an indexed view.
		''' It will not affect normal inserts/updates that much, leaving it on is not harmful. See Books online for details on SET ARITHABORT ON.
		''' After each statement the setting is turned off if it has been turned on prior to that statement.
		''' </summary>
		''' <remarks>Setting this flag is a global change.</remarks>
		Public Shared Sub SetArithAbortFlag(value As Boolean)
			SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.ArithAbortOn = value
		End Sub
		
		''' <summary>
		''' Sets the compatibility level used by the DQE. Default Is SqlServer2000. To utilize SqlServer 2005 specific features, Set this parameter 
		''' To SqlServer2005, either through a setting In the .config file of your application Or by calling this method once In your application.
		''' Compatibility level influences the query generated For paging, sequence name (@@IDENTITY/SCOPE_IDENTITY()), And usage of newsequenceid() In inserts. 
		''' </summary>
		''' <parameter name="compatibilityLevel">the compatibility level the DQE should be running On. Default Is SqlServer 2000 And up.</parameter>
		''' <remarks>Setting the compatibility level Is a global change. Calling this method will overrule a similar setting In the .config file.</remarks>
		Public Shared Sub SetSqlServerCompatibilityLevel(compatibilityLevel As SqlServerCompatibilityLevel)
			SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.CompatibilityLevel = compatibilityLevel
		End Sub

		''' <summary>
		''' Creates a new SqlConnection
		''' </summary>
		''' <param name="connectionString">Conectionstring To use</param>
		''' <returns>A ready to use, closed, sqlconnection Object</returns>
		Public Shared Function CreateConnection(connectionString As String) As SqlConnection
			Return New SqlConnection(connectionString)
		End Function


		''' <summary>
		''' Creates a new closed SqlConnection Object based on the connection string read from the *.config file of the appdomain.
		''' The connection string is stored in a key with the name defined in the constant connectionKeyString, mentioned above.
		''' </summary>
		''' <returns>A ready to use, closed, sqlconnection Object</returns>
		Public Shared Function CreateConnection() As SqlConnection
			If ActualConnectionString = String.Empty Then
				ActualConnectionString = ConfigFileHelper.ReadConnectionStringFromConfig( connectionKeyString)
			End If
			Return CreateConnection(ActualConnectionString)
		End Function


		''' <summary>
		''' Determines which connection to use: the connection held by the passed in transaction (if any) or a new one (if no Transaction was passed in)
		''' </summary>
		''' <param name="containingTransaction">A transaction the caller participates in. If null, the caller is not participating in a transaction</param>
		''' <returns>A ready to use connection Object</returns>
		Public Shared Function DetermineConnectionToUse(containingTransaction As ITransaction) As IDbConnection
			If (Not containingTransaction Is Nothing) AndAlso (Not containingTransaction.ConnectionToUse Is Nothing) Then
				Return containingTransaction.ConnectionToUse
			Else
				Return CreateConnection()
			End If
		End Function


		''' <summary>
		''' Creates a new SqlDataAdapter.
		''' </summary>
		''' <returns></returns>
		Public Shared Function CreateDataAdapter() As SqlDataAdapter
			Return New SqlDataAdapter()
		End Function


		''' <summary>
		''' Creates a new SqlServer transaction
		''' </summary>
		''' <param name="connectionToUse">the connection to use</param>
		''' <param name="isolationLevelToUse">the isolation level to use</param>
		''' <param name="name">the name for the transaction</param>
		''' <returns>new SqlTransaction Object.</returns>
		Public Shared Function CreateTransaction(connectionToUse As IDbConnection, isolationLevelToUse As IsolationLevel, name As String) As SqlTransaction
			Return (CType(connectionToUse, SqlConnection)).BeginTransaction(isolationLevelToUse, name)
		End Function


		''' <summary>
		''' Calls the specified action stored procedure in the SqlServer database a newly created connection is connecting to. 
		''' </summary>
		''' <param name="storedProcedureToCall">Stored procedure to call</param>
		''' <param name="parameters">array of parameters to specify</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>the amount of rows affected. This value will be -1 if the stored procedure sets ROWCOUNT to OFF or this has
		''' been disabled in the catalog by other settings.</returns>
		Public Shared Function CallActionStoredProcedure(storedProcedureToCall As String, parameters As SqlParameter(), transactionToUse As ITransaction) As Integer
			Dim command As SqlCommand = Nothing
			Dim connectionOpenedLocally As Boolean = False
			
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName(storedProcedureToCall)
			If Not transactionToUse Is Nothing Then
				Command = New SqlCommand(procName, CType(transactionToUse.ConnectionToUse, SqlConnection))
				command.Transaction = CType(transactionToUse.PhysicalTransaction, SqlTransaction)
			Else
				Command = New SqlCommand(procName, CreateConnection())
			End If
			
			command.CommandType = CommandType.StoredProcedure
			command.CommandTimeout = _commandTimeOut

			Dim toReturn As Integer = -1
			Try
				Dim i as Integer
				For i=0 to parameters.Length-1
					command.Parameters.Add(parameters(i))
				Next

				If command.Connection.State <> ConnectionState.Open Then
					command.Connection.Open()
					connectionOpenedLocally = True
				End If
				toReturn = command.ExecuteNonQuery()
			Finally
				If connectionOpenedLocally Then
					command.Connection.Close()
					command.Connection.Dispose()
				End If
				command.Dispose()

			End Try
			Return toReturn
		End Function


		''' <summary>
		''' Calls the specified retrieval stored procedure in the SqlServer database a newly created connection is connecting to. Fills the
		''' specified datatable. 
		''' </summary>
		''' <param name="storedProcedureToCall">Stored procedure to call</param>
		''' <param name="parameters">array of parameters to specify</param>
		''' <param name="tableToFill">Datatable to fill by the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Shared Function CallRetrievalStoredProcedure(storedProcedureToCall As String, parameters As SqlParameter(), tableToFill As DataTable, transactionToUse As ITransaction) As Boolean
			Dim command As SqlCommand = Nothing
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName(storedProcedureToCall)
			If Not transactionToUse Is Nothing Then
				Command = New SqlCommand(procName, CType(transactionToUse.ConnectionToUse, SqlConnection))
				command.Transaction = CType(transactionToUse.PhysicalTransaction, SqlTransaction)
			Else
				Command = New SqlCommand(procName, CreateConnection())
			End If

			command.CommandType = CommandType.StoredProcedure
			command.CommandTimeout = _commandTimeOut

			Try
				Dim adapter As new SqlDataAdapter(command)
				Dim i as Integer
				For i=0 to parameters.Length-1
					command.Parameters.Add(parameters(i))
				Next
				adapter.Fill(tableToFill)
				adapter.Dispose()
			Finally
				command.Dispose()
			End Try
			Return True
		End Function


		''' <summary>
		''' Calls the specified retrieval stored procedure in the SqlServer database a newly created connection is connecting to. Fills the
		''' specified DataSet. 
		''' </summary>
		''' <param name="storedProcedureToCall">Stored procedure to call</param>
		''' <param name="parameters">array of parameters to specify</param>
		''' <param name="dataSetToFill">DataSet to fill by the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>true if succeeded, false otherwise</returns>
		Public Overloads Shared Function CallRetrievalStoredProcedure(storedProcedureToCall As String, parameters As SqlParameter(), dataSetToFill As DataSet, transactionToUse As ITransaction) As Boolean
			Dim command As SqlCommand = Nothing
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName(storedProcedureToCall)
			If Not transactionToUse Is Nothing Then
				Command = New SqlCommand(procName, CType(transactionToUse.ConnectionToUse, SqlConnection))
				command.Transaction = CType(transactionToUse.PhysicalTransaction, SqlTransaction)
			Else
				command = New SqlCommand(procName, CreateConnection())
			End If

			command.CommandType = CommandType.StoredProcedure
			command.CommandTimeout = _commandTimeOut

			Try
				Dim adapter As new SqlDataAdapter(command)
				Dim i as Integer
				For i=0 to parameters.Length-1
					command.Parameters.Add(parameters(i))
				Next
				adapter.Fill(dataSetToFill)
				adapter.Dispose()
			Finally
				command.Dispose()
			End Try
			Return True
		End Function

#Region "Class Property Declarations"
		''' <summary>
		''' Gets / sets the command time out (in seconds). This is a global setting, so every Command object created after you've set this
		''' property to a value will have that value as CommandTimeOut. Default is 30 seconds which is the ADO.NET default.
		''' </summary>
		Public Shared Property CommandTimeOut As Integer
			Get
				Return _commandTimeOut
			End Get
			Set
				_commandTimeOut = value
				SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.CommandTimeOut = _commandTimeOut
			End Set
		End Property
#End Region

#Region "Included Code"

#End Region
	End Class
End Namespace
