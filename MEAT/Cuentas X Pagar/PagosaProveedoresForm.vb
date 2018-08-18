Imports CN = ClasesNegocio
Imports Integra.Clases
Imports HC = Integralab.ORM.HelperClasses
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class PagosaProveedoresForm
    Implements InterfaceForm
    Dim IdBanco As Integer

#Region " Declaraciones "
    Private WithEvents cheque As CN.ChequeClass
    Private WithEvents Bene As CN.BeneficiarioClass
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
        Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
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
            MsgBox("Debe configurar las cuentas contables para IVA pagado a proveedores, Retención de ISR y Retención de IVA" + vbNewLine + "en Catálogos - Contabilidad - Configuración de cuentas de control.", MsgBoxStyle.Information, "Aviso")
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
                txtSaldo.Text = (0D).ToString("N4").ToString
            ElseIf Not IsNothing(item.Tag) And Not IsNothing(cheque.Cuenta) Then
                Dim tmp As CN.CuentaClass = DirectCast(item.Tag, CN.CuentaClass)
                If tmp.Cuenta = cheque.Cuenta.Cuenta Then
                    item.Selected = True
                    Cuenta = tmp
                    txtCuenta.Text = String.Format("{0} - {1}", item.SubItems(0).Text, item.SubItems(1).Text)
                    txtSaldo.Text = Cuenta.SaldoActual.ToString("N4")
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
        ''setear el importe ---------- 

        ''----------------------------
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

        If DgvCuentas.Rows.Count > 0 Then
            Dim cargo As String
            Dim abono As String
            For Each Fila As DataGridViewRow In DgvCuentas.Rows
                If Not Fila.IsNewRow Then
                    cargo = Fila.Cells(ClmCargo.Index).Value
                    abono = Fila.Cells(ClmAbono.Index).Value

                    If (String.IsNullOrEmpty(cargo) Or CDec(cargo)) <= 0 And
                        (String.IsNullOrEmpty(abono) Or CDec(abono) <= 0) Then
                        Cadena &= "* Existen cuentas contables sin importe en el abono" & vbCrLf
                        Exit For
                    End If
                End If
            Next
        End If

        If Not Bl Then
            Cadena = Nothing
            'cheque.Anticipo = chkAnticipo.Checked
            'cheque.Beneficiario = DirectCast(cmbBeneficiario.SelectedItem, CN.BeneficiarioClass)
            'cheque.Beneficiario = Beneficiarios.Obtener2(cmbBeneficiario.SelectedValue)
            'Find(cmbBeneficiario.SelectedValue.ToString())
            'Dim Bene As New ClasesNegocio.BeneficiarioClass()
            'ClasesNegocio.BancosMovimientosTipo.RETIRO, chkEstatus
            'Bene.ObtenerEntidad(ClasesNegocio.BeneficiarioClass.C)
            Beneficiarios.Obtener2(cmbBeneficiario.SelectedValue, CondicionEnum.ACTIVOS)
            cheque.Beneficiario = Beneficiarios(0)




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
        Dim query As String = "SELECT t1.Codigo, t1.Beneficiario " &
  " FROM usrBanBeneficiarios t1 " &
 " INNER JOIN MCatCompProveedores t2 ON t1.EsProveedor = t2.PrIdProveedor " &
 " INNER JOIN usrCXPFacturasApagar t3 on t2.PrIdProveedor = t3.IdProveedor " &
        " WHERE(t1.Estatus = 1 And t2.PrEstatus = 1 And t3.Estatus = 1) " &
  " GROUP BY t1.Codigo, t1.Beneficiario " &
  " ORDER BY t1.Codigo "
        Me.cmbBeneficiario.SelectedIndex = -1
        Dim tb As New DataTable
        Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
        Using sqlcom As New SqlCommand(query, sqlCon)
            Dim adp As New SqlDataAdapter(sqlcom)
            sqlCon.Open()
            adp.Fill(tb)
            Me.cmbBeneficiario.DataSource = tb
            sqlCon.Close()
        End Using
        'Beneficiarios.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, True)
        'txtBeneficiario.AutoCompleteSource = AutoCompleteSource.CustomSource
        'txtBeneficiario.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        'txtBeneficiario.AutoCompleteCustomSource.AddRange(Beneficiarios.Listar)
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
        Else
            Me.DgvFacturas.DataSource = Nothing
            NoFacturas = False
            Buscar = False
            Me.DgvFacturas.Columns(3).DataPropertyName = "ImporteAbono"
            Me.DgvFacturas.Columns(4).DataPropertyName = "ImporteTotal"
            Me.DgvFacturas.Columns(5).DataPropertyName = "Saldo"
            Me.DgvFacturas.Columns(6).DataPropertyName = "ImporteaPagar"
        End If

    End Sub

    Private Sub txtBeneficiario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBeneficiario.KeyDown
        'Select Case e.KeyCode
        '    Case Keys.F12
        '        Beneficiarios.Obtener(CN.CondicionEnum.ACTIVOS)
        'End Select
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

                        'txtSaldo.Text = Cuenta.SaldoActual.ToString("C")
                        txtSaldo.Text = Cuenta.SaldoActual.ToString("N4")

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
        Dim BuscarCheques As New BuscarChequeForm
        BuscarCheques.BloquearTiposMovimiento = True
        BuscarCheques.TipoMovimientos = ClasesNegocio.BancosMovimientosTipo.RETIRO
        If BuscarCheques.ShowDialog = Windows.Forms.DialogResult.OK Then
            cheque = BuscarCheques.Cheque
            Buscar = True
            Mostrar()
        End If
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
        Dim Tran As New Integralab.ORM.HelperClasses.Transaction(IsolationLevel.ReadCommitted, "PagoProveedores")
        Try



            If IsNothing(Validar()) Then
                If VerificarBalance() = 0 Then
                    Dim bbl As Boolean
                    If (txtSaldo.Valor - txtImporte.Valor) < 0 Then
                        bbl = False
                        If MessageBox.Show("El importe de este cheque sobrepasa el saldo en la cuenta, ¿Desea continuar con la generación del Cheque?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
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

                            imprimir(cheque.Poliza)
                            ''--------------------------------------------------------------------------
                            ''--------------------------------------------------------------------------

                            Dim MovBancos As New CN.MovimientosBancosClass
                            MovBancos.NumPoliza = cheque.Poliza.Codigo
                            MovBancos.CtaBancaria = Cuenta.Codigo
                            'MovBancos.SaldoAnterior = SaldoAnterior
                            MovBancos.FechaMov = Me.dtp.Value
                            MovBancos.FechaCaptura = Now
                            MovBancos.Importe = Me.txtImporte.Text 'Me.DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value
                            MovBancos.Concepto = cheque.Poliza.Concepto
                            MovBancos.Cargo_Abono = ClasesNegocio.PolizaOperacionEnum.ABONO
                            MovBancos.TipoCambio = CDec(Me.txtTipoCambio.Text)
                            MovBancos.TipoMov = Chr(ClasesNegocio.BancosMovimientosTipo.RETIRO)
                            MovBancos.Origen = Chr(ClasesNegocio.BancosMovimientosOrigen.PAGOPROVEEDORES)
                            MovBancos.CveCancelacion = "N"
                            MovBancos.Beneficiario = Me.cmbBeneficiario.Text 'Me.txtBeneficiario.Text
                            ' MovBancos.Referencia = txtReferencia.Text

                            If Me.chkElectronico.Checked = False Then
                                Me.txtReferencia.Enabled = False
                            End If

                            MovBancos.Referencia = Me.txtReferencia.Text

                            If Not MovBancos.Guardar(Tran) Then
                                Tran.Rollback()
                                Cancelar = True
                                MessageBox.Show("No se pudieron Guardar los pagos, Intentelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Exit Sub
                            End If

                            ''--------------------------------------------------------------------------
                            ''--------------------------------------------------------------------------

                            If GuardarPago(Tran) Then
                                Tran.Commit()
                                MessageBox.Show(String.Format("Número de Póliza Generado:{0}{1}", vbCrLf, cheque.Poliza.NumeroPoliza), "Poliza Generada", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                    MessageBox.Show("No se puede generar el movimiento por que no está cuadrada la póliza.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        'If Not IsNothing(cheque) Then
        '    ImprimirCheque.Cheque = cheque
        '    ImprimirCheque.AbonoEnCuenta = MessageBox.Show("¿Es para abono en cuenta?", "Tipo de Cheque", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        '    ImprimirCheque.Banco = IdBanco
        '    ppDg.ShowDialog()
        '    If Not cheque.Emitido Then
        '        If cheque.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO Then
        '            PagoElectronico.Cheque = cheque
        '            pDg.Document = PagoElectronico
        '            If pDg.ShowDialog = Windows.Forms.DialogResult.OK Then
        '                Try
        '                    PagoElectronico.Print()
        '                    If MessageBox.Show("¿Se imprimio el comprobante?", "Confirmación de Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
        '                        PagoElectronico.ImpresionExitosa()
        '                        cheque.Guardar()
        '                    End If
        '                Catch ex As Exception
        '                    MessageBox.Show(ex.Message, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                End Try
        '            End If
        '        Else
        '            If MessageBox.Show("¿Desea imprimir el cheque?", "Confirmación de Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
        '                '                        ImprimirCheque.AbonoEnCuenta = MessageBox.Show("¿Es para abono en cuenta?", "Tipo de Cheque", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        '                'ImprimirCheque.Banco = IdBanco
        '                'ImprimirCheque.Cheque = cheque                        
        '                Me.ppDg.Close()
        '                pDg.Document = ImprimirCheque
        '                If pDg.ShowDialog = Windows.Forms.DialogResult.OK Then
        '                    Try
        '                        ImprimirCheque.Print()
        '                        If MessageBox.Show("¿Se imprimio el cheque?", "Confirmación de Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
        '                            ImprimirCheque.ImpresionExitosa()
        '                            '
        '                            'cheque.Guardar()
        '                            cheque.ObtenerEntidad.Save()
        '                        End If
        '                    Catch ex As Exception
        '                        MessageBox.Show(ex.Message, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                    End Try
        '                End If
        '            End If
        '        End If
        '    Else
        '        If Not cheque.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO Then MessageBox.Show(String.Format("Este cheque ya fue emitido el {0}.", cheque.FechaEmision.ToString("dd MMM' de 'yyyy"), "Cheque ya emitido", MessageBoxButtons.OK, MessageBoxIcon.Error))
        '    End If
        'End If
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
            'txtTipoCambio.Text = txtTipoCambio.Valor.ToString("C")
            txtTipoCambio.Text = txtTipoCambio.Valor.ToString("C2")
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
    '                Me.txtAbono.Text = txtImporte.Valor.ToString("N4")
    '                If Me.DgvCuentas.Rows.Count > 1 Then
    '                    Me.DgvCuentas.Rows(1).Cells("ClmAbono").Value = Me.txtAbono.Text
    '                    Me.txtCargo.Text = Me.txtAbono.Text
    '                End If
    '            Else
    '                ValorGridCuentas(0, 6, txtImporte.Valor * txtTipoCambio.Valor)
    '                Me.txtAbono.Text = (txtImporte.Valor * txtTipoCambio.Valor).ToString("N4")
    '                If Me.DgvCuentas.Rows.Count > 1 Then
    '                    Me.DgvCuentas.Rows(1).Cells("ClmCargo").Value = Me.txtAbono.Text
    '                    Me.txtCargo.Text = Me.txtAbono.Valor.ToString("N4")
    '                End If
    '            End If
    '            'Me.DgvCuentas.Rows(0).Cells("ClmAbono").Value = (txtImporte.Valor * txtTipoCambio.Valor).ToString("N4")
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

    Private Function CuentasRepetidas(ByVal cta As CN.CuentaContableClass) As Boolean
        Try
            For i As Integer = 0 To Me.DgvCuentas.Rows.Count - 1
                If cta.NombreCuenta = Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value Then
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Private Sub RellenarGridCuentas(ByVal Cta As ClasesNegocio.CuentaContableClass)
        Dim cargoAbono As Decimal = 0
        Try
            Dim CtasBan As New CN.CuentaCollectionClass
            CtasBan.Obtener(Cta.Codigo)
            If CtasBan.Count > 0 Then
                MsgBox("Imposible obtener la cuenta, es una Cuenta Bancaria", MsgBoxStyle.Information, "Aviso")
            Else
                If CuentasRepetidas(Cta) Then
                    MsgBox("Imposible obtener la cuenta, Error de duplicidad", MsgBoxStyle.Information, "Aviso")
                Else
                    Dim i As Integer = Me.DgvCuentas.Rows.Count
                    If i <> 0 Then
                        If Me.DgvCuentas.Rows(0).Cells("ClmCtaMayor").Value = Cta.CuentaMayor And _
                        Me.DgvCuentas.Rows(0).Cells("ClmSubCta").Value = Cta.SubCuenta And _
                        Me.DgvCuentas.Rows(0).Cells("ClmSsbCta").Value = Cta.SSubCuenta And _
                        Me.DgvCuentas.Rows(0).Cells("ClmSssCta").Value = Cta.SSSubCuenta And _
                        Me.DgvCuentas.Rows(0).Cells("ClmDescripcion").Value = Cta.NombreCuenta Then
                            MsgBox("Imposible agregar cuenta contable duplicada", MsgBoxStyle.Information, "Aviso")
                        Else
                            If Not Me.DgvCuentas.Rows(i - 1).Cells("ClmDescripcion").Value = "" Then
                                Me.DgvCuentas.Rows.Add()
                                Me.DgvCuentas.Rows(i).Cells("clmId").Value = Cta.Codigo
                                Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                                Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = Cta.SubCuenta
                                Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                                Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                                Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                                Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = cargoAbono.ToString("C4")
                                Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = cargoAbono.ToString("C4")
                                'Me.DgvCuentas.Rows.Add()
                            Else
                                Me.DgvCuentas.Rows(i - 1).Cells("clmId").Value = Cta.Codigo
                                Me.DgvCuentas.Rows(i - 1).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                                Me.DgvCuentas.Rows(i - 1).Cells("ClmSubCta").Value = Cta.SubCuenta
                                Me.DgvCuentas.Rows(i - 1).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                                Me.DgvCuentas.Rows(i - 1).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                                Me.DgvCuentas.Rows(i - 1).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                                Me.DgvCuentas.Rows(i - 1).Cells("ClmCargo").Value = cargoAbono.ToString("C4")
                                Me.DgvCuentas.Rows(i - 1).Cells("ClmAbono").Value = cargoAbono.ToString("C4")
                                'Me.DgvCuentas.Rows.Add()
                            End If
                        End If
                    Else
                        Me.DgvCuentas.Rows.Add()
                        Me.DgvCuentas.Rows(i).Cells("clmId").Value = Cta.Codigo
                        Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                        Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = Cta.SubCuenta
                        Me.DgvCuentas.Rows(i).Cells("ClmSClmCtaMayorsbCta").Value = Cta.SSubCuenta
                        Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                        Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                        Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = cargoAbono.ToString("C4")
                        Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = cargoAbono.ToString("C4")
                        Me.DgvCuentas.Rows.Add()
                    End If
                    Me.calcular()
                    'If Me.DgvCuentas.Rows.Count > 0 Then
                    '    For j As Integer = 0 To Me.DgvCuentas.Rows.Count - 1
                    '        If j > 0 Then
                    '            Me.DgvCuentas.Rows(j).Cells("ClmAbono").ReadOnly = False
                    '        End If

                    '    Next
                    'End If

                    'If Me.DgvCuentas.Rows.Count = 1 Then
                    'For j As Integer = 0 To Me.DgvCuentas.Columns.Count - 3
                    '    Me.DgvCuentas.Rows(0).Cells(j).ReadOnly = True
                    'Next
                    'End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DgvCuentas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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

        'If e.KeyCode = Keys.F3 Then
        '    Try
        '        Dim buscarCuenta As New BusquedaCuentasContablesForm
        '        buscarCuenta.BloquearCaracteristicas = True
        '        'ojo
        '        'buscarCuenta.Afectables = CheckState.Checked
        '        If buscarCuenta.ShowDialog = Windows.Forms.DialogResult.OK Then
        '            Me.RellenarGridCuentas(buscarCuenta.CuentaContable)
        '        End If
        '    Catch ex As Exception
        '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        '    End Try
        'End If
        'If e.KeyCode = Keys.Delete Then
        '    If MsgBox("¿Desea Realmente Borrar el detalle?", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.No Then
        '        Exit Sub
        '    Else
        '        Me.DgvCuentas.Rows.Remove(Me.DgvCuentas.SelectedRows(0))
        '        SumaCargo = 0
        '        SumaAbono = 0
        '        For i As Integer = 0 To Me.DgvCuentas.Rows.Count - 1
        '            SumaCargo = SumaCargo + Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value
        '            SumaAbono = SumaAbono + Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value
        '        Next
        '        Me.txtSumaCargo.Text = SumaCargo.ToString("C2")
        '        Me.txtSumaAbono.Text = SumaAbono.ToString("C2")
        '    End If
        'End If

    End Sub
    'Private Sub DgvCuentas_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs)

    'End Sub
    Private Sub DgvCuentas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        
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
        Me.DgvCuentas.Rows(ren).Cells("ClmCargo").Value = Cargo.ToString("C4")
        Me.DgvCuentas.Rows(ren).Cells("ClmAbono").Value = Abono.ToString("C4")

        Me.calcular()


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
        Poliza.FechaCaptura = dtp.Value
        Poliza.FechaPoliza = dtp.Value
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
                    Poliza.Detalles2.Add(polizaDet)
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
                    Poliza.Detalles2.Add(polizaDet)
                    Poliza.AgregarDetalle(polizaDet)
                End If
            End If
        Next
        cheque.Poliza = Poliza
        'imprimir(Poliza)

    End Sub

    Private Function obtenerdatasetPoliza(Poliza As ClasesNegocio.PolizaClass) As DataSet

        Dim cuentac, cuentac1, cuentac2, cuentac3 As New CN.CuentaContableClass
        Dim detalles As New CN.PolizaDetalleCollectionClass
        detalles = Poliza.Detalles2
        Dim padre, padre1, padre2, padre3 As String
        Dim ds As New DataSet()
        Dim dt As New DataTable()
        Try
            ''--------------------------------
            ds.Tables.Add(dt)
            dt.Columns.Add("cta")
            dt.Columns.Add("subcta")
            dt.Columns.Add("ssubcta")
            dt.Columns.Add("sssubcta")
            dt.Columns.Add("nomcuenta1")
            dt.Columns.Add("nomcuenta2")
            dt.Columns.Add("nomcuenta3")
            dt.Columns.Add("nomcuenta4")
            dt.Columns.Add("origen")
            dt.Columns.Add("poliza")
            dt.Columns.Add("fecha")
            dt.Columns.Add("importe")
            dt.Columns.Add("cargo")
            dt.Columns.Add("abono")

            ''elemntos del tatset -------------------------------------

            For Each item As CN.PolizaDetalleClass In detalles

                cuentac = item.CuentaContable
                padre = cuentac.NombreCuenta

                If (cuentac.Nivel = 1) Then
                    padre = cuentac.NombreCuenta
                End If

                If (cuentac.Nivel = 2) Then
                    padre1 = cuentac.NombreCuenta
                    padre = cuentac.CuentaPadre.NombreCuenta
                End If

                If (cuentac.Nivel = 3) Then
                    padre2 = cuentac.NombreCuenta
                    padre1 = cuentac.CuentaPadre.NombreCuenta
                    padre = cuentac.CuentaPadre.CuentaPadre.NombreCuenta
                End If

                If (cuentac.Nivel = 4) Then
                    padre3 = cuentac.NombreCuenta
                    padre2 = cuentac.CuentaPadre.NombreCuenta
                    padre1 = cuentac.CuentaPadre.CuentaPadre.NombreCuenta
                    padre1 = cuentac.CuentaPadre.CuentaPadre.CuentaPadre.NombreCuenta
                End If

                dt.Rows.Add(item.Cta, item.SCta, item.SSCta, item.SSSCta, padre, padre1, padre2, padre3, Poliza.Origen, Poliza.NumeroPoliza, Poliza.FechaPoliza, item.Importe, item.Cargo, item.Abono)
            Next

        Catch ex As Exception

        End Try
        Return ds
    End Function

    Private Function imprimir(Poliza As ClasesNegocio.PolizaClass)
        Try
            ''obtener  datos de la poliza guardada
            Dim datos As New DataSet
            datos = obtenerdatasetPoliza(Poliza)

            ''------------------------------------

            'Dim datos As New DataSet
            'Dim query = "EXEC  rptcuentascontables 1"
            'Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            '    Dim adapter As New SqlDataAdapter()
            '    adapter.SelectCommand = New SqlCommand(query, connection)
            '    adapter.Fill(datos)
            'End Using

            Dim Reporte As New Rptpolizapasivo
            Reporte.SetDataSource(datos.Tables(0))
            Reporte.SetParameterValue("Empresa", Controlador.Empresa.Nombre)
            Reporte.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnomcom)
            Reporte.SetParameterValue("Modulo", "")
            Reporte.SetParameterValue("NoFactura", DgvFacturas.CurrentRow.Cells(1).Value)

            Dim pre As New ClasesNegocio.PreVisualizarForm
            pre.Reporte = Reporte
            pre.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try

    End Function

    Private Sub MostrarPolizaFlexGrid(ByVal Poliza As CN.PolizaClass)
        Try

            Dim cta, ctaban, ctaprov As CN.CuentaContableClass
            LimpiarGridCuentas()

            ''-------------------------------------------------------
            Try
                llenarcuntascontablesgrid(Poliza)
            Catch ex As Exception

            End Try

            ''-------------------------------------------------------

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
                    Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = Poliza.Detalles(i).Importe.ToString("N4")
                    txtAbono.Text = txtAbono.Text + Poliza.Detalles(i).Importe
                Else
                    Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = Poliza.Detalles(i).Importe
                    txtCargo.Text = txtCargo.Text + Poliza.Detalles(i).Importe
                End If

            Next
            txtPoliza.Text = Poliza.NumeroPoliza

        Catch ex As Exception

        End Try
    End Sub

    Private Sub llenarcuntascontablesgrid(Poliza As ClasesNegocio.PolizaClass)
        For z As Integer = 0 To Poliza.Detalles.Count - 1
            Dim cargoAbono As Decimal = 0
            Try
                Dim Cta As New CN.CuentaContableClass
                Cta = Poliza.Detalles(z).CuentaContable

                Dim i As Integer = Me.DgvCuentas.Rows.Count

                Me.DgvCuentas.Rows.Add()
                Me.DgvCuentas.Rows(i).Cells("clmId").Value = Cta.Codigo
                Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = Cta.SubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = cargoAbono.ToString("C4")
                Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = cargoAbono.ToString("C4")

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Next

       
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
    Private Function GuardarPago(ByVal Tr As Integralab.ORM.HelperClasses.Transaction) As Boolean
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
                    Dim FacAp As New Integralab.ORM.EntityClasses.UsrCxpfacturasApagarEntity
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
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function
#End Region

    Private Sub txtCargo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCargo.TextChanged
        If Not bl Then
            bl = True
            'txtCargo.Text = txtCargo.Valor.ToString("C")
            txtCargo.Text = txtCargo.Valor.ToString("N4")
            bl = False
        End If
    End Sub

    Private Sub txtAbono_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbono.TextChanged
        If Not bl Then
            bl = True
            txtAbono.Text = txtAbono.Valor.ToString("N4")
            'txtAbono.Text = txtAbono.Valor.ToString("C")
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
                Me.txtSaldo.Text = 0
                For r As Integer = 0 To Me.DgvFacturas.Rows.Count - 1
                    If CBool(Me.DgvFacturas.Rows(r).Cells("ClmPagar").Value) = True Then
                        Me.txtImporte.Text = Me.txtImporte.Text + Me.DgvFacturas.Rows(r).Cells("ClmApagar").Value
                        Me.txtSaldo.Text = Me.txtSaldo.Text + Me.DgvFacturas.Rows(r).Cells("ClmApagar").Value

                        NoFacturas = True
                    End If
                Next

                Dim importeAPagar As Decimal = 0.0
                importeAPagar = Me.txtImporte.Text.ToString()
                importeAPagar = importeAPagar.ToString("N4")

                Me.txtImporte.Text = importeAPagar
                Me.txtSaldo.Text = importeAPagar
                Me.calcular()
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Sub calcular()
        Dim importeAPagar As Decimal = 0.0
        importeAPagar = If(String.IsNullOrEmpty(Me.txtImporte.Text), 0, Me.txtImporte.Text.ToString())
        'importeAPagar = importeAPagar.ToString("N4")

        'importe = CDec(txtImporte.Text.Replace(",", ""))
        If Me.DgvCuentas.Rows.Count > 0 Then
            Try
                Me.DgvCuentas.Rows(1).Cells("ClmCargo").Value = importeAPagar.ToString("C4")
            Catch ex As Exception

            End Try

            Try
                Me.DgvCuentas.Rows(0).Cells("ClmAbono").Value = importeAPagar.ToString("C4")
            Catch ex As Exception

            End Try
        End If
        If Me.DgvCuentas.Rows.Count > 0 Then
            For j As Integer = 0 To Me.DgvCuentas.Rows.Count - 1
                Me.DgvCuentas.Rows(j).ReadOnly = True
                If j > 0 Then
                    Me.DgvCuentas.Rows(j).Cells("ClmCargo").ReadOnly = False
                    Me.DgvCuentas.Rows(j).Cells("ClmAbono").ReadOnly = False
                End If

            Next
        End If

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
                txtImporte.Text = txtImporte.Valor.ToString("C4")
                Dim abono As Decimal
                If Me.txtTipoCambio.Valor = 0 Then
                    ValorGridCuentas(0, 5, txtImporte.Valor)
                    Me.txtAbono.Text = txtImporte.Valor.ToString("C4")
                    'If Me.DgvCuentas.Rows.Count > 1 Then
                    '    Me.DgvCuentas.Rows(1).Cells("ClmAbono").Value = Me.txtAbono.Text
                    '    Me.txtCargo.Text = Me.txtAbono.Text
                    'End If
                    abono = txtImporte.Valor
                Else
                    ValorGridCuentas(0, 6, txtImporte.Valor * txtTipoCambio.Valor)
                    Me.txtAbono.Text = (txtImporte.Valor * txtTipoCambio.Valor).ToString("C4")
                    'If Me.DgvCuentas.Rows.Count > 1 Then
                    '    Me.DgvCuentas.Rows(1).Cells("ClmCargo").Value = Me.txtAbono.Text
                    '    Me.txtCargo.Text = Me.txtAbono.Valor.ToString("N4")
                    'End If
                    abono = txtImporte.Valor * txtTipoCambio.Valor
                End If
                RellenarGridCuentas(Cuenta.CuentaContable, "BCO", 0, abono)
                'Me.DgvCuentas.Rows(0).Cells("ClmAbono").Value = (txtImporte.Valor * txtTipoCambio.Valor).ToString("N4")
                bl = False
            End If
        End If

    End Sub
    'Verifica que los abonos no sobrepase los cargos
    Private Function VerificarBalance2() As Decimal
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
        Return Cargos - Abonos
    End Function

    Private Sub DgvCuentas_CellEndEdit_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCuentas.CellEndEdit
        Try
            Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDec(Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value).ToString("C4")
        Catch ex As Exception
            Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
        End Try

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
            Case 7
                VerificarBalance2()

            Case 8
                VerificarBalance2()

        End Select

    End Sub

    Private Sub DgvCuentas_KeyDown_1(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles DgvCuentas.KeyDown
        'Dim i As Integer = 0
        If e.KeyCode = Keys.Delete Then
            'i = Me.DgvCuentas.CurrentCell.RowIndex
            Dim isValidRow As Boolean = False
            If Me.DgvCuentas.Rows.Count > 0 Then
                Dim cuentaBancos As DataGridViewRow = DgvCuentas.Rows(0)
                If Me.DgvCuentas.SelectedRows.Contains(cuentaBancos) Then
                    MessageBox.Show("No es posible eliminar la cuenta contable de Banco.", "Aviso Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    If MessageBox.Show("Las cuentas contables seleccionadas se eliminarán de la lista ¿Desea continuar?", "Eliminar Cuentas Contables", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        For Each item As DataGridViewRow In Me.DgvCuentas.SelectedRows
                            If item.IsNewRow = False Then
                                Me.DgvCuentas.Rows.Remove(item)
                            End If
                        Next
                    End If

                End If
            End If


            'For Each item As DataGridViewRow In DgvCuentas.SelectedRows
            '    If item.Index > 1 Then
            '        isValidRow = True
            '        Exit For
            '    End If
            'Next
            'If isValidRow Then
            '    DgvCuentas.SelectedRows.
            'End If
            'If i > 0 Then
            '    If Not Me.DgvCuentas.Rows(i).IsNewRow Then
            '        If MessageBox.Show("La cuenta contable se eliminará de la lista ¿Desea continuar?", "Eliminar Cuenta Contable", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            '            Me.DgvCuentas.Rows.RemoveAt(i)
            '        End If
            '    End If
            'End If
        End If

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

    End Sub

    Private Sub DgvFacturas_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvFacturas.CellEndEdit
        'Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDec(Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value).ToString("C4")
    End Sub

    Private Sub DgvCuentas_CellBeginEdit_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DgvCuentas.CellBeginEdit
        'CBool(Me.DgvFacturas.Rows(i).Cells("ClmPagar").Value)
        Dim existenFacturas As Boolean = False

        For r As Integer = 0 To Me.DgvFacturas.Rows.Count - 1
            If CBool(Me.DgvFacturas.Rows(r).Cells("ClmPagar").Value) = True Then
                existenFacturas = True
            End If
        Next

        If existenFacturas Then
            Dim abono As Decimal = 0
            If Not String.IsNullOrEmpty(Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                abono = Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString().Replace(",", "") ' e.RowIndex
                Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = abono
            End If
        Else
            MessageBox.Show("Debe seleccionar una factura a pagar para poder editar los importes de las cuentas contables.", "Seleccionar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
            'Me.DgvCuentas.BindingContext(Me.DgvCuentas.DataSource, Me.DgvCuentas.DataMember).EndCurrentEdit()
        End If



        'If txtImporte.Valor > 0 Then
        '    If e.RowIndex > 0 Then
        '        If IsNothing(Me.DgvCuentas.Rows(e.RowIndex - 1).DataBoundItem) Then
        '            e.Cancel = True
        '        Else
        '            If ValorGridCuentas(e.RowIndex - 1, 5) > 0 Or ValorGridCuentas(e.RowIndex - 1, 6) > 0 Then
        '                If (VerificarBalance() = 0) And ValorGridCuentas(e.RowIndex, 5) = 0 Then e.Cancel = True
        '            Else
        '                e.Cancel = True
        '            End If
        '            Select Case e.ColumnIndex
        '                Case 1, 2, 3, 4
        '                    'ValorGridCuentas(e.RowIndex, e.ColumnIndex, QuitarCeros(ValorGridCuentas(e.RowIndex, e.ColumnIndex)))
        '            End Select
        '        End If
        '    End If
        'Else
        '    e.Cancel = True
        '    txtImporte.Focus()
        'End If

    End Sub

    Private Sub DgvCuentas_EditingControlShowing(sender As System.Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DgvCuentas.EditingControlShowing

        Dim cajatexto As TextBox = TryCast(e.Control, TextBox)
        If cajatexto IsNot Nothing Then
            RemoveHandler cajatexto.KeyPress, AddressOf Me.txtImporte_KeyPress
            AddHandler cajatexto.KeyPress, AddressOf Me.txtImporte_KeyPress
        End If
    End Sub

    Private Sub txtImporte_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporte.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



End Class