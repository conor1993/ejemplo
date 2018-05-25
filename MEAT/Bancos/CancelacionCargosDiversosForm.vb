Imports CN = ClasesNegocio
Imports Integra.Clases
Imports HC = IntegraLab.ORM.HelperClasses
Imports System.Data.SqlClient

Public Class CancelacionCargosDiversosForm
    Implements InterfaceForm


#Region " Declaraciones "
    Private WithEvents cargodiverso As CN.ChequeClass
    Private seleccion As New Integra.Clases.BusquedaClass(Of CN.ChequeClass)
    Private CtasCont As New CN.CuentaContableCollectionClass
    Private Cuentas As New CN.CuentaCollectionClass
    Private Cuenta As CN.CuentaClass
    Private chkEstatus As CondicionEnum = CondicionEnum.ACTIVOS
    Private TipoCambio As CN.TipoCambioClass
    Dim MovBancos As CN.MovimientosBancosClass
#End Region

    Private Sub CancelacionCargosDiversosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        CargosDiversos.Obtener(ClasesNegocio.BancosMovimientosTipo.RETIRO, chkEstatus)
        RellenarBancos()
        RellenarBeneficiarios()
        Lectura()
        LimpiarBancos()
        LimpiarBeneficiarios()
        Me.txtCargo.Enabled = False
        Me.txtAbono.Enabled = False
    End Sub

#Region " Rellenar "
    Private Sub LimpiarBancos()
        txtBanco.Clear()
        cmbBanco.SelectedIndex = -1
        cmbBanco.Text = "Seleccione un Banco..."
        txtSaldo.Text = "0.00"
        txtImporte.Text = "0.00"
        txtCargo.Text = 0
        txtAbono.Text = 0
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
        ' Me.txtCodBeneficiario.Clear()
        ' cmbBeneficiario.SelectedIndex = -1
        ' cmbBeneficiario.Text = "Seleccione un Beneficiario..."
    End Sub

    Private Sub RellenarBeneficiarios()
        Beneficiarios.Obtener(CondicionEnum.ACTIVOS)
        ' txtBeneficiario.AutoCompleteSource = AutoCompleteSource.CustomSource
        ' txtBeneficiario.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ' txtBeneficiario.AutoCompleteCustomSource.AddRange(Beneficiarios.Listar)
    End Sub

    Private Sub cmbBeneficiario_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ' If cmbBeneficiario.SelectedIndex > -1 Then
        '  txtBeneficiario.Text = cmbBeneficiario.SelectedValue
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
        If Not IsNothing(cargodiverso) Then
            cargodiverso.Cuenta = Cuenta
            txtImporte.Text = cargodiverso.Importe
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
        Me.txtCargo.Text = "0.00"
        Me.txtAbono.Text = "0.00"
    End Sub

    Public Sub Mostrar() Implements InterfaceForm.Mostrar
        txtBanco.Text = cargodiverso.Cuenta.Banco.Descripcion
        'modificacion
        'ojo
        cmbBanco.SelectedValue = cargodiverso.Cuenta.Banco.DescripcionCta 'Me.cmbBanco.SelectedValue = cargodiverso.Cuenta.Banco.Clave
        'termina modificacion
        RellenarCuentas()
        For Each item As ListViewItem In lv.Items
            If IsNothing(item.Tag) And IsNothing(cargodiverso.Cuenta) Then
                item.Selected = True
                txtCuenta.Text = String.Format("{0} - {1}")
                txtSaldo.Text = "0.00".ToString("C")
            ElseIf Not IsNothing(item.Tag) And Not IsNothing(cargodiverso.Cuenta) Then
                Dim tmp As CN.CuentaClass = DirectCast(item.Tag, CN.CuentaClass)
                If tmp.Cuenta = cargodiverso.Cuenta.Cuenta Then
                    item.Selected = True
                    Cuenta = tmp
                    txtCuenta.Text = String.Format("{0} - {1}", item.SubItems(0).Text, item.SubItems(1).Text)
                    txtSaldo.Text = Cuenta.SaldoActual.ToString("C")
                End If
            End If
        Next
        ' Me.txtCodBeneficiario.Text = ""
        ' Me.cmbBeneficiario.Text = cargodiverso.Beneficiario.Beneficiario
        dtp.Value = cargodiverso.FechaDocumento
        txtImporte.Text = cargodiverso.Importe
        Me.txtTipoCambio.Text = cargodiverso.TipoCambio
        txtConcepto.Text = cargodiverso.Concepto
        chkAnticipo.Checked = cargodiverso.Anticipo
        Select Case cargodiverso.Medio
            Case ClasesNegocio.BancosMovimientosMedio.CHEQUE
                chkElectronico.Checked = False

            Case ClasesNegocio.BancosMovimientosMedio.ELECTRONICO
                chkElectronico.Checked = True
        End Select
        txtReferencia.Text = cargodiverso.Folio
        ' txtFolio.Text = cargodiverso.Folio
        Me.lblEstatus.Text = cargodiverso.Estatus.ToString
        Me.lblEstatus.Visible = True
        MostrarPolizaFlexGrid(cargodiverso.Poliza)
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
            cargodiverso.Anticipo = chkAnticipo.Checked
            '  cargodiverso.Beneficiario = DirectCast(cmbBeneficiario.SelectedItem, CN.BeneficiarioClass)
            cargodiverso.Concepto = txtConcepto.Text
            cargodiverso.Cuenta = Cuenta
            cargodiverso.FechaDocumento = dtp.Value
            cargodiverso.Folio = txtReferencia.Text
            cargodiverso.Importe = txtImporte.Valor
            cargodiverso.Origen = ClasesNegocio.BancosMovimientosOrigen.BANCOS
            cargodiverso.Resguardo = SiNoEnum.SI
            cargodiverso.TipoCambio = txtTipoCambio.Valor
            cargodiverso.TipoMovimiento = ClasesNegocio.BancosMovimientosTipo.RETIRO
        End If
        Return Cadena
    End Function
