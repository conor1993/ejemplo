Imports ClasesNegocio

Public Class FrmActFechaCortes

#Region "Miembros"
    Dim LoteCorte As CortesClass
#End Region

#Region "Metodos"
    Private Function Buscar() As Boolean
        Try
            Dim Ventana As New _960BusquasedaLotesDeCortes

            Ventana.Icon = Me.Icon
            Ventana.gbEstatus.Enabled = False
            Ventana.chkVigentes.Checked = True
            Ventana.chkCerrado.Checked = False
            Ventana.chkReproceso.Checked = True
            Ventana.chkProduccion.Checked = True

            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                LoteCorte = New CortesClass(Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmLoteCorte.Index).Value.ToString)
                txtLoteCorte.Text = LoteCorte.LoteCorte
                txtFolioSacrificio.Text = LoteCorte.LoteSacrificio
                txtNombre.Text = LoteCorte.Cliente.Nombre
                txtCodCliente.Text = LoteCorte.IdCliente
                txtDiasCaducidad.Text = LoteCorte.DiasCad
                dtpFechaCaducidad.Value = LoteCorte.FechaCad
                txtObservaciones.Text = LoteCorte.Observaciones
                dtpFechaSacrificio.Value = LoteCorte.FechaFapsa
                dtpFechaLoteCorte.Value = LoteCorte.FechaCorte
                lblEstatus.Text = IIf(LoteCorte.Estatus = "A", "ABIERTO", "CERRADO")
            End If
            Me.txtLoteCorte.Focus()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
            Return False
        End Try
    End Function

    Private Function Cancelar() As Boolean
        Limpiar()
        dtpFechaLoteCorte.Enabled = False
        Return True
    End Function

    Private Function Guardar() As Boolean
        If LoteCorte.Estatus <> "A" Then
            MsgBox("Este Lote de Corte ya se ha cerrado", MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
            Exit Function
        End If

        LoteCorte.FechaCorte = dtpFechaLoteCorte.Value
        Try
            If LoteCorte.Entidad.Save() Then
                MsgBox("Se ha modificado la fecha satisfactoriamente", MsgBoxStyle.Information, Controlador.Sesion.MiEmpresa.Empnom)
            End If
            Limpiar()
            dtpFechaLoteCorte.Enabled = False
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
        End Try
    End Function

    Private Function Editar() As Boolean
        dtpFechaLoteCorte.Enabled = True
        Return True
    End Function

    Private Sub Salir()
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Me.Close()
    End Sub

    Private Sub Limpiar()
        txtLoteCorte.ResetText()
        txtFolioSacrificio.ResetText()
        txtNombre.ResetText()
        txtCodCliente.ResetText()
        txtDiasCaducidad.ResetText()
        txtObservaciones.ResetText()
        dtpFechaCaducidad.Value = Now
        dtpFechaSacrificio.Value = Now
        dtpFechaLoteCorte.Value = Now
    End Sub
#End Region

#Region "Eventos"
    Private Sub Acciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtbMenu.ClickBuscar, mtbMenu.ClickGuardar, mtbMenu.ClickEditar, mtbMenu.ClickCancelar, mtbMenu.ClickBorrar, mtbMenu.ClickSalir, mtbMenu.ClickNuevo, mtbMenu.ClickLimpiar, mtbMenu.ClickImprimir
        Dim Resultado As Boolean = False

        Select Case e.Button.Text
            Case "Buscar"
                Resultado = Me.Buscar()
            Case "Cancelar"
                Resultado = Me.Cancelar()
            Case "Guardar"
                Resultado = Me.Guardar()
            Case "Editar"
                Resultado = Me.Editar()
            Case "Salir"
                Me.Salir()
        End Select

        Cancelar = Not Resultado
    End Sub

    Private Sub FrmActFechaCortes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        tbEstados.StateBuscar = "001000101"
        tbEstados.StateLimpiar = ""
        tbEstados.StateCancelar = "100000001"
        tbEstados.StateNuevo = ""
        tbEstados.StateGuardar = "100000001"
        tbEstados.StateBorrar = ""
        tbEstados.StateEditar = "001010001"
        tbEstados.StateImprimir = ""
        tbEstados.StateSalir = ""
        mtbMenu.ToolBarButtonStatus = tbEstados
        mtbMenu.sbCambiarEstadoBotones("Cancelar")

        txtLoteCorte.ReadOnly = True
        txtFolioSacrificio.ReadOnly = True
        txtNombre.ReadOnly = True
        txtCodCliente.ReadOnly = True
        txtDiasCaducidad.ReadOnly = True
        txtObservaciones.ReadOnly = True
        dtpFechaCaducidad.Enabled = False
        dtpFechaSacrificio.Enabled = False
        dtpFechaLoteCorte.Enabled = False
    End Sub
#End Region
End Class