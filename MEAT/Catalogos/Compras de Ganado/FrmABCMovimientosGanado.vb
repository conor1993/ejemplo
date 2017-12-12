Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class FrmABCMovimientosGanado
    Dim MovGanado As New TipoMovimientoGanadoClass

    Private Sub FrmABCMovimientosGanado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim tbMovGan As MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbMovGan.StateBuscar = "101101101"
            tbMovGan.StateLimpiar = ""
            tbMovGan.StateCancelar = "100100011"
            tbMovGan.StateNuevo = "011010001"
            tbMovGan.StateGuardar = "100100011"
            tbMovGan.StateBorrar = "101000011"
            tbMovGan.StateEditar = "001010001"
            tbMovGan.StateImprimir = ""
            tbMovGan.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbMovGan
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            MovGanadoC.Obtener()

            Me.Limpiar()
            Me.Deshabilitar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Key Press"
    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtDescCorta.Focus()
        End If
    End Sub

    Private Sub txtDescCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescCorta.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtObservaciones.Focus()
        End If
    End Sub
#End Region

#Region "Metodos"
    Sub Limpiar()
        Me.txtCodigo.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtDescCorta.Text = ""
        Me.txtObservaciones.Text = ""
        Me.chkSalida.Checked = False
        Me.lblEstatus.Visible = False
    End Sub
    Sub Habilitar()
        Me.txtDescripcion.Enabled = True
        Me.txtDescCorta.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.chkSalida.Enabled = True
    End Sub

    Sub Deshabilitar()
        Me.txtDescripcion.Enabled = False
        Me.txtDescCorta.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.chkSalida.Enabled = False
    End Sub
    Sub Guardar()
        MovGanado.Nombre = Me.txtDescripcion.Text
        MovGanado.NomCorto = Me.txtDescCorta.Text
        Me.MovGanado.Observaciones = Me.txtObservaciones.Text
        Me.MovGanado.Salida = Me.chkSalida.Checked
    End Sub
    Sub PonerDatos()
        Me.txtCodigo.Text = Me.MovGanado.IdMovGanado
        Me.txtDescripcion.Text = Me.MovGanado.Nombre
        Me.txtDescCorta.Text = Me.MovGanado.NomCorto
        Me.txtObservaciones.Text = Me.MovGanado.Observaciones
        Me.chkSalida.Checked = Me.MovGanado.Salida
        Me.lblEstatus.Text = Me.MovGanado.Estatus.ToString
        Me.lblEstatus.Visible = True
    End Sub
    Public Function Validar() As Boolean
        Try
            If Me.txtDescripcion.Text = "" Then
                MessageBox.Show("Especifique la Descripcion del Movimiento de Ganado", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtDescripcion.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "Botones Tollbar"
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Cursor = Cursors.WaitCursor

        Try
            If MovGanado.Estatus = EstatusDatos.CANCELADO Then
                MsgBox("No se puede cancelar el Movimiento de Ganado")
                Cancelar = True
            Else
                MovGanado.Borrar()
                Me.Limpiar()
                Me.MovGanadoC.Obtener()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Me.Deshabilitar()
        Me.Limpiar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Try
            If MovGanado.Estatus = EstatusDatos.VIGENTE Then
                Habilitar()
            ElseIf MessageBox.Show("El tipo movimeinto ganado esta cancelado. ¿Quiere Activarlo?", "Activar Tipo Movimeinto Ganado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                MovGanado.Estatus = ClasesNegocio.EstatusDatos.VIGENTE
                Me.lblEstatus.Text = MovGanado.Estatus.ToString
                Me.Habilitar()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            Cancelar = True
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            Me.Guardar()

            If MovGanado.Guardar() Then
                MessageBox.Show("El tipo movimiento de ganado se guardo", "Tipo Movimeinto Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Limpiar()
                Me.MovGanadoC.Obtener()
                Me.Deshabilitar()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            MovGanadoC.Obtener()
            If MovGanadoC.Count.ToString > 0 Then
                Dim Reporte As ClasesNegocio.rptCatMovimientosGanado = MovGanadoC.Reporte
                Dim VerReporte As New FrmReportes
                'Reporte.SetDataSource(MovGanadoC)
                Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
                Reporte.SetParameterValue(2, "Catalogos\Compras de Ganado\Movimientos de Ganado")
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()
            Else
                MsgBox("No se enconto ningun Movimiento de Ganado", MsgBoxStyle.Information, "No hay Informacion")
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
        MovGanado = New TipoMovimientoGanadoClass
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region

#Region "DataGrid"
    Private Sub dgvMovGanado_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvMovGanado.DataError

    End Sub

    Private Sub dgvMovGanado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvMovGanado.DoubleClick
        Try
            If Me.dgvMovGanado.SelectedRows.Count > 0 Then
                MovGanado = New ClasesNegocio.TipoMovimientoGanadoClass

                If Not MovGanado.Obtener(Me.MovGanadoC(Me.dgvMovGanado.CurrentRow.Index).IdMovGanado) Then
                    MessageBox.Show("No esxiste el moviemiento de Ganado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Me.PonerDatos()
                    Me.mtb.sbCambiarEstadoBotones("Buscar")
                    Deshabilitar()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

    Private Sub txtFiltro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltro.KeyPress
        Try
            If Me.txtFiltro.Text.Length > 4 Or e.KeyChar = Chr(13) Then
                Me.MovGanadoC.Obtener(Me.txtFiltro.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class