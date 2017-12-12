Public Class ComAutOrdenCpra

    Dim Orden As ClasesNegocio.OrdenCompraClass
    Dim OrdenServ As ClasesNegocio.OrdenServicioClass
    Dim UltimaTeclaPlaza As DateTime
    Dim UltimaTeclaSucursal As DateTime

    Dim CompraImporte As Decimal
    Dim CompraDescuento As Decimal
    Dim CompraSubTotal As Decimal
    Dim CompraIva As Decimal
    Dim CompraTotal As Decimal

    Dim ServicioSubTotal As Decimal
    Dim ServicioDescuento As Decimal
    Dim ServicioIva As Decimal
    Dim ServicioTotal As Decimal

    Dim TotalCantOrdenadaOrden As Decimal
    Dim TotalCantSolicitadaOrden As Decimal
    Dim TotalCantOrdenadaServicio As Decimal
    Dim TotalCantSolicitadaServicio As Decimal

    Dim Bandera As Boolean = True
    Dim Procesando As Boolean = False

#Region "Load"

    Private Sub ComAutOrdenCpra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Barra de botones de la ToolBar...
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            MtbEstados.StateBuscar = ""
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = ""
            MtbEstados.StateNuevo = ""
            MtbEstados.StateGuardar = ""
            MtbEstados.StateBorrar = ""
            MtbEstados.StateEditar = ""
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            MEAToolBar1.ToolBarButtonStatus = MtbEstados
            MEAToolBar1.sbCambiarEstadoBotones("Cancelar")

            PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            Dim colplz As New ClasesNegocio.PlazaCollectionClass
            Dim p As New ClasesNegocio.PlazaClass

            p.Descripcion = "TODAS"
            colplz.Add(p)

            For Each plaza As ClasesNegocio.PlazaClass In PlazaC
                colplz.Add(plaza)
            Next

            cmbPlaza.DataSource = colplz

            Bandera = True
            Procesando = False

            dgvDetalleOrdenCompra.AutoGenerateColumns = False
            DgDetOrdSer.AutoGenerateColumns = False
            Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub Limpiar()
        Try
            cmbPlaza.SelectedIndex = 0
            cmbSucursal.SelectedIndex = -1
            txtCantidadSolicitada.Clear()
            txtCantidadEmitida.Clear()
            txtImporte.Clear()
            txtSubTotal.Clear()
            txtDescuento.Clear()
            txtIVA.Clear()
            txtTotal.Clear()
            TxtCanSolS.Clear()
            TxtCanES.Clear()
            TxtSTot.Clear()
            TxtDto.Clear()
            TxtIvaS.Clear()
            TxtTotalS.Clear()

            Me.dgvOrdenCompra.DataSource = Nothing
            Me.dgvDetalleOrdenCompra.DataSource = Nothing
            Me.DgListOrdServ.DataSource = Nothing
            Me.DgDetOrdSer.DataSource = Nothing

            Me.OrdenCompraC.Clear()
            Me.OrdenServicioC.Clear()
            Me.OrdenServicioDetC.Clear()

            CompraImporte = 0
            CompraDescuento = 0
            CompraSubTotal = 0
            CompraIva = 0
            CompraTotal = 0

            Me.txtTotalCantdadOrdenada1.Text = ""
            Me.txtTotalCantdadSolicitada1.Text = ""
            Me.txtTotalCanEmitida2.Text = ""
            Me.txtTotalCanSolicitada2.Text = ""

            Me.TxtCanSolS.Text = ""
            Me.TxtCanES.Text = ""
            Me.txtCantidadSolicitada.Text = ""
            Me.txtCantidadEmitida.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Habilitar()
        cmbPlaza.Enabled = True
        cmbSucursal.Enabled = True
        txtCantidadSolicitada.Enabled = True
        txtCantidadEmitida.Enabled = True
        txtSubTotal.Enabled = True
        txtIVA.Enabled = True
        txtTotal.Enabled = True
        TxtCanSolS.Enabled = True
        TxtCanES.Enabled = True
        TxtSTot.Enabled = True
        TxtDto.Enabled = True
        TxtIvaS.Enabled = True
        TxtTotalS.Enabled = True
        Me.dgvOrdenCompra.Enabled = True
        dgvDetalleOrdenCompra.Enabled = True
        DgListOrdServ.Enabled = True
        DgDetOrdSer.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        cmbPlaza.Enabled = False
        cmbSucursal.Enabled = False
        txtCantidadSolicitada.Enabled = False
        txtCantidadEmitida.Enabled = False
        txtSubTotal.Enabled = False
        txtIVA.Enabled = False
        txtTotal.Enabled = False
        TxtCanSolS.Enabled = False
        TxtCanES.Enabled = False
        TxtSTot.Enabled = False
        TxtDto.Enabled = False
        TxtIvaS.Enabled = False
        TxtTotalS.Enabled = False
        Me.dgvOrdenCompra.Enabled = False
        dgvDetalleOrdenCompra.Enabled = False
        DgListOrdServ.Enabled = False
        DgDetOrdSer.Enabled = False
    End Sub

    Private Sub SumarTotalCantidadesCompra()
        For Each det As ClasesNegocio.OrdenCompraDetalleClass In Orden.Detalle
            Me.TotalCantOrdenadaOrden += det.CantidadOrdenada
            Me.TotalCantSolicitadaOrden += det.CantidadSolicitada
        Next

        Me.txtTotalCantdadSolicitada1.Text = Me.TotalCantSolicitadaOrden.ToString("N2")
        Me.txtTotalCantdadOrdenada1.Text = Me.TotalCantOrdenadaOrden.ToString("N2")
    End Sub

    Private Sub RestarTotalCantidadesCompra()
        For Each det As ClasesNegocio.OrdenCompraDetalleClass In Orden.Detalle
            Me.TotalCantOrdenadaOrden -= det.CantidadOrdenada
            Me.TotalCantSolicitadaOrden -= det.CantidadSolicitada
        Next

        Me.txtTotalCantdadSolicitada1.Text = Me.TotalCantSolicitadaOrden.ToString("N2")
        Me.txtTotalCantdadOrdenada1.Text = Me.TotalCantOrdenadaOrden.ToString("N2")
    End Sub

    Private Sub SumarTotalCantidadesServicio()
        For Each Det As ClasesNegocio.OrdenServicioDetClass In OrdenServ.Detalle
            Me.TotalCantSolicitadaServicio += Det.CantidadSolic
            Me.TotalCantOrdenadaServicio += Det.CantidadOrdenar
        Next

        Me.txtTotalCanSolicitada2.Text = Me.TotalCantSolicitadaServicio.ToString("N2")
        Me.txtTotalCanEmitida2.Text = Me.TotalCantOrdenadaServicio.ToString("N2")
    End Sub

    Private Sub RestarTotalCantidadesServicio()
        For Each Det As ClasesNegocio.OrdenServicioDetClass In OrdenServ.Detalle
            Me.TotalCantSolicitadaServicio -= Det.CantidadSolic
            Me.TotalCantOrdenadaServicio -= Det.CantidadOrdenar
        Next

        Me.txtTotalCanSolicitada2.Text = Me.TotalCantSolicitadaServicio.ToString("N2")
        Me.txtTotalCanEmitida2.Text = Me.TotalCantOrdenadaServicio.ToString("N2")
    End Sub

    Private Sub SumarCantidades()
        If Not Orden Is Nothing Then
            Dim cants, cante As Decimal

            For Each det As ClasesNegocio.OrdenCompraDetalleClass In Orden.Detalle
                cants += det.CantidadSolicitada
                cante += det.CantidadOrdenada
            Next

            txtCantidadSolicitada.Text = cants.ToString("N2")
            txtCantidadEmitida.Text = cante.ToString("N2")
        Else
            txtCantidadSolicitada.Text = 0.ToString("N2")
            txtCantidadEmitida.Text = 0.ToString("N2")
        End If
    End Sub

    Private Sub SumarCant()
        If Not OrdenServ Is Nothing Then
            Dim Cants, CantE As Decimal

            For Each Det As ClasesNegocio.OrdenServicioDetClass In OrdenServ.Detalle
                Cants += Det.CantidadSolic
                CantE += Det.CantidadOrdenar
            Next
            Me.TxtCanSolS.Text = Cants.ToString("N2")
            Me.TxtCanES.Text = CantE.ToString("N2")
        Else
            Me.TxtCanSolS.Text = 0.ToString("N2")
            Me.TxtCanES.Text = 0.ToString("N2")
        End If
    End Sub

    Private Sub CalcularImporteRenglonDetalle()
        Try
            Dim ImporteIVA As Decimal
            Dim Importe As Decimal
            Dim CantidadOrdenada As Decimal
            Dim CostoUnitario As Decimal
            Dim Descuento As Decimal
            Dim PorcentajeIVA As Decimal
            Dim ProductoOrden As ClasesNegocio.ProductoGeneralClass

            PorcentajeIVA = Me.dgvOrdenCompra.CurrentRow.Cells(Me.clmIVAPor.Index).Value
            For i As Integer = 0 To Me.dgvDetalleOrdenCompra.Rows.Count - 1
                ProductoOrden = New ClasesNegocio.ProductoGeneralClass
                ProductoOrden = Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmProducto.Index).Value
                If ProductoOrden.SeAplicaIva Then
                    CantidadOrdenada = Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmCantidadOrdenada.Index).Value
                    CostoUnitario = Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmPrecio.Index).Value
                    Descuento = Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmDescuento.Index).Value
                    ImporteIVA = (((CantidadOrdenada * CostoUnitario) - Descuento) * (PorcentajeIVA / 100))
                    Importe = ((CantidadOrdenada * CostoUnitario) - Descuento) + ImporteIVA
                    Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmIVA.Index).Value = ImporteIVA
                    Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmImporte.Index).Value = Importe
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "MToolBar"

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Try
            Dim Plaza As ClasesNegocio.PlazaClass = Nothing
            Dim Sucursal As ClasesNegocio.SucursalClass = Nothing

            If cmbPlaza.SelectedIndex > 0 Then
                Plaza = DirectCast(cmbPlaza.SelectedItem, ClasesNegocio.PlazaClass)
            End If

            If cmbSucursal.SelectedIndex > 0 Then
                Sucursal = DirectCast(cmbSucursal.SelectedItem, ClasesNegocio.SucursalClass)
            End If

            Me.dgvOrdenCompra.ClearSelection()
            Me.OrdenCompraC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, Plaza, Sucursal, Nothing, ClasesNegocio.CondicionAsignadaEnum.NO, ClasesNegocio.CondicionOrdenRecibida.NO)
            Me.DgListOrdServ.ClearSelection()
            Me.OrdenServicioC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, Plaza, Sucursal, Nothing, ClasesNegocio.CondicionAsignadaEnum.NO, ClasesNegocio.CondicionOrdenRecibida.TODOS)

            Me.DgListOrdServ.AutoGenerateColumns = False
            Me.DgListOrdServ.DataSource = Me.OrdenServicioC
            Me.DgListOrdServ.ClearSelection()

            Me.dgvOrdenCompra.AutoGenerateColumns = False
            Me.dgvOrdenCompra.DataSource = Me.OrdenCompraC
            Me.dgvOrdenCompra.ClearSelection()

            Me.dgvDetalleOrdenCompra.DataSource = Nothing
            Me.DgDetOrdSer.DataSource = Nothing

            Me.TxtCanSolS.Text = ""
            Me.TxtCanES.Text = ""
            Me.txtCantidadSolicitada.Text = ""
            Me.txtCantidadEmitida.Text = ""

            'If Me.dgvOrdenCompra.SelectedRows.Count > 0 Then
            '    Orden = DirectCast(Me.dgvOrdenCompra.SelectedRows(0).DataBoundItem, ClasesNegocio.OrdenCompraClass)

            '    Me.dgvDetalleOrdenCompra.DataSource = Orden.Detalle

            '    CalcularImporteRenglonDetalle()

            '    Me.txtImporte.Text = Orden.Importe.ToString("C2")
            '    Me.txtDescuento.Text = Orden.Descuento.ToString("C2")
            '    Me.txtSubTotal.Text = Orden.SubTotal.ToString("C2")
            '    txtIVA.Text = Orden.IVATotal.ToString("C2")
            '    txtTotal.Text = Orden.Total.ToString("C2")

            '    SumarCantidades()
            'Else
            '    Orden = Nothing
            '    dgvDetalleOrdenCompra.DataSource = Nothing

            '    Me.txtImporte.Clear()
            '    Me.txtDescuento.Clear()
            '    Me.txtSubTotal.Clear()
            '    txtIVA.Clear()
            '    txtTotal.Clear()

            '    SumarCantidades()
            'End If

            'If Me.DgListOrdServ.SelectedRows.Count > 0 Then

            '    OrdenServ = DirectCast(Me.DgListOrdServ.SelectedRows(0).DataBoundItem, ClasesNegocio.OrdenServicioClass)
            '    Me.DgDetOrdSer.AutoGenerateColumns = False
            '    Me.DgDetOrdSer.DataSource = OrdenServ.Detalle

            '    Me.TxtDto.Text = OrdenServ.Descuento.ToString("C2")
            '    Me.TxtSTot.Text = OrdenServ.SubTotal.ToString("C2")
            '    Me.TxtIvaS.Text = OrdenServ.IVA.ToString("C2")
            '    Me.TxtTotalS.Text = OrdenServ.Total.ToString("C2")

            '    SumarCant()

            'Else
            '    OrdenServ = Nothing
            '    DgDetOrdSer.DataSource = Nothing

            '    Me.TxtDto.Clear()
            '    Me.TxtSTot.Clear()
            '    Me.TxtIvaS.Clear()
            '    Me.TxtTotalS.Clear()

            '    SumarCant()
            'End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickGuardar
        Try
            If Me.TbCOrdServ.SelectedIndex = 0 Then
                Cursor = Cursors.WaitCursor

                Dim ordn As New ClasesNegocio.OrdenCompraClass

                Me.dgvOrdenCompra.Rows(Me.dgvOrdenCompra.Rows.Count - 1).Cells(2).Selected = True

                For Each ord As ClasesNegocio.OrdenCompraClass In OrdenCompraC
                    If ord.Autorizada Then
                        ord.FechaAutorizacion = Now
                    End If
                Next

                If OrdenCompraC.ObtenerColeccion.SaveMulti() > 0 Then
                    MsgBox("Se ha guardado", MsgBoxStyle.Information, "Aviso")
                End If

                Limpiar()
            Else
                Cursor = Cursors.WaitCursor

                'Dim ordn As New ClasesNegocio.OrdenServicioClass

                Me.DgListOrdServ.Rows(Me.DgListOrdServ.Rows.Count - 1).Cells(2).Selected = True

                For Each ord As ClasesNegocio.OrdenServicioClass In Me.OrdenServicioC
                    If ord.Autorizada Then
                        ord.FechaAutorizacion = Now
                    End If
                Next

                If OrdenServicioC.ObtenerColeccion.SaveMulti() > 0 Then
                    MsgBox("Se ha guardado", MsgBoxStyle.Information, "Aviso")
                End If

                Limpiar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
    End Sub

