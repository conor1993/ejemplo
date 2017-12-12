Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses

Public Class FrmABCTiposCorrales
    Dim TipoCorral As New TipoCorralClass

    Private Sub FrmABCTiposCorrales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.TipoCorralC.Obtener()
            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            tbEstados.StateBuscar = "101101101"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "001010001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            Me.Limpiar()
            Me.Deshabilitar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Close()
        End Try
    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If TipoCorral.Estatus = EstatusDatos.CANCELADO Then
                MsgBox("No se puede cancelar este tipo de corral", MsgBoxStyle.Exclamation, "MEAT")
                Exit Sub
            End If
            Me.TipoCorral.Borrar()
            Me.Limpiar()
            Me.TipoCorralC.Obtener()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Me.Limpiar()
        Me.Deshabilitar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        If TipoCorral.Estatus = EstatusEnum.ACTIVO Then
            Me.Habilitar()
        ElseIf MessageBox.Show("El Tipo de Corral esta inactivo. ¿Quiere activarlo?", "Tipo de Corral Inactivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Me.TipoCorral.Estatus = EstatusEnum.ACTIVO
            Me.lblEstatus.Text = Me.TipoCorral.Estatus.ToString
            Me.Habilitar()
        End If
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Not Me.Validar Then
                Cancelar = True
                Exit Sub
            End If

            Me.Guardar()

            If TipoCorral.Guardar() Then
                MsgBox("Se guardo el tipo de corral con el código " & Me.TipoCorral.IdTipoCorral, MsgBoxStyle.Information)
                Me.Limpiar()
                Me.TipoCorralC.Obtener()
                Me.Deshabilitar()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            TipoCorralC.Obtener(CondicionEstatusEnum.TODOS)
            If TipoCorralC.Count.ToString > 0 Then
                Dim Reporte As ClasesNegocio.RptCatTipoCorral = TipoCorralC.Reporte
                Dim VerReporte As New FrmReportes
                'Reporte.SetDataSource(TipoCorralC)
                Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
                Reporte.SetParameterValue(2, "Catalogos\Engorda\Tipos Corrales")
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()
            Else
                MsgBox("No se enconto ningun Tipo de Corral", MsgBoxStyle.Information, "No hay Informacion")
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
        Me.Limpiar()
        Me.Habilitar()
        Me.txtDescripcion.Focus()
        TipoCorral = New ClasesNegocio.TipoCorralClass
    End Sub

    Public Function Limpiar() As Boolean
        Me.txtCodigo.Clear()
        Me.txtDescCorta.Text = ""
        Me.txtDescripcion.Text = ""
        Me.lblEstatus.Visible = False
    End Function

    Public Function Guardar() As Boolean
        TipoCorral.DescCorta = Me.txtDescCorta.Text
        TipoCorral.Descripcion = Me.txtDescripcion.Text
    End Function

    Public Function PonerDatos() As Boolean
        Me.txtCodigo.Text = TipoCorral.IdTipoCorral
        Me.txtDescCorta.Text = TipoCorral.DescCorta
        Me.txtDescripcion.Text = TipoCorral.Descripcion
        Me.lblEstatus.Text = TipoCorral.Estatus.ToString
        Me.Deshabilitar()
        Me.lblEstatus.Visible = True
    End Function

    Public Function Validar() As Boolean
        If Me.txtDescripcion.Text = "" Then
            MsgBox("Falta especificar descripción de corral", MsgBoxStyle.Exclamation, "MEAT")
            Me.txtDescripcion.Focus()
            Return False
        End If
        If Me.txtDescCorta.Text = "" Then
            MsgBox("Falta especificar descripción corta de corral", MsgBoxStyle.Exclamation, "MEAT")
            Me.txtDescCorta.Focus()
            Return False
        End If
        Return True
    End Function

    Public Function Habilitar() As Boolean
        'Me.txtCodigo.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.txtDescCorta.Enabled = True
    End Function

    Public Function Deshabilitar() As Boolean
        Me.txtCodigo.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.txtDescCorta.Enabled = False
    End Function

    Private Sub dgvTipoCorral_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTipoCorral.CellClick
        Try
            If Me.dgvTipoCorral.SelectedRows.Count > 0 Then
                TipoCorral = New ClasesNegocio.TipoCorralClass(CInt(Me.dgvTipoCorral.SelectedRows(0).Cells(Me.IdTipoCorralDataGridViewTextBoxColumn.Index).Value))
                Me.PonerDatos()
                Me.mtb.sbCambiarEstadoBotones("Buscar")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtDescCorta.Focus()
        End If
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
End Class