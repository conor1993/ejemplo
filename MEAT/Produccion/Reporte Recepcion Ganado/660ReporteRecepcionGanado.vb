Imports CN = ClasesNegocio
Public Class _660ReporteRecepcionGanado

    Dim Introductores As New CN.ClientesIntroductoresColeccion
    Dim Recepciones As New CN.RecepcionGanadoColeccion
    Private Sub _660ReporteRecepcionGanado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = MdiParent.Icon
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = ""
        MtbEstados.StateCancelar = "100100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "110100011"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010000"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        mtb.ToolBarButtonStatus = MtbEstados
        mtb.sbCambiarEstadoBotones("Cancelar")
        Introductores.Obtener(True)
        Me.CmbIntroductor.DisplayMember = "Nombre"
        Me.CmbIntroductor.ValueMember = "Codigo"
        Me.CmbIntroductor.DataSource = Introductores
        Me.CmbIntroductor.SelectedIndex = -1
        Me.DgvRecepcionGanado.AutoGenerateColumns = False
    End Sub

    Private Sub Limpiar()
        Me.txtFolioRec.Clear()
        Me.txtLoteEngorda.Clear()
        Me.CmbIntroductor.SelectedIndex = -1
        Me.DtpFechaInicio.Value = Now
        Me.DtpFechaFinal.Value = Now
        Me.RdbTodas.Checked = True
        Me.RdbVigentes.Checked = False
        Me.RdbCanceladas.Checked = False
        Me.DgvRecepcionGanado.DataSource = Nothing
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        If Me.CmbIntroductor.SelectedIndex > -1 Or Me.txtFolioRec.Text <> "" Or Me.txtLoteEngorda.Text <> "" Then
            If Me.RdbCanceladas.Checked = True Then
                Recepciones.Obtener(Me.txtFolioRec.Text, Me.txtLoteEngorda.Text, "X", Me.CmbIntroductor.SelectedValue)
            ElseIf Me.RdbVigentes.Checked = True Then
                Recepciones.Obtener(Me.txtFolioRec.Text, Me.txtLoteEngorda.Text, "V", Me.CmbIntroductor.SelectedValue)
            Else
                Recepciones.Obtener(Me.txtFolioRec.Text, Me.txtLoteEngorda.Text, "", Me.CmbIntroductor.SelectedValue)
            End If
        Else
            If Me.RdbCanceladas.Checked = True Then
                Recepciones.Obtener(Me.DtpFechaInicio.Value, Me.DtpFechaFinal.Value, "X")
            ElseIf Me.RdbVigentes.Checked = True Then
                Recepciones.Obtener(Me.DtpFechaInicio.Value, Me.DtpFechaFinal.Value, "V")
            Else
                Recepciones.Obtener(Me.DtpFechaInicio.Value, Me.DtpFechaFinal.Value, "")
            End If
        End If
        Me.DgvRecepcionGanado.DataSource = Recepciones
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar

    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Dim Previsualizador As New CN.PreVisualizarForm
        Previsualizador.Reporte = Recepciones.Reporte(Controlador.Sesion.MiUsuario.Usrnom, Controlador.Sesion.MiEmpresa.Empnom, "Producción/Recepción de Ganado")
        Previsualizador.ShowDialog()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
End Class