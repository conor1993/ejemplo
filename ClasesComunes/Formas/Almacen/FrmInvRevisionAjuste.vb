Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = Integralab.ORM.TypedViewClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports ClasesNegocio
Imports SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmInvRevisionAjuste
    Dim Band As Boolean = False
    Dim valAlm As Integer
    Dim Almacen As ClasesNegocio.AlmacenClass
    Dim _FolioAlm As String = ""
    Dim InvMovAlmacenCab As AlmacenGeneral.MovimientoAlmacenPVClass
    Dim InvMovAlmacenDet As AlmacenGeneral.MovimientoAlmacenPVDetalleClass
    Dim HistorialInv As AlmacenGeneral.InventarioHistorialPVClass
    Dim Sucursal As New CN.SucursalClass()
    Dim indicePRueba As Integer = 0
    Dim cargaCodsucursal As Boolean
    Dim ds As CN.DsInventarioFisico
    Dim invs As CN.InventarioFisicoCollectionClass
#Region "Propiedades"
    Public Property valorAlmacen() As Integer
        Get
            Return valAlm
        End Get
        Set(ByVal value As Integer)
            valAlm = value
        End Set
    End Property
#End Region

    Private Sub FrmInvRevisionAjuste_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Utilerias.ObtenerCodSucursal = 0 Then
                cargaCodsucursal = False
                Exit Sub
            Else
                cargaCodsucursal = True
            End If

            Dim Almacen As New CN.AlmacenClass
            Almacen.Descripcion = "TODOS"
            Dim AlmacenesCol As New CN.AlmacenCollectionClass
            AlmacenesCol.Add(Almacen)

            Dim AuxCol As New CN.AlmacenCollectionClass
            AuxCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            For Each Alm As CN.AlmacenClass In AuxCol
                AlmacenesCol.Add(Alm)
            Next


            CmbAlmacenes.SelectedIndex = -1
            CmbAlmacenes.ValueMember = "Codigo"
            CmbAlmacenes.DisplayMember = "Descripcion"
            CmbAlmacenes.DataSource = AlmacenesCol
            Band = True


            Sucursal.Obtener(Utilerias.ObtenerCodSucursal())

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbAlmacenes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAlmacenes.SelectedIndexChanged
        If Band = False Then
            Exit Sub
        End If
        Try
            invs = New CN.InventarioFisicoCollectionClass
            ds = New CN.DsInventarioFisico
            Dim dst As New CN.DsInventarioFisico.VwReporteComprativoInventarioDataTable
            ds.Tables.Add(dst)
            Dim Filtro As New OC.PredicateExpression
            Filtro.Add(HC.InventarioFisicoFields.AlmacenId = CInt(CmbAlmacenes.SelectedValue) And HC.InventarioFisicoFields.Cantidad <> System.DBNull.Value)
            invs.Obtener(Filtro)
            Me.dgvDetalle.AutoGenerateColumns = False

            dgvDetalle.Rows.Clear()
            If invs.Count = 0 Then
                MessageBox.Show("Sin articulos por ajustar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Me.Dispose()
                Exit Sub
            End If
            Cursor.Current = Cursors.WaitCursor
            Application.DoEvents()
            For Each row As CN.InventarioFisicoClass In invs
                dgvDetalle.Rows.Add(row.ProductoID, row.Producto.Descripcion, IIf(row.CantidadSistema Is Nothing, 0D, row.CantidadSistema), row.Cantidad, row.Cantidad - IIf(row.CantidadSistema Is Nothing, 0D, row.CantidadSistema), row.FechaInventario)
                Dim dsr As CN.DsInventarioFisico.VwReporteComprativoInventarioRow = dst.NewVwReporteComprativoInventarioRow
                dsr.AlmacenId = row.AlmacenId
                dsr.ProductoId = row.ProductoID
                dsr.PdDescripcion = row.Producto.Descripcion
                dsr.Cantidad = row.Cantidad
                dsr.Existencia = IIf(row.CantidadSistema Is Nothing, 0D, row.CantidadSistema)
                dsr.FechaInventario = row.FechaInventario
                dst.Rows.Add(dsr)
            Next

            dgvDetalle.Sort(clmProducto, System.ComponentModel.ListSortDirection.Ascending)
            Cursor.Current = Cursors.Default

#If DEBUG Then
            MessageBox.Show(dgvDetalle.RowCount.ToString)
#End If
            'If Me.CmbAlmacenes.SelectedIndex > 0 Then
            '    Filtro.Add(HC.VwReporteComprativoInventarioFields.AlmacenId = Me.CmbAlmacenes.SelectedValue And HC.VwReporteComprativoInventarioFields.Cantidad <> System.DBNull.Value)
            'End If

            'Dim Vista As New TC.VwReporteComprativoInventarioTypedView
            'Vista.Fill(0, Nothing, True, Filtro)
            'dgvDetalle.Columns(clmFecha.Index).DefaultCellStyle.Format = "dd/MM/yyyy"

            'Me.dgvDetalle.DataSource = invs

            

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim Report As New CN.RptInventFisico

            'Dim bs As BindingSource = CType(dgvDetalle.DataSource, BindingSource)
            'Dim dt As New DataTable


            Report.SetDataSource(ds.Tables(1))
            Report.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            Report.SetParameterValue(1, "Inventarios / Comparación de Inventario")
            Report.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)


            Dim VerReporte As New FrmReportes
            VerReporte.CRV.ReportSource = Report
            VerReporte.StartPosition = FormStartPosition.CenterScreen
            VerReporte.WindowState = FormWindowState.Maximized
            VerReporte.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    


    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.CmbAlmacenes.SelectedIndex = 0
        Me.dgvDetalle.DataSource = Nothing
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar

        If MessageBox.Show("¿Seguro que quieres realizar el ajuste de inventario?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Ajuste_Inv_Fisico")
            Dim Sucursal As New ClasesNegocio.SucursalClass
            Dim CostoTotalEntrada As Double = 0
            Dim CostoTotalSalida As Double = 0
            Dim fecha As Date
            Dim n As Integer = 0
            Dim HuboEntrada As Boolean = False
            Dim HuboSalida As Boolean = False
            Try
                Sucursal.Obtener(Utilerias.ObtenerControlTurnoActual.CodSucursal)
                'obtiene la letra serie del almacen seleccionado
                Me.Almacen = New ClasesNegocio.AlmacenClass
                Almacen.Obtener(Sucursal.IdAlmacen)


                'For Each row As DataGridViewRow In dgvDetalle.Rows

                'genera el folio de movimiento de almacen en la clase
                Dim FolioAlmacen As New FolioAlmacenClass


                '    With row
                '        If row.Cells(clmDiferencia.Index).Value <> 0 Then
                '            InvMovAlmacenCab = New CN.AlmacenGeneral.MovimientoAlmacenPVClass()
                '            Dim InvAlmacen As New CN.AlmacenGeneral.InventarioAlmacenClass
                '            InvAlmacen.Obtener(row.Cells(clmProductoId.Index).Value, Sucursal.IdAlmacen)
                '            CostoTotal = InvAlmacen.CostoPromedio * row.Cells(clmDiferencia.Index).Value
                '            fecha = CDate(.Cells(clmFecha.Index).Value)
                '            With InvMovAlmacenCab
                '                .IdAlmacen = Sucursal.IdAlmacen
                '                .FolioMovimientoAlmacen = _FolioAlm
                '                .FechaMovimiento = Now
                '                .CostoTotal = CostoTotal
                '                .Origen = "INVENTARIO"
                '                .Referencia = fecha.ToString("dd/MM/yyyy HH:mm:ss")
                '                .IdUsuarioAlta = Controlador.Sesion.Usrndx
                '                .EstatusContabilizado = 0
                '            End With
                '            ''Tipo de movimiento
                '            If .Cells(clmExistencia.Index).Value < .Cells(clmExisFisica.Index).Value Then
                '                InvMovAlmacenCab.IdTipoMovimiento = AlmacenGeneral.MovimientoAlmacenPVClass.TipoMovimientoEnum.ENTRADA_X_AJUSTE_DE_INVENTARIO
                '            ElseIf .Cells(clmExistencia.Index).Value > .Cells(clmExisFisica.Index).Value Then
                '                InvMovAlmacenCab.IdTipoMovimiento = AlmacenGeneral.MovimientoAlmacenPVClass.TipoMovimientoEnum.SALIDA_X_AJUSTE_DE_INVENTARIO
                '            End If

                '            ''Guarda el cabecero del movimiento
                '            If Not InvMovAlmacenCab.Guardar(Trans) Then
                '                Trans.Rollback()
                '                Cancelar = True
                '                Exit Sub
                '            End If

                '            Dim j As Integer = 1
                '            Me.InvMovAlmacenDet = New AlmacenGeneral.MovimientoAlmacenPVDetalleClass
                '            Me.InvMovAlmacenDet.IdAlmacen = Almacen.Codigo
                '            Me.InvMovAlmacenDet.FolioMovimientoAlmacen = _FolioAlm
                '            Me.InvMovAlmacenDet.IdProducto = CInt(row.Cells(clmProductoId.Index).Value)
                '            Me.InvMovAlmacenDet.Cantidad = CDec(.Cells(clmDiferencia.Index).Value)
                '            Me.InvMovAlmacenDet.Costo = CDec(InvAlmacen.CostoPromedio)
                '            Me.InvMovAlmacenDet.Descuento = CDec(0)
                '            Me.InvMovAlmacenDet.Indice = j


                '            ''Guarda detalle del movimiento
                '            If Not Me.InvMovAlmacenDet.Guardar(Trans) Then
                '                Trans.Rollback()
                '                Cancelar = True
                '                Exit Sub
                '            End If

                '            ''guarda el historial del inventario
                '            HistorialInv = New AlmacenGeneral.InventarioHistorialPVClass
                '            HistorialInv.IdAlmacen = Almacen.Codigo
                '            HistorialInv.IdProducto = CInt(row.Cells(clmProductoId.Index).Value)
                '            HistorialInv.FechaInv = fecha
                '            HistorialInv.ExistenciaFisica = CDec(.Cells(clmExisFisica.Index).Value)
                '            HistorialInv.ExistenciaSistema = CDec(.Cells(clmExistencia.Index).Value)
                '            HistorialInv.PrecioUnitario = CDec(InvAlmacen.CostoPromedio)

                '            ''Guarda el historial
                '            If Not Me.HistorialInv.Guardar(Trans) Then
                '                Trans.Rollback()
                '                Cancelar = True
                '                Exit Sub
                '            End If

                '        End If
                '    End With
                'Next

                'Trans.Commit()
                'MessageBox.Show("Se realizo el ajuste de inventario correctamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Me.DialogResult = Windows.Forms.DialogResult.OK

                Dim matriz(dgvDetalle.RowCount - 1, 4) As String
                For Each row As DataGridViewRow In dgvDetalle.Rows
                    If row.Cells(clmDiferencia.Index).Value <> 0 Then
                        'ReDim matriz(row.Index, 4)

                        Dim InvAlmacen As New CN.AlmacenGeneral.InventarioAlmacenClass
                        InvAlmacen.Obtener(row.Cells(clmProductoId.Index).Value, CInt(CmbAlmacenes.SelectedValue))
                        'If InvAlmacen.IdAlmacen = 0 And InvAlmacen.IdProducto = 0 Then

                        'End If

                        fecha = CDate(row.Cells(clmFecha.Index).Value)
                        If row.Cells(clmExistencia.Index).Value < row.Cells(clmExisFisica.Index).Value Then
                            'InvMovAlmacenCab.IdTipoMovimiento = AlmacenGeneral.MovimientoAlmacenPVClass.TipoMovimientoEnum.ENTRADA_X_AJUSTE_DE_INVENTARIO
                            CostoTotalEntrada = CostoTotalEntrada + Math.Abs(InvAlmacen.CostoPromedio * row.Cells(clmDiferencia.Index).Value)
                            matriz(n, 0) = "E"
                            HuboEntrada = True
                        ElseIf row.Cells(clmExistencia.Index).Value > row.Cells(clmExisFisica.Index).Value Then
                            'InvMovAlmacenCab.IdTipoMovimiento = AlmacenGeneral.MovimientoAlmacenPVClass.TipoMovimientoEnum.SALIDA_X_AJUSTE_DE_INVENTARIO
                            CostoTotalSalida = CostoTotalSalida + Math.Abs(InvAlmacen.CostoPromedio * row.Cells(clmDiferencia.Index).Value)
                            matriz(n, 0) = "S"
                            HuboSalida = True
                        End If

                        'se inserta en matriz datos
                        matriz(n, 1) = row.Cells(clmProductoId.Index).Value
                        matriz(n, 2) = Math.Abs(row.Cells(clmDiferencia.Index).Value).ToString
                        matriz(n, 3) = InvAlmacen.CostoPromedio.ToString
                        matriz(n, 4) = "0.000"

                        ''guarda el historial del inventario
                        HistorialInv = New AlmacenGeneral.InventarioHistorialPVClass
                        HistorialInv.IdAlmacen = Almacen.Codigo
                        HistorialInv.IdProducto = CInt(row.Cells(clmProductoId.Index).Value)
                        HistorialInv.FechaInv = fecha
                        HistorialInv.ExistenciaFisica = CDec(row.Cells(clmExisFisica.Index).Value)
                        HistorialInv.ExistenciaSistema = CDec(row.Cells(clmExistencia.Index).Value)
                        HistorialInv.PrecioUnitario = CDec(InvAlmacen.CostoPromedio)

                        ''Guarda el historial
                        If Not Me.HistorialInv.Guardar(Trans) Then
                            Trans.Rollback()
                            Cancelar = True
                            Exit For
                        End If
                        n += 1
                    Else
                        fecha = CDate(row.Cells(clmFecha.Index).Value)
                        Dim InvAlmacen As New CN.AlmacenGeneral.InventarioAlmacenClass
                        InvAlmacen.Obtener(row.Cells(clmProductoId.Index).Value, Sucursal.IdAlmacen)
                        ''guarda el historial del inventario
                        HistorialInv = New AlmacenGeneral.InventarioHistorialPVClass
                        HistorialInv.IdAlmacen = Almacen.Codigo
                        HistorialInv.IdProducto = CInt(row.Cells(clmProductoId.Index).Value)
                        HistorialInv.FechaInv = fecha
                        HistorialInv.ExistenciaFisica = CDec(row.Cells(clmExisFisica.Index).Value)
                        HistorialInv.ExistenciaSistema = CDec(row.Cells(clmExistencia.Index).Value)
                        HistorialInv.PrecioUnitario = CDec(InvAlmacen.CostoPromedio)

                        ''Guarda el historial
                        If Not Me.HistorialInv.Guardar(Trans) Then
                            Trans.Rollback()
                            Cancelar = True
                            Exit Sub
                        End If
                    End If
                Next

                'Array.Clear(matriz, n, (dgvDetalle.RowCount - n) * 5)
                Dim j As Integer
                If HuboEntrada Then

                    FolioAlmacen.LetraSerie = Almacen.Letras
                    FolioAlmacen.Año = Now.Year
                    FolioAlmacen.Mes = Now.ToString("MM")

                    If Not FolioAlmacen.Guardar(Trans) Then
                        Trans.Rollback()
                        Cancelar = True
                        Exit Sub
                    End If

                    'asigna el folio de movimiento de almacen
                    _FolioAlm = AlmacenGeneral.MovimientoAlmacenClass.ObtenerFolioMovimiento(Almacen.Codigo, Trans)

                    ''generar mov cab de las entradas
                    InvMovAlmacenCab = New AlmacenGeneral.MovimientoAlmacenPVClass
                    With InvMovAlmacenCab
                        .IdAlmacen = Sucursal.IdAlmacen
                        .FolioMovimientoAlmacen = _FolioAlm
                        .FechaMovimiento = Now
                        .CostoTotal = CostoTotalEntrada
                        .Origen = "INVENTARIO"
                        .Referencia = fecha.ToString("dd/MM/yyyy HH:mm:ss")
                        .IdUsuarioAlta = Controlador.Sesion.Usrndx
                        .EstatusContabilizado = 0
                        .IdTipoMovimiento = AlmacenGeneral.MovimientoAlmacenPVClass.TipoMovimientoEnum.ENTRADA_X_AJUSTE_DE_INVENTARIO
                    End With

                    ''Guarda el cabecero del movimiento
                    If Not InvMovAlmacenCab.Guardar(Trans) Then
                        Trans.Rollback()
                        Cancelar = True
                        Exit Sub
                    End If
                    ''genera detalle de mov de las entradas
                    j = 0
                    For ind As Integer = 0 To n - 1

                        If matriz(ind, 0) = "E" Then
                            j += 1
                            Me.InvMovAlmacenDet = New AlmacenGeneral.MovimientoAlmacenPVDetalleClass
                            Me.InvMovAlmacenDet.IdAlmacen = Almacen.Codigo
                            Me.InvMovAlmacenDet.FolioMovimientoAlmacen = _FolioAlm
                            Me.InvMovAlmacenDet.IdProducto = CInt(matriz(ind, 1))
                            Me.InvMovAlmacenDet.Cantidad = CDec(matriz(ind, 2))
                            Me.InvMovAlmacenDet.Costo = CDec(matriz(ind, 3))
                            Me.InvMovAlmacenDet.Descuento = CDec(matriz(ind, 4))
                            Me.InvMovAlmacenDet.Indice = j
                            ''Guarda detalle del movimiento
                            If Not Me.InvMovAlmacenDet.Guardar(Trans) Then
                                Trans.Rollback()
                                Cancelar = True
                                Exit Sub
                            End If
                        End If
                    Next
                End If




                '-------------------------------------------------------------------SALIDAS
                'genera el folio de movimiento de almacen en la clase
                If HuboSalida Then
                    FolioAlmacen = New FolioAlmacenClass
                    FolioAlmacen.LetraSerie = Almacen.Letras
                    FolioAlmacen.Año = Now.Year
                    FolioAlmacen.Mes = Now.ToString("MM")

                    If Not FolioAlmacen.Guardar(Trans) Then
                        Trans.Rollback()
                        Cancelar = True
                        Exit Sub
                    End If

                    'asigna el folio de movimiento de almacen
                    _FolioAlm = AlmacenGeneral.MovimientoAlmacenClass.ObtenerFolioMovimiento(Almacen.Codigo, Trans)

                    ''generar mov cab de las entradas
                    InvMovAlmacenCab = New AlmacenGeneral.MovimientoAlmacenPVClass
                    With InvMovAlmacenCab
                        .IdAlmacen = Sucursal.IdAlmacen
                        .FolioMovimientoAlmacen = _FolioAlm
                        .FechaMovimiento = Now
                        .CostoTotal = CostoTotalSalida
                        .Origen = "INVENTARIO"
                        .Referencia = fecha.ToString("dd/MM/yyyy HH:mm:ss")
                        .IdUsuarioAlta = Controlador.Sesion.Usrndx
                        .EstatusContabilizado = 0
                        .IdTipoMovimiento = AlmacenGeneral.MovimientoAlmacenPVClass.TipoMovimientoEnum.SALIDA_X_AJUSTE_DE_INVENTARIO
                    End With

                    ''Guarda el cabecero del movimiento
                    If Not InvMovAlmacenCab.Guardar(Trans) Then
                        Trans.Rollback()
                        Cancelar = True
                        Exit Sub
                    End If
                    ''genera detalle de mov de las entradas
                    j = 0
                    For ind As Integer = 0 To n - 1
                        'If ind = 467 Then
                        '    indicePRueba = ind
                        'End If
                        If matriz(ind, 0) = "S" Then
                            j += 1
                            Me.InvMovAlmacenDet = New AlmacenGeneral.MovimientoAlmacenPVDetalleClass
                            Me.InvMovAlmacenDet.IdAlmacen = Almacen.Codigo
                            Me.InvMovAlmacenDet.FolioMovimientoAlmacen = _FolioAlm
                            Me.InvMovAlmacenDet.IdProducto = CInt(matriz(ind, 1))
                            Me.InvMovAlmacenDet.Cantidad = CDec(matriz(ind, 2))
                            Me.InvMovAlmacenDet.Costo = CDec(matriz(ind, 3))
                            Me.InvMovAlmacenDet.Descuento = CDec(matriz(ind, 4))
                            Me.InvMovAlmacenDet.Indice = j
                            ''Guarda detalle del movimiento
                            If Not Me.InvMovAlmacenDet.Guardar(Trans) Then
                                Trans.Rollback()
                                Cancelar = True
                                Exit Sub
                            End If
                        End If
                    Next
                End If


                Trans.Commit()
                MessageBox.Show("Se realizo el ajuste de inventario correctamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Windows.Forms.Cursor.Current = Cursors.Default
                Me.DialogResult = Windows.Forms.DialogResult.OK

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error " & indicePRueba.ToString, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Trans.Rollback()
                Cancelar = True
            End Try

        Else
            'Dim InvAlmacen As New CN.AlmacenGeneral.InventarioAlmacenClass
            'InvAlmacen.Obtener(dgvDetalle.Rows(1).Cells(clmProductoId.Index).Value, Sucursal.IdAlmacen)
            'MessageBox.Show("el costo promedio del articulo es: " & InvAlmacen.CostoPromedio.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If




    End Sub

    Private Sub FrmInvRevisionAjuste_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        If cargaCodsucursal = False Then
            Me.Close()
            Me.Dispose()
        End If

        CmbAlmacenes.SelectedValue = valorAlmacen
    End Sub

    'Public Function GuardarMovAlmacenCab(ByVal TipoMov As Integer) As Boolean
    '    Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")

    '    Try
    '        'Dim ConfigAlm As New CC.InventarioConfiguracionCollection
    '        'ConfigAlm.GetMulti(Nothing, 0, Nothing)

    '        'If ConfigAlm.Count < 1 Then
    '        '    MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        '    Return False
    '        'End If

    '        Me.InvMovAlmacenCab = New AlmacenGeneral.MovimientoAlmacenPVClass



    '        Me.InvMovAlmacenCab.IdAlmacen = Sucursal.IdAlmacen
    '        Me.InvMovAlmacenCab.FolioMovimientoAlmacen = _FolioAlm
    '        Me.InvMovAlmacenCab.FechaMovimiento = Now

    '        'If Modo = 1 Then
    '        '    If IsDBNull(ConfigAlm(0).ExCompra) Or ConfigAlm(0).ExCompra Is Nothing Then
    '        '        MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        '        Return False
    '        '    End If
    '        '    Me.InvMovAlmacenCab.IdTipoMovimiento = ConfigAlm(0).ExCompra
    '        'ElseIf Modo = 2 Then
    '        '    If IsDBNull(ConfigAlm(0).SxDevolucionCompra) Or ConfigAlm(0).ExCompra Is Nothing Then
    '        '        MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        '        Return False
    '        '    End If
    '        '    Me.InvMovAlmacenCab.IdTipoMovimiento = ConfigAlm(0).SxDevolucionCompra
    '        'End If
    '        ' Me.InvMovAlmacenCab.ValorMovimientoId = ""
    '        Me.InvMovAlmacenCab.IdTipoMovimiento = TipoMov ''ENTRADA POR COMPRA
    '        Me.InvMovAlmacenCab.CostoTotal = CDec(lblGranTotal.Text)
    '        Me.InvMovAlmacenCab.Origen = "AJUSTE DE INVENTARIO"
    '        Me.InvMovAlmacenCab.Referencia = ""
    '        Me.InvMovAlmacenCab.IdUsuarioAlta = Controlador.Sesion.Usrndx
    '        Me.InvMovAlmacenCab.EstatusContabilizado = 0

    '        Return True
    '        ' Me.InvMovAlmacenCab.FechaContabilizacion = ""
    '        'Me.InvMovAlmacenCab.PolizaContabilidad = ""
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False
    '    End Try
    'End Function


End Class