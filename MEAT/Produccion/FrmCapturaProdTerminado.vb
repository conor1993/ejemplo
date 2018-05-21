Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Imports BC = BarcodeLib
Imports BRC = BarCode
Imports System.IO
Imports System.Drawing.Text

Imports System
Imports System.IO.Ports
Imports System.Data.SqlClient

Public Class FrmCapturaProdTerminado

    Private diccionario As New Dictionary(Of String, String)()
    'Private totalkilosproductos As New Double()
    'Private totalPiezas As New Dictionary(Of String, Integer)()
    'Private piezasRegistradas As New Dictionary(Of String, Integer)()

#Region "Miembros"
    Private LoteCorte As New CortesClass
    Private WithEvents LoteCorteDetalle As New CortesDetalleClass
    'variables para las clases de almacen
    Private Almacen As New AlmacenProduccionClass
    Private AlmacenDetalle As New AlmacenDetalleClass
    Private Folio As New FoliosClass
    Private Inventario As New InventarioClass
    Private Productos As New ProductosClass
    Private nPag As Integer
    Private folioEtiqueta As String
    Private nombreIngles As String
    Private codBarras As String
    Private tipocorte As ClasesNegocio.TipoCorte
    Private valorAgregado As Boolean
    Private conHueso As Boolean
    Private prodSeleccionado As Boolean = False
    Private corte As EC.MscloteCortesDetEntity
    Private tempConservar As Integer
    Private mostarMensajes As Boolean = True
    Private CveProduto As String
    Private numcaja As Integer
    Private precioxkilo As Decimal
    Private kilosrecividos As Decimal
    Private kilostot As Decimal
#End Region

