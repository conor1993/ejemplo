﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 12 de julio de 2018 17:42:56
' // Code is generated using templates: SD.TemplateBindings.SqlServerSpecific.NET20
' // Templates vendor: Solutions Design.
' // Templates version: 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Configuration
Imports System.EnterpriseServices

Imports SD.LLBLGen.Pro.ORMSupportClasses

Namespace Integralab.ORM.HelperClasses
	''' <summary>
	''' General utility class for COM+ transactions. 
	''' </summary>
	<Transaction(TransactionOption.Required)> Public Class DbUtilsComPlus 
		Inherits ServicedComponent
		
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
		''' CTor
		''' </summary>
		Public Sub New()
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
		Public Function CreateConnection(connectionString As String) As SqlConnection
			Return New SqlConnection(connectionString)
		End Function

		''' <summary>
		''' Creates a new closed SqlConnection Object based on the connection string read from the *.config file of the appdomain.
		''' The connection string is stored in a key with the name defined in the constant connectionKeyString, mentioned above.
		''' </summary>
		''' <returns>A ready to use, closed, sqlconnection Object</returns>
		Public Function CreateConnection() As SqlConnection
			If ActualConnectionString = String.Empty Then
				ActualConnectionString = ConfigFileHelper.ReadConnectionStringFromConfig( connectionKeyString)
			End If
			Return CreateConnection(ActualConnectionString)
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
