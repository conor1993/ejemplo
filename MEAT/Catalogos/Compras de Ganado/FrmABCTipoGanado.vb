Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses

Public Class FrmABCTipoGanado
    Dim TipoGanado As New TipoGanadoClass

#Region "Load"
    Private Sub FrmABCTipoGanado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim tbTiposGanado As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbTiposGanado.StateBuscar = "101101101"
            tbTiposGanado.StateLimpiar = ""
            tbTiposGanado.StateCancelar = "100100011"
            tbTiposGanado.StateNuevo = "011010001"
            tbTiposGanado.StateGuardar = "100100011"
            tbTiposGanado.StateBorrar = "100100011"
            tbTiposGanado.StateEditar = "001011001"
            tbTiposGanado.StateImprimir = ""
            tbTiposGanado.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbTiposGanado
            Me.mtb.sbCambiarEstadoBotones("Cancelar")
            mtb.Buttons(1).Visible = False

            Me.TipoGanadoC.Obtener()
            Me.Limpiar()
            Me.Deshabilitar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "Metodos"
    Private Function Guardar() As Boolean
        Try

            TipoGanado.Descripcion = Me.txtDescripcion.Text
            TipoGanado.DescCorta = Me.txtDescCorta.Text
            TipoGanado.Observaciones = Me.txtObservaciones.Text
            TipoGanado.Lados = Me.txtlados.Text
            TipoGanado.Estatus = ClasesNegocio.EstatusDatos.VIGENTE

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function Limpiar() As Boolean
        Me.txtCodigo.Text = 0
        Me.txtDescripcion.Text = ""
        Me.txtDescCorta.Text = ""
        Me.txtObservaciones.Text = ""
        Me.txtLados.Text = ""
        Me.txtAcumCab.Text = ""
        Me.txtAcumKilos.Text = ""
        Me.DtpFechaEntrada.Value = Now
        Me.DtpFechaSalida.Value = Now
        Me.lblEstatus.Visible = False
        Me.lblEstatus.Text = "ESTATUS"
    End Function

    Private Function Habilitar() As Boolean
        Me.txtDescripcion.Enabled = True
        Me.txtLados.Enabled = True
        Me.txtDescCorta.Enabled = True
        Me.txtObservaciones.Enabled = True
    End Function

    Private Function Deshabilitar() As Boolean
        Me.txtObservaciones.Enabled = False
        Me.txtDescCorta.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.txtLados.Enabled = False
    End Function

    Private Sub PonerDatos()
        Me.txtCodigo.Text = TipoGanado.IdTipoGanado
        Me.txtDescripcion.Text = TipoGanado.Descripcion
        Me.txtDescCorta.Text = TipoGanado.DescCorta
        Me.txtObservaciones.Text = TipoGanado.Observaciones
        Me.lblEstatus.Text = TipoGanado.Estatus.ToString
        Me.lblEstatus.Visible = True
        Me.txtlados.Text = TipoGanado.Lados
        Me.txtAcumKilos.Text = TipoGanado.AcumuladoKilos
        Me.txtAcumCab.Text = TipoGanado.AcumuladoCabezas
        Me.DtpFechaEntrada.Value = TipoGanado.FechaUltimaEntrada
        Me.DtpFechaSalida.Value = TipoGanado.FechaUltimaSalida
    End Sub

    Private Function Validar() As Boolean
        Try
            If Me.txtDescripcion.Text = "" Then
                MessageBox.Show("Especifique nombre de Tipo de Ganado", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtDescripcion.Focus()
                Return False
            End If

            If Me.txtLados.Text = "" Then
                MsgBox("Ingrese el número de lados", MsgBoxStyle.Exclamation, "Aviso")
                Me.txtLados.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "key press"
    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtDescCorta.Focus()
        End If
    End Sub

    Private Sub txtDescCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescCorta.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtAcumCab.Focus()
        End If
    End Sub
#End Region

#Region "Botobes TollBar"
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If TipoGanado.Estatus = EstatusDatos.CANCELADO Then
                MsgBox("El tipo de ganado ya ha sido cancelado anteriormente", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If

            Me.TipoGanado.Borrar()
            MsgBox("Se ha cancelado el Tipo de Ganado", MsgBoxStyle.Information, "Aviso")
            Me.Limpiar()
            TipoGanadoC.Obtener()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Me.Limpiar()
        Me.Deshabilitar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
     
        If TipoGanado.Estatus = EstatusDatos.CANCELADO Then
            If MessageBox.Show("No se puede ediar el tipo de ganado, se encuentra cancelado ¿Quiere Activiarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.TipoGanado.Estatus = ClasesNegocio.EstatusDatos.VIGENTE
                Habilitar()
            Else
                Cancelar = True
                Exit Sub
            End If
        Else
            Habilitar()
        End If
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Not Me.Validar Then
                Cancelar = True
                Exit Sub
            End If

            Me.Guardar()

            If TipoGanado.Guardar() Then
                MessageBox.Show("Se ha guardado el tipo de ganado con el código: " & TipoGanado.IdTipoGanado, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Limpiar()
                Deshabilitar()
                Me.TipoGanadoC.Obtener()
            Else
                MsgBox("No se logro guardar el tipo de Ganado", MsgBoxStyle.Critical, "Error")
                Cancelar = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            TipoGanadoC.Obtener()
            If TipoGanadoC.Count.ToString > 0 Then
                Dim Reporte As ClasesNegocio.rptCatTipoGanado = TipoGanadoC.Reporte
                Dim VerReporte As New FrmReportes
                'Reporte.SetDataSource(TipoGanadoC)
                Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
                Reporte.SetParameterValue(2, "Catalogos\Compras de Ganado\Tipo de Ganado")
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()
            Else
                MsgBox("No se enconto ningun Tipo de Ganado", MsgBoxStyle.Information, "No hay Informacion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Habilitar()
        Me.txtDescripcion.Focus()
        TipoGanado = New ClasesNegocio.TipoGanadoClass

        'Me.mtb.HabilitarBorrar = False
        'Me.mtb.HabilitarBuscar = True
        'Me.mtb.HabilitarCancelar = False
        'Me.mtb.HabilitarEditar = False
        'Me.mtb.HabilitarGuardar = True
        'Me.mtb.HabilitarImprimir = False
        'Me.mtb.HabilitarLimpiar = True
        'Me.mtb.HabilitarNuevo = False
        'Me.mtb.HabilitarSalir = True
        'Me.GroupBox1.Enabled = True
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

#Region "DataGrid"
    Private Sub dgvTipoGanado_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvTipoGanado.DataError

    End Sub

    Private Sub dgvTipoGanado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvTipoGanado.DoubleClick
        Try
            If Me.dgvTipoGanado.SelectedRows.Count > 0 Then
                TipoGanado = New ClasesNegocio.TipoGanadoClass

                If Not TipoGanado.Obtener(DirectCast(Me.dgvTipoGanado.SelectedRows(0).DataBoundItem, ClasesNegocio.TipoGanadoClass).IdTipoGanado) Then
                    MessageBox.Show("No existe el Tipo de Ganado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Me.PonerDatos()
                    Me.mtb.sbCambiarEstadoBotones("Buscar")
                    Deshabilitar()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

    Private Sub txtFiltro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltro.KeyPress
        Try
            If Me.txtFiltro.Text.Length > 4 Or e.KeyChar = Chr(13) Then
                Me.TipoGanadoC.Obtener(Me.txtFiltro.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class