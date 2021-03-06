Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient
Imports ClasesNegocio
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio.AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum

Public Class frmSalidasDeMedicamento

#Region "Miembros Privados"

    Private Editar As Boolean = False
    Private selesccionado As Boolean = False
    Private seleccionar As Boolean = True
    Private listaProductos As New Dictionary(Of Integer, DataRow)
    Private mac As New AlmacenGeneral.MovimientoAlmacenClass
    Private madc As New AlmacenGeneral.MovimientoAlmacenDetalleCollectionClass
    Private mov As New ClasesNegocio.AlmacenGeneral.MovimientoAlmacenClass
    Private movCan As New ClasesNegocio.AlmacenGeneral.MovimientoAlmacenClass
    Private auxMovAlm As New ClasesNegocio.AlmacenGeneral.MovimientoAlmacenClass
    Private tablaDatos As New DataTable
    Private tablaDatos2 As New DataTable
    Private TiposDeAlmacenes As Integer

#End Region

#Region "Metodos"
    Private Sub DESHABILITAR()
        Me.txtPlaza.Enabled = False
        CmbPlaza.Enabled = False
        'TxtFolio.Enabled = False
        Me.txtAlmancen.Enabled = False
        CmbAlmacen.Enabled = False
        TxtEntrga.Enabled = False
        TxtRecibe.Enabled = False
        'DTPFecha.Enabled = False
        DataGrid.Enabled = False
        Me.txtObservaciones.Enabled = False
    End Sub

    Private Sub Limpiar()
        Me.txtPlaza.Clear()
        CmbPlaza.SelectedIndex = -1
        CmbPlaza.Text = "Seleccione Plaza"
        TxtFolio.Clear()
        Me.txtAlmancen.Clear()
        CmbAlmacen.SelectedIndex = -1
        CmbAlmacen.Text = "Seleccione Almacen"
        TxtEntrga.Clear()
        TxtRecibe.Clear()
        Me.DataGrid.Rows.Clear()
        DTPFecha.Value = Now
        Me.txtObservaciones.Clear()
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.Visible = False
    End Sub

    Private Sub HABILITAR()
        Me.txtPlaza.Enabled = True
        CmbPlaza.Enabled = True
        TxtFolio.Enabled = False
        Me.txtAlmancen.Enabled = True
        CmbAlmacen.Enabled = True
        TxtEntrga.Enabled = True
        TxtRecibe.Enabled = True
        DTPFecha.Enabled = False
        DataGrid.Enabled = True
        Me.txtObservaciones.Enabled = True
    End Sub

    Private Sub Escritura()
        Me.txtPlaza.Enabled = True
        Me.CmbPlaza.Enabled = True
        Me.CmbAlmacen.Enabled = True
        Me.txtAlmancen.Enabled = True
        Me.TxtEntrga.Enabled = True
        Me.TxtFolio.Enabled = True
        Me.TxtRecibe.Enabled = True
        Me.DataGrid.ReadOnly = False
        Me.CostoColumn.ReadOnly = False
        Me.ImporteColumn.ReadOnly = True
        Me.clmLote.ReadOnly = False
        Me.UMColumn.ReadOnly = True
        Me.txtObservaciones.Enabled = True
    End Sub

    Private Sub Lectura()
        Me.CmbPlaza.Enabled = False
        Me.CmbAlmacen.Enabled = False
        Me.TxtEntrga.Enabled = False
        Me.TxtFolio.Enabled = False
        Me.TxtRecibe.Enabled = False
        Me.TxtTotal.Enabled = False
        Me.DTPFecha.Enabled = False
        Me.DataGrid.ReadOnly = True
        Me.txtObservaciones.Enabled = True
    End Sub

    Private Sub ColumnaTextChange(ByVal sender As Object, ByVal e As EventArgs)
        'Guardo la referencia del control TextBox en edición
        'de la columna del grid para accesar a los metodos y propiedades
        'del TextBox
        Dim text As TextBox = sender

        If Not text.Text.Trim = "" AndAlso IsNumeric(text.Text) Then
            If Me.DataGrid.CurrentCell.ColumnIndex = Me.CódigoColumn.Index Then
                Me.ObtenerUnidadMedidaCostoImporte(text)
            ElseIf Me.DataGrid.CurrentCell.ColumnIndex = Me.CantidadColumn.Index Then
                Me.CalcularImporteCantidad(text)
            ElseIf Me.DataGrid.CurrentCell.ColumnIndex = Me.CostoColumn.Index Then
                Me.CalcularImporteXCosto(text)
            ElseIf Me.DataGrid.CurrentCell.ColumnIndex = Me.clmLote.Index Then
                Me.ObtenerCostoXLote(text)
            End If
        ElseIf Me.DataGrid.CurrentCell.ColumnIndex = Me.clmLote.Index Then
            Me.DataGrid.CurrentRow.Cells(Me.ImporteColumn.Index).Value = 0D.ToString() ' Aqui iva un "C2"
        End If
        Me.CalcularImporteTotal()
    End Sub

    Private Sub ObtenerUnidadMedidaCostoImporte(ByVal text As TextBox)
        'El codigo que proporcionado en el grid se pasa para buscar producto, costo, unidad de medida e importe
        'Se iguala el codigo de texto a un tipo numerico
        Dim codigo As Integer = CInt(text.Text)

        Me.DataGrid.CurrentRow.Cells(Me.clmProducto.Index).Value = codigo

        If Me.listaProductos.ContainsKey(codigo) Then
            Dim row As DataRow = Me.listaProductos(codigo)

            If row("PdSeManejaPorLotes") Then
                Dim lote As String
                If IsNothing(Me.DataGrid.CurrentRow.Cells(Me.clmLote.Index).Value) Then
                    lote = ""
                Else
                    lote = Me.DataGrid.CurrentRow.Cells(Me.clmLote.Index).Value.ToString().Trim
                End If

                If Not lote = "" Then
                    Dim invlote As New AlmacenGeneral.InventarioAlmacenLoteClass
                    If invlote.Obtener(codigo, Me.CmbAlmacen.SelectedValue, lote) Then
                        'Me.DataGrid.CurrentRow.Cells(Me.CostoColumn.Index).Value = invlote.CostoPromedio
                        Me.DataGrid.CurrentRow.Cells(Me.UMColumn.Index).Value = row("UMDescCorta")
                        Me.DataGrid.CurrentRow.Cells(Me.ImporteColumn.Index).Value = CDec((Me.DataGrid.CurrentRow.Cells(Me.CantidadColumn.Index).Value) * invlote.CostoPromedio)
                        Me.DataGrid.CurrentRow.ErrorText = ""
                    End If
                Else
                    'Me.DataGrid.CurrentRow.Cells(Me.CostoColumn.Index).Value = 0D
                    Me.DataGrid.CurrentRow.Cells(Me.ImporteColumn.Index).Value = 0D
                    Me.DataGrid.CurrentRow.ErrorText = "El producto no se encuentra en el lote especificado"
                End If

                'Me.DataGrid.CurrentRow.Cells(Me.clmLote.Index).ReadOnly = False
            Else
                'Captura los que no tienen lote
                Dim invAlm As New AlmacenGeneral.InventarioAlmacenClass
                If invAlm.Obtener(codigo, Me.CmbAlmacen.SelectedValue) Then
                    'Me.DataGrid.CurrentRow.Cells(Me.CostoColumn.Index).Value = invAlm.CostoPromedio
                    Me.DataGrid.CurrentRow.Cells(Me.UMColumn.Index).Value = row("UMDescCorta")
                    Me.DataGrid.CurrentRow.Cells(Me.ImporteColumn.Index).Value = CDec((Me.DataGrid.CurrentRow.Cells(Me.CantidadColumn.Index).Value) * invAlm.CostoPromedio)
                    Me.DataGrid.CurrentRow.ErrorText = ""
                Else
                    Me.DataGrid.CurrentRow.ErrorText = "El producto no esta registrado en almacen"
                    Me.DataGrid.CurrentRow.Cells(Me.UMColumn.Index).Value = ""
                    Me.DataGrid.CurrentRow.Cells(Me.clmProducto.Index).Value = -1
                    'Me.DataGrid.CurrentRow.Cells(Me.CostoColumn.Index).Value = 0D
                    Me.DataGrid.CurrentRow.Cells(Me.ImporteColumn.Index).Value = 0D
                End If
                'Me.DataGrid.CurrentRow.Cells(Me.clmLote.Index).ReadOnly = True
                Me.DataGrid.CurrentRow.Cells(Me.clmLote.Index).Value = ""
            End If
        Else
            Me.DataGrid.CurrentRow.Cells(Me.UMColumn.Index).Value = ""
            Me.DataGrid.CurrentRow.Cells(Me.clmProducto.Index).Value = -1
            Me.DataGrid.CurrentRow.Cells(Me.CostoColumn.Index).Value = 0D
            Me.DataGrid.CurrentRow.Cells(Me.ImporteColumn.Index).Value = 0D
            Me.DataGrid.CurrentRow.Cells(Me.clmLote.Index).ReadOnly = True
            Me.DataGrid.CurrentRow.Cells(Me.clmLote.Index).Value = ""
        End If
    End Sub

    Private Sub CalcularImporteCantidad(ByVal text As TextBox)
        'valido si el valor de la celda que contiene la cantidad de producto
        'tiene un valor numerico
        If IsNumeric(Me.DataGrid.CurrentRow.Cells(Me.CostoColumn.Index).Value) Then
            'obtengo la cantidad de producto que se le dara salida, el costo y calculo el importe
            Dim Cantidad As Decimal = CDec(text.Text)
            Dim costo As Decimal = CDec(Me.DataGrid.CurrentRow.Cells(Me.CostoColumn.Index).Value)
            Dim importe As Decimal = costo * Cantidad

            'asigno el importe a la celda que co
            Me.DataGrid.CurrentRow.Cells(Me.ImporteColumn.Index).Value = importe.ToString("C2") '****Porque c2?***
        Else
            'en caso que no haya una cantidad ingresada se le asigna el valor de 0
            'a la celda de importe
            Me.DataGrid.CurrentRow.Cells(Me.ImporteColumn.Index).Value = 0D.ToString("C2") '**Porque c2?***
        End If
    End Sub

    Private Sub CalcularImporteXCosto(ByVal text As TextBox)
        'valido si el valor de la celda que contiene la cantidad de producto
        'tiene un valor numerico
        If IsNumeric(Me.DataGrid.CurrentRow.Cells(Me.CantidadColumn.Index).Value) Then
            'obtengo la cantidad de producto que se le dara salida, el costo y calculo el importe
            Dim costo As Decimal = CDec(text.Text)
            Dim cantidad As Decimal = CDec(Me.DataGrid.CurrentRow.Cells(Me.CantidadColumn.Index).Value)
            Dim importe As Decimal = costo * cantidad

            'asigno el importe a la celda que co
            Me.DataGrid.CurrentRow.Cells(Me.ImporteColumn.Index).Value = importe.ToString("C2")
        Else
            'en caso que no haya una cantidad ingresada se le asigna el valor de 0
            'a la celda de importe
            Me.DataGrid.CurrentRow.Cells(Me.ImporteColumn.Index).Value = 0D.ToString("C2")
        End If
    End Sub

    Private Sub ObtenerCostoXLote(ByVal text As TextBox)
        Dim lote As String
        'obtengo el código de producto ingresado
        Dim codigo As Integer = Me.DataGrid.CurrentRow.Cells(Me.CódigoColumn.Index).Value
        Dim row As DataRow = Me.listaProductos(codigo)

        lote = text.Text.Trim

        If Not lote = "" Then
            Dim invlote As New AlmacenGeneral.InventarioAlmacenLoteClass

            If invlote.Obtener(Me.CmbAlmacen.SelectedValue, codigo, lote) Then
                'Me.DataGrid.CurrentRow.Cells(Me.CostoColumn.Index).Value = invlote.CostoPromedio
                'me.DataGrid.CurrentRow.Cells(me.CostoColumn.Index).Value=0d
                'Asigno la unidad de medida que utiliza el producto en la celda que la muestra
                Me.DataGrid.CurrentRow.Cells(Me.UMColumn.Index).Value = row("UMDescCorta")
                Me.DataGrid.CurrentRow.Cells(Me.ImporteColumn.Index).Value = _
                            CDec(Me.DataGrid.CurrentRow.Cells(Me.CantidadColumn.Index).Value) * _
                            invlote.CostoPromedio
                Me.DataGrid.CurrentRow.ErrorText = ""
            Else
                Me.DataGrid.CurrentRow.ErrorText = "El lote no existe"
                Me.DataGrid.CurrentRow.Cells(Me.CostoColumn.Index).Value = 0D
                Me.DataGrid.CurrentRow.Cells(Me.ImporteColumn.Index).Value = 0D
            End If
        Else
            Me.DataGrid.CurrentRow.ErrorText = "Debe ingresar un lote"
            Me.DataGrid.CurrentRow.Cells(Me.CostoColumn.Index).Value = 0D
            Me.DataGrid.CurrentRow.Cells(Me.ImporteColumn.Index).Value = 0D
        End If
    End Sub

    Private Sub CalcularImporteTotal()
        Dim productosAgregados As New Dictionary(Of Integer, Boolean)
        Dim numProductos As Integer = 0
        Dim sumImporte As Decimal = 0D
        Dim importe As Decimal = 0D
        Dim sumIva As Decimal = 0D
        Dim iva As Decimal = 0D
        Dim producto As New ProductoClass

        For Each row As DataGridViewRow In Me.DataGrid.Rows
            If row.Index = Me.DataGrid.Rows.Count - 1 OrElse row.Cells(Me.CódigoColumn.Index).Value Is Nothing _
                OrElse row.Cells(Me.CódigoColumn.Index).Value.ToString().Trim = "" Then Continue For

            producto.Obtener(row.Cells(Me.CódigoColumn.Index).Value)

            If Not productosAgregados.ContainsKey(row.Cells(Me.CódigoColumn.Index).Value) Then
                numProductos += 1
            End If

            importe = CDec(row.Cells(Me.ImporteColumn.Index).Value)
            sumImporte = sumImporte + CDec(row.Cells(Me.ImporteColumn.Index).Value)
            If producto.SeAplicaIva Then iva = importe * Controlador.ObtenerIVA Else iva = 0D
            sumIva = sumIva + iva
        Next
        Dim auxiliar As Decimal = 0D
        'Me.TxtTotal.Text = sumImporte.ToString("C2") 'Aqui iva un "C2"
        auxiliar = sumImporte
        Me.TxtTotal.Text = auxiliar.ToString("C2")
        'Me.transferencia.Importe = sumImporte
        'Me.transferencia.TotalProductos = numProductos
        'Me.transferencia.Importe = Me.transferencia.Importe
    End Sub

    Private Sub ObtenerDatos()

        Me.CalcularImporteTotal()
        With mac
            .Contabilizado = AlmacenGeneral.MovimientoAlmacenClass.MovimientoAlmacenEstatus.VIGENTE
            .Entregar = Me.TxtEntrga.Text
            .FechaMovimiento = Me.DTPFecha.Value
            .IdAlmacen = Me.CmbAlmacen.SelectedValue
            .IdUsuarioAlta = Controlador.Sesion.Usrndx
            .Recibe = Me.TxtRecibe.Text
            .TipoMovimientos = AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Aplicacion_Medicamento
            '.EstatusContabilizado = 0
            .Observaciones = Me.txtObservaciones.Text
            .Origen = "Salida de Medicamento"


            For Each row As DataGridViewRow In Me.DataGrid.Rows
                If row.Index = Me.DataGrid.Rows.Count - 1 Then Continue For
                mac.Detalle.Add(mac, row.Index + 1, row.Cells(Me.CódigoColumn.Index).Value, _
                                Me.DTPFecha.Value, row.Cells(Me.CantidadColumn.Index).Value, _
                                row.Cells(Me.CostoColumn.Index).Value, 0D, _
                                row.Cells(Me.clmLote.Index).Value, New Nullable(Of Date))
                mac.CostoTotal = row.Cells(Me.ImporteColumn.Index).Value

            Next
            'mac.CostoTotal = CDec(Me.TxtTotal.Text)
        End With
    End Sub

    Public Sub Imprimir(ByVal empresa As String, ByVal usuario As String)
        Try
            Dim OtraSalidaImprimir As New AlmacenGeneral.MovimientoAlmacenCollectionClass

            OtraSalidaImprimir.Add(mac)

            OtraSalidaImprimir.ImprimirSalida(empresa, usuario)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub PonerDatosBusqueda()
        Me.txtPlaza.Text = movCan.Almacen.Plaza.Codigo
        'Me.CmbPlaza.SelectedText = movCan.Almacen.Plaza.Descripcion
        Me.TxtFolio.Text = movCan.Referencia
        Me.DTPFecha.Text = mov.FechaMovimiento.Date
        Me.CmbAlmacen.SelectedValue = movCan.Almacen.Codigo
        Me.txtAlmancen.Text = movCan.Almacen.Codigo
        Me.TxtEntrga.Text = movCan.Entregar
        Me.TxtRecibe.Text = movCan.Recibe
        Me.lblEstatus.Text = movCan.Contabilizado.ToString
        Me.lblEstatus.Visible = True

        Me.DataGrid.Rows.Clear()
        Me.DataGrid.Rows.Add(Me.movCan.Detalle.Count)
        Dim fila As Integer = 0

        For Each det As AlmacenGeneral.MovimientoAlmacenDetalleClass In movCan.Detalle
            With Me.DataGrid.Rows(fila)
                .Cells(Me.CódigoColumn.Index).Value = det.IdProducto
                .Cells(Me.clmProducto.Index).Value = det.IdProducto
                .Cells(Me.clmLote.Index).Value = det.Lote
                .Cells(Me.CantidadColumn.Index).Value = det.Cantidad
                .Cells(Me.CostoColumn.Index).Value = det.Costo
                .Cells(Me.ImporteColumn.Index).Value = det.Improte
                .Cells(Me.UMColumn.Index).Value = det.Producto.UnidadMedida
            End With
            fila += 1
        Next
        Me.CalcularImporteTotal()
    End Sub

    Private Sub ActualizarPlaza(ByVal Plaza As PlazaClass)
        Dim Plazas As New PlazaCollectionClass, Familias As New LineaCollectionClass

        Plazas.Add(Plaza)
        Familias.Add(Controlador.Configuracion.Engorda.FamiliaMedicamentos)
        Controlador.LlenarComboAlmacenesConInventarioDeProductosGenerales(CmbAlmacen, Plazas, Familias)
    End Sub

