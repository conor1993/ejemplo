Imports TC = IntegraLab.ORM.TypedViewClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CN = ClasesNegocio
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmReporteProductos
    Dim Introductores As New CN.ClientesIntroductoresColeccion

    Private Sub FrmReporteProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Introductores.Obtener(True)
            Me.cmbIntroductor.ValueMember = "Codigo"
            Me.cmbIntroductor.DisplayMember = "Nombre"
            Me.cmbIntroductor.DataSource = Introductores
            Me.cmbIntroductor.SelectedIndex = -1
            Me.txtCodigoIntroductor.Text = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir
        Try
            Dim Vista As New TC.VwReporteExistenciaSubProductosTypedView
            Dim Filtro As New OC.PredicateExpression

            Filtro.Add(HC.VwReporteExistenciaSubProductosFields.Decomiso = False)
            If Not Me.txtFolioSacrificio.Text = "" Then
                Filtro.Add(HC.VwReporteExistenciaSubProductosFields.FolioSacrificio = Me.txtFolioSacrificio.Text)
            End If

            If Me.cmbIntroductor.SelectedIndex > -1 Then
                Filtro.Add(HC.VwReporteExistenciaSubProductosFields.IdCodCliente = Me.cmbIntroductor.SelectedValue)
            End If

            If Me.txtFolioSacrificio.Text = "" Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.VwReporteExistenciaSubProductosFields.FechaSacrificio, Me.dtFechaInicial.Value.ToShortDateString, _
               Me.DtFechaFinal.Value.AddDays(1).ToShortDateString))
            End If

            Vista.Fill(0, Nothing, False, Filtro)
            If Vista.Count > 0 Then
                Dim Reporte As New RptProductos
                Reporte.SetDataSource(CType(Vista, Object))
                Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
                Reporte.SetParameterValue(2, "Producción/Productos")

                Dim Ver As New CN.PreVisualizarForm
                Ver.Reporte = Reporte
                Ver.Show()
            Else
                MsgBox("No se encontraron productos con la información especificada", MsgBoxStyle.Exclamation, "Aviso")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Me.txtCodigoIntroductor.Text = ""
        Me.DtFechaFinal.Value = Now
        Me.dtFechaInicial.Value = Now
        Me.cmbIntroductor.SelectedIndex = -1
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub

    Private Sub cmbIntroductor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbIntroductor.SelectedIndexChanged
        If Me.cmbIntroductor.SelectedIndex > -1 Then
            Me.txtCodigoIntroductor.Text = Me.cmbIntroductor.SelectedValue
        End If
    End Sub

    Private Sub txtFolioSacrificio_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtFolioSacrificio.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F3 Then
                Dim Ventana As New ReporteRegistroSacrificios

                Ventana.Text = "SELECCIONE UN LOTE DE SACRIFICIO PARA EL REPORTE"
                Ventana.Label17.Text = "SELECCIONE UN LOTE DE SACRIFICIO PARA EL REPORTE"
                Ventana.Icon = Me.Icon

                If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.txtFolioSacrificio.Text = Ventana.Sacrificio.IdLoteSacrificio
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmbIntroductor_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbIntroductor.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Introductores.Obtener(True)
                Me.cmbIntroductor.ValueMember = "Codigo"
                Me.cmbIntroductor.DisplayMember = "Nombre"
                Me.cmbIntroductor.DataSource = Introductores
                Me.cmbIntroductor.SelectedIndex = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class