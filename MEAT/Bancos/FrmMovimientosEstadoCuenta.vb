Imports HC = Integralab.ORM.HelperClasses

Public Class FrmMovimientosEstadoCuenta

    Dim CuentasC As New ClasesNegocio.CuentaCollectionClass
    Dim Cuenta As New ClasesNegocio.CuentaClass
    Dim MovEstadoCuenta As New ClasesNegocio.MovimientosEstadosCuentaCollectionClass
    Dim Modificando As Boolean = False

    Private Sub FrmMovimientosEstadoCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            MtbEstados.StateBuscar = "010100101"
            MtbEstados.StateLimpiar = "000000001"
            MtbEstados.StateCancelar = ""
            MtbEstados.StateNuevo = "010110101"
            MtbEstados.StateGuardar = ""
            MtbEstados.StateBorrar = ""
            MtbEstados.StateEditar = "010110101"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = MtbEstados
            Me.mtb.sbCambiarEstadoBotones("Limpiar")

            BancosC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Limpiar()
            Me.dgvMovEstadoCuenta.AutoGenerateColumns = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            If Me.cmbCuenta.SelectedIndex > -1 Then
                MovEstadoCuenta.Obtener(Cuenta.Codigo)
                Me.dgvMovEstadoCuenta.DataSource = MovEstadoCuenta
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        If Me.dgvMovEstadoCuenta.Rows.Count > 0 Then
            For i As Integer = 0 To Me.dgvMovEstadoCuenta.Rows.Count - 1
                If Me.dgvMovEstadoCuenta.Rows(i).Index = Me.dgvMovEstadoCuenta.CurrentRow.Index Then
                    Me.dgvMovEstadoCuenta.CurrentRow.ReadOnly = False
                    Me.dgvMovEstadoCuenta.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
                Else
                    Me.dgvMovEstadoCuenta.Rows(i).ReadOnly = True
                    Me.dgvMovEstadoCuenta.Rows(i).DefaultCellStyle.BackColor = Color.White
                End If
            Next
        End If
        Me.mtb.sbCambiarEstadoBotones("Editar")
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Movimientos de Estados de Cuenta")
        Try
            MsgBox("Desea Guardar los cambios", MsgBoxStyle.OkCancel)
            trans.Add(MovEstadoCuenta.ObtenerColeccion)
            If MovEstadoCuenta.ObtenerColeccion.SaveMulti() > 0 Then
                trans.Commit()
                MsgBox("Se han guardado los cambios", MsgBoxStyle.Information)
            End If
            Limpiar()
            Me.mtb.sbCambiarEstadoBotones("Limpiar")
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Me.dgvMovEstadoCuenta.AllowUserToAddRows = True
        For i As Integer = 0 To Me.dgvMovEstadoCuenta.Rows.Count - 1
            If Me.dgvMovEstadoCuenta.Rows(i).IsNewRow Then
                Me.dgvMovEstadoCuenta.Rows(i).Selected = True
                Me.dgvMovEstadoCuenta.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
                Me.dgvMovEstadoCuenta.Rows(i).Cells(Me.clmFecha.Index).Value = Now.Date
            Else
                Me.dgvMovEstadoCuenta.Rows(i).Selected = False
            End If
        Next
        Me.mtb.sbCambiarEstadoBotones("Nuevo")
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub cmbBanco_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBanco.SelectedIndexChanged
        If Me.cmbBanco.SelectedIndex > -1 Then
            Dim Banco As ClasesNegocio.BancosClass = DirectCast(cmbBanco.SelectedItem, ClasesNegocio.BancosClass)
            CuentasC.Obtener(Banco.Codigo, ClasesNegocio.EstatusEnum.ACTIVO)
            Me.cmbCuenta.DataSource = CuentasC
            Me.cmbCuenta.SelectedIndex = -1
            Me.cmbCuenta.Text = "Seleccione una Cuenta..."
            Me.dgvMovEstadoCuenta.DataSource = Nothing
            Me.mtb.sbCambiarEstadoBotones("Limpiar")
        End If
    End Sub

    Private Sub cmbCuenta_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCuenta.SelectedIndexChanged
        If Me.cmbCuenta.SelectedIndex > -1 Then
            Cuenta = DirectCast(Me.cmbCuenta.SelectedItem, ClasesNegocio.CuentaClass)
            MovEstadoCuenta.Obtener(Cuenta.Codigo)
            Me.dgvMovEstadoCuenta.DataSource = MovEstadoCuenta
            For i As Integer = 0 To Me.dgvMovEstadoCuenta.Rows.Count - 1
                Me.dgvMovEstadoCuenta.Rows(i).ReadOnly = True
            Next
            Me.mtb.sbCambiarEstadoBotones("Buscar")
        End If
    End Sub

    Private Sub Limpiar()
        Me.cmbBanco.SelectedIndex = -1
        Me.cmbBanco.Text = "Seleccione un Banco..."
        Me.cmbCuenta.DataSource = Nothing
        Me.dgvMovEstadoCuenta.DataSource = Nothing
        Me.dgvMovEstadoCuenta.AllowUserToAddRows = False
    End Sub

    Private Sub dgvMovEstadoCuenta_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMovEstadoCuenta.CellClick
        If e.ColumnIndex = clmFecha.Index Then
            If CDate(Me.dgvMovEstadoCuenta.CurrentRow.Cells(Me.clmFecha.Index).Value) = (New Date) Then
                Me.dgvMovEstadoCuenta.CurrentRow.Cells(Me.clmFecha.Index).Value = Now.Date
            End If
        End If
    End Sub

    Private Sub dgvMovEstadoCuenta_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMovEstadoCuenta.CellLeave
        Me.dgvMovEstadoCuenta.CurrentRow.Cells(Me.clmIdCuenta.Index).Value = Cuenta.Codigo
    End Sub

    Private Sub dgvMovEstadoCuenta_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMovEstadoCuenta.CellValueChanged
        If Not Me.dgvMovEstadoCuenta.DataSource Is Nothing Then
            If e.ColumnIndex = Me.clmTipoMov.Index Then
                Me.Validate()
                If Not Me.dgvMovEstadoCuenta.CurrentRow.Cells(Me.clmTipoMov.Index).Value.ToString.ToUpper = "D" AndAlso Not Me.dgvMovEstadoCuenta.CurrentRow.Cells(Me.clmTipoMov.Index).Value.ToString.ToUpper = "R" Then
                    Me.dgvMovEstadoCuenta.Rows(e.RowIndex).Cells(Me.clmTipoMov.Index).Value = ""
                Else
                    If CStr(Me.dgvMovEstadoCuenta.CurrentRow.Cells(Me.clmTipoMov.Index).Value) = "d" Then
                        Me.dgvMovEstadoCuenta.CurrentRow.Cells(Me.clmTipoMov.Index).Value = "D"
                    End If
                    If CStr(Me.dgvMovEstadoCuenta.CurrentRow.Cells(Me.clmTipoMov.Index).Value) = "r" Then
                        Me.dgvMovEstadoCuenta.CurrentRow.Cells(Me.clmTipoMov.Index).Value = "R"
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dgvMovEstadoCuenta_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvMovEstadoCuenta.DataError

    End Sub

End Class