Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports ED = IntegraLab.ORM.EntityClasses

Public Class FrmABCCorrales
    Private Corral As CorralClass

    Private Sub FrmABCCorrales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            tbEstados.StateBuscar = "101001101"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "001010001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.Buttons(1).Visible = False
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            Me.cmbTipoCorral.DataSource = CC.McecatTiposCorralCollection.GetMultiAsDataTable(HC.McecatTiposCorralFields.Estatus = 1, 0, Nothing)
            Me.cmbTipoCorral.DisplayMember = "DescTipoCorral"
            Me.cmbTipoCorral.ValueMember = "IdTipoCorral"

            Me.CorralesCol.Obtener()
            DesHabilitar()
            Limpiar()
            dgvCorrales.ClearSelection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Guardar() As Boolean
        Try
            Corral.IdCorral = Me.txtCodigo.Text.Trim
            Corral.Descripcion = Me.txtDescripcion.Text
            Corral.DescCorta = Me.txtDescCorta.Text
            Corral.IdTipoCorral = Me.cmbTipoCorral.SelectedValue
            Corral.Capacidad = Me.txtCapacidad.Text
            Corral.Superficie = Me.txtSuperficie.Text
            Corral.Estatus = ClasesNegocio.EstatusDatos.VIGENTE

            If Me.rbtEngorda.Checked Then Corral.TipoCorral = TipoCorral.ENGORDA
            If Me.rbtEnfermeria.Checked Then Corral.TipoCorral = TipoCorral.ENFERMERIA
            If Me.rbtReciba.Checked Then Corral.TipoCorral = TipoCorral.RECIBA

            Return Corral.Guardar()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Limpiar() As Boolean
        'Me.GroupBox1.Enabled = False
        Me.cmbTipoCorral.SelectedIndex = -1
        Me.cmbTipoCorral.Text = "Seleccione un tipo de corral..."
        Me.txtCodigo.Clear()
        Me.txtDescripcion.Text = ""
        Me.txtDescCorta.Text = ""
        Me.txtSuperficie.Text = 0
        Me.txtCapacidad.Text = 0
        Me.lblEstatus.Visible = False
        Me.rbtEnfermeria.Checked = False
        Me.rbtEngorda.Checked = False
        Me.rbtReciba.Checked = False
        'Me.cmbTipoCorral.DataSource = Nothing
    End Function

    Private Sub Habilitar()
        Me.rbtEnfermeria.Enabled = True
        Me.rbtEngorda.Enabled = True
        Me.rbtReciba.Enabled = True
        Me.txtCodigo.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.txtDescCorta.Enabled = True
        Me.cmbTipoCorral.Enabled = True
        Me.txtCapacidad.Enabled = True
        Me.txtSuperficie.Enabled = True
        Me.dgvCorrales.Enabled = False
    End Sub

    Private Sub DesHabilitar()
        Me.rbtEnfermeria.Enabled = False
        Me.rbtEngorda.Enabled = False
        Me.rbtReciba.Enabled = False
        Me.txtCodigo.Enabled = False
        Me.dgvCorrales.Enabled = True
        Me.txtDescripcion.Enabled = False
        Me.txtDescCorta.Enabled = False
        Me.cmbTipoCorral.Enabled = False
        Me.txtCapacidad.Enabled = False
        Me.txtSuperficie.Enabled = False
    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If Me.Corral.Estatus = ClasesNegocio.EstatusDatos.CANCELADO Then
                MsgBox("No se puede cancelar el corral, ya fue cancelado anteriormente", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If

            Me.Corral.Quiendiobaja = Controlador.Sesion.MiUsuario.Usrndx

            If Me.Corral.Borrar Then
                MsgBox("Ha si cancelado el corral", MsgBoxStyle.Information, "Aviso")
                Limpiar()
                DesHabilitar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        DesHabilitar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Try
            If Me.Corral.Estatus = ClasesNegocio.EstatusDatos.CANCELADO Then
                If MessageBox.Show("El corral se encuentra inactivo. ¿Quiere Activarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Corral.Estatus = ClasesNegocio.EstatusDatos.VIGENTE
                    Me.lblEstatus.Text = Corral.Estatus.ToString
                    Habilitar()
                    Me.txtCodigo.Enabled = False
                Else
                    Cancelar = True
                End If
            Else
                Habilitar()
                Me.txtCodigo.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            If Not Guardar() Then
                MessageBox.Show("No se pudo guardar corral", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
            Else
                MessageBox.Show("Se guardo corral con el codigo : " & Me.txtCodigo.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Limpiar()
                DesHabilitar()
                Me.CorralesCol.Obtener()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            CorralesCol.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            If CorralesCol.Count.ToString > 0 Then
                Dim Reporte As ClasesNegocio.RptCatCorrales = CorralesCol.Reporte
                Dim VerReporte As New FrmReportes
                'Reporte.SetDataSource(CorralesCol)
                Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
                Reporte.SetParameterValue(2, "Catalogos\Engorda\Corrales")
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()
            Else
                MsgBox("No se enconto ningun Corral", MsgBoxStyle.Information, "No hay Informacion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Try
            Me.Limpiar()
            Habilitar()
            Me.txtDescripcion.Focus()
            Me.Corral = New CorralClass
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Public Function Validar() As Boolean
        If Me.txtCodigo.Text.Trim = "" Then
            MsgBox("Falta ingresar el corral", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Me.txtCodigo.Focus()
            Return False
        ElseIf Me.txtDescripcion.Text = "" Then
            MsgBox("Falta especificar descripcion del corral", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Me.txtDescripcion.Focus()
            Return False
        ElseIf Me.txtDescCorta.Text = "" Then
            MsgBox("Falta especificar descripcion corta del corral", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Me.txtDescCorta.Focus()
            Return False
        ElseIf Me.cmbTipoCorral.Text = "" Then
            MsgBox("Falta especificar tipos de corral", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Me.cmbTipoCorral.Focus()
            Return False
        ElseIf CInt(Me.txtCapacidad.Text) = 0 Then
            MsgBox("Falta especificar capacidad de cabezas del corral", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Me.txtCapacidad.Focus()
            Return False
        ElseIf CDec(Me.txtSuperficie.Text) = 0 Then
            MsgBox("Falta especificar supercie de corral", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Me.txtSuperficie.Focus()
            Return False
        ElseIf Not (Me.rbtReciba.Checked OrElse Me.rbtEngorda.Checked OrElse Me.rbtEnfermeria.Checked) Then
            MsgBox("Debe seleccionar si el corral es de engorda, reciba o enfermería", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Me.rbtEngorda.Focus()
            Return False
        Else
            Dim Corrales As New CC.McecatCorralesCabCollection

            If Corrales.GetDbCount(HC.McecatCorralesCabFields.NombreCorral = txtDescripcion.Text.Trim) > 0 Then
                MsgBox("Ya existe un corral con esa descripcion", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                Me.txtDescripcion.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtDescCorta.Focus()
        End If
    End Sub

    Private Sub txtDescCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescCorta.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmbTipoCorral.Focus()
        End If
    End Sub

    Private Sub cmbTipoCorral_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipoCorral.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtCapacidad.Focus()
        End If
    End Sub

    Private Sub txtCapacidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCapacidad.KeyPress
        Try
            If (Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "."c) OrElse (e.KeyChar = "."c And Me.txtCapacidad.Text.IndexOf(".", 0) > -1) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtSuperficie.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtSuperficie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSuperficie.KeyPress
        Try
            If (Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "."c) OrElse (e.KeyChar = "."c And Me.txtSuperficie.Text.IndexOf(".", 0) > -1) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtFiltro_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFiltro.TextChanged
        Try
            CorralesCol.Obtener(HC.McecatCorralesCabFields.NombreCorral Mod String.Format("%{0}%", Me.txtFiltro.Text.Trim))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmbTipoCorral_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbTipoCorral.KeyDown
        If e.KeyCode = Keys.F12 Then
            Me.cmbTipoCorral.DataSource = CC.McecatTiposCorralCollection.GetMultiAsDataTable(HC.McecatTiposCorralFields.Estatus = 1, 0, Nothing)
            Me.cmbTipoCorral.DisplayMember = "DescTipoCorral"
            Me.cmbTipoCorral.ValueMember = "IdTipoCorral"
            Me.cmbTipoCorral.SelectedIndex = -1
            Me.cmbTipoCorral.Text = "Seleccione un tipo de corral..."
        End If
    End Sub

    Private Sub dgvCorrales_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCorrales.CellClick
        Try
            If Me.dgvCorrales.SelectedRows.Count > 0 Then
                Corral = New CorralClass(Me.dgvCorrales.SelectedRows(0).Cells(Me.IdCorralDataGridViewTextBoxColumn.Index).Value.ToString.Trim)
                Me.txtCodigo.Text = Corral.IdCorral
                Me.txtDescripcion.Text = Corral.Descripcion
                Me.txtDescCorta.Text = Corral.DescCorta
                Me.cmbTipoCorral.SelectedValue = Corral.IdTipoCorral
                Me.txtSuperficie.Text = Corral.Superficie.ToString("N2")
                Me.txtCapacidad.Text = Corral.Capacidad.ToString("N2")
                Me.lblEstatus.Text = Corral.Estatus.ToString
                Me.rbtEngorda.Checked = Corral.TipoCorral = TipoCorral.ENGORDA
                Me.rbtEnfermeria.Checked = Corral.TipoCorral = TipoCorral.ENFERMERIA
                Me.rbtReciba.Checked = Corral.TipoCorral = TipoCorral.RECIBA
                Me.lblEstatus.Visible = True
                Me.mtb.sbCambiarEstadoBotones("Buscar")
                DesHabilitar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class