#End Region

#Region "DataGridView OrdenCompra"

    Private Sub dgvOrdenCompra_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOrdenCompra.CellDoubleClick
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgvOrdenCompra_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dgvOrdenCompra.SelectionChanged
        Try
            If Me.dgvOrdenCompra.CurrentRow.DataBoundItem IsNot Nothing Then
                Orden = DirectCast(Me.dgvOrdenCompra.CurrentRow.DataBoundItem, ClasesNegocio.OrdenCompraClass)
                Me.dgvDetalleOrdenCompra.DataSource = Orden.Detalle
                SumarCantidades()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgvOrdenCompra_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvOrdenCompra.DoubleClick
        Try
            For i As Integer = 0 To Me.dgvOrdenCompra.Rows.Count - 1
                Dim Control As DataGridViewCheckBoxCell = CType(Me.dgvOrdenCompra.Rows(i).Cells("Autorizada"), DataGridViewCheckBoxCell)
                If Control.EditingCellValueChanged = True Then
                    If Control.EditingCellFormattedValue = True Then
                        Control.EditingCellFormattedValue = False
                        Control.Value = False
                    Else
                        Control.EditingCellFormattedValue = True
                        Control.Value = True
                    End If

                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgvOrdenCompra_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOrdenCompra.CellContentClick
        Try
            Select Case e.ColumnIndex
                Case Me.Autorizada.Index
                    If Procesando = False Then
                        Procesando = True
                        If Me.txtTotal.Text = "" Then
                            Orden = DirectCast(Me.dgvOrdenCompra.Rows(e.RowIndex).DataBoundItem, ClasesNegocio.OrdenCompraClass)
                            Me.dgvDetalleOrdenCompra.DataSource = Orden.Detalle

                            CompraImporte = Orden.Importe
                            CompraDescuento = Orden.Descuento
                            CompraSubTotal = Orden.SubTotal
                            CompraIva = Orden.IVATotal
                            CompraTotal = Orden.Total

                            Me.txtImporte.Text = CompraImporte.ToString("C2")
                            Me.txtDescuento.Text = CompraDescuento.ToString("C2")
                            Me.txtSubTotal.Text = CompraSubTotal.ToString("C2")
                            Me.txtIVA.Text = CompraIva.ToString("C2")
                            Me.txtTotal.Text = CompraTotal.ToString("C2")

                            SumarTotalCantidadesCompra()

                            Bandera = False

                        Else
                            Orden = DirectCast(Me.dgvOrdenCompra.Rows(e.RowIndex).DataBoundItem, ClasesNegocio.OrdenCompraClass)
                            For i As Integer = 0 To Me.dgvOrdenCompra.Rows.Count - 1
                                Dim Control As DataGridViewCheckBoxCell = CType(Me.dgvOrdenCompra.Rows(i).Cells("Autorizada"), DataGridViewCheckBoxCell)
                                If Control.EditingCellValueChanged = True Then
                                    If Control.EditingCellFormattedValue = True Then

                                        CompraImporte += Orden.Importe
                                        CompraDescuento += Orden.Descuento
                                        CompraSubTotal += Orden.SubTotal
                                        CompraIva += Orden.IVATotal
                                        CompraTotal += Orden.Total

                                        Me.txtImporte.Text = CompraImporte.ToString("C2")
                                        Me.txtDescuento.Text = CompraDescuento.ToString("C2")
                                        Me.txtSubTotal.Text = CompraSubTotal.ToString("C2")
                                        Me.txtIVA.Text = CompraIva.ToString("C2")
                                        Me.txtTotal.Text = CompraTotal.ToString("C2")

                                        SumarTotalCantidadesCompra()

                                        Bandera = False

                                    Else

                                        CompraImporte -= Orden.Importe
                                        CompraDescuento -= Orden.Descuento
                                        CompraSubTotal -= Orden.SubTotal
                                        CompraIva -= Orden.IVATotal
                                        CompraTotal -= Orden.Total

                                        Me.txtImporte.Text = CompraImporte.ToString("C2")
                                        Me.txtDescuento.Text = CompraDescuento.ToString("C2")
                                        Me.txtSubTotal.Text = CompraSubTotal.ToString("C2")
                                        Me.txtIVA.Text = CompraIva.ToString("C2")
                                        Me.txtTotal.Text = CompraTotal.ToString("C2")

                                        RestarTotalCantidadesCompra()

                                        Bandera = False

                                    End If
                                End If

                                If Not Control.EditingCellFormattedValue = False Then
                                    Bandera = False
                                End If
                            Next

                            If Bandera = True Then
                                Me.dgvDetalleOrdenCompra.DataSource = Nothing
                                Me.txtCantidadSolicitada.Text = ""
                                Me.txtCantidadEmitida.Text = ""
                                Me.txtImporte.Text = ""
                                Me.txtDescuento.Text = ""
                                Me.txtSubTotal.Text = ""
                                Me.txtIVA.Text = ""
                                Me.txtTotalCantdadOrdenada1.Text = ""
                                Me.txtTotalCantdadSolicitada1.Text = ""
                                CompraImporte = 0
                                CompraDescuento = 0
                                CompraSubTotal = 0
                                CompraIva = 0
                                CompraTotal = 0
                                Me.txtTotal.Text = ""
                                Exit Sub
                            End If
                        End If
                        Procesando = False
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#End Region

  
#Region "DataGridViewOrdenServicio"

    Private Sub DgListOrdServ_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgListOrdServ.CellDoubleClick
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DgListOrdServ_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgListOrdServ.SelectionChanged
        Try
            If Me.DgListOrdServ.CurrentRow.DataBoundItem IsNot Nothing Then
                OrdenServ = DirectCast(Me.DgListOrdServ.CurrentRow.DataBoundItem, ClasesNegocio.OrdenServicioClass)
                Me.DgDetOrdSer.DataSource = OrdenServ.Detalle
                SumarCant()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DgListOrdServ_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgListOrdServ.DoubleClick
        Try
            For i As Integer = 0 To Me.dgvOrdenCompra.Rows.Count - 1
                Dim Control As DataGridViewCheckBoxCell = CType(Me.DgListOrdServ.Rows(i).Cells("clmSeleccion"), DataGridViewCheckBoxCell)
                If Control.EditingCellValueChanged = True Then
                    If Control.EditingCellFormattedValue = True Then
                        Control.EditingCellFormattedValue = False
                        Control.Value = False
                    Else
                        Control.EditingCellFormattedValue = True
                        Control.Value = True
                    End If

                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DgListOrdServ_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgListOrdServ.CellContentClick
        Try
            Select Case e.ColumnIndex
                Case Me.clmSeleccion.Index
                    If Procesando = False Then
                        Procesando = True
                        If Me.TxtSTot.Text = "" Then
                            OrdenServ = DirectCast(Me.DgListOrdServ.SelectedRows(0).DataBoundItem, ClasesNegocio.OrdenServicioClass)
                            Me.DgDetOrdSer.DataSource = OrdenServ.Detalle

                            ServicioSubTotal = OrdenServ.SubTotal
                            ServicioDescuento = OrdenServ.Descuento
                            ServicioIva = OrdenServ.IVA
                            ServicioTotal = OrdenServ.Total

                            Me.TxtSTot.Text = ServicioSubTotal.ToString("C2")
                            Me.TxtDto.Text = ServicioDescuento.ToString("C2")
                            Me.TxtIvaS.Text = ServicioIva.ToString("C2")
                            Me.TxtTotalS.Text = ServicioTotal.ToString("C2")

                            SumarTotalCantidadesServicio()

                            Bandera = False

                        Else
                            OrdenServ = DirectCast(Me.DgListOrdServ.Rows(e.RowIndex).DataBoundItem, ClasesNegocio.OrdenServicioClass)
                            For i As Integer = 0 To Me.DgListOrdServ.Rows.Count - 1
                                Dim Control As DataGridViewCheckBoxCell = CType(Me.DgListOrdServ.Rows(i).Cells("clmSeleccion"), DataGridViewCheckBoxCell)
                                If Control.EditingCellValueChanged = True Then
                                    If Control.EditingCellFormattedValue = True Then

                                        ServicioSubTotal += OrdenServ.SubTotal
                                        ServicioDescuento += OrdenServ.Descuento
                                        ServicioIva += OrdenServ.IVA
                                        ServicioTotal += OrdenServ.Total

                                        Me.TxtSTot.Text = ServicioSubTotal.ToString("C2")
                                        Me.TxtDto.Text = ServicioDescuento.ToString("C2")
                                        Me.TxtIvaS.Text = ServicioIva.ToString("C2")
                                        Me.TxtTotalS.Text = ServicioTotal.ToString("C2")

                                        SumarTotalCantidadesServicio()

                                        Bandera = False

                                    Else

                                        ServicioSubTotal -= OrdenServ.SubTotal
                                        ServicioDescuento -= OrdenServ.Descuento
                                        ServicioIva -= OrdenServ.IVA
                                        ServicioTotal -= OrdenServ.Total

                                        Me.TxtSTot.Text = ServicioSubTotal.ToString("C2")
                                        Me.TxtDto.Text = ServicioDescuento.ToString("C2")
                                        Me.TxtIvaS.Text = ServicioIva.ToString("C2")
                                        Me.TxtTotalS.Text = ServicioTotal.ToString("C2")

                                        RestarTotalCantidadesServicio()

                                        Bandera = False

                                    End If
                                End If

                                If Not Control.EditingCellFormattedValue = False Then
                                    Bandera = False
                                End If
                            Next
                        End If

                        If Bandera = True Then
                            Me.DgDetOrdSer.DataSource = Nothing
                            Me.TxtCanSolS.Text = ""
                            Me.TxtCanES.Text = ""
                            Me.TxtSTot.Text = ""
                            Me.TxtDto.Text = ""
                            Me.TxtIvaS.Text = ""
                            Me.TxtTotalS.Text = ""
                            Me.txtTotalCanEmitida2.Text = ""
                            Me.txtTotalCanSolicitada2.Text = ""
                            ServicioSubTotal = 0
                            ServicioDescuento = 0
                            ServicioIva = 0
                            ServicioTotal = 0
                            Exit Sub
                        End If
                        Procesando = False
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#End Region

    Private Sub cmbPlaza_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPlaza.KeyPress
        If e.KeyChar <> Chr(13) Then
            Tmplaza.Stop()
            UltimaTeclaPlaza = Now
            Me.Tmplaza.Start()
        End If
    End Sub

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        If cmbPlaza.SelectedIndex > 0 Then
            SucursalC.Clear()
            Dim suc As New ClasesNegocio.SucursalClass
            suc.Descripcion = "TODAS"
            SucursalC.Add(suc)

            For Each sucursal As ClasesNegocio.SucursalClass In DirectCast(cmbPlaza.SelectedItem, ClasesNegocio.PlazaClass).Sucursales
                SucursalC.Add(sucursal)
            Next

            cmbSucursal.DataSource = SucursalC
        Else
            cmbSucursal.DataSource = Nothing
            cmbSucursal.Text = "TODAS"
        End If
    End Sub

    Private Sub cmbSucursal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbSucursal.KeyPress
        If e.KeyChar <> Chr(13) Then
            TmSucursal.Stop()
            UltimaTeclaSucursal = Now
            Me.TmSucursal.Start()
        End If
    End Sub

    Private Sub CmbPlaza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            cmbSucursal.Focus()
            If cmbPlaza.Text = "" Then
                MsgBox("Seleccione una Plaza")
                cmbPlaza.Focus()
            End If
        End If
    End Sub

    Private Sub cmbPlaza_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlaza.TextChanged
        If cmbPlaza.SelectedIndex > 0 Then
            SucursalC.Clear()
            Dim suc As New ClasesNegocio.SucursalClass
            suc.Descripcion = "TODAS"
            SucursalC.Add(suc)

            For Each sucursal As ClasesNegocio.SucursalClass In DirectCast(cmbPlaza.SelectedItem, ClasesNegocio.PlazaClass).Sucursales
                SucursalC.Add(sucursal)
            Next

            cmbSucursal.DataSource = SucursalC
        Else
            cmbSucursal.DataSource = Nothing
            cmbSucursal.Text = "TODAS"
        End If
    End Sub

    Private Sub Tmplaza_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tmplaza.Tick
        If Me.UltimaTeclaPlaza.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
            Me.Tmplaza.Stop()
            Me.PlazaC.Obtener(Me.cmbPlaza.Text, ClasesNegocio.CondicionEnum.ACTIVOS, True)
            Me.cmbPlaza.DataSource = PlazaC
        End If
    End Sub

    Private Sub TmSucursal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmSucursal.Tick
        If Me.UltimaTeclaSucursal.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
            Me.TmSucursal.Stop()
            Me.SucursalC.Obtener(Me.cmbSucursal.Text, ClasesNegocio.CondicionEnum.ACTIVOS, Me.cmbPlaza.SelectedValue, True)
            Me.cmbSucursal.DataSource = SucursalC
        End If
    End Sub


    'Private Sub dgvOrdenCompra_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvOrdenCompra.DoubleClick
    '    Try
    '        If Me.dgvOrdenCompra.SelectedRows.Count > 0 Then
    '            Orden = DirectCast(Me.dgvOrdenCompra.SelectedRows(0).DataBoundItem, ClasesNegocio.OrdenCompraClass)

    '            Me.dgvDetalleOrdenCompra.DataSource = Orden.Detalle

    '            Me.txtImporte.Text = Orden.Importe.ToString("C2")
    '            Me.txtDescuento.Text = Orden.Descuento.ToString("C2")
    '            Me.txtSubTotal.Text = Orden.SubTotal.ToString("C2")
    '            txtIVA.Text = Orden.IVATotal.ToString("C2")
    '            txtTotal.Text = Orden.Total.ToString("C2")

    '            SumarCantidades()
    '        Else
    '            Orden = Nothing
    '            dgvDetalleOrdenCompra.DataSource = Nothing

    '            Me.txtImporte.Clear()
    '            Me.txtDescuento.Clear()
    '            Me.txtSubTotal.Clear()
    '            txtIVA.Clear()
    '            txtTotal.Clear()

    '            SumarCantidades()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub

    '=============================================================================================================================================================

    'Private Sub dgvOrdenCompra_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgvOrdenCompra.KeyPress
    '    Try
    '        If e.KeyChar = Chr(13) Then
    '            If Me.dgvOrdenCompra.SelectedRows.Count > 0 Then
    '                Orden = DirectCast(Me.dgvOrdenCompra.SelectedRows(0).DataBoundItem, ClasesNegocio.OrdenCompraClass)

    '                Me.dgvDetalleOrdenCompra.DataSource = Orden.Detalle
    '                Me.txtImporte.Text = Orden.Importe.ToString("C2")
    '                Me.txtDescuento.Text = Orden.Descuento.ToString("C2")
    '                Me.txtSubTotal.Text = Orden.SubTotal.ToString("C2")
    '                txtIVA.Text = Orden.IVATotal.ToString("C2")
    '                txtTotal.Text = Orden.Total.ToString("C2")

    '                SumarCantidades()
    '            Else
    '                Orden = Nothing
    '                dgvDetalleOrdenCompra.DataSource = Nothing

    '                Me.txtImporte.Clear()
    '                Me.txtDescuento.Clear()
    '                Me.txtSubTotal.Clear()
    '                txtIVA.Clear()
    '                txtTotal.Clear()

    '                SumarCantidades()
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub

    '=============================================================================================================================================================

    'Private Sub DgListOrdServ_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgListOrdServ.DoubleClick
    '    Try
    '        If Me.DgListOrdServ.SelectedRows.Count > 0 Then
    '            OrdenServ = DirectCast(Me.DgListOrdServ.SelectedRows(0).DataBoundItem, ClasesNegocio.OrdenServicioClass)

    '            Me.DgDetOrdSer.AutoGenerateColumns = False
    '            Me.DgDetOrdSer.DataSource = OrdenServ.Detalle

    '            Me.TxtDto.Text = OrdenServ.Descuento.ToString("C2")
    '            Me.TxtSTot.Text = OrdenServ.SubTotal.ToString("C2")
    '            Me.TxtIvaS.Text = OrdenServ.IVA.ToString("C2")
    '            Me.TxtTotalS.Text = OrdenServ.Total.ToString("C2")

    '            SumarCant()
    '        Else
    '            OrdenServ = Nothing
    '            DgDetOrdSer.DataSource = Nothing

    '            Me.TxtDto.Clear()
    '            Me.TxtSTot.Clear()
    '            Me.TxtIvaS.Clear()
    '            Me.TxtTotalS.Clear()

    '            SumarCant()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub

    '=============================================================================================================================================================

    'Private Sub DgListOrdServ_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DgListOrdServ.KeyPress
    '    Try
    '        If Me.DgListOrdServ.SelectedRows.Count > 0 Then
    '            OrdenServ = DirectCast(Me.DgDetOrdSer.SelectedRows(0).DataBoundItem, ClasesNegocio.OrdenServicioClass)

    '            Me.DgDetOrdSer.AutoGenerateColumns = False
    '            Me.DgDetOrdSer.DataSource = OrdenServ.Detalle

    '            Me.TxtDto.Text = OrdenServ.Descuento.ToString("C2")
    '            Me.TxtSTot.Text = OrdenServ.SubTotal.ToString("C2")
    '            Me.TxtIvaS.Text = OrdenServ.IVA.ToString("C2")
    '            Me.TxtTotalS.Text = OrdenServ.Total.ToString("C2")

    '            SumarCant()
    '        Else
    '            OrdenServ = Nothing
    '            DgDetOrdSer.DataSource = Nothing

    '            Me.TxtDto.Clear()
    '            Me.TxtSTot.Clear()
    '            Me.TxtIvaS.Clear()
    '            Me.TxtTotalS.Clear()

    '            SumarCant()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub


End Class