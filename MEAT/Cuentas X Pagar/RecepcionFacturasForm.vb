Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses

Public Class RecepcionFacturasForm

    Private Proveedores As New ClasesNegocio.ProveedorCollectionClass
    Private RecepSer As IntegraLab.ORM.CollectionClasses.OrdenServicioCollection
    Private Recepciones As IntegraLab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
    Private Fact As New IntegraLab.ORM.EntityClasses.UsrCxpfacturasCabEntity
    Private FactDet As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection
    Private FactDetRecep As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetRecepcionesCollection
    Dim Total As Decimal
    Dim Subtotal As Decimal
    ' Dim Re As IntegraLab.ORM.EntityClasses.RecepcionesNewEntity
    Dim Editar As Boolean = False
    Dim UltimaTeclaProveedor As DateTime
    Dim SelProveedor As Boolean
    Dim ConfigCont As EC.UsrConfigContabilidadEntity

    'Private Sub RecepcionFacturasForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    '    If e.Control Then
    '        Select Case e.KeyCode
    '            Case Keys.B

    '            Case Keys.N

    '            Case Keys.L

    '            Case Keys.C

    '            Case Keys.X

    '            Case Keys.E

    '            Case Keys.I

    '            Case Keys.S

    '        End Select
    '    End If
    'End Sub

    Private Sub RecepcionFacturasForm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send(Keys.Tab)
            'Me.SelectNextControl(sender, True, True, False, True)
        End If
    End Sub

    Private Sub RecepcionFacturasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "101101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100001"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            Me.mtb.Buttons(0).ToolTipText = "Busca las Facturas Registradas."
            Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
            Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
            Me.mtb.Buttons(5).ToolTipText = "Crea una nueva Factura."
            Me.mtb.Buttons(6).ToolTipText = "Guarda la Factura o los cambios que se le hayan Realizado."
            Me.mtb.Buttons(7).ToolTipText = "Cambia el estatus de la Factura a Inactiva."
            Me.mtb.Buttons(8).ToolTipText = "Permite Modificar la Factura."
            ' Me.mtb.Buttons(10).ToolTipText = "Imprime las Ciudades Registradas."
            Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."

            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")
            ConfigCont = LeeConfigCont()
            If ConfigCont Is Nothing Then
                MessageBox.Show("No se han configurado los parámetros de contabilidad." + vbNewLine + "Capturelos desde Catálogos - Contabilidad - Configuración.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            With Controlador.Sesion.MiEmpresa
                'Me.lbltitulo.BackColorEnd = Color.FromArgb(0, .R, .G, .B)
                Me.lblEmpresa.Text = .Empnom
            End With
            If Proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS) > 0 Then
                Me.CmbProveedor.ValueMember = "Codigo"
                Me.CmbProveedor.DataSource = Proveedores
                Me.CmbProveedor.DisplayMember = "RazonSocial"
            End If            
            Limpiar()
            Deshabilitar()
            'Fact.Estatus = EstatusFacturasEnum.VIGENTE

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

