Imports CN = ClasesNegocio
Imports Integra.Clases
Imports HC = IntegraLab.ORM.HelperClasses

Public Class CancelacionIngresosForm
    Implements InterfaceForm

#Region " Declaraciones "
    Private WithEvents ingreso As CN.ChequeClass
    Private seleccion As New Integra.Clases.BusquedaClass(Of CN.ChequeClass)
    Private Cuentas As New CN.CuentaCollectionClass
    Private CtasCont As New CN.CuentaContableCollectionClass
    Private Cuenta As CN.CuentaClass
    Private chkEstatus As CondicionEnum = CondicionEnum.ACTIVOS
    Private TipoCambio As CN.TipoCambioClass
#End Region

#Region " Forma "
    Private Sub CatTiposForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblTitulo.Text = Me.Text.ToUpper
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "100100011"
        MtbEstados.StateCancelar = "100100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "110100011"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010000"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        mtb.ToolBarButtonStatus = MtbEstados
        mtb.sbCambiarEstadoBotones("Cancelar")
        Ingresos.Obtener(ClasesNegocio.BancosMovimientosTipo.DEPOSITO, chkEstatus)
        RellenarBancos()
        Lectura()
        LimpiarBancos()
    End Sub
#End Region

#Region " Rellenar "
    Private Sub LimpiarBancos()
        txtBanco.Clear()
        cmbBanco.SelectedIndex = -1
        cmbBanco.Text = "Seleccione un Banco..."
        txtSaldo.Text = "0.00"
        txtImporte.Text = "0.00"
        txtCargo.Text = "0.00"
        txtAbono.Text = "0.00"
        txtReferencia.Clear()
        chkElectronico.Checked = False
        ' txtFolio.Clear()
        lv.Items.Clear()
        LimpiarGridCuentas()
        Me.lblEstatus.Visible = False
    End Sub

    Private Sub RellenarBancos()
        Bancos.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        txtBanco.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtBanco.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtBanco.AutoCompleteCustomSource.AddRange(Bancos.Listar)
    End Sub

    Private Sub cmbBanco_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBanco.SelectedIndexChanged
        If cmbBanco.SelectedIndex > -1 Then
            txtBanco.Text = Me.cmbBanco.SelectedValue.ToString()
            Dim banco As CN.BancosClass = DirectCast(cmbBanco.SelectedItem, CN.BancosClass)
            Cuentas.Obtener(banco.Codigo, ClasesNegocio.EstatusEnum.ACTIVO)
            RellenarCuentas()
        End If
    End Sub

    Private Sub txtBanco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBanco.KeyDown, cmbBanco.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                Bancos.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
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

    Private Sub lv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv.SelectedIndexChanged
        If lv.SelectedItems.Count > 0 Then
            For Each indice As ListViewItem In lv.SelectedItems
                txtCuenta.Text = String.Format("{0} - {1}", indice.SubItems(0).Text, indice.SubItems(1).Text)
                Cuenta = DirectCast(indice.Tag, CN.CuentaClass)
                If Not IsNothing(Cuenta.CuentaContable) Then
                    'ojoo
                    'Dim r As C1.Win.C1FlexGrid.Row = fg.Rows.Add
                    'RellenarFilaFlexGrid(r, Cuenta.CuentaContable)
                    'r.AllowEditing = False
                    RellenarGridCuentas(Cuenta.CuentaContable)
                    txtSaldo.Text = Cuenta.SaldoActual.ToString("C")
                    Dim tc As New CN.TipoCambioCollectionClass
                    If Not Cuenta.TipoMoneda.EsMonedaLocal Then
                        TipoCambio = tc.ObtenerTipoCambio(Cuenta.TipoMoneda, Now.ToString("dd/MM/yyyy"))
                        If IsNothing(TipoCambio) Then
                            MessageBox.Show("No existe tipo de cambio registrado, no se puede continuar con el registro.", "No hay tipo de cambio", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            mtb_ClickCancelar(sender, New ToolBarButtonClickEventArgs(mtb.Buttons(2)), False)
                            mtb.sbCambiarEstadoBotones("Cancelar")
                        Else
                            txtTipoCambio.Text = TipoCambio.TipoCambio
                        End If
                    Else
                        txtTipoCambio.Text = 1D
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
        If Not IsNothing(ingreso) Then
            ingreso.Cuenta = Cuenta
            txtImporte.Text = ingreso.Importe.ToString()
        End If
    End Sub
#End Region

#Region " Metodos "
    Public Sub Escritura() Implements InterfaceForm.Escritura
        pan.Enabled = True
        Me.DgvCuentas.Enabled = True
    End Sub

    Public Sub Lectura() Implements InterfaceForm.Lectura
        pan.Enabled = False
        Me.DgvCuentas.Enabled = False
        Me.txtCargo.Enabled = False
        Me.txtAbono.Enabled = False
    End Sub

    Public Sub Limpiar() Implements InterfaceForm.Limpiar
        LimpiarBancos()
        dtp.Value = Now
        txtImporte.Text = "0.00"
        txtSaldo.Text = "0.00"
        txtConcepto.Clear()
        txtImporteLetra.Clear()
        txtCuenta.Clear()
        'txtFolio.Clear()
        txtReferencia.Clear()
        txtPoliza.Clear()
        chkElectronico.Checked = False
    End Sub

    Public Sub Mostrar() Implements InterfaceForm.Mostrar
        cmbBanco.SelectedValue = ingreso.Cuenta.Banco.DescripcionCta
        RellenarCuentas()
        For Each item As ListViewItem In lv.Items
            If IsNothing(item.Tag) And IsNothing(ingreso.Cuenta) Then
                item.Selected = True
                txtCuenta.Text = String.Format("{0} - {1}")
                txtSaldo.Text = Decimal.Parse("0").ToString("C")
            ElseIf Not IsNothing(item.Tag) And Not IsNothing(ingreso.Cuenta) Then
                Dim tmp As CN.CuentaClass = DirectCast(item.Tag, CN.CuentaClass)
                If tmp.Cuenta = ingreso.Cuenta.Cuenta Then
                    item.Selected = True
                    Cuenta = tmp
                    txtCuenta.Text = String.Format("{0} - {1}", item.SubItems(0).Text, item.SubItems(1).Text)
                    txtSaldo.Text = Cuenta.SaldoActual.ToString("C")
                End If
            End If
        Next
        dtp.Value = ingreso.FechaDocumento
        txtImporte.Text = ingreso.Importe.ToString()
        txtConcepto.Text = ingreso.Concepto
        Select Case ingreso.Medio
            Case ClasesNegocio.BancosMovimientosMedio.CHEQUE
                chkElectronico.Checked = False

            Case ClasesNegocio.BancosMovimientosMedio.ELECTRONICO
                chkElectronico.Checked = True
        End Select
        txtReferencia.Text = ingreso.Folio
        ' txtFolio.Text = ingreso.Folio
        Me.lblEstatus.Text = ingreso.Estatus.ToString
        Me.lblEstatus.Visible = True
        MostrarPolizaFlexGrid(ingreso.Poliza)
        Me.txtAbono.Text = Me.txtImporte.Text
        Me.txtCargo.Text = Me.txtImporte.Text
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
        If txtImporte.Valor = 0 Then
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
        If Not Bl Then
            Cadena = Nothing
            ingreso.Anticipo = False
            ingreso.Beneficiario = Nothing
            ingreso.Concepto = txtConcepto.Text
            ingreso.Cuenta = Cuenta
            ingreso.FechaDocumento = dtp.Value
            ingreso.Importe = txtImporte.Valor
            ingreso.Origen = ClasesNegocio.BancosMovimientosOrigen.BANCOS
            ingreso.Resguardo = SiNoEnum.NO
            ingreso.TipoCambio = TipoCambio.TipoCambio
            ingreso.TipoMovimiento = ClasesNegocio.BancosMovimientosTipo.DEPOSITO
            If ingreso.TipoMovimiento = ClasesNegocio.BancosMovimientosTipo.DEPOSITO Then
                If ingreso.Medio = ClasesNegocio.BancosMovimientosMedio.CHEQUE Then
                    ingreso.Folio = txtReferencia.Text
                ElseIf ingreso.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO Then
                    ingreso.Folio = txtReferencia.Text
                End If
            End If
        End If
        Return Cadena
    End Function

#End Region

#Region " ToolBar "
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar       
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "CancelacionDeposito")
        Try
            Dim SaldoAnterior As Decimal = ingreso.Cuenta.SaldoActual

            If MsgBox("Desea cancelar el Deposito", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                Exit Sub
            End If
            If ingreso.Estatus = Integra.Clases.EstatusEnum.INACTIVO Then
                MsgBox("El Deposito ya ha sido Cancelado...")
                Limpiar()
                Lectura()
                Exit Sub
            Else
                GenerarPoliza()
                If ingreso.Borrar(Trans) Then
                    Dim MovBancos As New CN.MovimientosBancosClass() '(cheque.Poliza.Codigo, cheque.Cuenta.Codigo)
                    MovBancos.NumPoliza = ingreso.PolizaCancelacion.Codigo
                    MovBancos.FechaCaptura = Now
                    MovBancos.FechaMov = Now
                    MovBancos.Concepto = ingreso.PolizaCancelacion.Concepto
                    MovBancos.CveCancelacion = "S"
                    MovBancos.Referencia = ingreso.Poliza.Codigo
                    MovBancos.CtaBancaria = ingreso.Cuenta.Codigo
                    MovBancos.SaldoAnterior = SaldoAnterior
                    MovBancos.TipoMov = "R"
                    MovBancos.Origen = "B"
                    MovBancos.TipoCambio = CDec(Me.txtTipoCambio.Text)
                    MovBancos.Importe = ingreso.Importe
                    MovBancos.Cargo_Abono = ClasesNegocio.PolizaOperacionEnum.ABONO

                    If Not MovBancos.Guardar(Trans) Then
                        Trans.Rollback()
                        Cancelar = True
                        MsgBox("El Deposito no pudo ser Cancelado...", MsgBoxStyle.Critical, "Error")
                    End If

                    Cuenta.SaldoActual -= MovBancos.Importe
                    Trans.Add(Cuenta.ObtenerEntidad)
                    Cuenta.ObtenerEntidad.Save()

                    Trans.Commit() ''Se escriben los datos en la tabla, si no ha pasado ningun error

                    MsgBox("El Deposito ha sido Cancelado Satisfactoriamente...", MsgBoxStyle.Information, "Aviso")
                    Limpiar()
                    Lectura()
                    Cancelar = False
                Else
                    Trans.Rollback()
                    Cancelar = True
                    MsgBox("El Deposito no pudo ser Cancelado...", MsgBoxStyle.Critical, "Error")
                End If
            End If
            Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
            Ingresos.Obtener(ClasesNegocio.BancosMovimientosTipo.RETIRO, chkEstatus)
        Catch ex As Exception
            Trans.Rollback()
            Cancelar = True
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK)
            '#If CONFIG = "Debug" Then
            '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            '#Else
            '         msgbox("Ocurrió un Error", MsgBoxStyle.Critical ,"Error")
            '#End If
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        ingreso = Nothing
        Lectura()
        Limpiar()
        Ingresos.Obtener(ClasesNegocio.BancosMovimientosTipo.DEPOSITO, chkEstatus)
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        'Escritura()
        MessageBox.Show("No está habilitada la edición para este módulo.", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Cancelar = True
        If IsNothing(Validar()) Then
            If VerificarBalance() = 0 Then
                GenerarPoliza()
                If ingreso.Guardar() Then
                    MessageBox.Show(String.Format("Número de Póliza Generado:{0}{1}", vbCrLf, ingreso.Poliza.NumeroPoliza), "Póliza Generada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mtb_ClickImprimir(sender, e, Cancelar)
                    Limpiar()
                    Lectura()
                    Cancelar = False
                End If
            Else
                MessageBox.Show("No se puede generar el depósito por que no está cuadrada la póliza.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show(Validar, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Bancos.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        Ingresos.Obtener(ClasesNegocio.BancosMovimientosTipo.DEPOSITO, chkEstatus)
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Escritura()
        ingreso = New ClasesNegocio.ChequeClass
        Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        If Not IsNothing(ingreso) Then
            If Not ingreso.Emitido Then
                If ingreso.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO Then
                    PagoElectronico.Cheque = ingreso
                    pDg.Document = PagoElectronico
                    If pDg.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Try
                            PagoElectronico.Print()
                            If MessageBox.Show("¿Se imprimió el comprobante?", "Confirmación de Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                PagoElectronico.ImpresionExitosa()
                                ingreso.Guardar()
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                Else
                    If MessageBox.Show("¿Desea imprimir el cheque?", "Confirmación de Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        ImprimirCheque.Cheque = ingreso
                        ImprimirCheque.AbonoEnCuenta = MessageBox.Show("¿Es para abono en cuenta?", "Tipo de Cheque", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                        pDg.Document = ImprimirCheque
                        If pDg.ShowDialog = Windows.Forms.DialogResult.OK Then
                            Try
                                ImprimirCheque.Print()
                                If MessageBox.Show("¿Se imprimió el cheque?", "Confirmación de Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                    ImprimirCheque.ImpresionExitosa()
                                    ingreso.Guardar()
                                End If
                            Catch ex As Exception
                                MessageBox.Show(ex.Message, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End If
                    End If
                End If
            Else
                If Not ingreso.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO Then MessageBox.Show(String.Format("Este cheque ya fue emitido el {0}.", ingreso.FechaEmision.ToString("dd MMM' de 'yyyy"), "Cheque ya emitido", MessageBoxButtons.OK, MessageBoxIcon.Error))
            End If
        End If
    End Sub
#End Region

#Region " Otros "
    Private Sub cheque_Mensajes(ByVal sender As Object, ByVal Message As ClasesNegocio.MensajeClass) Handles ingreso.Mensajes
        MessageBox.Show(Message.Mensaje, Message.Titulo, MessageBoxButtons.OK, Message.Tipo)
    End Sub

    Private Sub chkElectronico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkElectronico.CheckedChanged
        txtReferencia.Visible = chkElectronico.Checked
        lblRef.Visible = chkElectronico.Checked
        If chkElectronico.Checked Then
            ingreso.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO
        Else
            ingreso.Medio = ClasesNegocio.BancosMovimientosMedio.CHEQUE
            txtReferencia.Clear()
        End If
    End Sub

    Private Sub txtTipoCambio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoCambio.TextChanged
        If Not bl Then
            bl = True
            txtTipoCambio.Text = txtTipoCambio.Valor.ToString("C")
            bl = False
        End If
    End Sub
#End Region

#Region " Importe "
    Private Sub txtImporteLetra_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporteLetra.GotFocus
        txtConcepto.Focus()
    End Sub

    Private bl As Boolean = False
    Private Sub txtImporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImporte.TextChanged
        If Not bl Then
            If Not IsNothing(ingreso) Then
                ingreso.Importe = txtImporte.Valor
                txtImporteLetra.Text = ingreso.ImporteLetra.ToUpper
                bl = True
                txtImporte.Text = txtImporte.Valor.ToString("C")
                'ojo
                'ValorFlexGrid(1, 6, txtImporte.Valor)
                bl = False
            End If
        End If
    End Sub
#End Region

#Region " FlexGrid "
    Private Sub LimpiarGridCuentas()
        Me.DgvCuentas.Rows.Clear()
        'fg.Rows.RemoveRange(1, fg.Rows.Count - 1)
    End Sub

    Private Function ValorGridCuentas(ByVal Renglon As Integer, ByVal Columna As Integer, Optional ByVal Valor As Object = Nothing) As Object
        If Me.DgvCuentas.Rows.Count > 0 Then
            If Not IsNothing(Valor) Then Me.DgvCuentas.Rows(Renglon).Cells(Columna).Value = Valor
            Return Me.DgvCuentas.Rows(Renglon).Cells(Columna).Value
        End If
        Return Nothing
    End Function

    Private Sub PasarCuenta(ByVal CtaCont As CN.CuentaContableClass, ByVal Renglon As Integer)
        If IsNothing(CtaCont) Then
            'fg.Rows(Renglon).UserData = Nothing
            ValorGridCuentas(Renglon, 5, "")
            ValorGridCuentas(Renglon, 6, 0D)
            ValorGridCuentas(Renglon, 7, 0D)
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
                ValorGridCuentas(Renglon, 5, "")
                ValorGridCuentas(Renglon, 6, 0D)
                ValorGridCuentas(Renglon, 7, 0D)
                MessageBox.Show(sMensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    'ojoo
    'Private Sub fg_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles fg.AfterEdit
    '    Select Case e.Col
    '        Case 1 To 4
    '            Dim tmp As CN.CuentaContableClass
    '            tmp = CtasCont.ObtenerCuentaContable(ValorFlexGrid(e.Row, 1), ValorFlexGrid(e.Row, 2), ValorFlexGrid(e.Row, 3), ValorFlexGrid(e.Row, 4))
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
    '                MessageBox.Show("La suma de los Abonoes sobrepasa a la suma de los Cargos.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End If
    '    End Select
    'End Sub

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
    '            'ojoo
    '            'BuscarCuentas.Bancos = CheckState.Unchecked
    '            'BuscarCuentas.Afectables = CheckState.Checked
    '            If BuscarCuentas.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                If fg.RowSel > 1 Then
    '                    Dim cta As New ClasesNegocio.CuentaContableClass
    '                    cta = BuscarCuentas.CuentaContable
    '                    RellenarFilaFlexGrid(fg.Rows(fg.RowSel), cta)
    '                End If
    '            End If
    '    End Select
    'End Sub

    'Private Sub RellenarFilaFlexGrid(ByVal r As C1.Win.C1FlexGrid.Row, ByVal Cta As ClasesNegocios.CuentaContableClass)
    '    r.Item(1) = Cta.CuentaMayor
    '    r.Item(2) = Cta.SubCuenta
    '    r.Item(3) = Cta.SSubCuenta
    '    r.Item(4) = Cta.SSSubCuenta
    '    r.Item(5) = Cta.NombreCuenta
    '    r.Item(6) = 0
    '    r.Item(7) = 0
    '    r.UserData = Cta
    'End Sub

    Private Sub RellenarGridCuentas(ByVal Cta As ClasesNegocio.CuentaContableClass)
        Me.DgvCuentas.Rows.Clear()
        Me.DgvCuentas.Rows.Add()
        Me.DgvCuentas.Rows(0).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
        Me.DgvCuentas.Rows(0).Cells("ClmSubCta").Value = Cta.SubCuenta
        Me.DgvCuentas.Rows(0).Cells("ClmSsbCta").Value = Cta.SSubCuenta
        Me.DgvCuentas.Rows(0).Cells("ClmSssCta").Value = Cta.SSSubCuenta
        Me.DgvCuentas.Rows(0).Cells("ClmDescripcion").Value = Cta.NombreCuenta
        Me.DgvCuentas.Rows(0).Cells("ClmCargo").Value = 0
        Me.DgvCuentas.Rows(0).Cells("ClmAbono").Value = 0
        'r.userdata = Cta
    End Sub

    Private Function VerificarBalance() As Decimal
        Dim Cargos As Decimal = 0
        Dim Abonos As Decimal = 0
        'ojo
        'For Each r As C1.Win.C1FlexGrid.Row In fg.Rows
        '    If r.Index > 0 Then
        '        Cargos += r(6)
        '        Abonos += r(7)
        '    End If
        'Next
        txtAbono.Text = Abonos.ToString()
        txtCargo.Text = Cargos.ToString()
        Return Cargos - Abonos
    End Function

    Private Sub GenerarPoliza()
        Try
            ingreso.PolizaCancelacion = Nothing
            Dim Empresa As New CN.EmpresaClass(Controlador.Sesion.MiEmpresa.Empndx)
            Dim Poliza As New CN.PolizaClass
            Poliza.Concepto = "CANCELACION DE " + txtConcepto.Text
            Poliza.Empresa = Empresa
            Poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.ACTIVA
            Poliza.FechaCaptura = Now
            Poliza.FechaPoliza = Now
            Poliza.Importe = txtImporte.Valor
            Poliza.Origen = ClasesNegocio.PolizaOrigenEnum.BANCOS
            Poliza.TipoCambio = txtTipoCambio.Valor
            Poliza.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.CANCELACION
            Poliza.TipoError = 0
            Poliza.Referencia = ingreso.Poliza.Codigo
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
                        polizaDet.Concepto = "CANCELACION DE " + txtConcepto.Text
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
                        polizaDet.Concepto = "CANCELACION DE " + txtConcepto.Text
                        Poliza.AgregarDetalle(polizaDet)
                    End If
                End If
            Next
            ingreso.PolizaCancelacion = Poliza
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK)
        End Try
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
            txtCargo.Text = txtCargo.Valor.ToString("C")
            bl = False
        End If
    End Sub

    Private Sub txtAbono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not bl Then
            bl = True
            txtAbono.Text = txtAbono.Valor.ToString("C")
            bl = False
        End If
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Dim BuscarCheques As New BuscarChequeForm
        BuscarCheques.Icon = Me.Icon
        BuscarCheques.BloquearTiposMovimiento = True
        BuscarCheques.TipoMovimientos = ClasesNegocio.BancosMovimientosTipo.DEPOSITO
        Dim bol As Boolean = True
        If BuscarCheques.ShowDialog = Windows.Forms.DialogResult.OK Then
            ingreso = BuscarCheques.Cheque
            Mostrar()
            bol = False
        End If
        Cancelar = bol
    End Sub
End Class