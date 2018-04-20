Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio

Public Class ComEmisionOrdenCompra

    Private Orden As New ClasesNegocio.OrdenCompraClass
    Private UltimaCantidad As Decimal
    Dim UltimaTeclaPlaza As DateTime
    Dim UltimaTeclaSucursal As DateTime

    Dim UltimaTeclaProveedor As DateTime
    Dim Cotizacion As ClasesNegocio.CotizacionCompraClass
    Dim Nuevo As Boolean
    Dim IdUsuario As Integer
    Dim TipoCambio As Decimal
    Dim OrdenCompraID As Integer
    Dim RenglonQuitaDetalle As Integer ' Renglon para quitar detalle de orden de compra cuando no se quiera ordenar un producto
    Dim PorcentajeIVA As Decimal ' para guardar el porcentaje del iva
    'Dim Orden As New ClasesNegocio.OrdenCompraClass

    Private Sub ComEmisionOrdenCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cursor = Cursors.WaitCursor

            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "001101111"
            MtbEstados.StateLimpiar = "100100001"
            MtbEstados.StateCancelar = "100100001"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100011"
            MtbEstados.StateBorrar = "100100011"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            MEAToolBar1.ToolBarButtonStatus = MtbEstados
            MEAToolBar1.sbCambiarEstadoBotones("Cancelar")

            PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            ProveedorC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            MonedaTC.Obtener()
            cmbMoneda.SelectedIndex = -1
            Orden = New ClasesNegocio.OrdenCompraClass

            Limpiar()
            Deshabilitar()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

