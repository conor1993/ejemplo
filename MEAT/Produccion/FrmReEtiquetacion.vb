Imports CN = ClasesNegocio
Imports TC = Integralab.ORM.TypedViewClasses
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio
Imports System.IO
Imports System.Drawing.Text
Imports BRC = BarCode
Imports System.Drawing.Imaging

Public Class FrmReEtiquetacion

#Region "Miembros"

    Dim CodCorte As Integer
    Dim CodCorte2 As Integer
    Dim NomCorte As String
    Dim Grados As Integer
    Dim Inicio As Boolean
    Dim ClientesCol As New CN.ClientesIntroductoresColeccion
    Dim ultimoCorte As EC.MscloteCortesDetEntity
    Private nPag As Integer
    Private etiquetas As New List(Of EtiquetasImprimir)
    Dim PuntosCol As CC.MgralcatPuntosEntregaCollection
    Dim etiqueta As EtiquetasImprimir
    Dim cveProducto As String

#End Region

#Region "Metodos"
    Private Sub Limpiar()
        'Me.txtCorte.Text = ""
        'Me.txtEtiqueta.Text = ""
        Me.txtEmbarque.Text = ""
        'Me.txtLoteCorte.Text = ""
        'Me.txtPiezas.Text = ""
        'Me.txtPrecorte.Text = ""
        'Me.DptFechaCad.Value = Now
        Me.DtpFechaCadNva.Value = Now
        'Me.DtpFechaCorte.Value = Now
        Me.CmbCliente.SelectedIndex = -1
        Me.txtLoteCorte.Clear()
        cveProducto = ""
        Me.nudCopias.Value = 1
        'Me.txtKilos.Text = ""
    End Sub

    Private Sub Habilitar()
        Me.CmbCliente.Enabled = True
        Me.DtpFechaCadNva.Enabled = True
    End Sub

    Private Sub DesHabilitar()
        Me.CmbCliente.Enabled = False
        Me.DtpFechaCadNva.Enabled = False
    End Sub

    'Private Sub Imprime_Documento(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
    '    Try
    '        Dim f10 As New Font("Arial", 10) 'formato de impresion Arial tamaño 10
    '        Dim fn10 As New Font("Arial", 10, FontStyle.Bold) 'formato de impresion Arial tamaño 10 Negrita

    '        Dim agregarRenglon As Integer = 5
    '        'Me.Codigobarras.Message = etiqueta.CodigoBarras

    'e.Graphics.DrawString(etiqueta.NombreProducto, New Font("Arial", 18, FontStyle.Bold), _
    '                        Brushes.Black, 20, 11 + agregarRenglon)
    'e.Graphics.DrawString("EMPAQUE:", f10, Brushes.Black, 20, 35 + agregarRenglon)
    'e.Graphics.DrawString("CADUCIDAD:", f10, Brushes.Black, 20, 50 + agregarRenglon)
    'e.Graphics.DrawString(etiqueta.FechaEmpaque.ToShortDateString, fn10, Brushes.Black, _
    '                        110, 35 + agregarRenglon)
    'e.Graphics.DrawString(etiqueta.FechaCaducidad.ToShortDateString, fn10, Brushes.Black, _
    '                        110, 50 + agregarRenglon)
    'e.Graphics.DrawString("PIEZAS:", f10, Brushes.Black, 185, 43 + agregarRenglon)
    'e.Graphics.DrawString(etiqueta.Piezas, New Font("Arial", 18, FontStyle.Bold), Brushes.Black, _
    '                        239, 35 + agregarRenglon)
    'e.Graphics.DrawString(etiqueta.Peso.ToString("N2"), New Font("Arial", 26, FontStyle.Bold), _
    '                        Brushes.Black, 259, 31 + agregarRenglon)
    'e.Graphics.DrawString("Kgs.", New Font("Arial", 10, FontStyle.Bold), _
    '                        Brushes.Black, 360, 50 + agregarRenglon)
    'e.Graphics.DrawString("CODIGO:", f10, Brushes.Black, 185, 65 + agregarRenglon)
    '        e.Graphics.DrawString(etiqueta.IdProducto, New Font("Arial", 11, FontStyle.Bold), _
    '                                Brushes.Black, 245, 64 + agregarRenglon)
    '        e.Graphics.DrawString("Hora: " & etiqueta.FechaCorte.ToString("HH:mm:ss"), fn10, _
    '                                Brushes.Black, 20, 65 + agregarRenglon)
    '        e.Graphics.DrawString("#", New Font("Wingdings 3", 40, FontStyle.Bold), _
    '                                Brushes.Black, 20, 80 + agregarRenglon)
    '        'e.Graphics.DrawImage(Me.Codigobarras.Picture, 65, 83 + agregarRenglon, 285, 60)
    '        e.Graphics.DrawString(etiqueta.Edad, New Font("Arial", 18, FontStyle.Bold), Brushes.Black, 350, _
    '                                90 + agregarRenglon)
    '        e.Graphics.DrawString(etiqueta.TipoProductoDescripcion.Substring(etiqueta.TipoProductoDescripcion.IndexOf("/"c) + 1, _
    '                                etiqueta.TipoProductoDescripcion.Length - _
    '                                etiqueta.TipoProductoDescripcion.IndexOf("/"c) - 1), _
    '                                fn10, Brushes.Black, 20, 145 + agregarRenglon)
    '        e.Graphics.DrawString("LOTE:", f10, Brushes.Black, 20, 162 + agregarRenglon)
    '        e.Graphics.DrawString(etiqueta.LoteCorte, New Font("Arial", 14, FontStyle.Bold), _
    '                                Brushes.Black, 60, 158 + agregarRenglon)
    '        e.Graphics.DrawString("CONSERVAR A:", f10, Brushes.Black, 240, 145 + agregarRenglon)
    '        e.Graphics.DrawString(etiqueta.Grados & "°C", fn10, Brushes.Black, 350, 145 + agregarRenglon)
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

    '        If Controlador.Configuracion.Produccion.EsTIFLogo Then
    '            e.Graphics.DrawImage(Me.ListaImagenes.Images(1), 295, 175 + agregarRenglon, 100, 100)
    '        End If

    '        nPag += 1

    '        If nPag < Me.nudCopias.Value Then
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
            If CmbCliente.SelectedIndex > -1 Then
                Dim nombreProductoCliente As New EC.MscrelacionCortesClientesEntity
                'nombreProducto = Me.txtSubCorte.Text
                'codigoProducto = Me.txtCodSubCorte.Text
                Dim cte As New ClientesIntroductoresClass(CInt(CmbCliente.SelectedValue))
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
                'Else
                '    nombreProducto = Me.txtSubCorte.Text
                '    codigoProducto = Me.txtCodSubCorte.Text
            End If
            ''NOMBRE DE PRODUCTO
            e.Graphics.DrawString(etiqueta.NombreProducto, New Font("Arial Narrow", 15, FontStyle.Bold), _
                                    Brushes.Black, 13, 115)
            ''FRESCA O CONGELADA
            e.Graphics.DrawString(etiqueta.TipoProductoDescripcion.Substring(etiqueta.TipoProductoDescripcion.IndexOf("/"c) + 1, _
                                    etiqueta.TipoProductoDescripcion.Length - _
                                    etiqueta.TipoProductoDescripcion.IndexOf("/"c) - 1), _
                                    New Font("Arial Narrow", 14, FontStyle.Regular), Brushes.Black, 13, 136)
            ''TEMPERATURA
            e.Graphics.DrawString("Consérvese refrigerado  " + etiqueta.Grados.ToString() + "°C", New Font("Arial Narrow", 14, FontStyle.Regular), Brushes.Black, 13, 157)
            ''PESO
            e.Graphics.DrawString("Peso neto: ", New Font("Arial Narrow", 14, FontStyle.Regular), _
                                    Brushes.Black, 11, 178)
            e.Graphics.DrawString(CDec(etiqueta.Peso).ToString("N3") + " Kgs", New Font("Arial Narrow", 15, FontStyle.Bold), _
                                    Brushes.Black, 95, 178)
            ''Lote
            e.Graphics.DrawString("Lote: ", New Font("Arial Narrow", 12, FontStyle.Regular), _
                                    Brushes.Black, 280, 204)
            e.Graphics.DrawString(etiqueta.LoteCorte, New Font("Arial Narrow", 12, FontStyle.Bold), _
                                    Brushes.Black, 310, 204)
            ''Fecha Produccion
            e.Graphics.DrawString("Fecha producción: ", New Font("Arial Narrow", 12, FontStyle.Regular), _
                                    Brushes.Black, 193, 221)
            e.Graphics.DrawString(etiqueta.FechaCorte.ToShortDateString, New Font("Arial Narrow", 12, FontStyle.Bold), _
                                    Brushes.Black, 310, 221)
            ''Fecha caducidad
            e.Graphics.DrawString("Fecha caducidad: ", New Font("Arial Narrow", 12, FontStyle.Regular), _
                                    Brushes.Black, 198, 238)
            e.Graphics.DrawString(etiqueta.FechaCaducidad.ToShortDateString, New Font("Arial Narrow", 12, FontStyle.Bold), _
                                    Brushes.Black, 310, 238)
            ''Folio o ID
            e.Graphics.DrawString("ID: ", New Font("Arial Narrow", 12, FontStyle.Regular), _
                                    Brushes.Black, 293, 255)
            e.Graphics.DrawString(etiqueta.FolioEtiqueta.Substring(etiqueta.FolioEtiqueta.Length - 4, 4), New Font("Arial Narrow", 12, FontStyle.Bold), _
                                    Brushes.Black, 310, 255)

            ''Clave del producto
            e.Graphics.DrawString(cveProducto, New Font("Arial Narrow", 38, FontStyle.Bold), _
                                    Brushes.Black, 12, 200)

            ''codigo barra
            e.Graphics.DrawImage(GeneraCodBarra(etiqueta.CodigoBarras), 70, 290, 265, 75)

            
            'tocb.

            'Dim fonts As PrivateFontCollection

            'Dim fontF As FontFamily
            'fontF = LoadFontFamily(Application.StartupPath + "\code128.ttf", fonts)


            ''e.Graphics.DrawImage(TextoAImagen(BRC.BarcodeConverter128.StringToBarcode(etiqueta.CodigoBarras), font, Color.Black, Color.Transparent), 70, 290, 260, 75)

            'e.Graphics.DrawString(BRC.BarcodeConverter128.StringToBarcode(etiqueta.CodigoBarras), Font, _
            '                       Brushes.Black, 5, 278)

            'e.Graphics.DrawString(etiqueta.CodigoBarras, New Font("Arial Narrow", 11, FontStyle.Bold), _
            '                       Brushes.Black, 85, 333)

            'Dim bitmap As New Bitmap(Me.etiqueta.CodigoBarras.Length * 10, 150)
            'Using grafico As Graphics = Graphics.FromImage(bitmap)
            '    Dim font As New Font(fontF, 32, FontStyle.Regular)
            '    Dim punto As New Point(2.0F, 2.0F)
            '    Dim black As New SolidBrush(Color.Black)
            '    Dim white As New SolidBrush(Color.White)
            '    grafico.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height)
            '    grafico.DrawString(BRC.BarcodeConverter128.StringToBarcode(etiqueta.CodigoBarras), font, black, punto)
            'End Using


            'e.Graphics.DrawImage(bitmap, 70, 290)




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

    Private Function TextoAImagen(text As String, font As Font, textColor As Color, backColor As Color) As Image
        'first, create a dummy bitmap just to get a graphics object
        Dim img As Image = New Bitmap(520, 150)
        Dim drawing As Graphics = Graphics.FromImage(img)
        'measure the string to see how big the image needs to be
        Dim textSize As SizeF = drawing.MeasureString(text, font)
        'free up the dummy image and old graphics object
        img.Dispose()
        drawing.Dispose()
        'create a new image of the right size
        img = New Bitmap(CInt(textSize.Width), CInt(textSize.Height))
        drawing = Graphics.FromImage(img)
        'paint the background
        drawing.Clear(backColor)
        'create a brush for the text
        Dim textBrush As Brush = New SolidBrush(textColor)
        drawing.DrawString(text, font, textBrush, 0, 0)
        drawing.Save()
        textBrush.Dispose()
        drawing.Dispose()
        Return img

    End Function



    Public Shared Function LoadFontFamily(fileName As String, ByRef fontCollection As PrivateFontCollection) As FontFamily
        fontCollection = New PrivateFontCollection()
        fontCollection.AddFontFile(fileName)
        Return fontCollection.Families(0)
    End Function

    Public Function GeneraCodBarra(ByVal CodBarra As String) As Image
        Dim barcode As New BarcodeLib.Barcode()
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

        Dim img As Image = barcode.Encode(BarcodeLib.TYPE.CODE128, CodBarra)

        Return img

    End Function

    Private Sub Imprime_DocumentoExp(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
        Try
            Dim f10 As New Font("Arial", 10) 'formato de impresion Arial tamaño 10
            Dim fn10 As New Font("Arial", 10, FontStyle.Bold) 'formato de impresion Arial tamaño 10 Negrita

            Dim agregarRenglon As Integer = 5
            Dim agregarColumna As Integer = -20
            'Dim cod As New PictureBox
            'Me.etiqueta = Me.etiquetas(Me.nPag)
            'Me.Codigobarras.Picture = cod.Image
            'Me.Codigobarras.Message = etiqueta.CodigoBarras
            'Me.Codigobarras.Picture.Save("C:\" & etiqueta.FolioEtiqueta & ".jpg")

            e.Graphics.DrawString(etiqueta.IdProducto & " " & etiqueta.NombreProductoIngles, _
                                    New Font("Arial", 22, FontStyle.Bold), _
                                    Brushes.Black, 20 + agregarColumna, 11 + agregarRenglon)
            agregarRenglon += 15
            e.Graphics.DrawString(etiqueta.TipoProductoDescripcion, New Font("Arial", 15), _
                                Brushes.Black, 20 + agregarColumna, 36 + agregarRenglon)
            e.Graphics.DrawString(etiqueta.NombreProducto, New Font("Arial", 15, FontStyle.Bold), _
                                Brushes.Black, 20 + agregarColumna, 54 + agregarRenglon)
            agregarRenglon += 10

            e.Graphics.DrawString("HOUR", f10, Brushes.Black, 20 + agregarColumna, 75 + agregarRenglon)
            e.Graphics.DrawString(etiqueta.FechaCaptura.ToString("HH:mm:ss"), fn10, Brushes.Black, 20 + agregarColumna, 90 + agregarRenglon)

            e.Graphics.DrawString("DATE:", f10, Brushes.Black, 190 + agregarColumna, 75 + agregarRenglon)
            e.Graphics.DrawString("CADUCITY:", f10, Brushes.Black, 190 + agregarColumna, 95 + agregarRenglon)
            e.Graphics.DrawString(etiqueta.FechaEmpaque.ToString("MM/dd/yyyy"), fn10, Brushes.Black, 270 + agregarColumna, 75 + agregarRenglon)
            e.Graphics.DrawString(etiqueta.FechaCaducidad.ToString("MM/dd/yyyy"), fn10, Brushes.Black, 270 + agregarColumna, 95 + agregarRenglon)

            e.Graphics.DrawString("LOTE:", f10, Brushes.Black, 20 + agregarColumna, 115 + agregarRenglon)
            e.Graphics.DrawString(etiqueta.LoteCorte, New Font("Arial", 16, FontStyle.Bold), _
                                    Brushes.Black, 63 + agregarColumna, 110 + agregarRenglon)

            e.Graphics.DrawString("PIECES:", f10, Brushes.Black, 190 + agregarColumna, 115 + agregarRenglon)
            e.Graphics.DrawString(etiqueta.Piezas, New Font("Arial", 16, FontStyle.Bold), _
                                    Brushes.Black, 250 + agregarColumna, 110 + agregarRenglon)

            e.Graphics.DrawString("SHIPPING MARK", f10, Brushes.Black, 20 + agregarColumna, 140 + agregarRenglon)
            e.Graphics.DrawString(etiqueta.Embarque, New Font("Arial", 30, FontStyle.Bold), _
                                    Brushes.Black, 20 + agregarColumna, 155 + agregarRenglon)

            'e.Graphics.DrawImage(Me.Codigobarras.Picture, 30 + agregarColumna, 200 + agregarRenglon, 320, 100)

            e.Graphics.DrawString(etiqueta.Libras.ToString("N2"), New Font("Arial", 38, FontStyle.Bold), _
                                    Brushes.Black, 350 + agregarColumna, 68 + agregarRenglon)
            e.Graphics.DrawString("Lbs.", New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 530 + agregarColumna, 90 + agregarRenglon)
            e.Graphics.DrawString(etiqueta.Peso.ToString("N2"), _
                                    New Font("Arial", 30, FontStyle.Bold), Brushes.Black, _
                                    350 + agregarColumna, 115 + agregarRenglon)
            e.Graphics.DrawString("Kgs.", New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 530 + agregarColumna, 135 + agregarRenglon)

            e.Graphics.DrawString("KEEP REFRIGERATED:", f10, Brushes.Black, 355 + agregarColumna, 160 + agregarRenglon)
            e.Graphics.DrawString(etiqueta.Farenheit & "°F", fn10, Brushes.Black, 530 + agregarColumna, 160 + agregarRenglon)

            e.Graphics.DrawString("MANTENGASE A:", f10, Brushes.Black, 355 + agregarColumna, 180 + agregarRenglon)
            e.Graphics.DrawString(etiqueta.Grados & "°C", fn10, Brushes.Black, 530 + agregarColumna, 180 + agregarRenglon)

            If Controlador.Configuracion.Produccion.EsTIFLogo Then
                e.Graphics.DrawImage(Me.ListaImagenes.Images(1), 385 + agregarColumna, 200 + agregarRenglon, 130, 130)
            End If

            e.Graphics.DrawString("#", New Font("Wingdings 3", 72, FontStyle.Bold), Brushes.Black, 500 + agregarColumna, 200 + agregarRenglon)
            e.Graphics.DrawString("PRODUCT OF MEXICO", New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 350 + agregarColumna, 335 + agregarRenglon)

            e.Graphics.DrawString(etiqueta.Edad, New Font("Arial", 26, FontStyle.Bold), Brushes.Black, 270 + agregarColumna, 335 + agregarRenglon)

            e.Graphics.DrawString(Controlador.Sesion.MiEmpresa.Empnom, f10, Brushes.Black, 20 + agregarColumna, 310 + agregarRenglon) '50

            Dim domicilio As String = Controlador.Sesion.MiEmpresa.EmpDomicilio
            Dim partes As New List(Of String)

            For Each palabra As String In domicilio.Split(" "c)
                If partes.Count = 0 Then
                    partes.Add(palabra.Trim)
                    Continue For
                End If

                If partes(partes.Count - 1).Trim.Length + palabra.Trim.Length > 40 Then
                    partes.Add(palabra.Trim)
                Else
                    partes(partes.Count - 1) &= " " & palabra.Trim
                End If
            Next

            For i As Integer = 0 To partes.Count - 1
                e.Graphics.DrawString(partes(i), f10, Brushes.Black, 20 + agregarColumna, 325 + agregarRenglon + i * 15)
            Next

            nPag += 1
            ' Me.Codigobarras.ShowHRText = True

            If nPag < Me.nudCopias.Value Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
            e.Cancel = True
        End Try
    End Sub

    Private Sub Imprimir()
        If Not Validar() Then
            Exit Sub
        End If

        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Reimprimir")

        Me.etiquetas.Clear()
        Me.CmbCliente.Focus()

        Try
            Dim consultaEtiqueta As New CC.HistorialCambiosFechaCollection
            Dim buscarRelacionProductoCliente As Boolean
            Dim nombreProducto As String = String.Empty
            Dim codigoProducto As String = String.Empty
            Dim nombreIngles As String = String.Empty
            Dim tipocorte As ClasesNegocio.TipoCorte
            Dim corte As New EC.MscloteCortesDetEntity

            If Me.CmbCliente.SelectedIndex > -1 AndAlso Me.cmbDestino.SelectedIndex > -1 Then
                buscarRelacionProductoCliente = True
            Else
                buscarRelacionProductoCliente = False
            End If

            For i As Integer = 0 To Me.DgvCortes.Rows.Count - 1
                If CBool(Me.DgvCortes.Rows(i).Cells(Me.clmSelecciono.Index).Value) Then
                    With Me.DgvCortes.Rows(i)
                        If Me.chkCambiarFechas.Checked Then
                            Dim historial As New EC.HistorialCambiosFechaEntity

                            trans.Add(historial)

                            historial.IdFolioEtiqueta = .Cells(Me.clmEtiqueta.Index).Value
                            trans.Add(consultaEtiqueta)

                            consultaEtiqueta.GetMulti(HC.HistorialCambiosFechaFields.IdFolioEtiqueta = historial.IdFolioEtiqueta, 1, _
                                        New OC.SortExpression(New OC.SortClause(HC.HistorialCambiosFechaFields.IdHistorial, _
                                        SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending)))

                            If consultaEtiqueta.Count > 0 Then
                                historial.FechaCaducidad = consultaEtiqueta(0).FechaCaducidadNueva
                                historial.FechaCorte = consultaEtiqueta(0).FechaEmpaqueNueva
                            Else
                                historial.FechaCaducidad = .Cells(Me.clmFechaCad.Index).Value
                                historial.FechaCorte = .Cells(Me.clmFechaCorte.Index).Value
                            End If

                            historial.FechaEmpaqueNueva = Me.dtFechaCorteNuevo.Value
                            historial.FechaCaducidadNueva = Me.DtpFechaCadNva.Value

                            historial.Save()

                            If buscarRelacionProductoCliente Then
                                Me.ObtenerNombreProductoCliente(Me.CmbCliente.SelectedValue, _
                                .Cells(Me.clmIdCorte.Index).Value, Me.cmbDestino.SelectedValue, _
                                nombreProducto, nombreIngles, codigoProducto, trans)
                            Else
                                Dim producto As New EC.MsccatProductosEntity

                                producto.FetchUsingPK(.Cells(Me.clmIdCorte.Index).Value)

                                nombreProducto = producto.Descripcion
                                nombreIngles = producto.NombreIngles
                                cveProducto = producto.DescripcionCorta
                                codigoProducto = .Cells(Me.clmIdCorte.Index).Value
                            End If

                            corte.FetchUsingPK(.Cells(Me.clmLoteCorte.Index).Value.ToString.Trim, .Cells(Me.clmEtiqueta.Index).Value.ToString.Trim)
                            tipocorte = corte.TipoProducto

                            etiquetas.Add(New EtiquetasImprimir(.Cells(Me.clmEtiqueta.Index).Value, codigoProducto, _
                                         nombreProducto, nombreIngles, .Cells(Me.clmKilos.Index).Value, _
                                         .Cells(Me.clmPiezas.Index).Value, .Cells(Me.clmLoteCorte.Index).Value, _
                                         historial.FechaEmpaqueNueva, historial.FechaCaducidadNueva, _
                                         .Cells(Me.clmFechaCaptura.Index).Value, _
                                         .Cells(Me.clmCodigoBarras.Index).Value.ToString.Trim, _
                                         IIf(tipocorte = ClasesNegocio.TipoCorte.CONGELADO OrElse tipocorte = _
                                         ClasesNegocio.TipoCorte.VALOR_AGREGADO_CONGELADO, _
                                         EtiquetasImprimir.TipoProductoEnum.CONGELADO, _
                                         EtiquetasImprimir.TipoProductoEnum.FRESCO), _
                                         corte.IdFolioEmbarque.Trim, corte.Grados, _
                                         IIf(corte.MasDe30Meses, "+30", ""), corte.CantLibras, historial.FechaCaducidadNueva, corte.Farenheit))

                        Else
                            If buscarRelacionProductoCliente Then
                                Me.ObtenerNombreProductoCliente(Me.CmbCliente.SelectedValue, _
                                .Cells(Me.clmIdCorte.Index).Value, Me.cmbDestino.SelectedValue, _
                                nombreProducto, nombreIngles, codigoProducto, trans)
                            Else
                                Dim producto As New EC.MsccatProductosEntity

                                producto.FetchUsingPK(.Cells(Me.clmIdCorte.Index).Value)

                                nombreProducto = producto.Descripcion
                                nombreIngles = producto.NombreIngles
                                cveProducto = producto.DescripcionCorta
                                codigoProducto = .Cells(Me.clmIdCorte.Index).Value
                            End If

                            corte.FetchUsingPK(.Cells(Me.clmLoteCorte.Index).Value.ToString.Trim, .Cells(Me.clmEtiqueta.Index).Value.ToString.Trim)
                            tipocorte = corte.TipoProducto

                            etiquetas.Add(New EtiquetasImprimir(.Cells(Me.clmEtiqueta.Index).Value, codigoProducto, _
                                            nombreProducto, nombreIngles, .Cells(Me.clmKilos.Index).Value, _
                                            .Cells(Me.clmPiezas.Index).Value, .Cells(Me.clmLoteCorte.Index).Value, _
                                            .Cells(Me.clmFechaCorte.Index).Value, _
                                            .Cells(Me.clmFechaCad.Index).Value, _
                                            .Cells(Me.clmFechaCaptura.Index).Value, _
                                            .Cells(Me.clmCodigoBarras.Index).Value.ToString.Trim, _
                                            IIf(tipocorte = ClasesNegocio.TipoCorte.CONGELADO OrElse tipocorte = _
                                            ClasesNegocio.TipoCorte.VALOR_AGREGADO_CONGELADO, _
                                            EtiquetasImprimir.TipoProductoEnum.CONGELADO, _
                                            EtiquetasImprimir.TipoProductoEnum.FRESCO), _
                                            corte.IdFolioEmbarque.Trim, corte.Grados, _
                                            IIf(corte.MasDe30Meses, "+30", ""), corte.CantLibras, .Cells(Me.clmFechaCad.Index).Value, corte.Farenheit))
                        End If

                        'Me.DgvCortes.Rows.RemoveAt(i)
                    End With
                End If
            Next

            trans.Commit()

            For Each etiqueta As EtiquetasImprimir In etiquetas
                Me.etiqueta = etiqueta
                Me.nPag = 0

                If Me.txtLoteCorte.Text.Trim.Length > 0 Then
                    Me.etiqueta.LoteCorte = Me.txtLoteCorte.Text.Trim
                End If
                'REGRESAR:
                'Dim prev As New PrintPreviewDialog

                'prev.Document = Me.pdDocumento
                'prev.ShowDialog()
                'GoTo REGRESAR
                Me.pdDocumento.Print()
            Next

            Limpiar()
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ObtenerNombreProductoCliente(ByVal idCliente As Integer, ByVal idProducto As Integer, _
                                            ByVal idDestino As Integer, ByRef nombreProducto As String, _
                                            ByRef nombreIngles As String, ByRef codigoProducto As String, _
                                            ByVal trans As HC.Transaction)

        Dim consultaProductoCliente As New EC.MscrelacionCortesClientesEntity

        If trans IsNot Nothing Then
            trans.Add(consultaProductoCliente)
        End If

        If consultaProductoCliente.FetchUsingPK(idCliente, idProducto, idDestino) Then
            nombreProducto = consultaProductoCliente.Descripcion
            codigoProducto = consultaProductoCliente.CodCorteCliente
            nombreIngles = consultaProductoCliente.MsccatProductos.NombreIngles
        Else
            Dim producto As New EC.MsccatProductosEntity

            If trans IsNot Nothing Then
                trans.Add(producto)
            End If

            producto.FetchUsingPK(idProducto)

            nombreProducto = producto.Descripcion
            nombreIngles = producto.NombreIngles
            codigoProducto = idProducto
        End If
    End Sub

    Private Sub Buscar(ByVal etiquetas As List(Of String))
        Try
            Dim vista As New TC.VwConsultaCortesParaReimprecionTypedView
            'Dim vista1 As New TC.VwConsultaCortesParaReimprecionTypedView
            Dim filtro As New OC.PredicateExpression
            'Dim filtro1 As New OC.PredicateExpression
            Dim ultimaFila As Integer = 0

            filtro.Add((New OC.FieldCompareRangePredicate(HC.VwConsultaCortesParaReimprecionFields.IdFolioEtiqueta, _
                        etiquetas.ToArray) Or _
                        New OC.FieldCompareRangePredicate(HC.VwConsultaCortesParaReimprecionFields.CodigoBarra, _
                        etiquetas.ToArray)))
            filtro.Add(HC.VwConsultaCortesParaReimprecionFields.Estatus = 1)

            vista.Fill(0, Nothing, True, filtro)

            'If vista.Rows.Count = 0 Then
            '    filtro1.Add(New OC.FieldCompareRangePredicate(HC.VwConsultaCortesParaReimprecionFields.CodigoBarra, etiquetas.ToArray))
            '    filtro1.Add(HC.VwConsultaCortesParaReimprecionFields.Estatus = 1)
            '    vista1.Fill(0, Nothing, True, filtro1)
            'End If

            Me.DgvCortes.Rows.Clear()

            For Each etiqueta As String In etiquetas.ToArray
                For Each row As TC.VwConsultaCortesParaReimprecionRow In vista
                    If row.IdFolioEtiqueta.Trim = etiqueta.Trim OrElse row.CodigoBarra.Trim = etiqueta.Trim Then
                        Me.DgvCortes.Rows.Add(1)

                        With Me.DgvCortes.Rows(ultimaFila)
                            .Cells(Me.clmSelecciono.Index).Value = False
                            .Cells(Me.clmEtiqueta.Index).Value = row.IdFolioEtiqueta
                            .Cells(Me.clmLoteCorte.Index).Value = row.LoteCorte
                            .Cells(Me.clmCliente.Index).Value = row.Cliente
                            .Cells(Me.clmPrecorte.Index).Value = row.PreCorte
                            .Cells(Me.clmCorte.Index).Value = row.Corte
                            .Cells(Me.clmPiezas.Index).Value = row.CantPzas
                            .Cells(Me.clmKilos.Index).Value = row.CantKgrs
                            .Cells(Me.clmFechaCorte.Index).Value = row.FechaCorte
                            .Cells(Me.clmFechaCad.Index).Value = row.FechaCad
                            .Cells(Me.clmIdPreCorte.Index).Value = row.IdPreCorte
                            .Cells(Me.clmIdCorte.Index).Value = row.IdCorte
                            .Cells(Me.clmGrados.Index).Value = 0D
                            .Cells(Me.clmFechaCaptura.Index).Value = row.FechaCaptura
                            .Cells(Me.clmCodigoBarras.Index).Value = row.CodigoBarra.Trim
                        End With

                        ultimaFila += 1
                        vista.Rows.Remove(row)
                        Exit For
                    End If
                Next
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub Buscar(ByVal folioEmbarque As String)
        Try
            Dim vista As New TC.VwConsultaCortesParaReimprecionTypedView
            Dim filtro As New OC.PredicateExpression
            Dim ultimaFila As Integer = 0

            filtro.Add(HC.VwConsultaCortesParaReimprecionFields.IdFolioEmbarque = folioEmbarque)
            filtro.Add(HC.VwConsultaCortesParaReimprecionFields.Estatus = 1)

            vista.Fill(0, Nothing, True, filtro)

            Me.DgvCortes.Rows.Clear()

            For Each row As TC.VwConsultaCortesParaReimprecionRow In vista
                Me.DgvCortes.Rows.Add(1)

                With Me.DgvCortes.Rows(ultimaFila)
                    .Cells(Me.clmSelecciono.Index).Value = False
                    .Cells(Me.clmEtiqueta.Index).Value = row.IdFolioEtiqueta
                    .Cells(Me.clmLoteCorte.Index).Value = row.LoteCorte
                    .Cells(Me.clmCliente.Index).Value = row.Cliente
                    .Cells(Me.clmPrecorte.Index).Value = row.PreCorte
                    .Cells(Me.clmCorte.Index).Value = row.Corte
                    .Cells(Me.clmPiezas.Index).Value = row.CantPzas
                    .Cells(Me.clmKilos.Index).Value = row.CantKgrs
                    .Cells(Me.clmFechaCorte.Index).Value = row.FechaCorte
                    .Cells(Me.clmFechaCad.Index).Value = row.FechaCad
                    .Cells(Me.clmIdPreCorte.Index).Value = row.IdPreCorte
                    .Cells(Me.clmIdCorte.Index).Value = row.IdCorte
                    .Cells(Me.clmGrados.Index).Value = 0D
                    .Cells(Me.clmFechaCaptura.Index).Value = row.FechaCaptura
                    .Cells(Me.clmCodigoBarras.Index).Value = row.CodigoBarra.Trim
                End With

                ultimaFila += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Function Validar() As Boolean
        Try
            Dim mensaje As New fmrAvisoAntesReimprimirEtiqeutas

            If Me.CmbCliente.SelectedIndex > -1 Then
                If Not Me.cmbDestino.SelectedIndex > -1 Then
                    If MsgBox("Se selecciono el cliente, falta el destino, ¿Quiere imprimir la/s etiqueta/s sin la información del cliente?", MsgBoxStyle.YesNo, "Falta Destino") = MsgBoxResult.No Then
                        Return False
                    Else
                        mensaje.lblCliente.Text = "Sin Cliente"
                        mensaje.lblDestino.Text = "Sin Destino"
                    End If
                Else
                    mensaje.lblCliente.Text = Me.CmbCliente.Text
                    mensaje.lblDestino.Text = Me.cmbDestino.Text
                End If
            Else
                If MsgBox("No selecciono cliente, ¿Quiere imprimir la/s etiqueta/s sin la información del cliente?", MsgBoxStyle.YesNo, "Falta Cliente") = MsgBoxResult.No Then
                    Return False
                Else
                    mensaje.lblCliente.Text = "Sin Cliente"
                    mensaje.lblDestino.Text = "Sin Destino"
                End If
            End If

            If Me.chkCambiarFechas.Checked Then
                If Me.dtFechaCorteNuevo.Value.ToShortDateString = Now.ToShortDateString Then
                    If MsgBox("La fecha de empaque no fue modificada, ¿Quiere imprimir la/s etiqueta/s con la fecha de empaque actual?", MsgBoxStyle.YesNo, "Fecha de Empaque Sin Modificar") = MsgBoxResult.No Then
                        Return False
                    End If
                End If

                If Me.DtpFechaCadNva.Value.ToShortDateString = _
                    Now.ToShortDateString OrElse _
                    Date.Compare(CDate(Me.DtpFechaCadNva.Value.ToString("dd/MM/yyyy")), _
                    CDate(Now.ToString("dd/MM/yyyy"))) < 0 Then

                    MsgBox("La fecha de caducidad es igual o menor a la actual", MsgBoxStyle.Exclamation, "Fecha Caducidad")
                    Return False
                End If

                'If Date.Compare(CDate(Me.dtFechaCorteNuevo.Value.AddDays(30).ToString("dd/MM/yyyy")), CDate(Me.DtpFechaCadNva.Value.ToString("dd/MM/yyyy"))) > 0 OrElse Date.Compare(CDate(Me.dtFechaCorteNuevo.Value.AddDays(30).ToString("dd/MM/yyyy")), CDate(Me.DtpFechaCadNva.Value.ToString("dd/MM/yyyy"))) < 0 Then
                '    MsgBox("El rango entre la fecha de empaque y caducidad no es de 30 dias", MsgBoxStyle.Exclamation, "Aviso")
                '    Return False
                'End If

                mensaje.lblFechaCaducidad.Text = Me.DtpFechaCadNva.Value.ToShortDateString
                mensaje.lblFechaEmpaque.Text = Me.dtFechaCorteNuevo.Value.ToShortDateString
            Else
                mensaje.lblFechaCaducidad.Text = "Fecha actual de cada etiqueta"
                mensaje.lblFechaEmpaque.Text = "Fecha actual de cada etiqueta"
            End If

            If mensaje.ShowDialog = Windows.Forms.DialogResult.OK Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
#End Region

#Region "Eventos"
    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir
        Try
            Imprimir()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub

    Private Sub DgvCortes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvCortes.Click
        'Try
        '    If Me.DgvCortes.SelectedRows.Count > 0 Then
        '        With Me.DgvCortes.SelectedRows(0)
        '            'Me.txtEtiqueta.Text = .Cells(Me.clmEtiqueta.Index).Value
        '            'Me.txtLoteCorte.Text = .Cells(Me.clmLoteCorte.Index).Value
        '            'Me.txtCorte.Text = .Cells(Me.clmCorte.Index).Value
        '            'Me.txtPrecorte.Text = .Cells(Me.clmPrecorte.Index).Value
        '            'Me.txtKilos.Text = .Cells(Me.clmKilos.Index).Value
        '            'Me.txtPiezas.Text = .Cells(Me.clmPiezas.Index).Value
        '            'Me.DtpFechaCorte.Value = .Cells(Me.clmFechaCorte.Index).Value
        '            'Me.DptFechaCad.Value = .Cells(Me.clmFechaCad.Index).Value
        '            'Me.DtpFechaCadNva.Value = Me.DptFechaCad.Value
        '            CodCorte = .Cells(Me.clmIdCorte.Index).Value
        '            CodCorte2 = CodCorte
        '            NomCorte = .Cells(Me.clmCorte.Index).Value
        '            Grados = .Cells(Me.clmGrados.Index).Value
        '            Me.CmbCliente.SelectedValue = .Cells(Me.clmIdCliente.Index).Value
        '            '    Me.dtFechaCorteNuevo.Value = Me.DtpFechaCorte.Value
        '            '    Me.DtpFechaCadNva.Value = Me.DptFechaCad.Value
        '        End With
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        'End Try
    End Sub

    Private Sub CmbCliente_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs)
        If e.KeyCode = Keys.F12 Then
            ClientesCol.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)
        End If
    End Sub

    Private Sub CmbCliente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            If Not Inicio Then
                If Me.CmbCliente.SelectedIndex > -1 Then
                    Dim ReClienteCorte As New EC.MscrelacionCortesClientesEntity
                    'If ReClienteCorte.FetchUsingPK(Me.CmbCliente.SelectedValue, CodCorte) Then
                    '    'Me.txtCorte.Text = ReClienteCorte.Descripcion
                    '    CodCorte2 = ReClienteCorte.CodCorteCliente
                    'Else
                    '    MsgBox("El cliente no tiene relacionado ningun nombre para este corte", MsgBoxStyle.Exclamation, "Aviso")
                    '    'Me.txtCorte.Text = NomCorte
                    '    CodCorte2 = CodCorte
                    'End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DgvCortes_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvCortes.DataError

    End Sub

    Private Sub txtEmbarque_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmbarque.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                Me.Buscar(Me.txtEmbarque.Text.Trim)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnBusquedaEtiquetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusquedaEtiquetas.Click
        Try
            Dim busqueda As New FrmBusquedaCortesConEtiqueta

            busqueda.EstablecerEstatus(True, True, False, False, False, CInt(CmbCliente.SelectedValue))

            If busqueda.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim etiquetas As New List(Of String)

                For i As Integer = 0 To busqueda.DgvCortes.Rows.Count - 1
                    Dim row As DataGridViewRow = busqueda.DgvCortes.Rows(i)

                    If CBool(row.Cells(busqueda.clmSeleccion.Index).Value) Then
                        etiquetas.Add(row.Cells(busqueda.clmFolioEtiqueta.Index).Value)
                    End If
                Next

                Me.Buscar(etiquetas)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnVaciarPistola_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVaciarPistola.Click
        Try
            Dim abrirArchivo As New OpenFileDialog

            abrirArchivo.Filter = "Archivos de Texto(Bloc de Notas)*.txt|*.txt"

            If abrirArchivo.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim fileContents As String
                Dim etiquetas As New List(Of String)

                fileContents = My.Computer.FileSystem.ReadAllText(abrirArchivo.FileName)

                For Each folioEtiqueta As String In fileContents.Split(New Char() {Chr(13), Chr(10)})
                    If Not folioEtiqueta.Trim = "" Then
                        etiquetas.Add(folioEtiqueta.Trim)
                    End If
                Next

                Me.Buscar(etiquetas)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtEmbarque_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtEmbarque.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F3 Then
                Dim busqueda As New MConsEmbarques

                busqueda.EstatusDefault(True) = ClasesNegocio.EstatusCharX.VIGENTE

                If busqueda.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.txtEmbarque.Text = busqueda.DgvEmbarques.SelectedRows(0).Cells(busqueda.IdFolioEmbarque.Index).Value

                    Me.txtEmbarque_KeyPress(sender, New KeyPressEventArgs(Chr(13)))
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub FrmReEtiquetacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Inicio = True

            AddHandler pdDocumento.PrintPage, AddressOf Imprime_Documento

            ClientesCol.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)

            PuntosCol = New CC.MgralcatPuntosEntregaCollection

            Me.CmbCliente.DisplayMember = "Nombre"
            Me.CmbCliente.ValueMember = "Codigo"
            Me.CmbCliente.DataSource = ClientesCol
            Me.CmbCliente.SelectedIndex = -1

            Limpiar()
            Habilitar()
            Inicio = False
            Me.CmbCliente.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnSeleccionarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionarTodos.Click
        Try
            For i As Integer = 0 To Me.DgvCortes.Rows.Count - 1
                Me.DgvCortes.Rows(i).Cells(Me.clmSelecciono.Index).Value = True
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub brnQuitarSeleccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnQuitarSeleccion.Click
        Try
            For i As Integer = 0 To Me.DgvCortes.Rows.Count - 1
                Me.DgvCortes.Rows(i).Cells(Me.clmSelecciono.Index).Value = False
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub chkCambiarFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCambiarFechas.CheckedChanged
        Me.GroupBox1.Enabled = Me.chkCambiarFechas.Checked
        Me.DtpFechaCadNva.Value = Me.dtFechaCorteNuevo.Value.AddDays(30)
    End Sub

    Private Sub CmbCliente_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCliente.SelectedIndexChanged
        If Me.CmbCliente.SelectedIndex > -1 Then
            Try
                Me.cmbDestino.DataSource = Nothing

                PuntosCol.GetMulti(HC.MgralcatPuntosEntregaFields.Estatus = "V" And _
                        HC.MgralcatPuntosEntregaFields.IdCliente = Me.CmbCliente.SelectedValue)

                Me.cmbDestino.ValueMember = "IdPuntoEntrega"
                Me.cmbDestino.DisplayMember = "Descripcion"
                Me.cmbDestino.DataSource = Me.PuntosCol
                Me.cmbDestino.SelectedIndex = -1
                Me.cmbDestino.Text = "Seleccionar Destiono..."
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Me.cmbDestino.DataSource = Nothing
        End If
    End Sub

    Private Sub dtFechaCorteNuevo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtFechaCorteNuevo.ValueChanged
        Me.DtpFechaCadNva.Value = Me.dtFechaCorteNuevo.Value.AddDays(30)
    End Sub

    Private Sub chkExportacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkExportacion.CheckedChanged
        If Me.chkExportacion.Checked Then
            RemoveHandler pdDocumento.PrintPage, AddressOf Imprime_Documento
            RemoveHandler pdDocumento.PrintPage, AddressOf Imprime_DocumentoExp
            AddHandler pdDocumento.PrintPage, AddressOf Imprime_DocumentoExp
        Else
            RemoveHandler pdDocumento.PrintPage, AddressOf Imprime_Documento
            RemoveHandler pdDocumento.PrintPage, AddressOf Imprime_DocumentoExp
            AddHandler pdDocumento.PrintPage, AddressOf Imprime_Documento
        End If
    End Sub
