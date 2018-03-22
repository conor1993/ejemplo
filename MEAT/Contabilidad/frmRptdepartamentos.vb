Imports HC = Integralab.ORM.HelperClasses
Imports System.Data.SqlClient

Public Class frmRptdepartamentos
    Private departamento As ClasesNegocio.DepartamentosClass
    Private DepartamentosC As New ClasesNegocio.DepartamentosCollectionClas

#Region "Eventos"
    Private Sub frmRptdepartamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
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
        Dim datos As New DataTable
        Dim departamentoId As Integer = 0

        If Not cmbDepartamentos.SelectedValue = -1 And Not cmbDepartamentos.SelectedValue Is Nothing Then
            departamentoId = cmbDepartamentos.SelectedValue
        End If

        Dim query = "EXEC  rptdepartamentos " + departamentoId.ToString
        
        Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            Dim adapter As New SqlDataAdapter()
            adapter.SelectCommand = New SqlCommand(query, connection)
            adapter.Fill(datos)
        End Using

        Dim Reporte As New ClasesNegocio.rptDepartamentos2

        Dim pre As New ClasesNegocio.PreVisualizarForm
        'Reporte.SetDataSource(datos.Tables(0))
        Reporte.SetDataSource(datos)

        pre.Reporte = Reporte
        pre.ShowDialog()
    End Sub

#End Region
End Class