#End Region

#Region "ToolBar"
    Private Sub mtb_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickCancelar
        Limpiar()
        DESHABILITAR()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        If Me.selesccionado Then
            Limpiar()
        Else
            Limpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickNuevo
        Try
            Cursor = Cursors.WaitCursor
            Me.PlazaCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            Escritura()
            Limpiar()
            HABILITAR()
            Editar = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            Me.mac = New AlmacenGeneral.MovimientoAlmacenClass
            Me.DataGrid.Rows(0).Cells(Me.ImporteColumn.Index).Selected = True
            Me.ObtenerDatos()

            If Me.mac.Guardar Then
                Me.Limpiar()
                Me.Lectura()
                MsgBox("La Salida se realizo con exito", MsgBoxStyle.Information, "Aviso")
                Me.Imprimir(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnom)
                Me.DESHABILITAR()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            Dim movCol As New CC.InventarioMovimientoAlmacenCollection

            If Not movCol.GetDbCount(HC.InventarioMovimientoAlmacenFields.Referencia = Me.TxtFolio.Text) > 0 Then
                If Me.movCan.Guardar Then
                    Me.Limpiar()
                    Me.Lectura()
                    MsgBox("El Borrado se ha realizado con exito", MsgBoxStyle.Information, "Aviso")
                    Me.DESHABILITAR()
                Else
                    MsgBox("El Borrado no se puede llevar acabo, porque una o mas salidas afectan el costo final del producto", MsgBoxStyle.Information, "Avisar")
                    Cancelar = True
                End If
            Else
                MsgBox("El movimiento ya ha sido cancelado", MsgBoxStyle.Information, "Aviso")
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Try
            Dim ventana As New frmBusquedaMovimientoAlmacen
            Me.Limpiar()
            Me.movCan = New AlmacenGeneral.MovimientoAlmacenClass
            'ventana.EstablecerTipoMovimiento(
            'ventana.EstablecerTipoMovimiento(frmBusquedaMovimientoAlmacen.DireccionFiltrada.Salidas, False)
            'ventana.EstablecerTipoMovimiento(frmBusquedaMovimientoAlmacen.DireccionFiltrada.Entradas, False)
            ventana.EstablecerTipoMovimiento(Salidas_X_Aplicacion_Medicamento, True)


            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                mov = ventana.MovimientoAlmacen
                With movCan
                    .Referencia = mov.FolioMovimientoAlmacen
                    .TipoMovimientos = Entradas_X_Cancelacion_Aplicacion_Medicamento
                    .Entregar = mov.Entregar
                    .Recibe = ""
                    .EstatusContabilizado = 0
                    .FechaMovimiento = Now
                    .IdAlmacen = mov.IdAlmacen
                    .IdUsuarioAlta = Controlador.Sesion.Usrndx
                    .Contabilizado = AlmacenGeneral.MovimientoAlmacenClass.MovimientoAlmacenEstatus.VIGENTE
                    '.Observaciones=me.
                    .Origen = "Salida Medicamento"
                End With

                For Each det As ClasesNegocio.AlmacenGeneral.MovimientoAlmacenDetalleClass In mov.Detalle
                    With det
                        movCan.Detalle.Add(movCan, .Indice, .IdProducto, Now, .Cantidad, _
                                            .Costo, .Descuento, .Lote, .FechaCaducidad)
                    End With
                Next

                Me.PonerDatosBusqueda()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub
