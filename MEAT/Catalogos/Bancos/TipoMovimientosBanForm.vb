Public Class TipoMovimientosBanForm

    'Dim TipoMovBan As ClasesNegocio.TiposMovtosBancariosClass
    'Dim TiposMovBanCol As New ClasesNegocio.TiposMovimientosBancariosColeccion
    '    Private Sub TipoMovimientosBanForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '        ' Barra de botones de la ToolBar...
    '        Me.Datagrid.AutoGenerateColumns = False
    '        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
    '        Me.MEAToolBar1.Buttons(0).ToolTipText = ""
    '        MtbEstados.StateBuscar = "110101111"
    '        Me.MEAToolBar1.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
    '        MtbEstados.StateLimpiar = ""
    '        Me.MEAToolBar1.Buttons(3).ToolTipText = "Cancela la acción actual ."
    '        MtbEstados.StateCancelar = "000100011"
    '        Me.MEAToolBar1.Buttons(5).ToolTipText = "Crea un nuevo Tipo de Movimiento Bancario."
    '        MtbEstados.StateNuevo = "011010001"
    '        Me.MEAToolBar1.Buttons(6).ToolTipText = "Guarda el Tipo de Movimiento Bancario o los cambios que se le hayan Realizado."
    '        MtbEstados.StateGuardar = "000100011"
    '        Me.MEAToolBar1.Buttons(7).ToolTipText = "Cambia el estatus de el Tipo de Movimiento Bancario."
    '        MtbEstados.StateBorrar = "000100001"
    '        Me.MEAToolBar1.Buttons(8).ToolTipText = "Permite Modificar el Tipo de Movimiento Bancario."
    '        MtbEstados.StateEditar = "0010100001"
    '        Me.MEAToolBar1.Buttons(10).ToolTipText = "Imprime Los Tipos de Movimientos Bancarios Registrados."
    '        MtbEstados.StateImprimir = ""
    '        Me.MEAToolBar1.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."
    '        MtbEstados.StateSalir = ""
    '        MEAToolBar1.ToolBarButtonStatus = MtbEstados
    '        MEAToolBar1.sbCambiarEstadoBotones("Cancelar")
    '        Deshabilitar()
    '        Me.Datagrid.DataSource = TiposMovBanCol
    '        Me.TiposMovBanCol.Obtener(ClasesNegocio.CondicionEstatusEnum.TODOS)
    '    End Sub

    '#Region "Pasar al siguiente Control"
    '    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
    '        'Para pasar al siguiente control
    '        If e.KeyChar = Chr(13) Then
    '            txtDescripcionCorta.Focus()
    '            If txtDescripcion.Text = "" Then
    '                MsgBox("Agregue Información a la Descripción . . . ")
    '                txtDescripcion.Focus()
    '            End If
    '        End If
    '    End Sub

    '    Private Sub txtDescripcionCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcionCorta.KeyPress
    '        'Para pasar al siguiente control
    '        If e.KeyChar = Chr(13) Then
    '            txtObservacion.Focus()
    '            If txtDescripcionCorta.Text = "" Then
    '                MsgBox("Agregue Información a la Descripción Corta . . . ")
    '                txtDescripcionCorta.Focus()
    '            End If
    '        End If
    '    End Sub
    '#End Region

    '#Region "metodos"

    '    Private Sub limpiar()
    '        Me.txtCodigo.Clear()
    '        Me.dtpFecha.Value = Now
    '        Me.txtDescripcion.Clear()
    '        Me.txtDescripcionCorta.Clear()
    '        Me.txtObservacion.Clear()
    '        lblEstatus.Text = "ESTATUS"
    '        Me.Txtfiltro.Clear()
    '    End Sub
    '    Private Sub Deshabilitar()
    '        txtCodigo.Enabled = False
    '        txtDescripcion.Enabled = False
    '        txtDescripcionCorta.Enabled = False
    '        txtObservacion.Enabled = False
    '        Datagrid.Enabled = True
    '    End Sub
    '    Private Sub Habilitar()
    '        txtCodigo.Enabled = False
    '        txtDescripcion.Enabled = True
    '        txtDescripcionCorta.Enabled = True
    '        txtObservacion.Enabled = True
    '        Datagrid.Enabled = False
    '    End Sub
    '    Private Sub PasarValores()
    '        TipoMovBan.FechaAlta = dtpFecha.Value
    '        TipoMovBan.Descripcion = txtDescripcion.Text
    '        TipoMovBan.DescripcionCorta = txtDescripcionCorta.Text
    '        TipoMovBan.Observaciones = txtObservacion.Text
    '    End Sub
    '    Private Sub ObtenerValores()
    '        txtCodigo.Text = TipoMovBan.Codigo
    '        dtpFecha.Value = TipoMovBan.FechaAlta
    '        txtDescripcion.Text = TipoMovBan.Descripcion
    '        txtDescripcionCorta.Text = TipoMovBan.DescripcionCorta
    '        txtObservacion.Text = TipoMovBan.Observaciones
    '        lblEstatus.Text = TipoMovBan.Estatus.ToString
    '    End Sub
    '#End Region

    '#Region "MEAToolBar"
    '    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBorrar
    '        If TipoMovBan.Estatus = Integra.Clases.EstatusEnum.ACTIVO Then
    '            If TipoMovBan.Borrar Then
    '                MessageBox.Show("El Tipo de Movimiento Bancario ha sido Inactivado.")
    '                Deshabilitar()
    '                limpiar()
    '            Else
    '                Cancelar = True
    '            End If
    '        Else
    '            MessageBox.Show("El Tipo de Movimiento Bancario ya está Inactivado.")
    '            limpiar()
    '            Deshabilitar()
    '        End If
    '    End Sub

    '    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickCancelar
    '        limpiar()
    '        Deshabilitar()
    '    End Sub

    '    Private Sub MEAToolBar1_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickEditar
    '        Cancelar = False
    '        If TipoMovBan.Estatus = Integra.Clases.EstatusEnum.ACTIVO Then
    '            Habilitar()
    '        Else
    '            If MessageBox.Show("El Tipo de Movimiento Bancario está Inactivo, ¿Desea Activarlo?", "Activar El Movimiento Bancario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
    '                Dim activar As Boolean = True
    '                If activar Then
    '                    TipoMovBan.Estatus = Integra.Clases.EstatusEnum.ACTIVO
    '                    Me.lblEstatus.Visible = True
    '                    Me.lblEstatus.Text = TipoMovBan.Estatus.ToString
    '                    Habilitar()
    '                End If
    '            Else
    '                Cancelar = True
    '                MEAToolBar1.sbCambiarEstadoBotones("Guardar")
    '                limpiar()
    '                Deshabilitar()
    '            End If
    '        End If
    '    End Sub

    '    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickGuardar
    '        Cancelar = False
    '        Try
    '            PasarValores()
    '            If txtDescripcion.Text = "" Or txtDescripcionCorta.Text = "" Then
    '                MessageBox.Show("La Descripción y Descripción Corta es Obligatoria Agregue Información ")
    '                Cancelar = True
    '            Else
    '                If TipoMovBan.Guardar Then
    '                    MessageBox.Show("El Tipo de Movimiento Bancario se ha guardado satisfactoriamente.")
    '                    limpiar()
    '                    Deshabilitar()
    '                    TiposMovBanCol.Obtener(ClasesNegocio.CondicionEstatusEnum.TODOS)
    '                Else
    '                    Cancelar = True
    '                End If
    '            End If
    '        Catch ex As Exception
    '            Cancelar = True
    '        End Try
    '    End Sub

    '    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir
    '        Dim Prev As New ClasesNegocio.PreVisualizarForm
    '        Prev.Reporte = Me.TiposMovBanCol.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom, "Catálogos/Bancos/Tipos Movimientos Bancos")
    '        Prev.ShowDialog()
    '    End Sub

    '    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
    '        limpiar()
    '    End Sub

    '    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickNuevo
    '        Habilitar()
    '        limpiar()
    '        TipoMovBan = New ClasesNegocio.TiposMovtosBancariosClass
    '        Me.txtDescripcion.Focus()
    '    End Sub

    '    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
    '        Me.Close()
    '    End Sub

    '#End Region

    '    Private Sub Txtfiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtfiltro.TextChanged
    '        Me.TiposMovBanCol.Obtener(Me.Txtfiltro.Text)
    '    End Sub

    '    Private Sub Datagrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Datagrid.CellClick
    '        Me.TipoMovBan = Me.Datagrid.SelectedRows(0).DataBoundItem
    '        If Not IsNothing(TipoMovBan) Then
    '            ObtenerValores()
    '            MEAToolBar1.sbCambiarEstadoBotones("Buscar")
    '        Else
    '            Windows.Forms.MessageBox.Show("No seleccionó un elemento válido.")
    '        End If
    '    End Sub

End Class