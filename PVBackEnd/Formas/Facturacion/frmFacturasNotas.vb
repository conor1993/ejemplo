Imports ClasesNegocio
Imports Ccom = ClasesComunes
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports Integralab
Imports System.IO

Public Class frmFacturasNotas

#Region "Miembros"
    'declaracion de clases    
    'variables para las clases de control y cuentas contables
    Dim Estado As FormState
    'variables para las clases de polizas
    'se cambio por las nuevas tablas de pólizas
    'Dim PolizaCab As New PolizaClass
    'Dim PolizaDet As New PolizaDetalleClass
    'Dim PolizaCab As New PolizaCabeceroClass
    'Dim PolizaDet As New PolizaDetalleGanClass
    'se eliminan los generadores de folios ya que la tabla de pólizas los genera en forma automatica
    '' Dim FolDia As New FolioDiarioPolizaClass
    ''Dim FolCan As New FolioDiarioPolizaClass
    'variables para las clases de facturas y embarques
    Dim FacturasCab As New FacturasClientesCabClass
    Dim FacturasDet As New FacurasClientesDetClass
    Dim FacturasDetProductosTotales As New FacturasClientesDetProductosTotalesClass
    Dim ClientesV As New ClasesNegocio.ClientesIntroductoresColeccion
    Dim Cliente As New ClientesIntroductoresClass
    'variables para la impresion de facturas
    Dim NumerodeFacturas As Integer
    Dim ListaNotas As New CC.NotaVentaCollection
    Dim ListaNotasR As New CC.NotaVentaRespCollection
    Dim DetalleNotaVentaResp As New CC.NotaVentaDetalleRespCollection
    Dim liCodSucursal As Integer = Ccom.Utilerias.ObtenerCodSucursal()
    Dim Sucursal As SucursalClass
    Dim ldIVA As Decimal = Controlador.ObtenerIVA()
    Dim liSubTotal, liIva, liIeps, liTotal As Decimal
    Dim ClientesCol As Integralab.ORM.CollectionClasses.MfacCatClientesCollection
    Dim CambDir As Boolean = False
    Dim Buscarr As Boolean = False
    Dim CveMetodoPago

#End Region