#End Region

#Region "TextChange"

    Private Sub CmbPlaza_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPlaza.SelectionChangeCommitted
        If CmbPlaza.SelectedItem IsNot Nothing Then
            RemoveHandler txtPlaza.TextChanged, AddressOf txtPlaza_TextChanged
            txtPlaza.Text = CmbPlaza.SelectedValue.ToString
            AddHandler txtPlaza.TextChanged, AddressOf txtPlaza_TextChanged

            ActualizarPlaza(CType(CmbPlaza.SelectedItem, PlazaClass))
        End If
    End Sub

    Private Sub ActualizarAlmacen()
        Me.clmProducto.DataSource = Controlador.ObtenerMedicamentosConExistencia(CType(CmbAlmacen.SelectedItem, AlmacenClass))
        Me.clmProducto.DisplayMember = "Descripcion"
        Me.clmProducto.ValueMember = "Codigo"
        Me.clmProducto.AutoComplete = True
    End Sub

    Private Sub CmbAlmacen_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAlmacen.SelectionChangeCommitted
        Try
            If Me.CmbAlmacen.SelectedItem IsNot Nothing Then
                RemoveHandler txtAlmancen.TextChanged, AddressOf txtAlmancen_TextChanged
                Me.txtAlmancen.Text = Me.CmbAlmacen.SelectedValue.ToString
                AddHandler txtAlmancen.TextChanged, AddressOf txtAlmancen_TextChanged

                ActualizarAlmacen()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtAlmancen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlmancen.TextChanged
        Try
            If IsNumeric(Me.txtAlmancen.Text) Then
                Me.CmbAlmacen.SelectedValue = CInt(Me.txtAlmancen.Text)

                If CmbAlmacen.SelectedItem IsNot Nothing Then
                    ActualizarAlmacen()
                End If
            Else
                Me.CmbAlmacen.SelectedIndex = -1
                Me.CmbAlmacen.Text = "Seleccione el Almacen"
                clmProducto.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ")
        End Try
    End Sub

