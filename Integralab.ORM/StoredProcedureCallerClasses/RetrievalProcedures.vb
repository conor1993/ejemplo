' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 26 de enero de 2018 13:41:35
' // Code is generated using templates: SD.TemplateBindings.SqlServerSpecific.NET20
' // Templates vendor: Solutions Design.
' // Templates version: 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports SD.LLBLGen.Pro.ORMSupportClasses

Imports Integralab.ORM.HelperClasses

Namespace Integralab.ORM.StoredProcedureCallerClasses
	''' <summary>
	''' Class which contains the static logic to execute retrieval stored procedures in the database.
	''' </summary>
	Public Class RetrievalProcedures
		''' <summary>
		''' private CTor so no instance can be created.
		''' </summary>
		Private Sub New()
		End Sub

	
		''' <summary>
		''' Calls stored procedure 'AntiguedadSaldosCXP'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="fecha">Input parameter of stored procedure</param>
		''' <param name="proveedor">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function AntiguedadSaldosCxp(fecha As System.DateTime, proveedor As System.Int32) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fecha)
			parameters(1) = new SqlParameter("@Proveedor", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, proveedor)

			' Call the stored proc.
			Dim toReturn As New DataTable("AntiguedadSaldosCxp")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[AntiguedadSaldosCXP]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'AntiguedadSaldosCXP'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="fecha">Input parameter of stored procedure</param>
		''' <param name="proveedor">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function AntiguedadSaldosCxp(fecha As System.DateTime, proveedor As System.Int32, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fecha)
			parameters(1) = new SqlParameter("@Proveedor", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, proveedor)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("AntiguedadSaldosCxp")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[AntiguedadSaldosCXP]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'AntiguedadSaldosCXP'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="fecha">Input parameter of stored procedure</param>
		''' <param name="proveedor">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function AntiguedadSaldosCxp(fecha As System.DateTime, proveedor As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fecha)
			parameters(1) = new SqlParameter("@Proveedor", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, proveedor)

			' Call the stored proc.
			Dim toReturn As New DataTable("AntiguedadSaldosCxp")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[AntiguedadSaldosCXP]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'AntiguedadSaldosCXP'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="fecha">Input parameter of stored procedure</param>
		''' <param name="proveedor">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function AntiguedadSaldosCxp(fecha As System.DateTime, proveedor As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fecha)
			parameters(1) = new SqlParameter("@Proveedor", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, proveedor)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("AntiguedadSaldosCxp")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[AntiguedadSaldosCXP]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'AntiguedadSaldosCXP'.
		''' 
		''' </summary>
		''' <param name="fecha">Input parameter of stored procedure</param>
		''' <param name="proveedor">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetAntiguedadSaldosCxpCallAsQuery( fecha As System.DateTime, proveedor As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[AntiguedadSaldosCXP]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fecha))
			toReturn.Parameters.Add(New SqlParameter("@Proveedor", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, proveedor))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'CalculodeNomina'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="codigo">Input parameter of stored procedure</param>
		''' <param name="dias">Input parameter of stored procedure</param>
		''' <param name="hrex2">Input parameter of stored procedure</param>
		''' <param name="hrex3">Input parameter of stored procedure</param>
		''' <param name="comisiones">Input parameter of stored procedure</param>
		''' <param name="salarioMinimo">Input parameter of stored procedure</param>
		''' <param name="porIsrgravado">Input parameter of stored procedure</param>
		''' <param name="smindf">Input parameter of stored procedure</param>
		''' <param name="folio">Input parameter of stored procedure</param>
		''' <param name="fechaAlta">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="prestamo">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function CalculodeNomina(codigo As System.Int32, dias As System.Int32, hrex2 As System.Int32, hrex3 As System.Int32, comisiones As System.Decimal, salarioMinimo As System.Decimal, porIsrgravado As System.Decimal, smindf As System.Decimal, folio As System.String, fechaAlta As System.DateTime, descripcion As System.String,  _
prestamo As System.Decimal) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(12 - 1) {}
			parameters(0) = new SqlParameter("@Codigo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codigo)
			parameters(1) = new SqlParameter("@Dias", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, dias)
			parameters(2) = new SqlParameter("@HREX2", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, hrex2)
			parameters(3) = new SqlParameter("@HREX3", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, hrex3)
			parameters(4) = new SqlParameter("@Comisiones", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, comisiones)
			parameters(5) = new SqlParameter("@SalarioMinimo", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, salarioMinimo)
			parameters(6) = new SqlParameter("@PorISRGravado", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, porIsrgravado)
			parameters(7) = new SqlParameter("@SMINDF", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, smindf)
			parameters(8) = new SqlParameter("@Folio", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folio)
			parameters(9) = new SqlParameter("@FechaAlta", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaAlta)
			parameters(10) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 60, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)
			parameters(11) = new SqlParameter("@Prestamo", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, prestamo)

			' Call the stored proc.
			Dim toReturn As New DataTable("CalculodeNomina")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[CalculodeNomina]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'CalculodeNomina'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="codigo">Input parameter of stored procedure</param>
		''' <param name="dias">Input parameter of stored procedure</param>
		''' <param name="hrex2">Input parameter of stored procedure</param>
		''' <param name="hrex3">Input parameter of stored procedure</param>
		''' <param name="comisiones">Input parameter of stored procedure</param>
		''' <param name="salarioMinimo">Input parameter of stored procedure</param>
		''' <param name="porIsrgravado">Input parameter of stored procedure</param>
		''' <param name="smindf">Input parameter of stored procedure</param>
		''' <param name="folio">Input parameter of stored procedure</param>
		''' <param name="fechaAlta">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="prestamo">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function CalculodeNomina(codigo As System.Int32, dias As System.Int32, hrex2 As System.Int32, hrex3 As System.Int32, comisiones As System.Decimal, salarioMinimo As System.Decimal, porIsrgravado As System.Decimal, smindf As System.Decimal, folio As System.String, fechaAlta As System.DateTime, descripcion As System.String,  _
prestamo As System.Decimal, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(12) {}
			parameters(0) = new SqlParameter("@Codigo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codigo)
			parameters(1) = new SqlParameter("@Dias", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, dias)
			parameters(2) = new SqlParameter("@HREX2", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, hrex2)
			parameters(3) = new SqlParameter("@HREX3", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, hrex3)
			parameters(4) = new SqlParameter("@Comisiones", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, comisiones)
			parameters(5) = new SqlParameter("@SalarioMinimo", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, salarioMinimo)
			parameters(6) = new SqlParameter("@PorISRGravado", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, porIsrgravado)
			parameters(7) = new SqlParameter("@SMINDF", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, smindf)
			parameters(8) = new SqlParameter("@Folio", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folio)
			parameters(9) = new SqlParameter("@FechaAlta", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaAlta)
			parameters(10) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 60, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)
			parameters(11) = new SqlParameter("@Prestamo", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, prestamo)

			' Return value parameter
			parameters(12) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("CalculodeNomina")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[CalculodeNomina]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(12).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'CalculodeNomina'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="codigo">Input parameter of stored procedure</param>
		''' <param name="dias">Input parameter of stored procedure</param>
		''' <param name="hrex2">Input parameter of stored procedure</param>
		''' <param name="hrex3">Input parameter of stored procedure</param>
		''' <param name="comisiones">Input parameter of stored procedure</param>
		''' <param name="salarioMinimo">Input parameter of stored procedure</param>
		''' <param name="porIsrgravado">Input parameter of stored procedure</param>
		''' <param name="smindf">Input parameter of stored procedure</param>
		''' <param name="folio">Input parameter of stored procedure</param>
		''' <param name="fechaAlta">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="prestamo">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function CalculodeNomina(codigo As System.Int32, dias As System.Int32, hrex2 As System.Int32, hrex3 As System.Int32, comisiones As System.Decimal, salarioMinimo As System.Decimal, porIsrgravado As System.Decimal, smindf As System.Decimal, folio As System.String, fechaAlta As System.DateTime, descripcion As System.String,  _
prestamo As System.Decimal, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(12 - 1) {}
			parameters(0) = new SqlParameter("@Codigo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codigo)
			parameters(1) = new SqlParameter("@Dias", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, dias)
			parameters(2) = new SqlParameter("@HREX2", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, hrex2)
			parameters(3) = new SqlParameter("@HREX3", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, hrex3)
			parameters(4) = new SqlParameter("@Comisiones", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, comisiones)
			parameters(5) = new SqlParameter("@SalarioMinimo", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, salarioMinimo)
			parameters(6) = new SqlParameter("@PorISRGravado", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, porIsrgravado)
			parameters(7) = new SqlParameter("@SMINDF", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, smindf)
			parameters(8) = new SqlParameter("@Folio", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folio)
			parameters(9) = new SqlParameter("@FechaAlta", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaAlta)
			parameters(10) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 60, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)
			parameters(11) = new SqlParameter("@Prestamo", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, prestamo)

			' Call the stored proc.
			Dim toReturn As New DataTable("CalculodeNomina")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[CalculodeNomina]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'CalculodeNomina'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="codigo">Input parameter of stored procedure</param>
		''' <param name="dias">Input parameter of stored procedure</param>
		''' <param name="hrex2">Input parameter of stored procedure</param>
		''' <param name="hrex3">Input parameter of stored procedure</param>
		''' <param name="comisiones">Input parameter of stored procedure</param>
		''' <param name="salarioMinimo">Input parameter of stored procedure</param>
		''' <param name="porIsrgravado">Input parameter of stored procedure</param>
		''' <param name="smindf">Input parameter of stored procedure</param>
		''' <param name="folio">Input parameter of stored procedure</param>
		''' <param name="fechaAlta">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="prestamo">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function CalculodeNomina(codigo As System.Int32, dias As System.Int32, hrex2 As System.Int32, hrex3 As System.Int32, comisiones As System.Decimal, salarioMinimo As System.Decimal, porIsrgravado As System.Decimal, smindf As System.Decimal, folio As System.String, fechaAlta As System.DateTime, descripcion As System.String,  _
prestamo As System.Decimal, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(12) {}
			parameters(0) = new SqlParameter("@Codigo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codigo)
			parameters(1) = new SqlParameter("@Dias", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, dias)
			parameters(2) = new SqlParameter("@HREX2", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, hrex2)
			parameters(3) = new SqlParameter("@HREX3", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, hrex3)
			parameters(4) = new SqlParameter("@Comisiones", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, comisiones)
			parameters(5) = new SqlParameter("@SalarioMinimo", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, salarioMinimo)
			parameters(6) = new SqlParameter("@PorISRGravado", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, porIsrgravado)
			parameters(7) = new SqlParameter("@SMINDF", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, smindf)
			parameters(8) = new SqlParameter("@Folio", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folio)
			parameters(9) = new SqlParameter("@FechaAlta", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaAlta)
			parameters(10) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 60, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)
			parameters(11) = new SqlParameter("@Prestamo", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, prestamo)

			' Return value parameter
			parameters(12) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("CalculodeNomina")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[CalculodeNomina]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(12).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'CalculodeNomina'.
		''' 
		''' </summary>
		''' <param name="codigo">Input parameter of stored procedure</param>
		''' <param name="dias">Input parameter of stored procedure</param>
		''' <param name="hrex2">Input parameter of stored procedure</param>
		''' <param name="hrex3">Input parameter of stored procedure</param>
		''' <param name="comisiones">Input parameter of stored procedure</param>
		''' <param name="salarioMinimo">Input parameter of stored procedure</param>
		''' <param name="porIsrgravado">Input parameter of stored procedure</param>
		''' <param name="smindf">Input parameter of stored procedure</param>
		''' <param name="folio">Input parameter of stored procedure</param>
		''' <param name="fechaAlta">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="prestamo">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetCalculodeNominaCallAsQuery( codigo As System.Int32, dias As System.Int32, hrex2 As System.Int32, hrex3 As System.Int32, comisiones As System.Decimal, salarioMinimo As System.Decimal, porIsrgravado As System.Decimal, smindf As System.Decimal, folio As System.String, fechaAlta As System.DateTime, descripcion As System.String,  _
prestamo As System.Decimal) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[CalculodeNomina]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codigo))
			toReturn.Parameters.Add(New SqlParameter("@Dias", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, dias))
			toReturn.Parameters.Add(New SqlParameter("@HREX2", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, hrex2))
			toReturn.Parameters.Add(New SqlParameter("@HREX3", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, hrex3))
			toReturn.Parameters.Add(New SqlParameter("@Comisiones", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, comisiones))
			toReturn.Parameters.Add(New SqlParameter("@SalarioMinimo", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, salarioMinimo))
			toReturn.Parameters.Add(New SqlParameter("@PorISRGravado", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, porIsrgravado))
			toReturn.Parameters.Add(New SqlParameter("@SMINDF", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, smindf))
			toReturn.Parameters.Add(New SqlParameter("@Folio", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folio))
			toReturn.Parameters.Add(New SqlParameter("@FechaAlta", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaAlta))
			toReturn.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.VarChar, 60, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion))
			toReturn.Parameters.Add(New SqlParameter("@Prestamo", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, prestamo))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'ConsultaCiudadesXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaCiudadesXestatus(estatus As System.Int16) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaCiudadesXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaCiudadesXEstatus]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaCiudadesXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaCiudadesXestatus(estatus As System.Int16, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaCiudadesXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaCiudadesXEstatus]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'ConsultaCiudadesXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaCiudadesXestatus(estatus As System.Int16, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaCiudadesXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaCiudadesXEstatus]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaCiudadesXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaCiudadesXestatus(estatus As System.Int16, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaCiudadesXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaCiudadesXEstatus]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'ConsultaCiudadesXEstatus'.
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetConsultaCiudadesXestatusCallAsQuery( estatus As System.Int16) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[ConsultaCiudadesXEstatus]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'ConsultaEstadosXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaEstadosXestatus(estatus As System.Int16) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaEstadosXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaEstadosXEstatus]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaEstadosXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaEstadosXestatus(estatus As System.Int16, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaEstadosXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaEstadosXEstatus]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'ConsultaEstadosXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaEstadosXestatus(estatus As System.Int16, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaEstadosXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaEstadosXEstatus]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaEstadosXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaEstadosXestatus(estatus As System.Int16, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaEstadosXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaEstadosXEstatus]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'ConsultaEstadosXEstatus'.
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetConsultaEstadosXestatusCallAsQuery( estatus As System.Int16) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[ConsultaEstadosXEstatus]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'ConsultaLineasNuevasCliente'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cliente">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaLineasNuevasCliente(cliente As System.Int32) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Cliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cliente)

			' Call the stored proc.
			Dim toReturn As New DataTable("ConsultaLineasNuevasCliente")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaLineasNuevasCliente]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaLineasNuevasCliente'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cliente">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaLineasNuevasCliente(cliente As System.Int32, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Cliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cliente)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("ConsultaLineasNuevasCliente")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaLineasNuevasCliente]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'ConsultaLineasNuevasCliente'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cliente">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaLineasNuevasCliente(cliente As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Cliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cliente)

			' Call the stored proc.
			Dim toReturn As New DataTable("ConsultaLineasNuevasCliente")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaLineasNuevasCliente]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaLineasNuevasCliente'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cliente">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaLineasNuevasCliente(cliente As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Cliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cliente)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("ConsultaLineasNuevasCliente")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaLineasNuevasCliente]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'ConsultaLineasNuevasCliente'.
		''' 
		''' </summary>
		''' <param name="cliente">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetConsultaLineasNuevasClienteCallAsQuery( cliente As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[ConsultaLineasNuevasCliente]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Cliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cliente))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'ConsultaLineasXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaLineasXestatus(estatus As System.Int16) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaLineasXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaLineasXEstatus]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaLineasXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaLineasXestatus(estatus As System.Int16, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaLineasXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaLineasXEstatus]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'ConsultaLineasXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaLineasXestatus(estatus As System.Int16, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaLineasXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaLineasXEstatus]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaLineasXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaLineasXestatus(estatus As System.Int16, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaLineasXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaLineasXEstatus]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'ConsultaLineasXEstatus'.
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetConsultaLineasXestatusCallAsQuery( estatus As System.Int16) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[ConsultaLineasXEstatus]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'ConsultaMarcaXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaMarcaXestatus(estatus As System.Int16) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaMarcaXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaMarcaXEstatus]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaMarcaXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaMarcaXestatus(estatus As System.Int16, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaMarcaXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaMarcaXEstatus]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'ConsultaMarcaXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaMarcaXestatus(estatus As System.Int16, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaMarcaXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaMarcaXEstatus]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaMarcaXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaMarcaXestatus(estatus As System.Int16, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaMarcaXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaMarcaXEstatus]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'ConsultaMarcaXEstatus'.
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetConsultaMarcaXestatusCallAsQuery( estatus As System.Int16) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[ConsultaMarcaXEstatus]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'ConsultaMotivoBajaXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaMotivoBajaXestatus(estatus As System.Int16) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaMotivoBajaXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaMotivoBajaXEstatus]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaMotivoBajaXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaMotivoBajaXestatus(estatus As System.Int16, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaMotivoBajaXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaMotivoBajaXEstatus]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'ConsultaMotivoBajaXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaMotivoBajaXestatus(estatus As System.Int16, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaMotivoBajaXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaMotivoBajaXEstatus]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaMotivoBajaXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaMotivoBajaXestatus(estatus As System.Int16, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaMotivoBajaXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaMotivoBajaXEstatus]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'ConsultaMotivoBajaXEstatus'.
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetConsultaMotivoBajaXestatusCallAsQuery( estatus As System.Int16) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[ConsultaMotivoBajaXEstatus]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'ConsultaMotivoCancelacionXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaMotivoCancelacionXestatus(estatus As System.Int16) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaMotivoCancelacionXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaMotivoCancelacionXEstatus]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaMotivoCancelacionXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaMotivoCancelacionXestatus(estatus As System.Int16, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaMotivoCancelacionXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaMotivoCancelacionXEstatus]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'ConsultaMotivoCancelacionXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaMotivoCancelacionXestatus(estatus As System.Int16, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaMotivoCancelacionXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaMotivoCancelacionXEstatus]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaMotivoCancelacionXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaMotivoCancelacionXestatus(estatus As System.Int16, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaMotivoCancelacionXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaMotivoCancelacionXEstatus]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'ConsultaMotivoCancelacionXEstatus'.
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetConsultaMotivoCancelacionXestatusCallAsQuery( estatus As System.Int16) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[ConsultaMotivoCancelacionXEstatus]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'ConsultaPlazaXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaPlazaXestatus(estatus As System.Int16) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaPlazaXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaPlazaXEstatus]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaPlazaXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaPlazaXestatus(estatus As System.Int16, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaPlazaXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaPlazaXEstatus]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'ConsultaPlazaXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaPlazaXestatus(estatus As System.Int16, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaPlazaXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaPlazaXEstatus]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaPlazaXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaPlazaXestatus(estatus As System.Int16, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaPlazaXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaPlazaXEstatus]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'ConsultaPlazaXEstatus'.
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetConsultaPlazaXestatusCallAsQuery( estatus As System.Int16) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[ConsultaPlazaXEstatus]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'ConsultaPoblacionesXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaPoblacionesXestatus(estatus As System.Int16) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaPoblacionesXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaPoblacionesXEstatus]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaPoblacionesXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaPoblacionesXestatus(estatus As System.Int16, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaPoblacionesXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaPoblacionesXEstatus]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'ConsultaPoblacionesXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaPoblacionesXestatus(estatus As System.Int16, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaPoblacionesXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaPoblacionesXEstatus]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaPoblacionesXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaPoblacionesXestatus(estatus As System.Int16, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaPoblacionesXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaPoblacionesXEstatus]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'ConsultaPoblacionesXEstatus'.
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetConsultaPoblacionesXestatusCallAsQuery( estatus As System.Int16) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[ConsultaPoblacionesXEstatus]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'ConsultaPresentacionXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaPresentacionXestatus(estatus As System.Int16) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaPresentacionXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaPresentacionXEstatus]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaPresentacionXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaPresentacionXestatus(estatus As System.Int16, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaPresentacionXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaPresentacionXEstatus]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'ConsultaPresentacionXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaPresentacionXestatus(estatus As System.Int16, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaPresentacionXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaPresentacionXEstatus]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaPresentacionXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaPresentacionXestatus(estatus As System.Int16, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaPresentacionXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaPresentacionXEstatus]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'ConsultaPresentacionXEstatus'.
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetConsultaPresentacionXestatusCallAsQuery( estatus As System.Int16) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[ConsultaPresentacionXEstatus]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'ConsultarProductosNuevosLP'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="listaPrecio">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultarProductosNuevosLp(listaPrecio As System.Int32) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@ListaPrecio", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, listaPrecio)

			' Call the stored proc.
			Dim toReturn As New DataTable("ConsultarProductosNuevosLp")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultarProductosNuevosLP]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultarProductosNuevosLP'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="listaPrecio">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultarProductosNuevosLp(listaPrecio As System.Int32, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@ListaPrecio", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, listaPrecio)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("ConsultarProductosNuevosLp")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultarProductosNuevosLP]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'ConsultarProductosNuevosLP'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="listaPrecio">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultarProductosNuevosLp(listaPrecio As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@ListaPrecio", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, listaPrecio)

			' Call the stored proc.
			Dim toReturn As New DataTable("ConsultarProductosNuevosLp")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultarProductosNuevosLP]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultarProductosNuevosLP'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="listaPrecio">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultarProductosNuevosLp(listaPrecio As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@ListaPrecio", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, listaPrecio)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("ConsultarProductosNuevosLp")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultarProductosNuevosLP]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'ConsultarProductosNuevosLP'.
		''' 
		''' </summary>
		''' <param name="listaPrecio">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetConsultarProductosNuevosLpCallAsQuery( listaPrecio As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[ConsultarProductosNuevosLP]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@ListaPrecio", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, listaPrecio))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'ConsultarProductosXClave'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="clave">Input parameter of stored procedure</param>
		''' <param name="cliente">Input parameter of stored procedure</param>
		''' <param name="tipoVenta">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultarProductosXclave(clave As System.String, cliente As System.Int32, tipoVenta As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@Clave", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, clave)
			parameters(1) = new SqlParameter("@Cliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cliente)
			parameters(2) = new SqlParameter("@TipoVenta", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, tipoVenta)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultarProductosXclave")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultarProductosXClave]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultarProductosXClave'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="clave">Input parameter of stored procedure</param>
		''' <param name="cliente">Input parameter of stored procedure</param>
		''' <param name="tipoVenta">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultarProductosXclave(clave As System.String, cliente As System.Int32, tipoVenta As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@Clave", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, clave)
			parameters(1) = new SqlParameter("@Cliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cliente)
			parameters(2) = new SqlParameter("@TipoVenta", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, tipoVenta)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultarProductosXclave")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultarProductosXClave]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'ConsultarProductosXClave'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="clave">Input parameter of stored procedure</param>
		''' <param name="cliente">Input parameter of stored procedure</param>
		''' <param name="tipoVenta">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultarProductosXclave(clave As System.String, cliente As System.Int32, tipoVenta As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@Clave", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, clave)
			parameters(1) = new SqlParameter("@Cliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cliente)
			parameters(2) = new SqlParameter("@TipoVenta", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, tipoVenta)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultarProductosXclave")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultarProductosXClave]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultarProductosXClave'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="clave">Input parameter of stored procedure</param>
		''' <param name="cliente">Input parameter of stored procedure</param>
		''' <param name="tipoVenta">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultarProductosXclave(clave As System.String, cliente As System.Int32, tipoVenta As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@Clave", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, clave)
			parameters(1) = new SqlParameter("@Cliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cliente)
			parameters(2) = new SqlParameter("@TipoVenta", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, tipoVenta)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultarProductosXclave")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultarProductosXClave]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'ConsultarProductosXClave'.
		''' 
		''' </summary>
		''' <param name="clave">Input parameter of stored procedure</param>
		''' <param name="cliente">Input parameter of stored procedure</param>
		''' <param name="tipoVenta">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetConsultarProductosXclaveCallAsQuery( clave As System.String, cliente As System.Int32, tipoVenta As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[ConsultarProductosXClave]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Clave", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, clave))
			toReturn.Parameters.Add(New SqlParameter("@Cliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cliente))
			toReturn.Parameters.Add(New SqlParameter("@TipoVenta", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, tipoVenta))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'ConsultaSubLineasXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaSubLineasXestatus(estatus As System.Int16) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaSubLineasXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaSubLineasXEstatus]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaSubLineasXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaSubLineasXestatus(estatus As System.Int16, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaSubLineasXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaSubLineasXEstatus]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'ConsultaSubLineasXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaSubLineasXestatus(estatus As System.Int16, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaSubLineasXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaSubLineasXEstatus]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaSubLineasXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaSubLineasXestatus(estatus As System.Int16, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaSubLineasXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaSubLineasXEstatus]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'ConsultaSubLineasXEstatus'.
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetConsultaSubLineasXestatusCallAsQuery( estatus As System.Int16) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[ConsultaSubLineasXEstatus]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'ConsultaSucursalesXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaSucursalesXestatus(estatus As System.Int16) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaSucursalesXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaSucursalesXEstatus]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaSucursalesXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaSucursalesXestatus(estatus As System.Int16, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaSucursalesXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaSucursalesXEstatus]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'ConsultaSucursalesXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaSucursalesXestatus(estatus As System.Int16, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaSucursalesXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaSucursalesXEstatus]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaSucursalesXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaSucursalesXestatus(estatus As System.Int16, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaSucursalesXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaSucursalesXEstatus]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'ConsultaSucursalesXEstatus'.
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetConsultaSucursalesXestatusCallAsQuery( estatus As System.Int16) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[ConsultaSucursalesXEstatus]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'ConsultaTipoComisionistaXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaTipoComisionistaXestatus(estatus As System.Int16) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaTipoComisionistaXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaTipoComisionistaXEstatus]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaTipoComisionistaXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaTipoComisionistaXestatus(estatus As System.Int16, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaTipoComisionistaXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaTipoComisionistaXEstatus]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'ConsultaTipoComisionistaXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaTipoComisionistaXestatus(estatus As System.Int16, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaTipoComisionistaXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaTipoComisionistaXEstatus]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaTipoComisionistaXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaTipoComisionistaXestatus(estatus As System.Int16, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaTipoComisionistaXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaTipoComisionistaXEstatus]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'ConsultaTipoComisionistaXEstatus'.
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetConsultaTipoComisionistaXestatusCallAsQuery( estatus As System.Int16) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[ConsultaTipoComisionistaXEstatus]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'ConsultaTipoPresupuestoXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaTipoPresupuestoXestatus(estatus As System.Int16) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaTipoPresupuestoXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaTipoPresupuestoXEstatus]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaTipoPresupuestoXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaTipoPresupuestoXestatus(estatus As System.Int16, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaTipoPresupuestoXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaTipoPresupuestoXEstatus]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'ConsultaTipoPresupuestoXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaTipoPresupuestoXestatus(estatus As System.Int16, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaTipoPresupuestoXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaTipoPresupuestoXEstatus]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaTipoPresupuestoXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaTipoPresupuestoXestatus(estatus As System.Int16, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaTipoPresupuestoXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaTipoPresupuestoXEstatus]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'ConsultaTipoPresupuestoXEstatus'.
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetConsultaTipoPresupuestoXestatusCallAsQuery( estatus As System.Int16) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[ConsultaTipoPresupuestoXEstatus]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'ConsultaUnidadMedidaXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaUnidadMedidaXestatus(estatus As System.Int16) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaUnidadMedidaXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaUnidadMedidaXEstatus]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaUnidadMedidaXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaUnidadMedidaXestatus(estatus As System.Int16, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaUnidadMedidaXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaUnidadMedidaXEstatus]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'ConsultaUnidadMedidaXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaUnidadMedidaXestatus(estatus As System.Int16, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaUnidadMedidaXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaUnidadMedidaXEstatus]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaUnidadMedidaXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaUnidadMedidaXestatus(estatus As System.Int16, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaUnidadMedidaXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaUnidadMedidaXEstatus]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'ConsultaUnidadMedidaXEstatus'.
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetConsultaUnidadMedidaXestatusCallAsQuery( estatus As System.Int16) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[ConsultaUnidadMedidaXEstatus]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'ConsultaZonasXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaZonasXestatus(estatus As System.Int16) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaZonasXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaZonasXEstatus]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaZonasXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaZonasXestatus(estatus As System.Int16, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaZonasXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaZonasXEstatus]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'ConsultaZonasXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaZonasXestatus(estatus As System.Int16, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaZonasXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaZonasXEstatus]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ConsultaZonasXEstatus'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ConsultaZonasXestatus(estatus As System.Int16, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ConsultaZonasXestatus")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ConsultaZonasXEstatus]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'ConsultaZonasXEstatus'.
		''' 
		''' </summary>
		''' <param name="estatus">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetConsultaZonasXestatusCallAsQuery( estatus As System.Int16) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[ConsultaZonasXEstatus]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Estatus", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, estatus))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'CxPFacturasApagar'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="fechaVencimiento">Input parameter of stored procedure</param>
		''' <param name="idEmpresa">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function CxPfacturasApagar(fechaVencimiento As System.DateTime, idEmpresa As System.Int32) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@FechaVencimiento", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaVencimiento)
			parameters(1) = new SqlParameter("@IdEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEmpresa)

			' Call the stored proc.
			Dim toReturn As New DataTable("CxPfacturasApagar")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[CxPFacturasApagar]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'CxPFacturasApagar'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="fechaVencimiento">Input parameter of stored procedure</param>
		''' <param name="idEmpresa">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function CxPfacturasApagar(fechaVencimiento As System.DateTime, idEmpresa As System.Int32, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@FechaVencimiento", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaVencimiento)
			parameters(1) = new SqlParameter("@IdEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEmpresa)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("CxPfacturasApagar")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[CxPFacturasApagar]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'CxPFacturasApagar'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="fechaVencimiento">Input parameter of stored procedure</param>
		''' <param name="idEmpresa">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function CxPfacturasApagar(fechaVencimiento As System.DateTime, idEmpresa As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@FechaVencimiento", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaVencimiento)
			parameters(1) = new SqlParameter("@IdEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEmpresa)

			' Call the stored proc.
			Dim toReturn As New DataTable("CxPfacturasApagar")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[CxPFacturasApagar]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'CxPFacturasApagar'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="fechaVencimiento">Input parameter of stored procedure</param>
		''' <param name="idEmpresa">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function CxPfacturasApagar(fechaVencimiento As System.DateTime, idEmpresa As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@FechaVencimiento", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaVencimiento)
			parameters(1) = new SqlParameter("@IdEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEmpresa)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("CxPfacturasApagar")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[CxPFacturasApagar]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'CxPFacturasApagar'.
		''' 
		''' </summary>
		''' <param name="fechaVencimiento">Input parameter of stored procedure</param>
		''' <param name="idEmpresa">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetCxPfacturasApagarCallAsQuery( fechaVencimiento As System.DateTime, idEmpresa As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[CxPFacturasApagar]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@FechaVencimiento", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaVencimiento))
			toReturn.Parameters.Add(New SqlParameter("@IdEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEmpresa))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'FacturasGenerales'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="fechaIni">Input parameter of stored procedure</param>
		''' <param name="fechaFin">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function FacturasGenerales(idCliente As System.Int32, fechaIni As System.DateTime, fechaFin As System.DateTime, opcion As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(1) = new SqlParameter("@FechaIni", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaIni)
			parameters(2) = new SqlParameter("@FechaFin", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFin)
			parameters(3) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Call the stored proc.
			Dim toReturn As New DataSet("FacturasGenerales")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[FacturasGenerales]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'FacturasGenerales'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="fechaIni">Input parameter of stored procedure</param>
		''' <param name="fechaFin">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function FacturasGenerales(idCliente As System.Int32, fechaIni As System.DateTime, fechaFin As System.DateTime, opcion As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(1) = new SqlParameter("@FechaIni", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaIni)
			parameters(2) = new SqlParameter("@FechaFin", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFin)
			parameters(3) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("FacturasGenerales")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[FacturasGenerales]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'FacturasGenerales'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="fechaIni">Input parameter of stored procedure</param>
		''' <param name="fechaFin">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function FacturasGenerales(idCliente As System.Int32, fechaIni As System.DateTime, fechaFin As System.DateTime, opcion As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(1) = new SqlParameter("@FechaIni", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaIni)
			parameters(2) = new SqlParameter("@FechaFin", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFin)
			parameters(3) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Call the stored proc.
			Dim toReturn As New DataSet("FacturasGenerales")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[FacturasGenerales]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'FacturasGenerales'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="fechaIni">Input parameter of stored procedure</param>
		''' <param name="fechaFin">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function FacturasGenerales(idCliente As System.Int32, fechaIni As System.DateTime, fechaFin As System.DateTime, opcion As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(1) = new SqlParameter("@FechaIni", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaIni)
			parameters(2) = new SqlParameter("@FechaFin", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFin)
			parameters(3) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("FacturasGenerales")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[FacturasGenerales]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'FacturasGenerales'.
		''' 
		''' </summary>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="fechaIni">Input parameter of stored procedure</param>
		''' <param name="fechaFin">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetFacturasGeneralesCallAsQuery( idCliente As System.Int32, fechaIni As System.DateTime, fechaFin As System.DateTime, opcion As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[FacturasGenerales]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente))
			toReturn.Parameters.Add(New SqlParameter("@FechaIni", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaIni))
			toReturn.Parameters.Add(New SqlParameter("@FechaFin", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFin))
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'GeneraPolizaPasivo'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="empresaId">Input parameter of stored procedure</param>
		''' <param name="proveedorId">Input parameter of stored procedure</param>
		''' <param name="fechaContabilizacion">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function GeneraPolizaPasivo(empresaId As System.Int32, proveedorId As System.Int32, fechaContabilizacion As System.DateTime, opcion As System.Int32) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@EmpresaId", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, empresaId)
			parameters(1) = new SqlParameter("@ProveedorId", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, proveedorId)
			parameters(2) = new SqlParameter("@FechaContabilizacion", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaContabilizacion)
			parameters(3) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Call the stored proc.
			Dim toReturn As New DataTable("GeneraPolizaPasivo")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[GeneraPolizaPasivo]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'GeneraPolizaPasivo'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="empresaId">Input parameter of stored procedure</param>
		''' <param name="proveedorId">Input parameter of stored procedure</param>
		''' <param name="fechaContabilizacion">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function GeneraPolizaPasivo(empresaId As System.Int32, proveedorId As System.Int32, fechaContabilizacion As System.DateTime, opcion As System.Int32, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@EmpresaId", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, empresaId)
			parameters(1) = new SqlParameter("@ProveedorId", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, proveedorId)
			parameters(2) = new SqlParameter("@FechaContabilizacion", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaContabilizacion)
			parameters(3) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("GeneraPolizaPasivo")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[GeneraPolizaPasivo]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'GeneraPolizaPasivo'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="empresaId">Input parameter of stored procedure</param>
		''' <param name="proveedorId">Input parameter of stored procedure</param>
		''' <param name="fechaContabilizacion">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function GeneraPolizaPasivo(empresaId As System.Int32, proveedorId As System.Int32, fechaContabilizacion As System.DateTime, opcion As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@EmpresaId", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, empresaId)
			parameters(1) = new SqlParameter("@ProveedorId", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, proveedorId)
			parameters(2) = new SqlParameter("@FechaContabilizacion", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaContabilizacion)
			parameters(3) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Call the stored proc.
			Dim toReturn As New DataTable("GeneraPolizaPasivo")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[GeneraPolizaPasivo]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'GeneraPolizaPasivo'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="empresaId">Input parameter of stored procedure</param>
		''' <param name="proveedorId">Input parameter of stored procedure</param>
		''' <param name="fechaContabilizacion">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function GeneraPolizaPasivo(empresaId As System.Int32, proveedorId As System.Int32, fechaContabilizacion As System.DateTime, opcion As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@EmpresaId", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, empresaId)
			parameters(1) = new SqlParameter("@ProveedorId", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, proveedorId)
			parameters(2) = new SqlParameter("@FechaContabilizacion", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaContabilizacion)
			parameters(3) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("GeneraPolizaPasivo")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[GeneraPolizaPasivo]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'GeneraPolizaPasivo'.
		''' 
		''' </summary>
		''' <param name="empresaId">Input parameter of stored procedure</param>
		''' <param name="proveedorId">Input parameter of stored procedure</param>
		''' <param name="fechaContabilizacion">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetGeneraPolizaPasivoCallAsQuery( empresaId As System.Int32, proveedorId As System.Int32, fechaContabilizacion As System.DateTime, opcion As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[GeneraPolizaPasivo]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@EmpresaId", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, empresaId))
			toReturn.Parameters.Add(New SqlParameter("@ProveedorId", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, proveedorId))
			toReturn.Parameters.Add(New SqlParameter("@FechaContabilizacion", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaContabilizacion))
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'GENERARFOLIOPOLIZA'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="emp">Input parameter of stored procedure</param>
		''' <param name="tip">Input parameter of stored procedure</param>
		''' <param name="mes">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function Generarfoliopoliza(emp As System.Int32, tip As System.String, mes As System.Int32) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@EMP", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, emp)
			parameters(1) = new SqlParameter("@TIP", SqlDbType.Char, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, tip)
			parameters(2) = new SqlParameter("@MES", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, mes)

			' Call the stored proc.
			Dim toReturn As New DataTable("Generarfoliopoliza")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[GENERARFOLIOPOLIZA]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'GENERARFOLIOPOLIZA'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="emp">Input parameter of stored procedure</param>
		''' <param name="tip">Input parameter of stored procedure</param>
		''' <param name="mes">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function Generarfoliopoliza(emp As System.Int32, tip As System.String, mes As System.Int32, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@EMP", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, emp)
			parameters(1) = new SqlParameter("@TIP", SqlDbType.Char, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, tip)
			parameters(2) = new SqlParameter("@MES", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, mes)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("Generarfoliopoliza")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[GENERARFOLIOPOLIZA]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'GENERARFOLIOPOLIZA'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="emp">Input parameter of stored procedure</param>
		''' <param name="tip">Input parameter of stored procedure</param>
		''' <param name="mes">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function Generarfoliopoliza(emp As System.Int32, tip As System.String, mes As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@EMP", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, emp)
			parameters(1) = new SqlParameter("@TIP", SqlDbType.Char, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, tip)
			parameters(2) = new SqlParameter("@MES", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, mes)

			' Call the stored proc.
			Dim toReturn As New DataTable("Generarfoliopoliza")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[GENERARFOLIOPOLIZA]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'GENERARFOLIOPOLIZA'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="emp">Input parameter of stored procedure</param>
		''' <param name="tip">Input parameter of stored procedure</param>
		''' <param name="mes">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function Generarfoliopoliza(emp As System.Int32, tip As System.String, mes As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@EMP", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, emp)
			parameters(1) = new SqlParameter("@TIP", SqlDbType.Char, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, tip)
			parameters(2) = new SqlParameter("@MES", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, mes)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("Generarfoliopoliza")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[GENERARFOLIOPOLIZA]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'GENERARFOLIOPOLIZA'.
		''' 
		''' </summary>
		''' <param name="emp">Input parameter of stored procedure</param>
		''' <param name="tip">Input parameter of stored procedure</param>
		''' <param name="mes">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetGenerarfoliopolizaCallAsQuery( emp As System.Int32, tip As System.String, mes As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[GENERARFOLIOPOLIZA]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@EMP", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, emp))
			toReturn.Parameters.Add(New SqlParameter("@TIP", SqlDbType.Char, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, tip))
			toReturn.Parameters.Add(New SqlParameter("@MES", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, mes))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'INVComparativoProduccion'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="almacen">Input parameter of stored procedure</param>
		''' <param name="idProducto">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function InvcomparativoProduccion(opcion As System.Int32, almacen As System.Int32, idProducto As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@Almacen", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, almacen)
			parameters(2) = new SqlParameter("@IdProducto", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProducto)

			' Call the stored proc.
			Dim toReturn As New DataSet("InvcomparativoProduccion")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[INVComparativoProduccion]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'INVComparativoProduccion'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="almacen">Input parameter of stored procedure</param>
		''' <param name="idProducto">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function InvcomparativoProduccion(opcion As System.Int32, almacen As System.Int32, idProducto As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@Almacen", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, almacen)
			parameters(2) = new SqlParameter("@IdProducto", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProducto)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("InvcomparativoProduccion")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[INVComparativoProduccion]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'INVComparativoProduccion'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="almacen">Input parameter of stored procedure</param>
		''' <param name="idProducto">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function InvcomparativoProduccion(opcion As System.Int32, almacen As System.Int32, idProducto As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@Almacen", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, almacen)
			parameters(2) = new SqlParameter("@IdProducto", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProducto)

			' Call the stored proc.
			Dim toReturn As New DataSet("InvcomparativoProduccion")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[INVComparativoProduccion]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'INVComparativoProduccion'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="almacen">Input parameter of stored procedure</param>
		''' <param name="idProducto">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function InvcomparativoProduccion(opcion As System.Int32, almacen As System.Int32, idProducto As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@Almacen", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, almacen)
			parameters(2) = new SqlParameter("@IdProducto", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProducto)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("InvcomparativoProduccion")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[INVComparativoProduccion]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'INVComparativoProduccion'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="almacen">Input parameter of stored procedure</param>
		''' <param name="idProducto">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetInvcomparativoProduccionCallAsQuery( opcion As System.Int32, almacen As System.Int32, idProducto As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[INVComparativoProduccion]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@Almacen", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, almacen))
			toReturn.Parameters.Add(New SqlParameter("@IdProducto", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProducto))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'ObtenerListadoBasicoProductos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="tipo">Input parameter of stored procedure</param>
		''' <param name="como">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ObtenerListadoBasicoProductos(tipo As System.Int32, como As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Tipo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, tipo)
			parameters(1) = new SqlParameter("@Como", SqlDbType.VarChar, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, como)

			' Call the stored proc.
			Dim toReturn As New DataSet("ObtenerListadoBasicoProductos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ObtenerListadoBasicoProductos]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ObtenerListadoBasicoProductos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="tipo">Input parameter of stored procedure</param>
		''' <param name="como">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ObtenerListadoBasicoProductos(tipo As System.Int32, como As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Tipo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, tipo)
			parameters(1) = new SqlParameter("@Como", SqlDbType.VarChar, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, como)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ObtenerListadoBasicoProductos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ObtenerListadoBasicoProductos]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'ObtenerListadoBasicoProductos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="tipo">Input parameter of stored procedure</param>
		''' <param name="como">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ObtenerListadoBasicoProductos(tipo As System.Int32, como As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Tipo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, tipo)
			parameters(1) = new SqlParameter("@Como", SqlDbType.VarChar, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, como)

			' Call the stored proc.
			Dim toReturn As New DataSet("ObtenerListadoBasicoProductos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ObtenerListadoBasicoProductos]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'ObtenerListadoBasicoProductos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="tipo">Input parameter of stored procedure</param>
		''' <param name="como">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function ObtenerListadoBasicoProductos(tipo As System.Int32, como As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Tipo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, tipo)
			parameters(1) = new SqlParameter("@Como", SqlDbType.VarChar, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, como)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("ObtenerListadoBasicoProductos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[ObtenerListadoBasicoProductos]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'ObtenerListadoBasicoProductos'.
		''' 
		''' </summary>
		''' <param name="tipo">Input parameter of stored procedure</param>
		''' <param name="como">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetObtenerListadoBasicoProductosCallAsQuery( tipo As System.Int32, como As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[ObtenerListadoBasicoProductos]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Tipo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, tipo))
			toReturn.Parameters.Add(New SqlParameter("@Como", SqlDbType.VarChar, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, como))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'PaContUsrConfigContabilidad'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="func">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="cancelaPolizaNegativos">Input parameter of stored procedure</param>
		''' <param name="iva">Input parameter of stored procedure</param>
		''' <param name="isr">Input parameter of stored procedure</param>
		''' <param name="tasaRetencion">Input parameter of stored procedure</param>
		''' <param name="flete">Input parameter of stored procedure</param>
		''' <param name="mostrarDomicilio">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function PaContUsrConfigContabilidad(func As System.String, opcion As System.Int32, cancelaPolizaNegativos As System.String, iva As System.Decimal, isr As System.Decimal, tasaRetencion As System.Decimal, flete As System.Decimal, mostrarDomicilio As System.Boolean) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(8 - 1) {}
			parameters(0) = new SqlParameter("@Func", SqlDbType.Char, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, func)
			parameters(1) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(2) = new SqlParameter("@CancelaPolizaNegativos", SqlDbType.Char, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cancelaPolizaNegativos)
			parameters(3) = new SqlParameter("@IVA", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, iva)
			parameters(4) = new SqlParameter("@ISR", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, isr)
			parameters(5) = new SqlParameter("@TasaRetencion", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, tasaRetencion)
			parameters(6) = new SqlParameter("@Flete", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, flete)
			parameters(7) = new SqlParameter("@MostrarDomicilio", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, mostrarDomicilio)

			' Call the stored proc.
			Dim toReturn As New DataTable("PaContUsrConfigContabilidad")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[PaContUsrConfigContabilidad]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'PaContUsrConfigContabilidad'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="func">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="cancelaPolizaNegativos">Input parameter of stored procedure</param>
		''' <param name="iva">Input parameter of stored procedure</param>
		''' <param name="isr">Input parameter of stored procedure</param>
		''' <param name="tasaRetencion">Input parameter of stored procedure</param>
		''' <param name="flete">Input parameter of stored procedure</param>
		''' <param name="mostrarDomicilio">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function PaContUsrConfigContabilidad(func As System.String, opcion As System.Int32, cancelaPolizaNegativos As System.String, iva As System.Decimal, isr As System.Decimal, tasaRetencion As System.Decimal, flete As System.Decimal, mostrarDomicilio As System.Boolean, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(8) {}
			parameters(0) = new SqlParameter("@Func", SqlDbType.Char, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, func)
			parameters(1) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(2) = new SqlParameter("@CancelaPolizaNegativos", SqlDbType.Char, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cancelaPolizaNegativos)
			parameters(3) = new SqlParameter("@IVA", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, iva)
			parameters(4) = new SqlParameter("@ISR", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, isr)
			parameters(5) = new SqlParameter("@TasaRetencion", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, tasaRetencion)
			parameters(6) = new SqlParameter("@Flete", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, flete)
			parameters(7) = new SqlParameter("@MostrarDomicilio", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, mostrarDomicilio)

			' Return value parameter
			parameters(8) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("PaContUsrConfigContabilidad")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[PaContUsrConfigContabilidad]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(8).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'PaContUsrConfigContabilidad'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="func">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="cancelaPolizaNegativos">Input parameter of stored procedure</param>
		''' <param name="iva">Input parameter of stored procedure</param>
		''' <param name="isr">Input parameter of stored procedure</param>
		''' <param name="tasaRetencion">Input parameter of stored procedure</param>
		''' <param name="flete">Input parameter of stored procedure</param>
		''' <param name="mostrarDomicilio">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function PaContUsrConfigContabilidad(func As System.String, opcion As System.Int32, cancelaPolizaNegativos As System.String, iva As System.Decimal, isr As System.Decimal, tasaRetencion As System.Decimal, flete As System.Decimal, mostrarDomicilio As System.Boolean, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(8 - 1) {}
			parameters(0) = new SqlParameter("@Func", SqlDbType.Char, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, func)
			parameters(1) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(2) = new SqlParameter("@CancelaPolizaNegativos", SqlDbType.Char, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cancelaPolizaNegativos)
			parameters(3) = new SqlParameter("@IVA", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, iva)
			parameters(4) = new SqlParameter("@ISR", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, isr)
			parameters(5) = new SqlParameter("@TasaRetencion", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, tasaRetencion)
			parameters(6) = new SqlParameter("@Flete", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, flete)
			parameters(7) = new SqlParameter("@MostrarDomicilio", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, mostrarDomicilio)

			' Call the stored proc.
			Dim toReturn As New DataTable("PaContUsrConfigContabilidad")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[PaContUsrConfigContabilidad]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'PaContUsrConfigContabilidad'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="func">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="cancelaPolizaNegativos">Input parameter of stored procedure</param>
		''' <param name="iva">Input parameter of stored procedure</param>
		''' <param name="isr">Input parameter of stored procedure</param>
		''' <param name="tasaRetencion">Input parameter of stored procedure</param>
		''' <param name="flete">Input parameter of stored procedure</param>
		''' <param name="mostrarDomicilio">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function PaContUsrConfigContabilidad(func As System.String, opcion As System.Int32, cancelaPolizaNegativos As System.String, iva As System.Decimal, isr As System.Decimal, tasaRetencion As System.Decimal, flete As System.Decimal, mostrarDomicilio As System.Boolean, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(8) {}
			parameters(0) = new SqlParameter("@Func", SqlDbType.Char, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, func)
			parameters(1) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(2) = new SqlParameter("@CancelaPolizaNegativos", SqlDbType.Char, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cancelaPolizaNegativos)
			parameters(3) = new SqlParameter("@IVA", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, iva)
			parameters(4) = new SqlParameter("@ISR", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, isr)
			parameters(5) = new SqlParameter("@TasaRetencion", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, tasaRetencion)
			parameters(6) = new SqlParameter("@Flete", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, flete)
			parameters(7) = new SqlParameter("@MostrarDomicilio", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, mostrarDomicilio)

			' Return value parameter
			parameters(8) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("PaContUsrConfigContabilidad")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[PaContUsrConfigContabilidad]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(8).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'PaContUsrConfigContabilidad'.
		''' 
		''' </summary>
		''' <param name="func">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="cancelaPolizaNegativos">Input parameter of stored procedure</param>
		''' <param name="iva">Input parameter of stored procedure</param>
		''' <param name="isr">Input parameter of stored procedure</param>
		''' <param name="tasaRetencion">Input parameter of stored procedure</param>
		''' <param name="flete">Input parameter of stored procedure</param>
		''' <param name="mostrarDomicilio">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetPaContUsrConfigContabilidadCallAsQuery( func As System.String, opcion As System.Int32, cancelaPolizaNegativos As System.String, iva As System.Decimal, isr As System.Decimal, tasaRetencion As System.Decimal, flete As System.Decimal, mostrarDomicilio As System.Boolean) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[PaContUsrConfigContabilidad]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Func", SqlDbType.Char, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, func))
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@CancelaPolizaNegativos", SqlDbType.Char, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cancelaPolizaNegativos))
			toReturn.Parameters.Add(New SqlParameter("@IVA", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, iva))
			toReturn.Parameters.Add(New SqlParameter("@ISR", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, isr))
			toReturn.Parameters.Add(New SqlParameter("@TasaRetencion", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, tasaRetencion))
			toReturn.Parameters.Add(New SqlParameter("@Flete", SqlDbType.Money, 0, ParameterDirection.Input, True, 19, 4, "",  DataRowVersion.Current, flete))
			toReturn.Parameters.Add(New SqlParameter("@MostrarDomicilio", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, mostrarDomicilio))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'PaCXCEstadodeCuentaClientes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <param name="idClienteInicial">Input parameter of stored procedure</param>
		''' <param name="idClienteFinal">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function PaCxcestadodeCuentaClientes(opcion As System.Int32, fechaInicial As System.DateTime, fechaFinal As System.DateTime, idClienteInicial As System.Int32, idClienteFinal As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(5 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial)
			parameters(2) = new SqlParameter("@FechaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal)
			parameters(3) = new SqlParameter("@IdClienteInicial", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteInicial)
			parameters(4) = new SqlParameter("@IdClienteFinal", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteFinal)

			' Call the stored proc.
			Dim toReturn As New DataSet("PaCxcestadodeCuentaClientes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[PaCXCEstadodeCuentaClientes]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'PaCXCEstadodeCuentaClientes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <param name="idClienteInicial">Input parameter of stored procedure</param>
		''' <param name="idClienteFinal">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function PaCxcestadodeCuentaClientes(opcion As System.Int32, fechaInicial As System.DateTime, fechaFinal As System.DateTime, idClienteInicial As System.Int32, idClienteFinal As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(5) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial)
			parameters(2) = new SqlParameter("@FechaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal)
			parameters(3) = new SqlParameter("@IdClienteInicial", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteInicial)
			parameters(4) = new SqlParameter("@IdClienteFinal", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteFinal)

			' Return value parameter
			parameters(5) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("PaCxcestadodeCuentaClientes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[PaCXCEstadodeCuentaClientes]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(5).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'PaCXCEstadodeCuentaClientes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <param name="idClienteInicial">Input parameter of stored procedure</param>
		''' <param name="idClienteFinal">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function PaCxcestadodeCuentaClientes(opcion As System.Int32, fechaInicial As System.DateTime, fechaFinal As System.DateTime, idClienteInicial As System.Int32, idClienteFinal As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(5 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial)
			parameters(2) = new SqlParameter("@FechaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal)
			parameters(3) = new SqlParameter("@IdClienteInicial", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteInicial)
			parameters(4) = new SqlParameter("@IdClienteFinal", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteFinal)

			' Call the stored proc.
			Dim toReturn As New DataSet("PaCxcestadodeCuentaClientes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[PaCXCEstadodeCuentaClientes]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'PaCXCEstadodeCuentaClientes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <param name="idClienteInicial">Input parameter of stored procedure</param>
		''' <param name="idClienteFinal">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function PaCxcestadodeCuentaClientes(opcion As System.Int32, fechaInicial As System.DateTime, fechaFinal As System.DateTime, idClienteInicial As System.Int32, idClienteFinal As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(5) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial)
			parameters(2) = new SqlParameter("@FechaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal)
			parameters(3) = new SqlParameter("@IdClienteInicial", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteInicial)
			parameters(4) = new SqlParameter("@IdClienteFinal", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteFinal)

			' Return value parameter
			parameters(5) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("PaCxcestadodeCuentaClientes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[PaCXCEstadodeCuentaClientes]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(5).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'PaCXCEstadodeCuentaClientes'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <param name="idClienteInicial">Input parameter of stored procedure</param>
		''' <param name="idClienteFinal">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetPaCxcestadodeCuentaClientesCallAsQuery( opcion As System.Int32, fechaInicial As System.DateTime, fechaFinal As System.DateTime, idClienteInicial As System.Int32, idClienteFinal As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[PaCXCEstadodeCuentaClientes]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial))
			toReturn.Parameters.Add(New SqlParameter("@FechaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal))
			toReturn.Parameters.Add(New SqlParameter("@IdClienteInicial", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteInicial))
			toReturn.Parameters.Add(New SqlParameter("@IdClienteFinal", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteFinal))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'PaCXCMovimientosxCliente'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="fechaCorte">Input parameter of stored procedure</param>
		''' <param name="idClienteInicial">Input parameter of stored procedure</param>
		''' <param name="idClienteFinal">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function PaCxcmovimientosxCliente(fechaCorte As System.DateTime, idClienteInicial As System.Int32, idClienteFinal As System.Int32) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@FechaCorte", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaCorte)
			parameters(1) = new SqlParameter("@IdClienteInicial", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteInicial)
			parameters(2) = new SqlParameter("@IdClienteFinal", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteFinal)

			' Call the stored proc.
			Dim toReturn As New DataTable("PaCxcmovimientosxCliente")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[PaCXCMovimientosxCliente]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'PaCXCMovimientosxCliente'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="fechaCorte">Input parameter of stored procedure</param>
		''' <param name="idClienteInicial">Input parameter of stored procedure</param>
		''' <param name="idClienteFinal">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function PaCxcmovimientosxCliente(fechaCorte As System.DateTime, idClienteInicial As System.Int32, idClienteFinal As System.Int32, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@FechaCorte", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaCorte)
			parameters(1) = new SqlParameter("@IdClienteInicial", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteInicial)
			parameters(2) = new SqlParameter("@IdClienteFinal", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteFinal)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("PaCxcmovimientosxCliente")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[PaCXCMovimientosxCliente]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'PaCXCMovimientosxCliente'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="fechaCorte">Input parameter of stored procedure</param>
		''' <param name="idClienteInicial">Input parameter of stored procedure</param>
		''' <param name="idClienteFinal">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function PaCxcmovimientosxCliente(fechaCorte As System.DateTime, idClienteInicial As System.Int32, idClienteFinal As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@FechaCorte", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaCorte)
			parameters(1) = new SqlParameter("@IdClienteInicial", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteInicial)
			parameters(2) = new SqlParameter("@IdClienteFinal", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteFinal)

			' Call the stored proc.
			Dim toReturn As New DataTable("PaCxcmovimientosxCliente")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[PaCXCMovimientosxCliente]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'PaCXCMovimientosxCliente'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="fechaCorte">Input parameter of stored procedure</param>
		''' <param name="idClienteInicial">Input parameter of stored procedure</param>
		''' <param name="idClienteFinal">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function PaCxcmovimientosxCliente(fechaCorte As System.DateTime, idClienteInicial As System.Int32, idClienteFinal As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@FechaCorte", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaCorte)
			parameters(1) = new SqlParameter("@IdClienteInicial", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteInicial)
			parameters(2) = new SqlParameter("@IdClienteFinal", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteFinal)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("PaCxcmovimientosxCliente")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[PaCXCMovimientosxCliente]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'PaCXCMovimientosxCliente'.
		''' 
		''' </summary>
		''' <param name="fechaCorte">Input parameter of stored procedure</param>
		''' <param name="idClienteInicial">Input parameter of stored procedure</param>
		''' <param name="idClienteFinal">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetPaCxcmovimientosxClienteCallAsQuery( fechaCorte As System.DateTime, idClienteInicial As System.Int32, idClienteFinal As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[PaCXCMovimientosxCliente]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@FechaCorte", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaCorte))
			toReturn.Parameters.Add(New SqlParameter("@IdClienteInicial", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteInicial))
			toReturn.Parameters.Add(New SqlParameter("@IdClienteFinal", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteFinal))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'PaCXCSaldosCliente'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="fechaCorte">Input parameter of stored procedure</param>
		''' <param name="idClienteInicial">Input parameter of stored procedure</param>
		''' <param name="idClienteFinal">Input parameter of stored procedure</param>
		''' <param name="validar17">Input parameter of stored procedure</param>
		''' <param name="validar815">Input parameter of stored procedure</param>
		''' <param name="validar1630">Input parameter of stored procedure</param>
		''' <param name="validar31">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function PaCxcsaldosCliente(opcion As System.Int32, fechaCorte As System.DateTime, idClienteInicial As System.Int32, idClienteFinal As System.Int32, validar17 As System.Boolean, validar815 As System.Boolean, validar1630 As System.Boolean, validar31 As System.Boolean) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(8 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@FechaCorte", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaCorte)
			parameters(2) = new SqlParameter("@IdClienteInicial", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteInicial)
			parameters(3) = new SqlParameter("@IdClienteFinal", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteFinal)
			parameters(4) = new SqlParameter("@Validar17", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, validar17)
			parameters(5) = new SqlParameter("@validar815", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, validar815)
			parameters(6) = new SqlParameter("@Validar1630", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, validar1630)
			parameters(7) = new SqlParameter("@Validar31", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, validar31)

			' Call the stored proc.
			Dim toReturn As New DataSet("PaCxcsaldosCliente")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[PaCXCSaldosCliente]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'PaCXCSaldosCliente'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="fechaCorte">Input parameter of stored procedure</param>
		''' <param name="idClienteInicial">Input parameter of stored procedure</param>
		''' <param name="idClienteFinal">Input parameter of stored procedure</param>
		''' <param name="validar17">Input parameter of stored procedure</param>
		''' <param name="validar815">Input parameter of stored procedure</param>
		''' <param name="validar1630">Input parameter of stored procedure</param>
		''' <param name="validar31">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function PaCxcsaldosCliente(opcion As System.Int32, fechaCorte As System.DateTime, idClienteInicial As System.Int32, idClienteFinal As System.Int32, validar17 As System.Boolean, validar815 As System.Boolean, validar1630 As System.Boolean, validar31 As System.Boolean, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(8) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@FechaCorte", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaCorte)
			parameters(2) = new SqlParameter("@IdClienteInicial", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteInicial)
			parameters(3) = new SqlParameter("@IdClienteFinal", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteFinal)
			parameters(4) = new SqlParameter("@Validar17", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, validar17)
			parameters(5) = new SqlParameter("@validar815", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, validar815)
			parameters(6) = new SqlParameter("@Validar1630", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, validar1630)
			parameters(7) = new SqlParameter("@Validar31", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, validar31)

			' Return value parameter
			parameters(8) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("PaCxcsaldosCliente")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[PaCXCSaldosCliente]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(8).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'PaCXCSaldosCliente'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="fechaCorte">Input parameter of stored procedure</param>
		''' <param name="idClienteInicial">Input parameter of stored procedure</param>
		''' <param name="idClienteFinal">Input parameter of stored procedure</param>
		''' <param name="validar17">Input parameter of stored procedure</param>
		''' <param name="validar815">Input parameter of stored procedure</param>
		''' <param name="validar1630">Input parameter of stored procedure</param>
		''' <param name="validar31">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function PaCxcsaldosCliente(opcion As System.Int32, fechaCorte As System.DateTime, idClienteInicial As System.Int32, idClienteFinal As System.Int32, validar17 As System.Boolean, validar815 As System.Boolean, validar1630 As System.Boolean, validar31 As System.Boolean, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(8 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@FechaCorte", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaCorte)
			parameters(2) = new SqlParameter("@IdClienteInicial", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteInicial)
			parameters(3) = new SqlParameter("@IdClienteFinal", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteFinal)
			parameters(4) = new SqlParameter("@Validar17", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, validar17)
			parameters(5) = new SqlParameter("@validar815", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, validar815)
			parameters(6) = new SqlParameter("@Validar1630", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, validar1630)
			parameters(7) = new SqlParameter("@Validar31", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, validar31)

			' Call the stored proc.
			Dim toReturn As New DataSet("PaCxcsaldosCliente")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[PaCXCSaldosCliente]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'PaCXCSaldosCliente'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="fechaCorte">Input parameter of stored procedure</param>
		''' <param name="idClienteInicial">Input parameter of stored procedure</param>
		''' <param name="idClienteFinal">Input parameter of stored procedure</param>
		''' <param name="validar17">Input parameter of stored procedure</param>
		''' <param name="validar815">Input parameter of stored procedure</param>
		''' <param name="validar1630">Input parameter of stored procedure</param>
		''' <param name="validar31">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function PaCxcsaldosCliente(opcion As System.Int32, fechaCorte As System.DateTime, idClienteInicial As System.Int32, idClienteFinal As System.Int32, validar17 As System.Boolean, validar815 As System.Boolean, validar1630 As System.Boolean, validar31 As System.Boolean, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(8) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@FechaCorte", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaCorte)
			parameters(2) = new SqlParameter("@IdClienteInicial", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteInicial)
			parameters(3) = new SqlParameter("@IdClienteFinal", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteFinal)
			parameters(4) = new SqlParameter("@Validar17", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, validar17)
			parameters(5) = new SqlParameter("@validar815", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, validar815)
			parameters(6) = new SqlParameter("@Validar1630", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, validar1630)
			parameters(7) = new SqlParameter("@Validar31", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, validar31)

			' Return value parameter
			parameters(8) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("PaCxcsaldosCliente")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[PaCXCSaldosCliente]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(8).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'PaCXCSaldosCliente'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="fechaCorte">Input parameter of stored procedure</param>
		''' <param name="idClienteInicial">Input parameter of stored procedure</param>
		''' <param name="idClienteFinal">Input parameter of stored procedure</param>
		''' <param name="validar17">Input parameter of stored procedure</param>
		''' <param name="validar815">Input parameter of stored procedure</param>
		''' <param name="validar1630">Input parameter of stored procedure</param>
		''' <param name="validar31">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetPaCxcsaldosClienteCallAsQuery( opcion As System.Int32, fechaCorte As System.DateTime, idClienteInicial As System.Int32, idClienteFinal As System.Int32, validar17 As System.Boolean, validar815 As System.Boolean, validar1630 As System.Boolean, validar31 As System.Boolean) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[PaCXCSaldosCliente]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@FechaCorte", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaCorte))
			toReturn.Parameters.Add(New SqlParameter("@IdClienteInicial", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteInicial))
			toReturn.Parameters.Add(New SqlParameter("@IdClienteFinal", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idClienteFinal))
			toReturn.Parameters.Add(New SqlParameter("@Validar17", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, validar17))
			toReturn.Parameters.Add(New SqlParameter("@validar815", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, validar815))
			toReturn.Parameters.Add(New SqlParameter("@Validar1630", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, validar1630))
			toReturn.Parameters.Add(New SqlParameter("@Validar31", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, validar31))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'RptCanal_Corte'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioLoteCorte">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function RptCanalCorte(folioLoteCorte As System.String, fechaInicial As System.DateTime, fechaFinal As System.DateTime) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@FolioLoteCorte", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioLoteCorte)
			parameters(1) = new SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial)
			parameters(2) = new SqlParameter("@FechaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal)

			' Call the stored proc.
			Dim toReturn As New DataTable("RptCanalCorte")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[RptCanal_Corte]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'RptCanal_Corte'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioLoteCorte">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function RptCanalCorte(folioLoteCorte As System.String, fechaInicial As System.DateTime, fechaFinal As System.DateTime, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@FolioLoteCorte", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioLoteCorte)
			parameters(1) = new SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial)
			parameters(2) = new SqlParameter("@FechaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("RptCanalCorte")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[RptCanal_Corte]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'RptCanal_Corte'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioLoteCorte">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function RptCanalCorte(folioLoteCorte As System.String, fechaInicial As System.DateTime, fechaFinal As System.DateTime, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@FolioLoteCorte", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioLoteCorte)
			parameters(1) = new SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial)
			parameters(2) = new SqlParameter("@FechaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal)

			' Call the stored proc.
			Dim toReturn As New DataTable("RptCanalCorte")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[RptCanal_Corte]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'RptCanal_Corte'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioLoteCorte">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function RptCanalCorte(folioLoteCorte As System.String, fechaInicial As System.DateTime, fechaFinal As System.DateTime, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@FolioLoteCorte", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioLoteCorte)
			parameters(1) = new SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial)
			parameters(2) = new SqlParameter("@FechaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("RptCanalCorte")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[RptCanal_Corte]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'RptCanal_Corte'.
		''' 
		''' </summary>
		''' <param name="folioLoteCorte">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetRptCanalCorteCallAsQuery( folioLoteCorte As System.String, fechaInicial As System.DateTime, fechaFinal As System.DateTime) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[RptCanal_Corte]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@FolioLoteCorte", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioLoteCorte))
			toReturn.Parameters.Add(New SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial))
			toReturn.Parameters.Add(New SqlParameter("@FechaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'RptIntegral'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioSacrificio">Input parameter of stored procedure</param>
		''' <param name="folioMoviemiento">Input parameter of stored procedure</param>
		''' <param name="loteCorte">Input parameter of stored procedure</param>
		''' <param name="totalPzas">Input parameter of stored procedure</param>
		''' <param name="totalKilos">Input parameter of stored procedure</param>
		''' <param name="folioEmbarque">Input parameter of stored procedure</param>
		''' <param name="kilosEnCorte">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function RptIntegral(folioSacrificio As System.String, folioMoviemiento As System.String, loteCorte As System.String, totalPzas As System.Decimal, totalKilos As System.Decimal, folioEmbarque As System.String, kilosEnCorte As System.Decimal, opcion As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(8 - 1) {}
			parameters(0) = new SqlParameter("@FolioSacrificio", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioSacrificio)
			parameters(1) = new SqlParameter("@FolioMoviemiento", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioMoviemiento)
			parameters(2) = new SqlParameter("@LoteCorte", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteCorte)
			parameters(3) = new SqlParameter("@TotalPzas", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "",  DataRowVersion.Current, totalPzas)
			parameters(4) = new SqlParameter("@TotalKilos", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "",  DataRowVersion.Current, totalKilos)
			parameters(5) = new SqlParameter("@FolioEmbarque", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioEmbarque)
			parameters(6) = new SqlParameter("@KilosEnCorte", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "",  DataRowVersion.Current, kilosEnCorte)
			parameters(7) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Call the stored proc.
			Dim toReturn As New DataSet("RptIntegral")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[RptIntegral]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'RptIntegral'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioSacrificio">Input parameter of stored procedure</param>
		''' <param name="folioMoviemiento">Input parameter of stored procedure</param>
		''' <param name="loteCorte">Input parameter of stored procedure</param>
		''' <param name="totalPzas">Input parameter of stored procedure</param>
		''' <param name="totalKilos">Input parameter of stored procedure</param>
		''' <param name="folioEmbarque">Input parameter of stored procedure</param>
		''' <param name="kilosEnCorte">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function RptIntegral(folioSacrificio As System.String, folioMoviemiento As System.String, loteCorte As System.String, totalPzas As System.Decimal, totalKilos As System.Decimal, folioEmbarque As System.String, kilosEnCorte As System.Decimal, opcion As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(8) {}
			parameters(0) = new SqlParameter("@FolioSacrificio", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioSacrificio)
			parameters(1) = new SqlParameter("@FolioMoviemiento", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioMoviemiento)
			parameters(2) = new SqlParameter("@LoteCorte", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteCorte)
			parameters(3) = new SqlParameter("@TotalPzas", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "",  DataRowVersion.Current, totalPzas)
			parameters(4) = new SqlParameter("@TotalKilos", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "",  DataRowVersion.Current, totalKilos)
			parameters(5) = new SqlParameter("@FolioEmbarque", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioEmbarque)
			parameters(6) = new SqlParameter("@KilosEnCorte", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "",  DataRowVersion.Current, kilosEnCorte)
			parameters(7) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Return value parameter
			parameters(8) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("RptIntegral")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[RptIntegral]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(8).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'RptIntegral'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioSacrificio">Input parameter of stored procedure</param>
		''' <param name="folioMoviemiento">Input parameter of stored procedure</param>
		''' <param name="loteCorte">Input parameter of stored procedure</param>
		''' <param name="totalPzas">Input parameter of stored procedure</param>
		''' <param name="totalKilos">Input parameter of stored procedure</param>
		''' <param name="folioEmbarque">Input parameter of stored procedure</param>
		''' <param name="kilosEnCorte">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function RptIntegral(folioSacrificio As System.String, folioMoviemiento As System.String, loteCorte As System.String, totalPzas As System.Decimal, totalKilos As System.Decimal, folioEmbarque As System.String, kilosEnCorte As System.Decimal, opcion As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(8 - 1) {}
			parameters(0) = new SqlParameter("@FolioSacrificio", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioSacrificio)
			parameters(1) = new SqlParameter("@FolioMoviemiento", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioMoviemiento)
			parameters(2) = new SqlParameter("@LoteCorte", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteCorte)
			parameters(3) = new SqlParameter("@TotalPzas", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "",  DataRowVersion.Current, totalPzas)
			parameters(4) = new SqlParameter("@TotalKilos", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "",  DataRowVersion.Current, totalKilos)
			parameters(5) = new SqlParameter("@FolioEmbarque", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioEmbarque)
			parameters(6) = new SqlParameter("@KilosEnCorte", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "",  DataRowVersion.Current, kilosEnCorte)
			parameters(7) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Call the stored proc.
			Dim toReturn As New DataSet("RptIntegral")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[RptIntegral]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'RptIntegral'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioSacrificio">Input parameter of stored procedure</param>
		''' <param name="folioMoviemiento">Input parameter of stored procedure</param>
		''' <param name="loteCorte">Input parameter of stored procedure</param>
		''' <param name="totalPzas">Input parameter of stored procedure</param>
		''' <param name="totalKilos">Input parameter of stored procedure</param>
		''' <param name="folioEmbarque">Input parameter of stored procedure</param>
		''' <param name="kilosEnCorte">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function RptIntegral(folioSacrificio As System.String, folioMoviemiento As System.String, loteCorte As System.String, totalPzas As System.Decimal, totalKilos As System.Decimal, folioEmbarque As System.String, kilosEnCorte As System.Decimal, opcion As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(8) {}
			parameters(0) = new SqlParameter("@FolioSacrificio", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioSacrificio)
			parameters(1) = new SqlParameter("@FolioMoviemiento", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioMoviemiento)
			parameters(2) = new SqlParameter("@LoteCorte", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteCorte)
			parameters(3) = new SqlParameter("@TotalPzas", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "",  DataRowVersion.Current, totalPzas)
			parameters(4) = new SqlParameter("@TotalKilos", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "",  DataRowVersion.Current, totalKilos)
			parameters(5) = new SqlParameter("@FolioEmbarque", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioEmbarque)
			parameters(6) = new SqlParameter("@KilosEnCorte", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "",  DataRowVersion.Current, kilosEnCorte)
			parameters(7) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Return value parameter
			parameters(8) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("RptIntegral")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[RptIntegral]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(8).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'RptIntegral'.
		''' 
		''' </summary>
		''' <param name="folioSacrificio">Input parameter of stored procedure</param>
		''' <param name="folioMoviemiento">Input parameter of stored procedure</param>
		''' <param name="loteCorte">Input parameter of stored procedure</param>
		''' <param name="totalPzas">Input parameter of stored procedure</param>
		''' <param name="totalKilos">Input parameter of stored procedure</param>
		''' <param name="folioEmbarque">Input parameter of stored procedure</param>
		''' <param name="kilosEnCorte">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetRptIntegralCallAsQuery( folioSacrificio As System.String, folioMoviemiento As System.String, loteCorte As System.String, totalPzas As System.Decimal, totalKilos As System.Decimal, folioEmbarque As System.String, kilosEnCorte As System.Decimal, opcion As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[RptIntegral]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@FolioSacrificio", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioSacrificio))
			toReturn.Parameters.Add(New SqlParameter("@FolioMoviemiento", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioMoviemiento))
			toReturn.Parameters.Add(New SqlParameter("@LoteCorte", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteCorte))
			toReturn.Parameters.Add(New SqlParameter("@TotalPzas", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "",  DataRowVersion.Current, totalPzas))
			toReturn.Parameters.Add(New SqlParameter("@TotalKilos", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "",  DataRowVersion.Current, totalKilos))
			toReturn.Parameters.Add(New SqlParameter("@FolioEmbarque", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioEmbarque))
			toReturn.Parameters.Add(New SqlParameter("@KilosEnCorte", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "",  DataRowVersion.Current, kilosEnCorte))
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'RptIntegral2'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioSacrificio">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function RptIntegral2(folioSacrificio As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@FolioSacrificio", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioSacrificio)

			' Call the stored proc.
			Dim toReturn As New DataSet("RptIntegral2")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[RptIntegral2]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'RptIntegral2'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioSacrificio">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function RptIntegral2(folioSacrificio As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@FolioSacrificio", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioSacrificio)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("RptIntegral2")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[RptIntegral2]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'RptIntegral2'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioSacrificio">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function RptIntegral2(folioSacrificio As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@FolioSacrificio", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioSacrificio)

			' Call the stored proc.
			Dim toReturn As New DataSet("RptIntegral2")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[RptIntegral2]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'RptIntegral2'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioSacrificio">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function RptIntegral2(folioSacrificio As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@FolioSacrificio", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioSacrificio)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("RptIntegral2")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[RptIntegral2]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'RptIntegral2'.
		''' 
		''' </summary>
		''' <param name="folioSacrificio">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetRptIntegral2CallAsQuery( folioSacrificio As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[RptIntegral2]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@FolioSacrificio", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioSacrificio))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_CatAlmProdRas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveAlm">Input parameter of stored procedure</param>
		''' <param name="nomAlm">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatAlmProdRas(numOpc As System.Int32, cveAlm As System.Int32, nomAlm As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveAlm", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveAlm)
			parameters(2) = new SqlParameter("@NomAlm", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomAlm)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatAlmProdRas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatAlmProdRas]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_CatAlmProdRas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveAlm">Input parameter of stored procedure</param>
		''' <param name="nomAlm">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatAlmProdRas(numOpc As System.Int32, cveAlm As System.Int32, nomAlm As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveAlm", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveAlm)
			parameters(2) = new SqlParameter("@NomAlm", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomAlm)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatAlmProdRas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatAlmProdRas]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_CatAlmProdRas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveAlm">Input parameter of stored procedure</param>
		''' <param name="nomAlm">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatAlmProdRas(numOpc As System.Int32, cveAlm As System.Int32, nomAlm As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveAlm", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveAlm)
			parameters(2) = new SqlParameter("@NomAlm", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomAlm)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatAlmProdRas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatAlmProdRas]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_CatAlmProdRas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveAlm">Input parameter of stored procedure</param>
		''' <param name="nomAlm">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatAlmProdRas(numOpc As System.Int32, cveAlm As System.Int32, nomAlm As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveAlm", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveAlm)
			parameters(2) = new SqlParameter("@NomAlm", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomAlm)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatAlmProdRas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatAlmProdRas]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_CatAlmProdRas'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveAlm">Input parameter of stored procedure</param>
		''' <param name="nomAlm">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconCatAlmProdRasCallAsQuery( numOpc As System.Int32, cveAlm As System.Int32, nomAlm As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_CatAlmProdRas]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@CveAlm", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveAlm))
			toReturn.Parameters.Add(New SqlParameter("@NomAlm", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomAlm))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_CatCiudades'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveEstado">Input parameter of stored procedure</param>
		''' <param name="cveCiudad">Input parameter of stored procedure</param>
		''' <param name="nomCiuEdo">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatCiudades(numOpc As System.Int32, cveEstado As System.Int32, cveCiudad As System.Int32, nomCiuEdo As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveEstado)
			parameters(2) = new SqlParameter("@CveCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCiudad)
			parameters(3) = new SqlParameter("@NomCiuEdo", SqlDbType.Char, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiuEdo)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatCiudades")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatCiudades]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_CatCiudades'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveEstado">Input parameter of stored procedure</param>
		''' <param name="cveCiudad">Input parameter of stored procedure</param>
		''' <param name="nomCiuEdo">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatCiudades(numOpc As System.Int32, cveEstado As System.Int32, cveCiudad As System.Int32, nomCiuEdo As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveEstado)
			parameters(2) = new SqlParameter("@CveCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCiudad)
			parameters(3) = new SqlParameter("@NomCiuEdo", SqlDbType.Char, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiuEdo)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatCiudades")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatCiudades]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_CatCiudades'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveEstado">Input parameter of stored procedure</param>
		''' <param name="cveCiudad">Input parameter of stored procedure</param>
		''' <param name="nomCiuEdo">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatCiudades(numOpc As System.Int32, cveEstado As System.Int32, cveCiudad As System.Int32, nomCiuEdo As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveEstado)
			parameters(2) = new SqlParameter("@CveCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCiudad)
			parameters(3) = new SqlParameter("@NomCiuEdo", SqlDbType.Char, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiuEdo)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatCiudades")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatCiudades]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_CatCiudades'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveEstado">Input parameter of stored procedure</param>
		''' <param name="cveCiudad">Input parameter of stored procedure</param>
		''' <param name="nomCiuEdo">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatCiudades(numOpc As System.Int32, cveEstado As System.Int32, cveCiudad As System.Int32, nomCiuEdo As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveEstado)
			parameters(2) = new SqlParameter("@CveCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCiudad)
			parameters(3) = new SqlParameter("@NomCiuEdo", SqlDbType.Char, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiuEdo)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatCiudades")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatCiudades]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_CatCiudades'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveEstado">Input parameter of stored procedure</param>
		''' <param name="cveCiudad">Input parameter of stored procedure</param>
		''' <param name="nomCiuEdo">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconCatCiudadesCallAsQuery( numOpc As System.Int32, cveEstado As System.Int32, cveCiudad As System.Int32, nomCiuEdo As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_CatCiudades]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@CveEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveEstado))
			toReturn.Parameters.Add(New SqlParameter("@CveCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCiudad))
			toReturn.Parameters.Add(New SqlParameter("@NomCiuEdo", SqlDbType.Char, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiuEdo))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_CatCiuEdo'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="nomCiuEdo">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatCiuEdo(numOpc As System.Int32, nomCiuEdo As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@NomCiuEdo", SqlDbType.Char, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiuEdo)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatCiuEdo")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatCiuEdo]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_CatCiuEdo'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="nomCiuEdo">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatCiuEdo(numOpc As System.Int32, nomCiuEdo As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@NomCiuEdo", SqlDbType.Char, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiuEdo)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatCiuEdo")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatCiuEdo]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_CatCiuEdo'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="nomCiuEdo">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatCiuEdo(numOpc As System.Int32, nomCiuEdo As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@NomCiuEdo", SqlDbType.Char, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiuEdo)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatCiuEdo")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatCiuEdo]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_CatCiuEdo'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="nomCiuEdo">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatCiuEdo(numOpc As System.Int32, nomCiuEdo As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@NomCiuEdo", SqlDbType.Char, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiuEdo)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatCiuEdo")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatCiuEdo]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_CatCiuEdo'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="nomCiuEdo">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconCatCiuEdoCallAsQuery( numOpc As System.Int32, nomCiuEdo As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_CatCiuEdo]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@NomCiuEdo", SqlDbType.Char, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiuEdo))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_CatCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCorte">Input parameter of stored procedure</param>
		''' <param name="nomCorte">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatCortes(numOpc As System.Int32, cveCorte As System.Int32, nomCorte As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveCorte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCorte)
			parameters(2) = new SqlParameter("@NomCorte", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCorte)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatCortes]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_CatCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCorte">Input parameter of stored procedure</param>
		''' <param name="nomCorte">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatCortes(numOpc As System.Int32, cveCorte As System.Int32, nomCorte As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveCorte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCorte)
			parameters(2) = new SqlParameter("@NomCorte", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCorte)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatCortes]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_CatCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCorte">Input parameter of stored procedure</param>
		''' <param name="nomCorte">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatCortes(numOpc As System.Int32, cveCorte As System.Int32, nomCorte As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveCorte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCorte)
			parameters(2) = new SqlParameter("@NomCorte", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCorte)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatCortes]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_CatCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCorte">Input parameter of stored procedure</param>
		''' <param name="nomCorte">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatCortes(numOpc As System.Int32, cveCorte As System.Int32, nomCorte As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveCorte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCorte)
			parameters(2) = new SqlParameter("@NomCorte", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCorte)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatCortes]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_CatCortes'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCorte">Input parameter of stored procedure</param>
		''' <param name="nomCorte">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconCatCortesCallAsQuery( numOpc As System.Int32, cveCorte As System.Int32, nomCorte As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_CatCortes]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@CveCorte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCorte))
			toReturn.Parameters.Add(New SqlParameter("@NomCorte", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCorte))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_CatCtaCont'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="ctaCont">Input parameter of stored procedure</param>
		''' <param name="nomCtaCont">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatCtaCont(numOpc As System.Int32, ctaCont As System.String, nomCtaCont As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CtaCont", SqlDbType.VarChar, 16, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, ctaCont)
			parameters(2) = new SqlParameter("@NomCtaCont", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCtaCont)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatCtaCont")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatCtaCont]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_CatCtaCont'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="ctaCont">Input parameter of stored procedure</param>
		''' <param name="nomCtaCont">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatCtaCont(numOpc As System.Int32, ctaCont As System.String, nomCtaCont As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CtaCont", SqlDbType.VarChar, 16, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, ctaCont)
			parameters(2) = new SqlParameter("@NomCtaCont", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCtaCont)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatCtaCont")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatCtaCont]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_CatCtaCont'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="ctaCont">Input parameter of stored procedure</param>
		''' <param name="nomCtaCont">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatCtaCont(numOpc As System.Int32, ctaCont As System.String, nomCtaCont As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CtaCont", SqlDbType.VarChar, 16, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, ctaCont)
			parameters(2) = new SqlParameter("@NomCtaCont", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCtaCont)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatCtaCont")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatCtaCont]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_CatCtaCont'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="ctaCont">Input parameter of stored procedure</param>
		''' <param name="nomCtaCont">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatCtaCont(numOpc As System.Int32, ctaCont As System.String, nomCtaCont As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CtaCont", SqlDbType.VarChar, 16, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, ctaCont)
			parameters(2) = new SqlParameter("@NomCtaCont", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCtaCont)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatCtaCont")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatCtaCont]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_CatCtaCont'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="ctaCont">Input parameter of stored procedure</param>
		''' <param name="nomCtaCont">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconCatCtaContCallAsQuery( numOpc As System.Int32, ctaCont As System.String, nomCtaCont As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_CatCtaCont]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@CtaCont", SqlDbType.VarChar, 16, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, ctaCont))
			toReturn.Parameters.Add(New SqlParameter("@NomCtaCont", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCtaCont))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_CatEstados'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveEstado">Input parameter of stored procedure</param>
		''' <param name="nomCiuEdo">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatEstados(numOpc As System.Int32, cveEstado As System.Int32, nomCiuEdo As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveEstado)
			parameters(2) = new SqlParameter("@NomCiuEdo", SqlDbType.Char, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiuEdo)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatEstados")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatEstados]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_CatEstados'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveEstado">Input parameter of stored procedure</param>
		''' <param name="nomCiuEdo">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatEstados(numOpc As System.Int32, cveEstado As System.Int32, nomCiuEdo As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveEstado)
			parameters(2) = new SqlParameter("@NomCiuEdo", SqlDbType.Char, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiuEdo)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatEstados")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatEstados]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_CatEstados'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveEstado">Input parameter of stored procedure</param>
		''' <param name="nomCiuEdo">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatEstados(numOpc As System.Int32, cveEstado As System.Int32, nomCiuEdo As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveEstado)
			parameters(2) = new SqlParameter("@NomCiuEdo", SqlDbType.Char, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiuEdo)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatEstados")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatEstados]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_CatEstados'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveEstado">Input parameter of stored procedure</param>
		''' <param name="nomCiuEdo">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatEstados(numOpc As System.Int32, cveEstado As System.Int32, nomCiuEdo As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveEstado)
			parameters(2) = new SqlParameter("@NomCiuEdo", SqlDbType.Char, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiuEdo)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatEstados")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatEstados]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_CatEstados'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveEstado">Input parameter of stored procedure</param>
		''' <param name="nomCiuEdo">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconCatEstadosCallAsQuery( numOpc As System.Int32, cveEstado As System.Int32, nomCiuEdo As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_CatEstados]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@CveEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveEstado))
			toReturn.Parameters.Add(New SqlParameter("@NomCiuEdo", SqlDbType.Char, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiuEdo))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_CatPoblaciones'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cvePoblacion">Input parameter of stored procedure</param>
		''' <param name="cveEstado">Input parameter of stored procedure</param>
		''' <param name="cveCiudad">Input parameter of stored procedure</param>
		''' <param name="nomCiuEdo">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatPoblaciones(numOpc As System.Int32, cvePoblacion As System.Int32, cveEstado As System.Int32, cveCiudad As System.Int32, nomCiuEdo As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(5 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CvePoblacion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cvePoblacion)
			parameters(2) = new SqlParameter("@CveEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveEstado)
			parameters(3) = new SqlParameter("@CveCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCiudad)
			parameters(4) = new SqlParameter("@NomCiuEdo", SqlDbType.Char, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiuEdo)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatPoblaciones")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatPoblaciones]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_CatPoblaciones'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cvePoblacion">Input parameter of stored procedure</param>
		''' <param name="cveEstado">Input parameter of stored procedure</param>
		''' <param name="cveCiudad">Input parameter of stored procedure</param>
		''' <param name="nomCiuEdo">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatPoblaciones(numOpc As System.Int32, cvePoblacion As System.Int32, cveEstado As System.Int32, cveCiudad As System.Int32, nomCiuEdo As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(5) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CvePoblacion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cvePoblacion)
			parameters(2) = new SqlParameter("@CveEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveEstado)
			parameters(3) = new SqlParameter("@CveCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCiudad)
			parameters(4) = new SqlParameter("@NomCiuEdo", SqlDbType.Char, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiuEdo)

			' Return value parameter
			parameters(5) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatPoblaciones")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatPoblaciones]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(5).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_CatPoblaciones'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cvePoblacion">Input parameter of stored procedure</param>
		''' <param name="cveEstado">Input parameter of stored procedure</param>
		''' <param name="cveCiudad">Input parameter of stored procedure</param>
		''' <param name="nomCiuEdo">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatPoblaciones(numOpc As System.Int32, cvePoblacion As System.Int32, cveEstado As System.Int32, cveCiudad As System.Int32, nomCiuEdo As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(5 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CvePoblacion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cvePoblacion)
			parameters(2) = new SqlParameter("@CveEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveEstado)
			parameters(3) = new SqlParameter("@CveCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCiudad)
			parameters(4) = new SqlParameter("@NomCiuEdo", SqlDbType.Char, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiuEdo)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatPoblaciones")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatPoblaciones]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_CatPoblaciones'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cvePoblacion">Input parameter of stored procedure</param>
		''' <param name="cveEstado">Input parameter of stored procedure</param>
		''' <param name="cveCiudad">Input parameter of stored procedure</param>
		''' <param name="nomCiuEdo">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatPoblaciones(numOpc As System.Int32, cvePoblacion As System.Int32, cveEstado As System.Int32, cveCiudad As System.Int32, nomCiuEdo As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(5) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CvePoblacion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cvePoblacion)
			parameters(2) = new SqlParameter("@CveEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveEstado)
			parameters(3) = new SqlParameter("@CveCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCiudad)
			parameters(4) = new SqlParameter("@NomCiuEdo", SqlDbType.Char, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiuEdo)

			' Return value parameter
			parameters(5) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatPoblaciones")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatPoblaciones]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(5).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_CatPoblaciones'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cvePoblacion">Input parameter of stored procedure</param>
		''' <param name="cveEstado">Input parameter of stored procedure</param>
		''' <param name="cveCiudad">Input parameter of stored procedure</param>
		''' <param name="nomCiuEdo">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconCatPoblacionesCallAsQuery( numOpc As System.Int32, cvePoblacion As System.Int32, cveEstado As System.Int32, cveCiudad As System.Int32, nomCiuEdo As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_CatPoblaciones]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@CvePoblacion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cvePoblacion))
			toReturn.Parameters.Add(New SqlParameter("@CveEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveEstado))
			toReturn.Parameters.Add(New SqlParameter("@CveCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCiudad))
			toReturn.Parameters.Add(New SqlParameter("@NomCiuEdo", SqlDbType.Char, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiuEdo))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_CatProdRas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveProdRas">Input parameter of stored procedure</param>
		''' <param name="nomProdRas">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatProdRas(numOpc As System.Int32, cveProdRas As System.Int32, nomProdRas As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveProdRas", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveProdRas)
			parameters(2) = new SqlParameter("@NomProdRas", SqlDbType.Char, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomProdRas)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatProdRas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatProdRas]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_CatProdRas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveProdRas">Input parameter of stored procedure</param>
		''' <param name="nomProdRas">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatProdRas(numOpc As System.Int32, cveProdRas As System.Int32, nomProdRas As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveProdRas", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveProdRas)
			parameters(2) = new SqlParameter("@NomProdRas", SqlDbType.Char, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomProdRas)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatProdRas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatProdRas]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_CatProdRas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveProdRas">Input parameter of stored procedure</param>
		''' <param name="nomProdRas">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatProdRas(numOpc As System.Int32, cveProdRas As System.Int32, nomProdRas As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveProdRas", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveProdRas)
			parameters(2) = new SqlParameter("@NomProdRas", SqlDbType.Char, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomProdRas)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatProdRas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatProdRas]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_CatProdRas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveProdRas">Input parameter of stored procedure</param>
		''' <param name="nomProdRas">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatProdRas(numOpc As System.Int32, cveProdRas As System.Int32, nomProdRas As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveProdRas", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveProdRas)
			parameters(2) = new SqlParameter("@NomProdRas", SqlDbType.Char, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomProdRas)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatProdRas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatProdRas]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_CatProdRas'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveProdRas">Input parameter of stored procedure</param>
		''' <param name="nomProdRas">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconCatProdRasCallAsQuery( numOpc As System.Int32, cveProdRas As System.Int32, nomProdRas As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_CatProdRas]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@CveProdRas", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveProdRas))
			toReturn.Parameters.Add(New SqlParameter("@NomProdRas", SqlDbType.Char, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomProdRas))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_CatSubCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCorte">Input parameter of stored procedure</param>
		''' <param name="cveSubCorte">Input parameter of stored procedure</param>
		''' <param name="nomSubCorte">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatSubCortes(numOpc As System.Int32, cveCorte As System.Int16, cveSubCorte As System.Int16, nomSubCorte As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveCorte", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveCorte)
			parameters(2) = new SqlParameter("@CveSubCorte", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveSubCorte)
			parameters(3) = new SqlParameter("@NomSubCorte", SqlDbType.Char, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomSubCorte)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatSubCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatSubCortes]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_CatSubCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCorte">Input parameter of stored procedure</param>
		''' <param name="cveSubCorte">Input parameter of stored procedure</param>
		''' <param name="nomSubCorte">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatSubCortes(numOpc As System.Int32, cveCorte As System.Int16, cveSubCorte As System.Int16, nomSubCorte As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveCorte", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveCorte)
			parameters(2) = new SqlParameter("@CveSubCorte", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveSubCorte)
			parameters(3) = new SqlParameter("@NomSubCorte", SqlDbType.Char, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomSubCorte)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatSubCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatSubCortes]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_CatSubCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCorte">Input parameter of stored procedure</param>
		''' <param name="cveSubCorte">Input parameter of stored procedure</param>
		''' <param name="nomSubCorte">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatSubCortes(numOpc As System.Int32, cveCorte As System.Int16, cveSubCorte As System.Int16, nomSubCorte As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveCorte", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveCorte)
			parameters(2) = new SqlParameter("@CveSubCorte", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveSubCorte)
			parameters(3) = new SqlParameter("@NomSubCorte", SqlDbType.Char, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomSubCorte)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatSubCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatSubCortes]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_CatSubCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCorte">Input parameter of stored procedure</param>
		''' <param name="cveSubCorte">Input parameter of stored procedure</param>
		''' <param name="nomSubCorte">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconCatSubCortes(numOpc As System.Int32, cveCorte As System.Int16, cveSubCorte As System.Int16, nomSubCorte As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@CveCorte", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveCorte)
			parameters(2) = new SqlParameter("@CveSubCorte", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveSubCorte)
			parameters(3) = new SqlParameter("@NomSubCorte", SqlDbType.Char, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomSubCorte)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconCatSubCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_CatSubCortes]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_CatSubCortes'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCorte">Input parameter of stored procedure</param>
		''' <param name="cveSubCorte">Input parameter of stored procedure</param>
		''' <param name="nomSubCorte">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconCatSubCortesCallAsQuery( numOpc As System.Int32, cveCorte As System.Int16, cveSubCorte As System.Int16, nomSubCorte As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_CatSubCortes]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@CveCorte", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveCorte))
			toReturn.Parameters.Add(New SqlParameter("@CveSubCorte", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveSubCorte))
			toReturn.Parameters.Add(New SqlParameter("@NomSubCorte", SqlDbType.Char, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomSubCorte))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_MCECatCorralesCab'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idCorral">Input parameter of stored procedure</param>
		''' <param name="nombreCorral">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcecatCorralesCab(numOpc As System.Int32, idCorral As System.Int32, nombreCorral As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdCorral", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCorral)
			parameters(2) = new SqlParameter("@NombreCorral", SqlDbType.VarChar, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreCorral)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcecatCorralesCab")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCECatCorralesCab]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MCECatCorralesCab'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idCorral">Input parameter of stored procedure</param>
		''' <param name="nombreCorral">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcecatCorralesCab(numOpc As System.Int32, idCorral As System.Int32, nombreCorral As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdCorral", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCorral)
			parameters(2) = new SqlParameter("@NombreCorral", SqlDbType.VarChar, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreCorral)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcecatCorralesCab")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCECatCorralesCab]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_MCECatCorralesCab'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idCorral">Input parameter of stored procedure</param>
		''' <param name="nombreCorral">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcecatCorralesCab(numOpc As System.Int32, idCorral As System.Int32, nombreCorral As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdCorral", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCorral)
			parameters(2) = new SqlParameter("@NombreCorral", SqlDbType.VarChar, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreCorral)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcecatCorralesCab")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCECatCorralesCab]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MCECatCorralesCab'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idCorral">Input parameter of stored procedure</param>
		''' <param name="nombreCorral">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcecatCorralesCab(numOpc As System.Int32, idCorral As System.Int32, nombreCorral As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdCorral", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCorral)
			parameters(2) = new SqlParameter("@NombreCorral", SqlDbType.VarChar, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreCorral)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcecatCorralesCab")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCECatCorralesCab]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_MCECatCorralesCab'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idCorral">Input parameter of stored procedure</param>
		''' <param name="nombreCorral">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconMcecatCorralesCabCallAsQuery( numOpc As System.Int32, idCorral As System.Int32, nombreCorral As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_MCECatCorralesCab]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@IdCorral", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCorral))
			toReturn.Parameters.Add(New SqlParameter("@NombreCorral", SqlDbType.VarChar, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreCorral))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_MCECatCorralesDet'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idCorral">Input parameter of stored procedure</param>
		''' <param name="idTipoGanado">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcecatCorralesDet(numOpc As System.Int32, idCorral As System.Int32, idTipoGanado As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdCorral", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCorral)
			parameters(2) = new SqlParameter("@IdTipoGanado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idTipoGanado)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcecatCorralesDet")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCECatCorralesDet]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MCECatCorralesDet'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idCorral">Input parameter of stored procedure</param>
		''' <param name="idTipoGanado">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcecatCorralesDet(numOpc As System.Int32, idCorral As System.Int32, idTipoGanado As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdCorral", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCorral)
			parameters(2) = new SqlParameter("@IdTipoGanado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idTipoGanado)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcecatCorralesDet")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCECatCorralesDet]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_MCECatCorralesDet'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idCorral">Input parameter of stored procedure</param>
		''' <param name="idTipoGanado">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcecatCorralesDet(numOpc As System.Int32, idCorral As System.Int32, idTipoGanado As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdCorral", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCorral)
			parameters(2) = new SqlParameter("@IdTipoGanado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idTipoGanado)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcecatCorralesDet")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCECatCorralesDet]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MCECatCorralesDet'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idCorral">Input parameter of stored procedure</param>
		''' <param name="idTipoGanado">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcecatCorralesDet(numOpc As System.Int32, idCorral As System.Int32, idTipoGanado As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdCorral", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCorral)
			parameters(2) = new SqlParameter("@IdTipoGanado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idTipoGanado)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcecatCorralesDet")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCECatCorralesDet]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_MCECatCorralesDet'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idCorral">Input parameter of stored procedure</param>
		''' <param name="idTipoGanado">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconMcecatCorralesDetCallAsQuery( numOpc As System.Int32, idCorral As System.Int32, idTipoGanado As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_MCECatCorralesDet]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@IdCorral", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCorral))
			toReturn.Parameters.Add(New SqlParameter("@IdTipoGanado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idTipoGanado))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_MCECatLotesCab'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idLote">Input parameter of stored procedure</param>
		''' <param name="idCorral">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcecatLotesCab(numOpc As System.Int32, idLote As System.Int32, idCorral As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdLote", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idLote)
			parameters(2) = new SqlParameter("@IdCorral", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCorral)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcecatLotesCab")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCECatLotesCab]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MCECatLotesCab'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idLote">Input parameter of stored procedure</param>
		''' <param name="idCorral">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcecatLotesCab(numOpc As System.Int32, idLote As System.Int32, idCorral As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdLote", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idLote)
			parameters(2) = new SqlParameter("@IdCorral", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCorral)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcecatLotesCab")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCECatLotesCab]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_MCECatLotesCab'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idLote">Input parameter of stored procedure</param>
		''' <param name="idCorral">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcecatLotesCab(numOpc As System.Int32, idLote As System.Int32, idCorral As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdLote", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idLote)
			parameters(2) = new SqlParameter("@IdCorral", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCorral)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcecatLotesCab")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCECatLotesCab]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MCECatLotesCab'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idLote">Input parameter of stored procedure</param>
		''' <param name="idCorral">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcecatLotesCab(numOpc As System.Int32, idLote As System.Int32, idCorral As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdLote", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idLote)
			parameters(2) = new SqlParameter("@IdCorral", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCorral)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcecatLotesCab")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCECatLotesCab]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_MCECatLotesCab'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idLote">Input parameter of stored procedure</param>
		''' <param name="idCorral">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconMcecatLotesCabCallAsQuery( numOpc As System.Int32, idLote As System.Int32, idCorral As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_MCECatLotesCab]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@IdLote", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idLote))
			toReturn.Parameters.Add(New SqlParameter("@IdCorral", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCorral))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_MCECatLotesDet'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idLote">Input parameter of stored procedure</param>
		''' <param name="idTipoGanado">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcecatLotesDet(numOpc As System.Int32, idLote As System.Int32, idTipoGanado As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdLote", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idLote)
			parameters(2) = new SqlParameter("@IdTipoGanado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idTipoGanado)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcecatLotesDet")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCECatLotesDet]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MCECatLotesDet'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idLote">Input parameter of stored procedure</param>
		''' <param name="idTipoGanado">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcecatLotesDet(numOpc As System.Int32, idLote As System.Int32, idTipoGanado As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdLote", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idLote)
			parameters(2) = new SqlParameter("@IdTipoGanado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idTipoGanado)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcecatLotesDet")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCECatLotesDet]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_MCECatLotesDet'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idLote">Input parameter of stored procedure</param>
		''' <param name="idTipoGanado">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcecatLotesDet(numOpc As System.Int32, idLote As System.Int32, idTipoGanado As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdLote", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idLote)
			parameters(2) = new SqlParameter("@IdTipoGanado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idTipoGanado)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcecatLotesDet")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCECatLotesDet]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MCECatLotesDet'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idLote">Input parameter of stored procedure</param>
		''' <param name="idTipoGanado">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcecatLotesDet(numOpc As System.Int32, idLote As System.Int32, idTipoGanado As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdLote", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idLote)
			parameters(2) = new SqlParameter("@IdTipoGanado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idTipoGanado)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcecatLotesDet")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCECatLotesDet]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_MCECatLotesDet'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idLote">Input parameter of stored procedure</param>
		''' <param name="idTipoGanado">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconMcecatLotesDetCallAsQuery( numOpc As System.Int32, idLote As System.Int32, idTipoGanado As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_MCECatLotesDet]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@IdLote", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idLote))
			toReturn.Parameters.Add(New SqlParameter("@IdTipoGanado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idTipoGanado))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_MCECatTiposCorral'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idTipoCorral">Input parameter of stored procedure</param>
		''' <param name="descTipoCorral">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcecatTiposCorral(numOpc As System.Int32, idTipoCorral As System.Int32, descTipoCorral As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdTipoCorral", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idTipoCorral)
			parameters(2) = new SqlParameter("@DescTipoCorral", SqlDbType.VarChar, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descTipoCorral)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcecatTiposCorral")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCECatTiposCorral]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MCECatTiposCorral'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idTipoCorral">Input parameter of stored procedure</param>
		''' <param name="descTipoCorral">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcecatTiposCorral(numOpc As System.Int32, idTipoCorral As System.Int32, descTipoCorral As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdTipoCorral", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idTipoCorral)
			parameters(2) = new SqlParameter("@DescTipoCorral", SqlDbType.VarChar, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descTipoCorral)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcecatTiposCorral")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCECatTiposCorral]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_MCECatTiposCorral'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idTipoCorral">Input parameter of stored procedure</param>
		''' <param name="descTipoCorral">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcecatTiposCorral(numOpc As System.Int32, idTipoCorral As System.Int32, descTipoCorral As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdTipoCorral", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idTipoCorral)
			parameters(2) = new SqlParameter("@DescTipoCorral", SqlDbType.VarChar, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descTipoCorral)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcecatTiposCorral")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCECatTiposCorral]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MCECatTiposCorral'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idTipoCorral">Input parameter of stored procedure</param>
		''' <param name="descTipoCorral">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcecatTiposCorral(numOpc As System.Int32, idTipoCorral As System.Int32, descTipoCorral As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdTipoCorral", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idTipoCorral)
			parameters(2) = new SqlParameter("@DescTipoCorral", SqlDbType.VarChar, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descTipoCorral)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcecatTiposCorral")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCECatTiposCorral]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_MCECatTiposCorral'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idTipoCorral">Input parameter of stored procedure</param>
		''' <param name="descTipoCorral">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconMcecatTiposCorralCallAsQuery( numOpc As System.Int32, idTipoCorral As System.Int32, descTipoCorral As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_MCECatTiposCorral]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@IdTipoCorral", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idTipoCorral))
			toReturn.Parameters.Add(New SqlParameter("@DescTipoCorral", SqlDbType.VarChar, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descTipoCorral))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_MCGCatCausasMuerte'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idCausaMuerte">Input parameter of stored procedure</param>
		''' <param name="nombreCausaMuerte">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcgcatCausasMuerte(numOpc As System.Int32, idCausaMuerte As System.Int32, nombreCausaMuerte As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdCausaMuerte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCausaMuerte)
			parameters(2) = new SqlParameter("@NombreCausaMuerte", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreCausaMuerte)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcgcatCausasMuerte")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCGCatCausasMuerte]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MCGCatCausasMuerte'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idCausaMuerte">Input parameter of stored procedure</param>
		''' <param name="nombreCausaMuerte">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcgcatCausasMuerte(numOpc As System.Int32, idCausaMuerte As System.Int32, nombreCausaMuerte As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdCausaMuerte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCausaMuerte)
			parameters(2) = new SqlParameter("@NombreCausaMuerte", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreCausaMuerte)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcgcatCausasMuerte")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCGCatCausasMuerte]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_MCGCatCausasMuerte'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idCausaMuerte">Input parameter of stored procedure</param>
		''' <param name="nombreCausaMuerte">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcgcatCausasMuerte(numOpc As System.Int32, idCausaMuerte As System.Int32, nombreCausaMuerte As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdCausaMuerte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCausaMuerte)
			parameters(2) = new SqlParameter("@NombreCausaMuerte", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreCausaMuerte)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcgcatCausasMuerte")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCGCatCausasMuerte]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MCGCatCausasMuerte'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idCausaMuerte">Input parameter of stored procedure</param>
		''' <param name="nombreCausaMuerte">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcgcatCausasMuerte(numOpc As System.Int32, idCausaMuerte As System.Int32, nombreCausaMuerte As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdCausaMuerte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCausaMuerte)
			parameters(2) = new SqlParameter("@NombreCausaMuerte", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreCausaMuerte)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcgcatCausasMuerte")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCGCatCausasMuerte]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_MCGCatCausasMuerte'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idCausaMuerte">Input parameter of stored procedure</param>
		''' <param name="nombreCausaMuerte">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconMcgcatCausasMuerteCallAsQuery( numOpc As System.Int32, idCausaMuerte As System.Int32, nombreCausaMuerte As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_MCGCatCausasMuerte]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@IdCausaMuerte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCausaMuerte))
			toReturn.Parameters.Add(New SqlParameter("@NombreCausaMuerte", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreCausaMuerte))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_MCGCatChoferes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idChofer">Input parameter of stored procedure</param>
		''' <param name="nombreChofer">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcgcatChoferes(numOpc As System.Int32, idChofer As System.Int32, nombreChofer As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdChofer", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idChofer)
			parameters(2) = new SqlParameter("@NombreChofer", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreChofer)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcgcatChoferes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCGCatChoferes]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MCGCatChoferes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idChofer">Input parameter of stored procedure</param>
		''' <param name="nombreChofer">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcgcatChoferes(numOpc As System.Int32, idChofer As System.Int32, nombreChofer As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdChofer", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idChofer)
			parameters(2) = new SqlParameter("@NombreChofer", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreChofer)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcgcatChoferes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCGCatChoferes]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_MCGCatChoferes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idChofer">Input parameter of stored procedure</param>
		''' <param name="nombreChofer">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcgcatChoferes(numOpc As System.Int32, idChofer As System.Int32, nombreChofer As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdChofer", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idChofer)
			parameters(2) = new SqlParameter("@NombreChofer", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreChofer)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcgcatChoferes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCGCatChoferes]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MCGCatChoferes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idChofer">Input parameter of stored procedure</param>
		''' <param name="nombreChofer">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcgcatChoferes(numOpc As System.Int32, idChofer As System.Int32, nombreChofer As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdChofer", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idChofer)
			parameters(2) = new SqlParameter("@NombreChofer", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreChofer)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcgcatChoferes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCGCatChoferes]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_MCGCatChoferes'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idChofer">Input parameter of stored procedure</param>
		''' <param name="nombreChofer">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconMcgcatChoferesCallAsQuery( numOpc As System.Int32, idChofer As System.Int32, nombreChofer As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_MCGCatChoferes]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@IdChofer", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idChofer))
			toReturn.Parameters.Add(New SqlParameter("@NombreChofer", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreChofer))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_MCGCatCompradoresGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idComprador">Input parameter of stored procedure</param>
		''' <param name="nombreComprador">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcgcatCompradoresGan(numOpc As System.Int32, idComprador As System.Int32, nombreComprador As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdComprador", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idComprador)
			parameters(2) = new SqlParameter("@NombreComprador", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreComprador)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcgcatCompradoresGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCGCatCompradoresGan]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MCGCatCompradoresGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idComprador">Input parameter of stored procedure</param>
		''' <param name="nombreComprador">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcgcatCompradoresGan(numOpc As System.Int32, idComprador As System.Int32, nombreComprador As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdComprador", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idComprador)
			parameters(2) = new SqlParameter("@NombreComprador", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreComprador)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcgcatCompradoresGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCGCatCompradoresGan]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_MCGCatCompradoresGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idComprador">Input parameter of stored procedure</param>
		''' <param name="nombreComprador">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcgcatCompradoresGan(numOpc As System.Int32, idComprador As System.Int32, nombreComprador As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdComprador", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idComprador)
			parameters(2) = new SqlParameter("@NombreComprador", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreComprador)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcgcatCompradoresGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCGCatCompradoresGan]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MCGCatCompradoresGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idComprador">Input parameter of stored procedure</param>
		''' <param name="nombreComprador">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcgcatCompradoresGan(numOpc As System.Int32, idComprador As System.Int32, nombreComprador As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdComprador", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idComprador)
			parameters(2) = new SqlParameter("@NombreComprador", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreComprador)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcgcatCompradoresGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCGCatCompradoresGan]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_MCGCatCompradoresGan'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idComprador">Input parameter of stored procedure</param>
		''' <param name="nombreComprador">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconMcgcatCompradoresGanCallAsQuery( numOpc As System.Int32, idComprador As System.Int32, nombreComprador As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_MCGCatCompradoresGan]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@IdComprador", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idComprador))
			toReturn.Parameters.Add(New SqlParameter("@NombreComprador", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreComprador))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_MCGCatMovGanado'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idMovGanado">Input parameter of stored procedure</param>
		''' <param name="nombreMovGanado">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcgcatMovGanado(numOpc As System.Int32, idMovGanado As System.Int32, nombreMovGanado As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdMovGanado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idMovGanado)
			parameters(2) = new SqlParameter("@NombreMovGanado", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreMovGanado)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcgcatMovGanado")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCGCatMovGanado]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MCGCatMovGanado'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idMovGanado">Input parameter of stored procedure</param>
		''' <param name="nombreMovGanado">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcgcatMovGanado(numOpc As System.Int32, idMovGanado As System.Int32, nombreMovGanado As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdMovGanado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idMovGanado)
			parameters(2) = new SqlParameter("@NombreMovGanado", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreMovGanado)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcgcatMovGanado")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCGCatMovGanado]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_MCGCatMovGanado'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idMovGanado">Input parameter of stored procedure</param>
		''' <param name="nombreMovGanado">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcgcatMovGanado(numOpc As System.Int32, idMovGanado As System.Int32, nombreMovGanado As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdMovGanado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idMovGanado)
			parameters(2) = new SqlParameter("@NombreMovGanado", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreMovGanado)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcgcatMovGanado")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCGCatMovGanado]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MCGCatMovGanado'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idMovGanado">Input parameter of stored procedure</param>
		''' <param name="nombreMovGanado">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcgcatMovGanado(numOpc As System.Int32, idMovGanado As System.Int32, nombreMovGanado As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdMovGanado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idMovGanado)
			parameters(2) = new SqlParameter("@NombreMovGanado", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreMovGanado)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcgcatMovGanado")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCGCatMovGanado]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_MCGCatMovGanado'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idMovGanado">Input parameter of stored procedure</param>
		''' <param name="nombreMovGanado">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconMcgcatMovGanadoCallAsQuery( numOpc As System.Int32, idMovGanado As System.Int32, nombreMovGanado As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_MCGCatMovGanado]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@IdMovGanado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idMovGanado))
			toReturn.Parameters.Add(New SqlParameter("@NombreMovGanado", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreMovGanado))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_MCGCatVehiculos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idVehiculo">Input parameter of stored procedure</param>
		''' <param name="descVehiculo">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcgcatVehiculos(numOpc As System.Int32, idVehiculo As System.Int32, descVehiculo As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idVehiculo)
			parameters(2) = new SqlParameter("@DescVehiculo", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descVehiculo)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcgcatVehiculos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCGCatVehiculos]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MCGCatVehiculos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idVehiculo">Input parameter of stored procedure</param>
		''' <param name="descVehiculo">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcgcatVehiculos(numOpc As System.Int32, idVehiculo As System.Int32, descVehiculo As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idVehiculo)
			parameters(2) = new SqlParameter("@DescVehiculo", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descVehiculo)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcgcatVehiculos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCGCatVehiculos]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_MCGCatVehiculos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idVehiculo">Input parameter of stored procedure</param>
		''' <param name="descVehiculo">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcgcatVehiculos(numOpc As System.Int32, idVehiculo As System.Int32, descVehiculo As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idVehiculo)
			parameters(2) = new SqlParameter("@DescVehiculo", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descVehiculo)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcgcatVehiculos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCGCatVehiculos]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MCGCatVehiculos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idVehiculo">Input parameter of stored procedure</param>
		''' <param name="descVehiculo">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMcgcatVehiculos(numOpc As System.Int32, idVehiculo As System.Int32, descVehiculo As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idVehiculo)
			parameters(2) = new SqlParameter("@DescVehiculo", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descVehiculo)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMcgcatVehiculos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MCGCatVehiculos]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_MCGCatVehiculos'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idVehiculo">Input parameter of stored procedure</param>
		''' <param name="descVehiculo">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconMcgcatVehiculosCallAsQuery( numOpc As System.Int32, idVehiculo As System.Int32, descVehiculo As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_MCGCatVehiculos]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@IdVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idVehiculo))
			toReturn.Parameters.Add(New SqlParameter("@DescVehiculo", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descVehiculo))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_MGCatCiudades'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="nomCiudad">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMgcatCiudades(numOpc As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, nomCiudad As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad)
			parameters(3) = new SqlParameter("@NomCiudad", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiudad)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMgcatCiudades")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MGCatCiudades]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MGCatCiudades'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="nomCiudad">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMgcatCiudades(numOpc As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, nomCiudad As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad)
			parameters(3) = new SqlParameter("@NomCiudad", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiudad)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMgcatCiudades")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MGCatCiudades]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_MGCatCiudades'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="nomCiudad">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMgcatCiudades(numOpc As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, nomCiudad As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad)
			parameters(3) = new SqlParameter("@NomCiudad", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiudad)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMgcatCiudades")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MGCatCiudades]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MGCatCiudades'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="nomCiudad">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMgcatCiudades(numOpc As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, nomCiudad As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad)
			parameters(3) = new SqlParameter("@NomCiudad", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiudad)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMgcatCiudades")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MGCatCiudades]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_MGCatCiudades'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="nomCiudad">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconMgcatCiudadesCallAsQuery( numOpc As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, nomCiudad As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_MGCatCiudades]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado))
			toReturn.Parameters.Add(New SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad))
			toReturn.Parameters.Add(New SqlParameter("@NomCiudad", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCiudad))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_MGCatEstados'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="nomEstado">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMgcatEstados(numOpc As System.Int32, idEstado As System.Int32, nomEstado As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@NomEstado", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomEstado)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMgcatEstados")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MGCatEstados]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MGCatEstados'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="nomEstado">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMgcatEstados(numOpc As System.Int32, idEstado As System.Int32, nomEstado As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@NomEstado", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomEstado)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMgcatEstados")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MGCatEstados]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_MGCatEstados'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="nomEstado">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMgcatEstados(numOpc As System.Int32, idEstado As System.Int32, nomEstado As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@NomEstado", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomEstado)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMgcatEstados")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MGCatEstados]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MGCatEstados'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="nomEstado">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMgcatEstados(numOpc As System.Int32, idEstado As System.Int32, nomEstado As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@NomEstado", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomEstado)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMgcatEstados")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MGCatEstados]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_MGCatEstados'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="nomEstado">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconMgcatEstadosCallAsQuery( numOpc As System.Int32, idEstado As System.Int32, nomEstado As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_MGCatEstados]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado))
			toReturn.Parameters.Add(New SqlParameter("@NomEstado", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomEstado))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_MGCatPoblaciones'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idPoblacion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="nomPoblacion">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMgcatPoblaciones(numOpc As System.Int32, idPoblacion As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, nomPoblacion As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(5 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdPoblacion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPoblacion)
			parameters(2) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(3) = new SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad)
			parameters(4) = new SqlParameter("@NomPoblacion", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomPoblacion)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMgcatPoblaciones")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MGCatPoblaciones]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MGCatPoblaciones'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idPoblacion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="nomPoblacion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMgcatPoblaciones(numOpc As System.Int32, idPoblacion As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, nomPoblacion As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(5) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdPoblacion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPoblacion)
			parameters(2) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(3) = new SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad)
			parameters(4) = new SqlParameter("@NomPoblacion", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomPoblacion)

			' Return value parameter
			parameters(5) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMgcatPoblaciones")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MGCatPoblaciones]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(5).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_MGCatPoblaciones'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idPoblacion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="nomPoblacion">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMgcatPoblaciones(numOpc As System.Int32, idPoblacion As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, nomPoblacion As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(5 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdPoblacion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPoblacion)
			parameters(2) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(3) = new SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad)
			parameters(4) = new SqlParameter("@NomPoblacion", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomPoblacion)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMgcatPoblaciones")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MGCatPoblaciones]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MGCatPoblaciones'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idPoblacion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="nomPoblacion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMgcatPoblaciones(numOpc As System.Int32, idPoblacion As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, nomPoblacion As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(5) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdPoblacion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPoblacion)
			parameters(2) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(3) = new SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad)
			parameters(4) = new SqlParameter("@NomPoblacion", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomPoblacion)

			' Return value parameter
			parameters(5) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMgcatPoblaciones")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MGCatPoblaciones]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(5).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_MGCatPoblaciones'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idPoblacion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="nomPoblacion">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconMgcatPoblacionesCallAsQuery( numOpc As System.Int32, idPoblacion As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, nomPoblacion As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_MGCatPoblaciones]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@IdPoblacion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPoblacion))
			toReturn.Parameters.Add(New SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado))
			toReturn.Parameters.Add(New SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad))
			toReturn.Parameters.Add(New SqlParameter("@NomPoblacion", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomPoblacion))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_MSCCatAlmacenes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idAlmacen">Input parameter of stored procedure</param>
		''' <param name="nomAlmacen">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMsccatAlmacenes(numOpc As System.Int32, idAlmacen As System.Int32, nomAlmacen As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdAlmacen", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idAlmacen)
			parameters(2) = new SqlParameter("@NomAlmacen", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomAlmacen)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMsccatAlmacenes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MSCCatAlmacenes]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MSCCatAlmacenes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idAlmacen">Input parameter of stored procedure</param>
		''' <param name="nomAlmacen">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMsccatAlmacenes(numOpc As System.Int32, idAlmacen As System.Int32, nomAlmacen As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdAlmacen", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idAlmacen)
			parameters(2) = new SqlParameter("@NomAlmacen", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomAlmacen)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMsccatAlmacenes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MSCCatAlmacenes]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_MSCCatAlmacenes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idAlmacen">Input parameter of stored procedure</param>
		''' <param name="nomAlmacen">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMsccatAlmacenes(numOpc As System.Int32, idAlmacen As System.Int32, nomAlmacen As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdAlmacen", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idAlmacen)
			parameters(2) = new SqlParameter("@NomAlmacen", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomAlmacen)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMsccatAlmacenes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MSCCatAlmacenes]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MSCCatAlmacenes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idAlmacen">Input parameter of stored procedure</param>
		''' <param name="nomAlmacen">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMsccatAlmacenes(numOpc As System.Int32, idAlmacen As System.Int32, nomAlmacen As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdAlmacen", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idAlmacen)
			parameters(2) = new SqlParameter("@NomAlmacen", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomAlmacen)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMsccatAlmacenes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MSCCatAlmacenes]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_MSCCatAlmacenes'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idAlmacen">Input parameter of stored procedure</param>
		''' <param name="nomAlmacen">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconMsccatAlmacenesCallAsQuery( numOpc As System.Int32, idAlmacen As System.Int32, nomAlmacen As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_MSCCatAlmacenes]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@IdAlmacen", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idAlmacen))
			toReturn.Parameters.Add(New SqlParameter("@NomAlmacen", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomAlmacen))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_MSCCatRelProdxCliente'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="idProdRas">Input parameter of stored procedure</param>
		''' <param name="idProdCliente">Input parameter of stored procedure</param>
		''' <param name="nomProdCliente">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMsccatRelProdxCliente(numOpc As System.Int32, idCliente As System.Int32, idProdRas As System.Int32, idProdCliente As System.String, nomProdCliente As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(5 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(2) = new SqlParameter("@IdProdRas", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProdRas)
			parameters(3) = new SqlParameter("@IdProdCliente", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idProdCliente)
			parameters(4) = new SqlParameter("@NomProdCliente", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomProdCliente)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMsccatRelProdxCliente")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MSCCatRelProdxCliente]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MSCCatRelProdxCliente'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="idProdRas">Input parameter of stored procedure</param>
		''' <param name="idProdCliente">Input parameter of stored procedure</param>
		''' <param name="nomProdCliente">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMsccatRelProdxCliente(numOpc As System.Int32, idCliente As System.Int32, idProdRas As System.Int32, idProdCliente As System.String, nomProdCliente As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(5) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(2) = new SqlParameter("@IdProdRas", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProdRas)
			parameters(3) = new SqlParameter("@IdProdCliente", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idProdCliente)
			parameters(4) = new SqlParameter("@NomProdCliente", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomProdCliente)

			' Return value parameter
			parameters(5) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMsccatRelProdxCliente")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MSCCatRelProdxCliente]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(5).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_MSCCatRelProdxCliente'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="idProdRas">Input parameter of stored procedure</param>
		''' <param name="idProdCliente">Input parameter of stored procedure</param>
		''' <param name="nomProdCliente">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMsccatRelProdxCliente(numOpc As System.Int32, idCliente As System.Int32, idProdRas As System.Int32, idProdCliente As System.String, nomProdCliente As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(5 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(2) = new SqlParameter("@IdProdRas", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProdRas)
			parameters(3) = new SqlParameter("@IdProdCliente", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idProdCliente)
			parameters(4) = new SqlParameter("@NomProdCliente", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomProdCliente)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMsccatRelProdxCliente")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MSCCatRelProdxCliente]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MSCCatRelProdxCliente'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="idProdRas">Input parameter of stored procedure</param>
		''' <param name="idProdCliente">Input parameter of stored procedure</param>
		''' <param name="nomProdCliente">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMsccatRelProdxCliente(numOpc As System.Int32, idCliente As System.Int32, idProdRas As System.Int32, idProdCliente As System.String, nomProdCliente As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(5) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(2) = new SqlParameter("@IdProdRas", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProdRas)
			parameters(3) = new SqlParameter("@IdProdCliente", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idProdCliente)
			parameters(4) = new SqlParameter("@NomProdCliente", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomProdCliente)

			' Return value parameter
			parameters(5) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMsccatRelProdxCliente")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MSCCatRelProdxCliente]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(5).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_MSCCatRelProdxCliente'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="idProdRas">Input parameter of stored procedure</param>
		''' <param name="idProdCliente">Input parameter of stored procedure</param>
		''' <param name="nomProdCliente">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconMsccatRelProdxClienteCallAsQuery( numOpc As System.Int32, idCliente As System.Int32, idProdRas As System.Int32, idProdCliente As System.String, nomProdCliente As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_MSCCatRelProdxCliente]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente))
			toReturn.Parameters.Add(New SqlParameter("@IdProdRas", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProdRas))
			toReturn.Parameters.Add(New SqlParameter("@IdProdCliente", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idProdCliente))
			toReturn.Parameters.Add(New SqlParameter("@NomProdCliente", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomProdCliente))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UPCon_MSCCatServiciosRastro'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idServicio">Input parameter of stored procedure</param>
		''' <param name="nombreServicio">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMsccatServiciosRastro(numOpc As System.Int32, idServicio As System.Int32, nombreServicio As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdServicio", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idServicio)
			parameters(2) = new SqlParameter("@NombreServicio", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreServicio)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMsccatServiciosRastro")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MSCCatServiciosRastro]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MSCCatServiciosRastro'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idServicio">Input parameter of stored procedure</param>
		''' <param name="nombreServicio">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMsccatServiciosRastro(numOpc As System.Int32, idServicio As System.Int32, nombreServicio As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdServicio", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idServicio)
			parameters(2) = new SqlParameter("@NombreServicio", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreServicio)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMsccatServiciosRastro")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MSCCatServiciosRastro]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UPCon_MSCCatServiciosRastro'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idServicio">Input parameter of stored procedure</param>
		''' <param name="nombreServicio">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMsccatServiciosRastro(numOpc As System.Int32, idServicio As System.Int32, nombreServicio As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdServicio", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idServicio)
			parameters(2) = new SqlParameter("@NombreServicio", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreServicio)

			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMsccatServiciosRastro")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MSCCatServiciosRastro]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UPCon_MSCCatServiciosRastro'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idServicio">Input parameter of stored procedure</param>
		''' <param name="nombreServicio">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UpconMsccatServiciosRastro(numOpc As System.Int32, idServicio As System.Int32, nombreServicio As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdServicio", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idServicio)
			parameters(2) = new SqlParameter("@NombreServicio", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreServicio)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UpconMsccatServiciosRastro")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UPCon_MSCCatServiciosRastro]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UPCon_MSCCatServiciosRastro'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idServicio">Input parameter of stored procedure</param>
		''' <param name="nombreServicio">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUpconMsccatServiciosRastroCallAsQuery( numOpc As System.Int32, idServicio As System.Int32, nombreServicio As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UPCon_MSCCatServiciosRastro]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@IdServicio", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idServicio))
			toReturn.Parameters.Add(New SqlParameter("@NombreServicio", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreServicio))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_CatClientes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCliente">Input parameter of stored procedure</param>
		''' <param name="nomCliente">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatClientes(numOpc As System.Int32, cveCliente As System.Int32, nomCliente As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@Cve_Cliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCliente)
			parameters(2) = new SqlParameter("@NomCliente", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCliente)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCatClientes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatClientes]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CatClientes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCliente">Input parameter of stored procedure</param>
		''' <param name="nomCliente">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatClientes(numOpc As System.Int32, cveCliente As System.Int32, nomCliente As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@Cve_Cliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCliente)
			parameters(2) = new SqlParameter("@NomCliente", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCliente)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCatClientes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatClientes]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_CatClientes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCliente">Input parameter of stored procedure</param>
		''' <param name="nomCliente">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatClientes(numOpc As System.Int32, cveCliente As System.Int32, nomCliente As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@Cve_Cliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCliente)
			parameters(2) = new SqlParameter("@NomCliente", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCliente)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCatClientes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatClientes]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CatClientes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCliente">Input parameter of stored procedure</param>
		''' <param name="nomCliente">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatClientes(numOpc As System.Int32, cveCliente As System.Int32, nomCliente As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@Cve_Cliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCliente)
			parameters(2) = new SqlParameter("@NomCliente", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCliente)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCatClientes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatClientes]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_CatClientes'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCliente">Input parameter of stored procedure</param>
		''' <param name="nomCliente">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConCatClientesCallAsQuery( numOpc As System.Int32, cveCliente As System.Int32, nomCliente As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_CatClientes]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@Cve_Cliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCliente))
			toReturn.Parameters.Add(New SqlParameter("@NomCliente", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCliente))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_CatCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCorte">Input parameter of stored procedure</param>
		''' <param name="nomCorte">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatCortes(numOpc As System.Int32, cveCorte As System.Int32, nomCorte As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@Cve_Corte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCorte)
			parameters(2) = new SqlParameter("@NomCorte", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCorte)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCatCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatCortes]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CatCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCorte">Input parameter of stored procedure</param>
		''' <param name="nomCorte">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatCortes(numOpc As System.Int32, cveCorte As System.Int32, nomCorte As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@Cve_Corte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCorte)
			parameters(2) = new SqlParameter("@NomCorte", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCorte)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCatCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatCortes]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_CatCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCorte">Input parameter of stored procedure</param>
		''' <param name="nomCorte">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatCortes(numOpc As System.Int32, cveCorte As System.Int32, nomCorte As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@Cve_Corte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCorte)
			parameters(2) = new SqlParameter("@NomCorte", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCorte)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCatCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatCortes]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CatCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCorte">Input parameter of stored procedure</param>
		''' <param name="nomCorte">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatCortes(numOpc As System.Int32, cveCorte As System.Int32, nomCorte As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@Cve_Corte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCorte)
			parameters(2) = new SqlParameter("@NomCorte", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCorte)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCatCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatCortes]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_CatCortes'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCorte">Input parameter of stored procedure</param>
		''' <param name="nomCorte">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConCatCortesCallAsQuery( numOpc As System.Int32, cveCorte As System.Int32, nomCorte As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_CatCortes]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@Cve_Corte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCorte))
			toReturn.Parameters.Add(New SqlParameter("@NomCorte", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomCorte))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_CatCtaCont'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="cveCta">Input parameter of stored procedure</param>
		''' <param name="cveSubCta">Input parameter of stored procedure</param>
		''' <param name="cveSsubCta">Input parameter of stored procedure</param>
		''' <param name="cveSssubCta">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatCtaCont(opcion As System.Int32, cveCta As System.String, cveSubCta As System.String, cveSsubCta As System.String, cveSssubCta As System.String) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(5 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@Cve_Cta", SqlDbType.Char, 4, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveCta)
			parameters(2) = new SqlParameter("@Cve_SubCta", SqlDbType.Char, 4, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveSubCta)
			parameters(3) = new SqlParameter("@Cve_SsubCta", SqlDbType.Char, 4, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveSsubCta)
			parameters(4) = new SqlParameter("@Cve_SssubCta", SqlDbType.Char, 4, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveSssubCta)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConCatCtaCont")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatCtaCont]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CatCtaCont'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="cveCta">Input parameter of stored procedure</param>
		''' <param name="cveSubCta">Input parameter of stored procedure</param>
		''' <param name="cveSsubCta">Input parameter of stored procedure</param>
		''' <param name="cveSssubCta">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatCtaCont(opcion As System.Int32, cveCta As System.String, cveSubCta As System.String, cveSsubCta As System.String, cveSssubCta As System.String, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(5) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@Cve_Cta", SqlDbType.Char, 4, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveCta)
			parameters(2) = new SqlParameter("@Cve_SubCta", SqlDbType.Char, 4, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveSubCta)
			parameters(3) = new SqlParameter("@Cve_SsubCta", SqlDbType.Char, 4, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveSsubCta)
			parameters(4) = new SqlParameter("@Cve_SssubCta", SqlDbType.Char, 4, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveSssubCta)

			' Return value parameter
			parameters(5) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConCatCtaCont")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatCtaCont]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(5).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_CatCtaCont'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="cveCta">Input parameter of stored procedure</param>
		''' <param name="cveSubCta">Input parameter of stored procedure</param>
		''' <param name="cveSsubCta">Input parameter of stored procedure</param>
		''' <param name="cveSssubCta">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatCtaCont(opcion As System.Int32, cveCta As System.String, cveSubCta As System.String, cveSsubCta As System.String, cveSssubCta As System.String, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(5 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@Cve_Cta", SqlDbType.Char, 4, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveCta)
			parameters(2) = new SqlParameter("@Cve_SubCta", SqlDbType.Char, 4, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveSubCta)
			parameters(3) = new SqlParameter("@Cve_SsubCta", SqlDbType.Char, 4, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveSsubCta)
			parameters(4) = new SqlParameter("@Cve_SssubCta", SqlDbType.Char, 4, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveSssubCta)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConCatCtaCont")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatCtaCont]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CatCtaCont'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="cveCta">Input parameter of stored procedure</param>
		''' <param name="cveSubCta">Input parameter of stored procedure</param>
		''' <param name="cveSsubCta">Input parameter of stored procedure</param>
		''' <param name="cveSssubCta">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatCtaCont(opcion As System.Int32, cveCta As System.String, cveSubCta As System.String, cveSsubCta As System.String, cveSssubCta As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(5) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@Cve_Cta", SqlDbType.Char, 4, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveCta)
			parameters(2) = new SqlParameter("@Cve_SubCta", SqlDbType.Char, 4, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveSubCta)
			parameters(3) = new SqlParameter("@Cve_SsubCta", SqlDbType.Char, 4, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveSsubCta)
			parameters(4) = new SqlParameter("@Cve_SssubCta", SqlDbType.Char, 4, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveSssubCta)

			' Return value parameter
			parameters(5) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConCatCtaCont")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatCtaCont]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(5).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_CatCtaCont'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="cveCta">Input parameter of stored procedure</param>
		''' <param name="cveSubCta">Input parameter of stored procedure</param>
		''' <param name="cveSsubCta">Input parameter of stored procedure</param>
		''' <param name="cveSssubCta">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConCatCtaContCallAsQuery( opcion As System.Int32, cveCta As System.String, cveSubCta As System.String, cveSsubCta As System.String, cveSssubCta As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_CatCtaCont]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@Cve_Cta", SqlDbType.Char, 4, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveCta))
			toReturn.Parameters.Add(New SqlParameter("@Cve_SubCta", SqlDbType.Char, 4, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveSubCta))
			toReturn.Parameters.Add(New SqlParameter("@Cve_SsubCta", SqlDbType.Char, 4, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveSsubCta))
			toReturn.Parameters.Add(New SqlParameter("@Cve_SssubCta", SqlDbType.Char, 4, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveSssubCta))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_CatRastros'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idRastro">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatRastros(opcion As System.Int32, idRastro As System.Int32, descripcion As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdRastro", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idRastro)
			parameters(2) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 120, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCatRastros")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatRastros]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CatRastros'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idRastro">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatRastros(opcion As System.Int32, idRastro As System.Int32, descripcion As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdRastro", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idRastro)
			parameters(2) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 120, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCatRastros")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatRastros]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_CatRastros'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idRastro">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatRastros(opcion As System.Int32, idRastro As System.Int32, descripcion As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdRastro", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idRastro)
			parameters(2) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 120, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCatRastros")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatRastros]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CatRastros'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idRastro">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatRastros(opcion As System.Int32, idRastro As System.Int32, descripcion As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdRastro", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idRastro)
			parameters(2) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 120, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCatRastros")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatRastros]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_CatRastros'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idRastro">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConCatRastrosCallAsQuery( opcion As System.Int32, idRastro As System.Int32, descripcion As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_CatRastros]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@IdRastro", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idRastro))
			toReturn.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.VarChar, 120, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_CatSubCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCorte">Input parameter of stored procedure</param>
		''' <param name="cveSubCorte">Input parameter of stored procedure</param>
		''' <param name="nomSubCorte">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatSubCortes(numOpc As System.Int32, cveCorte As System.Int32, cveSubCorte As System.Int32, nomSubCorte As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@Cve_Corte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCorte)
			parameters(2) = new SqlParameter("@Cve_SubCorte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveSubCorte)
			parameters(3) = new SqlParameter("@NomSubCorte", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomSubCorte)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCatSubCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatSubCortes]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CatSubCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCorte">Input parameter of stored procedure</param>
		''' <param name="cveSubCorte">Input parameter of stored procedure</param>
		''' <param name="nomSubCorte">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatSubCortes(numOpc As System.Int32, cveCorte As System.Int32, cveSubCorte As System.Int32, nomSubCorte As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@Cve_Corte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCorte)
			parameters(2) = new SqlParameter("@Cve_SubCorte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveSubCorte)
			parameters(3) = new SqlParameter("@NomSubCorte", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomSubCorte)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCatSubCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatSubCortes]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_CatSubCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCorte">Input parameter of stored procedure</param>
		''' <param name="cveSubCorte">Input parameter of stored procedure</param>
		''' <param name="nomSubCorte">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatSubCortes(numOpc As System.Int32, cveCorte As System.Int32, cveSubCorte As System.Int32, nomSubCorte As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@Cve_Corte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCorte)
			parameters(2) = new SqlParameter("@Cve_SubCorte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveSubCorte)
			parameters(3) = new SqlParameter("@NomSubCorte", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomSubCorte)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCatSubCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatSubCortes]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CatSubCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCorte">Input parameter of stored procedure</param>
		''' <param name="cveSubCorte">Input parameter of stored procedure</param>
		''' <param name="nomSubCorte">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatSubCortes(numOpc As System.Int32, cveCorte As System.Int32, cveSubCorte As System.Int32, nomSubCorte As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@Cve_Corte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCorte)
			parameters(2) = new SqlParameter("@Cve_SubCorte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveSubCorte)
			parameters(3) = new SqlParameter("@NomSubCorte", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomSubCorte)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCatSubCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatSubCortes]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_CatSubCortes'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="cveCorte">Input parameter of stored procedure</param>
		''' <param name="cveSubCorte">Input parameter of stored procedure</param>
		''' <param name="nomSubCorte">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConCatSubCortesCallAsQuery( numOpc As System.Int32, cveCorte As System.Int32, cveSubCorte As System.Int32, nomSubCorte As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_CatSubCortes]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@Cve_Corte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveCorte))
			toReturn.Parameters.Add(New SqlParameter("@Cve_SubCorte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveSubCorte))
			toReturn.Parameters.Add(New SqlParameter("@NomSubCorte", SqlDbType.VarChar, 70, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomSubCorte))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_CatTipGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="nomGanado">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatTipGan(nomGanado As System.String, numOpc As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Nom_Ganado", SqlDbType.VarChar, 80, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomGanado)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCatTipGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatTipGan]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CatTipGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="nomGanado">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatTipGan(nomGanado As System.String, numOpc As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Nom_Ganado", SqlDbType.VarChar, 80, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomGanado)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCatTipGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatTipGan]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_CatTipGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="nomGanado">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatTipGan(nomGanado As System.String, numOpc As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Nom_Ganado", SqlDbType.VarChar, 80, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomGanado)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCatTipGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatTipGan]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CatTipGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="nomGanado">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCatTipGan(nomGanado As System.String, numOpc As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Nom_Ganado", SqlDbType.VarChar, 80, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomGanado)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCatTipGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CatTipGan]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_CatTipGan'.
		''' 
		''' </summary>
		''' <param name="nomGanado">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConCatTipGanCallAsQuery( nomGanado As System.String, numOpc As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_CatTipGan]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Nom_Ganado", SqlDbType.VarChar, 80, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomGanado))
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_CfgCtrlCtas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="folio">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCfgCtrlCtas(opcion As System.Int32, folio As System.Int32) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@Folio", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, folio)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConCfgCtrlCtas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CfgCtrlCtas]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CfgCtrlCtas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="folio">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCfgCtrlCtas(opcion As System.Int32, folio As System.Int32, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@Folio", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, folio)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConCfgCtrlCtas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CfgCtrlCtas]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_CfgCtrlCtas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="folio">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCfgCtrlCtas(opcion As System.Int32, folio As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@Folio", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, folio)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConCfgCtrlCtas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CfgCtrlCtas]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CfgCtrlCtas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="folio">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCfgCtrlCtas(opcion As System.Int32, folio As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@Folio", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, folio)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConCfgCtrlCtas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CfgCtrlCtas]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_CfgCtrlCtas'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="folio">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConCfgCtrlCtasCallAsQuery( opcion As System.Int32, folio As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_CfgCtrlCtas]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, folio))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatCausasMue'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveCausaMue">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatCausasMue(cveCausaMue As System.Int16, numOpc As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Cve_CausaMue", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveCausaMue)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatCausasMue")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatCausasMue]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatCausasMue'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveCausaMue">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatCausasMue(cveCausaMue As System.Int16, numOpc As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Cve_CausaMue", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveCausaMue)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatCausasMue")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatCausasMue]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatCausasMue'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveCausaMue">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatCausasMue(cveCausaMue As System.Int16, numOpc As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Cve_CausaMue", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveCausaMue)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatCausasMue")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatCausasMue]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatCausasMue'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveCausaMue">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatCausasMue(cveCausaMue As System.Int16, numOpc As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Cve_CausaMue", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveCausaMue)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatCausasMue")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatCausasMue]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_CGCatCausasMue'.
		''' 
		''' </summary>
		''' <param name="cveCausaMue">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConCgcatCausasMueCallAsQuery( cveCausaMue As System.Int16, numOpc As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_CGCatCausasMue]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Cve_CausaMue", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveCausaMue))
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatChoferes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveChofer">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatChoferes(cveChofer As System.Int16, numOpc As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Cve_Chofer", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveChofer)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatChoferes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatChoferes]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatChoferes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveChofer">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatChoferes(cveChofer As System.Int16, numOpc As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Cve_Chofer", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveChofer)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatChoferes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatChoferes]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatChoferes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveChofer">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatChoferes(cveChofer As System.Int16, numOpc As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Cve_Chofer", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveChofer)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatChoferes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatChoferes]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatChoferes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveChofer">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatChoferes(cveChofer As System.Int16, numOpc As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Cve_Chofer", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveChofer)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatChoferes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatChoferes]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_CGCatChoferes'.
		''' 
		''' </summary>
		''' <param name="cveChofer">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConCgcatChoferesCallAsQuery( cveChofer As System.Int16, numOpc As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_CGCatChoferes]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Cve_Chofer", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveChofer))
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatComiGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveComi">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatComiGan(cveComi As System.Int32, numOpc As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Cve_Comi", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveComi)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatComiGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatComiGan]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatComiGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveComi">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatComiGan(cveComi As System.Int32, numOpc As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Cve_Comi", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveComi)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatComiGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatComiGan]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatComiGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveComi">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatComiGan(cveComi As System.Int32, numOpc As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Cve_Comi", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveComi)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatComiGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatComiGan]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatComiGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveComi">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatComiGan(cveComi As System.Int32, numOpc As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Cve_Comi", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveComi)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatComiGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatComiGan]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_CGCatComiGan'.
		''' 
		''' </summary>
		''' <param name="cveComi">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConCgcatComiGanCallAsQuery( cveComi As System.Int32, numOpc As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_CGCatComiGan]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Cve_Comi", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, cveComi))
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatConGas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveGasto">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatConGas(cveGasto As System.Int16, numOpc As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Cve_Gasto", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveGasto)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatConGas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatConGas]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatConGas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveGasto">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatConGas(cveGasto As System.Int16, numOpc As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Cve_Gasto", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveGasto)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatConGas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatConGas]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatConGas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveGasto">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatConGas(cveGasto As System.Int16, numOpc As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Cve_Gasto", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveGasto)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatConGas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatConGas]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatConGas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveGasto">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatConGas(cveGasto As System.Int16, numOpc As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Cve_Gasto", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveGasto)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatConGas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatConGas]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_CGCatConGas'.
		''' 
		''' </summary>
		''' <param name="cveGasto">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConCgcatConGasCallAsQuery( cveGasto As System.Int16, numOpc As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_CGCatConGas]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Cve_Gasto", SqlDbType.SmallInt, 0, ParameterDirection.Input, True, 5, 0, "",  DataRowVersion.Current, cveGasto))
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatMovGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="codigo">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatMovGan(codigo As System.Int32, numOpc As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Codigo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codigo)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatMovGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatMovGan]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatMovGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="codigo">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatMovGan(codigo As System.Int32, numOpc As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Codigo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codigo)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatMovGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatMovGan]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatMovGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="codigo">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatMovGan(codigo As System.Int32, numOpc As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Codigo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codigo)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatMovGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatMovGan]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatMovGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="codigo">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatMovGan(codigo As System.Int32, numOpc As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Codigo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codigo)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatMovGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatMovGan]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_CGCatMovGan'.
		''' 
		''' </summary>
		''' <param name="codigo">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConCgcatMovGanCallAsQuery( codigo As System.Int32, numOpc As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_CGCatMovGan]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codigo))
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatTipGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveGanado">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatTipGan(cveGanado As System.String, numOpc As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Cve_Ganado", SqlDbType.Char, 6, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveGanado)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatTipGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatTipGan]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatTipGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveGanado">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatTipGan(cveGanado As System.String, numOpc As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Cve_Ganado", SqlDbType.Char, 6, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveGanado)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatTipGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatTipGan]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatTipGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveGanado">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatTipGan(cveGanado As System.String, numOpc As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Cve_Ganado", SqlDbType.Char, 6, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveGanado)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatTipGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatTipGan]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CGCatTipGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveGanado">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgcatTipGan(cveGanado As System.String, numOpc As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Cve_Ganado", SqlDbType.Char, 6, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveGanado)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgcatTipGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CGCatTipGan]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_CGCatTipGan'.
		''' 
		''' </summary>
		''' <param name="cveGanado">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConCgcatTipGanCallAsQuery( cveGanado As System.String, numOpc As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_CGCatTipGan]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Cve_Ganado", SqlDbType.Char, 6, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveGanado))
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_CgCatVehiculos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="codVehiculo">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgCatVehiculos(codVehiculo As System.Int32, numOpc As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@CodVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codVehiculo)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgCatVehiculos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CgCatVehiculos]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CgCatVehiculos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="codVehiculo">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgCatVehiculos(codVehiculo As System.Int32, numOpc As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@CodVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codVehiculo)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgCatVehiculos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CgCatVehiculos]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_CgCatVehiculos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="codVehiculo">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgCatVehiculos(codVehiculo As System.Int32, numOpc As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@CodVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codVehiculo)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgCatVehiculos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CgCatVehiculos]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_CgCatVehiculos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="codVehiculo">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConCgCatVehiculos(codVehiculo As System.Int32, numOpc As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@CodVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codVehiculo)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConCgCatVehiculos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_CgCatVehiculos]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_CgCatVehiculos'.
		''' 
		''' </summary>
		''' <param name="codVehiculo">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConCgCatVehiculosCallAsQuery( codVehiculo As System.Int32, numOpc As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_CgCatVehiculos]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@CodVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codVehiculo))
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_Facturas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="serie">Input parameter of stored procedure</param>
		''' <param name="noFactura">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConFacturas(opcion As System.Int32, serie As System.String, noFactura As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@Serie", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, serie)
			parameters(2) = new SqlParameter("@NoFactura", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, noFactura)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConFacturas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_Facturas]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_Facturas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="serie">Input parameter of stored procedure</param>
		''' <param name="noFactura">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConFacturas(opcion As System.Int32, serie As System.String, noFactura As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@Serie", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, serie)
			parameters(2) = new SqlParameter("@NoFactura", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, noFactura)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConFacturas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_Facturas]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_Facturas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="serie">Input parameter of stored procedure</param>
		''' <param name="noFactura">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConFacturas(opcion As System.Int32, serie As System.String, noFactura As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@Serie", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, serie)
			parameters(2) = new SqlParameter("@NoFactura", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, noFactura)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConFacturas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_Facturas]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_Facturas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="serie">Input parameter of stored procedure</param>
		''' <param name="noFactura">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConFacturas(opcion As System.Int32, serie As System.String, noFactura As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@Serie", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, serie)
			parameters(2) = new SqlParameter("@NoFactura", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, noFactura)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConFacturas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_Facturas]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_Facturas'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="serie">Input parameter of stored procedure</param>
		''' <param name="noFactura">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConFacturasCallAsQuery( opcion As System.Int32, serie As System.String, noFactura As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_Facturas]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@Serie", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, serie))
			toReturn.Parameters.Add(New SqlParameter("@NoFactura", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, noFactura))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_LotesCorrales'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveCorral">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConLotesCorrales(cveCorral As System.String) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Cve_Corral", SqlDbType.Char, 5, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveCorral)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConLotesCorrales")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_LotesCorrales]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_LotesCorrales'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveCorral">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConLotesCorrales(cveCorral As System.String, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Cve_Corral", SqlDbType.Char, 5, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveCorral)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConLotesCorrales")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_LotesCorrales]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_LotesCorrales'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveCorral">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConLotesCorrales(cveCorral As System.String, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Cve_Corral", SqlDbType.Char, 5, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveCorral)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConLotesCorrales")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_LotesCorrales]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_LotesCorrales'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="cveCorral">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConLotesCorrales(cveCorral As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Cve_Corral", SqlDbType.Char, 5, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveCorral)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConLotesCorrales")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_LotesCorrales]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_LotesCorrales'.
		''' 
		''' </summary>
		''' <param name="cveCorral">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConLotesCorralesCallAsQuery( cveCorral As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_LotesCorrales]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Cve_Corral", SqlDbType.Char, 5, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, cveCorral))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MCGCatChoferes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idChofer">Input parameter of stored procedure</param>
		''' <param name="nombreChofer">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMcgcatChoferes(opcion As System.Int32, idChofer As System.Int32, nombreChofer As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdChofer", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idChofer)
			parameters(2) = new SqlParameter("@NombreChofer", SqlDbType.Char, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreChofer)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMcgcatChoferes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MCGCatChoferes]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MCGCatChoferes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idChofer">Input parameter of stored procedure</param>
		''' <param name="nombreChofer">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMcgcatChoferes(opcion As System.Int32, idChofer As System.Int32, nombreChofer As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdChofer", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idChofer)
			parameters(2) = new SqlParameter("@NombreChofer", SqlDbType.Char, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreChofer)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMcgcatChoferes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MCGCatChoferes]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MCGCatChoferes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idChofer">Input parameter of stored procedure</param>
		''' <param name="nombreChofer">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMcgcatChoferes(opcion As System.Int32, idChofer As System.Int32, nombreChofer As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdChofer", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idChofer)
			parameters(2) = new SqlParameter("@NombreChofer", SqlDbType.Char, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreChofer)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMcgcatChoferes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MCGCatChoferes]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MCGCatChoferes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idChofer">Input parameter of stored procedure</param>
		''' <param name="nombreChofer">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMcgcatChoferes(opcion As System.Int32, idChofer As System.Int32, nombreChofer As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdChofer", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idChofer)
			parameters(2) = new SqlParameter("@NombreChofer", SqlDbType.Char, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreChofer)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMcgcatChoferes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MCGCatChoferes]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MCGCatChoferes'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idChofer">Input parameter of stored procedure</param>
		''' <param name="nombreChofer">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMcgcatChoferesCallAsQuery( opcion As System.Int32, idChofer As System.Int32, nombreChofer As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MCGCatChoferes]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@IdChofer", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idChofer))
			toReturn.Parameters.Add(New SqlParameter("@NombreChofer", SqlDbType.Char, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreChofer))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MCGCatTiposdeGanado'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idTipoGanado">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMcgcatTiposdeGanado(opcion As System.Int32, idTipoGanado As System.Int32) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdTipoGanado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idTipoGanado)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMcgcatTiposdeGanado")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MCGCatTiposdeGanado]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MCGCatTiposdeGanado'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idTipoGanado">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMcgcatTiposdeGanado(opcion As System.Int32, idTipoGanado As System.Int32, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdTipoGanado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idTipoGanado)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMcgcatTiposdeGanado")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MCGCatTiposdeGanado]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MCGCatTiposdeGanado'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idTipoGanado">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMcgcatTiposdeGanado(opcion As System.Int32, idTipoGanado As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdTipoGanado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idTipoGanado)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMcgcatTiposdeGanado")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MCGCatTiposdeGanado]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MCGCatTiposdeGanado'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idTipoGanado">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMcgcatTiposdeGanado(opcion As System.Int32, idTipoGanado As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdTipoGanado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idTipoGanado)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMcgcatTiposdeGanado")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MCGCatTiposdeGanado]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MCGCatTiposdeGanado'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idTipoGanado">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMcgcatTiposdeGanadoCallAsQuery( opcion As System.Int32, idTipoGanado As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MCGCatTiposdeGanado]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@IdTipoGanado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idTipoGanado))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MCGCatVehiculos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idVehiculo">Input parameter of stored procedure</param>
		''' <param name="descVehiculo">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMcgcatVehiculos(opcion As System.Int32, idVehiculo As System.Int32, descVehiculo As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idVehiculo)
			parameters(2) = new SqlParameter("@DescVehiculo", SqlDbType.VarChar, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descVehiculo)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMcgcatVehiculos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MCGCatVehiculos]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MCGCatVehiculos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idVehiculo">Input parameter of stored procedure</param>
		''' <param name="descVehiculo">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMcgcatVehiculos(opcion As System.Int32, idVehiculo As System.Int32, descVehiculo As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idVehiculo)
			parameters(2) = new SqlParameter("@DescVehiculo", SqlDbType.VarChar, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descVehiculo)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMcgcatVehiculos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MCGCatVehiculos]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MCGCatVehiculos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idVehiculo">Input parameter of stored procedure</param>
		''' <param name="descVehiculo">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMcgcatVehiculos(opcion As System.Int32, idVehiculo As System.Int32, descVehiculo As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idVehiculo)
			parameters(2) = new SqlParameter("@DescVehiculo", SqlDbType.VarChar, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descVehiculo)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMcgcatVehiculos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MCGCatVehiculos]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MCGCatVehiculos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idVehiculo">Input parameter of stored procedure</param>
		''' <param name="descVehiculo">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMcgcatVehiculos(opcion As System.Int32, idVehiculo As System.Int32, descVehiculo As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idVehiculo)
			parameters(2) = new SqlParameter("@DescVehiculo", SqlDbType.VarChar, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descVehiculo)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMcgcatVehiculos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MCGCatVehiculos]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MCGCatVehiculos'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idVehiculo">Input parameter of stored procedure</param>
		''' <param name="descVehiculo">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMcgcatVehiculosCallAsQuery( opcion As System.Int32, idVehiculo As System.Int32, descVehiculo As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MCGCatVehiculos]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@IdVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idVehiculo))
			toReturn.Parameters.Add(New SqlParameter("@DescVehiculo", SqlDbType.VarChar, 100, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descVehiculo))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MFacEmbarquesCab'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioEmbarque">Input parameter of stored procedure</param>
		''' <param name="nombre">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMfacEmbarquesCab(opcion As System.Int32, idFolioEmbarque As System.String, nombre As System.String, fechaInicial As System.DateTime, fechaFinal As System.DateTime) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(5 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdFolioEmbarque", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioEmbarque)
			parameters(2) = new SqlParameter("@Nombre", SqlDbType.VarChar, 120, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombre)
			parameters(3) = new SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial)
			parameters(4) = new SqlParameter("@FEchaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMfacEmbarquesCab")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MFacEmbarquesCab]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MFacEmbarquesCab'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioEmbarque">Input parameter of stored procedure</param>
		''' <param name="nombre">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMfacEmbarquesCab(opcion As System.Int32, idFolioEmbarque As System.String, nombre As System.String, fechaInicial As System.DateTime, fechaFinal As System.DateTime, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(5) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdFolioEmbarque", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioEmbarque)
			parameters(2) = new SqlParameter("@Nombre", SqlDbType.VarChar, 120, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombre)
			parameters(3) = new SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial)
			parameters(4) = new SqlParameter("@FEchaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal)

			' Return value parameter
			parameters(5) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMfacEmbarquesCab")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MFacEmbarquesCab]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(5).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MFacEmbarquesCab'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioEmbarque">Input parameter of stored procedure</param>
		''' <param name="nombre">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMfacEmbarquesCab(opcion As System.Int32, idFolioEmbarque As System.String, nombre As System.String, fechaInicial As System.DateTime, fechaFinal As System.DateTime, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(5 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdFolioEmbarque", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioEmbarque)
			parameters(2) = new SqlParameter("@Nombre", SqlDbType.VarChar, 120, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombre)
			parameters(3) = new SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial)
			parameters(4) = new SqlParameter("@FEchaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMfacEmbarquesCab")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MFacEmbarquesCab]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MFacEmbarquesCab'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioEmbarque">Input parameter of stored procedure</param>
		''' <param name="nombre">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMfacEmbarquesCab(opcion As System.Int32, idFolioEmbarque As System.String, nombre As System.String, fechaInicial As System.DateTime, fechaFinal As System.DateTime, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(5) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdFolioEmbarque", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioEmbarque)
			parameters(2) = new SqlParameter("@Nombre", SqlDbType.VarChar, 120, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombre)
			parameters(3) = new SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial)
			parameters(4) = new SqlParameter("@FEchaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal)

			' Return value parameter
			parameters(5) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMfacEmbarquesCab")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MFacEmbarquesCab]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(5).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MFacEmbarquesCab'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioEmbarque">Input parameter of stored procedure</param>
		''' <param name="nombre">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMfacEmbarquesCabCallAsQuery( opcion As System.Int32, idFolioEmbarque As System.String, nombre As System.String, fechaInicial As System.DateTime, fechaFinal As System.DateTime) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MFacEmbarquesCab]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@IdFolioEmbarque", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioEmbarque))
			toReturn.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.VarChar, 120, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombre))
			toReturn.Parameters.Add(New SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial))
			toReturn.Parameters.Add(New SqlParameter("@FEchaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MFacEmbarquesDet'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioEmbarque">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="idDestino">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMfacEmbarquesDet(opcion As System.Int32, idFolioEmbarque As System.String, idCliente As System.Int32, idDestino As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdFolioEmbarque", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioEmbarque)
			parameters(2) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(3) = new SqlParameter("@IdDestino", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idDestino)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMfacEmbarquesDet")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MFacEmbarquesDet]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MFacEmbarquesDet'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioEmbarque">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="idDestino">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMfacEmbarquesDet(opcion As System.Int32, idFolioEmbarque As System.String, idCliente As System.Int32, idDestino As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdFolioEmbarque", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioEmbarque)
			parameters(2) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(3) = new SqlParameter("@IdDestino", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idDestino)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMfacEmbarquesDet")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MFacEmbarquesDet]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MFacEmbarquesDet'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioEmbarque">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="idDestino">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMfacEmbarquesDet(opcion As System.Int32, idFolioEmbarque As System.String, idCliente As System.Int32, idDestino As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdFolioEmbarque", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioEmbarque)
			parameters(2) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(3) = new SqlParameter("@IdDestino", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idDestino)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMfacEmbarquesDet")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MFacEmbarquesDet]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MFacEmbarquesDet'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioEmbarque">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="idDestino">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMfacEmbarquesDet(opcion As System.Int32, idFolioEmbarque As System.String, idCliente As System.Int32, idDestino As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdFolioEmbarque", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioEmbarque)
			parameters(2) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(3) = new SqlParameter("@IdDestino", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idDestino)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMfacEmbarquesDet")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MFacEmbarquesDet]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MFacEmbarquesDet'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioEmbarque">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="idDestino">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMfacEmbarquesDetCallAsQuery( opcion As System.Int32, idFolioEmbarque As System.String, idCliente As System.Int32, idDestino As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MFacEmbarquesDet]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@IdFolioEmbarque", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioEmbarque))
			toReturn.Parameters.Add(New SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente))
			toReturn.Parameters.Add(New SqlParameter("@IdDestino", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idDestino))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MGRALCatCiudades'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMgralcatCiudades(opcion As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, descripcion As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad)
			parameters(3) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMgralcatCiudades")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MGRALCatCiudades]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MGRALCatCiudades'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMgralcatCiudades(opcion As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, descripcion As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad)
			parameters(3) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMgralcatCiudades")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MGRALCatCiudades]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MGRALCatCiudades'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMgralcatCiudades(opcion As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, descripcion As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad)
			parameters(3) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMgralcatCiudades")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MGRALCatCiudades]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MGRALCatCiudades'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMgralcatCiudades(opcion As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, descripcion As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad)
			parameters(3) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMgralcatCiudades")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MGRALCatCiudades]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MGRALCatCiudades'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMgralcatCiudadesCallAsQuery( opcion As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, descripcion As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MGRALCatCiudades]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado))
			toReturn.Parameters.Add(New SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad))
			toReturn.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MGRALCatEstados'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMgralcatEstados(opcion As System.Int32, idEstado As System.Int32, descripcion As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMgralcatEstados")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MGRALCatEstados]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MGRALCatEstados'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMgralcatEstados(opcion As System.Int32, idEstado As System.Int32, descripcion As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMgralcatEstados")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MGRALCatEstados]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MGRALCatEstados'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMgralcatEstados(opcion As System.Int32, idEstado As System.Int32, descripcion As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMgralcatEstados")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MGRALCatEstados]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MGRALCatEstados'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMgralcatEstados(opcion As System.Int32, idEstado As System.Int32, descripcion As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMgralcatEstados")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MGRALCatEstados]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MGRALCatEstados'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMgralcatEstadosCallAsQuery( opcion As System.Int32, idEstado As System.Int32, descripcion As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MGRALCatEstados]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado))
			toReturn.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MGRALCatPoblaciones'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="idPoblacion">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMgralcatPoblaciones(opcion As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, idPoblacion As System.Int32, descripcion As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(5 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad)
			parameters(3) = new SqlParameter("@IdPoblacion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPoblacion)
			parameters(4) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMgralcatPoblaciones")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MGRALCatPoblaciones]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MGRALCatPoblaciones'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="idPoblacion">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMgralcatPoblaciones(opcion As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, idPoblacion As System.Int32, descripcion As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(5) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad)
			parameters(3) = new SqlParameter("@IdPoblacion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPoblacion)
			parameters(4) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)

			' Return value parameter
			parameters(5) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMgralcatPoblaciones")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MGRALCatPoblaciones]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(5).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MGRALCatPoblaciones'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="idPoblacion">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMgralcatPoblaciones(opcion As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, idPoblacion As System.Int32, descripcion As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(5 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad)
			parameters(3) = new SqlParameter("@IdPoblacion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPoblacion)
			parameters(4) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMgralcatPoblaciones")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MGRALCatPoblaciones]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MGRALCatPoblaciones'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="idPoblacion">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMgralcatPoblaciones(opcion As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, idPoblacion As System.Int32, descripcion As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(5) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad)
			parameters(3) = new SqlParameter("@IdPoblacion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPoblacion)
			parameters(4) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)

			' Return value parameter
			parameters(5) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMgralcatPoblaciones")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MGRALCatPoblaciones]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(5).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MGRALCatPoblaciones'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="idPoblacion">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMgralcatPoblacionesCallAsQuery( opcion As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, idPoblacion As System.Int32, descripcion As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MGRALCatPoblaciones]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado))
			toReturn.Parameters.Add(New SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad))
			toReturn.Parameters.Add(New SqlParameter("@IdPoblacion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPoblacion))
			toReturn.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MGRALCatPuntosEntrega'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="idPoblacion">Input parameter of stored procedure</param>
		''' <param name="idPuntoEntrega">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMgralcatPuntosEntrega(opcion As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, idPoblacion As System.Int32, idPuntoEntrega As System.Int32, idCliente As System.Int32, descripcion As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(7 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad)
			parameters(3) = new SqlParameter("@IdPoblacion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPoblacion)
			parameters(4) = new SqlParameter("@IdPuntoEntrega", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPuntoEntrega)
			parameters(5) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(6) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 250, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMgralcatPuntosEntrega")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MGRALCatPuntosEntrega]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MGRALCatPuntosEntrega'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="idPoblacion">Input parameter of stored procedure</param>
		''' <param name="idPuntoEntrega">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMgralcatPuntosEntrega(opcion As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, idPoblacion As System.Int32, idPuntoEntrega As System.Int32, idCliente As System.Int32, descripcion As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(7) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad)
			parameters(3) = new SqlParameter("@IdPoblacion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPoblacion)
			parameters(4) = new SqlParameter("@IdPuntoEntrega", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPuntoEntrega)
			parameters(5) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(6) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 250, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)

			' Return value parameter
			parameters(7) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMgralcatPuntosEntrega")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MGRALCatPuntosEntrega]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(7).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MGRALCatPuntosEntrega'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="idPoblacion">Input parameter of stored procedure</param>
		''' <param name="idPuntoEntrega">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMgralcatPuntosEntrega(opcion As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, idPoblacion As System.Int32, idPuntoEntrega As System.Int32, idCliente As System.Int32, descripcion As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(7 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad)
			parameters(3) = new SqlParameter("@IdPoblacion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPoblacion)
			parameters(4) = new SqlParameter("@IdPuntoEntrega", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPuntoEntrega)
			parameters(5) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(6) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 250, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMgralcatPuntosEntrega")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MGRALCatPuntosEntrega]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MGRALCatPuntosEntrega'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="idPoblacion">Input parameter of stored procedure</param>
		''' <param name="idPuntoEntrega">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMgralcatPuntosEntrega(opcion As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, idPoblacion As System.Int32, idPuntoEntrega As System.Int32, idCliente As System.Int32, descripcion As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(7) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado)
			parameters(2) = new SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad)
			parameters(3) = new SqlParameter("@IdPoblacion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPoblacion)
			parameters(4) = new SqlParameter("@IdPuntoEntrega", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPuntoEntrega)
			parameters(5) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(6) = new SqlParameter("@Descripcion", SqlDbType.VarChar, 250, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)

			' Return value parameter
			parameters(7) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMgralcatPuntosEntrega")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MGRALCatPuntosEntrega]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(7).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MGRALCatPuntosEntrega'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idEstado">Input parameter of stored procedure</param>
		''' <param name="idCiudad">Input parameter of stored procedure</param>
		''' <param name="idPoblacion">Input parameter of stored procedure</param>
		''' <param name="idPuntoEntrega">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMgralcatPuntosEntregaCallAsQuery( opcion As System.Int32, idEstado As System.Int32, idCiudad As System.Int32, idPoblacion As System.Int32, idPuntoEntrega As System.Int32, idCliente As System.Int32, descripcion As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MGRALCatPuntosEntrega]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@IdEstado", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idEstado))
			toReturn.Parameters.Add(New SqlParameter("@IdCiudad", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCiudad))
			toReturn.Parameters.Add(New SqlParameter("@IdPoblacion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPoblacion))
			toReturn.Parameters.Add(New SqlParameter("@IdPuntoEntrega", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPuntoEntrega))
			toReturn.Parameters.Add(New SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente))
			toReturn.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.VarChar, 250, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCatMotivosDecomiso'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idMotivoDec">Input parameter of stored procedure</param>
		''' <param name="nombreMotivoDec">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccatMotivosDecomiso(numOpc As System.Int32, idMotivoDec As System.Int32, nombreMotivoDec As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdMotivoDec", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idMotivoDec)
			parameters(2) = new SqlParameter("@NombreMotivoDec", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreMotivoDec)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsccatMotivosDecomiso")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCatMotivosDecomiso]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCatMotivosDecomiso'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idMotivoDec">Input parameter of stored procedure</param>
		''' <param name="nombreMotivoDec">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccatMotivosDecomiso(numOpc As System.Int32, idMotivoDec As System.Int32, nombreMotivoDec As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdMotivoDec", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idMotivoDec)
			parameters(2) = new SqlParameter("@NombreMotivoDec", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreMotivoDec)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsccatMotivosDecomiso")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCatMotivosDecomiso]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCatMotivosDecomiso'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idMotivoDec">Input parameter of stored procedure</param>
		''' <param name="nombreMotivoDec">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccatMotivosDecomiso(numOpc As System.Int32, idMotivoDec As System.Int32, nombreMotivoDec As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdMotivoDec", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idMotivoDec)
			parameters(2) = new SqlParameter("@NombreMotivoDec", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreMotivoDec)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsccatMotivosDecomiso")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCatMotivosDecomiso]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCatMotivosDecomiso'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idMotivoDec">Input parameter of stored procedure</param>
		''' <param name="nombreMotivoDec">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccatMotivosDecomiso(numOpc As System.Int32, idMotivoDec As System.Int32, nombreMotivoDec As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdMotivoDec", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idMotivoDec)
			parameters(2) = new SqlParameter("@NombreMotivoDec", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreMotivoDec)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsccatMotivosDecomiso")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCatMotivosDecomiso]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MSCCatMotivosDecomiso'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idMotivoDec">Input parameter of stored procedure</param>
		''' <param name="nombreMotivoDec">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMsccatMotivosDecomisoCallAsQuery( numOpc As System.Int32, idMotivoDec As System.Int32, nombreMotivoDec As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MSCCatMotivosDecomiso]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@IdMotivoDec", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idMotivoDec))
			toReturn.Parameters.Add(New SqlParameter("@NombreMotivoDec", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nombreMotivoDec))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCatMovtosAlmacen'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="idCodMovimiento">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccatMovtosAlmacen(idCodMovimiento As System.Int32, opcion As System.Int32) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@IdCodMovimiento", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCodMovimiento)
			parameters(1) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMsccatMovtosAlmacen")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCatMovtosAlmacen]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCatMovtosAlmacen'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="idCodMovimiento">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccatMovtosAlmacen(idCodMovimiento As System.Int32, opcion As System.Int32, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@IdCodMovimiento", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCodMovimiento)
			parameters(1) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMsccatMovtosAlmacen")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCatMovtosAlmacen]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCatMovtosAlmacen'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="idCodMovimiento">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccatMovtosAlmacen(idCodMovimiento As System.Int32, opcion As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@IdCodMovimiento", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCodMovimiento)
			parameters(1) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMsccatMovtosAlmacen")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCatMovtosAlmacen]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCatMovtosAlmacen'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="idCodMovimiento">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccatMovtosAlmacen(idCodMovimiento As System.Int32, opcion As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@IdCodMovimiento", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCodMovimiento)
			parameters(1) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMsccatMovtosAlmacen")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCatMovtosAlmacen]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MSCCatMovtosAlmacen'.
		''' 
		''' </summary>
		''' <param name="idCodMovimiento">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMsccatMovtosAlmacenCallAsQuery( idCodMovimiento As System.Int32, opcion As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MSCCatMovtosAlmacen]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@IdCodMovimiento", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCodMovimiento))
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCatProductos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="idProducto">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccatProductos(idProducto As System.Int32, descripcion As System.String, idCliente As System.Int32, opcion As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@IdProducto", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProducto)
			parameters(1) = new SqlParameter("@Descripcion", SqlDbType.Char, 80, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)
			parameters(2) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(3) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsccatProductos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCatProductos]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCatProductos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="idProducto">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccatProductos(idProducto As System.Int32, descripcion As System.String, idCliente As System.Int32, opcion As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@IdProducto", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProducto)
			parameters(1) = new SqlParameter("@Descripcion", SqlDbType.Char, 80, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)
			parameters(2) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(3) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsccatProductos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCatProductos]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCatProductos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="idProducto">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccatProductos(idProducto As System.Int32, descripcion As System.String, idCliente As System.Int32, opcion As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@IdProducto", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProducto)
			parameters(1) = new SqlParameter("@Descripcion", SqlDbType.Char, 80, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)
			parameters(2) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(3) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsccatProductos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCatProductos]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCatProductos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="idProducto">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccatProductos(idProducto As System.Int32, descripcion As System.String, idCliente As System.Int32, opcion As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@IdProducto", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProducto)
			parameters(1) = new SqlParameter("@Descripcion", SqlDbType.Char, 80, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion)
			parameters(2) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(3) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsccatProductos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCatProductos]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MSCCatProductos'.
		''' 
		''' </summary>
		''' <param name="idProducto">Input parameter of stored procedure</param>
		''' <param name="descripcion">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMsccatProductosCallAsQuery( idProducto As System.Int32, descripcion As System.String, idCliente As System.Int32, opcion As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MSCCatProductos]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@IdProducto", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProducto))
			toReturn.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.Char, 80, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, descripcion))
			toReturn.Parameters.Add(New SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente))
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCatTipGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="nomGanado">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccatTipGan(nomGanado As System.String, numOpc As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Nom_Ganado", SqlDbType.VarChar, 80, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomGanado)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsccatTipGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCatTipGan]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCatTipGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="nomGanado">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccatTipGan(nomGanado As System.String, numOpc As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Nom_Ganado", SqlDbType.VarChar, 80, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomGanado)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsccatTipGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCatTipGan]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCatTipGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="nomGanado">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccatTipGan(nomGanado As System.String, numOpc As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Nom_Ganado", SqlDbType.VarChar, 80, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomGanado)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsccatTipGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCatTipGan]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCatTipGan'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="nomGanado">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccatTipGan(nomGanado As System.String, numOpc As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Nom_Ganado", SqlDbType.VarChar, 80, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomGanado)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsccatTipGan")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCatTipGan]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MSCCatTipGan'.
		''' 
		''' </summary>
		''' <param name="nomGanado">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMsccatTipGanCallAsQuery( nomGanado As System.String, numOpc As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MSCCatTipGan]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Nom_Ganado", SqlDbType.VarChar, 80, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, nomGanado))
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MSCConfigAlmacenes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscconfigAlmacenes(opcion As System.Int32) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMscconfigAlmacenes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCConfigAlmacenes]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCConfigAlmacenes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscconfigAlmacenes(opcion As System.Int32, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMscconfigAlmacenes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCConfigAlmacenes]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MSCConfigAlmacenes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscconfigAlmacenes(opcion As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMscconfigAlmacenes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCConfigAlmacenes]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCConfigAlmacenes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscconfigAlmacenes(opcion As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMscconfigAlmacenes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCConfigAlmacenes]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MSCConfigAlmacenes'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMscconfigAlmacenesCallAsQuery( opcion As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MSCConfigAlmacenes]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MSCConfigsAlmacenes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscconfigsAlmacenes(opcion As System.Int32) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMscconfigsAlmacenes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCConfigsAlmacenes]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCConfigsAlmacenes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscconfigsAlmacenes(opcion As System.Int32, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMscconfigsAlmacenes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCConfigsAlmacenes]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MSCConfigsAlmacenes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscconfigsAlmacenes(opcion As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMscconfigsAlmacenes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCConfigsAlmacenes]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCConfigsAlmacenes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscconfigsAlmacenes(opcion As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMscconfigsAlmacenes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCConfigsAlmacenes]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MSCConfigsAlmacenes'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMscconfigsAlmacenesCallAsQuery( opcion As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MSCConfigsAlmacenes]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="codCliente">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccortes(opcion As System.Int32, codCliente As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@CodCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codCliente)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsccortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCortes]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="codCliente">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccortes(opcion As System.Int32, codCliente As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@CodCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codCliente)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsccortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCortes]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="codCliente">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccortes(opcion As System.Int32, codCliente As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@CodCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codCliente)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsccortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCortes]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="codCliente">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccortes(opcion As System.Int32, codCliente As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@CodCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codCliente)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsccortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCortes]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MSCCortes'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="codCliente">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMsccortesCallAsQuery( opcion As System.Int32, codCliente As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MSCCortes]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@CodCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codCliente))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCortesPreCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="idPreCorte">Input parameter of stored procedure</param>
		''' <param name="idCorte">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccortesPreCortes(idPreCorte As System.Int32, idCorte As System.Int32, opcion As System.Int32) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@IdPreCorte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPreCorte)
			parameters(1) = new SqlParameter("@IdCorte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCorte)
			parameters(2) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMsccortesPreCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCortesPreCortes]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCortesPreCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="idPreCorte">Input parameter of stored procedure</param>
		''' <param name="idCorte">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccortesPreCortes(idPreCorte As System.Int32, idCorte As System.Int32, opcion As System.Int32, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@IdPreCorte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPreCorte)
			parameters(1) = new SqlParameter("@IdCorte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCorte)
			parameters(2) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMsccortesPreCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCortesPreCortes]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCortesPreCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="idPreCorte">Input parameter of stored procedure</param>
		''' <param name="idCorte">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccortesPreCortes(idPreCorte As System.Int32, idCorte As System.Int32, opcion As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@IdPreCorte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPreCorte)
			parameters(1) = new SqlParameter("@IdCorte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCorte)
			parameters(2) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMsccortesPreCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCortesPreCortes]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCCortesPreCortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="idPreCorte">Input parameter of stored procedure</param>
		''' <param name="idCorte">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsccortesPreCortes(idPreCorte As System.Int32, idCorte As System.Int32, opcion As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@IdPreCorte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPreCorte)
			parameters(1) = new SqlParameter("@IdCorte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCorte)
			parameters(2) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMsccortesPreCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCCortesPreCortes]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MSCCortesPreCortes'.
		''' 
		''' </summary>
		''' <param name="idPreCorte">Input parameter of stored procedure</param>
		''' <param name="idCorte">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMsccortesPreCortesCallAsQuery( idPreCorte As System.Int32, idCorte As System.Int32, opcion As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MSCCortesPreCortes]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@IdPreCorte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idPreCorte))
			toReturn.Parameters.Add(New SqlParameter("@IdCorte", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCorte))
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MSCLayoutEtiqueta'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsclayoutEtiqueta(opcion As System.Int32) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMsclayoutEtiqueta")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCLayoutEtiqueta]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCLayoutEtiqueta'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsclayoutEtiqueta(opcion As System.Int32, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMsclayoutEtiqueta")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCLayoutEtiqueta]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MSCLayoutEtiqueta'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsclayoutEtiqueta(opcion As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMsclayoutEtiqueta")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCLayoutEtiqueta]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCLayoutEtiqueta'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsclayoutEtiqueta(opcion As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMsclayoutEtiqueta")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCLayoutEtiqueta]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MSCLayoutEtiqueta'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMsclayoutEtiquetaCallAsQuery( opcion As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MSCLayoutEtiqueta]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MSCLayoutEtiquetas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsclayoutEtiquetas(opcion As System.Int32) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMsclayoutEtiquetas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCLayoutEtiquetas]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCLayoutEtiquetas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsclayoutEtiquetas(opcion As System.Int32, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMsclayoutEtiquetas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCLayoutEtiquetas]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MSCLayoutEtiquetas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsclayoutEtiquetas(opcion As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(1 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMsclayoutEtiquetas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCLayoutEtiquetas]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCLayoutEtiquetas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsclayoutEtiquetas(opcion As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)

			' Return value parameter
			parameters(1) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMsclayoutEtiquetas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCLayoutEtiquetas]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(1).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MSCLayoutEtiquetas'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMsclayoutEtiquetasCallAsQuery( opcion As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MSCLayoutEtiquetas]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MSCLoteCortesCab'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idLoteCorte">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscloteCortesCab(numOpc As System.Int32, idLoteCorte As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdLoteCorte", SqlDbType.VarChar, 12, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idLoteCorte)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMscloteCortesCab")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCLoteCortesCab]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCLoteCortesCab'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idLoteCorte">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscloteCortesCab(numOpc As System.Int32, idLoteCorte As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdLoteCorte", SqlDbType.VarChar, 12, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idLoteCorte)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMscloteCortesCab")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCLoteCortesCab]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MSCLoteCortesCab'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idLoteCorte">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscloteCortesCab(numOpc As System.Int32, idLoteCorte As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdLoteCorte", SqlDbType.VarChar, 12, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idLoteCorte)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMscloteCortesCab")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCLoteCortesCab]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCLoteCortesCab'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idLoteCorte">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscloteCortesCab(numOpc As System.Int32, idLoteCorte As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)
			parameters(1) = new SqlParameter("@IdLoteCorte", SqlDbType.VarChar, 12, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idLoteCorte)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMscloteCortesCab")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCLoteCortesCab]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MSCLoteCortesCab'.
		''' 
		''' </summary>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="idLoteCorte">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMscloteCortesCabCallAsQuery( numOpc As System.Int32, idLoteCorte As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MSCLoteCortesCab]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))
			toReturn.Parameters.Add(New SqlParameter("@IdLoteCorte", SqlDbType.VarChar, 12, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idLoteCorte))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MSCLotesCanales'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioSacrificio">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsclotesCanales(opcion As System.Int32, idFolioSacrificio As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdFolioSacrificio", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioSacrificio)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsclotesCanales")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCLotesCanales]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCLotesCanales'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioSacrificio">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsclotesCanales(opcion As System.Int32, idFolioSacrificio As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdFolioSacrificio", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioSacrificio)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsclotesCanales")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCLotesCanales]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MSCLotesCanales'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioSacrificio">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsclotesCanales(opcion As System.Int32, idFolioSacrificio As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdFolioSacrificio", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioSacrificio)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsclotesCanales")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCLotesCanales]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCLotesCanales'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioSacrificio">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsclotesCanales(opcion As System.Int32, idFolioSacrificio As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdFolioSacrificio", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioSacrificio)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsclotesCanales")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCLotesCanales]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MSCLotesCanales'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioSacrificio">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMsclotesCanalesCallAsQuery( opcion As System.Int32, idFolioSacrificio As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MSCLotesCanales]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@IdFolioSacrificio", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioSacrificio))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MSCLotesCorrales'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="codCorral">Input parameter of stored procedure</param>
		''' <param name="codLote">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsclotesCorrales(codCorral As System.String, codLote As System.Int32, numOpc As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@CodCorral", SqlDbType.Char, 5, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, codCorral)
			parameters(1) = new SqlParameter("@CodLote", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codLote)
			parameters(2) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsclotesCorrales")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCLotesCorrales]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCLotesCorrales'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="codCorral">Input parameter of stored procedure</param>
		''' <param name="codLote">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsclotesCorrales(codCorral As System.String, codLote As System.Int32, numOpc As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@CodCorral", SqlDbType.Char, 5, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, codCorral)
			parameters(1) = new SqlParameter("@CodLote", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codLote)
			parameters(2) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsclotesCorrales")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCLotesCorrales]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MSCLotesCorrales'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="codCorral">Input parameter of stored procedure</param>
		''' <param name="codLote">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsclotesCorrales(codCorral As System.String, codLote As System.Int32, numOpc As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@CodCorral", SqlDbType.Char, 5, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, codCorral)
			parameters(1) = new SqlParameter("@CodLote", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codLote)
			parameters(2) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsclotesCorrales")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCLotesCorrales]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCLotesCorrales'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="codCorral">Input parameter of stored procedure</param>
		''' <param name="codLote">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMsclotesCorrales(codCorral As System.String, codLote As System.Int32, numOpc As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@CodCorral", SqlDbType.Char, 5, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, codCorral)
			parameters(1) = new SqlParameter("@CodLote", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codLote)
			parameters(2) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMsclotesCorrales")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCLotesCorrales]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MSCLotesCorrales'.
		''' 
		''' </summary>
		''' <param name="codCorral">Input parameter of stored procedure</param>
		''' <param name="codLote">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMsclotesCorralesCallAsQuery( codCorral As System.String, codLote As System.Int32, numOpc As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MSCLotesCorrales]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@CodCorral", SqlDbType.Char, 5, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, codCorral))
			toReturn.Parameters.Add(New SqlParameter("@CodLote", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, codLote))
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MSCProductosdeComisos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idProducto">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscproductosdeComisos(opcion As System.Int32, idProducto As System.Int32) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdProducto", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProducto)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMscproductosdeComisos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCProductosdeComisos]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCProductosdeComisos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idProducto">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscproductosdeComisos(opcion As System.Int32, idProducto As System.Int32, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdProducto", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProducto)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMscproductosdeComisos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCProductosdeComisos]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MSCProductosdeComisos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idProducto">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscproductosdeComisos(opcion As System.Int32, idProducto As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdProducto", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProducto)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMscproductosdeComisos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCProductosdeComisos]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCProductosdeComisos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idProducto">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscproductosdeComisos(opcion As System.Int32, idProducto As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdProducto", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProducto)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMscproductosdeComisos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCProductosdeComisos]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MSCProductosdeComisos'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idProducto">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMscproductosdeComisosCallAsQuery( opcion As System.Int32, idProducto As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MSCProductosdeComisos]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@IdProducto", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProducto))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MSCProductosValorAgregado'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idProducto">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscproductosValorAgregado(opcion As System.Int32, idProducto As System.Int32) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdProducto", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProducto)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMscproductosValorAgregado")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCProductosValorAgregado]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCProductosValorAgregado'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idProducto">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscproductosValorAgregado(opcion As System.Int32, idProducto As System.Int32, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdProducto", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProducto)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMscproductosValorAgregado")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCProductosValorAgregado]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MSCProductosValorAgregado'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idProducto">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscproductosValorAgregado(opcion As System.Int32, idProducto As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdProducto", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProducto)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMscproductosValorAgregado")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCProductosValorAgregado]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCProductosValorAgregado'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idProducto">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscproductosValorAgregado(opcion As System.Int32, idProducto As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdProducto", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProducto)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConMscproductosValorAgregado")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCProductosValorAgregado]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MSCProductosValorAgregado'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idProducto">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMscproductosValorAgregadoCallAsQuery( opcion As System.Int32, idProducto As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MSCProductosValorAgregado]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@IdProducto", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProducto))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MSCRecepcionCanalesCab'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioLote">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscrecepcionCanalesCab(folioLote As System.String, numOpc As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@FolioLote", SqlDbType.Char, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioLote)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMscrecepcionCanalesCab")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCRecepcionCanalesCab]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCRecepcionCanalesCab'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioLote">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscrecepcionCanalesCab(folioLote As System.String, numOpc As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@FolioLote", SqlDbType.Char, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioLote)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMscrecepcionCanalesCab")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCRecepcionCanalesCab]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MSCRecepcionCanalesCab'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioLote">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscrecepcionCanalesCab(folioLote As System.String, numOpc As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@FolioLote", SqlDbType.Char, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioLote)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMscrecepcionCanalesCab")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCRecepcionCanalesCab]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCRecepcionCanalesCab'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioLote">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscrecepcionCanalesCab(folioLote As System.String, numOpc As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@FolioLote", SqlDbType.Char, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioLote)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMscrecepcionCanalesCab")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCRecepcionCanalesCab]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MSCRecepcionCanalesCab'.
		''' 
		''' </summary>
		''' <param name="folioLote">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMscrecepcionCanalesCabCallAsQuery( folioLote As System.String, numOpc As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MSCRecepcionCanalesCab]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@FolioLote", SqlDbType.Char, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioLote))
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MSCRecepcionCanalesDet'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioLote">Input parameter of stored procedure</param>
		''' <param name="idFolioCanal">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="fecha">Input parameter of stored procedure</param>
		''' <param name="loteCorte">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscrecepcionCanalesDet(folioLote As System.String, idFolioCanal As System.String, opcion As System.Int32, fecha As System.DateTime, loteCorte As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(5 - 1) {}
			parameters(0) = new SqlParameter("@FolioLote", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioLote)
			parameters(1) = new SqlParameter("@IdFolioCanal", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioCanal)
			parameters(2) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(3) = new SqlParameter("@fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fecha)
			parameters(4) = new SqlParameter("@LoteCorte", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteCorte)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMscrecepcionCanalesDet")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCRecepcionCanalesDet]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCRecepcionCanalesDet'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioLote">Input parameter of stored procedure</param>
		''' <param name="idFolioCanal">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="fecha">Input parameter of stored procedure</param>
		''' <param name="loteCorte">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscrecepcionCanalesDet(folioLote As System.String, idFolioCanal As System.String, opcion As System.Int32, fecha As System.DateTime, loteCorte As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(5) {}
			parameters(0) = new SqlParameter("@FolioLote", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioLote)
			parameters(1) = new SqlParameter("@IdFolioCanal", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioCanal)
			parameters(2) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(3) = new SqlParameter("@fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fecha)
			parameters(4) = new SqlParameter("@LoteCorte", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteCorte)

			' Return value parameter
			parameters(5) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMscrecepcionCanalesDet")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCRecepcionCanalesDet]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(5).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MSCRecepcionCanalesDet'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioLote">Input parameter of stored procedure</param>
		''' <param name="idFolioCanal">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="fecha">Input parameter of stored procedure</param>
		''' <param name="loteCorte">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscrecepcionCanalesDet(folioLote As System.String, idFolioCanal As System.String, opcion As System.Int32, fecha As System.DateTime, loteCorte As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(5 - 1) {}
			parameters(0) = new SqlParameter("@FolioLote", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioLote)
			parameters(1) = new SqlParameter("@IdFolioCanal", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioCanal)
			parameters(2) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(3) = new SqlParameter("@fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fecha)
			parameters(4) = new SqlParameter("@LoteCorte", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteCorte)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMscrecepcionCanalesDet")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCRecepcionCanalesDet]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCRecepcionCanalesDet'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioLote">Input parameter of stored procedure</param>
		''' <param name="idFolioCanal">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="fecha">Input parameter of stored procedure</param>
		''' <param name="loteCorte">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscrecepcionCanalesDet(folioLote As System.String, idFolioCanal As System.String, opcion As System.Int32, fecha As System.DateTime, loteCorte As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(5) {}
			parameters(0) = new SqlParameter("@FolioLote", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioLote)
			parameters(1) = new SqlParameter("@IdFolioCanal", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioCanal)
			parameters(2) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(3) = new SqlParameter("@fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fecha)
			parameters(4) = new SqlParameter("@LoteCorte", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteCorte)

			' Return value parameter
			parameters(5) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMscrecepcionCanalesDet")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCRecepcionCanalesDet]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(5).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MSCRecepcionCanalesDet'.
		''' 
		''' </summary>
		''' <param name="folioLote">Input parameter of stored procedure</param>
		''' <param name="idFolioCanal">Input parameter of stored procedure</param>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="fecha">Input parameter of stored procedure</param>
		''' <param name="loteCorte">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMscrecepcionCanalesDetCallAsQuery( folioLote As System.String, idFolioCanal As System.String, opcion As System.Int32, fecha As System.DateTime, loteCorte As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MSCRecepcionCanalesDet]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@FolioLote", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioLote))
			toReturn.Parameters.Add(New SqlParameter("@IdFolioCanal", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioCanal))
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fecha))
			toReturn.Parameters.Add(New SqlParameter("@LoteCorte", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteCorte))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_MSCSalidasGanado'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioSalidaGanado">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscsalidasGanado(folioSalidaGanado As System.String, numOpc As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@FolioSalidaGanado", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioSalidaGanado)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMscsalidasGanado")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCSalidasGanado]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCSalidasGanado'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioSalidaGanado">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscsalidasGanado(folioSalidaGanado As System.String, numOpc As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@FolioSalidaGanado", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioSalidaGanado)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMscsalidasGanado")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCSalidasGanado]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_MSCSalidasGanado'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioSalidaGanado">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscsalidasGanado(folioSalidaGanado As System.String, numOpc As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@FolioSalidaGanado", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioSalidaGanado)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMscsalidasGanado")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCSalidasGanado]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_MSCSalidasGanado'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="folioSalidaGanado">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConMscsalidasGanado(folioSalidaGanado As System.String, numOpc As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@FolioSalidaGanado", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioSalidaGanado)
			parameters(1) = new SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConMscsalidasGanado")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_MSCSalidasGanado]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_MSCSalidasGanado'.
		''' 
		''' </summary>
		''' <param name="folioSalidaGanado">Input parameter of stored procedure</param>
		''' <param name="numOpc">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConMscsalidasGanadoCallAsQuery( folioSalidaGanado As System.String, numOpc As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_MSCSalidasGanado]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@FolioSalidaGanado", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioSalidaGanado))
			toReturn.Parameters.Add(New SqlParameter("@NumOpc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, numOpc))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_Polizas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="numeroPol">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConPolizas(opcion As System.Int32, numeroPol As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@Numero_Pol", SqlDbType.Char, 8, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, numeroPol)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConPolizas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_Polizas]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_Polizas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="numeroPol">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConPolizas(opcion As System.Int32, numeroPol As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@Numero_Pol", SqlDbType.Char, 8, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, numeroPol)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConPolizas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_Polizas]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_Polizas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="numeroPol">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConPolizas(opcion As System.Int32, numeroPol As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@Numero_Pol", SqlDbType.Char, 8, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, numeroPol)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConPolizas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_Polizas]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_Polizas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="numeroPol">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConPolizas(opcion As System.Int32, numeroPol As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@Numero_Pol", SqlDbType.Char, 8, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, numeroPol)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConPolizas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_Polizas]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_Polizas'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="numeroPol">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConPolizasCallAsQuery( opcion As System.Int32, numeroPol As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_Polizas]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@Numero_Pol", SqlDbType.Char, 8, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, numeroPol))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_RegistroSacrificiosDecomisos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="loteSacrificio">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConRegistroSacrificiosDecomisos(opcion As System.Int32, loteSacrificio As System.String) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@LoteSacrificio", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteSacrificio)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConRegistroSacrificiosDecomisos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_RegistroSacrificiosDecomisos]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_RegistroSacrificiosDecomisos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="loteSacrificio">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConRegistroSacrificiosDecomisos(opcion As System.Int32, loteSacrificio As System.String, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@LoteSacrificio", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteSacrificio)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConRegistroSacrificiosDecomisos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_RegistroSacrificiosDecomisos]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_RegistroSacrificiosDecomisos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="loteSacrificio">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConRegistroSacrificiosDecomisos(opcion As System.Int32, loteSacrificio As System.String, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@LoteSacrificio", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteSacrificio)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspConRegistroSacrificiosDecomisos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_RegistroSacrificiosDecomisos]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_RegistroSacrificiosDecomisos'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="loteSacrificio">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConRegistroSacrificiosDecomisos(opcion As System.Int32, loteSacrificio As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@LoteSacrificio", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteSacrificio)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspConRegistroSacrificiosDecomisos")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_RegistroSacrificiosDecomisos]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_RegistroSacrificiosDecomisos'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="loteSacrificio">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConRegistroSacrificiosDecomisosCallAsQuery( opcion As System.Int32, loteSacrificio As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_RegistroSacrificiosDecomisos]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@LoteSacrificio", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteSacrificio))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspCon_RegistroSacrificiosDet'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="loteSacrificio">Input parameter of stored procedure</param>
		''' <param name="folioCanal">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConRegistroSacrificiosDet(opcion As System.Int32, loteSacrificio As System.String, folioCanal As System.String) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@LoteSacrificio", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteSacrificio)
			parameters(2) = new SqlParameter("@FolioCanal", SqlDbType.Char, 15, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioCanal)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConRegistroSacrificiosDet")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_RegistroSacrificiosDet]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_RegistroSacrificiosDet'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="loteSacrificio">Input parameter of stored procedure</param>
		''' <param name="folioCanal">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConRegistroSacrificiosDet(opcion As System.Int32, loteSacrificio As System.String, folioCanal As System.String, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@LoteSacrificio", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteSacrificio)
			parameters(2) = new SqlParameter("@FolioCanal", SqlDbType.Char, 15, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioCanal)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConRegistroSacrificiosDet")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_RegistroSacrificiosDet]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspCon_RegistroSacrificiosDet'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="loteSacrificio">Input parameter of stored procedure</param>
		''' <param name="folioCanal">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConRegistroSacrificiosDet(opcion As System.Int32, loteSacrificio As System.String, folioCanal As System.String, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@LoteSacrificio", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteSacrificio)
			parameters(2) = new SqlParameter("@FolioCanal", SqlDbType.Char, 15, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioCanal)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspConRegistroSacrificiosDet")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_RegistroSacrificiosDet]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspCon_RegistroSacrificiosDet'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="loteSacrificio">Input parameter of stored procedure</param>
		''' <param name="folioCanal">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspConRegistroSacrificiosDet(opcion As System.Int32, loteSacrificio As System.String, folioCanal As System.String, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@LoteSacrificio", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteSacrificio)
			parameters(2) = new SqlParameter("@FolioCanal", SqlDbType.Char, 15, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioCanal)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspConRegistroSacrificiosDet")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspCon_RegistroSacrificiosDet]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspCon_RegistroSacrificiosDet'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="loteSacrificio">Input parameter of stored procedure</param>
		''' <param name="folioCanal">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspConRegistroSacrificiosDetCallAsQuery( opcion As System.Int32, loteSacrificio As System.String, folioCanal As System.String) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspCon_RegistroSacrificiosDet]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@LoteSacrificio", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteSacrificio))
			toReturn.Parameters.Add(New SqlParameter("@FolioCanal", SqlDbType.Char, 15, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioCanal))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspImp_Embarques'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioEmbarque">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspImpEmbarques(opcion As System.Int32, idFolioEmbarque As System.String, idCliente As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdFolioEmbarque", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioEmbarque)
			parameters(2) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspImpEmbarques")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspImp_Embarques]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspImp_Embarques'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioEmbarque">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspImpEmbarques(opcion As System.Int32, idFolioEmbarque As System.String, idCliente As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdFolioEmbarque", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioEmbarque)
			parameters(2) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspImpEmbarques")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspImp_Embarques]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspImp_Embarques'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioEmbarque">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspImpEmbarques(opcion As System.Int32, idFolioEmbarque As System.String, idCliente As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(3 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdFolioEmbarque", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioEmbarque)
			parameters(2) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspImpEmbarques")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspImp_Embarques]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspImp_Embarques'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioEmbarque">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspImpEmbarques(opcion As System.Int32, idFolioEmbarque As System.String, idCliente As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(3) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdFolioEmbarque", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioEmbarque)
			parameters(2) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)

			' Return value parameter
			parameters(3) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspImpEmbarques")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspImp_Embarques]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(3).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspImp_Embarques'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioEmbarque">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspImpEmbarquesCallAsQuery( opcion As System.Int32, idFolioEmbarque As System.String, idCliente As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspImp_Embarques]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@IdFolioEmbarque", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioEmbarque))
			toReturn.Parameters.Add(New SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspRpt_Cortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idProductor">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspRptCortes(opcion As System.Int32, idProductor As System.Int32) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdProductor", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProductor)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspRptCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspRpt_Cortes]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspRpt_Cortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idProductor">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspRptCortes(opcion As System.Int32, idProductor As System.Int32, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdProductor", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProductor)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspRptCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspRpt_Cortes]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspRpt_Cortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idProductor">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspRptCortes(opcion As System.Int32, idProductor As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdProductor", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProductor)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspRptCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspRpt_Cortes]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspRpt_Cortes'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idProductor">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspRptCortes(opcion As System.Int32, idProductor As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdProductor", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProductor)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspRptCortes")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspRpt_Cortes]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspRpt_Cortes'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idProductor">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspRptCortesCallAsQuery( opcion As System.Int32, idProductor As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspRpt_Cortes]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@IdProductor", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProductor))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspRpt_Embarques'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioEmbarque">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="precioActual">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspRptEmbarques(opcion As System.Int32, idFolioEmbarque As System.String, idCliente As System.Int32, precioActual As System.Boolean) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdFolioEmbarque", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioEmbarque)
			parameters(2) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(3) = new SqlParameter("@PrecioActual", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, precioActual)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspRptEmbarques")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspRpt_Embarques]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspRpt_Embarques'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioEmbarque">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="precioActual">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspRptEmbarques(opcion As System.Int32, idFolioEmbarque As System.String, idCliente As System.Int32, precioActual As System.Boolean, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdFolioEmbarque", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioEmbarque)
			parameters(2) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(3) = new SqlParameter("@PrecioActual", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, precioActual)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspRptEmbarques")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspRpt_Embarques]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspRpt_Embarques'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioEmbarque">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="precioActual">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspRptEmbarques(opcion As System.Int32, idFolioEmbarque As System.String, idCliente As System.Int32, precioActual As System.Boolean, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdFolioEmbarque", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioEmbarque)
			parameters(2) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(3) = new SqlParameter("@PrecioActual", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, precioActual)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspRptEmbarques")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspRpt_Embarques]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspRpt_Embarques'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioEmbarque">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="precioActual">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspRptEmbarques(opcion As System.Int32, idFolioEmbarque As System.String, idCliente As System.Int32, precioActual As System.Boolean, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdFolioEmbarque", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioEmbarque)
			parameters(2) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)
			parameters(3) = new SqlParameter("@PrecioActual", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, precioActual)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspRptEmbarques")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspRpt_Embarques]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspRpt_Embarques'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idFolioEmbarque">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="precioActual">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspRptEmbarquesCallAsQuery( opcion As System.Int32, idFolioEmbarque As System.String, idCliente As System.Int32, precioActual As System.Boolean) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspRpt_Embarques]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@IdFolioEmbarque", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, idFolioEmbarque))
			toReturn.Parameters.Add(New SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente))
			toReturn.Parameters.Add(New SqlParameter("@PrecioActual", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, precioActual))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspRpt_Facturas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="noFactura">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspRptFacturas(noFactura As System.String, idCliente As System.Int32) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@NoFactura", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, noFactura)
			parameters(1) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspRptFacturas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspRpt_Facturas]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspRpt_Facturas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="noFactura">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspRptFacturas(noFactura As System.String, idCliente As System.Int32, ByRef returnValue As System.Int32) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@NoFactura", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, noFactura)
			parameters(1) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspRptFacturas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspRpt_Facturas]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspRpt_Facturas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="noFactura">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspRptFacturas(noFactura As System.String, idCliente As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(2 - 1) {}
			parameters(0) = new SqlParameter("@NoFactura", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, noFactura)
			parameters(1) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)

			' Call the stored proc.
			Dim toReturn As New DataTable("UspRptFacturas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspRpt_Facturas]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspRpt_Facturas'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="noFactura">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataTable with resultset of stored procedure</returns>
		Public Overloads Shared Function UspRptFacturas(noFactura As System.String, idCliente As System.Int32, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataTable
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(2) {}
			parameters(0) = new SqlParameter("@NoFactura", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, noFactura)
			parameters(1) = new SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente)

			' Return value parameter
			parameters(2) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataTable("UspRptFacturas")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspRpt_Facturas]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(2).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspRpt_Facturas'.
		''' 
		''' </summary>
		''' <param name="noFactura">Input parameter of stored procedure</param>
		''' <param name="idCliente">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspRptFacturasCallAsQuery( noFactura As System.String, idCliente As System.Int32) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspRpt_Facturas]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@NoFactura", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, noFactura))
			toReturn.Parameters.Add(New SqlParameter("@IdCliente", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idCliente))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspRpt_RecepcionCanales'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="folioSacrificio">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspRptRecepcionCanales(opcion As System.Int32, folioSacrificio As System.String, fechaInicial As System.DateTime, fechaFinal As System.DateTime) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@FolioSacrificio", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioSacrificio)
			parameters(2) = new SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial)
			parameters(3) = new SqlParameter("@FechaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspRptRecepcionCanales")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspRpt_RecepcionCanales]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspRpt_RecepcionCanales'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="folioSacrificio">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspRptRecepcionCanales(opcion As System.Int32, folioSacrificio As System.String, fechaInicial As System.DateTime, fechaFinal As System.DateTime, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@FolioSacrificio", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioSacrificio)
			parameters(2) = new SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial)
			parameters(3) = new SqlParameter("@FechaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspRptRecepcionCanales")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspRpt_RecepcionCanales]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspRpt_RecepcionCanales'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="folioSacrificio">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspRptRecepcionCanales(opcion As System.Int32, folioSacrificio As System.String, fechaInicial As System.DateTime, fechaFinal As System.DateTime, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(4 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@FolioSacrificio", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioSacrificio)
			parameters(2) = new SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial)
			parameters(3) = new SqlParameter("@FechaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspRptRecepcionCanales")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspRpt_RecepcionCanales]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspRpt_RecepcionCanales'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="folioSacrificio">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspRptRecepcionCanales(opcion As System.Int32, folioSacrificio As System.String, fechaInicial As System.DateTime, fechaFinal As System.DateTime, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(4) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@FolioSacrificio", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioSacrificio)
			parameters(2) = new SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial)
			parameters(3) = new SqlParameter("@FechaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal)

			' Return value parameter
			parameters(4) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspRptRecepcionCanales")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspRpt_RecepcionCanales]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(4).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspRpt_RecepcionCanales'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="folioSacrificio">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspRptRecepcionCanalesCallAsQuery( opcion As System.Int32, folioSacrificio As System.String, fechaInicial As System.DateTime, fechaFinal As System.DateTime) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspRpt_RecepcionCanales]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@FolioSacrificio", SqlDbType.VarChar, 11, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, folioSacrificio))
			toReturn.Parameters.Add(New SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial))
			toReturn.Parameters.Add(New SqlParameter("@FechaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	

		''' <summary>
		''' Calls stored procedure 'UspRpt_RecepcionGanado'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idProductor">Input parameter of stored procedure</param>
		''' <param name="loteRecepcion">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspRptRecepcionGanado(opcion As System.Int32, idProductor As System.Int32, loteRecepcion As System.String, fechaInicial As System.DateTime, fechaFinal As System.DateTime) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(5 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdProductor", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProductor)
			parameters(2) = new SqlParameter("@LoteRecepcion", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteRecepcion)
			parameters(3) = new SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial)
			parameters(4) = new SqlParameter("@FechaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspRptRecepcionGanado")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspRpt_RecepcionGanado]", parameters, toReturn, Nothing)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspRpt_RecepcionGanado'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idProductor">Input parameter of stored procedure</param>
		''' <param name="loteRecepcion">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspRptRecepcionGanado(opcion As System.Int32, idProductor As System.Int32, loteRecepcion As System.String, fechaInicial As System.DateTime, fechaFinal As System.DateTime, ByRef returnValue As System.Int32) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(5) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdProductor", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProductor)
			parameters(2) = new SqlParameter("@LoteRecepcion", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteRecepcion)
			parameters(3) = new SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial)
			parameters(4) = new SqlParameter("@FechaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal)

			' Return value parameter
			parameters(5) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspRptRecepcionGanado")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspRpt_RecepcionGanado]", parameters, toReturn, Nothing)


			returnValue = CType(parameters(5).Value, Integer)
			Return toReturn
		End Function


		''' <summary>
		''' Calls stored procedure 'UspRpt_RecepcionGanado'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idProductor">Input parameter of stored procedure</param>
		''' <param name="loteRecepcion">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspRptRecepcionGanado(opcion As System.Int32, idProductor As System.Int32, loteRecepcion As System.String, fechaInicial As System.DateTime, fechaFinal As System.DateTime, transactionToUse As ITransaction) As DataSet
			' create parameters
			Dim parameters() As SqlParameter = New SqlParameter(5 - 1) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdProductor", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProductor)
			parameters(2) = new SqlParameter("@LoteRecepcion", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteRecepcion)
			parameters(3) = new SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial)
			parameters(4) = new SqlParameter("@FechaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal)

			' Call the stored proc.
			Dim toReturn As New DataSet("UspRptRecepcionGanado")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspRpt_RecepcionGanado]", parameters, toReturn, transactionToUse)


			Return toReturn
		End Function

	
		''' <summary>
		''' Calls stored procedure 'UspRpt_RecepcionGanado'.<br/><br/>
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idProductor">Input parameter of stored procedure</param>
		''' <param name="loteRecepcion">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <param name="returnValue">Return value of the stored procedure</param>
		''' <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		''' <returns>Filled DataSet with resultset of stored procedure</returns>
		Public Overloads Shared Function UspRptRecepcionGanado(opcion As System.Int32, idProductor As System.Int32, loteRecepcion As System.String, fechaInicial As System.DateTime, fechaFinal As System.DateTime, ByRef returnValue As System.Int32, transactionToUse As ITransaction) As DataSet
			' create parameters. Add 1 to make room for the return value parameter.
			Dim parameters() As SqlParameter = New SqlParameter(5) {}
			parameters(0) = new SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion)
			parameters(1) = new SqlParameter("@IdProductor", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProductor)
			parameters(2) = new SqlParameter("@LoteRecepcion", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteRecepcion)
			parameters(3) = new SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial)
			parameters(4) = new SqlParameter("@FechaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal)

			' Return value parameter
			parameters(5) = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, True, 10, 0, "",  DataRowVersion.Current, returnValue)			
			
			' Call the stored proc.
			Dim toReturn As New DataSet("UspRptRecepcionGanado")
			Dim hasSucceeded As Boolean = DbUtils.CallRetrievalStoredProcedure("[dbo].[UspRpt_RecepcionGanado]", parameters, toReturn, transactionToUse)


			returnValue = CType(parameters(5).Value, Integer)
			Return toReturn
		End Function

		''' <summary>Creates an IRetrievalQuery Object For a Call To the procedure 'UspRpt_RecepcionGanado'.
		''' 
		''' </summary>
		''' <param name="opcion">Input parameter of stored procedure</param>
		''' <param name="idProductor">Input parameter of stored procedure</param>
		''' <param name="loteRecepcion">Input parameter of stored procedure</param>
		''' <param name="fechaInicial">Input parameter of stored procedure</param>
		''' <param name="fechaFinal">Input parameter of stored procedure</param>
		''' <returns>IRetrievalQuery Object which Is ready To use For datafetching</returns>
		Public Shared Function GetUspRptRecepcionGanadoCallAsQuery( opcion As System.Int32, idProductor As System.Int32, loteRecepcion As System.String, fechaInicial As System.DateTime, fechaFinal As System.DateTime) As IRetrievalQuery 
			Dim procName As String = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[dbo].[UspRpt_RecepcionGanado]" )
			Dim toReturn As New RetrievalQuery( New SqlCommand(procName) )
			toReturn.Parameters.Add(New SqlParameter("@Opcion", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, opcion))
			toReturn.Parameters.Add(New SqlParameter("@IdProductor", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "",  DataRowVersion.Current, idProductor))
			toReturn.Parameters.Add(New SqlParameter("@LoteRecepcion", SqlDbType.Char, 10, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, loteRecepcion))
			toReturn.Parameters.Add(New SqlParameter("@FechaInicial", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaInicial))
			toReturn.Parameters.Add(New SqlParameter("@FechaFinal", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "",  DataRowVersion.Current, fechaFinal))

			toReturn.Command.CommandType = CommandType.StoredProcedure
			Return toReturn
		End Function
	


#Region "Included Code"

#End Region
	End Class
End Namespace
