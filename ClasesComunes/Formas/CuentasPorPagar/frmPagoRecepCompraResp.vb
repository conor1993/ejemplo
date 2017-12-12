Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports ClasesNegocio
Imports System.Drawing
Imports Microsoft.Win32

Public Class frmPagoRecepCompraResp
    Implements InterfaceForm
#Region "Definiciones"
    Dim lnCantidad As Decimal = 0D
    Dim Proveedores As New CN.ProveedorCollectionClass()
    Dim IdProveedor As Integer
    Dim ImporteT As String = ""
    Dim NombreProveedor As String = ""
    Dim SubTot As String = ""
    Dim IVAP As String = ""
    Dim IepsP As String = ""
    Dim FolioRecep As String = ""
    Dim IdRecepOC As Long
    Dim RecepcionOrdenCompra As New CN.RecepcionOrdenCompraClass()
    Public Retiro = New CN.RetiroDeCajaClass
    Dim Turno As New CN.ControlTurnoClass()
    Dim bandera As Boolean = False
    Dim gvCheck As Boolean = False
    Dim TotalGlobal As Decimal = 0
    Dim SubTotalGlobal As Decimal = 0
    Dim IepsGlobal As Decimal = 0
    Dim IvaGlobal As Decimal = 0
    Dim Bancos As BancosCollectionClass
    Dim ClickCheck As Boolean = False
    Private checkboxHeader231 As CheckBox
    Dim list As New ArrayList()
    Dim listPagados As New ArrayList()
    Dim listNopagados As New ArrayList()
    Dim listFacturas As New ArrayList()
    Dim dt As New DataTable
    Dim RetiroCaja As Boolean = False
    Dim cargacodsucucursal As Boolean
    Dim carganomimpresora As Boolean
    Dim combinado As Boolean = False
    Dim EstaBuscando As Boolean = False
