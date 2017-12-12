Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = Integralab.ORM.TypedViewClasses
Imports System.Drawing.Printing
Imports SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmBusqNotasVenta


    Private Sub chkFiltroFecha_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFiltroFecha.CheckedChanged
        If chkFiltroFecha.Checked Then
            gpFechas.Enabled = True
        Else
            gpFechas.Enabled = False
        End If

    End Sub

    Private Sub frmBusqNotasVenta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dgvNotas.AutoGenerateColumns = False
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        gpFechas.Enabled = False
        chkFiltroFecha.Checked = False
        'Me.ActiveControl = Me


        MtbEstados.StateBuscar = "110000011"
        MtbEstados.StateLimpiar = "110000001"
        MtbEstados.StateCancelar = ""
        MtbEstados.StateNuevo = ""
        MtbEstados.StateGuardar = ""
        MtbEstados.StateBorrar = ""
        MtbEstados.StateEditar = ""
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""

        mtb.ToolBarButtonStatus = MtbEstados

        mtb.sbCambiarEstadoBotones("Limpiar")
        
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Me.Cursor = Cursors.WaitCursor
        If Validar() Then
            dgvNotas.Rows.Clear()

            Dim filtro As New OC.PredicateExpression

            If txtFolio.Text.Trim <> "" Then filtro.Add(HC.NotaVentaFields.Codigo = CInt(txtFolio.Text.Trim))

            If chkFiltroFecha.Checked Then filtro.Add(New FieldBetweenPredicate(HC.NotaVentaFields.FechaVenta, dtpDesde.Value.ToString("yyyy-MM-dd 00:00:00"), dtpHasta.Value.ToString("yyyy-MM-dd 23:59:59")))
            'filtro.Add(HC.NotaVentaFields.Mod = False)
            'filtro.Add(HC.NotaVentaFields.FechaVenta >= dtpDe  sde.Value.Date)
            'filtro.Add(HC.NotaVentaFields.FechaVenta <= dtpHasta.Value.Date)
            Dim Notas As New CN.NotaVentaCollectionClass
            Notas.Obtener(filtro)

            'Dim notasResp As New CN.NotaVentaRespCollectionClass
            'filtro = New OC.PredicateExpression
            'If txtFolio.Text.Trim <> "" Then filtro.Add(HC.NotaVentaRespFields.Codigo = CInt(txtFolio.Text.Trim))

            'If chkFiltroFecha.Checked Then filtro.Add(New FieldBetweenPredicate(HC.NotaVentaRespFields.FechaVenta, dtpDesde.Value.ToString("yyyy-MM-dd 00:00:00"), dtpHasta.Value.ToString("yyyy-MM-dd 23:59:59")))
            'notasResp.Obtener(filtro)
            If Notas.Count > 0 Then
                For Each det As CN.NotaVentaClass In Notas
                    dgvNotas.Rows.Add(det.Codigo, det.Total, det.FechaVenta, "NO")
                Next
                'For Each det As CN.NotaVentaRespClass In notasResp
                '    dgvNotas.Rows.Add(det.Codigo, det.Total, det.FechaVenta, "SI")
                'Next
                mtb.sbCambiarEstadoBotones("Buscar")
            Else
                Cancelar = True
                dgvDetalle.Rows.Clear()
                MessageBox.Show("No se encontraron resultados.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            Cancelar = True
        End If
        Me.Cursor = Cursors.Default
        ''dgvNotas.DataSource = Notas
        ''LlenarGrid()

    End Sub

    Public Function Validar() As Boolean
        Dim Mensaje As String = ""

        Dim s As String = txtFolio.Text.Trim

        ' Try to parse it.
        ' ... If it isn't a number, use -1.
        Dim num As Integer
        

        If chkFiltroFecha.Checked Then
            If dtpDesde.Value.Date > dtpHasta.Value.Date Then
                Mensaje &= "*La fecha de inicio debe ser mernor o igual a la fecha final." & vbLf
            End If
        Else
            If Not Integer.TryParse(s, num) Then
                Mensaje &= "*El texto introducido en folio de la nota no es un numero." & vbLf
            End If
            If txtFolio.Text.Trim = "" Then
                Mensaje &= "*Es necesario el folio de la nota." & vbLf
            End If
        End If

        If Mensaje <> "" Then
            Mensaje = "Antes de continuar verifique lo siguiente:" & vbLf & vbLf & Mensaje
            MessageBox.Show(Mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        txtFolio.Text = ""
        chkFiltroFecha.Checked = False
        gpFechas.Enabled = False
        dtpDesde.Value = Now
        dtpHasta.Value = Now
        dgvNotas.Rows.Clear()
        dgvDetalle.Rows.Clear()
        txtFolio.Tag = Nothing
        txtFolio.Focus()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        'If txtFolio.Tag = "" Or txtFolio.Tag Is Nothing Then
        '    Return
        'End If
        If txtFolio.Tag IsNot Nothing Then
            ReImprimir(txtFolio.Tag, "Reimpresión")
            'Me.ActiveControl = Me
        End If
    End Sub

    Public Sub LlenarGrid(ByVal CodNota As Integer, ByVal Modif As String)
        Dim NotaVenta As New CN.NotaVentaClass()
        Dim NotaVentaR As New CN.NotaVentaRespClass()
        'NotaVenta.Obtener(CInt(txtFolio.Text.Trim))
        'If Modif.Equals("SI") Then
        '    NotaVentaR.Obtener(CodNota)
        '    dgvDetalle.Rows.Clear()
        '    Dim cont As Integer = 0
        '    Dim Totalkit As Integer = 0
        '    Dim contKits As Integer = 1
        '    Dim SumKit As Decimal = 0
        '    For Each det As CN.NotaVentaDetalleRespClass In NotaVentaR.Detalles
        '        If det.IdProductoCompuesto <> 0 Then
        '            cont += 1

        '            Dim kitdet As New CN.DetalleKitCollectionClass
        '            Dim prod As New CN.ProductoGeneralClass(det.IdProductoCompuesto)
        '            kitdet.Obtener(det.IdProductoCompuesto)

        '            If cont = 1 Then
        '                Totalkit = kitdet.Count
        '            End If
        '            If cont >= Totalkit Then
        '                cont = 0
        '                SumKit = SumKit + det.Importe
        '                'contKits += 1
        '                dgvDetalle.Rows.Add(prod.Descripcion, 1, SumKit, SumKit)
        '                SumKit = 0
        '                ''dgvDetalle.Rows.Add(prod.Descripcion, 1, prod.Precio(1).PrecioVentaC, prod.Precio(1).PrecioVentaC)
        '            Else
        '                SumKit = SumKit + det.Importe
        '            End If
        '        Else
        '            dgvDetalle.Rows.Add(det.Producto.Descripcion, det.Cantidad, det.Precio, det.Cantidad * det.Precio)
        '        End If
        '        ' dgvDetalle.Rows.Add(det.Producto.Descripcion, det.Cantidad, det.Precio, det.Cantidad * det.Precio)
        '        'txtFolio.Tag = txtFolio.Text.Trim
        '    Next
        '    Application.DoEvents()
        '    dgvNotas.Focus()
        'Else
        NotaVenta.Obtener(CodNota)
        dgvDetalle.Rows.Clear()
        Dim cont As Integer = 0
        Dim Totalkit As Integer = 0
        Dim contKits As Integer = 1
        Dim SumKit As Decimal = 0
        For Each det As CN.NotaVentaDetalleClass In NotaVenta.Detalles
            If det.IdProductoCompuesto <> 0 Then
                cont += 1

                Dim kitdet As New CN.DetalleKitCollectionClass
                Dim prod As New CN.ProductoGeneralClass(det.IdProductoCompuesto)
                kitdet.Obtener(det.IdProductoCompuesto)

                If cont = 1 Then
                    Totalkit = kitdet.Count
                End If
                If cont >= Totalkit Then
                    cont = 0
                    SumKit = SumKit + det.Importe
                    'contKits += 1
                    dgvDetalle.Rows.Add(prod.Descripcion, 1, SumKit, SumKit)
                    SumKit = 0
                    ''dgvDetalle.Rows.Add(prod.Descripcion, 1, prod.Precio(1).PrecioVentaC, prod.Precio(1).PrecioVentaC)
                Else
                    SumKit = SumKit + det.Importe
                End If
            Else
                dgvDetalle.Rows.Add(det.Producto.Descripcion, det.Cantidad, det.Precio, det.Cantidad * det.Precio)
            End If
            ' dgvDetalle.Rows.Add(det.Producto.Descripcion, det.Cantidad, det.Precio, det.Cantidad * det.Precio)
            'txtFolio.Tag = txtFolio.Text.Trim
        Next
        Application.DoEvents()
        dgvNotas.Focus()
        'End If




        'Me.ActiveControl = Me
    End Sub

    Private Sub ReImprimir(ByVal CodNota As Integer, Optional ByVal Reimp As String = "")
        Dim prtSet As New PrinterSettings

        Try
            'For Each nomprt As String In PrinterSettings.InstalledPrinters
            '    If nomprt.ToUpper = "TICKET" Then
            '        prtSet.PrinterName = nomprt
            '    End If
            'Next
            Dim NotaVenta As New CN.NotaVentaClass()
            Dim NotaVentaR As New CN.NotaVentaRespClass()

            NotaVenta.Obtener(CodNota)

            If NotaVenta.Estatus = ClasesNegocio.CondicionEnum.INACTIVOS Then
                Reimp &= " Cancelada"
            End If


            ' If Not NotaVenta.Modif Then
            Dim usuario As New CN.UsuarioClass(NotaVenta.UsuarioAlta)


            Dim ds As New dsNotaVenta()
            With ds
                .NotaVenta.AddNotaVentaRow(NotaVenta.Codigo, NotaVenta.IdSucursal, NotaVenta.Sucursal.DescripcionCorta, NotaVenta.Subtotal, NotaVenta.Descuento,
                                            NotaVenta.Total, NotaVenta.FechaVenta, NotaVenta.IVA, NotaVenta.IEPS, 0, NotaVenta.PagoEfectivo + NotaVenta.PagoTarjeta,
                                            NotaVenta.Cambio, usuario.UserName.ToUpper, NotaVenta.ObservacionesCancelacion)
                Dim cont As Integer = 0
                Dim Totalkit As Integer = 0
                Dim SumKit As Decimal = 0
                Dim contKits As Integer = 1
                Dim contadorGral As Integer = 0
                For Each det As CN.NotaVentaDetalleClass In NotaVenta.Detalles

                    If det.IdProductoCompuesto <> 0 Then
                        cont += 1
                        Dim kitdet As New CN.DetalleKitCollectionClass
                        Dim prod As New CN.ProductoGeneralClass(det.IdProductoCompuesto)
                        kitdet.Obtener(det.IdProductoCompuesto)

                        If cont = 1 Then
                            Totalkit = kitdet.Count
                        End If


                        '.NotaVentaDetalle.AddNotaVentaDetalleRow(det.NotaVenta, det.IdProducto, det.Producto.Descripcion, det.Cantidad, 0, 0, 0, 0, "", 0, prod.Descripcion & "-" & contKits.ToString, prod.Precio(1).PrecioVentaC, ds.NotaVenta.Rows(0))
                        '.NotaVentaDetalle.AddNotaVentaDetalleRow(det.NotaVenta, det.IdProducto, det.Producto.Descripcion, det.Cantidad, 0, 0, 0, 0, "", 0, prod.Descripcion & "-" & contKits.ToString, det.Importe, ds.NotaVenta.Rows(0))
                        If cont >= Totalkit Then
                            cont = 0
                            SumKit += det.Importe

                            .NotaVentaDetalle.AddNotaVentaDetalleRow(det.NotaVenta, det.IdProducto, det.Producto.Descripcion, det.Cantidad, 0, 0, 0, 0, "", 0, prod.Descripcion & "-" & contKits.ToString, SumKit, ds.NotaVenta.Rows(0))
                            contadorGral += (.NotaVentaDetalle.Count - contadorGral)
                            For index As Integer = 0 To contadorGral - 1
                                .NotaVentaDetalle(index).PrecioKit = SumKit
                            Next

                            SumKit = 0
                            contKits += 1
                        Else
                            .NotaVentaDetalle.AddNotaVentaDetalleRow(det.NotaVenta, det.IdProducto, det.Producto.Descripcion, det.Cantidad, 0, 0, 0, 0, "", 0, prod.Descripcion & "-" & contKits.ToString, 0, ds.NotaVenta.Rows(0))
                            SumKit += det.Importe
                        End If

                    Else
                        .NotaVentaDetalle.AddNotaVentaDetalleRow(det.NotaVenta, det.IdProducto, det.Producto.Descripcion, det.Cantidad, det.Precio, det.Importe, det.Descuento, det.IVA, "", det.IEPS, "", 0, ds.NotaVenta.Rows(0))
                    End If

                    'If det.IdProductoCompuesto <> 0 Then

                    'Else

                    'End If

                Next
                '.NotaVenta.AddNotaVentaRow(Nota.Codigo, Nota.IdSucursal, Nota.Sucursal.DescripcionCorta, Nota.Subtotal, Nota.Descuento, _
                '                           Nota.Total, Nota.FechaVenta, Nota.IVA, Nota.IEPS, 0, Nota.PagoEfectivo + Nota.PagoTarjeta, Nota.Cambio, Nota.UsuarioAlta, _
                '                           Nota.ObservacionesCancelacion)

                'For Each det As CN.NotaVentaDetalleClass In Nota.Detalles
                'Dim prod As New CN.ProductoGeneralClass(det.IdProducto)
                '    If prod.EsKit Then

                '    End If


                '    .NotaVentaDetalle.AddNotaVentaDetalleRow(det.NotaVenta, det.IdProducto, det.Producto.Descripcion, det.Cantidad, det.Precio, det.Importe, det.Descuento, det.IVA, "", det.IEPS, "", 0, ds.NotaVenta.Rows(0))
                'Next
                'For i As Integer = 0 To dgvDetalle.RowCount - 1
                '    .NotaVentaDetalle.AddNotaVentaDetalleRow(Nota.Codigo,dgvDetalle.Rows(i
                'Next

                'For Each row As DataGridViewRow In dgvDetalle.Rows
                '    Dim prod As New CN.ProductoGeneralClass(CInt(row.Cells(clmCodprodComp.Index).Value))

                '    If prod.EsKit Then
                '        'If CInt(row.Cells(clmContKit.Index).Value) <> CInt(dgvDetalle.Rows(row.Index - 1).Cells(clmContKit.Index).Value) Then

                '        'End If
                '        .NotaVentaDetalle.AddNotaVentaDetalleRow(Nota.Codigo, row.Cells(clmCodProducto.Index).Value, row.Cells(clmDescripcion.Index).Value, row.Cells(clmCantidad.Index).Value, 0, 0, 0, 0, "", 0, prod.Descripcion & "- " & row.Cells(clmContKit.Index).Value.ToString, prod.Precio(1).PrecioVentaC, ds.NotaVenta.Rows(0))
                '    Else
                '        If row.Cells(clmCodprodComp.Index).Value IsNot Nothing Then
                '            .NotaVentaDetalle.AddNotaVentaDetalleRow(Nota.Codigo, row.Cells(clmCodProducto.Index).Value, row.Cells(clmDescripcion.Index).Value, row.Cells(clmCantidad.Index).Value, row.Cells(clmPrecioUnit.Index).Value, row.Cells(clmCantidad.Index).Value * row.Cells(clmPrecioUnit.Index).Value, 0, 0, "", 0, "", 0, ds.NotaVenta.Rows(0))
                '        End If
                '    End If


                'Next


            End With
            Dim rep As New crNotaVtaTck
            rep.SetDataSource(ds)
            rep.SetParameterValue("Encabezado", Controlador.Empresa.Nombre + vbNewLine + Controlador.Empresa.Domicilio + vbNewLine + Controlador.Empresa.RFC)
            rep.SetParameterValue("Reimpresion", Reimp)
            'Dim reg As RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\INTEGRALAB\", True)
            rep.PrintOptions.PrinterName = Utilerias.ObtenerNomImpresora.ToString
            rep.PrintToPrinter(1, False, 0, 0)


#If DEBUG Then
            '.....prueba del ticket visualmente
            Dim Prev As New ClasesNegocio.PreVisualizarForm
            Prev.Reporte = rep
            Prev.Text = "TICKET"
            Prev.ShowDialog()
#End If

            rep.Dispose()
            ''            Else
            ''                NotaVentaR.Obtener(CodNota)
            ''                Dim usuario As New CN.UsuarioClass(NotaVentaR.UsuarioAlta)


            ''                Dim ds As New dsNotaVenta()
            ''                With ds
            ''                    .NotaVenta.AddNotaVentaRow(NotaVentaR.Codigo, NotaVentaR.IdSucursal, NotaVentaR.Sucursal.DescripcionCorta, NotaVentaR.Subtotal, NotaVentaR.Descuento,
            ''                                                NotaVentaR.Total, NotaVentaR.FechaVenta, NotaVentaR.IVA, NotaVentaR.IEPS, 0, NotaVentaR.PagoEfectivo + NotaVentaR.PagoTarjeta,
            ''                                                NotaVentaR.Cambio, usuario.UserName.ToUpper, NotaVentaR.ObservacionesCancelacion)
            ''                    Dim cont As Integer = 0
            ''                    Dim Totalkit As Integer = 0
            ''                    Dim SumKit As Decimal = 0
            ''                    Dim contKits As Integer = 1
            ''                    Dim contadorGral As Integer = 0
            ''                    For Each det As CN.NotaVentaDetalleRespClass In NotaVentaR.Detalles

            ''                        If det.IdProductoCompuesto <> 0 Then
            ''                            cont += 1
            ''                            Dim kitdet As New CN.DetalleKitCollectionClass
            ''                            Dim prod As New CN.ProductoGeneralClass(det.IdProductoCompuesto)
            ''                            kitdet.Obtener(det.IdProductoCompuesto)

            ''                            If cont = 1 Then
            ''                                Totalkit = kitdet.Count
            ''                            End If


            ''                            '.NotaVentaRDetalle.AddNotaVentaRDetalleRow(det.NotaVentaR, det.IdProducto, det.Producto.Descripcion, det.Cantidad, 0, 0, 0, 0, "", 0, prod.Descripcion & "-" & contKits.ToString, prod.Precio(1).PrecioVentaC, ds.NotaVentaR.Rows(0))
            ''                            '.NotaVentaRDetalle.AddNotaVentaRDetalleRow(det.NotaVentaR, det.IdProducto, det.Producto.Descripcion, det.Cantidad, 0, 0, 0, 0, "", 0, prod.Descripcion & "-" & contKits.ToString, det.Importe, ds.NotaVentaR.Rows(0))
            ''                            If cont >= Totalkit Then
            ''                                cont = 0
            ''                                SumKit += det.Importe

            ''                                .NotaVentaDetalle.AddNotaVentaDetalleRow(det.NotaVenta, det.IdProducto, det.Producto.Descripcion, det.Cantidad, 0, 0, 0, 0, "", 0, prod.Descripcion & "-" & contKits.ToString, SumKit, ds.NotaVenta.Rows(0))
            ''                                contadorGral += (.NotaVentaDetalle.Count - contadorGral)
            ''                                For index As Integer = 0 To contadorGral - 1
            ''                                    .NotaVentaDetalle(index).PrecioKit = SumKit
            ''                                Next

            ''                                SumKit = 0
            ''                                contKits += 1
            ''                            Else
            ''                                .NotaVentaDetalle.AddNotaVentaDetalleRow(det.NotaVenta, det.IdProducto, det.Producto.Descripcion, det.Cantidad, 0, 0, 0, 0, "", 0, prod.Descripcion & "-" & contKits.ToString, 0, ds.NotaVenta.Rows(0))
            ''                                SumKit += det.Importe
            ''                            End If

            ''                        Else
            ''                            .NotaVentaDetalle.AddNotaVentaDetalleRow(det.NotaVenta, det.IdProducto, det.Producto.Descripcion, det.Cantidad, det.Precio, det.Importe, det.Descuento, det.IVA, "", det.IEPS, "", 0, ds.NotaVenta.Rows(0))
            ''                        End If

            ''                        'If det.IdProductoCompuesto <> 0 Then

            ''                        'Else

            ''                        'End If

            ''                    Next
            ''                    '.NotaVentaR.AddNotaVentaRRow(Nota.Codigo, Nota.IdSucursal, Nota.Sucursal.DescripcionCorta, Nota.Subtotal, Nota.Descuento, _
            ''                    '                           Nota.Total, Nota.FechaVenta, Nota.IVA, Nota.IEPS, 0, Nota.PagoEfectivo + Nota.PagoTarjeta, Nota.Cambio, Nota.UsuarioAlta, _
            ''                    '                           Nota.ObservacionesCancelacion)

            ''                    'For Each det As CN.NotaVentaRDetalleClass In Nota.Detalles
            ''                    'Dim prod As New CN.ProductoGeneralClass(det.IdProducto)
            ''                    '    If prod.EsKit Then

            ''                    '    End If


            ''                    '    .NotaVentaRDetalle.AddNotaVentaRDetalleRow(det.NotaVentaR, det.IdProducto, det.Producto.Descripcion, det.Cantidad, det.Precio, det.Importe, det.Descuento, det.IVA, "", det.IEPS, "", 0, ds.NotaVentaR.Rows(0))
            ''                    'Next
            ''                    'For i As Integer = 0 To dgvDetalle.RowCount - 1
            ''                    '    .NotaVentaRDetalle.AddNotaVentaRDetalleRow(Nota.Codigo,dgvDetalle.Rows(i
            ''                    'Next

            ''                    'For Each row As DataGridViewRow In dgvDetalle.Rows
            ''                    '    Dim prod As New CN.ProductoGeneralClass(CInt(row.Cells(clmCodprodComp.Index).Value))

            ''                    '    If prod.EsKit Then
            ''                    '        'If CInt(row.Cells(clmContKit.Index).Value) <> CInt(dgvDetalle.Rows(row.Index - 1).Cells(clmContKit.Index).Value) Then

            ''                    '        'End If
            ''                    '        .NotaVentaRDetalle.AddNotaVentaRDetalleRow(Nota.Codigo, row.Cells(clmCodProducto.Index).Value, row.Cells(clmDescripcion.Index).Value, row.Cells(clmCantidad.Index).Value, 0, 0, 0, 0, "", 0, prod.Descripcion & "- " & row.Cells(clmContKit.Index).Value.ToString, prod.Precio(1).PrecioVentaC, ds.NotaVentaR.Rows(0))
            ''                    '    Else
            ''                    '        If row.Cells(clmCodprodComp.Index).Value IsNot Nothing Then
            ''                    '            .NotaVentaRDetalle.AddNotaVentaRDetalleRow(Nota.Codigo, row.Cells(clmCodProducto.Index).Value, row.Cells(clmDescripcion.Index).Value, row.Cells(clmCantidad.Index).Value, row.Cells(clmPrecioUnit.Index).Value, row.Cells(clmCantidad.Index).Value * row.Cells(clmPrecioUnit.Index).Value, 0, 0, "", 0, "", 0, ds.NotaVentaR.Rows(0))
            ''                    '        End If
            ''                    '    End If


            ''                    'Next


            ''                End With
            ''                Dim rep As New crNotaVtaTck
            ''                rep.SetDataSource(ds)
            ''                rep.SetParameterValue("Encabezado", Controlador.Empresa.Nombre + vbNewLine + Controlador.Empresa.Domicilio + vbNewLine + Controlador.Empresa.RFC)
            ''                rep.SetParameterValue("Reimpresion", Reimp)
            ''                'Dim reg As RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\INTEGRALAB\", True)
            ''                rep.PrintOptions.PrinterName = Utilerias.ObtenerNomImpresora.ToString
            ''                rep.PrintToPrinter(1, False, 0, 0)


            ''#If DEBUG Then
            ''                '.....prueba del ticket visualmente
            ''                Dim Prev As New ClasesNegocio.PreVisualizarForm
            ''                Prev.Reporte = rep
            ''                Prev.Text = "TICKET"
            ''                Prev.ShowDialog()
            ''#End If

            ''                rep.Dispose()
            ''            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub



    Private Sub dgvNotas_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvNotas.SelectionChanged
        If dgvNotas.RowCount > 0 Then
            txtFolio.Tag = dgvNotas.CurrentRow.Cells(Codigo.Index).Value
            LlenarGrid(CInt(dgvNotas.CurrentRow.Cells(Codigo.Index).Value), CStr(dgvNotas.CurrentRow.Cells(clmModificada.Index).Value))
        Else
            dgvDetalle.Rows.Clear()
        End If
    End Sub

    Private Sub txtFolio_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFolio.KeyDown
        If txtFolio.Text.Length > 0 Then
            If e.KeyCode = Keys.Enter Then
                mtb_ClickBuscar(Nothing, Nothing, False)
            End If
        End If
    End Sub

    Private Sub frmBusqNotasVenta_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        txtFolio.Focus()
    End Sub

   
    Private Sub frmBusqNotasVenta_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Select Case e.KeyChar
            Case Chr(27)
                'BtnCancelar_Click(sender, New System.EventArgs())
                Me.Close()
        End Select
    End Sub
End Class