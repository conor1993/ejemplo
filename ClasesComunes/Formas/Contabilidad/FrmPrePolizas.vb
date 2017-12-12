Imports ClasesNegocio
Imports Integralab.ORM.EntityClasses

Public Class FrmPrePolizas

#Region "Miembros"
    Dim Poliza As PolizaModeloCabClass
    Dim noValidar As Boolean = False
#End Region

#Region "Metodos"
    Private Sub ValidarNumericos(ByVal Sender As Object, ByVal e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ValidarCA(ByVal Sender As Object, ByVal e As KeyPressEventArgs)
        If Not e.KeyChar.ToString.ToUpper = Chr(Keys.A) And _
            Not e.KeyChar.ToString.ToUpper = Chr(Keys.C) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Limpiar()
        txtCodigo.Text = String.Empty
        txtDescripcion.Text = String.Empty
        dgvPrePolizaNacional.Rows.Clear()
    End Sub

    Private Sub InhabilitarEdicion()
        txtDescripcion.ReadOnly = True
        dgvPrePolizaNacional.ReadOnly = True
        dgvPrePolizaNacional.AllowUserToAddRows = False
    End Sub

    Private Sub HabilitarEdicion()
        txtDescripcion.ReadOnly = False
        dgvPrePolizaNacional.ReadOnly = False
        dgvPrePolizaNacional.AllowUserToAddRows = True
    End Sub

    Private Function SonAfectables() As DataGridViewRow
        For i As Integer = 0 To dgvPrePolizaNacional.Rows.Count - 2
            If dgvPrePolizaNacional.Rows(i).Cells("clmAfectable").Value = False Then
                Return dgvPrePolizaNacional.Rows(i)
            End If
        Next
        Return Nothing
    End Function

    Private Function TienenMovimiento() As DataGridViewRow
        For i As Integer = 0 To dgvPrePolizaNacional.Rows.Count - 2
            If dgvPrePolizaNacional.Rows(i).Cells("clmMovimiento").Value = String.Empty Then
                Return dgvPrePolizaNacional.Rows(i)
            End If
        Next
        Return Nothing
    End Function

    Private Function Existentes() As DataGridViewRow
        For i As Integer = 0 To dgvPrePolizaNacional.Rows.Count - 2
            If dgvPrePolizaNacional.Rows(i).Cells("clmDescripcion").Value Is Nothing Then
                Return dgvPrePolizaNacional.Rows(i)
            ElseIf CType(dgvPrePolizaNacional.Rows(i).Cells("clmDescripcion").Value, CuentaContableClass).NombreCuenta = String.Empty Then
                Return dgvPrePolizaNacional.Rows(i)
            End If
        Next
        Return Nothing
    End Function

    Private Function esCongruente() As String
        Dim Cargos As Boolean = False
        Dim Abonos As Boolean = False

        For i As Integer = 0 To dgvPrePolizaNacional.Rows.Count - 2
            If dgvPrePolizaNacional.Rows(i).Cells("clmMovimiento").Value = "C" Then
                Cargos = True
            Else
                Abonos = True
            End If

            If Cargos And Abonos Then
                Return Nothing
            End If
        Next

        If Cargos Then
            Return "Abono"
        Else
            Return "Cargo"
        End If
    End Function

    Private Function ValidarGuardar() As Boolean
        If txtDescripcion.Text = String.Empty Then
            txtDescripcion.Focus()
            MsgBox("Debe proporcionar la description", MsgBoxStyle.Exclamation, "Aviso")
            Exit Function
        Else
            If dgvPrePolizaNacional.Rows.Count = 1 Then
                MsgBox("No hay cuentas contables, debe proporcionarlas", MsgBoxStyle.Exclamation, "Aviso")
                Exit Function
            Else
                Dim row As DataGridViewRow = SonAfectables()
                row = Existentes()

                If row IsNot Nothing Then
                    MsgBox("La cuenta espeficicada no existe", MsgBoxStyle.Exclamation, "Aviso")
                    row.Selected = True
                    Exit Function
                Else
                    row = SonAfectables()
                    If row IsNot Nothing Then
                        MsgBox("Deben ser cuentas afectables", MsgBoxStyle.Exclamation, "Aviso")
                        row.Selected = True
                        Exit Function
                    Else
                        row = TienenMovimiento()
                        If row IsNot Nothing Then
                            MsgBox("Debe especificar el movimiento", MsgBoxStyle.Exclamation, "Aviso")
                            row.Cells("clmMovimiento").Selected = True
                            Exit Function
                        Else
                            Dim Faltante As String = esCongruente()
                            If Faltante IsNot Nothing Then
                                MsgBox("Debe tener al menos un " & Faltante, MsgBoxStyle.Exclamation, "Aviso")
                                Exit Function
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Return True
    End Function

    Private Sub Inicializar()
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = ""
        MtbEstados.StateCancelar = "100100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "100100011"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010000"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        mtb.ToolBarButtonStatus = MtbEstados
        mtb.sbCambiarEstadoBotones("Cancelar")
        txtDescripcion.ReadOnly = True
        dgvPrePolizaNacional.ReadOnly = True
    End Sub

    Public Function Buscar() As Boolean
        Try
            Dim Busqueda As New frmBusquedaPrePolizas
            If Busqueda.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                dgvPrePolizaNacional.AllowUserToAddRows = False
                Poliza = New PolizaModeloCabClass(CType(Busqueda.dgvPrePolizas.CurrentRow().DataBoundItem, PolizasModeloCabEntity))
                lblEstatus.Text = Poliza.Estatus.ToString
                txtCodigo.Text = Poliza.IdPoliza
                txtDescripcion.Text = Poliza.Descripcion

                For Each _detalle As PolizaModeloDetClass In Poliza.Detalle
                    _detalle.ActualizarCuentas()
                Next
                dgvPrePolizaNacional.DataSource = Poliza.Detalle
            Else
                Return False
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function BuscarCuentasContables() As Boolean
        Try
            Dim Busqueda As New BusquedaCuentasContablesForm

            If Busqueda.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                If Busqueda.dgv.CurrentRow.Cells(3).Value = "NO" Then
                    MsgBox("La cuenta debe ser afectable", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
                Dim Cuentas() As String = Busqueda.dgv.CurrentRow.Cells(1).Value.ToString.Split("-")
                Dim _detalle As New PolizaModeloDetClass()

                _detalle.IdCuentaContable = Busqueda.dgv.CurrentRow.Cells(Busqueda.dgv.Columns.Count - 1).Value
                _detalle.Poliza = Poliza
                _detalle.Cta = Cuentas(0)
                _detalle.Subcta = Cuentas(1)
                _detalle.Ssubcta = Cuentas(2)
                _detalle.Sssubcta = Cuentas(3)

                dgvPrePolizaNacional.DataSource = Nothing
                Poliza.Detalle.Add(_detalle)
                dgvPrePolizaNacional.DataSource = Poliza.Detalle
            Else
                Return False
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region

#Region "Eventos"

#Region "Forma"
    Private Sub FrmPrePolizas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub
#End Region

#Region "GridPrePoliza"
    Private Sub dgvPrePolizaNacional_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvPrePolizaNacional.EditingControlShowing
        Dim CeldaActual As DataGridViewCell = dgvPrePolizaNacional.CurrentCell
        RemoveHandler e.Control.KeyPress, AddressOf ValidarNumericos
        RemoveHandler e.Control.KeyPress, AddressOf ValidarCA

        If CeldaActual.OwningColumn.Name <> "clmDescripcion" And CeldaActual.OwningColumn.Name <> "clmMovimiento" Then
            AddHandler e.Control.KeyPress, AddressOf ValidarNumericos
        Else
            CType(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
            AddHandler e.Control.KeyPress, AddressOf ValidarCA
        End If
    End Sub

    Private Sub dgvPrePolizaNacional_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dgvPrePolizaNacional.PreviewKeyDown
        If e.KeyCode = Keys.F3 Then
            dgvPrePolizaNacional.AllowUserToAddRows = True
            BuscarCuentasContables()
        ElseIf e.KeyCode = Keys.Delete Then
            Dim resultado As New Windows.Forms.DialogResult

            If Not dgvPrePolizaNacional.CurrentRow Is Nothing Then
                If dgvPrePolizaNacional.CurrentRow.Index <> dgvPrePolizaNacional.Rows.Count - 1 Then
                    resultado = _
                    MessageBox.Show("¿Seguro que quiere eliminarlo?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

                    If resultado = Windows.Forms.DialogResult.Yes Then
                        'noValidar = True
                        dgvPrePolizaNacional.Rows.RemoveAt(dgvPrePolizaNacional.CurrentRow.Index)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dgvPrePolizaNacional_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPrePolizaNacional.CellEndEdit
        If Not dgvPrePolizaNacional.Rows(e.RowIndex) Is Nothing And Not dgvPrePolizaNacional.Rows(e.RowIndex).IsNewRow And dgvPrePolizaNacional.IsCurrentRowDirty Then
            Me.dgvPrePolizaNacional.Refresh()
        End If
    End Sub

    Private Sub dgvPrePolizaNacional_RowValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvPrePolizaNacional.RowValidating
        If Not noValidar Then
            If Not dgvPrePolizaNacional.Rows(e.RowIndex) Is Nothing And Not dgvPrePolizaNacional.Rows(e.RowIndex).IsNewRow And dgvPrePolizaNacional.IsCurrentRowDirty Then
                If Not dgvPrePolizaNacional.ReadOnly Then
                    Dim FilaActual As DataGridViewRow = dgvPrePolizaNacional.Rows(e.RowIndex)

                    If Not FilaActual.Cells("clmDescripcion").Value Is Nothing Then
                        If (CType(FilaActual.Cells("clmDescripcion").Value, CuentaContableClass).NombreCuenta = String.Empty) Then
                            e.Cancel = True
                            MsgBox("La cuenta espeficicada no existe", MsgBoxStyle.Exclamation, "Aviso")
                        Else
                            For Each row As DataGridViewRow In dgvPrePolizaNacional.Rows
                                If row.Index <> FilaActual.Index Then
                                    If row.Cells("clmCta").Value = FilaActual.Cells("clmCta").Value _
                                    And row.Cells("clmSubcta").Value = FilaActual.Cells("clmSubcta").Value _
                                    And row.Cells("clmSsubcta").Value = FilaActual.Cells("clmSsubcta").Value _
                                    And row.Cells("clmSssubcta").Value = FilaActual.Cells("clmSssubcta").Value Then
                                        e.Cancel = True
                                        MsgBox("Ya existe la cuenta", MsgBoxStyle.Exclamation, "Aviso")
                                        Exit Sub
                                    End If
                                End If
                            Next

                            If FilaActual.Index <> dgvPrePolizaNacional.Rows.Count - 1 And FilaActual.Cells("clmAfectable").Value = False Then
                                e.Cancel = True
                                MsgBox("La cuenta debe ser afectable", MsgBoxStyle.Exclamation, "Aviso")
                            ElseIf FilaActual.Cells("clmMovimiento").Value = String.Empty Then
                                e.Cancel = True
                                MsgBox("Debe especificar el movimiento", MsgBoxStyle.Exclamation, "Aviso")
                            End If
                        End If
                    ElseIf FilaActual.Cells("clmDescripcion").Value Is Nothing Then
                        e.Cancel = True
                        MsgBox("La cuenta espeficicada no existe", MsgBoxStyle.Exclamation, "Aviso")
                    End If
                End If
            End If
        Else
            noValidar = False
        End If
    End Sub
#End Region

#Region "Menu"
    Private Sub mtb_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickNuevo
        Limpiar()
        HabilitarEdicion()
        lblEstatus.Text = "ACTIVO"
        Poliza = New PolizaModeloCabClass()
        dgvPrePolizaNacional.DataSource = Poliza.Detalle
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickGuardar
        noValidar = True
        Poliza.Descripcion = txtDescripcion.Text
        Poliza.Estatus = EstatusEnum.ACTIVO

        If ValidarGuardar() Then
            If dgvPrePolizaNacional.Rows.Count = Poliza.Detalle.Count Then
                Poliza.Detalle.RemoveAt(Poliza.Detalle.Count - 1)
            End If

            If Poliza.Guardar() Then
                MsgBox("Los datos se han guardado correctamente", MsgBoxStyle.Information, "PrePolizas")
                Limpiar()
                InhabilitarEdicion()
            Else
                Cancelar = True
            End If
        Else
            Cancelar = True
        End If
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Me.Close()
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickCancelar
        Limpiar()
        InhabilitarEdicion()
        lblEstatus.Text = "ESTATUS"
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        InhabilitarEdicion()
        Cancelar = Not Buscar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickEditar
        HabilitarEdicion()
    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBorrar
        If Not Poliza Is Nothing Then
            If Poliza.Borrar Then
                MsgBox("Los datos se han eliminado correctamente", MsgBoxStyle.Information, "PrePolizas")
                Limpiar()
            Else
                Cancelar = True
            End If
        End If
    End Sub
#End Region
#End Region
End Class