#Region "Metodos"
    Private Sub Limpiar()
        Nuevo = True
        cmbPlaza.SelectedIndex = -1
        cmbPlaza.Text = "Seleccione una plaza..."
        cmbSucursal.SelectedIndex = -1
        cmbSucursal.Text = "Seleccione una sucursal..."
        cmbProveedor.SelectedIndex = -1
        cmbProveedor.Text = "Seleccione un proveedor..."
        txtSolicito.Clear()
        txtObservaciones.Clear()
        txtTipoCambio.Clear()
        txtDiasCredito.Clear()
        dgvDetalleOrdenCompra.Rows.Clear()
        ' txtFolioCotizacion.Clear()
        txtFolioOrden.Clear()
        Me.txtEntregarA.Clear()
        Me.txtSubTotalOtraMoneda.Clear()
        Me.txtDescuentoOtraMoneda.Clear()
        txtFletesOtraMonedas.Clear()
        txtIVAOtraMoneda.Clear()
        txtTotalOtraMoneda.Clear()
        Me.lblEstatus.Text = ""
        Me.lblEstatus.Visible = False
        Me.grpImportesOtraMoneda.Visible = False
        Me.grpImportesPeso.Visible = True
        Me.txtFletes.Text = 0
        Me.txtIVAPesos.Text = 0
        Me.txtSubTotal.Text = 0
        txtDescuento.Text = 0
        txtTotal.Text = 0
        Me.txtIVAFletes.Text = 0
        Me.dgvEspejoOrden.Rows.Clear()
        Me.dgvSolicitudes.Rows.Clear()
    End Sub

    Private Sub Deshabilitar()
        dtFechaAlta.Enabled = False
        Me.dgvDetalleOrdenCompra.Enabled = False
        Me.dgvSolicitudes.Enabled = False
        ' Me.DataGrid.ReadOnly = True
        cmbPlaza.Enabled = False
        cmbSucursal.Enabled = False
        cmbProveedor.Enabled = False
        cmbMoneda.Enabled = False
        'Me.txtFolioCotizacion.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.txtEntregarA.Enabled = False
    End Sub

    Private Sub Habilitar()
        dtFechaAlta.Enabled = True
        '  Me.DataGrid.ReadOnly = False
        'Me.txtEntregarA.Enabled = True
        Me.dgvDetalleOrdenCompra.Enabled = True
        Me.dgvDetalleOrdenCompra.ReadOnly = False
        Me.dgvSolicitudes.Enabled = True
        clmProductoOrdenCompra.ReadOnly = True
        clmUnidadMedidaOrdenCompra.ReadOnly = True
        clmCantidadSolicitada.ReadOnly = True
        clmIVA.ReadOnly = True
        clmImporteDetalle.ReadOnly = True

        cmbPlaza.Enabled = True
        cmbSucursal.Enabled = True
        cmbProveedor.Enabled = True
        cmbMoneda.Enabled = True
        Me.txtIVAFletes.Enabled = True
        Me.txtFletes.Enabled = True
        'Me.txtFolioCotizacion.Enabled = True
        Me.txtObservaciones.Enabled = True
    End Sub

    Private Function Validar() As Boolean
        Try
            'If Me.txtFolioCotizacion.Text = "" Then
            '    MsgBox("Debe ingresar una cotización", MsgBoxStyle.Exclamation, "Faltan Datos")
            '    Return False
            'End If

            If Me.cmbProveedor.SelectedValue Is Nothing Then
                MessageBox.Show("Seleccione un proveedor antes de Realizar la  Orden de Compra", Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
            Dim Selecciono As Boolean = False
        
            For i As Integer = 0 To Me.dgvDetalleOrdenCompra.Rows.Count - 2
                If Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmCantidadOrdenada.Index).Value = 0 Then
                    Selecciono = False
                    Exit For
                Else
                    Selecciono = True
                End If
            Next

            If Not Selecciono Then
                MessageBox.Show("No se pueden Ordenar Productos con Cantidad a Ordenar igual a 0(Cero)", Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            Selecciono = False
            For i As Integer = 0 To Me.dgvDetalleOrdenCompra.Rows.Count - 2
                If Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmCostoUnitario.Index).Value = 0 Then
                    Selecciono = False
                    Exit For
                Else
                    Selecciono = True
                End If
            Next

            If Not Selecciono Then
                MessageBox.Show("No se puenden Ordenar Productos con Costo Unitario igual a 0(Cero)", Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    'Private Sub QuitarProductos()
    '    Dim r As Integer = dgvDetalleOrdenCompra.Rows.Count
    '    For i As Integer = 0 To r - 1
    '        If r - 1 < i Then
    '            Exit For
    '        End If

    '        If Not CBool(dgvDetalleOrdenCompra.Rows(i).Cells(0).Value) Then
    '            Orden.Detalle.Remove(DirectCast(dgvDetalleOrdenCompra.Rows(i).DataBoundItem, ClasesNegocio.OrdenCompraDetalleClass))
    '            i -= 1
    '            r -= 1
    '        End If
    '    Next
    'End Sub

    Private Sub CalcularTotal()
        Try
            Dim importe, descuento, iva, importesiniva As Decimal

            For i As Integer = 0 To Me.dgvDetalleOrdenCompra.Rows.Count - 1
                importesiniva += Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmCantidadOrdenada.Index).Value * Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmCostoUnitario.Index).Value
                importe += Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmImporteDetalle.Index).Value
                iva += Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmIVA.Index).Value
                descuento += Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmDescuento.Index).Value
            Next

            Me.txtSubTotal.Text = importesiniva.ToString("C2")
            Me.txtDescuento.Text = descuento.ToString("C2")
            Me.txtIVAPesos.Text = iva.ToString("C2")
            Me.txtTotal.Text = importe.ToString("C2")

            'importes para cuando sea otra moneda diferente a la local
            If Me.txtTipoCambio.Text > 1 Then
                Me.grpImportesOtraMoneda.Visible = True
            Else
                Me.grpImportesOtraMoneda.Visible = False
            End If
            Me.txtSubTotalOtraMoneda.Text = (importe * Me.txtTipoCambio.Text).ToString("C2")
            Me.txtDescuentoOtraMoneda.Text = (descuento * Me.txtTipoCambio.Text).ToString("C2")
            'txtSubTotalPesos.Text = ((importe - descuento) * Me.txtTipoCambio.Text).ToString("C2")
            Me.txtIVAOtraMoneda.Text = (iva * Me.txtTipoCambio.Text).ToString("C2")
            Me.txtTotalOtraMoneda.Text = ((importe - descuento + iva) * Me.txtTipoCambio.Text).ToString("C2")

            'For Each det As ClasesNegocio.OrdenCompraDetalleClass In Orden.Detalle
            '    If det.CantidadOrdenada > 0 Then
            '        importe += det.CantidadOrdenada * det.Precio
            '        descuento += det.Descuento
            '        sumaCantSol += det.CantidadSolicitada
            '        sumaCantOrd += det.CantidadOrdenada

            '        If det.Producto.SeAplicaIva Then
            '            iva += (det.Precio * det.CantidadOrdenada - det.Descuento) * 0.15
            '        End If
            '    End If
            '    'Next

            '    Orden.Importe = importe
            '    Orden.Descuento = descuento
            '    Orden.SubTotal = importe - descuento
            '    Orden.IVA = iva
            '    Orden.Total = iva + Orden.SubTotal

            '    txtSubTotalOtraMoneda.Text = Orden.Importe.ToString("C2")
            '    txtDescuentoOtraMoneda.Text = Orden.Descuento.ToString("C2")
            '    txtFletesOtraMonedas.Text = Orden.SubTotal.ToString("C2")
            '    txtIVAOtraMoneda.Text = Orden.IVA.ToString("C2")
            '    txtTotalOtraMoneda.Text = Orden.Total.ToString("C2")
            '    Me.txtCantidadOrdenada.Text = sumaCantOrd.ToString("N3")
            '    Me.txtCantidadSolicitada.Text = sumaCantSol.ToString("N3")

            'If TipoCambio > 1 Then
            '    grpImportesPesos.Visible = True
            '    Me.txtImportePesos.Text = (importe * Cotizacion.TipoCambio).ToString("C2")
            '    txtDescuentoPesos.Text = (descuento * Cotizacion.TipoCambio).ToString("C2")
            '    txtSubTotalPesos.Text = ((importe - descuento) * Cotizacion.TipoCambio).ToString("C2")
            '    txtIVAPesos.Text = (iva * Cotizacion.TipoCambio).ToString("C2")
            '    txtTotalPesos.Text = ((importe - descuento + iva) * Cotizacion.TipoCambio).ToString("C2")
            'End If

        Catch ex As Exception
            MessageBox.Show("Error al calcular importes totales", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    'este funcion o proceso nos sirve pare el calculo del detalle de cada renglon
    Private Sub CalcularImporteRenglonDetalle(ByVal Renglon As Integer, ByVal SeAplicaIVA As Boolean, ByVal CantidadOrdenada As Decimal, ByVal CostoUnitario As Decimal, ByVal Descuento As Decimal, ByVal PorcentajeIVA As Decimal)
        Try
            Dim ImporteIVA As Decimal = 0
            Dim Importe As Decimal
            Dim PorcIVA As Decimal

            If SeAplicaIVA Then
                ImporteIVA = (((CantidadOrdenada * CostoUnitario) - Descuento) * (PorcentajeIVA / 100))
                Importe = ((CantidadOrdenada * CostoUnitario) - Descuento) + ImporteIVA
                PorcIVA = PorcentajeIVA
            Else
                Importe = (CantidadOrdenada * CostoUnitario) - Descuento
                PorcIVA = 0
            End If
            Me.dgvDetalleOrdenCompra.Rows(Renglon).Cells(Me.clmIVA.Index).Value = ImporteIVA
            Me.dgvDetalleOrdenCompra.Rows(Renglon).Cells(Me.clmImporteDetalle.Index).Value = Importe
            Me.dgvDetalleOrdenCompra.Rows(Renglon).Cells(Me.clmsubtotal.Index).Value = ((CantidadOrdenada * CostoUnitario) - Descuento)
            Me.dgvDetalleOrdenCompra.Rows(Renglon).Cells(Me.clmPorcentajeIVAEspejo.Index).Value = PorcentajeIVA
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Guardar()
        Orden.IdSucursal = CType(cmbSucursal.SelectedValue, Integer)
        Orden.IdProveedor = CType(cmbProveedor.SelectedValue, Integer)
        Orden.Observaciones = txtObservaciones.Text
        Orden.IdMoneda = CType(cmbMoneda.SelectedValue, Integer)
        Orden.TipoCambio = CType(txtTipoCambio.Text, Integer)
        If IsNumeric(txtDiasCredito.Text) Then
            Orden.DiasCredito = CDbl(txtDiasCredito.Text)
        End If
        '
        Orden.ObservacionesCancelacion = ""
        Orden.Descuento = Me.txtDescuento.Text
        Orden.Importe = Me.txtTotal.Text
        Orden.ImpteIvaFlete = Me.txtIVAFletes.Text
        If CDbl(Me.txtIVAPesos.Text) > 0 Then
            Orden.IVAPor = PorcentajeIVA
        Else
            Orden.IVAPor = 0
        End If

        Orden.IVATotal = Me.txtIVAPesos.Text
        Orden.IvaFlete = Me.txtIVAFletes.Text
        Orden.Observaciones = Me.txtObservaciones.Text
        Orden.SubTotal = Me.txtSubTotal.Text
        Orden.Total = Me.txtTotal.Text
        Orden.FechaOrdenCompra = Me.dtFechaAlta.Value.ToShortDateString
        Orden.IdUsuarioAlta = Controlador.Sesion.Usrndx
        Orden.Estatus = ClasesNegocio.EstatusOrdenCompra.VIGENTE
        Orden.Autorizada = False
        Orden.Recibida = ClasesNegocio.EstatusOrdenRecibida.NO_RECIBIDA


        'If IsNumeric(txtTipoCambio.Text) Then
        '    Orden.TipoCambio = CDbl(txtTipoCambio.Text)
        'End If
        'Orden. = CType(cmbMoneda.SelectedValue, Integer)
    End Sub

    Private Sub Imprimir()
        Try
            ImpresionOrdenCompra(Orden)
            'Dim OrdenCompra As New DataSet
            'Dim DatosOrden As New dsOrdenCompra.DataTable2DataTable
            'Dim Reporte As New crEmisionOrdenCompra
            'Dim VerReporte As New FrmReportes

            '''Dim cont As Integer = OrdenCompra.Tables(0).Rows.Count            
            'For Each Renglon As DataRow In OrdenCompra.Tables(0).Rows
            '    'Dim var As String = Renglon(0)
            '    'Datos.DataTable1.AddDataTable1Row(Renglon("LoteRecepcion"), Renglon("FechaRecepcion"), Renglon("Productor"), Renglon("Cabezas"), Renglon("KilosEnviados"), Renglon("KilosRecibidos"), Renglon("Diferencia"))
            '    DatosOrden.AddDataTable2Row(Renglon("Folio"), Renglon("SucursalId"), Renglon("SCDescripcion"), Renglon("ProveedorId"), _
            '    Renglon("PrRazSocial"), Renglon("FechaAlta"), CDec(Renglon("ImporteOrden")).ToString("C2"), CDec(Renglon("DescuentoOrden")).ToString("C2"), CDec(Renglon("SubTotal")).ToString("C2"), _
            '    CDec(Renglon("IVA")).ToString("C2"), CDec(Renglon("total")).ToString("C2"), Renglon("ProductoId"), Renglon("PdDescripcion"), CDec(Renglon("CantidadOrdenar")).ToString("N3"), _
            '    Renglon("UMDescripcion"), CDec(Renglon("Precio")).ToString("C2"), CDec(Renglon("DescuentoDetalle")).ToString("C2"), CDec(Renglon("ImporteDetalle")).ToString("C2"), Renglon("Observaciones"), Renglon("PLDescripcion"))
            'Next

            'OrdenCompra.Tables.Add(DatosOrden)
            ''Reporte.SetDataSource(DatosOrden)
            'Reporte.SetDataSource(OrdenCompra.Tables(0))
            'Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            'Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)

            'VerReporte.CRV.ReportSource = Reporte
            'VerReporte.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'imprimir orden de compra
    Public Sub ImpresionOrdenCompra(ByVal OrdenC As OrdenCompraClass)
        Dim PreVisualizar As New PreVisualizarForm
        Dim Compras As New OrdenCompraCollectionClass

        Compras.Add(OrdenC)
        PreVisualizar.Reporte = rptOrdenCompra(Compras)
        PreVisualizar.ShowDialog()
    End Sub

    Private Function rptOrdenCompra(ByRef Compras As OrdenCompraCollectionClass) As crEmisionOrdenCompra
        ' Dim dsSolicitudProduc As dsSolicitudProduc = New dsSolicitudProduc, dtSolicitudProducCab As dsSolicitudProduc.CabeceroDataTable = dsSolicitudProduc.Cabecero
        'Dim dtSolicitudProducDet As dsSolicitudProduc.DetalleDataTable = dsSolicitudProduc.Detalle
        Dim dsDatosOrden As New dsOrdenCompra
        Dim dtOrdenCompra As dsOrdenCompra.DataTable2DataTable = dsDatosOrden.DataTable2


        rptOrdenCompra = New crEmisionOrdenCompra

        For Each Comp As OrdenCompraClass In Compras
            For i As Integer = 0 To Comp.Detalle.Count - 1
                Dim compRow As dsOrdenCompra.DataTable2Row = dtOrdenCompra.AddDataTable2Row(Comp.FolioOrdenCompra, Comp.Sucursal.Codigo, Comp.Sucursal.Descripcion, Comp.Proveedor.Codigo, Comp.Proveedor.RazonSocial, _
                                                                                        Comp.FechaOrdenCompra, Comp.Total, Comp.Descuento, Comp.SubTotal, Comp.IVATotal, Comp.Total, Comp.Detalle(i).IdProducto, _
                                                                                            Comp.Detalle(i).ProductoNombre, Comp.Detalle(i).CantidadOrdenada, Comp.Detalle(i).UnidadMedida, Comp.Detalle(i).Precio, _
                                                                                            Comp.Detalle(i).Descuento, Comp.Detalle(i).Importe, Comp.Observaciones, Comp.Sucursal.Plaza.Descripcion)

            Next

            'Next

            'For Each det As SolicitudProductoDetalleClass In Solic.Detalle
            '    Dim FechaSurtir As Date = #1/1/1900#

            '    dtSolicitudProducDet.AddDetalleRow(SolicRow, det.Producto.Descripcion, det.Cantidad, det.Urgente.ToString, det.UnidadMedida, det.Producto.Marca.NombreCorto, det.Producto.Linea.Descripcion)
            'Next
        Next
        rptOrdenCompra.SetDataSource(dsDatosOrden)
        rptOrdenCompra.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
        rptOrdenCompra.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnom)
        'rptOrdenCompra.SetParameterValue(1, "Compras Generales/Orden de Compras")
        Return rptOrdenCompra
    End Function
#End Region

    Private Sub cmbPlaza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPlaza.KeyPress
        If e.KeyChar <> Chr(13) Then
            Tmplaza.Stop()
            UltimaTeclaPlaza = Now
            Me.Tmplaza.Start()
        End If
    End Sub

    Private Sub cmbPlaza_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbPlaza.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.cmbPlaza.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        If cmbPlaza.SelectedIndex > -1 Then
            SucursalC.Obtener(cmbPlaza.SelectedValue, ClasesNegocio.CondicionEnum.ACTIVOS)
            cmbSucursal.SelectedIndex = -1
            cmbSucursal.Text = "Seleccione una sucursal..."
        Else
            Me.SucursalC.Clear()
            cmbSucursal.SelectedIndex = -1
        End If
    End Sub

    Private Sub cmbMoneda_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbMoneda.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                MonedaTC.Obtener()
                cmbMoneda.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMoneda.SelectedIndexChanged
        If cmbMoneda.SelectedIndex > -1 Then
            TipoCambio = DirectCast(cmbMoneda.SelectedItem, ClasesNegocio.TipoMonedaClass).TipoCambio(Me.dtFechaAlta.Value)
            txtTipoCambio.Text = TipoCambio.ToString("C2")
        Else
            txtTipoCambio.Clear()
        End If
    End Sub

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBorrar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Orden")
        Try

            Orden.Obtener(CStr(OrdenCompraID))

            If Orden.Estatus = EstatusOrdenCompra.FINIQUITADO Then
                MsgBox("No se puede cancelar por que esta Finiquitada", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If

            If Orden.Estatus = EstatusOrdenCompra.FACTURADA Then
                MsgBox("No se puede cancelar por que esta Facturada", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If

            If Orden.Recibida = EstatusOrdenRecibida.RECIBIDA Then
                MsgBox("No se puede cancelar por que esta recibida", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If
            If Orden.Recibida = EstatusOrdenRecibida.PARCIAL Then
                MsgBox("No se puede cancelar por que esta recibida parcialmente", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If
            If Orden.Estatus = EstatusOrdenCompra.CANCELADO Then
                MsgBox("No se puede cancelar por que ya ha sido cancelado", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If

            If Orden.Borrar(Trans) Then
                'reactivar las solictudes que se han emitido en esta orden.
                For i As Integer = 0 To Orden.Detalle.Count - 1
                    Dim SolicitudDetalleProductos As ClasesNegocio.SolicitudProductoDetalleClass = ClasesNegocio.SolicitudProductoDetalleClass.Obtener(Orden.Detalle(i).IdSolicitud, Orden.Detalle(i).IdProducto)
                    SolicitudDetalleProductos.Estatus = ClasesNegocio.SolicitudProductoDetalleClass.EstatusSolicitudDetalle.VIGENTE
                    SolicitudDetalleProductos.Guardar(Trans)
                Next
                Trans.Commit()
                MsgBox("Se ha cancelado la orden de compra", MsgBoxStyle.Information, "Aviso")
                Limpiar()
                Deshabilitar()
            Else
                Trans.Rollback()
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Try
            Dim ventana As New ComBusquedaOrdenCompra

            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Recibida As String
                Dim OrdenCompra As New ClasesNegocio.OrdenCompraClass

                OrdenCompra.Obtener(ventana.DgvOrdencompra.SelectedRows(0).Cells("clmIdOrdenCompra").Value)

                Orden = OrdenCompra

                'Orden.Obtener(ventana.DgvOrdencompra.SelectedRows(0).Cells("Folio").Value)

                'Orden = DirectCast(ventana.DgvOrdencompra.SelectedRows(0).DataBoundItem, ClasesNegocio.OrdenCompraClass)

                cmbPlaza.SelectedValue = Orden.Sucursal.Plaza.Codigo
                cmbSucursal.SelectedValue = Orden.Sucursal.Codigo
                cmbProveedor.SelectedValue = Orden.Proveedor.Codigo
                cmbMoneda.SelectedValue = Orden.Detalle(0).IdMoneda
                txtTipoCambio.Text = Orden.Detalle(0).TipoCambio.ToString("C2")
                txtDiasCredito.Text = Orden.DiasCredito
                Me.txtObservaciones.Text = Orden.Observaciones


                Me.dtFechaAlta.Value = Orden.FechaOrdenCompra
                Me.lblEstatus.Visible = True
                Me.lblEstatus.Text = Orden.Estatus.ToString
                Recibida = Orden.Recibida.ToString
                If Recibida = ClasesNegocio.EstatusOrdenRecibida.PARCIAL.ToString Then
                    Me.lblEstatus.Text = Orden.Recibida.ToString
                End If
                If Recibida = ClasesNegocio.EstatusOrdenRecibida.RECIBIDA.ToString Then
                    Me.lblEstatus.Text = Orden.Recibida.ToString
                End If
                Me.txtSolicito.Text = Orden.UsuarioAlta.NombreCompleto
                Me.IdUsuario = Orden.UsuarioAlta.Codigo

                'Me.dgvDetalleOrdenCompra.DataSource = Orden.Detalle
                For i As Integer = 0 To Orden.Detalle.Count - 1
                    Me.dgvDetalleOrdenCompra.Rows.Add()
                    Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmProductoOrdenCompra.Index).Value = Orden.Detalle(i).Producto
                    Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmUnidadMedidaOrdenCompra.Index).Value = Orden.Detalle(i).Producto.UnidadMedida
                    Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmCantidadSolicitada.Index).Value = Orden.Detalle(i).CantidadSolicitada
                    Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmCantidadOrdenada.Index).Value = Orden.Detalle(i).CantidadOrdenada
                    Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmCostoUnitario.Index).Value = Orden.Detalle(i).Precio
                    Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmDescuento.Index).Value = Orden.Detalle(i).Descuento
                    Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmImporteDetalle.Index).Value = Orden.Detalle(i).Importe
                    AgregarDetalleaEspejo(i)
                Next

                Me.dgvDetalleOrdenCompra.ReadOnly = True
                Me.dgvDetalleOrdenCompra.Enabled = True

                'For i As Integer = 0 To Me.dgvDetalleOrdenCompra.Rows.Count - 1
                '    Me.dgvDetalleOrdenCompra.Rows(i).Cells("clmchk").Value = True
                'Next

                Me.txtFolioOrden.Text = Orden.FolioOrdenCompra
                OrdenCompraID = Orden.IdOrdenCompra
                CalcularTotal()
                Me.sstab.SelectedTab = Me.tpDetalle
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub
    
    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickCancelar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickEditar
        If Me.lblEstatus.Text = ClasesNegocio.EstatusOrdenCompra.CANCELADO.ToString Then
            MsgBox("No se puede editar por que ya ha sido cancelada", MsgBoxStyle.Exclamation, "Aviso")
            Cancelar = True
            Exit Sub
        End If

        If Me.lblEstatus.Text = ClasesNegocio.EstatusOrdenCompra.FINIQUITADO.ToString Then
            MsgBox("No se puede editar por que ya ha sido finiquitada", MsgBoxStyle.Exclamation, "Aviso")
            Cancelar = True
            Exit Sub
        End If

        If Me.lblEstatus.Text = ClasesNegocio.EstatusOrdenRecibida.RECIBIDA.ToString Then
            MsgBox("No se puede editar por que ya ha sido recibida", MsgBoxStyle.Exclamation, "Aviso")
            Cancelar = True
            Exit Sub
        End If

        If Me.lblEstatus.Text = ClasesNegocio.EstatusRecepcionEnum.PARCIAL.ToString Then
            MsgBox("No se puede editar por que ya ha sido recibida parcialmente", MsgBoxStyle.Exclamation, "Aviso")
            Cancelar = True
            Exit Sub
        End If

        If Orden.Autorizada Then
            MsgBox("No se puede editar por que ya ha sido Autorizada", MsgBoxStyle.Exclamation, "Aviso")
            Cancelar = True
            Exit Sub
        End If
        dgvDetalleOrdenCompra.ReadOnly = False
        clmProductoOrdenCompra.ReadOnly = True
        clmUnidadMedidaOrdenCompra.ReadOnly = True
        clmCantidadSolicitada.ReadOnly = True
        clmIVA.ReadOnly = True
        clmImporteDetalle.ReadOnly = True
        Nuevo = False
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickGuardar
        Dim Trans As New IntegraLab.ORM.HelperClasses.Transaction(IsolationLevel.ReadCommitted, "Orden")
        Try
            Dim ProductoOrden As ClasesNegocio.ProductoGeneralClass

            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If
            'QuitarProductos()

            If Nuevo Then
                Guardar()
                For i As Integer = 0 To Me.dgvEspejoOrden.Rows.Count - 1                    
                    ProductoOrden = New ClasesNegocio.ProductoGeneralClass
                    ProductoOrden = Me.dgvEspejoOrden.Rows(i).Cells(Me.clmProductoEspejo.Index).Value
                    If ProductoOrden Is Nothing Then Exit For
                    Orden.Detalle.AddNew()
                    Orden.Detalle(i).CantidadOrdenada = Me.dgvEspejoOrden.Rows(i).Cells(Me.clmCantOrdEspejo.Index).Value
                    Orden.Detalle(i).CantidadSolicitada = Me.dgvEspejoOrden.Rows(i).Cells(Me.clmCantSolEspejo.Index).Value
                    Orden.Detalle(i).Descuento = Me.dgvEspejoOrden.Rows(i).Cells(Me.clmDescuentoEspejo.Index).Value
                    Orden.Detalle(i).IdProducto = ProductoOrden.Codigo
                    Orden.Detalle(i).IdSolicitud = Me.dgvEspejoOrden.Rows(i).Cells(Me.clmIdSolicitudEspejo.Index).Value
                    Orden.Detalle(i).Importe = Me.dgvEspejoOrden.Rows(i).Cells(Me.clmImporteEspejo.Index).Value
                    Orden.Detalle(i).Precio = Me.dgvEspejoOrden.Rows(i).Cells(Me.clmCostoUnitarioEspejo.Index).Value
                    Orden.Detalle(i).Renglon = i
                    Orden.Detalle(i).IdMoneda = CType(cmbMoneda.SelectedValue, Integer)
                    Orden.Detalle(i).TipoCambio = Me.txtTipoCambio.Text
                    Orden.Detalle(i).Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                Next
                If Orden.Guardar(Trans) Then
                    'agregar a solicitud los folios o id para actualizar esas solicitudes una vez que se emiten.
                    For i As Integer = 0 To Me.dgvEspejoOrden.Rows.Count - 1
                        ProductoOrden = New ClasesNegocio.ProductoGeneralClass
                        ProductoOrden = Me.dgvEspejoOrden.Rows(i).Cells(Me.clmProductoEspejo.Index).Value
                        If ProductoOrden Is Nothing Then Exit For
                        Dim SolicitudDetalleProductos As ClasesNegocio.SolicitudProductoDetalleClass = ClasesNegocio.SolicitudProductoDetalleClass.Obtener(Me.dgvEspejoOrden.Rows(i).Cells(Me.clmIdSolicitudEspejo.Index).Value, ProductoOrden.Codigo)
                        SolicitudDetalleProductos.Estatus = ClasesNegocio.SolicitudProductoDetalleClass.EstatusSolicitudDetalle.EMITIDA
                        SolicitudDetalleProductos.Guardar(Trans)
                    Next
                    Trans.Commit()
                    MsgBox("Se ha guardado la orden de compra con el Folio: " & Me.Orden.FolioOrdenCompra, MsgBoxStyle.Information, "Aviso")
                    Me.txtFolioOrden.Text = Me.Orden.FolioOrdenCompra
                    'Imprimir()
                    Limpiar()
                    Deshabilitar()
                Else
                    MsgBox("No se logró guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                    Cancelar = True
                End If
                'Else
                '    'GuardarModificado()
                '    If Not Orden.Guardar(Trans) Then
                '        Cancelar = True
                '    Else
                '        Trans.Commit()
                '        MsgBox("Se logró la modificación de la orden de compra", MsgBoxStyle.Information, "AVISO")
                '        Imprimir()
                '        Limpiar()
                '        Deshabilitar()
                '    End If
            End If
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir
        If Orden.Autorizada Then
            Imprimir()
        Else
            MessageBox.Show("La orden no se ha autorizado, debera autorizarse para imprimirla", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickNuevo
        Try
            Dim i As Integer = 0
            Dim ConfigConta As New CC.UsrConfigContabilidadCollection

            Cursor = Cursors.WaitCursor

            Limpiar()
            Habilitar()

            ''buscar solicitudes de productos
            ''Dim Solicitud As New ClasesNegocio.SolicitudProductoDetalleCollectionClass  
            'Dim Relacion As New OC.RelationCollection
            'Dim Solicitud As New ClasesNegocio.SolicitudProductoDetalleCollectionClass

            'Relacion.Add(EC.SolicitudProductoDetalleEntity.Relations.SolicitudProductoEntityUsingIdSolicitud)
            'Solicitud.Obtener(HC.SolicitudProductoDetalleFields.Estatus = ClasesNegocio.SolicitudProductoDetalleClass.EstatusSolicitudDetalle.VIGENTE, Nothing, Relacion)

            'Me.dgvSolicitudes.AutoGenerateColumns = False
            'Me.dgvSolicitudes.DataSource = Solicitud

            Orden = New ClasesNegocio.OrdenCompraClass
            Orden.IdUsuarioAlta = Controlador.Sesion.MiUsuario.Usrndx
            

            Dim TipoMonedaColeccion As New Integralab.ORM.CollectionClasses.TipoMonedaCollection
            TipoMonedaColeccion.GetMulti(Integralab.ORM.HelperClasses.TipoMonedaFields.MonedaLocal = True)

            If TipoMonedaColeccion.Count > 0 Then
                cmbMoneda.SelectedValue = TipoMonedaColeccion(0).Codigo
            End If

            Me.txtTipoCambio.Text = 1
            Me.txtSolicito.Text = Orden.UsuarioAlta.NombreCompleto

            'traer el iva de la configuracion 
            ConfigConta.GetMulti(Nothing, 0, Nothing)
            If ConfigConta.Count > 0 Then
                PorcentajeIVA = ConfigConta(0).Iva
            Else
                PorcentajeIVA = 0
            End If
            Me.sstab.SelectedTab = Me.tpSolicitudes
            'Me.txtFolioCotizacion.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Errror")
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub

    Private Sub DataGrid_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvDetalleOrdenCompra.CellBeginEdit
        UltimaCantidad = dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(Me.clmCantidadOrdenada.Index).Value
    End Sub

    Private Sub DataGrid_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleOrdenCompra.CellEndEdit
        Try
            'Dim detalle As ClasesNegocio.OrdenCompraDetalleClass = DirectCast(dgvDetalleOrdenCompra.Rows(e.RowIndex).DataBoundItem, ClasesNegocio.OrdenCompraDetalleClass)
            'If detalle.CantidadOrdenada = 0 Then
            '    detalle.Improte = 0
            '    dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(0).Value = False
            'Else
            '    If detalle.CantidadOrdenada * detalle.Precio - detalle.Descuento <= 0 Then
            '        MsgBox("Debe ingresar suficiente cantidad de artículos para que el descuento sea mayor al importe", MsgBoxStyle.Exclamation, "Aviso")
            '        detalle.CantidadOrdenada = UltimaCantidad
            '        Exit Sub
            '    End If

            '    detalle.Improte = detalle.CantidadOrdenada * detalle.Precio - detalle.Descuento
            '    dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(0).Value = True
            'End If
            Dim ProductoDetalleOrden As New ClasesNegocio.ProductoGeneralClass           
            Dim CantidadOrdenada As Decimal = 0D
            Dim CostoUnitario As Decimal = 0D
            Dim Descuento As Decimal = 0D

            Dim CantidadSolicitada As Decimal = 0D

            'asignar valores a a las variables
            CantidadSolicitada = Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(Me.clmCantidadSolicitada.Index).Value
            ProductoDetalleOrden = Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(Me.clmProductoOrdenCompra.Index).Value

            If IsNumeric(dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmCantidadOrdenada.Index).Value) Then
                CantidadOrdenada = Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(Me.clmCantidadOrdenada.Index).Value
            Else
                Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(Me.clmCantidadOrdenada.Index).Value = 0D
            End If

            If IsNumeric(dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmCostoUnitario.Index).Value) Then
                CostoUnitario = Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(Me.clmCostoUnitario.Index).Value
            Else
                Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(Me.clmCostoUnitario.Index).Value = 0D
            End If

            If IsNumeric(dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmDescuento.Index).Value) Then
                Descuento = Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(Me.clmDescuento.Index).Value
            Else
                Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(Me.clmDescuento.Index).Value = 0D
            End If
            'verificar si cantidad ordenada es mayor a la solicitada
            If e.ColumnIndex = Me.clmCantidadOrdenada.Index Then
                If CantidadOrdenada > CantidadSolicitada Then
                    MessageBox.Show("Cantidad Ordenada es Mayor a Cantidad Solicitada", Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(Me.clmCantidadOrdenada.Index).Value = 0
                End If
            End If
            If e.ColumnIndex = Me.clmDescuento.Index Then
                If Descuento > (CantidadOrdenada * CostoUnitario) Then
                    MessageBox.Show("El Descuento es Mayor al Importe", Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(Me.clmDescuento.Index).Value = 0
                    Descuento = 0
                End If
            End If
            'realizar calculos con las variables
            Select Case e.ColumnIndex
                Case Me.clmCantidadOrdenada.Index
                    CalcularImporteRenglonDetalle(e.RowIndex, ProductoDetalleOrden.SeAplicaIva, CantidadOrdenada, CostoUnitario, Descuento, PorcentajeIVA)
                    DistribuirCantidadesEImportes(ProductoDetalleOrden.Descripcion, CantidadOrdenada, CostoUnitario, Descuento, PorcentajeIVA)
                Case Me.clmCostoUnitario.Index
                    CalcularImporteRenglonDetalle(e.RowIndex, ProductoDetalleOrden.SeAplicaIva, CantidadOrdenada, CostoUnitario, Descuento, PorcentajeIVA)
                    DistribuirCantidadesEImportes(ProductoDetalleOrden.Descripcion, CantidadOrdenada, CostoUnitario, Descuento, PorcentajeIVA)
                Case Me.clmDescuento.Index
                    CalcularImporteRenglonDetalle(e.RowIndex, ProductoDetalleOrden.SeAplicaIva, CantidadOrdenada, CostoUnitario, Descuento, PorcentajeIVA)
                    DistribuirCantidadesEImportes(ProductoDetalleOrden.Descripcion, CantidadOrdenada, CostoUnitario, Descuento, PorcentajeIVA)
            End Select
            dgvDetalleOrdenCompra.Refresh()
            CalcularTotal()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    

    Private Sub DataGrid_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvDetalleOrdenCompra.DataError
        Try
            MsgBox("Debe ingresar una cantidad", MsgBoxStyle.Exclamation, "Aviso")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles MEAToolBar1.ButtonClick

    End Sub

    'Private Sub CotizacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CotizacionesToolStripMenuItem.Click
    '    Try
    '        Cursor = Cursors.WaitCursor

    '        Orden.IdUsuarioAlta = Controlador.Sesion.MiUsuario.Usrndx
    '        Me.txtSolicito.Text = Orden.UsuarioAlta.NombreCompleto

    '        Dim Ventana As New ComBusquedaCotizacion
    '        If Me.cmbPlaza.SelectedIndex > -1 Then
    '            Ventana.IdPlaza = Me.cmbPlaza.SelectedValue
    '        End If

    '        If Me.cmbSucursal.SelectedIndex > -1 Then
    '            Ventana.idSucursal = Me.cmbSucursal.SelectedValue
    '        End If

    '        Ventana.OrdenGenerda = False

    '        If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then

    '            Me.txtFolioCotizacion.Text = Ventana.DataGridView1.SelectedRows(0).Cells("ClmFolio").Value

    '            Cotizacion = New ClasesNegocio.CotizacionCompraClass
    '            'If Cotizacion.Obtener(txtFolioCotizacion.Text) Then
    '            '    If Cotizacion.Estatus = ClasesNegocio.EstatusEnum.INACTIVO Then
    '            '        MsgBox("La cotización esta cancelada", MsgBoxStyle.Exclamation, "Aviso")
    '            '        Exit Sub
    '            '    End If

    '            '    If Cotizacion.OrdenGenerada = ClasesNegocio.AsignadaEnum.SI Then
    '            '        MsgBox("La cotización ya se le ha generado una orden de compra", MsgBoxStyle.Exclamation, "Aviso")
    '            '        Exit Sub
    '            '    End If

    '            '    If Cotizacion.PresupuestoCompra.OrdenCompraGenerada = ClasesNegocio.AsignadaEnum.SI Then
    '            '        MsgBox("Ya se le generó una orden de compra a todos los productos del presupuesto de compra al que pertenece la cotización", MsgBoxStyle.Exclamation, "Aviso")
    '            '        Exit Sub
    '            '    End If

    '            '    Orden.IdCotizacionCompra = Cotizacion.Folio
    '            '    cmbPlaza.SelectedValue = Cotizacion.Sucursal.Plaza.Codigo
    '            '    cmbSucursal.SelectedValue = Cotizacion.Sucursal.Codigo
    '            '    cmbProveedor.SelectedValue = Cotizacion.Proveedor.Codigo
    '            '    cmbMoneda.SelectedValue = Cotizacion.Moneda.Codigo
    '            '    txtTipoCambio.Text = Cotizacion.TipoCambio.ToString("C2")
    '            '    txtDiasCredito.Text = Cotizacion.DiasCredito
    '            '    Me.cmbSucursal.Enabled = False
    '            '    Me.cmbProveedor.Enabled = False
    '            '    Me.cmbPlaza.Enabled = False
    '            '    Me.cmbMoneda.Enabled = False

    '            '    Me.Orden.Detalle.Clear()
    '            '    For Each det As ClasesNegocio.CotizacionCompraDetalleClass In Cotizacion.Detalle
    '            '        Dim detalle As New ClasesNegocio.OrdenCompraDetalleClass
    '            '        detalle.IdProducto = det.CodigoProducto
    '            '        detalle.CantidadSolicitada = det.Cantidad
    '            '        detalle.Descuento = det.Descuento
    '            '        detalle.Improte = 0
    '            '        detalle.CantidadOrdenada = 0
    '            '        detalle.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
    '            '        detalle.Precio = det.Precio
    '            '        detalle.IdOrdenCompra = Orden.Folio

    '            '        Orden.Detalle.Add(detalle)
    '            '    Next

    '            '    Dim col As New ClasesNegocio.PresupuestoCompraDetalleCollectionClass

    '            '    col.Obtener(Cotizacion.PresupuestoCompra.Folio, ClasesNegocio.CondicionEnum.ACTIVOS)

    '            '    For Each det As ClasesNegocio.PresupuestoCompraDetalleClass In col
    '            '        For Each ordet As ClasesNegocio.OrdenCompraDetalleClass In Orden.Detalle
    '            '            If det.CodigoProducto = ordet.CodigoProducto Then
    '            '                Orden.Detalle.Remove(ordet)
    '            '                Exit For
    '            '            End If
    '            '        Next
    '            '    Next

    '            '    If Orden.Detalle.Count = 0 Then
    '            '        MessageBox.Show("Seleccione otra cotización, ya se generó una orden de compra con los productos de esta cotización", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            '        Exit Sub
    '            '    End If
    '            '    Deshabilitar()
    '            '    DataGrid.Enabled = True
    '            '    'DataGrid.ReadOnly = False
    '            '    txtObservaciones.Enabled = True

    '            '    Me.cmbPlaza.Enabled = False
    '            '    Me.cmbSucursal.Enabled = False
    '            '    CalcularTotal()
    '            'Else
    '            '    MsgBox("No existe una cotización con ese folio", MsgBoxStyle.Exclamation, "Aviso")
    '            '    txtFolioCotizacion.Clear()
    '            '    Orden.Detalle.Clear()
    '            'End If
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        txtFolioCotizacion.Clear()
    '        Orden.Detalle.Clear()
    '        Me.Limpiar()
    '        Habilitar()
    '    Finally
    '        Cursor = Cursors.Default
    '    End Try
    'End Sub

    Private Sub cmbProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbProveedor.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNothing(Me.cmbProveedor.SelectedValue) Then
                MsgBox("Seleccione un Proveedor")
                Me.cmbProveedor.Focus()
            End If
        ElseIf e.KeyChar = Chr(Keys.F12) Then
            ProveedorC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.cmbProveedor.ValueMember = "IDProveedor"
            Me.cmbProveedor.DataSource = ProveedorC
            Me.cmbProveedor.DisplayMember = "RazonSocial"
            Me.cmbProveedor.SelectedIndex = -1
            Me.cmbProveedor.Text = "Seleccione un Proveedor..."
        Else
            Me.TmProveedor.Stop()
            Me.UltimaTeclaProveedor = Now
            Me.TmProveedor.Start()
        End If
    End Sub

    Private Sub cmbProveedor_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbProveedor.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                ProveedorC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.cmbProveedor.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbProveedor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedValueChanged
        Try
            Dim Proveedor As New ClasesNegocio.ProveedorClass
            Proveedor.Obtener(Me.cmbProveedor.SelectedValue)
            Me.txtDiasCredito.Text = Proveedor.DiasCredito
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbSucursal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbSucursal.KeyPress
        If e.KeyChar <> Chr(13) Then
            TmSucursal.Stop()
            UltimaTeclaSucursal = Now
            Me.TmSucursal.Start()
        End If
    End Sub

    Private Sub cmbSucursal_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbSucursal.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.cmbPlaza_SelectedIndexChanged(Me, e)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbSucursal_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSucursal.SelectedValueChanged
        Try
            If Me.cmbSucursal.SelectedValue Is Nothing Then
                Exit Sub
            Else
                Dim Relacion As New OC.RelationCollection
                Relacion.Add(EC.SolicitudProductoDetalleEntity.Relations.SolicitudProductoEntityUsingIdSolicitud)
                Me.dgvSolicitudes.DataSource = Nothing

                Dim Solicitud As New ClasesNegocio.SolicitudProductoDetalleCollectionClass
                Solicitud.Obtener(HC.SolicitudProductoFields.IdSucursal = Me.cmbSucursal.SelectedValue And HC.SolicitudProductoDetalleFields.Estatus = ClasesNegocio.SolicitudProductoDetalleClass.EstatusSolicitudDetalle.VIGENTE, Nothing, Relacion)

                If Not Solicitud.Count > 0 Then
                    Exit Sub
                End If
                Me.dgvSolicitudes.AutoGenerateColumns = False
                Me.dgvSolicitudes.DataSource = Solicitud
                'Me.dgvSolicitudes.Rows(Me.clmCantidadOrdenada.Index).ReadOnly = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbPlaza_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlaza.TextChanged
        If cmbPlaza.SelectedIndex > -1 Then
            SucursalC.Obtener(cmbPlaza.SelectedValue, ClasesNegocio.CondicionEnum.ACTIVOS)
            cmbSucursal.SelectedIndex = -1
            cmbSucursal.Text = "Seleccione una sucursal..."
        Else
            Me.SucursalC.Clear()
            cmbSucursal.SelectedIndex = -1
        End If
    End Sub

    Private Sub TmSucursal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmSucursal.Tick
        If Me.UltimaTeclaSucursal.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
            Me.TmSucursal.Stop()
            Me.SucursalC.Obtener(Me.cmbSucursal.Text, ClasesNegocio.CondicionEnum.ACTIVOS, Me.cmbPlaza.SelectedValue)
            Me.cmbSucursal.DataSource = SucursalC
        End If
    End Sub

    Private Sub Tmplaza_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tmplaza.Tick
        If Me.UltimaTeclaPlaza.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
            Me.Tmplaza.Stop()
            Me.PlazaC.Obtener(Me.cmbPlaza.Text, ClasesNegocio.CondicionEnum.ACTIVOS)
        End If
    End Sub

    Private Sub TmProveedor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmProveedor.Tick
        Try
            If Me.UltimaTeclaProveedor.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
                Me.TmProveedor.Stop()
                ProveedorC.Obtener(False, Me.cmbProveedor.Text.Trim, ClasesNegocio.CondicionEnum.ACTIVOS)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgvSolicitudes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSolicitudes.CellContentClick
        If e.ColumnIndex = Me.clmSelSolicitud.Index Then
            Dim Celda As DataGridViewCheckBoxCell = CType(dgvSolicitudes.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            'Dim i As Integer
            Dim R As Integer
            R = Me.dgvDetalleOrdenCompra.Rows.Count - 1
            If Celda.EditedFormattedValue Then
                Me.dgvDetalleOrdenCompra.Refresh()
                Me.dgvDetalleOrdenCompra.Rows.Add()
                If R <> 0 Then
                    If Not BuscarProducto(Me.dgvSolicitudes.Rows(e.RowIndex).Cells(Me.clmProducto.Index).Value.ToString, Me.dgvSolicitudes.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value.ToString) Then
                        Me.dgvDetalleOrdenCompra.Rows(R).Cells(Me.clmProductoOrdenCompra.Index).Value = Me.dgvSolicitudes.Rows(e.RowIndex).Cells(Me.clmProducto.Index).Value
                        Me.dgvDetalleOrdenCompra.Rows(R).Cells(Me.clmUnidadMedidaOrdenCompra.Index).Value = Me.dgvSolicitudes.Rows(e.RowIndex).Cells(Me.clmUnidadMedida.Index).Value
                        Me.dgvDetalleOrdenCompra.Rows(R).Cells(Me.clmCantidadSolicitada.Index).Value = Me.dgvSolicitudes.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value
                        Me.txtEntregarA.Text = Me.dgvSolicitudes.Rows(e.RowIndex).Cells(Me.clmEntregar.Index).Value
                        AgregarDetalleaEspejo(e.RowIndex)
                    Else
                        AgregarDetalleaEspejo(e.RowIndex)
                        Me.dgvDetalleOrdenCompra.Rows.RemoveAt(R)
                        Me.dgvDetalleOrdenCompra.Refresh()
                    End If
                Else
                    Me.dgvDetalleOrdenCompra.Rows(R).Cells(Me.clmProductoOrdenCompra.Index).Value = Me.dgvSolicitudes.Rows(e.RowIndex).Cells(Me.clmProducto.Index).Value
                    Me.dgvDetalleOrdenCompra.Rows(R).Cells(Me.clmUnidadMedidaOrdenCompra.Index).Value = Me.dgvSolicitudes.Rows(e.RowIndex).Cells(Me.clmUnidadMedida.Index).Value
                    Me.dgvDetalleOrdenCompra.Rows(R).Cells(Me.clmCantidadSolicitada.Index).Value = Me.dgvSolicitudes.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value
                    Me.txtEntregarA.Text = Me.dgvSolicitudes.Rows(e.RowIndex).Cells(Me.clmEntregar.Index).Value
                    AgregarDetalleaEspejo(e.RowIndex)
                End If
            Else
                QuitarDetalle(Me.dgvSolicitudes.Rows(e.RowIndex).Cells(Me.clmProducto.Index).Value.ToString, Me.dgvSolicitudes.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value.ToString, Me.dgvSolicitudes.Rows(e.RowIndex).Cells(Me.clmSolicitud.Index).Value.ToString)
                Me.txtEntregarA.Text = ""
            End If
        End If
        CalcularTotal()
    End Sub

    Function BuscarProducto(ByVal Producto As String, ByVal Cantidad As Decimal) As Boolean
        Try
            Dim ProductoOrden As ClasesNegocio.ProductoGeneralClass
            Dim Bandera As Boolean
            Bandera = False
            For i As Integer = 0 To Me.dgvDetalleOrdenCompra.Rows.Count - 1
                ProductoOrden = New ClasesNegocio.ProductoGeneralClass
                ProductoOrden = Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmProductoOrdenCompra.Index).Value
                If ProductoOrden Is Nothing Then Exit For
                If ProductoOrden.Descripcion = Producto Then
                    Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmCantidadSolicitada.Index).Value = Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmCantidadSolicitada.Index).Value + Cantidad
                    Bandera = True
                    Exit For
                End If
            Next
            If Bandera Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Function QuitarDetalle(ByVal Producto As String, ByVal Cantidad As Decimal, ByVal Solicitud As String) As Boolean
        Try
            Dim ProductoOrden As ClasesNegocio.ProductoGeneralClass
            Dim CantidadOrden As Decimal
            For i As Integer = 0 To Me.dgvDetalleOrdenCompra.Rows.Count - 1
                ProductoOrden = New ClasesNegocio.ProductoGeneralClass
                ProductoOrden = Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmProductoOrdenCompra.Index).Value
                CantidadOrden = Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmCantidadSolicitada.Index).Value
                If ProductoOrden Is Nothing Then Exit For
                If ProductoOrden.Descripcion = Producto Then
                    If Cantidad = CantidadOrden Then
                        Me.dgvDetalleOrdenCompra.Rows.RemoveAt(i)
                        Me.dgvDetalleOrdenCompra.Refresh()
                        QuitarDetalleaEspejo(Solicitud)
                    Else
                        Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmCantidadSolicitada.Index).Value = Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmCantidadSolicitada.Index).Value - Cantidad
                        QuitarDetalleaEspejo(Solicitud)
                    End If
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Sub AgregarDetalleaEspejo(ByVal Renglon As Integer)
        Try           
            For i As Integer = 0 To Me.dgvEspejoOrden.Rows.Count - 1
                If Me.dgvEspejoOrden.Rows(i).Cells(Me.clmFolioSolicitudEspejo.Index).Value = "" Then
                    Me.dgvEspejoOrden.Rows.Add()
                    Me.dgvEspejoOrden.Refresh()
                    If Me.dgvSolicitudes.RowCount > 0 Then
                        Me.dgvEspejoOrden.Rows(i).Cells(Me.clmProductoEspejo.Index).Value = Me.dgvSolicitudes.Rows(Renglon).Cells(Me.clmProducto.Index).Value
                        Me.dgvEspejoOrden.Rows(i).Cells(Me.clmUnidadEspejo.Index).Value = Me.dgvSolicitudes.Rows(Renglon).Cells(Me.clmUnidadMedida.Index).Value
                        Me.dgvEspejoOrden.Rows(i).Cells(Me.clmCantSolEspejo.Index).Value = Me.dgvSolicitudes.Rows(Renglon).Cells(Me.clmCantidad.Index).Value
                        Me.dgvEspejoOrden.Rows(i).Cells(Me.clmFolioSolicitudEspejo.Index).Value = Me.dgvSolicitudes.Rows(Renglon).Cells(Me.clmSolicitud.Index).Value
                        Me.dgvEspejoOrden.Rows(i).Cells(Me.clmIdSolicitudEspejo.Index).Value = Me.dgvSolicitudes.Rows(Renglon).Cells(Me.clmIdSolicitud.Index).Value
                        Me.dgvEspejoOrden.Rows(i).Cells(Me.clmPorcentajeIVAEspejo.Index).Value = Me.dgvSolicitudes.Rows(Renglon).Cells(Me.clmPorcentajeIVA.Index).Value
                    End If
                End If
            Next
            Me.dgvEspejoOrden.Sort(Me.dgvEspejoOrden.Columns(Me.clmFolioSolicitudEspejo.Index), System.ComponentModel.ListSortDirection.Ascending)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub QuitarDetalleaEspejo(ByVal Solicitud As String)
        Try
            For i As Integer = 0 To Me.dgvEspejoOrden.Rows.Count
                If Me.dgvEspejoOrden.Rows(i).Cells(Me.clmFolioSolicitudEspejo.Index).Value = Solicitud Then
                    Me.dgvEspejoOrden.Rows.RemoveAt(i)
                    Me.dgvEspejoOrden.Refresh()
                    Exit For
                End If
            Next
            Me.dgvEspejoOrden.Sort(Me.dgvEspejoOrden.Columns(Me.clmFolioSolicitudEspejo.Index), System.ComponentModel.ListSortDirection.Ascending)

        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function DistribuirCantidadesEImportes(ByVal Producto As String, ByVal Cantidad As Decimal, ByVal CostoUnitario As Decimal, ByVal Descuento As Decimal, ByVal PorcentajeIVA As Decimal) As Boolean
        Try
            Dim ProductoOrden As ClasesNegocio.ProductoGeneralClass
            Dim CantidadSolicitada As Decimal
            Dim ImporteIVA As Decimal
            For i As Integer = 0 To Me.dgvEspejoOrden.Rows.Count - 1
                ProductoOrden = New ClasesNegocio.ProductoGeneralClass
                ProductoOrden = Me.dgvEspejoOrden.Rows(i).Cells(Me.clmProductoEspejo.Index).Value
                If ProductoOrden Is Nothing Then Exit For
                If ProductoOrden.Descripcion = Producto Then
                    Me.dgvEspejoOrden.Rows(i).Cells(Me.clmCantOrdEspejo.Index).Value = 0
                    Me.dgvEspejoOrden.Rows(i).Cells(Me.clmCostoUnitarioEspejo.Index).Value = 0
                    Me.dgvEspejoOrden.Rows(i).Cells(Me.clmImporteEspejo.Index).Value = 0
                End If
            Next
            For i As Integer = 0 To Me.dgvEspejoOrden.Rows.Count - 1
                ProductoOrden = New ClasesNegocio.ProductoGeneralClass
                ProductoOrden = Me.dgvEspejoOrden.Rows(i).Cells(Me.clmProductoEspejo.Index).Value
                CantidadSolicitada = Me.dgvEspejoOrden.Rows(i).Cells(Me.clmCantSolEspejo.Index).Value
                If ProductoOrden Is Nothing Then Exit For
                If ProductoOrden.Descripcion = Producto Then
                    If Cantidad = CantidadSolicitada Then
                        Me.dgvEspejoOrden.Rows(i).Cells(Me.clmCantOrdEspejo.Index).Value = Cantidad
                        Me.dgvEspejoOrden.Rows(i).Cells(Me.clmCostoUnitarioEspejo.Index).Value = CostoUnitario
                        Me.dgvEspejoOrden.Rows(i).Cells(Me.clmDescuentoEspejo.Index).Value = Descuento

                        If ProductoOrden.SeAplicaIva Then
                            Me.dgvEspejoOrden.Rows(i).Cells(Me.clmIVAEspejo.Index).Value = (((Cantidad * CostoUnitario) - Descuento) * (PorcentajeIVA / 100))
                        Else
                            Me.dgvEspejoOrden.Rows(i).Cells(Me.clmIVAEspejo.Index).Value = 0D
                        End If
                        ImporteIVA = Me.dgvEspejoOrden.Rows(i).Cells(Me.clmIVAEspejo.Index).Value
                        Me.dgvEspejoOrden.Rows(i).Cells(Me.clmImporteEspejo.Index).Value = ((Cantidad * CostoUnitario) - Descuento) + ImporteIVA
                        Me.dgvEspejoOrden.Rows(i).Cells(Me.clmPorcentajeIVAEspejo.Index).Value = PorcentajeIVA
                        Exit For
                    ElseIf Cantidad < CantidadSolicitada Then
                        Me.dgvEspejoOrden.Rows(i).Cells(Me.clmCantOrdEspejo.Index).Value = Cantidad
                        Me.dgvEspejoOrden.Rows(i).Cells(Me.clmCostoUnitarioEspejo.Index).Value = CostoUnitario

                        If Cantidad = 0D Then
                            Me.dgvEspejoOrden.Rows(i).Cells(Me.clmDescuentoEspejo.Index).Value = 0D
                        Else
                            Me.dgvEspejoOrden.Rows(i).Cells(Me.clmDescuentoEspejo.Index).Value = Descuento / Cantidad
                        End If

                        If ProductoOrden.SeAplicaIva Then
                            Me.dgvEspejoOrden.Rows(i).Cells(Me.clmIVAEspejo.Index).Value = (((Cantidad * CostoUnitario) - Descuento) * (PorcentajeIVA / 100))
                        Else
                            Me.dgvEspejoOrden.Rows(i).Cells(Me.clmIVAEspejo.Index).Value = 0D
                        End If
                        ImporteIVA = Me.dgvEspejoOrden.Rows(i).Cells(Me.clmIVAEspejo.Index).Value
                        Me.dgvEspejoOrden.Rows(i).Cells(Me.clmImporteEspejo.Index).Value = ((Cantidad * CostoUnitario) - Descuento) + ImporteIVA
                        Cantidad = CantidadSolicitada - Cantidad
                        Me.dgvEspejoOrden.Rows(i).Cells(Me.clmPorcentajeIVAEspejo.Index).Value = PorcentajeIVA
                        Exit For
                    ElseIf Cantidad > CantidadSolicitada Then
                        Me.dgvEspejoOrden.Rows(i).Cells(Me.clmCantOrdEspejo.Index).Value = CantidadSolicitada
                        Me.dgvEspejoOrden.Rows(i).Cells(Me.clmCostoUnitarioEspejo.Index).Value = CostoUnitario

                        If CantidadSolicitada = 0D Then
                            Me.dgvEspejoOrden.Rows(i).Cells(Me.clmDescuentoEspejo.Index).Value = 0D
                        Else
                            Me.dgvEspejoOrden.Rows(i).Cells(Me.clmDescuentoEspejo.Index).Value = Descuento / CantidadSolicitada
                        End If

                        If ProductoOrden.SeAplicaIva Then
                            Me.dgvEspejoOrden.Rows(i).Cells(Me.clmIVAEspejo.Index).Value = (((CantidadSolicitada * CostoUnitario) - Descuento) * (PorcentajeIVA / 100))
                        Else
                            Me.dgvEspejoOrden.Rows(i).Cells(Me.clmIVAEspejo.Index).Value = 0D
                        End If
                        ImporteIVA = Me.dgvEspejoOrden.Rows(i).Cells(Me.clmIVAEspejo.Index).Value
                        Me.dgvEspejoOrden.Rows(i).Cells(Me.clmImporteEspejo.Index).Value = ((CantidadSolicitada * CostoUnitario) - Descuento) + ImporteIVA
                        Cantidad = Cantidad - CantidadSolicitada
                        Me.dgvEspejoOrden.Rows(i).Cells(Me.clmPorcentajeIVAEspejo.Index).Value = PorcentajeIVA
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub dgvDetalleOrdenCompra_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvDetalleOrdenCompra.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales

        If clmCantidadOrdenada.Index = dgvDetalleOrdenCompra.CurrentCell.ColumnIndex _
        OrElse clmCostoUnitario.Index = dgvDetalleOrdenCompra.CurrentCell.ColumnIndex _
        OrElse clmDescuento.Index = dgvDetalleOrdenCompra.CurrentCell.ColumnIndex Then
            AddHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
        End If

    End Sub

    Private Sub dgvDetalleOrdenCompra_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvDetalleOrdenCompra.LostFocus
        If Me.dgvDetalleOrdenCompra.Rows.Count < 0 Then
            Me.txtSubTotal.Text = ""
            Me.txtDescuento.Text = ""
            Me.txtIVAPesos.Text = ""
            Me.txtTotal.Text = ""
        End If
    End Sub

    Private Sub cmbSucursal_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSucursal.SelectedIndexChanged

    End Sub
End Class