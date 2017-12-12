Imports CN = ClasesNegocio

Public Class _092ConceptodeNotasdeCredito
    Dim TipoNota As CN.TiposNotasCreditoClass
    Dim TipoNotaCol As New CN.TiposNotasCreditoCollectionClass
    Private Sub _092ConceptodeNotasdeCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Me.mtb.Buttons(1).Visible = False

            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101111"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100001"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "010011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            TipoNotaCol.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            Me.DataGrid.AutoGenerateColumns = False
            Me.DataGrid.DataSource = TipoNotaCol

            Limpiar()
            DesHabilitar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#Region "Metodos"

    Private Sub Limpiar()
        Me.TxtDescripcion.Text = ""
        Me.TxtCodigo.Text = ""
        Me.txtCuentaContable.Text = ""
        Me.DtpFecha.Value = Now
        Me.lblEstatus.Visible = False
    End Sub

    Private Sub Habilitar()
        Me.TxtDescripcion.Enabled = True
        Me.btnCuentaContable.Enabled = True
    End Sub

    Private Sub DesHabilitar()
        Me.TxtDescripcion.Enabled = False
        Me.btnCuentaContable.Enabled = False
    End Sub


#End Region

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If TipoNota.Estatus = ClasesNegocio.EstatusDatos.CANCELADO Then
                MsgBox("El concepto de nota de crédito ya fue cancelado anteriormente", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If

            If MessageBox.Show("¿Esta seguro de cancelar el Concepto de Nota de Crédito?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                TipoNota.Estatus = ClasesNegocio.EstatusDatos.CANCELADO
                If TipoNota.Borrar Then
                    MsgBox("El Concepto de Nota de Crédito ha sido cancelado", MsgBoxStyle.Information, "Aviso")
                    Limpiar()
                    DesHabilitar()
                    Me.TipoNotaCol.Obtener(ClasesNegocio.CondicionEnum.TODOS)
                    Me.DataGrid.AutoGenerateColumns = False
                    Me.DataGrid.DataSource = TipoNotaCol
                End If
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
        If Me.TipoNota.Estatus = ClasesNegocio.EstatusDatos.CANCELADO Then
            If MessageBox.Show("El Concepto de nota crédito se encuentra cancelado ¿esea habilitarlo para poder editarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                TipoNota.Estatus = ClasesNegocio.EstatusDatos.VIGENTE
            End If
        End If
        Habilitar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Me.TxtDescripcion.Text = "" Then
                MsgBox("Ingrese la Descripción", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If

            If IsNothing(Me.TipoNota.CuentaContable) Then
                MsgBox("Seleccione una cuenta contable", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If

            TipoNota.Descripcion = Me.TxtDescripcion.Text
            TipoNota.Estatus = ClasesNegocio.EstatusDatos.VIGENTE
            If TipoNota.Guardar Then
                MsgBox("Se ha guardo el Concepto de nota de Crédito con el código: " & TipoNota.Codigo, MsgBoxStyle.Information, "Aviso")
                Limpiar()
                DesHabilitar()
                TipoNotaCol.Obtener(ClasesNegocio.CondicionEnum.TODOS)
                Me.DataGrid.AutoGenerateColumns = False
                Me.DataGrid.DataSource = TipoNotaCol
            End If
        Catch ex As Exception
            Cancelar = True
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Habilitar()
        Me.TipoNota = New CN.TiposNotasCreditoClass
        Me.TxtDescripcion.Focus()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub btnCuentaContable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuentaContable.Click
        Try
            Dim Ventana As New BusquedaCuentasContablesForm
            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.TipoNota.CuentaContable = Ventana.CuentaContable
                Me.txtCuentaContable.Text = TipoNota.CuentaContable.NombreLargo
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DataGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid.DoubleClick
        Try
            If Me.DataGrid.SelectedRows.Count > 0 Then
                Me.TipoNota = DirectCast(Me.DataGrid.SelectedRows(0).DataBoundItem, CN.TiposNotasCreditoClass)

                Me.TxtDescripcion.Text = TipoNota.Descripcion
                Me.txtCuentaContable.Text = TipoNota.CuentaContable.NombreLargo
                Me.TxtCodigo.Text = TipoNota.Codigo
                Me.DtpFecha.Value = TipoNota.FechaAlta
                Me.lblEstatus.Text = TipoNota.Estatus.ToString
                Me.lblEstatus.Visible = True

                Me.mtb.sbCambiarEstadoBotones("Buscar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DataGrid_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.RowEnter
        Try
            If Me.DataGrid.SelectedRows.Count > 0 Then
                Me.TipoNota = DirectCast(Me.DataGrid.SelectedRows(0).DataBoundItem, CN.TiposNotasCreditoClass)

                Me.TxtDescripcion.Text = TipoNota.Descripcion
                Me.txtCuentaContable.Text = TipoNota.CuentaContable.NombreLargo
                Me.TxtCodigo.Text = TipoNota.Codigo
                Me.DtpFecha.Value = TipoNota.FechaAlta
                Me.lblEstatus.Text = TipoNota.Estatus.ToString
                Me.lblEstatus.Visible = True

                Me.mtb.sbCambiarEstadoBotones("Buscar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class