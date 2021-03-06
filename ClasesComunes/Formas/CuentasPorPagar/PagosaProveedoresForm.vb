Imports CN = ClasesNegocio
Imports Integra.Clases
Imports HC = Integralab.ORM.HelperClasses
Imports System.Windows.Forms

Public Class PagosaProveedoresForm
    Implements InterfaceForm
    Dim IdBanco As Integer

#Region " Declaraciones "
    Private WithEvents cheque As CN.ChequeClass
    Private seleccion As New Integra.Clases.BusquedaClass(Of CN.ChequeClass)
    Private CtasCont As New CN.CuentaContableCollectionClass
    Private Cuentas As New CN.CuentaCollectionClass
    Private Cuenta As CN.CuentaClass
    Private CtaIva, CtaRetISR, CtaRetIva As CN.CuentaContableClass
    Private chkEstatus As CN.EstatusEnum = CN.EstatusEnum.ACTIVO
    Private TipoCambio As CN.TipoCambioClass
    Private Proveedor As CN.ProveedorClass
    Private Cuen As CN.CuentaClass
    Private NoFacturas As Boolean 'para validar qe haya facturas seleccionadas
    Private UltimaTeclaBen As Date
    Private Buscar As Boolean
    Private Facturas As String 'Para qe aparezcan las facturas qe se pagaron como concepto
    'Private PagoProv As CN.PagosProveedoresClass
#End Region

    Private Sub PagosaProveedoresForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblTitulo.Text = Me.Text.ToUpper
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = ""
        MtbEstados.StateCancelar = "100100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "110100011"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010000"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        mtb.ToolBarButtonStatus = MtbEstados
        Me.mtb.Buttons(0).ToolTipText = "Busca los Registros de Cheque Registrados"
        Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
        Me.mtb.Buttons(3).ToolTipText = "Cancela la acci�n actual."
        Me.mtb.Buttons(5).ToolTipText = "Crea un nuevo Registro de cheque."
        Me.mtb.Buttons(6).ToolTipText = "Guarda el Registro de Cheque o los cambios que se le hayan Realizado."
        'Me.mtb.Buttons(7).ToolTipText = "Cambia el estatus del Banco."
        'Me.mtb.Buttons(8).ToolTipText = "Permite Modificar el Banco."
        Me.mtb.Buttons(10).ToolTipText = "Imprime Los resgistros de Cheques Registrados."
        Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."

        Dim Err As Boolean = False
        Dim confi As New CN.ConfiguracionCtasCtrolColeccion
        If confi.Obtener(26) > 0 Then CtaIva = confi(0).CuentaContable Else Err = True
        confi.Clear()
        If confi.Obtener(20) > 0 Then CtaRetISR = confi(0).CuentaContable Else Err = True
        confi.Clear()
        If confi.Obtener(21) > 0 Then CtaRetIva = confi(0).CuentaContable Else Err = True
        confi.Clear()
        If Err Then
            MsgBox("Debe configurar las cuentas contables para IVA pagado a proveedores, Retenci�n de ISR y Retenci�n de IVA" + vbNewLine + "en Cat�logos - Contabilidad - Configuraci�n de cuentas de control.", MsgBoxStyle.Information, "Aviso")
        End If

        mtb.sbCambiarEstadoBotones("Cancelar")

        Cheques.Obtener(ClasesNegocio.BancosMovimientosTipo.RETIRO, chkEstatus)
        RellenarBancos()
        RellenarBeneficiarios()
        Lectura()
        LimpiarBancos()
        LimpiarBeneficiarios()
    End Sub

