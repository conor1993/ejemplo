Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Public Class FrmInvFisicoVsLibro
    Dim Band As Boolean = False
    Private Sub FrmInvFisicoVsLibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim Almacen As New CN.AlmacenClass
            Almacen.Descripcion = "TODOS"
            Dim AlmacenesCol As New CN.AlmacenCollectionClass
            AlmacenesCol.Add(Almacen)

            Dim AuxCol As New CN.AlmacenCollectionClass
            AuxCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            For Each Alm As CN.AlmacenClass In AuxCol
                AlmacenesCol.Add(Alm)
            Next


            CmbAlmacenes.SelectedIndex = -1
            CmbAlmacenes.ValueMember = "Codigo"
            CmbAlmacenes.DisplayMember = "Descripcion"
            CmbAlmacenes.DataSource = AlmacenesCol
            Band = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbAlmacenes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAlmacenes.SelectedIndexChanged
        If Band = False Then
            Exit Sub
        End If
        Try
            Dim Filtro As New OC.PredicateExpression
            If Me.CmbAlmacenes.SelectedIndex > 0 Then
                Filtro.Add(HC.VwReporteComprativoInventarioFields.AlmacenId = Me.CmbAlmacenes.SelectedValue)
            End If

            Dim Vista As New TC.VwReporteComprativoInventarioTypedView
            Vista.Fill(0, Nothing, True, Filtro)

            Me.DataGridView1.AutoGenerateColumns = False
            Me.DataGridView1.DataSource = Vista
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim Report As New CN.RptInventFisico
            Report.SetDataSource(Me.DataGridView1.DataSource)
            Report.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            Report.SetParameterValue(1, "Inventarios / Comparación de Inventario")
            Report.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)

            Dim VerReporte As New FrmReportes
            VerReporte.CRV.ReportSource = Report
            VerReporte.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.CmbAlmacenes.SelectedIndex = 0
        Me.DataGridView1.DataSource = Nothing
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
End Class