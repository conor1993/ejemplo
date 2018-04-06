Imports HC = Integralab.ORM.HelperClasses
Imports CN = ClasesNegocio
Imports System.Data.SqlClient

Public Class frmRptDepartamentosDos

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim datos As New DataSet
            Dim query = String.Format("EXEC rptDepartamentosNew 1, {0}, 0, {1}, 1, 1", cmbDepartamento.SelectedValue, cmbAnio.SelectedValue)
            Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
                Dim adapter As New SqlDataAdapter()
                adapter.SelectCommand = New SqlCommand(query, connection)
                adapter.Fill(datos)
            End Using

            Dim Reporte As New CN.rptDepartamentoComparativoMes
            Reporte.SetDataSource(datos.Tables(0))
            Reporte.SetParameterValue("Empresa", Controlador.Empresa.Nombre)

            Dim pre As New ClasesNegocio.PreVisualizarForm
            pre.Reporte = Reporte
            pre.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub limpiar()
        Dim query As String = ""
        Dim tb As New DataTable
        Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)

        ''Llenar ComboBox Años
        query = "SELECT Ejercicio" &
                " FROM UsrGralPeriodosCont" &
                " WHERE Estatus = 1"
        Dim tbAnio As New DataTable
        tbAnio.Columns.Add("Ejercicio")
        Using sqlcom As New SqlCommand(query, sqlCon)
            Dim adp As New SqlDataAdapter(sqlcom)
            sqlCon.Open()
            adp.Fill(tbAnio)
            cmbAnio.DataSource = tbAnio

            sqlCon.Close()
        End Using

        query = "SELECT Cve_Depto, Nom_Depto" &
                " FROM CatDeptos"

        
        tb.Columns.Add("Cve_Depto")
        tb.Columns.Add("Nom_Depto")
        Dim dr As DataRow = tb.NewRow

        dr("Cve_Depto") = -1
        dr("Nom_Depto") = "TODOS"
        tb.Rows.Add(dr)

        Using sqlcom As New SqlCommand(query, sqlCon)
            Dim adp As New SqlDataAdapter(sqlcom)
            sqlCon.Open()
            adp.Fill(tb)
            cmbDepartamento.DataSource = tb

            sqlCon.Close()
        End Using

        ''Llenar ComboBox Meses
        tb.Columns.Add("Codigo")
        tb.Columns.Add("Mes")
        Dim datarow As DataRow = tb.NewRow
        datarow("Codigo") = -1
        datarow("Mes") = "TODOS"
        tb.Rows.Add(datarow)

        Dim codigo As Integer = 0
        For Each mes As String In System.Enum.GetNames(GetType(CN.MesEnum))
            datarow("Codigo") = codigo
            datarow("Mes") = mes
            tb.Rows.Add(datarow)
            codigo = codigo + 1
            Console.WriteLine(codigo)
        Next
        Console.WriteLine("f")
    End Sub

    Private Sub frmRptDepartamentosDos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        
    End Sub

    Private Sub frmRptDepartamentosDos_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        Me.limpiar()
    End Sub
End Class