#End Region

#Region "datagrid"
    Private Sub DataGrid_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGrid.DataError

    End Sub

    Private Sub DataGrid_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGrid.EditingControlShowing
        Try
            Dim combo As ComboBox = Nothing

            RemoveHandler e.Control.KeyPress, AddressOf ColumnaIntegerKeyPress
            RemoveHandler e.Control.KeyPress, AddressOf ColumnaDecimalKeyPress
            RemoveHandler e.Control.LostFocus, AddressOf ColumnaLostFocus
            RemoveHandler e.Control.TextChanged, AddressOf ColumnaTextChange

            If e.Control.GetType.ToString = "System.Windows.Forms.DataGridViewComboBoxEditingControl" Then
                combo = e.Control
                RemoveHandler combo.SelectedIndexChanged, AddressOf ColumnaSelectedIndexChanged
            End If
            If Me.DataGrid.CurrentCell.ColumnIndex = Me.CódigoColumn.Index Then
                AddHandler e.Control.KeyPress, AddressOf ColumnaIntegerKeyPress
                AddHandler e.Control.TextChanged, AddressOf ColumnaTextChange
            ElseIf Me.DataGrid.CurrentCell.ColumnIndex = Me.CantidadColumn.Index OrElse _
                    Me.DataGrid.CurrentCell.ColumnIndex = Me.CostoColumn.Index Then
                AddHandler e.Control.KeyPress, AddressOf ColumnaDecimalKeyPress
                AddHandler e.Control.TextChanged, AddressOf ColumnaTextChange
            ElseIf Me.DataGrid.CurrentCell.ColumnIndex = Me.clmProducto.Index Then
                AddHandler combo.SelectedIndexChanged, AddressOf ColumnaSelectedIndexChanged
                AddHandler e.Control.LostFocus, AddressOf ColumnaLostFocus
            ElseIf Me.DataGrid.CurrentCell.ColumnIndex = Me.clmLote.Index Then
                AddHandler e.Control.TextChanged, AddressOf ColumnaTextChange
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en DataGrid_EditingControlShowing")
        End Try
    End Sub

    Private Sub DataGrid_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles DataGrid.PreviewKeyDown
        If e.KeyCode = Keys.F3 Then

            'If Me.DataGrid.ReadOnly Then Exit Sub

            'Dim ventana As New SistemaAgrosCS.Catalogos.Generales.ListaProdRegfrm

            'If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
            '    If ventana.ProductosSeleccionados.Count > 0 Then
            '        Dim codigoProducto As Integer = ventana.ProductosSeleccionados(0).Codigo
            '        'Me.clmProducto.DisplayMember = Me.ProductoCollectionClass1.Obtener(CondicionEnum.ACTIVOS)
            '        'Me.ProductoCollectionClass1.Obtener(CondicionEnum.ACTIVOS)
            '        Me.DataGrid.CurrentRow.Cells(Me.clmProducto.Index).Value = -1
            '        Me.DataGrid.CurrentRow.Cells(Me.clmProducto.Index).Value = "Seleccione un producto..."
            '        If Me.DataGrid.CurrentRow.Index = Me.DataGrid.Rows.Count - 1 Then
            '            Me.DataGrid.Rows.Add(1)

            '            Dim row As DataGridViewRow = Me.DataGrid.Rows(Me.DataGrid.Rows.Count - 2)

            '            row.Cells(Me.CódigoColumn.Index).Value = codigoProducto
            '            row.Cells(Me.clmProducto.Index).Value = codigoProducto
            '        End If
            '    End If
            'End If
        ElseIf e.KeyCode = Keys.Delete Then
            If Not Me.DataGrid.CurrentRow.Index = Me.DataGrid.Rows.Count - 1 Then
                If MessageBox.Show("¿Quiere quitar el producto de la Salida", "Quitar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Me.DataGrid.Rows.Remove(Me.DataGrid.CurrentRow)
                End If
            End If
        End If
    End Sub

    Private Sub DataGrid_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid.SelectionChanged
        If Not Me.seleccionar Then Exit Sub

        For Each row As DataGridViewRow In Me.DataGrid.Rows
            If row.Index = Me.DataGrid.Rows.Count - 1 Then Continue For

            If Not row.ErrorText.Trim = "" OrElse Not IsNumeric(row.Cells(Me.CantidadColumn.Index).Value) OrElse _
                    Not CDec(row.Cells(Me.CantidadColumn.Index).Value) > 0D Then
                Me.seleccionar = False
                row.Cells(Me.DataGrid.CurrentCell.ColumnIndex).Selected = True
                Me.seleccionar = True
                Exit Sub
            End If
        Next
    End Sub

    'Private Sub DataGrid_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellEnter
    '    Dim combo As ComboBox = sender
    '    'Dim row As DataRowView = DirectCast(combo.SelectedItem, DataRowView)
    '    'Dim utilizaLotes As Boolean = row("PdSeManejaPorLotes")
    '    If Me.DataGrid.CurrentRow.Cells(Me.CódigoColumn.Index).Value = 0 Then
    '        Me.clmLote.ReadOnly = True
    '    Else
    '        Me.clmLote.ReadOnly = False
    '    End If
    'End Sub
#End Region

#Region "PrevieKeyDown"

    Private Sub CmbPlaza_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbPlaza.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.PlazaCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.CmbPlaza.SelectedIndex = -1
                'Me.CmbPlaza.Text = "Seleccione una plaza"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ")
        End Try
    End Sub

    Private Sub CmbAlmacen_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbAlmacen.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                If CmbPlaza.SelectedItem IsNot Nothing Then
                    ActualizarPlaza(CType(CmbPlaza.SelectedItem, PlazaClass))
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error CmbAlmacen_PreviewKeyDown")
        End Try
    End Sub

#End Region

#Region "Columnas"
    Private Sub ColumnaLostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'guarda la referencia e el control ComboBox con el que 
        'se esta editando la columna clmDescripcion del grid
        'para poder accesar a los eventos que un ComboBox tiene
        Dim combo As ComboBox = sender

        'quito los redireccionamientos que el control podria tener 
        'a los metodos ColumnaLostFocus y ColumnaSelectedIndexChanged
        'para eviar que un control en edicion no deseado del grid 
        'se redireccione a ellos
        RemoveHandler combo.LostFocus, AddressOf ColumnaLostFocus
        RemoveHandler combo.SelectedIndexChanged, AddressOf ColumnaSelectedIndexChanged
    End Sub

    Private Sub ColumnaSelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim combo As ComboBox = sender

            If combo.SelectedIndex > -1 Then
                Dim Producto As ProductoGeneralClass = DirectCast(combo.SelectedItem, ProductoGeneralClass)
                Dim utilizaLotes As Boolean = Producto.SeManejaPorLotes
                Me.DataGrid.CurrentRow.Cells(Me.CódigoColumn.Index).Value = combo.SelectedValue
                Dim codigo As Integer = Me.DataGrid.CurrentRow.Cells(Me.CódigoColumn.Index).Value

                If utilizaLotes Then
                    'If Not Me.DataGrid.CurrentRow.Cells(Me.CódigoColumn.Index).Value = 0 Then
                    Me.DataGrid.CurrentRow.Cells(Me.clmLote.Index).ReadOnly = False
                    Dim lote As String
                    Me.clmLote.ReadOnly = False
                    If IsNothing(Me.DataGrid.CurrentRow.Cells(Me.clmLote.Index).Value) Then
                        lote = ""
                    Else
                        lote = Me.DataGrid.CurrentRow.Cells(Me.clmLote.Index).Value.ToString.Trim
                    End If

                    If Not lote = "" Then
                        Dim invlote As New AlmacenGeneral.InventarioAlmacenLoteClass

                        Me.clmLote.ReadOnly = False

                        If invlote.Obtener(codigo, Me.CmbAlmacen.SelectedValue, lote) Then
                            'Me.DataGrid.CurrentRow.Cells(Me.CostoColumn.Index).Value = invlote.CostoPromedio
                            Me.DataGrid.CurrentRow.Cells(Me.UMColumn.Index).Value = Producto.UnidadMedida.DescCorta
                            Me.DataGrid.CurrentRow.Cells(Me.ImporteColumn.Index).Value = 0D
                            'Me.DataGrid.CurrentRow.Cells(Me.CódigoColumn.Index).Value = codigo
                            Me.DataGrid.CurrentRow.ErrorText = ""
                        Else
                            Me.DataGrid.CurrentRow.ErrorText = "El producto no esta registrado con ese lote"
                            Me.DataGrid.CurrentRow.Cells(Me.UMColumn.Index).Value = ""
                            Me.DataGrid.CurrentRow.Cells(Me.ImporteColumn.Index).Value = 0D
                            'Me.DataGrid.CurrentRow.Cells(Me.CódigoColumn.Index).Value = combo.SelectedValue
                            'Me.DataGrid.CurrentRow.Cells(Me.CostoColumn.Index).Value = 0D
                        End If
                    Else
                        'Me.DataGrid.CurrentRow.Cells(Me.CódigoColumn.Index).Value = combo.SelectedValue
                        Me.DataGrid.CurrentRow.Cells(Me.ImporteColumn.Index).Value = 0D
                        Me.DataGrid.CurrentRow.Cells(Me.UMColumn.Index).Value = Producto.UnidadMedida.DescCorta
                        Me.clmLote.ReadOnly = True
                        Me.DataGrid.CurrentRow.ErrorText = "No a ingresado un lote"
                        '                    Me.DataGrid.CurrentRow.Cells(Me.CostoColumn.Index).Value = 0D
                    End If
                Else
                    'Me.DataGrid.CurrentRow.Cells(Me.CódigoColumn.Index).Selected = True
                    Dim inv As New AlmacenGeneral.InventarioAlmacenClass

                    Me.clmLote.ReadOnly = True

                    If inv.Obtener(codigo, Me.CmbAlmacen.SelectedValue) Then
                        Me.DataGrid.CurrentRow.Cells(Me.CostoColumn.Index).Value = inv.CostoPromedio
                        Me.DataGrid.CurrentRow.Cells(Me.UMColumn.Index).Value = Producto.UnidadMedida.DescCorta
                        Me.DataGrid.CurrentRow.Cells(Me.ImporteColumn.Index).Value = 0D
                        'Me.DataGrid.CurrentRow.Cells(Me.CódigoColumn.Index).Value = codigo
                        Me.DataGrid.CurrentRow.ErrorText = ""
                    Else
                        Me.DataGrid.CurrentRow.ErrorText = "El producto no esta registrado en este alamcén"
                        Me.DataGrid.CurrentRow.Cells(Me.UMColumn.Index).Value = ""
                        Me.DataGrid.CurrentRow.Cells(Me.ImporteColumn.Index).Value = 0D
                        'Me.DataGrid.CurrentRow.Cells(Me.CódigoColumn.Index).Value = ""
                    End If

                    Me.DataGrid.CurrentRow.Cells(Me.clmLote.Index).ReadOnly = True
                    Me.DataGrid.CurrentRow.Cells(Me.clmLote.Index).Value = ""
                End If
                'End If
                Me.DataGrid.CurrentRow.Cells(Me.UMColumn.Index).Value = Producto.UnidadMedida.DescCorta
                'Me.DataGrid.EndEdit()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ")
        End Try
    End Sub

    Private Sub ColumnaIntegerKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ColumnaDecimalKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) AndAlso Not e.KeyChar = "."c) OrElse _
            (e.KeyChar = "."c AndAlso sender.text.indexof("."c) > -1) Then
            e.Handled = True
        End If
    End Sub
