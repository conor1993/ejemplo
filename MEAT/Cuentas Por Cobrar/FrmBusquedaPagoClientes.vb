Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = Integralab.ORM.TypedViewClasses
Imports CC = Integralab.ORM.CollectionClasses

Public Class FrmBusquedaPagoClientes

    Private Sub FrmBusquedaPagoClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim Cli As New CN.ClientesIntroductoresClass
            Cli.Nombre = "TODOS"
            Dim ClientesCol As New CN.ClientesIntroductoresColeccion
            ClientesCol.Add(Cli)

            Dim ColeccionClie As New CN.ClientesIntroductoresColeccion
            ColeccionClie.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)
            For Each Clie As CN.ClientesIntroductoresClass In ColeccionClie
                ClientesCol.Add(Clie)
            Next

            Me.CmbClientes.ValueMember = "Codigo"
            Me.CmbClientes.DisplayMember = "Nombre"
            Me.CmbClientes.DataSource = ClientesCol
            Me.dgvPagos.AutoGenerateColumns = False
            Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Limpiar()
        Me.CmbClientes.SelectedIndex = -1
        Me.txtNoPago.Text = ""
        Me.DgvFacturas.DataSource = Nothing
        Me.RbtnTodos.Checked = True
        Me.ChkFechas.Checked = False
    End Sub

    Private Function ValidarFechas() As Boolean
        If Me.DtPFechaini.Value > Me.DtpFechaFin.Value Then
            MessageBox.Show("La Fecha Inicial debe ser mayor o igual a la Fecha Final", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        Return True
    End Function

    Private Sub Buscar()
        Cursor = Cursors.WaitCursor
        Try
            Dim a As String = HC.DbUtils.ActualConnectionString
            Dim PagosClientesCabacero As New TC.VwPagoClientesCabeceroTypedView
            Dim dtPagosClientesDetalle As DataTable
            Dim FiltroPagosClientesCabacero As New OC.PredicateExpression

            If Me.CmbClientes.SelectedIndex > 0 Then
                FiltroPagosClientesCabacero.Add(HC.VwPagoClientesCabeceroFields.CveCliente = Me.CmbClientes.SelectedValue)
            End If

            If Not Me.txtNoPago.Text = "" Then
                FiltroPagosClientesCabacero.Add(HC.VwPagoClientesCabeceroFields.FolIngreso Mod String.Format("%{0}%", Me.txtNoPago.Text))
            End If

            If Me.ChkFechas.Checked Then
                If ValidarFechas() Then
                    FiltroPagosClientesCabacero.Add(New OC.FieldBetweenPredicate(HC.VwPagoClientesCabeceroFields.FecIngreso, Me.DtPFechaini.Value.ToShortDateString, Me.DtpFechaFin.Value.AddDays(1).ToShortDateString))
                Else
                    Cursor = Cursors.Arrow
                    Exit Sub
                End If
            End If

            If Not Me.txtNoFactura.Text.Trim = String.Empty Or Me.RbtnVigentes.Checked Or Me.RbtnCancelados.Checked Then
                Dim FiltroPagosDetalle As New OC.PredicateExpression

                If Not Me.txtNoFactura.Text.Trim = String.Empty Then
                    FiltroPagosDetalle.Add(HC.PagoDeCtesFields.FolFactura Mod String.Format("%{0}%", txtNoFactura.Text.Trim))
                End If

                If Me.RbtnVigentes.Checked Then
                    FiltroPagosDetalle.Add(HC.PagoDeCtesFields.Estatus = "V")
                ElseIf Me.RbtnCancelados.Checked Then
                    FiltroPagosDetalle.Add(HC.PagoDeCtesFields.Estatus = "C")
                End If

                If Me.CmbClientes.SelectedIndex > 0 Then
                    FiltroPagosDetalle.Add(HC.PagoDeCtesFields.CveCliente = CmbClientes.SelectedValue)
                End If

                If Not Me.txtNoPago.Text = "" Then
                    FiltroPagosDetalle.Add(HC.PagoDeCtesFields.FolIngreso Mod String.Format("%{0}%", Me.txtNoPago.Text))
                End If

                If Me.ChkFechas.Checked Then
                    If ValidarFechas() Then
                        FiltroPagosDetalle.Add(New OC.FieldBetweenPredicate(HC.PagoDeCtesFields.FecIngreso, Me.DtPFechaini.Value.ToShortDateString, Me.DtpFechaFin.Value.AddDays(1).ToShortDateString))
                    Else
                        Cursor = Cursors.Arrow
                        Exit Sub
                    End If
                End If
                Dim Lista As New List(Of String)
                dtPagosClientesDetalle = CC.PagoDeCtesCollection.GetMultiAsDataTable(FiltroPagosDetalle, 0, Nothing)

                For Each Renglon As DataRow In dtPagosClientesDetalle.Rows
                    If Not Lista.Contains(Renglon.Item("FolIngreso")) Then
                        Lista.Add(Renglon.Item("FolIngreso"))
                    End If
                Next

                If Lista.Count > 2000 Then
                    MsgBox("Por favor sea mas especifico en la busqueda ya que la consulta podria tardar demasiado", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                    Cursor = Cursors.Arrow
                    Exit Sub
                End If

                If Lista.Count > 0 Then
                    FiltroPagosClientesCabacero.Add(New OC.FieldCompareRangePredicate(HC.VwPagoClientesCabeceroFields.FolIngreso, Lista))
                Else
                    dgvPagos.DataSource = Nothing
                    Cursor = Cursors.Arrow
                    Exit Sub
                End If
            End If
            PagosClientesCabacero.Fill(0, New OC.SortExpression(New OC.SortClause(HC.VwPagoClientesCabeceroFields.FecIngreso, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending)), False, FiltroPagosClientesCabacero)
            dgvPagos.DataSource = PagosClientesCabacero
            Me.DgvFacturas.DataSource = Nothing
            Cursor = Cursors.Arrow
        Catch ex As Exception
            Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Buscar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub ChkFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkFechas.CheckedChanged
        If ChkFechas.Checked Then
            Me.DtPFechaini.Enabled = True
            Me.DtpFechaFin.Enabled = True
        Else
            Me.DtPFechaini.Enabled = False
            Me.DtpFechaFin.Enabled = False
        End If
    End Sub

    Private Sub BrnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BrnAceptar.Click
        If Me.dgvPagos.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dgvPagos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvPagos.Click
        Try
            If Me.dgvPagos.SelectedRows.Count > 0 Then
                Dim IdCliente As Integer
                Dim FolioPago As String
                IdCliente = Me.dgvPagos.SelectedRows(0).Cells(Me.clmIdCliente.Index).Value
                FolioPago = Me.dgvPagos.SelectedRows(0).Cells(Me.clmFolioIngreso.Index).Value
                Me.PagosDeClientesC.Obtener(IdCliente, FolioPago)

                Me.DgvFacturas.AutoGenerateColumns = False
                Me.DgvFacturas.DataSource = Me.PagosDeClientesC
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgvPagos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvPagos.DoubleClick
        If Me.dgvPagos.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub dgvPagos_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPagos.RowEnter
        Try
            If Me.dgvPagos.SelectedRows.Count > 0 Then
                Dim IdCliente As Integer
                Dim FolioPago As String
                IdCliente = Me.dgvPagos.SelectedRows(0).Cells(Me.clmIdCliente.Index).Value
                FolioPago = Me.dgvPagos.SelectedRows(0).Cells(Me.clmFolioIngreso.Index).Value
                Me.PagosDeClientesC.Obtener(IdCliente, FolioPago)

                Me.DgvFacturas.AutoGenerateColumns = False
                Me.DgvFacturas.DataSource = Me.PagosDeClientesC
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtNoFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoFactura.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            CmbClientes.Focus()
        End If
    End Sub

    Private Sub txtNoPago_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoPago.TextChanged
        Try
            Buscar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class