Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio.AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum
Imports ClasesNegocio
Imports System.Data.SqlClient

Public Class frmProrrateoMedicamento
    Private prorrateo As ProrrateoMedicamentoClass
    Private seleccionandoFila As Boolean = False

    Private Sub Limpiar()
        Me.txtFolio.Clear()
        Me.txtSalidaAlmacen.Clear()
        Me.dtFecha.Value = Now
        Me.dgDetalle.DataSource = Nothing
    End Sub

    Private Sub Deshabilitar()
        Me.dtFecha.Enabled = False
        Me.txtSalidaAlmacen.Enabled = False
        Me.btnBuscarSalidaMedicamento.Enabled = False
        Me.dgDetalle.ReadOnly = True
    End Sub

    Private Sub Habilitar()
        Me.dtFecha.Enabled = True
        Me.txtSalidaAlmacen.Enabled = True
        Me.btnBuscarSalidaMedicamento.Enabled = True
        Me.dgDetalle.ReadOnly = False
        For Each col As DataGridViewColumn In Me.dgDetalle.Columns
            col.ReadOnly = True
        Next

        Me.IdMedicamentoDataGridViewTextBoxColumn.ReadOnly = False
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = False
    End Sub

    Private Sub BuscarMedicamentos(ByVal folioMovimiento As String)
        Dim sqlcon As New SqlConnection(HC.DbUtils.ActualConnectionString)

        Try
            If Me.prorrateo.MovimientoAlmacenSalida.FolioMovimientoAlmacen = "" Then
                MsgBox("Debe establecer primero una salida de almacén", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If

            Dim cadenaConsulta As String = _
                    "SELECT MCatCompProductos.PdIdProducto, MCatCompProductos.PdDescripcion, " & _
                    "       CabMediReim.Boo_XCab, CabMediReim.Unidades, CabMediReim.UniXKilo, CabMediReim.Boo_XKilo, " & _
                    "       @EsReimplante AS EsReimplante " & _
                    "FROM   MCatCompProductos " & _
                    "       INNER JOIN CabMediReim ON MCatCompProductos.PdIdProducto = CabMediReim.Cve_Medi " & _
                    "WHERE	MCatCompProductos.PdIdProducto IN (SELECT	ProductoId " & _
                    "                                          FROM     dbo.MInvMovimientosAlmacenDetalles " & _
                    "		 							       WHERE	dbo.MInvMovimientosAlmacenDetalles.FolioMovimiento=@FolioMovimiento)"
            Dim sqlCom As New SqlClient.SqlCommand(cadenaConsulta, sqlcon)
            Dim sqlDa As New SqlDataAdapter(sqlCom)
            Dim productos As New DataTable

            sqlCom.CommandText &= " Union " & sqlCom.CommandText.Replace("CabMediReim", "CabMediTrab").Replace("@EsReimplante", "@EsTrabajo")
            sqlCom.Parameters.Add("@EsReimplante", SqlDbType.Bit).Value = True
            sqlCom.Parameters.Add("@EsTrabajo", SqlDbType.Bit).Value = False
            sqlCom.Parameters.Add("@FolioMovimiento", SqlDbType.VarChar, 20).Value = folioMovimiento

            sqlDa.Fill(productos)

            Me.IdMedicamentoDataGridViewTextBoxColumn.DataSource = productos
            Me.IdMedicamentoDataGridViewTextBoxColumn.DisplayMember = "PdDescripcion"
            Me.IdMedicamentoDataGridViewTextBoxColumn.ValueMember = "PdIdProducto"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmProrrateoMedicamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "101101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100001"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100001"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "0010100001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")

            Limpiar()
            Deshabilitar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnBuscarSalidaMedicamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarSalidaMedicamento.Click
        Try
            Dim ventanaMovimientos As New frmBusquedaMovimientoAlmacen

            'ventanaMovimientos.EstablecerTipoMovimiento(Entradas, False)
            'ventanaMovimientos.EstablecerTipoMovimiento(Salidas, False)
            ventanaMovimientos.EstablecerTipoMovimiento(Salidas_X_Aplicacion_Medicamento, True)

            If ventanaMovimientos.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtSalidaAlmacen.Text = ventanaMovimientos.MovimientoAlmacen.FolioMovimientoAlmacen
                Me.prorrateo.MovimientoAlmacenSalida = ventanaMovimientos.MovimientoAlmacen
                Me.BuscarMedicamentos(Me.prorrateo.FolioMovimeintoSalida)
                Me.prorrateo.FechaProrrate = Me.dtFecha.Value
                Me.dgDetalle.AutoGenerateColumns = False
                Me.dgDetalle.DataSource = Me.prorrateo.Detalle
            Else
                Me.txtSalidaAlmacen.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgDetalle_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDetalle.CellEndEdit
        Me.dgDetalle.Refresh()

        Try
            Dim medicamentoSeleccionado As Integer = CInt(Me.dgDetalle(Me.IdMedicamentoDataGridViewTextBoxColumn.Index, e.RowIndex).Value)

            For i As Integer = 0 To Me.dgDetalle.Rows.Count - 2
                If i = e.RowIndex Then Continue For

                If CInt(Me.dgDetalle(Me.IdMedicamentoDataGridViewTextBoxColumn.Index, i).Value) = medicamentoSeleccionado Then
                    MsgBox("El medicamento ya se encuentra en la lista", MsgBoxStyle.Exclamation, "Aviso")
                    Me.dgDetalle.Rows.RemoveAt(e.RowIndex)
                    Exit Sub
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Cursor = Cursors.WaitCursor

        Try
            Dim ventana As New frmBusquedaProrrateMedicamento

            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Limpiar()
                Me.prorrateo = ventana.ProrrateoMedicamento
                Me.txtFolio.Text = Me.prorrateo.FolioProrrateo
                Me.txtSalidaAlmacen.Text = Me.prorrateo.FolioMovimeintoSalida
                Me.dtFecha.Value = Me.prorrateo.FechaProrrate
                Me.dgDetalle.AutoGenerateColumns = False
                Me.dgDetalle.DataSource = Me.prorrateo.Detalle
                Me.BuscarMedicamentos(prorrateo.FolioMovimeintoSalida)
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Me.Limpiar()
        Me.Deshabilitar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Cursor = Cursors.WaitCursor

        Try
            If Me.dgDetalle.Rows.Count = 1 Then
                MsgBox("Debe ingresar un medicamento", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            Else
                Me.dgDetalle(0, 0).Selected = True
            End If

            Me.prorrateo.IdUsuarioAlta = Controlador.Sesion.Usrndx
            Me.prorrateo.FechaProrrate = Me.dtFecha.Value

            If Me.prorrateo.Guardar Then
                MsgBox("Se guardo con el Folio: " & Me.prorrateo.FolioProrrateo, MsgBoxStyle.Information, "Aviso")
                Me.Limpiar()
                Me.Deshabilitar()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Try
            Me.prorrateo = New ProrrateoMedicamentoClass
            Me.Limpiar()
            Me.Habilitar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub dgDetalle_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgDetalle.SelectionChanged
        If Me.seleccionandoFila OrElse Me.dgDetalle.CurrentRow Is Nothing Then Exit Sub

        Try
            Dim filaSeleccionada As Integer = Me.dgDetalle.CurrentRow.Index

            Me.seleccionandoFila = True

            For Each row As DataGridViewRow In Me.dgDetalle.Rows
                If row.Index = filaSeleccionada OrElse Me.dgDetalle.Rows.Count - 1 = row.Index Then Continue For

                Dim det As ProrrateoMedicamentoDetalleClass = Me.prorrateo.Detalle(row.Index)

                If det.Cantidad = 0D Then
                    row.Cells(Me.dgDetalle.CurrentCell.ColumnIndex).Selected = True
                End If
            Next

            Me.seleccionandoFila = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgDetalle_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgDetalle.UserAddedRow
        Try
            'DirectCast(e.Row.DataBoundItem, AplicacionMedicamentoDetalleClass).AplicacionMedicamento = Me.aplicacionMedicamento
            If Me.prorrateo.Detalle.Count > 0 Then
                Me.prorrateo.Detalle(Me.prorrateo.Detalle.Count - 1).ProrrateoMedicamento = Me.prorrateo
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgDetalle_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgDetalle.DataError

    End Sub
End Class