Imports CN = ClasesNegocio
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class FrmABCdeEstadosFinancieros
    Dim Balance As CN.CabBalanceClass
    Private Sub FrmABCdeEstadosFinancieros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Icon = MdiParent.Icon
            Me.lblEmpresa.Text = Controlador.Sesion.MiEmpresa.Empnom

            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            MtbEstados.StateBuscar = "110101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "110100011"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010011"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            mtb.ToolBarButtonStatus = MtbEstados
            Me.mtb.Buttons(0).ToolTipText = "Busca los Registros de Estados Financieros Registrados"
            Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
            Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
            Me.mtb.Buttons(5).ToolTipText = "Crea un nuevo Registro de Estados Financieros."
            Me.mtb.Buttons(6).ToolTipText = "Guarda el Registro de Estados Financieros o los cambios que se le hayan Realizado."
            'Me.mtb.Buttons(7).ToolTipText = "Cambia el estatus del Banco."
            'Me.mtb.Buttons(8).ToolTipText = "Permite Modificar el Banco."
            Me.mtb.Buttons(10).ToolTipText = "Imprime Los resgistros de Estados Financieros Registrados."
            Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."

            mtb.sbCambiarEstadoBotones("Cancelar")

            cmbCategoria.ValueMember = "Código"
            cmbCategoria.DisplayMember = "Descripcion"
            cmbCategoria.DataSource = CN.CatAgrupadoresBalGralEdoResCollectionClass.CargarAgrupadoresBalanceGral(HC.CatAgrupadoresBalGralEdoResFields.BalanceGral = True)
            DesHabilitar()
            Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Metodos"

    Private Sub Limpiar()
        Me.txtIdRubro.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtSaldo.Text = 0D
        Me.cmbCategoria.SelectedIndex = -1
        Me.cmbCategoria.Text = "Seleccione la Categoría"
        Me.grid.DataSource = Nothing
    End Sub

    Private Sub Habilitar()
        Me.txtDescripcion.Enabled = True
        Me.txtIdRubro.Enabled = True
        Me.txtSaldo.Enabled = True
        Me.grid.Enabled = True
        Me.cmbCategoria.Enabled = True
    End Sub

    Private Sub DesHabilitar()
        Me.txtDescripcion.Enabled = False
        Me.txtIdRubro.Enabled = False
        Me.txtSaldo.Enabled = False
        Me.grid.Enabled = False
        Me.cmbCategoria.Enabled = False
    End Sub

    Private Sub Sumar()
        Dim Total As Decimal = 0D
        For i As Integer = 0 To Me.grid.Rows.Count - 1
            Total += grid.Rows(i).Cells(Me.clmSaldo.Index).Value
        Next
        Me.txtSaldo.Text = Total.ToString("C2")
    End Sub

    Private Function Validar() As Boolean
        Try
            If Me.txtIdRubro.Text = "" Then
                MessageBox.Show("Ingrese el Rubro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtIdRubro.Focus()
                Return False
            End If

            If Me.txtDescripcion.Text = "" Then
                MsgBox("Ingrese la Descripción", MsgBoxStyle.Exclamation, "Aviso")
                Me.txtDescripcion.Focus()
                Return False
            End If

            If Balance.Detalles.Count < 1 Then
                MsgBox("Ingrese el detalle del Balance", MsgBoxStyle.Exclamation, "Aviso")
                Me.grid.Focus()
                Return False
            End If

            If cmbCategoria.SelectedValue Is Nothing Then
                MsgBox("Debe especificar la categoria a la que pertenece", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            Dim Coleccion As New CC.CabBalanceCollection

            If Balance.Entidad.IsNew Then
                Coleccion.GetMulti(HC.CabBalanceFields.CveBalance = txtIdRubro.Text)

                If Coleccion.Count > 0 Then
                    MsgBox("Ya existe un balance con ese rubro", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                    Return False
                End If
            ElseIf Not Balance.Entidad.IsNew Then
                Coleccion.GetMulti(HC.CabBalanceFields.CveBalance = txtIdRubro.Text And HC.CabBalanceFields.CveBalance <> Balance.IdBalance)

                If Coleccion.Count > 0 Then
                    MsgBox("Ya existe un balance con ese rubro", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                    Return False
                End If
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
#End Region

#Region "Toolbar"
    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim Ventana As New FrmBusqBalance
            Ventana.Icon = Me.Icon
            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Balance = DirectCast(Ventana.dgvCab.SelectedRows(0).DataBoundItem, CN.CabBalanceClass)
                Me.txtIdRubro.Text = Balance.IdBalance
                Me.txtDescripcion.Text = Balance.Nombre
                Me.txtSaldo.Text = Balance.Saldo
                cmbCategoria.DataSource = CN.CatAgrupadoresBalGralEdoResCollectionClass.CargarAgrupadoresBalanceGral(HC.CatAgrupadoresBalGralEdoResFields.BalanceGral = True)
                Me.cmbCategoria.SelectedValue = Balance.IdAgrupador
                Me.grid.AutoGenerateColumns = False
                Me.grid.DataSource = Balance.Detalles
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        DesHabilitar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Habilitar()
        Me.txtIdRubro.Enabled = False
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Guardar")
        Try
            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            Balance.IdBalance = Me.txtIdRubro.Text
            Balance.Nombre = Me.txtDescripcion.Text
            Balance.Saldo = Me.txtSaldo.Text.Replace("$", "")
            Balance.IdAgrupador = cmbCategoria.SelectedValue

            For i As Integer = 0 To Balance.Detalles.Count - 1
                Balance.Detalles(i).IdRenglon = i + 1
                Balance.Detalles(i).Balance = Balance
            Next

            If Not Balance.Guardar(Trans) Then
                Trans.Rollback()
                Cancelar = True
                Exit Sub
            End If

            Trans.Commit()
            MessageBox.Show("Datos del Balance Guardados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DesHabilitar()
            Limpiar()
        Catch ex As Exception
            Cancelar = True
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Habilitar()
        Balance = New CN.CabBalanceClass
        Me.grid.AutoGenerateColumns = False
        Me.grid.DataSource = Balance.Detalles
        Me.txtIdRubro.Focus()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region

    Private Sub grid_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellEndEdit
        If e.ColumnIndex = Me.clmSaldo.Index Then
            Sumar()
        End If
    End Sub

    Private Sub grid_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grid.DataError

    End Sub

    Private Sub grid_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles grid.EditingControlShowing
        If Me.grid.CurrentCell.ColumnIndex = Me.clmSumaResta.Index Then
            RemoveHandler e.Control.KeyPress, AddressOf SumaResta
            AddHandler e.Control.KeyPress, AddressOf SumaResta
        Else
            RemoveHandler e.Control.KeyPress, AddressOf SumaResta
        End If
    End Sub

    Private Sub SumaResta(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Try
            If Not e.KeyChar = "+"c And Not e.KeyChar = Chr(8) AndAlso Not e.KeyChar = "-"c Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub grid_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles grid.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F3 Then
                Dim Ventana As New BusquedaCuentasContablesForm

                Ventana.AfectableDefault(True) = ClasesNegocio.CondicionAsignadaEnum.SI
                Ventana.InactivaDefault(True) = ClasesNegocio.CondicionAsignadaEnum.NO

                If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim BalanceDet As New CN.DetBalanceClass
                    Me.grid.DataSource = Nothing

                    BalanceDet.Cuenta = Ventana.CuentaContable
                    Balance.Detalles.Add(BalanceDet)
                    Me.grid.DataSource = Balance.Detalles
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub grid_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles grid.UserDeletedRow
        Sumar()
    End Sub

    Private Sub txtIdRubro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdRubro.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtIdRubro_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdRubro.Leave
        txtIdRubro.Text = txtIdRubro.Text.PadLeft(3, "0")
    End Sub
End Class