#Region "Metodos"
    Private Sub ConfigurarPuerto()

        txtLeerPeso.Port = validarPuerto() 'se obtiene el com disponible y se establece
        txtLeerPeso.BaudRate = 9600 '9600 bits por segundo
        txtLeerPeso.DataBit = 8  '8 bits de datos
        txtLeerPeso.StopBit = wclTextBoxSerial.Rs232.DataStopBit.StopBit_1 'Un bit de parada
        txtLeerPeso.Parity = wclTextBoxSerial.Rs232.DataParity.Parity_None 'No paridad
        txtLeerPeso.TimeOut = 1500 'Esperar 1500 milisegundos antes de considerar time out

        'Esperar 300 milisegundos para dar tiempo a que llegue un grupo de bytes.
        'A menor tiempo menor es el número de bytes que llegan en cada llamada del evento SerialDataArrived.
        'Por ejemplo un lector que envia 14 bytes podrian llegar en la primer llamada al evento 7 caracteres y 
        'en otra llamada otros 7. Dando mayor tiempo damos oportunidad a que lleguen los 14 bytes juntos.
        txtLeerPeso.TimeToWaitForMoreData = 500

        'Puede mostrar la información con formato Ascii, Hexadecimal o Decimal. 
        'Por ejemplo si se recibe la cadena HOLA la salida sería:
        'ASCII: HOLA
        'Decimal:  072079076065
        'Hexadecimal: 484F4C41
        txtLeerPeso.Format = wclTextBoxSerial.TextBoxSerial.FormatoDatos.Ascii 'Formato en que se mostrará la información
    End Sub

    Private Function validarPuerto() As Integer
        Dim test As New validacionDePuertos
        Dim seleccionarcombo As New Frmproduccionselecciondepuerto
        Dim numport As Integer
        numport = test.testsport()
        If numport = -1 Then
            If seleccionarcombo.ShowDialog = Windows.Forms.DialogResult.OK Then
                numport = seleccionarcombo.Puerto
            End If
        End If
        Return numport
    End Function

    'Private Sub Imprime_Documento(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
    '    Try
    '        'generadorCodigoBarra.Message = folioEtiqueta

    '        'e.PageSettings.PaperSize = New Printing.PaperSize("Etiqueta", 406, 500)
    '        'Dim f10 As New Font("Arial", 10) 'formato de impresion Arial tamaño 10
    '        'Dim fn10 As New Font("Arial", 10, FontStyle.Bold) 'formato de impresion Arial tamaño 10 Negrita
    '        Dim nombreProducto As String
    '        Dim codigoProducto As String
    '        'Dim agregarRenglon As Integer = 5

    '        If Me.cmbClientes.SelectedIndex > -1 Then
    '            Dim nombreProductoCliente As New EC.MscrelacionCortesClientesEntity
    '            nombreProducto = Me.txtSubCorte.Text
    '            codigoProducto = Me.txtCodSubCorte.Text
    '            'If nombreProductoCliente.FetchUsingPK(cmbClientes.SelectedValue, CInt(Me.txtCodSubCorte.Text)) Then
    '            '    nombreProducto = nombreProductoCliente.Descripcion
    '            '    codigoProducto = nombreProductoCliente.CodCorteCliente
    '            'Else
    '            '    nombreProducto = Me.txtSubCorte.Text
    '            '    codigoProducto = Me.txtCodSubCorte.Text
    '            'End If
    '        Else
    '            nombreProducto = Me.txtSubCorte.Text
    '            codigoProducto = Me.txtCodSubCorte.Text
    '        End If

    '        Dim f10 As New Font("Arial", 10) 'formato de impresion Arial tamaño 10
    '        Dim fn10 As New Font("Arial", 10, FontStyle.Bold) 'formato de impresion Arial tamaño 10 Negrita

    '        Dim agregarRenglon As Integer = 5

    '        e.Graphics.DrawString(nombreProducto, New Font("Arial", 18, FontStyle.Bold), Brushes.Black, 20, 11 + agregarRenglon)

    '        agregarRenglon += 15

    '        e.Graphics.DrawString(nombreIngles, New Font("Arial", 12), Brushes.Black, 20, 36 + agregarRenglon)
    '        e.Graphics.DrawString(IIf(Me.chkTipoCorte.Checked, "PRODUCTO CONGELADO/FROZEN", "PRODUCTO FRESCO/FRESH"), fn10, Brushes.Black, 20, 54 + agregarRenglon)

    '        e.Graphics.DrawString("BOLSAS", f10, Brushes.Black, 265, 54 + agregarRenglon)
    '        e.Graphics.DrawString(Me.txtPiezas.Text, New Font("Arial", 32, FontStyle.Bold), Brushes.Black, 275, 66 + agregarRenglon)

    '        e.Graphics.DrawString(Me.txtPeso.Text.Trim, New Font("Arial", 55, FontStyle.Bold), Brushes.Black, 20, 65 + agregarRenglon)
    '        e.Graphics.DrawString("Kgs.", New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 245, 115 + agregarRenglon)

    '        agregarRenglon += 5

    '        e.Graphics.DrawString(corte.CantLibras.GetValueOrDefault(0).ToString("N2"), New Font("Arial", 30, FontStyle.Bold), Brushes.Black, 20, 130 + agregarRenglon)
    '        e.Graphics.DrawString("Lbs.", New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 160, 150 + agregarRenglon)

    '        e.Graphics.DrawString("CODIGO:", f10, Brushes.Black, 20, 190 + agregarRenglon) '10
    '        e.Graphics.DrawString(codigoProducto, New Font("Arial", 16, FontStyle.Bold), Brushes.Black, 85, 185 + agregarRenglon) '15

    '        agregarRenglon -= 15

    '        e.Graphics.DrawString("EMPAQUE:", f10, Brushes.Black, 20, 226 + agregarRenglon)
    '        e.Graphics.DrawString("CADUCIDAD:", f10, Brushes.Black, 175, 226 + agregarRenglon)
    '        e.Graphics.DrawString(Me.dtpFechaCorte.Value.ToShortDateString, fn10, Brushes.Black, 95, 226 + agregarRenglon)
    '        e.Graphics.DrawString(Me.dtpFechaCaducidad.Value.ToShortDateString, fn10, Brushes.Black, 270, 226 + agregarRenglon)

    '        e.Graphics.DrawString("#", New Font("Wingdings 3", 30, FontStyle.Bold), Brushes.Black, 15, 255)
    '        e.Graphics.DrawImage(Me.codigobarras.Picture, 48, 246 + agregarRenglon, 275, 60)
    '        e.Graphics.DrawString("#", New Font("Wingdings 3", 30, FontStyle.Bold), Brushes.Black, 315, 255)

    '        e.Graphics.DrawString("LOTE:", f10, Brushes.Black, 20, 313 + agregarRenglon)
    '        e.Graphics.DrawString(Me.txtLoteCorte.Text, New Font("Arial", 16, FontStyle.Bold), Brushes.Black, 63, 308 + agregarRenglon)
    '        e.Graphics.DrawString("CONSERVAR A:", f10, Brushes.Black, 180, 313 + agregarRenglon)
    '        e.Graphics.DrawString(IIf(Me.chkTipoCorte.Checked, "-18°C", "4ºC"), fn10, Brushes.Black, 290, 313 + agregarRenglon)

    '        e.Graphics.DrawString("CVE PROV", f10, Brushes.Black, 20, 336 + agregarRenglon)
    '        e.Graphics.DrawString("PAIS ORIGEN", f10, Brushes.Black, 159, 336 + agregarRenglon) '40
    '        e.Graphics.DrawString("3010659", fn10, Brushes.Black, 20, 356 + agregarRenglon)
    '        e.Graphics.DrawString("MEXICO", fn10, Brushes.Black, 159, 356 + agregarRenglon) '45
    '        e.Graphics.DrawString(Controlador.Sesion.MiEmpresa.Empnom, f10, Brushes.Black, 20, 376 + agregarRenglon) '50

    '        Dim domicilio As String = Controlador.Sesion.MiEmpresa.EmpDomicilio
    '        Dim partes As New List(Of String)

    '        For Each palabra As String In domicilio.Split(" "c)
    '            If partes.Count = 0 Then
    '                partes.Add(palabra.Trim)
    '                Continue For
    '            End If

    '            If partes(partes.Count - 1).Trim.Length + palabra.Trim.Length > 37 Then
    '                partes.Add(palabra.Trim)
    '            Else
    '                partes(partes.Count - 1) &= " " & palabra.Trim
    '            End If
    '        Next

    '        For i As Integer = 0 To partes.Count - 1
    '            e.Graphics.DrawString(partes(i), f10, Brushes.Black, 20, 396 + agregarRenglon + i * 15)
    '        Next

    '        e.Graphics.DrawImage(Me.ListaImagenes.Images(1), 295, 360 + agregarRenglon, 100, 100)

    '        Me.codigobarras.ShowHRText = False

    '        Me.codigobarras.Rotation = TALBarCode.TALROTATEVALSENUM.bcClockwise_90
    '        e.Graphics.DrawImage(Me.codigobarras.Picture, 355, 67 + agregarRenglon, 30, 285)
    '        Me.codigobarras.Rotation = TALBarCode.TALROTATEVALSENUM.bcZeroDegrees
    '        'e.Graphics.DrawImage(Me.Codigobarras.Picture, 30, 430 + agregarRenglon, 285, 30)
    '        e.Graphics.DrawString("Hora: " & Now.ToString("HH:mm:ss"), fn10, Brushes.Black, 20, 440 + agregarRenglon)
    '        e.Graphics.DrawString(IIf(Me.chkEdadGanado.Text = "-30", "", "+30"), New Font("Arial", 26, FontStyle.Bold), Brushes.Black, 238, 440 + agregarRenglon)
    '        e.Graphics.DrawString("NO ESTIBAR MAS DE 6 CAJAS", f10, Brushes.Black, 20, 460 + agregarRenglon) '30

    '        nPag += 1
    '        Me.codigobarras.ShowHRText = True
    '        'e.Graphics.DrawString(nombreProducto, New Font("Arial", 18, FontStyle.Bold), Brushes.Black, 15, 11 + agregarRenglon)
    '        'e.Graphics.DrawString(nombreIngles, New Font("Arial", 12), Brushes.Black, 15, 36 + agregarRenglon)
    '        'e.Graphics.DrawString("PESO NETO", f10, Brushes.Black, 15, 54 + agregarRenglon)
    '        'e.Graphics.DrawString(Me.txtPeso.Text, f10, Brushes.Black, 100, 54 + agregarRenglon)
    '        'e.Graphics.DrawString("BOLSAS", f10, Brushes.Black, 305, 54 + agregarRenglon)
    '        'e.Graphics.DrawString(Me.txtPeso.Text, New Font("Arial", 60, FontStyle.Bold), Brushes.Black, 40, 66 + agregarRenglon)
    '        'e.Graphics.DrawString(Me.txtPiezas.Text, New Font("Arial", 32, FontStyle.Bold), Brushes.Black, 320, 66 + agregarRenglon)
    '        'e.Graphics.DrawString("LOTE", f10, Brushes.Black, 15, 146 + agregarRenglon)
    '        'e.Graphics.DrawString("CONSERVA A", f10, Brushes.Black, 120, 146 + agregarRenglon)
    '        'e.Graphics.DrawString("CODIGO PRODUCTO", f10, Brushes.Black, 225, 146 + agregarRenglon) '10
    '        'e.Graphics.DrawString(Me.txtLoteCorte.Text, fn10, Brushes.Black, 15, 166 + agregarRenglon)
    '        'e.Graphics.DrawString("4ºC", fn10, Brushes.Black, 150, 166 + agregarRenglon)
    '        'e.Graphics.DrawString(codigoProducto, fn10, Brushes.Black, 290, 166 + agregarRenglon) '15
    '        'e.Graphics.DrawString("FECHA", f10, Brushes.Black, 15, 186 + agregarRenglon)
    '        'e.Graphics.DrawString("FECHA", f10, Brushes.Black, 160, 186 + agregarRenglon) '20
    '        'e.Graphics.DrawString("EMPAQUE", f10, Brushes.Black, 15, 206 + agregarRenglon)
    '        'e.Graphics.DrawString("CADUCIDAD", f10, Brushes.Black, 165, 206 + agregarRenglon)
    '        'e.Graphics.DrawString(Me.dtpFechaCorte.Value.ToShortDateString, f10, Brushes.Black, 90, 206 + agregarRenglon)
    '        'e.Graphics.DrawString(Me.dtpFechaCaducidad.Value.ToShortDateString, f10, Brushes.Black, 265, 206 + agregarRenglon) '25
    '        'e.Graphics.DrawString("NO ESTIBAR MAS DE 6 CAJAS ESTE LADO HACIA", f10, Brushes.Black, 15, 226 + agregarRenglon) '30
    '        'e.Graphics.DrawString("#", New Font("Wingdings 3", 55, FontStyle.Bold), Brushes.Black, 25, 260)
    '        'e.Graphics.DrawString("#", New Font("Wingdings 3", 55, FontStyle.Bold), Brushes.Black, 330, 260)
    '        ''e.Graphics.DrawImage(Me.ListaImagenes.Images(0), 25, 246 + agregarRenglon, 30, 70)
    '        ''e.Graphics.DrawImage(Me.ListaImagenes.Images(0), 330, 246 + agregarRenglon, 30, 70)
    '        'e.Graphics.DrawImage(Me.codigobarras.Picture, 90, 246 + agregarRenglon, 220, 80) '35
    '        'e.Graphics.DrawString("CVE PROV", f10, Brushes.Black, 15, 336 + agregarRenglon)
    '        'e.Graphics.DrawString("PAIS ORIGEN", f10, Brushes.Black, 154, 336 + agregarRenglon) '40
    '        'e.Graphics.DrawString("3010659", fn10, Brushes.Black, 15, 356 + agregarRenglon)
    '        'e.Graphics.DrawString("MEXICO", fn10, Brushes.Black, 154, 356 + agregarRenglon) '45
    '        'e.Graphics.DrawString(Controlador.Sesion.MiEmpresa.Empnom, f10, Brushes.Black, 15, 376 + agregarRenglon) '50
    '        'e.Graphics.DrawString(Controlador.Sesion.MiEmpresa.EmpDomicilio, f10, Brushes.Black, 15, 396 + agregarRenglon)
    '        'e.Graphics.DrawImage(Me.ListaImagenes.Images(1), 270, 336 + agregarRenglon, 100, 100)
    '        'e.Graphics.DrawString("Hora: " & Now.ToString("HH:mm:ss"), fn10, Brushes.Black, 268, 440 + agregarRenglon)
    '        'Me.codigobarras.ShowHRText = False
    '        'e.Graphics.DrawImage(Me.codigobarras.Picture, 268, 460 + agregarRenglon, 100, 25)
    '        'nPag += 1
    '        'Me.codigobarras.ShowHRText = True

    '        If nPag < 1 Then
    '            e.HasMorePages = True
    '        Else
    '            e.HasMorePages = False
    '        End If
    '    Catch ex As Exception
    '        e.HasMorePages = False
    '    End Try
    'End Sub

    ''Etiqueta preelaborada

    'Private Sub Imprime_Documento(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
    '    Try
    '        Dim nombreProducto As String
    '        Dim codigoProducto As String
    '        Dim f10 As New Font("Arial", 10) 'formato de impresion Arial tamaño 10
    '        Dim fn10 As New Font("Arial", 10, FontStyle.Bold) 'formato de impresion Arial tamaño 10 Negrita

    '        If Me.cmbClientes.SelectedIndex > -1 Then
    '            Dim nombreProductoCliente As New EC.MscrelacionCortesClientesEntity
    '            nombreProducto = Me.txtSubCorte.Text
    '            codigoProducto = Me.txtCodSubCorte.Text
    '            'If nombreProductoCliente.FetchUsingPK(cmbClientes.SelectedValue, CInt(Me.txtCodSubCorte.Text)) Then
    '            '    nombreProducto = nombreProductoCliente.Descripcion
    '            '    codigoProducto = nombreProductoCliente.CodCorteCliente
    '            'Else
    '            '    nombreProducto = Me.txtSubCorte.Text
    '            '    codigoProducto = Me.txtCodSubCorte.Text
    '            'End If
    '        Else
    '            nombreProducto = Me.txtSubCorte.Text
    '            codigoProducto = Me.txtCodSubCorte.Text
    '        End If

    '        Dim agregarRenglon As Integer = 5

    '        e.Graphics.DrawString(Me.txtSubCorte.Text.Trim, New Font("Arial", 18, FontStyle.Bold), _
    '                                Brushes.Black, 20, 11 + agregarRenglon)
    '        e.Graphics.DrawString("EMPAQUE:", f10, Brushes.Black, 20, 35 + agregarRenglon)
    '        e.Graphics.DrawString("CADUCIDAD:", f10, Brushes.Black, 20, 50 + agregarRenglon)
    '        e.Graphics.DrawString(Me.dtpFechaCorte.Value.ToShortDateString, fn10, Brushes.Black, _
    '                                110, 35 + agregarRenglon)
    '        e.Graphics.DrawString(Me.dtpFechaCaducidad.Value.ToShortDateString, fn10, Brushes.Black, _
    '                                110, 50 + agregarRenglon)
    '        e.Graphics.DrawString("PIEZAS:", f10, Brushes.Black, 185, 43 + agregarRenglon)
    '        e.Graphics.DrawString(Me.txtPiezas.Text.Trim, New Font("Arial", 18, FontStyle.Bold), Brushes.Black, _
    '                                239, 35 + agregarRenglon)
    '        e.Graphics.DrawString(CDec(Me.txtPeso.Text).ToString("N2"), New Font("Arial", 26, FontStyle.Bold), _
    '                                Brushes.Black, 259, 31 + agregarRenglon)
    '        e.Graphics.DrawString("Kgs.", New Font("Arial", 10, FontStyle.Bold), _
    '                                Brushes.Black, 360, 50 + agregarRenglon)
    '        e.Graphics.DrawString("CODIGO:", f10, Brushes.Black, 185, 65 + agregarRenglon)
    '        e.Graphics.DrawString(codigoProducto, New Font("Arial", 11, FontStyle.Bold), _
    '                                Brushes.Black, 245, 64 + agregarRenglon)
    '        e.Graphics.DrawString("Hora: " & Now.ToString("HH:mm:ss"), fn10, _
    '                                Brushes.Black, 20, 65 + agregarRenglon)
    '        e.Graphics.DrawString("#", New Font("Wingdings 3", 40, FontStyle.Bold), _
    '                                Brushes.Black, 20, 80 + agregarRenglon)
    '        'e.Graphics.DrawImage(Me.codigobarras.Picture, 65, 83 + agregarRenglon, 285, 60)
    '        e.Graphics.DrawString(IIf(Me.chkEdadGanado.Text = "-30", "", "+30"), New Font("Arial", 18, FontStyle.Bold), Brushes.Black, 350, _
    '                                90 + agregarRenglon)
    '        e.Graphics.DrawString(IIf(Me.chkTipoCorte.Checked, "CARNE CONGELADA", "CARNE FRESCA"), _
    '                                fn10, Brushes.Black, 20, 145 + agregarRenglon)
    '        e.Graphics.DrawString("LOTE:", f10, Brushes.Black, 20, 162 + agregarRenglon)
    '        e.Graphics.DrawString(Me.txtLoteCorte.Text.Trim, New Font("Arial", 14, FontStyle.Bold), _
    '                                Brushes.Black, 60, 158 + agregarRenglon)
    '        e.Graphics.DrawString("CONSERVAR A:", f10, Brushes.Black, 240, 145 + agregarRenglon)
    '        e.Graphics.DrawString(Me.tempConservar & "°C", fn10, Brushes.Black, 350, 145 + agregarRenglon)
    '        e.Graphics.DrawString("CVE PROV", f10, Brushes.Black, 20, 177 + agregarRenglon)
    '        e.Graphics.DrawString("3010659", fn10, Brushes.Black, 94, 177 + agregarRenglon)
    '        e.Graphics.DrawString("PAIS ORIGEN", f10, Brushes.Black, 175, 160 + agregarRenglon)
    '        e.Graphics.DrawString("MEXICO", fn10, Brushes.Black, 275, 160 + agregarRenglon)
    '        e.Graphics.DrawString(Controlador.Sesion.MiEmpresa.Empnom, f10, Brushes.Black, 20, 195 + agregarRenglon)

    '        Dim domicilio As String = Controlador.Sesion.MiEmpresa.EmpDomicilio
    '        Dim partes As New List(Of String)

    '        For Each palabra As String In domicilio.Split(" "c)
    '            If partes.Count = 0 Then
    '                partes.Add(palabra.Trim)
    '                Continue For
    '            End If

    '            If partes(partes.Count - 1).Trim.Length + palabra.Trim.Length > 37 Then
    '                partes.Add(palabra.Trim)
    '            Else
    '                partes(partes.Count - 1) &= " " & palabra.Trim
    '            End If
    '        Next

    '        For i As Integer = 0 To partes.Count - 1
    '            e.Graphics.DrawString(partes(i), f10, Brushes.Black, 20, 210 + agregarRenglon + i * 15)
    '        Next

    '        e.Graphics.DrawImage(Me.ListaImagenes.Images(1), 295, 175 + agregarRenglon, 100, 100)

    '        e.Graphics.DrawImage(GeneraCodBarra(Me.codBarras), 10, 280 + agregarRenglon, 380, 75)

    '        nPag += 1

    '        If nPag < 1 Then
    '            e.HasMorePages = True
    '        Else
    '            e.HasMorePages = False
    '        End If
    '    Catch ex As Exception
    '        e.Cancel = True
    '    End Try
    'End Sub


    ''Etiqueta idefoods nuevo diseño
    Private Sub Imprime_Documento(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
        Try

            Dim nombreProducto As String
            Dim codigoProducto As String
            Dim f10 As New Font("Arial", 10) 'formato de impresion Arial tamaño 10
            Dim fn10 As New Font("Arial", 10, FontStyle.Bold) 'formato de impresion Arial tamaño 10 Negrita

            Dim agregarRenglon As Integer = 12
            If Me.cmbClientes.SelectedIndex > -1 Then
                Dim nombreProductoCliente As New EC.MscrelacionCortesClientesEntity
                nombreProducto = Me.txtSubCorte.Text
                codigoProducto = Me.txtCodSubCorte.Text
                Dim cte As New ClientesIntroductoresClass(CInt(cmbClientes.SelectedValue))
                Dim Logo As Image
                If cte.Logo.Length > 0 Then
                    Dim ms As MemoryStream = New MemoryStream(cte.Logo)
                    'Me.pbLogo.Image = Image.FromStream(ms)
                    Logo = Image.FromStream(ms)
                    e.Graphics.DrawImage(Logo, 10, 11, 100, 100)
                End If

                e.Graphics.DrawString(cte.RazonSocial.ToUpper().Substring(0, IIf(cte.RazonSocial.Length >= 23, 23, cte.RazonSocial.Length)), New Font("Arial Narrow", 11.5, FontStyle.Bold), _
                                    Brushes.Black, 110, 18)
                e.Graphics.DrawString("R.F.C. " + cte.RFC, New Font("Arial Narrow", 10, FontStyle.Regular), _
                                    Brushes.Black, 269, 20)
                Dim dom As String
                dom = cte.Domicilio + ", COL. " + cte.Colonia + vbCrLf + "C.P. " + cte.CodigoPostal + ", " + cte.Ciudad.Descripcion + ", " + cte.Estado.Descripcion + ", MEX."
                e.Graphics.DrawString(dom, New Font("Arial Narrow", 10, FontStyle.Regular), _
                                    Brushes.Black, 110, 20 + agregarRenglon + 3)

                'If nombreProductoCliente.FetchUsingPK(cmbClientes.SelectedValue, CInt(Me.txtCodSubCorte.Text)) Then
                '    nombreProducto = nombreProductoCliente.Descripcion
                '    codigoProducto = nombreProductoCliente.CodCorteCliente
                'Else
                '    nombreProducto = Me.txtSubCorte.Text
                '    codigoProducto = Me.txtCodSubCorte.Text
                'End If
            Else
                nombreProducto = Me.txtSubCorte.Text
                codigoProducto = Me.txtCodSubCorte.Text
            End If
            ''NOMBRE DE PRODUCTO
            e.Graphics.DrawString(nombreProducto, New Font("Arial Narrow", 15, FontStyle.Bold), _
                                    Brushes.Black, 13, 115)
            ''FRESCA O CONGELADA
            e.Graphics.DrawString(IIf(Me.chkTipoCorte.Checked, "CARNE CONGELADA", "CARNE FRESCA"), _
                                    New Font("Arial Narrow", 14, FontStyle.Regular), Brushes.Black, 13, 136)
            ''TEMPERATURA
            e.Graphics.DrawString("Consérvese refrigerado  " + Me.tempConservar.ToString() + "°C", New Font("Arial Narrow", 14, FontStyle.Regular), Brushes.Black, 13, 157)
            ''PESO
            e.Graphics.DrawString("Peso neto: ", New Font("Arial Narrow", 14, FontStyle.Regular), _
                                    Brushes.Black, 11, 178)
            e.Graphics.DrawString(CDec(Me.txtPeso.Text).ToString("N3") + " Kgs", New Font("Arial Narrow", 15, FontStyle.Bold), _
                                    Brushes.Black, 95, 178)
            ''Lote
            e.Graphics.DrawString("Lote: ", New Font("Arial Narrow", 12, FontStyle.Regular), _
                                    Brushes.Black, 280, 204)
            e.Graphics.DrawString(Me.txtLoteCorte.Text.Trim(), New Font("Arial Narrow", 12, FontStyle.Bold), _
                                    Brushes.Black, 310, 204)
            ''Fecha Produccion
            e.Graphics.DrawString("Fecha producción: ", New Font("Arial Narrow", 12, FontStyle.Regular), _
                                    Brushes.Black, 193, 221)
            e.Graphics.DrawString(Me.dtpFechaCorte.Value.ToShortDateString, New Font("Arial Narrow", 12, FontStyle.Bold), _
                                    Brushes.Black, 310, 221)
            ''Fecha caducidad
            e.Graphics.DrawString("Fecha caducidad: ", New Font("Arial Narrow", 12, FontStyle.Regular), _
                                    Brushes.Black, 198, 238)
            e.Graphics.DrawString(Me.dtpFechaCaducidad.Value.ToShortDateString, New Font("Arial Narrow", 12, FontStyle.Bold), _
                                    Brushes.Black, 310, 238)
            ''Folio o ID
            e.Graphics.DrawString("ID: ", New Font("Arial Narrow", 12, FontStyle.Regular), _
                                    Brushes.Black, 293, 255)
            e.Graphics.DrawString(folioEtiqueta.Substring(folioEtiqueta.Length - 4, 4), New Font("Arial Narrow", 12, FontStyle.Bold), _
                                    Brushes.Black, 310, 255)

            ''Clave del producto
            e.Graphics.DrawString(CveProduto, New Font("Arial Narrow", 38, FontStyle.Bold), _
                                    Brushes.Black, 12, 200)

            ''codigo barra
            e.Graphics.DrawImage(GeneraCodBarra(Me.codBarras), 70, 290, 265, 75)

            'Dim fonts As PrivateFontCollection

            'Dim fontF As FontFamily
            'fontF = LoadFontFamily(Application.StartupPath + "\code128.ttf", fonts)
            'Dim font As New Font(fontF, 37, FontStyle.Regular)



            'e.Graphics.DrawString(BRC.BarcodeConverter128.StringToBarcode(Me.codBarras), font, _
            '                       Brushes.Black, 5, 278)

            'e.Graphics.DrawString(Me.codBarras, New Font("Arial Narrow", 11, FontStyle.Bold), _
            '                       Brushes.Black, 85, 333)
            'e.Graphics.DrawImage(GenCode128.Code128Rendering.MakeBarcodeImage(Me.codBarras, 2, True), 37, 290, 340, 75)






            'Dim agregarRenglon As Integer = 5

            'e.Graphics.DrawString(Me.txtSubCorte.Text.Trim, New Font("Arial", 18, FontStyle.Bold), _
            '                        Brushes.Black, 20, 11 + agregarRenglon)
            'e.Graphics.DrawString("EMPAQUE:", f10, Brushes.Black, 20, 35 + agregarRenglon)
            'e.Graphics.DrawString("CADUCIDAD:", f10, Brushes.Black, 20, 50 + agregarRenglon)
            'e.Graphics.DrawString(Me.dtpFechaCorte.Value.ToShortDateString, fn10, Brushes.Black, _
            '                        110, 35 + agregarRenglon)
            'e.Graphics.DrawString(Me.dtpFechaCaducidad.Value.ToShortDateString, fn10, Brushes.Black, _
            '                        110, 50 + agregarRenglon)
            'e.Graphics.DrawString("PIEZAS:", f10, Brushes.Black, 185, 43 + agregarRenglon)
            'e.Graphics.DrawString(Me.txtPiezas.Text.Trim, New Font("Arial", 18, FontStyle.Bold), Brushes.Black, _
            '                        239, 35 + agregarRenglon)
            'e.Graphics.DrawString(CDec(Me.txtPeso.Text).ToString("N2"), New Font("Arial", 26, FontStyle.Bold), _
            '                        Brushes.Black, 259, 31 + agregarRenglon)
            'e.Graphics.DrawString("Kgs.", New Font("Arial", 10, FontStyle.Bold), _
            '                        Brushes.Black, 360, 50 + agregarRenglon)
            'e.Graphics.DrawString("CODIGO:", f10, Brushes.Black, 185, 65 + agregarRenglon)
            'e.Graphics.DrawString(codigoProducto, New Font("Arial", 11, FontStyle.Bold), _
            '                        Brushes.Black, 245, 64 + agregarRenglon)
            'e.Graphics.DrawString("Hora: " & Now.ToString("HH:mm:ss"), fn10, _
            '                        Brushes.Black, 20, 65 + agregarRenglon)
            'e.Graphics.DrawString("#", New Font("Wingdings 3", 40, FontStyle.Bold), _
            '                        Brushes.Black, 20, 80 + agregarRenglon)

            'e.Graphics.DrawString(IIf(Me.chkEdadGanado.Text = "-30", "", "+30"), New Font("Arial", 18, FontStyle.Bold), Brushes.Black, 350, _
            '                        90 + agregarRenglon)
            'e.Graphics.DrawString(IIf(Me.chkTipoCorte.Checked, "CARNE CONGELADA", "CARNE FRESCA"), _
            '                        fn10, Brushes.Black, 20, 145 + agregarRenglon)
            'e.Graphics.DrawString("LOTE:", f10, Brushes.Black, 20, 162 + agregarRenglon)
            'e.Graphics.DrawString(Me.txtLoteCorte.Text.Trim, New Font("Arial", 14, FontStyle.Bold), _
            '                        Brushes.Black, 60, 158 + agregarRenglon)
            'e.Graphics.DrawString("CONSERVAR A:", f10, Brushes.Black, 240, 145 + agregarRenglon)
            'e.Graphics.DrawString(Me.tempConservar & "°C", fn10, Brushes.Black, 350, 145 + agregarRenglon)
            'e.Graphics.DrawString("CVE PROV", f10, Brushes.Black, 20, 177 + agregarRenglon)
            'e.Graphics.DrawString("3010659", fn10, Brushes.Black, 94, 177 + agregarRenglon)
            'e.Graphics.DrawString("PAIS ORIGEN", f10, Brushes.Black, 175, 160 + agregarRenglon)
            'e.Graphics.DrawString("MEXICO", fn10, Brushes.Black, 275, 160 + agregarRenglon)
            'e.Graphics.DrawString(Controlador.Sesion.MiEmpresa.Empnom, f10, Brushes.Black, 20, 195 + agregarRenglon)

            'Dim domicilio As String = Controlador.Sesion.MiEmpresa.EmpDomicilio
            'Dim partes As New List(Of String)

            'For Each palabra As String In domicilio.Split(" "c)
            '    If partes.Count = 0 Then
            '        partes.Add(palabra.Trim)
            '        Continue For
            '    End If

            '    If partes(partes.Count - 1).Trim.Length + palabra.Trim.Length > 37 Then
            '        partes.Add(palabra.Trim)
            '    Else
            '        partes(partes.Count - 1) &= " " & palabra.Trim
            '    End If
            'Next

            'For i As Integer = 0 To partes.Count - 1
            '    e.Graphics.DrawString(partes(i), f10, Brushes.Black, 20, 210 + agregarRenglon + i * 15)
            'Next

            'e.Graphics.DrawImage(Me.ListaImagenes.Images(1), 295, 175 + agregarRenglon, 100, 100)

            'e.Graphics.DrawImage(GeneraCodBarra(Me.codBarras), 10, 280 + agregarRenglon, 380, 75)

            nPag += 1

            If nPag < 1 Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
            e.Cancel = True
        End Try
    End Sub

    Public Shared Function LoadFontFamily(ByVal fileName As String, ByRef fontCollection As PrivateFontCollection) As FontFamily
        fontCollection = New PrivateFontCollection()
        fontCollection.AddFontFile(fileName)
        Return fontCollection.Families(0)
    End Function



    Public Function GeneraCodBarra(ByVal CodBarra As String) As Image
        Dim barcode As New BC.Barcode()
        With barcode
            .IncludeLabel = True
            .Alignment = BarcodeLib.AlignmentPositions.CENTER
            .Width = 5700
            .Height = 1125
            .RotateFlipType = RotateFlipType.RotateNoneFlipNone
            .BackColor = Color.White
            .ForeColor = Color.Black
            .LabelFont = New Font("Arial Narrow", 150, FontStyle.Regular)

        End With

        Dim img As Image = barcode.Encode(BC.TYPE.CODE128, CodBarra)

        Return img

    End Function

    Private Sub Imprimir()
        Try
            'Me.codigobarras.Message = folioEtiqueta.Trim
            'Me.codigobarras.Message = Me.codBarras
            Me.ppdVisor.Document = Me.pdDocumento

            Me.pdDocumento.Print()
            'Me.ppdVisor.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Guardar() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")

        Try

            txtKilosCanales.Text = Convert.ToDecimal(txtKilosCanales.Text) + Convert.ToDecimal(txtPeso.Text)
            txtPiezasCanales.Text = Convert.ToDecimal(txtPiezasCanales.Text) + Convert.ToDecimal(txtPiezas.Text)

            Dim Consecutivo As Integer
            Dim movAlmacen As New MovimientoAlmacenClass
            Dim col As New CC.MscloteCortesDetCollection
            corte = New EC.MscloteCortesDetEntity
            Dim grados As Integer

            LoteCorte.LoteCorte = Me.txtLoteCorte.Text
            LoteCorte.TotalKgs = Me.txtPeso.Text
            LoteCorte.TotalPzas = Me.txtPiezas.Text


            LoteCorte.Nopiezas = 0
            LoteCorte.Producto = 1
            LoteCorte.Unidad = ""
            LoteCorte.Conductor = ""
            LoteCorte.Placas = ""
            LoteCorte.Horaviaje = 0D
            LoteCorte.Idproveedor = 0
            LoteCorte.Cvecomprador = 0
            LoteCorte.Cvelugcom = 0
            LoteCorte.Observacioneslote = ""
            LoteCorte.KilosRecibidos = 0D
            LoteCorte.Nofactura = ""
            LoteCorte.Importe = 0D


            LoteCorte.Func = "M"
            LoteCorte.NumOpc = 1

            LoteCorte.Nopiezas = 0
            LoteCorte.Producto = 1
            LoteCorte.Unidad = ""
            LoteCorte.Conductor = ""
            LoteCorte.Placas = ""
            LoteCorte.Horaviaje = 0D
            LoteCorte.Idproveedor = 0
            LoteCorte.Cvecomprador = 0
            LoteCorte.Cvelugcom = 0
            LoteCorte.Observacioneslote = ""
            ''-------------------------------------------   datos nuevos de precio por kilo
            LoteCorte.Precioxkilo = 0D
            LoteCorte.Precioxkilogasto = 0D
            LoteCorte.Precioxkilototal = 0D

            Dim CantPzas As Decimal = 0
            Dim CantKgrs As Decimal = 0
            Dim KilosRecibidos As Decimal = 0
            Dim Nopiezas As Decimal = 0
            'Dim NoBultos As Decimal = 0
            Dim NoCajas As Decimal = txtcajas.Text
            'If(dtpFechaInicio.Enabled = True, Me.dtpFechaInicio.Value.ToShortDateString, String.Empty)
            Dim query As String = "exec Usp_MSCLoteCortesCon 5, '{0}' , '{1}', '', ''"
            query = String.Format(query, Me.txtLoteCorte.Text, Me.cmbCortes.SelectedValue.ToString())

            Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
            Using sqlcom As New SqlCommand(query, sqlCon)
                sqlCon.Open()
                'Dim sqlcom As New SqlCommand(cadenaConsulta, sqlCon)
                'Dim adp As New SqlDataAdapter(sqlcom)
                Dim Rs As SqlDataReader = sqlcom.ExecuteReader()
                Rs.Read()

                CantPzas = Rs(0).ToString()
                CantKgrs = Rs(1).ToString()
                KilosRecibidos = Rs(2).ToString()
                Nopiezas = Rs(3).ToString()
                'NoBultos = Rs(4).ToString()

                'inicio editando codigo---------------

                'verificarKilos(CantPzas, CantKgrs, KilosRecibidos, Nopiezas)


                'fin----------------------------------


                'codigo original -----------------------------------

                'If (CantKgrs + LoteCorte.TotalKgs) > KilosRecibidos Then
                '    Trans.Rollback()
                '    MessageBox.Show("Los kilos registrados exceden los kilos comprados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                '    Return False
                'End If

                'If (CantPzas + LoteCorte.TotalPzas) > Nopiezas Then
                '    Trans.Rollback()
                '    MessageBox.Show("Las piezas registradas exceden las piezas compradas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    Return False

                'End If

                'Codigo original -------------------------------


                'LoteCorte.TotalPzas

                'FormPrincipal.txtFolioSacrificio.Text = Rs(2).ToString()
                Rs.Close()
                sqlCon.Close()

            End Using


            If Not LoteCorte.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            Consecutivo = col.GetDbCount(HC.MscloteCortesDetFields.LoteCorte = Me.txtLoteCorte.Text.Trim) + 1

            With movAlmacen
                'True Congelado, False Fresco
                If Me.chkTipoCorte.Checked Then
                    If Me.valorAgregado Then
                        .EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.VALOR_AGREGADO_CONGELADO)
                        tipocorte = ClasesNegocio.TipoCorte.VALOR_AGREGADO_CONGELADO
                        grados = Controlador.Configuracion.Produccion.TemperaturaValorAgregadoCongelado
                    Else
                        .EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CONGELADO)
                        tipocorte = ClasesNegocio.TipoCorte.CONGELADO
                        grados = Controlador.Configuracion.Produccion.TemperaturaProdCongelado
                    End If
                Else
                    If Me.valorAgregado Then
                        .EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.VALOR_AGREGADO_FRESCO)
                        tipocorte = ClasesNegocio.TipoCorte.VALOR_AGREGADO_FRESCO
                        grados = Controlador.Configuracion.Produccion.TemperaturaValorAgregado
                    Else
                        .EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
                        tipocorte = ClasesNegocio.TipoCorte.FRESCO
                        grados = Controlador.Configuracion.Produccion.TemperaturaProdFresco
                    End If
                End If

                .EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Captura)
                .Estatus = EstatusChar.VIGENTE
                .FechaMovimiento = Now
                .IdPoliza = ""
                .Kilos = CDec(Me.txtPeso.Text)
                .Piezas = CInt(Me.txtPiezas.Text)
                'Modificar
                .AgregarDetalle(CInt(Me.txtCodSubCorte.Text), .Kilos, .Piezas, precioxkilo, 0D)

                .Guardar(Trans)
            End With

            Trans.Add(corte)

            corte.IdFolioEtiqueta = Me.txtLoteCorte.Text.Trim & Consecutivo.ToString("0000")
            folioEtiqueta = corte.IdFolioEtiqueta
            corte.LoteCorte = Me.txtLoteCorte.Text.Trim

            If Not (tipocorte = ClasesNegocio.TipoCorte.VALOR_AGREGADO_CONGELADO OrElse tipocorte = ClasesNegocio.TipoCorte.VALOR_AGREGADO_FRESCO) Then
                corte.IdCorte = CInt(Me.txtCodCorte.Text)
            Else
                corte.IdCorte = 0
            End If
            'Modificar 
            corte.IdProducto = CInt(Me.txtCodSubCorte.Text)
            corte.CantKgrs = CDec(Me.txtPeso.Text)
            corte.CantPzas = CInt(Me.txtPiezas.Text)
            corte.IdFolioMovimiento = movAlmacen.FolioMovimiento
            corte.IdAlmacenActual = movAlmacen.IdAlmacen
            corte.Estatus = ClasesNegocio.EstatusCorte.VIGENTE
            corte.TipoProducto = tipocorte
            corte.FechaCaducidad = Me.dtpFechaCaducidad.Value
            corte.FechaCaducidadAnterior = Me.dtpFechaCaducidad.Value
            corte.Grados = grados
            corte.MasDe30Meses = Me.chkEdadGanado.Checked

            With corte
                If Me.txtFolioReferencia.Text.Trim = "" Then
                    'corte.CodigoBarra = String.Format("{0}{1}{2}{3}", .IdProducto.ToString("000"), _
                    '                                .CantPzas.ToString("000"), _
                    '                                Math.Truncate(.CantKgrs).ToString("0000") & _
                    '                                .CantKgrs.ToString("N2").Substring(.CantKgrs.ToString("N2").Length - 2, _
                    '                                2), folioEtiqueta)
                    corte.CodigoBarra = IIf(Me.CveProduto.Trim().Length = 7, Me.CveProduto, AgregarCaracterCant("0", 7 - Me.CveProduto.Trim().Length, Me.CveProduto)) + _
                                        Math.Truncate(.CantKgrs).ToString("000") + .CantKgrs.ToString("N3").Substring(.CantKgrs.ToString("N3").Length - 3, 3) + _
                                        dtpFechaCorte.Value.ToString("yyMMdd") + folioEtiqueta.Trim()
                Else
                    corte.CodigoBarra = Me.txtFolioReferencia.Text
                End If
            End With

            Me.codBarras = corte.CodigoBarra

            corte.Save()
            Trans.Commit()

            If Controlador.Configuracion.Produccion.ImprimirEtiquetasCortes Then
                Imprimir()
            End If

            Dim Etiquetas As DataSet = LoteCorteDetalle.Obtener(Me.txtLoteCorte.Text.Trim)

            If Etiquetas.Tables(0).Rows.Count > 0 Then
                Me.dgvEtiquetas.AutoGenerateColumns = False
                Me.dgvEtiquetas.DataSource = Etiquetas.Tables(0)
                Me.IdFolioEtiqueta.DataPropertyName = "IdFolioEtiqueta"
                Me.IdCorte.DataPropertyName = "IdCorte"
                Me.Nom_Corte.DataPropertyName = "Nom_Corte"
                Me.IdProducto.DataPropertyName = "IdProducto"
                Me.Nom_SubCorte.DataPropertyName = "Nom_SubCorte"
                Me.CantPzas.DataPropertyName = "CantPzas"
                Me.CantKgrs.DataPropertyName = "CantKgrs"
            End If


            'Me.cmbClientes.SelectedIndex = 0

            Sumar()


            'If Me.mostarMensajes Then MessageBox.Show("Se genero corte con el folio :" & folioEtiqueta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'If CDec(Me.txtKilosCanales.Text) - CDec(Me.txtTotKgrs.Text) <= 30 Then
            '    If mostarMensajes Then MsgBox("Está por terminar la captura de cortes.", MsgBoxStyle.Exclamation, "Aviso")
            'End If

            'Me.txtPeso.SelectAll()

            Return True
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function AgregarCaracterCant(ByVal Caracter As Char, ByVal Cuantos As Integer, ByVal Cadena As String) As String
        Dim i As Integer

        For i = 1 To Cuantos
            Cadena = Caracter + Cadena
        Next

        Return Cadena
    End Function

    Private Function Limpiar() As Boolean
        'Me.GroupBox1.Enabled = False
        Me.txtCorte.Text = 0
        Me.cmbClientes.SelectedIndex = 0
        'Me.txtDescripcionCorte.Text = ""
        'Me.txtDescripcionPreCorte.Text = ""
        'Me.txtKilos.Text = 0
        'Me.txtPiezas.Text = 0
        'Me.txtPrecorte.Text = 0
    End Function

    Private Function Buscar() As Boolean

    End Function

    Private Sub Imprimir(ByVal NomCorte As String, ByVal Kilos As Decimal, ByVal Codigo As Integer, ByVal Piezas As Integer, ByVal Lote As String, ByVal Fecha As Date, ByVal FechaCad As Date, _
                            ByVal Grados As String, ByVal FolioEtiqueta As String, ByVal Empresa As String, ByVal DireccionEmp As String)
        Try
            Dim Reporte As New RptEtiquetaCorte

            Reporte.SetParameterValue("NomCorte", Trim(NomCorte))
            Reporte.SetParameterValue("Kilos", Kilos)
            Reporte.SetParameterValue("Codigo", Codigo)
            Reporte.SetParameterValue("Piezas", Piezas)
            Reporte.SetParameterValue("Lote", Lote)
            Reporte.SetParameterValue("FechaEmbarque", Fecha)
            Reporte.SetParameterValue("Conservacion", Grados & "°C")
            Reporte.SetParameterValue("FechaCad", FechaCad)
            Reporte.SetParameterValue("Folioetiqueta", FolioEtiqueta)
            Reporte.SetParameterValue("NomEmpresa", Empresa)
            Reporte.SetParameterValue("DirEmpresa", DireccionEmp)

            Dim VerReporte As New FrmReportes
            VerReporte.CRV.ReportSource = Reporte
            'VerReporte.CRV.PrintReport()
            VerReporte.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Sumar()
        Try
            Dim Piezas, Kilos As Decimal

            Dim totalEtiquetas = Me.dgvEtiquetas.Rows.Count

            For i As Integer = 0 To totalEtiquetas - 1
                With Me.dgvEtiquetas.Rows(i)
                    Piezas += .Cells(Me.CantPzas.Index).Value
                    Kilos += .Cells(Me.CantKgrs.Index).Value
                End With
            Next

            Me.txtTotEti.Text = totalEtiquetas
            'Me.txtTotPzas.Text = Piezas.ToString("N3")
            'Me.txtTotKgrs.Text = Kilos.ToString("N3")

            'Me.txtPiezasCanales.Text = totalEtiquetas
            'Me.txtKilosCanales.Text = Kilos.ToString("N3")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function GuardarSalida(ByVal FolioEtiqueta As String, ByVal IdCorte As Integer, _
                                    ByVal Kilos As Decimal, ByVal Piezas As Decimal) As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Salida")

        Try
            'folio para el registro de movimientos de almacen
            Folio.Codigo = CodigodeFolios.MovimientosdeAlmacen
            Folio.Año = Now.Year
            Folio.Mes = Now.ToString("MM")

            If Not Folio.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            'folio para el registro de movimientos de almacen
            Dim FolioAlmacen As String

            FolioAlmacen = Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("000000")
            LoteCorteDetalle = New CortesDetalleClass(Me.txtLoteCorte.Text, FolioEtiqueta)
            LoteCorteDetalle.Estatus = 0
            Trans.Add(LoteCorteDetalle.ObtenerEntidad)

            If Not LoteCorteDetalle.ObtenerEntidad.Save Then
                Trans.Rollback()
                MsgBox("Ocurrió un error al borrar el corte", MsgBoxStyle.Critical, "Error")
                Return False
            End If

            Dim movimientoAlmacen As New ClasesNegocio.MovimientoAlmacenClass

            With movimientoAlmacen
                .EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
                .EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Captura_Corte)
                .Estatus = EstatusChar.VIGENTE
                .FechaMovimiento = Now
                .FolioMovmientoReferencia = LoteCorteDetalle.IdFolioMovimiento
                .IdPoliza = ""
                .Kilos = LoteCorteDetalle.CantKgrs
                .Piezas = LoteCorteDetalle.CantPzas
                .AgregarDetalle(LoteCorteDetalle.IdProducto, .Kilos, .Piezas, 0D, 0D)

                If Not .Guardar(Trans) Then
                    Trans.Rollback()
                    MsgBox("Ocurrio un error al guardar el inventario", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            End With

            Trans.Commit()

            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub ObtenerDiasCaducidad()
        Try
            If Me.prodSeleccionado Then
                If Me.chkTipoCorte.Checked Then
                    Me.chkTipoCorte.BackColor = Color.LightCyan

                    If Me.valorAgregado Then
                        Me.txtDiasCad.Text = Controlador.Configuracion.Produccion.DiasCaducidadValorAgregadoCongelado
                        Me.dtpFechaCaducidad.Value = Me.dtpFechaCorte.Value.AddDays(Controlador.Configuracion.Produccion.DiasCaducidadValorAgregadoCongelado)
                        Me.tempConservar = Controlador.Configuracion.Produccion.TemperaturaValorAgregadoCongelado
                    ElseIf Me.conHueso Then
                        Me.txtDiasCad.Text = Controlador.Configuracion.Produccion.DiasCaducidadHuesoCongelado
                        Me.dtpFechaCaducidad.Value = Me.dtpFechaCorte.Value.AddDays(Controlador.Configuracion.Produccion.DiasCaducidadHuesoCongelado)
                        Me.tempConservar = Controlador.Configuracion.Produccion.TemperaturaProdCongelado
                    Else
                        Me.txtDiasCad.Text = Controlador.Configuracion.Produccion.DiasCaducidadProdCongelado
                        Me.dtpFechaCaducidad.Value = Me.dtpFechaCorte.Value.AddDays(Controlador.Configuracion.Produccion.DiasCaducidadProdCongelado)
                        Me.tempConservar = Controlador.Configuracion.Produccion.TemperaturaProdCongelado
                    End If
                Else
                    Me.chkTipoCorte.BackColor = Color.MistyRose

                    If Me.valorAgregado Then
                        Me.txtDiasCad.Text = Controlador.Configuracion.Produccion.DiasCaducidadValorAgregado
                        Me.dtpFechaCaducidad.Value = Me.dtpFechaCorte.Value.AddDays(Controlador.Configuracion.Produccion.DiasCaducidadValorAgregado)
                        Me.tempConservar = Controlador.Configuracion.Produccion.TemperaturaValorAgregado
                    ElseIf Me.conHueso Then
                        Me.txtDiasCad.Text = Controlador.Configuracion.Produccion.DiasCaducidadHuesoFresco
                        Me.dtpFechaCaducidad.Value = Me.dtpFechaCorte.Value.AddDays(Controlador.Configuracion.Produccion.DiasCaducidadHuesoFresco)
                        Me.tempConservar = Controlador.Configuracion.Produccion.TemperaturaProdFresco
                    Else
                        Me.txtDiasCad.Text = Controlador.Configuracion.Produccion.DiasCaducidadProdFresco
                        Me.dtpFechaCaducidad.Value = Me.dtpFechaCorte.Value.AddDays(Controlador.Configuracion.Produccion.DiasCaducidadProdFresco)
                        Me.tempConservar = Controlador.Configuracion.Produccion.TemperaturaProdFresco
                    End If
                End If
            Else
                If Me.chkTipoCorte.Checked Then
                    Me.chkTipoCorte.BackColor = Color.LightCyan
                Else
                    Me.chkTipoCorte.BackColor = Color.MistyRose
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "Eventos"
#Region "TextBox"
    Private Sub txtCodSubCorte_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodSubCorte.GotFocus
        Me.txtCodSubCorte.SelectAll()
    End Sub

    Private Sub txtCodSubCorte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodSubCorte.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                If Me.txtCodSubCorte.Text.Trim = "" Then
                    e.Handled = True
                    Exit Sub
                ElseIf Not IsNumeric(Me.txtCodSubCorte.Text) Then
                    e.Handled = True
                    Exit Sub
                End If

                buscarcortes()

            Catch ex As Exception

            End Try
        End If

        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub buscarcortes(Optional ByVal id_producto As String = "0")
        Me.txtPiezas.Clear()

        Dim TablaProductos As New DataSet

        Productos = New ClasesNegocio.ProductosClass
        'TablaProductos = Productos.Obtener(CInt(Me.txtCodSubCorte.Text), "", 0, 7)

        'Dim cadena As String = "Select 	IdPreCorte,	" & _
        '                       "        (Select Descripcion " & _
        '                       "        From MSCCatProductos" & _
        '                       "		Where IdProducto=IdPreCorte) as PreCorte," & _
        '                       "        Cp.IdProducto as IdCorte, Descripcion, DescripcionCorta,'',MaximoPiezasxCaja," & _
        '                       "        Case	When Estatus = 1 then 'VIGENTE'	" & _
        '                       "                when  Estatus = 0 then 'CANCELADO'" & _
        '                       "	    End as Estatus,	NombreIngles, CodigoBarra,Cp.ValorAgregado,cp.ConHueso " & _
        '                       "FROM	MSCCatProductos Cp left join MSCCortesPreCortes Cpc " & _
        '                       "        on Cpc.IdCorte=Cp.IdProducto " & _
        '                       "WHERE	(IdCorte in (Select IdCorte	" & _
        '                       "                      From	MSCCortesPreCortes  Inner join " & _
        '                       "                            MSCCatProductos  on MSCCortesPreCortes.IdCorte=MSCCatProductos.IdProducto) " & _
        '                       "        OR Cp.ValorAgregado = 1) AND Estatus = 1 AND Cp.IdProducto = " & _
        '                       Me.txtCodSubCorte.Text.Trim

        Dim cadena As String = "exec Usp_MSCLoteCortesCon 4, '{0}' , '{1}', '', ''"
        cadena = String.Format(cadena, Me.txtLoteCorte.Text, id_producto)

        'Dim cadena As String = "Select IdPreCorte, (Select Descripcion From MSCCatProductos " & _
        '                       "Where IdProducto=IdPreCorte) as PreCorte, IdCorte,Descripcion, " & _
        '                       "DescripcionCorta,'', MaximoPiezasxCaja,Case When Estatus = 1 then 'VIGENTE' " & _
        '                       "when  Estatus = 0 then 'CANCELADO' End as Estatus,NombreIngles,CodigoBarra " & _
        '                       "From MSCCortesPreCortes Cpc Inner join MSCCatProductos Cp on Cpc.IdCorte=Cp.IdProducto " & _
        '                       "WHERE Cp.IdProducto = " & Me.txtCodSubCorte.Text.Trim
        'Modificar
        Dim ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(cadena, New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)))

        Try
            ad.SelectCommand.Connection.Open()

            ad.Fill(TablaProductos)
        Catch ex As Exception


        End Try
        'Mee
        If TablaProductos.Tables(0).Rows.Count = 0 Then
            MsgBox("No se encuentra un producto con ese codigo", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If

        If DBNull.Value.Equals(TablaProductos.Tables(0).Rows(0)("NombreIngles")) Then
            nombreIngles = ""
        Else
            nombreIngles = TablaProductos.Tables(0).Rows(0)("NombreIngles")
        End If

        Me.txtCodSubCorte.Text = TablaProductos.Tables(0).Rows(0)("IdCorte")

        If DBNull.Value.Equals(TablaProductos.Tables(0).Rows(0)("Descripcion")) Then
            Me.txtSubCorte.Text = ""
        Else
            Me.txtSubCorte.Text = TablaProductos.Tables(0).Rows(0)("Descripcion")
        End If

        Me.txtPiezas.Text = 1

        If DBNull.Value.Equals(TablaProductos.Tables(0).Rows(0)("IdPrecorte")) Then
            Me.txtCodCorte.Text = ""
        Else
            Me.txtCodCorte.Text = TablaProductos.Tables(0).Rows(0)("IdPrecorte")
        End If

        If DBNull.Value.Equals(TablaProductos.Tables(0).Rows(0)("PreCorte")) Then
            Me.txtCorte.Text = ""
        Else
            Me.txtCorte.Text = TablaProductos.Tables(0).Rows(0)("PreCorte")
        End If

        If DBNull.Value.Equals(TablaProductos.Tables(0).Rows(0)("DescripcionCorta")) Then
            Me.CveProduto = ""
        Else
            Me.CveProduto = TablaProductos.Tables(0).Rows(0)("DescripcionCorta")
        End If

        'Me.txtKilosRegistrar.Text = CDec(Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmKilosRecibidos.Index).Value).ToString("N3")
        'Me.txtPiezasRegistrar.Text = CDec(Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmPiezas.Index).Value).ToString("N3")

        Me.valorAgregado = TablaProductos.Tables(0).Rows(0)("ValorAgregado")
        Me.conHueso = TablaProductos.Tables(0).Rows(0)("ConHueso")
        'Me.prodSeleccionado = True

        ObtenerDiasCaducidad()


        '------
        TablaProductos.Clear()
        TablaProductos = New DataSet

        cadena = "exec Usp_MSCLoteCortesCon 5, '{0}' , '{1}', '', ''"
        cadena = String.Format(cadena, Me.txtLoteCorte.Text, id_producto)

        ad = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(cadena, New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)))
        Try
            ad.SelectCommand.Connection.Open()

            ad.Fill(TablaProductos)
        Catch ex As Exception


        End Try
        'Obtenemos datos del formulario
        If TablaProductos.Tables(0).Rows.Count = 0 Then
            MsgBox("No se encuentra un producto con ese codigo", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If

        If DBNull.Value.Equals(TablaProductos.Tables(0).Rows(0)("CantPzas")) Then
            Me.txtPiezasCanales.Text = ""
        Else
            Me.txtPiezasCanales.Text = TablaProductos.Tables(0).Rows(0)("CantPzas")
        End If

        If DBNull.Value.Equals(TablaProductos.Tables(0).Rows(0)("CantKgrs")) Then
            Me.txtKilosCanales.Text = ""
        Else
            Me.txtKilosCanales.Text = TablaProductos.Tables(0).Rows(0)("CantKgrs")
        End If

        If DBNull.Value.Equals(TablaProductos.Tables(0).Rows(0)("KilosRecibidos")) Then
            Me.txtKilosRegistrar.Text = ""
        Else
            Me.txtKilosRegistrar.Text = TablaProductos.Tables(0).Rows(0)("KilosRecibidos")
        End If

        If DBNull.Value.Equals(TablaProductos.Tables(0).Rows(0)("NoPiezas")) Then
            Me.txtPiezasRegistrar.Text = ""
        Else
            Me.txtPiezasRegistrar.Text = TablaProductos.Tables(0).Rows(0)("NoPiezas")
        End If

        Me.txtPiezas.Focus()
    End Sub

    Private Sub txtPiezas_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPiezas.GotFocus
        Me.txtPiezas.SelectAll()
    End Sub

    Private Sub txtPiezas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPiezas.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtPeso.Focus()
        End If
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPeso_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPeso.GotFocus
        Me.txtPeso.SelectAll()
    End Sub

    Private Sub txtPeso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPeso.KeyPress
        If e.KeyChar = Chr(13) Then
            If Not IsNumeric(Me.txtPeso.Text) OrElse Not (CInt(Me.txtPeso.Text) > 0) Then 'AndAlso CInt(Me.txtPeso.Text) < 80) Then
                MsgBox("El peso debe ser mayor a 0 Kgs.", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If

            If Not IsNumeric(Me.txtPiezas.Text) OrElse Not (CInt(Me.txtPiezas.Text) > 0) Then 'OrElse Not (CInt(Me.txtPiezas.Text) > 0 AndAlso CInt(Me.txtPiezas.Text) < 40) Then
                MsgBox("Debe ingresar las piezas", MsgBoxStyle.Exclamation, "Aviso")
                'MsgBox("Las piezas deben estar en el rango de 2 a 15", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If

            If Me.txtSubCorte.Text = "" Then
                MsgBox("Seleccione un Corte.", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If


            If Me.txtcajas.Text = "" Or Me.txtcajas.Text = "0" Then
                MsgBox("Seleccione el numero de cajas/bultos.", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If

            numcaja = txtcajas.Text
            ''nuevo modo de guardar----------------------------------------


            'If kilosrecividos < (numcaja * txtPeso.Text) Then
            '    MsgBox("El monto de kilos ingresados es mayor al monto de kilos recibidos en", MsgBoxStyle.Exclamation, "Aviso")
            '    Exit Sub
            'End If

            Dim saveResult As Boolean
            For i As Integer = 1 To numcaja
                saveResult = Me.Guardar()
                If saveResult = False Then
                    Exit For
                End If

            Next

            Dim ID_Producto As Integer = 0
            Dim transaction As SqlTransaction
            Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
                connection.Open()
                Dim command As SqlCommand = connection.CreateCommand()
                transaction = connection.BeginTransaction("SampleTransaction")
                command.Connection = connection
                command.Transaction = transaction
                Dim query As String = "exec Usp_MSCLoteCortesCon 6, '{0}', '', '', ''"
                Try
                    query = String.Format(query, Me.txtLoteCorte.Text)
                    command.CommandText = query
                    command.ExecuteNonQuery()

                    Dim Rs As SqlDataReader = command.ExecuteReader()
                    Rs.Read()
                    ID_Producto = Rs(0).ToString()
                    Rs.Close()
                    command.Transaction.Commit()
                    connection.Close()
                Catch ex As Exception
                    command.Transaction.Rollback()
                End Try

            End Using

            Me.txtPeso.Text = "0"
            Me.txtPiezas.Text = "1"
            Me.txtcajas.Text = "0"

            If ID_Producto > 0 Then
                MsgBox("Se han registrado exitosamente el total de kgs en cada producto, a continuación se procederá a cerrar los cortes", MsgBoxStyle.Information, "AVISO")
                'Me.Enabled = False
                Me.txtcajas.Enabled = False
                Me.txtPiezas.Enabled = False
                Me.txtPeso.Enabled = False
                Me.chkActivarLectura.Enabled = False
                Me.dgvEtiquetas.Enabled = False

                Me.txtCerrado.Show()
            End If

            If saveResult = True Then
                Me.txtcajas.Focus()
            End If
            'If Me.Guardar() Then
            '    Me.txtCodSubCorte.Focus()
            'End If
        End If

        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodSubCorte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodSubCorte.TextChanged

    End Sub

    Private Sub txtPiezas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPiezas.TextChanged

    End Sub

    Private Sub txtPeso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPeso.TextChanged

    End Sub

    Private Sub txtLeerPeso_SerialDataArrived(ByVal sender As System.Object, ByVal e As wclTextBoxSerial.SerialDataArrivedEventArgs) Handles txtLeerPeso.SerialDataArrived
        'En e.Data esta el grupo de caracteres recibidos desde el puerto serial
        If e.Data.Length >= 50 Then 'Si llegan 25 caracteres procesarlos
            Dim res As String = (ClasesNegocio.LecturaBasculaClass.ObtenerPeso(e.Data.Substring(0, 50), _
                                LecturaBasculaClass.TipoLectura.GRAMOS, _
                                LecturaBasculaClass.TipoLectura.KILOGRAMOS) / 10D).ToString("N2") 'Se divide entre 10 por q la bascula de cortes arroja 3 decimales
            Me.txtPeso.Text = res
        Else
            e.Handled = True 'Ignora los caracteres
        End If
    End Sub
#End Region

#Region "ComboBox"
    Private Sub cmdBuscarCortes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarCortes.Click
        Try
            Dim TablaProductos As New DataSet
            Dim Consultas As New FrmConsultaCortes

            Productos = New ClasesNegocio.ProductosClass
            TablaProductos = Productos.Obtener(0, "", 0, 9)

            If TablaProductos.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No existen cortes para captura", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Consultas.dgvCortes.AutoGenerateColumns = False
                Consultas.dgvCortes.DataSource = TablaProductos.Tables(0)
                Consultas.Codigo.DataPropertyName = "IdCorte"
                Consultas.Descripcion.DataPropertyName = "Descripcion"
                Consultas.Piezas.DataPropertyName = "MaximoPiezasxCaja"
                Consultas.CodigoPrecorte.DataPropertyName = "IdPrecorte"
                Consultas.DescripcionPrecorte.DataPropertyName = "PreCorte"
                Consultas.clmDescCorta.DataPropertyName = "DescripcionCorta"

                If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If DBNull.Value.Equals(TablaProductos.Tables(0).Rows(Consultas.dgvCortes.SelectedRows(0).Index)("NombreIngles")) Then
                        nombreIngles = ""
                    Else
                        nombreIngles = TablaProductos.Tables(0).Rows(Consultas.dgvCortes.SelectedRows(0).Index)("NombreIngles")
                    End If
                    'Modificar los dos txtCodSubCorte txtSubCorte
                    Me.txtCodSubCorte.Text = Consultas.dgvCortes.CurrentRow.Cells("Codigo").Value
                    Me.txtSubCorte.Text = Consultas.dgvCortes.CurrentRow.Cells("Descripcion").Value
                    Me.txtPiezas.Text = 1

                    If DBNull.Value.Equals(Consultas.dgvCortes.CurrentRow.Cells("CodigoPreCorte").Value) Then
                        Me.txtCodCorte.Text = ""
                    Else
                        Me.txtCodCorte.Text = Consultas.dgvCortes.CurrentRow.Cells("CodigoPreCorte").Value
                    End If

                    If DBNull.Value.Equals(Consultas.dgvCortes.CurrentRow.Cells("DescripcionPreCorte").Value) Then
                        Me.txtCorte.Text = ""
                    Else
                        Me.txtCorte.Text = Consultas.dgvCortes.CurrentRow.Cells("DescripcionPreCorte").Value
                    End If

                    If DBNull.Value.Equals(Consultas.dgvCortes.CurrentRow.Cells("clmDescCorta").Value) Then
                        Me.CveProduto = ""
                    Else
                        Me.CveProduto = Consultas.dgvCortes.CurrentRow.Cells("clmDescCorta").Value
                    End If

                    Me.valorAgregado = TablaProductos.Tables(0).Rows(Consultas.dgvCortes.CurrentRow.Index)("ValorAgregado")
                    'Me.prodSeleccionado = True

                    ObtenerDiasCaducidad()

                    Me.txtPiezas.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdLeerArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLeerArchivo.Click
        Try
            Dim strRuta As String
            Dim archivo As New OpenFileDialog
            Dim ListadeCortes As List(Of String) 'lista para guardar los codigos de barra a guardar en la tabla de cortes
            Dim ConfiguracionEtiqueta As New DataSet 'busca el detalle de la configuracion de etiqueta.
            Dim TablaProductos As New DataSet 'tabla de productos
            Dim ProductosRastros As New DataSet 'tabla de relacion de productos de rastros
            Dim CodigoRastro As String 'variable para buscar el codigo del rastro en la tabla de relaciones
            Dim CodigoPropio As String 'variable para codigo que se encuentra registrado en la tabla de productos propia

            Productos = New ClasesNegocio.ProductosClass
            'obtener configuracion.
            ConfiguracionEtiqueta = Utilerias.EjecutarSQL("Select * From ConfiguracionLecturaEtiqueta", "ConfiguracionLecturaEtiqueta", HC.DbUtils.ActualConnectionString)
            'lectura de archivo
            archivo.Filter = "*.txt |*.txt"

            If archivo.ShowDialog = Windows.Forms.DialogResult.OK Then
                strRuta = archivo.FileName
                Me.mostarMensajes = False

                ListadeCortes = Utilerias.LeerArchivodeTexto(strRuta)
                'Me.txtFolioReferencia.Text = Utilerias.LeerArchivodeTexto(strRuta)
                For i As Integer = 0 To ListadeCortes.Count - 1
                    Me.txtFolioReferencia.Text = ListadeCortes.Item(i)
                    Dim loteCorteDetC As New CC.MscloteCortesDetCollection

                    loteCorteDetC.GetMulti(HC.MscloteCortesDetFields.CodigoBarra = Me.txtFolioReferencia.Text)

                    If loteCorteDetC.Count > 0 Then
                        MsgBox("La etiqueta " & loteCorteDetC.Item(0).IdFolioEtiqueta & Chr(13) & _
                                "Con el codigo de barra " & loteCorteDetC.Item(0).CodigoBarra & Chr(13) & _
                                "Con el Peso " & loteCorteDetC.Item(0).CantKgrs & "ESTA DUPLICADA", MsgBoxStyle.Information, "")
                    Else
                        Me.txtPeso.Text = Mid(Me.txtFolioReferencia.Text, ConfiguracionEtiqueta.Tables(0).Rows(0)("KilosColumnaInicial"), ConfiguracionEtiqueta.Tables(0).Rows(0)("KilosLongitud"))
                        Me.txtPeso.Text = Mid(Me.txtPeso.Text, 1, 4) & "." & Mid(Me.txtPeso.Text, 5, 2)
                        Me.txtPiezas.Text = 1
                        'busca el codigo del producto en la tabla de relacion del rastro
                        CodigoRastro = Mid(Me.txtFolioReferencia.Text, ConfiguracionEtiqueta.Tables(0).Rows(0)("CodigoColumnaInicial"), ConfiguracionEtiqueta.Tables(0).Rows(0)("CodigoLongitud"))
                        ProductosRastros = Utilerias.EjecutarSQL("Select * From MSCRelacionProductosRastros where CodProductoRastro=" & CodigoRastro, "MSCRelacionProductosRastros", HC.DbUtils.ActualConnectionString)
                        CodigoPropio = ProductosRastros.Tables(0).Rows(0)("CodProducto").ToString
                        'buscar producto y lo guarda en la tabla de cortes                  
                        TablaProductos = Productos.Obtener(CodigoPropio, "", 0, 7)
                        Me.txtCodSubCorte.Text = TablaProductos.Tables(0).Rows(0)("IdCorte").ToString
                        Me.txtCodCorte.Text = TablaProductos.Tables(0).Rows(0)("IdPreCorte").ToString
                        Me.txtCorte.Text = TablaProductos.Tables(0).Rows(0)("PreCorte").ToString
                        Me.txtSubCorte.Text = TablaProductos.Tables(0).Rows(0)("Corte").ToString

                        'Exit For
                        Guardar()
                    End If
                Next

                MsgBox("Se ha generado lote de cortes", MsgBoxStyle.Information, "AVISO")
                Limpiar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.mostarMensajes = True
        End Try
    End Sub

    Private Sub cmbClientes_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbClientes.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            Dim ClientesCol As New ClasesNegocio.ClientesIntroductoresColeccion
            Dim Cliente As New ClasesNegocio.ClientesIntroductoresClass
            Cliente.Nombre = "NINGUNO"
            ClientesCol.Add(Cliente)

            Dim ClientesAux As New ClasesNegocio.ClientesIntroductoresColeccion
            ClientesAux.Obtener(CondicionEstatusEnum.ACTIVO)
            For Each Cli As ClasesNegocio.ClientesIntroductoresClass In ClientesAux
                ClientesCol.Add(Cli)
            Next
        End If
    End Sub
#End Region

#Region "Form"
    Private Sub FrmCapturaProdTerminado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Controlador.Configuracion.ActualizarProduccion()

            If Controlador.Configuracion.Produccion.Entidad.IsNew Then
                MsgBox("Debe estableces una configuración de producción", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If

            If Controlador.Configuracion.Produccion.TrabajarLotesSacrificiosAbiertos Then
                Dim Ventana As New _960BusquasedaLotesDeCortes

                Ventana.Icon = Me.Icon
                Ventana.gbEstatus.Enabled = False
                Ventana.chkVigentes.Checked = True
                Ventana.chkCerrado.Checked = False
                Ventana.chkReproceso.Checked = True
                Ventana.chkProduccion.Checked = True

                If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.txtLoteCorte.Text = Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmLoteCorte.Index).Value
                    Me.txtDiasCad.Text = Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmDiasCad.Index).Value
                    Me.dtpFechaCaducidad.Value = CDate(Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmFechaCorte.Index).Value).AddDays(CInt(Me.txtDiasCad.Text))
                    Me.txtProveedor.Text = Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmIntroductor.Index).Value
                    'Me.txtCodSubCorte.Text = Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmproducto.Index).Value

                    Me.txtKilosRegistrar.Text = CDec(Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmKilosRecibidos.Index).Value).ToString("N3")
                    Me.txtPiezasRegistrar.Text = CDec(Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmPiezas.Index).Value).ToString("N3")

                    If Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.precioxkilototal.Index).Value IsNot DBNull.Value Then
                        precioxkilo = Convert.ToDecimal(Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.precioxkilototal.Index).Value)
                    Else
                        precioxkilo = 0
                    End If


                    If Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmKilosRecibidos().Index).Value IsNot DBNull.Value Then
                        kilosrecividos = Convert.ToDecimal(Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmKilosRecibidos().Index).Value)
                    Else
                        kilosrecividos = 0
                    End If

                    Dim query As String = "exec Usp_MSCLoteCortesCon 4, '{0}' , '', '', ''"
                    query = String.Format(query, Me.txtLoteCorte.Text, "")
                    Me.cmbCortes.DisplayMember = "Descripcion"
                    Me.cmbCortes.ValueMember = "IdCorte"
                    'Me.cmbCortes.SelectedIndex = -1
                    Dim ID_Producto As Integer = 0
                    Dim tb As New DataTable
                    Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
                    Using sqlcom As New SqlCommand(query, sqlCon)
                        Dim adp As New SqlDataAdapter(sqlcom)
                        sqlCon.Open()
                        adp.Fill(tb)
                        cmbCortes.DataSource = tb
                        If tb.Rows.Count > 0 Then
                            ID_Producto = CInt(tb.Rows(0)("IdCorte"))
                        End If

                        'Mee
                        'tb.Ta()
                        'If cmbCortes.Items.Count > 0 Then
                        '    Me.cmbCortes.SelectedIndex = 0
                        'End If

                        sqlCon.Close()
                    End Using

                    buscarcortes(ID_Producto)

                Else
                    For Each control As Control In Me.Controls
                        control.Enabled = False
                    Next

                    Exit Sub
                End If
            End If

            'Dim LoteAbierto As DataSet
            Dim DetalleLote As DataSet

            'If txtLoteCorte.Text = "" Then
            '    LoteAbierto = LoteCorte.Obtener(3, "")

            '    If LoteAbierto.Tables(0).Rows.Count = 0 Then
            '        MessageBox.Show("No existe lote de corte disponible", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        Exit Sub
            '        'Me.Dispose()                
            '    End If

            '    Me.txtLoteCorte.Text = LoteAbierto.Tables(0).Rows(0)("IdFolioLoteCorte")
            '    Me.txtDiasCad.Text = LoteAbierto.Tables(0).Rows(0)("DiasCad")
            '    'Me.dtpFechaCaducidad.Value.AddDays(Double.Parse(Me.txtDiasCad.Text))
            'End If
            Dim loteCab As New ClasesNegocio.CortesClass(Me.txtLoteCorte.Text.Trim())
            dtpFechaCaducidad.Value = loteCab.FechaCad
            txtDiasCad.Text = loteCab.DiasCad.ToString()
            'txtKilosCanales.Text = loteCab.TotalKgs.ToString("N3")
            'txtPiezasCanales.Text = loteCab.TotalPzas.ToString()



            'Me.txtProveedor.Text = LoteAbierto.Tables(0).Rows(0)("Nombre")
            DetalleLote = LoteCorteDetalle.Obtener(Me.txtLoteCorte.Text.Trim)

            If DetalleLote.Tables(0).Rows.Count > 0 Then
                Me.dgvEtiquetas.AutoGenerateColumns = False
                Me.dgvEtiquetas.DataSource = DetalleLote.Tables(0)
                Me.IdFolioEtiqueta.DataPropertyName = "IdFolioEtiqueta"
                Me.IdCorte.DataPropertyName = "IdCorte"
                Me.Nom_Corte.DataPropertyName = "Nom_Corte"
                Me.IdProducto.DataPropertyName = "IdProducto"
                Me.Nom_SubCorte.DataPropertyName = "Nom_SubCorte"
                Me.CantPzas.DataPropertyName = "CantPzas"
                Me.CantKgrs.DataPropertyName = "CantKgrs"
            End If

            Dim detcanalcorte As New DetCanalACorteColeccion

            'Me.txtPiezasCanales.Text = detcanalcorte.Obtener(Me.txtLoteCorte.Text)

            Dim Kilos As Decimal = 0

            For i As Integer = 0 To detcanalcorte.Count - 1
                Kilos += detcanalcorte(i).KgrsEnCorte
            Next

            'Me.txtKilosCanales.Text = Kilos.ToString("N2")

            Sumar()

            Dim ClientesCol As New ClasesNegocio.ClientesIntroductoresColeccion
            Dim Cliente As New ClasesNegocio.ClientesIntroductoresClass

            Cliente.Nombre = "NINGUNO"
            ClientesCol.Add(Cliente)

            Dim ClientesAux As New ClasesNegocio.ClientesIntroductoresColeccion

            ClientesAux.Obtener(CondicionEstatusEnum.ACTIVO)

            For Each Cli As ClasesNegocio.ClientesIntroductoresClass In ClientesAux
                ClientesCol.Add(Cli)
            Next

            Me.cmbClientes.ValueMember = "Codigo"
            Me.cmbClientes.DisplayMember = "Nombre"
            Me.cmbClientes.DataSource = ClientesCol
            cmbClientes.SelectedIndex = 0

            Me.ConfigurarPuerto()
            AddHandler pdDocumento.PrintPage, AddressOf Imprime_Documento
            ppdVisor.Document = pdDocumento
            'Me.dtpFechaLoteCorte.Value = LoteAbierto.Tables(0).Rows(0)("FechaCorte")
            'Me.dtpFechaCaducidad.Value = LoteAbierto.Tables(0).Rows(0)("FechaCad")
            'Me.txtDiasCaducidad.Text = LoteAbierto.Tables(0).Rows(0)("DiasCad")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "DataGrid"
    Private Sub dgvEtiquetas_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dgvEtiquetas.PreviewKeyDown
        Try
            If e.KeyCode = Keys.Delete Then
                If Me.dgvEtiquetas.SelectedRows.Count > 0 Then
                    If MessageBox.Show("¿Esta seguro de borrar el corte?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        With Me.dgvEtiquetas.SelectedRows(0)
                            If GuardarSalida(.Cells(Me.IdFolioEtiqueta.Index).Value, .Cells(Me.IdProducto.Index).Value, _
                                            CDec(.Cells(Me.CantKgrs.Index).Value), CDec(.Cells(Me.CantPzas.Index).Value)) Then
                                Me.dgvEtiquetas.Rows.RemoveAt(Me.dgvEtiquetas.SelectedRows(0).Index)
                            End If
                        End With
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "CheckBox"
    Private Sub chkActivarLectura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivarLectura.CheckedChanged
        Try
            If Me.chkActivarLectura.Checked Then
                Me.txtLeerPeso.OpenPort()
                Me.chkActivarLectura.Text = "Lectura de Peso Activada"
                Me.txtPeso.ReadOnly = True
                Me.txtPeso.Focus()
            Else
                Me.txtLeerPeso.ClosePort()
                Me.chkActivarLectura.Text = "Lectura de Peso Desactivada"
                Me.txtPeso.ReadOnly = False
                Me.txtPeso.Focus()
            End If
        Catch UAex As UnauthorizedAccessException
            MsgBox("No se pudo conectar a la bascula, pruebe que este encendida o que no se este usando una lectura de bascula en otra ventana o aplicación", MsgBoxStyle.Exclamation, "Aviso")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "Otros"

#End Region
#End Region

    Private Sub chkTipoCorte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTipoCorte.CheckedChanged
        ObtenerDiasCaducidad()

        If Me.chkTipoCorte.Checked Then
            Me.chkTipoCorte.Text = "Congelado"
        Else
            Me.chkTipoCorte.Text = "Fresco"
        End If
    End Sub

    Private Sub chkEdadGanado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEdadGanado.CheckedChanged
        If Me.chkEdadGanado.Checked Then
            Me.chkEdadGanado.Text = "+30"
        Else
            Me.chkEdadGanado.Text = "-30"
        End If
    End Sub

    Private Sub dgvEtiquetas_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvEtiquetas.SizeChanged

    End Sub

    Private Sub CmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdImprimir.Click

    End Sub

    Private Sub cmbCortes_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCortes.SelectedValueChanged
        If Me.cmbCortes.SelectedValue <> Nothing Then
            Me.buscarcortes(Me.cmbCortes.SelectedValue.ToString())
            'exec Usp_MSCLoteCortesCon 5, '190218051' , '2', '', ''


        End If

    End Sub

    'Private Sub verificarKilos(ByVal CantPzas As Decimal, ByVal CantKgrs As Decimal, ByVal KilosRecibidos As Decimal, ByVal Nopiezas As Decimal)

    '    'CantPzas, CantKgrs, KilosRecibidos, Nopiezas
    '    If (CantKgrs + LoteCorte.TotalKgs) > KilosRecibidos Then
    '        Trans.Rollback()
    '        MessageBox.Show("Los kilos registrados exceden los kilos comprados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False
    '    End If

    '    If (CantPzas + LoteCorte.TotalPzas) > Nopiezas Then
    '        Trans.Rollback()
    '        MessageBox.Show("Las piezas registradas exceden las piezas compradas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False

    'End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click

        Dim resultado As Integer = MessageBox.Show("El total de kilos no cuandra con los kilos registrados ¿Desea continuar? ",
                           "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1)

        If resultado = DialogResult.OK Then

            numcaja = txtcajas.Text
            ''nuevo modo de guardar----------------------------------------


            'If kilosrecividos < (numcaja * txtPeso.Text) Then
            '    MsgBox("El monto de kilos ingresados es mayor al monto de kilos recibidos en", MsgBoxStyle.Exclamation, "Aviso")
            '    Exit Sub
            'End If

            Dim saveResult As Boolean
            For i As Integer = 1 To numcaja
                saveResult = Me.Guardar()
                If saveResult = False Then
                    Exit For
                End If

            Next

            Dim ID_Producto As Integer = 0
            Dim transaction As SqlTransaction
            Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
                connection.Open()
                Dim command As SqlCommand = connection.CreateCommand()
                transaction = connection.BeginTransaction("SampleTransaction")
                command.Connection = connection
                command.Transaction = transaction
                Dim query As String = "exec Usp_MSCLoteCortesCon 7, '{0}', '', '', ''"
                Try
                    query = String.Format(query, Me.txtLoteCorte.Text)
                    command.CommandText = query
                    command.ExecuteNonQuery()

                    Dim Rs As SqlDataReader = command.ExecuteReader()
                    Rs.Read()
                    ID_Producto = Rs(0).ToString()
                    Rs.Close()
                    command.Transaction.Commit()
                    connection.Close()
                Catch ex As Exception
                    command.Transaction.Rollback()
                End Try
            End Using

            Me.txtPeso.Text = "0"
            Me.txtPiezas.Text = "1"
            Me.txtcajas.Text = "0"

            If saveResult = True Then
                Me.txtcajas.Focus()
            End If
            'If Me.Guardar() Then
            '    Me.txtCodSubCorte.Focus()
            'End If
            'End If
            'If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "." Then
            '    e.Handled = True
            'End If
            'Limpiar()123
            btnCerrar.Enabled = False
            btnBuscarTxt.Enabled = False
        ElseIf resultado = DialogResult.Cancel Then
            'No hace nada
        End If
    End Sub

    Private Sub btnBuscarTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarTxt.Click

        Dim strem As Stream = Nothing
        Dim ofdBucarTxt As New OpenFileDialog()


        'Detalles del openfiledialog
        ofdBucarTxt.InitialDirectory = "C:\"
        ofdBucarTxt.Filter = "txt files (*.txt)|*.txt"
        ofdBucarTxt.FilterIndex = 2
        ofdBucarTxt.RestoreDirectory = True

        If ofdBucarTxt.ShowDialog() = Windows.Forms.DialogResult.OK Then
            strem = ofdBucarTxt.OpenFile()
            If (strem IsNot Nothing) Then
                'llamar metodo validar para verificar
                validarTxt(ofdBucarTxt.FileName.ToString())
            End If
        End If

    End Sub

    Private Sub validarTxt(ByVal ruta As String)

        Dim separador() As String = {"-"}
        Dim productosTxt As String 'para guardar lo hay en el txt 
        Dim producto() As String 'se usa para hacer el split de productostxt
        Dim codigo() As String 'se usa para hacer split en la cadena de producto
        Dim codigoBarraArray As New ArrayList
        Dim kls As Double
        Dim punteroCb As Integer
        productosTxt = My.Computer.FileSystem.ReadAllText(ruta.ToString())
        producto = productosTxt.Split(New String() {Environment.NewLine}, StringSplitOptions.None) 'hace el split con salto de linea

        Try
            'ciclo para validar que los productos existen
            For Each elemento As String In producto 'separa el txt en cadenas cada salto de linea y las guarda en elemento

                codigo = elemento.Split(separador, StringSplitOptions.RemoveEmptyEntries) 'hace split a las cadenas creadas anteriormente
                'totalkilosproductos = totalkilosproductos + Convert.ToDouble(codigo(1)) 'se acumula para verificar compara con el total de los productos        
                If (Not codigoBarraArray.Contains(codigo(0))) Then 'cuando el CB sea diferente se agrana al arreglo y se registra
                    codigoBarraArray.Add(codigo(0))
                    'piezasRegistradas.Add(codigo(0), 0)
                    If (verificarProducto(codigo(0))) = False Then
                        MessageBox.Show("El codigo de barra '" + codigo(0) + "' no esta relacionado con ningun producto", "Producto no entontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub 'si algun CB no se encuantra en la BD se termina la operacion y no se registra
                        Exit For
                    End If
                End If

                'piezasRegistradas(codigo(0)) += 1
                'If (totalPiezas(codigo(0)) < piezasRegistradas(codigo(0))) Then
                '    MessageBox.Show("El numero de piezas del producto: '" + codigo(0) + "' a sobrepasado al total, verifique el archivo TXT.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    Exit Sub
                'End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        'verifica que los kilos del txt sean los mismo que los registrados
        'totalkilosproductos = Math.Round(totalkilosproductos, 4)
        'If verificarkilos() = False Then
        '    MessageBox.Show("El total de kilos registrados en el txt exceden a los kilos comprados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        codigoBarraArray.Clear()
        punteroCb = 0
        For Each elemento As String In producto
            Try
                codigo = elemento.Split(separador, StringSplitOptions.RemoveEmptyEntries)
                kls = Convert.ToDouble(codigo(1))
                kls = Math.Round(kls, 4)
                If (cmbCortes.Text <> diccionario(codigo(0))) Then 'cuando los producto sean diferente entra.           kls > Convert.ToDouble(txtKilosRegistrar.Text)
                    codigoBarraArray.Add(cmbCortes.Text)
                    If (codigoBarraArray.Contains(codigo(0))) Then
                        punteroCb = cmbCortes.FindString(diccionario(codigo(0)))
                        cmbCortes.SelectedIndex = punteroCb
                        txtKilosCanales.Text = (Convert.ToDouble(txtKilosCanales.Text) + kls)
                    Else
                        punteroCb = cmbCortes.FindString(diccionario(codigo(0)))
                        'kls = Convert.ToDouble(codigo(1)) 'se resetea kls con el ultimo valor ingresado que sera el primero del proximo producto cuando se actualize el combobox
                        cmbCortes.SelectedIndex = punteroCb ' hace set al combobox(actualiza)
                        txtKilosCanales.Text = (Convert.ToDouble(txtKilosCanales.Text) + kls)
                    End If

                End If
                txtPeso.Text = codigo(1) 'se hace set para registrar los kls de cada uno de los productos en el grid
                Guardar()

            Catch ex As Exception
                MessageBox.Show("Erro al insertar los datos del archivo de texto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        Next

        'Si todo sale bien manda mensaje 
        txtPeso.Text = "0"

        'cerraLoteTxt(txtLoteCorte.Text) cabia el status a cancelado manualmente

        MsgBox("Se han registrado los kgs de los producto del archivo txt, verfique antes de cerrar corte", MsgBoxStyle.Information, "AVISO")

        Me.txtcajas.Enabled = False
        Me.txtPiezas.Enabled = False
        Me.txtPeso.Enabled = False
        Me.chkActivarLectura.Enabled = False
        Me.dgvEtiquetas.Enabled = False
        Me.btnBuscarTxt.Enabled = False
        Me.txtCerrado.Show()
        btnBuscarTxt.Enabled = False

    End Sub

    'metodo para verificar si el producto existe en la base de da7787os
    Private Function verificarProducto(ByVal productocdg As String) As Boolean

        Dim query As String = "exec Ups_VerificarProducto '{0}','{1}'"
        query = String.Format(query, productocdg, txtLoteCorte.Text)
        Dim existeProducto As Boolean = False
        Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)

        Using sqlcom As New SqlCommand(query, sqlCon)
            sqlCon.Open()
            Dim Rs As SqlDataReader = sqlcom.ExecuteReader()
            If Rs.Read() Then 'si lee, existe producto
                existeProducto = True
                diccionario.Add(productocdg, Rs.GetString(0)) 'Agrega al diccionario (Codigo Barra, ID)
                'totalPiezas.Add(productocdg, Rs.GetInt32(1)) 'se usa para verificar que las cajas registradas no sean mayor a las de la compra
                'Return Rs.GetInt32(0)
            End If
            Rs.Close()
            sqlCon.Close()
        End Using
        Return existeProducto
    End Function
    'Verfica que el total de kilos registrados sea igual o menor que los que estan en el txt (recibe el total de kilos del txt)
    'Private Function verificarkilos() As Boolean
    '    Dim query As String = "select sum(KilosRecibidos) from MSCLoteCortesDetProductos where LoteCorte = '" + txtLoteCorte.Text + "'"
    '    Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
    '    Dim totalReal As String
    '    Using sqlcom As New SqlCommand(query, sqlCon)
    '        sqlCon.Open()
    '        Dim Rs As SqlDataReader = sqlcom.ExecuteReader()
    '        Rs.Read()
    '        totalReal = Rs(0).ToString()
    '        Rs.Close()
    '        sqlCon.Close()
    '        If (Convert.ToDouble(totalReal) < totalkilosproductos) Then
    '            Return False
    '        End If
    '    End Using
    '    Return True
    'End Function
End Class