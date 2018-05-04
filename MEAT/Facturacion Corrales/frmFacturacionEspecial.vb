Imports ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports System.Data.SqlClient
Imports Integralab
Imports Integralab.FactDigital
Imports System.IO


Public Class frmFacturacionEspecial

#Region "Miembros"
    Dim FacturaCabecero As FacturasClass
    Dim ClientesCol As ClientesIntroductoresColeccion
    Dim ProductosGenCol As ProductoCollectionClass
    Dim ConF As New CC.ConfiguracionFacturaCollection
    Dim NumRenglones As Integer
    Dim PolizaDet2 As New PolizaDetalleClass
    Dim Poliza As New PolizaClass
    Dim configurarImprecion As Boolean = True
    Dim DomFiscalCte2 As DomicilioClienteClass
    Dim SumaCargo As Decimal
    Dim SumaAbono As Decimal
    Dim Band As Boolean
    Dim PolizaACancelar As String
    Dim dtProdServ As New DataTable
    Dim dtUnidades As New DataTable
    Dim Buscarr As Boolean
#End Region

#Region "Metodos"
    Private Sub Habilitar()
        Me.txtFolioFactura.Enabled = True
        Me.dtFechaFactura.Enabled = True
        Me.dtpFechaVencimiento.Enabled = True
        Me.txtCodigoCliente.Enabled = True
        Me.CmbCliente.Enabled = True
        Me.txtDireccion.Enabled = True
        Me.txtRFC.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.txtDiasCredito.Enabled = True
        Me.rdContado.Enabled = True
        Me.rdCredito.Enabled = True
        Me.ultcmbDomiciliosFiscales.Enabled = True
        Me.dgvDetalle.Enabled = True
        Me.gbFormaPago.Enabled = True
        txtlugarexpedicion.Enabled = True
        Me.txtDescuento.Enabled = True
        cmbUsoCFDI.Enabled = True
        gbFacturar.Enabled = True
        txtUUID.Enabled = True
        dgvCuentasContables.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        Me.txtFolioFactura.Enabled = False
        Me.dtFechaFactura.Enabled = False
        Me.dtpFechaVencimiento.Enabled = False
        Me.txtCodigoCliente.Enabled = False
        Me.CmbCliente.Enabled = False
        Me.txtDireccion.Enabled = False
        Me.txtRFC.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.txtDiasCredito.Enabled = False
        Me.rdContado.Enabled = False
        Me.rdCredito.Enabled = False
        Me.CmbClientesVarios.Enabled = False
        Me.ultcmbDomiciliosFiscales.Enabled = False
        Me.dgvDetalle.Enabled = False
        Me.gbFormaPago.Enabled = False
        txtlugarexpedicion.Enabled = False
        Me.txtDescuento.Enabled = False
        cmbUsoCFDI.Enabled = False
        gbFacturar.Enabled = False
        txtUUID.Enabled = False
        dgvCuentasContables.Enabled = False
    End Sub

    Private Function Limpiar() As Boolean
        Me.txtCodigoCliente.Text = ""
        Me.CmbCliente.Text = "0"
        Me.txtDiasCredito.Text = "0"
        Me.txtDireccion.Text = ""
        Me.txtFolioFactura.Text = ""
        Me.txtIVA.Text = "0"
        Me.txtObservaciones.Text = ""
        Me.txtRFC.Text = ""
        Me.txtSubTotal.Text = "0"
        Me.txtTotal.Text = "0"
        Me.txtDescuento.Text = "0"
        Me.txtSumaCargo.Text = "0"
        Me.txtSumaAbono.Text = "0"
        Me.dgvDetalle.Rows.Clear()
        Me.dgvCuentasContables.Rows.Clear()
        'Me.ProductosVistaC.Obtener(CondicionEnum.ACTIVOS)
        'Me.clmProductoDes.DisplayMember = "Descripcion"
        'Me.clmProductoDes.ValueMember = "Codigo"
        'Me.clmProductoDes.DataSource = Me.ProductosVistaC


        Me.lblEstatus.Visible = False
        Me.dtFechaFactura.Value = Now
        Me.dtpFechaVencimiento.Value = Now
        Me.ultcmbDomiciliosFiscales.DataSource = Nothing
        cmbformadepago.SelectedIndex = -1
        cmbmetododepago.SelectedIndex = -1
        cmbUsoCFDI.SelectedIndex = -1
        cmbUsoCFDI.Text = "Seleccione el uso del cfdi..."
        cmbformadepago.Text = "Seleccione la forma de pago..."
        cmbmetododepago.Text = "Seleccione la método de pago..."
        txtlugarexpedicion.Text = ""
        dgvDetalle.AllowUserToAddRows = True
        dgvCuentasContables.AllowUserToAddRows = True

        Me.txtSubTotal.Text = "0.00"
        Me.txtDescuento.Text = "0.00"
        Me.txtIVA.Text = "0.00"
        Me.txtTotal.Text = "0.00"
        Me.OptProductos.Checked = True
        txtNumCta.Text = ""
        OptExternos.Checked = True
        txtUUID.Text = ""
        Buscarr = False
        Band = False
        CmbCliente.SelectedIndex = -1
        Band = True
        ultcmbDomiciliosFiscales.Value = Nothing

    End Function

    Public Function validar() As Boolean
        Try
            If Me.OptProductos.Checked = True Then
                If Trim(Me.dgvDetalle.Rows(0).Cells(Me.clmProductoDes.Index).Value) = "" Then
                    MessageBox.Show("Falta detalle para guardar Factura Especial", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If
            Else
                If Trim(Me.dgvDetalle.Rows(0).Cells(Me.clmDescripcionEspecial.Index).Value) = "" Then
                    MessageBox.Show("Falta detalle para guardar Factura Especial", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If

            End If

            If Trim(Me.dgvCuentasContables.Rows(0).Cells(Me.clmDescripcion.Index).Value) = "" Then
                MessageBox.Show("Falta detalle de cuentas contables para guardar Facturar Especial", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            If cmbmetododepago.SelectedIndex = -1 Or cmbmetododepago.SelectedValue = Nothing Then
                MessageBox.Show("Falta seleccionar método de pago para guardar Facturar Especial", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            If cmbformadepago.SelectedIndex = -1 Or cmbformadepago.SelectedValue = Nothing Then
                MessageBox.Show("Falta seleccionar forma de pago para guardar Facturar Especial", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            If txtlugarexpedicion.Text.Trim().Equals("") Then
                MessageBox.Show("Falta lugar de expedición (Cod. Postal) para guardar Facturar Especial", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            If ultcmbDomiciliosFiscales.Value Is Nothing Then
                MessageBox.Show("Falta seleccionar el domicilio fiscal.", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If



            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function ObtenerComprobante(ByVal Comprobante As CFDI.Comprobante, ByVal Folio As String, ByVal Serie As String, Optional ByVal EsParaPDF As Boolean = False)

        Dim ComprobanteImpuestos As New CFDI.ComprobanteImpuestos
        Dim RegimenFis As CFDI.c_RegimenFiscal
        RegimenFis = DirectCast([Enum].Parse(GetType(CFDI.c_RegimenFiscal), "_" + Controlador.Sesion.MiEmpresa.EmpRegimenFiscal.Trim()), CFDI.c_RegimenFiscal)
        Dim Emisor As New CFDI.ComprobanteEmisor(Controlador.Sesion.MiEmpresa.EmpRfc, RegimenFis)
        Dim Cliente As ClientesIntroductoresClass
        Dim DomFiscalCte As DomicilioClienteClass
        DomFiscalCte = DirectCast(DirectCast(ultcmbDomiciliosFiscales.SelectedRow.ListObject, Object), DomicilioClienteClass)
        DomFiscalCte2 = DomFiscalCte
        Cliente = New ClientesIntroductoresClass(CInt(CmbCliente.SelectedValue))

        Dim Receptor As New CFDI.ComprobanteReceptor(Cliente.RFC.Replace("_", "").Replace("-", "").Replace(" ", ""))
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
        ControlFD = New Integralab.FactDigital.ControladorFactDigital(Controlador.Empresa.CodEmpndx, ConStr)

        Try
            Dim DomicilioFiscal As CFDI.UbicacionFiscal
            Dim RegimenFiscalEmisor As New List(Of CFDI.ComprobanteEmisorRegimenFiscal)
            Dim ExpedidoEn As New Integralab.CFDI.Ubicacion("MEXICO")


            If EsParaPDF Then
                DomicilioFiscal = New CFDI.UbicacionFiscal(Controlador.Sesion.MiEmpresa.EmpCalle, Controlador.Sesion.MiEmpresa.EmpLocalidad, Controlador.Sesion.MiEmpresa.EmpEstado, "MEXICO", Controlador.Sesion.MiEmpresa.EmpCodigoPostal)
                DomicilioFiscal.colonia = Controlador.Sesion.MiEmpresa.EmpColonia
                DomicilioFiscal.noExterior = Controlador.Sesion.MiEmpresa.EmpNoExt
                DomicilioFiscal.noInterior = Controlador.Sesion.MiEmpresa.EmpNoInt
                Emisor.DomicilioFiscal = DomicilioFiscal

                RegimenFiscalEmisor.Add(New CFDI.ComprobanteEmisorRegimenFiscal(Controlador.Sesion.MiEmpresa.EmpRegimenFiscal))
                Emisor.RegimenFiscalEmisor = RegimenFiscalEmisor(0)

                ExpedidoEn.municipio = Controlador.Sesion.MiEmpresa.EmpLocalidad
                ExpedidoEn.estado = Controlador.Sesion.MiEmpresa.EmpEstado

                Emisor.ExpedidoEn = ExpedidoEn

                Dim Domicilio As New CFDI.Ubicacion("MEXICO")
                Domicilio.calle = DomFiscalCte.Calle
                Domicilio.colonia = DomFiscalCte.Colonia
                Domicilio.codigoPostal = DomFiscalCte.CodigPostal
                Domicilio.noExterior = DomFiscalCte.NoExt
                Domicilio.noInterior = DomFiscalCte.NoInt
                Domicilio.localidad = DomFiscalCte.Poblacion.Descripcion
                Domicilio.municipio = DomFiscalCte.Ciudad.Descripcion
                Domicilio.estado = DomFiscalCte.Estado.Descripcion
                'Domicilio.referencia = CompA.Receptor.Domicilio.Referencia

                Receptor.Domicilio = Domicilio
            End If

            Emisor.Nombre = Controlador.Sesion.MiEmpresa.Empnom

            Receptor.Nombre = Cliente.RazonSocial
            Dim usoCFDI As CFDI.c_UsoCFDI
            usoCFDI = [Enum].Parse(GetType(CFDI.c_UsoCFDI), cmbUsoCFDI.SelectedValue)
            Receptor.UsoCFDI = usoCFDI

            Dim IvaAL0 As Boolean
            IvaAL0 = False
            Dim Conceptos As New List(Of CFDI.ComprobanteConcepto)()
            For Each row As DataGridViewRow In dgvDetalle.Rows
                If Not row.IsNewRow Then
                    Dim ConceptosImpuestos As New CFDI.ComprobanteConceptoImpuestos
                    Dim ConceptosImpuestosTraslados As New List(Of CFDI.ComprobanteConceptoImpuestosTraslado)()
                    Dim Concepto As CFDI.ComprobanteConcepto

                    With row

                        Dim CveProdServ = DirectCast([Enum].Parse(GetType(CFDI.c_ClaveProdServ), .Cells(clmProductoServicio.Index).Value.ToString()), CFDI.c_ClaveProdServ)
                        Dim CveUnidadS = DirectCast([Enum].Parse(GetType(CFDI.c_ClaveUnidad), .Cells(clmUnidadSat.Index).Value.ToString()), CFDI.c_ClaveUnidad)

                        Concepto = New CFDI.ComprobanteConcepto(CveProdServ, .Cells(clmUnidadSat.Index).Value.ToString(), String.Format("{0:D5}", (row.Index + 1)), CDec(.Cells(clmCantidad.Index).Value), .Cells(clmUnidad.Index).Value.ToString(), IIf(.Cells(clmProductoDes.Index).Visible = True, .Cells(clmProductoDes.Index).EditedFormattedValue.ToString(), .Cells(clmDescripcionEspecial.Index).EditedFormattedValue), CDec(.Cells(clmPrecio.Index).Value), CDec(.Cells(clmImporte.Index).Value) - CDec(.Cells(clmIVA.Index).Value))

                        Dim ComprobanteImpuestosTraslados As New List(Of CFDI.ComprobanteConceptoImpuestosTraslado)()
                        'If CDec(.Cells(clmIVA.Index).Value) > 0 Then
                        Dim PorcIva As Decimal
                        PorcIva = Math.Round(Controlador.ObtenerIVA() / 100, 6, MidpointRounding.AwayFromZero)
                        Dim ComprobanteImpuestoTraslado As New CFDI.ComprobanteConceptoImpuestosTraslado
                        ComprobanteImpuestoTraslado.Base = Math.Round(CDec(.Cells(clmPrecio.Index).Value) * CDec(.Cells(clmCantidad.Index).Value), 2, MidpointRounding.AwayFromZero)
                        ComprobanteImpuestoTraslado.Impuesto = CFDI.c_Impuesto._002
                        ComprobanteImpuestoTraslado.TipoFactor = CFDI.c_TipoFactor.Tasa
                        If CDec(.Cells(clmIVA.Index).Value) > 0 Then
                            ComprobanteImpuestoTraslado.TasaOCuota = PorcIva.ToString("N6")
                            ComprobanteImpuestoTraslado.Importe = Math.Round(CDec(.Cells(clmIVA.Index).Value), 2, MidpointRounding.AwayFromZero)
                            IvaAL0 = False
                        Else
                            ComprobanteImpuestoTraslado.TasaOCuota = 0.ToString("N6")
                            ComprobanteImpuestoTraslado.Importe = Math.Round(CDec(.Cells(clmIVA.Index).Value), 2, MidpointRounding.AwayFromZero)
                            IvaAL0 = True
                        End If
                        ComprobanteImpuestoTraslado.TasaOCuotaSpecified = True
                        ComprobanteImpuestoTraslado.ImporteSpecified = True

                        ComprobanteImpuestosTraslados.Add(ComprobanteImpuestoTraslado)
                        'End If

                        If ComprobanteImpuestosTraslados.Count > 0 Then
                            ConceptosImpuestos.Traslados = ComprobanteImpuestosTraslados
                        End If
                        If Not IsNothing(ConceptosImpuestos.Traslados) Then
                            If ConceptosImpuestos.Traslados.Count > 0 Then
                                Concepto.Impuestos = ConceptosImpuestos
                            End If
                        End If

                    End With
                    Conceptos.Add(Concepto)
                End If
            Next
            'Comprobante.Conceptos = Conceptos
            Dim ComprobanteImpuestoTraslados As New List(Of CFDI.ComprobanteImpuestosTraslado)
            If IvaAL0 Then

                Dim ComprobanteImpuestoTraslado As New CFDI.ComprobanteImpuestosTraslado
                ComprobanteImpuestoTraslado.Impuesto = CFDI.c_Impuesto._002
                ComprobanteImpuestoTraslado.TipoFactor = CFDI.c_TipoFactor.Tasa
                ComprobanteImpuestoTraslado.TasaOCuota = 0.ToString("N6")
                ComprobanteImpuestoTraslado.Importe = Math.Round(0D, 2, MidpointRounding.AwayFromZero)

                ComprobanteImpuestoTraslados.Add(ComprobanteImpuestoTraslado)
                'If CDec(txtIVA.Text.Trim()) <= 0 Then
                '    ComprobanteImpuestos.Traslados = ComprobanteImpuestoTraslados
                'End If

            End If


            If Not txtIVA.Text.Trim().Equals("") Then
                If CDec(txtIVA.Text.Trim()) > 0 Then
                    Dim PorcIva As Decimal
                    PorcIva = Math.Round(Controlador.ObtenerIVA() / 100, 6, MidpointRounding.AwayFromZero)

                    'Dim ComprobanteImpuestoTraslados As New List(Of CFDI.ComprobanteImpuestosTraslado)
                    Dim ComprobanteImpuestoTraslado As New CFDI.ComprobanteImpuestosTraslado
                    ComprobanteImpuestoTraslado.Impuesto = CFDI.c_Impuesto._002
                    ComprobanteImpuestoTraslado.TipoFactor = CFDI.c_TipoFactor.Tasa
                    ComprobanteImpuestoTraslado.TasaOCuota = PorcIva.ToString("N6")
                    ComprobanteImpuestoTraslado.Importe = Math.Round(CDec(txtIVA.Text.Trim()), 2, MidpointRounding.AwayFromZero)

                    ComprobanteImpuestoTraslados.Add(ComprobanteImpuestoTraslado)

                    'ComprobanteImpuestos.Traslados = ComprobanteImpuestoTraslados
                    'ComprobanteImpuestos.TotalImpuestosTrasladados = Math.Round(CDec(txtIVA.Text.Trim()), 2, MidpointRounding.AwayFromZero)
                    'Comprobante.Impuestos = ComprobanteImpuestos

                End If
            End If
            If ComprobanteImpuestoTraslados.Count > 0 Then
                ComprobanteImpuestos.Traslados = ComprobanteImpuestoTraslados
                ComprobanteImpuestos.CalcularTotalImpuestosTrasladados()
                ComprobanteImpuestos.TotalImpuestosTrasladadosSpecified = True
            End If


            Dim formaPago = DirectCast([Enum].Parse(GetType(CFDI.c_FormaPago), cmbformadepago.SelectedValue.ToString()), CFDI.c_FormaPago)
            Dim metodoPago = DirectCast([Enum].Parse(GetType(CFDI.c_MetodoPago), cmbmetododepago.SelectedValue.ToString()), CFDI.c_MetodoPago)
            Comprobante = New CFDI.Comprobante(Emisor, Receptor, Conceptos, ComprobanteImpuestos, dtFechaFactura.Value, "", formaPago, "", "", _
                      Math.Round(CDec(txtSubTotal.Text.Trim()), 2, MidpointRounding.AwayFromZero), Math.Round(CDec(txtTotal.Text.Trim()), 2, MidpointRounding.AwayFromZero), CFDI.c_TipoDeComprobante.I, metodoPago, txtlugarexpedicion.Tag.ToString())

            With Comprobante
                .Folio = Folio
                .Serie = Serie
                If Not txtDescuento.Text.Trim().Equals("") Then
                    .Descuento = CDec(txtDescuento.Text.Trim())
                Else
                    .Descuento = 0
                End If
                If EsParaPDF Then
                    If Not txtNumCta.Text.Trim().Equals("") Then
                        .NumCtaPago = txtNumCta.Text.Trim()
                    End If
                End If
                .CondicionesDePago = IIf(Me.rdContado.Checked, "CONTADO", "CREDITO")


                .TipoCambio = 1.0
                .Moneda = CFDI.c_Moneda.MXN
                .Observacion = txtObservaciones.Text.Trim
                .eMail = DomFiscalCte.Email
            End With
            Return Comprobante



        Catch ex As Exception
            If ex.Message = "No hay ninguna aplicación asociada con el archivo especificado para esta operación" Then
                MessageBox.Show("Debe instalar Adobe Reader para abrir los archivos pdf", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else


                'TransG.Rollback()
                MsgBox("Error al generar el CFDI." & vbCrLf & ex.Message, MsgBoxStyle.Critical, ex.Source)
                Return False
            End If
        End Try


    End Function

    Public Function Guardar(ByVal Trans As HC.Transaction, ByVal Estatus As String) As Boolean

        Dim ControlFD As Integralab.FactDigital.ControladorFactDigital
        Dim ConStr As String
        If File.Exists(Application.StartupPath + "\\cx.dat") Then
            ConStr = Integralab.FactDigital.ControladorFactDigital.Decrypt(File.ReadAllText(Application.StartupPath + "\\cx.dat"))
        Else
            Throw New Exception("No se ha configurado la conexión a la base de datos de la factura digital.")
        End If
        ControlFD = New Integralab.FactDigital.ControladorFactDigital(Controlador.Empresa.CodEmpndx, ConStr)

        Cursor = Cursors.WaitCursor
        MEAToolBar1.Enabled = False
        Application.DoEvents()

        Dim TransG As New Gentle.Framework.Transaction(Integralab.FactDigital.ControladorFactDigital.Conexion)
        Try

            If Not validar() Then
                Return False
                Exit Function
            End If

            'System.Threading.Thread.Sleep(6000)
            'Application.DoEvents()
            'Cursor = Cursors.Default
            'TransG.Rollback()
            'MessageBox.Show("Ocurrio un problema, error no controlado.", "SAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Return False
            'DomFiscalCte.Obtener(CmbCliente.SelectedValue, )
            'DomFiscalCte = DirectCast(ultcmbDomiciliosFiscales.SelectedRow.cell, DomicilioClienteClass)
            If Estatus = "V" Then
                Dim Folio As New FoliosClass 'variable para la clase de folio
                'Dim FacturasDetalleCol As New CN.FacturasDetalleCollectionClass ' para crear la coleccion de detalle
                'Dim FacturasDet As New EC.DetFacturasEntity 'para agregar al detalle
                'para crear el folio de la factura

                Folio.Codigo = CodigodeFolios.FacturasVentasyCorrales
                Folio.Año = Year(dtFechaFactura.Value)
                Folio.Mes = Month(dtFechaFactura.Value)


                If Not Folio.Guardar(Trans) Then
                    Trans.Rollback()
                    Cursor = Cursors.Default
                    MEAToolBar1.Enabled = True
                    MessageBox.Show("Error al generar folio de Factura", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

                Dim Fact As CFDI.Comprobante
                Fact = ObtenerComprobante(Fact, Folio.Consecutivo.ToString("0000000"), "A")

                Dim FactPDF As CFDI.Comprobante
                FactPDF = ObtenerComprobante(FactPDF, Folio.Consecutivo.ToString("0000000"), "A", True)


#If DEBUG Then
                Dim cfdi As CFDI.ORM.CFDI = ControlFD.GenerarCFDI(Fact.Folio, Fact, TransG, True, True, FactPDF)
#Else
                Dim cfdi As CFDI.ORM.CFDI = ControlFD.GenerarCFDI(Fact.Folio, Fact, TransG, False, True, FactPDF)
#End If
                If File.Exists(Application.StartupPath + "\\" + "Error.txt") Then
                    TransG.Rollback()
                    Cursor = Cursors.Default
                    MEAToolBar1.Enabled = True
                    File.ReadAllText(Application.StartupPath + "\\" + "Error.txt")
                    MsgBox("Error al generar el CFDI." & vbCrLf & File.ReadAllText(Application.StartupPath + "\\" + "Error.txt"), MsgBoxStyle.Critical, "Facturación")
                    Return False
                End If


                'folio de la factura
                FacturaCabecero.NoFactura = "F" & Folio.Consecutivo.ToString("0000000")

                'guardar poliza
                Dim Poliza As New PolizaClass
                Dim Poliza2 As New PolizaClass
                'se guarda la poliza en contabilidad
                Poliza.Concepto = "Cargo por Factura Especial a: " & Trim(Me.CmbCliente.Text) & " # Factura : " & FacturaCabecero.NoFactura
                Poliza.EmpresaId = Controlador.Sesion.MiEmpresa.Empndx
                Poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.ACTIVA
                Poliza.FechaCaptura = Now
                Poliza.FechaPoliza = Me.dtFechaFactura.Value
                Poliza.Importe = Me.txtTotal.Text
                Poliza.Origen = ClasesNegocio.PolizaOrigenEnum.VENTAS
                Poliza.TipoCambio = 1
                Poliza.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.DIARIO
                Poliza.TipoError = 0


                'Se crea el detalle de la poliza
                For i As Integer = 0 To Me.dgvCuentasContables.Rows.Count - 1
                    If CType(Me.dgvCuentasContables.Rows(i).Cells(Me.clmCargo.Index).Value, Decimal) > 0D Then
                        Dim CuentaCon As New CuentaContableClass
                        Dim PolizaDet As New PolizaDetalleClass
                        CuentaCon.Obtener(CType(Me.dgvCuentasContables.Rows(i).Cells("ClmCodigoCuenta").Value, Integer))
                        PolizaDet.Operacion2 = ClasesNegocio.PolizaOperacionEnum2.C
                        PolizaDet.CuentaContable = CuentaCon
                        PolizaDet.Posicion = i + 1
                        PolizaDet.Importe = CType(Me.dgvCuentasContables.Rows(i).Cells(Me.clmCargo.Index).Value, Decimal)
                        Poliza.Detalles2.Add(PolizaDet)
                        PolizaDet2 = PolizaDet
                        'Poliza.AgregarDetalle(PolizaDet)
                    ElseIf CType(Me.dgvCuentasContables.Rows(i).Cells(Me.clmAbono.Index).Value, Decimal) > 0D Then
                        Dim CuentaCon As New CuentaContableClass
                        Dim PolizaDet As New PolizaDetalleClass
                        CuentaCon.Obtener(CType(Me.dgvCuentasContables.Rows(i).Cells("ClmCodigoCuenta").Value, Integer))
                        PolizaDet.Operacion2 = ClasesNegocio.PolizaOperacionEnum2.A
                        PolizaDet.CuentaContable = CuentaCon
                        PolizaDet.Posicion = i + 1
                        PolizaDet.Importe = CType(Me.dgvCuentasContables.Rows(i).Cells(Me.clmAbono.Index).Value, Decimal)
                        Poliza.Detalles2.Add(PolizaDet)
                        'Poliza.AgregarDetalle(PolizaDet)
                    End If

                Next

                If Not Poliza.Detalles2.Count > 0 Then
                    MsgBox("Se cancelara la instrucción debido a que no se encuentra el detalle de la poliza", MsgBoxStyle.Exclamation, "Aviso")
                    Trans.Rollback()
                    Cursor = Cursors.Default
                    MEAToolBar1.Enabled = True
                    Exit Function
                End If

                If Not Poliza.Guardar2(Trans) Then
                    Trans.Rollback()
                    Cursor = Cursors.Default
                    MEAToolBar1.Enabled = True
                    MessageBox.Show("No se Guardo la poliza", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Function
                End If

                'guardar facturas
                'asignar datos a la factura
                'asignar datos a cabecero de factura

                Me.txtFolioFactura.Text = FacturaCabecero.NoFactura
                FacturaCabecero.FechaFactura = Me.dtFechaFactura.Value
                FacturaCabecero.FechaVencimiento = Me.dtpFechaVencimiento.Value
                FacturaCabecero.SubTotal = CDec(Me.txtSubTotal.Text)
                FacturaCabecero.ImporteDescuento = CDec(Me.txtDescuento.Text)
                FacturaCabecero.Cliente = CType(Me.CmbCliente.SelectedValue, Integer)
                FacturaCabecero.ClaveUsuario = Controlador.Sesion.MiUsuario.Usrndx
                FacturaCabecero.DiasCredito = Integer.Parse(Me.txtDiasCredito.Text)
                'FacturaCabecero.Referencia = 0f
                FacturaCabecero.FolPoliza = Poliza.Codigo
                FacturaCabecero.Estatus = "V"
                FacturaCabecero.StaFacturacion = "S"
                FacturaCabecero.LugarExpedicion = txtlugarexpedicion.Text.Trim()
                FacturaCabecero.FormaPago = CStr(cmbformadepago.SelectedValue)
                FacturaCabecero.MetodoPago = CStr(cmbmetododepago.SelectedValue)
                FacturaCabecero.NumCta = CStr(txtNumCta.Text.Trim())
                FacturaCabecero.UUID = cfdi.UUID.ToString()
                FacturaCabecero.UsoCfdi = CStr(cmbUsoCFDI.SelectedValue)
                FacturaCabecero.Observaciones = txtObservaciones.Text
                FacturaCabecero.Direccion = txtDireccion.Text

                'guardar cabecero
                Controlador.RealizarFacturasdeVenta(FacturaCabecero, Now, ClasesNegocio.TipoFacturaEnum.FACTURACION_ESPECIAL, Trans)

                'agregar a la clase detalle de facturas
                For i As Integer = 0 To Me.dgvDetalle.RowCount - 1
                    If Not Me.dgvDetalle.Rows(i).IsNewRow Then
                        Dim FacturasDetalle As New FacturasDetalleClass
                        If Me.OptProductos.Checked = True Then
                            FacturasDetalle.CveProducto = CType(Me.dgvDetalle.Rows(i).Cells(Me.clmCodigo.Index).Value, Integer)
                        Else
                            FacturasDetalle.Descripcion = Me.dgvDetalle.Rows(i).Cells(Me.clmDescripcionEspecial.Index).Value.ToString
                        End If
                        FacturasDetalle.PrecioUnitario = CType(Me.dgvDetalle.Rows(i).Cells(Me.clmPrecio.Index).Value, Decimal)
                        FacturasDetalle.CantidadxProducto = CType(Me.dgvDetalle.Rows(i).Cells(Me.clmCantidad.Index).Value, Decimal)
                        FacturasDetalle.PorcentajeIVA = CType(Me.dgvDetalle.Rows(i).Cells(Me.clmImporte.Index).Value, Decimal)
                        FacturasDetalle.Renglon = i
                        FacturasDetalle.Servicios = "N"
                        FacturasDetalle.TipoFactura = TipoFacturaEnum.FACTURACION_ESPECIAL
                        FacturasDetalle.Estatus = "V"
                        FacturasDetalle.CveProductoServ = CStr(Me.dgvDetalle.Rows(i).Cells(Me.clmProductoServicio.Index).Value)
                        FacturasDetalle.CveUnidad = CStr(Me.dgvDetalle.Rows(i).Cells(Me.clmUnidadSat.Index).Value)
                        FacturasDetalle.IVA = CDec(Me.dgvDetalle.Rows(i).Cells(Me.clmIVA.Index).Value)
                        FacturasDetalle.Total = CDec(Me.dgvDetalle.Rows(i).Cells(Me.clmImporte.Index).Value)
                        FacturasDetalle.Subtotal = TruncateDecimal(CDec(Me.dgvDetalle.Rows(i).Cells(Me.clmImporte.Index).Value) - CDec(Me.dgvDetalle.Rows(i).Cells(Me.clmIVA.Index).Value), 2)
                        FacturasDetalle.Unidad = CStr(Me.dgvDetalle.Rows(i).Cells(Me.clmUnidad.Index).Value)
                        'guardar el detalle
                        Controlador.RealizarFacturasdeVentaenDetalle(FacturasDetalle, Me.txtFolioFactura.Text, Trans)
                    End If
                Next

                TransG.Commit()


                Dim Ubicacion As String = ControlFD.GenerarArchivoPDF(cfdi, Fact.Conceptos, 0, FactPDF)
                Application.DoEvents()
                Cursor = Cursors.Default
                Dim Procesar As New Process()

                Procesar.StartInfo.FileName = Ubicacion
                Procesar.StartInfo.CreateNoWindow = True

                Procesar.Start()
                Trans.Commit()
                Cursor.Current = Cursors.Default


                Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
                Dim cmd As New SqlCommand
                Try

                    sqlCon.Open()
                    cmd.Connection = sqlCon
                    cmd.CommandText = "INSERT INTO GastosDepartamentalesFG VALUES('" & 0 & "','" & cmbsucursal.SelectedValue & "','" & 100 & "','" & CInt(txtTotal.Text) & "','" & cmbmetodo.SelectedValue & "','" & PolizaDet2.IdCuentaContable & "','" & String.Format("{0:yyyyMMdd}", Poliza.FechaCaptura) & "','" & 0 & "','" & txtFolioFactura.Text & "','" & CmbCliente.SelectedValue & "','" & Poliza.EmpresaId & "')"
                    cmd.ExecuteNonQuery()
                    sqlCon.Close()

                Catch exe As Exception
                    MsgBox("Error al insertar en la tabla GastosDepartamenralesFG")
                End Try
                Dim sqlCone As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
                Try

                    'Dim cadenaConsulta As String = "INSERT INTO GastosDepartamentosDetFG
                    'cadenaConsulta = String.Format(cadenaConsulta, cmbsucursal.SelectedValue, cmbmetodo.SelectedValue, PolizaDet2.IdCuentaContable, txtFolioFactura.Text, 3, 100, CmbCliente.SelectedValue)
                    sqlCone.Open()
                    cmd.Connection = sqlCone
                    cmd.CommandText = "INSERT INTO GastosDepartamentosDetFG VALUES('" & cmbsucursal.SelectedValue & "','" & cmbmetodo.SelectedValue & "','" & PolizaDet2.IdCuentaContable & "','" & String.Format("{0:yyyyMMdd}", Poliza.FechaCaptura) & "','" & DomFiscalCte2.IdDepartamento & "','" & 100 & "'," & 0 & ")"
                    cmd.ExecuteNonQuery()
                    sqlCone.Close()

                Catch exe As Exception

                End Try




                MessageBox.Show("La Factura de Reciba a Venta se ha realizado satisfactoriamente con el folio: " & FacturaCabecero.FolFactura, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                FacturaCabecero.Estatus = "C"
                Controlador.RealizarFacturasdeVenta(FacturaCabecero, Now, ClasesNegocio.TipoFacturaEnum.FACTURACION_DE_VENTA_DE_CORRAL, Trans)
            End If
            Cursor = Cursors.Default
            MEAToolBar1.Enabled = True
            Application.DoEvents()
            Return True

        Catch ex As Exception
            Cursor = Cursors.Default
            MEAToolBar1.Enabled = True
            If ex.Message = "No hay ninguna aplicación asociada con el archivo especificado para esta operación" Then
                Cursor.Current = Cursors.Default


                'DomFiscalCte = DirectCast(DirectCast(ultcmbDomiciliosFiscales.SelectedRow.ListObject, Object), DomicilioClienteClass)



                MessageBox.Show("Debe instalar Adobe Reader para abrir los archivos pdf", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                Cursor.Current = Cursors.Default
                TransG.Rollback()
                MsgBox("Error al generar el CFDI." & vbCrLf & ex.Message, MsgBoxStyle.Critical, ex.Source)
                Return False
            End If
        End Try

    End Function

    Private Function Imprimir(ByVal DomicilioCliente As DomicilioClienteClass, Optional ByVal conRFC As Boolean = True) As Boolean
        Try
            'Dim I As Integer
            'Fact = FacturasCab.Obtener(3, Me.txtFolioFactura.Text)
            Dim Imp As New EscritorClass(80, 60)
            Dim Fact As New FacturasCollectionClass
            Dim ClientesImp As New ClientesIntroductoresClass
            Fact = Controlador.ObtenerFacturasDeVenta(Me.txtFolioFactura.Text)
            'Dim Fact1 As DataSet = FacturasCab.Obtener(4, Me.txtFolioFactura.Text)
            Dim Convertir As New ConvertirNumeroALetraClass
            'If Fact.Tables(0).Rows.Count = 0 Then
            ' Fact = Fact1zw
            ' End If
            'Fact = FacturasCab.Obtener(Me.txtFolioFactura.Text, Me.txtCodigoCliente.Text)

            If Fact.Count = 0 Then
                Exit Function
            End If

            'cabecero de factura
            If ConF(0).Campo1X = 0 Or ConF(0).Campo1Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresión del nombre del cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If ConF(0).Campo2X = 0 Or ConF(0).Campo2Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresión del domicilio del cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If ConF(0).Campo3X = 0 Or ConF(0).Campo3Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresión de la ciudad del cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If ConF(0).Campo4X = 0 Or ConF(0).Campo4Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresión del estado del cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If ConF(0).Campo5X = 0 Or ConF(0).Campo5Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresión del RFC del cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If ConF(0).Campo6X = 0 Or ConF(0).Campo6Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresión del folio o numero de factura", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If ConF(0).Campo7X = 0 Or ConF(0).Campo7Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresión de la fecha de factura", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If ConF(0).Campo8X = 0 Or ConF(0).Campo8Y = 0 Or ConF(0).Campo9X = 0 Or ConF(0).Campo9Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresión de la cantidad y la descripcion del producto", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If ConF(0).Campo10X = 0 Or ConF(0).Campo10Y = 0 Or ConF(0).Campo11X = 0 Or ConF(0).Campo11Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresión del precio y el importe total del producto", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If ConF(0).Campo12X = 0 Or ConF(0).Campo12Y = 0 Or ConF(0).Campo13X = 0 Or ConF(0).Campo13Y = 0 Or ConF(0).Campo14X = 0 Or ConF(0).Campo14Y = 0 Or ConF(0).Campo15X = 0 Or ConF(0).Campo15Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresión del subtotal, iva, total e importe con letra de la factura", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            ClientesImp.Obtener(Fact.Item(0).Cliente)
            Dim cliente As String = ClientesImp.Nombre 'Fact.Tables(0).Rows(0)("Nombre").ToString.Replace("Ñ", "N").Trim.Replace("ñ", "n")

            If ConF(0).LetrasXrenglonCliente < cliente.Length Then
                Dim separado As String() = cliente.Split(" ")
                Dim Partes As New List(Of String)

                For Each palabra As String In separado
                    If Partes.Count = 0 Then
                        Partes.Add(palabra.Trim)
                        Continue For
                    End If

                    If (Partes(Partes.Count - 1).Length + palabra.Trim.Length) > ConF(0).LetrasXrenglonCliente Then
                        Partes.Add(palabra.Trim)
                    Else
                        Partes(Partes.Count - 1) &= " " & palabra.Trim
                    End If
                Next

                For i As Integer = 0 To Partes.Count - 1
                    Imp.Escribe(Partes(i), ConF(0).Campo1X, ConF(0).Campo1Y + i) 'direccion del cliente
                Next
            Else
                Imp.Escribe(cliente, ConF(0).Campo1X, ConF(0).Campo1Y) ' nombre del cliente
            End If

            Dim bajarFila As Integer = Math.Truncate(cliente.Length / ConF(0).LetrasXrenglonCliente)
            Dim domicilio As String = DomicilioCliente.Domicilio.Trim.Replace("Ñ", "N").Replace("ñ", "n") & " COL. " & DomicilioCliente.Colonia.Trim

            If ConF(0).LetrasXrenglonDomicilio < domicilio.Length Then
                Dim separado As String() = domicilio.Split(" ")
                Dim Partes As New List(Of String)

                For Each palabra As String In separado
                    If Partes.Count = 0 Then
                        Partes.Add(palabra.Trim)
                        Continue For
                    End If

                    If (Partes(Partes.Count - 1).Length + palabra.Trim.Length) > ConF(0).LetrasXrenglonDomicilio Then
                        Partes.Add(palabra.Trim)
                    Else
                        Partes(Partes.Count - 1) &= " " & palabra.Trim
                    End If
                Next

                For i As Integer = 0 To Partes.Count - 1
                    If i > 0 Then
                        bajarFila += 1
                    End If
                    Imp.Escribe(Partes(i), ConF(0).Campo2X, ConF(0).Campo2Y + bajarFila) 'direccion del cliente
                Next
            Else
                Imp.Escribe(domicilio, ConF(0).Campo2X, ConF(0).Campo2Y + bajarFila) 'direccion del cliente
            End If

            If ConF(0).DatosClienteCpC <> 0 AndAlso ConF(0).DatosClienteCpR <> 0 AndAlso DomicilioCliente.CodigPostal.Trim <> String.Empty Then
                If ConF(0).DatosClienteCpR = ConF(0).Campo2Y Then
                    bajarFila += 1
                End If
                Imp.Escribe("C.P. " & DomicilioCliente.CodigPostal.Replace(",", "").Replace(".", ""), ConF(0).DatosClienteCpC, ConF(0).DatosClienteCpR + bajarFila) 'codigo postal del cliente
            End If

            Imp.Escribe(DomicilioCliente.Ciudad.Descripcion, ConF(0).Campo3X, ConF(0).Campo3Y + bajarFila) 'ciudad del cliente
            Imp.Escribe(DomicilioCliente.Estado.Descripcion, ConF(0).Campo4X, ConF(0).Campo4Y + bajarFila) 'estado del cliente
            Imp.Escribe(IIf(conRFC, ClientesImp.RFC, ""), ConF(0).Campo5X, ConF(0).Campo5Y + bajarFila) 'rfc del cliente
            Imp.Escribe(Fact.Item(0).FolFactura, ConF(0).Campo6X, ConF(0).Campo6Y) ' + bajarFila 'Folio de Factura
            Imp.Escribe(Fact.Item(0).FecFactura.Value.ToShortDateString, ConF(0).Campo7X, ConF(0).Campo7Y) ' + bajarFila 'fecha de la factura

            Dim Observaciones As String = "" 'Fact.Item(0)..ToString.Trim

            If ConF(0).DatosFacturaObsrvC <> 0 AndAlso ConF(0).DatosFacturaObsrvR <> 0 Then
                If ConF(0).LetrasxRenglonObsrv < Observaciones.Length Then
                    Dim separado As String() = Observaciones.Split(" ")
                    Dim Partes As New List(Of String)

                    For Each palabra As String In separado
                        If Partes.Count = 0 Then
                            Partes.Add(palabra.Trim)
                            Continue For
                        End If

                        If (Partes(Partes.Count - 1).Length + palabra.Trim.Length) > ConF(0).LetrasxRenglonObsrv Then
                            Partes.Add(palabra.Trim)
                        Else
                            Partes(Partes.Count - 1) &= " " & palabra.Trim
                        End If
                    Next

                    For i As Integer = 0 To Partes.Count - 1
                        If i > 0 Then
                            bajarFila += 1
                        End If
                        Imp.Escribe(Partes(i), ConF(0).DatosFacturaObsrvC, ConF(0).DatosFacturaObsrvR + bajarFila) 'observaciones factura
                    Next
                Else
                    Imp.Escribe(Observaciones, ConF(0).DatosFacturaObsrvC, ConF(0).DatosFacturaObsrvR) 'observaciones factura
                End If
            End If

            ''detalle de factura
            'Microsoft.VisualBasic.Right("000" + CStr(Ventana.DgvCortes.CurrentRow.Cells(Ventana.ClmCodigo.Index).Value), 3)
            Dim renglon As Byte

            renglon = ConF(0).Campo8Y


            For Each Detalle As FacturasDetalleClass In Fact.Item(0).Detalles
                Imp.EscribeDer(CDec(Detalle.CabezasxTipoGanado).ToString("N2"), ConF(0).Campo8X, ConF(0).Campo8X, renglon)
                Imp.Escribe(Detalle.TipoGanado.ToString.Trim.Replace("Ñ", "N").Replace("ñ", "n"), ConF(0).Campo9X, renglon)
                Dim num As Decimal = CDec(Detalle.PrecioxKiloxTipoGanado)
                Imp.EscribeDer(num.ToString("N2"), ConF(0).Campo10X, ConF(0).Campo10X, renglon)
                Imp.EscribeDer(CDec(Detalle.PrecioxKiloxTipoGanado * Detalle.KilosxTipoGanado).ToString("N2"), ConF(0).Campo11X, ConF(0).Campo11X, renglon)
                renglon = renglon + 1
            Next

            'For i As Integer = 0 To Fact.Count - 1
            '    Fact.Item(0).Detalles
            '    Imp.EscribeDer(CDec(Fact.Tables(0).Rows(i)("KilosFacturados")).ToString("N2") & "Kgrs", ConF(0).Campo8X, ConF(0).Campo8X, renglon)
            '    Imp.Escribe(Fact.Tables(0).Rows(i)("Descripcion").ToString.Trim.Replace("Ñ", "N").Replace("ñ", "n"), ConF(0).Campo9X, renglon)
            '    Dim num As Decimal = CDec(Fact.Tables(0).Rows(i)("PrecioxKgr"))
            '    Imp.EscribeDer(num.ToString("N2"), ConF(0).Campo10X, ConF(0).Campo10X, renglon)
            '    Imp.EscribeDer(CDec(Fact.Tables(0).Rows(i)("ImporteFacturado")).ToString("N2"), ConF(0).Campo11X, ConF(0).Campo11X, renglon)
            '    renglon = renglon + 1
            'Next

            'total de factura
            Imp.Escribe(CDec(Fact.Item(0).SubTotal).ToString("N2"), ConF(0).Campo12X, ConF(0).Campo12Y)
            Imp.Escribe(CDec(Fact.Item(0).ImporteIVA).ToString("N2"), ConF(0).Campo13X, ConF(0).Campo13Y)
            Imp.Escribe(CDec(Fact.Item(0).SubTotal).ToString("N2"), ConF(0).Campo14X, ConF(0).Campo14Y)

            Dim TotalLetra As String = ClasesNegocio.ConvertirNumeroALetraClass.Convertir(Fact.Item(0).SubTotal, TipoMonedaEnum.Peso)

            Try
                If TotalLetra.Length > ConF(0).LetrasXrenglonDelTotalEnLetra Then
                    Dim separado As String() = TotalLetra.Split(" ")
                    Dim partes As New List(Of String)

                    For Each palabra As String In separado
                        If partes.Count = 0 Then
                            partes.Add(palabra)
                            Continue For
                        End If

                        If (partes(partes.Count - 1).Length + palabra.Length) > ConF(0).LetrasXrenglonDelTotalEnLetra Then
                            partes.Add(palabra)
                        Else
                            partes(partes.Count - 1) &= " " & palabra.Trim
                        End If
                    Next

                    For i As Integer = 0 To partes.Count - 1
                        Imp.Escribe(partes(i), ConF(0).Campo15X, ConF(0).Campo15Y + i)
                    Next
                Else
                    Imp.Escribe(TotalLetra, ConF(0).Campo15X, ConF(0).Campo15Y)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


            'Imp.Escribe(ConvertirNumeroALetraClass.Convertir(Fact.Tables(0).Rows(0)("Total"), TipoMonedaEnum.Peso), ConF(0).Campo15X, ConF(0).Campo15Y)
            ' ''total a pagar
            If Not ConF(0).Campo16X = 0 And Not ConF(0).Campo16Y = 0 Then
                Imp.Escribe(Me.dtpFechaVencimiento.Value.ToString("dd {1} MMMM {1} yyyy").Replace("{1}", "de"), ConF(0).Campo16X, ConF(0).Campo16Y)
            End If

            If Not ConF(0).Campo17X = 0 And Not ConF(0).Campo17Y = 0 Then
                Imp.Escribe(CDec(Fact.Item(0).SubTotal).ToString("N2"), ConF(0).Campo17X, ConF(0).Campo17Y)
            End If

            If Not ConF(0).Campo18X = 0 And Not ConF(0).Campo18Y = 0 Then
                Try
                    If TotalLetra.Length > ConF(0).LetrasXrenglonDelTotalEnLetraPagare Then
                        Dim separado As String() = TotalLetra.Split(" ")
                        Dim partes As New List(Of String)

                        For Each palabra As String In separado
                            If partes.Count = 0 Then
                                partes.Add(palabra)
                                Continue For
                            End If

                            If (partes(partes.Count - 1).Length + palabra.Length) > ConF(0).LetrasXrenglonDelTotalEnLetraPagare Then
                                partes.Add(palabra)
                            Else
                                partes(partes.Count - 1) &= " " & palabra.Trim
                            End If
                        Next

                        For i As Integer = 0 To partes.Count - 1
                            Imp.Escribe(partes(i), ConF(0).Campo18X, ConF(0).Campo18Y + i)
                        Next
                    Else
                        Imp.Escribe(TotalLetra, ConF(0).Campo18X, ConF(0).Campo18Y)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

            If ConF(0).Campo19X <> 0 And ConF(0).Campo19Y = 0 Then
                Imp.Escribe(Me.txtTotal.Text, ConF(0).Campo19X, ConF(0).Campo19Y)
            End If

            Imp.Imprime()

            Fact = Nothing

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


#End Region

#Region "MetodosForma"
    Private Sub frmFacturacionEspecial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Band = False
            ClientesCol = New ClientesIntroductoresColeccion
            ClientesCol.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)

            Me.CmbCliente.DisplayMember = "Nombre"
            Me.CmbCliente.ValueMember = "Codigo"
            Me.CmbCliente.DataSource = ClientesCol


            'cargar productos
            'ProductosGenCol = New ProductoCollectionClass
            ''ProductosGenCol.ObtenerColeccion()
            'Me.ProductosVistaC.Obtener(CondicionEnum.ACTIVOS)
            'Me.clmProductoDes.DisplayMember = "Descripcion"
            'Me.clmProductoDes.ValueMember = "Codigo"
            'Me.clmProductoDes.DataSource = Me.ProductosVistaC
            ''llena combos de gastos
            Controlador.LlenarComboSucursales(cmbsucursal, ClasesNegocio.CondicionEnum.ACTIVOS)
            Controlador.LlenarComboMetodosdeProrrateo(cmbmetodo)
            ''
            llenarFormasPago()
            llenarMetodosPago()
            llenarProductosSAT()
            llenarUnidadesSAT()
            llenarUsoCFDISAT()

            Dim colProd As New ProductoCollectionClass
            colProd.Obtener(CondicionEnum.TODOS, True)

            Me.clmProductoDes.DataSource = colProd
            Me.clmProductoDes.DisplayMember = "Descripcion"
            Me.clmProductoDes.ValueMember = "Codigo"

            clmProductoServicio.MaxDropDownItems = 6
            clmProductoDes.MaxDropDownItems = 6
            clmUnidadSat.MaxDropDownItems = 6

            'llenarProductos()

            cmbformadepago.SelectedIndex = -1
            cmbmetododepago.SelectedIndex = -1
            cmbformadepago.Text = "Seleccione la forma de pago..."
            cmbmetododepago.Text = "Seleccione la método de pago..."

            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "101001111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100001"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100001"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            Me.MEAToolBar1.ToolBarButtonStatus = MtbEstados
            Me.MEAToolBar1.sbCambiarEstadoBotones("Cancelar")
            Limpiar()
            Deshabilitar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBorrar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Guardar Facturas")
        Try
            'verifica si la factura esta pagada
            If FacturaCabecero.Estatus = "P" Then
                Trans.Rollback()
                Cancelar = True
                MessageBox.Show("No se puede cancelar la factura: " & Me.txtFolioFactura.Text & " por que se encuentra pagada", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'verifica si la factura esta abonada
            If FacturaCabecero.Estatus = "A" Then
                Trans.Rollback()
                Cancelar = True
                MessageBox.Show("No se puede cancelar la factura: " & Me.txtFolioFactura.Text & " por que se encuentra abonada", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'verifica si la factura esta cancelada
            If FacturaCabecero.Estatus = "C" Then
                Trans.Rollback()
                Cancelar = True
                MessageBox.Show("No se puede cancelar la factura: " & Me.txtFolioFactura.Text & " por que se encuentra cancelada", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


            Dim result As Integer = MessageBox.Show("¿Desea cancelar la factura?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If result = DialogResult.No Then
                Trans.Rollback()
                Cancelar = True
                Exit Sub
                'ElseIf result = DialogResult.Yes Then
                '    MessageBox.Show("Yes pressed")
            End If

            Cursor = Cursors.WaitCursor 'and some various me.Cursor / current.cursor 
            MEAToolBar1.Enabled = False
            Application.DoEvents()


            ''Componente de facturacion 3.3
            Dim TransG As Gentle.Framework.Transaction
            Dim ControlFD As Integralab.FactDigital.ControladorFactDigital
            Dim ConStr As String
            If File.Exists(Application.StartupPath + "\\cx.dat") Then
                ConStr = Integralab.FactDigital.ControladorFactDigital.Decrypt(File.ReadAllText(Application.StartupPath + "\\cx.dat"))
            Else
                Throw New Exception("No se ha configurado la conexión a la base de datos de la factura digital.")
            End If
            'Dim TransG As New Gentle.Framework.Transaction(IntegraLab.FactDigital.ControladorFactDigital.Conexion)
            ControlFD = New Integralab.FactDigital.ControladorFactDigital(Controlador.Empresa.CodEmpndx, ConStr)
            TransG = New Gentle.Framework.Transaction(Integralab.FactDigital.ControladorFactDigital.Conexion)

            ControlFD.CancelarCFDI(txtUUID.Text, DateTime.Now, TransG)




            'generar poliza de cancelacion
            Dim PolizaCan As New PolizaClass
            PolizaCan.Concepto = "Cancelacion de Cargo por Factura Especial a: " & Trim(Me.CmbCliente.Text) & " # Factura : " & FacturaCabecero.NoFactura
            PolizaCan.EmpresaId = Controlador.Sesion.MiEmpresa.Empndx
            PolizaCan.Estatus = ClasesNegocio.PolizaEstatusEnum.ACTIVA
            PolizaCan.FechaCaptura = Now
            PolizaCan.FechaPoliza = Me.dtFechaFactura.Value
            PolizaCan.Importe = Me.txtTotal.Text
            PolizaCan.Origen = ClasesNegocio.PolizaOrigenEnum.VENTAS
            PolizaCan.TipoCambio = 1
            PolizaCan.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.CANCELACION
            PolizaCan.TipoError = 0
            PolizaCan.Referencia = PolizaACancelar

            'Se crea el detalle de la poliza
            For i As Integer = 0 To Me.dgvCuentasContables.Rows.Count - 1
                If Me.dgvCuentasContables.Rows(i).Cells(Me.clmCargo.Index).Value > 0 Then
                    Dim CuentaCon As New CuentaContableClass
                    Dim PolizaDetCan As New PolizaDetalleClass
                    CuentaCon.Obtener(Me.dgvCuentasContables.Rows(i).Cells("ClmCodigoCuenta").Value)
                    PolizaDetCan.Operacion2 = ClasesNegocio.PolizaOperacionEnum2.A
                    PolizaDetCan.CuentaContable = CuentaCon
                    PolizaDetCan.Posicion = i + 1
                    PolizaDetCan.Importe = Me.dgvCuentasContables.Rows(i).Cells(Me.clmCargo.Index).Value
                    PolizaCan.Detalles2.Add(PolizaDetCan)
                    'Poliza.AgregarDetalle(PolizaDet)
                ElseIf Me.dgvCuentasContables.Rows(i).Cells(Me.clmAbono.Index).Value > 0 Then
                    Dim CuentaCon As New CuentaContableClass
                    Dim PolizaDetCan As New PolizaDetalleClass
                    CuentaCon.Obtener(Me.dgvCuentasContables.Rows(i).Cells("ClmCodigoCuenta").Value)
                    PolizaDetCan.Operacion2 = ClasesNegocio.PolizaOperacionEnum2.C
                    PolizaDetCan.CuentaContable = CuentaCon
                    PolizaDetCan.Posicion = i + 1
                    PolizaDetCan.Importe = Me.dgvCuentasContables.Rows(i).Cells(Me.clmAbono.Index).Value
                    PolizaCan.Detalles2.Add(PolizaDetCan)
                    'Poliza.AgregarDetalle(PolizaDet)
                End If
            Next

            If Not PolizaCan.Detalles2.Count > 0 Then
                MsgBox("Se cancelara la instrucción debido a que no se encuentra el detalle de la poliza", MsgBoxStyle.Exclamation, "Aviso")
                Trans.Rollback()
                Exit Sub
            End If

            If Not PolizaCan.Guardar2(Trans) Then
                Trans.Rollback()
                MessageBox.Show("No se Guardo la poliza", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Guardar(Trans, "C")
            Trans.Commit()
            TransG.Commit()
            Cursor = Cursors.Default
            Me.Limpiar()
            MEAToolBar1.Enabled = True
            MessageBox.Show("Se ha cancelado la Factura:" & Me.txtFolioFactura.Text, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Cursor = Cursors.Default
            MEAToolBar1.Enabled = True
            Trans.Rollback()
            Cancelar = True
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Try
            Dim Consultas As New frmBusquedaFacturas
            Dim Clientes As New ClientesIntroductoresClass
            Dim ListaSalidas As New List(Of String)
            Dim i As Integer = 0
            Dim Poliza As New PolizaClass
            Dim PolizaDet As New PolizaDetalleClass

            Consultas.TipoFactura = TipoFacturaEnum.FACTURACION_ESPECIAL

            If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then

                FacturaCabecero = CType(Consultas.dgvFacturasCabecero.SelectedRows(0).DataBoundItem, FacturasClass)
                Me.txtFolioFactura.Text = FacturaCabecero.NoFactura
                'Me.dgvDetalle.AutoGenerateColumns = False
                'Me.dgvDetalle.DataSource = FacturaCabecero.Detalles
                Clientes.Obtener(FacturaCabecero.CveCliente)
                Me.txtCodigoCliente.Text = FacturaCabecero.CveCliente
                Me.CmbCliente.Text = Clientes.Nombre
                Me.txtlugarexpedicion.Text = FacturaCabecero.LugarExpedicion
                cmbUsoCFDI.SelectedValue = FacturaCabecero.UsoCfdi
                txtRFC.Text = Clientes.RFC
                'txtObservaciones.Text = Me.FacturaCabecero.ob
                Me.cmbformadepago.SelectedValue = Me.FacturaCabecero.FormaPago
                Me.cmbmetododepago.SelectedValue = Me.FacturaCabecero.MetodoPago
                Me.txtNumCta.Text = Me.FacturaCabecero.NumCta
                Me.txtSubTotal.Text = Me.FacturaCabecero.ImporteSubTotal.ToString("N2")
                Me.txtDescuento.Text = Me.FacturaCabecero.ImporteDescuento.ToString("N2")
                Me.txtIVA.Text = Me.FacturaCabecero.ImporteIVA.ToString("N2")
                Me.txtTotal.Text = (Me.FacturaCabecero.ImporteSubTotal + Me.FacturaCabecero.ImporteIVA).ToString("N2")
                Me.txtUUID.Text = Me.FacturaCabecero.Uuid
                Me.txtObservaciones.Text = Me.FacturaCabecero.Observaciones
                Me.txtDireccion.Text = Me.FacturaCabecero.Direccion
                If Me.FacturaCabecero.DiasCredito > 0 Then
                    rdCredito.Checked = True
                Else
                    rdContado.Checked = True
                End If
                Me.txtDiasCredito.Text = Me.FacturaCabecero.DiasCredito.ToString()
                Me.lblEstatus.Visible = True

                Buscarr = True

                'If FacturaCabecero.Estatus = EstatusFacturasEnum.ABONADA Then
                '    Me.lblEstatus.Text = "ABONADA"
                'End If

                'If FacturaCabecero.Estatus = EstatusFacturasEnum.CANCELADA Then
                '    Me.lblEstatus.Text = "CANCELADA"
                'End If
                'If FacturaCabecero.Estatus = EstatusFacturasEnum.PAGADA Then
                '    Me.lblEstatus.Text = "PAGADA"
                'End If
                'If FacturaCabecero.Estatus = EstatusFacturasEnum.VIGENTE Then
                '    Me.lblEstatus.Text = "VIGENTE"
                'End If
                If FacturaCabecero.Estatus = "V" Then
                    lblEstatus.Text = "VIGENTE"
                ElseIf FacturaCabecero.Estatus = "C" Then
                    lblEstatus.Text = "CANCELADA"
                End If


                'llenar datos del grid de detalle               
                dgvDetalle.AllowUserToAddRows = False
                For Each Detalle As FacturasDetalleClass In FacturaCabecero.Detalles
                    Dim Producto As New ProductoClass
                    Me.clmDescripcionEspecial.Visible = True
                    Me.clmProductoDes.Visible = False
                    If Detalle.IdProducto = 0 And Detalle.Descripcion = "" Then
                        Exit For
                    End If
                    If Detalle.IdProducto > 0 Then
                        Me.dgvDetalle.Rows(i).Cells(Me.clmCodigo.Index).Value = Detalle.IdProducto
                        Producto.Obtener(Detalle.IdProducto)
                        Me.dgvDetalle.Rows.Add()
                        Me.dgvDetalle.Rows(i).Cells(Me.clmDescripcionEspecial.Index).Value = Producto.Descripcion
                        Me.dgvDetalle.Rows(i).Cells(Me.clmUnidad.Index).Value = Producto.UnidadMedida.Descripcion
                        Me.clmCodigo.Visible = True
                        Me.clmUnidad.Visible = True
                        OptProductos.Checked = True
                    Else
                        Me.dgvDetalle.Rows.Add()
                        Me.dgvDetalle.Rows(i).Cells(Me.clmDescripcionEspecial.Index).Value = Detalle.Descripcion
                        Me.clmCodigo.Visible = False
                        Me.clmUnidad.Visible = False
                        OptExternos.Checked = True
                    End If
                    Me.dgvDetalle.Rows(i).Cells(Me.clmProductoServicio.Index).Value = Detalle.CveProductoServ
                    Me.dgvDetalle.Rows(i).Cells(Me.clmUnidadSat.Index).Value = Detalle.CveUnidad
                    If Detalle.IVA > 0 Then
                        Me.dgvDetalle.Rows(i).Cells(Me.clmConIVA.Index).Value = True
                    Else
                        Me.dgvDetalle.Rows(i).Cells(Me.clmConIVA.Index).Value = False
                    End If
                    Me.dgvDetalle.Rows(i).Cells(Me.clmIVA.Index).Value = Detalle.IVA
                    Me.dgvDetalle.Rows(i).Cells(Me.clmIVAdecimales.Index).Value = Detalle.IVA
                    Me.dgvDetalle.Rows(i).Cells(Me.clmImporte.Index).Value = Detalle.Total
                    Me.dgvDetalle.Rows(i).Cells(Me.clmImporteDecimales.Index).Value = Detalle.Total


                    Me.dgvDetalle.Rows(i).Cells(Me.clmCantidad.Index).Value = Detalle.CantidadxProducto
                    Me.dgvDetalle.Rows(i).Cells(Me.clmPrecio.Index).Value = Detalle.PrecioUnitario
                    'Me.dgvDetalle.Rows(i).Cells(Me.clmImporte.Index).Value = Detalle.CantidadxProducto * Detalle.PrecioUnitario
                    i = i + 1
                Next

                'llenar detalle de poliza
                i = 0
                dgvCuentasContables.AllowUserToAddRows = False
                If Poliza.Obtener(FacturaCabecero.FolPoliza) Then
                    PolizaACancelar = Poliza.NumeroPoliza
                    For Each DetallePol As PolizaDetalleClass In Poliza.Detalles2
                        Me.dgvCuentasContables.Rows.Add()
                        Me.dgvCuentasContables.Rows(i).Cells(Me.clmCtaMayor.Index).Value = DetallePol.Cta
                        Me.dgvCuentasContables.Rows(i).Cells(Me.clmSubCta.Index).Value = DetallePol.SCta
                        Me.dgvCuentasContables.Rows(i).Cells(Me.clmSSubCta.Index).Value = DetallePol.SSCta
                        Me.dgvCuentasContables.Rows(i).Cells(Me.clmSSSubCta.Index).Value = DetallePol.SSSCta
                        Me.dgvCuentasContables.Rows(i).Cells(Me.clmDescripcion.Index).Value = DetallePol.CuentaContable.NombreCuenta
                        Me.dgvCuentasContables.Rows(i).Cells(Me.clmCodigoCuenta.Index).Value = DetallePol.CuentaContable.Codigo
                        If DetallePol.Operacion2 = PolizaOperacionEnum2.C Then
                            Me.dgvCuentasContables.Rows(i).Cells(Me.clmCargo.Index).Value = DetallePol.Importe
                            Me.dgvCuentasContables.Rows(i).Cells(Me.clmAbono.Index).Value = CDec(0)
                        Else
                            Me.dgvCuentasContables.Rows(i).Cells(Me.clmAbono.Index).Value = DetallePol.Importe
                            Me.dgvCuentasContables.Rows(i).Cells(Me.clmCargo.Index).Value = CDec(0)
                        End If
                        i = i + 1
                    Next
                End If
                calcular()

                'datos para el combo de domicilios fiscales
                Me.ultcmbDomiciliosFiscales.DataSource = Clientes.DomiciliosFiscales
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("IdCliente").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("IdRenglon").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("IdPoblacion").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Entidad").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Contenedor").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("EsPrincipal").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("IndiceEnContenedor").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Seleccionado").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Cliente").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Transaction").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("ParticipatesInTransaction").Hidden = True

                If Clientes.DomiciliosFiscales.Count = 1 Then
                    ultcmbDomiciliosFiscales.Rows(0).Selected = True
                End If
            Else
                Cancelar = True
            End If

        Catch ex As Exception
            Cancelar = True
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickCancelar
        Me.Limpiar()
        Me.Deshabilitar()
    End Sub

    'guarda las facturas de venta en reciba
    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Guardar Facturas")
        Try
            Dim bool As Boolean
            bool = Guardar(Trans, "V")
            If bool Then
                Trans.Commit()
                Me.Limpiar()
                Me.Deshabilitar()
            Else
                Trans.Rollback()
                Cancelar = True
                'Me.Limpiar()
                'Me.Deshabilitar()
            End If

            'Trans.Commit()
            'Me.Limpiar()
            'Me.Deshabilitar()
            'MessageBox.Show("Se ha cancelado la Factura:" & Me.txtFolioFactura.Text, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir
        Try
            'Dim conRFC As Boolean = True

            'If Me.ultcmbDomiciliosFiscales.SelectedRow Is Nothing Then
            '    MsgBox("Debe seleccionar el domicilio fiscal", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            '    Cancelar = True
            '    Exit Sub
            'End If

            'If Me.configurarImprecion Then
            '    Dim seleccionarCOnfiguracion As New frmSeleccionConfiguracionFactura

            '    If seleccionarCOnfiguracion.ShowDialog = Windows.Forms.DialogResult.OK Then
            '        ConF.Add(seleccionarCOnfiguracion.ConfiguracionSeleccionada.Entidad)
            '    Else
            '        MsgBox("Debe seleccionar una configuración", MsgBoxStyle.Exclamation, "Seleccione una Configuración")
            '        Exit Sub
            '    End If
            'End If

            ''buscar el numero de renglones por factura para dividir las facturas en mas
            ''de una factura                 
            'NumRenglones = ConF(0).RenglonesEnDetalle

            'If MessageBox.Show("¿Desea imprimirlo con RFC?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            '    conRFC = False
            'End If

            'Me.Imprimir(CType(ultcmbDomiciliosFiscales.SelectedRow.ListObject, DomicilioClienteClass), conRFC)
            If Buscarr = True Then
                Try
                    Dim ControlFD As Integralab.FactDigital.ControladorFactDigital
                    Dim ConStr As String
                    If File.Exists(Application.StartupPath + "\\cx.dat") Then
                        ConStr = Integralab.FactDigital.ControladorFactDigital.Decrypt(File.ReadAllText(Application.StartupPath + "\\cx.dat"))
                    Else
                        Throw New Exception("No se ha configurado la conexión a la base de datos de la factura digital.")
                    End If
                    ControlFD = New Integralab.FactDigital.ControladorFactDigital(Controlador.Empresa.CodEmpndx, ConStr)

                    ControlFD.GeneraCFDI_PDF(txtUUID.Text, True)

                Catch ex As Exception
                    Cancelar = True
                    MessageBox.Show(ex.Message.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try


            End If
        Catch ex As Exception
            Cancelar = True
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Me.Limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickNuevo
        Me.Limpiar()
        Habilitar()
        Me.GroupBox1.Enabled = True
        Me.rdContado.Checked = True
        FacturaCabecero = New FacturasClass
        Me.txtlugarexpedicion.Text = Controlador.Sesion.MiEmpresa.EmpCodigoPostal.Trim() + "-" + Controlador.Sesion.MiEmpresa.EmpMunicipio + ", " + Controlador.Sesion.MiEmpresa.EmpEstado + ", MEXICO"
        Me.txtlugarexpedicion.Tag = Controlador.Sesion.MiEmpresa.EmpCodigoPostal.Trim()
        cmbUsoCFDI.SelectedValue = "P01"
        cmbmetododepago.SelectedValue = "PUE"
        cmbformadepago.SelectedValue = "99"
        txtCodigoCliente.Focus()
        'FacturasDetalle = New CN.FacturasDetalleClass
        'Me.dgvDetalle.DataSource = FacturaCabecero.Detalles
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub

    Private Sub CmbCliente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCliente.GotFocus
        Band = True
    End Sub


    Private Sub CmbCliente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCliente.SelectedIndexChanged
        Try
            If Band Then
                Dim ClientesClas As New ClientesIntroductoresClass
                Me.txtCodigoCliente.Text = Me.CmbCliente.SelectedValue
                ClientesClas.Obtener(Me.CmbCliente.SelectedValue)
                Me.txtRFC.Text = ClientesClas.RFC
                Me.txtDiasCredito.Text = ClientesClas.DiasCredito
                If ClientesClas.DiasCredito > 0 Then
                    Me.rdCredito.Checked = True
                    Dim Fecha As DateTime
                    Fecha = dtFechaFactura.Value
                    Fecha = Fecha.AddDays(CDbl(ClientesClas.DiasCredito))
                    dtpFechaVencimiento.Value = Fecha
                Else
                    Me.rdContado.Checked = True
                End If

                cmbUsoCFDI.SelectedValue = ClientesClas.UsoCFDI.Trim()
                cmbformadepago.SelectedValue = ClientesClas.FormaPago.Trim()

                Me.txtDireccion.Text = ClientesClas.Domicilio
                Me.ultcmbDomiciliosFiscales.DataSource = ClientesClas.DomiciliosFiscales

                '''----- cambia tamaño col
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("NoInt").Width = 50
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("NoExt").Width = 50
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Ciudad").Width = 100
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Estado").Width = 100
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Poblacion").Width = 100
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Email").Width = 100
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Calle").Width = 120
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Colonia").Width = 110
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("CodigPostal").Width = 75
                ''' 

                '''----- oculta campos 
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("IdCliente").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("IdRenglon").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("IdPoblacion").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("IdCiudad").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("IdEstado").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Domicilio").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Telefono1").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Celular").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Fax").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Entidad").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Contenedor").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("EsPrincipal").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("IndiceEnContenedor").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Seleccionado").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Cliente").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Transaction").Hidden = True
                Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("ParticipatesInTransaction").Hidden = True
                '''----

                If IsDBNull(ClientesClas.Idcuentaventa) Then
                    MessageBox.Show("El cliente no tiene registrada la cuenta contable de ventas, Catalogos/Ventas/Clientes", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If

                ' Cargo
                If ClientesClas.CuentaContableId > 0 Then
                    Me.RellenarGridCuentas(ClientesClas.CuentaContable)
                End If

                If ClientesClas.CuentaAntiId > 0 Then
                    Me.RellenarGridCuentas(ClientesClas.CuentaContableAntici)
                    '  Me.RellenarGridCuentas(ClientesClas.CuentaAntiId)
                End If
                'Abono
                If ClientesClas.Idcuentaventa > 0 Then
                    'Me.RellenarGridCuentas(ClientesClas.Idcuentaventa)
                    Me.RellenarGridCuentas(ClientesClas.CuentaContableVenta)
                    calcular()
                    'Dim CtasConts As New CuentaContableCollectionClass
                Else
                    MessageBox.Show("Cliente no tiene cuenta contable asignada", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If



            End If
        Catch ex As Exception
            MessageBox.Show("Cliente no tiene cuenta contable asignada", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)

            ''  MessageBox.Show("Cliente no tiene cuenta contable asignada", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '' MsgBox(ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub

    Private Sub CmbCliente_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCliente.SelectedValueChanged
        'Try
        '    Dim DomiciliosCol As New CC.MfacClientesDatosFiscalesCollection



        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Aviso")
        'End Try
    End Sub

#End Region



    Private Sub dgvDetalle_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalle.CellEndEdit
        Try
            Dim suma As Decimal
            Select Case e.ColumnIndex
                'Case 1
                '    dgvDetalle.Refresh()
                '    Dim Cod As Integer
                '    Dim Prod As New ProductoClass
                '    Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCodigo.Index).Value = Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmProductoDes.Index).Value
                '    Cod = Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCodigo.Index).Value
                '    If Prod.Obtener(Cod) Then
                '        'Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCodigo.Index).Value = Prod.Item(0).Codigo
                '        Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmUnidad.Index).Value = Prod.UnidadMedida.Descripcion
                '    End If
                Case clmPrecio.Index
                    If Me.clmDescripcionEspecial.Visible = False Then
                        'Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmImporte.Index).Value = (CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value * Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value) + CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value * (Controlador.ObtenerIVA() / 100))).ToString("N2")
                        'Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmIVA.Index).Value = CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value * (Controlador.ObtenerIVA() / 100)).ToString("N2")
                        'Me.dgvDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value).ToString("N2")

                        Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmIVA.Index).Value = TruncateDecimal(CDec((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)) * (Controlador.ObtenerIVA() / 100)), 2)
                        Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmIVAdecimales.Index).Value = CDec((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)) * (Controlador.ObtenerIVA() / 100)).ToString("F4")
                        Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmImporte.Index).Value = (TruncateDecimal((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)), 2) _
                                                                                                          + TruncateDecimal((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value) * CDec((Controlador.ObtenerIVA() / 100))), 2))
                        Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmImporteDecimales.Index).Value = (TruncateDecimal((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)), 2) _
                                                                                                    + TruncateDecimal((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value) * CDec((Controlador.ObtenerIVA() / 100))), 2))

                    Else
                        If Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmConIVA.Index).EditedFormattedValue = True Then
                            Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmIVA.Index).Value = Math.Round(CDec((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)) * (Controlador.ObtenerIVA() / 100)), 2)
                            Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmIVAdecimales.Index).Value = CDec((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)) * (Controlador.ObtenerIVA() / 100)).ToString("F4")
                            Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmImporte.Index).Value = (Math.Round((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)), 2) _
                                                                                                              + Math.Round((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value) * CDec((Controlador.ObtenerIVA() / 100))), 2))
                            Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmImporteDecimales.Index).Value = (Math.Round((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)), 2) _
                                                                                                        + Math.Round((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value) * CDec((Controlador.ObtenerIVA() / 100))), 2))
                        Else
                            Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmIVA.Index).Value = Math.Round(CDec((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)) * (0)), 2)
                            Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmIVAdecimales.Index).Value = CDec((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)) * (0)).ToString("F4")
                            Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmImporte.Index).Value = (Math.Round((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)), 2) _
                                                                                                              + Math.Round((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value) * CDec((0))), 2))
                            Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmImporteDecimales.Index).Value = (Math.Round((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)), 2) _
                                                                                                        + Math.Round((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value) * CDec((0))), 2))
                        End If

                    End If
                    Me.dgvDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value).ToString("N2")
                    calcular()
                Case clmCantidad.Index
                    'If Me.clmDescripcionEspecial.Visible = False Then

                    '    Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmIVA.Index).Value = TruncateDecimal(CDec((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)) * (Controlador.ObtenerIVA() / 100)), 2)
                    '    Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmIVAdecimales.Index).Value = CDec((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)) * (Controlador.ObtenerIVA() / 100)).ToString("F4")
                    '    Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmImporte.Index).Value = (TruncateDecimal((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)), 2) _
                    '                                                                                + TruncateDecimal((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value) * CDec((Controlador.ObtenerIVA() / 100))), 2))
                    '    Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmImporteDecimales.Index).Value = (TruncateDecimal((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)), 2) _
                    '                                                                                + TruncateDecimal((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value) * CDec((Controlador.ObtenerIVA() / 100))), 2))
                    '    Me.dgvDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value).ToString("N2")
                    'Else

                    'End If
                    'calcular()
                    If Me.clmDescripcionEspecial.Visible = False Then
                        'Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmImporte.Index).Value = (CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value * Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value) + CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value * (Controlador.ObtenerIVA() / 100))).ToString("N2")
                        'Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmIVA.Index).Value = CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value * (Controlador.ObtenerIVA() / 100)).ToString("N2")
                        'Me.dgvDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value).ToString("N2")

                        Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmIVA.Index).Value = TruncateDecimal(CDec((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)) * (Controlador.ObtenerIVA() / 100)), 2)
                        Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmIVAdecimales.Index).Value = CDec((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)) * (Controlador.ObtenerIVA() / 100)).ToString("F4")
                        Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmImporte.Index).Value = (TruncateDecimal((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)), 2) _
                                                                                                          + TruncateDecimal((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value) * CDec((Controlador.ObtenerIVA() / 100))), 2))
                        Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmImporteDecimales.Index).Value = (TruncateDecimal((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)), 2) _
                                                                                                    + TruncateDecimal((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value) * CDec((Controlador.ObtenerIVA() / 100))), 2))

                    Else
                        If Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmConIVA.Index).EditedFormattedValue = True Then
                            Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmIVA.Index).Value = Math.Round(CDec((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)) * (Controlador.ObtenerIVA() / 100)), 2)
                            Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmIVAdecimales.Index).Value = CDec((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)) * (Controlador.ObtenerIVA() / 100)).ToString("F4")
                            Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmImporte.Index).Value = (Math.Round((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)), 2) _
                                                                                                              + Math.Round((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value) * CDec((Controlador.ObtenerIVA() / 100))), 2))
                            Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmImporteDecimales.Index).Value = (Math.Round((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)), 2) _
                                                                                                        + Math.Round((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value) * CDec((Controlador.ObtenerIVA() / 100))), 2))
                        Else
                            Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmIVA.Index).Value = Math.Round(CDec((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)) * (0)), 2)
                            Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmIVAdecimales.Index).Value = CDec((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)) * (0)).ToString("F4")
                            Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmImporte.Index).Value = (Math.Round((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)), 2) _
                                                                                                              + Math.Round((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value) * CDec((0))), 2))
                            Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmImporteDecimales.Index).Value = (Math.Round((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value)), 2) _
                                                                                                        + Math.Round((CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value) * CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecio.Index).Value) * CDec((0))), 2))
                        End If

                    End If
                    Me.dgvDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDec(Me.dgvDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value).ToString("N2")
                    calcular()
            End Select
            'If Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmImporte.Index).Value <> 0 Then
            '    'suma = 0
            '    'For i As Integer = 0 To Me.dgvDetalle.Rows.Count - 1
            '    '    suma = suma + Me.dgvDetalle.Rows(i).Cells(Me.clmImporte.Index).Value
            '    'Next
            '    'Me.txtSubTotal.Text = suma
            '    'Me.txtTotal.Text = suma
            '    'Me.dgvCuentasContables.Rows(0).Cells(Me.clmCargo.Index).Value = suma

            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function TruncateDecimal(value As Decimal, precision As Integer) As Decimal
        Dim stepper As Decimal = Math.Pow(10, precision)
        Dim tmp As Decimal = Math.Truncate(stepper * value)
        Return tmp / stepper
    End Function

    Public Sub calcular()
        Dim suma As Decimal
        Dim sumaIVA As Decimal
        suma = 0
        sumaIVA = 0
        For i As Integer = 0 To Me.dgvDetalle.Rows.Count - 1
            If Not dgvDetalle.Rows(i).IsNewRow Then
                suma = suma + (Math.Truncate((CDec(Me.dgvDetalle.Rows(i).Cells(Me.clmPrecio.Index).Value) * CDec(Me.dgvDetalle.Rows(i).Cells(Me.clmCantidad.Index).Value)) * 100) / 100)
                If CDec(Me.dgvDetalle.Rows(i).Cells(Me.clmIVA.Index).Value) > 0 Then
                    sumaIVA += CDec(Me.dgvDetalle.Rows(i).Cells(Me.clmIVAdecimales.Index).Value) '((CDec(Me.dgvDetalle.Rows(i).Cells(Me.clmIVA.Index).Value) / 100) * CDec(Me.dgvDetalle.Rows(i).Cells(Me.clmImporte.Index).Value))
                    Me.dgvDetalle.Rows(i).Cells(Me.clmImporte.Index).Value = Math.Round((Math.Round(CDec(Me.dgvDetalle.Rows(i).Cells(Me.clmPrecio.Index).Value) * CDec(Me.dgvDetalle.Rows(i).Cells(Me.clmCantidad.Index).Value), 2)) * (1 + CDec(Controlador.ObtenerIVA() / 100)), 2)
                Else
                    Me.dgvDetalle.Rows(i).Cells(Me.clmImporte.Index).Value = (Math.Round(CDec(Me.dgvDetalle.Rows(i).Cells(Me.clmPrecio.Index).Value) * CDec(Me.dgvDetalle.Rows(i).Cells(Me.clmCantidad.Index).Value), 2))
                    Me.dgvCuentasContables.Rows(i + 1).Cells(Me.clmAbono.Index).Value = (Math.Round(CDec(Me.dgvDetalle.Rows(i).Cells(Me.clmPrecio.Index).Value) * CDec(Me.dgvDetalle.Rows(i).Cells(Me.clmCantidad.Index).Value), 2))

                End If
                'Me.dgvDetalle.Rows(i).Cells(Me.clmImporte.Index).Value = (CDec(Me.dgvDetalle.Rows(i).Cells(Me.clmPrecio.Index).Value) * CDec(Me.dgvDetalle.Rows(i).Cells(Me.clmCantidad.Index).Value)) + (CDec(Controlador.ObtenerIVA() / 100) * CDec(Me.dgvDetalle.Rows(i).Cells(Me.clmCantidad.Index).Value))
            End If
        Next
        Me.txtSubTotal.Text = (Math.Round(suma, 2)).ToString()
        Me.txtIVA.Text = (Math.Round(sumaIVA, 2)).ToString()

        If Not txtDescuento.Text.Trim.Equals("") Then
            Me.txtTotal.Text = ((Math.Round(suma, 2)) - CDec(txtDescuento.Text.Trim()) + (Math.Round(sumaIVA, 2))).ToString("N2") '(((Math.Round(suma, 2)) - CDec(txtDescuento.Text.Trim())) + (Math.Truncate(100 * sumaIVA) / 100)).ToString()
            Me.dgvCuentasContables.Rows(0).Cells(Me.clmCargo.Index).Value = (((Math.Truncate(100 * suma) / 100) - CDec(txtDescuento.Text.Trim())) + (Math.Truncate(100 * sumaIVA) / 100)).ToString()
            Me.dgvCuentasContables.Rows(0).Cells(Me.clmAbono.Index).Value = CDec(0).ToString()
        Else
            Me.txtTotal.Text = ((Math.Round(suma, 2)) + (Math.Round(sumaIVA, 2))).ToString("N2")
            Me.dgvCuentasContables.Rows(0).Cells(Me.clmCargo.Index).Value = ((Math.Truncate(100 * suma) / 100) + (Math.Truncate(100 * sumaIVA) / 100)).ToString()
            Me.dgvCuentasContables.Rows(0).Cells(Me.clmAbono.Index).Value = CDec(0).ToString()
        End If
        Application.DoEvents()

        ' Me.dgvCuentasContables.Rows(0).Cells(Me.clmCargo.Index).Value = (suma + sumaIVA).ToString("N2")
        calculacargosabonos()
        Me.txtSumaAbono.Text = SumaAbono.ToString("N2")
    End Sub



    Private Sub dgvCuentasContables_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCuentasContables.CellEndEdit
        Try
            If e.ColumnIndex = Me.clmCargo.Index Or e.ColumnIndex = Me.clmAbono.Index Then
                SumaCargo = 0
                SumaAbono = 0
                If Me.dgvCuentasContables.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> "" Or Not IsNumeric(Me.dgvCuentasContables.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                    Me.dgvCuentasContables.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDec(Me.dgvCuentasContables.Rows(e.RowIndex).Cells(e.ColumnIndex).Value).ToString("C2")
                Else
                    Me.dgvCuentasContables.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0.ToString("C2")
                End If
                If Me.dgvCuentasContables.Rows(e.RowIndex).Cells("ClmCargo").Value < 0 Or Me.dgvCuentasContables.Rows(e.RowIndex).Cells("ClmAbono").Value < 0 Then
                    MsgBox("La cantidad no puede ser Menor a 0.", MsgBoxStyle.Exclamation, "Advertencia")
                End If

                'If e.ColumnIndex = Me.ClmCargo.Index Then
                For i As Integer = 0 To Me.dgvCuentasContables.Rows.Count - 1
                    SumaCargo = SumaCargo + Me.dgvCuentasContables.Rows(i).Cells("ClmCargo").Value
                Next
                'End If
                'If e.ColumnIndex = Me.ClmAbono.Index Then
                For i As Integer = 0 To Me.dgvCuentasContables.Rows.Count - 1
                    SumaAbono = SumaAbono + Me.dgvCuentasContables.Rows(i).Cells("ClmAbono").Value
                Next
                'End If

                Me.txtSumaCargo.Text = SumaCargo.ToString("C2")
                Me.txtSumaAbono.Text = SumaAbono.ToString("C2")
            ElseIf e.ColumnIndex = Me.clmSubCta.Index Or e.ColumnIndex = Me.clmSSubCta.Index Or e.ColumnIndex = Me.clmSSSubCta.Index Then
                Dim CtasConts As New CuentaContableCollectionClass
                Dim Cta As CuentaContableClass = CtasConts.ObtenerCuentaContable(Me.dgvCuentasContables.Rows(e.RowIndex).Cells("ClmCtaMayor").Value, Me.dgvCuentasContables.Rows(e.RowIndex).Cells("ClmSubCta").Value, Me.dgvCuentasContables.Rows(e.RowIndex).Cells("ClmSsubCta").Value, Me.dgvCuentasContables.Rows(e.RowIndex).Cells("ClmSssubCta").Value)
                If Not IsNothing(Cta) Then
                    Me.RellenarGridCuentas(Cta)
                End If
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Public Sub calculacargosabonos()
        SumaCargo = 0
        SumaAbono = 0
        For i As Integer = 0 To Me.dgvCuentasContables.Rows.Count - 1
            If Not Me.dgvCuentasContables.Rows(i).IsNewRow Then
                SumaCargo = SumaCargo + Me.dgvCuentasContables.Rows(i).Cells("ClmCargo").Value
                Me.dgvCuentasContables.Rows(i + 1).Cells("ClmAbono").Value = SumaCargo
                SumaAbono = SumaAbono + Me.dgvCuentasContables.Rows(i).Cells("ClmCargo").Value
                Me.txtSumaCargo.Text = SumaCargo.ToString("N2")
                Me.txtSumaAbono.Text = SumaAbono.ToString("N2")
            End If
        Next
        'End If
        'If e.ColumnIndex = Me.ClmAbono.Index Then
        'For i As Integer = 0 To Me.dgvCuentasContables.Rows.Count - 1
        '    SumaAbono = SumaAbono + Me.dgvCuentasContables.Rows(i).Cells("ClmAbono").Value
        'Next
        'End If
    End Sub

    Private Sub RellenarGridCuentas(ByVal Cta As ClasesNegocio.CuentaContableClass)
        Try
            Dim i As Integer = Me.dgvCuentasContables.Rows.Count
            Dim CtasBan As New CuentaCollectionClass
            CtasBan.Obtener(Cta.Codigo)
            If CtasBan.Count > 0 Then
                MsgBox("Imposible obtener la cuenta, es una Cuenta Bancaria", MsgBoxStyle.Information, "Aviso")
            Else
                If Me.dgvCuentasContables.Rows(0).Cells("ClmDescripcion").Value <> "" Then
                    'If CuentasRepetidas(Cta) Then
                    '    MsgBox("Imposible obtener la cuenta, Error de duplicidad", MsgBoxStyle.Information, "Aviso")
                    'Else

                    If Me.dgvCuentasContables.Rows(i - 1).Cells("ClmDescripcion").Value <> "" Then

                        Me.dgvCuentasContables.Rows(i - 1).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                        Me.dgvCuentasContables.Rows(i - 1).Cells("ClmSubCta").Value = Cta.SubCuenta
                        Me.dgvCuentasContables.Rows(i - 1).Cells("ClmSsubCta").Value = Cta.SSubCuenta
                        Me.dgvCuentasContables.Rows(i - 1).Cells("ClmSssubCta").Value = Cta.SSSubCuenta
                        Me.dgvCuentasContables.Rows(i - 1).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                        Me.dgvCuentasContables.Rows(i - 1).Cells("ClmCargo").Value = 0
                        Me.dgvCuentasContables.Rows(i - 1).Cells("ClmAbono").Value = 0
                        Me.dgvCuentasContables.Rows(i - 1).Cells("ClmCodigoCuenta").Value = Cta.Codigo
                        'Me.dgvCuentasContables.Rows.Add()

                    Else
                        Me.dgvCuentasContables.Rows(i - 1).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                        Me.dgvCuentasContables.Rows(i - 1).Cells("ClmSubCta").Value = Cta.SubCuenta
                        Me.dgvCuentasContables.Rows(i - 1).Cells("ClmSsubCta").Value = Cta.SSubCuenta
                        Me.dgvCuentasContables.Rows(i - 1).Cells("ClmSssubCta").Value = Cta.SSSubCuenta
                        Me.dgvCuentasContables.Rows(i - 1).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                        Me.dgvCuentasContables.Rows(i - 1).Cells("ClmCargo").Value = 0
                        Me.dgvCuentasContables.Rows(i - 1).Cells("ClmAbono").Value = 0
                        Me.dgvCuentasContables.Rows(i - 1).Cells("ClmCodigoCuenta").Value = Cta.Codigo
                        'Me.dgvCuentasContables.Rows.Add()
                    End If
                    ' End If
                Else
                    Me.dgvCuentasContables.Rows.Add()
                    Me.dgvCuentasContables.Rows(0).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                    Me.dgvCuentasContables.Rows(0).Cells("ClmSubCta").Value = Cta.SubCuenta
                    Me.dgvCuentasContables.Rows(0).Cells("ClmSsubCta").Value = Cta.SSubCuenta
                    Me.dgvCuentasContables.Rows(0).Cells("ClmSssubCta").Value = Cta.SSSubCuenta
                    Me.dgvCuentasContables.Rows(0).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                    Me.dgvCuentasContables.Rows(0).Cells("ClmCargo").Value = 0
                    Me.dgvCuentasContables.Rows(0).Cells("ClmAbono").Value = 0
                    Me.dgvCuentasContables.Rows(i - 1).Cells("ClmCodigoCuenta").Value = Cta.Codigo
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' CargoyAbono(dgvCuentasContables)
    End Sub

    Private Function CuentasRepetidas(ByVal cta As CuentaContableClass) As Boolean
        Try
            For i As Integer = 0 To Me.dgvCuentasContables.Rows.Count - 1
                If cta.NombreCuenta = Me.dgvCuentasContables.Rows(i).Cells("ClmDescripcion").Value Then
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Private Sub dgvCuentasContables_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvCuentasContables.KeyDown
        Try
            If e.KeyCode = Keys.F3 Then
                Dim buscarCuenta As New BusquedaCuentasContablesForm
                buscarCuenta.BloquearCaracteristicas = True
                'ojo
                'buscarCuenta.Afectables = CheckState.Checked
                If buscarCuenta.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.RellenarGridCuentas(buscarCuenta.CuentaContable)
                End If
            End If
            If e.KeyCode = Keys.Delete Then
                If MsgBox("¿Desea Realmente Borrar el detalle?", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.No Then
                    Exit Sub
                Else
                    Me.dgvCuentasContables.Rows.Remove(Me.dgvCuentasContables.SelectedRows(0))
                    SumaCargo = 0
                    SumaAbono = 0
                    For i As Integer = 0 To Me.dgvCuentasContables.Rows.Count - 1
                        SumaCargo = SumaCargo + Me.dgvCuentasContables.Rows(i).Cells("ClmCargo").Value
                        SumaAbono = SumaAbono + Me.dgvCuentasContables.Rows(i).Cells("ClmAbono").Value
                    Next
                    Me.txtSumaCargo.Text = SumaCargo.ToString("C2")
                    Me.txtSumaAbono.Text = SumaAbono.ToString("C2")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub OptExternos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptExternos.CheckedChanged
        If OptExternos.Checked = True Then
            Me.clmDescripcionEspecial.Visible = True
            Me.clmConIVA.Visible = True
            Me.clmProductoDes.Visible = False
            Me.clmCodigo.Visible = False
            Me.clmUnidad.Visible = False
        End If
    End Sub

    Private Sub OptProductos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptProductos.CheckedChanged
        If OptProductos.Checked = True Then
            Me.clmDescripcionEspecial.Visible = False
            Me.clmConIVA.Visible = False
            Me.clmProductoDes.Visible = True
            Me.clmCodigo.Visible = True
            Me.clmUnidad.Visible = True
        End If
    End Sub

    Private Sub txtDescuento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescuento.TextChanged
        calcular()
    End Sub


    Public Sub llenarMetodosPago()
        Dim connetionString As String = Nothing
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim i As Integer = 0
        Dim sql As String = Nothing
        connetionString = "Data Source=ServerName;Initial Catalog=databasename;User ID=userid;Password=yourpassword"
        sql = "select Clave,Clave+'-'+Concepto as Concepto from CatMetodosPagoSAT order by Clave"
        connection = New SqlConnection(HC.DbUtils.ActualConnectionString)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            connection.Close()
            cmbmetododepago.DataSource = ds.Tables(0)
            cmbmetododepago.ValueMember = "Clave"
            cmbmetododepago.DisplayMember = "Concepto"
            'connection.Close()
            connection.Dispose()
        Catch ex As Exception
            MessageBox.Show("Problema en llenar los metodos de pago ")
        End Try
    End Sub

    Public Sub llenarFormasPago()
        Dim connetionString As String = Nothing
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim i As Integer = 0
        Dim sql As String = Nothing
        connetionString = "Data Source=ServerName;Initial Catalog=databasename;User ID=userid;Password=yourpassword"
        sql = "select Clave,Clave+'-'+Concepto as Concepto from CatFormasPagoSAT order by Clave"
        connection = New SqlConnection(HC.DbUtils.ActualConnectionString)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            connection.Close()
            cmbformadepago.DataSource = ds.Tables(0)
            cmbformadepago.ValueMember = "Clave"
            cmbformadepago.DisplayMember = "Concepto"
            'connection.Close()
            connection.Dispose()
        Catch ex As Exception
            MessageBox.Show("Problema en llenar los formas de pago ")
        End Try
    End Sub

    Public Sub llenarUnidadesSAT()

        Dim connetionString As String = Nothing
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim i As Integer = 0
        Dim sql As String = Nothing
        connetionString = "Data Source=ServerName;Initial Catalog=databasename;User ID=userid;Password=yourpassword"
        sql = "select Clave,Clave +'-'+Concepto as Concepto from CatUnidadSAT order by 1"
        connection = New SqlConnection(HC.DbUtils.ActualConnectionString)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            connection.Close()
            clmUnidadSat.DataSource = ds.Tables(0)
            clmUnidadSat.ValueMember = "Clave"
            clmUnidadSat.DisplayMember = "Concepto"
            clmUnidadSat.ValueType = GetType(String)
            'connection.Close()
            connection.Dispose()
        Catch ex As Exception
            MessageBox.Show("Problema en llenar los unidades sat ")
        End Try
    End Sub

    Public Sub llenarUsoCFDISAT()
        Dim connetionString As String = Nothing
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim i As Integer = 0
        Dim sql As String = Nothing
        connetionString = "Data Source=ServerName;Initial Catalog=databasename;User ID=userid;Password=yourpassword"
        sql = "select Clave,Clave +'-'+Concepto as Concepto from UsoCFDISAT order by 1"
        connection = New SqlConnection(HC.DbUtils.ActualConnectionString)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            connection.Close()
            cmbUsoCFDI.DataSource = ds.Tables(0)
            cmbUsoCFDI.ValueMember = "Clave"
            cmbUsoCFDI.DisplayMember = "Concepto"
            'cmbUsoCFDI.ValueType = GetType(String)
            'connection.Close()
            connection.Dispose()
        Catch ex As Exception
            MessageBox.Show("Problema en llenar los uso de cfdi sat ")
        End Try
    End Sub

    Public Sub llenarProductosSAT()
        Dim connetionString As String = Nothing
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim i As Integer = 0
        Dim sql As String = Nothing
        dtProdServ.Columns.Add("Clave", GetType(String))
        dtProdServ.Columns.Add("Concepto", GetType(String))
        connetionString = "Data Source=ServerName;Initial Catalog=databasename;User ID=userid;Password=yourpassword"
        sql = "select Clave ,Clave +'-'+Concepto as Concepto from CatProdServSAT order by 1"
        connection = New SqlConnection(HC.DbUtils.ActualConnectionString)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            connection.Close()
            For Each row As DataRow In ds.Tables(0).Rows
                dtProdServ.Rows.Add(row("Clave"), row("Concepto"))
            Next
            clmProductoServicio.DataSource = dtProdServ
            clmProductoServicio.ValueMember = "Clave"
            clmProductoServicio.DisplayMember = "Concepto"
            'connection.Close()
            connection.Dispose()
        Catch ex As Exception
            MessageBox.Show("Problema en llenar los productos servicios sat ")
        End Try
    End Sub


    Private Sub dgvDetalle_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalle.CellValueChanged
        Try
            If e.RowIndex <> -1 Then
                If e.ColumnIndex = clmProductoDes.Index Then

                    Dim Prod As New ProductoGeneralClass(CInt(dgvDetalle.Rows(e.RowIndex).Cells(clmProductoDes.Index).Value))
                    'Prod = DirectCast(dgvDetalle.Rows(e.RowIndex).Cells(clmProductoDes.Index).Value, ProductoGeneralClass)
                    dgvDetalle.Rows(e.RowIndex).Cells(clmCodigo.Index).Value = Prod.Codigo
                    dgvDetalle.Rows(e.RowIndex).Cells(clmUnidad.Index).Value = Prod.NomUnidadMedida
                    dgvDetalle.Rows(e.RowIndex).Cells(clmIVA.Index).Value = IIf(Prod.SeAplicaIva, ((Controlador.ObtenerIVA() / 100) * (CDec(dgvDetalle.Rows(e.RowIndex).Cells(clmCantidad.Index).Value) * CDec(dgvDetalle.Rows(e.RowIndex).Cells(clmPrecio.Index).Value))).ToString("F2"), 0D)
                    dgvDetalle.Rows(e.RowIndex).Cells(clmIVAdecimales.Index).Value = IIf(Prod.SeAplicaIva, ((Controlador.ObtenerIVA() / 100) * (CDec(dgvDetalle.Rows(e.RowIndex).Cells(clmCantidad.Index).Value) * CDec(dgvDetalle.Rows(e.RowIndex).Cells(clmPrecio.Index).Value))).ToString("F4"), 0D)
                    dgvDetalle.Rows(e.RowIndex).Cells(clmProductoServicio.Index).Value = "01010101"
                    dgvDetalle.Rows(e.RowIndex).Cells(clmUnidadSat.Index).Value = "XNA"

                    'dgvDetalle.Rows(e.RowIndex).Cells(clmUnidad.Index).Value = Prod.
                    calcular()
                End If
                If e.ColumnIndex = clmDescripcionEspecial.Index Then
                    If Me.clmDescripcionEspecial.Visible = True Then
                        dgvDetalle.Rows(e.RowIndex).Cells(clmProductoServicio.Index).Value = "01010101"
                        dgvDetalle.Rows(e.RowIndex).Cells(clmUnidadSat.Index).Value = "XNA"
                        dgvDetalle.Rows(e.RowIndex).Cells(clmUnidad.Index).Value = "N/A"
                        dgvDetalle.Rows(e.RowIndex).Cells(clmIVA.Index).Value = CDec(0).ToString("F2")
                        calcular()
                    End If
                End If
                If e.ColumnIndex = clmConIVA.Index Then
                    If dgvDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).EditedFormattedValue = True Then
                        dgvDetalle.Rows(e.RowIndex).Cells(clmIVA.Index).Value = Math.Round(((Controlador.ObtenerIVA() / 100) * Math.Round((CDec(dgvDetalle.Rows(e.RowIndex).Cells(clmCantidad.Index).Value) * CDec(dgvDetalle.Rows(e.RowIndex).Cells(clmPrecio.Index).Value)), 2)), 2)
                        dgvDetalle.Rows(e.RowIndex).Cells(clmIVAdecimales.Index).Value = ((Controlador.ObtenerIVA() / 100) * (CDec(dgvDetalle.Rows(e.RowIndex).Cells(clmCantidad.Index).Value) * CDec(dgvDetalle.Rows(e.RowIndex).Cells(clmPrecio.Index).Value))).ToString("F4")
                    Else
                        dgvDetalle.Rows(e.RowIndex).Cells(clmIVA.Index).Value = CDec(0).ToString("F2")
                    End If
                    calcular()
                End If
            End If
        Catch ex As Exception
          ''  MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub dgvDetalle_DefaultValuesNeeded(sender As System.Object, e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvDetalle.DefaultValuesNeeded

        e.Row.Cells(clmCargo.Index).Value = Math.Round(0, 2, MidpointRounding.AwayFromZero)
        e.Row.Cells(clmAbono.Index).Value = Math.Round(0, 2, MidpointRounding.AwayFromZero)
        e.Row.Cells(clmCantidad.Index).Value = Math.Round(1, 2, MidpointRounding.AwayFromZero)
        e.Row.Cells(clmImporte.Index).Value = Math.Round(1, 2, MidpointRounding.AwayFromZero)
        e.Row.Cells(clmPrecio.Index).Value = Math.Round(1, 2, MidpointRounding.AwayFromZero)
        If Me.clmDescripcionEspecial.Visible = True Then
            e.Row.Cells(Me.clmUnidad.Index).Value = "N/A"
            e.Row.Cells(clmIVA.Index).Value = Math.Round(0, 2, MidpointRounding.AwayFromZero)
        End If

    End Sub


    Private Sub dgvDetalle_CurrentCellDirtyStateChanged(sender As System.Object, e As System.EventArgs) Handles dgvDetalle.CurrentCellDirtyStateChanged
        If dgvDetalle.IsCurrentCellDirty Then
            dgvDetalle.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub txtDescuento_Leave(sender As System.Object, e As System.EventArgs) Handles txtDescuento.Leave
        If txtDescuento.Text.Trim().Equals("") Then
            txtDescuento.Text = "0.00"
        End If

    End Sub



    'Private Sub frmFacturacionEspecial_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        e.SuppressKeyPress = True
    '        SendKeys.Send("{ENTER}")
    '    End If

    'End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Dim keyCode As Keys = CType(msg.WParam, IntPtr).ToInt32
        Const WM_KEYDOWN As Integer = &H100
        'Const WM_KEYUP As Integer = &H101   in case people need this

        If msg.Msg = WM_KEYDOWN AndAlso keyCode = Keys.Enter Then
            'AndAlso (Me.ActiveControl.GetType.Name = "TextBox" Or Me.ActiveControl.GetType.Name = "ComboBox" Or Me.ActiveControl.GetType.Name = "UltraCombo" Or Me.ActiveControl.GetType.Name = "RadioButton") Then
            SendKeys.Send("{TAB}")
            Return True

        End If
        Return MyBase.ProcessCmdKey(msg, keyData)


    End Function

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtCodigoCliente_Leave(sender As System.Object, e As System.EventArgs) Handles txtCodigoCliente.Leave
        If Not txtCodigoCliente.Text.Trim().Equals("") Then
            CmbCliente.SelectedValue = CInt(txtCodigoCliente.Text.Trim())
        End If
    End Sub

    Private Sub dgvDetalle_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalle.CellContentClick

    End Sub
End Class