#End Region

    Private Sub CatAlmRegOtraSalidaAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mtb.Enabled = False

            If Not Controlador.Configuracion.Engorda.IdFamiliaMedicamento.HasValue Then
                Throw New Exception("Configuracion de Engorda: No se ha establecido aun la Familia de Medicamentos, debera establecerla previamente para continuar con el proceso")
            End If
            mtb.Enabled = True

            'Barra de botones de la ToolBar...
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            MtbEstados.StateBuscar = "110101111"
            MtbEstados.StateLimpiar = "000100011"
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "110100001"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010000"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")
            DESHABILITAR()

            Me.TxtFolio.Enabled = False
            Me.DTPFecha.Enabled = False
            Me.PlazaCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtPlaza_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlaza.TextChanged
        If IsNumeric(txtPlaza.Text) Then
            CmbPlaza.SelectedValue = Integer.Parse(txtPlaza.Text)

            If CmbPlaza.SelectedItem IsNot Nothing Then
                ActualizarPlaza(CType(CmbPlaza.SelectedItem, PlazaClass))
            End If
        Else
            CmbPlaza.SelectedIndex = -1
            CmbPlaza.Text = "Seleccione la Plaza"
            CmbAlmacen.DataSource = Nothing
            CmbAlmacen.Text = ""
        End If
    End Sub
End Class