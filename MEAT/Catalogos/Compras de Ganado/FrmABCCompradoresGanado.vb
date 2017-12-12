Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports System.Windows.Forms
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class FrmABCCompradoresGanado

#Region "Miembros"
    Dim CompradorGan As New CompradorGanadoClass
#End Region

#Region "Metodos"
    Private Function Guardar() As Boolean
        Try
            CompradorGan.Nombre = Me.txtNombre.Text
            CompradorGan.ApellidoPaterno = Me.txtApellidoPaterno.Text
            CompradorGan.ApellidoMaterno = Me.txtApellidoMaterno.Text
            CompradorGan.RFC = Me.txtRFC.Text
            CompradorGan.Calle = Me.txtCalle.Text
            CompradorGan.Colonia = Me.txtColonia.Text
            CompradorGan.Entidad.IdEstado = Me.cmbEstado.SelectedValue
            CompradorGan.Entidad.IdCiudad = Me.cmbCiudad.SelectedValue
            CompradorGan.Entidad.IdPoblacion = Me.cmbPoblacion.SelectedValue
            CompradorGan.PagarComision = Me.chkPagarComision.Checked
            CompradorGan.Estatus = EstatusDatos.VIGENTE
            CompradorGan.FechaAlta = Now

            If Me.chkPagarComision.Checked Then
                CompradorGan.ComisionPorKilo = CDec(Me.txtComisionKilos.Text)
                CompradorGan.ComisionxCabeza = CDec(Me.txtComisionxCabeza.Text)
            Else
                CompradorGan.ComisionPorKilo = 0D
                CompradorGan.ComisionxCabeza = 0D
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function Validar() As Boolean
        Try

            If Me.txtCta.Text = "" Then
                MessageBox.Show("Especifique Cuenta Contable", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtNombre.Focus()
                Return False
            End If
            If Me.txtNombre.Text = "" Then
                MessageBox.Show("Especifique nombre de Comprador de Ganado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtNombre.Focus()
                Return False
            End If

            If Me.cmbEstado.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione el Estado del Comprador de Ganado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.cmbEstado.Focus()
                Me.cmbEstado.SelectedIndex = 0
                Return False
            End If

            If Me.cmbCiudad.SelectedIndex = -1 Then
                MsgBox("Selccione la ciudad del Comprador de Ganado", MsgBoxStyle.Exclamation, "Aviso")
                Me.cmbCiudad.SelectedIndex = 0
                Me.cmbCiudad.Focus()
                Return False
            End If

            If Me.cmbPoblacion.SelectedIndex = -1 Then
                MsgBox("Seleccione la población del Comprador de Ganado", MsgBoxStyle.Exclamation, "Aviso")
                Me.cmbPoblacion.SelectedIndex = 0
                Me.cmbPoblacion.Focus()
                Return False
            End If

            If Me.chkPagarComision.Checked Then
                If (Me.txtComisionKilos.Text.Trim = "" OrElse Not IsNumeric(Me.txtComisionKilos.Text) OrElse _
                        CDec(Me.txtComisionKilos.Text) = 0D) AndAlso (Me.txtComisionxCabeza.Text.Trim = "" OrElse _
                        Not IsNumeric(Me.txtComisionxCabeza.Text) OrElse CDec(Me.txtComisionxCabeza.Text) = 0D) Then
                    MsgBox("Debe ingresar por lo menos un tipo de comisión", MsgBoxStyle.Exclamation, "Aviso")
                    Me.txtComisionxCabeza.Focus()
                    Return False
                End If
            End If

            'If CompradorGan.CuentaContable Is Nothing OrElse CompradorGan.CuentaContable.CuentaMayor = "" Then
            '    MsgBox("Seleccione una cuenta contable", MsgBoxStyle.Exclamation, "Aviso")
            '    Me.btnCta.Focus()
            '    Return False
            'End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function Limpiar() As Boolean
        Me.txtComisionKilos.Clear()
        Me.txtCodigo.Text = 0
        Me.txtNombre.Text = ""
        Me.txtApellidoPaterno.Text = ""
        Me.txtApellidoMaterno.Text = ""
        Me.txtRFC.Text = ""
        Me.txtCalle.Text = ""
        Me.txtColonia.Text = ""
        Me.chkPagarComision.Checked = True
        Me.chkPagarComision.Checked = False
        Me.txtComisionxCabeza.Text = 0
        Me.cmbEstado.SelectedIndex = -1
        Me.cmbPoblacion.SelectedIndex = -1
        Me.cmbCiudad.SelectedIndex = -1
        Me.lblEstatus.Visible = False
        Me.txtCta.Text = ""
        cmbEstado.Text = "Selecione un Estado"
    End Function

    Private Function Habilitar() As Boolean
        Me.dgvLotes.Enabled = True
        Me.txtNombre.Enabled = True
        Me.txtApellidoPaterno.Enabled = True
        Me.txtApellidoMaterno.Enabled = True
        Me.txtRFC.Enabled = True
        Me.txtCalle.Enabled = True
        Me.txtColonia.Enabled = True
        Me.chkPagarComision.Enabled = True
        Me.cmbEstado.Enabled = True
        Me.cmbPoblacion.Enabled = True
        Me.cmbCiudad.Enabled = True
        Me.btnCta.Enabled = True
    End Function

    Private Function Deshabilitar() As Boolean
        Me.dgvLotes.Enabled = True
        Me.txtNombre.Enabled = False
        Me.txtApellidoPaterno.Enabled = False
        Me.txtApellidoMaterno.Enabled = False
        Me.txtRFC.Enabled = False
        Me.txtCalle.Enabled = False
        Me.txtColonia.Enabled = False
        Me.chkPagarComision.Enabled = False
        Me.txtComisionxCabeza.Enabled = False
        Me.cmbEstado.Enabled = False
        Me.cmbPoblacion.Enabled = False
        Me.cmbCiudad.Enabled = False
        Me.btnCta.Enabled = False
        Me.txtComisionKilos.Enabled = False
    End Function

    Private Function PonerDatos() As Boolean
        Try
            Me.txtCodigo.Text = CompradorGan.IdComprador
            Me.txtNombre.Text = CompradorGan.Nombre
            Me.txtApellidoPaterno.Text = CompradorGan.ApellidoPaterno
            Me.txtApellidoMaterno.Text = CompradorGan.ApellidoMaterno
            Me.txtRFC.Text = CompradorGan.RFC
            Me.txtCalle.Text = CompradorGan.Calle
            Me.txtColonia.Text = CompradorGan.Colonia
            Me.txtCta.Text = CompradorGan.CuentaContable.NombreLargo
            Me.cmbEstado.SelectedValue = CompradorGan.Entidad.IdEstado
            Me.cmbCiudad.SelectedValue = CompradorGan.Entidad.IdCiudad
            Me.cmbPoblacion.SelectedValue = CompradorGan.Entidad.IdPoblacion
            Me.chkPagarComision.Checked = CompradorGan.PagarComision
            Me.txtComisionxCabeza.Text = CompradorGan.ComisionxCabeza.ToString("N3")
            Me.lblEstatus.Text = CompradorGan.Estatus.ToString
            Me.lblEstatus.Visible = True
            Me.txtComisionKilos.Text = CompradorGan.ComisionPorKilo.ToString("N3")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Private Function Imprimir() As Boolean

    End Function

    Private Sub LlenaCombox()
        Me.cmbEstado.DataSource = CC.EstadoCollection.GetMultiAsDataTable(HC.EstadoFields.Estatus = "1", 0, Nothing)
        Me.cmbEstado.DisplayMember = "Descripcion"
        Me.cmbEstado.ValueMember = "Codigo"
        Me.cmbEstado.Text = "Seleccione un Estado"
        Me.cmbEstado.SelectedIndex = -1
    End Sub
#End Region

#Region "Eventos"
#Region "Form"
    Private Sub FrmABCCompradoresGanado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim tbCompradoresGan As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbCompradoresGan.StateBuscar = "101101101"
            tbCompradoresGan.StateLimpiar = ""
            tbCompradoresGan.StateCancelar = "100100011"
            tbCompradoresGan.StateNuevo = "011010001"
            tbCompradoresGan.StateGuardar = "100100011"
            tbCompradoresGan.StateBorrar = "100100011"
            tbCompradoresGan.StateEditar = "010010001"
            tbCompradoresGan.StateImprimir = ""
            tbCompradoresGan.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbCompradoresGan
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            Me.CompradoresGanadoC.Obtener()
            Me.EstadoC.Obtener(CondicionEnum.ACTIVOS)

            Me.Limpiar()
            Me.Deshabilitar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "DataGrid"
    Private Sub dgvLotes_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvLotes.DataError

    End Sub

    Private Sub dgvLotes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvLotes.DoubleClick
        Try
            If Me.dgvLotes.SelectedRows.Count > 0 Then
                CompradorGan = New ClasesNegocio.CompradorGanadoClass
                If Not CompradorGan.Obtener(DirectCast(Me.dgvLotes.SelectedRows(0).DataBoundItem, ClasesNegocio.CompradorGanadoClass).IdComprador) Then
                    MessageBox.Show("No existe el Comprador de Ganado", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

#Region "ComBox"
    Private Sub cmbEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstado.SelectedIndexChanged
        Try
            If Me.cmbEstado.SelectedIndex > -1 Then
                Me.CiudadC.Obtener(CInt(Me.cmbEstado.SelectedValue), CondicionEnum.ACTIVOS)
                Me.cmbCiudad.DataSource = Me.CiudadC
                Me.cmbCiudad.SelectedIndex = -1
                Me.cmbCiudad.Text = "Seleccione una ciudad"
            Else

                Me.CiudadC.Clear()
                Me.cmbCiudad.Text = "Seleccione una ciudad"
                Me.cmbCiudad.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbCiudad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCiudad.SelectedIndexChanged
        Try
            If Me.cmbCiudad.SelectedIndex > -1 Then
                Me.PoblacionC.Obtener(CondicionEnum.ACTIVOS, CInt(Me.cmbEstado.SelectedValue), CInt(Me.cmbCiudad.SelectedValue))
                Me.cmbPoblacion.SelectedIndex = -1
                Me.cmbPoblacion.Text = "Seleccione una población"
            Else
                Me.PoblacionC.Clear()
                Me.cmbPoblacion.SelectedIndex = -1
                Me.cmbPoblacion.Text = "Seleccione una población"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbEstado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbEstado.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmbCiudad.Focus()
        End If
    End Sub

    Private Sub cmbCiudad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCiudad.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmbPoblacion.Focus()
        End If
    End Sub

    Private Sub cmbPoblacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPoblacion.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btnCta.Focus()
        End If
    End Sub
#End Region

#Region "TexBox"
    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                Me.txtApellidoPaterno.Focus()
            End If
            If IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtApellidoPaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellidoPaterno.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtApellidoMaterno.Focus()
        End If
        If IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtApellidoMaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellidoMaterno.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtRFC.Focus()
        End If
        If IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRFC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRFC.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtCalle.Focus()
        End If
    End Sub

    Private Sub txtCalle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCalle.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtColonia.Focus()
        End If
    End Sub

    Private Sub txtColonia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtColonia.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmbEstado.Focus()
        End If
    End Sub

    Private Sub txtComisionxCabeza_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtComisionxCabeza.LostFocus
        Me.txtComisionxCabeza.Text = CDec(IIf(IsNumeric(Me.txtComisionxCabeza.Text), Me.txtComisionxCabeza.Text, 0)).ToString("C2")
    End Sub

    Private Sub txtComisionxCabeza_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtComisionxCabeza.GotFocus
        Me.txtComisionxCabeza.Text = IIf(Me.txtComisionxCabeza.Text = "", 0.0, Me.txtComisionxCabeza.Text.Replace("$", "").Replace(",", ""))
    End Sub

    Private Sub txtComisionxCabeza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtComisionxCabeza.KeyPress
        Try
            If IsNumeric(Me.txtComisionKilos.Text.Replace("$", "")) AndAlso _
                CDec(Me.txtComisionKilos.Text.Replace("$", "")) > 0D AndAlso Not e.KeyChar = Chr(13) Then
                Me.txtComisionKilos.Text = 0D.ToString("C2")
            End If

            If e.KeyChar = "." And Me.txtComisionxCabeza.Text.IndexOf(".") > -1 Then
                e.Handled = True
                Exit Sub
            End If
            If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "." Then
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtFiltro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltro.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                Me.CompradoresGanadoC.Obtener(Me.txtFiltro.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtFiltro_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFiltro.TextChanged
        Try
            If Me.txtFiltro.Text.Trim.Length > 2 Then
                Me.CompradoresGanadoC.Obtener(Me.txtFiltro.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "ToolBar"
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If CompradorGan.Estatus = EstatusDatos.CANCELADO Then
                MsgBox("No se puede cancelar este Comprador de Ganado", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If

            If Me.CompradorGan.Borrar() Then
                MsgBox("El comprador a sido cancelado", MsgBoxStyle.Information, "Aviso")
                Me.Limpiar()
                Me.Deshabilitar()
                Me.CompradoresGanadoC.Obtener()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            Cancelar = True
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Me.Limpiar()
        Me.Deshabilitar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        If CompradorGan.Estatus = EstatusEnum.ACTIVO Then
            Me.Habilitar()
        ElseIf MessageBox.Show("El comprador esta inactivo. ¿Quiere Activarlo?", "Activar Comprador", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            CompradorGan.Estatus = EstatusEnum.ACTIVO
            Me.Habilitar()
        Else
            Cancelar = True
        End If
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Not Me.Validar Then
                Cancelar = True
                Exit Sub
            End If

            Me.Guardar()

            If CompradorGan.Guardar() Then
                CompradoresGanadoC.Obtener()
                Me.Limpiar()
                Me.Deshabilitar()
                MsgBox("Se guardo el comprador", MsgBoxStyle.Information, "Aviso")
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            Cancelar = True
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            CompradoresGanadoC.Obtener()
            If CompradoresGanadoC.Count.ToString > 0 Then
                Dim Reporte As ClasesNegocio.rptCatCompradoresGanado = CompradoresGanadoC.Reporte
                Dim VerReporte As New FrmReportes
                'Reporte.SetDataSource(CompradoresGanadoC)
                Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
                Reporte.SetParameterValue(2, "Catalogos\Compras de Ganado\Compradores de Ganado")
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()
            Else
                MsgBox("No se enconto ningun Compradores de Ganado", MsgBoxStyle.Information, "No hay Informacion")
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
        Try
            Me.LlenaCombox()
            Me.Limpiar()
            Me.GroupBox1.Enabled = True
            Habilitar()
            Me.txtNombre.Focus()
            CompradorGan = New ClasesNegocio.CompradorGanadoClass
        Catch ex As Exception
            Cancelar = True
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

#Region "Buttons"
    Private Sub btnCta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCta.Click
        Try
            Dim Ventana As New BusquedaCuentasContablesForm
            Ventana.AfectableDefault(True) = ClasesNegocio.CondicionAsignadaEnum.SI
            Ventana.InactivaDefault(True) = ClasesNegocio.CondicionAsignadaEnum.NO
            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                CompradorGan.CuentaContable = Ventana.CuentaContable
                Me.txtCta.Text = CompradorGan.CuentaContable.NombreLargo
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "CheckBox"
    Private Sub chkPagarComision_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPagarComision.CheckedChanged
        If Me.chkPagarComision.Checked = True Then
            Me.txtComisionxCabeza.Text = ""
            Me.txtComisionxCabeza.Enabled = True
            Me.txtComisionxCabeza.Focus()
            Me.txtComisionKilos.Text = 0.0
            Me.txtComisionKilos.Enabled = True
        Else
            Me.txtComisionxCabeza.Enabled = False
            Me.txtComisionxCabeza.Text = ""
            Me.txtComisionKilos.Clear()
            Me.txtComisionKilos.Enabled = False
        End If
    End Sub
#End Region
#End Region

    Private Sub txtComisionKilos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtComisionKilos.GotFocus
        Me.txtComisionKilos.Text = Me.txtComisionKilos.Text.Replace("$", "").Replace(",", "")
    End Sub

    Private Sub txtComisionKilos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtComisionKilos.KeyPress
        If IsNumeric(Me.txtComisionxCabeza.Text.Replace("$", "")) AndAlso _
            CDec(Me.txtComisionxCabeza.Text.Replace("$", "")) > 0D AndAlso Not e.KeyChar = Chr(13) Then
            Me.txtComisionxCabeza.Text = 0D.ToString("C2")
        End If

        If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) AndAlso Not e.KeyChar = "."c) OrElse _
            (e.KeyChar = "."c AndAlso Me.txtComisionKilos.Text.IndexOf("."c) > -1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtComisionKilos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtComisionKilos.LostFocus
        Me.txtComisionKilos.Text = CDec(IIf(IsNumeric(Me.txtComisionKilos.Text), Me.txtComisionKilos.Text, 0)).ToString("C2")
    End Sub
End Class