Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports System.Xml
Imports System.IO
Imports System.Data.SqlClient

Public Class RecepcionFacturasForm

    Private Proveedores As New ClasesNegocio.ProveedorCollectionClass
    Private CXP As New ClasesNegocio.FacturasCXP
    Private RecepSer As IntegraLab.ORM.CollectionClasses.OrdenServicioCollection
    Private Recepciones As IntegraLab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
    Private Fact As New IntegraLab.ORM.EntityClasses.UsrCxpfacturasCabEntity
    Private FactDet As IntegraLab.ORM.CollectionClasses.UsrCxpfacturasDetCollection
    Private FactDetRecep As IntegraLab.ORM.CollectionClasses.UsrCxpfacturasDetRecepcionesCollection


    Dim Total As Decimal
    Dim Subtotal As Decimal
    Dim TotalAux As Decimal 'Se usa para comparar el total de cargos y abonos para el total de facturas
    Dim IVAA As Decimal
    Dim NoFactura As String
    Dim FechaFactura As Date
    Dim Observaciones As String
    'Dim Re As IntegraLab.ORM.EntityClasses.RecepcionesNewEntity
    Dim Editar As Boolean = False
    Dim UltimaTeclaProveedor As DateTime
    Dim SelProveedor As Boolean
    Dim ConfigCont As EC.UsrConfigContabilidadEntity

    Dim Carpeta As String = "XML"
    Dim NombreDelFichero As String = "RecepcionFacturas"

    Dim formato As String = "C4"

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
            Me.mtb.Buttons(3).ToolTipText = "Cancela la acci�n actual."
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
                MessageBox.Show("No se han configurado los par�metros de contabilidad." + vbNewLine + "Capturelos desde Cat�logos - Contabilidad - Configuraci�n.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

#Region "M�todos"
    Public Sub Limpiar(Optional ByVal NoOmitir As Boolean = True)
        If NoOmitir = True Then
            Me.CmbProveedor.SelectedIndex = -1
            Me.CmbProveedor.Text = "Seleccione un Proveedor..."
            Me.chkTerceros.Checked = False
        End If

        Me.txtCheque.Clear()
        Me.txtPoliza.Clear()
        Me.txtDiasPlazo.Text = ""
        Me.TxtFactura.Clear()
        Me.chkPagada.Checked = False
        'Me.ChkAgregarRecepciones.Checked = False
        Me.TxtSubtotal.Text = ""
        Me.txtIva.Text = ""
        Me.TxtAnticipo.Text = ""
        Me.TxtTotal.Text = ""
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
        ' Me.txtTasaIVA.Text = ""
        Me.ckbFlete.Checked = False
        Me.ckbHonorarios.Checked = False
        Me.txtISR.Text = ""
        Me.txtRetIVA.Text = ""
        Me.txtIVAFlete1.Text = ""
        Me.txtIVAFlete.Text = ""
        Me.txtTasaRetIVA.Text = ""
        Me.txtTasaISR.Text = ""
        Me.dgvDistribuciondeGastos.Rows.Clear()
        Me.dgvdistribuciongastosdet.Rows.Clear()
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


        'Me.TxtSubtotal.Enabled = True
        Me.txtIva.Enabled = True
        Me.TxtAnticipo.Enabled = True
        'Me.txtISR.Enabled = True
        'Me.txtRetIVA.Enabled = True
        'Me.txtIVAFlete1.Enabled = True


        'Me.TxtTotal.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.txtConcepto.Enabled = True
        Me.DgvRecepciones.Enabled = True
        Me.chkServicio.Enabled = True
        Me.DgvCuentas.Enabled = True
        'Me.txtTasaIVA.Text = ""
        Me.ckbFlete.Enabled = True
        Me.ckbHonorarios.Enabled = True

        Me.MtxtUUID.Enabled = True

        Me.chkTerceros.Enabled = True
        'Me.txtTasaIVA.Enabled = True
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
        Me.TxtSubtotal.Enabled = False
        Me.txtIva.Enabled = False
        Me.TxtAnticipo.Enabled = False
        Me.TxtTotal.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.txtConcepto.Enabled = False
        Me.DgvRecepciones.Enabled = False
        Me.chkServicio.Enabled = False
        Me.DgvCuentas.Enabled = True
        Me.ckbFlete.Enabled = False
        Me.ckbHonorarios.Enabled = False
        Me.txtISR.Enabled = False
        Me.txtRetIVA.Enabled = False
        Me.txtIVAFlete1.Enabled = False
        Me.MtxtUUID.Enabled = False

        Me.chkTerceros.Enabled = False
        ' Me.txtTasaIVA.Enabled = False
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
        'If Me.txtTasaISR.Text > 0 Then
        '    Fact.TasaIsr = Me.txtTasaISR.Text
        'Else
        '    Fact.TasaIsr = 0.ToString(formato)
        'End If
        ''Fact.TasaIva = Me.
        'If Me.txtTasaRetIVA.Text > 0 Then
        '    Fact.TasaRetIva = Me.txtTasaRetIVA.Text
        'Else
        '    Fact.TasaRetIva = 0.ToString(formato)
        'End If

        If Me.TxtSubtotal.Text = "" Then
            Fact.SubTotal = 0
        Else
            Fact.SubTotal = Me.TxtSubtotal.Text
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
        Fact.Uuid = Me.MtxtUUID.Text
        'Fact.TasaIva = Me.txtTasaIVA.Text
        If ckbHonorarios.Checked = True Then
            Fact.ImporteIsr = Me.txtISR.Text
            Fact.ImporteRetIva = Me.txtRetIVA.Text
        Else
            Fact.ImporteIsr = 0.ToString(formato)
            Fact.ImporteRetIva = 0.ToString(formato)
        End If
        If ckbFlete.Checked = True Then
            Fact.Ivaflete = Me.txtIVAFlete1.Text
        Else
            Fact.Ivaflete = 0.ToString(formato)
        End If

        If ckbHonorarios.Checked = True Then
            Me.Fact.TasaIsr = Me.txtTasaISR.Text
            Me.Fact.TasaRetIva = Me.txtTasaRetIVA.Text
        End If
        If ckbFlete.Checked = True Then
            Me.Fact.Ivaflete = Me.txtIVAFlete1.Text
        End If

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
        Me.MtxtUUID.Text = Me.Fact.Uuid
    End Sub

    Public Function Validar() As Boolean
        If Me.Fact.IsNew Then
            If Me.TxtFactura.Text = "" Then
                MsgBox("El campo Folio Factura es obligatorio...", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            Else
                Dim Facturas As New IntegraLab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
                Facturas.GetMulti(IntegraLab.ORM.HelperClasses.UsrCxpfacturasCabFields.NoFactura = Me.TxtFactura.Text And IntegraLab.ORM.HelperClasses.UsrCxpfacturasCabFields.IdProveedor = Me.CmbProveedor.SelectedValue And IntegraLab.ORM.HelperClasses.UsrCxpfacturasCabFields.Estatus <> CN.EstatusFacturasEnum.CANCELADA)
                If Facturas.Count > 0 Then
                    MsgBox("El n�mero de Factura ya fue registrado, ingrese otro...")
                    Me.TxtFactura.Focus()
                    Return False
                End If
            End If
        End If
        If Me.TxtSubtotal.Text = "" Then
            MsgBox("No puede hacer una factura por $0.00")
            Return False
        End If
        'Dorantes: comente este codigo, estaba redundante
        'If Me.Fact.IsNew Then
        '    Dim facts As New IntegraLab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
        '    Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
        '    filtro.Add(IntegraLab.ORM.HelperClasses.UsrCxpfacturasCabFields.NoFactura = Me.TxtFactura.Text)
        '    'filtro.Add(IntegraLab.ORM.HelperClasses.UsrCxpfacturasCabFields.Estatus <> CN.EstatusFacturasEnum.CANCELADA)
        '    filtro.Add(IntegraLab.ORM.HelperClasses.UsrCxpfacturasCabFields.IdProveedor = Me.CmbProveedor.SelectedValue)
        '    facts.GetMulti(filtro)
        '    If facts.Count > 0 Then
        '        MsgBox("La Factura ya fue Registrada...", MsgBoxStyle.Exclamation, "Aviso")
        '        Return False
        '    End If
        'End If
        If Me.DgvCuentas.Rows.Count <= 1 Then
            MsgBox("No ha relacionado las Cuentas Contables a Afectar.", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End If
        If Not CDec(Me.TxtSumaAbono.Text) = CDec(Me.txtSumaCargo.Text) Then
            MsgBox("Las Sumas del Cargo y del Abono deben ser Equivalentes", MsgBoxStyle.Exclamation, "Aviso")
            Return False
            'ElseIf Not CDec(Me.TxtSumaAbono.Text) = CDec(Me.TxtTotal.Text) Then
        ElseIf Not CDec(Me.TxtSumaAbono.Text) = calcularSubtotal() Then

            MsgBox("El importe de las Sumas de Cargos y Abonos debe ser Igual al Importe Total...", , "Aviso")
            Return False
        End If
        'If Me.txtSumaCargo.Text <> Me.TxtTotal.Text Then
        If Me.txtSumaCargo.Text <> calcularSubtotal() Then
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

    Function ObtenerComprasTerceros() As Boolean
        Try
            If CmbProveedor.SelectedIndex = -1 Then
                MessageBox.Show("Antes debe seleccionar un proveedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            Dim Proveedor As ClasesNegocio.ProveedorClass = Me.CmbProveedor.SelectedItem
            Me.txtDiasPlazo.Text = Proveedor.DiasCredito.ToString


            Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)

            Dim query = "EXEC Usp_MSCLoteCorteTercerosCon 1, {0}, '{1}'"
            query = String.Format(query, Me.CmbProveedor.SelectedValue, String.Empty)

            Dim sqlcom As SqlCommand = New SqlCommand(query, sqlCon)
            Dim adp As New SqlDataAdapter(sqlcom)
            Dim tb As New DataTable
            adp.Fill(tb)
            'tb.Select()

            DgvRecepciones.DataSource = tb

        Catch ex As Exception

        End Try
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
                            Me.DgvRecepciones.Rows(i).Cells("IdRecepcionOrdenCompra").Value = Recep(i).IdRecepcionOrdenCompra
                            Me.DgvRecepciones.Rows(i).Cells("IVA").Value = Recep(i).IVA.ToString(formato)
                            Me.DgvRecepciones.Rows(i).Cells("FechaRecepcion").Value = Recep(i).FechaRecepcion
                            Me.DgvRecepciones.Rows(i).Cells("FolioOrden").Value = Recep(i).OrdenCompra.FolioOrdenCompra
                            Me.DgvRecepciones.Rows(i).Cells("CantidadProducto").Value = Recep(i).Cantidad
                            Me.DgvRecepciones.Rows(i).Cells("Importe").Value = Recep(i).Total.ToString(formato)
                            Me.DgvRecepciones.Rows(i).Cells("Precio").Value = Recep(i).SubTotal.ToString(formato)
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
                        Me.DgvRecepciones.Rows(i).Cells("Importe").Value = RecepServicio(i).Total.ToString(formato)
                    Next
                End If
            End If
        End If
    End Sub

    Public Function xmlRead(Tipo As String, nombre As String) As String
        Try

            Dim ficheroXML As String = Path.Combine(Carpeta, NombreDelFichero)
            'ficheroXML = Server.MapPath("Divide.xml")
            Dim doc As Xml.XmlDocument = New XmlDocument()
            If File.Exists(ficheroXML) Then
                doc.Load(ficheroXML)
            End If

            ' Lectura del nodo principal
            Dim nodoPrincipal As Xml.XmlNode = doc.SelectSingleNode(Carpeta)
            Dim nodoActual As Xml.XmlNode = nodoPrincipal.SelectSingleNode(Tipo + "s")
            Dim valor As Xml.XmlNode = nodoActual.SelectSingleNode(Tipo + "[@Name= '" + nombre + "']")

            'Dim valor As Xml.XmlNode = NodoActualHijo.SelectSingleNode(nombre + "[@type='M']")

            Return Convert.ToString(valor)
        Catch ex As Exception

            Return ""

        End Try
    End Function

    Private Function CuentasRepetidas(ByVal cta As CN.CuentaContableClass, Optional ByVal eliminarRow As Boolean = False) As Boolean
        Try
            For i As Integer = 0 To Me.DgvCuentas.Rows.Count - 1
                If cta.NombreCuenta = Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value Then
                    If (eliminarRow) Then
                        Me.DgvCuentas.Rows.Remove(Me.DgvCuentas.Rows(i))
                    End If
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
                            Me.DgvCuentas.Rows(i).Cells("clmidcuentacont").Value = Cta.Codigo
                            Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                            Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = Cta.SubCuenta
                            Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                            Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                            Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                            Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = 0
                            Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = 0
                            Me.DgvCuentas.Rows.Add()
                        Else
                            Me.DgvCuentas.Rows(i - 1).Cells("clmidcuentacont").Value = Cta.Codigo
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
                        Me.DgvCuentas.Rows(i).Cells("clmidcuentacont").Value = Cta.Codigo
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
                                New SqlClient.SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
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
        If Me.Fact.Estatus = CN.EstatusFacturasEnum.CANCELADA Then
            MsgBox("No es posible Cancelar la factura, ya est� cancelada", MsgBoxStyle.Information, "Aviso")
            Cancelar = True
        ElseIf Me.Fact.Estatus = CN.EstatusFacturasEnum.PAGADA Or Me.Fact.Estatus = CN.EstatusFacturasEnum.ABONADA Then
            MsgBox("La Factura ya Fu� Abonada o Pagada, Imposible Cancelarla", MsgBoxStyle.Information, "Aviso")
            Cancelar = True
        ElseIf Me.Fact.Contabilizada = "S" Or Not Me.Fact.FechaContabilizacion Is Nothing Then
            MsgBox("La Factura no puede ser cancelada ya que se encuentra provisionada en una poliza de pasivos, verifique porfavor...", MsgBoxStyle.Information, "Aviso")
            Cancelar = True
        Else
            Dim Ventana As New CancelacionOrdenRetiroForm
            Ventana.Text = "Cancelaci�n de Factura"
            Ventana.lblTitulo.Text = "CANCELACI�N DE FACTURA"
            'If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
            'ojo
            Me.Fact.IdUsuarioCancelacion = Controlador.Sesion.Usrndx

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
                    Dim NumeroFactura As String = Fact.NoFactura
                    Dim ID_Proveedor As String = Fact.IdProveedor
                    Dim Success As Boolean = False
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

                            Success = True
                            'MsgBox("La Factura ha sido Cancelada...")
                            Limpiar()
                            Cancelar = False
                            Me.TxtSubtotal.Enabled = False
                            Me.txtIva.Enabled = True
                            Me.TxtTotal.Enabled = False
                        Else
                            tran.Rollback()
                            MsgBox("La Factura no pudo ser Cancelada...")
                            Me.TxtSubtotal.Enabled = False
                            Me.txtIva.Enabled = True
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
                        Success = True
                        'MsgBox("La Factura ha sido Cancelada...")
                        Limpiar()
                        Cancelar = False
                        Me.TxtSubtotal.Enabled = False
                        Me.txtIva.Enabled = True
                        Me.TxtTotal.Enabled = False
                    End If
                    'Dorantes, se eliminan prorrateo , se elimina la factura y se colocan prorrateo y factura en otras tablas para guardar historial
                    If (Success) Then
                        CXP.CancelarFactura(NumeroFactura, ID_Proveedor)
                        MsgBox("La Factura ha sido Cancelada...")
                    End If

                Else
                    tran.Rollback()
                    MsgBox("La Factura no pudo ser Cancelada...")
                    Me.TxtSubtotal.Enabled = False
                    Me.txtIva.Enabled = True
                    Me.TxtTotal.Enabled = False
                End If
            Catch ex As Exception
                tran.Rollback()
                MsgBox(ex.Message)
            End Try
            '    Else
            '    Cancelar = True
            'End If
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
                                Me.DgvRecepciones.Rows(i).Cells("Importe").Value = FacDe(i).Total.ToString(formato)
                                Me.DgvRecepciones.Rows(i).Cells("Agregar").Value = True
                                'Me.DgvRecepciones.Rows(i).Cells("CantidadProducto").Value = FacDe(i).CantidadTotalRecibida
                                'Me.DgvRecepciones.Rows(i).Cells("Importe").Value = FacDe(i).ImporteTotal.ToString(formato)
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
                                Me.DgvRecepciones.Rows(i).Cells("Importe").Value = FacDe(i).Total.ToString(formato)
                                Me.DgvRecepciones.Rows(i).Cells("Agregar").Value = True
                                'Me.DgvRecepciones.Rows(i).Cells("CantidadProducto").Value = FacDe(i).CantidadTotalRecibida
                                'Me.DgvRecepciones.Rows(i).Cells("Importe").Value = FacDe(i).ImporteTotal.ToString(formato)
                            Next
                        End If
                        Editar = True
                    End If
                End If

                Dim FacturasDetalle As New CC.UsrCxpfacturasDetCollection
                FacturasDetalle.GetMulti(HC.UsrCxpfacturasDetFields.EmpresaId = Controlador.Sesion.Empndx And HC.UsrCxpfacturasDetFields.IdProveedor = Me.CmbProveedor.SelectedValue And HC.UsrCxpfacturasDetFields.NoFactura = Me.TxtFactura.Text And (HC.UsrCxpfacturasDetFields.CarAbo = "C" Or HC.UsrCxpfacturasDetFields.CarAbo = "A"))

                If FacturasDetalle.Count = 0 Then
                    MessageBox.Show("Esta factura no tienes cuentas contables asociadas", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim CuentasCont As ClasesNegocio.CuentaContableClass
                    For Each FacDetalle As EC.UsrCxpfacturasDetEntity In FacturasDetalle
                        CuentasCont = New ClasesNegocio.CuentaContableClass(FacDetalle.CuentaContable)
                        'RellenarGridCuentas(CuentasCont)
                        If FacDetalle.CarAbo = "C" Then
                            Me.RellenarGridCuentasB(CuentasCont, FacDetalle.Importe, True)
                        Else
                            Me.RellenarGridCuentasB(CuentasCont, FacDetalle.Importe, False)
                        End If
                    Next
                End If

                Me.lblEstatus.Visible = True
                Me.TxtSubtotal.Enabled = False
                Me.txtIva.Enabled = True
                Me.TxtTotal.Enabled = False
                Total = Me.Fact.Total
            Else
                Try
                    buscarcanceladas(Busqueda.Ifacturacancelada)
                    Me.lblEstatus.Visible = True
                    Me.TxtSubtotal.Enabled = False
                    Me.txtIva.Enabled = True
                    Me.TxtTotal.Enabled = False
                    Total = Me.Fact.Total
                Catch ex As Exception

                End Try
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
            MsgBox("La factura ya est� Pagada no puede Editarla")
            Cancelar = True
        Else
            If Me.Fact.Estatus = CN.EstatusFacturasEnum.CANCELADA Then
                MsgBox("La factura ya est� Cancelada no puede Editarla")
                Cancelar = True
            Else
                If Me.Fact.UsrCxpfacturasDetRecepciones.Count > 0 Then
                    MsgBox("La Factura no puede ser editada...")
                    Cancelar = True
                Else
                    Habilitar()
                    Me.DgvRecepciones.Enabled = False
                    Me.CmbProveedor.Enabled = False
                    Me.TxtAnticipo.Enabled = True
                    Me.TxtSubtotal.Enabled = True
                    Me.txtIva.Enabled = True
                    Me.TxtTotal.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim tran As New IntegraLab.ORM.HelperClasses.Transaction(IsolationLevel.ReadCommitted, "Fac")
        If Me.chkTerceros.Checked And Me.TxtFactura.Text = String.Empty Then
            MessageBox.Show("Debe de seleccionar una compra", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
            Return
        End If

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
                    For Each Det As Integralab.ORM.EntityClasses.UsrCxpfacturasDetRecepcionesEntity In FactDetRecep
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
                                        If guardarprorrate(Fact) Then

                                        End If
                                        MsgBox("La Recepci�n de Factura ha sido guardada satisfactoriamente...")
                                        Limpiar()
                                        Deshabilitar()
                                        Cancelar = False
                                    End If
                                Else
                                    tran.Rollback()
                                    MsgBox("La Recepci�n de factura NO pudo ser Guardada...")
                                    Cancelar = True
                                End If
                            Else
                                tran.Commit()
                                If guardarprorrate(Fact) Then

                                End If
                                MsgBox("La Recepci�n de Factura ha sido guardada satisfactoriamente...")
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
                                        If guardarprorrate(Fact) Then

                                        End If
                                        MsgBox("La Recepci�n de Factura ha sido guardada satisfactoriamente...")
                                        Limpiar()
                                        Deshabilitar()
                                        Cancelar = False
                                    End If
                                Else
                                    tran.Rollback()
                                    MsgBox("La Recepci�n de factura NO pudo ser Guardada...")
                                    Cancelar = True
                                End If
                            Else
                                tran.Commit()
                                If guardarprorrate(Fact) Then

                                End If
                                MsgBox("La Recepci�n de Factura ha sido guardada satisfactoriamente...")
                                Limpiar()
                                Deshabilitar()
                                Cancelar = False
                            End If
                        End If
                    Else
                        tran.Commit()
                        If guardarprorrate(Fact) Then

                        End If
                        MsgBox("La Recepci�n de Factura ha sido guardada satisfactoriamente...")
                        Limpiar()
                        Deshabilitar()
                        Cancelar = False
                    End If

                Else
                    tran.Rollback()
                    MsgBox("La Recepci�n de factura NO pudo ser Guardada...")
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
                MsgBox("Agregue Informaci�n a el No. de Factura. . . ")
                TxtFactura.Focus()
            Else
                Dim facturas As New IntegraLab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
                Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
                filtro.Add(IntegraLab.ORM.HelperClasses.UsrCxpfacturasCabFields.NoFactura = Me.TxtFactura.Text)
                filtro.Add(IntegraLab.ORM.HelperClasses.UsrCxpfacturasCabFields.IdProveedor = Me.CmbProveedor.SelectedValue)
                facturas.GetMulti(filtro)
                If facturas.Count > 0 Then
                    MsgBox("El n�mero de Factura ya fue registrado...")
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

    Function refreshInfo() As Boolean
        If CmbProveedor.SelectedValue Is Nothing Then
            Return False
        End If
        Try
            If SelProveedor = False Then
                Exit Function
            End If
            Dim Prov As New CN.ProveedorCollectionClass
            Dim Pr As CN.ProveedorClass = Prov.Obtener(Me.CmbProveedor.SelectedValue)

            If Me.CmbProveedor.SelectedValue > 0 Then
                'Limpiar Grid Cuentas Contablees y lo llenamos 
                Me.DgvCuentas.Rows.Clear()
                RellenarGridCuentas(Pr.CuentaContable2)

                'Limpiar GridRecepciones y procedemos a llenarlo
                'Me.DgvRecepciones.Rows.Clear()
                Me.DgvRecepciones.DataSource = Nothing
                If Me.chkTerceros.Checked Then
                    ObtenerComprasTerceros()
                Else
                    If chkServicio.Checked Then
                        ObtenerRecepcionesServicio()
                        Dim confi As New CN.ConfiguracionCtasCtrolColeccion
                        If confi.Obtener(24) > 0 Then
                            Me.RellenarGridCuentas(confi(0).CuentaContable)
                        Else
                            MessageBox.Show("No se ha configurado la cuenta para el IVA de Fletes." + vbNewLine + "Capt�relo desde Cat�logos - Contabilidad - Cuentas de control.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        ObtenerRecepcionesCompra()
                        'RellenarGridCuentas(Pr.CuentaContable2)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function


    Private Sub CmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProveedor.SelectedIndexChanged
        Me.refreshInfo()

    End Sub

    Private Sub txtIva_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIva.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TxtTotal.Focus()
        End If
    End Sub

    Private Sub txtIva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIva.TextChanged
        If Not IsNumeric(Me.txtIva.Text) Then
            Me.txtIva.Text = 0.ToString(formato)
            Me.txtIva.Focus()
        Else
            If Editar = False Then
                If Not Me.TxtSubtotal.Text = "" Then
                    Me.Subtotal = Me.TxtSubtotal.Text
                    If Not SeAgregaronRecepciones() Then
                        Me.txtIva.Text = CDec(((Subtotal * ConfigCont.Iva) / 100)).ToString(formato)
                    End If
                    If Not Me.txtIva.Text = "" Then
                        Me.TxtTotal.Text = CDec(Subtotal + CDec(Me.txtIva.Text)).ToString(formato)
                    Else
                        Me.TxtTotal.Text = Me.TxtSubtotal.Text
                    End If
                    If Not Me.TxtAnticipo.Text = "" Then
                        Me.TxtTotal.Text = CDec((Subtotal + CDec(Me.txtIva.Text)) - CDec(Me.TxtAnticipo.Text)).ToString(formato)
                    End If
                Else
                    Subtotal = 0
                    Me.TxtTotal.Text = Subtotal.ToString(formato)
                End If
            End If
        End If
    End Sub

    Private Sub TxtAnticipo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAnticipo.TextChanged
        'If Not IsNumeric(Me.TxtAnticipo.Text) Then
        '    'MsgBox("Teclee una cantidad v�lida")
        '    Me.TxtAnticipo.Text = "0.0"
        '    Me.TxtAnticipo.Focus()
        'Else
        '    Calcular()
        '    'If Editar = False Then
        '    '    If Not Me.TxtSubtotal.Text = "" Then
        '    '        Me.Subtotal = Me.TxtSubtotal.Text
        '    '        If Not SeAgregaronRecepciones() Then
        '    '            Me.txtIva.Text = (((Subtotal * ConfigCont.Iva) / 100)).ToString(formato)
        '    '        End If
        '    '        If Not Me.txtIva.Text = "" Then
        '    '            Me.TxtTotal.Text = (Subtotal + CDec(Me.txtIva.Text)).ToString(formato)
        '    '        Else
        '    '            Me.TxtTotal.Text = Me.TxtSubtotal.Text
        '    '        End If
        '    '        ' Me.TxtTotal.Text = Me.txtSubtotal.Text
        '    '        If Not Me.TxtAnticipo.Text = "" Then
        '    '            Me.TxtTotal.Text = ((Subtotal + CDec(Me.txtIva.Text)).ToString(formato) - CDec(Me.TxtAnticipo.Text)).ToString(formato)
        '    '            'Me.TxtTotal.Text = (Subtotal - CDec(Me.TxtAnticipo.Text)).ToString(formato)
        '    '        End If
        '    '    Else
        '    '        Subtotal = 0
        '    '        Me.TxtTotal.Text = Subtotal.ToString(formato)
        '    '    End If
        '    'End If
        'End If
    End Sub

    Private Sub chkPagada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPagada.CheckedChanged
        Me.Fact.Estatus = CN.EstatusFacturasEnum.PAGADA
    End Sub

    Public Function calcularTotales() As Boolean

        Me.Subtotal = 0
        Me.IVAA = 0
        For i As Integer = 0 To Me.DgvRecepciones.Rows.Count - 1
            If CBool(Me.DgvRecepciones.Rows(i).Cells("Agregar").Value) Then
                Subtotal = Subtotal + Me.DgvRecepciones.Rows(i).Cells("Precio").Value
                IVAA = IVAA + Me.DgvRecepciones.Rows(i).Cells("IVA").Value
            End If

        Next
        'If Editar = False Then
        If Me.chkTerceros.Checked Then
            Me.TxtFactura.Text = Me.NoFactura
            Me.DtpFechaFactura.Value = Me.FechaFactura
            Me.txtObservaciones.Text = Me.Observaciones
        End If

        Me.TxtSubtotal.Text = Subtotal.ToString(formato)
        Me.txtIva.Text = IVAA.ToString(formato)
        Me.txtISR.Text = 0.ToString(formato)
        Me.txtIVAFlete1.Text = 0.ToString(formato)
        Me.txtRetIVA.Text = 0.ToString(formato)

        'End If
    End Function

    Public Sub Calcular(Optional ByVal ignorarFlete As Boolean = False)
        'calcularHonorarios()
        calcularTotales()
        calcularFlete(ignorarFlete)
        calcularSubtotal()
    End Sub

    Private Sub DgvRecepciones_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvRecepciones.CellContentClick
        Try
            If e.ColumnIndex = Me.Agregar.Index Then
                If CBool(Me.DgvRecepciones.Rows(e.RowIndex).Cells("Agregar").Value) Then
                    Me.DgvRecepciones.Rows(e.RowIndex).Cells("Agregar").Value = False
                    'Exit Sub
                Else
                    Me.DgvRecepciones.Rows(e.RowIndex).Cells("Agregar").Value = True

                End If

                Calcular(True)

                'Re = New Integralab.ORM.EntityClasses.RecepcionesNewEntity

            End If
        Catch ex As Exception

        End Try

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
                Me.TxtSubtotal.Text = (CDec(Me.TxtSubtotal.Text)).ToString(formato)
                Me.txtIva.Focus()
            End If
        End If
    End Sub

    Public Function calcularSubtotal() As Decimal

        Me.Subtotal = If(String.IsNullOrEmpty(Me.TxtSubtotal.Text), 0, Me.TxtSubtotal.Text)
        Me.TotalAux = 0D
        Dim IVAFlete As Decimal = 0D
        Dim ISRInt As Decimal = 0D
        Dim RetIVAInt As Decimal = 0D
        Dim IVA As Decimal = 0D
        Dim Anticipo As Decimal = If(String.IsNullOrEmpty(Me.TxtAnticipo.Text), 0, Me.TxtAnticipo.Text)

        'Dim AnticipoInt As Decimal = CDec(If(String.IsNullOrEmpty(TxtAnticipo.Text), 0, TxtAnticipo.Text))
        If Not IsNumeric(Me.TxtSubtotal.Text) Then
            'MsgBox("Teclee una cantidad v�lida")
            Me.TxtSubtotal.Text = ""
            Me.TxtSubtotal.Focus()
        Else
            If Editar = False Then
                If Not Me.TxtSubtotal.Text = "" Then
                    If ckbHonorarios.Checked = True Then
                        Label22.Visible = True
                        txtTasaISR.Visible = True
                        Label23.Visible = True
                        txtTasaRetIVA.Visible = True
                        'ckbFlete.Checked = False
                        Dim Conf As New CC.UsrConfigContabilidadCollection
                        Conf.GetMulti(Nothing)

                        Me.txtTasaISR.Text = 0
                        Me.txtTasaRetIVA.Text = 0

                        Me.txtTasaISR.Text = CDec(Conf(0).Isr).ToString("N2")
                        Me.txtTasaRetIVA.Text = CDec(Conf(0).TasaRetencion).ToString("N2")

                        Dim TasaISR As Decimal = If(String.IsNullOrEmpty(Me.txtTasaISR.Text), 0, Me.txtTasaISR.Text)
                        Dim TasaRetIVA As Decimal = If(String.IsNullOrEmpty(Me.txtTasaRetIVA.Text), 0, Me.txtTasaRetIVA.Text)
                        'Mee
                        ISRInt = ((Me.Subtotal * TasaISR) / 100).ToString(formato)
                        RetIVAInt = ((Me.Subtotal * TasaRetIVA) / 100).ToString(formato)

                        Me.txtISR.Text = ISRInt.ToString(formato)
                        Me.txtRetIVA.Text = RetIVAInt.ToString(formato)

                    Else
                        Label22.Visible = False
                        txtTasaISR.Visible = False
                        Label23.Visible = False
                        txtTasaRetIVA.Visible = False
                        txtTasaISR.Text = 0.ToString(formato)
                        txtTasaRetIVA.Text = 0.ToString(formato)
                    End If

                    If (ckbFlete.Checked) Then
                        IVAFlete = CDec(If(String.IsNullOrEmpty(Me.txtIVAFlete1.Text), 0, Me.txtIVAFlete1.Text))
                    End If
                    IVA = CDec(If(String.IsNullOrEmpty(Me.txtIva.Text), 0, Me.txtIva.Text))
                    If Not SeAgregaronRecepciones() Then
                        Me.txtIva.Text = CDec(((Subtotal * ConfigCont.Iva) / 100)).ToString(formato)
                        IVA = CDec(((Subtotal * ConfigCont.Iva) / 100)).ToString(formato)
                    End If
                    Me.TotalAux = (Subtotal + IVA)
                    Me.Subtotal = (Subtotal + IVA) - (ISRInt + RetIVAInt + IVAFlete + Anticipo)

                    Me.TxtTotal.Text = Subtotal.ToString(formato)

                    'If Not Me.txtIva.Text = "" Then
                    '    Me.TxtTotal.Text = CDec(Subtotal + CDec(Me.txtIva.Text)).ToString(formato)
                    'Else
                    '    Me.TxtTotal.Text = Me.Subtotal.ToString(formato)
                    'End If
                    'If Not Me.TxtAnticipo.Text = "" Then
                    '    Me.TxtTotal.Text = ((Subtotal).ToString(formato) - CDec(Me.TxtAnticipo.Text)).ToString(formato)
                    'End If
                    'If Not Me.txtISR.Text = "" And Me.txtRetIVA.Text = "" Then
                    '    Me.TxtTotal.Text = (((Subtotal + CDec(Me.txtIva.Text)) - (CDec(Me.txtISR.Text) + CDec(Me.txtRetIVA.Text))).ToString(formato) - CDec(Me.TxtAnticipo.Text)).ToString(formato)
                    '    'Me.TxtTotal.Text = (Subtotal - CDec(Me.TxtAnticipo.Text)).ToString(formato)
                    'End If
                    'If Not Me.txtIVAFlete1.Text = "" Then
                    '    Me.TxtTotal.Text = ((Subtotal + CDec(Me.txtIva.Text)) - CDec(Me.txtIVAFlete1.Text).ToString(formato) - CDec(Me.TxtAnticipo.Text)).ToString(formato)
                    '    'Me.TxtTotal.Text = (Subtotal - CDec(Me.TxtAnticipo.Text)).ToString(formato)
                    'End If
                Else
                    Subtotal = 0
                    TotalAux = 0
                    Me.TxtTotal.Text = Subtotal.ToString(formato)
                    'Me.txtIva.Text = (((Subtotal * Me.Fact.TasaIva) / 100)).ToString(formato)
                End If
            End If
        End If

        Return Me.TotalAux
    End Function

    Private Sub TxtSubtotal_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSubtotal.TextChanged
        'Me.calcularSubtotal()

    End Sub

    Private Sub chkServicio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkServicio.CheckedChanged
        Try
            If chkServicio.Checked Then
                ObtenerRecepcionesServicio()
                Dim confi As New CN.ConfiguracionCtasCtrolColeccion
                If confi.Obtener(24) > 0 Then
                    Me.RellenarGridCuentas(confi(0).CuentaContable)
                Else
                    MessageBox.Show("No se ha configurado la cuenta para el IVA de Fletes." + vbNewLine + "Capt�relo desde Cat�logos - Contabilidad - Cuentas de control.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    chkServicio.Checked = False
                End If
            Else
                ObtenerRecepcionesCompra()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvCuentas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCuentas.CellEndEdit
        Try

            ''------------------------------------------------------------------------------------------------------------------------------------------
            ''------------------------------------------------------------------------------------------------------------------------------------------

            ''------------------------------------------------------------
            Dim ren As Integer = 0
            Dim rendet As Integer = 0
            ''------------------------------------------------------------

            Select Case e.ColumnIndex
                Case Me.ClmCargo.Index
                    Dim Cuenta As New CN.CuentaContableClass
                    Cuenta.Obtener(Me.DgvCuentas.CurrentRow.Cells(Me.clmidcuentacont.Index).Value)
                    If Cuenta.Departamentalizable = Integra.Clases.SiNoEnum.SI Then

                        Dim Ventana As New frmDistribuciondeGastos
                        frmDistribuciondeGastos.valor = Me.DgvCuentas.CurrentRow.Cells(Me.ClmCargo.Index).Value()
                        If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then

                            Me.dgvDistribuciondeGastos.AutoGenerateColumns = False

                            If (dgvDistribuciondeGastos.Rows.Count) >= 1 Then
                                ren = dgvDistribuciondeGastos.Rows.Count
                            End If

                            For i As Integer = 0 To (Ventana.dgvMetodos.Rows.Count - 1)

                                Me.dgvDistribuciondeGastos.Rows.Add()
                                Me.dgvDistribuciondeGastos.Rows(i + ren).Cells(Me.clmCuentaContable.Index).Value = Me.DgvCuentas.CurrentRow.Cells(Me.clmidcuentacont.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i + ren).Cells(Me.clmSucursal.Index).Value = Ventana.dgvMetodos.Rows(i).Cells(Ventana.clmSucursal.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i + ren).Cells(Me.clmMetodoProrrateo.Index).Value = Ventana.dgvMetodos.Rows(i).Cells(Ventana.clmMetodoProrrateo.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i + ren).Cells(Me.clmImporte.Index).Value = Ventana.dgvMetodos.Rows(i).Cells(Ventana.clmImporte.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i + ren).Cells(Me.clmPorcentaje.Index).Value = Ventana.txtPorcentaje.Text

                                If (dgvdistribuciongastosdet.Rows.Count) >= 1 Then
                                    rendet = dgvdistribuciongastosdet.Rows.Count
                                End If

                                For j As Integer = 0 To Ventana.dgvDetalledeProrrateo.Rows.Count - 1
                                    Me.dgvdistribuciongastosdet.Rows.Add()
                                    Me.dgvdistribuciongastosdet.Rows(j + rendet).Cells(Me.sucursal1.Index).Value = Ventana.dgvMetodos.CurrentRow.Cells(Ventana.clmSucursal.Index).Value
                                    Me.dgvdistribuciongastosdet.Rows(j + rendet).Cells(Me.Prorrateo1.Index).Value = Ventana.dgvMetodos.CurrentRow.Cells(Ventana.clmMetodoProrrateo.Index).Value
                                    Me.dgvdistribuciongastosdet.Rows(j + rendet).Cells(Me.Cuenta1.Index).Value = Me.DgvCuentas.CurrentRow.Cells(Me.clmidcuentacont.Index).Value
                                    Me.dgvdistribuciongastosdet.Rows(j + rendet).Cells(Me.cod_centro.Index).Value = Ventana.dgvDetalledeProrrateo.Rows(j).Cells(Ventana.Cve_Depto.Index).Value
                                    Me.dgvdistribuciongastosdet.Rows(j + rendet).Cells(Me.idporcentaje.Index).Value = Ventana.dgvDetalledeProrrateo.Rows(j).Cells(Ventana.clmPorcentaje.Index).Value
                                Next
                            Next
                        End If
                    End If
                Case Me.ClmAbono.Index
                    Dim Cuenta As New CN.CuentaContableClass
                    Cuenta.Obtener(Me.DgvCuentas.CurrentRow.Cells(Me.clmidcuentacont.Index).Value)
                    If Cuenta.Departamentalizable = Integra.Clases.SiNoEnum.SI Then
                        Dim Ventana As New frmDistribuciondeGastos
                        frmDistribuciondeGastos.valor = Me.DgvCuentas.CurrentRow.Cells(Me.ClmAbono.Index).Value()
                        If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                            Me.dgvDistribuciondeGastos.AutoGenerateColumns = False

                            If (dgvDistribuciondeGastos.Rows.Count) >= 1 Then
                                ren = dgvDistribuciondeGastos.Rows.Count
                            End If

                            For i As Integer = 0 To Ventana.dgvMetodos.Rows.Count - 1
                                Me.dgvDistribuciondeGastos.Rows.Add()
                                Me.dgvDistribuciondeGastos.Rows(i + ren).Cells(Me.clmCuentaContable.Index).Value = Me.DgvCuentas.CurrentRow.Cells(Me.clmidcuentacont.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i + ren).Cells(Me.clmSucursal.Index).Value = Ventana.dgvMetodos.Rows(i).Cells(Ventana.clmSucursal.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i + ren).Cells(Me.clmMetodoProrrateo.Index).Value = Ventana.dgvMetodos.Rows(i).Cells(Ventana.clmMetodoProrrateo.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i + ren).Cells(Me.clmImporte.Index).Value = Ventana.dgvMetodos.Rows(i).Cells(Ventana.clmImporte.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i + ren).Cells(Me.clmPorcentaje.Index).Value = Ventana.txtPorcentaje.Text

                                If (dgvdistribuciongastosdet.Rows.Count) >= 1 Then
                                    rendet = dgvdistribuciongastosdet.Rows.Count
                                End If

                                For j As Integer = 0 To Ventana.dgvDetalledeProrrateo.Rows.Count - 1
                                    Me.dgvdistribuciongastosdet.Rows.Add()
                                    Me.dgvdistribuciongastosdet.Rows(j + rendet).Cells(Me.sucursal1.Index).Value = Ventana.dgvDetalledeProrrateo.Rows(j).Cells(Ventana.clmSucursal.Index).Value
                                    Me.dgvdistribuciongastosdet.Rows(j + rendet).Cells(Me.Prorrateo1.Index).Value = Ventana.dgvDetalledeProrrateo.Rows(j).Cells(Ventana.clmMetodoProrrateo.Index).Value
                                    Me.dgvdistribuciongastosdet.Rows(j + rendet).Cells(Me.Cuenta1.Index).Value = Me.DgvCuentas.CurrentRow.Cells(Me.clmidcuentacont.Index).Value
                                    Me.dgvdistribuciongastosdet.Rows(j + rendet).Cells(Me.cod_centro.Index).Value = Ventana.dgvDetalledeProrrateo.Rows(j).Cells(Ventana.Cve_Depto.Index).Value
                                    Me.dgvdistribuciongastosdet.Rows(j + rendet).Cells(Me.idporcentaje.Index).Value = Ventana.dgvDetalledeProrrateo.Rows(j).Cells(Ventana.clmPorcentaje.Index).Value
                                Next
                            Next
                        End If
                    End If
            End Select
            ''-----------------------------------------------------------------------------------------------------------------------------------------
            ''-----------------------------------------------------------------------------------------------------------------------------------------

            If e.ColumnIndex = Me.ClmCargo.Index Or e.ColumnIndex = Me.ClmAbono.Index Then
                If String.IsNullOrEmpty(Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                    Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0.ToString(formato)
                Else
                    Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString().Replace("$", "")
                    If Not IsNumeric(Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                        MsgBox("Teclee una Cantidad Correcta", MsgBoxStyle.Exclamation, "Error")
                        Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0.ToString(formato)
                    Else
                        Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDec(Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value).ToString(formato)
                    End If
                End If
            End If
        Catch ex As Exception
            Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0.ToString(formato)
        End Try

    End Sub

    Private Sub DgvCuentas_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCuentas.CellValueChanged
        Try
            Dim SumaCargo As Decimal = 0
            Dim SumaAbono As Decimal = 0
            'If e.ColumnIndex = Me.ClmCargo.Index Then
            '    For i As Integer = 0 To Me.DgvCuentas.Rows.Count - 1
            '        Tot += Decimal.Parse(Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value.ToString)
            '    Next
            '    Me.txtSumaCargo.Text = Tot.ToString(formato)
            'End If
            For i As Integer = 0 To Me.DgvCuentas.Rows.Count - 1
                SumaCargo = SumaCargo + Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value
                SumaAbono = SumaAbono + Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value
            Next
            Me.txtSumaCargo.Text = SumaCargo.ToString(formato)
            Me.TxtSumaAbono.Text = SumaAbono.ToString(formato)
        Catch ex As Exception

        End Try

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

    Public Function calcularFlete(Optional ByVal ignorarCuentaFlete As Boolean = False) As Boolean
        'Mee
        If ckbFlete.Checked = True Then
            If ignorarCuentaFlete = False Then
                Dim confi As New CN.ConfiguracionCtasCtrolColeccion
                If confi.Obtener(24) > 0 Then
                    Me.RellenarGridCuentas(confi(0).CuentaContable)
                Else
                    MessageBox.Show("No se ha configurado la cuenta para el IVA de Fletes." + vbNewLine + "Capt�relo desde Cat�logos - Contabilidad - Cuentas de control.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ckbFlete.Checked = False
                    Return False
                End If


            End If
            Label21.Visible = True
            txtIVAFlete.Visible = True
            'ckbHonorarios.Checked = False
            Dim Conf As New CC.UsrConfigContabilidadCollection
            Conf.GetMulti(Nothing)
            Me.txtIVAFlete.Text = CDec(Conf(0).Ivaflete)

            Dim SubtotalInt As Decimal = If(String.IsNullOrEmpty(Me.TxtSubtotal.Text), 0, Me.TxtSubtotal.Text)
            Dim IVAFleteInt As Decimal = If(String.IsNullOrEmpty(Me.txtIVAFlete.Text), 0, Me.txtIVAFlete.Text)
            Dim IVAFlete1Int As Decimal = If(String.IsNullOrEmpty(Me.txtIVAFlete1.Text), 0, Me.txtIVAFlete1.Text)

            IVAFlete1Int = ((SubtotalInt * IVAFleteInt) / 100).ToString(formato)
            Me.txtIVAFlete1.Text = IVAFlete1Int.ToString(formato)

            'If IVAFlete1Int > 0 Then
            '    If TxtAnticipo.Text = "" Then
            '        Me.TxtTotal.Text = CDec(CDec(Me.TxtTotal.Text) - IVAFlete1Int).ToString(formato)
            '    Else
            '        Me.TxtTotal.Text = ((CDec(Me.TxtTotal.Text) - IVAFlete1Int) - CDec(Me.TxtAnticipo.Text)).ToString(formato)
            '    End If
            'End If

        Else

            Dim confi As New CN.ConfiguracionCtasCtrolColeccion
            If confi.Obtener(24) > 0 Then
                Dim Cta As New ClasesNegocio.CuentaContableClass()
                Cta = confi(0).CuentaContable
                CuentasRepetidas(Cta, True)
            Else
                Return False
            End If
            Dim SubtotalInt As Decimal = If(String.IsNullOrEmpty(Me.TxtSubtotal.Text), 0, Me.TxtSubtotal.Text)
            Dim IVAFleteInt As Decimal = If(String.IsNullOrEmpty(Me.txtIVAFlete.Text), 0, Me.txtIVAFlete.Text)
            Dim IVAFlete1Int As Decimal = If(String.IsNullOrEmpty(Me.txtIVAFlete1.Text), 0, Me.txtIVAFlete1.Text)

            IVAFlete1Int = ((SubtotalInt * IVAFleteInt) / 100).ToString(formato)
            Me.txtIVAFlete1.Text = IVAFlete1Int.ToString(formato)
            'If IVAFlete1Int > 0 Then
            '    If TxtAnticipo.Text = "" Then
            '        Me.TxtTotal.Text = CDec(CDec(Me.TxtTotal.Text) + IVAFlete1Int).ToString(formato)
            '    Else
            '        Me.TxtTotal.Text = ((CDec(Me.TxtTotal.Text) + IVAFlete1Int) - CDec(Me.TxtAnticipo.Text)).ToString(formato)
            '    End If
            '    'Me.TxtTotal.Text = (Subtotal - CDec(Me.TxtAnticipo.Text)).ToString(formato)
            'End If

            Label21.Visible = False
            txtIVAFlete.Visible = False
            Me.txtIVAFlete1.Text = 0.ToString(formato)
        End If
        Return True
    End Function

    Public Function calcularHonorarios() As Boolean

    End Function


    Private Sub ckbFlete_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbFlete.CheckedChanged
        Me.Calcular()
    End Sub

    Private Sub ckbHonorarios_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbHonorarios.CheckedChanged
        Me.Calcular(True)
    End Sub

    Private Sub chkTerceros_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTerceros.CheckedChanged
        If chkTerceros.Checked Then
            Me.grRecepciones.Text = "Recepciones"
            Me.DgvRecepciones.Columns("Agregar").Visible = False
            Me.DgvRecepciones.Columns("FolioOrden").Visible = False
            Me.DgvRecepciones.Columns("CantidadProducto").Visible = False
            Me.DgvRecepciones.AutoGenerateColumns = False

            Me.TxtFactura.Enabled = False
            Me.DtpFechaFactura.Enabled = False

            'Me.chkServicio.Checked = False
            'Me.chkServicio.Enabled = False
            Limpiar(False)
            'Dim query As String = xmlRead("Query", "CompraTerceros")
            'query = ""
            refreshInfo()

        Else
            Me.grRecepciones.Text = "Materia prima y/o Productos de terceros"
            Me.DgvRecepciones.Columns("Agregar").Visible = True
            Me.DgvRecepciones.Columns("FolioOrden").Visible = True
            Me.DgvRecepciones.Columns("CantidadProducto").Visible = True
            Me.DgvRecepciones.AutoGenerateColumns = False

            Me.TxtFactura.Enabled = True
            Me.DtpFechaFactura.Enabled = True
            'Me.chkServicio.Checked = True
            'Me.chkServicio.Enabled = True
            Limpiar(False)
            refreshInfo()
        End If

    End Sub

    Private Sub DgvRecepciones_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvRecepciones.CellClick
        Try
            If Me.chkTerceros.Checked Then
                If CBool(Me.DgvRecepciones.Rows(e.RowIndex).Cells("Agregar").Value) Then
                    Me.DgvRecepciones.Rows(e.RowIndex).Cells("Agregar").Value = False
                    'Exit Sub
                Else
                    Me.DgvRecepciones.Rows(e.RowIndex).Cells("Agregar").Value = True

                End If
                'Re = New Integralab.ORM.EntityClasses.RecepcionesNewEntity
                Me.Subtotal = 0
                Me.IVAA = 0
                For i As Integer = 0 To Me.DgvRecepciones.Rows.Count - 1
                    Editar = False
                    Me.NoFactura = Me.DgvRecepciones.Rows(e.RowIndex).Cells("Folio").Value.ToString()
                    Me.Subtotal = Me.DgvRecepciones.Rows(e.RowIndex).Cells("Precio").Value.ToString()
                    Me.IVAA = Me.DgvRecepciones.Rows(e.RowIndex).Cells("IVA").Value.ToString()
                    Me.FechaFactura = Me.DgvRecepciones.Rows(e.RowIndex).Cells("FechaRecepcion").Value.ToString()
                    Me.Observaciones = Me.DgvRecepciones.Rows(e.RowIndex).Cells("clmObservaciones").Value.ToString()
                Next
                'If Subtotal = 0 Then
                '    Me.TxtSubtotal.Enabled = True
                '    Me.txtIva.Enabled = True
                '    Me.TxtTotal.Enabled = True
                '    Me.txtISR.Enabled = True
                '    Me.txtIVAFlete1.Enabled = True
                '    Me.txtRetIVA.Enabled = True
                '    Editar = True
                'Else
                '    Me.TxtSubtotal.Enabled = False
                '    Me.txtIva.Enabled = True
                '    Me.TxtTotal.Enabled = False
                '    Me.txtISR.Enabled = False
                '    Me.txtIVAFlete1.Enabled = False
                '    Me.txtRetIVA.Enabled = False
                '    'Me.txtIva.Text = Me.DgvRecepciones.Rows(2).Cells("IVA").Value
                '    'If Me.DgvRecepciones.Rows(1).Cells("").Value > 0 Then

                '    'End If
                '    'Me.txtISR.Text = Me.DgvRecepciones.Rows(2).Cells("IVA").Value
                '    'Me.txtRetIVA.Text = Me.DgvRecepciones.Rows(2).Cells("IVA").Value
                '    'Me.txtIVAFlete1.Text = Me.DgvRecepciones.Rows(2).Cells("IVA").Value


                'End If
                If Editar = False Then
                    'If TxtSubtotal.Text = "" Then
                    If Me.chkTerceros.Checked Then
                        Me.TxtFactura.Text = Me.NoFactura
                        Me.DtpFechaFactura.Value = Me.FechaFactura
                        Me.txtObservaciones.Text = Me.Observaciones
                    End If

                    Me.TxtSubtotal.Text = Subtotal.ToString(formato)
                    Me.txtIva.Text = IVAA.ToString(formato)
                    Me.txtISR.Text = 0.ToString(formato)
                    Me.txtIVAFlete1.Text = 0.ToString(formato)
                    Me.txtRetIVA.Text = 0.ToString(formato)
                    'End If
                Else
                    Me.TxtSubtotal.Text = 0.ToString(formato)
                    Me.txtIva.Text = 0.ToString(formato)
                    Me.txtISR.Text = 0.ToString(formato)
                    Me.txtIVAFlete1.Text = 0.ToString(formato)
                    Me.txtRetIVA.Text = 0.ToString(formato)
                    Me.TxtTotal.Text = 0.ToString(formato)

                End If
            End If
            calcularSubtotal()
        Catch ex As Exception

        End Try
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
    Private Sub DgvCuentas_EditingControlShowing(sender As System.Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DgvCuentas.EditingControlShowing
        Dim cajatexto As TextBox = TryCast(e.Control, TextBox)
        If (Me.DgvCuentas.CurrentCell.ColumnIndex() <> ClmDescripcion.Index) Then
            If cajatexto IsNot Nothing Then
                RemoveHandler cajatexto.KeyPress, AddressOf Me.txtDiasPlazo_KeyPress
                AddHandler cajatexto.KeyPress, AddressOf Me.txtDiasPlazo_KeyPress
            End If
        Else
            RemoveHandler cajatexto.KeyPress, AddressOf Me.txtDiasPlazo_KeyPress
        End If

    End Sub

    Private Sub txtDiasPlazo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiasPlazo.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    'Private Sub DgvCuentas_CellBeginEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DgvCuentas.CellBeginEdit
    '    Dim abono As Decimal = 0
    '    If Not String.IsNullOrEmpty(Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
    '        abono = Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString().Replace(",", "") ' e.RowIndex
    '        Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = abono
    '    End If
    'End Sub

    Private Function guardarprorrate(Fact As Integralab.ORM.EntityClasses.UsrCxpfacturasCabEntity) As Boolean
        Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)

        Try
            For i As Integer = 0 To dgvDistribuciondeGastos.Rows.Count - 1


                Dim cadenaConsulta As String = "INSERT INTO GastosDepartamentalesFG(IdPoliza,IdSucursal,IdMetodo,Cuenta,Ptj_Importe,Importe,Fecha,Estatus,Factura,Idprovedor,EmpresaId) VALUES({0},{1},{2},{3},{4},{5},'{6}',{7},'{8}',{9},{10})"
                cadenaConsulta = String.Format(cadenaConsulta, 0, dgvDistribuciondeGastos.Rows(i).Cells(clmSucursal.Index).Value, dgvDistribuciondeGastos.Rows(i).Cells(clmMetodoProrrateo.Index).Value, dgvDistribuciondeGastos.Rows(i).Cells(clmCuentaContable.Index).Value, dgvDistribuciondeGastos.Rows(i).Cells(clmPorcentaje.Index).Value, CDec(dgvDistribuciondeGastos.Rows(i).Cells(clmImporte.Index).Value), DtpFechaFactura.Text, 0, Fact.NoFactura, Fact.IdProveedor, Fact.EmpresaId)
                Dim sqlcom As New SqlCommand(cadenaConsulta, sqlCon)
                Dim adp As New SqlDataAdapter(sqlcom)

                sqlCon.Open()
                sqlcom.ExecuteNonQuery()
                sqlCon.Close()

            Next

        Catch ex As Exception

        End Try
        Dim sqlCone As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
        Try
            For i As Integer = 0 To (dgvdistribuciongastosdet.Rows.Count - 1)
                Dim cadenaConsulta As String = "INSERT INTO GastosDepartamentosDetFG(IdSucursal,IdMetodoProrrateo,IdCuentaContable,Factura,Cod_CentroCostos,Porcentaje) values({0},{1},{2},'{3}',{4},{5},{6})"
                cadenaConsulta = String.Format(cadenaConsulta, dgvdistribuciongastosdet.Rows(i).Cells(sucursal1.Index).Value, dgvdistribuciongastosdet.Rows(i).Cells(Prorrateo1.Index).Value, dgvdistribuciongastosdet.Rows(i).Cells(Cuenta1.Index).Value, Fact.NoFactura, dgvdistribuciongastosdet.Rows(i).Cells(cod_centro.Index).Value, dgvdistribuciongastosdet.Rows(i).Cells(idporcentaje.Index).Value, Fact.IdProveedor)

                Dim sqlcom As New SqlCommand(cadenaConsulta, sqlCone)
                Dim adp As New SqlDataAdapter(sqlcom)

                'Dim tb As New DataTable
                'sqlCon.Open()
                '    adp.Fill(tb)
                '    Me.dgvDistribuciondeGastos.AutoGenerateColumns = False
                '    Me.dgvDistribuciondeGastos.DataSource = tb
                sqlCone.Open()
                sqlcom.ExecuteNonQuery()
                sqlCone.Close()


            Next
            Return True
        Catch ex As Exception

        End Try
        sqlCon.Close()
        sqlCone.Close()

    End Function




    Private Sub DgvCuentas_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCuentas.CellDoubleClick
        Try

            Dim Cuenta As New CN.CuentaContableClass
            Cuenta.Obtener(Me.DgvCuentas.CurrentRow.Cells(Me.clmidcuentacont.Index).Value)
            If Cuenta.Departamentalizable = Integra.Clases.SiNoEnum.SI Then
                Dim Ventana As New frmDistribuciondeGastosconsulta
                frmDistribuciondeGastosconsulta.factura = TxtFactura.Text
                frmDistribuciondeGastosconsulta.idcuentacontable = Me.DgvCuentas.CurrentRow.Cells(Me.clmidcuentacont.Index).Value
                If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                End If
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub RellenarGridCuentasB(ByVal Cta As ClasesNegocio.CuentaContableClass, ByVal Importe As Decimal, ByVal Cargo As Boolean)
        Try
            Dim i As Integer = Me.DgvCuentas.Rows.Count
            Me.DgvCuentas.Rows.Add()
            If Cargo Then
                Me.DgvCuentas.Rows(i).Cells("clmidcuentacont").Value = Cta.Codigo
                Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = Cta.SubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = Importe.ToString("C2")
                Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = 0
            Else
                Me.DgvCuentas.Rows(i).Cells("clmidcuentacont").Value = Cta.Codigo
                Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = Cta.SubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = 0
                Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = Importe.ToString("C2")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtIVAFlete_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtIVAFlete.KeyPress
        If Char.IsDigit(e.KeyChar) Or ((e.KeyChar = Convert.ToChar(Keys.Back)) Or (e.KeyChar = "." And Me.txtIVAFlete.Text.IndexOf(".") < 0)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtIVAFlete_Leave(sender As System.Object, e As System.EventArgs) Handles txtIVAFlete.Leave
        Dim value As Decimal = Replace(txtIVAFlete.Text, ",", "")
        txtIVAFlete.Text = value.ToString("N4")
    End Sub

    Private Sub txtTasaRetIVA_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTasaRetIVA.KeyPress
        If Char.IsDigit(e.KeyChar) Or ((e.KeyChar = Convert.ToChar(Keys.Back)) Or (e.KeyChar = "." And Me.txtTasaRetIVA.Text.IndexOf(".") < 0)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTasaRetIVA_Leave(sender As System.Object, e As System.EventArgs) Handles txtTasaRetIVA.Leave
        Dim value As Decimal = Replace(txtTasaRetIVA.Text, ",", "")
        txtTasaRetIVA.Text = value.ToString("N4")
    End Sub

    Private Sub txtTasaISR_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTasaISR.KeyPress
        If Char.IsDigit(e.KeyChar) Or ((e.KeyChar = Convert.ToChar(Keys.Back)) Or (e.KeyChar = "." And Me.txtTasaISR.Text.IndexOf(".") < 0)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTasaISR_Leave(sender As System.Object, e As System.EventArgs) Handles txtTasaISR.Leave
        Dim value As Decimal = Replace(txtTasaISR.Text, ",", "")
        txtTasaISR.Text = value.ToString("N4")
    End Sub


    Private Sub buscarcanceladas(id As Integer)

        Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
        Dim cadenaConsulta As String = "EXEC Usp_HistorialUsrFacturas 1, {0}"
        cadenaConsulta = String.Format(cadenaConsulta, id)

        Using sqlcom As New SqlCommand(cadenaConsulta, sqlCon)
            sqlCon.Open()
            Dim adp As New SqlDataAdapter(sqlcom)
            Dim Rs As SqlDataReader = sqlcom.ExecuteReader()

            Dim cuentascontables As New DataSet()
            cuentascontables.Tables.Add("cuentascontables")
            cuentascontables.Tables(0).Load(Rs)

            Me.CmbProveedor.SelectedValue = CInt(cuentascontables.Tables(0).Rows(0).ItemArray(2).ToString())
            Me.TxtFactura.Text = cuentascontables.Tables(0).Rows(0).ItemArray(3).ToString()
            Me.DtpFechaFactura.Value = cuentascontables.Tables(0).Rows(0).ItemArray(4).ToString()
            Me.DtpFechaCaptura.Value = cuentascontables.Tables(0).Rows(0).ItemArray(5).ToString()
            Me.DtpFechaVencimiento.Value = cuentascontables.Tables(0).Rows(0).ItemArray(6).ToString()
            Me.TxtSubtotal.Text = cuentascontables.Tables(0).Rows(0).ItemArray(7).ToString()
            Me.txtIva.Text = cuentascontables.Tables(0).Rows(0).ItemArray(8).ToString()
            Me.TxtTotal.Text = cuentascontables.Tables(0).Rows(0).ItemArray(9).ToString()
            Me.TxtAnticipo.Text = cuentascontables.Tables(0).Rows(0).ItemArray(10).ToString()
            Select Case (cuentascontables.Tables(0).Rows(0).ItemArray(11).ToString())
                Case 0
                    Me.lblEstatus.Text = "CANCELADA"
                Case 1
                    Me.lblEstatus.Text = "PAGADA"
                Case 2
                    Me.lblEstatus.Text = "VIGENTE"
                Case 3
                    Me.lblEstatus.Text = "ABONADA"
            End Select
            lblEstatus.Visible = True
            Me.txtObservaciones.Text = cuentascontables.Tables(0).Rows(0).ItemArray(15).ToString()
            ' Me.txtConcepto.Text = Me.Fact.Concepto
            Me.chkServicio.Checked = cuentascontables.Tables(0).Rows(0).ItemArray(19).ToString()
            Me.MtxtUUID.Text = cuentascontables.Tables(0).Rows(0).ItemArray(29).ToString()

            llenarcuentascontablesfac(cuentascontables)
            sqlCon.Close()

        End Using

    End Sub

    'Private Sub llenarcuentascontablesfac(Rs As SqlDataReader)

    '    While Rs.Read()
    '        Try
    '            Dim i As Integer = Me.DgvCuentas.Rows.Count
    '            Me.DgvCuentas.Rows.Add()
    '            If Rs("CarAbo").ToString().Equals("C") Then
    '                Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = Rs("cta").ToString()
    '                Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = Rs("subcta").ToString()
    '                Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = Rs("SSubCta").ToString()
    '                Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = Rs("SSSubCta").ToString()
    '                Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = Rs("NomCuenta").ToString()
    '                Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = Rs("importecuenta").ToString()
    '                Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = 0
    '            Else
    '                Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = Rs("cta").ToString()
    '                Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = Rs("subcta").ToString()
    '                Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = Rs("SSubCta").ToString()
    '                Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = Rs("SSSubCta").ToString()
    '                Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = Rs("NomCuenta").ToString()
    '                Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = 0
    '                Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = Rs("importecuenta").ToString()
    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '        End Try
    '    End While

    'End Sub

    Private Sub llenarcuentascontablesfac(cuentascontables As DataSet)


        For Each row As DataRow In cuentascontables.Tables(0).Rows
            Dim i As Integer = Me.DgvCuentas.Rows.Count
            Me.DgvCuentas.Rows.Add()
            If row("CarAbo").ToString().Equals("C") Then
                Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = row("cta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = row("subcta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = row("SSubCta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = row("SSSubCta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = row("NomCuenta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = row("importecuenta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = 0
            Else
                Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = row("cta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = row("subcta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = row("SSubCta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = row("SSSubCta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = row("NomCuenta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = 0
                Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = row("importecuenta").ToString()
            End If
        Next

    End Sub

End Class