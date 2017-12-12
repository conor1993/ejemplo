Imports CN = ClasesNegocio
Imports Integra.Clases
Imports HC = IntegraLab.ORM.HelperClasses


Public Class CancelacionTraspasosForm
    Implements InterfaceForm

#Region " Declaraciones "
    Private WithEvents CargoTraspaso As CN.ChequeClass
    Private WithEvents AbonoTraspaso As CN.ChequeClass
    Private seleccion As New Integra.Clases.BusquedaClass(Of CN.ChequeClass)
    Private Cuentas As New CN.CuentaCollectionClass
    Private CtasCont As New CN.CuentaContableCollectionClass
    Private Cuenta As CN.CuentaClass
    Private CuentaDestino As CN.CuentaClass
    Private chkEstatus As CondicionEnum = CondicionEnum.ACTIVOS
    Private TipoCambio As CN.TipoCambioClass
    Private Buscar As Boolean = False
    Dim NoCuentaDestino As String
#End Region

    Private Sub CancelacionTraspasosForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.lblTitulo.Text = Me.Text.ToUpper
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "100000001"
        MtbEstados.StateCancelar = "100100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "110100011"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010000"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        Me.mtb.Buttons(0).ToolTipText = "Busca los Registros de Depósitos Registrados"
        Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
        Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
        Me.mtb.Buttons(5).ToolTipText = "Crea un nuevo Registro de depósitos."
        Me.mtb.Buttons(6).ToolTipText = "Guarda el Registro de Depósito o los cambios que se le hayan Realizado."
        Me.mtb.Buttons(10).ToolTipText = "Imprime Los resgistros de Depósitos Registrados."
        Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."
        mtb.ToolBarButtonStatus = MtbEstados
        mtb.sbCambiarEstadoBotones("Limpiar")
        Abonos.Obtener(ClasesNegocio.BancosMovimientosTipo.CARGO_DIVERSO, chkEstatus)
        RellenarBancos()
        RellenarBancosDestinos()
        Lectura()
        LimpiarBancos()
    End Sub