#Region "Métodos"
    Public Sub Limpiar()
        Me.CmbProveedor.SelectedIndex = -1
        Me.CmbProveedor.Text = "Seleccione un Proveedor..."
        Me.txtCheque.Clear()
        Me.txtPoliza.Clear()
        Me.txtDiasPlazo.Text = ""
        Me.TxtFactura.Clear()
        Me.chkPagada.Checked = False
        'Me.ChkAgregarRecepciones.Checked = False
        Me.TxtSubtotal.Clear
        Me.txtIva.Clear()
        Me.TxtAnticipo.Text = ""
        Me.TxtTotal.Clear()
        Me.txtObservaciones.Clear()
        Me.txtConcepto.Clear()
        Me.lblEstatus.Visible = False
        For i As Integer = 0 To Me.DgvRecepciones.Rows.Count - 1
            Me.DgvRecepciones.Rows.RemoveAt(Me.DgvRecepciones.Rows.Count - 1)
        Next
        Editar = False
        Me.chkServicio.Checked = False
        For i As Integer = 0 To Me.DgvCuentas.Rows.Count - 1
            Me.DgvCuentas.Rows.RemoveAt(Me.DgvCuentas.Rows.Count - 1)
        Next
    End Sub

    Public Sub Habilitar()
        Me.CmbProveedor.Enabled = True
        Me.txtCheque.Enabled = True
        Me.txtPoliza.Enabled = True
        Me.DtpFechaFactura.Enabled = True
        ' Me.DtpFechaVencimiento.Enabled = True
        Me.TxtFactura.Enabled = True
        Me.chkPagada.Enabled = True
        'Me.ChkAgregarRecepciones.Enabled = True
        Me.txtSubtotal.Enabled = True
        Me.txtIva.Enabled = True
        Me.TxtAnticipo.Enabled = True
        'Me.TxtTotal.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.txtConcepto.Enabled = True
        Me.DgvRecepciones.Enabled = True
        Me.chkServicio.Enabled = True
        Me.DgvCuentas.Enabled = True
    End Sub

    Public Sub Deshabilitar()
        Me.CmbProveedor.Enabled = False
        Me.txtCheque.Enabled = False
        Me.DtpFechaFactura.Enabled = False
        Me.DtpFechaVencimiento.Enabled = False
        Me.txtPoliza.Enabled = False
        Me.TxtFactura.Enabled = False
        Me.chkPagada.Enabled = False
        ' Me.ChkAgregarRecepciones.Enabled = False
        Me.txtSubtotal.Enabled = False
        Me.txtIva.Enabled = False
        Me.TxtAnticipo.Enabled = False
        Me.TxtTotal.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.txtConcepto.Enabled = False
        Me.DgvRecepciones.Enabled = False
        Me.chkServicio.Enabled = False
        Me.DgvCuentas.Enabled = False
    End Sub

    Public Sub PasarValores()
        Fact.IdUsuarioAlta = Controlador.Sesion.Usrndx
        Fact.EmpresaId = Controlador.Sesion.Empndx
        Fact.IdProveedor = Me.CmbProveedor.SelectedValue
        Fact.FechaCaptura = Now
        Fact.NoFactura = Me.TxtFactura.Text
        Fact.FechaFactura = Me.DtpFechaFactura.Value
        Fact.FechaVencimiento = Me.DtpFechaVencimiento.Value
        If Me.chkServicio.Checked Then
            Fact.Servicios = True
        Else
            Fact.Servicios = False
        End If

        Fact.Gastos = False
        Fact.TasaIsr = 0
        Fact.TasaIva = 0
        Fact.TasaRetIva = 0

        If Me.txtSubtotal.Text = "" Then
            Fact.SubTotal = 0
        Else
            Fact.SubTotal = Me.txtSubtotal.Text
        End If
        If Me.txtIva.Text = "" Then
            Fact.Iva = 0
        Else
            Fact.Iva = Me.txtIva.Text
        End If
        If Me.TxtAnticipo.Text = "" Then
            Fact.Anticipo = 0
        Else
            Fact.Anticipo = Me.TxtAnticipo.Text
            If Fact.Anticipo <> 0 Then
                Fact.Estatus = CN.EstatusFacturasEnum.ABONADA
            End If
        End If
        If Me.TxtTotal.Text = "" Then
            Fact.Saldo = 0
        Else
            Fact.Total = Me.TxtTotal.Text
            Fact.Saldo = Me.TxtTotal.Text
        End If

        Fact.Observaciones = Me.txtObservaciones.Text
        Fact.Concepto = Me.txtConcepto.Text

    End Sub

    Public Sub ObtenerValores()
        Me.DtpFechaCaptura.Value = Me.Fact.FechaCaptura
        Me.CmbProveedor.SelectedValue = Me.Fact.IdProveedor
        Me.TxtFactura.Text = Fact.NoFactura
        Me.DtpFechaFactura.Value = Me.Fact.FechaFactura
        Me.DtpFechaVencimiento.Value = Me.Fact.FechaVencimiento
        Me.TxtSubtotal.Text = Me.Fact.SubTotal
        Me.txtIva.Text = Me.Fact.Iva
        Me.TxtAnticipo.Text = Me.Fact.Anticipo
        Me.TxtTotal.Text = Me.Fact.Total
        Me.txtObservaciones.Text = Me.Fact.Observaciones
        Me.txtConcepto.Text = Me.Fact.Concepto
        Select Case (Me.Fact.Estatus)
            Case 0
                Me.lblEstatus.Text = "CANCELADA"
            Case 1
                Me.lblEstatus.Text = "PAGADA"
            Case 2
                Me.lblEstatus.Text = "VIGENTE"
            Case 3
                Me.lblEstatus.Text = "ABONADA"
        End Select
        Me.chkServicio.Checked = Me.Fact.Servicios
    End Sub

    Public Function Validar() As Boolean
        If Me.Fact.IsNew Then
            If Me.TxtFactura.Text = "" Then
                MsgBox("Agregue información a el No. de Factura...", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            Else
                Dim Facturas As New IntegraLab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
                Facturas.GetMulti(IntegraLab.ORM.HelperClasses.UsrCxpfacturasCabFields.NoFactura = Me.TxtFactura.Text And IntegraLab.ORM.HelperClasses.UsrCxpfacturasCabFields.IdProveedor = Me.CmbProveedor.SelectedValue)
                If Facturas.Count > 0 Then
                    MsgBox("El número de Factura ya fue registrado, ingrese otro...")
                    Me.TxtFactura.Focus()
                    Return False
                End If
            End If
        End If
        If Me.txtSubtotal.Text = "" Then
            MsgBox("No puede hacer una factura por $0.00")
            Return False
        End If
        If Me.Fact.IsNew Then
            Dim facts As New Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(Integralab.ORM.HelperClasses.UsrCxpfacturasCabFields.NoFactura = Me.TxtFactura.Text)
            filtro.Add(Integralab.ORM.HelperClasses.UsrCxpfacturasCabFields.IdProveedor = Me.CmbProveedor.SelectedValue)
            facts.GetMulti(filtro)
            If facts.Count > 0 Then
                MsgBox("La Factura ya fue Registrada...", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        End If
        If Me.DgvCuentas.Rows.Count <= 1 Then
            MsgBox("No ha relacionado las Cuentas Contables a Afectar.", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End If
        If Not CDec(Me.TxtSumaAbono.Text) = CDec(Me.txtSumaCargo.Text) Then
            MsgBox("Las Sumas del Cargo y del Abono deben ser Equivalentes", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        ElseIf Not CDec(Me.TxtSumaAbono.Text) = CDec(Me.TxtTotal.Text) Then
            MsgBox("El importe de las Sumas de Cargos y Abonos debe ser Igual al Importe Total...", , "Aviso")
            Return False
        End If
        If Me.txtSumaCargo.Text <> Me.TxtTotal.Text Then
            MsgBox("La Suma de el (los) Cargo(s) no Coinciden con el Total de la Factura", MsgBoxStyle.Exclamation, "Error")
            Return False
        End If
        Return True
    End Function

    Public Sub AgregarRecepcionesCompra()
        Try
            Recepciones = New IntegraLab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
            FactDetRecep = New IntegraLab.ORM.CollectionClasses.UsrCxpfacturasDetRecepcionesCollection
            For i As Integer = 0 To Me.DgvRecepciones.Rows.Count - 1
                If CBool(Me.DgvRecepciones.Rows(i).Cells("Agregar").Value) Then
                    Dim Rec As New IntegraLab.ORM.EntityClasses.RecepcionOrdenCompraEntity
                    Dim FD As New IntegraLab.ORM.EntityClasses.UsrCxpfacturasDetRecepcionesEntity
                    If Rec.FetchUsingPK(Me.DgvRecepciones.Rows(i).Cells("IdRecepcionOrdenCompra").Value) Then
                        Rec.Facturada = True
                        Rec.NoFactura = Me.TxtFactura.Text
                        Recepciones.Add(Rec)
                    End If
                    FD.EmpresaId = Controlador.Sesion.Empndx
                    FD.IdProveedor = Me.CmbProveedor.SelectedValue
                    FD.NoFactura = Me.TxtFactura.Text
                    FD.IdRecepcionOrdenCompra = Me.DgvRecepciones.Rows(i).Cells("IdRecepcionOrdenCompra").Value
                    Me.FactDetRecep.Add(FD)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub AgregarRecepcionesServicio()
        Try
            RecepSer = New IntegraLab.ORM.CollectionClasses.OrdenServicioCollection
            FactDetRecep = New IntegraLab.ORM.CollectionClasses.UsrCxpfacturasDetRecepcionesCollection
            For i As Integer = 0 To Me.DgvRecepciones.Rows.Count - 1
                If CBool(Me.DgvRecepciones.Rows(i).Cells("Agregar").Value) Then
                    Dim Rec As New IntegraLab.ORM.EntityClasses.OrdenServicioEntity
                    Dim FD As New IntegraLab.ORM.EntityClasses.UsrCxpfacturasDetRecepcionesEntity
                    If Rec.FetchUsingPK(Me.DgvRecepciones.Rows(i).Cells("Folio").Value) Then
                        Rec.FolioFactura = Me.TxtFactura.Text
                        RecepSer.Add(Rec)
                    End If
                    FD.EmpresaId = Controlador.Sesion.Empndx
                    FD.IdProveedor = Me.CmbProveedor.SelectedValue
                    FD.NoFactura = Me.TxtFactura.Text
                    FD.IdRecepcionOrdenCompra = Me.DgvRecepciones.Rows(i).Cells("Folio").Value
                    Me.FactDetRecep.Add(FD)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    'Este metodo determina si hay recepciones agregadas 
    'Con el fin de calcular el Iva en caso de qe
    'no haya
    Public Function SeAgregaronRecepciones() As Boolean
        Dim Contador As Integer = 0
        For i As Integer = 0 To Me.DgvRecepciones.Rows.Count - 1
            If CBool(Me.DgvRecepciones.Rows(i).Cells("Agregar").Value) Then
                Contador += 1
            End If
        Next
        If Contador = 0 Then
            Return False
        End If
        Return True
    End Function

    Function ObtenerRecepcionesCompra() As Boolean
        Try
            If Me.Editar = False Then
                If CmbProveedor.SelectedIndex = -1 Then
                    MessageBox.Show("Antes debe seleccionar un proveedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If
                Dim Proveedor As ClasesNegocio.ProveedorClass = Me.CmbProveedor.SelectedItem
                Me.txtDiasPlazo.Text = Proveedor.DiasCredito.ToString
                Dim Recep As New CN.RecepcionOrdenCompraCollectionClass
                If Recep.Obtener(Me.CmbProveedor.SelectedValue, "", ClasesNegocio.CondicionEnum.ACTIVOS) > 0 Then
                    Me.DgvRecepciones.AutoGenerateColumns = False
                    Me.DgvRecepciones.Rows.Clear()
                    If Recep.Count > 0 Then
                        For i As Integer = 0 To Recep.Count - 1
                            Me.DgvRecepciones.Rows.Add()
                            Me.DgvRecepciones.Rows(i).Cells("Folio").Value = Recep(i).FolioRecepcionOrdenCompra
                            Me.DgvRecepciones.Rows(i).Cells("IdRecepcionOrdenCompra").Value = Recep(i).IdOrdenCompra
                            Me.DgvRecepciones.Rows(i).Cells("FechaRecepcion").Value = Recep(i).FechaRecepcion
                            Me.DgvRecepciones.Rows(i).Cells("FolioOrden").Value = Recep(i).OrdenCompra.FolioOrdenCompra
                            Me.DgvRecepciones.Rows(i).Cells("CantidadProducto").Value = Recep(i).Cantidad
                            Me.DgvRecepciones.Rows(i).Cells("Importe").Value = Recep(i).Total.ToString("C2")

                        Next
                    End If
                Else
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try        
    End Function

    Public Sub ObtenerRecepcionesServicio()
        If Not IsNothing(Me.CmbProveedor.SelectedValue) Then
            If Me.Editar = False Then
                Dim Proveedor As ClasesNegocio.ProveedorClass = Me.CmbProveedor.SelectedItem
                Me.txtDiasPlazo.Text = Proveedor.DiasCredito.ToString
                Dim RecepServicio As New CN.OrdenServicioCollectionClass
                RecepServicio.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, , , Proveedor, , ClasesNegocio.CondicionOrdenRecibida.SI)
                Me.DgvRecepciones.Rows.Clear()
                If RecepServicio.Count > 0 Then
                    For i As Integer = 0 To RecepServicio.Count - 1
                        Me.DgvRecepciones.Rows.Add()
                        Me.DgvRecepciones.Rows(i).Cells("Folio").Value = RecepServicio(i).Folio
                        Me.DgvRecepciones.Rows(i).Cells("FechaRecepcion").Value = RecepServicio(i).FechaRecepcion
                        'Me.DgvRecepciones.Rows(i).Cells("FechaRetiro").Value = Recep(i).FechaRetiro
                        'Me.DgvRecepciones.Rows(i).Cells("NombreProducto").Value = Recep(i).ProductoNombre
                        Me.DgvRecepciones.Rows(i).Cells("CantidadProducto").Value = RecepServicio(i).Cantidad
                        Me.DgvRecepciones.Rows(i).Cells("Importe").Value = RecepServicio(i).Total.ToString("C2")
                    Next
                End If
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
                        'If Me.DgvCuentas.Rows(0).Cells("ClmCtaMayor").Value = Cta.CuentaMayor And _
                        'Me.DgvCuentas.Rows(0).Cells("ClmSubCta").Value = Cta.SubCuenta And _
                        'Me.DgvCuentas.Rows(0).Cells("ClmSsbCta").Value = Cta.SSubCuenta And _
                        'Me.DgvCuentas.Rows(0).Cells("ClmSssCta").Value = Cta.SSSubCuenta And _
                        'Me.DgvCuentas.Rows(0).Cells("ClmDescripcion").Value = Cta.NombreCuenta Then
                        '    MsgBox("Imposible agregar cuenta contable duplicada", MsgBoxStyle.Information, "Aviso")
                        ' Else
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
                            Me.DgvCuentas.Rows(i - 1).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                            Me.DgvCuentas.Rows(i - 1).Cells("ClmSubCta").Value = Cta.SubCuenta
                            Me.DgvCuentas.Rows(i - 1).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                            Me.DgvCuentas.Rows(i - 1).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                            Me.DgvCuentas.Rows(i - 1).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                            Me.DgvCuentas.Rows(i - 1).Cells("ClmCargo").Value = 0
                            Me.DgvCuentas.Rows(i - 1).Cells("ClmAbono").Value = 0
                            Me.DgvCuentas.Rows.Add()
                        End If
                        'End If
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
                    If Me.DgvCuentas.Rows.Count = 1 Then
                        For j As Integer = 0 To Me.DgvCuentas.Columns.Count - 3
                            Me.DgvCuentas.Rows(0).Cells(j).ReadOnly = True
                        Next
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub GuardarCtas()
        ' If Me.chkServicio.Checked = False Then
        'Cargos de la factura
        For i As Integer = 0 To Me.DgvCuentas.Rows.Count - 1
            If Not Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = "" Then
                Dim CtaCon As New CN.CuentaContableCollectionClass
                Dim FacturaDet As New EC.UsrCxpfacturasDetEntity
                CtaCon.Obtener(, Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value, Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value, Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value, Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value, Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value, , , , , , )
                FacturaDet.CuentaContableId = CtaCon(0).Codigo
                FacturaDet.EmpresaId = Controlador.Sesion.Empndx
                FacturaDet.NoFactura = Me.Fact.NoFactura
                FacturaDet.IdProveedor = Me.CmbProveedor.SelectedValue
                If Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value > 0 Then
                    FacturaDet.Importe = Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value
                    FacturaDet.CarAbo = "C"
                ElseIf Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value > 0 Then
                    FacturaDet.Importe = Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value
                    FacturaDet.CarAbo = "A"
                End If
                Me.FactDet.Add(FacturaDet)
                'Me.Factura.Detalles.Add(Det)
            End If
        Next
        'Cuenta a abono del proveedor
        'Dim prov As New CN.ProveedorCollectionClass
        'prov.Obtener(CType(Me.CmbProveedor.SelectedValue, Integer))
        'If prov.Count > 0 Then
        '    Dim FacturaDet As New EC.UsrCxpfacturasDetEntity
        '    FacturaDet.EmpresaId = Me.Fact.EmpresaId
        '    FacturaDet.NoFactura = Me.Fact.NoFactura
        '    FacturaDet.IdProveedor = Me.Fact.IdProveedor
        '    FacturaDet.CuentaContableId = prov(0).CuentaContable2.Codigo
        '    FacturaDet.CarAbo = "A"
        '    FacturaDet.Importe = Me.Fact.Total
        '    Me.FactDet.Add(FacturaDet)
        'End If
        FactDet.SaveMulti()
        'End If
    End Sub

    Function LeeConfigCont() As EC.UsrConfigContabilidadEntity
        Dim tabla As New DataSet
        Dim loConf As EC.UsrConfigContabilidadEntity

        Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("PaContUsrConfigContabilidad", _
                                New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
            ad.SelectCommand.CommandType = CommandType.StoredProcedure
            With ad.SelectCommand.Parameters
                .Add("@Func", SqlDbType.Char).Value = "C"
                .Add("@Opcion", SqlDbType.Int).Value = 1
                .Add("@CancelaPolizaNegativos", SqlDbType.Char).Value = "S"
                .Add("@IVA", SqlDbType.Money).Value = 0
                .Add("@ISR", SqlDbType.Money).Value = 0
                .Add("@TasaRetencion", SqlDbType.Money).Value = 0
                .Add("@Flete", SqlDbType.Money).Value = 0
                .Add("@MostrarDomicilio", SqlDbType.Bit).Value = 0
            End With

            ad.SelectCommand.CommandTimeout = 30
            ad.SelectCommand.Connection.Open()
            ad.Fill(tabla)
            ad.SelectCommand.Connection.Close()
        End Using
        If tabla.Tables.Count > 0 Then
            If tabla.Tables(0).Rows.Count > 0 Then
                loConf = New EC.UsrConfigContabilidadEntity
                loConf.CancelacionPolizasNegativos = tabla.Tables(0).Rows(0)("CancelacionPolizasNegativos")
                loConf.Iva = CDbl(tabla.Tables(0).Rows(0)("iva"))
                loConf.Isr = CDbl(tabla.Tables(0).Rows(0)("ISR"))
                loConf.TasaRetencion = CDbl(tabla.Tables(0).Rows(0)("TasaRetencion"))
                loConf.MostrarDomicPoliza = tabla.Tables(0).Rows(0)("MostrarDomicPoliza")
                loConf.Ivaflete = CDbl(tabla.Tables(0).Rows(0)("IVAFlete"))
                Return loConf
            Else
                Return Nothing
            End If
        Else
            Return Nothing
        End If
    End Function
#End Region

#Region "MEAToolBar"

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        If Me.Fact.Estatus = CN.EstatusFacturasEnum.PAGADA Or Me.Fact.Estatus = CN.EstatusFacturasEnum.ABONADA Then
            MsgBox("La Factura ya Fué Abonada o Pagada, Imposible Cancelarla", MsgBoxStyle.Information, "Aviso")
            Cancelar = True
        Else
            Dim Ventana As New CancelacionOrdenRetiroForm
            Ventana.Text = "Cancelación de Factura"
            Ventana.lblTitulo.Text = "CANCELACIÓN DE FACTURA"
            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                'ojo
                'Me.Fact.IdUsuarioCancelacion = Ventana.Usuario.Usrndx
                'Me.Fact.IdMotivoCancelacion = Ventana.Motivo.Codigo
                Me.Fact.FechaCancelacion = Now
                Fact.Estatus = CN.EstatusFacturasEnum.CANCELADA
                Recepciones = New IntegraLab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
                Recepciones.GetMulti(IntegraLab.ORM.HelperClasses.RecepcionOrdenCompraFields.NoFactura = Me.Fact.NoFactura)
                For Each Rec As IntegraLab.ORM.EntityClasses.RecepcionOrdenCompraEntity In Recepciones
                    Rec.NoFactura = ""
                    Rec.Facturada = False
                Next
                Dim tran As New IntegraLab.ORM.HelperClasses.Transaction(IsolationLevel.ReadCommitted, "FacCan")
                Try
                    tran.Add(Fact)
                    If Fact.Save Then
                        If Recepciones.Count > 0 Then
                            tran.Add(Recepciones)
                            If Recepciones.SaveMulti Then
                                tran.Commit()
                                'busca si hay facturas en la programacion de pagos para 
                                'eliminarlas si no estan abonadas
                                Dim FactPagar As New CN.FacturasAPagarCXPColeccion
                                FactPagar.Obtener(Me.Fact.IdProveedor, Fact.NoFactura)
                                If FactPagar.Count = 1 Then
                                    FactPagar.ObtenerColeccion.DeleteMulti()
                                End If
                                MsgBox("La Factura ha sido Cancelada...")
                                Limpiar()
                                Cancelar = False
                                Me.TxtSubtotal.Enabled = False
                                Me.txtIva.Enabled = False
                                Me.TxtTotal.Enabled = False
                            Else
                                tran.Rollback()
                                MsgBox("La Factura no pudo ser Cancelada...")
                                Me.TxtSubtotal.Enabled = False
                                Me.txtIva.Enabled = False
                                Me.TxtTotal.Enabled = False
                            End If
                        Else
                            tran.Commit()
                            'busca si hay facturas en la programacion de pagos para 
                            'eliminarlas si no estan abonadas
                            Dim FactPagar As New CN.FacturasAPagarCXPColeccion
                            FactPagar.Obtener(Me.Fact.IdProveedor, Fact.NoFactura)
                            If FactPagar.Count = 1 Then
                                FactPagar.ObtenerColeccion.DeleteMulti()
                            End If
                            MsgBox("La Factura ha sido Cancelada...")
                            Limpiar()
                            Cancelar = False
                            Me.TxtSubtotal.Enabled = False
                            Me.txtIva.Enabled = False
                            Me.TxtTotal.Enabled = False
                        End If
                    Else
                        tran.Rollback()
                        MsgBox("La Factura no pudo ser Cancelada...")
                        Me.TxtSubtotal.Enabled = False
                        Me.txtIva.Enabled = False
                        Me.TxtTotal.Enabled = False
                    End If
                Catch ex As Exception
                    tran.Rollback()
                    MsgBox(ex.Message)
                End Try
            Else
                Cancelar = True
            End If
        End If
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Dim Busqueda As New BusquedaFacturasForm
        Busqueda.EsDeGastos = False
        If Busqueda.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Facturas_ As New IntegraLab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
            Facturas_.GetMulti(HC.UsrCxpfacturasCabFields.NoFactura = Busqueda.Factura And HC.UsrCxpfacturasCabFields.IdProveedor = Busqueda.ProveedorID)
            If Facturas_.Count = 1 Then
                Me.Fact = Facturas_(0)
                ObtenerValores()
                If Fact.Servicios Then
                    Dim FacDe As New CN.OrdenServicioCollectionClass
                    FacDe.Obtener(Fact.IdProveedor, Fact.NoFactura)
                    If FacDe.Count <> 0 Then
                        Editar = True
                        Me.DgvRecepciones.DataSource = Nothing
                        'Else
                        Me.DgvRecepciones.Rows.Clear()
                        If FacDe.Count > 0 Then
                            For i As Integer = 0 To FacDe.Count - 1
                                Me.DgvRecepciones.Rows.Add()
                                'If Recep(i).ImporteTotal > 0.0 Then
                                Me.DgvRecepciones.Rows(i).Cells("Folio").Value = FacDe(i).Folio
                                Me.DgvRecepciones.Rows(i).Cells("FechaRecepcion").Value = FacDe(i).FechaRecepcion
                                Me.DgvRecepciones.Rows(i).Cells("CantidadProducto").Value = FacDe(i).Cantidad
                                Me.DgvRecepciones.Rows(i).Cells("Importe").Value = FacDe(i).Total.ToString("C2")
                                Me.DgvRecepciones.Rows(i).Cells("Agregar").Value = True
                                'Me.DgvRecepciones.Rows(i).Cells("CantidadProducto").Value = FacDe(i).CantidadTotalRecibida
                                'Me.DgvRecepciones.Rows(i).Cells("Importe").Value = FacDe(i).ImporteTotal.ToString("C2")
                            Next
                        End If
                        Editar = True
                    End If
                Else
                    Dim FacDe As New CN.RecepcionOrdenCompraCollectionClass
                    FacDe.Obtener(Fact.IdProveedor, Fact.NoFactura)
                    If FacDe.Count <> 0 Then
                        Editar = True
                        Me.DgvRecepciones.DataSource = Nothing
                        'Else
                        Me.DgvRecepciones.Rows.Clear()
                        If FacDe.Count > 0 Then
                            For i As Integer = 0 To FacDe.Count - 1
                                Me.DgvRecepciones.Rows.Add()
                                'If Recep(i).ImporteTotal > 0.0 Then
                                Me.DgvRecepciones.Rows(i).Cells("Folio").Value = FacDe(i).FolioRecepcionOrdenCompra
                                Me.DgvRecepciones.Rows(i).Cells("FechaRecepcion").Value = FacDe(i).FechaRecepcion
                                Me.DgvRecepciones.Rows(i).Cells("CantidadProducto").Value = FacDe(i).Cantidad
                                Me.DgvRecepciones.Rows(i).Cells("Importe").Value = FacDe(i).Total.ToString("C2")
                                Me.DgvRecepciones.Rows(i).Cells("Agregar").Value = True
                                'Me.DgvRecepciones.Rows(i).Cells("CantidadProducto").Value = FacDe(i).CantidadTotalRecibida
                                'Me.DgvRecepciones.Rows(i).Cells("Importe").Value = FacDe(i).ImporteTotal.ToString("C2")
                            Next
                        End If
                        Editar = True
                    End If
                End If

                Dim FacturasDetalle As New CC.UsrCxpfacturasDetCollection
                FacturasDetalle.GetMulti(HC.UsrCxpfacturasDetFields.EmpresaId = Controlador.Sesion.Empndx And HC.UsrCxpfacturasDetFields.IdProveedor = Me.CmbProveedor.SelectedValue And HC.UsrCxpfacturasDetFields.NoFactura = Me.TxtFactura.Text And HC.UsrCxpfacturasDetFields.CarAbo = "C")

                If FacturasDetalle.Count = 0 Then
                    MessageBox.Show("Esta factura no tienes cuentas contables asociadas", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim CuentasCont As ClasesNegocio.CuentaContableClass
                    For Each FacDetalle As EC.UsrCxpfacturasDetEntity In FacturasDetalle
                        CuentasCont = New ClasesNegocio.CuentaContableClass(FacDetalle.CuentaContable)
                        RellenarGridCuentas(CuentasCont)
                    Next
                End If

                Me.lblEstatus.Visible = True
                Me.TxtSubtotal.Enabled = False
                Me.txtIva.Enabled = False
                Me.TxtTotal.Enabled = False
                Total = Me.Fact.Total
            End If
        End If
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Deshabilitar()
        'Cancelar = True
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar

        If Me.Fact.Estatus = CN.EstatusFacturasEnum.PAGADA Then
            MsgBox("La factura ya está Pagada no puede Editarla")
            Cancelar = True
        Else
            If Me.Fact.Estatus = CN.EstatusFacturasEnum.CANCELADA Then
                MsgBox("La factura ya está Cancelada no puede Editarla")
                Cancelar = True
            Else
                If Me.Fact.UsrCxpfacturasDetRecepciones.Count > 0 Then
                    MsgBox("La Factura no puede ser editada...")
                    Cancelar = True
                Else
                    Habilitar()
                    Me.DgvRecepciones.Enabled = False
                    Me.CmbProveedor.Enabled = False
                    Me.TxtAnticipo.Text = 0.ToString("C2")
                    Me.TxtSubtotal.Enabled = True
                    Me.txtIva.Enabled = True
                    Me.TxtTotal.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim tran As New IntegraLab.ORM.HelperClasses.Transaction(IsolationLevel.ReadCommitted, "Fac")
        Try
            PasarValores()
            If Me.TxtTotal.Text = "$0.00" Then
                Me.Fact.Estatus = CN.EstatusFacturasEnum.PAGADA
            End If
            If Editar = False Then
                If Me.chkServicio.Checked Then
                    AgregarRecepcionesServicio()
                    For Each Det As IntegraLab.ORM.EntityClasses.UsrCxpfacturasDetRecepcionesEntity In FactDetRecep
                        Fact.UsrCxpfacturasDetRecepciones.Add(Det)
                    Next
                Else
                    AgregarRecepcionesCompra()
                    For Each Det As IntegraLab.ORM.EntityClasses.UsrCxpfacturasDetRecepcionesEntity In FactDetRecep
                        Fact.UsrCxpfacturasDetRecepciones.Add(Det)
                    Next
                End If
            End If
            If Validar() Then
                tran.Add(Fact)
                If Fact.Save Then
                    GuardarCtas()
                    If Editar = False Then
                        If chkServicio.Checked Then
                            If RecepSer.Count > 0 Then
                                tran.Add(RecepSer)
                                If RecepSer.SaveMulti Then
                                    tran.Add(Fact.UsrCxpfacturasDetRecepciones)
                                    If Fact.UsrCxpfacturasDetRecepciones.SaveMulti Then
                                        tran.Commit()
                                        MsgBox("La Recepción de Factura ha sido guardada satisfactoriamente...")
                                        Limpiar()
                                        Deshabilitar()
                                        Cancelar = False
                                    End If
                                Else
                                    tran.Rollback()
                                    MsgBox("La Recepción de factura NO pudo ser Guardada...")
                                    Cancelar = True
                                End If
                            Else
                                tran.Commit()
                                MsgBox("La Recepción de Factura ha sido guardada satisfactoriamente...")
                                Limpiar()
                                Deshabilitar()
                                Cancelar = False
                            End If
                        Else
                            If Recepciones.Count > 0 Then
                                tran.Add(Recepciones)
                                If Recepciones.SaveMulti Then
                                    tran.Add(Fact.UsrCxpfacturasDetRecepciones)
                                    If Fact.UsrCxpfacturasDetRecepciones.SaveMulti Then
                                        tran.Commit()
                                        MsgBox("La Recepción de Factura ha sido guardada satisfactoriamente...")
                                        Limpiar()
                                        Deshabilitar()
                                        Cancelar = False
                                    End If
                                Else
                                    tran.Rollback()
                                    MsgBox("La Recepción de factura NO pudo ser Guardada...")
                                    Cancelar = True
                                End If
                            Else
                                tran.Commit()
                                MsgBox("La Recepción de Factura ha sido guardada satisfactoriamente...")
                                Limpiar()
                                Deshabilitar()
                                Cancelar = False
                            End If
                        End If
                    Else
                        tran.Commit()
                        MsgBox("La Recepción de Factura ha sido guardada satisfactoriamente...")
                        Limpiar()
                        Deshabilitar()
                        Cancelar = False
                    End If
                Else
                    tran.Rollback()
                    MsgBox("La Recepción de factura NO pudo ser Guardada...")
                    Cancelar = True
                End If
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            tran.Rollback()
            Cancelar = True
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        Finally
            tran = Nothing
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Habilitar()
        Fact = New IntegraLab.ORM.EntityClasses.UsrCxpfacturasCabEntity
        Me.FactDet = New CC.UsrCxpfacturasDetCollection
        Fact.TasaIva = ConfigCont.Iva
        Fact.Estatus = CN.EstatusFacturasEnum.VIGENTE
        SelProveedor = True
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

    Private Sub TxtFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFactura.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            Me.DtpFechaFactura.Focus()
            If Me.TxtFactura.Text = "" Then
                MsgBox("Agregue Información a el No. de Factura. . . ")
                TxtFactura.Focus()
            Else
                Dim facturas As New IntegraLab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
                Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
                filtro.Add(IntegraLab.ORM.HelperClasses.UsrCxpfacturasCabFields.NoFactura = Me.TxtFactura.Text)
                filtro.Add(IntegraLab.ORM.HelperClasses.UsrCxpfacturasCabFields.IdProveedor = Me.CmbProveedor.SelectedValue)
                facturas.GetMulti(filtro)
                If facturas.Count > 0 Then
                    MsgBox("El número de Factura ya fue registrado...")
                    Me.TxtFactura.Clear()
                    Me.TxtFactura.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub txtDiasPlazo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiasPlazo.TextChanged
        If Me.txtDiasPlazo.Text = "" Then
            Me.txtDiasPlazo.Text = "0"
        End If
        Me.DtpFechaVencimiento.Value = DtpFechaFactura.Value.AddDays(CDec(Me.txtDiasPlazo.Text))
    End Sub

    Private Sub CmbProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbProveedor.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNothing(Me.CmbProveedor.SelectedValue) Then
                MsgBox("Seleccione un Proveedor")
                Me.CmbProveedor.Focus()
            Else
                Me.TxtFactura.Focus()
            End If
        ElseIf e.KeyChar = Chr(Keys.F12) Then
            Proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.CmbProveedor.ValueMember = "IDProveedor"
            Me.CmbProveedor.DataSource = Proveedores
            Me.CmbProveedor.DisplayMember = "RazonSocial"
            Me.CmbProveedor.SelectedIndex = -1
            Me.CmbProveedor.Text = "Seleccione un Proveedor..."
        Else
            Me.TmProveedor.Stop()
            Me.UltimaTeclaProveedor = Now
            Me.TmProveedor.Start()
        End If
    End Sub

    '    If Me.ChkAgregarRecepciones.Checked Then
    '        Recepciones = New IntegraLab.ORM.CollectionClasses.RecepcionesNewCollection
    '        FactDetRecep = New IntegraLab.ORM.CollectionClasses.FacturasCuentasXPagarDetRecepcionesCollection
    '        Dim AgregarRecep As New AgregarRecepcionesForm
    '        If Not IsNothing(Me.CmbProveedor.SelectedValue) Then
    '            If Not Me.TxtFactura.Text = "" Then
    '                AgregarRecep.prov = Me.CmbProveedor.SelectedValue

    '                Dim Recep As New IntegraLab.ORM.TypedViewClasses.RecepcionesProveedoresTypedView

    '                Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

    '                filtro.Add(IntegraLab.ORM.HelperClasses.RecepcionesProveedoresFields.IdProveedor = AgregarRecep.prov)
    '                filtro.Add(New SD.LLBLGen.Pro.ORMSupportClasses.FieldCompareNullPredicate(IntegraLab.ORM.HelperClasses.RecepcionesProveedoresFields.FolioFactura))
    '                AgregarRecep.DgvRecepciones.AutoGenerateColumns = False

    '                Recep.Fill(0, Nothing, True, filtro)
    '                If Recep.Count = 0 Then
    '                    MsgBox("El proveedor no tiene Recepciones a facturar...")
    '                Else
    '                    AgregarRecep.DgvRecepciones.DataSource = Recep
    '                    If AgregarRecep.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                        ' Dim Filtro2 As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
    '                        'Filtro2.Add(IntegraLab.ORM.HelperClasses.RecepcionesProveedoresFields.IdProveedor = AgregarRecep.prov)
    '                        'Filtro2.Add(New SD.LLBLGen.Pro.ORMSupportClasses.FieldCompareNullPredicate(IntegraLab.ORM.HelperClasses.RecepcionesProveedoresFields.FolioFactura))
    '                        'Recepciones.GetMulti(Filtro2)
    '                        For i As Integer = 0 To Recep.Count - 1
    '                            Dim FactDetR As New IntegraLab.ORM.EntityClasses.FacturasCuentasXPagarDetRecepcionesEntity
    '                            If CBool(AgregarRecep.DgvRecepciones.Rows(i).Cells("Agregar").Value) Then
    '                                If Not Me.TxtFactura.Text = "" Then
    '                                    ' la recepcion relacionada a la factura ponerle el folio de la factura y cambiarle
    '                                    ' El estatus a facturada
    '                                    Recepciones.GetMulti(IntegraLab.ORM.HelperClasses.RecepcionesNewFields.FolioRecepcion = Recep(i).FolioRecepcion)
    '                                    If Recepciones.Count = 1 Then
    '                                        Recepciones(0).FolioFactura = Me.TxtFactura.Text
    '                                        Recepciones(0).Facturada = True
    '                                    End If
    '                                    'Agregar Los detalles
    '                                    FactDetR.EmpresaId = Controlador.Sesion.Empndx
    '                                    FactDetR.IdProveedor = Me.CmbProveedor.SelectedValue
    '                                    FactDetR.NoFactura = Me.TxtFactura.Text
    '                                    FactDetR.FolioRecepcion = AgregarRecep.DgvRecepciones.Rows(i).Cells("Folio").Value
    '                                    FactDetRecep.Add(FactDetR)
    '                                End If
    '                            End If
    '                        Next
    '                    End If
    '                End If
    '            Else
    '                MsgBox("Agregue el No. de Factura...")
    '            End If
    '        Else
    '            MsgBox("Seleccione un Proveedor...")
    '        End If
    '        'If Not Me.TxtFactura.Text = "" Then
    '        '    AgregarRecep.Fact = TxtFactura.Text
    '        'End If

    '        Me.ChkAgregarRecepciones.Checked = False
    '    End If
    'End Sub

    Private Sub CmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProveedor.SelectedIndexChanged
        If CmbProveedor.SelectedValue Is Nothing Then
            Return
        End If
        Try
            If SelProveedor = False Then
                Exit Sub
            End If
            Dim Prov As New CN.ProveedorCollectionClass
            Dim Pr As CN.ProveedorClass = Prov.Obtener(Me.CmbProveedor.SelectedValue)
            If Me.CmbProveedor.SelectedValue > 0 Then
                Me.DgvCuentas.Rows.Clear()
                RellenarGridCuentas(Pr.CuentaContable2)
            End If
            If Me.CmbProveedor.SelectedValue > 0 Then
                Me.DgvRecepciones.Rows.Clear()
                'Me.DgvCuentas.Rows.Clear()
                If chkServicio.Checked Then
                    ObtenerRecepcionesServicio()
                    Dim confi As New CN.ConfiguracionCtasCtrolColeccion
                    If confi.Obtener(24) > 0 Then
                        Me.RellenarGridCuentas(confi(0).CuentaContable)
                    Else
                        MessageBox.Show("No se ha configurado la cuenta para el IVA de Fletes." + vbNewLine + "Captúrelo desde Catálogos - Contabilidad - Cuentas de control.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    ObtenerRecepcionesCompra()
                    'RellenarGridCuentas(Pr.CuentaContable2)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtIva_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIva.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TxtTotal.Focus()
        End If
    End Sub

    Private Sub txtIva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIva.TextChanged
        If Editar = False Then
            If Not Me.TxtSubtotal.Text = "" Then
                Me.Subtotal = Me.TxtSubtotal.Text
                If Not SeAgregaronRecepciones() Then
                    Me.txtIva.Text = (((Subtotal * ConfigCont.Iva) / 100)).ToString("C2")
                End If
                If Not Me.txtIva.Text = "" Then
                    Me.TxtTotal.Text = (Subtotal + CDec(Me.txtIva.Text)).ToString("C2")
                Else
                    Me.TxtTotal.Text = Me.TxtSubtotal.Text
                End If
                If Not Me.TxtAnticipo.Text = "" Then
                    Me.TxtTotal.Text = ((Subtotal + CDec(Me.txtIva.Text)).ToString("C2") - CDec(Me.TxtAnticipo.Text)).ToString("C2")
                End If
            Else
                Subtotal = 0
                Me.TxtTotal.Text = Subtotal.ToString("C2")
            End If
        End If
    End Sub

    Private Sub TxtAnticipo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAnticipo.TextChanged
        If Not IsNumeric(Me.TxtAnticipo.Text) Then
            MsgBox("Teclee una cantidad válida")
            Me.TxtAnticipo.Text = "0.0"
            Me.TxtAnticipo.Focus()
        Else
            If Editar = False Then
                If Not Me.TxtSubtotal.Text = "" Then
                    Me.Subtotal = Me.TxtSubtotal.Text
                    If Not SeAgregaronRecepciones() Then
                        Me.txtIva.Text = (((Subtotal * ConfigCont.Iva) / 100)).ToString("C2")
                    End If
                    If Not Me.txtIva.Text = "" Then
                        Me.TxtTotal.Text = (Subtotal + CDec(Me.txtIva.Text)).ToString("C2")
                    Else
                        Me.TxtTotal.Text = Me.TxtSubtotal.Text
                    End If
                    ' Me.TxtTotal.Text = Me.txtSubtotal.Text
                    If Not Me.TxtAnticipo.Text = "" Then
                        Me.TxtTotal.Text = ((Subtotal + CDec(Me.txtIva.Text)).ToString("C2") - CDec(Me.TxtAnticipo.Text)).ToString("C2")
                        'Me.TxtTotal.Text = (Subtotal - CDec(Me.TxtAnticipo.Text)).ToString("C2")
                    End If
                Else
                    Subtotal = 0
                    Me.TxtTotal.Text = Subtotal.ToString("C2")
                End If
            End If
        End If
    End Sub

    Private Sub chkPagada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPagada.CheckedChanged
        Me.Fact.Estatus = CN.EstatusFacturasEnum.PAGADA
    End Sub

    Private Sub DgvRecepciones_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvRecepciones.CellContentClick
        If e.ColumnIndex = Me.Agregar.Index Then
            If CBool(Me.DgvRecepciones.Rows(e.RowIndex).Cells("Agregar").Value) Then
                Me.DgvRecepciones.Rows(e.RowIndex).Cells("Agregar").Value = False
                'Exit Sub
            Else
                Me.DgvRecepciones.Rows(e.RowIndex).Cells("Agregar").Value = True

            End If
            'Re = New Integralab.ORM.EntityClasses.RecepcionesNewEntity
            Me.Subtotal = 0
            For i As Integer = 0 To Me.DgvRecepciones.Rows.Count - 1
                If CBool(Me.DgvRecepciones.Rows(i).Cells("Agregar").Value) Then
                    '  If Re.FetchUsingPK(Controlador.Sesion.Empndx, Me.DgvRecepciones.Rows(i).Cells("Folio").Value) Then
                    If Editar = False Then
                        'Dim total As Decimal
                        'Total = Re.Precio * Re.Cantidad
                        Subtotal = Subtotal + Me.DgvRecepciones.Rows(i).Cells("Importe").Value
                        'Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = Subtotal
                    End If
                    'End If
                End If
            Next
            If Subtotal = 0 Then
                Me.TxtSubtotal.Enabled = True
                Me.txtIva.Enabled = True
                Me.TxtTotal.Enabled = True
            Else
                Me.TxtSubtotal.Enabled = False
                Me.txtIva.Enabled = False
                Me.TxtTotal.Enabled = False
            End If
            If Editar = False Then
                If TxtSubtotal.Text = "" Then
                    Me.TxtSubtotal.Text = Subtotal.ToString("C2")
                End If

            End If
        End If
    End Sub

    Private Sub DgvRecepciones_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvRecepciones.CellEndEdit

    End Sub

    Private Sub DtpFechaFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtpFechaFactura.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                If Trim(Me.txtDiasPlazo.Text) <> "" Then
                    Me.DtpFechaVencimiento.Value = Me.DtpFechaFactura.Value.AddDays(CInt(Me.txtDiasPlazo.Text))
                End If
                Me.txtConcepto.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Erro al intentar sumar los dias de plazo a la fecha de factura", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    'Con este control se controla qe el usuario cuando tarda 1 segundo sin teclear permite filtrar 
    Private Sub TmProveedor_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TmProveedor.Tick
        Try
            If Me.UltimaTeclaProveedor.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
                Me.TmProveedor.Stop()
                Proveedores.Obtener(False, Me.CmbProveedor.Text.Trim, ClasesNegocio.CondicionEnum.ACTIVOS)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TxtSubtotal_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSubtotal.KeyPress
        If e.KeyChar = Chr(13) Then
            If Not Me.TxtSubtotal.Text = "" Then
                Me.TxtSubtotal.Text = (CDec(Me.TxtSubtotal.Text)).ToString("C2")
                Me.txtIva.Focus()
            End If
        End If
    End Sub

    Private Sub TxtSubtotal_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSubtotal.TextChanged
        If Not IsNumeric(Me.TxtSubtotal.Text) Then
            MsgBox("Teclee una cantidad válida")
            Me.TxtSubtotal.Text = "0.0"
            Me.TxtSubtotal.Focus()
        Else
            If Editar = False Then
                If Not Me.TxtSubtotal.Text = "" Then
                    Me.Subtotal = Me.TxtSubtotal.Text
                    If Not SeAgregaronRecepciones() Then
                        Me.txtIva.Text = (((Subtotal * ConfigCont.Iva) / 100)).ToString("C2")
                    End If
                    If Not Me.txtIva.Text = "" Then
                        Me.TxtTotal.Text = ((Subtotal + CDec(Me.txtIva.Text)).ToString("C2"))
                    Else
                        Me.TxtTotal.Text = Me.TxtSubtotal.Text
                    End If
                    ' Me.TxtTotal.Text = Me.txtSubtotal.Text
                    If Not Me.TxtAnticipo.Text = "" Then
                        Me.TxtTotal.Text = ((Subtotal + CDec(Me.txtIva.Text)).ToString("C2") - CDec(Me.TxtAnticipo.Text)).ToString("C2")
                        'Me.TxtTotal.Text = (Subtotal - CDec(Me.TxtAnticipo.Text)).ToString("C2")
                    End If
                Else
                    Subtotal = 0
                    Me.TxtTotal.Text = Subtotal.ToString("C2")
                    'Me.txtIva.Text = (((Subtotal * Me.Fact.TasaIva) / 100)).ToString("C2")
                End If
            End If
        End If

    End Sub

    Private Sub chkServicio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkServicio.CheckedChanged
        Try
            If chkServicio.Checked Then
                ObtenerRecepcionesServicio()
                Dim confi As New CN.ConfiguracionCtasCtrolColeccion
                If confi.Obtener(24) > 0 Then
                    Me.RellenarGridCuentas(confi(0).CuentaContable)
                Else
                    MessageBox.Show("No se ha configurado la cuenta para el IVA de Fletes." + vbNewLine + "Captúrelo desde Catálogos - Contabilidad - Cuentas de control.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ObtenerRecepcionesCompra()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvCuentas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCuentas.CellEndEdit
        If e.ColumnIndex = Me.ClmCargo.Index Then
            If Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString = "" Then
                Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0.ToString("C2")
            Else
                If Not IsNumeric(Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                    MsgBox("Teclee una Cantidad Correcta", MsgBoxStyle.Exclamation, "Error")
                    Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0.ToString("C2")
                Else
                    Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDec(Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value).ToString("C2")
                End If
            End If
        End If
    End Sub

    Private Sub DgvCuentas_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCuentas.CellValueChanged
        Dim SumaCargo As Decimal = 0
        Dim SumaAbono As Decimal = 0
        'If e.ColumnIndex = Me.ClmCargo.Index Then
        '    For i As Integer = 0 To Me.DgvCuentas.Rows.Count - 1
        '        Tot += Decimal.Parse(Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value.ToString)
        '    Next
        '    Me.txtSumaCargo.Text = Tot.ToString("C2")
        'End If
        For i As Integer = 0 To Me.DgvCuentas.Rows.Count - 1
            SumaCargo = SumaCargo + Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value
            SumaAbono = SumaAbono + Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value
        Next
        Me.txtSumaCargo.Text = SumaCargo.ToString("C2")
        Me.TxtSumaAbono.Text = SumaAbono.ToString("C2")
    End Sub

    Private Sub DgvCuentas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DgvCuentas.KeyDown
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

    Private Sub DtpFechaFactura_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DtpFechaFactura.Validating

    End Sub

    Private Sub DtpFechaFactura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpFechaFactura.ValueChanged
        Try

            If Trim(Me.txtDiasPlazo.Text) <> "" Then
                Me.DtpFechaVencimiento.Value = Me.DtpFechaFactura.Value.AddDays(CInt(Me.txtDiasPlazo.Text))
            End If

        Catch ex As Exception
            MessageBox.Show("Erro al intentar sumar los dias de plazo a la fecha de factura", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtConcepto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConcepto.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtObservaciones.Focus()
        End If
    End Sub

    Private Sub txtObservaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtObservaciones.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TxtSubtotal.Focus()
        End If
    End Sub

    Private Sub txtObservaciones_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObservaciones.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TxtFactura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFactura.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class