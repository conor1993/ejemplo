Public Class ComAnalisisCotCompras
    Dim UltimoPrecio, UltimoDescuento As Decimal
    Dim Presupuesto As ClasesNegocio.PresupuestoCompraClass

    Private Sub Limpiar()
        DataGrid.Rows.Clear()
        lbProveedores.Items.Clear()

        If DataGrid.Columns.Count > 4 Then
            For i As Integer = 4 To DataGrid.Columns.Count - 1
                DataGrid.Columns.Remove(DataGrid.Columns(4))
            Next
        End If
        txtPresupuesto.Focus()
    End Sub

    Private Sub ComAnalisisCotCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim usuario As New ClasesNegocio.UsuarioClass(Controlador.Sesion.MiUsuario.Usrndx)

        PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

        cmbPlaza.Text = ""
        cmbPlaza.SelectedIndex = -1
        cmbSucursal.SelectedIndex = -1
        cmbPlaza.Enabled = True
        cmbSucursal.Enabled = True
    End Sub

    Private Sub txtPresupuesto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPresupuesto.KeyPress
        Try
            Cursor = Cursors.WaitCursor

            If e.KeyChar = Chr(13) Then
                If txtPresupuesto.Text = "" Then
                    MsgBox("Debe teclear un folio de presupuesto", MsgBoxStyle.Exclamation, "Faltan Datos")
                    Exit Sub
                End If

                Dim Lista As New ClasesNegocio.ListaAnalisisCotizacionCompraCollectionClass
                Dim idPlaza As Integer = -1
                Dim IdSucursal As Integer = -1
                If Me.cmbPlaza.SelectedIndex > -1 Then
                    idPlaza = CType(Me.cmbPlaza.SelectedValue, Integer)
                End If
                If Me.cmbSucursal.SelectedIndex > -1 Then
                    IdSucursal = CType(Me.cmbSucursal.SelectedValue, Integer)
                End If

                Lista.Obtener(idPlaza, IdSucursal)

                Limpiar()

                Dim Proveedor As Integer = -1
                Dim SumTotal() As Decimal = Nothing
                Dim clmPre, ClmTot, ClmDesc As DataGridViewColumn
                Dim ColActual As Integer = 3
                Dim fila As Integer
                Dim NProv As Integer = 0
                Dim agregarfila As Boolean = True

                If Lista.Count = 0 Then
                    MsgBox("No se encontraron cotizaciones de ese presupuesto", MsgBoxStyle.Information, "Aviso")
                    Exit Sub
                End If

                Dim clmColor As Color = Color.LightYellow

                Presupuesto = New ClasesNegocio.PresupuestoCompraClass(txtPresupuesto.Text)

                For Each Row As ClasesNegocio.ListaAnalisisCotizacionCompraClass In Lista
                    If Not Proveedor = Row.CodigoProveedor Then
                        Proveedor = Row.CodigoProveedor

                        clmPre = New DataGridViewColumn
                        clmPre.CellTemplate = New DataGridViewTextBoxCell
                        clmPre.DefaultCellStyle.Format = "C2"
                        clmPre.Name = Row.IdCotizacion.ToString()
                        clmPre.HeaderText = "Proveedor " & NProv + 1 & Chr(13) & "(Precio)"
                        clmPre.ToolTipText = Row.Proveedor
                        clmPre.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        'clmPre.SortMode = DataGridViewColumnSortMode.Automatic
                        clmPre.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        clmPre.DefaultCellStyle.BackColor = clmColor
                        'clmPre.DefaultCellStyle.NullValue = 0

                        ClmTot = New DataGridViewColumn
                        ClmTot.CellTemplate = New DataGridViewTextBoxCell
                        ClmTot.DefaultCellStyle.Format = "C2"
                        ClmTot.Name = Row.CodigoProveedor & "Total"
                        ClmTot.HeaderText = "Total"
                        ClmTot.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        ClmTot.ReadOnly = True
                        'ClmTot.SortMode = DataGridViewColumnSortMode.Automatic
                        ClmTot.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        ClmTot.DefaultCellStyle.BackColor = Color.LightCyan

                        ClmDesc = New DataGridViewColumn
                        ClmDesc.CellTemplate = New DataGridViewTextBoxCell
                        ClmDesc.DefaultCellStyle.Format = "C2"
                        ClmDesc.Name = Row.CodigoProveedor & "Descuento"
                        ClmDesc.HeaderText = "Descuento"
                        ClmDesc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        'ClmDesc.SortMode = DataGridViewColumnSortMode.Automatic
                        ClmDesc.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        ClmDesc.DefaultCellStyle.BackColor = clmColor
                        'ClmDesc.DefaultCellStyle.NullValue = 0

                        clmPre.Width = 100

                        DataGrid.Columns.Add(clmPre)
                        DataGrid.Columns.Add(ClmDesc)
                        DataGrid.Columns.Add(ClmTot)

                        ColActual += 3
                        fila = 0
                        NProv += 1

                        If NProv > 1 Then
                            agregarfila = False
                        End If

                        ReDim Preserve SumTotal(NProv) ', SumaDescuento(NProv)

                        Me.lbProveedores.Items.Add("Proveedor " & NProv & " - " & Row.Proveedor)
                    End If

                    If agregarfila Then
                        DataGrid.Rows.Add(1)

                        DataGrid.Rows(fila).Cells(0).Value = Row.CodigoProducto
                        DataGrid.Rows(fila).Cells(1).Value = Row.Producto
                        DataGrid.Rows(fila).Cells(2).Value = Row.Cantidad
                        DataGrid.Rows(fila).Cells(3).Value = Row.AplicaIva
                    End If

                    DataGrid.Rows(fila).Cells(ColActual - 2).Value = Row.Precio
                    DataGrid.Rows(fila).Cells(ColActual - 1).Value = Row.Descuento
                    DataGrid.Rows(fila).Cells(ColActual).Value = Row.Importe

                    fila += 1
                    SumTotal(NProv - 1) += Row.Importe
                    'SumaDescuento(NProv - 1) += Row.Descuento
                Next

                DataGrid.Rows.Add(1)
                DataGrid.Rows(DataGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Lavender

                Dim n As Integer = 0

                DataGrid.Rows(fila).Cells(1).Value = "Suma Totales"

                For i As Integer = 6 To DataGrid.Columns.Count - 1 Step 3
                    DataGrid.Rows(fila).Cells(i).Value = SumTotal(n)
                    'DataGrid.Rows(fila).Cells(i - 1).Value = SumaDescuento(n)
                    n += 1
                Next
                txtPresupuesto.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub DataGrid_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DataGrid.CellBeginEdit
        If e.RowIndex = DataGrid.Rows.Count - 1 Then
            MsgBox("Esta fila no es editable", MsgBoxStyle.Information, "Aviso")
            e.Cancel = True
        Else
            If DataGrid.Columns(e.ColumnIndex).HeaderText = "Descuento" Then
                UltimoPrecio = CDec(DataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value.ToString.Replace("$", "").Replace(",", ""))
                UltimoDescuento = CDec(DataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.Replace("$", "").Replace(",", ""))
            Else
                UltimoPrecio = CDec(DataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.Replace("$", "").Replace(",", ""))
                UltimoDescuento = CDec(DataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value.ToString.Replace("$", "").Replace(",", ""))
            End If
        End If
    End Sub

    Private Sub DataGrid_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellEndEdit
        If DataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString = "" Then
            MsgBox("Debe ingresar una cantidad", MsgBoxStyle.Exclamation, "Aviso")
            GoTo SALIR
        End If

        If Not IsNumeric(DataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.Replace("$", "").Replace(",", "")) Then
            MsgBox("Debe teclear numeros", MsgBoxStyle.Exclamation, "Datos Invalidos")
SALIR:
            If DataGrid.Columns(e.ColumnIndex).HeaderText = "Descuento" Then
                DataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value = UltimoPrecio.ToString("C2")
                DataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = UltimoDescuento.ToString("C2")
            Else
                DataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = UltimoPrecio.ToString("C2")
                DataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = UltimoDescuento.ToString("C2")
            End If
        Else
            If DataGrid.Columns(e.ColumnIndex).HeaderText = "Descuento" Then
                Dim NPrecio As Decimal = CDec(DataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value.ToString.Replace("$", "").Replace(",", ""))
                Dim cantidad As Decimal = CDec(DataGrid.Rows(e.RowIndex).Cells(2).Value)
                Dim Descuento As Decimal = CDec(DataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.Replace("$", "").Replace(",", ""))

                DataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Descuento.ToString("C2")
                DataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = (NPrecio * cantidad - Descuento).ToString("C2")

                Dim suma As Decimal = CDec(DataGrid.Rows(DataGrid.Rows.Count - 1).Cells(e.ColumnIndex + 1).Value.ToString.Replace("$", "").Replace(",", ""))
                suma += (NPrecio * cantidad - Descuento) - (UltimoPrecio * cantidad - UltimoDescuento)

                DataGrid.Rows(DataGrid.Rows.Count - 1).Cells(e.ColumnIndex + 1).Value = suma.ToString("C2")
            Else
                Dim NPrecio As Decimal = CDec(DataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.Replace("$", "").Replace(",", ""))
                Dim cantidad As Decimal = CDec(DataGrid.Rows(e.RowIndex).Cells(2).Value)
                Dim Descuento As Decimal = CDec(DataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value.ToString.Replace("$", "").Replace(",", ""))

                DataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDec(DataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.Replace("$", "").Replace(",", "")).ToString("C2")
                DataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).Value = (NPrecio * cantidad - Descuento).ToString("C2")

                Dim suma As Decimal = Decimal.Parse(DataGrid.Rows(DataGrid.Rows.Count - 1).Cells(e.ColumnIndex + 2).Value.ToString.Replace("$", "").Replace(",", ""))
                DataGrid.Rows(DataGrid.Rows.Count - 1).Cells(e.ColumnIndex + 2).Value = (suma + (NPrecio * cantidad - Descuento) - (UltimoPrecio * cantidad - UltimoDescuento)).ToString("C2")
            End If
        End If
    End Sub

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        If cmbPlaza.SelectedIndex > -1 Then
            SucursalC.Obtener(CType(cmbPlaza.SelectedValue, Integer), ClasesNegocio.CondicionEnum.ACTIVOS)
            cmbSucursal.SelectedIndex = -1
            cmbSucursal.Text = "Seleccione una sucursal"
        Else
            cmbSucursal.SelectedIndex = -1
            cmbSucursal.Text = ""
        End If
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Try
            Dim ventana As New ComBusquedaPresupuestoCompra
            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Folio As String
                Dim Suc As New ClasesNegocio.SucursalClass
                Folio = ventana.DataGrid.SelectedRows(0).Cells(ventana.ClmFolio.Index).Value.ToString
                Suc = DirectCast(ventana.DataGrid.SelectedRows(0).Cells(ventana.clmSucursal.Index).Value, ClasesNegocio.SucursalClass)

                Dim Lista As New ClasesNegocio.ListaAnalisisCotizacionCompraCollectionClass


                ' Lista.Obtener(Suc.Plaza.Codigo, Suc.Codigo, Folio)

                'Limpiar()

                Me.cmbPlaza.SelectedValue = Suc.Plaza.Codigo
                Me.cmbSucursal.SelectedValue = Suc.Codigo
                Me.txtPresupuesto.Text = Folio

                Me.txtPresupuesto_KeyPress(sender, New KeyPressEventArgs(Chr(13)))

                '    Dim Proveedor As Integer = -1
                '    Dim SumTotal() As Decimal
                '    Dim clmPre, ClmTot, ClmDesc As DataGridViewColumn
                '    Dim ColActual As Integer = 3
                '    Dim fila As Integer
                '    Dim NProv As Integer = 0
                '    Dim agregarfila As Boolean = True

                '    If Lista.Count = 0 Then
                '        MsgBox("No se encontraron cotizaciones de ese presupuesto", MsgBoxStyle.Exclamation, "Aviso")
                '        Exit Sub
                '    End If

                '    Dim clmColor As Color = Color.LightYellow

                '    Presupuesto = New ClasesNegocio.PresupuestoCompraClass(txtPresupuesto.Text)

                '    For Each Row As ClasesNegocio.ListaAnalisisCotizacionCompraClass In Lista
                '        If Not Proveedor = Row.CodigoProveedor Then
                '            Proveedor = Row.CodigoProveedor

                '            clmPre = New DataGridViewColumn
                '            clmPre.CellTemplate = New DataGridViewTextBoxCell
                '            clmPre.DefaultCellStyle.Format = "C2"
                '            clmPre.Name = Row.FolioCotizacion
                '            clmPre.HeaderText = "Proveedor " & NProv + 1 & Chr(13) & "(Precio)"
                '            clmPre.ToolTipText = Row.Proveedor
                '            clmPre.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                '            'clmPre.SortMode = DataGridViewColumnSortMode.Automatic
                '            clmPre.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                '            clmPre.DefaultCellStyle.BackColor = clmColor
                '            'clmPre.DefaultCellStyle.NullValue = 0

                '            ClmTot = New DataGridViewColumn
                '            ClmTot.CellTemplate = New DataGridViewTextBoxCell
                '            ClmTot.DefaultCellStyle.Format = "C2"
                '            ClmTot.Name = Row.CodigoProveedor & "Total"
                '            ClmTot.HeaderText = "Total"
                '            ClmTot.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                '            ClmTot.ReadOnly = True
                '            'ClmTot.SortMode = DataGridViewColumnSortMode.Automatic
                '            ClmTot.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                '            ClmTot.DefaultCellStyle.BackColor = Color.LightCyan

                '            ClmDesc = New DataGridViewColumn
                '            ClmDesc.CellTemplate = New DataGridViewTextBoxCell
                '            ClmDesc.DefaultCellStyle.Format = "C2"
                '            ClmDesc.Name = Row.CodigoProveedor & "Descuento"
                '            ClmDesc.HeaderText = "Descuento"
                '            ClmDesc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                '            'ClmDesc.SortMode = DataGridViewColumnSortMode.Automatic
                '            ClmDesc.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                '            ClmDesc.DefaultCellStyle.BackColor = clmColor
                '            'ClmDesc.DefaultCellStyle.NullValue = 0

                '            clmPre.Width = 100

                '            DataGrid.Columns.Add(clmPre)
                '            DataGrid.Columns.Add(ClmDesc)
                '            DataGrid.Columns.Add(ClmTot)

                '            ColActual += 3
                '            fila = 0
                '            NProv += 1

                '            If NProv > 1 Then
                '                agregarfila = False
                '            End If

                '            ReDim Preserve SumTotal(NProv) ', SumaDescuento(NProv)

                '            Me.lbProveedores.Items.Add("Proveedor " & NProv & " - " & Row.Proveedor)
                '        End If

                '        If agregarfila Then
                '            DataGrid.Rows.Add(1)

                '            DataGrid.Rows(fila).Cells(0).Value = Row.CodigoProducto
                '            DataGrid.Rows(fila).Cells(1).Value = Row.Producto
                '            DataGrid.Rows(fila).Cells(2).Value = Row.Cantidad
                '            DataGrid.Rows(fila).Cells(3).Value = Row.AplicaIva
                '        End If

                '        DataGrid.Rows(fila).Cells(ColActual - 2).Value = Row.Precio
                '        DataGrid.Rows(fila).Cells(ColActual - 1).Value = Row.Descuento
                '        DataGrid.Rows(fila).Cells(ColActual).Value = Row.Importe

                '        fila += 1
                '        SumTotal(NProv - 1) += Row.Importe
                '        'SumaDescuento(NProv - 1) += Row.Descuento
                '    Next

                '    DataGrid.Rows.Add(1)
                '    DataGrid.Rows(DataGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Lavender

                '    Dim n As Integer = 0

                '    DataGrid.Rows(fila).Cells(1).Value = "Suma Totales"

                '    For i As Integer = 6 To DataGrid.Columns.Count - 1 Step 3
                '        DataGrid.Rows(fila).Cells(i).Value = SumTotal(n)
                '        'DataGrid.Rows(fila).Cells(i - 1).Value = SumaDescuento(n)
                '        n += 1
                '    Next
                '    txtPresupuesto.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickCancelar
        Limpiar()
        txtPresupuesto.Enabled = True
        txtPresupuesto.Clear()
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickGuardar
        Dim Trans As Integralab.ORM.HelperClasses.Transaction = Nothing

        Try
            Cursor = Cursors.WaitCursor

            If txtPresupuesto.Text = "" Then
                MsgBox("Debe introducir un presupuesto", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If

            If DataGrid.Rows.Count = 0 Then
                MsgBox("Debe haber productos en el listado", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If

            Trans = New IntegraLab.ORM.HelperClasses.Transaction(IsolationLevel.ReadCommitted, "Guardar")

            For i As Integer = 0 To DataGrid.Rows.Count - 2
                For j As Integer = 4 To DataGrid.Columns.Count - 1 Step 3
                    Dim det As New ClasesNegocio.CotizacionCompraProveedorDetalleClass
                    With DataGrid.Rows(i)
                        det.IdProducto = Integer.Parse(.Cells(0).Value.ToString)
                        det.Cantidad = Decimal.Parse(.Cells(2).Value.ToString)
                        det.Precio = Decimal.Parse(.Cells(j).Value.ToString)
                        det.Importe = Decimal.Parse(.Cells(j + 2).Value.ToString)
                        det.Descuento = Decimal.Parse(.Cells(j + 1).Value.ToString)

                        det.ObtenerEntidad.IsNew = False

                        If Not det.Guardar(Trans) Then
                            Trans.Rollback()
                            MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                            Exit Sub
                        End If
                    End With
                Next
            Next

            'Trans.Add(Presupuesto.ObtenerEntidad)


            For i As Integer = 0 To Integer.Parse(((DataGrid.Columns.Count - 4) / 3).ToString) - 1

                Dim Importe As Decimal = 0
                Dim Descuento As Decimal = 0
                Dim SubTotal As Decimal = 0
                Dim IVA As Decimal = 0

                Dim ClmIni As Integer = i * 3 + 4
                Dim Cot As New ClasesNegocio.CotizacionCompraClass

                'Cot.Obtener(DataGrid.Columns(ClmIni).Name)

                For j As Integer = 0 To DataGrid.Rows.Count - 2
                    With DataGrid.Rows(j)
                        Importe += CDec(.Cells(ClmIni).Value) * CDec(.Cells(2).Value)
                        Descuento += CDec(.Cells(ClmIni + 1).Value)
                        SubTotal += CDec(.Cells(ClmIni).Value) * CDec(.Cells(2).Value) - CDec(.Cells(ClmIni + 1).Value)

                        If CBool(.Cells(3).Value) Then
                            IVA += Decimal.Round((CDec(.Cells(ClmIni).Value) * CDec(.Cells(2).Value) - CDec(.Cells(ClmIni + 1).Value)) * 0.15D, 2)
                        End If
                    End With
                Next

                'Cot.Importe = Importe
                'Cot.IVA = IVA
                'Cot.SubTotal = SubTotal
                'Cot.Descuento = Descuento
                'Cot.Total = IVA + SubTotal

                Trans.Add(Cot.ObtenerEntidad)

                If Not Cot.ObtenerEntidad.Save Then
                    Trans.Rollback()
                    MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                    Exit Sub
                End If
            Next

            Trans.Commit()

            MsgBox("Los datos han sido guardados", MsgBoxStyle.Information, "Aviso")

            Limpiar()

            txtPresupuesto.Clear()
            txtPresupuesto.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            If Not Trans Is Nothing Then
                Trans.Rollback()
            End If
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub
End Class