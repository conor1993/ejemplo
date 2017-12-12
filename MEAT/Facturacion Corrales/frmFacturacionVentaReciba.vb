Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses

Public Class frmFacturacionVentaReciba

#Region "Miembros"
    Dim SalidadeRecibaAVenta As SalidaGanadoCabeceroClass
    Dim SalidadeRecibaAVentadetalle As SalidaGanadoDetalleClass
    Dim FacturaCabecero As FacturasClass
    Dim ClientesCol As ClientesIntroductoresColeccion
    Dim ConF As New CC.ConfiguracionFacturaCollection
    Dim NumRenglones As Integer
    Dim configurarImprecion As Boolean = True

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
        Me.txtDescuento.Text = "0"
        Me.txtSubTotal.Text = "0"
        Me.txtTotal.Text = "0"

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
                Dim Folio As New FoliosClass 'variable para la clase de folio
                'Dim FacturasDetalleCol As New CN.FacturasDetalleCollectionClass ' para crear la coleccion de detalle
                'Dim FacturasDet As New EC.DetFacturasEntity 'para agregar al detalle
                'para crear el folio de la factura
                Folio.Codigo = CodigodeFolios.FacturasVentasyCorrales
                Folio.Año = 1
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
                FacturaCabecero.Referencia = SalidadeRecibaAVenta.IdSalidaGanadoCab
                FacturaCabecero.Estatus = "V"
                FacturaCabecero.StaFacturacion = "N"
                'guardar cabecero
                Controlador.RealizarFacturasdeVenta(FacturaCabecero, Now, ClasesNegocio.TipoFacturaEnum.FACTURACION_DE_VENTA_DE_RECIBA, Trans)

                'agregar a la clase detalle de facturas
                For i As Integer = 0 To Me.dgvDetalle.RowCount - 1
                    Dim FacturasDetalle As New FacturasDetalleClass
                    FacturasDetalle.CabezasxTipoGanado = Me.dgvDetalle.Rows(i).Cells(Me.Cabezas.Index).Value
                    FacturasDetalle.IdTipoGanado = Me.dgvDetalle.Rows(i).Cells(Me.Codigo.Index).Value
                    FacturasDetalle.KilosxTipoGanado = Me.dgvDetalle.Rows(i).Cells(Me.Kilos.Index).Value
                    FacturasDetalle.PrecioxKiloxTipoGanado = Me.dgvDetalle.Rows(i).Cells(Me.PrecioxKilo.Index).Value
                    FacturasDetalle.Renglon = i
                    FacturasDetalle.Servicios = "N"
                    FacturasDetalle.TipoFactura = TipoFacturaEnum.FACTURACION_DE_VENTA_DE_RECIBA
                    FacturasDetalle.Estatus = "V"
                    FacturasDetalle.CveCorral = Me.dgvDetalle.Rows(i).Cells(Me.CveCorral.Index).Value
                    'guardar el detalle
                    Controlador.RealizarFacturasdeVentaenDetalle(FacturasDetalle, Me.txtFolioFactura.Text, Trans)
                Next
                'afectar tabla de salidas de reciba
                Controlador.FacturarSalidaDeGanadodeReciba(SalidadeRecibaAVenta, True, Trans)
                Trans.Commit()
                MessageBox.Show("La Factura de Reciba a Venta se ha realizado satisfactoriamente con el folio: " & FacturaCabecero.FolFactura)
            Else
                FacturaCabecero.Estatus = "C"
                Controlador.FacturarSalidaDeGanadodeReciba(SalidadeRecibaAVenta, False, Trans)
            End If
            Limpiar()
            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    Private Function Imprimir(ByVal DomicilioCliente As DomicilioClienteClass, Optional ByVal conRFC As Boolean = True) As Boolean
        Try
            'Dim I As Integer
            'Fact = FacturasCab.Obtener(3, Me.txtFolioFactura.Text)
            Dim Imp As New EscritorClass(80, 60)
            Dim Fact As New FacturasCollectionClass
            Dim ClientesImp As New ClientesIntroductoresClass
            Fact = Controlador.ObtenerFacturasDeVenta(Me.txtFolioFactura.Text, Nothing, 0, EstatusChar.TODOS, TipoFacturaEnum.FACTURACION_DE_VENTA_DE_RECIBA)
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

    Private Function CargarSalidasdeGanado() As Boolean
        Try
            Dim Cabezas As Integer = 0, Kilos As Decimal = 0D, Importe As Decimal = 0D, ImporteVenta As Decimal = 0D
            Dim Consultas As New frmBusquedaCorralesRecibaVenta
            Dim ListaSalidas As New List(Of String)
            Dim estatus As String = String.Empty

            Consultas.chkVigentes.Enabled = False
            Consultas.chkVigentes.Checked = True
            Consultas.chkCancelados.Checked = True
            Consultas.chkCancelados.Enabled = False

            If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then

                SalidadeRecibaAVenta = CType(Consultas.dgvCorralesRecibaCab.SelectedRows(0).DataBoundItem, SalidaGanadoCabeceroClass)
                Me.txtFolioSalidaVenta.Text = SalidadeRecibaAVenta.Folio
                Me.dgvDetalle.AutoGenerateColumns = False
                Me.dgvDetalle.DataSource = SalidadeRecibaAVenta.Detalles

                For Each Detalle As SalidaGanadoDetalleClass In SalidadeRecibaAVenta.Detalles
                    Cabezas += Detalle.Cabezas
                    Kilos += Detalle.Kilos
                    Importe += Detalle.Importe
                    ImporteVenta += Detalle.ImporteVenta
                Next

                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "Eventos"
    Private Sub frmFacturacionVentaReciba_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
         

            'Me.dgvDetalle.AutoGenerateColumns = False
            'ConF.GetMulti(Nothing)

            ClientesCol = New ClientesIntroductoresColeccion
            ClientesCol.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)

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
            If MessageBox.Show("¿ Se va a Cancelar Factura de Reciba de Venta: " & Me.txtFolioFactura.Text & " ?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
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
            End If
           
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Try
            Dim Consultas As New frmBusquedaFacturas
            Dim Clientes As New ClientesIntroductoresClass
            Dim ListaSalidas As New List(Of String)
            Consultas.TipoFactura = TipoFacturaEnum.FACTURACION_DE_VENTA_DE_RECIBA
            If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then

                FacturaCabecero = CType(Consultas.dgvFacturasCabecero.SelectedRows(0).DataBoundItem, FacturasClass)
                Me.txtFolioFactura.Text = FacturaCabecero.NoFactura
                Me.txtFolioSalidaVenta.Text = FacturaCabecero.ReferenciaSalidas
                Me.dgvDetalle.AutoGenerateColumns = False
                Me.dgvDetalle.DataSource = FacturaCabecero.Detalles
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

                'Cliente = New ClasesNegocio.ClientesIntroductoresClass(New EC.MfacCatClientesEntity(CInt(Me.txtCodigoCliente.Text)))

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

            If MessageBox.Show("¿ Se va Generar Factura de Reciba de Venta Es la información correcta ?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Guardar(Trans, "V")
                Trans.Commit()
                Me.Limpiar()
                Me.Deshabilitar()
            Else
                Cancelar = True
            End If
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

            If Controlador.Configuracion.Venta.Count > 0 Then
                If Controlador.Configuracion.Venta.Count = 1 Then
                    ConF.Add(Controlador.Configuracion.Venta(0).Entidad)
                Else
                    Dim seleccionarCOnfiguracion As New frmSeleccionConfiguracionFactura

                    If seleccionarCOnfiguracion.ShowDialog = Windows.Forms.DialogResult.OK Then
                        ConF.Add(seleccionarCOnfiguracion.ConfiguracionSeleccionada.Entidad)
                    Else
                        MsgBox("Debe seleccionar una configuración", MsgBoxStyle.Exclamation, "Seleccione una Configuración")
                        Exit Sub
                    End If
                End If
            Else
                MsgBox("Establezca una configuración", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            End If

            'buscar el numero de renglones por factura para dividir las facturas en mas
            'de una factura                 
            NumRenglones = ConF(0).RenglonesEnDetalle

            If MessageBox.Show("¿Desea imprimirlo con RFC?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                conRFC = False
            End If

            Me.Imprimir(CType(ultcmbDomiciliosFiscales.SelectedRow.ListObject, DomicilioClienteClass), conRFC)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Me.Limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickNuevo
        Me.Limpiar()
        FacturaCabecero = New FacturasClass
        Cancelar = True

        If CargarSalidasdeGanado() Then
            Habilitar()
            Me.GroupBox1.Enabled = True
            Me.rdContado.Checked = True
            Cancelar = False
        End If
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub

    'Private Sub cmdSalidas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalidas.Click
    '    Try
    '        Dim Cabezas As Integer = 0, Kilos As Decimal = 0D, Importe As Decimal = 0D, ImporteVenta As Decimal = 0D
    '        Dim Consultas As New frmBusquedaCorralesRecibaVenta
    '        Dim ListaSalidas As New List(Of String)
    '        Dim estatus As String = String.Empty

    '        Consultas.chkVigentes.Enabled = False
    '        Consultas.chkVigentes.Checked = True
    '        Consultas.chkCancelados.Checked = True
    '        Consultas.chkCancelados.Enabled = False

    '        If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then

    '            SalidadeRecibaAVenta = CType(Consultas.dgvCorralesRecibaCab.SelectedRows(0).DataBoundItem, SalidaGanadoCabeceroClass)
    '            Me.txtFolioSalidaVenta.Text = SalidadeRecibaAVenta.Folio
    '            Me.dgvDetalle.AutoGenerateColumns = False
    '            Me.dgvDetalle.DataSource = SalidadeRecibaAVenta.Detalles
    '            'dtpFecha.Value = CorralReciba.Fecha
    '            'cmbCorral.SelectedValue = CorralReciba.IdCorral
    '            'Me.ActualizarCorral(CorralReciba.Corral)
    '            'dgvDetalle.DataSource = CorralReciba.Detalles
    '            'lblEstatus.Text = CorralReciba.Estatus.ToString()

    '            For Each Detalle As SalidaGanadoDetalleClass In SalidadeRecibaAVenta.Detalles
    '                Cabezas += Detalle.Cabezas
    '                Kilos += Detalle.Kilos
    '                Importe += Detalle.Importe
    '                ImporteVenta += Detalle.ImporteVenta
    '            Next



    '            'txtTotalCabezas.Text = Cabezas
    '            'txtTotalKilos.Text = Kilos.ToString("N2")
    '            'Me.txtSubTotal.Text = ImporteVenta.ToString("C2")
    '            'Me.txtTotal.Text = Me.txtSubTotal.Text



    '            'Return True
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub


    Private Sub CmbCliente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCliente.SelectedIndexChanged
        Try
            Dim ClientesClas As New ClientesIntroductoresClass
            Me.txtCodigoCliente.Text = Me.CmbCliente.SelectedValue
            If ClientesClas.Obtener(Me.CmbCliente.SelectedValue) Then
                Me.txtRFC.Text = ClientesClas.RFC
                Me.txtDiasCredito.Text = ClientesClas.DiasCredito
                Me.txtDireccion.Text = ClientesClas.Domicilio
                Me.ultcmbDomiciliosFiscales.DataSource = ClientesClas.DomiciliosFiscales
                Me.ultcmbDomiciliosFiscales.Rows(0).Selected = True
            End If
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






    Private Sub dgvDetalle_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalle.CellContentClick

    End Sub

    Private Sub dgvDetalle_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalle.CellEndEdit
        Try
            Dim Total As Decimal = 0
            If e.ColumnIndex = 5 Then
                Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.Importe.Index).Value = Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.Kilos.Index).Value * Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.PrecioxKilo.Index).Value
            End If
            For i As Integer = 0 To Me.dgvDetalle.Rows.Count
                Total += Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.Importe.Index).Value
            Next
            Me.txtSubTotal.Text = Total.ToString("N2")
            Me.txtTotal.Text = Total.ToString("N2")
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDescuento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescuento.TextChanged
        If Me.txtDescuento.Text <> "0" Then
            Me.txtTotal.Text = CDbl(Me.txtSubTotal.Text) - CDbl(Me.txtDescuento.Text)
        End If
    End Sub
End Class