#End Region

#Region " ToolBar "
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "CancelacionPago")
        Try
            Dim SaldoAnterior As Decimal = cargodiverso.Cuenta.SaldoActual

            If MsgBox("Desea cancelar el Cargo Diverso", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                Exit Sub
            End If
            If cargodiverso.Estatus = Integra.Clases.EstatusEnum.INACTIVO Then
                MsgBox("El Cargo Diverso ya ha sido Cancelado...")
                Limpiar()
                Lectura()
                Exit Sub
            Else
                If cargodiverso.Entregado = True Then
                    MsgBox("El Cargo Diverso no puede ser borrado, ya fué Entregado...")
                Else
                    GenerarPoliza()
                    If cargodiverso.Borrar(Trans) Then
                        MovBancos = New CN.MovimientosBancosClass() '(cargodiverso.Poliza.Codigo, cargodiverso.Cuenta.Codigo)
                        MovBancos.NumPoliza = cargodiverso.PolizaCancelacion.Codigo
                        MovBancos.FechaCaptura = Now
                        MovBancos.FechaMov = Now
                        MovBancos.Concepto = cargodiverso.PolizaCancelacion.Concepto
                        MovBancos.CveCancelacion = "S"
                        MovBancos.Referencia = cargodiverso.Poliza.Codigo
                        MovBancos.CtaBancaria = cargodiverso.Cuenta.Codigo
                        MovBancos.SaldoAnterior = SaldoAnterior
                        MovBancos.Cargo_Abono = ClasesNegocio.PolizaOperacionEnum.CARGO
                        MovBancos.TipoMov = "D"
                        MovBancos.Origen = "B"
                        MovBancos.TipoCambio = CDec(Me.txtTipoCambio.Text)
                        MovBancos.Importe = cargodiverso.Importe

                        If Not MovBancos.Guardar(Trans) Then
                            Trans.Rollback()
                            Cancelar = True
                            MsgBox("El Cargo Diverso no pudo ser Cancelado...", MsgBoxStyle.Critical, "Error")
                            Exit Sub
                        End If

                        If Not RemoverProrrateo(cargodiverso.Poliza.Codigo) Then
                            Trans.Rollback()
                            Cancelar = True
                            Exit Sub
                        End If

                        Cuenta.SaldoActual -= MovBancos.Importe
                        Trans.Add(Cuenta.ObtenerEntidad)
                        Cuenta.ObtenerEntidad.Save()


                        Trans.Commit()

                        MsgBox("El Cargo Diverso ha sido Cancelado Satisfactoriamente...", MsgBoxStyle.Information, "Aviso")
                        Limpiar()
                        Lectura()
                    Else
                        Trans.Rollback()
                        Cancelar = True
                        MsgBox("El Cargo Diverso no pudo ser Cancelado...", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End If
                End If
            End If
            Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
            CargosDiversos.Obtener(ClasesNegocio.BancosMovimientosTipo.RETIRO, chkEstatus)
        Catch ex As Exception
            Trans.Rollback()
            Cancelar = True
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK)
            '#If CONFIG = "Debug" Then
            '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            '#Else
            '            msgbox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
            '#End If
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        cargodiverso = Nothing
        Lectura()
        Limpiar()
        CargosDiversos.Obtener(ClasesNegocio.BancosMovimientosTipo.RETIRO, chkEstatus)
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        'Escritura()
        MessageBox.Show("No esta habilitada la edición para este modulo.", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Cancelar = True
        If IsNothing(Validar()) Then
            If VerificarBalance() = 0 Then
                Dim bbl As Boolean
                If (txtSaldo.Valor - txtImporte.Valor) < 0 Then
                    bbl = False
                    If MessageBox.Show("El importe de este cheque sobrepasa el saldo en la cuenta, ¿Desea continuar con la generación del Cheque?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then bbl = True
                Else
                    bbl = True
                End If

                If bbl Then
                    GenerarPoliza()
                    If cargodiverso.Guardar() Then
                        MessageBox.Show(String.Format("Número de Poliza Generado:{0}{1}", vbCrLf, cargodiverso.Poliza.NumeroPoliza), "Poliza Generada", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        CargosDiversos.Obtener(ClasesNegocio.BancosMovimientosTipo.RETIRO, chkEstatus)
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Escritura()
        cargodiverso = New ClasesNegocio.ChequeClass
        Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        If Not IsNothing(cargodiverso) Then
            'ImprimirCheque.Cheque = cheque
            'ppDg.ShowDialog()
            If Not cargodiverso.Emitido Then
                If cargodiverso.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO Then
                    PagoElectronico.Cheque = cargodiverso
                    pDg.Document = PagoElectronico
                    If pDg.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Try
                            PagoElectronico.Print()
                            If MessageBox.Show("¿Se imprimio el comprobante?", "Confirmación de Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                PagoElectronico.ImpresionExitosa()
                                cargodiverso.Guardar()
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                Else
                    If MessageBox.Show("¿Desea imprimir el cheque?", "Confirmación de Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        ImprimirCheque.Cheque = cargodiverso
                        ImprimirCheque.AbonoEnCuenta = MessageBox.Show("¿Es para abono en cuenta?", "Tipo de Cheque", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                        pDg.Document = ImprimirCheque
                        If pDg.ShowDialog = Windows.Forms.DialogResult.OK Then
                            Try
                                ImprimirCheque.Print()
                                If MessageBox.Show("¿Se imprimio el cheque?", "Confirmación de Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                    ImprimirCheque.ImpresionExitosa()
                                    cargodiverso.Guardar()
                                End If
                            Catch ex As Exception
                                MessageBox.Show(ex.Message, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End If
                    End If
                End If
            Else
                If Not cargodiverso.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO Then MessageBox.Show(String.Format("Este cheque ya fue emitido el {0}.", cargodiverso.FechaEmision.ToString("dd MMM' de 'yyyy"), "Cheque ya emitido", MessageBoxButtons.OK, MessageBoxIcon.Error))
            End If
        End If
    End Sub
#End Region

#Region " Otros "
    Private Sub cargodiverso_Mensajes(ByVal sender As Object, ByVal Message As ClasesNegocio.MensajeClass) Handles cargodiverso.Mensajes
        MessageBox.Show(Message.Mensaje, Message.Titulo, MessageBoxButtons.OK, Message.Tipo)
    End Sub

    Private Sub chkElectronico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkElectronico.CheckedChanged
        txtReferencia.Visible = chkElectronico.Checked
        lblRef.Visible = chkElectronico.Checked
        If chkElectronico.Checked Then
            cargodiverso.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO
        Else
            cargodiverso.Medio = ClasesNegocio.BancosMovimientosMedio.CHEQUE
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
            If Not IsNothing(cargodiverso) Then
                cargodiverso.Importe = txtImporte.Valor
                txtImporteLetra.Text = cargodiverso.ImporteLetra.ToUpper
                bl = True
                txtImporte.Text = txtImporte.Valor.ToString("C")
                If Me.txtTipoCambio.Valor = 0 Then
                    ValorGridCuentas(0, 6, txtImporte.Valor)
                    Me.txtAbono.Text = txtImporte.Valor.ToString("C2")
                    If Me.DgvCuentas.Rows.Count > 1 Then
                        Me.DgvCuentas.Rows(1).Cells("ClmCargo").Value = Me.txtAbono.Text
                        Me.txtCargo.Text = Me.txtAbono.Text
                    End If
                Else
                    ValorGridCuentas(0, 6, txtImporte.Valor * txtTipoCambio.Valor)
                    Me.txtAbono.Text = (txtImporte.Valor * txtTipoCambio.Valor).ToString("C2")
                    If Me.DgvCuentas.Rows.Count > 1 Then
                        Me.DgvCuentas.Rows(1).Cells("ClmCargo").Value = Me.txtAbono.Text
                        Me.txtCargo.Text = Me.txtAbono.Valor.ToString("C2")
                    End If
                End If
                'Me.DgvCuentas.Rows(0).Cells("ClmAbono").Value = (txtImporte.Valor * txtTipoCambio.Valor).ToString("C2")
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
            cargodiverso.PolizaCancelacion = Nothing
            Dim Empresa As New CN.EmpresaClass(Controlador.Sesion.MiEmpresa.Empndx)
            Dim Poliza As New CN.PolizaClass
            Poliza.Concepto = "CANCELACION DE " + txtConcepto.Text
            Poliza.Empresa = Empresa
            Poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.ACTIVA
            Poliza.FechaCaptura = Now
            Poliza.FechaPoliza = Now
            Poliza.Importe = txtImporte.Valor
            Poliza.Origen = ClasesNegocio.PolizaOrigenEnum.BANCOS
            Poliza.TipoCambio = txtTipoCambio.Text
            Poliza.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.CANCELACION
            Poliza.TipoError = 0
            Poliza.Referencia = cargodiverso.Poliza.Codigo
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
            cargodiverso.PolizaCancelacion = Poliza
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub MostrarPolizaFlexGrid(ByVal Poliza As CN.PolizaClass)
        LimpiarGridCuentas()
        'For i As Integer = 0 To Poliza.Detalles.Count - 1
        '    'Me.DgvCuentas.Rows.Add()
        '    If i > 0 Then
        '        Me.RellenarGridCtasProveedor(Poliza.Detalles(i).CuentaContable)
        '    Else
        '        RellenarGridCuentas(Poliza.Detalles(i).CuentaContable)
        '    End If
        '    If Poliza.Detalles(i).Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO Then
        '        Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = Poliza.Detalles(i).Importe.ToString("C2")
        '    Else
        '        Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = Poliza.Detalles(i).Importe.ToString("C2")
        '    End If
        'Next
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
        BuscarCheques.TipoMovimientos = ClasesNegocio.BancosMovimientosTipo.CARGO_DIVERSO
        Dim bol As Boolean = True
        If BuscarCheques.ShowDialog = Windows.Forms.DialogResult.OK Then
            cargodiverso = BuscarCheques.Cheque
            Mostrar()
            LimpiarGridCuentas()
            RellenarCuentasstore(cargodiverso.IdPoliza)
            bol = False
        End If
        Cancelar = bol
    End Sub

    Private Sub DgvCuentas_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCuentas.CellValueChanged
        If Me.txtImporte.Text <> "" Then
            If txtImporte.Valor > 0 Then
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
    Private Sub RellenarCuentasstore(ByVal idPoliza As Integer)
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