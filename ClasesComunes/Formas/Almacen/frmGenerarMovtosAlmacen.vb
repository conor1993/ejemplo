Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = Integralab.ORM.TypedViewClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports Microsoft.Win32

Public Class frmGenerarMovtosAlmacen
#Region "Miembros"
    Dim Almacen As CN.AlmacenClass
    Dim Sucursal As CN.SucursalClass
    Dim InvMovAlmacenCab As CN.AlmacenGeneral.MovimientoAlmacenPVClass
    Dim InvMovAlmacenDet As CN.AlmacenGeneral.MovimientoAlmacenPVDetalleClass
    Dim _FolioAlm As String = ""
    Dim GranTotal As Decimal = 0
    Dim GranCantidad As Decimal = 0
    Dim CodBarraEstatus As Boolean = False
#End Region

#Region "Metodos"
    Public Sub llenarTiposMovimientos()
        Dim movtos As New CN.TipoMovimientoPVCollectionClass
        Dim filtro As New OC.PredicateExpression
        filtro.Add(HC.CatMovimientosAlmacenPvFields.IdMov <> 1 And HC.CatMovimientosAlmacenPvFields.IdMov <> 2 And HC.CatMovimientosAlmacenPvFields.IdMov <> 7 And HC.CatMovimientosAlmacenPvFields.IdMov <> 8 And HC.CatMovimientosAlmacenPvFields.IdMov <> 9 And HC.CatMovimientosAlmacenPvFields.IdMov <> 10)
        movtos.Obtener(filtro)
        cmbTipoMov.DataSource = movtos
        cmbTipoMov.DisplayMember = "Nombre"
        cmbTipoMov.ValueMember = "Codigo"
        cmbTipoMov.SelectedIndex = -1
        cmbTipoMov.Text = "< Seleccione un movimiento >".ToUpper
    End Sub

    Public Sub llenarArticulos()
        Dim prods As New CN.ProductoCollectionClass
        Dim filtro As New OC.PredicateExpression
        filtro.Add(HC.ProductoFields.Estatus = True And HC.ProductoFields.PdEsKit = False)
        prods.Obtener(filtro)
        clmArticulo.DataSource = prods
        clmArticulo.DisplayMember = "Descripcion"
        clmArticulo.ValueMember = "Codigo"

        'cmbTipoMov.Text = "< Seleccione un  >".ToUpper
    End Sub
    Public Sub Nuevo()
        dgvDetalleArticulos.Rows.Clear()
        cmbTipoMov.SelectedIndex = -1
        cmbTipoMov.Text = "< Seleccione un movimiento >".ToUpper
        GranCantidad = 0
        GranTotal = 0
        _FolioAlm = ""
        gbPrincipal.Enabled = True
        lblTotal.Text = Convert.ToDecimal(0).ToString("N2")
        lblCantidad.Text = Convert.ToDecimal(0).ToString("N3")
    End Sub
    Public Sub calcularTotalCantidad()
        GranCantidad = 0
        GranTotal = 0
        For Each row As DataGridViewRow In dgvDetalleArticulos.Rows
            If Not row.IsNewRow Then
                row.Cells(clmTotal.Index).Value = (CDec(row.Cells(clmCosto.Index).Value) * CDec(row.Cells(clmCantidad.Index).Value)).ToString("N2")
                GranTotal += CDec(row.Cells(clmTotal.Index).Value)
                GranCantidad += CDec(row.Cells(clmCantidad.Index).Value)
            End If
        Next
        lblTotal.Text = GranTotal.ToString("N2")
        lblCantidad.Text = GranCantidad.ToString("N3")
    End Sub
    Public Function validar() As Boolean
        Dim mensaje As String = ""
        If cmbTipoMov.SelectedValue Is Nothing And cmbTipoMov.SelectedIndex = -1 Then
            mensaje &= "*Seleccione un tipo de movimiento de la lista. " & vbLf
        End If
        If dgvDetalleArticulos.Rows.Count <= 1 Then
            mensaje &= "*Debe contener al menos un articulo en la lista. " & vbLf
        End If

        If Not mensaje.Equals("") Then
            mensaje = "Antes de guardar verifique lo siguiente: " & vbLf & vbLf & mensaje
            MessageBox.Show(mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Return False
        End If


        Return True
    End Function

    Public Function GuardarMovAlmacenCab(ByVal TipoMov As Integer) As Boolean
        Try
            'Dim ConfigAlm As New CC.InventarioConfiguracionCollection
            'ConfigAlm.GetMulti(Nothing, 0, Nothing)

            'If ConfigAlm.Count < 1 Then
            '    MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Return False
            'End If

            Me.InvMovAlmacenCab.IdAlmacen = Almacen.Codigo
            Me.InvMovAlmacenCab.FolioMovimientoAlmacen = _FolioAlm
            Me.InvMovAlmacenCab.FechaMovimiento = Now

            'If Modo = 1 Then
            '    If IsDBNull(ConfigAlm(0).ExCompra) Or ConfigAlm(0).ExCompra Is Nothing Then
            '        MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '        Return False
            '    End If
            '    Me.InvMovAlmacenCab.IdTipoMovimiento = ConfigAlm(0).ExCompra
            'ElseIf Modo = 2 Then
            '    If IsDBNull(ConfigAlm(0).SxDevolucionCompra) Or ConfigAlm(0).ExCompra Is Nothing Then
            '        MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '        Return False
            '    End If
            '    Me.InvMovAlmacenCab.IdTipoMovimiento = ConfigAlm(0).SxDevolucionCompra
            'End If
            ' Me.InvMovAlmacenCab.ValorMovimientoId = ""
            Me.InvMovAlmacenCab.IdTipoMovimiento = TipoMov ''ENTRADA POR COMPRA
            Me.InvMovAlmacenCab.CostoTotal = CDec(lblTotal.Text)
            Me.InvMovAlmacenCab.Origen = "COMPRAS"
            Me.InvMovAlmacenCab.Referencia = "MOVIMIENTO DIRECTO"
            Me.InvMovAlmacenCab.IdUsuarioAlta = Controlador.Sesion.Usrndx
            Me.InvMovAlmacenCab.EstatusContabilizado = 0

            Return True
            ' Me.InvMovAlmacenCab.FechaContabilizacion = ""
            'Me.InvMovAlmacenCab.PolizaContabilidad = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Sub imprimir()
        Dim Reportes As New CN.crRecepCompraTck
        Dim Titulo As String = ""
        Dim Directas As Boolean = True
        Dim cont As Double = 0

        Dim Ds As New DataSet
        Dim DsCab As New CN.DSRecepcionOrdenCompra.RecepcionOrdenCabDataTable
        Dim DsDet As New CN.DSRecepcionOrdenCompra.RecepcionOrdenDetDataTable
        Dim ImporteTotal As Decimal = 0
        Dim style As Drawing.FontStyle = Drawing.FontStyle.Bold
        Dim CantidadTotal As Decimal = 0

        Dim RecepRow As CN.DSRecepcionOrdenCompra.RecepcionOrdenCabRow = DsCab.AddRecepcionOrdenCabRow(Sucursal.Plaza.Descripcion, _
        Sucursal.Descripcion, _FolioAlm, "", "", Almacen.Descripcion, "", InvMovAlmacenCab.FechaMovimiento)

        For Each DetRecep As CN.AlmacenGeneral.MovimientoAlmacenPVDetalleClass In InvMovAlmacenCab.Detalle
            DsDet.AddRecepcionOrdenDetRow(RecepRow, DetRecep.IdProducto, DetRecep.Producto.Descripcion, DetRecep.Cantidad, 0, DetRecep.Cantidad, DetRecep.Costo, DetRecep.Descuento, 0, DetRecep.Costo * DetRecep.Cantidad)
            'cont = cont + DetRecep.Cantidad
            CantidadTotal += DetRecep.Cantidad
        Next

        Ds.Tables.Add(DsCab)
        Ds.Tables.Add(DsDet)

        Titulo = cmbTipoMov.Text.Trim.ToString
        Reportes.SetDataSource(Ds)
        Reportes.SetParameterValue(0, Controlador.Empresa.Nombre)
        Reportes.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnom)
        Reportes.SetParameterValue(2, " Inventario/Generar Movimientos")
        Reportes.SetParameterValue(3, Titulo)

        Dim reg As RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\INTEGRALAB\", True)
        Reportes.PrintOptions.PrinterName = reg.GetValue("NombreImpresora", Nothing).ToString
        Reportes.PrintToPrinter(1, False, 0, 0)