#Region "Metodos"

    Public Property MetodoPagoCVE() As String
        Get
            Return Me.CveMetodoPago
        End Get
        Set(ByVal Value As String)
            Me.CveMetodoPago = Value
        End Set
    End Property

    Private Function Guardar(ByRef Trans As HC.Transaction) As Boolean
        'If Not ValidarCambiosPrecios() Then Exit Function
        ''generar folio de factura
        'If Not FolioFactura.Guardar(Trans) Then
        '    MsgBox("FolioFactura")
        '    Trans.Rollback()
        '    Return False
        'End If

        'Me.txtFolioFactura.Text = FolioFactura.Consecutivo
        'Dim FechaFactura As DateTime = Now
        'Sucursal.SerieFactura.Entidad.Refetch()
        'Me.txtFolioFactura.Text = Sucursal.SerieFactura.Consecutivo
        'Sucursal.SerieFactura.Consecutivo += 1
        Dim metodoPago As String
        Dim NumCta As String
        ''Validar metodo de pago
        Dim forma As New frmMetodoPagoEmergente
        Dim reult As DialogResult = forma.ShowDialog

        If reult = Windows.Forms.DialogResult.OK Then

            MetodoPagoCVE = forma.MetodoPagoCVE
            metodoPago = MetodoPagoCVE
            NumCta = forma.NumeroCuenta
        Else
            Return False
        End If

        Dim Fact As CFDI.Comprobante
        Dim DomFiscalCte As DomicilioClienteClass
        DomFiscalCte = DirectCast(cmbDomiciliosFiscales.SelectedItem, DomicilioClienteClass)
        Cliente = New ClientesIntroductoresClass(DirectCast(CmbCliente.SelectedItem, EC.MfacCatClientesEntity))
        FacturasCab = New FacturasClientesCabClass
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
        Dim TransG As New Gentle.Framework.Transaction(Integralab.FactDigital.ControladorFactDigital.Conexion)
        Try
            '' Datos del emisor
            Dim DomicilioFiscal As New CFDI.UbicacionFiscal(Controlador.Sesion.MiEmpresa.EmpCalle, Controlador.Sesion.MiEmpresa.EmpLocalidad, Controlador.Sesion.MiEmpresa.EmpEstado, "MEXICO", Controlador.Sesion.MiEmpresa.EmpCodigoPostal)
            DomicilioFiscal.colonia = Controlador.Sesion.MiEmpresa.EmpColonia
            DomicilioFiscal.noExterior = Controlador.Sesion.MiEmpresa.EmpNoExt
            DomicilioFiscal.noInterior = Controlador.Sesion.MiEmpresa.EmpNoInt

            'Dim ExpedidoEn As New Integralab.CFDI.Ubicacion("MEXICO")
            'ExpedidoEn.municipio = "CULIACAN"
            'ExpedidoEn.estado = "SINALOA"

            Dim RegimenFiscal As New List(Of CFDI.ComprobanteEmisorRegimenFiscal)
            RegimenFiscal.Add(New CFDI.ComprobanteEmisorRegimenFiscal(Controlador.Sesion.MiEmpresa.EmpRegimenFiscal))

            Dim Emisor As New CFDI.ComprobanteEmisor(Controlador.Sesion.MiEmpresa.EmpRfc, RegimenFiscal)
            Emisor.nombre = Controlador.Sesion.MiEmpresa.Empnom
            Emisor.DomicilioFiscal = DomicilioFiscal
            'Emisor.ExpedidoEn = ExpedidoEn

            '' Datos del cliente

            Dim Receptor As New CFDI.ComprobanteReceptor(Cliente.RFC.Replace("_", "").Replace("-", "").Replace(" ", ""))
            Dim Domicilio As New CFDI.Ubicacion("MEXICO")
            Domicilio.calle = DomFiscalCte.Calle
            Domicilio.colonia = DomFiscalCte.Colonia
            Domicilio.codigoPostal = DomFiscalCte.CodigPostal
            Domicilio.noExterior = DomFiscalCte.NoExt
            Domicilio.noInterior = DomFiscalCte.NoInt
            Domicilio.localidad = DomFiscalCte.Poblacion.Descripcion
            Domicilio.municipio = DomFiscalCte.Poblacion.CodigoCiudad.Descripcion
            Domicilio.estado = DomFiscalCte.Poblacion.CodigoEstado.Descripcion
            'Domicilio.referencia = CompA.Receptor.Domicilio.Referencia

            Receptor.nombre = Cliente.RazonSocial
            Receptor.Domicilio = Domicilio

            '' crea lista IVA vacio
            Dim Impuestos As New CFDI.ComprobanteImpuestos()
            Impuestos.Traslados = New List(Of CFDI.ComprobanteImpuestosTraslado)

            '' crea lista de conceptos y la llena
            Dim Conceptos As New List(Of CFDI.ComprobanteConcepto)()
            Dim ldSubtotal, ldTotal As Decimal
            For Each det As DataGridViewRow In dgvDetalleConcentrado.Rows
                Dim producto As New ClasesNegocio.ProductoGeneralClass(CInt(det.Cells(clmCodigo.Index).Value))
                Dim impues As Decimal = 0
                If CDec(det.Cells("clmIVA").Value) > 0 Then
                    If producto.SeAplicaIva Then
                        impues += Controlador.ObtenerIVA
                    End If
                End If
                If CDec(det.Cells("clmPorcIEPS").Value) > 0 Then
                    If producto.PorcIEPS > 0 Then
                        impues += producto.PorcIEPS
                    End If
                End If

                ''Dim puSinIva As Decimal = CDec(det.Cells("clmPrecioUnit").Value) / IIf(impues = 0, 1, 1 + (impues / 100))

                Dim puSinIva As Decimal = ((CDec(det.Cells("clmPrecioUnit").Value) - (CDec(det.Cells("clmIVA").Value) / CDec(det.Cells(clmCantidad.Index).Value))) - (CDec(det.Cells("clmIEPS").Value) / CDec(det.Cells(clmCantidad.Index).Value)))
                'Console.WriteLine(CStr(puSinIva))
                'Application.DoEvents()
                Dim ImporteSinIva As Decimal = CDec(puSinIva) * CDec(det.Cells(clmCantidad.Index).Value)
                Dim Concepto As New CFDI.ComprobanteConcepto(CDec(det.Cells("clmCantidad").Value), CStr(det.Cells("clmUniMed").Value), CStr(det.Cells("clmDescripcion").Value), CDec(puSinIva).ToString("N4"), CDec(ImporteSinIva).ToString("N4"))
                Conceptos.Add(Concepto)
                ldSubtotal += Concepto.importe
                ldTotal += CDec(det.Cells("clmTotal").Value)

                '' se busca el impuesto correcto para acumular y si no se encuentra agrega el impuesto del producto a la lista
                Dim acum As Boolean = False
                Dim ldImpIva As Decimal = CDec(det.Cells("clmIVA").Value)
                If ldImpIva > 0 Then
                    For Each imp As CFDI.ComprobanteImpuestosTraslado In Impuestos.Traslados
                        If imp.impuesto = Integralab.CFDI.ComprobanteImpuestosTrasladoImpuesto.IVA And imp.tasa = ldIVA Then
                            imp.importe = imp.importe + (ldImpIva)
                            acum = True
                        End If
                    Next
                    If Not acum Then
                        Dim Impuesto As New CFDI.ComprobanteImpuestosTraslado
                        Impuesto.impuesto = Integralab.CFDI.ComprobanteImpuestosTrasladoImpuesto.IVA
                        Impuesto.tasa = ldIVA
                        Impuesto.importe = (ldImpIva)
                        Impuestos.Traslados.Add(Impuesto)
                    End If
                End If

                acum = False
                Dim ldImpIeps As Decimal = CDec(det.Cells("clmIEPS").Value)
                Dim ldPorcIeps As Decimal = CDec(det.Cells("clmPorcIEPS").Value)
                If ldImpIeps > 0 Then
                    For Each imp As CFDI.ComprobanteImpuestosTraslado In Impuestos.Traslados
                        If imp.impuesto = Integralab.CFDI.ComprobanteImpuestosTrasladoImpuesto.IEPS And imp.tasa = ldPorcIeps Then
                            imp.importe = imp.importe + (ldImpIeps)
                            acum = True
                        End If
                    Next
                    If Not acum Then
                        Dim Impuesto As New CFDI.ComprobanteImpuestosTraslado
                        Impuesto.impuesto = Integralab.CFDI.ComprobanteImpuestosTrasladoImpuesto.IEPS
                        Impuesto.tasa = ldPorcIeps
                        Impuesto.importe = (ldImpIeps)
                        Impuestos.Traslados.Add(Impuesto)
                    End If
                End If
            Next

            'si no hay iva agrega el renglon al 0%
            If Impuestos.Traslados.Count = 0 Then
                Dim Impuesto As New CFDI.ComprobanteImpuestosTraslado
                Impuesto.impuesto = Integralab.CFDI.ComprobanteImpuestosTrasladoImpuesto.IVA
                Impuesto.tasa = 0
                Impuesto.importe = 0
                Impuestos.Traslados.Add(Impuesto)
            End If

            Impuestos.CalcularTotalImpuestosRetenidos()
            Impuestos.CalcularTotalImpuestosTrasladados()

            Dim ldPagoEfectivo, ldPagoTarjeta As Decimal

            For Each nt As EC.NotaVentaEntity In ListaNotas
                ldPagoEfectivo += nt.Pago
                ldPagoTarjeta += nt.PagoTarj
            Next

            ''Se comento esto por que de la parte de arriba saca el metodo de pago de una ventana emergente
            'If ldPagoEfectivo > 0 And ldPagoTarjeta = 0 Then
            '    metodoPago = "EFECTIVO"
            'ElseIf ldPagoEfectivo = 0 And ldPagoTarjeta > 0 Then
            '    metodoPago = "TARJETA DE CREDITO"
            'Else
            '    metodoPago = "NO IDENTIFICADO"
            'End If

            ' Crea el objeto comprobante
            Fact = New CFDI.Comprobante(Emisor, Receptor, Conceptos, Impuestos, dtFechaFactura.Value, "", "PAGO EN UNA SOLA EXHIBICION", "", "", ldSubtotal, ldTotal, _
                                        IntegraLab.CFDI.ComprobanteTipoDeComprobante.ingreso, metodoPago, Controlador.Sesion.MiEmpresa.EmpMunicipio + ", " + Controlador.Sesion.MiEmpresa.EmpEstado)
            With Fact
                .folio = txtFolioFactura.Text.Trim()
                .serie = Sucursal.SerieFactura.StaLetraSerie
                .condicionesDePago = ""
                .descuento = 0
                .motivoDescuento = ""
                .TipoCambio = ""
                .Moneda = ""
                .NumCtaPago = NumCta
                .FolioFiscalOrig = ""
                .SerieFolioFiscalOrig = ""
                .MontoFolioFiscalOrig = 0
                .Observacion = txtObservaciones.Text.Trim
                .eMail = DomFiscalCte.Email
            End With






            ''ANTES DE GENERAR SE GENERA LA FACTURA EN EL SISTEMA Y DESPUES SE TIMBRA
            'datos para el cabecero de factura.
            Trans.Save("Factura")
            Dim reintentar = True
            While reintentar
                Try
                    FacturasCab.NoFactura = Me.txtFolioFactura.Text 'FolioFactura.Consecutivo
                    FacturasCab.Serie = Sucursal.SerieFactura.StaLetraSerie
                    FacturasCab.FechaCaptura = Now
                    FacturasCab.FechaFactura = dtFechaFactura.Value  'Me.dtFechaFactura.Value
                    FacturasCab.FechaVencimiento = dtpFechaVencimiento.Value
                    ' contemplar si es cliente vario
                    FacturasCab.IdCliente = CInt(Me.txtCodigoCliente.Text)
                    FacturasCab.IdDomicilioFiscal = DomFiscalCte.IdRenglon
                    FacturasCab.IdClienteCargo = CInt(Me.txtCodigoCliente.Text)

                    FacturasCab.Contado = True    'Me.rdContado.Checked
                    'FacturasCab.Credito = Me.rdCredito.Checked
                    'FacturasCab.IdPoliza = PolizaCab.Codigo
                    FacturasCab.Contabilizado = "N"
                    'FacturasCab.FechaContabilizacion = FechaFactura
                    FacturasCab.IVA = CDec(Me.txtIVA.Text)
                    FacturasCab.IEPS = CDec(Me.txtIEPS.Text)
                    FacturasCab.SubTotal = CDec(Me.txtSubTotal.Text)
                    FacturasCab.Total = CDec(Me.txtTotal.Text)
                    FacturasCab.Estatus = "V"
                    FacturasCab.Observaciones = Me.txtObservaciones.Text
                    FacturasCab.TipoFactura = 1
                    FacturasCab.Origen = "V"
                    FacturasCab.UUID = ""
                    FacturasCab.FormaDePago = Fact.formaDePago
                    FacturasCab.MetodoDePago = Fact.metodoDePago
                    FacturasCab.CondicionesDePago = Fact.condicionesDePago
                    FacturasCab.Func = "I"
                    FacturasCab.NumOpc = 1

                    If Not FacturasCab.Guardar(Trans) Then
                        MessageBox.Show("No se pudo guardar la factura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Trans.Rollback()
                        Return False
                    End If


                    'guarda el concentrado por productos de la factura            
                    For i As Integer = 0 To Me.dgvDetalleConcentrado.RowCount - 1
                        FacturasDetProductosTotales = New FacturasClientesDetProductosTotalesClass
                        With FacturasDetProductosTotales
                            .SerieFactura = FacturasCab.Serie
                            .NoFactura = FacturasCab.NoFactura
                            .IdProducto = CInt(Me.dgvDetalleConcentrado.Rows(i).Cells("clmCodigo").Value)
                            '.KilosEmb = CDec(Me.dgvDetalleConcentrado.Rows(i).Cells("KilosEmbarcados").Value)
                            .KilosFac = CDec(Me.dgvDetalleConcentrado.Rows(i).Cells("clmCantidad").Value)
                            .Precio = CDec(Me.dgvDetalleConcentrado.Rows(i).Cells("clmPrecioUnit").Value)
                            '.ImporteEmb = CDec(Me.dgvDetalleConcentrado.Rows(i).Cells("ImporteEmbarcado").Value)
                            .ImporteFac = CDec(Me.dgvDetalleConcentrado.Rows(i).Cells("clmImporte").Value)
                            .IVA = CDec(Me.dgvDetalleConcentrado.Rows(i).Cells("clmIVA").Value)
                            .IEPS = CDec(Me.dgvDetalleConcentrado.Rows(i).Cells("clmIEPS").Value)
                            .Renglon = i + 1
                            .NotaVenta = CInt(Me.dgvDetalleConcentrado.Rows(i).Cells(clmNotaVenta.Index).Value)
                            '.Embarque = Me.lvNotasVenta.Items(0).Text
                        End With

                        If Not FacturasDetProductosTotales.Guardar(Trans) Then
                            MessageBox.Show("No se pudo guardar el detalle de la factura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Trans.Rollback()
                            Return False
                        End If


                    Next

                    'For Each LItem As ListViewItem In Me.lvNotasVenta.Items
                    For Each LItem As EC.NotaVentaEntity In ListaNotas
                        LItem.SerieFact = txtSerie.Text.Trim
                        LItem.FolioFact = txtFolioFactura.Text.Trim
                        Trans.Add(LItem)
                        LItem.Save()
                    Next

                    For Each LItem As EC.NotaVentaRespEntity In ListaNotasR
                        LItem.SerieFact = txtSerie.Text.Trim
                        LItem.FolioFact = txtFolioFactura.Text.Trim
                        Trans.Add(LItem)
                        LItem.Save()
                    Next

                    'guarda el detalle de facturas  esto para el area contable
                    'For i As Integer = 0 To Cuentas.Count - 1
                    '    FacturasDet.NoFactura = FacturasCab.NoFactura
                    '    FacturasDet.IdCliente = Me.txtCodigoCliente.Text
                    '    FacturasDet.CtaMay = Cuentas(i).CuentaMayor
                    '    FacturasDet.SubCta = Cuentas(i).SubCuenta
                    '    FacturasDet.SsbCta = Cuentas(i).SSubCuenta
                    '    FacturasDet.SssCta = Cuentas(i).SSSubCuenta
                    '    FacturasDet.Importe = Me.txtTotal.Text

                    '    If i = 0 Then
                    '        FacturasDet.CargoAbono = "C"
                    '    Else
                    '        FacturasDet.CargoAbono = "A"
                    '    End If

                    '    FacturasDet.Func = "I"
                    '    FacturasDet.NumOpc = 1

                    '    If Not FacturasDet.Guardar(Trans) Then
                    '        Trans.Rollback()
                    '        'MessageBox.Show("Detalle Factura", "", MessageBoxButtons.OK)
                    '        Return False
                    '    End If
                    'Next

                    'FacturasDet.Serie = FacturasCab.Serie
                    'FacturasDet.NoFactura = FacturasCab.NoFactura
                    'FacturasDet.IdCliente = Me.txtCodigoCliente.Text
                    'FacturasDet.Importe = Me.txtTotal.Text

                    'FacturasDet.Func = "I"
                    'FacturasDet.NumOpc = 1

                    'If Not FacturasDet.Guardar(Trans) Then
                    '    Throw New Exception("Error  al guardar el producto ")
                    'End If

                    
                    Dim conRFC As Boolean = True

                    'If MessageBox.Show("¿Desea imprimirlo con RFC?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                    '    conRFC = False
                    'End If

                    'FacturasCab = New FacturasClientesCabClass()


                    reintentar = False
                Catch ex As Exception
                    If MessageBox.Show("La factura se ha generado pero no fue posible marcar los tickets como facturados debido al siguiente error:" & vbCrLf & ex.Message + vbCrLf + "¿Desea reintentar marcar los tickets?", ex.Source, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                        Return False
                    Else
                        Trans.Rollback("Facturas")
                    End If
                End Try
            End While


#If DEBUG Then
            Dim cfdi As CFDI.ORM.CFDI = ControlFD.GenerarCFDI(Fact.folio, Fact, TransG, True, True)
#Else
            Dim cfdi As CFDI.ORM.CFDI = ControlFD.GenerarCFDI(Fact.folio, Fact, TransG, False, True)
#End If
            If File.Exists(Application.StartupPath + "\\" + "Error.txt") Then
                TransG.Rollback()
                File.ReadAllText(Application.StartupPath + "\\" + "Error.txt")
                MsgBox("Error al generar el CFDI." & vbCrLf & File.ReadAllText(Application.StartupPath + "\\" + "Error.txt"), MsgBoxStyle.Critical, "Facturación")
                Return False
            End If
            Trans.Commit()
            FacturasCab.UUID = cfdi.UUID.ToString()
            If Not FacturasCab.Guardar(Trans) Then
                MessageBox.Show("No se pudo guardar la factura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Trans.Rollback()
                Return False
            End If

            TransG.Commit()

            'File.WriteAllText(Application.StartupPath + "\\" + "Folio.txt", cfdi.UUID)
            txtUUID.Text = cfdi.UUID

            Dim Ubicacion As String = ControlFD.GenerarArchivoPDF(cfdi, Conceptos)
            System.Diagnostics.Process.Start(Ubicacion)
            Me.dgvDetalleConcentrado.Rows.Clear()

            Return True
        Catch ex As Exception
            If ex.Message = "No hay ninguna aplicación asociada con el archivo especificado para esta operación" Then
                MessageBox.Show("Debe instalar Adobe Reader para abrir los archivos pdf", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else


                TransG.Rollback()
                MsgBox("Error al generar el CFDI." & vbCrLf & ex.Message, MsgBoxStyle.Critical, ex.Source)
                Return False
            End If
        End Try
        '-----------------------------------------------
        ' termina codigo agregado para generar el CFDI
        '-----------------------------------------------


        '----------------------------------------------------
        '   Inicia la generacion de la poliza contable
        '----------------------------------------------------
        'datos para el cabecero de poliza 

        'Dim Cuentas As New List(Of CuentaContableClass)
        'Dim IdCuentaContVentas As Integer = CuentaControl(0).IdCuentaContable

        ''Dim PolizaCab As New PolizaClass

        'Cuentas.Add(Cliente.CuentaContable)
        'Cuentas.Add(New CuentaContableClass(CuentaControl(0).CuentaContable))

        'PolizaCab.Concepto = "Póliza de venta de cortes,productos con factura " & Me.txtFolioFactura.Text & " del cliente " & Me.txtCodigoCliente.Text
        'PolizaCab.EmpresaId = Controlador.Sesion.MiEmpresa.Empndx
        'PolizaCab.Estatus = PolizaEstatusEnum.ACTIVA
        'PolizaCab.FechaCaptura = Now
        'PolizaCab.FechaPoliza = Now
        'PolizaCab.Importe = Me.txtTotal.Text
        'PolizaCab.Mes = Month(Now)
        'PolizaCab.Origen = PolizaOrigenEnum.VENTAS
        'PolizaCab.TipoCambio = 1
        'PolizaCab.TipoError = ErroresPolizaEnum.NINGUNO
        'PolizaCab.TipoPoliza = PolizaTipoPolizaEnum.DIARIO

        'For i As Integer = 0 To Cuentas.Count - 1
        '    Dim PolizaDet As New PolizaDetalleClass

        '    PolizaDet = New PolizaDetalleClass
        '    PolizaDet.IdCuentaContable = Cuentas(i).Codigo
        '    PolizaDet.Importe = Me.txtTotal.Text

        '    If i = 0 Then
        '        PolizaDet.Operacion = PolizaOperacionEnum.CARGO
        '    Else
        '        PolizaDet.Operacion = PolizaOperacionEnum.ABONO
        '    End If
        '    PolizaDet.Posicion = i + 1
        '    PolizaCab.Detalles2.Add(PolizaDet)
        'Next

        'If PolizaCab.Detalles2.Count = 0 Then
        '    PolizaCab.TipoError = ClasesNegocio.ErroresPolizaEnum.NO_SE_ENCONTRO_EL_DETALLE_DE_LA_POLIZA
        'End If

        'If Not PolizaCab.Guardar2(Trans) Then
        '    Trans.Rollback()
        '    MessageBox.Show("La Póliza no ha sido grabada ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Return False
        'End If

        '----------------------------------------------------
        '   Termina la generación de la poliza contable
        '----------------------------------------------------

        '----------------------------------------------------
        '   Inicia el guardado de la factura
        '----------------------------------------------------

        
    End Function

    Private Function Limpiar() As Boolean
        Me.txtCodigoCliente.Text = ""
        Me.CmbCliente.SelectedIndex = -1
        Me.txtDiasCredito.Text = "0"
        Me.txtFolioNota.Text = ""
        Me.txtFolioFactura.Text = ""
        Me.txtIVA.Text = "0.00"
        Me.txtObservaciones.Text = ""
        Me.txtRFC.Text = ""
        Me.txtSubTotal.Text = "0.00"
        Me.txtTotal.Text = "0.00"
        Me.txtUUID.Text = ""
        Me.dgvDetalle.DataSource = Nothing
        Me.dgvDetalle.Rows.Clear()
        Me.dgvDetalleConcentrado.DataSource = Nothing
        Me.dgvDetalleConcentrado.Rows.Clear()

        Me.lblEstatus.Visible = False
        Me.txtUUID.Visible = False
        Me.lblUUID.Visible = False
        Me.dtFechaFactura.Value = Now
        Me.dtpFechaVencimiento.Value = Now
        'Me.CmbClientesVarios.Text = "Seleccione un cliente"
        Me.lvNotasVenta.Clear()
        Me.cmbDomiciliosFiscales.DataSource = Nothing
        ListaNotas.Clear()
        Buscarr = False
        liSubTotal = 0
        liTotal = 0
        liIeps = 0
        liIva = 0
    End Function

    Private Function Buscar() As Boolean
        If Me.ActiveControl.Name = "cmbCliente" Or Me.ActiveControl.Name = "txtCodigoCliente" Then
            Try
                Me.lblEstatus.Text = FormState.Buscar
                Dim Ventana As New Ccom.FrmBusquedaClientes
                If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Cliente = New ClientesIntroductoresClass
                    Cliente.Obtener(Ventana.dgvClientes.SelectedRows(0).Cells("clmCodigo").Value)
                    txtCodigoCliente.Text = Format(Cliente.Codigo, "N0")
                    CmbCliente.Text = Cliente.RazonSocial
                    txtRFC.Text = Cliente.RFC
                    txtCodigoCliente.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Facturación de notas de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            Try
                Dim Consulta As New FrmConFacturas

                If Consulta.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.dgvDetalleConcentrado.Rows.Clear()
                    Me.lvNotasVenta.Items.Clear()
                    Dim Folio As String = Consulta.DgvFacturas.CurrentRow.Cells("Factura").Value
                    Dim Serie As String = Consulta.DgvFacturas.CurrentRow.Cells("Serie").Value
                    'If Not DBNull.Value.Equals(Consulta.DgvFacturas.CurrentRow.Cells("IdFolioEmbarque").Value) Then
                    '    For i As Integer = 0 To Consulta.DgvFacturas.Rows.Count - 1
                    '        If Folio = Consulta.DgvFacturas.Rows(i).Cells("Factura").Value Then
                    '            Me.lvNotasVenta.Items.Add(Consulta.DgvFacturas.Rows(i).Cells("IdFolioEmbarque").Value)
                    '        End If
                    '    Next
                    'End If

                    Dim IdCliente As Integer = CInt(Consulta.DgvFacturas.CurrentRow.Cells("IdCliente").Value)
                    Me.FacturasCab = New FacturasClientesCabClass(Serie, Folio)

                    Me.txtSerie.Text = FacturasCab.Serie
                    Me.txtFolioFactura.Text = FacturasCab.NoFactura
                    Me.txtUUID.Text = FacturasCab.UUID
                    Me.CmbCliente.Text = FacturasCab.Cliente.RazonSocial
                    Me.txtCodigoCliente.Text = FacturasCab.IdCliente
                    Me.dtFechaFactura.Text = FacturasCab.FechaFactura
                    Me.txtSubTotal.Text = FacturasCab.SubTotal.ToString("N2")
                    Me.txtIVA.Text = FacturasCab.IVA.ToString("N2")
                    Me.txtIEPS.Text = FacturasCab.IEPS.ToString("N2")
                    Me.txtTotal.Text = FacturasCab.Total.ToString("N2")
                    Me.txtObservaciones.Text = FacturasCab.Observaciones
                    Me.txtRFC.Text = FacturasCab.Cliente.RFC
                    Me.lblEstatus.Text = IIf(IsDBNull(Consulta.DgvFacturas.CurrentRow.Cells("Estatus").Value), "CANCELADA", Consulta.DgvFacturas.CurrentRow.Cells("Estatus").Value)
                    Me.lblEstatus.Visible = True
                    Me.txtUUID.Visible = True
                    Me.lblUUID.Visible = True
                    Dim TablaFac As DataSet = FacturasCab.Consulta(Me.txtSerie.Text, Me.txtFolioFactura.Text, 5)

                    Me.dgvDetalleConcentrado.AutoGenerateColumns = False
                    Me.dgvDetalleConcentrado.DataSource = TablaFac.Tables(0)

                    Cliente = New ClasesNegocio.ClientesIntroductoresClass(New EC.MfacCatClientesEntity(CInt(Me.txtCodigoCliente.Text)))
                    Me.cmbDomiciliosFiscales.DataSource = Cliente.DomiciliosFiscales

                    If Cliente.DomiciliosFiscales.Count = 1 Then
                        cmbDomiciliosFiscales.SelectedIndex = 0
                    End If
                    Buscarr = True
                Else
                    Return False
                End If

                Return True
            Catch ex As Exception
                MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End If
    End Function

    Private Sub RellenarClientesVarios()
        ClientesV.Obtener(False, CondicionEstatusEnum.ACTIVO)
        'Me.CmbClientesVarios.ValueMember = "Codigo"
        'Me.CmbClientesVarios.DisplayMember = "Nombre"
        'Me.CmbClientesVarios.DataSource = ClientesV
    End Sub

    Private Sub Habilitar()
        Me.txtFolioNota.Enabled = True
        Me.txtFolioFactura.Enabled = True
        Me.dtFechaFactura.Enabled = True
        Me.dtpFechaVencimiento.Enabled = True
        Me.txtCodigoCliente.Enabled = True
        Me.CmbCliente.Enabled = True
        Me.txtRFC.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.txtDiasCredito.Enabled = True
        Me.rdContado.Enabled = True
        Me.rdCredito.Enabled = True
        Me.cmbDomiciliosFiscales.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        Me.txtFolioNota.Enabled = False
        Me.txtFolioFactura.ReadOnly = True
        Me.dtFechaFactura.Enabled = False
        Me.dtpFechaVencimiento.Enabled = False
        Me.txtCodigoCliente.Enabled = False
        Me.CmbCliente.Enabled = False
        Me.txtRFC.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.txtDiasCredito.Enabled = False
        Me.rdContado.Enabled = False
        Me.rdCredito.Enabled = False
        Me.cmbDomiciliosFiscales.Enabled = False
    End Sub

    Private Function Cancelacion() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
        Dim Notas As New CC.NotaVentaCollection
        Dim TransG As Gentle.Framework.Transaction
        Try


            Dim ControlFD As IntegraLab.FactDigital.ControladorFactDigital
            Dim ConStr As String
            If File.Exists(Application.StartupPath + "\\cx.dat") Then
                ConStr = IntegraLab.FactDigital.ControladorFactDigital.Decrypt(File.ReadAllText(Application.StartupPath + "\\cx.dat"))
            Else
                Throw New Exception("No se ha configurado la conexión a la base de datos de la factura digital.")
            End If
            'Dim TransG As New Gentle.Framework.Transaction(IntegraLab.FactDigital.ControladorFactDigital.Conexion)
            ControlFD = New IntegraLab.FactDigital.ControladorFactDigital(Controlador.Empresa.CodEmpndx, ConStr)
            TransG = New Gentle.Framework.Transaction(IntegraLab.FactDigital.ControladorFactDigital.Conexion)
            'ControlFD.GeneraCFDI_PDF(FacturasCab.UUID, True)

            'Dim ControlFD As New IntegraLab.FactDigital.ControladorFactDigital(Controlador.Empresa.CodEmpndx, ConStr)

            ''ControlFD.GeneraCFDI_PDF(FacturasCab.UUID, True)
            ControlFD.CancelarCFDI(FacturasCab.UUID, DateTime.Now, TransG)
            'variables para el regreso de los obtener en dataset y datatable
            'Dim TablaConfiguracionCuentas As DataTable
            'Dim PolizaCab As New PolizaClass

            'datos para el cabecero de factura.
            'FacturasCab.NoFactura = Me.txtFolioFactura.Text
            'FacturasCab.FechaCaptura = Now
            'FacturasCab.FechaFactura = Me.dtFechaFactura.Value
            'FacturasCab.FechaVencimiento = Me.dtpFechaVencimiento.Value
            'FacturasCab.IdCliente = Me.txtCodigoCliente.Text
            'FacturasCab.Contado = Me.rdContado.Checked
            'FacturasCab.Credito = Me.rdCredito.Checked
            'FacturasCab.Contabilizado = "N"
            'FacturasCab.IdPoliza = 0
            'FacturasCab.FechaContabilizacion = Now
            'FacturasCab.IVA = Me.txtIVA.Text
            'FacturasCab.SubTotal = Me.txtSubTotal.Text
            'FacturasCab.Total = Me.txtTotal.Text
            FacturasCab.Estatus = "C"
            'FacturasCab.Observaciones = Me.txtObservaciones.Text
            'FacturasCab.IdClienteCargo = 0
            'FacturasCab.Func = "M"
            'FacturasCab.NumOpc = 3
            FacturasCab.FechaCancelacion = DateTime.Now
            FacturasCab.IdUsuarioCancela = Controlador.Sesion.MiUsuario.Usrndx
            'FacturasCab.TipoFactura = 0

            If Not FacturasCab.Guardar(Trans) Then
                MessageBox.Show("Cabecero Factura", "", MessageBoxButtons.OK)
                Trans.Rollback()
                Return False
            End If

            Trans.Add(Notas)
            Notas.GetMulti(HC.NotaVentaFields.SerieFact = txtSerie.Text And HC.NotaVentaFields.FolioFact = Me.txtFolioFactura.Text)

            For Each Nt As EC.NotaVentaEntity In Notas
                Nt.SerieFact = ""
                Nt.FolioFact = ""
            Next
            Notas.SaveMulti()

            'For Each Item As ListViewItem In lvNotasVenta.Items
            '    Dim Embarques As New CC.MfacEmbarquesCabCollection

            '    Trans.Add(Embarques)
            '    Embarques.GetMulti(HC.MfacEmbarquesCabFields.IdFolioEmbarque = Item.Text)

            '    For Each emb As EC.MfacEmbarquesCabEntity In Embarques
            '        emb.Estatus = "V"
            '    Next
            '    Embarques.SaveMulti()
            'Next

            ''datos para la modificacion del embarque se esta facturando
            'EmbarqueCab.FolioEmbarque = Me.txtFolioEmbarque.Text
            'EmbarqueCab.IdCliente = Me.txtCodigoCliente.Text
            'EmbarqueCab.NoFactura = ""
            'EmbarqueCab.Estatus = EstatusCharX.VIGENTE
            'EmbarqueCab.Func = "M"
            'EmbarqueCab.NumOpc = 3
            'If Not EmbarqueCab.Guardar(Trans) Then
            '    MessageBox.Show("Cabecero Embarques", "", MessageBoxButtons.OK)
            '    Trans.Rollback()
            '    Return False
            'End If
            'datos para poner de referencia la poliza que se cancela

            'datos para el cabecero de poliza 
            'PolizaCab.Concepto = "Póliza de cancelación de venta de cortes,productos con factura " & Me.txtFolioFactura.Text & " del cliente " & Me.txtCodigoCliente.Text
            'PolizaCab.EmpresaId = Controlador.Sesion.MiEmpresa.Empndx
            'PolizaCab.Estatus = PolizaEstatusEnum.ACTIVA
            'PolizaCab.FechaCaptura = Now
            'PolizaCab.FechaPoliza = Now
            'PolizaCab.Importe = Me.txtTotal.Text
            'PolizaCab.Mes = Month(Now)
            'PolizaCab.Origen = PolizaOrigenEnum.VENTAS
            'PolizaCab.TipoCambio = 1
            'PolizaCab.TipoError = ErroresPolizaEnum.NINGUNO
            'PolizaCab.TipoPoliza = PolizaTipoPolizaEnum.CANCELACION

            'Dim PolizasDetalle As New CC.PolizaDetalleCollection
            'Dim PolizaDet As New PolizaDetalleClass

            'PolizasDetalle.GetMulti(HC.PolizaDetalleFields.PolizaId = FacturasCab.IdPoliza)

            'For Each PolizaDetalle As EC.PolizaDetalleEntity In PolizasDetalle
            '    PolizaDet.IdCuentaContable = PolizaDetalle.CuentaContableId
            '    PolizaDet.Importe = PolizaDetalle.Importe
            '    PolizaDet.Operacion = CType(IIf(PolizaDetalle.OperacionCa = "C", PolizaOperacionEnum.ABONO, PolizaOperacionEnum.CARGO), PolizaOperacionEnum)
            '    PolizaDet.Posicion = PolizaDetalle.Posicion
            '    PolizaCab.Detalles2.Add(PolizaDet)
            'Next

            'If PolizaCab.Detalles2.Count = 0 Then
            '    PolizaCab.TipoError = ClasesNegocio.ErroresPolizaEnum.NO_SE_ENCONTRO_EL_DETALLE_DE_LA_POLIZA
            'End If

            'If Not PolizaCab.Guardar2(Trans) Then
            '    Trans.Rollback()
            '    MessageBox.Show("La Póliza no ha sido grabada ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Return False
            'End If
            TransG.Commit()
            Trans.Commit()

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Trans.Rollback()
            If TransG IsNot Nothing Then
                TransG.Rollback()
            End If
            Return False
        End Try
    End Function

#End Region

#Region "Eventos"

    Private Sub txtFolioFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolioFactura.KeyPress, txtUUID.KeyPress, txtCodigoCliente.KeyPress, CmbCliente.KeyPress, dtpFechaVencimiento.KeyPress, dtFechaFactura.KeyPress, txtRFC.KeyPress, txtObservaciones.KeyPress, rdCredito.KeyPress, rdContado.KeyPress, dgvDetalleConcentrado.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            SendKeys.Send(Chr(Keys.Tab))
        End If
    End Sub

    Private Sub MFacRegFacturasVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Ccom.Utilerias.ObtenerCodSucursal = 0 Then
                Me.Close()
                Me.Dispose()
            End If


            'AddHandler pdDocumento.PrintPage, AddressOf Imprime_Documento

            Dim Relacion As New OC.RelationCollection

            Relacion.Add(EC.CfgCtrlCtasEntity.Relations.ConCfgCtasEntityUsingIdConCfgCtas)
            'Me.CuentaControl.GetMulti(HC.ConCfgCtasFields.Concepto = "VENTA DE PRODUCTOS", 0, Nothing, Relacion)

            Me.dgvDetalle.AutoGenerateColumns = False

            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            Sucursal = New SucursalClass(liCodSucursal)
            txtSerie.Text = Sucursal.SerieFactura.StaLetraSerie.Trim
            dgvDetalleConcentrado.AutoGenerateColumns = False

            ClientesCol = New CC.MfacCatClientesCollection
            Dim Filtro As New OC.PredicateExpression
            Dim Orden As New OC.SortExpression(New OC.SortClause(HC.MfacCatClientesFields.Nombre, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
            Filtro.Add(HC.MfacCatClientesFields.Estatus = ClasesNegocio.CondicionEstatusEnum.ACTIVO)
            ClientesCol.GetMulti(Filtro, 0, Orden)

            CambDir = True
            Me.CmbCliente.DisplayMember = "Nombre"
            Me.CmbCliente.ValueMember = "IdCliente"
            Me.CmbCliente.DataSource = ClientesCol
            CambDir = False

            MtbEstados.StateBuscar = "101001011"
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
        Dim Vigentes As Boolean = False
        Me.Estado = FormState.Borrar
        Cancelar = True
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        For Each Pago As PagosDeClientesClass In FacturasCab.Pagos
            If Pago.Estatus = EstatusChar.VIGENTE Then
                Vigentes = True
                Exit For
            End If
        Next
        If lblEstatus.Text = "cancelada".ToUpper Then
            MessageBox.Show("La Factura ya se encuentra cancelada.", "Aviso", MessageBoxButtons.OK)
            Cancelar = True
            Return
        End If

        If Vigentes Then
            MessageBox.Show("La Factura tiene pagos vigentes, no es posible cancelarla", "Aviso", MessageBoxButtons.OK)
        ElseIf MessageBox.Show("¿Esta seguro de cancelar esta factura?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If Cancelacion() Then
                Cancelar = False
                Windows.Forms.Cursor.Current = Cursors.Default
                MessageBox.Show("Se Canceló Factura " & Me.txtSerie.Text + "-" + Me.txtFolioFactura.Text, "Aviso", MessageBoxButtons.OK)
                Me.Limpiar()
                Deshabilitar()
                Me.MEAToolBar1.sbCambiarEstadoBotones("Cancelar")
            Else
                Windows.Forms.Cursor.Current = Cursors.Default
            End If
        End If
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Me.Estado = FormState.Buscar
        Cancelar = Not Buscar()
        Deshabilitar()

        If Not Cancelar Then
            cmbDomiciliosFiscales.Enabled = True
        End If
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickCancelar
        Me.Estado = FormState.Cancelar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickEditar
        If FacturasCab.Estatus = "V" Then
            Estado = FormState.Editar
            'txtFolioFactura.Enabled = True

            If IsNumeric(FacturasCab.NoFactura) Then
                txtFolioFactura.Text = FacturasCab.NoFactura
            Else
                txtFolioFactura.Text = FacturasCab.NoFactura.Substring(2)
            End If
            cmbDomiciliosFiscales.Enabled = False

        Else
            MessageBox.Show("No se puede modificar el folio de una factura abonada, pagada o cancelada", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Cancelar = True
        End If
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "TransFact")
        Dim Folio As String = ""
        Dim Serie As String


        Me.Cursor = Cursors.WaitCursor
        Try
            'If Me.txtFolioFactura.Text = "" Then
            '    MsgBox("Debe ingresar el Folio de la Factura", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            '    Cancelar = True
            '    Exit Sub
            'End If

            'If CuentaControl.Count > 0 Then
            '    For Each Cuenta As EC.CfgCtrlCtasEntity In CuentaControl
            '        If Not Cuenta.CuentaContable.BooAfectable Then
            '            MsgBox("La cuenta contable de venta de productos debe ser afectable, verifique la configuracion de cuentas de control", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            '            Cancelar = True
            '            Exit Sub
            '        End If
            '    Next

            '    If Cliente.CuentaContable.Afectable = SiNoEnum.NO Then
            '        MsgBox("La cuenta contable del cliente debe ser afectable", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            '        Cancelar = True
            '        Exit Sub
            '    End If
            'Else
            '    MsgBox("No se han establecido las cuentas contables en la configuracion de cuentas de control", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            '    Cancelar = True
            '    Exit Sub
            'End If

            If Estado = FormState.Nuevo Then
                If Me.cmbDomiciliosFiscales.SelectedItem Is Nothing Then
                    MsgBox("Debe seleccionar el domicilio fiscal", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                    Cancelar = True
                    Exit Sub
                Else
                    If dgvDetalleConcentrado.RowCount <= 0 Then
                        MsgBox("Debe de añadir notas de venta.", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                        Cancelar = True
                        Exit Sub
                    Else
                        Dim Fact As New CC.FacturasClientesCabCollection()
                        ''  MessageBox.Show(liCodSucursal.ToString())
                        Controlador.Configuracion.ActualizarFacturaFolios(1)
                        Application.DoEvents()
                        Folio = (Controlador.Configuracion.FacturaFolios.GenerarFolio(Trans)).Trim
                        Fact.GetMulti(HC.FacturasClientesCabFields.NoFactura = Folio Or HC.FacturasClientesCabFields.NoFactura = String.Format("C-{0}", Folio))

                        If Fact.Count > 0 Then
                            Cancelar = True
                            Throw New Exception("Ya existe una factura con ese folio, por favor configure correctamente el foliador")
                        Else
                            Serie = Controlador.Configuracion.FacturaFolios.StaLetraSerie
                            txtFolioFactura.Text = Folio
                        End If
                    End If
                End If
                Trans.Commit()
                Application.DoEvents()
                Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "TransFactReal")
                If Guardar(Trans) Then
                    Trans.Commit()
                    MessageBox.Show("Se guardó factura " & Me.txtSerie.Text & "-" & Me.txtFolioFactura.Text + vbNewLine + "UUID: " + Me.txtUUID.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Limpiar()
                    Deshabilitar()
                    ' MEAToolBar1_ClickNuevo(MEAToolBar1, New ToolBarButtonClickEventArgs(MEAToolBar1.Buttons("tbbtnNuevo")), Cancelar)
                    'Me.MEAToolBar1.sbCambiarEstadoBotones("Cancelar")
                    Deshabilitar()
                    Cancelar = False

                Else
                    Trans.Rollback()
                    MsgBox("La Factura no pudo ser Guardada", MsgBoxStyle.Critical, "Error")
                    Cancelar = True
                    'Limpiar()
                    'Deshabilitar()
                    'Me.MEAToolBar1.sbCambiarEstadoBotones("Cancelar")

                End If
            Else
                MsgBox("No se permite modificar una factura timbrada.", MsgBoxStyle.Critical, "Error")
                Limpiar()
                MEAToolBar1_ClickCancelar(New Object(), Nothing, False)
            End If
        Catch ex As Exception
            Trans.Rollback()
            Cancelar = True
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al guardar." + vbnewline + ex.Message, MsgBoxStyle.Critical, "Error")
#End If
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir


        'Dim DomFiscalCte As DomicilioClienteClass
        'DomFiscalCte = DirectCast(cmbDomiciliosFiscales.SelectedItem, DomicilioClienteClass)
        'Cliente = New ClientesIntroductoresClass(DirectCast(CmbCliente.SelectedItem, EC.MfacCatClientesEntity))

        '----------------------------------------------------
        '   Inicia codigo agregado para generar el CFDI
        '----------------------------------------------------
        If Buscarr = True Then
            Try
                Dim ControlFD As Integralab.FactDigital.ControladorFactDigital
                Dim ConStr As String
                If File.Exists(Application.StartupPath + "\\cx.dat") Then
                    ConStr = Integralab.FactDigital.ControladorFactDigital.Decrypt(File.ReadAllText(Application.StartupPath + "\\cx.dat"))
                Else
                    Throw New Exception("No se ha configurado la conexión a la base de datos de la factura digital.")
                End If
                ControlFD = New IntegraLab.FactDigital.ControladorFactDigital(Controlador.Empresa.CodEmpndx, ConStr)

                ControlFD.GeneraCFDI_PDF(FacturasCab.UUID, True)

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            

        End If

        
        'Me.Estado = FormState.Imprimir
        'Dim conRFC As Boolean = True

        'If Me.cmbDomiciliosFiscales.SelectedIndex = -1 Then
        '    MsgBox("Debe seleccionar el domicilio fiscal", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
        '    Cancelar = True
        '    Exit Sub
        'End If

        'If Controlador.Configuracion.Venta.Count > 1 Then
        '    'Dim seleccionarCOnfiguracion As New frmSeleccionConfiguracionFactura

        '    'If seleccionarCOnfiguracion.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    '    Controlador.Configuracion.SeleccionarConfiguracionFactura(seleccionarCOnfiguracion.ConfiguracionSeleccionada.IdConfiguracion)
        '    'Else
        '    '    MsgBox("Debe seleccionar una configuración", MsgBoxStyle.Exclamation, "Seleccione una Configuración")
        '    '    Exit Sub
        '    'End If
        'ElseIf Controlador.Configuracion.Venta.Count = 1 Then
        '    Controlador.Configuracion.SeleccionarConfiguracionFactura(Controlador.Configuracion.Venta(0).IdConfiguracion)
        'Else
        '    MessageBox.Show("Debe registrar previamente una configuracion de factura", Controlador.Sesion.MiEmpresa.Empnom)
        '    Exit Sub
        'End If

        ''buscar el numero de renglones por factura para dividir los embarques que se facturaran en mas
        ''de una factura                 

        'If MessageBox.Show("¿Desea imprimirlo con RFC?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
        '    conRFC = False
        'End If

        'Me.Imprimir(CType(cmbDomiciliosFiscales.SelectedItem, DomicilioClienteClass), conRFC)
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Me.Estado = FormState.Limpiar
        Me.Limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickNuevo
        Me.Estado = FormState.Nuevo
        Me.Limpiar()
        Habilitar()
        Me.GroupBox1.Enabled = True
        Me.rdContado.Checked = True

        'If MostrarEmbarques() Then
        'txtFolioNota.Focus()
        'txtFolioFactura.Text = Controlador.Configuracion.FacturaFolios.MostrarFolio
        'Else
        '   MEAToolBar1_ClickCancelar(sender, New ToolBarButtonClickEventArgs(MEAToolBar1.Buttons("tbbtnCancelar")), Cancelar)
        '   Cancelar = True
        'End If
    End Sub

    'Private Sub dgvDetalleConcentrado_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleConcentrado.CellEndEdit
    '    Try
    '        If Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.KilosFacturados.Index).Value IsNot Nothing Then
    '            Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.KilosFacturados.Index).Value = CType(Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.KilosFacturados.Index).Value, Decimal)

    '            If Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.Precios.Index).Value IsNot Nothing Then
    '                Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.Precios.Index).Value = CType(Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.Precios.Index).Value, Decimal)
    '                Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.ImporteFacturado.Index).Value = Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.KilosFacturados.Index).Value * Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.Precios.Index).Value
    '                Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.ImporteEmbarcado.Index).Value = Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.KilosEmbarcados.Index).Value * Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.Precios.Index).Value
    '            End If
    '        Else
    '            Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.ImporteFacturado.Index).Value = Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.KilosFacturados.Index).Value * Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.Precios.Index).Value
    '            Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.ImporteEmbarcado.Index).Value = Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.KilosEmbarcados.Index).Value * Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.Precios.Index).Value
    '        End If

    '        PasarDatosAGridDetalle()

    '        Dim SubTotal As Decimal = 0D, Total As Decimal = 0D, Kilos As Decimal = 0D, Piezas As Integer = 0

    '        For i As Integer = 0 To Me.dgvDetalleConcentrado.Rows.Count - 1
    '            Total += Me.dgvDetalleConcentrado.Rows(i).Cells("ImporteFacturado").Value
    '            SubTotal += Me.dgvDetalleConcentrado.Rows(i).Cells("ImporteFacturado").Value
    '            Piezas += Me.dgvDetalleConcentrado.Rows(i).Cells(clmPiezas.Index).Value

    '            If Me.dgvDetalleConcentrado.Rows(i).Cells(KilosFacturados.Index).Value IsNot Nothing Then
    '                Kilos += Me.dgvDetalleConcentrado.Rows(i).Cells(KilosFacturados.Index).Value
    '            End If

    '            Me.txtTotal.Text = Total.ToString("C2")
    '            Me.txtSubTotal.Text = SubTotal.ToString("C2")
    '        Next
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Me.Estado = FormState.Salir
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Close()
    End Sub

    Private Sub ultcmbDomiciliosFiscales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Me.Estado = FormState.Nuevo Or Me.Estado = FormState.Buscar Then
            If e.KeyCode = Keys.F12 And Cliente IsNot Nothing Then
                Cliente.ActualizarDomiciliosFiscales()
                Me.cmbDomiciliosFiscales.DataSource = Cliente.DomiciliosFiscales

                'Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("IdCliente").Hidden = True
                'Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("IdRenglon").Hidden = True
                'Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("IdPoblacion").Hidden = True
                'Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Entidad").Hidden = True
                'Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Contenedor").Hidden = True
                'Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("EsPrincipal").Hidden = True
                'Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("IndiceEnContenedor").Hidden = True
                'Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Seleccionado").Hidden = True
                'Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Cliente").Hidden = True
                'Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("Transaction").Hidden = True
                'Me.ultcmbDomiciliosFiscales.Rows.Band.Columns("ParticipatesInTransaction").Hidden = True

                If Cliente.DomiciliosFiscales.Count = 1 Then
                    cmbDomiciliosFiscales.SelectedIndex = 0
                End If
            End If
        End If
    End Sub

    Private Sub dtFechaFactura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtFechaFactura.ValueChanged
        If IsNumeric(Me.txtDiasCredito.Text.Trim) Then
            dtpFechaVencimiento.Value = Me.dtFechaFactura.Value.AddDays(CInt(Me.txtDiasCredito.Text))
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Controlador.Configuracion.ActualizarFacturaFolios(liCodSucursal)
        'txtFolioFactura.Text = Controlador.Configuracion.FacturaFolios.MostrarFolio
        
        If txtFolioNota.Text.Trim = "" Then Exit Sub
        For Each item As ListViewItem In Me.lvNotasVenta.Items
            If item.Text.Equals(txtFolioNota.Text.Trim()) Then
                MessageBox.Show("La nota " & item.Text & " que trata de agregar ya se encuentra en la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtFolioNota.Text = ""
                txtFolioNota.Focus()
                Exit Sub
            End If
        Next
        Dim notas As New CC.NotaVentaCollection
        Dim notasr As New CC.NotaVentaRespCollection
        Dim Filtro As New OC.PredicateExpression()
        Try
            Filtro.Add(HC.NotaVentaFields.Codigo = CInt(Me.txtFolioNota.Text.Trim) And HC.NotaVentaFields.Mod = False)
            'Filtro.AddWithAnd(HC.NotaVentaFields.FolioFact = "")
            notas.GetMulti(Filtro)

            If notas.Count > 0 Then
                If notas(0).Estatus = 0 Then
                    MessageBox.Show("La nota que trata de agregar se encuentra cancelada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtFolioNota.Text = ""
                    txtFolioNota.Focus()
                    Return
                End If

                If notas(0).FolioFact = "" Then
                    Dim nota As New EC.NotaVentaEntity()
                    nota = notas(0)
                    ListaNotas.Add(nota)
                    Me.lvNotasVenta.Items.Add(nota.Codigo.ToString)
                    Me.txtFolioNota.Text = ""

                    If DetalleNotaVenta Is Nothing Then DetalleNotaVenta = New NotaVentaDetalleCollectionClass()
                    For Each prod As EC.NotaVentaDetalleEntity In nota.Detalle
                        DetalleNotaVenta.Add(New NotaVentaDetalleClass(prod))
                        Dim band As Boolean = False
                        Dim k As Integer
                        For k = 0 To Me.dgvDetalleConcentrado.Rows.Count - 1
                            If Me.dgvDetalleConcentrado.Rows(k).Cells("clmCodigo").Value = prod.Producto And _
                                        Me.dgvDetalleConcentrado.Rows(k).Cells("clmPrecioUnit").Value = prod.Precio Then
                                band = True
                                Exit For
                            End If
                        Next
                        If Not band Then
                            dgvDetalleConcentrado.Rows.Add()
                            Me.dgvDetalleConcentrado.Rows(k).Cells("clmCodigo").Value = prod.Producto
                            Me.dgvDetalleConcentrado.Rows(k).Cells("clmPrecioUnit").Value = prod.Precio
                            Me.dgvDetalleConcentrado.Rows(k).Cells("clmDescripcion").Value = prod.Producto_.Descripcion
                            Me.dgvDetalleConcentrado.Rows(k).Cells("clmUniMed").Value = prod.Producto_.UnidadMedida.DescripcionCorta
                            Me.dgvDetalleConcentrado.Rows(k).Cells("clmPorcIEPS").Value += prod.Producto_.PorcIeps
                        End If
                        Me.dgvDetalleConcentrado.Rows(k).Cells(clmNotaVenta.Index).Value = prod.NotaVenta
                        Me.dgvDetalleConcentrado.Rows(k).Cells("clmCantidad").Value += prod.Cantidad
                        Me.dgvDetalleConcentrado.Rows(k).Cells("clmImporte").Value += prod.Precio * prod.Cantidad
                        Me.dgvDetalleConcentrado.Rows(k).Cells("clmIVA").Value += prod.Iva
                        Me.dgvDetalleConcentrado.Rows(k).Cells("clmIEPS").Value += prod.Ieps
                        Me.dgvDetalleConcentrado.Rows(k).Cells("clmTotal").Value += prod.Importe

                    Next

                    liSubTotal += nota.SubTotal
                    txtSubTotal.Text = Format(liSubTotal, "N2")
                    liIva += nota.Iva
                    txtIVA.Text = Format(liIva, "N2")
                    liIeps += nota.Ieps
                    txtIEPS.Text = Format(liIeps, "N2")
                    liTotal += nota.Total
                    txtTotal.Text = Format(liTotal, "N2")

                    dgvDetalleConcentrado.Refresh()
                Else
                    MessageBox.Show("La nota de venta ya fue facturada.", "Aviso", MessageBoxButtons.OK)
                    Return
                End If
            Else
                Filtro = New OC.PredicateExpression
                Filtro.Add(HC.NotaVentaRespFields.Codigo = CInt(Me.txtFolioNota.Text.Trim))
                'Filtro.AddWithAnd(HC.NotaVentaFields.FolioFact = "")
                notasr.GetMulti(Filtro)
                If notasr.Count > 0 Then



                    If notasr(0).FolioFact = "" Then
                        Dim nota As New EC.NotaVentaRespEntity()
                        nota = notasr(0)
                        ListaNotasR.Add(nota)
                        Me.lvNotasVenta.Items.Add(nota.Codigo.ToString)
                        Me.txtFolioNota.Text = ""

                        If DetalleNotaVenta Is Nothing Then DetalleNotaVenta = New NotaVentaDetalleCollectionClass()
                        For Each prod As EC.NotaVentaDetalleRespEntity In nota.MventaNotaVentaDetalleResp
                            DetalleNotaVentaResp.Add(prod)
                            Dim producto As New ClasesNegocio.ProductoGeneralClass(prod.Producto)
                            'Dim UnidadMedida As New ClasesNegocio.UnidadesMedidaClass(producto.un)
                            Dim band As Boolean = False
                            Dim k As Integer
                            For k = 0 To Me.dgvDetalleConcentrado.Rows.Count - 1
                                If Me.dgvDetalleConcentrado.Rows(k).Cells("clmCodigo").Value = prod.Producto And _
                                            Me.dgvDetalleConcentrado.Rows(k).Cells("clmPrecioUnit").Value = prod.Precio Then
                                    band = True
                                    Exit For
                                End If
                            Next
                            If Not band Then
                                dgvDetalleConcentrado.Rows.Add()
                                Me.dgvDetalleConcentrado.Rows(k).Cells("clmCodigo").Value = prod.Producto
                                Me.dgvDetalleConcentrado.Rows(k).Cells("clmPrecioUnit").Value = prod.Precio
                                Me.dgvDetalleConcentrado.Rows(k).Cells("clmDescripcion").Value = producto.Descripcion
                                Me.dgvDetalleConcentrado.Rows(k).Cells("clmUniMed").Value = producto.UnidadMedida.DescCorta
                                Me.dgvDetalleConcentrado.Rows(k).Cells("clmPorcIEPS").Value += producto.PorcIEPS
                            End If
                            Me.dgvDetalleConcentrado.Rows(k).Cells(clmNotaVenta.Index).Value = prod.NotaVenta
                            Me.dgvDetalleConcentrado.Rows(k).Cells("clmCantidad").Value += prod.Cantidad
                            Me.dgvDetalleConcentrado.Rows(k).Cells("clmImporte").Value += prod.Precio * prod.Cantidad
                            Me.dgvDetalleConcentrado.Rows(k).Cells("clmIVA").Value += prod.Iva
                            Me.dgvDetalleConcentrado.Rows(k).Cells("clmIEPS").Value += prod.Ieps
                            Me.dgvDetalleConcentrado.Rows(k).Cells("clmTotal").Value += prod.Importe

                        Next

                        liSubTotal += nota.SubTotal
                        txtSubTotal.Text = Format(liSubTotal, "N2")
                        liIva += nota.Iva
                        txtIVA.Text = Format(liIva, "N2")
                        liIeps += nota.Ieps
                        txtIEPS.Text = Format(liIeps, "N2")
                        liTotal += nota.Total
                        txtTotal.Text = Format(liTotal, "N2")

                        dgvDetalleConcentrado.Refresh()
                    Else
                        MessageBox.Show("La nota de venta ya fue facturada.", "Aviso", MessageBoxButtons.OK)
                        Return
                    End If
                Else
                    MessageBox.Show("No existe una nota de venta con ese folio.", "Aviso", MessageBoxButtons.OK)
                    Return
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
        txtFolioNota.Focus()
    End Sub

    'Private Sub txtFolioFactura_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFolioFactura.Validating
    '    If txtFolioFactura.Enabled Then
    '        Dim Fact As New CC.FacturasClientesCabCollection()

    '        If txtFolioFactura.Text.Trim <> "" Then
    '            Fact.GetMulti(HC.FacturasClientesCabFields.NoFactura = (Controlador.Configuracion.SeleccionActualConfiguracionFactura.Serie.Trim & "-" & Me.txtFolioFactura.Text.Trim).Trim)

    '            If Fact.Count > 0 Then
    '                MessageBox.Show("Ya existe una factura con ese folio, por favor especifique uno distinto", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                e.Cancel = True
    '            End If
    '        Else
    '            MsgBox("Debe ingresar el Folio de la Factura", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
    '            e.Cancel = True
    '        End If
    '    End If
    'End Sub

#End Region

    Private Sub CmbCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCliente.SelectedIndexChanged
        Try
            If CmbCliente.SelectedIndex = -1 Then
                Me.txtCodigoCliente.Text = ""
                Me.txtRFC.Text = ""
                Me.txtDiasCredito.Text = ""
                Me.cmbDomiciliosFiscales.DataSource = Nothing
                Me.cmbDomiciliosFiscales.Text = ""
            Else
                If Not CambDir Then
                    Dim ClientesClas As New ClientesIntroductoresClass
                    Me.txtCodigoCliente.Text = Me.CmbCliente.SelectedValue
                    ClientesClas.Obtener(CInt(Me.CmbCliente.SelectedValue))


                    cmbDomiciliosFiscales.DataSource = Nothing
                    Me.txtRFC.Text = ClientesClas.RFC
                    Me.txtDiasCredito.Text = ClientesClas.DiasCredito
                    Me.cmbDomiciliosFiscales.DisplayMember = "Domicilio"
                    Me.cmbDomiciliosFiscales.SelectedValue = "IdRenglon "
                    Me.cmbDomiciliosFiscales.DataSource = ClientesClas.DomiciliosFiscales
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub frmFacturasNotas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        Dim forma As New frmMetodoPagoEmergente
        Dim reult As DialogResult = forma.ShowDialog
        MessageBox.Show(reult.ToString())
        If reult = Windows.Forms.DialogResult.OK Then
            MessageBox.Show("Aceptó")
        Else
            MessageBox.Show("CAncelo")
        End If

    End Sub
End Class