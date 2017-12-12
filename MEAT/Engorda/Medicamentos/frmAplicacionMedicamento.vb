Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio.AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum
Imports MEAT.frmBusquedaMovimientoAlmacen.DireccionFiltrada
Imports ClasesNegocio
Imports System.Data.SqlClient

Public Class frmAplicacionMedicamento
#Region "Miembros"
    Private aplicacionMedicamento As ClasesNegocio.AplicacionMedicamentoClass
    Private seleccionandoAretes As Boolean = False
    Private seleccionandoTipoMedicamento As Boolean = False
    Dim configuracion As EC.ConfigGanEntity
    Private seleccionandoFila As Boolean = False
    Private cambiandoCantidad As Boolean = False
    Private buscando As Boolean = False
    Private limpiando As Boolean = False
#End Region

#Region "Metodos"
    Private Sub BuscarMedicamentos(ByVal folioMovimiento As String)
        Dim sqlcon As New SqlConnection(HC.DbUtils.ActualConnectionString)

        Try
            If Me.aplicacionMedicamento.MovimientoAlmacenSalida.FolioMovimientoAlmacen = "" Then
                MsgBox("Debe establecer primero una salida de almacén", MsgBoxStyle.Exclamation, "Aviso")

                For Each rb As RadioButton In Me.gbTipoMedicamento.Controls
                    rb.Checked = False
                Next

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

            If Me.rbTrabajo.Checked Then
                sqlCom.CommandText = sqlCom.CommandText.Replace("CabMediReim", "CabMediTrab")
                sqlCom.Parameters.Add("@EsReimplante", SqlDbType.Bit).Value = False
            ElseIf Me.rbTratamiento.Checked Then
                sqlCom.CommandText &= " Union " & sqlCom.CommandText.Replace("CabMediReim", "CabMediTrab").Replace("@EsReimplante", "@EsTrabajo")
                sqlCom.Parameters.Add("@EsReimplante", SqlDbType.Bit).Value = True
                sqlCom.Parameters.Add("@EsTrabajo", SqlDbType.Bit).Value = False
            ElseIf Me.rbReimplante.Checked Then
                sqlCom.Parameters.Add("@EsReimplante", SqlDbType.Bit).Value = True
            Else
                Exit Sub
                'sqlCom.CommandText = sqlCom.CommandText.Replace("@EsReimplante", "1")
            End If

            sqlCom.Parameters.Add("@FolioMovimiento", SqlDbType.VarChar, 20).Value = folioMovimiento

            sqlDa.Fill(productos)

            If productos Is Nothing Then
                MessageBox.Show("Salida de Almacen no tiene medicamentos para este tipo de aplicación", Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.IdMedicamentoDataGridViewTextBoxColumn.DataSource = productos
            Me.IdMedicamentoDataGridViewTextBoxColumn.DisplayMember = "PdDescripcion"
            Me.IdMedicamentoDataGridViewTextBoxColumn.ValueMember = "PdIdProducto"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BuscarLotes()
        Try
            Me.IdLoteDataGridViewTextBoxColumn.DataSource = CC.McecatLotesCabCollection.GetMultiAsDataTable( _
                                        HC.McecatLotesCabFields.Estatus = ClasesNegocio.EstatusEnum.ACTIVO, _
                                        0, New OC.SortExpression(New OC.SortClause(HC.McecatLotesCabFields.NombreLote, _
                                        SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Me.IdLoteDataGridViewTextBoxColumn.DisplayMember = "NombreLote"
            Me.IdLoteDataGridViewTextBoxColumn.ValueMember = "IdLote"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Limpiar()
        limpiando = True
        Me.txtFolio.Clear()
        Me.txtSalidaAlmacen.Clear()
        Me.dtFecha.Value = Now

        For Each opciones As RadioButton In Me.gbTipoMedicamento.Controls
            opciones.Checked = False
        Next

        Me.dgAretes.DataSource = Nothing
        Me.dgDetalle.DataSource = Nothing

        Me.chkSeleccionAretes.Checked = False
        Me.rbTrabajo.Checked = True
        Me.buscando = False
        limpiando = False
    End Sub

    Private Sub Deshabilitar()
        Me.txtSalidaAlmacen.Enabled = False
        Me.dtFecha.Enabled = False
        Me.btnBuscarSalidaMedicamento.Enabled = False
        Me.gbTipoMedicamento.Enabled = False
        Me.dgDetalle.ReadOnly = True
        Me.dgAretes.ReadOnly = True
        Me.chkSeleccionAretes.Enabled = False
    End Sub

    Private Sub Habilitar()
        Me.txtSalidaAlmacen.Enabled = True
        Me.dtFecha.Enabled = True
        Me.btnBuscarSalidaMedicamento.Enabled = True
        Me.gbTipoMedicamento.Enabled = True
        Me.dgDetalle.ReadOnly = False
        Me.dgAretes.ReadOnly = False
        Me.chkSeleccionAretes.Enabled = True
        Me.SeleccionadoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.AretePropioDataGridViewTextBoxColumn.ReadOnly = True

        For Each colum As DataGridViewColumn In Me.dgDetalle.Columns
            colum.ReadOnly = True
        Next

        For Each colum As DataGridViewColumn In Me.dgAretes.Columns
            colum.ReadOnly = True
        Next

        Me.CantidadDataGridViewTextBoxColumn1.ReadOnly = False
        Me.IdLoteDataGridViewTextBoxColumn.ReadOnly = False
        Me.IdMedicamentoDataGridViewTextBoxColumn.ReadOnly = False
    End Sub

    Private Sub EstablecerEstadoSeleccion(ByVal filaSeleccionada As AplicacionMedicamentoDetalleClass)
        Dim cantidadAretesSeleccionados As Integer = 0

        For Each det As AplicacionMedicamentoDetalleDetalleClass In filaSeleccionada.Detalle
            If det.Seleccionado Then cantidadAretesSeleccionados += 1
        Next

        Me.seleccionandoAretes = True
        If cantidadAretesSeleccionados = filaSeleccionada.Detalle.Count Then
            Me.chkSeleccionAretes.CheckState = CheckState.Checked
        ElseIf cantidadAretesSeleccionados = 0 Then
            Me.chkSeleccionAretes.CheckState = CheckState.Unchecked
        Else
            Me.chkSeleccionAretes.CheckState = CheckState.Indeterminate
        End If

        Me.seleccionandoAretes = False
    End Sub

    Private Sub CalcularCantidadKilosImporte(ByVal filaSeleccionada As AplicacionMedicamentoDetalleClass)
        Dim kilos As Decimal = 0D
        Dim cantidad As Decimal = 0D
        Dim cabezas As Integer = 0
        Dim importe As Decimal = 0D

        For Each arete As AplicacionMedicamentoDetalleDetalleClass In filaSeleccionada.Detalle
            kilos += arete.Kilos
            cantidad += arete.Cantidad
            cabezas += 1
            importe += arete.Importe
        Next

        filaSeleccionada.Cabezas = cabezas
        If Not filaSeleccionada.CantidadManipulada Then filaSeleccionada.Entidad.Cantidad = cantidad
        filaSeleccionada.kilos = kilos
        filaSeleccionada.Importe = importe
    End Sub
#End Region

#Region "Eventos"
#Region "Form"
    Private Sub frmAplicacionMedicamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
#End Region

#Region "Buttons"
    Private Sub btnBuscarSalidaMedicamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarSalidaMedicamento.Click
        Try
            Dim ventanaMovimientos As New frmBusquedaMovimientoAlmacen

            ventanaMovimientos.EstablecerTipoMovimiento(Salidas_X_Aplicacion_Medicamento, True)

            If ventanaMovimientos.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtSalidaAlmacen.Text = ventanaMovimientos.MovimientoAlmacen.FolioMovimientoAlmacen
                Me.aplicacionMedicamento.MovimientoAlmacenSalida = ventanaMovimientos.MovimientoAlmacen
                Me.BuscarMedicamentos(Me.aplicacionMedicamento.FolioMovimientoAlmacenSalida)
                Me.aplicacionMedicamento.FechaAplicacionMedicamento = Me.dtFecha.Value
                Me.dgDetalle.AutoGenerateColumns = False
                Me.dgDetalle.DataSource = Me.aplicacionMedicamento.Detalle
            Else
                Me.txtSalidaAlmacen.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "DataGridView"
    Private Sub dgDetalle_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDetalle.CellEndEdit
        If e.RowIndex = Me.dgDetalle.Rows.Count - 1 OrElse _
            Me.IdMedicamentoDataGridViewTextBoxColumn.DataSource Is Nothing Then Exit Sub

        Me.dgDetalle.Refresh()

        Try
            Dim filaSeleccionada As AplicacionMedicamentoDetalleClass = Me.aplicacionMedicamento.Detalle(e.RowIndex)
            Dim tbProductos As DataTable = CType(Me.IdMedicamentoDataGridViewTextBoxColumn.DataSource, DataTable)
            Dim rows As DataRow() = tbProductos.Select("PdIdProducto = " & filaSeleccionada.IdMedicamento)

            If e.ColumnIndex = Me.CantidadDetalleDataGridViewTextBox.Index Then
                Me.cambiandoCantidad = True
                Me.chkSeleccionAretes.Checked = False
                'Dim cantidad As Decimal = filaSeleccionada.Cantidad

                'filaSeleccionada.InicializarCantidadPorCabeza()
                'filaSeleccionada.Cantidad = 0D
                'filaSeleccionada.Cantidad = cantidad

                Me.cambiandoCantidad = False
            Else
                If rows IsNot Nothing Then
                    For Each productoSeleccionado As DataRow In rows
                        filaSeleccionada.EsMedicamentoReimplante = CBool(productoSeleccionado("EsReimplante"))
                        filaSeleccionada.EsMedicamentoTrabajo = Not filaSeleccionada.EsMedicamentoReimplante
                        'Me.EstablecerEstadoSeleccion(filaSeleccionada)
                    Next

                    Me.dgAretes.AutoGenerateColumns = False
                    Me.dgAretes.DataSource = filaSeleccionada.Detalle
                    Me.EstablecerEstadoSeleccion(filaSeleccionada)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgDetalle_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDetalle.CellEnter
        Try
            If e.RowIndex = Me.dgDetalle.Rows.Count - 1 OrElse _
                Me.aplicacionMedicamento.Detalle(e.RowIndex).Medicamento.Entidad.IsNew OrElse _
                (Me.dgDetalle.SelectedCells.Count > 0 AndAlso _
                Me.dgDetalle.SelectedCells(0).RowIndex = Me.dgDetalle.Rows.Count - 1) Then
                Me.dgAretes.DataSource = Nothing
                Me.chkSeleccionAretes.Checked = False
                Me.chkSeleccionAretes.Enabled = False
                Exit Sub
            End If

            Dim filaSeleccionada As AplicacionMedicamentoDetalleClass = Me.aplicacionMedicamento.Detalle(e.RowIndex)

            If e.ColumnIndex = Me.CantidadDetalleDataGridViewTextBox.Index Then
                Me.CantidadDetalleDataGridViewTextBox.ReadOnly = filaSeleccionada.Medicamento.IsNew OrElse filaSeleccionada.Lote.Entidad.IsNew
            End If

            Me.dgAretes.AutoGenerateColumns = False
            Me.dgAretes.DataSource = filaSeleccionada.Detalle
            Me.EstablecerEstadoSeleccion(filaSeleccionada)
            Me.chkSeleccionAretes.Enabled = Not Me.buscando
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgDetalle_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgDetalle.DataError

    End Sub

    Private Sub dgAretes_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgAretes.CellContentClick
        If Me.dgAretes.CurrentRow Is Nothing Then Exit Sub

        If e.ColumnIndex = Me.SeleccionadoDataGridViewCheckBoxColumn.Index Then
            'Dim filaSeleccionadaDetalle As AplicacionMedicamentoDetalleClass = _
            '                            DirectCast(Me.dgAretes.CurrentRow.DataBoundItem, _
            '                            AplicacionMedicamentoDetalleDetalleClass).AplicacionMedicamentoDetalle
            'Me.dgAretes.CurrentRow.Cells(Me.SeleccionadoDataGridViewCheckBoxColumn.Index).Value = _
            '            Not CBool(Me.dgAretes.CurrentRow.Cells(Me.SeleccionadoDataGridViewCheckBoxColumn.Index).Value)
            'Me.EstablecerEstadoSeleccion(filaSeleccionadaDetalle)
            'Me.CalcularCantidadKilosImporte(filaSeleccionadaDetalle)
        End If
    End Sub

    Private Sub dgAretes_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgAretes.CellEndEdit
        Me.dgAretes.Refresh()

        Try
            Dim filaSeleccionadaDetalle As AplicacionMedicamentoDetalleClass = _
                                        DirectCast(Me.dgAretes.CurrentRow.DataBoundItem, _
                                        AplicacionMedicamentoDetalleDetalleClass).AplicacionMedicamentoDetalle

            'If Not Me.chkSeleccionAretes.CheckState = CheckState.Checked Then filaSeleccionadaDetalle.Cantidad = 0D
            filaSeleccionadaDetalle.CantidadManipulada = False
            Me.CalcularCantidadKilosImporte(filaSeleccionadaDetalle)
            Me.EstablecerEstadoSeleccion(filaSeleccionadaDetalle)
            Me.dgDetalle.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgAretes_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgAretes.DataError

    End Sub

    Private Sub dgDetalle_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDetalle.LostFocus
        Try
            If Me.dgDetalle.SelectedCells.Count > 0 AndAlso _
                Me.dgDetalle.SelectedCells(0).RowIndex = Me.dgDetalle.Rows.Count - 1 Then
                Me.dgDetalle.Rows(0).Cells(0).Selected = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgDetalle_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDetalle.RowEnter
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgDetalle_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDetalle.SelectionChanged
        If Me.seleccionandoFila OrElse Me.dgDetalle.CurrentRow Is Nothing Then Exit Sub

        Try
            Dim filaSeleccionada As Integer = Me.dgDetalle.CurrentRow.Index

            Me.seleccionandoFila = True

            For Each row As DataGridViewRow In Me.dgDetalle.Rows
                If row.Index = filaSeleccionada OrElse Me.dgDetalle.Rows.Count - 1 = row.Index Then Continue For

                Dim det As AplicacionMedicamentoDetalleClass = Me.aplicacionMedicamento.Detalle(row.Index)

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
            If Me.aplicacionMedicamento.Detalle.Count > 0 Then
                Me.aplicacionMedicamento.Detalle(Me.aplicacionMedicamento.Detalle.Count - 1).AplicacionMedicamento = Me.aplicacionMedicamento
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgAretes_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgAretes.CellEnter
        'If e.RowIndex = Me.dgAretes.Rows.Count - 1 Then Exit Sub

        Try
            'Me.dgAretes(Me.CantidadDataGridViewTextBoxColumn1.Index, e.RowIndex).ReadOnly = _
            '            Not CBool(Me.dgAretes(Me.SeleccionadoDataGridViewCheckBoxColumn.Index, e.RowIndex).Value)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "DateTimePiker"
    Private Sub dtFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtFecha.ValueChanged
        If Me.aplicacionMedicamento IsNot Nothing Then Me.aplicacionMedicamento.FechaAplicacionMedicamento = Me.dtFecha.Value
    End Sub
#End Region

#Region "RadioButtons"
    Private Sub rbTrabajo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTrabajo.CheckedChanged
        If Me.seleccionandoTipoMedicamento OrElse Me.aplicacionMedicamento Is Nothing OrElse limpiando Then Exit Sub

        Me.seleccionandoTipoMedicamento = True
        Me.BuscarMedicamentos(Me.aplicacionMedicamento.FolioMovimientoAlmacenSalida)
        Me.seleccionandoTipoMedicamento = False
    End Sub

    Private Sub rbReimplante_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbReimplante.CheckedChanged
        If Me.seleccionandoTipoMedicamento Then Exit Sub

        Me.seleccionandoTipoMedicamento = True
        Me.BuscarMedicamentos(Me.aplicacionMedicamento.FolioMovimientoAlmacenSalida)
        Me.seleccionandoTipoMedicamento = False
    End Sub

    Private Sub rbTratamiento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTratamiento.CheckedChanged
        If Me.seleccionandoTipoMedicamento Then Exit Sub

        Me.seleccionandoTipoMedicamento = True
        Me.BuscarMedicamentos(Me.aplicacionMedicamento.FolioMovimientoAlmacenSalida)
        Me.seleccionandoTipoMedicamento = False
    End Sub
#End Region

#Region "ToolBar"
    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Cursor = Cursors.WaitCursor

        Try
            Dim configuracionEngorda As New CC.ConfigGanCollection

            configuracionEngorda.GetMulti(Nothing, 1)

            If configuracionEngorda.Count = 0 Then
                MsgBox("Primero establesca una configuracón de engorda, Engorda/Configuración", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            Else
                Me.configuracion = configuracionEngorda(0)
            End If

            Dim ventana As New frmBusquedaAplicacionMedicamento

            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.aplicacionMedicamento = ventana.AplicacionMedicamento

                Me.txtFolio.Text = Me.aplicacionMedicamento.FolioAplicacionMedicamento
                Me.dtFecha.Value = Me.aplicacionMedicamento.FechaAplicacionMedicamento
                Me.txtSalidaAlmacen.Text = Me.aplicacionMedicamento.FolioMovimientoAlmacenSalida
                Me.dgDetalle.AutoGenerateColumns = False
                Me.dgDetalle.DataSource = Me.aplicacionMedicamento.Detalle
                Me.dgDetalle.ReadOnly = True
                Me.dgAretes.ReadOnly = True
                seleccionandoTipoMedicamento = True
                Me.rbTratamiento.Checked = True
                seleccionandoTipoMedicamento = False
                Me.BuscarMedicamentos(Me.aplicacionMedicamento.FolioMovimientoAlmacenSalida)
                Me.BuscarLotes()
                Me.chkSeleccionAretes.Enabled = False
                Me.buscando = True
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
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Cursor = Cursors.WaitCursor

        Try
            Me.aplicacionMedicamento.IdUsuarioAlta = Controlador.Sesion.Usrndx
            Me.aplicacionMedicamento.FechaAplicacionMedicamento = Me.dtFecha.Value

            If Me.aplicacionMedicamento.Guardar Then
                MsgBox("Se guardo la aplicación de medicamento con el folio: " & Me.aplicacionMedicamento.FolioAplicacionMedicamento, MsgBoxStyle.Information, "Aviso")
                Me.Limpiar()
                Me.Deshabilitar()
                Me.aplicacionMedicamento = Nothing
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

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Try
            Me.BuscarLotes()
            Me.Limpiar()
            Me.Habilitar()
            Me.aplicacionMedicamento = New AplicacionMedicamentoClass
            Me.dgDetalle.AutoGenerateColumns = False
            Me.dgDetalle.DataSource = Me.aplicacionMedicamento.Detalle
            Me.dgAretes.DataSource = Nothing
            Me.chkSeleccionAretes.Checked = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region

#Region "TextBox"
    Private Sub txtSalidaAlmacen_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtSalidaAlmacen.PreviewKeyDown
        If e.KeyCode = Keys.F3 Then
            Me.btnBuscarSalidaMedicamento_Click(sender, System.EventArgs.Empty)
        End If
    End Sub
#End Region

    Private Sub chkSeleccionAretes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSeleccionAretes.CheckedChanged
        If Me.seleccionandoAretes OrElse Me.cambiandoCantidad OrElse Me.dgAretes.Rows.Count = 0 OrElse _
            Me.dgDetalle.Rows.Count - 1 = Me.dgDetalle.CurrentRow.Index OrElse limpiando Then Exit Sub
        Try
            Dim filaSeleccionadaDetalle As AplicacionMedicamentoDetalleClass = _
                                        DirectCast(Me.dgAretes.CurrentRow.DataBoundItem, _
                                        AplicacionMedicamentoDetalleDetalleClass).AplicacionMedicamentoDetalle
            Dim cantidadPorArete As Decimal = 0D

            If Me.chkSeleccionAretes.Checked AndAlso filaSeleccionadaDetalle.CantidadManipulada Then
                cantidadPorArete = filaSeleccionadaDetalle.Cantidad / filaSeleccionadaDetalle.Detalle.Count
            ElseIf Not Me.chkSeleccionAretes.Checked AndAlso Not filaSeleccionadaDetalle.CantidadManipulada Then
                filaSeleccionadaDetalle.Cantidad = 0D
                Me.dgDetalle.Refresh()
            End If

            Me.seleccionandoAretes = True

            For Each det As AplicacionMedicamentoDetalleDetalleClass In filaSeleccionadaDetalle.Detalle
                det.Entidad.Cantidad = cantidadPorArete
                det.Seleccionado = det.Cantidad > 0D
                det.Importe = det.Cantidad * det.Costo
            Next

            Me.chkSeleccionAretes.Checked = cantidadPorArete > 0D
            Me.dgAretes.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.seleccionandoAretes = False
        End Try
    End Sub
#End Region
End Class