#End Region

#Region "Estructuras"
    Private Structure EtiquetasImprimir

        Private m_Etiqueta As String
        Public Property FolioEtiqueta() As String
            Get
                Return m_Etiqueta
            End Get
            Set(ByVal value As String)
                m_Etiqueta = value
            End Set
        End Property

        Private m_IdProducto As String
        Public Property IdProducto() As String
            Get
                Return m_IdProducto
            End Get
            Set(ByVal value As String)
                m_IdProducto = value
            End Set
        End Property

        Private m_NombreProducto As String
        Public Property NombreProducto() As String
            Get
                Return m_NombreProducto.Trim
            End Get
            Set(ByVal value As String)
                m_NombreProducto = value
            End Set
        End Property

        Private m_NombreProductoIngles As String
        Public Property NombreProductoIngles() As String
            Get
                Return m_NombreProductoIngles.Trim
            End Get
            Set(ByVal value As String)
                m_NombreProductoIngles = value
            End Set
        End Property

        Private m_Peso As Decimal
        Public Property Peso() As Decimal
            Get
                Return m_Peso
            End Get
            Set(ByVal value As Decimal)
                m_Peso = value
            End Set
        End Property

        Private m_Piezas As Integer
        Public Property Piezas() As Integer
            Get
                Return m_Piezas
            End Get
            Set(ByVal value As Integer)
                m_Piezas = value
            End Set
        End Property

        Private m_LoteCorte As String
        Public Property LoteCorte() As String
            Get
                Return m_LoteCorte
            End Get
            Set(ByVal value As String)
                m_LoteCorte = value
            End Set
        End Property

        Private m_FechaEmpaque As Date
        Public Property FechaEmpaque() As Date
            Get
                Return m_FechaEmpaque
            End Get
            Set(ByVal value As Date)
                m_FechaEmpaque = value
            End Set
        End Property

        Private m_FechaCaducidad As Date
        Public Property FechaCaducidad() As Date
            Get
                Return m_FechaCaducidad
            End Get
            Set(ByVal value As Date)
                m_FechaCaducidad = value
            End Set
        End Property

        Private m_FechaCaptura As Date
        Public Property FechaCaptura() As Date
            Get
                Return m_FechaCaptura
            End Get
            Set(ByVal value As Date)
                m_FechaCaptura = value
            End Set
        End Property

        Private m_FechaCorte As Date
        Public Property FechaCorte() As Date
            Get
                Return m_FechaCorte
            End Get
            Set(ByVal value As Date)
                m_FechaCorte = value
            End Set
        End Property

        Private codBarras As String
        Public Property CodigoBarras() As String
            Get
                Return codBarras
            End Get
            Set(ByVal value As String)
                codBarras = value
            End Set
        End Property

        Private _TipoProducto As TipoProductoEnum
        Public Property TipoProducto() As TipoProductoEnum
            Get
                Return _TipoProducto
            End Get
            Set(ByVal value As TipoProductoEnum)
                _TipoProducto = value
            End Set
        End Property

        Public ReadOnly Property TipoProductoDescripcion() As String
            Get
                If TipoProducto = TipoProductoEnum.CONGELADO Then
                    Return "FROZEN BEEF/CARNE CONGELADA"
                Else
                    Return "FRESH BEEF/CARNE FRESCA"
                End If
            End Get
        End Property

        Private m_Embarque As String
        Public Property Embarque() As String
            Get
                Return m_Embarque
            End Get
            Set(ByVal value As String)
                m_Embarque = value
            End Set
        End Property

        Private m_Grados As Integer
        Public Property Grados() As Integer
            Get
                Return m_Grados
            End Get
            Set(ByVal value As Integer)
                m_Grados = value
            End Set
        End Property

        Private m_EdadCanal As String
        Public Property Edad() As String
            Get
                Return m_EdadCanal
            End Get
            Set(ByVal value As String)
                m_EdadCanal = value
            End Set
        End Property

        Private m_Libras As Decimal
        Public Property Libras() As Decimal
            Get
                Return m_Libras
            End Get
            Set(ByVal value As Decimal)
                m_Libras = value
            End Set
        End Property

        Private m_Farenheit As Decimal
        Public Property Farenheit() As Decimal
            Get
                Return m_Farenheit
            End Get
            Set(ByVal value As Decimal)
                m_Farenheit = value
            End Set
        End Property

        Sub New(ByVal folioEtiqueta As String, ByVal idProducto As String, ByVal nombreProducto As String, _
                ByVal nombreProductoIngles As String, ByVal peso As Decimal, ByVal piezas As Integer, _
                ByVal loteCorte As String, ByVal fechaEmpaque As Date, ByVal fechaCaducidad As Date, _
                ByVal fechaCorte As Date, ByVal codigoBarras As String, ByVal tipo As TipoProductoEnum, _
                ByVal embarque As String, ByVal grados As Integer, ByVal edad As String, _
                ByVal libras As Decimal, ByVal fechaCaptura As Date, ByVal farenheith As Decimal)
            Me.FolioEtiqueta = folioEtiqueta
            Me.IdProducto = idProducto
            Me.NombreProducto = nombreProducto
            Me.NombreProductoIngles = nombreProductoIngles
            Me.Peso = peso
            Me.Piezas = piezas
            Me.LoteCorte = loteCorte
            Me.FechaEmpaque = fechaEmpaque
            Me.FechaCaducidad = fechaCaducidad
            Me.FechaCorte = fechaCorte
            Me.CodigoBarras = codigoBarras
            Me.TipoProducto = tipo
            Me.Embarque = embarque
            Me.Grados = grados
            Me.Edad = edad
            Me.Libras = libras
            Me.FechaCaptura = fechaCaptura
            Me.Farenheit = farenheith
        End Sub

        Public Enum TipoProductoEnum
            FRESCO
            CONGELADO
        End Enum
    End Structure
#End Region

End Class