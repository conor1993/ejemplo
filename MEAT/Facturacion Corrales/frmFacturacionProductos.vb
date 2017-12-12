Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports System.Data.SqlClient
Imports Integralab
Imports ClasesNegocio
Imports System.IO

Public Class frmFacturacionProductos

#Region "Miembros"
    Dim SalidadeRecibaAVenta As CN.SalidaGanadoCabeceroClass
    Dim SalidadeRecibaAVentadetalle As CN.SalidaGanadoDetalleClass
    Dim FacturaCabecero As CN.FacturasClass
    Dim ClientesCol As CN.ClientesIntroductoresColeccion
    Dim CodAlmacen As Integer ' variable para el codigo de almacen
    Dim ConF As New CC.ConfiguracionFacturaCollection
    Dim NumRenglones As Integer
    Dim configurarImprecion As Boolean = True
    Dim FacturasCab As New FacturasClientesCabClass
    Dim FacturasDet As New FacurasClientesDetClass
    Dim Cliente As New ClientesIntroductoresClass
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
        Me.dgvDetalle.Rows.Clear()

        Me.lblEstatus.Visible = False
        Me.dtFechaFactura.Value = Now
        Me.dtpFechaVencimiento.Value = Now
        Me.txtFolioSalidaVenta.Text = ""
        Me.ultcmbDomiciliosFiscales.DataSource = Nothing
    End Function

    Public Function Guardar(ByVal Trans As HC.Transaction, ByVal Estatus As String) As Boolean
        Try
            If Estatus = "V" Then
                Dim Folio As New CN.FoliosClass 'variable para la clase de folio
                'Dim FacturasDetalleCol As New CN.FacturasDetalleCollectionClass ' para crear la coleccion de detalle
                'Dim FacturasDet As New EC.DetFacturasEntity 'para agregar al detalle
                'para crear el folio de la factura
                Folio.Codigo = CN.CodigodeFolios.FacturasVentasyCorrales
                Folio.A�o = 1
                Folio.Mes = 1

                If Not Folio.Guardar(Trans) Then
                    Trans.Rollback()
                    MessageBox.Show("Error al generar folio de Factura", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

                'asignar datos a la factura
                'asignar datos a cabecero de factura
                FacturaCabecero.NoFactura = "F" & Folio.Consecutivo.ToString("0000000")
                Me.txtFolioFactura.Text = FacturaCabecero.NoFactura
                FacturaCabecero.FechaFactura = Me.dtFechaFactura.Value
                FacturaCabecero.FechaVencimiento = Me.dtpFechaVencimiento.Value
                FacturaCabecero.SubTotal = CDec(Me.txtSubTotal.Text)
                FacturaCabecero.ImporteDescuento = CDec(Me.txtDescuento.Text)
                FacturaCabecero.Cliente = Me.CmbCliente.SelectedValue
                FacturaCabecero.ClaveUsuario = Controlador.Sesion.MiUsuario.Usrndx
                FacturaCabecero.DiasCredito = Me.txtDiasCredito.Text
                'FacturaCabecero.Referencia = 
                FacturaCabecero.Estatus = "V"
                FacturaCabecero.StaFacturacion = "N"
                'guardar cabecero
                Controlador.RealizarFacturasdeVenta(FacturaCabecero, Now, ClasesNegocio.TipoFacturaEnum.VENTA_DE_PRODUCTO, Trans)

                'agregar a la clase detalle de facturas
                For i As Integer = 0 To Me.dgvDetalle.RowCount - 1
                    Dim FacturasDetalle As New CN.FacturasDetalleClass
                    FacturasDetalle.IdProducto = Me.dgvDetalle.Rows(i).Cells(Me.clmCodigo.Index).Value
                    FacturasDetalle.PrecioUni = Me.dgvDetalle.Rows(i).Cells(Me.clmPrecioUnitario.Index).Value
                    FacturasDetalle.CostoUnitario = Me.dgvDetalle.Rows(i).Cells(Me.clmCostoUnitario.Index).Value
                    FacturasDetalle.Renglon = i
                    FacturasDetalle.Servicios = "N"
                    FacturasDetalle.TipoFactura = CN.TipoFacturaEnum.VENTA_DE_PRODUCTO
                    FacturasDetalle.Estatus = "V"
                    FacturasDetalle.CveAlmacen = Me.CodAlmacen
                    FacturasDetalle.CantidadxProducto = Me.dgvDetalle.Rows(i).Cells(Me.clmCantidad.Index).Value
                    'guardar el detalle
                    Controlador.RealizarFacturasdeVentaenDetalle(FacturasDetalle, Me.txtFolioFactura.Text, Trans)
                Next
                Trans.Commit()
                MessageBox.Show("La Factura de Producto se ha realizado satisfactoriamente con el folio: " & FacturaCabecero.FolFactura)
            Else
                FacturaCabecero.Estatus = "C"
                Controlador.RealizarFacturasdeVenta(FacturaCabecero, Now, ClasesNegocio.TipoFacturaEnum.VENTA_DE_PRODUCTO, Trans)
            End If
            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function


    Private Function Imprimir(ByVal DomicilioCliente As CN.DomicilioClienteClass, Optional ByVal conRFC As Boolean = True) As Boolean
        Try
            'Dim I As Integer
            'Fact = FacturasCab.Obtener(3, Me.txtFolioFactura.Text)
            Dim Imp As New CN.EscritorClass(80, 60)
            Dim Fact As New CN.FacturasCollectionClass
            Dim ClientesImp As New CN.ClientesIntroductoresClass
            Fact = Controlador.ObtenerFacturasDeVenta(Me.txtFolioFactura.Text)
            'Dim Fact1 As DataSet = FacturasCab.Obtener(4, Me.txtFolioFactura.Text)
            Dim Convertir As New CN.ConvertirNumeroALetraClass
            'If Fact.Tables(0).Rows.Count = 0 Then
            ' Fact = Fact1zw
            ' End If
            'Fact = FacturasCab.Obtener(Me.txtFolioFactura.Text, Me.txtCodigoCliente.Text)

            If Fact.Count = 0 Then
                Exit Function
            End If

            'cabecero de factura
            If ConF(0).Campo1X = 0 Or ConF(0).Campo1Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresi�n del nombre del cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If ConF(0).Campo2X = 0 Or ConF(0).Campo2Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresi�n del domicilio del cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If ConF(0).Campo3X = 0 Or ConF(0).Campo3Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresi�n de la ciudad del cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If ConF(0).Campo4X = 0 Or ConF(0).Campo4Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresi�n del estado del cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If ConF(0).Campo5X = 0 Or ConF(0).Campo5Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresi�n del RFC del cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If ConF(0).Campo6X = 0 Or ConF(0).Campo6Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresi�n del folio o numero de factura", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If ConF(0).Campo7X = 0 Or ConF(0).Campo7Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresi�n de la fecha de factura", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If ConF(0).Campo8X = 0 Or ConF(0).Campo8Y = 0 Or ConF(0).Campo9X = 0 Or ConF(0).Campo9Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresi�n de la cantidad y la descripcion del producto", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If ConF(0).Campo10X = 0 Or ConF(0).Campo10Y = 0 Or ConF(0).Campo11X = 0 Or ConF(0).Campo11Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresi�n del precio y el importe total del producto", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If ConF(0).Campo12X = 0 Or ConF(0).Campo12Y = 0 Or ConF(0).Campo13X = 0 Or ConF(0).Campo13Y = 0 Or ConF(0).Campo14X = 0 Or ConF(0).Campo14Y = 0 Or ConF(0).Campo15X = 0 Or ConF(0).Campo15Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresi�n del subtotal, iva, total e importe con letra de la factura", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            ClientesImp.Obtener(Fact.Item(0).Cliente)
            Dim cliente As String = ClientesImp.Nombre 'Fact.Tables(0).Rows(0)("Nombre").ToString.Replace("�", "N").Trim.Replace("�", "n")

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
            Dim domicilio As String = DomicilioCliente.Domicilio.Trim.Replace("�", "N").Replace("�", "n") & " COL. " & DomicilioCliente.Colonia.Trim

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


            For Each Detalle As CN.FacturasDetalleClass In Fact.Item(0).Detalles
                Dim prod As New CN.ProductoClass
                Imp.EscribeDer(CDec(Detalle.CantidadxProducto).ToString("N2"), ConF(0).Campo8X, ConF(0).Campo8X, renglon)
                prod.Obtener(Detalle.IdProducto)
                Imp.Escribe(prod.Descripcion.ToString.Trim.Replace("�", "N").Replace("�", "n"), ConF(0).Campo9X, renglon)
                Dim num As Decimal = CDec(Detalle.PrecioUni)
                Imp.EscribeDer(num.ToString("N2"), ConF(0).Campo10X, ConF(0).Campo10X, renglon)
                Imp.EscribeDer(CDec(Detalle.PrecioUni * Detalle.CantidadxProducto).ToString("N2"), ConF(0).Campo11X, ConF(0).Campo11X, renglon)
                renglon = renglon + 1
            Next

            'For i As Integer = 0 To Fact.Count - 1
            '    Fact.Item(0).Detalles
            '    Imp.EscribeDer(CDec(Fact.Tables(0).Rows(i)("KilosFacturados")).ToString("N2") & "Kgrs", ConF(0).Campo8X, ConF(0).Campo8X, renglon)
            '    Imp.Escribe(Fact.Tables(0).Rows(i)("Descripcion").ToString.Trim.Replace("�", "N").Replace("�", "n"), ConF(0).Campo9X, renglon)
            '    Dim num As Decimal = CDec(Fact.Tables(0).Rows(i)("PrecioxKgr"))
            '    Imp.EscribeDer(num.ToString("N2"), ConF(0).Campo10X, ConF(0).Campo10X, renglon)
            '    Imp.EscribeDer(CDec(Fact.Tables(0).Rows(i)("ImporteFacturado")).ToString("N2"), ConF(0).Campo11X, ConF(0).Campo11X, renglon)
            '    renglon = renglon + 1
            'Next

            'total de factura
            Imp.Escribe(CDec(Fact.Item(0).SubTotal).ToString("N2"), ConF(0).Campo12X, ConF(0).Campo12Y)
            Imp.Escribe(CDec(Fact.Item(0).ImporteIVA).ToString("N2"), ConF(0).Campo13X, ConF(0).Campo13Y)
            Imp.Escribe(CDec(Fact.Item(0).SubTotal).ToString("N2"), ConF(0).Campo14X, ConF(0).Campo14Y)

            Dim TotalLetra As String = ClasesNegocio.ConvertirNumeroALetraClass.Convertir(Fact.Item(0).SubTotal, CN.TipoMonedaEnum.Peso)

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

    Private Sub CargarSalidasdePRoductos()
        Try
            Dim Cabezas As Integer = 0, Kilos As Decimal = 0D, Importe As Decimal = 0D, ImporteVenta As Decimal = 0D
            Dim Consultas As New frmBusquedaMovimientoAlmacen
            Dim ListaSalidas As New List(Of String)
            Dim InvConfiguracion As New CC.InventarioConfiguracionCollection
            'variables para capturar el movimiento de salida por venta de productos.
            Dim AlmacenCab As New CN.AlmacenGeneral.MovimientoAlmacenClass
            Dim AlmacenDet As New CN.AlmacenGeneral.MovimientoAlmacenDetalleClass

            InvConfiguracion.GetMulti(Nothing, 0, Nothing)


            If InvConfiguracion.Item(0).SxVenta.Value > 0 Then
                Consultas.LlenarTiposMovimientoAlmacen(InvConfiguracion.Item(0).SxVenta)
            Else
                MessageBox.Show("Configura el movimiento de Salidas por Venta", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If




            If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then

                AlmacenCab = Consultas.MovimientoAlmacen ' CType(Consultas.dgMovimientosAlmacen.SelectedRows(0).DataBoundItem, CN.AlmacenGeneral.MovimientoAlmacenClass)
                Me.txtFolioSalidaVenta.Text = AlmacenCab.FolioMovimientoAlmacen
                Me.CodAlmacen = AlmacenCab.IdAlmacen
                Me.dgvDetalle.AutoGenerateColumns = False
                Me.dgvDetalle.Rows.Add(AlmacenCab.Detalle.Count)
                'Me.dgvDetalle.DataSource = AlmacenCab.Detalle
                Dim fila As Integer = 0

                For Each det As CN.AlmacenGeneral.MovimientoAlmacenDetalleClass In AlmacenCab.Detalle
                    With Me.dgvDetalle.Rows(fila)
                        .Cells(Me.clmCodigo.Index).Value = det.IdProducto
                        .Cells(Me.clmProducto.Index).Value = det.Producto.Descripcion
                        .Cells(Me.clmCantidad.Index).Value = det.Cantidad
                        .Cells(Me.clmCostoUnitario.Index).Value = det.Costo
                        .Cells(Me.clmCostoTotal.Index).Value = det.Improte
                    End With
                Next

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Eventos"

    Private Sub frmFacturacionProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Dim Cuentas As New Integralab.ORM.CollectionClasses.CfgCtrlCtasCollection

            'Me.Cuentas.GetMulti(HC.CfgCtrlCtasFields.Folio = "018" Or HC.CfgCtrlCtasFields.Folio = "037")

            llenarcombometododepago()
            llenarcomboformasdepago()

            Me.CmbCliente.DisplayMember = "Nombre"
            Me.CmbCliente.ValueMember = "Codigo"
            Me.CmbCliente.DataSource = ClientesCol

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
                MessageBox.Show("No se puede cancelar la factura: " & Me.txtFolioFactura.Text & " por que se encuentra pagada", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'verifica si la factura esta abonada
            If FacturaCabecero.Estatus = "A" Then
                Trans.Rollback()
                MessageBox.Show("No se puede cancelar la factura: " & Me.txtFolioFactura.Text & " por que se encuentra abonada", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'verifica si la factura esta cancelada
            If FacturaCabecero.Estatus = "C" Then
                Trans.Rollback()
                MessageBox.Show("No se puede cancelar la factura: " & Me.txtFolioFactura.Text & " por que se encuentra cancelada", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Guardar(Trans, "C")
            Trans.Commit()
            Me.Limpiar()
            MessageBox.Show("Se ha cancelado la Factura:" & Me.txtFolioFactura.Text, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Try
            Dim Consultas As New frmBusquedaFacturas
            Dim Clientes As New CN.ClientesIntroductoresClass
            Dim Productos As New CN.ProductoClass
            Dim ListaSalidas As New List(Of String)


            Consultas.TipoFactura = ClasesNegocio.TipoFacturaEnum.VENTA_DE_PRODUCTO
            If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then

                FacturaCabecero = CType(Consultas.dgvFacturasCabecero.SelectedRows(0).DataBoundItem, CN.FacturasClass)
                Me.txtFolioFactura.Text = FacturaCabecero.NoFactura
                'Me.txtFolioSalidaVenta.Text = FacturaCabecero.ReferenciaSalidas
                Me.dgvDetalle.AutoGenerateColumns = False

                'Me.dgvDetalle.DataSource = FacturaCabecero.Detalles
                Dim fila As Integer = 0
                For Each Det As CN.FacturasDetalleClass In FacturaCabecero.Detalles
                    'For fila As Integer = 0 To FacturaCabecero.Detalles.Count
                    Me.dgvDetalle.Rows.Add()
                    'Me.dgvDetalle.Rows(fila).Cells(Me.clmCodigo.Index).Value = FacturaCabecero.Detalles.Item(fila).IdProducto
                    With Me.dgvDetalle.Rows(fila)
                        .Cells(Me.clmCodigo.Index).Value = Det.IdProducto
                        'obtener la descripcion del producto
                        Productos.Obtener(Det.IdProducto)
                        .Cells(Me.clmProducto.Index).Value = Productos.Descripcion
                        .Cells(Me.clmCantidad.Index).Value = Det.Cantidad
                        .Cells(Me.clmPrecioUnitario.Index).Value = Det.PrecioUnitario
                        .Cells(Me.clmImporte.Index).Value = (Det.PrecioUnitario * Det.Cantidad)
                    End With
                Next

                Clientes.Obtener(FacturaCabecero.CveCliente)
                Me.txtCodigoCliente.Text = FacturaCabecero.CveCliente
                Me.CmbCliente.Text = Clientes.Nombre
                Me.lblEstatus.Visible = True
                If FacturaCabecero.Estatus = "A" Then
                    Me.lblEstatus.Text = "ABONADA"
                End If
                If FacturaCabecero.Estatus = "C" Then
                    Me.lblEstatus.Text = "CANCELADA"
                End If
                If FacturaCabecero.Estatus = "P" Then
                    Me.lblEstatus.Text = "PAGADA"
                End If
                If FacturaCabecero.Estatus = "V" Then
                    Me.lblEstatus.Text = "VIGENTE"
                End If

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
            End If

        Catch ex As Exception
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
            Guardar(Trans, "V")
            Trans.Commit()
            Me.Limpiar()
            Me.Deshabilitar()
            'MessageBox.Show("Se ha cancelado la Factura:" & Me.txtFolioFactura.Text, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir
        Try
            Dim conRFC As Boolean = True

            If Me.ultcmbDomiciliosFiscales.SelectedRow Is Nothing Then
                MsgBox("Debe seleccionar el domicilio fiscal", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                Cancelar = True
                Exit Sub
            End If

            If Me.configurarImprecion Then
                Dim seleccionarCOnfiguracion As New frmSeleccionConfiguracionFactura

                If seleccionarCOnfiguracion.ShowDialog = Windows.Forms.DialogResult.OK Then
                    ConF.Add(seleccionarCOnfiguracion.ConfiguracionSeleccionada.Entidad)
                Else
                    MsgBox("Debe seleccionar una configuraci�n", MsgBoxStyle.Exclamation, "Seleccione una Configuraci�n")
                    Exit Sub
                End If
            End If

            'buscar el numero de renglones por factura para dividir las facturas en mas
            'de una factura                 
            NumRenglones = ConF(0).RenglonesEnDetalle

            If MessageBox.Show("�Desea imprimirlo con RFC?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                conRFC = False
            End If

            Me.Imprimir(CType(ultcmbDomiciliosFiscales.SelectedRow.ListObject, CN.DomicilioClienteClass), conRFC)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Me.Limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickNuevo
        Me.Limpiar()
        FacturaCabecero = New CN.FacturasClass
        Me.CargarSalidasdePRoductos()
        Habilitar()
        Me.GroupBox1.Enabled = True
        Me.rdContado.Checked = True
        'FacturasDetalle = New CN.FacturasDetalleClass
        'Me.dgvDetalle.DataSource = FacturaCabecero.Detalles
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub

    'Private Sub cmdSalidas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalidas.Click
    '    Try
    '        Dim Cabezas As Integer = 0, Kilos As Decimal = 0D, Importe As Decimal = 0D, ImporteVenta As Decimal = 0D
    '        Dim Consultas As New frmBusquedaMovimientoAlmacen
    '        Dim ListaSalidas As New List(Of String)
    '        Dim InvConfiguracion As New CC.InventarioConfiguracionCollection
    '        'variables para capturar el movimiento de salida por venta de productos.
    '        Dim AlmacenCab As New CN.AlmacenGeneral.MovimientoAlmacenClass
    '        Dim AlmacenDet As New CN.AlmacenGeneral.MovimientoAlmacenDetalleClass

    '        InvConfiguracion.GetMulti(Nothing, 0, Nothing)
    '        If InvConfiguracion.Item(0).SxVenta.Value > 0 Then
    '            Consultas.LlenarTiposMovimientoAlmacen(InvConfiguracion.Item(0).SxVenta)
    '        Else
    '            MessageBox.Show("Configura el movimiento de Salidas por Venta", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Exit Sub
    '        End If


    '        If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then

    '            AlmacenCab = Consultas.MovimientoAlmacen ' CType(Consultas.dgMovimientosAlmacen.SelectedRows(0).DataBoundItem, CN.AlmacenGeneral.MovimientoAlmacenClass)
    '            Me.txtFolioSalidaVenta.Text = AlmacenCab.FolioMovimientoAlmacen
    '            Me.CodAlmacen = AlmacenCab.IdAlmacen
    '            Me.dgvDetalle.AutoGenerateColumns = False
    '            Me.dgvDetalle.Rows.Add(AlmacenCab.Detalle.Count)
    '            'Me.dgvDetalle.DataSource = AlmacenCab.Detalle
    '            Dim fila As Integer = 0

    '            For Each det As CN.AlmacenGeneral.MovimientoAlmacenDetalleClass In AlmacenCab.Detalle
    '                With Me.dgvDetalle.Rows(fila)
    '                    .Cells(Me.clmCodigo.Index).Value = det.IdProducto
    '                    .Cells(Me.clmProducto.Index).Value = det.Producto.Descripcion
    '                    .Cells(Me.clmCantidad.Index).Value = det.Cantidad
    '                    .Cells(Me.clmCostoUnitario.Index).Value = det.Costo
    '                    .Cells(Me.clmCostoTotal.Index).Value = det.Improte
    '                End With
    '            Next

    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub


    Private Sub CmbCliente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCliente.SelectedIndexChanged
        Try
            Dim ClientesClas As New CN.ClientesIntroductoresClass
            Me.txtCodigoCliente.Text = Me.CmbCliente.SelectedValue
            ClientesClas.Obtener(Me.CmbCliente.SelectedValue)
            Me.txtRFC.Text = ClientesClas.RFC
            Me.txtDiasCredito.Text = ClientesClas.DiasCredito
            Me.txtDireccion.Text = ClientesClas.Domicilio
            Me.ultcmbDomiciliosFiscales.DataSource = ClientesClas.DomiciliosFiscales


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Aviso")
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
            Select Case e.ColumnIndex
                Case 3
                    Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmImporte.Index).Value = Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmPrecioUnitario.Index).Value * Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDescuento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescuento.TextChanged
        If Me.txtDescuento.Text <> "0" Then
            Me.txtTotal.Text = CDbl(Me.txtSubTotal.Text) - CDbl(Me.txtDescuento.Text)
        End If
    End Sub

    Private Sub llenarcombometododepago()
        Try
            Dim FormasPago As DataSet = New DataSet
            Dim queryString As String = "select * from catformaspagosat"
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(queryString, HC.DbUtils.ActualConnectionString)
            adapter.Fill(FormasPago)
            cmbformadepago.DataSource = FormasPago.Tables(0)
            cmbformadepago.DisplayMember = "concepto"
            cmbformadepago.ValueMember = "clave"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub llenarcomboformasdepago()
        Try
            Dim FormasPago As DataSet = New DataSet
            Dim queryString As String = "SELECT * FROM catmetodospagosat"
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(queryString, HC.DbUtils.ActualConnectionString)
            adapter.Fill(FormasPago)
            cmbmetododepago.DataSource = FormasPago.Tables(0)
            cmbmetododepago.DisplayMember = "concepto"
            cmbmetododepago.ValueMember = "clave"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub guardarfacturacion()
        Dim Fact As CFDI.Comprobante
        Dim DomFiscalCte As DomicilioClienteClass
        DomFiscalCte = DirectCast(ultcmbDomiciliosFiscales.SelectedRow.ListObject, DomicilioClienteClass)
        Cliente = New ClientesIntroductoresClass(DirectCast(CmbCliente.SelectedItem, EC.MfacCatClientesEntity))

        '----------------------------------------------------
        '   Inicia codigo agregado para generar el CFDI
        '----------------------------------------------------
        Dim ControlFD As Integralab.FactDigital.ControladorFactDigital
        Dim ConStr As String
        If File.Exists(Application.StartupPath + "\\cx.dat") Then
            ConStr = Integralab.FactDigital.ControladorFactDigital.Decrypt(File.ReadAllText(Application.StartupPath + "\\cx.dat"))
        Else
            Throw New Exception("No se ha configurado la conexi�n a la base de datos de la factura digital.")
        End If
        ControlFD = New Integralab.FactDigital.ControladorFactDigital(1, ConStr)
        Dim TransG As New Gentle.Framework.Transaction(Integralab.FactDigital.ControladorFactDigital.Conexion)

        ''datos del emisor
        Dim regimenfiscal = DirectCast([Enum].Parse(GetType(CFDI.c_RegimenFiscal), Controlador.Sesion.MiEmpresa.EmpRegimenFiscal), CFDI.c_RegimenFiscal)
        Dim Emisor As New CFDI.ComprobanteEmisor(Controlador.Sesion.MiEmpresa.EmpRfc, regimenfiscal)

        ''datos del receptor
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
        Receptor.Nombre = Cliente.RazonSocial
        Receptor.UsoCFDI = CFDI.c_UsoCFDI.P01

        ''CONCEPTOS
        Dim Conceptos As New List(Of CFDI.ComprobanteConcepto)()

        ''  IMPUESTOS
        Dim Impuestos As New CFDI.ComprobanteConceptoImpuestos()

        ''       TRASLADOS
        Dim Traslados As New List(Of CFDI.ComprobanteImpuestosTraslado)


        ''RECORRER GRID
        For Each det As DataGridViewRow In dgvDetalle.Rows
            ''CONCEPTO 
            Dim Concepto As New CFDI.ComprobanteConcepto(CStr(det.Cells("clmProducto").Value), CStr(det.Cells("Unidadsat").Value), "pendiente", CDec(det.Cells("clmCantidad").Value), CStr(det.Cells("Unidadsat").Value), "descripcion", CDec(det.Cells("clmPrecioUnitario").Value), CDec(det.Cells("clmImporte").Value))

            ''Concepto.Impuestos = Impuestos.


        Next


    End Sub
End Class