#Region " Metodos "
    Public Sub Escritura() Implements InterfaceForm.Escritura
        pan.Enabled = True
        Me.DgvCuentas.Enabled = True ' fg.Enabled = True
        Me.DgvFacturas.Enabled = True
        Me.txtConcepto.Enabled = False
    End Sub

    Public Sub Lectura() Implements InterfaceForm.Lectura
        pan.Enabled = False
        Me.DgvCuentas.Enabled = False ' fg.Enabled = False
        Me.DgvFacturas.Enabled = False
    End Sub

    Public Sub Limpiar() Implements InterfaceForm.Limpiar
        LimpiarBancos()
        LimpiarBeneficiarios()
        dtp.Value = Now
        txtImporte.Text = "0"
        txtSaldo.Text = "0"
        txtConcepto.Clear()
        txtImporteLetra.Clear()
        txtCuenta.Clear()
        txtFolio.Clear()
        txtReferencia.Clear()
        txtPoliza.Clear()
        txtCargo.Text = "0"
        txtAbono.Text = "0"
        txtTipoCambio.Text = "0"
        chkElectronico.Checked = False
        Me.DgvFacturas.DataSource = Nothing
        NoFacturas = False
        Buscar = False
        Me.DgvFacturas.Columns(3).DataPropertyName = "ImporteAbono"
        Me.DgvFacturas.Columns(4).DataPropertyName = "ImporteTotal"
        Me.DgvFacturas.Columns(5).DataPropertyName = "Saldo"
        Me.DgvFacturas.Columns(6).DataPropertyName = "ImporteaPagar"
    End Sub

    Public Sub Mostrar() Implements InterfaceForm.Mostrar
        'ojo
        cmbBanco.SelectedValue = cheque.Cuenta.Banco.DescripcionCta
        RellenarCuentas()
        For Each item As ListViewItem In lv.Items
            If IsNothing(item.Tag) And IsNothing(cheque.Cuenta) Then
                item.Selected = True
                txtCuenta.Text = String.Format("{0} - {1}")
                txtSaldo.Text = (0D).ToString("C").ToString
            ElseIf Not IsNothing(item.Tag) And Not IsNothing(cheque.Cuenta) Then
                Dim tmp As CN.CuentaClass = DirectCast(item.Tag, CN.CuentaClass)
                If tmp.Cuenta = cheque.Cuenta.Cuenta Then
                    item.Selected = True
                    Cuenta = tmp
                    txtCuenta.Text = String.Format("{0} - {1}", item.SubItems(0).Text, item.SubItems(1).Text)
                    txtSaldo.Text = Cuenta.SaldoActual.ToString("C")
                End If
            End If
        Next
        txtBeneficiario.Text = cheque.Beneficiario.Beneficiario
        dtp.Value = cheque.FechaDocumento
        txtImporte.Text = cheque.Importe.ToString
        txtConcepto.Text = cheque.Concepto
        ' chkAnticipo.Checked = cheque.Anticipo
        Select Case cheque.Medio
            Case ClasesNegocio.BancosMovimientosMedio.CHEQUE
                chkElectronico.Checked = False

            Case ClasesNegocio.BancosMovimientosMedio.ELECTRONICO
                chkElectronico.Checked = True
        End Select
        txtReferencia.Text = cheque.Folio
        txtFolio.Text = cheque.Folio
        MostrarPolizaFlexGrid(cheque.Poliza)
        'Obtener las facturas 
        Dim Pago As New Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection
        Pago.GetMulti(Integralab.ORM.HelperClasses.UsrCxppagosProveedoresFields.EmpresaId = Controlador.Sesion.Empndx And Integralab.ORM.HelperClasses.UsrCxppagosProveedoresFields.Cheque = cheque.Folio)
        Dim Fac As New Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
        Dim Facs As New Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
        Me.DgvFacturas.AutoGenerateColumns = False
        For i As Integer = 0 To Pago.Count - 1
            Fac.GetMulti(HC.UsrCxpfacturasCabFields.EmpresaId = Controlador.Sesion.Empndx And Integralab.ORM.HelperClasses.UsrCxpfacturasCabFields.NoFactura = Pago(i).NoFactura)
            Facs.Add(Fac(0))
            Me.DgvFacturas.DataSource = Facs
            Me.DgvFacturas.Rows(i).Cells("ClmApagar").Value = Pago(i).Importe
        Next
        Me.DgvFacturas.Columns(3).DataPropertyName = "Anticipo"
        Me.DgvFacturas.Columns(4).DataPropertyName = "Total"
        Me.DgvFacturas.Columns(5).DataPropertyName = "Saldo"
        Me.DgvFacturas.Columns(6).DataPropertyName = ""

        For i As Integer = 0 To Pago.Count - 1
            Me.DgvFacturas.Rows(i).Cells("ClmApagar").Value = Pago(i).Importe
        Next
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
        If txtBeneficiario.Text.Replace(" ", "").Length = 0 Then
            Cadena &= "* Beneficiario" & vbCrLf
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
        If NoFacturas = False Then
            Cadena &= "* Facturas a Pagar" & vbCrLf
            Bl = True
        End If
        If Not Bl Then
            Cadena = Nothing
            'cheque.Anticipo = chkAnticipo.Checked
            cheque.Beneficiario = DirectCast(cmbBeneficiario.SelectedItem, CN.BeneficiarioClass)
            For i As Integer = 0 To Me.DgvFacturas.Rows.Count - 1
                If CBool(Me.DgvFacturas.Rows(i).Cells("ClmPagar").Value) Then
                    Facturas = Facturas & String.Format(" {0}", Me.DgvFacturas.Rows(i).Cells("clmNoFactura").Value)
                End If
                Me.txtConcepto.Text = Facturas
            Next
            cheque.Concepto = txtConcepto.Text
            cheque.Cuenta = Cuenta
            cheque.FechaDocumento = dtp.Value
            cheque.Folio = txtReferencia.Text
            cheque.Importe = txtImporte.Valor
            cheque.Origen = ClasesNegocio.BancosMovimientosOrigen.PAGOPROVEEDORES
            cheque.Resguardo = SiNoEnum.SI
            cheque.TipoCambio = txtTipoCambio.Valor
            cheque.TipoMovimiento = ClasesNegocio.BancosMovimientosTipo.RETIRO
        End If
        Return Cadena
    End Function
#End Region