#End Region

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'IdProveedor = Proveedor
        'ImporteT = Total
        'NombreProveedor = NomProveedor
        'SubTot = SubTotal
        'IVAP = Iva
        'IepsP = Ieps
        'FolioRecep = FolRecep
        'IdRecepOC = idRecep

        'cmbProveedor.DataSource(Proveedores)
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'Me.llenarComboConceptos(Tipo)
    End Sub

    'Public Sub New()

    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.

    'End Sub

    Private Sub frmPagoRecepCompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        'Select Case e.KeyChar
        '    Case Chr(13)
        '        BtnPagar_Click(sender, New System.EventArgs())
        '    Case Chr(27)
        '        BtnCancelar_Click(sender, New System.EventArgs())
        'End Select
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then

            ' e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Space)
            'e.Handled = False
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)

        End If

        If txtNumCheque.Focused Or txtReferencia.Focused Or txtNumRemision.Focused Or txtCuentaRecep.Focused Then
            If e.KeyChar <> ChrW(Keys.Back) And (Not Char.IsNumber(e.KeyChar)) And e.KeyChar <> ChrW(Keys.Enter) Then
                MsgBox("Solo se permiten numeros.", MsgBoxStyle.Exclamation, "Advertencia")
                e.Handled = True
                Return
            End If
        End If

    End Sub

    Public Function ValidarAgregar() As Boolean
        Dim mensaje As String = ""
        Dim validado As Boolean = True

        If cmbProveedor.SelectedIndex = -1 Then
            mensaje &= "*Seleccione un proveedor." & vbLf
            validado = False
        Else
            If dgvRecepComp.Rows.Count = 0 Then
                mensaje &= "*Sin recepciones de compra pendientes del proveedor " & cmbProveedor.Text & vbLf
                validado = False
            Else
                For i As Integer = 0 To dgvFacturas.Rows.Count - 1
                    If dgvFacturas.Rows(i).Cells(0).Value.ToString = txtFactura.Text.Trim() Or dgvFacturas.Rows(i).Cells(0).Value.ToString = txtNumRemision.Text.Trim() Then
                        mensaje &= "*La factura/Nota Remisión que tratas de agregar ya se encuenta en la lista." & vbLf
                        validado = False
                    End If
                Next
            End If
        End If

        If list.Count = 0 Then
            mensaje &= "*Seleccione recepciones de compra para agregar." & vbLf
            validado = False
        End If

        If rbFactura.Checked Then
            If txtFactura.Text.Trim() = "" Then
                mensaje &= "*El campo No. Factura es requerido." & vbLf
                validado = False
            End If
        ElseIf rbNotaRem.Checked Then
            If txtNumRemision.Text.Trim() = "" Then
                mensaje &= "*El campo No. Remisión es requerido." & vbLf
                validado = False
            End If
        Else
            If rbCheque.Checked Then

                If txtNumCheque.Text.Trim() = "" Then
                    mensaje &= "*El campo de No. de Cheque es requerido antes de agregar. (S/Docto)" & vbLf
                    validado = False
                End If

            ElseIf rbTrans.Checked Then

                If txtReferencia.Text.Trim() = "" Then
                    mensaje &= "*El campo de Referencia es requerido antes de agregar. (S/Docto)" & vbLf
                    validado = False
                End If

            End If
        End If

        If mensaje = "" Then
            validado = True
        Else
            mensaje = "Antes de agregar verifique lo siguiente: " & vbLf & vbLf & mensaje
            MsgBox(mensaje, MsgBoxStyle.Exclamation, "AVISO")
        End If

        Return validado
    End Function

    Public Function Validar() As Boolean
        Dim mensaje As String = ""
        Dim validado As Boolean = True

        If cmbProveedor.SelectedIndex = -1 Then
            mensaje &= "    *Seleccione un proveedor." & vbLf
            validado = False
        End If

        If rbSinDocto.Checked = False Then
            If dgvFacturas.Rows.Count = 0 Then
                mensaje &= "    *Es necesario agregar Factura/Nota Remision/S-Docto." & vbLf
                validado = False
            End If
        Else
            If list.Count <= 0 Then
                mensaje &= "    *Seleccione recepciones que desea pagar." & vbLf
                validado = False
            End If
        End If

        'If rbFactura.Checked Then
        '    If txtFactura.Text.Trim() = "" Then
        '        mensaje &= "    *El campo No. Factura es requerido." & vbLf
        '        validado = False
        '    End If
        'ElseIf rbNotaRem.Checked Then
        '    If txtNumRemision.Text.Trim() = "" Then
        '        mensaje &= "    *El campo No. Remisión es requerido." & vbLf
        '        validado = False
        '    End If
        'End If

        If rbCheque.Checked Then
            If cmbBancos.SelectedIndex = -1 Then
                mensaje &= "    *Seleccione un banco." & vbLf
                validado = False
            End If

            If cmbCuenta.SelectedIndex = -1 Then
                mensaje &= "    *Seleccione un cuenta." & vbLf
                validado = False
            End If

            If txtNumCheque.Text.Trim() = "" Then
                mensaje &= "    *El campo de No. de Cheque es requerido." & vbLf
                validado = False
            End If

        ElseIf rbTrans.Checked Then
            If cmbBancos.SelectedIndex = -1 Then
                mensaje &= "    *Seleccione un banco." & vbLf
                validado = False
            End If

            If cmbCuenta.SelectedIndex = -1 Then
                mensaje &= "    *Seleccione un cuenta." & vbLf
                validado = False
            End If

            If txtReferencia.Text.Trim() = "" Then
                mensaje &= "    *El campo de Referencia es requerido." & vbLf
                validado = False
            End If

            If cmbBancosR.SelectedIndex = -1 Then
                mensaje &= "    *Seleccione un banco receptor." & vbLf
                validado = False
            End If

            If txtCuentaRecep.Text.Trim = "" Then
                mensaje &= "    *El campo No. Cuenta del receptor es requerido." & vbLf
                validado = False
            End If
        End If

        If mensaje = "" Then
            validado = True
            If rbEfect.Checked Then
                Dim result As Integer = MessageBox.Show("¿Deseas retirar de caja?", "AVISO", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    RetiroCaja = False
                ElseIf result = DialogResult.Yes Then
                    RetiroCaja = True
                End If
            End If
        Else
            mensaje = "Antes de realizar el pago verifique lo siguiente: " & vbLf & vbLf & mensaje
            MsgBox(mensaje, MsgBoxStyle.Exclamation, "AVISO")
        End If


        'If txtFolRecep.Text = "" Then
        '    MsgBox("Confirme el número de la recepción", MsgBoxStyle.Exclamation, "AVISO")
        '    txtFolRecep.Focus()
        '    Return False
        'End If
        'If (Me.lblFolRecep.Text <> txtFolRecep.Text) Then
        '    MsgBox("Confirmación incorrecta, reintente", MsgBoxStyle.Exclamation, "AVISO")
        '    txtFolRecep.Text = ""
        '    txtFolRecep.Focus()
        '    Return False
        'End If
        Return validado
    End Function





    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Abort
        limpiar()
        limpiarTotales()
        Me.Close()
    End Sub

    Private Sub frmPagoFacturas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.BtnAceptar.Enabled = False
        'Me.BtnPagar.Enabled = False
        'lblCajero.Text = Controlador.Sesion.MiUsuario.Usrnom
        'timer1.Enabled = True
        'timer1.Interval = 1000



        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "111011111"
        MtbEstados.StateLimpiar = ""
        MtbEstados.StateCancelar = "100100001"
        MtbEstados.StateNuevo = "001010001"
        MtbEstados.StateGuardar = "100100001"
        MtbEstados.StateBorrar = "000100001"
        MtbEstados.StateEditar = "001010000"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        mtb.ToolBarButtonStatus = MtbEstados
        mtb.sbCambiarEstadoBotones("Cancelar")

        If Utilerias.ObtenerCodSucursal = 0 Then
            cargacodsucucursal = False
            Exit Sub
        Else
            cargacodsucucursal = True
        End If

        If Utilerias.ObtenerNomImpresora = "" Then
            carganomimpresora = False
            Exit Sub
        Else
            carganomimpresora = True
        End If


        GBPrincipal.Enabled = False
        lblFecha.Text = Date.Now().ToString("dd-MM-yyyy hh:mm tt")

        lblImporte.Text = ImporteT
        'lblProveedor.Text = NombreProveedor
        txtFactura.CharacterCasing = CharacterCasing.Upper ''Mayusculas
        ' Me.lblFolRecep.Text = FolioRecep
        'Me.txtFactura.Focus()

        ''LLENAR COMBO DE PROVEEDORES
        Proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        cmbProveedor.ValueMember = "Codigo"
        cmbProveedor.DisplayMember = "RazonSocial"
        cmbProveedor.DataSource = Proveedores
        cmbProveedor.SelectedIndex = -1
        cmbProveedor.Text = "Seleccione un Proveedor..."

        ''EVITA QUE SE AGREGUE LA FILA EN BLANCO
        dgvRecepComp.AllowUserToAddRows = False

        txtFactura.Enabled = True
        lblFactura.Enabled = True
        gbFacturadas.Enabled = False
        ''LLENAR BANCOS
        'Bancos = New BancosCollectionClass
        'Bancos.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        'cmbBancos.ValueMember = "IdBanco"
        'cmbBancos.DataSource = Bancos
        'cmbBancos.DisplayMember = "Descripcion"
        'cmbBancos.SelectedIndex = -1
        'cmbBancos.Text = "Seleccione un Banco..."
        'Bancos = New BancosCollectionClass
        'Bancos.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        'cmbBancosR.ValueMember = "IdBanco"
        'cmbBancosR.DataSource = Bancos
        'cmbBancosR.DisplayMember = "Descripcion"
        'cmbBancosR.SelectedIndex = -1
        'cmbBancosR.Text = "Seleccione un Banco..."
        CargarCombos()
        bandera = True
        rbCheque.Checked = True


        dgvRecepComp.Columns(clmSubtotal.Index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvRecepComp.Columns(clmIva.Index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvRecepComp.Columns(clmieps.Index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvRecepComp.Columns(clmNoFactura.Index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvRecepComp.Columns(clmTotal.Index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        ''PONER CHECK SELECCIONA TODO
        'show_chkBox()
        Me.cmbProveedor.Focus()
        rbFactura.Checked = True

        ''AÑADIR COLUMNAS A DATA TABLE
        dt.Columns.Add("ID", GetType(String))
        dt.Columns.Add("Fecha", GetType(Date))
        dt.Columns.Add("Recepciones", GetType(String))
        dt.Columns.Add("Total", GetType(Decimal))
        dt.Columns.Add("IdsROC", GetType(Array))
        dt.Columns.Add("Subtotal", GetType(Decimal))
        dt.Columns.Add("Iva", GetType(Decimal))
        dt.Columns.Add("Ieps", GetType(Decimal))
        dt.Columns.Add("Tipo", GetType(String))
        dt.Columns.Add("UUID", GetType(String))
        chkFormaPago.Checked = False
    End Sub
    Public Sub limpiarTotales()
        Dim n0 As Decimal = 0D
        lblSubtotal.Text = n0.ToString("C2")
        lblIeps.Text = n0.ToString("C2")
        lblIva.Text = n0.ToString("C2")
        lblImporte.Text = n0.ToString("C2")
    End Sub
    Public Sub limpiarTotalesFact()
        Dim n0 As Decimal = 0D
        lblSubTotalFact.Text = n0.ToString("C2")
        lblIepsFact.Text = n0.ToString("C2")
        lblIvaFact.Text = n0.ToString("C2")
        lblTotalFact.Text = n0.ToString("C2")
    End Sub
    Public Sub llenarGridRecepOrdenes()
        ''dgv
        If cmbProveedor.SelectedIndex <> -1 And bandera <> False Then

            'Dim x As ProveedorClass = cmbProveedor.SelectedValue

            dgvRecepComp.Rows.Clear()
            Dim RecepcionesOrdenCompra As New IntegraLab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
            dgvRecepComp.AutoGenerateColumns = False
            If rbFactura.Checked Then
                Dim filtro As New OC.PredicateExpression
                filtro.Add(HC.RecepcionOrdenCompraFields.IdProveedor = cmbProveedor.SelectedValue)
                If chkFacturada.Checked Then
                    gbFacturadas.Enabled = True
                    filtro.Add(HC.RecepcionOrdenCompraFields.Facturada = True)
                    clmNoFactura.Visible = True
                    If rbPagadas.Checked Then
                        filtro.Add(HC.RecepcionOrdenCompraFields.Pagada = True)
                        clmCheTrans.Visible = True

                    ElseIf rbSinPagar.Checked Then
                        filtro.Add(HC.RecepcionOrdenCompraFields.Pagada = False)
                        clmCheTrans.Visible = False
                    End If
                Else
                    clmCheTrans.Visible = False
                    clmNoFactura.Visible = False
                    gbFacturadas.Enabled = False
                    filtro.Add(HC.RecepcionOrdenCompraFields.Facturada = False)
                End If

                'If chkPagada.Checked And chkSPagar.Checked Then
                '    filtro.Add(HC.RecepcionOrdenCompraFields.Pagada = True Or HC.RecepcionOrdenCompraFields.Pagada = False)
                'Else
                '    If chkPagada.Checked Then
                '        filtro.Add(HC.RecepcionOrdenCompraFields.Pagada = True)
                '    ElseIf chkSPagar.Checked Then
                '        filtro.Add(HC.RecepcionOrdenCompraFields.Pagada = False)
                '    End If
                'End If

                RecepcionesOrdenCompra.GetMulti(filtro)
                ' RecepcionesOrdenCompra.GetMulti(HC.RecepcionOrdenCompraFields.IdProveedor = cmbProveedor.SelectedValue And HC.RecepcionOrdenCompraFields.Facturada = False)

            Else


                If rbNotaRem.Checked Then
                    ''nota remision
                    RecepcionesOrdenCompra.GetMulti(HC.RecepcionOrdenCompraFields.IdProveedor = cmbProveedor.SelectedValue And HC.RecepcionOrdenCompraFields.Pagada = False And HC.RecepcionOrdenCompraFields.Facturada = False And HC.RecepcionOrdenCompraFields.NoRemision = "")
                Else
                    ''sin docto
                    RecepcionesOrdenCompra.GetMulti(HC.RecepcionOrdenCompraFields.IdProveedor = cmbProveedor.SelectedValue And HC.RecepcionOrdenCompraFields.Pagada = False And HC.RecepcionOrdenCompraFields.Facturada = False And HC.RecepcionOrdenCompraFields.NoRemision = "")
                End If


            End If


            'RecepcionOrdenCompra.GetMulti(HC.RecepcionOrdenCompraFields.IdOrdenCompra = OrdenesCompra(i).IdOrdenCompra) ''And HC.RecepcionOrdenCompraFields.Facturada = False)
            'RecepcionesOrdenCompra.Add(RecepcionOrdenCompra(0))
            'Me.dgvRecepComp.DataSource = RecepcionesOrdenCompra

            For Each row As EC.RecepcionOrdenCompraEntity In RecepcionesOrdenCompra
                Dim fact As New CN.FacturasCabCXPClass(Controlador.Empresa.CodEmpndx, row.IdProveedor, row.NoFactura)
                Dim chetra As String = ""
                If fact.Estatus = EstatusFacturasEnum.PAGADA Then
                    Dim Pago As New CN.PagosProveedoresColeccionClass
                    Pago.Obtener(row.IdProveedor, row.NoFactura, Controlador.Empresa.CodEmpndx)
                    ' cmbCuenta.SelectedValue = Pago(0).CuentaBancaria.Codigo
                    Dim chetran As New CN.ChequeCollectionClass()
                    Dim filtro As New OC.PredicateExpression
                    filtro.Add(HC.ChequeFields.Folio = Pago(0).Cheque And HC.ChequeFields.CuentaId = Pago(0).CuentaBancaria.Codigo)
                    chetran.Obtener(filtro)
                    If chetran.Count > 0 Then

                        If chetran(0).Medio = BancosMovimientosMedio.CHEQUE Then
                            'txtNumCheque.Text = Pago(0).Cheque
                            'rbCheque.Checked = True
                            chetra = Pago(0).Cheque
                        ElseIf chetran(0).Medio = BancosMovimientosMedio.ELECTRONICO Then
                            'rbTrans.Checked = True
                            'cmbBancosR.SelectedValue = chetran(0).CodBancoDestino.ToString("000")
                            'txtCuentaRecep.Text = chetran(0).CuentaDestinoReceptor
                            'txtNumCheque.Text = ""
                            'txtReferencia.Text = chetran(0).Referencia
                            chetra = Pago(0).Referencia


                        End If
                        'Else
                        '    rbEfect.Checked = True
                    Else
                        chetra = "EFECTIVO"
                    End If
                End If
                dgvRecepComp.Rows.Add(False, row.IdRecepcionOrdenCompra, IIf(row.NoRemision = "", row.FolioRecepcionOrdenCompra, row.NoRemision).ToString(), row.NoFactura, row.FechaRecepcion, row.SubTotal, row.Iva, row.Ieps, row.Total, Nothing, (IIf(row.Pagada = True, "PAGADA", "POR PAGAR")), chetra)
            Next
            'dgvRecepComp.Focus()
            'dgvRecepComp.Rows(0).Cells(0).Selected = False
            'dgvRecepComp.Rows(0).Cells(1).Selected = True


            'Me.dgvRecepComp.DataSource = RecepcionesOrdenCompra

            dgvRecepComp.Columns(1).DataPropertyName = "IdRecepcionOrdenCompra"
            dgvRecepComp.Columns(2).DataPropertyName = "FechaRecepcion"
            dgvRecepComp.Columns(3).DataPropertyName = "SubTotal"
            dgvRecepComp.Columns(4).DataPropertyName = "Iva"
            dgvRecepComp.Columns(5).DataPropertyName = "Ieps"
            dgvRecepComp.Columns(6).DataPropertyName = "Total"


        End If

    End Sub

    Private Sub BtnPagar_Click(sender As System.Object, e As System.EventArgs)

    End Sub



    Private Sub txtFactura_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        'If Me.txtFactura.Text.Length <= 0 Then
        '    Me.BtnPagar.Enabled = False
        'Else
        '    Me.BtnPagar.Enabled = True
        'End If

    End Sub

    Private Sub txtFactura_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Convert.ToInt32(e.KeyChar) = 13 Then
            ' Me.txtFolRecep.Focus()
        End If
    End Sub

    Private Sub cmbProveedor_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cmbProveedor.SelectedValueChanged

    End Sub

    Private Sub cmbProveedor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbProveedor.SelectedIndexChanged
        If bandera Then
            llenarGridRecepOrdenes()
            limpiar()
            list.Clear()
            dgvFacturas.DataSource = Nothing
        End If




    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GBPrincipal.Enter

    End Sub

    Private Sub dgvRecepComp_CurrentCellDirtyStateChanged(sender As System.Object, e As System.EventArgs) Handles dgvRecepComp.CurrentCellDirtyStateChanged
        If dgvRecepComp.IsCurrentCellDirty Then
            ClickCheck = True
            dgvRecepComp.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgvRecepComp_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRecepComp.CellValueChanged
        If e.RowIndex <> -1 Then
            If e.ColumnIndex = 0 Then

                Dim Total As Object = dgvRecepComp.Rows(e.RowIndex).Cells(clmTotal.Index).Value
                Dim SubTotal As Object = dgvRecepComp.Rows(e.RowIndex).Cells(clmSubtotal.Index).Value
                Dim Iva As Object = dgvRecepComp.Rows(e.RowIndex).Cells(clmIva.Index).Value
                Dim Ieps As Object = dgvRecepComp.Rows(e.RowIndex).Cells(clmieps.Index).Value
                Dim Id As Object = dgvRecepComp.Rows(e.RowIndex).Cells(clmIdRecepCom.Index).Value
                If dgvRecepComp.Rows(e.RowIndex).Cells(0).Value = True Then
                    TotalGlobal = TotalGlobal + Total
                    SubTotalGlobal = SubTotalGlobal + SubTotal
                    IvaGlobal = IvaGlobal + Iva
                    IepsGlobal = IepsGlobal + Ieps
                    lblImporte.Text = TotalGlobal.ToString("C3")
                    lblSubtotal.Text = SubTotalGlobal.ToString("C3")
                    lblIva.Text = IvaGlobal.ToString("C3")
                    lblIeps.Text = IepsGlobal.ToString("C3")
                    If dgvRecepComp.Rows(e.RowIndex).Cells(clmEstatus.Index).Value.Equals("PAGADA") Then
                        listPagados.Add(Id)
                    Else
                        listNopagados.Add(Id)
                    End If
                    If chkFacturada.Checked And rbSinPagar.Checked Then
                        If Not listFacturas.Contains(dgvRecepComp.Rows(e.RowIndex).Cells(clmNoFactura.Index).Value) Then
                            listFacturas.Add(dgvRecepComp.Rows(e.RowIndex).Cells(clmNoFactura.Index).Value)
                            Dim fact As String = dgvRecepComp.Rows(e.RowIndex).Cells(clmNoFactura.Index).Value.ToString()
                            For Each row As DataGridViewRow In dgvRecepComp.Rows
                                If row.Cells(clmNoFactura.Index).Value.ToString().Equals(fact) Then
                                    row.Cells(Pagar.Index).Value = True
                                End If
                            Next
                        End If
                    End If


                    list.Add(Id)
                ElseIf dgvRecepComp.Rows(e.RowIndex).Cells(0).Value = False And ClickCheck = True Then
                    TotalGlobal = TotalGlobal - Total
                    SubTotalGlobal = SubTotalGlobal - SubTotal
                    IvaGlobal = IvaGlobal - Iva
                    IepsGlobal = IepsGlobal - Ieps
                    lblImporte.Text = TotalGlobal.ToString("C3")
                    lblSubtotal.Text = SubTotalGlobal.ToString("C3")
                    lblIva.Text = IvaGlobal.ToString("C3")
                    lblIeps.Text = IepsGlobal.ToString("C3")
                    list.Remove(Id)
                    If dgvRecepComp.Rows(e.RowIndex).Cells(clmEstatus.Index).Value.Equals("PAGADA") Then
                        listPagados.Remove(Id)
                    Else
                        listNopagados.Remove(Id)
                    End If

                    If chkFacturada.Checked And rbSinPagar.Checked Then
                        Dim count As Integer = 0
                        For Each row As DataGridViewRow In dgvRecepComp.Rows
                            If dgvRecepComp.Rows(e.RowIndex).Cells(clmNoFactura.Index).Value.ToString().Equals(row.Cells(clmNoFactura.Index).Value.ToString()) And row.Cells(Pagar.Index).Value = True Then
                                count += 1
                            End If
                        Next
                        If listFacturas.Contains(dgvRecepComp.Rows(e.RowIndex).Cells(clmNoFactura.Index).Value) Then
                            listFacturas.Remove(dgvRecepComp.Rows(e.RowIndex).Cells(clmNoFactura.Index).Value)
                            Dim fact As String = dgvRecepComp.Rows(e.RowIndex).Cells(clmNoFactura.Index).Value.ToString()
                            For Each row As DataGridViewRow In dgvRecepComp.Rows
                                If row.Cells(clmNoFactura.Index).Value.ToString().Equals(fact) Then
                                    row.Cells(Pagar.Index).Value = False
                                End If
                            Next
                        End If
                    End If
                End If
                If listNopagados.Count > 0 And listPagados.Count > 0 Then
                    chkFormaPago.Checked = False
                    chkFormaPago.Enabled = False
                Else
                    If listPagados.Count > 0 Then
                        chkFormaPago.Checked = False
                        chkFormaPago.Enabled = False
                    Else
                        chkFormaPago.Enabled = True
                    End If
                End If


            End If
        End If
    End Sub

    Public Sub limpiar()
        TotalGlobal = 0
        SubTotalGlobal = 0
        IvaGlobal = 0
        IepsGlobal = 0
        listNopagados.Clear()
        listPagados.Clear()
        EstaBuscando = False
        chkFormaPago.Checked = False
        gbFormaPago.Enabled = False
        limpiarTotales()
    End Sub

    Public Function EstaCombinados() As Boolean
        For Each row As DataGridViewRow In dgvRecepComp.Rows

        Next
    End Function

    Private Sub TabPage2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbCheque.CheckedChanged
        If rbCheque.Checked Then
            cmbBancos.Enabled = True
            cmbCuenta.Enabled = True
            txtNumCheque.Enabled = True
            txtReferencia.Enabled = False
            cmbBancosR.Enabled = False
            txtCuentaRecep.Enabled = False

        End If
    End Sub

    Private Sub rbTrans_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbTrans.CheckedChanged
        If rbTrans.Checked Then
            cmbBancos.Enabled = True
            cmbCuenta.Enabled = True
            txtNumCheque.Enabled = False
            txtReferencia.Enabled = True
            cmbBancosR.Enabled = True
            txtCuentaRecep.Enabled = True

        End If
    End Sub

    Private Sub rbEfect_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbEfect.CheckedChanged
        If rbEfect.Checked Then
            'BtnPagar.Enabled = True
            cmbBancos.Enabled = False
            cmbCuenta.Enabled = False
            txtNumCheque.Enabled = False
            txtReferencia.Enabled = False
            cmbBancosR.Enabled = False
            txtCuentaRecep.Enabled = False
        End If

    End Sub

    Private Sub dgvRecepComp_RowPrePaint(sender As System.Object, e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgvRecepComp.RowPrePaint
        ClickCheck = False
        dgvRecepComp.Rows(e.RowIndex).Cells(clmDetalle.Index).Value = "..."
    End Sub



    Public Sub AgregarCmbCuentas()
        If cmbBancos.SelectedIndex <> -1 Then
            Dim esnumero As Boolean = Int32.TryParse(cmbCuenta.Text.Trim(), 0)
            If esnumero Then
                Dim Cuentas As New Integralab.ORM.CollectionClasses.CuentaCollection
                Cuentas.GetMulti(HC.CuentaFields.Cuenta = cmbCuenta.Text)
                If Cuentas.Count = 0 Then
                    Dim Cuenta As New CuentaClass

                    ''Cuenta.Banco = cmbBancos.SelectedValue
                    Cuenta.CodBanco = cmbBancos.SelectedValue
                    Cuenta.Cuenta = cmbCuenta.Text.Trim()
                    Dim Empresa As New EmpresaClass
                    Empresa.Obtener(Controlador.Sesion.Empndx)
                    Cuenta.Empresa = Empresa
                    Cuenta.Estatus = Integra.Clases.EstatusEnum.ACTIVO
                    Dim TipoMoneda As New TipoMonedaClass
                    TipoMoneda.Obtener(1)
                    Cuenta.TipoMoneda = TipoMoneda
                    Try
                        If Cuenta.Guardar() Then
                            llenarCuentas()
                            bandera = False
                            cmbCuenta.SelectedValue = Cuenta.Codigo
                            bandera = True
                            MessageBox.Show("Se agrego la cuenta a la lista.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        Else
            MessageBox.Show("Selecciona un banco.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbCuenta.Text = "Selecciona una cuenta..."
            cmbCuenta.SelectedIndex = -1
            cmbBancos.Focus()
        End If
    End Sub

    Private Sub cmbCuenta_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCuenta.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            AgregarCmbCuentas()
        End If
    End Sub

    Public Sub llenarCuentas()
        ' If cmbBancos.SelectedIndex <> -1 Then
        Dim Cuentas = New Integralab.ORM.CollectionClasses.CuentaCollection
        'Dim Filtro As New OC.PredicateExpression
        'Filtro.Add(HC.CuentaFields.Estatus = ClasesNegocio.EstatusEnum.ACTIVO And HC.CuentaFields.BancoId = cmbBancos.SelectedValue)
        'Dim Banco As BancosClass
        'Banco = cmbBancos.SelectedValue
        If cmbBancos.SelectedIndex <> -1 And cmbBancos.SelectedValue IsNot Nothing Then
            Cuentas.GetMulti(HC.CuentaFields.Estatus = ClasesNegocio.EstatusEnum.ACTIVO And HC.CuentaFields.BancoId = cmbBancos.SelectedValue)
        Else
            Cuentas.GetMulti(HC.CuentaFields.Estatus = ClasesNegocio.EstatusEnum.ACTIVO)
        End If
        cmbCuenta.ValueMember = "Codigo"
        cmbCuenta.DisplayMember = "Cuenta"
        cmbCuenta.DataSource = Cuentas
        cmbCuenta.SelectedIndex = -1
        cmbCuenta.Text = "Seleccione o teclee una cuenta..."
        '  End If
    End Sub

    Private Sub cmbBancos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbBancos.SelectedIndexChanged
        If bandera Then
            llenarCuentas()
        End If
    End Sub

    ''CONTROL CHECKBOX SELECCIONA TODA LA COLUMNA
    Private Sub show_chkBox()
        Dim rect As Rectangle = dgvRecepComp.GetCellDisplayRectangle(0, -1, True)
        ' set checkbox header to center of header cell. +1 pixel to position 
        rect.Y = 12
        rect.X = rect.Location.X + 3 + (rect.Width / 4)
        checkboxHeader231 = New CheckBox()
        With checkboxHeader231
            .BackColor = Color.Transparent
        End With

        checkboxHeader231.Name = "checkboxHeader1"
        checkboxHeader231.Size = New Size(18, 18)
        checkboxHeader231.Location = rect.Location
        AddHandler checkboxHeader231.CheckedChanged, AddressOf checkboxHeader231_CheckedChanged
        dgvRecepComp.Controls.Add(checkboxHeader231)
    End Sub
    ''EVENTO CAMBIO DEL CHECKBOX DE COLUMNA
    Private Sub checkboxHeader231_CheckedChanged(sender As System.Object, e As System.EventArgs)
        Dim headerBox As CheckBox = DirectCast(dgvRecepComp.Controls.Find("checkboxHeader1", True)(0), CheckBox)
        If headerBox.Checked = False Then
            ClickCheck = True
        End If
        For i As Integer = 0 To dgvRecepComp.Rows.Count - 1
            dgvRecepComp.Rows(i).Cells(0).Value = headerBox.Checked
        Next


        'For Each row As DataGridViewRow In dgvRecepComp.Rows
        '    row.Cells(0).Value = headerBox.Checked
        'Next
    End Sub

    Private Sub dgvRecepComp_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvRecepComp.KeyDown

    End Sub

    Private Sub dgvRecepComp_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles dgvRecepComp.KeyPress


    End Sub

    Private Sub rbFactura_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbFactura.CheckedChanged
        Me.txtFactura.Enabled = True
        'Me.lblFec.Text = "Fecha Factura: "
        Me.MtxtUUID.Enabled = True
        'Me.DtpFechaFac.Enabled = True
        Me.DtpFechaFac.Enabled = True
        Me.txtNumRemision.Enabled = False
        Me.txtNumRemision.Text = ""

        btnAgregarFact.Enabled = True
        dgvFacturas.Enabled = True
        llenarGridRecepOrdenes()
        list.Clear()
        limpiarTotales()
        limpiar()
    End Sub

    Private Sub rbNotaRem_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbNotaRem.CheckedChanged
        chkFacturada.Checked = False
        Me.txtFactura.Enabled = False
        'Me.lblFec.Text = "Fecha Remisión:"
        Me.txtFactura.Text = ""
        Me.MtxtUUID.Enabled = False
        Me.MtxtUUID.Text = ""
        Me.DtpFechaFac.Enabled = True
        'Me.DtpFechaFac.Enabled = False
        Me.txtNumRemision.Enabled = True

        btnAgregarFact.Enabled = True
        dgvFacturas.Enabled = True
        llenarGridRecepOrdenes()
        list.Clear()
        limpiarTotales()
        limpiar()
    End Sub

    Private Sub rbSinDocto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbSinDocto.CheckedChanged
        If bandera Then
            chkFacturada.Checked = False
            Me.txtFactura.Enabled = False
            'Me.lblFec.Text = "Fecha Factura: "
            Me.txtFactura.Text = ""
            Me.MtxtUUID.Enabled = False
            Me.MtxtUUID.Text = ""
            Me.txtNumRemision.Text = ""
            Me.txtNumRemision.Enabled = False
            Me.DtpFechaFac.Enabled = False

            llenarGridRecepOrdenes()
            dgvFacturas.DataSource = Nothing
            btnAgregarFact.Enabled = False
            dgvFacturas.Enabled = False
            'btnAgregarFact.Visible = False
            'dgvFacturas.Visible = False
            list.Clear()
            limpiarTotales()
            limpiar()
            limpiarTotalesFact()
            ''se selecciona el numero
        End If
    End Sub




    Public Sub addFactDGV()
        Dim row As DataRow = dt.NewRow()
        'dt.Columns.Add("ID", GetType(String))
        'dt.Columns.Add("Fecha", GetType(Date))
        'dt.Columns.Add("Recepciones", GetType(String))
        'dt.Columns.Add("Total", GetType(Decimal))
        'dt.Columns.Add("IdsROC", GetType(Array))
        'dt.Columns.Add("Subtotal", GetType(Decimal))
        'dt.Columns.Add("Iva", GetType(Decimal))
        'dt.Columns.Add("Ieps", GetType(Decimal))
        If rbFactura.Checked Then
            row("ID") = txtFactura.Text.Trim()
            row("Tipo") = "F"
            If MtxtUUID.MaskFull Then
                row("UUID") = MtxtUUID.Text
            Else
                row("UUID") = ""
            End If
        ElseIf rbNotaRem.Checked Then
            row("ID") = txtNumRemision.Text.Trim()
            row("Tipo") = "NR"
            row("UUID") = ""
        ElseIf rbSinDocto.Checked Then
            row("ID") = "SinFacturaChe:" & txtNumCheque.Text.Trim()
            row("Tipo") = "SD"
        End If


        row("Fecha") = DtpFechaFac.Value.ToString("dd/MM/yyyy")
        Dim ids As String = ""
        For i As Integer = 0 To list.Count - 1
            If i = 0 Then
                ids = ids & list(i).ToString
            Else
                ids = ids & "," & list(i).ToString
            End If


        Next
        row("Recepciones") = ids
        row("Total") = Convert.ToDecimal(Replace(lblImporte.Text, "$", ""))
        row("IdsROC") = list.ToArray
        row("Subtotal") = SubTotalGlobal
        row("Iva") = IvaGlobal
        row("Ieps") = IepsGlobal

        lblSubTotalFact.Text = (Convert.ToDecimal(Replace(lblSubTotalFact.Text, "$", "")) + SubTotalGlobal).ToString("C2")
        lblIvaFact.Text = (Convert.ToDecimal(Replace(lblIvaFact.Text, "$", "")) + IvaGlobal).ToString("C2")
        lblIepsFact.Text = (Convert.ToDecimal(Replace(lblIepsFact.Text, "$", "")) + IepsGlobal).ToString("C2")
        'lblSubTotalFact.Text = (Convert.ToDecimal(Replace(lblSubTotalFact.Text, "$", "")) + SubTotalGlobal).ToString("C2")
        lblTotalFact.Text = (Convert.ToDecimal(Replace(lblTotalFact.Text, "$", "")) + Convert.ToDecimal(Replace(lblImporte.Text, "$", ""))).ToString("C2")
        dt.Rows.Add(row)
        dgvFacturas.DataSource = dt

        ''Eliminar los seleccionados en datatable de las recepciones

        'For i As Integer = 0 To dgvRecepComp.RowCount - 1
        '    'For j As Integer = 0 To list.Count - 1
        '    '    'If dgvRecepComp.Rows(i).Cells(0).Value = list(j) Then

        '    '    'End If


        '    'Next
        '    'DGV.Rows.Remove(DGV.Rows(i - 1))
        '    'DGV.Refresh()
        '    If dgvRecepComp.Rows(i).Cells(0).Value = True Then
        '        dgvRecepComp.Rows.Remove(dgvRecepComp.Rows(i))
        '        dgvRecepComp.Refresh()
        '    End If
        'Next
        'For Each r As DataGridViewRow In dgvRecepComp.Rows
        '    'If Not row.IsNewRow Then
        '    '    MessageBox.Show(row.Cells(0).Value.ToString & "," & row.Cells(1).Value.ToString)
        '    'End If
        '    If r.Cells(0).Value = True Then
        '        dgvRecepComp.Rows.Remove(r)

        '    End If

        'Next
        Dim r As Integer = 0
        Dim count As Integer = dgvRecepComp.RowCount - 1
        While r <= count


            If dgvRecepComp.Rows(r).Cells(0).Value = True Then
                dgvRecepComp.Rows.Remove(dgvRecepComp.Rows(r))
                r = 0
                count = dgvRecepComp.RowCount - 1
            Else
                r += 1
            End If

        End While



        dgvRecepComp.Refresh()



        list.Clear()
        Me.txtFactura.Text = ""
        Me.MtxtUUID.Text = ""
        Me.txtNumRemision.Text = ""
        Me.DtpFechaFac.Value = Now
        limpiar()


    End Sub

    Private Sub btnAgregarFact_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarFact.Click
        'If ValidarAgregar() Then
        '    addFactDGV()
        'Else
        '    Return
        'End If
        'Dim row As DataRow
        'Dim lista As Array
        'For i As Integer = 0 To dt.Rows.Count - 1
        '    lista = dt.Rows(i)(4)
        'Next
        'Dim x As Integer = lista.Count

    End Sub

    Private Sub dgvFacturas_CellToolTipTextNeeded(sender As System.Object, e As System.Windows.Forms.DataGridViewCellToolTipTextNeededEventArgs) Handles dgvFacturas.CellToolTipTextNeeded
        If e.RowIndex <> -1 And e.ColumnIndex <> -1 Then
            e.ToolTipText = dgvFacturas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString
        End If


    End Sub

    Public Sub CargarCombos()
        'cmbCuenta.SelectedIndex = -1
        'cmbCuenta.Text = "Seleccione o teclee una cuenta..."


        Dim sort As New OC.SortExpression
        sort.Add(New OC.SortClause(HC.ECtSatcatBancosFields.NomCorto, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

        Dim bcos As New CC.ECtSatcatBancosCollection
        bcos.GetMulti(Nothing, 0, sort)

        'Bancos = New BancosCollectionClass
        'Bancos.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

        cmbBancos.ValueMember = "CveBco"
        cmbBancos.DataSource = bcos
        cmbBancos.DisplayMember = "NomCorto"
        cmbBancos.SelectedIndex = -1
        cmbBancos.Text = "Seleccione un Banco..."

        llenarCuentas()

        bcos = New CC.ECtSatcatBancosCollection
        bcos.GetMulti(Nothing, 0, sort)

        'Bancos = New BancosCollectionClass
        'Bancos.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        cmbBancosR.ValueMember = "CveBco"
        cmbBancosR.DataSource = bcos
        cmbBancosR.DisplayMember = "NomCorto"
        cmbBancosR.SelectedIndex = -1
        cmbBancosR.Text = "Seleccione un Banco..."
    End Sub

    Private Sub dgvFacturas_DataBindingComplete(sender As System.Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgvFacturas.DataBindingComplete
        dgvFacturas.Columns("Tipo").Visible = False
        dgvFacturas.Columns("UUID").Visible = False
    End Sub

#Region "Metodos Barra"
    Public Sub Escritura() Implements InterfaceForm.Escritura
        'pan.Enabled = True
        'Me.DgvCuentas.Enabled = True ' fg.Enabled = True
        'Me.DgvFacturas.Enabled = True
        'Me.txtConcepto.Enabled = False
    End Sub

    Public Sub Lectura() Implements InterfaceForm.Lectura
        'pan.Enabled = False
        'Me.DgvCuentas.Enabled = False ' fg.Enabled = False
        'Me.DgvFacturas.Enabled = False
    End Sub

    Public Sub LimpiarBarra() Implements InterfaceForm.Limpiar
        'LimpiarBancos()
        'LimpiarBeneficiarios()
        'dtp.Value = Now
        'txtImporte.Text = "0"
        'txtSaldo.Text = "0"
        'txtConcepto.Clear()
        'txtImporteLetra.Clear()
        'txtCuenta.Clear()
        'txtFolio.Clear()
        'txtReferencia.Clear()
        'txtPoliza.Clear()
        'txtCargo.Text = "0"
        'txtAbono.Text = "0"
        'txtTipoCambio.Text = "0"
        'chkElectronico.Checked = False
        'Me.DgvFacturas.DataSource = Nothing
        'NoFacturas = False
        'Buscar = False
        'Me.DgvFacturas.Columns(3).DataPropertyName = "ImporteAbono"
        'Me.DgvFacturas.Columns(4).DataPropertyName = "ImporteTotal"
        'Me.DgvFacturas.Columns(5).DataPropertyName = "Saldo"
        'Me.DgvFacturas.Columns(6).DataPropertyName = "ImporteaPagar"
    End Sub

    Public Sub Mostrar() Implements InterfaceForm.Mostrar
        'ojo
        'cmbBanco.SelectedValue = cheque.Cuenta.Banco.DescripcionCta
        'RellenarCuentas()
        'For Each item As ListViewItem In lv.Items
        '    If IsNothing(item.Tag) And IsNothing(cheque.Cuenta) Then
        '        item.Selected = True
        '        txtCuenta.Text = String.Format("{0} - {1}")
        '        txtSaldo.Text = (0D).ToString("C").ToString
        '    ElseIf Not IsNothing(item.Tag) And Not IsNothing(cheque.Cuenta) Then
        '        Dim tmp As CN.CuentaClass = DirectCast(item.Tag, CN.CuentaClass)
        '        If tmp.Cuenta = cheque.Cuenta.Cuenta Then
        '            item.Selected = True
        '            Cuenta = tmp
        '            txtCuenta.Text = String.Format("{0} - {1}", item.SubItems(0).Text, item.SubItems(1).Text)
        '            txtSaldo.Text = Cuenta.SaldoActual.ToString("C")
        '        End If
        '    End If
        'Next
        'txtBeneficiario.Text = cheque.Beneficiario.Beneficiario
        'dtp.Value = cheque.FechaDocumento
        'txtImporte.Text = cheque.Importe.ToString
        'txtConcepto.Text = cheque.Concepto
        '' chkAnticipo.Checked = cheque.Anticipo
        'Select Case cheque.Medio
        '    Case ClasesNegocio.BancosMovimientosMedio.CHEQUE
        '        chkElectronico.Checked = False

        '    Case ClasesNegocio.BancosMovimientosMedio.ELECTRONICO
        '        chkElectronico.Checked = True
        'End Select
        'txtReferencia.Text = cheque.Folio
        'txtFolio.Text = cheque.Folio
        'MostrarPolizaFlexGrid(cheque.Poliza)
        ''Obtener las facturas 
        'Dim Pago As New Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection
        'Pago.GetMulti(Integralab.ORM.HelperClasses.UsrCxppagosProveedoresFields.EmpresaId = Controlador.Sesion.Empndx And Integralab.ORM.HelperClasses.UsrCxppagosProveedoresFields.Cheque = cheque.Folio)
        'Dim Fac As New Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
        'Dim Facs As New Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
        'Me.DgvFacturas.AutoGenerateColumns = False
        'For i As Integer = 0 To Pago.Count - 1
        '    Fac.GetMulti(HC.UsrCxpfacturasCabFields.EmpresaId = Controlador.Sesion.Empndx And Integralab.ORM.HelperClasses.UsrCxpfacturasCabFields.NoFactura = Pago(i).NoFactura)
        '    Facs.Add(Fac(0))
        '    Me.DgvFacturas.DataSource = Facs
        '    Me.DgvFacturas.Rows(i).Cells("ClmApagar").Value = Pago(i).Importe
        'Next
        'Me.DgvFacturas.Columns(3).DataPropertyName = "Anticipo"
        'Me.DgvFacturas.Columns(4).DataPropertyName = "Total"
        'Me.DgvFacturas.Columns(5).DataPropertyName = "Saldo"
        'Me.DgvFacturas.Columns(6).DataPropertyName = ""

        'For i As Integer = 0 To Pago.Count - 1
        '    Me.DgvFacturas.Rows(i).Cells("ClmApagar").Value = Pago(i).Importe
        'Next
    End Sub

    Public Function ValidarBarra() As String Implements InterfaceForm.Validar

        Dim mensaje As String = Nothing
        'Dim validado As Boolean = True






        If cmbProveedor.SelectedIndex = -1 Then
            mensaje &= "    *Seleccione un proveedor." & vbLf
            'validado = False
        End If

        If dgvRecepComp.Rows.Count = 0 And cmbProveedor.SelectedValue IsNot Nothing Then
            mensaje &= "    *Sin " & IIf(rbFactura.Checked And chkFacturada.Checked And rbSinPagar.Checked, "facturas", "recepciones") & " pendientes para el proveedor " & cmbProveedor.Text & "." & vbLf
        End If

        'If rbSinDocto.Checked = False Then
        '    If dgvFacturas.Rows.Count = 0 Then
        '        mensaje &= "    *Es necesario agregar Factura/Nota Remision/S-Docto." & vbLf
        '        validado = False
        '    End If
        'Else
        '    If list.Count <= 0 Then
        '        mensaje &= "    *Seleccione recepciones que desea pagar." & vbLf
        '        validado = False
        '    End If
        'End If

        If rbFactura.Checked Then
            If txtFactura.Enabled Then
                If txtFactura.Text.Trim() = "" Then
                    mensaje &= "    *Se requiere del numero de factura." & vbLf
                End If
            End If
            If chkFacturada.Checked And rbSinPagar.Checked Then
                If chkFormaPago.Checked = False Then
                    mensaje &= "    *Seleccione la forma de pago." & vbLf
                End If
            End If
            If chkFormaPago.Checked Then
                If rbCheque.Checked Then
                    If cmbCuenta.SelectedIndex = -1 Or cmbCuenta.SelectedValue Is Nothing Then
                        mensaje &= "    *Se requiere seleccionar una cuenta." & vbLf
                    End If
                    If cmbBancos.SelectedIndex = -1 Or cmbBancos.SelectedValue Is Nothing Then
                        mensaje &= "    *Se requiere seleccionar un banco." & vbLf
                    End If
                    If txtNumCheque.Text.Trim() = "" Then
                        mensaje &= "    *Se requiere del numero del cheque." & vbLf
                    End If
                ElseIf rbTrans.Checked Then
                    If cmbCuenta.SelectedIndex = -1 Or cmbCuenta.SelectedValue Is Nothing Then
                        mensaje &= "    *Se requiere seleccionar una cuenta." & vbLf
                    End If
                    If cmbBancos.SelectedIndex = -1 Or cmbBancos.SelectedValue Is Nothing Then
                        mensaje &= "    *Se requiere seleccionar un banco." & vbLf
                    End If
                    If txtReferencia.Text.Trim() = "" Then
                        mensaje &= "    *Se requiere del numero de la referencia." & vbLf
                    End If

                    If cmbBancosR.SelectedIndex = -1 Or cmbBancosR.SelectedValue Is Nothing Then
                        mensaje &= "    *Se requiere seleccionar el banco del receptor." & vbLf
                    End If
                    If txtCuentaRecep.Text.Trim() = "" Then
                        mensaje &= "    *Se requiere seleccionar la cuenta del receptor." & vbLf
                    End If
                Else

                End If

            End If
        ElseIf rbNotaRem.Checked Then
            If txtNumRemision.Text.Trim() = "" Then
                mensaje &= "    *Se requiere del numero de nota de remisión." & vbLf
            End If
            If chkFormaPago.Checked Then
                If rbCheque.Checked Then
                    If cmbCuenta.SelectedIndex = -1 Or cmbCuenta.SelectedValue Is Nothing Then
                        mensaje &= "    *Se requiere seleccionar una cuenta." & vbLf
                    End If
                    If cmbBancos.SelectedIndex = -1 Or cmbBancos.SelectedValue Is Nothing Then
                        mensaje &= "    *Se requiere seleccionar un banco." & vbLf
                    End If
                    If txtNumCheque.Text.Trim() = "" Then
                        mensaje &= "    *Se requiere del numero del cheque." & vbLf
                    End If
                ElseIf rbTrans.Checked Then
                    If cmbCuenta.SelectedIndex = -1 Or cmbCuenta.SelectedValue Is Nothing Then
                        mensaje &= "    *Se requiere seleccionar una cuenta." & vbLf
                    End If
                    If cmbBancos.SelectedIndex = -1 Or cmbBancos.SelectedValue Is Nothing Then
                        mensaje &= "    *Se requiere seleccionar un banco." & vbLf
                    End If
                    If txtReferencia.Text.Trim() = "" Then
                        mensaje &= "    *Se requiere del numero de la referencia." & vbLf
                    End If

                    If cmbBancosR.SelectedIndex = -1 Or cmbBancosR.SelectedValue Is Nothing Then
                        mensaje &= "    *Se requiere seleccionar el banco del receptor." & vbLf
                    End If
                    If txtCuentaRecep.Text.Trim() = "" Then
                        mensaje &= "    *Se requiere seleccionar la cuenta del receptor." & vbLf
                    End If
                Else

                End If

            End If
        Else
            If chkFormaPago.Checked Then
                If rbCheque.Checked Then
                    If cmbCuenta.SelectedIndex = -1 Or cmbCuenta.SelectedValue Is Nothing Then
                        mensaje &= "    *Se requiere seleccionar una cuenta." & vbLf
                    End If
                    If cmbBancos.SelectedIndex = -1 Or cmbBancos.SelectedValue Is Nothing Then
                        mensaje &= "    *Se requiere seleccionar un banco." & vbLf
                    End If
                    If txtNumCheque.Text.Trim() = "" Then
                        mensaje &= "    *Se requiere del numero del cheque." & vbLf
                    End If
                ElseIf rbTrans.Checked Then
                    If cmbCuenta.SelectedIndex = -1 Or cmbCuenta.SelectedValue Is Nothing Then
                        mensaje &= "    *Se requiere seleccionar una cuenta." & vbLf
                    End If
                    If cmbBancos.SelectedIndex = -1 Or cmbBancos.SelectedValue Is Nothing Then
                        mensaje &= "    *Se requiere seleccionar un banco." & vbLf
                    End If
                    If txtReferencia.Text.Trim() = "" Then
                        mensaje &= "    *Se requiere del numero de la referencia." & vbLf
                    End If

                    If cmbBancosR.SelectedIndex = -1 Or cmbBancosR.SelectedValue Is Nothing Then
                        mensaje &= "    *Se requiere seleccionar el banco del receptor." & vbLf
                    End If
                    If txtCuentaRecep.Text.Trim() = "" Then
                        mensaje &= "    *Se requiere seleccionar la cuenta del receptor." & vbLf
                    End If
                Else

                End If
            Else
                mensaje &= "    *Es necesario llenar los campos de la forma de pago." & vbLf
            End If
        End If

        If list.Count = 0 Then
            mensaje &= "    *Se requiere seleccionar al menos una " & IIf(rbFactura.Checked And chkFacturada.Checked And rbSinPagar.Checked, "factura", "recepcion") & "." & vbLf
        End If

        If chkFacturada.Checked And rbPagadas.Checked Then
            mensaje &= "    *Lista facturas pagadas es de solo lectura. " & "." & vbLf
        End If





        'If rbCheque.Checked Then
        '    If cmbBancos.SelectedIndex = -1 Then
        '        mensaje &= "    *Seleccione un banco." & vbLf
        '        validado = False
        '    End If

        '    If cmbCuenta.SelectedIndex = -1 Then
        '        mensaje &= "    *Seleccione un cuenta." & vbLf
        '        validado = False
        '    End If

        '    If txtNumCheque.Text.Trim() = "" Then
        '        mensaje &= "    *El campo de No. de Cheque es requerido." & vbLf
        '        validado = False
        '    End If

        'ElseIf rbTrans.Checked Then
        '    If cmbBancos.SelectedIndex = -1 Then
        '        mensaje &= "    *Seleccione un banco." & vbLf
        '        validado = False
        '    End If

        '    If cmbCuenta.SelectedIndex = -1 Then
        '        mensaje &= "    *Seleccione un cuenta." & vbLf
        '        validado = False
        '    End If

        '    If txtReferencia.Text.Trim() = "" Then
        '        mensaje &= "    *El campo de Referencia es requerido." & vbLf
        '        validado = False
        '    End If

        '    If cmbBancosR.SelectedIndex = -1 Then
        '        mensaje &= "    *Seleccione un banco receptor." & vbLf
        '        validado = False
        '    End If

        '    If txtCuentaRecep.Text.Trim = "" Then
        '        mensaje &= "    *El campo No. Cuenta del receptor es requerido." & vbLf
        '        validado = False
        '    End If
        'End If

        If mensaje Is Nothing Then
            If rbEfect.Checked Then
                Dim result As Integer = MessageBox.Show("¿Deseas retirar de caja?", "AVISO", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    RetiroCaja = False
                ElseIf result = DialogResult.Yes Then
                    RetiroCaja = True
                End If
            End If
        Else
            mensaje = "Antes de realizar el pago verifique lo siguiente: " & vbLf & vbLf & mensaje
            MsgBox(mensaje, MsgBoxStyle.Exclamation, "AVISO")
        End If



        Return mensaje
    End Function

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        ReiniciarTodo()
        bandera = False
        llenarCuentas()
        bandera = True
        EstaBuscando = False
        'Escritura()
        'cheque = New ClasesNegocio.ChequeClass
        'Proveedor = New CN.ProveedorClass
        'Beneficiarios.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        'Me.cmbBeneficiario.SelectedIndex = -1
        'Me.cmbBeneficiario.Text = "Seleccione un Beneficiario..."
        'Bancos.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        'Me.cmbBanco.SelectedIndex = -1
        'Me.cmbBanco.Text = "Seleccione un Banco..."
        'Me.cmbBeneficiario.Enabled = False
        GBPrincipal.Enabled = True
        DtpFechaFac.Value = Now
        chkFormaPago.Checked = False
        gbFormaPago.Enabled = False
        GroupBox2.Enabled = True
        cmbProveedor.Focus()
    End Sub

    Public Sub ReiniciarTodo()
        limpiar()
        limpiarTotales()
        limpiarTotalesFact()
        cmbProveedor.SelectedIndex = -1
        cmbProveedor.Text = "Seleccione un proveedor..."
        rbFactura.Checked = True
        txtFactura.Text = ""
        MtxtUUID.Text = ""
        DtpFechaFac.Value = Now
        txtNumRemision.Text = ""
        dgvFacturas.DataSource = Nothing
        dgvRecepComp.DataSource = Nothing
        dgvRecepComp.Rows.Clear()
        rbCheque.Checked = True
        cmbBancos.SelectedIndex = -1
        cmbBancos.Text = "Seleccione un banco..."
        cmbCuenta.SelectedIndex = -1
        cmbCuenta.Text = "Seleccione una cuenta..."
        txtNumCheque.Text = ""
        txtReferencia.Text = ""
        cmbBancosR.SelectedIndex = -1
        cmbBancosR.Text = "Seleccione un banco receptor..."
        txtCuentaRecep.Text = ""
        dt.Clear()
        list.Clear()
        lblTotalConcepto.Text = "0.00"
        chkFacturada.Checked = False
        gbFacturadas.Enabled = False
        rbSinPagar.Checked = True
        listFacturas.Clear()
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        'Limpiar()
        'Escritura()
        'cheque = New ClasesNegocio.ChequeClass
        'Proveedor = New CN.ProveedorClass
        'Beneficiarios.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        'Me.cmbBeneficiario.SelectedIndex = -1
        'Me.cmbBeneficiario.Text = "Seleccione un Beneficiario..."
        'Bancos.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        'Me.cmbBanco.SelectedIndex = -1
        'Me.cmbBanco.Text = "Seleccione un Banco..."
        'Me.cmbBeneficiario.Enabled = False
        GBPrincipal.Enabled = False
        ReiniciarTodo()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        'GBPrincipal.Enabled = True
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        dgvRecepComp.AutoGenerateColumns = False
        Dim busqueda As New ClasesComunes.frmBuscarFactRecep
        busqueda.StartPosition = FormStartPosition.CenterScreen
        If busqueda.ShowDialog() = Windows.Forms.DialogResult.OK Then
            dgvRecepComp.Rows.Clear()
            EstaBuscando = True
            If busqueda.Tipo.Equals("F") Then
                Dim fact As New CN.FacturasCabCXPClass(Controlador.Empresa.CodEmpndx, busqueda.Proveedor, busqueda.Factura)
                Dim prov As New CN.ProveedorClass(busqueda.Proveedor)
                bandera = False
                cmbProveedor.SelectedValue = busqueda.Proveedor
                bandera = True
                txtFactura.Text = fact.NoFactura
                MtxtUUID.Text = fact.UUID
                DtpFechaFac.Value = fact.FechaFactura
                Dim recepciones As New CC.RecepcionOrdenCompraCollection
                For Each row As CN.FacturasDetalleCXPRecepcionesClass In fact.DetalleRecepciones
                    ' recepciones.Add(row.RecepcionOC.ObtenerEntidad)
                    dgvRecepComp.Rows.Add(False, row.IdRecepOC, IIf(row.NoRemision = "", row.FolioRecepcion, row.NoRemision), row.NumFactura, CDate(row.FechaRecepcion), row.SubTotal, row.IVA, row.IEPS, row.Total, Nothing, (IIf(row.Pagada = True, "PAGADA", "POR PAGAR")))
                Next
                'dgvRecepComp.DataSource = recepciones
                clmNoFactura.Visible = True
                dgvRecepComp.Columns(1).DataPropertyName = "IdRecepcionOrdenCompra"
                dgvRecepComp.Columns(2).DataPropertyName = "FechaRecepcion"
                dgvRecepComp.Columns(3).DataPropertyName = "SubTotal"
                dgvRecepComp.Columns(4).DataPropertyName = "Iva"
                dgvRecepComp.Columns(5).DataPropertyName = "Ieps"
                dgvRecepComp.Columns(6).DataPropertyName = "Total"


                For Each row As DataGridViewRow In dgvRecepComp.Rows
                    If row.Cells(clmEstatus.Index).Value.Equals("PAGADA") Then
                        row.ReadOnly = True
                    End If
                Next
                lblTotalDocTexto.Text = "Total Factura:"
                lblTotalConcepto.Text = fact.Total.ToString("C2")
                If fact.Estatus = EstatusFacturasEnum.PAGADA Then
                    chkFormaPago.Checked = True
                    GBPrincipal.Enabled = False
                    Dim Pago As New CN.PagosProveedoresColeccionClass
                    Pago.Obtener(fact.IdProveedor, fact.NoFactura, Controlador.Empresa.CodEmpndx)
                    cmbCuenta.SelectedValue = Pago(0).CuentaBancaria.Codigo


                    Dim chetran As New CN.ChequeCollectionClass()

                    Dim filtro As New OC.PredicateExpression
                    filtro.Add(HC.ChequeFields.Folio = Pago(0).Cheque And HC.ChequeFields.CuentaId = Pago(0).CuentaBancaria.Codigo)
                    chetran.Obtener(filtro)
                    If chetran.Count > 0 Then
                        If chetran(0).Medio = BancosMovimientosMedio.CHEQUE Then
                            txtNumCheque.Text = Pago(0).Cheque
                            rbCheque.Checked = True
                        Else
                            rbTrans.Checked = True
                            cmbBancosR.SelectedValue = chetran(0).CodBancoDestino.ToString("000")
                            txtCuentaRecep.Text = chetran(0).CuentaDestinoReceptor
                            txtNumCheque.Text = ""
                            txtReferencia.Text = chetran(0).Referencia
                        End If
                    Else
                        rbEfect.Checked = True
                    End If




                Else

                    GBPrincipal.Enabled = True
                    chkFormaPago.Checked = False
                    gbFormaPago.Enabled = False
                End If
            Else
                If busqueda.Tipo = "NR" Then
                    clmNoFactura.Visible = False
                    Dim recepciones As New CN.RecepcionOrdenCompraCollectionClass
                    Dim filtro As New OC.PredicateExpression
                    filtro.Add(HC.RecepcionOrdenCompraFields.IdProveedor = busqueda.Proveedor And HC.RecepcionOrdenCompraFields.NoRemision = busqueda.NotaRemision)
                    recepciones.Obtener(filtro)
                    Dim totalRemsion As Decimal = 0
                    For Each row As CN.RecepcionOrdenCompraClass In recepciones
                        ' recepciones.Add(row.RecepcionOC.ObtenerEntidad)
                        DtpFechaFac.Value = row.FechaCaptura
                        totalRemsion += row.Total
                        dgvRecepComp.Rows.Add(False, row.IdRecepcionOrdenCompra, IIf(row.NoRemision = "", row.FolioRecepcionOrdenCompra, row.NoRemision), row.NumFactura, CDate(row.FechaRecepcion), row.SubTotal, row.IVA, row.Ieps, row.Total, Nothing, (IIf(row.Pagada = True, "PAGADA", "POR PAGAR")))
                    Next

                    bandera = False
                    cmbProveedor.SelectedValue = busqueda.Proveedor
                    rbNotaRem.Checked = True
                    bandera = True

                    For Each row As DataGridViewRow In dgvRecepComp.Rows
                        row.Cells(0).Value = True
                    Next
                    lblTotalDocTexto.Text = "Total remisión:"
                    lblTotalConcepto.Text = totalRemsion.ToString("C2")

                    txtNumRemision.Text = busqueda.NotaRemision
                    Dim Pago As New CN.PagosProveedoresColeccionClass
                    Pago.Obtener(busqueda.Proveedor, busqueda.NotaRemision, Controlador.Empresa.CodEmpndx, "")
                    If Pago.Count > 0 Then
                        chkFormaPago.Checked = True
                        cmbCuenta.SelectedValue = Pago(0).CuentaBancaria.Codigo
                        txtNumCheque.Text = Pago(0).Cheque
                        Dim chetran As New CN.ChequeCollectionClass()

                        filtro = New OC.PredicateExpression
                        filtro.Add(HC.ChequeFields.Folio = Pago(0).Cheque And HC.ChequeFields.CuentaId = Pago(0).CuentaBancaria.Codigo)
                        chetran.Obtener(filtro)
                        If chetran.Count > 0 Then
                            If chetran(0).Medio = BancosMovimientosMedio.CHEQUE Then
                                rbCheque.Checked = True
                            Else
                                rbTrans.Checked = True
                                cmbBancosR.SelectedValue = chetran(0).CodBancoDestino.ToString("000")
                                txtCuentaRecep.Text = chetran(0).CuentaDestinoReceptor
                                txtReferencia.Text = chetran(0).Referencia
                            End If
                        Else
                            rbEfect.Checked = True
                        End If
                    End If
                Else
                    clmNoFactura.Visible = False
                    Dim recepciones As New CN.RecepcionOrdenCompraCollectionClass
                    Dim filtro As New OC.PredicateExpression
                    filtro.Add(HC.RecepcionOrdenCompraFields.IdProveedor = busqueda.Proveedor And HC.RecepcionOrdenCompraFields.IdRecepcionOrdenCompra = busqueda.Recepcion)
                    recepciones.Obtener(filtro)
                    For Each row As CN.RecepcionOrdenCompraClass In recepciones
                        ' recepciones.Add(row.RecepcionOC.ObtenerEntidad)
                        ' dgvRecepComp.Rows.Add(False, row.IdRecepcionOrdenCompra, CDate(row.FechaRecepcion), IIf(row.NoRemision = "", row.FolioRecepcionOrdenCompra, row.NoRemision), row.SubTotal, row.IVA, row.Ieps, row.Total, Nothing, (IIf(row.Pagada = True, "PAGADA", "POR PAGAR")))
                        dgvRecepComp.Rows.Add(False, row.IdRecepcionOrdenCompra, IIf(row.NoRemision = "", row.FolioRecepcionOrdenCompra, row.NoRemision), row.NumFactura, CDate(row.FechaRecepcion), row.SubTotal, row.IVA, row.Ieps, row.Total, Nothing, (IIf(row.Pagada = True, "PAGADA", "POR PAGAR")))

                    Next
                    Application.DoEvents()


                    bandera = False
                    cmbProveedor.SelectedValue = busqueda.Proveedor
                    rbSinDocto.Checked = True
                    bandera = True

                    For Each row As DataGridViewRow In dgvRecepComp.Rows
                        row.Cells(0).Value = True
                    Next
                    '  rbNotaRem.Checked = True
                    'txtNumRemision.Text = busqueda.Recepcion
                    Dim Pago As New CN.PagosProveedoresColeccionClass
                    Pago.Obtener(busqueda.Proveedor, CInt(busqueda.Recepcion), Controlador.Empresa.CodEmpndx, "")
                    If Pago.Count > 0 Then
                        chkFormaPago.Checked = True
                        cmbCuenta.SelectedValue = Pago(0).CuentaBancaria.Codigo
                        txtNumCheque.Text = Pago(0).Cheque
                        Dim chetran As New CN.ChequeCollectionClass()

                        filtro = New OC.PredicateExpression
                        filtro.Add(HC.ChequeFields.Folio = Pago(0).Cheque And HC.ChequeFields.CuentaId = Pago(0).CuentaBancaria.Codigo)
                        chetran.Obtener(filtro)
                        If chetran.Count > 0 Then
                            If chetran(0).Medio = BancosMovimientosMedio.CHEQUE Then
                                rbCheque.Checked = True
                            Else
                                rbTrans.Checked = True
                                cmbBancosR.SelectedValue = chetran(0).CodBancoDestino.ToString("000")
                                txtCuentaRecep.Text = chetran(0).CuentaDestinoReceptor
                                txtReferencia.Text = chetran(0).Referencia
                            End If
                        Else
                            rbEfect.Checked = True
                        End If
                    End If


                End If
                GBPrincipal.Enabled = True
                GroupBox2.Enabled = False
                dgvRecepComp.Enabled = True
                gbFormaPago.Enabled = False
                For Each row As DataGridViewRow In dgvRecepComp.Rows
                    row.Cells(Pagar.Index).ReadOnly = True
                    row.Cells(clmDetalle.Index).ReadOnly = False
                Next
                ''parte busqueda de notas de repecion y recepciones en si



            End If

            'GBPrincipal.Enabled = True

            'mtb_ClickEditar(sender, e, False)
        Else
            ' MessageBox.Show("CANCELO REGRESO CORRECTO")
            Cancelar = True
        End If


        'Dim fact As New CN.FacturasCabCXPClass(Controlador.Empresa.CodEmpndx, CType(cmbProveedor.SelectedValue, CN.ProveedorClass).Codigo, txtFactura.Text.Trim)
        'MtxtUUID.Text = fact.UUID
        'DtpFechaFac.Value = fact.FechaFactura
        'Dim recepciones As New CC.RecepcionOrdenCompraCollection
        'For Each row As CN.FacturasDetalleCXPRecepcionesClass In fact.DetalleRecepciones
        '    recepciones.Add(row.RecepcionOC.ObtenerEntidad)
        'Next
        'dgvRecepComp.DataSource = recepciones

        'dgvRecepComp.Columns(1).DataPropertyName = "IdRecepcionOrdenCompra"
        'dgvRecepComp.Columns(2).DataPropertyName = "FechaRecepcion"
        'dgvRecepComp.Columns(3).DataPropertyName = "SubTotal"
        'dgvRecepComp.Columns(4).DataPropertyName = "Iva"
        'dgvRecepComp.Columns(5).DataPropertyName = "Ieps"
        'dgvRecepComp.Columns(6).DataPropertyName = "Total"


        'For Each row As DataGridViewRow In dgvRecepComp.Rows
        '    row.Cells(0).Value = True
        'Next
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Facturas As String = ""
        Dim TotalFacturas As Decimal = 0
        Dim procesoCorrecto As Boolean = False
        'Dim Proveedor As New CN.ProveedorClass()
        Dim TodasRecepciones As New ArrayList()
        Dim Tipo As String = ""
        Dim Recepciones As String = ""

        If IsNothing(ValidarBarra()) Then
            Dim Tran As New Integralab.ORM.HelperClasses.Transaction(IsolationLevel.ReadCommitted, "PagoRecepCompras")
            Dim Prov As New ProveedorClass
            Prov.Obtener(cmbProveedor.SelectedValue)
            NombreProveedor = Prov.RazonSocial.ToString.ToUpper
            ' Dim reg As RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\INTEGRALAB\", True)
            Try
                If rbSinDocto.Checked Or rbNotaRem.Checked Then
                    Dim recepcionCompra As New RecepcionOrdenCompraClass()
                    If rbNotaRem.Checked Then
                        For i As Integer = 0 To dgvRecepComp.Rows.Count - 1
                            If dgvRecepComp.Rows(i).Cells(0).Value = True And dgvRecepComp.Rows(i).Cells(0).Value <> Nothing Then
                                Tipo = "SD"
                                recepcionCompra = New RecepcionOrdenCompraClass()
                                recepcionCompra.Obtener(dgvRecepComp.Rows(i).Cells(1).Value)
                                If list.Count - 1 = i Then
                                    Recepciones = Recepciones & recepcionCompra.IdRecepcionOrdenCompra.ToString
                                Else
                                    Recepciones = Recepciones & recepcionCompra.IdRecepcionOrdenCompra.ToString & ", "
                                End If

                                'recepcionCompra.IdRecepcionOrdenCompra
                                Dim folio As String = ""

                                folio = txtNumRemision.Text.Trim()
                                recepcionCompra.NoRemision = folio
                                recepcionCompra.FechaCaptura = DtpFechaFac.Value
                                'recepcionCompra.Pagada = True
                                recepcionCompra.NumFactura = folio
                                If chkFormaPago.Checked Then
                                    recepcionCompra.Pagada = True
                                End If
                                If Not recepcionCompra.Guardar(Tran) Then
                                    Tran.Rollback()
                                    procesoCorrecto = False
                                    MsgBox("Error en actualizar recepciones a pagado.", MsgBoxStyle.Critical, "ERROR")
                                    Return
                                End If
                            End If
                        Next
                        'guarda pago a proveedor
                        If chkFormaPago.Checked Then
                            ''marcar recepcion pagada
                            'For i As Integer = 0 To dgvRecepComp.Rows.Count - 1
                            '    If dgvRecepComp.Rows(i).Cells(0).Value = True And dgvRecepComp.Rows(i).Cells(0).Value <> Nothing Then
                            '        recepcionCompra = New RecepcionOrdenCompraClass()
                            '        recepcionCompra.Obtener(dgvRecepComp.Rows(i).Cells(1).Value)
                            '        recepcionCompra.Pagada = True
                            '        If Not recepcionCompra.Guardar(Tran) Then
                            '            Tran.Rollback()
                            '            procesoCorrecto = False
                            '            MsgBox("Error actualizar pagada recepcion.", MsgBoxStyle.Critical, "ERROR")
                            '            Return
                            '        End If
                            '    End If
                            'Next

                            ''PAGO-------------------------------
                            Dim Pago As New CN.PagosProveedoresClass
                            Pago.ObtenerEntidad.EmpresaId = Controlador.Sesion.Empndx
                            Pago.Proveedor = Prov
                            Pago.FechaPago = Now
                            Dim Cta As CN.CuentaClass
                            If rbCheque.Checked Then
                                Pago.Cheque = txtNumCheque.Text.Trim()
                                Cta = New CuentaClass(CInt(cmbCuenta.SelectedValue))
                                Pago.CuentaBancaria = Cta

                            ElseIf rbTrans.Checked Then
                                Pago.Cheque = txtReferencia.Text.Trim()
                                Pago.Referencia = txtReferencia.Text.Trim()
                                Cta = New CuentaClass(CInt(cmbCuenta.SelectedValue))
                                Pago.CuentaBancaria = Cta
                            Else
                                Pago.Cheque = ""
                            End If
                            'Pago.Cheque = ""
                            Pago.IdPoliza = 0
                            Pago.Estatus = ClasesNegocio.EstatusPagosProveedoresEnum.VIGENTE
                            Pago.NoFactura = txtNumRemision.Text.Trim()
                            If rbNotaRem.Checked Then
                                Pago.NoRemision = txtNumRemision.Text.Trim()
                            End If

                            Pago.Importe = Convert.ToDecimal(lblImporte.Text.Replace("$", ""))
                            Pago.IdUsuarioAlta = Controlador.Sesion.Usrndx
                            Pago.IdConcepto = 0


                            If Pago.Guardar(Tran) Then
                                procesoCorrecto = True
                            Else
                                Tran.Rollback()
                                procesoCorrecto = False
                                MsgBox("Error en guardar pagos", MsgBoxStyle.Critical, "ERROR")
                                Return
                            End If
                        Else
                            'MsgBox("Se guardo nota de remision correctamente.", MsgBoxStyle.Critical, "ERROR")
                            procesoCorrecto = True
                        End If
                    Else
                        For i As Integer = 0 To dgvRecepComp.Rows.Count - 1
                            If dgvRecepComp.Rows(i).Cells(0).Value = True And dgvRecepComp.Rows(i).Cells(0).Value <> Nothing Then
                                Tipo = "SD"
                                recepcionCompra = New RecepcionOrdenCompraClass()
                                recepcionCompra.Obtener(dgvRecepComp.Rows(i).Cells(1).Value)
                                If list.Count - 1 = i Then
                                    Recepciones = Recepciones & recepcionCompra.IdRecepcionOrdenCompra.ToString
                                Else
                                    Recepciones = Recepciones & recepcionCompra.IdRecepcionOrdenCompra.ToString & ", "
                                End If

                                'recepcionCompra.IdRecepcionOrdenCompra
                                Dim folio As String = ""

                                folio = recepcionCompra.FolioRecepcionOrdenCompra.ToString()



                                'recepcionCompra.Pagada = True
                                recepcionCompra.NumFactura = folio
                                If recepcionCompra.Guardar(Tran) Then
                                    'guarda pago a proveedor
                                    If chkFormaPago.Checked Then
                                        recepcionCompra.Pagada = True
                                        If Not recepcionCompra.Guardar(Tran) Then
                                            Tran.Rollback()
                                            procesoCorrecto = False
                                            MsgBox("Error actualizar pagada recepcion.", MsgBoxStyle.Critical, "ERROR")
                                            Return
                                        End If
                                        Dim Pago As New CN.PagosProveedoresClass
                                        Pago.ObtenerEntidad.EmpresaId = Controlador.Sesion.Empndx
                                        Pago.Proveedor = Prov
                                        Pago.FechaPago = Now
                                        Dim Cta As CN.CuentaClass
                                        If rbCheque.Checked Then
                                            Pago.Cheque = txtNumCheque.Text.Trim()
                                            Cta = New CuentaClass(CInt(cmbCuenta.SelectedValue))
                                            Pago.CuentaBancaria = Cta

                                        ElseIf rbTrans.Checked Then
                                            Pago.Cheque = txtReferencia.Text.Trim()
                                            Pago.Referencia = txtReferencia.Text.Trim()
                                            Cta = New CuentaClass(CInt(cmbCuenta.SelectedValue))
                                            Pago.CuentaBancaria = Cta
                                        Else
                                            Pago.Cheque = ""
                                        End If
                                        'Pago.Cheque = ""
                                        Pago.IdPoliza = 0
                                        Pago.Estatus = ClasesNegocio.EstatusPagosProveedoresEnum.VIGENTE
                                        Pago.NoFactura = folio


                                        Pago.Importe = Convert.ToDecimal(dgvRecepComp.Rows(i).Cells(6).Value)
                                        Pago.IdUsuarioAlta = Controlador.Sesion.Usrndx
                                        Pago.IdConcepto = 0


                                        If Pago.Guardar(Tran) Then
                                            procesoCorrecto = True
                                        Else
                                            Tran.Rollback()
                                            procesoCorrecto = False
                                            MsgBox("Error en guardar pagos", MsgBoxStyle.Critical, "ERROR")
                                            Return
                                        End If
                                    End If
                                Else
                                    Tran.Rollback()
                                    procesoCorrecto = False
                                    MsgBox("Error en actualizar recepciones a pagado.", MsgBoxStyle.Critical, "ERROR")
                                    Return
                                End If
                            End If
                        Next
                    End If


                Else

                    If rbFactura.Checked Then
                        Dim Factura As CN.FacturasCabCXPClass
                        If chkFormaPago.Checked Then
                            If chkFacturada.Checked And rbSinPagar.Checked Then
                                Dim totalPagadas = 0, TotalNopagadas = 0
                                Facturas = ""
                                Dim i As Integer = 0
                                For Each row As String In listFacturas
                                    i += 1
                                    If i = listFacturas.Count Then
                                        Facturas += row
                                    Else
                                        Facturas += row & ","
                                    End If
                                Next
                                'Facturas = Facturas & dgvFacturas.Rows(i).Cells(0).Value.ToString
                                For Each row As String In listFacturas
                                    totalPagadas = 0
                                    Factura = New CN.FacturasCabCXPClass(Controlador.Empresa.CodEmpndx, cmbProveedor.SelectedValue, row)
                                    For Each renglon As CN.FacturasDetalleCXPRecepcionesClass In Factura.DetalleRecepciones
                                        If renglon.Pagada Then
                                            totalPagadas += renglon.Total
                                        End If
                                    Next
                                    For Each ren As DataGridViewRow In dgvRecepComp.Rows
                                        If ren.Cells(Pagar.Index).Value = True And ren.Cells(clmNoFactura.Index).Value.ToString().Equals(row) Then
                                            totalPagadas += CDec(ren.Cells(clmTotal.Index).Value)
                                            Dim recepcion As New CN.RecepcionOrdenCompraClass(CInt(ren.Cells(clmIdRecepCom.Index).Value))
                                            recepcion.Pagada = True
                                            If Not recepcion.Guardar(Tran) Then
                                                Tran.Rollback()
                                                'procesoCorrecto = False
                                                MsgBox("Error en guardar detalle de recepciones.", MsgBoxStyle.Critical, "ERROR")
                                                Return
                                            End If
                                        End If
                                    Next
                                    If totalPagadas = Factura.Total Then
                                        Factura.Estatus = EstatusFacturasEnum.PAGADA
                                        Factura.Saldo = 0
                                    Else
                                        Factura.Saldo = Factura.Total - totalPagadas
                                    End If
                                    If Factura.Guardar(Tran) Then
                                        ''Guarda el pago
                                        Dim folio As String = row
                                        Dim Pago As New CN.PagosProveedoresClass
                                        Pago.ObtenerEntidad.EmpresaId = Controlador.Sesion.Empndx
                                        Pago.Proveedor = Prov
                                        Pago.FechaPago = Now
                                        Dim cta As New CN.CuentaClass(CInt(cmbCuenta.SelectedValue))
                                        If rbCheque.Checked Then
                                            Pago.CuentaBancaria = cta
                                            Pago.Cheque = txtNumCheque.Text.Trim()
                                        ElseIf rbTrans.Checked Then
                                            Pago.CuentaBancaria = cta
                                            Pago.Cheque = txtReferencia.Text.Trim()
                                            Pago.Referencia = txtReferencia.Text.Trim()
                                        Else
                                            Pago.Cheque = ""
                                        End If
                                        'Pago.Cheque = ""
                                        Pago.IdPoliza = 0
                                        Pago.Estatus = ClasesNegocio.EstatusPagosProveedoresEnum.VIGENTE
                                        Pago.NoFactura = folio
                                        Pago.Importe = Convert.ToDecimal(lblImporte.Text.Replace("$", ""))
                                        Pago.IdUsuarioAlta = Controlador.Sesion.Usrndx
                                        Pago.IdConcepto = 0
                                        If Not Pago.Guardar(Tran) Then
                                            Tran.Rollback()
                                            ' procesoCorrecto = False
                                            MsgBox("Error en guardar pagos", MsgBoxStyle.Critical, "ERROR")
                                            Return
                                        End If

                                    Else
                                        Tran.Rollback()
                                        'procesoCorrecto = False
                                        MsgBox("Error en actualizar la factura.", MsgBoxStyle.Critical, "ERROR")
                                    End If
                                Next

                                ''CHEQUE TRAN O EFEC
                                If chkFormaPago.Checked Then
                                    If rbCheque.Checked Or rbTrans.Checked Then
                                        Dim idCta As Integer = cmbCuenta.SelectedValue
                                        Dim Cuenta As New CN.CuentaClass(idCta)
                                        'Dim Banco As New BancosClass(CInt(cmbBancos.SelectedValue))
                                        Dim Banco As New EC.ECtSatcatBancosEntity(CStr(cmbBancos.SelectedValue))
                                        Dim Cheque As New CN.ChequeClass()
                                        If rbCheque.Checked Then
                                            Cuenta.FolioActual = Convert.ToInt32(Me.txtNumCheque.Text.Trim()) + 1

                                            Cuenta.Guardar()
                                        End If

                                        'Cheque.Cuenta.FolioActual =
                                        Cheque.Cuenta = Cuenta
                                        Cheque.CodBanco = Banco.CveBco

                                        If rbCheque.Checked Then
                                            Cheque.Medio = BancosMovimientosMedio.CHEQUE
                                            Cheque.Folio = txtNumCheque.Text.Trim()
                                            Cheque.FechaEmision = Now
                                        Else
                                            Cheque.Medio = BancosMovimientosMedio.ELECTRONICO
                                            'Banco = New CN.BancosClass
                                            Banco = New EC.ECtSatcatBancosEntity(CStr(cmbBancosR.SelectedValue))
                                            Cheque.CodBancoDestino = Banco.CveBco
                                            Cheque.CuentaDestinoReceptor = txtCuentaRecep.Text.Trim()
                                            Cheque.Referencia = txtReferencia.Text.Trim()
                                            Cheque.Folio = Me.txtReferencia.Text.Trim()
                                        End If

                                        'Cheque.IdBeneficiario = 0
                                        Cheque.IdPoliza = 0
                                        'Cheque.Poliza.EmpresaId = Controlador.Sesion.Empndx
                                        Cheque.Origen = BancosMovimientosOrigen.PAGOPROVEEDORES
                                        Cheque.TipoMovimiento = BancosMovimientosTipo.RETIRO
                                        Cheque.FechaMovimiento = Now
                                        Cheque.FechaDocumento = DtpFechaFac.Value


                                        If rbFactura.Checked Then
                                            Cheque.Concepto = "PAGO A PROVEEDOR " & NombreProveedor & " la(s) Factura: " & Facturas
                                            'ElseIf rbNotaRem.Checked Then
                                            '    Cheque.Concepto = "PAGO A PROVEEDOR " & NombreProveedor & " la(s) Nota(s) de Remisión: " & txtNumRemision.Text.Trim
                                            'Else
                                            '    Cheque.Concepto = "PAGO A PROVEEDOR " & NombreProveedor & " la(s) Recepción(es) de Compra: " & Recepciones
                                        End If
                                        'Cheque.Concepto = "PAGO A PROVEEDOR " & cmbProveedor.Text & " FACTURA: " & Facturas
                                        Cheque.Emitido = True
                                        Cheque.Anticipo = False
                                        Cheque.Resguardo = Integra.Clases.SiNoEnum.NO
                                        Cheque.Importe = lblImporte.Text.Replace("$", "")
                                        'If rbSinDocto.Checked Then
                                        '    Cheque.Importe = lblImporte.Text.Replace("$", "")
                                        'Else
                                        '    Cheque.Importe = TotalFacturas
                                        'End If


                                        Cheque.TipoCambio = 1
                                        Cheque.Estatus = Integra.Clases.EstatusEnum.ACTIVO
                                        Cheque.Entregado = True
                                        If Cheque.Guardar(False) Then
                                            If rbCheque.Checked Then
                                                Tran.Commit()
                                                MsgBox("Se guardo cheque correctamente por el concepto de:" & vbLf & Cheque.Concepto, MsgBoxStyle.Information, "AVISO")
                                            Else
                                                Tran.Commit()
                                                MsgBox("Se guardo transferencia correctamente. " & vbLf & Cheque.Concepto, MsgBoxStyle.Information, "AVISO")
                                            End If

                                            'MsgBox("Se guardo cheque correctamente por el concepto de:" & vbLf & Cheque.Concepto, MsgBoxStyle.Information, "AVISO")
                                            'txtFactura.Text = ""
                                            'MtxtUUID.Text = ""
                                            'DtpFechaFac.Value = Now
                                            'txtNumRemision.Text = ""
                                            'txtCuentaRecep.Text = ""
                                            'txtReferencia.Text = ""
                                            'llenarGridRecepOrdenes()
                                            'cmbCuenta.SelectedIndex = -1
                                            'cmbCuenta.Text = "Seleccione o teclee una cuenta..."
                                            'cmbBancos.SelectedIndex = -1
                                            'cmbBancos.Text = "Seleccione un Banco..."
                                            'cmbBancosR.SelectedIndex = -1
                                            'cmbBancosR.Text = "Seleccione una Cuenta..."
                                            ''CargarCombos()
                                            'txtNumCheque.Text = ""
                                            'dgvFacturas.DataSource = Nothing
                                            'dgvFacturas.Refresh()
                                            'dt.Clear()
                                            'list.Clear()
                                            'limpiar()
                                            'limpiarTotales()
                                            ReiniciarTodo()
                                            GBPrincipal.Enabled = False
                                        End If
                                    ElseIf rbEfect.Checked Then

                                        If RetiroCaja Then
                                            Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
                                            Dim Concepto As New ConceptoCajaClass
                                            Dim ConfigPuntoVta As New CC.ConfigPuntoVtaCollection()
                                            Retiro = New RetiroDeCajaClass()
                                            ConfigPuntoVta.GetMulti(Nothing)

                                            Turno = Utilerias.ObtenerControlTurnoActual()


                                            'Dim Folio As New FoliosClass
                                            'Folio.Codigo = CodigodeFolios.PagoEfectivoRecepcionCompra
                                            'Folio.Año = Now.Year
                                            'Folio.Mes = Now.ToString("MM")

                                            'If Not Folio.Guardar(Trans) Then
                                            '    Trans.Rollback()
                                            '    'Cancelar = True
                                            'End If
                                            Retiro.CodUsuario = Controlador.Sesion.Usrndx
                                            Retiro.FechaHora = DateTime.Now
                                            If rbSinDocto.Checked Then
                                                Retiro.importe = TotalGlobal
                                            Else
                                                Retiro.importe = TotalFacturas
                                            End If

                                            'Retiro.Importe = Convert.ToDecimal(Replace(lblImporte.Text, "$", ""))
                                            Retiro.CodControlTurno = Turno.Id
                                            Retiro.IdConcepto = ConfigPuntoVta(0).ConceptoPagoFactura
                                            'If Tipo = "F" Then
                                            Retiro.Observaciones = NombreProveedor & " la(s) Factura(s): " & Facturas
                                            'ElseIf Tipo = "NR" Then
                                            '    Retiro.Observaciones = NombreProveedor & " la(s) Nota(s) de Remisión: " & Facturas
                                            'Else
                                            '    Retiro.Observaciones = NombreProveedor & " la(s) Recepción(es) de Compra: " & Recepciones
                                            'End If
                                            'Retiro.Observaciones = NombreProveedor & " Pago en efectivo con folio: " '& Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("0000")
                                            Concepto.Obtener(Retiro.IdConcepto)
                                            If Retiro.Guardar() Then
                                                Try
                                                    Tran.Commit()
                                                    Dim rep As New crRetiroTck
                                                    rep.SetParameterValue("IdRetiro", Retiro.Id)
                                                    rep.SetParameterValue("Sucursal", Turno.Sucursal.DescripcionCorta)
                                                    rep.SetParameterValue("IdControlTurno", Retiro.Id)
                                                    rep.SetParameterValue("Cajero", Controlador.Sesion.MiUsuario.Usrnomcom)
                                                    rep.SetParameterValue("FechaHora", Retiro.FechaHora)
                                                    rep.SetParameterValue("Importe", Retiro.Importe)
                                                    rep.SetParameterValue("Observaciones", UCase(Retiro.Observaciones))
                                                    rep.SetParameterValue("Concepto", UCase(Concepto.Concepto))
                                                    rep.SetParameterValue("Copia", "")
                                                    rep.PrintOptions.PrinterName = Utilerias.ObtenerNomImpresora.ToString
                                                    rep.PrintToPrinter(1, False, 0, 0)
                                                    rep.Dispose()
                                                Catch ex As Exception
                                                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                                                Finally

                                                    MsgBox("Pago se realizo correctamente de la(s) Factura(s): " & Facturas & ".", MsgBoxStyle.Information, "AVISO")
                                                    'Retiro.Observaciones = NombreProveedor & " la(s) Factura(s): " & Facturas

                                                    ReiniciarTodo()
                                                    GBPrincipal.Enabled = False
                                                    'Me.Close()
                                                End Try
                                            Else
                                                Tran.Rollback()
                                                procesoCorrecto = False
                                                MsgBox("Error al hacer el retiro.", MsgBoxStyle.Critical, "ERROR")

                                            End If
                                        Else

                                            MsgBox("Pago se realizo correctamente de la(s) Factura(s): " & Facturas & ".", MsgBoxStyle.Information, "AVISO")
                                            'Retiro.Observaciones = NombreProveedor & " la(s) Factura(s): " & Facturas

                                            Tran.Commit()
                                            ReiniciarTodo()
                                            GBPrincipal.Enabled = False
                                            'Me.Close()
                                        End If
                                    End If
                                Else
                                    If rbFactura.Checked Then
                                        MsgBox("Se guardo correctamente la factura: " & txtFactura.Text.Trim() & ".", MsgBoxStyle.Information, "AVISO")
                                    Else
                                        MsgBox("Se guardo correctamente de la Nota de Remisión: " & txtNumRemision.Text.Trim() & ".", MsgBoxStyle.Information, "AVISO")
                                    End If
                                    Tran.Commit()
                                    ReiniciarTodo()
                                    GBPrincipal.Enabled = False
                                End If

                                MessageBox.Show(listFacturas.Count.ToString())
                                Cancelar = True
                                Return
                            Else
                                ''SE HACE FACTURA
                                If EstaBuscando Then
                                    Factura = New CN.FacturasCabCXPClass(Controlador.Empresa.CodEmpndx, cmbProveedor.SelectedValue, txtFactura.Text.Trim())
                                Else
                                    Factura = New CN.FacturasCabCXPClass
                                End If

                                'If listNopagados.Count > 0 And listPagados.Count > 0 Then
                                '    Factura.Estatus = CN.EstatusFacturasEnum.ABONADA
                                'Else
                                '    Factura.Estatus = CN.EstatusFacturasEnum.VIGENTE
                                'End If
                                Dim totalPagadas = 0, TotalNopagadas = 0
                                If EstaBuscando Then
                                    For Each row As DataGridViewRow In dgvRecepComp.Rows
                                        If row.Cells(0).Value = True Or row.Cells(clmEstatus.Index).Value.Equals("PAGADA") Then

                                            totalPagadas += CDec(row.Cells(clmTotal.Index).Value)

                                            ' TotalNopagadas += CDec(row.Cells(clmTotal.Index).Value)

                                        End If
                                    Next
                                    If totalPagadas = CDec(lblTotalConcepto.Text.Replace("$", "")) Then
                                        Factura.Saldo = 0.0
                                        Factura.Estatus = CN.EstatusFacturasEnum.PAGADA
                                    Else
                                        Factura.Saldo = CDec(lblTotalConcepto.Text.Replace("$", "")) - totalPagadas
                                    End If
                                Else


                                    For Each row As DataGridViewRow In dgvRecepComp.Rows
                                        If row.Cells(0).Value = True Then
                                            If row.Cells(clmEstatus.Index).Value.Equals("PAGADA") Then
                                                totalPagadas += CDec(row.Cells(clmTotal.Index).Value)
                                            Else
                                                TotalNopagadas += CDec(row.Cells(clmTotal.Index).Value)
                                            End If
                                        End If
                                    Next
                                    If totalPagadas = CDec(lblImporte.Text.Replace("$", "")) Or TotalNopagadas = CDec(lblImporte.Text.Replace("$", "")) Then
                                        Factura.Saldo = 0.0
                                        Factura.Estatus = CN.EstatusFacturasEnum.PAGADA
                                    Else
                                        Factura.Saldo = CDec(lblImporte.Text.Replace("$", "")) - totalPagadas
                                    End If
                                End If





                                If EstaBuscando = False Then
                                    Factura.IdEmpresa = Controlador.Sesion.Empndx
                                    Factura.Proveedor = Prov
                                    Factura.NoFactura = txtFactura.Text.Trim()
                                    Factura.UUID = MtxtUUID.Text.Trim()
                                    Factura.FechaCaptura = Now
                                    Factura.Subtotal = Convert.ToDecimal(lblSubtotal.Text.Replace("$", ""))
                                    Factura.Total = Convert.ToDecimal(lblImporte.Text.Replace("$", ""))
                                    Factura.IdUsuarioAlta = Controlador.Sesion.Usrndx
                                    Factura.IdPoliza = 0
                                    Factura.FechaFactura = DtpFechaFac.Value.Date
                                    Factura.FechaVencimiento = DtpFechaFac.Value.Date
                                    Factura.Gastos = True
                                    Factura.Servicios = False
                                    Factura.Saldo = 0.0
                                    Factura.TasaIva = Controlador.ObtenerIVA()
                                    Factura.Iva = Convert.ToDecimal(lblIva.Text.Replace("$", ""))
                                    Factura.TasaISR = 0.0
                                    Factura.Ieps = Convert.ToDecimal(lblIeps.Text.Replace("$", ""))
                                    Factura.TasaRetIva = 0.0
                                    Factura.Contabilizada = "N"
                                    Factura.FechaContabilizacion = New DateTime(1900, 1, 1)
                                    Factura.Anticipo = 0.0
                                End If

                                If Factura.Guardar(Tran) Then
                                    Dim folio As String = txtFactura.Text.Trim()
                                    Dim Pago As New CN.PagosProveedoresClass
                                    Pago.ObtenerEntidad.EmpresaId = Controlador.Sesion.Empndx
                                    Pago.Proveedor = Prov
                                    Pago.FechaPago = Now
                                    Dim cta As New CN.CuentaClass(CInt(cmbCuenta.SelectedValue))

                                    If rbCheque.Checked Then
                                        Pago.CuentaBancaria = cta
                                        Pago.Cheque = txtNumCheque.Text.Trim()
                                    ElseIf rbTrans.Checked Then
                                        Pago.CuentaBancaria = cta
                                        Pago.Cheque = txtReferencia.Text.Trim()
                                        Pago.Referencia = txtReferencia.Text.Trim()
                                    Else
                                        Pago.Cheque = ""
                                    End If
                                    'Pago.Cheque = ""
                                    Pago.IdPoliza = 0
                                    Pago.Estatus = ClasesNegocio.EstatusPagosProveedoresEnum.VIGENTE
                                    Pago.NoFactura = folio
                                    Pago.Importe = Convert.ToDecimal(lblImporte.Text.Replace("$", ""))
                                    Pago.IdUsuarioAlta = Controlador.Sesion.Usrndx
                                    Pago.IdConcepto = 0

                                    If Pago.Guardar(Tran) Then
                                        'procesoCorrecto = True
                                        For i As Integer = 0 To dgvRecepComp.Rows.Count - 1
                                            If dgvRecepComp.Rows(i).Cells(0).Value = True And dgvRecepComp.Rows(i).Cells(0).Value <> Nothing Then

                                                Dim FactDetRecep As New CN.FacturasDetalleCXPRecepcionesClass(Controlador.Empresa.CodEmpndx, cmbProveedor.SelectedValue, txtFactura.Text.Trim(), CInt(dgvRecepComp.Rows(i).Cells(1).Value))
                                                FactDetRecep.IdProveedor = Prov.Codigo
                                                FactDetRecep.EmpresaID = Controlador.Sesion.Empndx
                                                FactDetRecep.NumFactura = txtFactura.Text.Trim
                                                FactDetRecep.IdRecepOC = CInt(dgvRecepComp.Rows(i).Cells(1).Value)
                                                If Not FactDetRecep.Guardar(Tran) Then
                                                    Tran.Rollback()
                                                    procesoCorrecto = False
                                                    MsgBox("Error en guardar detalle de recepciones.", MsgBoxStyle.Critical, "ERROR")
                                                    Return
                                                End If


                                                Dim recepcionCompra As New RecepcionOrdenCompraClass()
                                                recepcionCompra.Obtener(dgvRecepComp.Rows(i).Cells(1).Value)
                                                If list.Count - 1 = i Then
                                                    Recepciones = Recepciones & recepcionCompra.IdRecepcionOrdenCompra.ToString
                                                Else
                                                    Recepciones = Recepciones & recepcionCompra.IdRecepcionOrdenCompra.ToString & ", "
                                                End If

                                                ' Dim folio As String = txtFactura.Text.Trim()
                                                recepcionCompra.Pagada = True
                                                recepcionCompra.Facturada = True
                                                recepcionCompra.NumFactura = txtFactura.Text.Trim()
                                                If Not recepcionCompra.Guardar(Tran) Then
                                                    Tran.Rollback()
                                                    procesoCorrecto = False
                                                    MsgBox("Error en actualizar recepciones.", MsgBoxStyle.Critical, "ERROR")
                                                    Return
                                                    'Else
                                                    '    Tran.Commit()
                                                    '    MsgBox("Se guardo la factura correctamente.", MsgBoxStyle.Information, "AVISO")

                                                End If

                                                'If recepcionCompra.Guardar(Tran) Then
                                                '    'Dim pago As New frmPagoProveedor

                                                'Else
                                                '    Tran.Rollback()
                                                '    MsgBox("Error en actualizar recepciones a pagado.", MsgBoxStyle.Critical, "ERROR")
                                                '    Return
                                                'End If
                                            End If
                                        Next
                                    Else
                                        Tran.Rollback()
                                        procesoCorrecto = False
                                        MsgBox("Error en guardar pagos", MsgBoxStyle.Critical, "ERROR")
                                        Return
                                    End If

                                    'Tran.Commit()
                                    'MsgBox("Se guardo la factura correctamente.", MsgBoxStyle.Information, "AVISO")
                                Else
                                    Tran.Rollback()
                                    procesoCorrecto = False
                                    MsgBox("Error en guardar factura.", MsgBoxStyle.Critical, "ERROR")
                                End If
                            End If
                        Else

                            ''SE HACE FACTURA

                            Factura = New CN.FacturasCabCXPClass
                            Factura.IdEmpresa = Controlador.Sesion.Empndx
                            Factura.Proveedor = Prov
                            Factura.NoFactura = txtFactura.Text.Trim()
                            Factura.UUID = MtxtUUID.Text.Trim()
                            Factura.FechaCaptura = Now
                            Factura.Subtotal = Convert.ToDecimal(lblSubtotal.Text.Replace("$", ""))
                            Factura.Total = Convert.ToDecimal(lblImporte.Text.Replace("$", ""))

                            Dim totalPagadas = 0, TotalNopagadas = 0
                            If listNopagados.Count > 0 And listPagados.Count > 0 Then
                                Factura.Estatus = CN.EstatusFacturasEnum.ABONADA
                                For Each row As DataGridViewRow In dgvRecepComp.Rows
                                    If row.Cells(0).Value = True Then
                                        If row.Cells(clmEstatus.Index).Value.Equals("PAGADA") Then
                                            totalPagadas += CDec(row.Cells(clmTotal.Index).Value)
                                        Else
                                            TotalNopagadas += CDec(row.Cells(clmTotal.Index).Value)
                                        End If
                                    End If
                                Next
                            Else
                                Factura.Estatus = CN.EstatusFacturasEnum.VIGENTE
                                For Each row As DataGridViewRow In dgvRecepComp.Rows
                                    If row.Cells(0).Value = True Then

                                        totalPagadas += CDec(row.Cells(clmTotal.Index).Value)

                                    End If
                                Next
                            End If

                            'Factura.Estatus = CN.EstatusFacturasEnum.VIGENTE
                            Factura.IdUsuarioAlta = Controlador.Sesion.Usrndx
                            Factura.IdPoliza = 0
                            Factura.FechaFactura = DtpFechaFac.Value.Date
                            Factura.FechaVencimiento = DtpFechaFac.Value.Date
                            Factura.Gastos = True
                            Factura.Servicios = False
                            If totalPagadas = CDec(lblImporte.Text.Replace("$", "")) Then
                                Factura.Saldo = 0.0
                            Else
                                Factura.Saldo = CDec(lblImporte.Text.Replace("$", "")) - totalPagadas
                            End If


                            Factura.TasaIva = Controlador.ObtenerIVA()
                            Factura.Iva = Convert.ToDecimal(lblIva.Text.Replace("$", ""))
                            Factura.TasaISR = 0.0
                            Factura.Ieps = Convert.ToDecimal(lblIeps.Text.Replace("$", ""))
                            Factura.TasaRetIva = 0.0
                            Factura.Contabilizada = "N"
                            Factura.FechaContabilizacion = New DateTime(1900, 1, 1)
                            Factura.Anticipo = 0.0
                            If Factura.Guardar(Tran) Then
                                For i As Integer = 0 To dgvRecepComp.Rows.Count - 1
                                    If dgvRecepComp.Rows(i).Cells(0).Value = True And dgvRecepComp.Rows(i).Cells(0).Value <> Nothing Then


                                        Dim FactDetRecep As New CN.FacturasDetalleCXPRecepcionesClass(Controlador.Empresa.CodEmpndx, cmbProveedor.SelectedValue, txtFactura.Text.Trim(), CInt(dgvRecepComp.Rows(i).Cells(1).Value))
                                        FactDetRecep.IdProveedor = Prov.Codigo
                                        FactDetRecep.EmpresaID = Controlador.Sesion.Empndx
                                        FactDetRecep.NumFactura = txtFactura.Text.Trim
                                        FactDetRecep.IdRecepOC = CInt(dgvRecepComp.Rows(i).Cells(1).Value)
                                        If Not FactDetRecep.Guardar(Tran) Then
                                            procesoCorrecto = False
                                            Tran.Rollback()
                                            MsgBox("Error en guardar detalle de recepciones.", MsgBoxStyle.Critical, "ERROR")
                                            Return
                                        End If

                                        Dim recepcionCompra As New RecepcionOrdenCompraClass()
                                        recepcionCompra.Obtener(dgvRecepComp.Rows(i).Cells(1).Value)
                                        If list.Count - 1 = i Then
                                            Recepciones = Recepciones & recepcionCompra.IdRecepcionOrdenCompra.ToString
                                        Else
                                            Recepciones = Recepciones & recepcionCompra.IdRecepcionOrdenCompra.ToString & ", "
                                        End If

                                        ' Dim folio As String = txtFactura.Text.Trim()
                                        ' recepcionCompra.Pagada = True
                                        recepcionCompra.Facturada = True
                                        recepcionCompra.NumFactura = txtFactura.Text.Trim()
                                        If Not recepcionCompra.Guardar(Tran) Then
                                            procesoCorrecto = False
                                            Tran.Rollback()
                                            MsgBox("Error en actualizar recepciones.", MsgBoxStyle.Critical, "ERROR")
                                            Return
                                        End If

                                        'If recepcionCompra.Guardar(Tran) Then
                                        '    'Dim pago As New frmPagoProveedor

                                        'Else
                                        '    Tran.Rollback()
                                        '    MsgBox("Error en actualizar recepciones a pagado.", MsgBoxStyle.Critical, "ERROR")
                                        '    Return
                                        'End If
                                    End If
                                Next
                            Else
                                Tran.Rollback()
                                procesoCorrecto = False
                                MsgBox("Error al guardar la factura..", MsgBoxStyle.Critical, "ERROR")
                                Return
                            End If
                        End If


                        'Tran.Commit()
                        'MsgBox("Se guardo la factura correctamente.", MsgBoxStyle.Information, "AVISO")
                        procesoCorrecto = True

                        'For i As Integer = 0 To dgvRecepComp.Rows.Count - 1
                        '    If dgvRecepComp.Rows(i).Cells(0).Value = True And dgvRecepComp.Rows(i).Cells(0).Value <> Nothing Then
                        '        Tipo = "SD"
                        '        Dim recepcionCompra As New RecepcionOrdenCompraClass()
                        '        recepcionCompra.Obtener(dgvRecepComp.Rows(i).Cells(1).Value)
                        '        If list.Count - 1 = i Then
                        '            Recepciones = Recepciones & recepcionCompra.IdRecepcionOrdenCompra.ToString
                        '        Else
                        '            Recepciones = Recepciones & recepcionCompra.IdRecepcionOrdenCompra.ToString & ", "
                        '        End If

                        '        Dim folio As String = txtFactura.Text.Trim()

                        '        If chkFormaPago.Checked Then
                        '            recepcionCompra.Pagada = True
                        '        End If
                        '        recepcionCompra.NumFactura = folio
                        '        If Not recepcionCompra.Guardar(Tran) Then
                        '            Tran.Rollback()
                        '            MsgBox("Error en actualizar recepciones.", MsgBoxStyle.Critical, "ERROR")
                        '            Return
                        '        End If

                        '    End If
                        'Next

                        ' ''SE HACE FACTURA
                        'Factura = New CN.FacturasCabCXPClass

                        'Factura.IdEmpresa = Controlador.Sesion.Empndx
                        'Factura.Proveedor = Proveedor
                        'Factura.NoFactura = txtFactura.Text.Trim()
                        'Factura.UUID = MtxtUUID.Text.Trim()
                        'Factura.FechaCaptura = Now
                        'Factura.Subtotal = Convert.ToDecimal(lblSubtotal.Text.Replace("$", ""))
                        'Factura.Total = Convert.ToDecimal(lblImporte.Text.Replace("$", ""))
                        'If chkFormaPago.Checked Then
                        '    Factura.Estatus = CN.EstatusFacturasEnum.PAGADA
                        'End If
                        'Factura.IdUsuarioAlta = Controlador.Sesion.Usrndx
                        'Factura.IdPoliza = 0
                        'Factura.FechaFactura = DtpFechaFac.Value.Date
                        'Factura.FechaVencimiento = DtpFechaFac.Value.Date
                        'Factura.Gastos = True
                        'Factura.Servicios = False
                        'Factura.Saldo = 0.0
                        'Factura.TasaIva = Controlador.ObtenerIVA()
                        'Factura.Iva = Convert.ToDecimal(lblIva.Text.Replace("$", ""))
                        'Factura.TasaISR = 0.0
                        'Factura.Ieps = Convert.ToDecimal(lblIeps.Text.Replace("$", ""))
                        'Factura.TasaRetIva = 0.0
                        'Factura.Contabilizada = "N"
                        'Factura.FechaContabilizacion = New DateTime(1900, 1, 1)
                        'Factura.Anticipo = 0.0
                        'If Factura.Guardar(Tran) Then
                        '    ''SE HACE EL PAGO
                        '    If chkFormaPago.Checked Then
                        '        Dim folio As String = txtFactura.Text.Trim()


                        '        Dim Pago As New CN.PagosProveedoresClass
                        '        Pago.ObtenerEntidad.EmpresaId = Controlador.Sesion.Empndx
                        '        Pago.Proveedor = Proveedor
                        '        Pago.FechaPago = Now
                        '        If rbCheque.Checked Then
                        '            Pago.Cheque = txtNumCheque.Text.Trim()
                        '        ElseIf rbTrans.Checked Then
                        '            Pago.Cheque = txtReferencia.Text.Trim()
                        '            Pago.Referencia = txtReferencia.Text.Trim()
                        '        Else
                        '            Pago.Cheque = ""
                        '        End If
                        '        'Pago.Cheque = ""
                        '        Pago.IdPoliza = 0
                        '        Pago.Estatus = ClasesNegocio.EstatusPagosProveedoresEnum.VIGENTE
                        '        Pago.NoFactura = folio
                        '        Pago.Importe = Convert.ToDecimal(lblImporte.Text.Replace("$", ""))
                        '        Pago.IdUsuarioAlta = Controlador.Sesion.Usrndx
                        '        Pago.IdConcepto = 0

                        '        If Pago.Guardar(Tran) Then
                        '            procesoCorrecto = True
                        '        Else
                        '            Tran.Rollback()
                        '            MsgBox("Error en guardar pagos", MsgBoxStyle.Critical, "ERROR")
                        '            Return
                        '        End If
                        '    End If
                        'Else
                        '    Tran.Rollback()
                        '    MsgBox("Error al guardar la factura.", MsgBoxStyle.Critical, "ERROR")
                        '    Return
                        'End If





                    End If




                    '---------------------------------------------------------------------------

                    'For i As Integer = 0 To dgvFacturas.RowCount - 1

                    '    Dim ActualizoRecepOC As Boolean = False

                    '    If dgvFacturas.Rows(i).Cells(7).Value.ToString = "F" Then
                    '        Tipo = dgvFacturas.Rows(i).Cells(7).Value.ToString
                    '        Dim Factura As New CN.FacturasCabCXPClass

                    '        Factura.IdEmpresa = Controlador.Sesion.Empndx
                    '        Factura.Proveedor = Proveedor
                    '        Factura.NoFactura = dgvFacturas.Rows(i).Cells(0).Value.ToString
                    '        Factura.UUID = dgvFacturas.Rows(i).Cells(8).Value.ToString
                    '        Factura.FechaCaptura = Now
                    '        Factura.Subtotal = Convert.ToDecimal(dgvFacturas.Rows(i).Cells(4).Value)
                    '        Factura.Total = Convert.ToDecimal(dgvFacturas.Rows(i).Cells(3).Value)
                    '        Factura.Estatus = CN.EstatusFacturasEnum.PAGADA
                    '        Factura.IdUsuarioAlta = Controlador.Sesion.Usrndx
                    '        Factura.IdPoliza = 0
                    '        Factura.FechaFactura = dgvFacturas.Rows(i).Cells(1).Value
                    '        Factura.FechaVencimiento = dgvFacturas.Rows(i).Cells(1).Value
                    '        Factura.Gastos = True
                    '        Factura.Servicios = False
                    '        Factura.Saldo = 0.0
                    '        Factura.TasaIva = Controlador.ObtenerIVA()
                    '        Factura.Iva = Convert.ToDecimal(dgvFacturas.Rows(i).Cells(5).Value)
                    '        Factura.TasaISR = 0.0
                    '        Factura.Ieps = Convert.ToDecimal(dgvFacturas.Rows(i).Cells(6).Value)
                    '        Factura.TasaRetIva = 0.0
                    '        Factura.Contabilizada = "N"
                    '        Factura.FechaContabilizacion = New DateTime(1900, 1, 1)
                    '        Factura.Anticipo = 0.0
                    '        If Factura.Guardar(Tran) Then
                    '            ''Se obtiene el array de las recepciones que incluye la factura
                    '            Dim lista As Array = dt.Rows(i)(4)
                    '            For Each r As Integer In lista
                    '                RecepcionOrdenCompra = New CN.RecepcionOrdenCompraClass()
                    '                RecepcionOrdenCompra.Obtener(Convert.ToInt32(r))
                    '                TodasRecepciones.Add(r)

                    '                RecepcionOrdenCompra.NumFactura = dgvFacturas.Rows(i).Cells(0).Value.ToString
                    '                RecepcionOrdenCompra.Facturada = True
                    '                RecepcionOrdenCompra.Pagada = True


                    '                ''Se actualizan todas las recepciones de compra con el numero de factura, pagada y facturada
                    '                If RecepcionOrdenCompra.Guardar() Then
                    '                    ActualizoRecepOC = True
                    '                Else
                    '                    Tran.Rollback()
                    '                    ActualizoRecepOC = False
                    '                    MsgBox("Error al actualizar las ordenes de compra.", MsgBoxStyle.Critical, "ERROR")
                    '                    Return
                    '                End If


                    '            Next
                    '            ''Si se actualizaron las recepciones de compra se prosigue con el pago
                    '            If ActualizoRecepOC Then
                    '                Dim Pago As New CN.PagosProveedoresClass
                    '                Pago.ObtenerEntidad.EmpresaId = Controlador.Sesion.Empndx
                    '                Pago.Proveedor = Proveedor
                    '                Pago.FechaPago = Now

                    '                If rbCheque.Checked Then
                    '                    Pago.Cheque = txtNumCheque.Text.Trim()
                    '                ElseIf rbTrans.Checked Then
                    '                    Pago.Cheque = txtReferencia.Text.Trim()
                    '                    Pago.Referencia = txtReferencia.Text.Trim()
                    '                Else
                    '                    Pago.Cheque = ""
                    '                End If

                    '                Pago.IdPoliza = 0
                    '                Pago.Estatus = ClasesNegocio.EstatusPagosProveedoresEnum.VIGENTE
                    '                Pago.NoFactura = dgvFacturas.Rows(i).Cells(0).Value.ToString
                    '                Pago.Importe = Convert.ToDecimal(dgvFacturas.Rows(i).Cells(3).Value)
                    '                Pago.IdUsuarioAlta = Controlador.Sesion.Usrndx
                    '                Pago.IdConcepto = 0

                    '                If Pago.Guardar(Tran) Then
                    '                    TotalFacturas = TotalFacturas + Pago.Importe
                    '                    If i = dgvFacturas.RowCount - 1 Then
                    '                        Facturas = Facturas & dgvFacturas.Rows(i).Cells(0).Value.ToString
                    '                        procesoCorrecto = True
                    '                    Else
                    '                        Facturas = Facturas & dgvFacturas.Rows(i).Cells(0).Value.ToString & ", "
                    '                    End If
                    '                Else
                    '                    Tran.Rollback()
                    '                    MsgBox("Error al hacer el pago.", MsgBoxStyle.Critical, "ERROR")
                    '                    Return
                    '                End If

                    '            End If


                    '        Else
                    '            Tran.Rollback()
                    '            MsgBox("Error al generar la factura.", MsgBoxStyle.Critical, "ERROR")
                    '            Return
                    '        End If
                    '    ElseIf dgvFacturas.Rows(i).Cells(7).Value.ToString = "NR" Then
                    '        Tipo = dgvFacturas.Rows(i).Cells(7).Value.ToString
                    '        Dim lista As Array = dt.Rows(i)(4)
                    '        For Each r As Integer In lista
                    '            RecepcionOrdenCompra = New CN.RecepcionOrdenCompraClass()
                    '            RecepcionOrdenCompra.Obtener(Convert.ToInt32(r))
                    '            TodasRecepciones.Add(r)

                    '            RecepcionOrdenCompra.NumFactura = dgvFacturas.Rows(i).Cells(0).Value.ToString
                    '            RecepcionOrdenCompra.Pagada = True
                    '            RecepcionOrdenCompra.Facturada = False
                    '            RecepcionOrdenCompra.NoRemision = dgvFacturas.Rows(i).Cells(0).Value.ToString


                    '            ''Se actualizan todas las recepciones de compra con el numero de factura, pagada y facturada
                    '            If RecepcionOrdenCompra.Guardar(Tran) Then
                    '                ActualizoRecepOC = True
                    '            Else
                    '                Tran.Rollback()
                    '                ActualizoRecepOC = False
                    '                MsgBox("Error al actualizar las ordenes de compra.", MsgBoxStyle.Critical, "ERROR")
                    '                Return
                    '            End If


                    '        Next
                    '        ''Si se actualizaron las recepciones de compra se prosigue con el pago
                    '        If ActualizoRecepOC Then
                    '            Dim Pago As New CN.PagosProveedoresClass
                    '            Pago.ObtenerEntidad.EmpresaId = Controlador.Sesion.Empndx
                    '            Pago.Proveedor = Proveedor
                    '            Pago.FechaPago = Now
                    '            If rbCheque.Checked Then
                    '                Pago.Cheque = txtNumCheque.Text.Trim()
                    '            ElseIf rbTrans.Checked Then
                    '                Pago.Cheque = txtReferencia.Text.Trim()
                    '                Pago.Referencia = txtReferencia.Text.Trim()
                    '            Else
                    '                Pago.Cheque = ""
                    '            End If

                    '            Pago.IdPoliza = 0
                    '            Pago.Estatus = ClasesNegocio.EstatusPagosProveedoresEnum.VIGENTE
                    '            Pago.NoFactura = dgvFacturas.Rows(i).Cells(0).Value.ToString
                    '            Pago.Importe = Convert.ToDecimal(dgvFacturas.Rows(i).Cells(3).Value)
                    '            Pago.IdUsuarioAlta = Controlador.Sesion.Usrndx
                    '            Pago.IdConcepto = 0

                    '            If Pago.Guardar(Tran) Then
                    '                TotalFacturas = TotalFacturas + Pago.Importe
                    '                If i = dgvFacturas.RowCount - 1 Then
                    '                    Facturas = Facturas & dgvFacturas.Rows(i).Cells(0).Value.ToString
                    '                    procesoCorrecto = True
                    '                Else
                    '                    Facturas = Facturas & dgvFacturas.Rows(i).Cells(0).Value.ToString & ", "
                    '                End If
                    '            Else
                    '                Tran.Rollback()
                    '                MsgBox("Error al hacer el pago.", MsgBoxStyle.Critical, "ERROR")
                    '                Return
                    '            End If

                    '        End If

                    '    End If
                    'Next
                End If



            Catch ex As Exception
                MsgBox("Error en el proceso de guardado." & vbLf & ex.Message.ToString, MsgBoxStyle.Critical, "ERROR")
                Return
            Finally
                If procesoCorrecto Then
                    '  Tran.Commit()
                    If chkFormaPago.Checked Then
                        If rbCheque.Checked Or rbTrans.Checked Then
                            Dim idCta As Integer = cmbCuenta.SelectedValue
                            Dim Cuenta As New CN.CuentaClass(idCta)
                            'Dim Banco As New BancosClass(CInt(cmbBancos.SelectedValue))
                            Dim Banco As New EC.ECtSatcatBancosEntity(CStr(cmbBancos.SelectedValue))
                            Dim Cheque As New CN.ChequeClass()
                            If rbCheque.Checked Then
                                Cuenta.FolioActual = Convert.ToInt32(Me.txtNumCheque.Text.Trim()) + 1

                                Cuenta.Guardar()
                            End If

                            'Cheque.Cuenta.FolioActual =
                            Cheque.Cuenta = Cuenta
                            Cheque.CodBanco = Banco.CveBco

                            If rbCheque.Checked Then
                                Cheque.Medio = BancosMovimientosMedio.CHEQUE
                                Cheque.Folio = txtNumCheque.Text.Trim()
                                Cheque.FechaEmision = Now
                            Else
                                Cheque.Medio = BancosMovimientosMedio.ELECTRONICO
                                'Banco = New CN.BancosClass
                                Banco = New EC.ECtSatcatBancosEntity(CStr(cmbBancosR.SelectedValue))
                                Cheque.CodBancoDestino = Banco.CveBco
                                Cheque.CuentaDestinoReceptor = txtCuentaRecep.Text.Trim()
                                Cheque.Referencia = txtReferencia.Text.Trim()
                                Cheque.Folio = Me.txtReferencia.Text.Trim()
                            End If

                            'Cheque.IdBeneficiario = 0
                            Cheque.IdPoliza = 0
                            'Cheque.Poliza.EmpresaId = Controlador.Sesion.Empndx
                            Cheque.Origen = BancosMovimientosOrigen.PAGOPROVEEDORES
                            Cheque.TipoMovimiento = BancosMovimientosTipo.RETIRO
                            Cheque.FechaMovimiento = Now
                            Cheque.FechaDocumento = DtpFechaFac.Value


                            If rbFactura.Checked Then
                                Cheque.Concepto = "PAGO A PROVEEDOR " & NombreProveedor & " la(s) Factura: " & txtFactura.Text.Trim
                            ElseIf rbNotaRem.Checked Then
                                Cheque.Concepto = "PAGO A PROVEEDOR " & NombreProveedor & " la(s) Nota(s) de Remisión: " & txtNumRemision.Text.Trim
                            Else
                                Cheque.Concepto = "PAGO A PROVEEDOR " & NombreProveedor & " la(s) Recepción(es) de Compra: " & Recepciones
                            End If
                            'Cheque.Concepto = "PAGO A PROVEEDOR " & cmbProveedor.Text & " FACTURA: " & Facturas
                            Cheque.Emitido = True
                            Cheque.Anticipo = False
                            Cheque.Resguardo = Integra.Clases.SiNoEnum.NO
                            Cheque.Importe = lblImporte.Text.Replace("$", "")
                            'If rbSinDocto.Checked Then
                            '    Cheque.Importe = lblImporte.Text.Replace("$", "")
                            'Else
                            '    Cheque.Importe = TotalFacturas
                            'End If


                            Cheque.TipoCambio = 1
                            Cheque.Estatus = Integra.Clases.EstatusEnum.ACTIVO
                            Cheque.Entregado = True
                            If Cheque.Guardar(False) Then
                                If rbCheque.Checked Then
                                    Tran.Commit()
                                    MsgBox("Se guardo cheque correctamente por el concepto de:" & vbLf & Cheque.Concepto, MsgBoxStyle.Information, "AVISO")
                                Else
                                    Tran.Commit()
                                    MsgBox("Se guardo transferencia correctamente. " & vbLf & Cheque.Concepto, MsgBoxStyle.Information, "AVISO")
                                End If

                                'MsgBox("Se guardo cheque correctamente por el concepto de:" & vbLf & Cheque.Concepto, MsgBoxStyle.Information, "AVISO")
                                'txtFactura.Text = ""
                                'MtxtUUID.Text = ""
                                'DtpFechaFac.Value = Now
                                'txtNumRemision.Text = ""
                                'txtCuentaRecep.Text = ""
                                'txtReferencia.Text = ""
                                'llenarGridRecepOrdenes()
                                'cmbCuenta.SelectedIndex = -1
                                'cmbCuenta.Text = "Seleccione o teclee una cuenta..."
                                'cmbBancos.SelectedIndex = -1
                                'cmbBancos.Text = "Seleccione un Banco..."
                                'cmbBancosR.SelectedIndex = -1
                                'cmbBancosR.Text = "Seleccione una Cuenta..."
                                ''CargarCombos()
                                'txtNumCheque.Text = ""
                                'dgvFacturas.DataSource = Nothing
                                'dgvFacturas.Refresh()
                                'dt.Clear()
                                'list.Clear()
                                'limpiar()
                                'limpiarTotales()
                                ReiniciarTodo()
                                GBPrincipal.Enabled = False
                            End If
                        ElseIf rbEfect.Checked Then

                            If RetiroCaja Then
                                Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
                                Dim Concepto As New ConceptoCajaClass
                                Dim ConfigPuntoVta As New CC.ConfigPuntoVtaCollection()
                                Retiro = New RetiroDeCajaClass()
                                ConfigPuntoVta.GetMulti(Nothing)

                                Turno = Utilerias.ObtenerControlTurnoActual()


                                'Dim Folio As New FoliosClass
                                'Folio.Codigo = CodigodeFolios.PagoEfectivoRecepcionCompra
                                'Folio.Año = Now.Year
                                'Folio.Mes = Now.ToString("MM")

                                'If Not Folio.Guardar(Trans) Then
                                '    Trans.Rollback()
                                '    'Cancelar = True
                                'End If
                                Retiro.CodUsuario = Controlador.Sesion.Usrndx
                                Retiro.FechaHora = DateTime.Now
                                If rbSinDocto.Checked Then
                                    Retiro.importe = TotalGlobal
                                Else
                                    Retiro.importe = TotalFacturas
                                End If

                                'Retiro.Importe = Convert.ToDecimal(Replace(lblImporte.Text, "$", ""))
                                Retiro.CodControlTurno = Turno.Id
                                Retiro.IdConcepto = ConfigPuntoVta(0).ConceptoPagoFactura
                                If Tipo = "F" Then
                                    Retiro.Observaciones = NombreProveedor & " la(s) Factura(s): " & Facturas
                                ElseIf Tipo = "NR" Then
                                    Retiro.Observaciones = NombreProveedor & " la(s) Nota(s) de Remisión: " & Facturas
                                Else
                                    Retiro.Observaciones = NombreProveedor & " la(s) Recepción(es) de Compra: " & Recepciones
                                End If
                                'Retiro.Observaciones = NombreProveedor & " Pago en efectivo con folio: " '& Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("0000")
                                Concepto.Obtener(Retiro.IdConcepto)
                                If Retiro.Guardar() Then
                                    Try
                                        Tran.Commit()
                                        Dim rep As New crRetiroTck
                                        rep.SetParameterValue("IdRetiro", Retiro.Id)
                                        rep.SetParameterValue("Sucursal", Turno.Sucursal.DescripcionCorta)
                                        rep.SetParameterValue("IdControlTurno", Retiro.Id)
                                        rep.SetParameterValue("Cajero", Controlador.Sesion.MiUsuario.Usrnomcom)
                                        rep.SetParameterValue("FechaHora", Retiro.FechaHora)
                                        rep.SetParameterValue("Importe", Retiro.Importe)
                                        rep.SetParameterValue("Observaciones", UCase(Retiro.Observaciones))
                                        rep.SetParameterValue("Concepto", UCase(Concepto.Concepto))
                                        rep.SetParameterValue("Copia", "")
                                        rep.PrintOptions.PrinterName = Utilerias.ObtenerNomImpresora.ToString
                                        rep.PrintToPrinter(1, False, 0, 0)
                                        rep.Dispose()
                                    Catch ex As Exception
                                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                                    Finally
                                        If Tipo = "F" Then
                                            MsgBox("Pago se realizo correctamente de la(s) Factura(s): " & Facturas & ".", MsgBoxStyle.Information, "AVISO")
                                            'Retiro.Observaciones = NombreProveedor & " la(s) Factura(s): " & Facturas
                                        ElseIf Tipo = "NR" Then
                                            MsgBox("Pago se realizo correctamente de la(s) Nota(s) de Remisión: " & Facturas & ".", MsgBoxStyle.Information, "AVISO")
                                            ' Retiro.Observaciones = NombreProveedor & " la(s) Nota(s) de Remisión: " & Facturas
                                        Else
                                            MsgBox("Pago se realizo correctamente de la(s) Recepción(es) de Compra: " & Recepciones & ".", MsgBoxStyle.Information, "AVISO")
                                            'Retiro.Observaciones = NombreProveedor & " la(s) Recepción(es) de Compra: " & Recepciones
                                        End If
                                        ReiniciarTodo()
                                        GBPrincipal.Enabled = False
                                        'Me.Close()
                                    End Try
                                Else
                                    Tran.Rollback()
                                    procesoCorrecto = False
                                    MsgBox("Error al hacer el retiro.", MsgBoxStyle.Critical, "ERROR")

                                End If
                            Else
                                If Tipo = "F" Then
                                    MsgBox("Pago se realizo correctamente de la(s) Factura(s): " & Facturas & ".", MsgBoxStyle.Information, "AVISO")
                                    'Retiro.Observaciones = NombreProveedor & " la(s) Factura(s): " & Facturas
                                ElseIf Tipo = "NR" Then
                                    MsgBox("Pago se realizo correctamente de la(s) Nota(s) de Remisión: " & Facturas & ".", MsgBoxStyle.Information, "AVISO")
                                    ' Retiro.Observaciones = NombreProveedor & " la(s) Nota(s) de Remisión: " & Facturas
                                Else
                                    MsgBox("Pago se realizo correctamente de la(s) Recepción(es) de Compra: " & Recepciones & ".", MsgBoxStyle.Information, "AVISO")
                                    'Retiro.Observaciones = NombreProveedor & " la(s) Recepción(es) de Compra: " & Recepciones
                                End If
                                Tran.Commit()
                                ReiniciarTodo()
                                GBPrincipal.Enabled = False
                                'Me.Close()
                            End If
                        End If
                    Else
                        If rbFactura.Checked Then
                            MsgBox("Se guardo correctamente la factura: " & txtFactura.Text.Trim() & ".", MsgBoxStyle.Information, "AVISO")
                        Else
                            MsgBox("Se guardo correctamente de la Nota de Remisión: " & txtNumRemision.Text.Trim() & ".", MsgBoxStyle.Information, "AVISO")
                        End If
                        Tran.Commit()
                        ReiniciarTodo()
                        GBPrincipal.Enabled = False
                    End If
                End If
            End Try



        Else
            'mtb.sbCambiarEstadoBotones("Nuevo")
            'e.Button.
            'Return
            Cancelar = True
        End If

        '''-----------------------------------------------------------------------------------------------------
        'If Validar() Then
        '    Dim Factura As New CN.FacturasCabCXPClass
        '    Dim Proveedor As New CN.ProveedorClass()
        '    Proveedor.Obtener(IdProveedor)
        '    Factura.IdEmpresa = Controlador.Sesion.Empndx
        '    Factura.Proveedor = Proveedor
        '    Factura.NoFactura = txtFactura.Text
        '    Factura.FechaCaptura = Now
        '    Factura.Subtotal = Convert.ToDecimal(Replace(SubTot, "$", ""))
        '    Factura.Total = Convert.ToDecimal(Replace(lblImporte.Text, "$", ""))
        '    Factura.Estatus = CN.EstatusFacturasEnum.PAGADA
        '    Factura.IdUsuarioAlta = Controlador.Sesion.Usrndx
        '    Factura.IdPoliza = 0
        '    Factura.FechaFactura = DtpFechaFac.Value
        '    Factura.FechaVencimiento = DtpFechaFac.Value
        '    Factura.Gastos = True
        '    Factura.Servicios = False
        '    Factura.Saldo = 0.0
        '    Factura.TasaIva = Controlador.ObtenerIVA()
        '    Factura.Iva = Convert.ToDecimal(Replace(IVAP, "$", ""))
        '    Factura.TasaISR = 0.0
        '    Factura.Ieps = Convert.ToDecimal(Replace(IepsP, "$", ""))
        '    Factura.TasaRetIva = 0.0
        '    Factura.Contabilizada = "N"
        '    Factura.FechaContabilizacion = New DateTime(1900, 1, 1)
        '    Factura.Anticipo = 0.0

        '    If Factura.Guardar() Then

        '        For i As Integer = 0 To list.Count - 1
        '            RecepcionOrdenCompra = New CN.RecepcionOrdenCompraClass()
        '            RecepcionOrdenCompra.Obtener(Convert.ToInt32(list(i)))
        '            RecepcionOrdenCompra.NumFactura = txtFactura.Text
        '            RecepcionOrdenCompra.Facturada = True
        '            RecepcionOrdenCompra.Pagada = True
        '        Next


        '        If RecepcionOrdenCompra.Guardar() Then
        '            ''SE REGISTRA EL RETIRO POR CONCEPTO DE PAGO PROVEEDOR
        '            Dim Concepto As New ConceptoCajaClass
        '            Dim ConfigPuntoVta As New CC.ConfigPuntoVtaCollection()
        '            ConfigPuntoVta.GetMulti(Nothing)
        '            Dim idCta As Integer = cmbCuenta.SelectedValue
        '            Dim Cuenta As New CN.CuentaClass(idCta)
        '            Dim Banco As CN.BancosClass = cmbBancos.SelectedValue
        '            Dim Cheque As New CN.ChequeClass()
        '            Cuenta.FolioActual = Convert.ToInt32(Me.txtNumCheque.Text.Trim()) - 1
        '            Cuenta.Guardar()
        '            'Cheque.Folio = Me.txtNumCheque.Text.Trim()
        '            'Cheque.Cuenta.FolioActual =
        '            Cheque.Cuenta = Cuenta
        '            Cheque.Medio = BancosMovimientosMedio.CHEQUE
        '            Cheque.CodBanco = Banco.Codigo
        '            'Cheque.IdBeneficiario = 0
        '            Cheque.IdPoliza = 0
        '            'Cheque.Poliza.EmpresaId = Controlador.Sesion.Empndx
        '            Cheque.Origen = BancosMovimientosOrigen.PAGOPROVEEDORES
        '            Cheque.TipoMovimiento = BancosMovimientosTipo.RETIRO
        '            Cheque.FechaMovimiento = Now
        '            Cheque.FechaDocumento = DtpFechaFac.Value
        '            Cheque.Concepto = "PAGO A PROVEEDOR " & cmbProveedor.Text & " FACTURA(S): " & Factura.NoFactura
        '            Cheque.Emitido = True
        '            Cheque.Anticipo = False
        '            Cheque.Resguardo = Integra.Clases.SiNoEnum.NO
        '            Cheque.Importe = Convert.ToDecimal(Replace(lblImporte.Text, "$", ""))
        '            Cheque.TipoCambio = 1
        '            Cheque.Estatus = Integra.Clases.EstatusEnum.ACTIVO
        '            Cheque.Entregado = True

        '            'Cheque.CuentaDestino = 0


        '            'Cheque.poli
        '            'Turno = Utilerias.ObtenerControlTurnoActual()

        '            'Retiro.CodUsuario = Controlador.Sesion.Usrndx
        '            'Retiro.FechaHora = DateTime.Now
        '            'Retiro.Importe = Convert.ToDecimal(Replace(lblImporte.Text, "$", ""))
        '            'Retiro.CodControlTurno = Turno.Id
        '            'Retiro.IdConcepto = ConfigPuntoVta(0).ConceptoPagoFactura
        '            'Retiro.Observaciones = NombreProveedor & " No.Fact: " & txtFactura.Text
        '            'Concepto.Obtener(Retiro.IdConcepto)
        '            If Cheque.Guardar(False) Then
        '                Dim Pago As New CN.PagosProveedoresClass
        '                Pago.ObtenerEntidad.EmpresaId = Controlador.Sesion.Empndx
        '                Pago.Proveedor = Proveedor
        '                Pago.FechaPago = Now

        '                Pago.Cheque = txtNumCheque.Text.Trim()
        '                Pago.IdPoliza = 0
        '                Pago.Estatus = ClasesNegocio.EstatusPagosProveedoresEnum.VIGENTE
        '                Pago.NoFactura = txtFactura.Text
        '                Pago.Importe = Convert.ToDecimal(Replace(lblImporte.Text, "$", ""))
        '                Pago.IdUsuarioAlta = Controlador.Sesion.Usrndx
        '                Pago.IdConcepto = Retiro.IdConcepto
        '                If Pago.Guardar() Then
        '                    MsgBox("Pago se realizo correctamente.", MsgBoxStyle.Information, "AVISO")
        '                    'Try
        '                    '    Dim rep As New crRetiroTck
        '                    '    rep.SetParameterValue("IdRetiro", Retiro.Id)
        '                    '    rep.SetParameterValue("Sucursal", Turno.Sucursal.DescripcionCorta)
        '                    '    rep.SetParameterValue("IdControlTurno", Retiro.Id)
        '                    '    rep.SetParameterValue("Cajero", Controlador.Sesion.MiUsuario.Usrnomcom)
        '                    '    rep.SetParameterValue("FechaHora", Retiro.FechaHora)
        '                    '    rep.SetParameterValue("Importe", Retiro.Importe)
        '                    '    rep.SetParameterValue("Observaciones", UCase(Retiro.Observaciones))
        '                    '    rep.SetParameterValue("Concepto", UCase(Concepto.Concepto))
        '                    '    rep.PrintOptions.PrinterName = "TICKET"
        '                    '    rep.PrintToPrinter(1, False, 0, 0)
        '                    '    rep.Dispose()
        '                    'Catch ex As Exception
        '                    '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        '                    'Finally
        '                    '    MsgBox("Pago se realizo correctamente.", MsgBoxStyle.Information, "AVISO")
        '                    '    Me.Close()
        '                    'End Try
        '                End If
        '            End If
        '        End If
        '    End If
        'Else
        '    Return
        'End If
    End Sub
#End Region

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles timer1.Tick
        lblFecha.Text = Now().ToString("dd-MM-yyyy hh:mm tt")
    End Sub

    Private Sub dgvFacturas_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvFacturas.RowsRemoved

    End Sub

    Private Sub frmPagoRecepCompra_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        If cargacodsucucursal = False Then
            Me.Close()
            Me.Dispose()
        End If

        If carganomimpresora = False Then
            Me.Close()
            Me.Dispose()
        End If


    End Sub

    Private Sub GroupBox3_Enter(sender As System.Object, e As System.EventArgs) Handles gbFormaPago.Enter

    End Sub



    Private Sub chkFormaPago_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFormaPago.CheckedChanged
        If chkFormaPago.Checked Then
            gbFormaPago.Enabled = True
        Else
            gbFormaPago.Enabled = False
        End If
    End Sub

    Private Sub cmbCuenta_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbCuenta.SelectedIndexChanged
        If bandera Then
            If cmbCuenta.SelectedIndex <> -1 Then
                Dim cta As New CN.CuentaClass(CInt(cmbCuenta.SelectedValue))
                bandera = False
                cmbBancos.SelectedValue = CInt(cta.CodBanco).ToString("D3")
                bandera = True
                'Dim bco As New EC.ECtSatcatBancosEntity
                'bco.FetchUsingPK(cmb)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim fact As New CN.FacturasCabCXPClass(Controlador.Empresa.CodEmpndx, CType(cmbProveedor.SelectedValue, CN.ProveedorClass).Codigo, txtFactura.Text.Trim)
        MtxtUUID.Text = fact.UUID
        DtpFechaFac.Value = fact.FechaFactura
        Dim recepciones As New CC.RecepcionOrdenCompraCollection

        For Each row As CN.FacturasDetalleCXPRecepcionesClass In fact.DetalleRecepciones
            recepciones.Add(row.RecepcionOC.ObtenerEntidad)
        Next
        dgvRecepComp.DataSource = recepciones

        dgvRecepComp.Columns(1).DataPropertyName = "IdRecepcionOrdenCompra"
        dgvRecepComp.Columns(2).DataPropertyName = "FechaRecepcion"
        dgvRecepComp.Columns(3).DataPropertyName = "SubTotal"
        dgvRecepComp.Columns(4).DataPropertyName = "Iva"
        dgvRecepComp.Columns(5).DataPropertyName = "Ieps"
        dgvRecepComp.Columns(6).DataPropertyName = "Total"


        For Each row As DataGridViewRow In dgvRecepComp.Rows
            row.Cells(0).Value = True
        Next

    End Sub

    Private Sub dgvRecepComp_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRecepComp.CellContentClick
        If e.ColumnIndex = clmDetalle.Index Then
            Dim detalle As New ClasesComunes.frmDetalleRecepcion(dgvRecepComp.Rows(e.RowIndex).Cells(clmIdRecepCom.Index).Value)
            detalle.ShowDialog()
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub chkFacturada_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFacturada.CheckedChanged
        If chkFacturada.Checked Then
            txtFactura.Enabled = False
            MtxtUUID.Enabled = False
            DtpFechaFac.Enabled = False
        Else
            txtFactura.Enabled = True
            MtxtUUID.Enabled = True
            DtpFechaFac.Enabled = True
        End If

        llenarGridRecepOrdenes()
    End Sub

    Private Sub chkSPagar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSPagar.CheckedChanged
        llenarGridRecepOrdenes()
    End Sub

    Private Sub chkPagada_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPagada.CheckedChanged
        llenarGridRecepOrdenes()
    End Sub

    Private Sub dgvRecepComp_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRecepComp.CellDoubleClick
        'If dgvRecepComp.Rows(e.RowIndex).Cells(clmNoFactura.Index).Value IsNot Nothing And dgvRecepComp.Rows(e.RowIndex).Cells(clmNoFactura.Index).Value <> "" Then
        '    'ReiniciarTodo()
        '    Dim prov As New CN.ProveedorClass(CInt(cmbProveedor.SelectedValue))
        '    Dim noFact As String = dgvRecepComp.Rows(e.RowIndex).Cells(clmNoFactura.Index).Value.ToString()
        '    dgvRecepComp.Rows.Clear()
        '    EstaBuscando = True
        '    Dim fact As New CN.FacturasCabCXPClass(Controlador.Empresa.CodEmpndx, prov.Codigo, noFact)
        '    bandera = False
        '    cmbProveedor.SelectedValue = prov.Codigo
        '    bandera = True
        '    txtFactura.Text = fact.NoFactura
        '    MtxtUUID.Text = fact.UUID
        '    DtpFechaFac.Value = fact.FechaFactura
        '    Dim recepciones As New CC.RecepcionOrdenCompraCollection
        '    For Each row As CN.FacturasDetalleCXPRecepcionesClass In fact.DetalleRecepciones
        '        ' recepciones.Add(row.RecepcionOC.ObtenerEntidad)
        '        dgvRecepComp.Rows.Add(False, row.IdRecepOC, IIf(row.NoRemision = "", row.FolioRecepcion, row.NoRemision), row.NumFactura, CDate(row.FechaRecepcion), row.SubTotal, row.IVA, row.IEPS, row.Total, Nothing, (IIf(row.Pagada = True, "PAGADA", "POR PAGAR")))
        '    Next
        '    'dgvRecepComp.DataSource = recepciones

        '    dgvRecepComp.Columns(1).DataPropertyName = "IdRecepcionOrdenCompra"
        '    dgvRecepComp.Columns(2).DataPropertyName = "FechaRecepcion"
        '    dgvRecepComp.Columns(3).DataPropertyName = "SubTotal"
        '    dgvRecepComp.Columns(4).DataPropertyName = "Iva"
        '    dgvRecepComp.Columns(5).DataPropertyName = "Ieps"
        '    dgvRecepComp.Columns(6).DataPropertyName = "Total"


        '    For Each row As DataGridViewRow In dgvRecepComp.Rows
        '        If row.Cells(clmEstatus.Index).Value.Equals("PAGADA") Then
        '            'row.ReadOnly = True
        '            row.Cells(Pagar.Index).ReadOnly = True
        '        End If
        '    Next
        '    lblTotalDocTexto.Text = "Total Factura:"
        '    lblTotalConcepto.Text = fact.Total.ToString("C2")
        '    If fact.Estatus = EstatusFacturasEnum.PAGADA Then
        '        chkFormaPago.Checked = True
        '        GBPrincipal.Enabled = False
        '        Dim Pago As New CN.PagosProveedoresColeccionClass
        '        Pago.Obtener(fact.IdProveedor, fact.NoFactura, Controlador.Empresa.CodEmpndx)
        '        cmbCuenta.SelectedValue = Pago(0).CuentaBancaria.Codigo

        '        GBPrincipal.Enabled = True
        '        GroupBox2.Enabled = False
        '        dgvRecepComp.Enabled = True
        '        gbFormaPago.Enabled = False

        '        Dim chetran As New CN.ChequeCollectionClass()

        '        Dim filtro As New OC.PredicateExpression
        '        filtro.Add(HC.ChequeFields.Folio = Pago(0).Cheque And HC.ChequeFields.CuentaId = Pago(0).CuentaBancaria.Codigo)
        '        chetran.Obtener(filtro)
        '        If chetran.Count > 0 Then
        '            If chetran(0).Medio = BancosMovimientosMedio.CHEQUE Then
        '                txtNumCheque.Text = Pago(0).Cheque
        '                rbCheque.Checked = True
        '            Else
        '                rbTrans.Checked = True
        '                cmbBancosR.SelectedValue = chetran(0).CodBancoDestino.ToString("000")
        '                txtCuentaRecep.Text = chetran(0).CuentaDestinoReceptor
        '                txtNumCheque.Text = ""
        '                txtReferencia.Text = chetran(0).Referencia
        '            End If
        '        Else
        '            rbEfect.Checked = True
        '        End If
        '        If chkFormaPago.Checked Then
        '            chkFormaPago.Enabled = False
        '        End If

        '    Else

        '        GBPrincipal.Enabled = True
        '        chkFormaPago.Checked = False
        '        gbFormaPago.Enabled = False
        '    End If

        '    'GBPrincipal.Enabled = True
        '    'GroupBox2.Enabled = False
        '    'dgvRecepComp.Enabled = True
        '    'gbFormaPago.Enabled = False
        '    'For Each row As DataGridViewRow In dgvRecepComp.Rows
        '    '    row.Cells(Pagar.Index).ReadOnly = True
        '    '    row.Cells(clmDetalle.Index).ReadOnly = False
        '    'Next
        'End If
    End Sub

    Private Sub rbSinPagar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbSinPagar.CheckedChanged
        llenarGridRecepOrdenes()
    End Sub

    Private Sub rbPagadas_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbPagadas.CheckedChanged
        llenarGridRecepOrdenes()
    End Sub
End Class