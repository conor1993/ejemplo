Imports CN = ClasesNegocio
Imports Ccom = ClasesComunes
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports Integralab
Imports System.IO
Imports System.Drawing.Printing

Public Class frmFacturasVtaDiaria
    Dim puedorefrescar As Boolean = True
    Dim Editar As Boolean = False
    Dim seleccionado As Boolean = False
    Dim Busqueda As New ClasesNegocio.BusquedaClass(Of ClasesNegocio.CiudadClass)
    Dim listFact As List(Of TasasIepsFact)
    Dim cancelarE As Boolean = False
    Dim CveMetodoPago As String = ""
    Dim NoCuenta As String = ""

#Region "Constuctores"
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
#End Region

    Private Sub TxtPorc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPorc.KeyPress
        Dim punto As String = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator
        If Not (Asc(e.KeyChar) < 32 Or Char.IsDigit(e.KeyChar) Or (e.KeyChar = punto And TxtPorc.Text.Contains(punto))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmFacturasVtaDiaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "100100011"
        MtbEstados.StateCancelar = "100100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "100100011"
        MtbEstados.StateBorrar = "100100011"
        MtbEstados.StateEditar = "001010001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        mtb.ToolBarButtonStatus = MtbEstados
        mtb.sbCambiarEstadoBotones("Nuevo")

        limpiar()
        CargarDatos()
#If DEBUG Then
        txtTotalFactTemp.Visible = True

#End If

        'dtpFecha.Value = Date.Today
        'dtpFecha.MaxDate = Date.Today
        'dtpFecha.MinDate = Date.Today
    End Sub

#Region "Metodos"

    Private Sub limpiar()
        Me.TxtPorc.Clear()
        Me.txtObservacion.Clear()
        lblEstatus.Text = "ESTATUS"
        seleccionado = False
        Editar = False
        'Me.lblEstatus.Visible = False
        Me.TxtPorc.Focus()
        NoCuenta = ""

    End Sub

    Public Sub CargarDatos()
        Dim Facts As New CN.FacturasClientesCabCollectionClass()
        Dim Filtro As New OC.PredicateExpression
        listFact = New List(Of TasasIepsFact)
        Filtro.Add(HC.FacturasClientesCabFields.FechaFactura >= dtpFecha.Value.Date.ToString("dd-MM-yyyy 00:00:00") And HC.FacturasClientesCabFields.FechaFactura <= dtpFecha.Value.Date.ToString("dd-MM-yyyy 23:59:59"))
        Facts.Obtener(Filtro)
        For Each objeto As CN.FacturasClientesCabClass In Facts
            For Each row As EC.FacturasClientesDetProductosTotalesEntity In objeto.DetalleProductos
                If row.IdProducto = 0 Then
                    lblEstatus.Text = "FACTURADO"
                    mtb.sbCambiarEstadoBotones("Cancelar")
                Else
                    lblEstatus.Text = " POR FACTURAR"
                    mtb.sbCambiarEstadoBotones("Nuevo")
                End If
            Next
        Next

        If Facts.Count = 0 Then
            lblEstatus.Text = " POR FACTURAR"
            mtb.sbCambiarEstadoBotones("Nuevo")
        End If

        Dim Total As Decimal = Total, Subtotal As Decimal, IVA As Decimal, ieps As Decimal
        'Dim Total As Decimal = 0
        For Each objeto As CN.FacturasClientesCabClass In Facts
            For Each row As EC.FacturasClientesDetProductosTotalesEntity In objeto.DetalleProductos
                If row.Ieps > 0 Then
                    Dim producto As New CN.ProductoGeneralClass(row.IdProducto)
                    Dim tasa As Decimal = producto.PorcIEPS
                    If listFact.Exists(Function(column) column.Tasa = tasa) Then
                        Dim obj As TasasIepsFact = listFact.Find(Function(column) column.Tasa = tasa)
                        listFact.Remove(obj)
                        obj.Total += row.Ieps
                        listFact.Add(obj)
                    Else
                        Dim obj As New TasasIepsFact
                        obj.Tasa = tasa
                        obj.Total = row.Ieps
                        listFact.Add(obj)
                    End If

                End If
                Subtotal += (row.ImporteFacturado - row.Iva - row.Ieps)
                IVA += row.Iva
                ieps += row.Ieps
            Next

            Total += objeto.Total
        Next
        txtSubTotalFact.Text = Subtotal.ToString("N3")
        txtTotalFact.Text = Total.ToString("N3")
        txtivaFact.Text = IVA.ToString("N3")
        txtiepsFact.Text = ieps.ToString("N3")
        Dim temp As Decimal = Total ', Subtotal As Decimal, IVA As Decimal, ieps As Decimal
        Total = 0
        IVA = 0
        Subtotal = 0
        ieps = 0
        Dim Notas As New CN.NotaVentaCollectionClass

        Filtro = New OC.PredicateExpression
        Filtro.Add(HC.NotaVentaFields.FechaVenta >= dtpFecha.Value.Date.ToString("dd-MM-yyyy 00:00:00") And HC.NotaVentaFields.FechaVenta <= dtpFecha.Value.Date.ToString("dd-MM-yyyy 23:59:59") And HC.NotaVentaFields.FolioFact = "" And HC.NotaVentaFields.PagoTarj = 0 And HC.NotaVentaFields.Estatus = 1)
        Notas.Obtener(Filtro)

        For Each objeto As CN.NotaVentaClass In Notas
            Subtotal += objeto.Subtotal
            ieps += objeto.IEPS
            IVA += objeto.IVA
            Total += objeto.Total
        Next

        txtTotalSubtotal.Text = Subtotal.ToString("N3")
        txtTotalIeps.Text = ieps.ToString("N3")
        txtTotalIVA.Text = IVA.ToString("N3")
        txtTotalVentaDia.Text = Total.ToString("N3")
        txtDiff.Text = (Total - temp).ToString("N3")
        txtTotalFactTemp.Text = txtDiff.Text
    End Sub

    Public Sub CargarDatos(ByVal Notas As List(Of NotasLocal))
        'Dim Facts As New CN.FacturasClientesCabCollectionClass()
        'Dim Filtro As New OC.PredicateExpression
        'Filtro.Add(HC.FacturasClientesCabFields.FechaCaptura >= dtpFecha.Value.Date.ToString("dd-MM-yyyy 00:00:00") And HC.FacturasClientesCabFields.FechaCaptura <= dtpFecha.Value.Date.ToString("dd-MM-yyyy 23:59:59"))
        'Facts.Obtener(Filtro)
        Dim Total As Decimal = 0
        'For Each objeto As CN.FacturasClientesCabClass In Facts
        '    Total += objeto.Total
        'Next
        'txtTotalFact.Text = Total.ToString("N2")
        Dim temp As Decimal = Total, Subtotal As Decimal, IVA As Decimal, ieps As Decimal
        Total = 0
        ' Dim Notas As New CN.NotaVentaCollectionClass
        'Notas =
        'Filtro = New OC.PredicateExpression
        'Filtro.Add(HC.NotaVentaFields.FechaVenta >= dtpFecha.Value.Date.ToString("dd-MM-yyyy 00:00:00") And HC.NotaVentaFields.FechaVenta <= dtpFecha.Value.Date.ToString("dd-MM-yyyy 23:59:59"))
        'Notas.Obtener(Filtro)
        For Each objeto As NotasLocal In Notas
            'For Each objeto As CN.NotaVentaClass In elem.NotaC
            Subtotal += objeto.NotaC.Subtotal
            ieps += objeto.NotaC.IEPS
            IVA += objeto.NotaC.IVA
            Total += objeto.NotaC.Total
            'Next
        Next
        txtTotalSubtotal.Text = Subtotal.ToString("N3")
        txtTotalIeps.Text = ieps.ToString("N3")
        txtTotalIVA.Text = IVA.ToString("N3")
        txtTotalVentaDia.Text = Total.ToString("N3")
        txtDiff.Text = (Total - temp).ToString("N3")
        txtTotalFactTemp.Text = txtDiff.Text
    End Sub

    Public Class TasasIeps

        Private porc As Decimal, tot As Decimal

        Property Tasa() As String
            Get
                Return porc
            End Get
            Set(ByVal Value As String)
                porc = Value
            End Set
        End Property

        Property Total() As String
            Get
                Return tot
            End Get
            Set(ByVal Value As String)
                tot = Value
            End Set
        End Property

   
    End Class

    Public Class TasasIepsFact

        Private porc As Decimal, tot As Decimal

        Property Tasa() As String
            Get
                Return porc
            End Get
            Set(ByVal Value As String)
                porc = Value
            End Set
        End Property

        Property Total() As String
            Get
                Return tot
            End Get
            Set(ByVal Value As String)
                tot = Value
            End Set
        End Property


    End Class

    Public Class NotasLocal
        Private nota As New CN.NotaVentaClass
        Property NotaC() As CN.NotaVentaClass
            Get
                Return nota
            End Get
            Set(ByVal Value As CN.NotaVentaClass)
                nota = Value
            End Set
        End Property
    End Class

    Public Class NotasDetalleLocal
        Private nota As New CN.NotaVentaDetalleClass
        Property NotaC() As CN.NotaVentaDetalleClass
            Get
                Return nota
            End Get
            Set(ByVal Value As CN.NotaVentaDetalleClass)
                nota = Value
            End Set
        End Property
    End Class


    Private Sub guardar()
        Dim ListaNotas As New CN.NotaVentaCollectionClass()
        Dim Cliente As CN.ClientesIntroductoresClass
        Dim CodCtePublicoGral As Integer
        Dim list As New List(Of TasasIeps)
        Dim listNC As New List(Of NotasLocal)
        Dim listND As New List(Of NotasDetalleLocal)
        Dim Fact As CFDI.Comprobante
        Dim DomFiscalCte As New CN.DomicilioClienteClass()

        '
        Cliente = New CN.ClientesIntroductoresClass(1)
        DomFiscalCte = DirectCast(Cliente.DomicilioFiscalPrincipal, CN.DomicilioClienteClass)
        '----------------------------------------------------
        '   Inicia codigo agregado para generar el CFDI
        '----------------------------------------------------
        Dim ControlFD As Integralab.FactDigital.ControladorFactDigital
        Dim ConStr As String
        If File.Exists(Application.StartupPath + "\\cx.dat") Then
            ConStr = Integralab.FactDigital.ControladorFactDigital.Decrypt(File.ReadAllText(Application.StartupPath + "\\cx.dat"))
        Else
            Throw New Exception("No se ha configurado la conexión a la base de datos de la factura digital.")
        End If
        ControlFD = New IntegraLab.FactDigital.ControladorFactDigital(Controlador.Empresa.CodEmpndx, ConStr)

        Dim TransG As New Gentle.Framework.Transaction(IntegraLab.FactDigital.ControladorFactDigital.Conexion)
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
        Dim FacturasDetProductosTotales As New CN.FacturasClientesDetProductosTotalesClass
        Dim FacturasCab As New CN.FacturasClientesCabClass
        Dim FacturasDet As New CN.FacurasClientesDetClass
        Dim Folio As String = ""



        Dim Factura As New CC.FacturasClientesCabCollection()
        Controlador.Configuracion.ActualizarFacturaFolios(1)
        Folio = (Controlador.Configuracion.FacturaFolios.GenerarFolio(Trans)).Trim
        Factura.GetMulti(HC.FacturasClientesCabFields.NoFactura = Folio Or HC.FacturasClientesCabFields.NoFactura = String.Format("C-{0}", Folio))

        
        Try
            'If CDec(txtDiff.Text.Trim) <> CDec(txtTotalFactTemp.Text) Then


            'Dim diferencia As Decimal = CDec(txtTotalFactTemp.Text) - CDec(txtDiff.Text)
            Dim filtro As New OC.PredicateExpression
            filtro = New OC.PredicateExpression
            filtro.Add(HC.NotaVentaFields.FechaVenta >= dtpFecha.Value.Date.ToString("dd-MM-yyyy 00:00:00") And HC.NotaVentaFields.FechaVenta <= dtpFecha.Value.Date.ToString("dd-MM-yyyy 23:59:59") And HC.NotaVentaFields.FolioFact = "" And HC.NotaVentaFields.PagoTarj = 0 And HC.NotaVentaFields.Estatus = 1)
            Dim notas As New CN.NotaVentaCollectionClass()
            notas.Obtener(filtro)

            Dim porcentaje As Double = ((CDbl(txtDiff.Text)) / CDbl(txtTotalVentaDia.Text))
            'MessageBox.Show(porcentaje.ToString("N3"))
            For Each row As CN.NotaVentaClass In notas
                Dim rowN As New CN.NotaVentaClass()
                rowN.Obtener(row.Codigo)
                ''---RESPALDAR NOTA
                Dim nvr As New CN.NotaVentaRespClass()
                nvr.Codigo = row.Codigo
                nvr.IdSucursal = row.IdSucursal
                nvr.Estatus = row.Estatus
                nvr.Subtotal = row.Subtotal
                nvr.Descuento = row.Descuento
                nvr.Total = row.Total
                nvr.FechaVenta = row.FechaVenta
                nvr.FechaCancelacion = row.FechaCancelacion
                nvr.UsuarioCancelacion = row.UsuarioCancelacion
                nvr.UsuarioAlta = row.UsuarioAlta
                nvr.MotivoCancelacion = row.MotivoCancelacion
                nvr.ObservacionesCancelacion = row.ObservacionesCancelacion
                nvr.IVA = row.IVA
                nvr.IEPS = row.IEPS
                nvr.IdFactura = row.IdFactura
                nvr.PagoEfectivo = row.PagoEfectivo
                nvr.PagoTarjeta = row.PagoTarjeta
                nvr.Cambio = row.Cambio
                nvr.CodCaja = row.CodCaja
                nvr.IdControlTurno = row.IdControlTurno
                'nvr.IdControlTurnoCanc = row.IdControlTurnoCanc
                nvr.SerieFactura = row.SerieFactura
                nvr.FolioFactura = row.FolioFactura
                'If nvr.Guardar(Trans) Then

                'End If
                If nvr.Guardar(Trans) Then
                    rowN.Modif = True
                    ''--NOTA VENTA

                End If


                ''DETALLE NOTA VENTA
                For Each rd As CN.NotaVentaDetalleClass In row.Detalles
                    ''---RESPALDAR DETALLE NOTA
                    Dim rdN As New CN.NotaVentaDetalleClass(rd.Codigo)

                    Dim nvdr As New CN.NotaVentaDetalleRespClass
                    nvdr.Codigo = rd.Codigo
                    nvdr.NotaVenta = row.Codigo
                    nvdr.IdProducto = rd.IdProducto
                    nvdr.Cantidad = rd.Cantidad
                    nvdr.Precio = rd.Precio
                    nvdr.Importe = rd.Importe
                    nvdr.Descuento = rd.Descuento
                    nvdr.IVA = rd.IVA
                    nvdr.IEPS = rd.IEPS
                    nvdr.IdProductoCompuesto = rd.IdProductoCompuesto
                    If nvdr.Guardar(Trans) Then

                    End If

                    ' nvr.Detalles.Add(nvdr)

                    ''RESTA DICHO PORCENTAJE
                    rdN.Precio *= porcentaje
                    rdN.Importe *= porcentaje
                    rdN.Descuento *= porcentaje
                    rdN.IVA *= porcentaje
                    rdN.IEPS *= porcentaje

                    ''----CALCULA LAS TASAS DE IEPS QUE PUEDA HABER
                    If rdN.IEPS > 0 And rdN.Producto IsNot Nothing Then
                        Dim tasa As Decimal = rdN.Producto.PorcIEPS
                        If list.Exists(Function(column) column.Tasa = tasa) Then
                            Dim obj As TasasIeps = list.Find(Function(column) column.Tasa = tasa)
                            list.Remove(obj)
                            obj.Total += rdN.IEPS
                            list.Add(obj)
                        Else
                            Dim obj As New TasasIeps
                            obj.Tasa = tasa
                            obj.Total = rdN.IEPS
                            list.Add(obj)
                        End If
                    End If

                    Dim notaD As New NotasDetalleLocal()
                    notaD.NotaC = rdN
                    listND.Add(notaD)
                    'If Not rdN.Guardar(Trans) Then
                    '    MessageBox.Show("ERROR AL MODIFICAR DETALLE NOTA DE VENTA.")
                    'End If
                    'Trans.Rollback()
                Next



                'For Each dw As CN.NotaVentaDetalleRespClass In nvr.Detalles
                '    If Not dw.Guardar() Then

                '    End If

                'Next
                rowN.PagoEfectivo *= porcentaje
                rowN.PagoTarjeta *= porcentaje
                rowN.Cambio *= porcentaje
                rowN.Subtotal = row.Subtotal * porcentaje
                rowN.IVA = row.IVA * porcentaje
                rowN.IEPS = row.IEPS * porcentaje
                rowN.Total = row.Total * porcentaje

                'If row.Guardar(Trans) Then

                'End If
                Dim notaC As New NotasLocal()
                notaC.NotaC = rowN
                listNC.Add(notaC)
                'If Not rowN.Guardar(Trans, True) Then
                '    MessageBox.Show("ERROR AL MODIFICAR NOTA DE VENTA.")
                'End If

                'Trans.Rollback()
            Next
            'Trans.Commit()
            'For Each r As TasasIeps In list
            '    MessageBox.Show(r.Tasa.ToString() & " ---> " & r.Total.ToString())
            'Next

            'Exit Sub
            'End If

            ''RECORREN LAS NOTAS 
            For Each row As NotasLocal In listNC
                'row.NotaC.SerieFactura = Controlador.Configuracion.FacturaFolios.StaLetraSerie
                'row.NotaC.FolioFactura = Folio
                If row.NotaC.Guardar(Trans, True) Then

                End If

            Next

            For Each row As NotasDetalleLocal In listND
                If row.NotaC.Guardar(Trans) Then

                End If

            Next

            CargarDatos(listNC)
            Application.DoEvents()
            'MessageBox.Show(Total.ToString())
            ' Datos del emisor
            Dim DomicilioFiscal As New CFDI.UbicacionFiscal(Controlador.Sesion.MiEmpresa.EmpCalle, Controlador.Sesion.MiEmpresa.EmpLocalidad, Controlador.Sesion.MiEmpresa.EmpEstado, "MEXICO", Controlador.Sesion.MiEmpresa.EmpCodigoPostal)
            DomicilioFiscal.colonia = Controlador.Sesion.MiEmpresa.EmpColonia
            DomicilioFiscal.noExterior = Controlador.Sesion.MiEmpresa.EmpNoExt
            DomicilioFiscal.noInterior = Controlador.Sesion.MiEmpresa.EmpNoInt


            Dim ExpedidoEn As New Integralab.CFDI.Ubicacion("MEXICO")
            ExpedidoEn.municipio = "CULIACAN"
            ExpedidoEn.estado = "SINALOA"

            Dim RegimenFiscal As New List(Of CFDI.ComprobanteEmisorRegimenFiscal)
            RegimenFiscal.Add(New CFDI.ComprobanteEmisorRegimenFiscal(Controlador.Sesion.MiEmpresa.EmpRegimenFiscal))

            Dim Emisor As New CFDI.ComprobanteEmisor(Controlador.Sesion.MiEmpresa.EmpRfc, RegimenFiscal)
            Emisor.nombre = Controlador.Sesion.MiEmpresa.Empnom
            Emisor.DomicilioFiscal = DomicilioFiscal


            ' '' Datos del cliente

            Dim Receptor As New CFDI.ComprobanteReceptor("XAXX010101000")
            Dim Domicilio As New CFDI.Ubicacion("MEXICO")
            Domicilio.calle = ""
            Domicilio.colonia = ""
            Domicilio.codigoPostal = Controlador.Sesion.MiEmpresa.EmpCodigoPostal
            Domicilio.noExterior = ""
            Domicilio.noInterior = ""
            Domicilio.localidad = "CULIACAN"
            Domicilio.municipio = "CULIACAN"
            Domicilio.estado = "SINALOA"
            Receptor.nombre = "PUBLICO EN GENERAL"
            Receptor.Domicilio = Domicilio

            '' crea lista IVA vacio
            Dim Impuestos As New CFDI.ComprobanteImpuestos()
            Impuestos.Traslados = New List(Of CFDI.ComprobanteImpuestosTraslado)

            ' '' crea lista de conceptos y la llena
            Dim Conceptos As New List(Of CFDI.ComprobanteConcepto)()
            'Dim ldSubtotal, ldTotal As Decimal
            'For Each det As DataGridViewRow In dgvDetalleConcentrado.Rows
            Dim Concepto As New CFDI.ComprobanteConcepto(1, "N/A", "FACTURACIÓN DE VENTA DIARIA " & dtpFecha.Value.Date.ToString("dd/MM/yyyy"), (CDec(txtTotalSubtotal.Text) - CDec(txtSubTotalFact.Text)).ToString("N2"), (CDec(txtTotalSubtotal.Text) - CDec(txtSubTotalFact.Text)).ToString("N2"))
            Conceptos.Add(Concepto)
            '    ldSubtotal += Concepto.importe
            '    ldTotal += CDec(det.Cells("clmTotal").Value)

            '    '' se busca el impuesto correcto para acumular y si no se encuentra agrega el impuesto del producto a la lista
            '    Dim acum As Boolean = False
            Dim ldImpIva As Decimal = CDec(txtTotalIVA.Text)
            If ldImpIva > 0 Then
                '        For Each imp As CFDI.ComprobanteImpuestosTraslado In Impuestos.Traslados
                '            If imp.impuesto = IntegraLab.CFDI.ComprobanteImpuestosTrasladoImpuesto.IVA And imp.tasa = ldIVA Then
                '                imp.importe = imp.importe + ldImpIva
                '                acum = True
                '            End If
                '        Next
                '        If Not acum Then
                Dim Impuesto As New CFDI.ComprobanteImpuestosTraslado
                Impuesto.impuesto = Integralab.CFDI.ComprobanteImpuestosTrasladoImpuesto.IVA
                Impuesto.tasa = Controlador.ObtenerIVA()
                Impuesto.importe = (CDec(ldImpIva) - CDec(txtivaFact.Text)).ToString("N4")
                Impuestos.Traslados.Add(Impuesto)
                '        End If
            End If

            '    acum = False
            Dim ldImpIeps As Decimal = CDec(txtTotalIeps.Text)
            '    Dim ldPorcIeps As Decimal = CDec(det.Cells("clmPorcIEPS").Value)
            If ldImpIeps > 0 Then
                '        For Each imp As CFDI.ComprobanteImpuestosTraslado In Impuestos.Traslados
                '            If imp.impuesto = IntegraLab.CFDI.ComprobanteImpuestosTrasladoImpuesto.IEPS And imp.tasa = ldPorcIeps Then
                '                imp.importe = imp.importe + ldImpIeps
                '                acum = True
                '            End If
                '        Next
                For Each n As TasasIepsFact In listFact
                    For Each r As TasasIeps In list
                        If n.Tasa = r.Tasa Then
                            Dim obj As TasasIeps = list.Find(Function(column) column.Tasa = n.Tasa)
                            ' list.Remove(obj)
                            obj.Total -= n.Total
                            'list.Add(obj)
                        End If
                    Next
                Next
                For Each r As TasasIeps In list
                    If r.Total > 0 Then
                        Dim Impuesto As New CFDI.ComprobanteImpuestosTraslado
                        Impuesto.impuesto = Integralab.CFDI.ComprobanteImpuestosTrasladoImpuesto.IEPS
                        Impuesto.tasa = r.Tasa
                        Impuesto.importe = CDec(r.Total).ToString("N4")
                        Impuestos.Traslados.Add(Impuesto)
                    Else
                        TransG.Rollback()
                        Trans.Rollback()
                        'mtb.sbCambiarEstadoBotones("Nuevo")
                        cancelarE = True
                        MessageBox.Show("Se encontraron inconsistencias en los datos, favor de verificar con el administrador.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CargarDatos()
                        Exit Sub
                    End If
                Next
                '        If Not acum Then
                '            
                '        End If
            End If
            'Next
            Impuestos.CalcularTotalImpuestosRetenidos()
            Impuestos.CalcularTotalImpuestosTrasladados()

            'Dim ldPagoEfectivo, ldPagoTarjeta As Decimal
            Dim metodoPago As String
            'For Each nt As EC.NotaVentaEntity In ListaNotas
            '    ldPagoEfectivo += nt.Pago
            '    ldPagoTarjeta += nt.PagoTarj
            'Next
            'If ldPagoEfectivo > 0 And ldPagoTarjeta = 0 Then
            metodoPago = "EFECTIVO"
            'ElseIf ldPagoEfectivo = 0 And ldPagoTarjeta > 0 Then
            '    metodoPago = "TARJETA DE CREDITO"
            'Else
            '    metodoPago = "NO IDENTIFICADO"
            'End If


            '' Crea el objeto comprobante
            Fact = New CFDI.Comprobante(Emisor, Receptor, Conceptos, Impuestos, dtpFecha.Value, "", "PAGO EN UNA SOLA EXHIBICION", "", "", CDec(txtTotalSubtotal.Text) - CDec(txtSubTotalFact.Text), CDec(txtDiff.Text) - CDec(txtTotalFact.Text), IntegraLab.CFDI.ComprobanteTipoDeComprobante.ingreso, CveMetodoPago, Controlador.Sesion.MiEmpresa.EmpMunicipio + ", " + Controlador.Sesion.MiEmpresa.EmpEstado)
            With Fact
                .folio = Folio
                .serie = Controlador.Configuracion.FacturaFolios.StaLetraSerie
                .condicionesDePago = ""
                .descuento = 0
                .motivoDescuento = ""
                .TipoCambio = ""
                .Moneda = ""
                .NumCtaPago = NoCuenta
                .FolioFiscalOrig = ""
                .SerieFolioFiscalOrig = ""
                .MontoFolioFiscalOrig = 0
                .Observacion = txtObservacion.Text.Trim
                .eMail = DomFiscalCte.Email
            End With
#If DEBUG Then
            Dim cfdi As CFDI.ORM.CFDI = ControlFD.GenerarCFDI(Fact.folio, Fact, TransG, True, True)
#Else
                                    Dim cfdi As CFDI.ORM.CFDI = ControlFD.GenerarCFDI(Fact.folio, Fact, TransG, False, True)
#End If
            If File.Exists(Application.StartupPath + "\\" + "Error.txt") Then
                TransG.Rollback()
                File.ReadAllText(Application.StartupPath + "\\" + "Error.txt")
                MsgBox("Error al generar el CFDI." & vbCrLf & File.ReadAllText(Application.StartupPath + "\\" + "Error.txt"), MsgBoxStyle.Critical, "Facturación")
                Return
            End If
            Dim sumieps As Decimal = 0, iva As Decimal = 0

            FacturasCab = New CN.FacturasClientesCabClass
            ''GENERA FACTURA 
            FacturasCab.NoFactura = Folio 'FolioFactura.Consecutivo
            FacturasCab.Serie = Controlador.Configuracion.FacturaFolios.StaLetraSerie
            FacturasCab.FechaCaptura = Now
            FacturasCab.FechaFactura = dtpFecha.Value  'Me.dtFechaFactura.Value
            FacturasCab.FechaVencimiento = dtpFecha.Value
            ' contemplar si es cliente vario
            FacturasCab.IdCliente = CInt(Cliente.Codigo)
            FacturasCab.IdDomicilioFiscal = DomFiscalCte.IdRenglon
            FacturasCab.IdClienteCargo = CInt(Cliente.Codigo)

            FacturasCab.Contado = True    'Me.rdContado.Checked
            'FacturasCab.Credito = Me.rdCredito.Checked
            'FacturasCab.IdPoliza = PolizaCab.Codigo
            FacturasCab.Contabilizado = "N"
            'FacturasCab.FechaContabilizacion = FechaFactura
            FacturasCab.IVA = CDec(txtTotalIVA.Text) - CDec(txtivaFact.Text)
            FacturasCab.IEPS = CDec(Me.txtTotalIeps.Text) - CDec(txtiepsFact.Text)
            FacturasCab.SubTotal = CDec(Me.txtTotalSubtotal.Text) - CDec(txtSubTotalFact.Text)
            FacturasCab.Total = CDec(Me.txtDiff.Text) - CDec(txtTotalFact.Text)
            FacturasCab.Estatus = "V"
            FacturasCab.Observaciones = Me.txtObservacion.Text
            FacturasCab.TipoFactura = 1
            FacturasCab.Origen = "V"
            FacturasCab.UUID = cfdi.UUID.ToString()
            FacturasCab.FormaDePago = Fact.formaDePago
            FacturasCab.MetodoDePago = Fact.metodoDePago
            FacturasCab.CondicionesDePago = Fact.condicionesDePago
            FacturasCab.Func = "I"
            FacturasCab.NumOpc = 1

            If FacturasCab.Guardar(Trans) Then
                'guarda el concentrado por productos de la factura 

                ' For i As Integer = 0 To Me.dgvDetalleConcentrado.RowCount - 1
                FacturasDetProductosTotales = New CN.FacturasClientesDetProductosTotalesClass
                With FacturasDetProductosTotales
                    .SerieFactura = FacturasCab.Serie
                    .NoFactura = FacturasCab.NoFactura
                    .IdProducto = 0
                    '.KilosEmb = CDec(Me.dgvDetalleConcentrado.Rows(i).Cells("KilosEmbarcados").Value)
                    .KilosFac = 0
                    .Precio = CDec(Me.txtTotalSubtotal.Text) - CDec(txtSubTotalFact.Text)
                    '.ImporteEmb = CDec(Me.dgvDetalleConcentrado.Rows(i).Cells("ImporteEmbarcado").Value)
                    .ImporteFac = CDec(Me.txtDiff.Text) - CDec(txtTotalFact.Text)
                    .IVA = CDec(txtTotalIVA.Text) - CDec(txtivaFact.Text)
                    .IEPS = CDec(Me.txtTotalIeps.Text) - CDec(txtiepsFact.Text)
                    .Renglon = 1
                    '.Embarque = Me.lvNotasVenta.Items(0).Text
                End With

                If FacturasDetProductosTotales.Guardar(Trans) Then

                End If


                ' Next
            End If



            TransG.Commit()
            Trans.Commit()

            'File.WriteAllText(Application.StartupPath + "\\" + "Folio.txt", cfdi.UUID)
            'txtUUID.Text = cfdi.UUID
            
            Dim Ubicacion As String = ControlFD.GenerarArchivoPDF(cfdi, Conceptos)
            System.Diagnostics.Process.Start(Ubicacion)
            'MessageBox.Show("Se genero la factura")
            Application.DoEvents()
            CargarDatos()
        Catch ex As Exception
            If ex.Message = "No hay ninguna aplicación asociada con el archivo especificado para esta operación" Then
                MessageBox.Show("Debe instalar Adobe Reader para abrir los archivos pdf", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                TransG.Rollback()
                Trans.Rollback()
                MsgBox("Error al generar el CFDI." & vbCrLf & ex.Message, MsgBoxStyle.Critical, ex.Source)
                ' Return False
            End If
        End Try
        '-----------------------------------------------
        ' termina codigo agregado para generar el CFDI
        '-----------------------------------------------
    End Sub

    Private Sub Imprimir(ByVal CodNota As Integer)
        Dim prtSet As New PrinterSettings

        Try
            'For Each nomprt As String In PrinterSettings.InstalledPrinters
            '    If nomprt.ToUpper = "TICKET" Then
            '        prtSet.PrinterName = nomprt
            '    End If
            'Next

            'Dim ds As New Ccom.dsNotaVenta()
            'With ds
            '    .NotaVenta.AddNotaVentaRow(Nota.Codigo, Nota.IdSucursal, Nota.Sucursal.DescripcionCorta, Nota.Subtotal, Nota.Descuento, _
            '                               Nota.Total, Nota.FechaVenta, Nota.IVA, Nota.IEPS, 0, Nota.PagoEfectivo + Nota.PagoTarjeta, Nota.Cambio, Nota.UsuarioAlta, _
            '                               Nota.ObservacionesCancelacion)

            '    For Each det As CN.NotaVentaDetalleClass In Nota.Detalles
            '        .NotaVentaDetalle.AddNotaVentaDetalleRow(det.NotaVenta, det.IdProducto, det.Producto.Descripcion, det.Cantidad, det.Precio, det.Importe, det.Descuento, det.IVA, "", det.IEPS, ds.NotaVenta.Rows(0))
            '    Next
            'End With
            'Dim rep As New Ccom.crNotaVtaTck
            'rep.SetDataSource(ds)
            'rep.SetParameterValue("Encabezado", Controlador.Empresa.Nombre + vbNewLine + Controlador.Empresa.Domicilio + vbNewLine + Controlador.Empresa.RFC)
            'rep.SetParameterValue("Reimpresion", "")
            'rep.PrintOptions.PrinterName = "TICKET"
            'rep.PrintToPrinter(1, False, 0, 0)
            'rep.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#End Region

    Private Sub MEAToolBar_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickCancelar
        limpiar()
    End Sub

    Private Sub MEAToolBar_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickGuardar
        Cursor = Cursors.WaitCursor
        Try
            If txtDiff.Text.Trim().Equals("") Then
                MessageBox.Show("Campo a facturar vacio, verifique.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Cancelar = True
                Exit Sub
            End If
            Dim temp As Decimal = 0
            If Not Decimal.TryParse(txtDiff.Text.Trim(), temp) Then
                temp = 0
                MessageBox.Show("Formato incorrecto en el campo total a facturar, verifique.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Cancelar = True
                Exit Sub
            End If

            If temp <= 0 Then
                MessageBox.Show("Cantidad a facturar menor o igual a cero, verifique.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Cancelar = True
                Exit Sub
            End If


            Dim result As DialogResult = MessageBox.Show("¿ Desea facturar la venta del dia " & dtpFecha.Value.Date.ToString("dd/MM/yyyy") & " ?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If result = Windows.Forms.DialogResult.Yes Then

                Dim forma As New frmMetodoPagoEmergente
                Dim reult As DialogResult = forma.ShowDialog

                If reult = Windows.Forms.DialogResult.OK Then
                    CveMetodoPago = forma.MetodoPagoCVE
                    NoCuenta = forma.NumeroCuenta
                Else
                    CveMetodoPago = ""
                    NoCuenta = ""
                    Cancelar = True
                    Exit Sub
                End If

                Dim fecha As String
                fecha = InputBox("Confirme la fecha por favor " & dtpFecha.Value.Date.ToString("dd/MM/yyyy") & " :", "AVISO")
                If fecha.Equals(dtpFecha.Value.Date.ToString("dd/MM/yyyy")) Then
                    guardar()
                Else
                    MessageBox.Show("Confirmación incorrecta, verifique.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Cancelar = True
                End If


            Else
                Cancelar = True
            End If



            'If Me.TxtPorc.Text = "" Then
            '    MsgBox("Debe ingresar una descripción", MsgBoxStyle.Exclamation, "Faltan Datos")
            '    Cancelar = False
            '    Exit Sub
            'End If

            'puedorefrescar = False
            'guardar()
            'puedorefrescar = True

            'If Ciudad.Guardar Then
            '    If Editar Then
            '        MsgBox("La Ciudad se ha modificado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
            '    Else
            '        MsgBox("La Ciudad se ha guardado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
            '    End If

            '    limpiar()
            'Else
            '    Cancelar = True
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
        Finally
            If cancelarE Then
                Cancelar = True
            End If

            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean)
    End Sub

    Private Sub MEAToolBar_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub MEAToolBar_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean)
        limpiar()
        Editar = False
    End Sub

    Private Sub btnCambiaFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiaFecha.Click
        'dtpFecha.MinDate = #1/1/2000#
        'dtpFecha.MaxDate = Date.Today
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpFecha.ValueChanged
        CargarDatos()
    End Sub

    Private Sub frmFacturasVtaDiaria_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        CargarDatos()
    End Sub
End Class