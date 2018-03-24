Imports HC = Integralab.ORM.HelperClasses
Imports System.Data.SqlClient

Public Class frmRptdepartamentos
    Private departamento As ClasesNegocio.DepartamentosClass
    Private DepartamentosC As New ClasesNegocio.DepartamentosCollectionClas

#Region "Eventos"
    Private Sub frmRptdepartamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'datos.Columns.Add("Cve_Depto")
            'datos.Columns.Add("Nom_Depto")
            'datos.Rows.Add(-1, "TODOS")

            cmbDepartamentos.DataSource = Nothing
            cmbDepartamentos.ValueMember = "Codigo"
            cmbDepartamentos.DisplayMember = "Nom_Depto"

            Me.DepartamentosC.Obtener()
            'Dim dep = New ClasesNegocio.DepartamentosCollectionClas()
            'DepartamentosC.Add(dep)
            Me.cmbDepartamentos.DataSource = DepartamentosC
        Catch ex As Exception

        End Try

        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim datos As New DataSet

        'La fecha inicial es mayor a la final
        Console.WriteLine(DtPIni.Value.ToString("yyyyMMdd") + "  :  " + DtPIni.Value.Date.ToString)
        If DtPIni.Value.Date.CompareTo(DtPFin.Value.Date) > 0 Then
            MessageBox.Show("La fecha inicial tiene que ser antes de la fecha final", "Error", _
                       MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf DtPIni.Value.Date.CompareTo(Date.Today) > 0 Then
            MessageBox.Show("La fecha inicial tiene que ser hoy o antes", "Error", _
                       MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim datos As New DataTable
            Dim departamentoId As Integer = 0

            If Not cmbDepartamentos.SelectedValue = -1 And Not cmbDepartamentos.SelectedValue Is Nothing Then
                departamentoId = cmbDepartamentos.SelectedValue
            End If

            Dim query = String.Format("EXEC  [rptdepartamentos] {0}, '{1}', '{2}'", departamentoId.ToString, _
                                      DtPIni.Value.ToString("yyyyMMdd"), DtPFin.Value.ToString("yyyyMMdd"))

            Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
                Dim adapter As New SqlDataAdapter()
                adapter.SelectCommand = New SqlCommand(query, connection)
                adapter.Fill(datos)
            End Using

            Dim Reporte As New ClasesNegocio.rptDepartamentos2

            Dim pre As New ClasesNegocio.PreVisualizarForm
            'Reporte.SetDataSource(datos.Tables(0))
            Reporte.SetDataSource(datos)
            Reporte.SetParameterValue(Reporte.Parameter_Empresa.ParameterFieldName, Controlador.Empresa.Nombre)
            Reporte.SetParameterValue(Reporte.Parameter_Departamento.ParameterFieldName, cmbDepartamentos.GetItemText(cmbDepartamentos.SelectedItem))
            Reporte.SetParameterValue(Reporte.Parameter_FechaInicial.ParameterFieldName, DtPIni.Value.Date)
            Reporte.SetParameterValue(Reporte.Parameter_FechaFinal.ParameterFieldName, DtPFin.Value.Date)

            pre.Reporte = Reporte
            pre.ShowDialog()
        End If
    End Sub

#End Region
End Class