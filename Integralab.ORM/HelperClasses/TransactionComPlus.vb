' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 26 de marzo de 2018 17:30:29
' // Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
' // Templates vendor: Solutions Design.
' // Templates version: 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
Imports System
Imports System.Data
Imports System.EnterpriseServices

Imports Integralab.ORM.HelperClasses

Imports SD.LLBLGen.Pro.ORMSupportClasses

Namespace Integralab.ORM.HelperClasses
	''' <summary>
	''' Specific implementation of the TransactionComPlus class. The constructor will take care of the creation of the physical transaction and the
	''' opening of the connection. It will require a COM+ transaction.
	''' </summary>
	<MustRunInClientContext(True)> Public Class TransactionComPlus 
		Inherits TransactionComPlusBase
	
		''' <summary>
		''' CTor
		''' </summary>
		Public Sub New()
		End Sub



		''' <summary>
		''' Creates a new IDbConnection instance which will be used by all elements using this ITransaction instance. 
		''' Reads connectionstring from .config file. The COM+ transaction will flow to the used method.
		''' </summary>
		''' <returns>new IDbConnection instance</returns>
		Protected Overrides Overloads Function CreateConnection() As System.Data.IDbConnection
			Dim dbUtilsToUse As New DbUtilsComPlus()
			Return dbUtilsToUse.CreateConnection()
		End Function


		''' <summary>
		''' Creates a new IDbConnection instance which will be used by all elements using this ITransaction instance
		''' The COM+ transaction will flow to the used method.
		''' </summary>
		''' <param name="connectionString">Connection string to use</param>
		''' <returns>new IDbConnection instance</returns>
		Protected Overrides Overloads Function CreateConnection(connectionString As String) As System.Data.IDbConnection
			Dim dbUtilsToUse As New DbUtilsComPlus()
			Return dbUtilsToUse.CreateConnection(connectionString)
		End Function


		''' <summary>
		''' Creates a new physical transaction Object over the created connection. The connection is assumed to be open.
		''' This method is void in combination of a COM+ transaction. It will always Return null.
		''' </summary>
		''' <returns>null</returns>
		Protected Overrides Overloads Function CreatePhysicalTransaction() As System.Data.IDbTransaction
			Return Nothing
		End Function

#Region "Included Code"

#End Region
	End Class
End Namespace
