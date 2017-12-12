Imports ClasesNegocio
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Text

Public Class FrmNotaCredito
    Dim Nota As NotaCreditoCabClass
    Dim Clientes As CC.MfacCatClientesCollection
    Dim Conceptos As CC.CatTipNotasCollection
    Dim Estado As FormState

    Private Sub FrmNotaCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Utilerias.RunControlException(Me, "InicializarForma")
    End Sub

#Region "Metodos"

    Public Sub InicializarForma()
        Dim tbestados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        tbestados.StateBuscar = "001001011"
        tbestados.StateLimpiar = ""
        tbestados.StateCancelar = "100100001"
        tbestados.StateNuevo = "011010001"
        tbestados.StateGuardar = tbestados.StateCancelar
        tbestados.StateBorrar = tbestados.StateCancelar
        tbestados.StateImprimir = ""
        tbestados.StateSalir = ""

        Me.mtb.ToolBarButtonStatus = tbestados
        Me.mtb.sbCambiarEstadoBotones("Cancelar")

        Clientes = New CC.MfacCatClientesCollection
        Clientes.GetMulti(HC.MfacCatClientesFields.Estatus = 1, 0, New OC.SortExpression(New OC.SortClause(HC.MfacCatClientesFields.Nombre, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
        Me.CmbCliente.ValueMember = "IdCliente"
        Me.CmbCliente.DisplayMember = "Nombre"
        Me.CmbCliente.DataSource = Clientes

        Conceptos = New CC.CatTipNotasCollection
        Conceptos.GetMulti(Nothing)
        Me.cmbConcepto.ValueMember = "CveTipNota"
        Me.cmbConcepto.DisplayMember = "NomTipNota"
        Me.cmbConcepto.DataSource = Conceptos

        dgvFacturas.AutoGenerateColumns = False
        Limpiar()
        DesHabilitar()
    End Sub

    Private Sub Habilitar()
        Me.CmbCliente.Enabled = True
        Me.cmbConcepto.Enabled = True
        Me.txtAutorizo.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.txtFolio.Enabled = True
    End Sub

    Private Sub DesHabilitar()
        Me.CmbCliente.Enabled = False
        Me.cmbConcepto.Enabled = False
        Me.txtAutorizo.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.txtFolio.Enabled = False
    End Sub

    Private Sub GridModo(ByVal Nuevo As Boolean)
        If Nuevo = True Then
            clmChecado.Visible = True
            clmFechaFactura.HeaderText = "Fecha"
            clmFechaFactura.DataPropertyName = "FechaFactura"
            clmEstatus.DataPropertyName = "Estatus"
            clmEstatus.Width = 70
            clmTotalFactura.ValueType = GetType(Decimal)
            clmTotalFactura.HeaderText = "Total Fact."
            clmTotalFactura.DataPropertyName = "Total"
            clmTotalNotas.Visible = True
            clmSaldo.Visible = True
            clmImporte.DataPropertyName = ""
            clmImporte.ReadOnly = False
            clmIva.DataPropertyName = ""
            clmIva.ReadOnly = False
            clmTotal.DataPropertyName = ""
            clmTotal.ReadOnly = False
        Else
            clmChecado.Visible = False
            clmFechaFactura.ValueType = GetType(Date)
            clmFechaFactura.HeaderText = "Fecha de Aplicacion"
            clmFechaFactura.DataPropertyName = "FecAplica"
            clmEstatus.DataPropertyName = "EstatusDescripcion"
            clmEstatus.Width = 100
            clmTotalFactura.ValueType = GetType(String)
            clmTotalFactura.HeaderText = "Folio de Pago"
            clmTotalFactura.DataPropertyName = "FolPago"
            clmTotalNotas.Visible = False
            clmSaldo.Visible = False
            clmImporte.DataPropertyName = "SubTotal"
            clmImporte.ReadOnly = True
            clmIva.DataPropertyName = "ImpteIVA"
            clmIva.ReadOnly = True
            clmTotal.DataPropertyName = "Total"
            clmTotal.ReadOnly = True
        End If
    End Sub

    Private Sub Validar()
        Dim Mensaje As New StringBuilder()

        Me.Validate()

        If Not Me.CmbCliente.SelectedIndex > -1 Then
            Mensaje.AppendLine("Cliente")
        End If

        If Not Me.cmbConcepto.SelectedIndex > -1 Then
            Me.cmbConcepto.SelectedIndex = -1
            Mensaje.AppendLine("Concepto")
        End If

        If Me.txtAutorizo.Text.Trim = String.Empty Then
            Mensaje.AppendLine("Autorizó")
        End If

        Dim Seleccion As Boolean = False

        For Each Renglon As DataGridViewRow In dgvFacturas.Rows
            If Renglon.Cells(clmChecado.Index).Value Then
                Seleccion = True

                If Not ValidarRenglon(Renglon.Index) Then
                    Renglon.Selected = True
                    Throw New BusinessException(CategoriaEnumException.DESCONOCIDO, ModuloEnum.NOTAS_DE_CREDITO, 0, "Datos invalidos, porfavor verifique las cantidades.")
                End If
            End If
        Next

        If Not Seleccion Then
            Mensaje.AppendLine("Seleccion de Facturas")
        End If

        If Mensaje.ToString() <> String.Empty Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.NOTAS_DE_CREDITO, 1, Mensaje.ToString)
        End If
    End Sub

    Private Function ValidarRenglon(ByVal RowIndex As Integer) As Boolean
        If dgvFacturas.Rows(RowIndex).Cells(clmChecado.Index).Value Then
            Dim NotasAnteriores As Decimal = 0D
            Dim SaldoFactura As Decimal = dgvFacturas.Rows(RowIndex).Cells(clmSaldo.Index).Value
            Dim TotalNotaDetalle As Decimal = 0D

            If IsNumeric(dgvFacturas.Rows(RowIndex).Cells(clmTotalNotas.Index).Value) Then
                NotasAnteriores = dgvFacturas.Rows(RowIndex).Cells(clmTotalNotas.Index).Value
            End If

            If IsNumeric(dgvFacturas.Rows(RowIndex).Cells(clmTotal.Index).Value) Then
                TotalNotaDetalle = Decimal.Parse(dgvFacturas.Rows(RowIndex).Cells(clmTotal.Index).Value)
            End If

            If TotalNotaDetalle > SaldoFactura - NotasAnteriores Then
                Return False
            End If
            Return True
        Else
            Return True
        End If
    End Function

    Public Sub EstablecerValores()
        Dim FolNota As String
        Dim ValorMaximo As Object

        Nota.IdCliente = Integer.Parse(CmbCliente.SelectedValue)
        Nota.FechaNota = DtpFecha.Value
        Nota.IdConcepto = Integer.Parse(cmbConcepto.SelectedValue)
        Nota.Elaboro = txtElaboro.Text.Trim
        Nota.Autorizo = txtAutorizo.Text.Trim
        Nota.Observaciones = txtObservaciones.Text.Trim
        Nota.Estatus = 1

        If Me.Estado = FormState.Nuevo Or Me.Estado = FormState.Guardar Or Me.Estado = FormState.Limpiar Then
            Dim Coleccion As New CC.NotaCreditoCabCollection
            ValorMaximo = Coleccion.GetScalar(IntegraLab.ORM.NotaCreditoCabFieldIndex.FolNota, SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.Max)

            If Not IsDBNull(ValorMaximo) Then
                FolNota = "N" & (Integer.Parse(ValorMaximo.ToString().Replace("N", "")) + 1).ToString().PadLeft(7, "0")
            Else
                FolNota = "N0000001"
            End If
            Nota.FolNota = FolNota

            Nota.Detalle.Clear()
            For Each Renglon As DataGridViewRow In dgvFacturas.Rows
                If Renglon.Cells(clmChecado.Index).Value Then
                    Dim Iva As Decimal = Decimal.Parse(Renglon.Cells(clmIva.Index).Value)
                    Dim Importe As Decimal = Decimal.Parse(Renglon.Cells(clmImporte.Index).Value)
                    Dim Total As Decimal = Decimal.Parse(Renglon.Cells(clmTotal.Index).Value)
                    Dim NoFactura As String = Renglon.Cells(clmFactura.Index).Value.ToString().Trim()
                    Dim DetalleNotaCredito As New EC.NotaCreditoDetEntity()

                    DetalleNotaCredito.FolNota = FolNota
                    DetalleNotaCredito.FolFactura = NoFactura
                    DetalleNotaCredito.SubTotal = Importe
                    DetalleNotaCredito.ImpteIva = Iva
                    DetalleNotaCredito.Total = Total
                    DetalleNotaCredito.Estatus = NotaCreditoEnum.VIGENTE
                    DetalleNotaCredito.Cheque = String.Empty
                    DetalleNotaCredito.OrigenCta = String.Empty
                    DetalleNotaCredito.Aplicar = False
                    DetalleNotaCredito.FolPago = String.Empty
                    Nota.Detalle.Add(DetalleNotaCredito)
                End If
            Next
        End If
    End Sub

#Region "Acciones_Menu"

    Public Function Borrar(ByVal Trans As HC.Transaction) As Boolean
        Estado = FormState.Borrar

        If MsgBox("Va a cancelar esta nota de credito, ¿Esta seguro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Controlador.Sesion.MiEmpresa.Empnom) = MsgBoxResult.Yes Then
            Nota.Cancelar(Trans, txtObservaciones.Text.Trim)
            Trans.Commit()
            MessageBox.Show("La operacion ha terminado satisfactoriamente", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Limpiar()
            Return True
        End If
    End Function

    Public Function Buscar() As Boolean
        Dim Busqueda As New FrmBusquedaNotaCredito()
        Dim ColeccionDetalle As New System.ComponentModel.BindingList(Of NotaCreditoDetClass)
        Estado = FormState.Buscar

        If Busqueda.ShowDialog() = Windows.Forms.DialogResult.OK Then
            GridModo(False)
            Nota = CType(Busqueda.DgvNotas.SelectedRows(0).DataBoundItem, NotaCreditoCabClass)
            txtFolio.Text = Nota.FolNota
            DtpFecha.Value = Nota.FechaNota
            CmbCliente.SelectedValue = Nota.IdCliente
            cmbConcepto.SelectedValue = Nota.IdConcepto
            txtElaboro.Text = Nota.Elaboro
            txtAutorizo.Text = Nota.Autorizo
            txtObservaciones.Text = Nota.Observaciones
            txtTotal.Text = Nota.Total
            lblEstatus.Visible = True
            lblEstatus.Text = Nota.EstatusDescripcion.ToString().Replace("_", " ")

            For Each detalleNota As EC.NotaCreditoDetEntity In Nota.Detalle
                ColeccionDetalle.Add(New NotaCreditoDetClass(detalleNota))
            Next
            dgvFacturas.DataSource = ColeccionDetalle
            Return True
        End If
    End Function

    Public Function Cancelar() As Boolean
        Estado = FormState.Cancelar
        Limpiar()
        DesHabilitar()
        Return True
    End Function

    Public Function Editar() As Boolean

        Return True
    End Function

    Public Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        Estado = FormState.Guardar
        Validar()
        EstablecerValores()
        Nota.Guardar(Trans)
        Trans.Commit()
        'Imprimir(NotasCredito)
        MessageBox.Show("Se ha generado la nota con el folio: " & Nota.FolNota, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Limpiar()
        DesHabilitar()
        Return True
    End Function

    Private Function Limpiar() As Boolean
        Estado = FormState.Limpiar
        Me.txtFolio.Text = ""
        Me.txtObservaciones.Text = ""
        Me.txtTotal.Text = 0.0
        Me.CmbCliente.SelectedIndex = -1
        Me.cmbConcepto.SelectedIndex = -1
        Me.lblEstatus.Visible = False
        Me.DtpFecha.Value = Now
        Me.txtElaboro.Text = ""
        Me.txtAutorizo.Text = ""
        Me.dgvFacturas.DataSource = Nothing
        Return True
    End Function

    Public Function Nuevo() As Boolean
        Estado = FormState.Nuevo
        GridModo(True)
        Nota = New NotaCreditoCabClass
        clmFechaFactura.DataPropertyName = "FechaFactura"
        Me.txtFolio.Focus()
        Limpiar()
        Habilitar()
        Me.txtElaboro.Text = Controlador.Sesion.MiUsuario.Usrnomcom
        Return True
    End Function

    Public Function Salir() As Boolean
        Me.Estado = FormState.Salir
        Close()
        Return True
    End Function

    Public Function Imprimir() As Boolean
        Nota.Imprimir(Controlador.Sesion)
        Return True
    End Function
#End Region

#End Region

    Private Sub Acciones_Menu(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar, mtb.ClickBuscar, mtb.ClickCancelar, mtb.ClickEditar, mtb.ClickGuardar, mtb.ClickImprimir, mtb.ClickLimpiar, mtb.ClickNuevo, mtb.ClickSalir
        Dim Resultado As Object = Nothing

        Select Case e.Button.Text
            Case "Borrar", "Guardar"
                Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Cancelar Nota de Credito")

                If Utilerias.RunControlException(Me, e.Button.Text, New Object() {Trans}) Is Nothing Then
                    Trans.Rollback()
                    Resultado = False
                Else
                    Resultado = True
                End If
                'Case "Guardar"
                '    Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Generarcion de Notas de Credito")

                '    If Utilerias.RunControlException(Me, e.Button.Text, New Object() {Trans}) Is Nothing Then
                '        Trans.Rollback()
                '        Resultado = False
                '    Else
                '        Resultado = True
                '    End If
            Case Else
                Resultado = Utilerias.RunControlException(Me, e.Button.Text)
        End Select

        If Resultado Is Nothing OrElse Not Resultado Then
            Cancelar = True
        End If
    End Sub

    Private Sub DgvNotas_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

    End Sub

    Private Sub CmbCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbCliente.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmbConcepto.Focus()
        End If
    End Sub

    Private Sub cmbConcepto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbConcepto.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtAutorizo.Focus()
        End If
    End Sub

    Private Sub txtAutorizo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAutorizo.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtObservaciones.Focus()
        End If
    End Sub

    Private Sub txtObservaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtObservaciones.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.mtb.Focus()
        End If
    End Sub

    Private Sub CmbCliente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCliente.SelectedIndexChanged
        Try
            If Estado = FormState.Nuevo Or Estado = FormState.Guardar Or Estado = FormState.Limpiar Then
                Dim Filtro As New OC.PredicateExpression(HC.FacturasClientesCabFields.IdClienteCargo = Me.CmbCliente.SelectedValue And (HC.FacturasClientesCabFields.Estatus = "V" Or HC.FacturasClientesCabFields.Estatus = "A"))
                Dim dtFacturas As DataTable = CC.FacturasClientesCabCollection.GetMultiAsDataTable(Filtro, 0, Nothing)
                dtFacturas.Columns.Add("Seleccionado", GetType(Boolean))
                dtFacturas.Columns.Add("Saldo", GetType(Decimal))
                dtFacturas.Columns.Add("NotasAnteriores", GetType(Decimal))
                dtFacturas.Columns("NoFactura").ColumnName = "FolFactura"

                If dtFacturas.Rows.Count > 0 Then
                    Me.dgvFacturas.DataSource = dtFacturas
                    'sacar(saldos)
                    For i As Integer = 0 To Me.dgvFacturas.RowCount - 1
                        Dim ImporteIngreso As Decimal = 0D
                        Dim ImporteNotas As Decimal = 0D
                        Dim dtPagos As DataTable = CC.PagoDeCtesCollection.GetMultiAsDataTable(HC.PagoDeCtesFields.FolFactura = Me.dgvFacturas.Rows(i).Cells(Me.clmFactura.Index).Value And HC.PagoDeCtesFields.Estatus = "v", 0, Nothing)
                        Dim dtNotas As DataTable = CC.NotaCreditoDetCollection.GetMultiAsDataTable(HC.NotaCreditoDetFields.FolFactura = dtFacturas.Rows(i).Item("FolFactura") And HC.NotaCreditoDetFields.Estatus = NotaCreditoEnum.APLICADA, 0, Nothing)

                        For j As Integer = 0 To dtPagos.Rows.Count - 1
                            ImporteIngreso += dtPagos.Rows(j).Item("ImpteIngreso")
                        Next

                        For j As Integer = 0 To dtNotas.Rows.Count - 1
                            ImporteNotas += dtNotas.Rows(j).Item("Total")
                        Next
                        dtFacturas.Rows(i).Item("Saldo") = Me.dgvFacturas.Rows(i).Cells(Me.clmTotalFactura.Index).Value - ImporteIngreso
                        dtFacturas.Rows(i).Item("NotasAnteriores") = ImporteNotas

                        Select Case dtFacturas.Rows(i).Item("Estatus")
                            Case "V"
                                dtFacturas.Rows(i).Item("Estatus") = "VIGENTE"
                            Case "A"
                                dtFacturas.Rows(i).Item("Estatus") = "ABONADO"
                        End Select

                        dgvFacturas.Rows(i).Cells(clmChecado.Index).Value = False

                        If dtFacturas.Rows(i).Item("Saldo") <= dtFacturas.Rows(i).Item("NotasAnteriores") Then
                            dgvFacturas.Rows(i).Cells(clmChecado.Index).ReadOnly = True
                            dgvFacturas.Rows(i).DefaultCellStyle.BackColor = Color.LightSlateGray
                        End If

                        dgvFacturas.Rows(i).Cells(clmImporte.Index).ReadOnly = True
                        dgvFacturas.Rows(i).Cells(clmIva.Index).ReadOnly = True
                        dgvFacturas.Rows(i).Cells(clmTotal.Index).ReadOnly = True
                    Next
                    Me.cmbConcepto.Focus()
                Else
                    Me.dgvFacturas.DataSource = Nothing
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Suma()
        Try
            Dim Total As Decimal = 0D
            For Each Renglon As DataGridViewRow In Me.dgvFacturas.Rows
                If Renglon.Cells(clmChecado.Index).Value Then
                    Dim Importe As Decimal = 0

                    If IsNumeric(Renglon.Cells(clmTotal.Index).Value) Then
                        Importe = Renglon.Cells(clmTotal.Index).Value
                    End If
                    Total += Importe
                End If
            Next
            Me.txtTotal.Text = Total.ToString("C2")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub clmChecado_ValidateCheckState1(ByVal sender As Object, ByVal e As Infragistics.Win.ValidateCheckStateEventArgs) Handles clmChecado.ValidateCheckState
        Try
            Dim Resultado As Boolean = Not CBool(e.NewCheckState)
            dgvFacturas.CurrentRow.Cells(clmImporte.Index).ReadOnly = Resultado
            dgvFacturas.CurrentRow.Cells(clmIva.Index).ReadOnly = Resultado
            dgvFacturas.CurrentRow.Cells(clmTotal.Index).ReadOnly = Resultado
            dgvFacturas.CurrentRow.Cells(clmChecado.Index).Value = Not Resultado

            'cambiar estilo a los campos editables
            If Not Resultado Then
                Dim Saldo As Decimal = dgvFacturas.CurrentRow.Cells(clmSaldo.Index).Value
                Dim NotasAnteriores As Decimal = dgvFacturas.CurrentRow.Cells(clmTotalNotas.Index).Value
                dgvFacturas.CurrentRow.Cells(clmImporte.Index).Style.BackColor = Color.LightSalmon
                dgvFacturas.CurrentRow.Cells(clmIva.Index).Style.BackColor = Color.LightSalmon
                dgvFacturas.CurrentRow.Cells(clmTotal.Index).Style.BackColor = Color.LightSalmon
                dgvFacturas.CurrentRow.Cells(Me.clmImporte.Index).Value = Saldo - NotasAnteriores
                dgvFacturas.CurrentRow.Cells(Me.clmIva.Index).Value = 0
                dgvFacturas.CurrentRow.Cells(Me.clmTotal.Index).Value = Saldo - NotasAnteriores
            Else
                dgvFacturas.Rows(dgvFacturas.CurrentRow.Index).Cells(clmImporte.Index).Style.BackColor = Color.White
                dgvFacturas.Rows(dgvFacturas.CurrentRow.Index).Cells(clmIva.Index).Style.BackColor = Color.White
                dgvFacturas.Rows(dgvFacturas.CurrentRow.Index).Cells(clmTotal.Index).Style.BackColor = Color.White
                dgvFacturas.CurrentRow.Cells(Me.clmImporte.Index).Value = 0
                dgvFacturas.CurrentRow.Cells(Me.clmIva.Index).Value = 0
                dgvFacturas.CurrentRow.Cells(Me.clmTotal.Index).Value = 0
            End If

            Suma()
        Catch ex As Exception
            MessageBox.Show("Error al intentar Sumar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvFacturas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacturas.CellEndEdit
        Dim Grid As DataGridView = CType(sender, DataGridView)

        If clmIva.Index = e.ColumnIndex Or clmImporte.Index = e.ColumnIndex Then
            Dim Importe As Decimal = 0D
            Dim Iva As Decimal = 0D

            If IsNumeric(Grid.Rows(e.RowIndex).Cells(clmImporte.Index).Value) Then
                Importe = Decimal.Parse(Grid.Rows(e.RowIndex).Cells(clmImporte.Index).Value)
            End If
            If IsNumeric(Grid.Rows(e.RowIndex).Cells(clmIva.Index).Value) Then
                Iva = Decimal.Parse(Grid.Rows(e.RowIndex).Cells(clmIva.Index).Value)
            End If
            Grid.Rows(e.RowIndex).Cells(clmTotal.Index).Value = Importe * (1 + Iva / 100)
        ElseIf clmTotal.Index = e.ColumnIndex Then
            If IsNumeric(Grid.Rows(e.RowIndex).Cells(clmTotal.Index).Value) Then
                Grid.Rows(e.RowIndex).Cells(clmImporte.Index).Value = Grid.Rows(e.RowIndex).Cells(clmTotal.Index).Value
                Grid.Rows(e.RowIndex).Cells(clmIva.Index).Value = 0
            End If
        End If
    End Sub

    Private Sub dgvFacturas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgvFacturas.KeyPress
        If Estado = FormState.Nuevo Or Estado = FormState.Guardar Or Estado = FormState.Limpiar Then
            If e.KeyChar = Chr(Keys.Space) Then
                dgvFacturas.CurrentRow.Cells(clmChecado.Index).Value = Not dgvFacturas.CurrentRow.Cells(clmChecado.Index).Value
                clmChecado_ValidateCheckState1(sender, New Infragistics.Win.ValidateCheckStateEventArgs(CType(dgvFacturas.CurrentRow.Cells(clmChecado.Index).Value, CheckState)))
            End If
        End If
    End Sub

    Private Sub ValidarNumerico(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsNumeric(CType(sender, TextBox).Text & e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ValidarIva(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsNumeric(CType(sender, TextBox).Text & e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Or e.KeyChar = "-" Then
            e.Handled = True
        ElseIf Val(CType(sender, TextBox).Text & e.KeyChar) > 100 Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgvFacturas_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvFacturas.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf ValidarNumerico
        RemoveHandler e.Control.KeyPress, AddressOf ValidarIva

        If dgvFacturas.CurrentCell.ColumnIndex = clmImporte.Index Or dgvFacturas.CurrentCell.ColumnIndex = clmTotal.Index Then
            AddHandler e.Control.KeyPress, AddressOf ValidarNumerico
        ElseIf dgvFacturas.CurrentCell.ColumnIndex = clmIva.Index Then
            AddHandler e.Control.KeyPress, AddressOf ValidarIva
        End If
    End Sub

    Private Sub dgvFacturas_RowValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvFacturas.RowValidating
        If Estado = FormState.Nuevo Or Estado = FormState.Guardar Or Estado = FormState.Limpiar Then
            If dgvFacturas.CurrentRow.Cells(clmChecado.Index).Value And (Not IsNumeric(dgvFacturas.CurrentRow.Cells(clmTotal.Index).Value) OrElse dgvFacturas.CurrentRow.Cells(clmTotal.Index).Value = 0) Then
                MsgBox("Debe introducir el total", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                e.Cancel = True
            ElseIf Not ValidarRenglon(e.RowIndex) Then
                Dim FolFactura As String = dgvFacturas.Rows(e.RowIndex).Cells(clmFactura.Index).Value
                MsgBox("El total no puede superar el saldo menos las notas de credito previas en la factura: " & FolFactura, MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                e.Cancel = True
            Else
                Suma()
            End If
        End If
    End Sub
End Class