#If DEBUG Then
        '.....prueba del ticket visualmente
        Dim Prev As New ClasesNegocio.PreVisualizarForm
        Prev.Reporte = Reportes
        Prev.Text = "TICKET"
        Prev.Show()
#End If

    End Sub
#End Region

#Region "Barra"
    Private Sub Mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickGuardar
        Try
            If validar() Then
                Dim correcto As Boolean = True
                Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
                Sucursal = New CN.SucursalClass(Utilerias.ObtenerCodSucursal)
                'obtiene la letra serie del almacen seleccionado
                Me.Almacen = New ClasesNegocio.AlmacenClass
                Almacen.Obtener(Sucursal.IdAlmacen)
                'genera el folio de movimiento de almacen en la clase
                Dim FolioAlmacen As New CN.FolioAlmacenClass
                FolioAlmacen.LetraSerie = Almacen.Letras
                FolioAlmacen.Año = Now.Year
                FolioAlmacen.Mes = Now.ToString("MM")

                If Not FolioAlmacen.Guardar(Trans) Then
                    Trans.Rollback()
                    Cancelar = True
                    Exit Sub
                End If

                'asigna el folio de movimiento de almacen
                _FolioAlm = CN.AlmacenGeneral.MovimientoAlmacenClass.ObtenerFolioMovimiento(Almacen.Codigo, Trans)
                InvMovAlmacenCab = New CN.AlmacenGeneral.MovimientoAlmacenPVClass
                If Not GuardarMovAlmacenCab(CInt(cmbTipoMov.SelectedValue)) Then
                    correcto = False
                    Trans.Rollback()
                    Cancelar = True
                    Exit Sub
                End If

                If Not InvMovAlmacenCab.Guardar(Trans) Then
                    Trans.Rollback()
                    'TransMovAlm.Rollback()

                    Cancelar = True
                    'Exit Function
                    Exit Sub
                End If

                For Each row As DataGridViewRow In dgvDetalleArticulos.Rows

                    If Not row.IsNewRow Then
                        Me.InvMovAlmacenDet = New CN.AlmacenGeneral.MovimientoAlmacenPVDetalleClass
                        Me.InvMovAlmacenDet.IdAlmacen = Almacen.Codigo
                        Me.InvMovAlmacenDet.FolioMovimientoAlmacen = _FolioAlm
                        Me.InvMovAlmacenDet.IdProducto = CInt(row.Cells(clmArticulo.Index).Value)
                        Me.InvMovAlmacenDet.Cantidad = CDec(row.Cells(clmCantidad.Index).Value)
                        Me.InvMovAlmacenDet.Costo = CDec(row.Cells(clmCosto.Index).Value)
                        Me.InvMovAlmacenDet.Descuento = 0D
                        Me.InvMovAlmacenDet.Indice = row.Index + 1
                        If Not Me.InvMovAlmacenDet.Guardar(Trans) Then
                            correcto = False
                            Trans.Rollback()
                            Cancelar = True
                            Exit Sub
                        End If
                    End If
                Next

                If correcto Then
                    Trans.Commit()
                    imprimir()
                    MessageBox.Show("Se genero el movimiento correctamente con el folio: " & _FolioAlm & ".", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Nuevo()
                    gbPrincipal.Enabled = False
                End If

            Else
                Cancelar = True
            End If
        Catch ex As Exception
            Cancelar = True
            MessageBox.Show(ex.Message.ToString, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickLimpiar
        Nuevo()
    End Sub

    Private Sub Mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickCancelar
        Nuevo()
        gbPrincipal.Enabled = False
    End Sub

    Private Sub Mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickNuevo
        Nuevo()
    End Sub

    Private Sub Mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickSalir
        Me.Close()
        Me.Dispose()
    End Sub
#End Region

    Private Sub frmGenerarMovtosAlmacen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        tbEstados.StateBuscar = "001101111"
        tbEstados.StateLimpiar = ""
        tbEstados.StateCancelar = "000100001"
        tbEstados.StateNuevo = "011010001"
        tbEstados.StateGuardar = "000100011"
        tbEstados.StateBorrar = "000100011"
        tbEstados.StateEditar = "000011001"
        tbEstados.StateImprimir = ""
        tbEstados.StateSalir = ""

        Me.Mtb.ToolBarButtonStatus = tbEstados
        Me.Mtb.sbCambiarEstadoBotones("Cancelar")
        llenarTiposMovimientos()
        llenarArticulos()
        gbPrincipal.Enabled = False
    End Sub

    Private Sub frmGenerarMovtosAlmacen_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Me.dgvDetalleArticulos.CurrentRow IsNot Nothing Then
            If e.KeyCode = Keys.F1 AndAlso Me.dgvDetalleArticulos.CurrentRow.Cells(clmCodigoBarra.Index).Selected Then
                'endedit = True
                'dgvDetalleOrdenCompra_KeyDown(dgvDetalleOrdenCompra, e)
                'endedit = False
                If dgvDetalleArticulos.CurrentRow.Cells(clmCodigoBarra.Index).Selected Then
                    e.Handled = True
                    Dim ventana As New FrmBuscarProductos
                    ventana.dgvProductosReg.Columns(ventana.clmExistencia.Index).Visible = False
                    'ventana.Edicion = True
                    ventana.txtDescripcion.Focus()
                    'ventana.txtDescripcion.Text = valorcelda
                    ventana.txtDescripcion.Text = dgvDetalleArticulos.CurrentRow.Cells(clmCodigoBarra.Index).EditedFormattedValue.ToString
                    'ventana.txtDescripcion.Text = dgvDetalleOrdenCompra.CurrentRow.Cells(clmCodigoBarra.Index).Value.ToString
                    If ventana.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Dim prod As ClasesNegocio.ProductoGeneralClass = ventana.ProductosSeleccionados.Item(0)
                        'endedit = True
                        e.Handled = True
                        SendKeys.Send(Chr(Keys.Enter))
                        Application.DoEvents()
                        CodBarraEstatus = True
                        dgvDetalleArticulos.CurrentRow.Cells(clmArticulo.Index).Value = prod.Codigo
                        CodBarraEstatus = False
                        'dgvDetalleArticulos.CurrentRow.Cells(clmCodigoBarra.Index).Value = prod.CodigoBarra
                        SendKeys.Send(Chr(Keys.Enter))
                        SendKeys.Send(Chr(Keys.Enter))
                        'endedit = False
                    End If
                End If
            End If

        End If
        If e.KeyCode = Keys.Delete Then
            If dgvDetalleArticulos.CurrentRow IsNot Nothing And dgvDetalleArticulos.CurrentRow.Cells(clmArticulo.Index).Value <> Nothing Then
                Dim result As DialogResult = MessageBox.Show("¿Desea borrar el articulo " & dgvDetalleArticulos.CurrentRow.Cells(clmArticulo.Index).FormattedValue.ToString & " de la lista ?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                If result = Windows.Forms.DialogResult.Yes Then
                    dgvDetalleArticulos.Rows.RemoveAt(dgvDetalleArticulos.CurrentRow.Index)
                    calcularTotalCantidad()
                End If

            End If
        End If

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send(Convert.ToChar(Keys.Tab))
        End If

    End Sub

    Private Sub dgvDetalleArticulos_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleArticulos.CellValueChanged
        If e.ColumnIndex = clmArticulo.Index And e.RowIndex >= 0 Then
            ''***kareli 17/12/2014 modificación= se cambió el columnIndex a 1, tenía cero, porque el índice de la columna era 0
            ''**pero se agregó la columna codigo de barras, antes de el idproducto y el índice de la columna ahora es 1.
            Dim prod As New CN.ProductoCollectionClass
            Dim filtro As New OC.PredicateExpression
            filtro.Add(HC.ProductoFields.Codigo = CInt(dgvDetalleArticulos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value))
            prod.Obtener(filtro)
            ''codprod = Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmIdProducto.Index).Value
            'prod.Obtener(codprod)
            ''***Kareli 18/12/2014****
            ''MessageBox.Show("Se mostrará el Último Costo del Producto", "Punto de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            ''***Kareli 18/12/2014****
            ''***Para hacer la comparación del último costo con el nuevo

            Me.dgvDetalleArticulos.Rows(e.RowIndex).Cells(clmCodigoBarra.Index).Value = prod(0).CodigoBarra

            Me.dgvDetalleArticulos.Rows(e.RowIndex).Cells(clmCosto.Index).Value = prod(0).UltimoCosto
            Me.dgvDetalleArticulos.Rows(e.RowIndex).Cells(clmUnidad.Index).Value = prod(0).UnidadMedida.DescCorta
            Me.dgvDetalleArticulos.Rows(e.RowIndex).Cells(clmCantidad.Index).Value = CDec(1).ToString("N3")
            'txtCostoAnterior.Text = Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value


            ''
            'dgvDetalleArticulos.Refresh()
        End If

        If e.ColumnIndex = clmCodigoBarra.Index And e.RowIndex >= 0 Then
            ''***kareli 17/12/2014 modificación= se cambió el columnIndex a 1, tenía cero, porque el índice de la columna era 0
            ''**pero se agregó la columna codigo de barras, antes de el idproducto y el índice de la columna ahora es 1.
            If CodBarraEstatus = False Then
                Dim prod As New CN.ProductoCollectionClass
                Dim filtro As New OC.PredicateExpression
                If dgvDetalleArticulos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value IsNot Nothing Then
                    filtro.Add(HC.ProductoFields.CodigoBarra = CStr(dgvDetalleArticulos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value))
                    prod.Obtener(filtro)
                    ''codprod = Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmIdProducto.Index).Value
                    'prod.Obtener(codprod)
                    ''***Kareli 18/12/2014****
                    ''MessageBox.Show("Se mostrará el Último Costo del Producto", "Punto de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                    ''***Kareli 18/12/2014****
                    ''***Para hacer la comparación del último costo con el nuevo
                    If prod.Count > 0 Then
                        Me.dgvDetalleArticulos.Rows(e.RowIndex).Cells(clmArticulo.Index).Value = prod(0).Codigo

                        Me.dgvDetalleArticulos.Rows(e.RowIndex).Cells(clmCodigoBarra.Index).Value = prod(0).CodigoBarra

                        Me.dgvDetalleArticulos.Rows(e.RowIndex).Cells(clmCosto.Index).Value = prod(0).UltimoCosto
                        Me.dgvDetalleArticulos.Rows(e.RowIndex).Cells(clmUnidad.Index).Value = prod(0).UnidadMedida.DescCorta
                        Me.dgvDetalleArticulos.Rows(e.RowIndex).Cells(clmCantidad.Index).Value = CDec(1).ToString("N3")
                        calcularTotalCantidad()
                        'txtCostoAnterior.Text = Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value

                        'SendKeys.Send(Chr(Keys.Enter))
                        'Else
                        '    MessageBox.Show("No se encontro articulo.", "Punto de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '    dgvDetalleArticulos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Nothing
                        '    dgvDetalleArticulos.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = True
                    End If
                Else
                    dgvDetalleArticulos.Rows.RemoveAt(e.RowIndex)
                    dgvDetalleArticulos.CurrentCell.Selected = True
                End If
            End If
            ''
            'dgvDetalleArticulos.Refresh()
        End If

        If (e.ColumnIndex = clmCantidad.Index Or e.ColumnIndex = clmCosto.Index) And e.RowIndex >= 0 Then
            calcularTotalCantidad()
        End If



    End Sub

    Private Sub dgvDetalleArticulos_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleArticulos.CellEndEdit
        dgvDetalleArticulos.CurrentRow.Cells(clmCantidad.Index).Value = CDec(dgvDetalleArticulos.CurrentRow.Cells(clmCantidad.Index).Value).ToString("N3")
        dgvDetalleArticulos.CurrentRow.Cells(clmCosto.Index).Value = CDec(dgvDetalleArticulos.CurrentRow.Cells(clmCosto.Index).Value).ToString("N2")
    End Sub

    Private Sub dgvDetalleArticulos_CellValidating(sender As System.Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvDetalleArticulos.CellValidating
        If e.ColumnIndex = clmCantidad.Index Or e.ColumnIndex = clmCosto.Index Then
            If Not e.FormattedValue.ToString.Equals("") And e.FormattedValue IsNot Nothing Then
                Dim temp As Decimal = 0
                If Not Decimal.TryParse(e.FormattedValue.ToString, temp) Then
                    'e.Cancel = True
                    MessageBox.Show("Solo acepta numeros/formato incorrecto.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    dgvDetalleArticulos.CancelEdit()
                    dgvDetalleArticulos.RefreshEdit()
                End If
            End If
        End If
        If e.ColumnIndex = clmCodigoBarra.Index Then
            If e.FormattedValue.ToString.Equals("") Or e.FormattedValue Is Nothing Then
                dgvDetalleArticulos.CancelEdit()
                dgvDetalleArticulos.RefreshEdit()
            End If
        End If

    End Sub
End Class