#Region " Rellenar "
    Private Sub LimpiarBancos()
        txtBanco.Clear()
        Me.txtBancoDestino.Clear()
        cmbBanco.SelectedIndex = -1
        cmbBanco.Text = "Seleccione un Banco..."
        Me.cmbBancoDestino.SelectedIndex = -1
        Me.cmbBancoDestino.Text = "Seleccione un Banco..."
        txtSaldo.Text = "0.00"
        txtImporte.Text = "0.00"
        lv.Items.Clear()
        Me.lvCuentasBancariasdestino.Items.Clear()
        LimpiarGridCuentas()
        Me.lblEstatus.Visible = False
    End Sub

    Private Sub RellenarBancos()
        Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
        txtBanco.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtBanco.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtBanco.AutoCompleteCustomSource.AddRange(Bancos.Listar)
    End Sub

    Private Sub RellenarBancosDestinos()
        BancosDestino.Obtener(CN.CondicionEnum.ACTIVOS)
        txtBancoDestino.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtBancoDestino.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtBancoDestino.AutoCompleteCustomSource.AddRange(BancosDestino.Listar)
    End Sub

    Private Sub cmbBanco_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBanco.SelectedIndexChanged
        If cmbBanco.SelectedIndex > -1 Then
            txtBanco.Text = Me.cmbBanco.SelectedValue
            Dim banco As CN.BancosClass = DirectCast(cmbBanco.SelectedItem, CN.BancosClass)
            Cuentas.Obtener(banco.Codigo, ClasesNegocio.EstatusEnum.ACTIVO)
            LimpiarGridCuentas()
            RellenarCuentas()
            Me.txtCuenta.Text = ""
            Me.txtSaldo.Text = ""
            Me.cmbBancoDestino.SelectedIndex = -1
            Me.cmbBancoDestino.Text = "Seleccione un Banco..."
            Me.cmbBancoDestino.Enabled = False
            Me.txtBancoDestino.Text = ""
            Me.txtBancoDestino.Enabled = False
            Me.txtCuentaDestino.Text = ""
            Me.txtSaldoCuentaDestino.Text = ""
            Me.lvCuentasBancariasdestino.Items.Clear()
        End If
    End Sub

    Private Sub txtBanco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBanco.KeyDown, cmbBanco.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
        End Select
    End Sub

    Private Sub txtBanco_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBanco.TextChanged, txtCuenta.TextChanged, txtSaldo.TextChanged
        cmbBanco.SelectedValue = txtBanco.Text
    End Sub

    Private Sub RellenarCuentas()
        lv.Items.Clear()
        For Each cta As CN.CuentaClass In Cuentas
            Dim lvi As New ListViewItem(cta.Cuenta)
            lvi.Tag = cta
            Dim lvsi As New ListViewItem.ListViewSubItem(lvi, cta.Descripcion)
            Dim lvsi1 As New ListViewItem.ListViewSubItem(lvi, cta.TipoMoneda.DescripcionCorta)
            lvi.SubItems.Add(lvsi)
            lvi.SubItems.Add(lvsi1)
            Me.lv.Items.Add(lvi)
        Next
    End Sub

    Private Sub RellenarCuentasDestino()
        Me.lvCuentasBancariasdestino.Items.Clear()
        For Each cta As CN.CuentaClass In Cuentas
            Dim lvi As New ListViewItem(cta.Cuenta)
            lvi.Tag = cta
            Dim lvsi As New ListViewItem.ListViewSubItem(lvi, cta.Descripcion)
            Dim lvsi1 As New ListViewItem.ListViewSubItem(lvi, cta.TipoMoneda.DescripcionCorta)
            lvi.SubItems.Add(lvsi)
            lvi.SubItems.Add(lvsi1)
            Me.lvCuentasBancariasdestino.Items.Add(lvi)
        Next
    End Sub

    Private Sub lv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv.SelectedIndexChanged
        Try
            If lv.SelectedItems.Count > 0 Then
                For Each indice As ListViewItem In lv.SelectedItems
                    Me.LimpiarGridCuentas()
                    'Me.txtImporte.Enabled = True
                    txtCuenta.Text = String.Format("{0} - {1}", indice.SubItems(0).Text, indice.SubItems(1).Text)
                    Cuenta = DirectCast(indice.Tag, CN.CuentaClass)

                    If Not IsNothing(Cuenta.CuentaContable) Then
                        'Dim r As C1.Win.C1FlexGrid.Row = fg.Rows.Add
                        'Dim r As New System.Windows.Forms.DataGridViewRow
                        'Me.DgvCuentas.Rows.Add(r)
                        'r.ReadOnly = False
                        '
                        ' Me.DgvCuentas.DataSource = Cuenta.CuentaContable
                        'Cuen = Cuenta
                        RellenarGridCuentas(Cuenta.CuentaContable)
                        txtSaldo.Text = Cuenta.SaldoActual.ToString("C")
                        txtFolio.Text = Cuenta.FolioActual + 1

                        Dim tc As New CN.TipoCambioCollectionClass
                        If Cuenta.TipoMoneda.Codigo = 0 Then
                            MessageBox.Show("Cuenta bancaria no tiene Tipo de Moneda Asignado", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.lv.Refresh()
                            Exit Sub
                        Else
                            If Not Cuenta.TipoMoneda.EsMonedaLocal Then
                                TipoCambio = tc.ObtenerTipoCambio(Cuenta.TipoMoneda, Now.ToString("dd/MM/yyyy"))
                                If IsNothing(TipoCambio) Then
                                    If Not Buscar Then
                                        MessageBox.Show("No existe tipo de cambio registrado, no se puede continuar con el registro.", "No hay tipo de cambio", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        mtb_ClickCancelar(sender, New ToolBarButtonClickEventArgs(mtb.Buttons(2)), False)
                                        mtb.sbCambiarEstadoBotones("Cancelar")
                                    Else
                                        If Not IsNothing(TipoCambio) Then
                                            txtTipoCambio.Text = TipoCambio.TipoCambio
                                        End If
                                    End If
                                Else
                                    txtTipoCambio.Text = 1D
                                End If
                            Else
                                Me.txtTipoCambio.Text = 1D
                            End If
                        End If
                    Else
                        MessageBox.Show("Esta cuenta no tiene una Cuenta Contable Asociada, no se puede continuar con el registro.", "No hay Cuenta Contable asociada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mtb_ClickCancelar(sender, New ToolBarButtonClickEventArgs(mtb.Buttons(2)), False)
                        mtb.sbCambiarEstadoBotones("Cancelar")
                    End If
                Next
            Else
                txtCuenta.Clear()
                Cuenta = Nothing
            End If
            If Not IsNothing(AbonoTraspaso) Then
                AbonoTraspaso.Cuenta = Cuenta
                txtImporte.Text = AbonoTraspaso.Importe.ToString("C2")
            End If
            Me.txtBancoDestino.Enabled = True
            Me.cmbBancoDestino.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK)
        End Try
    End Sub

#End Region

#Region " Metodos "
    Public Sub Escritura() Implements InterfaceForm.Escritura
        pan.Enabled = True
        Me.DgvCuentas.Enabled = True
        Me.txtReferencia.Enabled = True
        ' Me.txtImporte.Enabled = True
        Me.txtConcepto.Enabled = True
        Me.txtTipoCambio.Enabled = True
        Me.txtPoliza.Enabled = True
        Me.DgvCuentas.Enabled = True
        Me.txtCargo.Enabled = True
        Me.txtAbono.Enabled = True
    End Sub

    Public Sub Lectura() Implements InterfaceForm.Lectura
        pan.Enabled = False
        Me.DgvCuentas.Enabled = False
        Me.txtReferencia.Enabled = False
        Me.txtImporte.Enabled = False
        Me.txtConcepto.Enabled = False
        Me.txtTipoCambio.Enabled = False
        Me.txtPoliza.Enabled = False
        Me.DgvCuentas.Enabled = False
        Me.txtCargo.Enabled = False
        Me.txtAbono.Enabled = False
    End Sub

    Public Sub Limpiar() Implements InterfaceForm.Limpiar
        LimpiarBancos()
        dtp.Value = Now
        txtImporte.Text = "0.00"
        txtSaldo.Text = "0.00"
        Me.txtSaldoCuentaDestino.Text = "0.00"
        txtConcepto.Clear()
        txtImporteLetra.Clear()
        txtCuenta.Clear()
        Me.txtCuentaDestino.Clear()
        txtFolio.Clear()
        txtReferencia.Clear()
        txtPoliza.Clear()
        Buscar = False
        chkElectronico.Checked = False
        Me.txtBancoDestino.Enabled = False
        Me.cmbBancoDestino.Enabled = False
        Me.txtCargo.Text = "0.00"
        Me.txtAbono.Text = "0.00"
    End Sub

    Public Sub Mostrar() Implements InterfaceForm.Mostrar
        cmbBanco.SelectedValue = AbonoTraspaso.Cuenta.Banco.DescripcionCta
        Me.cmbBancoDestino.SelectedValue = AbonoTraspaso.CuentaDestino.Banco.DescripcionCta
        RellenarCuentas()
        For Each item As ListViewItem In lv.Items
            If IsNothing(item.Tag) And IsNothing(AbonoTraspaso.Cuenta) Then
                item.Selected = True
                txtCuenta.Text = String.Format("{0} - {1}")
                txtSaldo.Text = "0.00".ToString("C2")
            Else
                If Not IsNothing(item.Tag) And Not IsNothing(AbonoTraspaso.Cuenta) Then
                    Dim tmp As CN.CuentaClass = DirectCast(item.Tag, CN.CuentaClass)

                    If tmp.Cuenta = AbonoTraspaso.Cuenta.Cuenta Then
                        item.Selected = True
                        Cuenta = tmp
                        txtCuenta.Text = String.Format("{0} - {1}", item.SubItems(0).Text, item.SubItems(1).Text)
                        txtSaldo.Text = Cuenta.SaldoActual.ToString("C2")
                    Else
                        If tmp.Cuenta = AbonoTraspaso.CuentaDestino.Cuenta Then
                            CuentaDestino = tmp
                            Me.txtCuentaDestino.Text = tmp.Cuenta & " - " & tmp.Descripcion
                            Me.txtSaldoCuentaDestino.Text = tmp.SaldoActual.ToString("C2")
                        End If
                    End If
                End If
            End If
        Next
        dtp.Value = AbonoTraspaso.FechaDocumento
        txtImporte.Text = AbonoTraspaso.Importe.ToString("C2")
        txtConcepto.Text = AbonoTraspaso.Concepto
        Select Case AbonoTraspaso.Medio
            Case ClasesNegocio.BancosMovimientosMedio.CHEQUE
                chkElectronico.Checked = False
            Case ClasesNegocio.BancosMovimientosMedio.ELECTRONICO
                chkElectronico.Checked = True
        End Select
        Me.lblEstatus.Text = AbonoTraspaso.Estatus.ToString
        Me.lblEstatus.Visible = True
        txtReferencia.Text = AbonoTraspaso.Folio
        txtFolio.Text = AbonoTraspaso.Folio
        'ojo
        MostrarPolizaFlexGrid(AbonoTraspaso.Poliza)
    End Sub

    Public Function Validar() As String Implements InterfaceForm.Validar
        Dim Cadena As String = "Faltan los siguientes datos:" & vbCrLf
        Dim Bl As Boolean = False

        If txtBanco.Text.Replace(" ", "").Length = 0 Then
            Cadena &= "* Banco" & vbCrLf
            Bl = True
        End If
        If txtCuenta.Text.Replace(" ", "").Length = 0 Then
            Cadena &= "* Cuenta Bancaria" & vbCrLf
            Bl = True
        End If
        If txtImporte.Text = 0 Then
            Cadena &= "* Importe" & vbCrLf
            Bl = True
        End If
        If txtConcepto.Text.Replace(" ", "").Length = 0 Then
            Cadena &= "* Concepto" & vbCrLf
            Bl = True
        End If
        If chkElectronico.Checked And txtReferencia.Text.Replace(" ", "").Length = 0 Then
            Cadena &= "* Referencia" & vbCrLf
            Bl = True
        End If
        If lv.SelectedItems.Count = 0 Then
            Cadena &= "* Cuenta" & vbCrLf
            Bl = True
        End If
        If lvCuentasBancariasdestino.SelectedItems.Count = 0 Then
            Cadena &= "* Cuenta Destino" & vbCrLf
            Bl = True
        End If

        If Not Bl Then
            Cadena = Nothing

            AbonoTraspaso.Anticipo = False
            AbonoTraspaso.Beneficiario = Nothing
            AbonoTraspaso.Concepto = txtConcepto.Text
            AbonoTraspaso.Cuenta = Cuenta
            AbonoTraspaso.FechaDocumento = dtp.Value
            AbonoTraspaso.Importe = txtImporte.Text
            AbonoTraspaso.Origen = ClasesNegocio.BancosMovimientosOrigen.BANCOS
            AbonoTraspaso.Resguardo = SiNoEnum.NO
            AbonoTraspaso.TipoCambio = txtTipoCambio.Text
            AbonoTraspaso.TipoMovimiento = ClasesNegocio.BancosMovimientosTipo.TRASPASO
            AbonoTraspaso.CuentaDestino = CuentaDestino
            'If Cargo.TipoMovimiento = ClasesNegocio.BancosMovimientosTipo.DEPOSITO Then
            '    If Cargo.Medio = ClasesNegocio.BancosMovimientosMedio.CHEQUE Then
            '        Cargo.Folio = txtFolio.Valor
            '    ElseIf Cargo.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO Then
            AbonoTraspaso.Folio = txtReferencia.Text
            'End If
            '    End If
        End If
        Return Cadena
    End Function

#End Region

#Region " ToolBar "
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Ingresos Depositos")
        Try
            Dim SaldoAnterior As Decimal = Cuenta.SaldoActual
            Dim SaldoAnteriorDestino As Decimal = CuentaDestino.SaldoActual

            If MsgBox("Desea cancelar el Traspaso", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                Exit Sub
            End If
            If AbonoTraspaso.Estatus = Integra.Clases.EstatusEnum.INACTIVO Then
                MsgBox("El Traspaso ya ha sido Cancelado...")
                Limpiar()
                Lectura()
                Exit Sub
            Else
                GenerarPoliza()
                'Guarda abono de movimiento de traspaso
                If AbonoTraspaso.Borrar(Trans) Then
                    'Guardar movimiento en tabla de movimientos bancarios
                    Dim MovBancos As New CN.MovimientosBancosClass
                    MovBancos.NumPoliza = AbonoTraspaso.PolizaCancelacion.Codigo
                    MovBancos.FechaCaptura = Now
                    MovBancos.FechaMov = Now
                    MovBancos.Concepto = AbonoTraspaso.PolizaCancelacion.Concepto
                    MovBancos.CveCancelacion = "S"
                    MovBancos.Referencia = AbonoTraspaso.PolizaCancelacion.Codigo
                    MovBancos.CtaBancaria = CuentaDestino.Codigo 'Cuenta.Codigo
                    MovBancos.SaldoAnterior = SaldoAnteriorDestino 'SaldoAnterior
                    MovBancos.Cargo_Abono = ClasesNegocio.PolizaOperacionEnum.ABONO
                    MovBancos.TipoMov = "R"
                    MovBancos.Origen = "B"
                    MovBancos.Importe = Me.txtImporte.Text 'Me.DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value
                    MovBancos.TipoCambio = CDec(Me.txtTipoCambio.Text)
                    MovBancos.Referencia = AbonoTraspaso.PolizaCancelacion.Codigo

                    If Not MovBancos.Guardar(Trans) Then
                        Trans.Rollback()
                        Cancelar = True
                        MessageBox.Show("No se pudieron Guardar los Traspasos, Intentelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    CuentaDestino.SaldoActual -= MovBancos.Importe
                    Trans.Add(CuentaDestino.ObtenerEntidad)
                    CuentaDestino.ObtenerEntidad.Save()

                    'Guardar movimiento en tabla de movimientos bancarios
                    Dim MovBancos2 As New CN.MovimientosBancosClass
                    MovBancos2.NumPoliza = AbonoTraspaso.PolizaCancelacion.Codigo
                    MovBancos2.FechaCaptura = Now
                    MovBancos2.FechaMov = Now
                    MovBancos2.Concepto = AbonoTraspaso.PolizaCancelacion.Concepto
                    MovBancos2.CveCancelacion = "S"
                    MovBancos2.CtaBancaria = Cuenta.Codigo 'CuentaDestino.Codigo
                    MovBancos2.SaldoAnterior = SaldoAnterior 'SaldoAnteriorDestino
                    MovBancos2.Cargo_Abono = ClasesNegocio.PolizaOperacionEnum.CARGO
                    MovBancos2.TipoMov = "D"
                    MovBancos2.Origen = "B"
                    MovBancos2.Importe = Me.txtImporte.Text 'Me.DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value
                    MovBancos2.TipoCambio = CDec(Me.txtTipoCambio.Text)
                    MovBancos2.Referencia = AbonoTraspaso.PolizaCancelacion.Codigo

                    If Not MovBancos2.Guardar(Trans) Then
                        Trans.Rollback()
                        Cancelar = True
                        MessageBox.Show("No se pudieron Guardar los Traspasos, Intentelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    Cuenta.SaldoActual += MovBancos2.Importe
                    Trans.Add(Cuenta.ObtenerEntidad)
                    Cuenta.ObtenerEntidad.Save()

                    Trans.Commit() ''Se escriben los datos en la tabla, si no ha pasado ningun error

                    MsgBox("El Traspaso ha sido Cancelado Satisfactoriamente...", MsgBoxStyle.Information, "Aviso")
                    Limpiar()
                    Lectura()
                    Cancelar = False
                Else
                    Trans.Rollback()
                    Cancelar = True
                    MsgBox("El Traspaso  no pudo ser Cancelado...", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
            End If
            Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
            Abonos.Obtener(ClasesNegocio.BancosMovimientosTipo.DEPOSITO, chkEstatus)
        Catch ex As Exception
            Trans.Rollback()
            Cancelar = True
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        AbonoTraspaso = Nothing
        Lectura()
        Limpiar()
        Abonos.Obtener(ClasesNegocio.BancosMovimientosTipo.DEPOSITO, chkEstatus)
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        'Escritura()
        MessageBox.Show("No está habilitada la edición para este módulo.", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Ingresos Depositos")

        Try
            Dim SaldoAnterior As Decimal = Cuenta.SaldoActual
            Dim SaldoAnteriorDestino As Decimal = CuentaDestino.SaldoActual

            Cancelar = True

            If IsNothing(Validar()) Then
                If VerificarBalance() = 0 Then
                    GenerarPoliza()
                    'guarda abono de movimiento de traspaso
                    If AbonoTraspaso.Guardar() Then
                        'guardar movimiento en tabla de movimientos bancarios
                        Dim MovBancos As New CN.MovimientosBancosClass
                        MovBancos.NumPoliza = AbonoTraspaso.Poliza.Codigo
                        MovBancos.CtaBancaria = Cuenta.Codigo
                        MovBancos.SaldoAnterior = SaldoAnterior
                        MovBancos.FechaMov = Me.dtp.Value
                        MovBancos.FechaCaptura = Now
                        MovBancos.Importe = Me.txtImporte.Text 'Me.DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value
                        MovBancos.Concepto = AbonoTraspaso.Poliza.Concepto
                        MovBancos.Cargo_Abono = ClasesNegocio.PolizaOperacionEnum.ABONO
                        MovBancos.TipoCambio = CDec(Me.txtTipoCambio.Text)
                        MovBancos.TipoMov = "R"
                        MovBancos.Origen = "B"
                        MovBancos.CveCancelacion = "N"
                        'MovBancos.Beneficiario = Me.txtBeneficiario.Text
                        If Me.chkElectronico.Checked = True Then
                            MovBancos.Referencia = Me.txtReferencia.Text
                        Else
                            MovBancos.Referencia = AbonoTraspaso.Folio
                        End If

                        If Not MovBancos.Guardar(Trans) Then
                            Trans.Rollback()
                            MessageBox.Show("No se pudieron Guardar los Traspasos, Intentelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Cancelar = True
                            Exit Sub
                        End If
                        Cuenta.SaldoActual -= MovBancos.Importe
                        Trans.Add(Cuenta.ObtenerEntidad)
                        Cuenta.ObtenerEntidad.Save()

                        'guardar movimiento en tabla de movimientos bancarios
                        Dim MovBancos2 As New CN.MovimientosBancosClass
                        MovBancos2.NumPoliza = AbonoTraspaso.Poliza.Codigo
                        MovBancos2.CtaBancaria = CuentaDestino.Codigo
                        MovBancos2.SaldoAnterior = SaldoAnteriorDestino
                        MovBancos2.FechaMov = Me.dtp.Value
                        MovBancos2.FechaCaptura = Now
                        MovBancos2.Importe = Me.txtImporte.Text 'Me.DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value
                        MovBancos2.Concepto = AbonoTraspaso.Poliza.Concepto
                        MovBancos2.Cargo_Abono = ClasesNegocio.PolizaOperacionEnum.CARGO
                        MovBancos2.TipoCambio = CDec(Me.txtTipoCambio.Text)
                        MovBancos2.TipoMov = "D"
                        MovBancos2.Origen = "B"
                        MovBancos2.CveCancelacion = "N"
                        'MovBancos.Beneficiario = Me.txtBeneficiario.Text
                        If Me.chkElectronico.Checked = True Then
                            MovBancos2.Referencia = Me.txtReferencia.Text
                        Else
                            MovBancos2.Referencia = AbonoTraspaso.Folio
                        End If

                        If Not MovBancos2.Guardar(Trans) Then
                            Trans.Rollback()
                            MessageBox.Show("No se pudieron Guardar los Traspasos, Intentelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Cancelar = True
                            Exit Sub
                        End If
                        CuentaDestino.SaldoActual += MovBancos.Importe
                        Trans.Add(CuentaDestino.ObtenerEntidad)
                        CuentaDestino.ObtenerEntidad.Save()

                        Trans.Commit()
                        MessageBox.Show(String.Format("Número de Póliza Generado:{0}{1}", vbCrLf, AbonoTraspaso.Poliza.NumeroPoliza), "Poliza Generada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'mtb_ClickImprimir(sender, e, Cancelar)
                        Limpiar()
                        Lectura()
                        Cancelar = False
                    End If
                Else
                    MessageBox.Show("No se puede generar el depósito por que no esta cuadrada la póliza.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show(Validar, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
            Abonos.Obtener(ClasesNegocio.BancosMovimientosTipo.DEPOSITO, chkEstatus)
        Catch ex As Exception
            Trans.Rollback()
            Cancelar = True
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Escritura()
        AbonoTraspaso = New ClasesNegocio.ChequeClass
        Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
        Me.cmbBanco.SelectedIndex = -1
        Me.cmbBanco.Text = "Seleccione un Banco..."
        Me.cmbBancoDestino.SelectedIndex = -1
        Me.cmbBancoDestino.Text = "Seleccione un Banco..."
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        If Not IsNothing(AbonoTraspaso) Then
            If Not AbonoTraspaso.Emitido Then
                If AbonoTraspaso.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO Then
                    PagoElectronico.Cheque = AbonoTraspaso
                    pDg.Document = PagoElectronico
                    If pDg.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Try
                            PagoElectronico.Print()
                            If MessageBox.Show("¿Se imprimió el comprobante?", "Confirmación de Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                PagoElectronico.ImpresionExitosa()
                                AbonoTraspaso.Guardar()
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                Else
                    If MessageBox.Show("¿Desea imprimir el cheque?", "Confirmación de Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        ImprimirCheque.Cheque = AbonoTraspaso
                        ImprimirCheque.AbonoEnCuenta = MessageBox.Show("¿Es para abono en cuenta?", "Tipo de Cheque", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                        pDg.Document = ImprimirCheque
                        If pDg.ShowDialog = Windows.Forms.DialogResult.OK Then
                            Try
                                ImprimirCheque.Print()
                                If MessageBox.Show("¿Se imprimió el cheque?", "Confirmación de Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                    ImprimirCheque.ImpresionExitosa()
                                    AbonoTraspaso.Guardar()
                                End If
                            Catch ex As Exception
                                MessageBox.Show(ex.Message, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End If
                    End If
                End If
            Else
                If Not CargoTraspaso.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO Then MessageBox.Show(String.Format("Este cheque ya fue emitido el {0}.", CargoTraspaso.FechaEmision.ToString("dd MMM' de 'yyyy"), "Cheque ya emitido", MessageBoxButtons.OK, MessageBoxIcon.Error))
            End If
        End If
    End Sub
#End Region

#Region " Otros "
    Private Sub cheque_Mensajes(ByVal sender As Object, ByVal Message As ClasesNegocio.MensajeClass) Handles AbonoTraspaso.Mensajes
        MessageBox.Show(Message.Mensaje, Message.Titulo, MessageBoxButtons.OK, Message.Tipo)
    End Sub

    Private Sub chkElectronico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkElectronico.CheckedChanged
        txtReferencia.Visible = chkElectronico.Checked
        lblRef.Visible = chkElectronico.Checked
        If chkElectronico.Checked Then
            AbonoTraspaso.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO
        Else
            AbonoTraspaso.Medio = ClasesNegocio.BancosMovimientosMedio.CHEQUE
            txtReferencia.Clear()
        End If
    End Sub

    Private Sub txtTipoCambio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not bl Then
            bl = True
            txtTipoCambio.Text = txtTipoCambio.Text.ToString("C2")
            bl = False
        End If
    End Sub
#End Region

#Region " Importe "
    Private Sub txtImporteLetra_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporteLetra.GotFocus
        txtConcepto.Focus()
    End Sub

    Private bl As Boolean = False
    'Private Sub txtImporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not bl Then
    '        If Not IsNothing(AbonoTraspaso) Then
    '            If Me.txtImporte.Text = "" Then
    '                Exit Sub
    '            Else
    '                AbonoTraspaso.Importe = txtImporte.Text
    '                txtImporteLetra.Text = AbonoTraspaso.ImporteLetra.ToUpper
    '                bl = True
    '                'txtImporte.Text = txtImporte.Valor.ToString("C")
    '                ValorGridCuentas(0, 6, txtImporte.Text)
    '                ValorGridCuentas(1, 5, txtImporte.Text)
    '                bl = False
    '            End If
    '        End If
    '    End If
    'End Sub
#End Region

#Region " Grid "

    Private Sub PasarCuenta(ByVal CtaCont As CN.CuentaContableClass, ByVal Renglon As Integer)
        If IsNothing(CtaCont) Then
            'fg.Rows(Renglon).UserData = Nothing
            ValorGridCuentas(Renglon, 4, "")
            ValorGridCuentas(Renglon, 5, 0D)
            ValorGridCuentas(Renglon, 6, 0D)
        Else
            If CtaCont.Bancos = SiNoEnum.NO And CtaCont.Afectable = SiNoEnum.SI Then
                'fg.Rows(Renglon).UserData = CtaCont
                RellenarGridCuentas(CtaCont)
                'fg.FinishEditing()
                'fg.Col = 5
            Else
                Dim sMensaje As String = "No se puede utilizar esta cuenta por que sus propiedades son:" & vbCrLf
                If CtaCont.Bancos = SiNoEnum.SI Then sMensaje &= "* De Bancos" & vbCrLf
                If CtaCont.Afectable = SiNoEnum.NO Then sMensaje &= "* No Afectable" & vbCrLf
                ' fg.Rows(Renglon).UserData = Nothing
                ValorGridCuentas(Renglon, 4, "")
                ValorGridCuentas(Renglon, 5, 0D)
                ValorGridCuentas(Renglon, 6, 0D)
                MessageBox.Show(sMensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    'ojoo
    'Private Sub fg_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles fg.AfterEdit
    '    Select Case e.Col
    '        Case 1 To 4
    '            Dim tmp As CN.CuentaContableClass
    '            ValorFlexGrid(e.Row, 1, FuncionesClass.PonerCeros(ValorFlexGrid(e.Row, 1)))
    '            ValorFlexGrid(e.Row, 2, FuncionesClass.PonerCeros(ValorFlexGrid(e.Row, 2)))
    '            ValorFlexGrid(e.Row, 3, FuncionesClass.PonerCeros(ValorFlexGrid(e.Row, 3)))
    '            ValorFlexGrid(e.Row, 4, FuncionesClass.PonerCeros(ValorFlexGrid(e.Row, 4)))
    '            tmp = CtasCont.ObtenerCuentaContable(FuncionesClass.PonerCeros(ValorFlexGrid(e.Row, 1)), FuncionesClass.PonerCeros(ValorFlexGrid(e.Row, 2)), FuncionesClass.PonerCeros(ValorFlexGrid(e.Row, 3)), FuncionesClass.PonerCeros(ValorFlexGrid(e.Row, 4)))
    '            PasarCuenta(tmp, e.Row)
    '        Case 5
    '            'Buscar Cuenta Por Nombre
    '            CtasCont.Obtener(Nothing, ValorFlexGrid(e.Row, 5))
    '            Dim tmp As CN.CuentaContableClass
    '            Select Case CtasCont.Count
    '                Case 1
    '                    tmp = CtasCont(0)
    '                Case Is > 1
    '                    SelCuentaContableForm.CuentasContables = CtasCont
    '                    If SelCuentaContableForm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                        tmp = SelCuentaContableForm.CuentaContable
    '                    End If
    '                Case Else
    '            End Select
    '            PasarCuenta(tmp, e.Row)
    '        Case 7
    '            If VerificarBalance() < 0 Then
    '                ValorFlexGrid(e.Row, e.Col, 0)
    '                MessageBox.Show("La suma de los Abonos sobrepasa a la suma de los Cargos.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End If
    '    End Select
    'End Sub

    'ojooooooooooo
    'Private Sub fg_BeforeEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles fg.BeforeEdit
    '    If txtImporte.Valor > 0 Then
    '        If e.Row > 0 Then
    '            If IsNothing(fg.Rows(e.Row - 1).UserData) Then
    '                e.Cancel = True
    '            Else
    '                If ValorFlexGrid(e.Row - 1, 6) > 0 Or ValorFlexGrid(e.Row - 1, 7) > 0 Then
    '                    If (VerificarBalance() = 0) And ValorFlexGrid(e.Row, 7) = 0 Then e.Cancel = True
    '                Else
    '                    e.Cancel = True
    '                End If
    '                Select Case e.Col
    '                    Case 1, 2, 3, 4
    '                        'ValorFlexGrid(e.Row, e.Col, QuitarCeros(ValorFlexGrid(e.Row, e.Col)))
    '                End Select
    '            End If
    '        End If
    '    Else
    '        e.Cancel = True
    '        txtImporte.Focus()
    '    End If
    'End Sub

    'Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fg.KeyDown
    '    Select Case e.KeyCode
    '        Case Keys.Delete
    '            If fg.RowSel > 1 Then fg.Rows.Remove(fg.RowSel)
    '        Case Keys.F3
    '            Dim BuscarCuentas As New BusquedaCuentasContablesForm
    '            BuscarCuentas.BloquearCaracteristicas = True
    '            'ojo
    '            'BuscarCuentas.Bancos = CheckState.Unchecked
    '            'BuscarCuentas.Afectables = CheckState.Checked
    '            If BuscarCuentas.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                If fg.RowSel > 1 Then
    '                    Dim cta As New ClasesNegocio.CuentaContableClass
    '                    cta = BuscarCuentas.CuentaContable
    '                    'ojo
    '                    'RellenarFilaFlexGrid(fg.Rows(fg.RowSel), cta)
    '                    'fg.Col = 7
    '                End If
    '            End If
    '    End Select
    'End Sub
    'ojooo

    Private Sub DgvCuentas_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DgvCuentas.CellBeginEdit
        If txtImporte.Text > 0 Then
            If e.RowIndex > 0 Then
                If IsNothing(Me.DgvCuentas.Rows(e.RowIndex - 1).Cells("ClmCtaMayor").Value) Then
                    e.Cancel = True
                Else
                    If ValorGridCuentas(e.RowIndex - 1, 5) > 0 Or ValorGridCuentas(e.RowIndex - 1, 6) > 0 Then
                        If (VerificarBalance() = 0) And ValorGridCuentas(e.RowIndex, 5) = 0 Then e.Cancel = True
                    Else
                        e.Cancel = True
                    End If
                    Select Case e.ColumnIndex
                        Case 1, 2, 3, 4
                            'ValorGridCuentas(e.RowIndex, e.ColumnIndex, QuitarCeros(ValorGridCuentas(e.RowIndex, e.ColumnIndex)))
                    End Select
                End If
            End If
        Else
            e.Cancel = True
            txtImporte.Focus()
        End If
    End Sub

    Private Sub DgvCuentas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCuentas.CellEndEdit
        Select Case e.ColumnIndex
            Case 0 To 3
                Dim tmp As CN.CuentaContableClass
                ValorGridCuentas(e.RowIndex, 0, FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 0)))
                ValorGridCuentas(e.RowIndex, 1, FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 1)))
                ValorGridCuentas(e.RowIndex, 2, FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 2)))
                ValorGridCuentas(e.RowIndex, 3, FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 3)))
                tmp = CtasCont.ObtenerCuentaContable(FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 0)), FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 1)), FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 2)), FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 3)))
                PasarCuenta(tmp, e.RowIndex)
            Case 4
                'Buscar Cuenta Por Nombre
                CtasCont.Obtener(Nothing, ValorGridCuentas(e.RowIndex, 4))
                Dim tmp As CN.CuentaContableClass = Nothing
                Select Case CtasCont.Count
                    Case 0
                        tmp = CtasCont(0)
                    Case Is > 0
                        SelCuentaContableForm.CuentasContables = CtasCont
                        If SelCuentaContableForm.ShowDialog = Windows.Forms.DialogResult.OK Then
                            tmp = SelCuentaContableForm.CuentaContable
                        End If
                    Case Else
                End Select
                PasarCuenta(tmp, e.RowIndex)
            Case 5
                If VerificarBalance() < 0 Then
                    ValorGridCuentas(e.RowIndex, e.ColumnIndex, 0)
                    MessageBox.Show("La suma de los Cargos sobrepasa a la suma de los Abonos.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
        End Select
    End Sub

    Private Function ValorGridCuentas(ByVal Renglon As Integer, ByVal Columna As Integer, Optional ByVal Valor As Object = Nothing) As Object
        If Me.DgvCuentas.Rows.Count > 0 Then
            If Not IsNothing(Valor) Then Me.DgvCuentas.Rows(Renglon).Cells(Columna).Value = Valor
            Return Me.DgvCuentas.Rows(Renglon).Cells(Columna).Value
        End If
        Return Nothing
    End Function

    Private Function VerificarBalance() As Decimal
        Dim Cargos As Decimal = 0
        Dim Abonos As Decimal = 0
        For Each r As System.Windows.Forms.DataGridViewRow In Me.DgvCuentas.Rows
            If r.Index > -1 Then
                Cargos += r.Cells("ClmCargo").Value
                Abonos += r.Cells("ClmAbono").Value
            End If
        Next
        txtAbono.Text = Abonos.ToString("C2")
        txtCargo.Text = Cargos.ToString("C2")
        Return Abonos - Cargos
    End Function

    Private Sub LimpiarGridCuentas()
        Me.DgvCuentas.Rows.Clear()
        'fg.Rows.RemoveRange(1, fg.Rows.Count - 1)
    End Sub

    Private Sub RellenarGridCuentas(ByVal Cta As ClasesNegocio.CuentaContableClass)
        Try
            Dim i As Integer = Me.DgvCuentas.Rows.Count
            If i <> 0 Then
                If Not Me.DgvCuentas.Rows(i - 1).Cells("ClmDescripcion").Value = "" Then
                    Me.DgvCuentas.Rows.Add()
                    Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                    Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = Cta.SubCuenta
                    Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                    Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                    Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                    Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = 0
                    Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = 0
                    Me.DgvCuentas.Rows.Add()
                Else
                    If i >= 3 Then
                        Me.DgvCuentas.Rows.Remove(Me.DgvCuentas.Rows(1))
                        Me.DgvCuentas.Rows(i - 2).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                        Me.DgvCuentas.Rows(i - 2).Cells("ClmSubCta").Value = Cta.SubCuenta
                        Me.DgvCuentas.Rows(i - 2).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                        Me.DgvCuentas.Rows(i - 2).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                        Me.DgvCuentas.Rows(i - 2).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                        Me.DgvCuentas.Rows(i - 2).Cells("ClmCargo").Value = 0
                        Me.DgvCuentas.Rows(i - 2).Cells("ClmAbono").Value = 0
                        Me.DgvCuentas.Rows.Add()
                    Else
                        Me.DgvCuentas.Rows(i - 1).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                        Me.DgvCuentas.Rows(i - 1).Cells("ClmSubCta").Value = Cta.SubCuenta
                        Me.DgvCuentas.Rows(i - 1).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                        Me.DgvCuentas.Rows(i - 1).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                        Me.DgvCuentas.Rows(i - 1).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                        Me.DgvCuentas.Rows(i - 1).Cells("ClmCargo").Value = 0
                        Me.DgvCuentas.Rows(i - 1).Cells("ClmAbono").Value = 0
                        Me.DgvCuentas.Rows.Add()
                    End If

                End If
            Else
                Me.DgvCuentas.Rows.Add()
                Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = Cta.SubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = 0
                Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = 0
                Me.DgvCuentas.Rows.Add()
            End If

            If Me.DgvCuentas.Rows.Count > 1 Then
                ' For j As Integer = 0 To Me.DgvCuentas.Columns.Count - 3
                Me.DgvCuentas.Rows(0).ReadOnly = True
                Me.DgvCuentas.Rows(1).ReadOnly = False
                'Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub GenerarPoliza()
        AbonoTraspaso.PolizaCancelacion = Nothing
        Dim Empresa As New CN.EmpresaClass(Controlador.Sesion.MiEmpresa.Empndx)
        Dim Poliza As New CN.PolizaClass
        Poliza.Concepto = "CANCELACION DE TRASPASO " + Me.txtConcepto.Text
        Poliza.Empresa = Empresa
        Poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.ACTIVA
        Poliza.FechaCaptura = Now
        Poliza.FechaPoliza = Now
        Poliza.Importe = txtImporte.Text
        Poliza.Origen = ClasesNegocio.PolizaOrigenEnum.BANCOS
        Poliza.TipoCambio = txtTipoCambio.Text
        Poliza.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.CANCELACION
        Poliza.TipoError = 0
        Poliza.Referencia = AbonoTraspaso.Poliza.Codigo
        For Each r As System.Windows.Forms.DataGridViewRow In Me.DgvCuentas.Rows
            If r.Index > -1 Then
                'If ValorFlexGrid(r.Index, 6) > 0 Then
                If Me.DgvCuentas.Rows(r.Index).Cells("ClmCargo").Value > 0 Then
                    Dim polizaDet As New CN.PolizaDetalleClass
                    Dim CuenCont As New CN.CuentaContableCollectionClass
                    'Se obtiene la Cuenta contable ya qe como fue enlazada al dgv manualmente no acepta el databounditem
                    'polizaDet.CuentaContable = r.DataBoundItem
                    CuenCont.Obtener(, , r.Cells("ClmCtaMayor").Value, r.Cells("ClmSubCta").Value, r.Cells("ClmSsbCta").Value, r.Cells("ClmSssCta").Value)
                    If CuenCont.Count = 1 Then
                        polizaDet.CuentaContable = CuenCont(0)
                    End If
                    '  polizaDet.Importe = ValorFlexGrid(r.Index, 6)
                    polizaDet.Importe = Me.DgvCuentas.Rows(r.Index).Cells("ClmCargo").Value
                    polizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO
                    polizaDet.Posicion = r.Index
                    polizaDet.Concepto = "CANCELACION DE TRASPASO " + Me.txtConcepto.Text
                    Poliza.AgregarDetalle(polizaDet)
                    'ElseIf ValorFlexGrid(r.Index, 7) > 0 Then
                ElseIf Me.DgvCuentas.Rows(r.Index).Cells("ClmAbono").Value > 0 Then
                    Dim polizaDet As New CN.PolizaDetalleClass
                    Dim CuenCont As New CN.CuentaContableCollectionClass
                    'Se obtiene la Cuenta contable ya qe como fue enlazada al dgv manualmente no acepta el databounditem
                    'polizaDet.CuentaContable = r.DataBoundItem
                    CuenCont.Obtener(, , r.Cells("ClmCtaMayor").Value, r.Cells("ClmSubCta").Value, r.Cells("ClmSsbCta").Value, r.Cells("ClmSssCta").Value)
                    If CuenCont.Count = 1 Then
                        polizaDet.CuentaContable = CuenCont(0)
                    End If
                    polizaDet.Importe = Me.DgvCuentas.Rows(r.Index).Cells("ClmAbono").Value
                    polizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.CARGO
                    polizaDet.Posicion = r.Index
                    polizaDet.Concepto = "CANCELACION DE TRASPASO " + Me.txtConcepto.Text
                    Poliza.AgregarDetalle(polizaDet)
                End If
            End If
        Next
        AbonoTraspaso.PolizaCancelacion = Poliza
    End Sub

    Private Sub RellenarGridCtasProveedor(ByVal Cta As ClasesNegocio.CuentaContableClass)
        For i As Integer = Me.DgvCuentas.Rows.Count - 1 To 1 Step -1
            Me.DgvCuentas.Rows.RemoveAt(i)
        Next
        If Me.DgvCuentas.Rows.Count = 1 Then
            Me.DgvCuentas.Rows.Add()
            Me.DgvCuentas.Rows(1).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
            Me.DgvCuentas.Rows(1).Cells("ClmSubCta").Value = Cta.SubCuenta
            Me.DgvCuentas.Rows(1).Cells("ClmSsbCta").Value = Cta.SSubCuenta
            Me.DgvCuentas.Rows(1).Cells("ClmSssCta").Value = Cta.SSSubCuenta
            Me.DgvCuentas.Rows(1).Cells("ClmDescripcion").Value = Cta.NombreCuenta
            Me.DgvCuentas.Rows(1).Cells("ClmCargo").Value = 0
            Me.DgvCuentas.Rows(1).Cells("ClmAbono").Value = 0
        Else
            MsgBox("Seleccione la cuenta Bancaria", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub MostrarPolizaFlexGrid(ByVal Poliza As CN.PolizaClass)
        LimpiarGridCuentas()
        For i As Integer = 0 To Poliza.Detalles.Count - 1
            'Me.DgvCuentas.Rows.Add()
            If i > 0 Then
                Me.RellenarGridCtasProveedor(Poliza.Detalles(i).CuentaContable)
            Else
                RellenarGridCuentas(Poliza.Detalles(i).CuentaContable)
            End If
            If Poliza.Detalles(i).Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO Then
                Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = Poliza.Detalles(i).Importe.ToString("C2")
            Else
                Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = Poliza.Detalles(i).Importe.ToString("C2")
            End If
        Next
        txtPoliza.Text = Poliza.NumeroPoliza
    End Sub
#End Region

    Private Sub txtCargo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not bl Then
            bl = True
            txtCargo.Text = txtCargo.Text.ToString("C")
            bl = False
        End If
    End Sub

    Private Sub txtAbono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not bl Then
            bl = True
            txtAbono.Text = txtAbono.Text.ToString("C")
            bl = False
        End If
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Dim BuscarCheques As New BuscarChequeForm
        BuscarCheques.Icon = Me.Icon
        BuscarCheques.BloquearTiposMovimiento = True
        BuscarCheques.GroupBox2.Enabled = False
        BuscarCheques.chkEle.Checked = False
        BuscarCheques.TipoMovimientos = ClasesNegocio.BancosMovimientosTipo.TRASPASO
        Buscar = True
        If BuscarCheques.ShowDialog = Windows.Forms.DialogResult.OK Then
            AbonoTraspaso = BuscarCheques.Cheque
            Mostrar()
        End If
    End Sub

    Private Sub DgvCuentas_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCuentas.CellValueChanged
        If Me.txtImporte.Text <> "" Then
            If txtImporte.Text > 0 Then
                ' If e.RowIndex > -1 Then
                If IsNothing(Me.DgvCuentas.Rows(e.RowIndex).Cells("ClmCtaMayor").Value) Then
                    Exit Sub
                Else
                    If ValorGridCuentas(e.RowIndex, 5) > 0 Or ValorGridCuentas(e.RowIndex, 6) > 0 Then
                        If (VerificarBalance() = 0) And ValorGridCuentas(e.RowIndex, 5) = 0 Then Exit Sub
                    Else
                        Exit Sub
                    End If
                    Select Case e.ColumnIndex
                        Case 1, 2, 3, 4
                            'ValorGridCuentas(e.RowIndex, e.ColumnIndex, QuitarCeros(ValorGridCuentas(e.RowIndex, e.ColumnIndex)))
                    End Select
                End If
            End If
            'Else
            'Exit Sub
            'txtImporte.Focus()
            'End If
        End If
    End Sub

    Private Sub DgvCuentas_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DgvCuentas.KeyDown
        If e.KeyCode = Keys.F3 Then
            Try
                Dim buscarCuenta As New BusquedaCuentasContablesForm
                buscarCuenta.BloquearCaracteristicas = True
                'ojo
                'buscarCuenta.Afectables = CheckState.Checked
                If buscarCuenta.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.RellenarGridCuentas(buscarCuenta.CuentaContable)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
        If e.KeyCode = Keys.Delete Then
            If Me.DgvCuentas.Rows.Count > 1 Then
                If Me.DgvCuentas.CurrentRow.Index = 0 Then
                    Exit Sub
                End If
                If MessageBox.Show("¿Esta seguro de eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                Else
                    Me.DgvCuentas.Rows.Remove(Me.DgvCuentas.CurrentRow)
                    If VerificarBalance() < 0 Then
                        MessageBox.Show("La suma de los Cargos sobrepasa a la suma de los Abonos.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cmbBancoDestino_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbBancoDestino.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                BancosDestino.Obtener(CN.CondicionEnum.ACTIVOS)
        End Select
    End Sub

    Private Sub cmbBancoDestino_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBancoDestino.SelectedIndexChanged
        If cmbBancoDestino.SelectedIndex > -1 Then
            txtBancoDestino.Text = Me.cmbBanco.SelectedValue
            Dim bancodestino As CN.BancosClass = DirectCast(cmbBancoDestino.SelectedItem, CN.BancosClass)
            Cuentas.Obtener(bancodestino.Codigo, ClasesNegocio.EstatusEnum.ACTIVO)
            RellenarCuentasDestino()
            Me.txtCuentaDestino.Text = ""
            Dim i As Integer = Me.DgvCuentas.Rows.Count
            If i >= 3 Then
                Me.DgvCuentas.Rows.Remove(Me.DgvCuentas.Rows(1))
            End If
        End If
    End Sub

    Private Sub lvCuentasBancariasdestino_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvCuentasBancariasdestino.SelectedIndexChanged
        If lvCuentasBancariasdestino.SelectedItems.Count > 0 Then
            For Each indice As ListViewItem In lvCuentasBancariasdestino.SelectedItems
                'Me.LimpiarGridCuentas()
                txtCuentaDestino.Text = String.Format("{0} - {1}", indice.SubItems(0).Text, indice.SubItems(1).Text)
                If Me.txtCuenta.Text = Me.txtCuentaDestino.Text Then
                    MessageBox.Show("Cuenta bancaria destino debe ser diferente a Cuenta bancaria origen", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtCuentaDestino.Text = ""
                    Me.txtSaldoCuentaDestino.Text = ""
                    Exit Sub
                End If
                CuentaDestino = DirectCast(indice.Tag, CN.CuentaClass)
                NoCuentaDestino = CuentaDestino.CuentaContable.CuentaContable
                If Not IsNothing(CuentaDestino.CuentaContable) Then
                    'Dim r As C1.Win.C1FlexGrid.Row = fg.Rows.Add
                    'Dim r As New System.Windows.Forms.DataGridViewRow
                    'Me.DgvCuentas.Rows.Add(r)
                    'r.ReadOnly = False
                    '
                    ' Me.DgvCuentas.DataSource = Cuenta.CuentaContable
                    'Cuen = Cuenta
                    RellenarGridCuentas(CuentaDestino.CuentaContable)
                    txtSaldoCuentaDestino.Text = CuentaDestino.SaldoActual.ToString("C")
                    'txtFolio.Text = Cuenta.FolioActual + 1

                    Dim tc As New CN.TipoCambioCollectionClass
                    If CuentaDestino.TipoMoneda.Codigo = 0 Then
                        MessageBox.Show("Cuenta bancaria no tiene Tipo de Moneda Asignado", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.lv.Refresh()
                        Exit Sub
                    Else
                        If Not CuentaDestino.TipoMoneda.EsMonedaLocal Then
                            TipoCambio = tc.ObtenerTipoCambio(Cuenta.TipoMoneda, Now.ToString("dd/MM/yyyy"))
                            If IsNothing(TipoCambio) Then
                                If Not Buscar Then
                                    MessageBox.Show("No existe tipo de cambio registrado, no se puede continuar con el registro.", "No hay tipo de cambio", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    mtb_ClickCancelar(sender, New ToolBarButtonClickEventArgs(mtb.Buttons(2)), False)
                                    mtb.sbCambiarEstadoBotones("Cancelar")
                                Else
                                    If Not IsNothing(TipoCambio) Then
                                        txtTipoCambio.Text = TipoCambio.TipoCambio
                                    End If
                                End If
                                'Else
                                '    txtTipoCambio.Text = 1D
                            End If
                            'Else
                            '    Me.txtTipoCambio.Text = 1D
                        End If
                    End If
                Else
                    MessageBox.Show("Esta cuenta no tiene una Cuenta Contable Asociada, no se puede continuar con el registro.", "No hay Cuenta Contable asociada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mtb_ClickCancelar(sender, New ToolBarButtonClickEventArgs(mtb.Buttons(2)), False)
                    mtb.sbCambiarEstadoBotones("Cancelar")
                End If
            Next
        Else
            txtCuentaDestino.Clear()
            CuentaDestino = Nothing
        End If
        If Not IsNothing(CargoTraspaso) Then
            CargoTraspaso.Cuenta = CuentaDestino
            'txtImporte.Text = Cargo.Importe
        End If
    End Sub

    Private Sub txtImporte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporte.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            If Not e.KeyChar = Chr(Keys.Back) Then
                If e.KeyChar = "." Then
                    If txtImporte.Text.Contains(".") OrElse txtImporte.Text = String.Empty Then
                        e.Handled = True
                    ElseIf txtImporte.SelectionStart <= txtImporte.Text.Length - 3 Then
                        e.Handled = True
                    End If
                Else
                    e.Handled = True
                End If
            End If
        Else
            Dim index As Integer = txtImporte.Text.IndexOf(".")

            If index <> -1 Then
                If index = txtImporte.Text.Length - 3 Then
                    If txtImporte.SelectionStart > index AndAlso txtImporte.SelectionLength <> 2 Then
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtImporte_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporte.TextChanged
        If Not bl Then
            If Not IsNothing(AbonoTraspaso) Then
                If Me.txtImporte.Text = "" Then
                    ValorGridCuentas(0, 6, "0.00")
                    ValorGridCuentas(1, 5, "0.00")
                    Me.txtCargo.Text = "0.00"
                    Me.txtAbono.Text = "0.00"
                    Exit Sub
                Else
                    AbonoTraspaso.Importe = txtImporte.Text
                    txtImporteLetra.Text = AbonoTraspaso.ImporteLetra.ToUpper
                    bl = True
                    'txtImporte.Text = txtImporte.Valor.ToString("C")
                    ValorGridCuentas(0, 6, txtImporte.Text)
                    ValorGridCuentas(1, 5, txtImporte.Text)
                    bl = False
                End If
            End If
        End If
    End Sub

End Class