#Region "Rellenar"
    Private Sub LimpiarBancos()
        txtBanco.Clear()
        cmbBanco.SelectedIndex = -1
        cmbBanco.Text = "Seleccione un Banco..."
        txtSaldo.Text = "0.00"
        txtImporte.Text = "0.00"
        lv.Items.Clear()
        LimpiarGridCuentas()
    End Sub

    Private Sub RellenarBancos()
        Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
        txtBanco.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtBanco.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtBanco.AutoCompleteCustomSource.AddRange(Bancos.Listar)
    End Sub

    Private Sub cmbBanco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBanco.SelectedIndexChanged
        If cmbBanco.SelectedIndex > -1 Then
            txtBanco.Text = Me.cmbBanco.SelectedValue.ToString
            Dim banco As CN.BancosClass = DirectCast(cmbBanco.SelectedItem, CN.BancosClass)
            'ojo
            IdBanco = banco.Codigo
            Cuentas.Obtener(banco.Codigo, ClasesNegocio.EstatusEnum.ACTIVO)
            'Cuentas = banco.Cuentas
            RellenarCuentas()
        End If
    End Sub

    Private Sub txtBanco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBanco.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
        End Select
    End Sub

    Private Sub txtBanco_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBanco.TextChanged
        cmbBanco.SelectedValue = txtBanco.Text
    End Sub

    Private Sub LimpiarBeneficiarios()
        txtBeneficiario.Clear()
        cmbBeneficiario.SelectedIndex = -1
        cmbBeneficiario.Text = "Seleccione un Beneficiario..."
    End Sub

    Private Sub RellenarBeneficiarios()
        Beneficiarios.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, True)
        txtBeneficiario.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtBeneficiario.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtBeneficiario.AutoCompleteCustomSource.AddRange(Beneficiarios.Listar)
    End Sub

    Private Sub cmbBeneficiario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbBeneficiario.KeyPress
        Me.TmBeneficiario.Stop()
        Me.UltimaTeclaBen = Now
        Me.TmBeneficiario.Start()
    End Sub

    Private Sub LimpiarRow()
        Me.DgvCuentas.Rows(0).Cells("ClmCtaMayor").Value = ""
        Me.DgvCuentas.Rows(0).Cells("ClmSubCta").Value = ""
        Me.DgvCuentas.Rows(0).Cells("ClmSsbCta").Value = ""
        Me.DgvCuentas.Rows(0).Cells("ClmSssCta").Value = ""
        Me.DgvCuentas.Rows(0).Cells("ClmDescripcion").Value = ""
        Me.DgvCuentas.Rows(0).Cells("ClmCargo").Value = 0
        Me.DgvCuentas.Rows(0).Cells("ClmAbono").Value = 0
    End Sub

    Private Sub cmbBeneficiario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBeneficiario.SelectedIndexChanged
        Dim Ben As New CN.BeneficiarioCollectionClass
        If cmbBeneficiario.SelectedIndex > -1 Then
            txtBeneficiario.Text = cmbBeneficiario.SelectedValue.ToString
            Ben.Obtener2(CType(Me.cmbBeneficiario.SelectedValue, Integer))

            If Ben.Count > 0 Then
                If Not IsNothing(Ben(0).Proveedor) Then
                    Proveedor = Ben(0).Proveedor
                    Me.txtConcepto.Clear()
                    Facturas = String.Format("PAGO A PROVEEDOR #{0}", Ben(0).Proveedor.Codigo)
                    Me.txtConcepto.Text = Facturas
                    If Not IsNothing(Ben(0).Proveedor.CuentaContable2) Then
                        'ojo
                        If Ben(0).Proveedor.CuentaContable2.Codigo = 0 Then
                            MsgBox("El Proveedor(Beneficiario) No tiene Cuenta Contable, Imposible realizar el Pago...", MsgBoxStyle.Information, "Aviso")
                            If Me.DgvCuentas.Rows(0).Cells("ClmCtaMayor").Value.ToString <> "" Then
                                LimpiarRow()
                            End If
                            Me.txtConcepto.Text = ""
                            LimpiarBeneficiarios()
                        Else
                            'RellenarGridCtasProveedor(Ben(0).Proveedor.CuentaContable2)
                            RellenarGridCuentas(Ben(0).Proveedor.CuentaContable2, "PROV", 0, 0)
                        End If
                    Else
                        MsgBox("El Proveedor(Beneficiario) No tiene Cuenta Contable, Imposible realizar el Pago...", MsgBoxStyle.Information, "Aviso")
                        If Me.DgvCuentas.Rows.Count > 1 Then
                            Me.DgvCuentas.Rows.RemoveAt(1)
                        End If
                    End If
                    'Ben(0).Proveedor.CuentaContable
                    If Buscar = False Then
                        Dim Fac As New Integralab.ORM.CollectionClasses.UsrCxpfacturasApagarCollection
                        Me.DgvFacturas.AutoGenerateColumns = False
                        Fac.GetMulti(HC.UsrCxpfacturasApagarFields.EmpresaId = Controlador.Sesion.Empndx And HC.UsrCxpfacturasApagarFields.Estatus = CN.EstatusFacturasApagar.AUTORIZADA And HC.UsrCxpfacturasApagarFields.IdProveedor = Ben(0).Proveedor.Codigo)
                        Me.DgvFacturas.DataSource = Fac
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtBeneficiario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBeneficiario.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                Beneficiarios.Obtener(CN.CondicionEnum.ACTIVOS)
        End Select
    End Sub

    Private Sub txtBeneficiario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBeneficiario.TextChanged
        'cmbBeneficiario.SelectedValue = txtBeneficiario.Text
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

    Private Sub lv_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lv.SelectedIndexChanged
        Try
            If lv.SelectedItems.Count > 0 Then
                For Each indice As ListViewItem In lv.SelectedItems
                    txtCuenta.Text = String.Format("{0} - {1}", indice.SubItems(0).Text, indice.SubItems(1).Text)
                    Me.cmbBeneficiario.Enabled = True

                    Cuenta = DirectCast(indice.Tag, CN.CuentaClass)
                    If Not IsNothing(Cuenta.CuentaContable) Then
                        'Dim r As C1.Win.C1FlexGrid.Row = fg.Rows.Add
                        'Dim r As New System.Windows.Forms.DataGridViewRow
                        'Me.DgvCuentas.Rows.Add(r)
                        'r.ReadOnly = False
                        '
                        ' Me.DgvCuentas.DataSource = Cuenta.CuentaContable
                        Cuen = Cuenta
                        RellenarGridCuentas(Cuenta.CuentaContable, "BCO", 0, txtImporte.Valor)
                        txtSaldo.Text = Cuenta.SaldoActual.ToString("C")
                        txtFolio.Text = (Cuenta.FolioActual + 1).ToString

                        Dim tc As New CN.TipoCambioCollectionClass

                        If Not Cuenta.TipoMoneda.EsMonedaLocal Then
                            Dim Fecha As New Date(Now.Year, Now.Month, Now.Day)
                            TipoCambio = tc.ObtenerTipoCambio(Cuenta.TipoMoneda, Fecha)
                            If IsNothing(TipoCambio) Then
                                If Not Buscar Then
                                    MessageBox.Show("No existe tipo de cambio registrado, no se puede continuar con el registro.", "No hay tipo de cambio", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    mtb_ClickCancelar(sender, New ToolBarButtonClickEventArgs(mtb.Buttons(2)), False)
                                    mtb.sbCambiarEstadoBotones("Cancelar")
                                Else
                                    If Not IsNothing(TipoCambio) Then
                                        txtTipoCambio.Text = TipoCambio.TipoCambio.ToString
                                    End If
                                End If

                            End If
                        Else
                            txtTipoCambio.Text = "1"
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
            If Not IsNothing(cheque) Then
                cheque.Cuenta = Cuenta
                ' txtImporte.Text = cheque.Importe.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#End Region

#Region "ToollBar"

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Cancelar = True
        If cheque.Borrar() Then
            Limpiar()
            Lectura()
        Else
            Cancelar = True
        End If
        Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
        Cheques.Obtener(ClasesNegocio.BancosMovimientosTipo.RETIRO, chkEstatus)
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        'Dim BuscarCheques As New BuscarChequeForm
        'BuscarCheques.BloquearTiposMovimiento = True
        'BuscarCheques.TipoMovimientos = ClasesNegocio.BancosMovimientosTipo.RETIRO
        'If BuscarCheques.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    cheque = BuscarCheques.Cheque
        '    Buscar = True
        '    Mostrar()
        'End If
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        cheque = Nothing
        Lectura()
        Limpiar()
        Cheques.Obtener(ClasesNegocio.BancosMovimientosTipo.RETIRO, chkEstatus)
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar

    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Tran As New IntegraLab.ORM.HelperClasses.Transaction(IsolationLevel.ReadCommitted, "PagoProveedores")
        Try
            If IsNothing(Validar()) Then
                If VerificarBalance() = 0 Then
                    Dim bbl As Boolean
                    If (txtSaldo.Valor - txtImporte.Valor) < 0 Then
                        bbl = False
                        If MessageBox.Show("El importe de este cheque sobrepasa el saldo en la cuenta, �Desea continuar con la generaci�n del Cheque?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            bbl = True
                        Else
                            Me.Lectura()
                            Me.Limpiar()
                        End If
                    Else
                        bbl = True
                    End If
                    If bbl Then
                        GenerarPoliza()
                        If cheque.Guardar(Tran) Then
                            If GuardarPago(Tran) Then
                                Tran.Commit()
                                MessageBox.Show(String.Format("N�mero de P�liza Generado:{0}{1}", vbCrLf, cheque.Poliza.NumeroPoliza), "Poliza Generada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                mtb_ClickImprimir(sender, e, Cancelar)
                                Limpiar()
                                Lectura()
                                Cancelar = False
                            Else
                                Tran.Rollback()
                                Cancelar = True
                            End If
                        Else
                            Tran.Rollback()
                            Cancelar = True
                        End If
                    End If
                Else
                    MessageBox.Show("No se puede generar el movimiento por que no est� cuadrada la p�liza.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show(Validar, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Cancelar = True
            End If
            Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
            Cheques.Obtener(ClasesNegocio.BancosMovimientosTipo.RETIRO, chkEstatus)
        Catch ex As Exception
            Tran.Rollback()
            Cancelar = True
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        If Not IsNothing(cheque) Then
            ImprimirCheque.Cheque = cheque
            ImprimirCheque.AbonoEnCuenta = MessageBox.Show("�Es para abono en cuenta?", "Tipo de Cheque", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            ImprimirCheque.Banco = IdBanco
            ppDg.ShowDialog()
            If Not cheque.Emitido Then
                If cheque.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO Then
                    PagoElectronico.Cheque = cheque
                    pDg.Document = PagoElectronico
                    If pDg.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Try
                            PagoElectronico.Print()
                            If MessageBox.Show("�Se imprimio el comprobante?", "Confirmaci�n de Impresi�n", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                PagoElectronico.ImpresionExitosa()
                                cheque.Guardar()
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                Else
                    If MessageBox.Show("�Desea imprimir el cheque?", "Confirmaci�n de Impresi�n", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        '                        ImprimirCheque.AbonoEnCuenta = MessageBox.Show("�Es para abono en cuenta?", "Tipo de Cheque", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                        'ImprimirCheque.Banco = IdBanco
                        'ImprimirCheque.Cheque = cheque                        
                        Me.ppDg.Close()
                        pDg.Document = ImprimirCheque
                        If pDg.ShowDialog = Windows.Forms.DialogResult.OK Then
                            Try
                                ImprimirCheque.Print()
                                If MessageBox.Show("�Se imprimio el cheque?", "Confirmaci�n de Impresi�n", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                    ImprimirCheque.ImpresionExitosa()
                                    '
                                    'cheque.Guardar()
                                    cheque.ObtenerEntidad.Save()
                                End If
                            Catch ex As Exception
                                MessageBox.Show(ex.Message, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End If
                    End If
                End If
            Else
                If Not cheque.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO Then MessageBox.Show(String.Format("Este cheque ya fue emitido el {0}.", cheque.FechaEmision.ToString("dd MMM' de 'yyyy"), "Cheque ya emitido", MessageBoxButtons.OK, MessageBoxIcon.Error))
            End If
        End If
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Escritura()
        cheque = New ClasesNegocio.ChequeClass
        Proveedor = New CN.ProveedorClass
        Beneficiarios.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        Me.cmbBeneficiario.SelectedIndex = -1
        Me.cmbBeneficiario.Text = "Seleccione un Beneficiario..."
        Bancos.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        Me.cmbBanco.SelectedIndex = -1
        Me.cmbBanco.Text = "Seleccione un Banco..."
        Me.cmbBeneficiario.Enabled = False
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

#Region "Otros"
    Private Sub cheque_Mensajes1(ByVal sender As Object, ByVal Message As ClasesNegocio.MensajeClass) Handles cheque.Mensajes
        MessageBox.Show(Message.Mensaje, Message.Titulo, MessageBoxButtons.OK, Message.Tipo)
    End Sub

    Private Sub chkElectronico_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkElectronico.CheckedChanged
        txtReferencia.Visible = chkElectronico.Checked
        lblRef.Visible = chkElectronico.Checked
        If chkElectronico.Checked Then
            cheque.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO
        Else
            If Not IsNothing(cheque) Then
                cheque.Medio = ClasesNegocio.BancosMovimientosMedio.CHEQUE
                txtReferencia.Clear()
            End If
        End If
    End Sub

    Private Sub txtTipoCambio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoCambio.TextChanged
        If Not bl Then
            bl = True
            txtTipoCambio.Text = txtTipoCambio.Valor.ToString("C")
            bl = False
        End If
    End Sub
#End Region

#Region "Importe"

    Private Sub txtImporteLetra_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporteLetra.GotFocus
        txtConcepto.Focus()
    End Sub

    Private bl As Boolean = False
    'Private Sub txtImporte_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporte.TextChanged
    '    If Not bl Then
    '        If Not IsNothing(cheque) Then
    '            cheque.Importe = txtImporte.Valor
    '            txtImporteLetra.Text = cheque.ImporteLetra.ToUpper
    '            bl = True
    '            txtImporte.Text = txtImporte.Valor.ToString("C")
    '            If Me.txtTipoCambio.Valor = 0 Then
    '                ValorGridCuentas(0, 5, txtImporte.Valor)
    '                Me.txtAbono.Text = txtImporte.Valor.ToString("C2")
    '                If Me.DgvCuentas.Rows.Count > 1 Then
    '                    Me.DgvCuentas.Rows(1).Cells("ClmAbono").Value = Me.txtAbono.Text
    '                    Me.txtCargo.Text = Me.txtAbono.Text
    '                End If
    '            Else
    '                ValorGridCuentas(0, 6, txtImporte.Valor * txtTipoCambio.Valor)
    '                Me.txtAbono.Text = (txtImporte.Valor * txtTipoCambio.Valor).ToString("C2")
    '                If Me.DgvCuentas.Rows.Count > 1 Then
    '                    Me.DgvCuentas.Rows(1).Cells("ClmCargo").Value = Me.txtAbono.Text
    '                    Me.txtCargo.Text = Me.txtAbono.Valor.ToString("C2")
    '                End If
    '            End If
    '            'Me.DgvCuentas.Rows(0).Cells("ClmAbono").Value = (txtImporte.Valor * txtTipoCambio.Valor).ToString("C2")
    '            bl = False
    '        End If
    '    End If
    'End Sub

#End Region

#Region "grids"
    Private Sub PasarCuenta(ByVal CtaCont As CN.CuentaContableClass, ByVal Renglon As Integer)
        If IsNothing(CtaCont) Then
            'fg.Rows(Renglon).UserData = Nothing
            ValorGridCuentas(Renglon, 5, "")
            ValorGridCuentas(Renglon, 6, 0D)
            ValorGridCuentas(Renglon, 7, 0D)
        Else
            If CtaCont.Bancos = SiNoEnum.NO And CtaCont.Afectable = SiNoEnum.SI Then
                'fg.Rows(Renglon).UserData = CtaCont
                ' *********  restablecer -> RellenarGridCuentas(CtaCont)
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
    Private Sub DgvCuentas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DgvCuentas.KeyDown
        'Select Case e.KeyCode
        '    Case Keys.Delete
        '        'If Me.DgvCuentas.SelectedRows.Count > 1 Then fg.Rows.Remove(fg.RowSel)
        '    Case Keys.F3
        '        Dim BuscarCuentas As New BusquedaCuentasContablesForm
        '        BuscarCuentas.BloquearCaracteristicas = True
        '        BuscarCuentas.Bancos = CheckState.Unchecked
        '        BuscarCuentas.Afectables = CheckState.Checked
        '        If BuscarCuentas.ShowDialog = Windows.Forms.DialogResult.OK Then
        '            If fg.RowSel > 1 Then
        '                Dim cta As New ClasesNegocios.CuentaContableClass
        '                cta = BuscarCuentas.CuentaContable
        '                RellenarFilaFlexGrid(fg.Rows(fg.RowSel), cta)
        '                fg.FinishEditing()
        '                fg.Col = 6
        '            End If
        '        End If
        'End Select
    End Sub
    Private Sub DgvCuentas_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DgvCuentas.CellBeginEdit
        If txtImporte.Valor > 0 Then
            If e.RowIndex > 0 Then
                If IsNothing(Me.DgvCuentas.Rows(e.RowIndex - 1).DataBoundItem) Then
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
        'Select Case e.ColumnIndex
        '    Case 0 To 3
        '        Dim tmp As CN.CuentaContableClass
        '        ValorGridCuentas(e.RowIndex, 0, FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 0)))
        '        ValorGridCuentas(e.RowIndex, 1, FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 1)))
        '        ValorGridCuentas(e.RowIndex, 2, FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 2)))
        '        ValorGridCuentas(e.RowIndex, 3, FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 3)))
        '        tmp = CtasCont.ObtenerCuentaContable(FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 0)), FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 1)), FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 2)), FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 3)))
        '        PasarCuenta(tmp, e.RowIndex)
        '    Case 4
        '        'Buscar Cuenta Por Nombre
        '        CtasCont.Obtener(Nothing, ValorGridCuentas(e.RowIndex, 4))
        '        Dim tmp As CN.CuentaContableClass = Nothing
        '        Select Case CtasCont.Count
        '            Case 0
        '                tmp = CtasCont(0)
        '            Case Is > 0
        '                SelCuentaContableForm.CuentasContables = CtasCont
        '                If SelCuentaContableForm.ShowDialog = Windows.Forms.DialogResult.OK Then
        '                    tmp = SelCuentaContableForm.CuentaContable
        '                End If
        '            Case Else
        '        End Select
        '        PasarCuenta(tmp, e.RowIndex)
        '    Case 5
        '        If VerificarBalance() < 0 Then
        '            ValorGridCuentas(e.RowIndex, e.ColumnIndex, 0)
        '            MessageBox.Show("La suma de los Cargos sobrepasa a la suma de los Abonos.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        End If
        'End Select
    End Sub

    Private Sub RellenarGridCuentas(ByVal Cta As ClasesNegocio.CuentaContableClass, ByVal Id As String, ByVal Cargo As Decimal, ByVal Abono As Decimal)
        'Me.DgvCuentas.Rows.Clear()
        Dim ren As Integer = -1
        For Each row As DataGridViewRow In DgvCuentas.Rows
            If row.Cells("clmId").Value = Id Then
                ren = row.Index
                Exit For
            End If
        Next
        If ren = -1 Then
            Me.DgvCuentas.Rows.Add(1)
            ren = DgvCuentas.Rows.Count - 1
            Me.DgvCuentas.Rows(ren).Cells("clmId").Value = Id
            Me.DgvCuentas.Rows(ren).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
            Me.DgvCuentas.Rows(ren).Cells("ClmSubCta").Value = Cta.SubCuenta
            Me.DgvCuentas.Rows(ren).Cells("ClmSsbCta").Value = Cta.SSubCuenta
            Me.DgvCuentas.Rows(ren).Cells("ClmSssCta").Value = Cta.SSSubCuenta
            Me.DgvCuentas.Rows(ren).Cells("ClmDescripcion").Value = Cta.NombreCuenta
        End If
        Me.DgvCuentas.Rows(ren).Cells("ClmCargo").Value = Cargo
        Me.DgvCuentas.Rows(ren).Cells("ClmAbono").Value = Abono
        'r.userdata = Cta
    End Sub

    'Private Sub RellenarGridCtasProveedor(ByVal Cta As ClasesNegocio.CuentaContableClass)
    '    'For i As Integer = Me.DgvCuentas.Rows.Count - 1 To 1 Step -1
    '    '    Me.DgvCuentas.Rows.RemoveAt(i)
    '    'Next
    '    If Me.DgvCuentas.Rows.Count = 2 Then
    '        'Me.DgvCuentas.Rows.Add()
    '        Me.DgvCuentas.Rows(0).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
    '        Me.DgvCuentas.Rows(0).Cells("ClmSubCta").Value = Cta.SubCuenta
    '        Me.DgvCuentas.Rows(0).Cells("ClmSsbCta").Value = Cta.SSubCuenta
    '        Me.DgvCuentas.Rows(0).Cells("ClmSssCta").Value = Cta.SSSubCuenta
    '        Me.DgvCuentas.Rows(0).Cells("ClmDescripcion").Value = Cta.NombreCuenta
    '        Me.DgvCuentas.Rows(0).Cells("ClmCargo").Value = 0
    '        Me.DgvCuentas.Rows(0).Cells("ClmAbono").Value = 0
    '    Else
    '        MsgBox("Seleccione la cuenta Bancaria", MsgBoxStyle.Information, "Aviso")
    '    End If
    'End Sub

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

    Private Function VerificarBalance() As Decimal
        Dim Cargos As Decimal = 0
        Dim Abonos As Decimal = 0
        For Each r As System.Windows.Forms.DataGridViewRow In Me.DgvCuentas.Rows
            If r.Index > -1 Then
                Cargos += r.Cells("ClmCargo").Value
                Abonos += r.Cells("ClmAbono").Value
            End If
        Next
        txtAbono.Text = Abonos
        txtCargo.Text = Cargos
        Return Abonos - Cargos
    End Function

    Private Sub GenerarPoliza()
        cheque.Poliza = Nothing
        Dim Empresa As New CN.EmpresaClass(Controlador.Sesion.MiEmpresa.Empndx)
        Dim Poliza As New CN.PolizaClass
        '--- Concepto
        Me.txtConcepto.Text = Me.txtConcepto.Text & " " & "FACTURA(S) "
        For i As Integer = 0 To Me.DgvFacturas.Rows.Count - 1
            If CBool(Me.DgvFacturas.Rows(i).Cells("ClmPagar").Value) Then
                Me.txtConcepto.Text = Me.txtConcepto.Text & " " & Me.DgvFacturas.Rows(i).Cells("clmNoFactura").Value
            End If
        Next
        Poliza.Concepto = txtConcepto.Text
        Poliza.Empresa = Empresa
        Poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.ACTIVA
        Poliza.FechaCaptura = Now
        Poliza.FechaPoliza = Now
        Poliza.Importe = txtImporte.Valor
        Poliza.Origen = ClasesNegocio.PolizaOrigenEnum.CUENTASxPAGAR
        Poliza.TipoCambio = txtTipoCambio.Valor
        Poliza.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.EGRESO
        Poliza.TipoError = 0
        For Each r As DataGridViewRow In Me.DgvCuentas.Rows
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
                    polizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.CARGO
                    polizaDet.Posicion = r.Index
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
                    polizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO
                    polizaDet.Posicion = r.Index
                    Poliza.AgregarDetalle(polizaDet)
                End If
            End If
        Next
        cheque.Poliza = Poliza
    End Sub

    Private Sub MostrarPolizaFlexGrid(ByVal Poliza As CN.PolizaClass)
        Dim cta, ctaban, ctaprov As CN.CuentaContableClass
        LimpiarGridCuentas()
        For i As Integer = 0 To Poliza.Detalles.Count - 1
            'Me.DgvCuentas.Rows.Add()
            'If i > 0 Then
            '    Me.RellenarGridCtasProveedor(Poliza.Detalles(i).CuentaContable)
            'Else
            '    RellenarGridCuentas(Poliza.Detalles(i).CuentaContable)
            'End If
            cta = Poliza.Detalles(i).CuentaContable
            ctaprov = cheque.Beneficiario.Proveedor.CuentaContable2
            ctaban = cheque.Cuenta.CuentaContable
            If cta.CuentaMayor + cta.SubCuenta + cta.SSubCuenta + cta.SSSubCuenta = ctaprov.CuentaMayor + ctaprov.SubCuenta + ctaprov.SSubCuenta + ctaprov.SSSubCuenta Then
                Me.DgvCuentas.Rows(i).Cells("clmId").Value = "PROV"
            ElseIf cta.CuentaMayor + cta.SubCuenta + cta.SSubCuenta + cta.SSSubCuenta = ctaban.CuentaMayor + ctaban.SubCuenta + ctaban.SSubCuenta + ctaban.SSSubCuenta Then
                Me.DgvCuentas.Rows(i).Cells("clmId").Value = "BCO"
            ElseIf cta.CuentaMayor + cta.SubCuenta + cta.SSubCuenta + cta.SSSubCuenta = CtaIva.CuentaMayor + CtaIva.SubCuenta + CtaIva.SSubCuenta + CtaIva.SSSubCuenta Then
                Me.DgvCuentas.Rows(i).Cells("clmId").Value = "IVA"
            ElseIf cta.CuentaMayor + cta.SubCuenta + cta.SSubCuenta + cta.SSSubCuenta = CtaRetISR.CuentaMayor + CtaRetISR.SubCuenta + CtaRetISR.SSubCuenta + CtaRetISR.SSSubCuenta Then
                Me.DgvCuentas.Rows(i).Cells("clmId").Value = "RISR"
            ElseIf cta.CuentaMayor + cta.SubCuenta + cta.SSubCuenta + cta.SSSubCuenta = CtaRetIva.CuentaMayor + CtaRetIva.SubCuenta + CtaRetIva.SSubCuenta + CtaRetIva.SSSubCuenta Then
                Me.DgvCuentas.Rows(i).Cells("clmId").Value = "RIVA"
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

#Region "Metodo Guardar el pago de proveedores"
    Private Sub PasarValores(ByVal PagoProv As CN.PagosProveedoresClass)
        PagoProv.ObtenerEntidad.EmpresaId = Controlador.Sesion.Empndx
        PagoProv.Cheque = cheque.Folio
        PagoProv.Referencia = Me.txtReferencia.Text
        PagoProv.Poliza = cheque.Poliza
        PagoProv.FechaPago = Now
        PagoProv.Estatus = ClasesNegocio.EstatusPagosProveedoresEnum.VIGENTE
        PagoProv.CuentaBancaria = Cuen
        PagoProv.Proveedor = Proveedor
    End Sub
    Private Function GuardarPago(ByVal Tr As IntegraLab.ORM.HelperClasses.Transaction) As Boolean
        Try
            For i As Integer = 0 To Me.DgvFacturas.Rows.Count - 1
                If CBool(Me.DgvFacturas.Rows(i).Cells("ClmPagar").Value) Then
                    Dim Pago As New CN.PagosProveedoresClass
                    PasarValores(Pago)
                    Pago.NoFactura = Me.DgvFacturas.Rows(i).Cells("clmNoFactura").Value
                    Pago.Importe = Me.DgvFacturas.Rows(i).Cells("ClmApagar").Value
                    Pago.IdUsuarioAlta = Controlador.Sesion.Usrndx
                    If Not Pago.Guardar(Tr) Then
                        Return False
                    End If
                    Dim FacAp As New IntegraLab.ORM.EntityClasses.UsrCxpfacturasApagarEntity
                    If FacAp.FetchUsingPK(Controlador.Sesion.Empndx, Pago.Proveedor.Codigo, Pago.NoFactura) Then
                        'FacAp.Estatus = ClasesNegocio.EstatusFacturasApagar.PAGADA
                        'FacAp.Saldo = FacAp.Saldo - Pago.Importe
                        'FacAp.ImporteApagar = 0
                        'Tr.Add(FacAp)
                        'FacAp.Save()
                        FacAp.Delete()
                    End If

                    '---------------------------------------------------------
                    Dim Facturas As New CN.FacturasCabCXPClass
                    Facturas.Obtener(Controlador.Sesion.Empndx, Pago.Proveedor.Codigo, Pago.NoFactura)
                    Facturas.Saldo = Facturas.Saldo - Pago.Importe
                    If CDec(Facturas.Saldo) = 0D Then
                        Facturas.Estatus = CN.EstatusFacturasEnum.PAGADA
                    Else
                        Facturas.Estatus = CN.EstatusFacturasEnum.ABONADA
                    End If
                    Facturas.Guardar()
                End If
            Next
            Return True
        Catch ex As Exception
            Return False
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurri� un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function
#End Region

    Private Sub txtCargo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCargo.TextChanged
        If Not bl Then
            bl = True
            txtCargo.Text = txtCargo.Valor.ToString("C")
            bl = False
        End If
    End Sub

    Private Sub txtAbono_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbono.TextChanged
        If Not bl Then
            bl = True
            txtAbono.Text = txtAbono.Valor.ToString("C")
            bl = False
        End If
    End Sub

    Private Sub DgvFacturas_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvFacturas.CellContentClick
        Try
            If e.ColumnIndex = Me.ClmPagar.Index Then
                If CBool(Me.DgvFacturas.Rows(e.RowIndex).Cells("ClmPagar").Value) Then
                    Me.DgvFacturas.Rows(e.RowIndex).Cells("ClmPagar").Value = False
                Else
                    Me.DgvFacturas.Rows(e.RowIndex).Cells("ClmPagar").Value = True
                End If
                NoFacturas = False
                Me.txtImporte.Text = 0
                For r As Integer = 0 To Me.DgvFacturas.Rows.Count - 1
                    If CBool(Me.DgvFacturas.Rows(r).Cells("ClmPagar").Value) Then
                        Me.txtImporte.Text = Me.txtImporte.Text + Me.DgvFacturas.Rows(r).Cells("ClmApagar").Value
                        NoFacturas = True
                    End If
                Next
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurri� un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub TmBeneficiario_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TmBeneficiario.Tick
        Try
            If Me.UltimaTeclaBen.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
                Me.TmBeneficiario.Stop()
                Me.Beneficiarios.Obtener(Me.cmbBeneficiario.Text.Trim, ClasesNegocio.CondicionEnum.ACTIVOS)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub txtImporte_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImporte.Leave
        If Not bl Then
            If Not IsNothing(cheque) Then
                cheque.Importe = txtImporte.Valor
                txtImporteLetra.Text = cheque.ImporteLetra.ToUpper
                bl = True
                txtImporte.Text = txtImporte.Valor.ToString("C")
                Dim abono As Decimal
                If Me.txtTipoCambio.Valor = 0 Then
                    ValorGridCuentas(0, 5, txtImporte.Valor)
                    Me.txtAbono.Text = txtImporte.Valor.ToString("C2")
                    'If Me.DgvCuentas.Rows.Count > 1 Then
                    '    Me.DgvCuentas.Rows(1).Cells("ClmAbono").Value = Me.txtAbono.Text
                    '    Me.txtCargo.Text = Me.txtAbono.Text
                    'End If
                    abono = txtImporte.Valor
                Else
                    ValorGridCuentas(0, 6, txtImporte.Valor * txtTipoCambio.Valor)
                    Me.txtAbono.Text = (txtImporte.Valor * txtTipoCambio.Valor).ToString("C2")
                    'If Me.DgvCuentas.Rows.Count > 1 Then
                    '    Me.DgvCuentas.Rows(1).Cells("ClmCargo").Value = Me.txtAbono.Text
                    '    Me.txtCargo.Text = Me.txtAbono.Valor.ToString("C2")
                    'End If
                    abono = txtImporte.Valor * txtTipoCambio.Valor
                End If
                RellenarGridCuentas(Cuenta.CuentaContable, "BCO", 0, abono)
                'Me.DgvCuentas.Rows(0).Cells("ClmAbono").Value = (txtImporte.Valor * txtTipoCambio.Valor).ToString("C2")
                bl = False
            End If
        End If

    End Sub

End Class