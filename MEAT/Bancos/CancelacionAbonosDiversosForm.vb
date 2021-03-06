Imports CN = ClasesNegocio
Imports Integra.Clases
Imports HC = Integralab.ORM.HelperClasses
Imports System.Data.SqlClient

Public Class CancelacionAbonosDiversosForm
    Implements InterfaceForm

#Region " Declaraciones "
    Private WithEvents abonodiverso As CN.ChequeClass
    Private seleccion As New Integra.Clases.BusquedaClass(Of CN.ChequeClass)
    Private CtasCont As New CN.CuentaContableCollectionClass
    Private Cuentas As New CN.CuentaCollectionClass
    Private Cuenta As CN.CuentaClass
    Private chkEstatus As CondicionEnum = CondicionEnum.ACTIVOS
    Private TipoCambio As CN.TipoCambioClass
    Dim MovBancos As CN.MovimientosBancosClass
#End Region

    Private Sub CancelacionAbonosDiversosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        AbonosDiversos.Obtener(ClasesNegocio.BancosMovimientosTipo.RETIRO, chkEstatus)
        RellenarBancos()
        RellenarBeneficiarios()
        Lectura()
        LimpiarBancos()
        LimpiarBeneficiarios()
    End Sub

#Region " Rellenar "
    Private Sub LimpiarBancos()
        txtBanco.Clear()
        cmbBanco.SelectedIndex = -1
        cmbBanco.Text = "Seleccione un Banco..."
        txtSaldo.Text = "0.00"
        txtImporte.Text = "0.00"
        Me.txtCargo.Text = "0.00"
        Me.txtAbono.Text = "0.00"
        lv.Items.Clear()
        LimpiarGridCuentas()
        Me.lblEstatus.Visible = False
    End Sub

    Private Sub RellenarBancos()
        Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
        txtBanco.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtBanco.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtBanco.AutoCompleteCustomSource.AddRange(Bancos.Listar)
    End Sub

    Private Sub cmbBanco_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBanco.SelectedIndexChanged
        If cmbBanco.SelectedIndex > -1 Then
            txtBanco.Text = Me.cmbBanco.SelectedValue
            Dim banco As CN.BancosClass = DirectCast(cmbBanco.SelectedItem, CN.BancosClass)
            Cuentas.Obtener(banco.Codigo, ClasesNegocio.EstatusEnum.ACTIVO)
            RellenarCuentas()
        End If
    End Sub

    Private Sub txtBanco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBanco.KeyDown, cmbBanco.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
        End Select
    End Sub

    Private Sub txtBanco_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBanco.TextChanged, txtCuenta.TextChanged
        cmbBanco.SelectedValue = txtBanco.Text
    End Sub

    Private Sub LimpiarBeneficiarios()
        'Me.txtCodBeneficiario.Clear()
        'cmbBeneficiario.SelectedIndex = -1
        'cmbBeneficiario.Text = "Seleccione un Beneficiario..."
    End Sub

    Private Sub RellenarBeneficiarios()
        Beneficiarios.Obtener(CondicionEnum.ACTIVOS)
        ' txtBeneficiario.AutoCompleteSource = AutoCompleteSource.CustomSource
        ' txtBeneficiario.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ' txtBeneficiario.AutoCompleteCustomSource.AddRange(Beneficiarios.Listar)
    End Sub

    Private Sub cmbBeneficiario_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ' If cmbBeneficiario.SelectedIndex > -1 Then
        ' txtBeneficiario.Text = cmbBeneficiario.SelectedValue
        ' End If
    End Sub

    Private Sub txtBeneficiario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.F12
                Beneficiarios.Obtener(CondicionEnum.ACTIVOS)
        End Select
    End Sub

    Private Sub txtBeneficiario_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ' cmbBeneficiario.SelectedValue = txtBeneficiario.Text
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
                    'ojo
                    'Dim r As C1.Win.C1FlexGrid.Row = fg.Rows.Add
                    'RellenarFilaFlexGrid(r, Cuenta.CuentaContable)
                    'r.AllowEditing = False
                    RellenarGridCuentas(Cuenta.CuentaContable)
                    txtSaldo.Text = Cuenta.SaldoActual.ToString("C")
                    ' txtFolio.Text = Cuenta.FolioActual + 1
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
        If Not IsNothing(abonodiverso) Then
            abonodiverso.Cuenta = Cuenta
            txtImporte.Text = abonodiverso.Importe.ToString("C2")
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
        LimpiarBeneficiarios()
        dtp.Value = Now
        'txtImporte.Clear()
        'txtSaldo.Clear()
        txtConcepto.Clear()
        txtImporteLetra.Clear()
        txtCuenta.Clear()
        ' txtFolio.Clear()
        txtReferencia.Clear()
        txtPoliza.Clear()
        chkElectronico.Checked = False
        chkAnticipo.Checked = False
    End Sub

    Public Sub Mostrar() Implements InterfaceForm.Mostrar
        txtBanco.Text = abonodiverso.Cuenta.Banco.Descripcion
        'modificacion
        'ojo
        cmbBanco.SelectedValue = abonodiverso.Cuenta.Banco.DescripcionCta 'Me.cmbBanco.SelectedValue = abonodiverso.Cuenta.Banco.Clave
        'termina modificacion
        RellenarCuentas()
        For Each item As ListViewItem In lv.Items
            If IsNothing(item.Tag) And IsNothing(abonodiverso.Cuenta) Then
                item.Selected = True
                txtCuenta.Text = String.Format("{0} - {1}")
                txtSaldo.Text = "0.00".ToString("C2")
            ElseIf Not IsNothing(item.Tag) And Not IsNothing(abonodiverso.Cuenta) Then
                Dim tmp As CN.CuentaClass = DirectCast(item.Tag, CN.CuentaClass)
                If tmp.Cuenta = abonodiverso.Cuenta.Cuenta Then
                    item.Selected = True
                    Cuenta = tmp
                    txtCuenta.Text = String.Format("{0} - {1}", item.SubItems(0).Text, item.SubItems(1).Text)
                    txtSaldo.Text = Cuenta.SaldoActual.ToString("C2")
                End If
            End If
        Next
        ' Me.txtCodBeneficiario.Text = ""
        ' Me.cmbBeneficiario.Text = abonodiverso.Beneficiario.Beneficiario
        dtp.Value = abonodiverso.FechaDocumento
        txtImporte.Text = abonodiverso.Importe.ToString("C2")
        txtConcepto.Text = abonodiverso.Concepto
        chkAnticipo.Checked = abonodiverso.Anticipo
        Select Case abonodiverso.Medio
            Case ClasesNegocio.BancosMovimientosMedio.CHEQUE
                chkElectronico.Checked = False
            Case ClasesNegocio.BancosMovimientosMedio.ELECTRONICO
                chkElectronico.Checked = True
        End Select
        txtReferencia.Text = abonodiverso.Referencia
        ' txtFolio.Text = abonodiverso.Folio
        Me.lblEstatus.Text = abonodiverso.Estatus.ToString
        Me.lblEstatus.Visible = True
        'MostrarPolizaFlexGrid(abonodiverso.Poliza)
        txtPoliza.Text = abonodiverso.Poliza.NumeroPoliza
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
        'If Me.txtCodBeneficiario.Text.Replace(" ", "").Length = 0 Then
        '    Cadena &= "* Beneficiario" & vbCrLf
        '    Bl = True
        'End If
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
        If Not Bl Then
            Cadena = Nothing
            abonodiverso.Anticipo = chkAnticipo.Checked
            ' abonodiverso.Beneficiario = DirectCast(cmbBeneficiario.SelectedItem, CN.BeneficiarioClass)
            abonodiverso.Concepto = txtConcepto.Text
            abonodiverso.Cuenta = Cuenta
            abonodiverso.FechaDocumento = dtp.Value
            abonodiverso.Folio = txtReferencia.Text
            abonodiverso.Importe = txtImporte.Text
            abonodiverso.Origen = ClasesNegocio.BancosMovimientosOrigen.BANCOS
            abonodiverso.Resguardo = SiNoEnum.SI
            abonodiverso.TipoCambio = txtTipoCambio.Valor
            abonodiverso.TipoMovimiento = ClasesNegocio.BancosMovimientosTipo.RETIRO
        End If
        Return Cadena
    End Function
