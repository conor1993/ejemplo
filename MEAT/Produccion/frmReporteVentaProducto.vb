Imports System.Data.SqlClient

Public Class frmReporteVentaProducto

    Private Sub LlenarProductos()
        Dim sqlCon As New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)

        Try
            Dim sqlCom As New SqlCommand("", sqlCon)
            Dim ad As New SqlDataAdapter(sqlCom)
            Dim tb As New DataTable

            sqlCon.Open()
            ad.Fill(tb)
            cmbProducto.DataSource = tb

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmReporteVentaProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class