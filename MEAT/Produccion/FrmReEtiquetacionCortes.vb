Imports CN = ClasesNegocio
Imports ClasesNegocio
Imports TC = Integralab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses

Public Class FrmReEtiquetacionCortes
#Region "Miembros"
    Dim FolioMovimiento As String
    Dim IdProducto As Integer
    Dim LoteCorte As CN.CortesClass
    Dim WithEvents LoteCorteDetalle As CN.CortesDetalleClass
    'variables para las clases de almacen
    Dim Almacen As CN.AlmacenProduccionClass
    Dim AlmacenDetalle As CN.AlmacenDetalleClass
    Dim Folio As CN.FoliosClass
    Dim Inventario As CN.InventarioClass
    ' Dim Productos As New CN.ProductosClass
    Dim configProdC As EC.UsrProdConfiguracionEntity
    Dim cargo As Boolean = False
    Dim ultimoCorte As EC.MscloteCortesDetEntity
    Private nPag As Integer
#End Region

#Region "Metodos"
    Private Sub Limpiar()
        Me.txtEtiqueta.Text = ""
        Me.txtCorte.Text = ""
        Me.txtKilos.Text = 0
        Me.txtKilosNvos.Text = 0
        Me.txtLoteCorte.Text = ""
        Me.txtPzas.Text = 0
        Me.txtPzasNvas.Text = 0
        Me.txtSubCorte.Text = ""
        Me.DtpFechaCad.Value = Now
        Me.DtpFechaCorte.Value = Now
        Me.txtFiltro.Text = ""
    End Sub

    Private Sub Habilitar()
        Me.txtKilosNvos.Enabled = True
        Me.txtPzasNvas.Enabled = True
    End Sub

    Private Sub DesHabilitar()
        Me.txtKilosNvos.Enabled = False
        Me.txtPzasNvas.Enabled = False
    End Sub

    Private Function Guardar() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")

        Try
            Dim corte As New EC.MscloteCortesDetEntity
            dim nuevoCorte as New EC.MscloteCortesDetEntity
            Dim movimientoAlm As New ClasesNegocio.MovimientoAlmacenClass
            Dim movimientoAlmCan As New ClasesNegocio.MovimientoAlmacenClass
            Dim folio As New ClasesNegocio.FoliosClass

            Trans.Add(corte)
            corte.FetchUsingPK(Me.txtLoteCorte.Text, Me.txtEtiqueta.Text)
            corte.Estatus = ClasesNegocio.EstatusEnum.INACTIVO

            corte.Save()

            With movimientoAlmCan
                .FolioMovmientoReferencia = corte.IdFolioMovimiento
                .EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
                .EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Captura_Corte)
                .Estatus = EstatusChar.VIGENTE
                .FechaMovimiento = Now
                .IdPoliza = ""
                .Kilos = corte.CantKgrs
                .Piezas = corte.CantPzas
                .AgregarDetalle(corte.IdProducto, corte.CantKgrs, corte.CantPzas, 0D, 0D)

                If .Guardar(Trans) Then
                    Trans.Rollback()
                    Return False
                End If
            End With

            folio.Año = Now.Year
            folio.Mes = Now.Month
            folio.Codigo = CodigodeFolios.EntradaCortesAlmacén

            If folio.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            With movimientoAlm
                .EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
                .EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Captura)
                .Estatus = EstatusChar.VIGENTE
                .FechaMovimiento = Now
                .IdPoliza = ""
                .Kilos = CInt(Me.txtKilosNvos.Text)
                .Piezas = CDec(Me.txtPzasNvas.Text)

                If .Guardar(Trans) Then
                    Trans.Rollback()
                    Return False
                End If
            End With

            nuevoCorte.IdFolioEtiqueta = folio.Consecutivo.ToString("0000")
            nuevoCorte.CantPzas = CInt(Me.txtPzasNvas.Text)
            nuevoCorte.CantKgrs = CDec(Me.txtKilosNvos.Text)
            nuevoCorte.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
            nuevoCorte.IdCliente = corte.IdCliente
            nuevoCorte.IdCorte = corte.IdCorte
            nuevoCorte.IdFolioMovimiento = movimientoAlm.FolioMovimiento
            nuevoCorte.IdProducto = corte.IdProducto
            nuevoCorte.LoteCorte = corte.LoteCorte

            nuevoCorte.Save()

            Trans.Commit()

            ultimoCorte = nuevoCorte

            Imprimir()

            Limpiar()
            DesHabilitar()

            Return True
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub Imprimir()
        Try
            'Me.codigoBarras.Message = ultimoCorte.IdFolioEtiqueta

            Me.pdDocumento.Print()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Imprime_Documento(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
        Try
            'generadorCodigoBarra.Message = folioEtiqueta

            'e.PageSettings.PaperSize = New Printing.PaperSize("Etiqueta", 406, 500)
            Dim f10 As New Font("Arial", 10) 'formato de impresion Arial tamaño 10
            Dim fn10 As New Font("Arial", 10, FontStyle.Bold) 'formato de impresion Arial tamaño 10 Negrita
            Dim nombreProducto As String = String.Empty
            Dim codigoProducto As String = String.Empty
            Dim fechaEmpaque As Date
            Dim fechaCaducidad As Date
            Dim historialFechas As New CC.HistorialCambiosFechaCollection

            

            historialFechas.GetMulti(HC.HistorialCambiosFechaFields.IdFolioEtiqueta = ultimoCorte.IdFolioEtiqueta, 1, _
                                    New OC.SortExpression(New OC.SortClause(HC.HistorialCambiosFechaFields.FechaCaducidadNueva, _
                                    SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending)))

            If historialFechas.Count > 1 Then
                fechaEmpaque = historialFechas(0).FechaEmpaqueNueva
                fechaCaducidad = historialFechas(0).FechaCaducidadNueva
            Else
                fechaEmpaque = Me.DtpFechaCorte.Value
                fechaCaducidad = Me.DtpFechaCad.Value
            End If

            e.Graphics.DrawString(nombreProducto, New Font("Arial", 18, FontStyle.Bold), Brushes.Black, 5, 5)
            e.Graphics.DrawString(ultimoCorte.MsccatProductosCorte.NombreIngles, New Font("Arial", 12), Brushes.Black, 5, 30)
            e.Graphics.DrawString("PESO NETO", f10, Brushes.Black, 5, 48)
            e.Graphics.DrawString(ultimoCorte.CantKgrs.ToString("N2"), f10, Brushes.Black, 100, 48)
            e.Graphics.DrawString("BOLSAS", f10, Brushes.Black, 340, 48)
            e.Graphics.DrawString(ultimoCorte.CantKgrs.ToString("N2"), New Font("Arial", 60, FontStyle.Bold), Brushes.Black, 40, 60)
            e.Graphics.DrawString(ultimoCorte.CantPzas, New Font("Arial", 32, FontStyle.Bold), Brushes.Black, 350, 60)
            e.Graphics.DrawString("LOTE", f10, Brushes.Black, 5, 140)
            e.Graphics.DrawString("CONSERVA A", f10, Brushes.Black, 120, 140)
            e.Graphics.DrawString("CODIGO PRODUCTO", f10, Brushes.Black, 255, 140) '10
            e.Graphics.DrawString(ultimoCorte.LoteCorte, fn10, Brushes.Black, 5, 160)
            e.Graphics.DrawString("4ºC", fn10, Brushes.Black, 150, 160)
            e.Graphics.DrawString(codigoProducto, fn10, Brushes.Black, 310, 160) '15
            e.Graphics.DrawString("FECHA", f10, Brushes.Black, 5, 180)
            e.Graphics.DrawString("FECHA", f10, Brushes.Black, 160, 180) '20
            e.Graphics.DrawString("EMPAQUE", f10, Brushes.Black, 5, 200)
            e.Graphics.DrawString("CADUCIDAD", f10, Brushes.Black, 160, 200)
            e.Graphics.DrawString(fechaEmpaque.ToShortDateString, f10, Brushes.Black, 85, 200)
            e.Graphics.DrawString(fechaCaducidad.ToShortDateString, f10, Brushes.Black, 260, 200) '25
            e.Graphics.DrawString("NO ESTIBAR MAS DE 6 CAJAS ESTE LADO HACIA", f10, Brushes.Black, 15, 220) '30
            e.Graphics.DrawImage(Me.ListaImagenes.Images(0), 5, 240, 30, 70)
            e.Graphics.DrawImage(Me.ListaImagenes.Images(0), 360, 240, 30, 70)
            'e.Graphics.DrawImage(Me.codigoBarras.Picture, 90, 240, 220, 80) '35
            e.Graphics.DrawString("CVE PROV", f10, Brushes.Black, 5, 330)
            e.Graphics.DrawString("PAIS ORIGEN", f10, Brushes.Black, 154, 330) '40
            e.Graphics.DrawString("3010659", fn10, Brushes.Black, 5, 350)
            e.Graphics.DrawString("MEXICO", fn10, Brushes.Black, 154, 350) '45
            e.Graphics.DrawString(Controlador.Sesion.MiEmpresa.Empnom, f10, Brushes.Black, 5, 370) '50
            e.Graphics.DrawString(Controlador.Sesion.MiEmpresa.EmpDomicilio, f10, Brushes.Black, 5, 390)
            e.Graphics.DrawImage(Me.ListaImagenes.Images(1), 300, 330, 100, 100)

            nPag += 1

            If nPag < 1 Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
            e.HasMorePages = False
        End Try
    End Sub

    Private Sub ConfigurarPuerto()
        txtLeerPeso.Port = 1 'Abro el com2
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
#End Region

    Private Sub FrmReEtiquetacionCortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler pdDocumento.PrintPage, AddressOf Imprime_Documento

        Try
            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            Dim VistaCortes As New TC.VwBusquedaCortesTypedView
            Dim configuracionesProd As New CC.UsrProdConfiguracionCollection

            tbEstados.StateBuscar = "001101111"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100001"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "010011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")
            Me.mtb.Buttons(0).Visible = False

            VistaCortes.Fill()

            Me.DgvCortes.AutoGenerateColumns = False
            Me.DgvCortes.DataSource = VistaCortes

            configuracionesProd.GetMulti(Nothing)

            If configuracionesProd.Count > 0 Then
                Me.configProdC = configuracionesProd(0)
                cargo = True
            Else
                MsgBox("Debe establecer una configuración de  de producción antes de usar esta ventana", MsgBoxStyle.Exclamation, "Aviso")
                cargo = False
            End If

            Me.ConfigurarPuerto()
            Limpiar()
            DesHabilitar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        DesHabilitar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Not Guardar() Then
                MsgBox("No se pudo realizar el cambio a la etiqueta", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub DgvCortes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvCortes.Click
        Try
            If Me.DgvCortes.SelectedRows.Count > 0 Then
                With Me.DgvCortes.SelectedRows(0)
                    Me.txtEtiqueta.Text = .Cells(Me.clmEtiqueta.Index).Value
                    Me.txtCorte.Text = .Cells(Me.clmCorte.Index).Value
                    Me.txtSubCorte.Text = .Cells(Me.clmSubCorte.Index).Value
                    Me.txtKilos.Text = .Cells(Me.clmKilos.Index).Value
                    Me.txtPzas.Text = .Cells(Me.clmPiezas.Index).Value
                    Me.DtpFechaCad.Value = .Cells(Me.clmFechaCad.Index).Value
                    Me.DtpFechaCorte.Value = .Cells(Me.clmFechaCorte.Index).Value
                    Me.txtLoteCorte.Text = .Cells(Me.clmLote.Index).Value
                    FolioMovimiento = .Cells(Me.clmFolioMov.Index).Value
                    IdProducto = .Cells(Me.clmIdProducto.Index).Value
                    Me.DtpFechaCad.Value = .Cells(Me.clmFechaCad.Index).Value
                    Me.DtpFechaCorte.Value = .Cells(Me.clmFechaCorte.Index).Value
                End With

                Me.mtb.sbCambiarEstadoBotones("Nuevo")
                Habilitar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DgvCortes_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvCortes.DataError

    End Sub

    Private Sub txtLeerPeso_SerialDataArrived(ByVal sender As System.Object, ByVal e As wclTextBoxSerial.SerialDataArrivedEventArgs) Handles txtLeerPeso.SerialDataArrived
        'En e.Data esta el grupo de caracteres recibidos desde el puerto serial
        If e.Data.Length >= 50 Then 'Si llegan 25 caracteres procesarlos
            Dim res As String = (ClasesNegocio.LecturaBasculaClass.ObtenerPeso(e.Data.Substring(0, 50), _
                                LecturaBasculaClass.TipoLectura.GRAMOS, _
                                LecturaBasculaClass.TipoLectura.KILOGRAMOS) / 10D).ToString("N2") 'Se divide entre 10 por q la bascula de cortes arroja 3 decimales
            Me.txtKilosNvos.Text = res
        Else
            e.Handled = True 'Ignora los caracteres
        End If
    End Sub

    Private Sub FrmReEtiquetacionCortes_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Not cargo Then
            Close()
        End If
    End Sub

    Private Sub chkActivarLectura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivarLectura.CheckedChanged
        Try
            If Me.chkActivarLectura.Checked Then
                'Me.TextBox1.Text = ClasesNegocio.LecturaBasculaClass.ObtenerPeso(String.Format("<9  41290   355{0}<9  41285   355{0}<9  41280   355{0}<9  41280   355{0}<9  41275   355{0}<9  41275   355{0}<9  41275   355{0}<9  41280   3", vbNewLine), LecturaBasculaClass.TipoLectura.GRAMOS, LecturaBasculaClass.TipoLectura.KILOGRAMOS).ToString("N2")
                Me.txtLeerPeso.OpenPort()
                Me.chkActivarLectura.Text = "Lectura de Peso Activada"
                'Me.txtKgrsRecibidos.Enabled = False
                Me.txtKilosNvos.ReadOnly = True
                Me.txtKilosNvos.Focus()
            Else
                Me.txtLeerPeso.ClosePort()
                Me.chkActivarLectura.Text = "Lectura de Peso Desactivada"
                'Me.txtKgrsRecibidos.Enabled = True
                Me.txtKilosNvos.ReadOnly = False
                Me.txtKilosNvos.Focus()
            End If
        Catch UAex As UnauthorizedAccessException
            MsgBox("No se pudo conectar a la bascula, pruebe que este encendida o que no se este usando una lectura de bascula en otra ventana o aplicación", MsgBoxStyle.Exclamation, "Aviso")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class