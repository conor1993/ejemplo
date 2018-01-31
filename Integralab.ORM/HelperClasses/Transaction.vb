' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 31 de enero de 2018 11:15:18
' // Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
' // Templates vendor: Solutions Design.
' // Templates version: 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
Imports System
Imports System.Data

Imports Integralab.ORM.HelperClasses

Imports SD.LLBLGen.Pro.ORMSupportClasses

Namespace Integralab.ORM.HelperClasses
	''' <summary>
	''' Specific implementation of the Transaction class. The constructor will take care of the creation of the physical transaction and the
	''' opening of the connection. The transaction Object is ready to use as soon as the constructor succeeds.
	''' </summary>
	Public Class Transaction 
		Inherits TransactionBase
	
		''' <summary>
		''' CTor. Will read the connection string from an external source. Opens connection, class
		''' </summary>
		''' <param name="transactionIsolationLevel">IsolationLevel to use in the transaction</param>
		''' <param name="name">The name of the transaction to use.</param>
		Public Sub New(transactionIsolationLevel As IsolationLevel, name As String)
			MyBase.New(transactionIsolationLevel, name)
		End Sub

		
		''' <summary>
		''' CTor. 
		''' </summary>
		''' <param name="transactionIsolationLevel">IsolationLevel to use in the transaction</param>
		''' <param name="name">The name of the transaction to use.</param>
		''' <param name="connectionString">Connection string to use in this transaction</param>
		Public Sub New(transactionIsolationLevel As IsolationLevel, name As String, connectionString As String)
			MyBase.New(transactionIsolationLevel, name, connectionString)
		End Sub


		''' <summary>
		''' Creates a new IDbConnection instance which will be used by all elements using this ITransaction instance. 
		''' Reads connectionstring from .config file.
		''' </summary>
		''' <returns>new IDbConnection instance</returns>
		Protected Overrides Overloads Function CreateConnection() As System.Data.IDbConnection
			Return DbUtils.CreateConnection()
		End Function


		''' <summary>
		''' Creates a new IDbConnection instance which will be used by all elements using this ITransaction instance
		''' </summary>
		''' <param name="connectionString">Connection string to use</param>
		''' <returns>new IDbConnection instance</returns>
		Protected Overrides Overloads Function CreateConnection(connectionString As String) As System.Data.IDbConnection
			Return DbUtils.CreateConnection(connectionString)
		End Function


		''' <summary>
		''' Creates a new physical transaction Object over the created connection. The connection is assumed to be open.
		''' </summary>
		''' <returns>a physical transaction Object, like an instance of SqlTransaction.</returns>
		Protected Overrides Overloads Function CreatePhysicalTransaction() As System.Data.IDbTransaction
			Return DbUtils.CreateTransaction(MyBase.ConnectionToUse, MyBase.TransactionIsolationLevel, Me.Name)
		End Function

#Region "Included Code"

#End Region
	End Class
End Namespace
