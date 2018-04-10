Imports HC = Integralab.ORM.HelperClasses
Imports CN = ClasesNegocio
Imports System.Data.SqlClient

Public Class frmRptDepartamentosDos

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim datos As New DataSet
            Dim pre As New ClasesNegocio.PreVisualizarForm
            Dim query = String.Format("EXEC rptDepartamentosNew 1, {0}, {1}, {2}, {3}, {4}", If(String.IsNullOrEmpty(cmbDepartamento.SelectedValue), -1, cmbDepartamento.SelectedValue), cmbMeses.SelectedValue, cmbAnio.SelectedValue, Convert.ToByte(chbComparativo.Checked), Convert.ToByte(rdbSimplificado.Checked))

            Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
                Dim adapter As New SqlDataAdapter()
                adapter.SelectCommand = New SqlCommand(query, connection)
                adapter.Fill(datos)
            End Using

            If chbComparativo.Checked Then
                If rdbSimplificado.Checked Then
                    Dim Reporte As New CN.rptDepartamentoComparativoSimple
                    Reporte.SetDataSource(datos.Tables(0))
                    Reporte.SetParameterValue("Empresa", Controlador.Empresa.Nombre)
                    Reporte.SetParameterValue("Departamento", cmbDepartamento.Text)
                    Reporte.SetParameterValue("Año", cmbAnio.Text)
                    Reporte.SetParameterValue("Mes", cmbMeses.Text)


                    pre.Reporte = Reporte
                    pre.ShowDialog()
                Else
                    Dim Reporte As New CN.rptDepartamentoComparativoDetalles
                    Reporte.SetDataSource(datos.Tables(0))
                    Reporte.SetParameterValue("Empresa", Controlador.Empresa.Nombre)
                    Reporte.SetParameterValue("Departamento", cmbDepartamento.Text)
                    Reporte.SetParameterValue("Año", cmbAnio.Text)
                    Reporte.SetParameterValue("Mes", cmbMeses.Text)


                    pre.Reporte = Reporte
                    pre.ShowDialog()
                End If
            Else
                If (If(String.IsNullOrEmpty(cmbDepartamento.SelectedValue), -1, cmbDepartamento.SelectedValue = -1)) Then
                    MsgBox("Debe seleccionar un Departamento cuando el reporte no es Comparativo", MsgBoxStyle.Information, " Seleccione un Departamento")
                    Return
                End If
                If rdbSimplificado.Checked Then
                    Dim Reporte As New CN.rptDepartamentoNoComparativoSimple
                    Reporte.SetDataSource(datos.Tables(0))
                    Reporte.SetParameterValue("Empresa", Controlador.Empresa.Nombre)
                    Reporte.SetParameterValue("Departamento", cmbDepartamento.Text)
                    Reporte.SetParameterValue("Año", cmbAnio.Text)
                    Reporte.SetParameterValue("Mes", cmbMeses.Text)


                    pre.Reporte = Reporte
                    pre.ShowDialog()
                Else
                    Console.WriteLine(query)
                    Dim Reporte As New CN.rptDepartamentoNoComparativoDetalles
                    Reporte.SetDataSource(datos.Tables(0))
                    Reporte.SetParameterValue("Empresa", Controlador.Empresa.Nombre)
                    Reporte.SetParameterValue("Departamento", cmbDepartamento.Text)
                    Reporte.SetParameterValue("Año", cmbAnio.Text)
                    Reporte.SetParameterValue("Mes", cmbMeses.Text)


                    pre.Reporte = Reporte
                    pre.ShowDialog()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmRptDepartamentosDos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.llenarDatos()

        'Me.cmbDepartamento.Enabled = False
    End Sub

    Sub llenarDatos()
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
        'tb.Rows.Add(dr)

        Using sqlcom As New SqlCommand(query, sqlCon)
            Dim adp As New SqlDataAdapter(sqlcom)
            sqlCon.Open()
            adp.Fill(tb)
            cmbDepartamento.DataSource = tb

            sqlCon.Close()
        End Using

        ''Llenar ComboBox Meses
        Dim dt As New DataTable
        dt.Columns.Add("Codigo")
        dt.Columns.Add("Mes")
        Dim datarow As DataRow = dt.NewRow
        datarow("Codigo") = 0
        datarow("Mes") = "TODOS"
        dt.Rows.Add(datarow)
        Dim codigo As Integer = 1
        For Each mes As String In [Enum].GetNames(GetType(CN.MesEnum))
            datarow = dt.NewRow
            datarow("Codigo") = codigo
            datarow("Mes") = mes
            dt.Rows.Add(datarow)
            codigo = codigo + 1
        Next

        cmbMeses.DataSource = dt
    End Sub

    Sub llenarDepartamentos(ByVal tof As Boolean)
        Dim query As String = ""
        Dim tb As New DataTable
        Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
        query = "SELECT Cve_Depto, Nom_Depto" &
               " FROM CatDeptos"


        tb.Columns.Add("Cve_Depto")
        tb.Columns.Add("Nom_Depto")
        Dim dr As DataRow = tb.NewRow

        dr("Cve_Depto") = -1
        dr("Nom_Depto") = "TODOS"
        If (tof) Then
            tb.Rows.Add(dr)
        End If


        Using sqlcom As New SqlCommand(query, sqlCon)
            Dim adp As New SqlDataAdapter(sqlcom)
            sqlCon.Open()
            adp.Fill(tb)
            cmbDepartamento.DataSource = tb

            sqlCon.Close()
            cmbDepartamento.SelectedValue = -1
        End Using
    End Sub

    Private Sub chbComparativo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbComparativo.CheckedChanged
        cmbMeses.SelectedIndex = 0
        If chbComparativo.Checked Then
            cmbMeses.Enabled = False
            'cmbDepartamento.Enabled = True
            Me.llenarDepartamentos(True)


        Else
            cmbMeses.Enabled = True
            Me.llenarDepartamentos(False)
        End If
        cmbDepartamento.SelectedIndex = 0
    End Sub
End Class