#End Region

#Region " ToolBar "
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "CancelacionPago")
        Try
            Dim SaldoAnterior As Decimal = abonodiverso.Cuenta.SaldoActual
            If MsgBox("Desea cancelar el Abono Diverso", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                Exit Sub
            End If
            If abonodiverso.Estatus = Integra.Clases.EstatusEnum.INACTIVO Then
                MsgBox("El Abono Diverso ya ha sido Cancelado...")
                Limpiar()
                Lectura()
                Exit Sub
            Else
                If abonodiverso.Entregado = True Then
                    MsgBox("El Abono Diverso no puede ser borrado, ya fu� Entregado...")
                Else
                    GenerarPoliza()
                    If abonodiverso.Borrar(Trans) Then
                        MovBancos = New CN.MovimientosBancosClass() '(abonodiverso.Poliza.Codigo, abonodiverso.Cuenta.Codigo)
                        MovBancos.NumPoliza = abonodiverso.PolizaCancelacion.Codigo
                        MovBancos.FechaCaptura = Now
                        MovBancos.FechaMov = Now
                        MovBancos.Concepto = abonodiverso.PolizaCancelacion.Concepto
                        MovBancos.CveCancelacion = "S"
                        MovBancos.Referencia = abonodiverso.Poliza.Codigo
                        MovBancos.CtaBancaria = abonodiverso.Cuenta.Codigo
                        MovBancos.SaldoAnterior = SaldoAnterior
                        MovBancos.Cargo_Abono = ClasesNegocio.PolizaOperacionEnum.ABONO
                        MovBancos.TipoMov = "R"
                        MovBancos.Origen = "B"
                        MovBancos.Importe = abonodiverso.Importe
                        MovBancos.TipoCambio = CDec(Me.txtTipoCambio.Text)

                        If Not MovBancos.Guardar(Trans) Then
                            Trans.Rollback()
                            Cancelar = True
                            MsgBox("El Cargo Diverso no pudo ser Cancelado...", MsgBoxStyle.Critical, "Error")
                            Exit Sub
                        End If

                        If Not RemoverProrrateo(abonodiverso.Poliza.Codigo) Then
                            Trans.Rollback()
                            Cancelar = True
                            Exit Sub
                        End If

                        Cuenta.SaldoActual -= MovBancos.Importe
                        Trans.Add(Cuenta.ObtenerEntidad)
                        Cuenta.ObtenerEntidad.Save()

                        Trans.Commit() ''Se escriben los datos en la tabla, si no ha pasado ningun error

                        MsgBox("El Cargo Diverso ha sido Cancelado Satisfactoriamente...", MsgBoxStyle.Information, "Aviso")
                        Limpiar()
                        Lectura()
                        Cancelar = False
                    Else
                        Trans.Rollback()
                        Cancelar = True
                        MsgBox("El Cargo Diverso no pudo ser Cancelado...", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End If
                End If
            End If
            Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
            AbonosDiversos.Obtener(ClasesNegocio.BancosMovimientosTipo.RETIRO, chkEstatus)
        Catch ex As Exception
            Trans.Rollback()
            Cancelar = True
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK)
            '#If CONFIG = "Debug" Then
            '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            '#Else
            '            msgbox("Ocurri� un Error", MsgBoxStyle.Critical, "Error")
            '#End If
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        abonodiverso = Nothing
        Lectura()
        Limpiar()
        AbonosDiversos.Obtener(ClasesNegocio.BancosMovimientosTipo.RETIRO, chkEstatus)
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        'Escritura()
        MessageBox.Show("No esta habilitada la edici�n para este modulo.", "Acci�n no permitida", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Cancelar = True
        If IsNothing(Validar()) Then
            If VerificarBalance() = 0 Then
                Dim bbl As Boolean
                If (txtSaldo.Valor - txtImporte.Text) < 0 Then
                    bbl = False
                    If MessageBox.Show("El importe de este cheque sobrepasa el saldo en la cuenta, �Desea continuar con la generaci�n del Cheque?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then bbl = True
                Else
                    bbl = True
                End If

                If bbl Then
                    GenerarPoliza()
                    If abonodiverso.Guardar() Then
                        MessageBox.Show(String.Format("N�mero de Poliza Generado:{0}{1}", vbCrLf, abonodiverso.Poliza.NumeroPoliza), "Poliza Generada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mtb_ClickImprimir(sender, e, Cancelar)
                        Limpiar()
                        Lectura()
                        Cancelar = False
                    End If
                End If
            Else
                MessageBox.Show("No se puede generar el movimiento por que no esta cuadrada la poliza.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show(Validar, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
        AbonosDiversos.Obtener(ClasesNegocio.BancosMovimientosTipo.RETIRO, chkEstatus)
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Escritura()
        abonodiverso = New ClasesNegocio.ChequeClass
        Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        If Not IsNothing(abonodiverso) Then
            'ImprimirCheque.Cheque = cheque
            'ppDg.ShowDialog()
            If Not abonodiverso.Emitido Then
                If abonodiverso.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO Then
                    PagoElectronico.Cheque = abonodiverso
                    pDg.Document = PagoElectronico
                    If pDg.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Try
                            PagoElectronico.Print()
                            If MessageBox.Show("�Se imprimio el comprobante?", "Confirmaci�n de Impresi�n", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                PagoElectronico.ImpresionExitosa()
                                abonodiverso.Guardar()
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                Else
                    If MessageBox.Show("�Desea imprimir el cheque?", "Confirmaci�n de Impresi�n", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        ImprimirCheque.Cheque = abonodiverso
                        ImprimirCheque.AbonoEnCuenta = MessageBox.Show("�Es para abono en cuenta?", "Tipo de Cheque", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                        pDg.Document = ImprimirCheque
                        If pDg.ShowDialog = Windows.Forms.DialogResult.OK Then
                            Try
                                ImprimirCheque.Print()
                                If MessageBox.Show("�Se imprimio el cheque?", "Confirmaci�n de Impresi�n", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                    ImprimirCheque.ImpresionExitosa()
                                    abonodiverso.Guardar()
                                End If
                            Catch ex As Exception
                                MessageBox.Show(ex.Message, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End If
                    End If
                End If
            Else
                If Not abonodiverso.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO Then MessageBox.Show(String.Format("Este cheque ya fue emitido el {0}.", abonodiverso.FechaEmision.ToString("dd MMM' de 'yyyy"), "Cheque ya emitido", MessageBoxButtons.OK, MessageBoxIcon.Error))
            End If
        End If
    End Sub
#End Region

#Region " Otros "
    Private Sub abonodiverso_Mensajes(ByVal sender As Object, ByVal Message As ClasesNegocio.MensajeClass) Handles abonodiverso.Mensajes
        MessageBox.Show(Message.Mensaje, Message.Titulo, MessageBoxButtons.OK, Message.Tipo)
    End Sub

    Private Sub chkElectronico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkElectronico.CheckedChanged
        If chkElectronico.Checked Then
            abonodiverso.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO
        Else
            abonodiverso.Medio = ClasesNegocio.BancosMovimientosMedio.CHEQUE
            txtReferencia.Clear()
        End If
    End Sub

    Private Sub txtTipoCambio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoCambio.TextChanged
        If Not bl Then
            bl = True
            txtTipoCambio.Text = txtTipoCambio.Valor.ToString("C2")
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
            If Not IsNothing(abonodiverso) Then
                abonodiverso.Importe = txtImporte.Text
                txtImporteLetra.Text = abonodiverso.ImporteLetra.ToUpper
                bl = True
                txtImporte.Text = txtImporte.Text
                If Me.txtTipoCambio.Valor = 0 Then
                    ValorGridCuentas(0, 6, txtImporte.Text)
                    Me.txtAbono.Text = txtImporte.Text.ToString("C2")
                    If Me.DgvCuentas.Rows.Count > 1 Then
                        Me.DgvCuentas.Rows(1).Cells("ClmCargo").Value = Me.txtAbono.Text
                        Me.txtCargo.Text = Me.txtAbono.Text
                    End If
                Else
                    ValorGridCuentas(0, 6, txtImporte.Text * txtTipoCambio.Valor)
                    Me.txtAbono.Text = (txtImporte.Text * txtTipoCambio.Valor).ToString("C2")
                    If Me.DgvCuentas.Rows.Count > 1 Then
                        Me.DgvCuentas.Rows(1).Cells("ClmCargo").Value = Me.txtAbono.Text
                        Me.txtCargo.Text = Me.txtAbono.Valor.ToString("C2")
                    End If
                End If
                Me.DgvCuentas.Rows(0).Cells("ClmAbono").Value = (txtImporte.Text * txtTipoCambio.Valor).ToString("C2")
                bl = False
            End If
        End If
    End Sub
#End Region

#Region " FlexGrid "
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

    'ojo
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
    '        Case 6
    '            If VerificarBalance() < 0 Then
    '                ValorFlexGrid(e.Row, e.Col, 0)
    '                MessageBox.Show("La suma de los Cargos sobrepasa a la suma de los Abonos.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    '                    If (VerificarBalance() = 0) And ValorFlexGrid(e.Row, 6) = 0 Then e.Cancel = True
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
    '            BuscarCuentas.Bancos = CheckState.Unchecked
    '            BuscarCuentas.Afectables = CheckState.Checked
    '            If BuscarCuentas.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                If fg.RowSel > 1 Then
    '                    Dim cta As New ClasesNegocios.CuentaContableClass
    '                    cta = BuscarCuentas.CuentaContable
    '                    RellenarFilaFlexGrid(fg.Rows(fg.RowSel), cta)
    '                End If
    '            End If
    '    End Select
    'End Sub

    Private Sub LimpiarGridCuentas()
        Me.DgvCuentas.Rows.Clear()
        'fg.Rows.RemoveRange(1, fg.Rows.Count - 1)
    End Sub

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

    'Private Sub LimpiarFlexGrid()
    '    fg.Rows.RemoveRange(1, fg.Rows.Count - 1)
    'End Sub

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
        'ojo
        'For Each r As C1.Win.C1FlexGrid.Row In fg.Rows
        '    If r.Index > 0 Then
        '        Cargos += r(6)
        '        Abonos += r(7)
        '    End If
        'Next
        txtAbono.Text = Abonos
        txtCargo.Text = Cargos
        Return Abonos - Cargos
    End Function

    Private Sub GenerarPoliza()
        Try
            abonodiverso.PolizaCancelacion = Nothing
            Dim Empresa As New CN.EmpresaClass(Controlador.Sesion.MiEmpresa.Empndx)
            Dim Poliza As New CN.PolizaClass
            Poliza.Concepto = "CANCELACION DE " + txtConcepto.Text
            Poliza.Empresa = Empresa
            Poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.ACTIVA
            Poliza.FechaCaptura = Now
            Poliza.FechaPoliza = Now
            Poliza.Importe = txtImporte.Text
            Poliza.Origen = ClasesNegocio.PolizaOrigenEnum.BANCOS
            Poliza.TipoCambio = txtTipoCambio.Text
            Poliza.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.CANCELACION
            Poliza.TipoError = 0
            Poliza.Referencia = abonodiverso.Poliza.Codigo
            'ojo
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
            abonodiverso.PolizaCancelacion = Poliza
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK)
        End Try

    End Sub

    '' FECHA 25/05/2018 deprecated''
    'Private Sub MostrarPolizaFlexGrid(ByVal Poliza As CN.PolizaClass)
    '    LimpiarGridCuentas()
    '    For i As Integer = 0 To Poliza.Detalles.Count - 1
    '        'Me.DgvCuentas.Rows.Add()
    '        If i > 0 Then
    '            Me.RellenarGridCtasProveedor(Poliza.Detalles(i).CuentaContable)
    '        Else
    '            RellenarGridCuentas(Poliza.Detalles(i).CuentaContable)
    '        End If
    '        If Poliza.Detalles(i).Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO Then
    '            Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = Poliza.Detalles(i).Importe.ToString("C2")
    '        Else
    '            Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = Poliza.Detalles(i).Importe.ToString("C2")
    '        End If
    '    Next
    '    txtPoliza.Text = Poliza.NumeroPoliza
    'End Sub

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
        BuscarCheques.TipoMovimientos = ClasesNegocio.BancosMovimientosTipo.ABONO_DIVERSO
        Dim bol As Boolean = True
        If BuscarCheques.ShowDialog = Windows.Forms.DialogResult.OK Then
            abonodiverso = BuscarCheques.Cheque
            Mostrar()
            LimpiarGridCuentas()
            RellenarCuentasStore(abonodiverso.IdPoliza)
            bol = False
        End If
        Cancelar = bol
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

    '' Usado para llenar el grid de cuentas mediante el SP ConsultaProrrateo
    Private Sub RellenarCuentasStore(ByVal idPoliza As Integer)
        Try
            Dim i As Integer = 0
            Dim datos As New DataSet
            Dim query = "EXEC  ConsultaProrrateo {0}"
            query = String.Format(query, idPoliza)
            Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
                Dim adapter As New SqlDataAdapter()
                adapter.SelectCommand = New SqlCommand(query, connection)
                adapter.Fill(datos)
            End Using
            LimpiarGridCuentas()
            For Each row As DataRow In datos.Tables(0).Rows
                Me.DgvCuentas.Rows.Add()
                Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = row("Cta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = row("SubCta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = row("SSubCta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = row("SSSubCta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = row("NomCuenta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = row("Cargo").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = row("Abono").ToString()

                Me.DgvCuentas.Rows(i).Cells("idCuentaContable").Value = row("IdCuentaContable").ToString()
                Me.DgvCuentas.Rows(i).Cells("posicion").Value = row("Posicion").ToString()

                i = i + 1
            Next

        Catch ex As Exception
            MessageBox.Show("No se pudo cargar el Grid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '' Remueve los datos de prorrateo de la poliza en las tablas GastosDepartamentalesFG y GastosDepartamentosDetFG
    Private Function RemoverProrrateo(idpoliza As Integer) As Boolean
        Try
            Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
                Dim query = "EXEC RemoverDepartamentalizacion " & idpoliza
                Dim command As New SqlCommand
                command.Connection = connection
                command.CommandText = query

                Dim errorValue As Integer
                Dim errorMessage As String

                connection.Open()
                Dim readCommand As SqlDataReader = command.ExecuteReader()
                readCommand.Read()
                errorValue = CInt(readCommand(0))
                errorMessage = CStr(readCommand(1))
                readCommand.Close()

                If errorValue > 0 Then
                    MessageBox.Show(errorMessage, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK)
                    Return False
                End If

                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK)
            Return False
        End Try
    End Function
End Class