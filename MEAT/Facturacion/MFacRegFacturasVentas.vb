Imports ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient
Imports Integralab.CFD
Imports System.IO
Imports Integralab

Public Class MFacRegFacturasVentas

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
    Dim Cliente As ClientesIntroductoresClass
    'variables para la impresion de facturas
    Dim NumerodeFacturas As Integer

#Region "Eventos"

#End Region
#End Region

#Region "Constructores"

#End Region

#Region "Propiedades"

#End Region

#Region "Metodos"

    Private Function Guardar(ByRef Trans As HC.Transaction) As Boolean




    End Function

    Private Function Limpiar() As Boolean
        Me.txtCajas.Text = "0"
        Me.txtCodigoCliente.Text = ""
        Me.txtCliente.Text = "0"
        Me.txtDiasCredito.Text = "0"
        Me.txtDireccion.Text = ""
        Me.txtFolioEmbarque.Text = ""
        Me.txtFolioFactura.Text = ""
        Me.txtIVA.Text = "0"
        Me.txtKgrs.Text = "0"
        Me.txtObservaciones.Text = ""
        Me.txtPiezas.Text = ""
        Me.txtRFC.Text = ""
        Me.txtSubTotal.Text = "0"
        Me.txtTotal.Text = "0"
        Me.txtPoliza.Text = ""
        '        Me.dgvDetalle.DataSource = Nothing

        Me.dgvDetalle.Rows.Clear()
        Me.dgvDetalleConcentrado.DataSource = Nothing
        Me.dgvDetalleConcentrado.Rows.Clear()

        Me.lblEstatus.Visible = False
        Me.dtFechaFactura.Value = Now
        Me.dtpFechaVencimiento.Value = Now
        Me.ChkVarios.Checked = False
        Me.CmbClientesVarios.Text = "Seleccione un cliente"
        Me.lvEmbarques.Clear()
        Me.ultcmbDomiciliosFiscales.DataSource = Nothing
    End Function

    Private Function Buscar() As Boolean
        Try
            ''Dim Tabla As DataSet
            Dim Consulta As New FrmConFacturas
            ''Tabla = FacturasCab.Consulta("", 1)
            ''Consulta.DgvFacturas.AutoGenerateColumns = False
            ''Consulta.DgvFacturas.DataSource = Tabla.Tables(0)
            ''Consulta.Factura.DataPropertyName = "NoFactura"
            ''Consulta.IdCLiente.DataPropertyName = "IdCliente"
            ''Consulta.Cliente.DataPropertyName = "Nombre"
            ''Consulta.FechaCaptura.DataPropertyName = "FechaCaptura"
            ''Consulta.FechaFactura.DataPropertyName = "FechaFactura"
            ''Consulta.FechaVencimiento.DataPropertyName = "FechaVencimiento"
            ''Consulta.Contado.DataPropertyName = "Contado"
            ''Consulta.Credito.DataPropertyName = "Credito"
            ''Consulta.SubTotal.DataPropertyName = "SubTotal"
            ''Consulta.IVA.DataPropertyName = "IVA"
            ''Consulta.Total.DataPropertyName = "Total"
            ''Consulta.Estatus.DataPropertyName = "Estatus"
            ''Consulta.Observaciones.DataPropertyName = "Observaiones"
            ''Consulta.RFC.DataPropertyName = "RFC"
            ''Consulta.Poliza.DataPropertyName = "IdPoliza"
            ''Consulta.IdFolioEmbarque.DataPropertyName = "IdFolioEmbarque"
            ''Consulta.Domicilio.DataPropertyName = "Domicilio"

            If Consulta.ShowDialog = Windows.Forms.DialogResult.OK Then
                'Me.dgvDetalleConcentrado.Rows.Clear()
                Me.lvEmbarques.Items.Clear()
                Dim Folio As String = Consulta.DgvFacturas.CurrentRow.Cells("Factura").Value
                If Not DBNull.Value.Equals(Consulta.DgvFacturas.CurrentRow.Cells("IdFolioEmbarque").Value) Then
                    For i As Integer = 0 To Consulta.DgvFacturas.Rows.Count - 1
                        If Folio = Consulta.DgvFacturas.Rows(i).Cells("Factura").Value Then
                            Me.lvEmbarques.Items.Add(Consulta.DgvFacturas.Rows(i).Cells("IdFolioEmbarque").Value)
                        End If
                    Next
                End If
                Dim IdCliente As Integer = CInt(Consulta.DgvFacturas.CurrentRow.Cells("IdCliente").Value)
                Me.FacturasCab = New FacturasClientesCabClass(Controlador.Configuracion.FacturaFolios.StaLetraSerie, Folio)

                Me.txtFolioFactura.Text = FacturasCab.NoFactura
                Me.txtCliente.Text = Consulta.DgvFacturas.CurrentRow.Cells("Cliente").Value
                Me.txtCodigoCliente.Text = FacturasCab.IdCliente
                Me.dtFechaFactura.Text = FacturasCab.FechaFactura
                Me.dtpFechaVencimiento.Text = FacturasCab.FechaVencimiento
                Me.rdContado.Checked = FacturasCab.Contado
                Me.rdCredito.Checked = FacturasCab.Credito
                Me.txtSubTotal.Text = FacturasCab.SubTotal.ToString("C2")
                Me.txtIVA.Text = FacturasCab.IVA.ToString("C2")
                Me.txtTotal.Text = FacturasCab.Total.ToString("C2")
                Me.txtObservaciones.Text = FacturasCab.Observaciones
                Me.CmbClientesVarios.SelectedValue = FacturasCab.IdClienteCargo
                'If Not DBNull.Value.Equals(Consulta.DgvFacturas.CurrentRow.Cells("IdFolioEmbarque").Value) Then
                '    Me.txtFolioEmbarque.Text = Consulta.DgvFacturas.CurrentRow.Cells("IdFolioEmbarque").Value
                'End If

                Me.txtPoliza.Text = Consulta.DgvFacturas.CurrentRow.Cells("Poliza").Value
                Me.txtDireccion.Text = Consulta.DgvFacturas.CurrentRow.Cells("Domicilio").Value
                Me.txtRFC.Text = Consulta.DgvFacturas.CurrentRow.Cells("RFC").Value
                Me.lblEstatus.Text = Consulta.DgvFacturas.CurrentRow.Cells("Estatus").Value
                Me.lblEstatus.Visible = True
                Dim TablaFac As DataSet = FacturasCab.Consulta(Controlador.Configuracion.FacturaFolios.StaLetraSerie, Me.txtFolioFactura.Text, 3)
                'Dim TablaFac1 As DataSet = FacturasCab.Consulta(Me.txtFolioFactura.Text, 4)
                'If TablaFac.Tables(0).Rows.Count = 0 Then
                'TablaFac = TablaFac1
                'End If
                Me.dgvDetalleConcentrado.AutoGenerateColumns = False
                Me.dgvDetalleConcentrado.DataSource = TablaFac.Tables(0)
                Me.Codigo.DataPropertyName = "Codigo"
                Me.Descripcion.DataPropertyName = "Descripcion"
                Me.KilosEmbarcados.DataPropertyName = "KilosEmbarcados"
                Me.KilosFacturados.DataPropertyName = "KilosFacturados"
                Me.Precios.DataPropertyName = "PrecioxKgr"
                Me.ImporteFacturado.DataPropertyName = "ImporteFacturado"
                Me.ImporteEmbarcado.DataPropertyName = "ImporteEmbarcado"
                'Dim TablaFactura As DataSet = FacturasCab.Consulta(Me.txtFolioFactura.Text, 2)
                'dgvDetalle.DataSource = TablaFactura.Tables(0)
                'Me.Etiqueta.DataPropertyName = "IdFolioEtiqueta"
                'Me.Corte.DataPropertyName = "Descripcion"
                'Me.Piezas.DataPropertyName = "CantPzas"
                'Me.Kilos.DataPropertyName = "CantKgrs"
                'Me.PrecioUnitario.DataPropertyName = "PrecioxKgr"
                'Me.IVA.DataPropertyName = "IVA"
                'Me.Importe.DataPropertyName = "Importe"

                Cliente = New ClasesNegocio.ClientesIntroductoresClass(New EC.MfacCatClientesEntity(CInt(Me.txtCodigoCliente.Text)))

                Me.ultcmbDomiciliosFiscales.DataSource = Cliente.DomiciliosFiscales

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

                If Cliente.DomiciliosFiscales.Count = 1 Then
                    ultcmbDomiciliosFiscales.Rows(0).Selected = True
                End If
            Else
                Return False
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub RellenarClientesVarios()
        ClientesV.Obtener(False, CondicionEstatusEnum.ACTIVO)
        Me.CmbClientesVarios.ValueMember = "Codigo"
        Me.CmbClientesVarios.DisplayMember = "Nombre"
        Me.CmbClientesVarios.DataSource = ClientesV
    End Sub

    'Private Sub ObtenerCuentas()
    '    Dim tvw As New Integralab.ORM.DaoClasses.TypedListDAO
    '    Dim Dt As New DataTable
    '    Dim campos As New HC.ResultsetFields(2)
    '    campos.DefineField(HC.CfgCtrlCtasFields.Folio, 0, "018")
    '    campos.DefineField(HC.CfgCtrlCtasFields.Folio, 1, "037")
    '    tvw.GetMultiAsDataTable(campos, Dt, 0, Nothing, Nothing, Nothing, True, Nothing, Nothing, 0, 0)
    'End Sub
    'Private Function Imprimir(ByRef Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
    '    Try
    '        'Dim I As Integer
    '        Dim Fact As DataSet = FacturasCab.Obtener(3, Me.txtFolioFactura.Text, Trans)
    '        Dim Convertir As New ConvertirNumeroALetraClass
    '        Dim ConF As New CC.ConfiguracionFacturaCollection
    '        ConF.GetMulti(Nothing)
    '        If Fact Is Nothing Then
    '            Return False
    '        End If
    '        'Fact = FacturasCab.Obtener(Me.txtFolioFactura.Text, Me.txtCodigoCliente.Text)

    '        'cabecero de factura
    '        Imp.Escribe(Fact.Tables(0).Rows(0)("Nombre"), ConF(0).Campo1X, ConF(0).Campo1Y) ' nombre del cliente
    '        Imp.Escribe(Fact.Tables(0).Rows(0)("NoFactura"), ConF(0).Campo6X, ConF(0).Campo6Y) 'Folio de Factura
    '        Imp.Escribe(Fact.Tables(0).Rows(0)("Domicilio"), ConF(0).Campo2X, ConF(0).Campo2Y) 'direccion del cliente
    '        'Imp.Escribe(Fact.Tables(0).Rows(0)("Domicilio"), 10, 10) 'ciudad del cliente
    '        Imp.Escribe(Fact.Tables(0).Rows(0)("RFC"), ConF(0).Campo4X, ConF(0).Campo4Y) 'rfc del cliente
    '        Imp.Escribe(Fact.Tables(0).Rows(0)("FechaFactura"), ConF(0).Campo14X, ConF(0).Campo14Y) 'fecha de la factura
    '        ''detalle de factura
    '        Dim renglon As Byte
    '        renglon = 13
    '        For i As Integer = 0 To Fact.Tables(0).Rows.Count - 1
    '            Imp.Escribe(CDec(Fact.Tables(0).Rows(i)("CantKgrs")).ToString("N2"), 2, renglon)
    '            Imp.Escribe(Fact.Tables(0).Rows(i)("Descripcion"), 10, renglon)
    '            Imp.Escribe(CDec(Fact.Tables(0).Rows(i)("PrecioxKgr")).ToString("N2"), 50, renglon)
    '            Imp.Escribe(CDec(Fact.Tables(0).Rows(i)("Importe")).ToString("N2"), 62, renglon)
    '            renglon = renglon + 1
    '        Next
    '        'total de factura
    '        Imp.Escribe(CDec(Fact.Tables(0).Rows(0)("SubTotal")).ToString("N2"), ConF(0).Campo10X, ConF(0).Campo10Y)
    '        Imp.Escribe(CDec(Fact.Tables(0).Rows(0)("IVA")).ToString("N2"), ConF(0).Campo11X, ConF(0).Campo11Y)
    '        Imp.Escribe(CDec(Fact.Tables(0).Rows(0)("Total")).ToString("N2"), ConF(0).Campo12X, ConF(0).Campo12Y)
    '        Imp.Escribe(Convertir.Convertir(Fact.Tables(0).Rows(0)("Total"), TipoMonedaEnum.PESO), 15, 49)
    '        ' ''total a pagar
    '        Imp.Escribe(Me.dtpFechaVencimiento.Value, 55, 53)
    '        Imp.Escribe(CDec(Fact.Tables(0).Rows(0)("Total")).ToString("N2"), 65, 54)
    '        Imp.Escribe(Convertir.Convertir(Fact.Tables(0).Rows(0)("Total"), TipoMonedaEnum.PESO), 15, 55)
    '        'Imp.Escribe(Me.txtTotal.Text, 65, 54)

    '        Imp.Imprime()
    '        Return True
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False

    '    End Try
    'End Function

    Private Sub Imprime_Documento(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
        Try
            'generadorCodigoBarra.Message = folioEtiqueta

            'e.PageSettings.PaperSize = New Printing.PaperSize("Etiqueta", 406, 500)
            Dim f10 As New Font("Arial", 10) 'formato de impresion Arial tamaño 10
            Dim fn10 As New Font("Arial", 10, FontStyle.Bold) 'formato de impresion Arial tamaño 10 Negrita
            Dim nombreProducto As String = String.Empty
            Dim agregarRenglon As Integer = 0

            e.Graphics.DrawString(nombreProducto, New Font("Arial", 18, FontStyle.Bold), Brushes.Black, 15, 11 + agregarRenglon)

            e.HasMorePages = False
        Catch ex As Exception
            e.HasMorePages = False
        End Try
    End Sub

    Private Function Imprimir(ByVal DomicilioCliente As DomicilioClienteClass, Optional ByVal conRFC As Boolean = True) As Boolean
        Try
            'Dim I As Integer
            'Fact = FacturasCab.Obtener(3, Me.txtFolioFactura.Text)
            Dim Imp As New EscritorClass(80, 60)
            Dim Fact As DataSet = FacturasCab.Obtener(3, Controlador.Configuracion.FacturaFolios.StaLetraSerie, Me.txtFolioFactura.Text)
            'Dim Fact1 As DataSet = FacturasCab.Obtener(4, Me.txtFolioFactura.Text)
            Dim Convertir As New ConvertirNumeroALetraClass
            'If Fact.Tables(0).Rows.Count = 0 Then
            ' Fact = Fact1zw
            ' End If
            'Fact = FacturasCab.Obtener(Me.txtFolioFactura.Text, Me.txtCodigoCliente.Text)

            If Fact.Tables(0).Rows.Count = 0 Then
                Exit Function
            End If

            'cabecero de factura
            If Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo1X = 0 Or Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo1Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresión del nombre del cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo2X = 0 Or Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo2Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresión del domicilio del cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo3X = 0 Or Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo3Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresión de la ciudad del cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo4X = 0 Or Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo4Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresión del estado del cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo5X = 0 Or Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo5Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresión del RFC del cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo6X = 0 Or Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo6Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresión del folio o numero de factura", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo7X = 0 Or Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo7Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresión de la fecha de factura", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo8X = 0 Or Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo8Y = 0 Or Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo9X = 0 Or Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo9Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresión de la cantidad y la descripcion del producto", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo10X = 0 Or Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo10Y = 0 Or Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo11X = 0 Or Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo11Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresión del precio y el importe total del producto", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            If Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo12X = 0 Or Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo12Y = 0 Or Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo13X = 0 Or Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo13Y = 0 Or Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo14X = 0 Or Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo14Y = 0 Or Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo15X = 0 Or Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo15Y = 0 Then
                MessageBox.Show("Configure las coordenas de impresión del subtotal, iva, total e importe con letra de la factura", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If

            Dim cliente As String = Fact.Tables(0).Rows(0)("Nombre").ToString.Replace("Ñ", "N").Trim.Replace("ñ", "n")

            If Controlador.Configuracion.SeleccionActualConfiguracionFactura.LetrasXrenglonCliente < cliente.Length Then
                Dim separado As String() = cliente.Split(" ")
                Dim Partes As New List(Of String)

                For Each palabra As String In separado
                    If Partes.Count = 0 Then
                        Partes.Add(palabra.Trim)
                        Continue For
                    End If

                    If (Partes(Partes.Count - 1).Length + palabra.Trim.Length) > Controlador.Configuracion.SeleccionActualConfiguracionFactura.LetrasXrenglonCliente Then
                        Partes.Add(palabra.Trim)
                    Else
                        Partes(Partes.Count - 1) &= " " & palabra.Trim
                    End If
                Next

                For i As Integer = 0 To Partes.Count - 1
                    Imp.Escribe(Partes(i), Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo1X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo1Y + i) 'direccion del cliente
                Next
            Else
                Imp.Escribe(cliente, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo1X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo1Y) ' nombre del cliente
            End If

            Dim bajarFila As Integer = Math.Truncate(cliente.Length / Controlador.Configuracion.SeleccionActualConfiguracionFactura.LetrasXrenglonCliente)
            Dim domicilio As String = DomicilioCliente.Domicilio.Trim.Replace("Ñ", "N").Replace("ñ", "n") & " COL. " & DomicilioCliente.Colonia.Trim

            If Controlador.Configuracion.SeleccionActualConfiguracionFactura.NumeroLetrasXFilaDomicilio < domicilio.Length Then
                Dim separado As String() = domicilio.Split(" ")
                Dim Partes As New List(Of String)

                For Each palabra As String In separado
                    If Partes.Count = 0 Then
                        Partes.Add(palabra.Trim)
                        Continue For
                    End If

                    If (Partes(Partes.Count - 1).Length + palabra.Trim.Length) > Controlador.Configuracion.SeleccionActualConfiguracionFactura.NumeroLetrasXFilaDomicilio Then
                        Partes.Add(palabra.Trim)
                    Else
                        Partes(Partes.Count - 1) &= " " & palabra.Trim
                    End If
                Next

                For i As Integer = 0 To Partes.Count - 1
                    If i > 0 Then
                        bajarFila += 1
                    End If
                    Imp.Escribe(Partes(i), Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo2X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo2Y + bajarFila) 'direccion del cliente
                Next
            Else
                Imp.Escribe(domicilio, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo2X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo2Y + bajarFila) 'direccion del cliente
            End If

            If Controlador.Configuracion.SeleccionActualConfiguracionFactura.DatosClienteCpC <> 0 AndAlso Controlador.Configuracion.SeleccionActualConfiguracionFactura.DatosClienteCpR <> 0 AndAlso DomicilioCliente.CodigPostal.Trim <> String.Empty Then
                If Controlador.Configuracion.SeleccionActualConfiguracionFactura.DatosClienteCpR = Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo2Y Then
                    bajarFila += 1
                End If
                Imp.Escribe("C.P. " & DomicilioCliente.CodigPostal.Replace(",", "").Replace(".", ""), Controlador.Configuracion.SeleccionActualConfiguracionFactura.DatosClienteCpC, Controlador.Configuracion.SeleccionActualConfiguracionFactura.DatosClienteCpR + bajarFila) 'codigo postal del cliente
            End If

            Imp.Escribe(DomicilioCliente.Ciudad.Descripcion, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo3X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo3Y + bajarFila) 'ciudad del cliente
            Imp.Escribe(DomicilioCliente.Estado.Descripcion, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo4X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo4Y + bajarFila) 'estado del cliente
            Imp.Escribe(IIf(conRFC, Fact.Tables(0).Rows(0)("RFC"), ""), Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo5X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo5Y + bajarFila) 'rfc del cliente
            Imp.Escribe(Fact.Tables(0).Rows(0)("NoFactura"), Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo6X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo6Y) ' + bajarFila 'Folio de Factura
            Imp.Escribe(Fact.Tables(0).Rows(0)("FechaFactura"), Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo7X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo7Y) ' + bajarFila 'fecha de la factura

            Dim Observaciones As String = Fact.Tables(0).Rows(0)("Observaciones").ToString.Trim

            If Controlador.Configuracion.SeleccionActualConfiguracionFactura.DatosFacturaObsrvC <> 0 AndAlso Controlador.Configuracion.SeleccionActualConfiguracionFactura.DatosFacturaObsrvR <> 0 Then
                If Controlador.Configuracion.SeleccionActualConfiguracionFactura.LetrasxRenglonObsrv < Observaciones.Length Then
                    Dim separado As String() = Observaciones.Split(" ")
                    Dim Partes As New List(Of String)

                    For Each palabra As String In separado
                        If Partes.Count = 0 Then
                            Partes.Add(palabra.Trim)
                            Continue For
                        End If

                        If (Partes(Partes.Count - 1).Length + palabra.Trim.Length) > Controlador.Configuracion.SeleccionActualConfiguracionFactura.LetrasxRenglonObsrv Then
                            Partes.Add(palabra.Trim)
                        Else
                            Partes(Partes.Count - 1) &= " " & palabra.Trim
                        End If
                    Next

                    For i As Integer = 0 To Partes.Count - 1
                        If i > 0 Then
                            bajarFila += 1
                        End If
                        Imp.Escribe(Partes(i), Controlador.Configuracion.SeleccionActualConfiguracionFactura.DatosFacturaObsrvC, Controlador.Configuracion.SeleccionActualConfiguracionFactura.DatosFacturaObsrvR + bajarFila) 'observaciones factura
                    Next
                Else
                    Imp.Escribe(Observaciones, Controlador.Configuracion.SeleccionActualConfiguracionFactura.DatosFacturaObsrvC, Controlador.Configuracion.SeleccionActualConfiguracionFactura.DatosFacturaObsrvR) 'observaciones factura
                End If
            End If

            Dim ColReferenciaEmbarque As New List(Of String), ReferenciaEmbarque As String = ""

            For Each Embarque As EC.MfacEmbarquesCabEntity In FacturasCab.Entidad.MfacEmbarquesCabCollectionViaMfacEmbarquesDet
                ColReferenciaEmbarque.Add(Embarque.FolioEmbarqueEmp.Trim)
            Next
            ReferenciaEmbarque = Join(ColReferenciaEmbarque.ToArray, ", ").Trim

            If Controlador.Configuracion.SeleccionActualConfiguracionFactura.DatosFacturaReferenciaC <> 0 AndAlso Controlador.Configuracion.SeleccionActualConfiguracionFactura.DatosFacturaReferenciaR <> 0 Then
                If Controlador.Configuracion.SeleccionActualConfiguracionFactura.LetrasxRenglonReferencia < ReferenciaEmbarque.Length Then
                    Dim separado As String() = ReferenciaEmbarque.Split(" ")
                    Dim Partes As New List(Of String)

                    For Each palabra As String In separado
                        If Partes.Count = 0 Then
                            Partes.Add(palabra.Trim)
                            Continue For
                        End If

                        If (Partes(Partes.Count - 1).Length + palabra.Trim.Length) > Controlador.Configuracion.SeleccionActualConfiguracionFactura.LetrasxRenglonReferencia Then
                            Partes.Add(palabra.Trim)
                        Else
                            Partes(Partes.Count - 1) &= " " & palabra.Trim
                        End If
                    Next

                    For i As Integer = 0 To Partes.Count - 1
                        If i > 0 Then
                            bajarFila += 1
                        End If
                        Imp.Escribe(Partes(i), Controlador.Configuracion.SeleccionActualConfiguracionFactura.DatosFacturaReferenciaC, Controlador.Configuracion.SeleccionActualConfiguracionFactura.DatosFacturaReferenciaR + bajarFila) 'referencia embarque
                    Next
                Else
                    Imp.Escribe(ReferenciaEmbarque, Controlador.Configuracion.SeleccionActualConfiguracionFactura.DatosFacturaReferenciaC, Controlador.Configuracion.SeleccionActualConfiguracionFactura.DatosFacturaReferenciaR) 'referencia embarque
                End If
            End If

            ''detalle de factura
            'Microsoft.VisualBasic.Right("000" + CStr(Ventana.DgvCortes.CurrentRow.Cells(Ventana.ClmCodigo.Index).Value), 3)
            Dim renglon As Byte

            renglon = Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo8Y

            For i As Integer = 0 To Fact.Tables(0).Rows.Count - 1
                Imp.EscribeDer(CDec(Fact.Tables(0).Rows(i)("KilosFacturados")).ToString("N2") & "Kgrs", Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo8X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo8X, renglon)
                Imp.Escribe(Fact.Tables(0).Rows(i)("Descripcion").ToString.Trim.Replace("Ñ", "N").Replace("ñ", "n"), Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo9X, renglon)
                Dim num As Decimal = CDec(Fact.Tables(0).Rows(i)("PrecioxKgr"))
                Imp.EscribeDer(num.ToString("N2"), Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo10X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo10X, renglon)
                Imp.EscribeDer(CDec(Fact.Tables(0).Rows(i)("ImporteFacturado")).ToString("N2"), Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo11X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo11X, renglon)
                renglon = renglon + 1
            Next

            'total de factura
            Imp.Escribe(CDec(Fact.Tables(0).Rows(0)("SubTotal")).ToString("N2"), Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo12X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo12Y)
            Imp.Escribe(CDec(Fact.Tables(0).Rows(0)("IVA")).ToString("N2"), Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo13X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo13Y)
            Imp.Escribe(CDec(Fact.Tables(0).Rows(0)("Total")).ToString("N2"), Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo14X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo14Y)

            Dim TotalLetra As String = ConvertirNumeroALetraClass.Convertir(Fact.Tables(0).Rows(0)("Total"), TipoMonedaEnum.Peso)

            Try
                If TotalLetra.Length > Controlador.Configuracion.SeleccionActualConfiguracionFactura.NumeroLetrasXFilaCantidadLetra Then
                    Dim separado As String() = TotalLetra.Split(" ")
                    Dim partes As New List(Of String)

                    For Each palabra As String In separado
                        If partes.Count = 0 Then
                            partes.Add(palabra)
                            Continue For
                        End If

                        If (partes(partes.Count - 1).Length + palabra.Length) > Controlador.Configuracion.SeleccionActualConfiguracionFactura.NumeroLetrasXFilaCantidadLetra Then
                            partes.Add(palabra)
                        Else
                            partes(partes.Count - 1) &= " " & palabra.Trim
                        End If
                    Next

                    For i As Integer = 0 To partes.Count - 1
                        Imp.Escribe(partes(i), Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo15X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo15Y + i)
                    Next
                Else
                    Imp.Escribe(TotalLetra, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo15X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo15Y)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'Imp.Escribe(ConvertirNumeroALetraClass.Convertir(Fact.Tables(0).Rows(0)("Total"), TipoMonedaEnum.Peso), ConF(0).Campo15X, ConF(0).Campo15Y)
            ' ''total a pagar
            If Not Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo16X = 0 And Not Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo16Y = 0 Then
                Imp.Escribe(Me.dtpFechaVencimiento.Value.ToString("dd {1} MMMM {1} yyyy").Replace("{1}", "de"), Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo16X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo16Y)
            End If

            If Not Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo17X = 0 And Not Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo17Y = 0 Then
                Imp.Escribe(CDec(Fact.Tables(0).Rows(0)("Total")).ToString("N2"), Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo17X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo17Y)
            End If

            If Not Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo18X = 0 And Not Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo18Y = 0 Then
                Try
                    If TotalLetra.Length > Controlador.Configuracion.SeleccionActualConfiguracionFactura.LetrasXrenglonDelTotalEnLetraPagare Then
                        Dim separado As String() = TotalLetra.Split(" ")
                        Dim partes As New List(Of String)

                        For Each palabra As String In separado
                            If partes.Count = 0 Then
                                partes.Add(palabra)
                                Continue For
                            End If

                            If (partes(partes.Count - 1).Length + palabra.Length) > Controlador.Configuracion.SeleccionActualConfiguracionFactura.LetrasXrenglonDelTotalEnLetraPagare Then
                                partes.Add(palabra)
                            Else
                                partes(partes.Count - 1) &= " " & palabra.Trim
                            End If
                        Next

                        For i As Integer = 0 To partes.Count - 1
                            Imp.Escribe(partes(i), Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo18X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo18Y + i)
                        Next
                    Else
                        Imp.Escribe(TotalLetra, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo18X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo18Y)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

            If Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo19X <> 0 And Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo19Y = 0 Then
                Imp.Escribe(Me.txtTotal.Text, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo19X, Controlador.Configuracion.SeleccionActualConfiguracionFactura.Campo19Y)
            End If

#If CONFIG = "Debug" Then
            System.IO.File.Create("c:\archivo.txt").Close()
            Imp.ImprimeA("c:\archivo.txt")
#Else
            Imp.Imprime()
#End If

            Fact = Nothing

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub Habilitar()
        Me.txtFolioEmbarque.Enabled = True
        'Me.txtFolioFactura.Enabled = True
        Me.dtFechaFactura.Enabled = True
        Me.dtpFechaVencimiento.Enabled = True
        Me.txtCodigoCliente.Enabled = True
        Me.txtCliente.Enabled = True
        Me.txtDireccion.Enabled = True
        Me.txtRFC.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.txtDiasCredito.Enabled = True
        Me.rdContado.Enabled = True
        Me.rdCredito.Enabled = True
        Me.ChkVarios.Enabled = True
        Me.ultcmbDomiciliosFiscales.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        Me.txtFolioEmbarque.Enabled = False
        Me.txtFolioFactura.ReadOnly = True
        Me.dtFechaFactura.Enabled = False
        Me.dtpFechaVencimiento.Enabled = False
        Me.txtCodigoCliente.Enabled = False
        Me.txtCliente.Enabled = False
        Me.txtDireccion.Enabled = False
        Me.txtRFC.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.txtDiasCredito.Enabled = False
        Me.rdContado.Enabled = False
        Me.rdCredito.Enabled = False
        Me.ChkVarios.Enabled = False
        Me.CmbClientesVarios.Enabled = False
        Me.ultcmbDomiciliosFiscales.Enabled = False
    End Sub

    Private Sub PasarDatosAGridDetalle()
        Try
            For i As Integer = 0 To Me.dgvDetalleConcentrado.Rows.Count - 1
                For j As Integer = 0 To Me.dgvDetalle.Rows.Count - 1
                    If Me.dgvDetalle.Rows(j).Cells("Corte").Value = Me.dgvDetalleConcentrado.Rows(i).Cells("Descripcion").Value Then
                        Me.dgvDetalle.Rows(j).Cells("PrecioUnitario").Value = Me.dgvDetalleConcentrado.Rows(i).Cells("Precios").Value
                    End If
                Next
            Next
            Dim SubTotal As Decimal = 0.0
            Dim ImporteIVA As Decimal = 0.0
            Dim Total As Decimal = 0.0
            For i As Integer = 0 To Me.dgvDetalle.Rows.Count - 1
                Me.dgvDetalle.Rows(i).Cells("Importe").Value = Me.dgvDetalle.Rows(i).Cells("Kilos").Value * Me.dgvDetalle.Rows(i).Cells("PrecioUnitario").Value
                Me.dgvDetalle.Rows(i).Cells("ImporteIVA").Value = (Me.dgvDetalle.Rows(i).Cells("IVA").Value / 100) * Me.dgvDetalle.Rows(i).Cells("Importe").Value
                Me.dgvDetalle.Rows(i).Cells("Importe").Value = Me.dgvDetalle.Rows(i).Cells("Importe").Value + Me.dgvDetalle.Rows(i).Cells("ImporteIVA").Value
                'Total = Me.dgvDetalle.Rows(i).Cells("Importe").Value + Total
                'ImporteIVA = Me.dgvDetalle.Rows(i).Cells("ImporteIVA").Value + ImporteIVA
                'Me.txtIVA.Text = ImporteIVA.ToString("C2")
                'Me.txtTotal.Text = Total.ToString("C2")
                'SubTotal = Me.dgvDetalle.Rows(i).Cells("Importe").Value + SubTotal
                'Me.txtSubTotal.Text = SubTotal.ToString("C2")
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function Cancelacion() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
        Dim EmbarqueDetalles As New CC.MfacEmbarquesDetCollection

        Try
            'variables para el regreso de los obtener en dataset y datatable
            'Dim TablaConfiguracionCuentas As DataTable
            Dim PolizaCab As New PolizaClass

            'datos para el cabecero de factura.
            FacturasCab.NoFactura = Me.txtFolioFactura.Text
            FacturasCab.FechaCaptura = Now
            FacturasCab.FechaFactura = Me.dtFechaFactura.Value
            FacturasCab.FechaVencimiento = Me.dtpFechaVencimiento.Value
            FacturasCab.IdCliente = Me.txtCodigoCliente.Text
            FacturasCab.Contado = Me.rdContado.Checked
            FacturasCab.Credito = Me.rdCredito.Checked
            FacturasCab.Contabilizado = "N"
            FacturasCab.IdPoliza = 0
            FacturasCab.FechaContabilizacion = Now
            FacturasCab.IVA = Me.txtIVA.Text
            FacturasCab.SubTotal = Me.txtSubTotal.Text
            FacturasCab.Total = Me.txtTotal.Text
            FacturasCab.Estatus = "X"
            FacturasCab.Observaciones = Me.txtObservaciones.Text
            FacturasCab.IdClienteCargo = 0
            FacturasCab.Func = "M"
            FacturasCab.NumOpc = 3
            FacturasCab.FechaCancelacion = DateTime.Now
            FacturasCab.IdUsuarioCancela = Controlador.Sesion.MiUsuario.Usrndx
            FacturasCab.TipoFactura = 0

            If Not FacturasCab.Guardar(Trans) Then
                MessageBox.Show("Cabecero Factura", "", MessageBoxButtons.OK)
                Trans.Rollback()
                Return False
            End If

            Trans.Add(EmbarqueDetalles)
            EmbarqueDetalles.GetMulti(HC.MfacEmbarquesDetFields.NoFactura = Me.txtFolioFactura.Text)

            For Each EmbDet As EC.MfacEmbarquesDetEntity In EmbarqueDetalles
                EmbDet.NoFactura = ""
                EmbDet.Estatus = "V"
            Next
            EmbarqueDetalles.SaveMulti()

            For Each Item As ListViewItem In lvEmbarques.Items
                Dim Embarques As New CC.MfacEmbarquesCabCollection

                Trans.Add(Embarques)
                Embarques.GetMulti(HC.MfacEmbarquesCabFields.IdFolioEmbarque = Item.Text)

                For Each emb As EC.MfacEmbarquesCabEntity In Embarques
                    emb.Estatus = "V"
                Next
                Embarques.SaveMulti()
            Next

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
            PolizaCab.Concepto = "Póliza de cancelación de venta de cortes,productos con factura " & Me.txtFolioFactura.Text & " del cliente " & Me.txtCodigoCliente.Text
            PolizaCab.EmpresaId = Controlador.Sesion.MiEmpresa.Empndx
            PolizaCab.Estatus = PolizaEstatusEnum.ACTIVA
            PolizaCab.FechaCaptura = Now
            PolizaCab.FechaPoliza = Now
            PolizaCab.Importe = Me.txtTotal.Text
            PolizaCab.Mes = Month(Now)
            PolizaCab.Origen = PolizaOrigenEnum.VENTAS
            PolizaCab.TipoCambio = 1
            PolizaCab.TipoError = ErroresPolizaEnum.NINGUNO
            PolizaCab.TipoPoliza = PolizaTipoPolizaEnum.CANCELACION

            Dim PolizasDetalle As New CC.PolizaDetalleCollection
            Dim PolizaDet As New PolizaDetalleClass

            PolizasDetalle.GetMulti(HC.PolizaDetalleFields.PolizaId = FacturasCab.IdPoliza)

            For Each PolizaDetalle As EC.PolizaDetalleEntity In PolizasDetalle
                PolizaDet.IdCuentaContable = PolizaDetalle.CuentaContableId
                PolizaDet.Importe = PolizaDetalle.Importe
                PolizaDet.Operacion = CType(IIf(PolizaDetalle.OperacionCa = "C", PolizaOperacionEnum.ABONO, PolizaOperacionEnum.CARGO), PolizaOperacionEnum)
                PolizaDet.Posicion = PolizaDetalle.Posicion
                PolizaCab.Detalles2.Add(PolizaDet)
            Next

            If PolizaCab.Detalles2.Count = 0 Then
                PolizaCab.TipoError = ClasesNegocio.ErroresPolizaEnum.NO_SE_ENCONTRO_EL_DETALLE_DE_LA_POLIZA
            End If

            If Not PolizaCab.Guardar2(Trans) Then
                Trans.Rollback()
                MessageBox.Show("La Póliza no ha sido grabada ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Trans.Commit()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Trans.Rollback()
            Return False
        End Try
    End Function

    Private Sub ObtenerEmbarque(Optional ByVal SelConfiguracionFactura As Boolean = True)
        Dim RenglonesEnEmbarque As Integer = 0

        Try
            If SelConfiguracionFactura Then

                If Controlador.Configuracion.Venta.Count > 1 Then
                    Dim seleccionarCOnfiguracion As New frmSeleccionConfiguracionFactura

                    If seleccionarCOnfiguracion.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Controlador.Configuracion.SeleccionarConfiguracionFactura(seleccionarCOnfiguracion.ConfiguracionSeleccionada.IdConfiguracion)
                    Else
                        MsgBox("Debe seleccionar una configuración", MsgBoxStyle.Exclamation, "Seleccione una Configuración")
                        Exit Sub
                    End If
               ' ElseIf Controlador.Configuracion.Venta.Count = 1 Then
                    Controlador.Configuracion.SeleccionarConfiguracionFactura(Controlador.Configuracion.Venta(0).IdConfiguracion)
                    'Else
                    '  MessageBox.Show("Debe registrar previamente una configuracion de factura", Controlador.Sesion.MiEmpresa.Empnom)
                    ' Exit Sub
                End If
            End If

            'buscar el numero de renglones por factura para dividir los embarques que se facturaran en mas
            'de una factura                 
            Dim Resultado As Double

            'Dim emb As New EC.MfacEmbarquesCabEntity(Me.txtFolioEmbarque.Text)

            'llena el concentrado de importes para la factura
            Dim cont As Integer

            cont = 0

            For i As Integer = 0 To Me.lvEmbarques.Items.Count - 1
                Dim emb As New EC.MfacEmbarquesCabEntity(Me.lvEmbarques.Items(i).Text)
                Dim TablaEmbarque2 As DataSet = Integralab.ORM.StoredProcedureCallerClasses.RetrievalProcedures.UspConMfacEmbarquesDet(4, Me.lvEmbarques.Items(i).Text, emb.IdCliente, emb.IdPuntoEntrega)
                Dim productosSinPrecio As String = ""
                Dim band As Boolean, PreciosEspecificados As Boolean = True

                For Each row As DataRow In TablaEmbarque2.Tables(0).Rows
                    If CDec(row("PrecioxKgr")) = 0D Then
                        productosSinPrecio &= row("Corte").ToString.Trim & ", "
                    End If
                Next

                If Not productosSinPrecio.Trim.Length = 0 Then
                    productosSinPrecio = productosSinPrecio.Substring(0, productosSinPrecio.Trim.Length - 1)
                    MsgBox("Los siguientes productos, cajas o canales no tienen precio" & vbNewLine & productosSinPrecio, MsgBoxStyle.Exclamation, "Aviso")
                    Exit Sub
                End If

                RenglonesEnEmbarque += TablaEmbarque2.Tables(0).Rows.Count

                If RenglonesEnEmbarque = 0 Then
                    MessageBox.Show("Este embarque ya ha sido facturado", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Limpiar()
                    Me.MEAToolBar1.sbCambiarEstadoBotones("Cancelar")
                    Exit Sub
                End If

                'sacar el numero de facturas a imprimir por embarque
                ' If RenglonesEnEmbarque <= Controlador.Configuracion.SeleccionActualConfiguracionFactura.Renglones Then
                '    NumerodeFacturas = 1
                ' Else
                '  Resultado = RenglonesEnEmbarque Mod Controlador.Configuracion.SeleccionActualConfiguracionFactura.Renglones

                ' If Resultado > 0 Then
                '   NumerodeFacturas = (RenglonesEnEmbarque / Controlador.Configuracion.SeleccionActualConfiguracionFactura.Renglones) + 1
                ' Else
                '  NumerodeFacturas = (RenglonesEnEmbarque / Controlador.Configuracion.SeleccionActualConfiguracionFactura.Renglones) + 1
                ' End If
                'End If

                Me.dgvDetalleConcentrado.AutoGenerateColumns = False

                For j As Integer = 0 To TablaEmbarque2.Tables(0).Rows.Count - 1
                    band = False

                    If Me.dgvDetalle.Rows.Count > -1 Then
                        For k As Integer = 0 To Me.dgvDetalleConcentrado.Rows.Count - 1
                            If Me.dgvDetalleConcentrado.Rows(k).Cells(Me.Codigo.Index).Value = TablaEmbarque2.Tables(0).Rows(j)("Codigo") Then
                                Dim Importe As Decimal = TablaEmbarque2.Tables(0).Rows(j)("ImporteFacturar")

                                Controlador.Configuracion.Produccion.ObtenerEntidad.Refetch()

                                If Controlador.Configuracion.Produccion.ReferenciarPrecioEmbarqueEnFacturacion AndAlso Not IsDBNull(TablaEmbarque2.Tables(0).Rows(j)("ImporteEmbarque")) Then
                                    Importe = Me.dgvDetalleConcentrado.Rows(k).Cells(Me.Precios.Index).Value * TablaEmbarque2.Tables(0).Rows(j)("Kilos")
                                ElseIf Controlador.Configuracion.Produccion.ReferenciarPrecioEmbarqueEnFacturacion AndAlso PreciosEspecificados Then
                                    PreciosEspecificados = False
                                End If

                                Me.dgvDetalleConcentrado.Rows(k).Cells(Me.KilosEmbarcados.Index).Value += TablaEmbarque2.Tables(0).Rows(j)("Kilos")
                                Me.dgvDetalleConcentrado.Rows(k).Cells(Me.ImporteEmbarcado.Index).Value += Importe
                                Me.dgvDetalleConcentrado.Rows(k).Cells(Me.ImporteFacturado.Index).Value += Importe
                                Me.dgvDetalleConcentrado.Rows(k).Cells(Me.KilosFacturados.Index).Value += TablaEmbarque2.Tables(0).Rows(j)("KilosFacturar")
                                Me.dgvDetalleConcentrado.Rows(k).Cells(Me.clmPiezas.Index).Value += TablaEmbarque2.Tables(0).Rows(j)("Piezas")
                                band = True
                            End If
                        Next
                    End If

                    If Not band Then
                        Dim Precio As Decimal = TablaEmbarque2.Tables(0).Rows(j)("PrecioxKgr"), Importe As Decimal = TablaEmbarque2.Tables(0).Rows(j)("ImporteFacturar")

                        Controlador.Configuracion.Produccion.ObtenerEntidad.Refetch()

                        If Controlador.Configuracion.Produccion.ReferenciarPrecioEmbarqueEnFacturacion AndAlso Not IsDBNull(TablaEmbarque2.Tables(0).Rows(j)("PrecioEmbarque")) Then
                            Precio = TablaEmbarque2.Tables(0).Rows(j)("PrecioEmbarque")
                            Importe = TablaEmbarque2.Tables(0).Rows(j)("ImporteEmbarque")
                        ElseIf Controlador.Configuracion.Produccion.ReferenciarPrecioEmbarqueEnFacturacion AndAlso PreciosEspecificados Then
                            PreciosEspecificados = False
                        End If

                        Me.dgvDetalleConcentrado.Rows.Add(1)
                        Me.dgvDetalleConcentrado.Rows(cont).Cells(Me.Codigo.Index).Value = TablaEmbarque2.Tables(0).Rows(j)("Codigo")
                        Me.dgvDetalleConcentrado.Rows(cont).Cells(Me.Descripcion.Index).Value = TablaEmbarque2.Tables(0).Rows(j)("Corte")
                        Me.dgvDetalleConcentrado.Rows(cont).Cells(Me.KilosEmbarcados.Index).Value = TablaEmbarque2.Tables(0).Rows(j)("Kilos")
                        Me.dgvDetalleConcentrado.Rows(cont).Cells(Me.Precios.Index).Value = Precio
                        Me.dgvDetalleConcentrado.Rows(cont).Cells(Me.clmPrecioReal.Index).Value = Precio
                        Me.dgvDetalleConcentrado.Rows(cont).Cells(Me.ImporteEmbarcado.Index).Value = Importe
                        Me.dgvDetalleConcentrado.Rows(cont).Cells(Me.ImporteFacturado.Index).Value = Importe
                        Me.dgvDetalleConcentrado.Rows(cont).Cells(Me.KilosFacturados.Index).Value = TablaEmbarque2.Tables(0).Rows(j)("KilosFacturar")
                        Me.dgvDetalleConcentrado.Rows(cont).Cells(Me.clmPiezas.Index).Value = TablaEmbarque2.Tables(0).Rows(j)("Piezas")
                        cont += 1
                    End If
                    'Me.dgvDetalleConcentrado.DataSource = TablaEmbarque2.Tables(0)
                    'Me.Codigo.DataPropertyName = "Codigo"
                    'Me.Descripcion.DataPropertyName = "Corte"
                    'Me.KilosEmbarcados.DataPropertyName = "Kilos"
                    'Me.Precios.DataPropertyName = "PrecioxKgr"
                    'Me.ImporteEmbarcado.DataPropertyName = "Totales"
                    'Me.ImporteFacturado.DataPropertyName = "ImporteFacturar"
                    'Me.KilosFacturados.DataPropertyName = "KilosFacturar"
                Next

                If Not PreciosEspecificados Then
                    MessageBox.Show("Algunos precios del embarque:" & emb.IdFolioEmbarque & " no se establecieron." & vbNewLine & "El sistema tomara los actuales", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                'If Me.dgvDetalleConcentrado.Rows.Count > Controlador.Configuracion.SeleccionActualConfiguracionFactura.Renglones Then
                '  For j As Integer = Controlador.Configuracion.SeleccionActualConfiguracionFactura.Renglones To Me.dgvDetalleConcentrado.Rows.Count - 1
                'Me.dgvDetalleConcentrado.Rows(j).Visible = False
                ' Next
                '  End If

            Next

            Dim Piezas As Integer = 0, Kilos As Decimal = 0D

            For k As Integer = 0 To Me.dgvDetalleConcentrado.Rows.Count - 1
                If Me.dgvDetalleConcentrado.Rows(k).Visible Then
                    Me.txtSubTotal.Text += Me.dgvDetalleConcentrado.Rows(k).Cells(Me.ImporteFacturado.Index).Value
                    Me.txtTotal.Text += Me.dgvDetalleConcentrado.Rows(k).Cells(Me.ImporteFacturado.Index).Value
                    Me.txtSubTotal.Text = CDbl(Me.txtSubTotal.Text).ToString("C2")
                    Me.txtTotal.Text = CDbl(Me.txtTotal.Text).ToString("C2")
                    Piezas += Integer.Parse(Me.dgvDetalleConcentrado.Rows(k).Cells(Me.clmPiezas.Index).Value)
                    Kilos += Decimal.Parse(Me.dgvDetalleConcentrado.Rows(k).Cells(Me.KilosFacturados.Index).Value)
                End If
            Next
            txtPiezas.Text = Piezas
            txtKgrs.Text = Kilos.ToString("N2")
            Me.txtFolioFactura.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidarCambiosPrecios() As Boolean
        Dim ventanaAutorizacion As New frmAutorizacionCambioPrecio
        Dim cont As Integer = 0

        With ventanaAutorizacion
            For Each row As DataGridViewRow In Me.dgvDetalleConcentrado.Rows
                If CDec(row.Cells(Me.clmPrecioReal.Index).Value) > CDec(row.Cells(Me.Precios.Index).Value) Then
                    .ListView1.Items.Add(row.Cells(Me.Descripcion.Index).Value.ToString.Trim)
                    .ListView1.Items(cont).SubItems.Add(CDec(row.Cells(Me.clmPrecioReal.Index).Value).ToString("C2"))
                    .ListView1.Items(cont).SubItems.Add(CDec(row.Cells(Me.Precios.Index).Value).ToString("C2"))

                    cont += 1
                End If
            Next

            Return .ListView1.Items.Count = 0 OrElse ventanaAutorizacion.ShowDialog = Windows.Forms.DialogResult.OK
        End With
    End Function

    Private Function MostrarEmbarques() As Boolean
        Dim Consultas As New MConsEmbarques(True)
        Dim ListaEmbarques As New List(Of String)
        Dim estatus As String

        Consultas.EstatusDefault(True) = EstatusCharX.VIGENTE

        If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim FechaMenor As Date = CType(Consultas.DgvEmbarques.SelectedRows(0).Cells(Consultas.Fecha.Index).Value, Date)

            For i As Integer = 0 To Consultas.DgvEmbarques.SelectedRows.Count - 1
                ListaEmbarques.Add(Consultas.DgvEmbarques.SelectedRows(i).Cells("IdFolioEmbarque").Value)

                If FechaMenor.Ticks > CType(Consultas.DgvEmbarques.SelectedRows(i).Cells(Consultas.Fecha.Index).Value, Date).Ticks Then
                    FechaMenor = CType(Consultas.DgvEmbarques.SelectedRows(i).Cells(Consultas.Fecha.Index).Value, Date)
                End If
            Next

            Me.dtFechaFactura.Value = FechaMenor
            Me.txtFolioEmbarque.Text = ListaEmbarques.Item(0) 'Consultas.DgvEmbarques.CurrentRow.Cells("IdFolioEmbarque").Value
            Me.txtCliente.Text = Consultas.DgvEmbarques.CurrentRow.Cells("Cliente").Value
            Me.txtCodigoCliente.Text = Consultas.DgvEmbarques.CurrentRow.Cells("ClmIdCliente").Value
            Me.txtDireccion.Text = Consultas.DgvEmbarques.CurrentRow.Cells("Domicilio").Value
            Me.txtRFC.Text = Consultas.DgvEmbarques.CurrentRow.Cells("RFC").Value
            estatus = Consultas.DgvEmbarques.CurrentRow.Cells("clmEstatus").Value

            If estatus = "FACTURADO" Then
                MsgBox("Embarque Facturado", MsgBoxStyle.OkOnly, Controlador.Sesion.MiEmpresa.Empnom)
                Return False
            End If
            '-----------------------------------------------
            ' Si el cliente es un cliente Vario.....
            'Dim Clientes As New ClasesNegocio.ClientesIntroductoresColeccion
            'Clientes.Obtener(True, CondicionEstatusEnum.ACTIVO, CInt(Me.txtCodigoCliente.Text))
            'If Clientes.Count > 0 Then
            '    Me.CmbClientesVarios.Visible = True
            '    RellenarClientesVarios()
            'Else
            '    Me.CmbClientesVarios.Visible = False
            'End If
            Dim emb As New EC.MfacEmbarquesCabEntity(Me.txtFolioEmbarque.Text)

            'llena los datos del detalle de cada etiqueta

            For i As Integer = 0 To ListaEmbarques.Count - 1
                'Dim TablaEmbarque1 As DataSet = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures.UspConMfacEmbarquesDet(3, Me.txtFolioEmbarque.Text, CInt(Consultas.DgvEmbarques.CurrentRow.Cells("ClmIdCliente").Value), emb.IdPuntoEntrega)
                Me.lvEmbarques.Items.Add(ListaEmbarques.Item(i))
                Dim TablaEmbarque1 As DataSet = Integralab.ORM.StoredProcedureCallerClasses.RetrievalProcedures.UspConMfacEmbarquesDet(3, ListaEmbarques.Item(i), CInt(Me.txtCodigoCliente.Text), emb.IdPuntoEntrega)
                If TablaEmbarque1.Tables(0).Rows.Count = 0 Then
                    'MessageBox.Show("No existen precios para este destino del cliente", "Error", MessageBoxButtons.OK)
                Else
                    Me.dgvDetalle.Rows.Add(TablaEmbarque1.Tables(0).Rows.Count)
                    For j As Integer = 0 To TablaEmbarque1.Tables(0).Rows.Count - 1
                        Me.dgvDetalle.Rows(j).Cells(Me.Etiqueta.Index).Value = TablaEmbarque1.Tables(0).Rows(j)("IdFolioEtiqueta")
                        Me.dgvDetalle.Rows(j).Cells(Me.Corte.Index).Value = TablaEmbarque1.Tables(0).Rows(j)("Descripcion")
                        Me.dgvDetalle.Rows(j).Cells(Me.Piezas.Index).Value = TablaEmbarque1.Tables(0).Rows(j)("CantPzas")
                        Me.dgvDetalle.Rows(j).Cells(Me.Kilos.Index).Value = TablaEmbarque1.Tables(0).Rows(j)("CantKgrs")
                        Me.dgvDetalle.Rows(j).Cells(Me.PrecioUnitario.Index).Value = TablaEmbarque1.Tables(0).Rows(j)("PrecioxKgr")
                        Me.dgvDetalle.Rows(j).Cells(Me.IVA.Index).Value = TablaEmbarque1.Tables(0).Rows(j)("IVA")
                        Me.dgvDetalle.Rows(j).Cells(Me.Importe.Index).Value = TablaEmbarque1.Tables(0).Rows(j)("Importe")


                    Next
                    txtCajas.Text = TablaEmbarque1.Tables(0).Rows.Count
                    'Me.dgvDetalle.DataSource = TablaEmbarque1.Tables(0)
                    'Me.Etiqueta.DataPropertyName = "IdFolioEtiqueta"
                    'Me.Corte.DataPropertyName = "Descripcion"
                    'Me.Piezas.DataPropertyName = "CantPzas"
                    'Me.Kilos.DataPropertyName = "CantKgrs"
                    'Me.PrecioUnitario.DataPropertyName = "PrecioxKgr"
                    'Me.IVA.DataPropertyName = "IVA"
                    'Me.Importe.DataPropertyName = "Importe"
                End If

            Next

            Cliente = New ClientesIntroductoresClass(New EC.MfacCatClientesEntity(CInt(Me.txtCodigoCliente.Text)))

            Me.txtDiasCredito.Text = Cliente.DiasCredito

            If Cliente.DiasCredito > 0 Then
                dtpFechaVencimiento.Value = dtFechaFactura.Value.AddDays(Cliente.DiasCredito)
                rdCredito.Checked = True
            End If

            Me.ultcmbDomiciliosFiscales.DataSource = Cliente.DomiciliosFiscales

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

            If Cliente.DomiciliosFiscales.Count = 1 Then
                ultcmbDomiciliosFiscales.Rows(0).Selected = True
            Else
                For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In ultcmbDomiciliosFiscales.Rows
                    If CType(Fila.Cells("IdRenglon").Value, Integer) = Cliente.DomicilioFiscalPrincipal.IdRenglon Then
                        Fila.Selected = True
                        Exit For
                    End If
                Next
            End If

            Me.ObtenerEmbarque()

            If lvEmbarques.Items.Count > 0 Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

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

    Private Sub llenarcombosgrid()
        Try
            Dim FormasPago As DataSet = New DataSet
            Dim queryString As String = "SELECT * FROM CatUnidadSAT"
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(queryString, HC.DbUtils.ActualConnectionString)
            adapter.Fill(FormasPago)
            Me.clmunidadsat.DataSource = FormasPago.Tables(0)
            Me.clmunidadsat.DisplayMember = "concepto"
            Me.clmunidadsat.ValueMember = "clave"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            Dim FormasPago As DataSet = New DataSet
            Dim queryString As String = "SELECT * FROM CatProdServSAT"
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(queryString, HC.DbUtils.ActualConnectionString)
            adapter.Fill(FormasPago)
            Me.clmproductoserv.DataSource = FormasPago.Tables(0)
            Me.clmproductoserv.DisplayMember = "concepto"
            Me.clmproductoserv.ValueMember = "clave"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub guardarfacturacion()
        Dim Fact As CFDI.Comprobante
        Dim DomFiscalCte As DomicilioClienteClass
        DomFiscalCte = DirectCast(ultcmbDomiciliosFiscales.SelectedRow.ListObject, DomicilioClienteClass)
        Cliente = New ClientesIntroductoresClass(txtCodigoCliente.Text)

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
        Domicilio.municipio = DomFiscalCte.Ciudad.Descripcion
        Domicilio.estado = DomFiscalCte.Estado.Descripcion
        Receptor.Nombre = Cliente.RazonSocial
        Receptor.UsoCFDI = CFDI.c_UsoCFDI.P01

        ''CONCEPTOS
        Dim Conceptos As New List(Of CFDI.ComprobanteConcepto)()




        ''RECORRER GRID
        For Each det As DataGridViewRow In dgvDetalleConcentrado.Rows

            Dim concepto As New CFDI.ComprobanteConcepto(CStr(det.Cells("clmproductoserv").Value), CStr(det.Cells("clmunidadsat").Value), CStr(det.Index + 1), CDec(det.Cells("KilosFacturados").Value), "KG", CStr(det.Cells("Descripcion").Value), CDec(det.Cells("Precios").Value), CDec(det.Cells("ImporteFacturado").Value))

            ''traslados 


            Dim traslado As New CFDI.ComprobanteConceptoImpuestosTraslado
            traslado.Base = "22500"
            traslado.Impuesto = "002"
            traslado.TipoFactor = CFDI.c_TipoFactor.Tasa
            traslado.TasaOCuota = 0.6
            traslado.Importe = 3600

            ''se agrega traslado a la lista
            Dim Traslados As New List(Of CFDI.ComprobanteConceptoImpuestosTraslado)
            Traslados.Add(traslado)
            ''comprobante
            Dim comprobanteconceptoimpuesto As New CFDI.ComprobanteConceptoImpuestos()
            comprobanteconceptoimpuesto.Traslados = Traslados
            ''concepto
            concepto.Impuestos = comprobanteconceptoimpuesto


            Conceptos.Add(concepto)
            ''

        Next


    End Sub


#End Region

#Region "Eventos"

    Private Sub txtFolioFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolioFactura.KeyPress, txtPoliza.KeyPress, ultcmbDomiciliosFiscales.KeyPress, txtCodigoCliente.KeyPress, txtCliente.KeyPress, dtpFechaVencimiento.KeyPress, dtFechaFactura.KeyPress, txtRFC.KeyPress, txtObservaciones.KeyPress, txtDireccion.KeyPress, CmbClientesVarios.KeyPress, ChkVarios.KeyPress, rdCredito.KeyPress, rdContado.KeyPress, dgvDetalleConcentrado.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            SendKeys.Send(Chr(Keys.Tab))
        End If
    End Sub

    Private Sub dgvDetalle_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalle.CellEndEdit
        Try
            Dim SubTotal As Decimal = 0.0
            Dim ImporteIVA As Decimal = 0.0
            Dim Total As Decimal = 0.0

            For i As Integer = 0 To Me.dgvDetalle.Rows.Count - 1
                Me.dgvDetalle.Rows(i).Cells("Importe").Value = Me.dgvDetalle.Rows(i).Cells("Kilos").Value * Me.dgvDetalle.Rows(i).Cells("PrecioUnitario").Value
                Me.dgvDetalle.Rows(i).Cells("ImporteIVA").Value = (Me.dgvDetalle.Rows(i).Cells("IVA").Value / 100) * Me.dgvDetalle.Rows(i).Cells("Importe").Value
                Me.dgvDetalle.Rows(i).Cells("Importe").Value = Me.dgvDetalle.Rows(i).Cells("Importe").Value + Me.dgvDetalle.Rows(i).Cells("ImporteIVA").Value
                Total = Me.dgvDetalle.Rows(i).Cells("Importe").Value + Total
                ImporteIVA = Me.dgvDetalle.Rows(i).Cells("ImporteIVA").Value + ImporteIVA
                Me.txtIVA.Text = ImporteIVA.ToString("C2")
                Me.txtTotal.Text = Total.ToString("C2")
                SubTotal = Me.dgvDetalle.Rows(i).Cells("Importe").Value + SubTotal
                Me.txtSubTotal.Text = SubTotal.ToString("C2")
                'Me.txtTotal.Text = (CDec(Me.txtSubTotal.Text) + CDec(Me.txtIVA.Text)).ToString("C2")
            Next
        Catch ex As Exception
            MessageBox.Show("No se permiten letras en esta celda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MFacRegFacturasVentas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.B

                Case Keys.N

                Case Keys.L

                Case Keys.C

                Case Keys.X

                Case Keys.E

                Case Keys.I

                Case Keys.S

            End Select
        End If
    End Sub

    Private Sub MFacRegFacturasVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            llenarcomboformasdepago()
            llenarcombometododepago()
            llenarcombosgrid()

            AddHandler pdDocumento.PrintPage, AddressOf Imprime_Documento

            Dim Relacion As New OC.RelationCollection

            Relacion.Add(EC.CfgCtrlCtasEntity.Relations.ConCfgCtasEntityUsingIdConCfgCtas)
            Me.CuentaControl.GetMulti(HC.ConCfgCtasFields.Concepto = "VENTA DE PRODUCTOS", 0, Nothing, Relacion)

            Me.dgvDetalle.AutoGenerateColumns = False

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
        Dim Vigentes As Boolean = False
        Me.Estado = FormState.Borrar
        Cancelar = True

        For Each Pago As PagosDeClientesClass In FacturasCab.Pagos
            If Pago.Estatus = EstatusChar.VIGENTE Then
                Vigentes = True
                Exit For
            End If
        Next

        If Vigentes Then
            MessageBox.Show("La Factura tiene pagos vigentes, no es posible cancelarla", "Aviso", MessageBoxButtons.OK)
        ElseIf MessageBox.Show("¿Esta seguro de cancelar esta factura?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If Cancelacion() Then
                Cancelar = False
                MessageBox.Show("Se Canceló Factura " & Me.txtFolioFactura.Text, "Aviso", MessageBoxButtons.OK)
                Me.Limpiar()
                Deshabilitar()
                Me.MEAToolBar1.sbCambiarEstadoBotones("Cancelar")
            End If
        End If
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Me.Estado = FormState.Buscar
        Cancelar = Not Buscar()
        Deshabilitar()

        If Not Cancelar Then
            ultcmbDomiciliosFiscales.Enabled = True
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
            ultcmbDomiciliosFiscales.Enabled = False
        Else
            MessageBox.Show("No se puede modificar el folio de una factura abonada, pagada o cancelada", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Cancelar = True
        End If
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickGuardar
        guardarfacturacion()
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir
        Me.Estado = FormState.Imprimir
        Dim conRFC As Boolean = True

        If Me.ultcmbDomiciliosFiscales.SelectedRow Is Nothing Then
            MsgBox("Debe seleccionar el domicilio fiscal", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Cancelar = True
            Exit Sub
        End If

        If Controlador.Configuracion.Venta.Count > 1 Then
            Dim seleccionarCOnfiguracion As New frmSeleccionConfiguracionFactura

            If seleccionarCOnfiguracion.ShowDialog = Windows.Forms.DialogResult.OK Then
                Controlador.Configuracion.SeleccionarConfiguracionFactura(seleccionarCOnfiguracion.ConfiguracionSeleccionada.IdConfiguracion)
            Else
                MsgBox("Debe seleccionar una configuración", MsgBoxStyle.Exclamation, "Seleccione una Configuración")
                Exit Sub
            End If
        ElseIf Controlador.Configuracion.Venta.Count = 1 Then
            Controlador.Configuracion.SeleccionarConfiguracionFactura(Controlador.Configuracion.Venta(0).IdConfiguracion)
        Else
            MessageBox.Show("Debe registrar previamente una configuracion de factura", Controlador.Sesion.MiEmpresa.Empnom)
            Exit Sub
        End If

        'buscar el numero de renglones por factura para dividir los embarques que se facturaran en mas
        'de una factura                 

        If MessageBox.Show("¿Desea imprimirlo con RFC?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            conRFC = False
        End If

        Me.Imprimir(CType(ultcmbDomiciliosFiscales.SelectedRow.ListObject, DomicilioClienteClass), conRFC)
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

        If MostrarEmbarques() Then
            txtFolioEmbarque.Focus()
            txtFolioFactura.Text = Controlador.Configuracion.FacturaFolios.MostrarFolio
        Else
            MEAToolBar1_ClickCancelar(sender, New ToolBarButtonClickEventArgs(MEAToolBar1.Buttons("tbbtnCancelar")), Cancelar)
            Cancelar = True
        End If
    End Sub

    Private Sub dgvDetalleConcentrado_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleConcentrado.CellEndEdit
        Try
            If Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.KilosFacturados.Index).Value IsNot Nothing Then
                Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.KilosFacturados.Index).Value = CType(Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.KilosFacturados.Index).Value, Decimal)

                If Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.Precios.Index).Value IsNot Nothing Then
                    Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.Precios.Index).Value = CType(Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.Precios.Index).Value, Decimal)
                    Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.ImporteFacturado.Index).Value = Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.KilosFacturados.Index).Value * Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.Precios.Index).Value
                    Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.ImporteEmbarcado.Index).Value = Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.KilosEmbarcados.Index).Value * Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.Precios.Index).Value
                End If
            Else
                Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.ImporteFacturado.Index).Value = Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.KilosFacturados.Index).Value * Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.Precios.Index).Value
                Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.ImporteEmbarcado.Index).Value = Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.KilosEmbarcados.Index).Value * Me.dgvDetalleConcentrado.CurrentRow.Cells(Me.Precios.Index).Value
            End If

            PasarDatosAGridDetalle()

            Dim SubTotal As Decimal = 0D, Total As Decimal = 0D, Kilos As Decimal = 0D, Piezas As Integer = 0

            For i As Integer = 0 To Me.dgvDetalleConcentrado.Rows.Count - 1
                Total += Me.dgvDetalleConcentrado.Rows(i).Cells("ImporteFacturado").Value
                SubTotal += Me.dgvDetalleConcentrado.Rows(i).Cells("ImporteFacturado").Value
                Piezas += Me.dgvDetalleConcentrado.Rows(i).Cells(clmPiezas.Index).Value

                If Me.dgvDetalleConcentrado.Rows(i).Cells(KilosFacturados.Index).Value IsNot Nothing Then
                    Kilos += Me.dgvDetalleConcentrado.Rows(i).Cells(KilosFacturados.Index).Value
                End If

                Me.txtTotal.Text = Total.ToString("C2")
                Me.txtSubTotal.Text = SubTotal.ToString("C2")
            Next
            txtPiezas.Text = Piezas
            txtKgrs.Text = Kilos.ToString("N2")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ChkVarios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkVarios.CheckedChanged
        If ChkVarios.Checked Then
            Me.CmbClientesVarios.Enabled = True
            Me.RellenarClientesVarios()
        Else
            Me.CmbClientesVarios.Enabled = False
        End If
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Me.Estado = FormState.Salir
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Close()
    End Sub

    Private Sub ultcmbDomiciliosFiscales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ultcmbDomiciliosFiscales.KeyDown
        If Me.Estado = FormState.Nuevo Or Me.Estado = FormState.Buscar Then
            If e.KeyCode = Keys.F12 And Cliente IsNot Nothing Then
                Cliente.ActualizarDomiciliosFiscales()
                Me.ultcmbDomiciliosFiscales.DataSource = Cliente.DomiciliosFiscales

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

                If Cliente.DomiciliosFiscales.Count = 1 Then
                    ultcmbDomiciliosFiscales.Rows(0).Selected = True
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
        Controlador.Configuracion.ActualizarFacturaFolios(1)
        txtFolioFactura.Text = Controlador.Configuracion.FacturaFolios.MostrarFolio
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



End Class