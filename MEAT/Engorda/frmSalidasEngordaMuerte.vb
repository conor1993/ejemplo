Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmSalidasEngordaMuerte
    Inherits MeatForm

#Region "Miembros"

    Dim Estado As New FormState
    Private SalidaGanado As SalidaGanadoCabeceroClass
    Private chkTodos As CheckBox

#End Region

#Region "Metodos"

    Public Overrides Sub InicializarForma()
        'Establecer acciones del menu
        Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        tbEstados.StateBuscar = "001101111"
        tbEstados.StateLimpiar = ""
        tbEstados.StateCancelar = "100100001"
        tbEstados.StateNuevo = "011010001"
        tbEstados.StateGuardar = "100100001"
        tbEstados.StateBorrar = "100100001"
        tbEstados.StateEditar = "001011001"
        tbEstados.StateImprimir = ""
        tbEstados.StateSalir = ""
        Me.tbrMenu.ToolBarButtonStatus = tbEstados
        Me.tbrMenu.sbCambiarEstadoBotones("Cancelar")

        'Incrustar chekbox de Todos
        chkTodos = New CheckBox()
        chkTodos.CausesValidation = False
        chkTodos.ThreeState = True
        chkTodos.BackColor = Color.White
        Dim rect As Rectangle = dgvDetalleLote.GetCellDisplayRectangle(0, -1, True)
        chkTodos.Size = New Size(14, 13)
        chkTodos.Location = rect.Location
        chkTodos.Left = 5
        chkTodos.Top = 4
        AddHandler chkTodos.CheckStateChanged, AddressOf chkTodos_CheckedChanged
        dgvDetalleLote.Controls.Add(chkTodos)

        dgvDetalleLote.AutoGenerateColumns = False
        dgvLotes.AutoGenerateColumns = False

        Controlador.LlenarComboCausasMuerte(cmbCausaMuerte)
        Controlador.LlenarComboTiposGanado(clmIdTipoGanado, CondicionEnum.TODOS)

        Modo(False)
        Limpiar()
    End Sub

    Public Overrides Sub Modo(ByVal Edicion As Boolean)
        dtpFecha.Enabled = Edicion
        dgvLotes.ReadOnly = Not Edicion
        dgvLotes.AllowUserToAddRows = Edicion
        dgvDetalleLote.ReadOnly = Not Edicion
        chkTodos.Visible = Edicion
        clmSeleccion.Visible = Edicion

        If Edicion Then
            dgvLotes.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
            dgvDetalleLote.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect

            clmLote.ReadOnly = False
            clmIdTipoGanado.ReadOnly = False
            clmCorral.ReadOnly = True
            clmKilos.ReadOnly = True
            clmCabezas.ReadOnly = True
            clmImporte.ReadOnly = True

            clmSeleccion.ReadOnly = False
            clmAreteTransporte.ReadOnly = True
            clmAreteSINIIGA.ReadOnly = True
            clmArete.ReadOnly = True
            clmDetalleCostoxKilo.ReadOnly = True
            clmTipoGanado.ReadOnly = True
        Else
            dgvLotes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDetalleLote.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
        cmbCausaMuerte.Enabled = Edicion
        txtNoAviso.ReadOnly = Not Edicion
        chkRecuperacion.Enabled = Edicion
    End Sub

    Private Function ActualizarTipoGanado(ByVal RowIndex As Integer) As TipoGanadoColecttionClass
        Dim TiposGanado As New TipoGanadoColecttionClass

        If IsNumeric(dgvLotes.Rows(RowIndex).Cells(clmLote.Index).Value) Then
            Dim Lote As LoteClass = CType(dgvLotes.Rows(RowIndex).Cells(clmLote.Index).Tag, LoteClass)
            Dim dtTipoGanado As dsDetalleTiposGanado.DataTable1DataTable = Lote.DetallesPorTiposGanado_Vigentes

            For Each TipoGanado As TipoGanadoClass In CType(clmIdTipoGanado.DataSource, TipoGanadoColecttionClass)
                TiposGanado.Add(TipoGanado)
            Next

            For i As Integer = TiposGanado.Count - 1 To 0 Step -1
                Dim Busqueda() As dsDetalleTiposGanado.DataTable1Row = dtTipoGanado.Select("IdTipoGanado = '" & TiposGanado.Item(i).IdTipoGanado.ToString & "'")

                If Busqueda Is Nothing OrElse Not Busqueda.Length > 0 Then
                    TiposGanado.RemoveAt(i)
                End If
            Next

            For Each Fila As DataGridViewRow In Me.dgvLotes.Rows
                If Not Fila.IsNewRow AndAlso Fila.Index <> RowIndex AndAlso Fila.Cells(clmLote.Index).Value = dgvLotes.Rows(RowIndex).Cells(clmLote.Index).Value Then
                    For i As Integer = TiposGanado.Count - 1 To 0 Step -1
                        If CType(Fila.Cells(clmIdTipoGanado.Index).Value, Integer) = TiposGanado.Item(i).IdTipoGanado Then
                            TiposGanado.RemoveAt(i)
                            Exit For
                        End If
                    Next
                End If
            Next
        End If
        Return TiposGanado
    End Function

    Private Sub ActualizarSeleccion(ByRef RenglonLote As DataGridViewRow)
        For Each GridRow As DataGridViewRow In dgvDetalleLote.Rows
            Dim dr() As DataRow = RenglonLote.Tag.Select("IdMceCatLotesDet = '" & GridRow.Cells(clmIdMceCatLotesDet.Index).Value & "'")

            If dr.Length > 0 Then
                CType(GridRow.Cells(clmSeleccion.Index), DataGridViewCheckBoxCell).EditingCellFormattedValue = True
                GridRow.Cells(clmSeleccion.Index).Value = True
                GridRow.Cells(clmDetalleKilos.Index).Value = dr(0).Item("Kilos")
            End If
        Next
    End Sub

    Private Sub ActualizarCheckBoxGeneral()
        Dim Todos As Boolean = True, Ninguno As Boolean = True

        For Each GridRow As DataGridViewRow In dgvDetalleLote.Rows
            Dim CeldaCheckBox As DataGridViewCheckBoxCell = CType(GridRow.Cells(clmSeleccion.Index), DataGridViewCheckBoxCell)

            If CeldaCheckBox.EditedFormattedValue Then
                Ninguno = False
            Else
                Todos = False
            End If
        Next

        RemoveHandler chkTodos.CheckStateChanged, AddressOf chkTodos_CheckedChanged
        If Todos Then
            chkTodos.CheckState = CheckState.Checked
        ElseIf Ninguno Then
            chkTodos.CheckState = CheckState.Unchecked
        Else
            chkTodos.CheckState = CheckState.Indeterminate
        End If
        AddHandler chkTodos.CheckStateChanged, AddressOf chkTodos_CheckedChanged
    End Sub

    Public Sub ActualizarDetalleLote(ByVal e As DataGridViewCellEventArgs)
        Dim GridRow As DataGridViewRow = dgvLotes.Rows(e.RowIndex)
        Dim Lote As LoteClass = Nothing

        If IsNumeric(GridRow.Cells(clmLote.Index).Value) Then
            If GridRow.Cells(clmLote.Index).Tag Is Nothing OrElse CType(GridRow.Cells(clmLote.Index).Tag, LoteClass).IdLote <> CType(GridRow.Cells(clmLote.Index).Value, Integer) Then
                GridRow.Cells(clmLote.Index).Tag = New LoteClass(CType(GridRow.Cells(clmLote.Index).Value, Integer))
            End If
            Lote = CType(GridRow.Cells(clmLote.Index).Tag, LoteClass)
        End If

        If e.ColumnIndex = clmLote.Index Then
            GridRow.Tag = New dsSeleccionDetalleLote.SelDetalleLoteDataTable()
            GridRow.Cells(clmIdTipoGanado.Index).Value = Nothing
            dgvDetalleLote.DataSource = Nothing

            If Lote IsNot Nothing AndAlso Not Lote.Entidad.IsNew Then
                Dim TiposGanado As TipoGanadoColecttionClass = ActualizarTipoGanado(GridRow.Index)

                If TiposGanado.Count = 0 Then
                    dgvLotes.Rows.RemoveAt(GridRow.Index)
                    Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_CORRAL_RASTRO, 3, CType(GridRow.Cells(clmLote.Index), DataGridViewComboBoxCell).Value)
                ElseIf TiposGanado.Count = 1 Then
                    GridRow.Cells(clmIdTipoGanado.Index).Value = TiposGanado.Item(0).IdTipoGanado
                End If
                GridRow.Cells(clmCorral.Index).Value = Lote.Corral.Descripcion
            Else
                GridRow.Cells(clmCorral.Index).Value = ""
            End If
            dgvLotes.Refresh()
        ElseIf e.ColumnIndex = clmIdTipoGanado.Index Then
            If IsNumeric(GridRow.Cells(clmIdTipoGanado.Index).Value) Then
                If chkTodos IsNot Nothing Then
                    RemoveHandler chkTodos.CheckStateChanged, AddressOf chkTodos_CheckedChanged
                    chkTodos.Checked = False
                    AddHandler chkTodos.CheckStateChanged, AddressOf chkTodos_CheckedChanged
                End If

                If Not Controlador.Configuracion.Engorda.RequerirArete Then
                    GridRow.Cells(clmCabezas.Index).ReadOnly = False
                End If
                GridRow.Cells(clmKilos.Index).ReadOnly = False
                dgvDetalleLote.DataSource = Nothing
                dgvDetalleLote.DataSource = Lote.Aretes(LoteDetClass.EstatusLoteDetalle.VIGENTE, CType(GridRow.Cells(clmIdTipoGanado.Index).Value, Integer))
                RecalcularDetalleLotes(GridRow)
                RecalcularMontosGenerales()
            End If
        End If
    End Sub

    ''' <summary>
    ''' Valida que cada detalle tenga un tipo de ganado diferente y una cantidad de cabezas y kilos mayor a 0
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Sub ValidarGrid(ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs)
        If dgvLotes.Rows.Count > 0 Then
            If Not dgvLotes.Rows(e.RowIndex).IsNewRow Then
                If Not IsNumeric(dgvLotes.Rows(e.RowIndex).Cells(clmLote.Index).Value) Then
                    e.Cancel = True
                    Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_CORRAL_RASTRO, 0)
                ElseIf dgvLotes.Rows(e.RowIndex).Cells(clmCabezas.Index).Value <= 0 Then
                    e.Cancel = True
                    Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 1)
                ElseIf dgvLotes.Rows(e.RowIndex).Cells(clmKilos.Index).Value <= 0 Then
                    e.Cancel = True
                    Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 2)
                End If
            End If

            For Each detalle As DataGridViewRow In dgvLotes.Rows
                If Not detalle.IsNewRow AndAlso detalle.Tag IsNot Nothing Then
                    Dim dr() As DataRow = detalle.Tag.Select("Kilos <= 0")

                    If dr.Length > 0 Then
                        e.Cancel = True
                        MessageBox.Show("La cabeza con Arete Propio: " & dr(0).Item("AretePropio") & " del lote: " & CType(detalle.Cells(clmLote.Index), DataGridViewComboBoxCell).EditedFormattedValue & " debe especificar los kilos como una cantidad mayor a 0")
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub ValidarDatos()
        Dim ExisteDetalle As Boolean = False

        For Each Detalle As DataGridViewRow In dgvLotes.Rows
            If Not Detalle.IsNewRow AndAlso Detalle.Tag IsNot Nothing AndAlso Detalle.Tag.Rows.Count > 0 Then
                ExisteDetalle = True
            End If
        Next

        If Not ExisteDetalle Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 5)
        End If
    End Sub

    Private Sub RecalcularMontosGenerales()
        Dim TotalCabezas As Integer = 0D, TotalKilos As Decimal = 0D, TotalImporte As Decimal = 0D

        For Each GridRow As DataGridViewRow In dgvLotes.Rows
            If Not GridRow.IsNewRow Then
                TotalCabezas += Val(GridRow.Cells(clmCabezas.Index).Value)
                TotalKilos += Val(GridRow.Cells(clmKilos.Index).Value)
                TotalImporte += CDec(GridRow.Cells(clmImporte.Index).Value)
            End If
        Next
        txtTotalCabezas.Text = TotalCabezas
        txtTotalKilos.Text = TotalKilos.ToString("N2")
        txtTotalImporte.Text = TotalImporte.ToString("C2")
        dgvLotes.Refresh()
    End Sub

    Private Sub RecalcularDetalleLotes(Optional ByRef GridRow As DataGridViewRow = Nothing, Optional ByVal KilosModificados As Boolean = False)
        Dim Importe As Decimal = 0D, Kilos As Decimal = 0D

        If GridRow Is Nothing Then
            GridRow = dgvLotes.CurrentRow
        End If

        For Each detalle As dsSeleccionDetalleLote.SelDetalleLoteRow In GridRow.Tag.Rows
            Kilos += detalle.Kilos
            Importe += detalle.Kilos * detalle.CostoxKilo
        Next

        If KilosModificados AndAlso GridRow.Tag.Rows.count > 0 Then
            GridRow.Cells(clmKilos.Index).Value = Kilos
        End If

        GridRow.Cells(clmImporte.Index).Value = Importe
        GridRow.Cells(clmCabezas.Index).Value = GridRow.Tag.Rows.Count
        dgvLotes.Refresh()
    End Sub

    Public Sub FinDeEdicion(ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.ColumnIndex = clmCabezas.Index Then
            Dim Cabezas As Integer = CType(dgvLotes.Rows(e.RowIndex).Cells(clmCabezas.Index).Value, Integer)
            Dim Lote As LoteClass = CType(dgvLotes.Rows(e.RowIndex).Cells(clmLote.Index).Tag, LoteClass)

            dgvLotes.Rows(e.RowIndex).Cells(clmCabezas.Index).Value = 0

            If Cabezas <= Lote.SaldoCabezas Then
                For Each GridRow As DataGridViewRow In dgvDetalleLote.Rows
                    Dim chkSeleccionado As DataGridViewCheckBoxCell = GridRow.Cells(clmSeleccion.Index), Seleccion As Boolean = False

                    If Cabezas > 0 Then
                        Seleccion = True
                        Cabezas -= 1
                    End If
                    chkSeleccionado.EditingCellFormattedValue = Seleccion
                    chkSeleccionado.Value = Seleccion
                    dgvDetalleLote_CellContentClick(chkTodos, New DataGridViewCellEventArgs(clmSeleccion.Index, GridRow.Index))
                Next
                RecalcularDetalleLotes()
                RecalcularMontosGenerales()
                dgvDetalleLote.Refresh()
            Else
                Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_CORRAL_RASTRO, 4)
            End If
        ElseIf e.ColumnIndex = clmKilos.Index Then
            Dim Cabezas As Integer = CType(dgvLotes.Rows(e.RowIndex).Cells(clmCabezas.Index).Value, Integer)
            Dim Kilos As Decimal = CType(dgvLotes.Rows(e.RowIndex).Cells(clmKilos.Index).Value, Decimal)
            Dim KilosxCabeza As Decimal = 0D
            Dim Lote As LoteClass = CType(dgvLotes.Rows(e.RowIndex).Cells(clmLote.Index).Tag, LoteClass)

            If Cabezas <> 0D Then
                KilosxCabeza = Kilos / Cabezas
            End If

            For Each GridRow As DataGridViewRow In dgvDetalleLote.Rows
                If GridRow.Cells(clmSeleccion.Index).Value Then
                    GridRow.Cells(clmDetalleKilos.Index).Value = KilosxCabeza
                    dgvDetalleLote_CellEndEdit(chkTodos, New DataGridViewCellEventArgs(clmDetalleKilos.Index, GridRow.Index))
                End If
            Next
            RecalcularDetalleLotes(Nothing, True)
            RecalcularMontosGenerales()
        End If
    End Sub

#End Region

#Region "Acciones_Menu"

    Public Function Buscar() As Boolean
        Dim frmCorralesReciba As New frmBusquedaCorralesAMuerte
        Estado = FormState.Buscar
        Limpiar()

        If frmCorralesReciba.ShowDialog() = Windows.Forms.DialogResult.OK Then
            SalidaGanado = CType(frmCorralesReciba.dgvCorralesRecibaCab.SelectedRows(0).DataBoundItem, SalidaGanadoCabeceroClass)
            txtFolio.Text = SalidaGanado.Folio
            dtpFecha.Value = SalidaGanado.Fecha
            cmbCausaMuerte.SelectedValue = SalidaGanado.IdCausaMuerte
            txtNoAviso.Text = SalidaGanado.Aviso
            chkRecuperacion.Checked = SalidaGanado.Recuperacion
            Controlador.LlenarComboLotes(clmLote, LoteClass.EstatusLote.TODOS)

            For Each Item As dsLotesTiposGanado.LoteTipoGanadoRow In SalidaGanado.Lotes_y_TiposGanado
                Dim index As Integer = dgvLotes.Rows.Add(Item.LoteDescripcion, Item.CorralDescripcion, Item.TipoGanadoDescripcion, Item.Cabezas, Item.Kilos, Item.Importe)
                dgvLotes.Rows(index).Cells(clmLote.Index).Tag = Item.IdLote
                dgvLotes.Rows(index).Cells(clmIdTipoGanado.Index).Tag = Item.IdTipoGanado
            Next

            lblEstatus.Text = SalidaGanado.Estatus.ToString()
            txtTotalCabezas.Text = SalidaGanado.Cabezas
            txtTotalKilos.Text = SalidaGanado.Kilos.ToString("N2")
            txtTotalImporte.Text = SalidaGanado.CostoMovto.Value.ToString("C2")
            dgvLotes_RowEnter(dgvLotes, New DataGridViewCellEventArgs(clmLote.Index, 0))
            Return True
        End If
    End Function

    Public Overrides Function Limpiar() As Boolean
        Dim EstAnterior As FormState = Me.Estado
        Me.Estado = FormState.Limpiar
        dgvLotes.Rows.Clear()
        dgvDetalleLote.Rows.Clear()
        dgvDetalleLote.DataSource = Nothing

        dtpFecha.Value = Now
        txtTotalCabezas.ResetText()
        txtTotalKilos.ResetText()
        txtTotalImporte.ResetText()
        txtFolio.ResetText()
        txtNoAviso.ResetText()
        cmbCausaMuerte.SelectedIndex = -1
        cmbCausaMuerte.Text = "Seleccione la Causa de Muerte"
        chkRecuperacion.Checked = False
        RemoveHandler chkTodos.CheckStateChanged, AddressOf chkTodos_CheckedChanged
        chkTodos.Checked = False
        AddHandler chkTodos.CheckStateChanged, AddressOf chkTodos_CheckedChanged
        Me.Estado = EstAnterior
        Return True
    End Function

    Public Overrides Function Nuevo() As Boolean
        Estado = FormState.Nuevo
        Limpiar()
        Modo(True)
        lblEstatus.Text = "ESTATUS"
        Controlador.Configuracion.Engorda.Entidad.Refetch()
        SalidaGanado = New SalidaGanadoCabeceroClass()
        SalidaGanado.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Muerte
        'Cargar Lotes
        Controlador.LlenarComboLotes(clmLote, LoteClass.EstatusLote.VIGENTE)
        Return True
    End Function

    Public Overrides Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        Dim dsDetalle As New dsSeleccionDetalleLote.SelDetalleLoteDataTable
        Dim FrmVistaDetalle As frmDetalleLote = Nothing

        If MessageBox.Show("La Salida por Muerte se efectuara, ¿Esta seguro?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Return False
        End If

        ValidarDatos()

        If Me.Validate() Then
            SalidaGanado.Detalles.Clear()

            For Each Detalle As DataGridViewRow In dgvLotes.Rows
                If Not Detalle.IsNewRow AndAlso Detalle.Tag IsNot Nothing AndAlso Detalle.Tag.Rows.Count > 0 Then
                    For Each Renglon As dsSeleccionDetalleLote.SelDetalleLoteRow In Detalle.Tag.Rows
                        SalidaGanado.Detalles.Add(New SalidaGanadoDetalleClass(0, Renglon.IdTipoGanado, 0, Now, _
                        Detalle.Cells(clmLote.Index).Value, 0, 1, Renglon.Kilos, Renglon.CostoxKilo, 0, 0, 0, 0, _
                        Renglon.IdMceCatLotesDet, "", "", "", 0))
                    Next
                    dsDetalle.Merge(CType(Detalle.Tag, dsSeleccionDetalleLote.SelDetalleLoteDataTable))
                End If
            Next
            FrmVistaDetalle = New frmDetalleLote(dsDetalle, False)

            If FrmVistaDetalle.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Controlador.RealizarSalidadeCorralaMuerte(SalidaGanado, Me.dtpFecha.Value, cmbCausaMuerte.SelectedValue, txtNoAviso.Text.Trim(), chkRecuperacion.Checked, Trans)
                Trans.Commit()
                MessageBox.Show("La Salida de Corral a Muerte se ha realizado satisfactoriamente con el folio: " & SalidaGanado.Folio)

                If MessageBox.Show("¿Desea previsualizar los datos para impresion?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Controlador.ImpresionSalidaDeGanado(SalidaGanado)
                End If
                Cancelar()
                Return True
            End If
        End If
    End Function

    Public Overrides Function Borrar(ByVal Trans As HC.Transaction) As Boolean
        If MessageBox.Show("La Salida por Muerte (" & SalidaGanado.Folio & ") se cancelara, ¿Esta seguro?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Return False
        End If

        Controlador.CancelarSalidaDeCorralAMuerte(SalidaGanado, Trans)
        Trans.Commit()
        Cancelar()
        MessageBox.Show("La Salida de Corral a Muerte se ha cancelado satisfactoriamente")
        Return True
    End Function

    Public Overrides Function Imprimir() As Boolean
        Controlador.ImpresionSalidaDeGanado(SalidaGanado)
        Return True
    End Function

#End Region

#Region "Eventos"

    Private Sub frmSalidasRecibaRastro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Utilerias.RunControlException(Me, "InicializarForma")
    End Sub

    Private Sub cmbCausaMuerte_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCausaMuerte.KeyDown
        If e.KeyCode = Keys.F12 Then
            Controlador.LlenarComboCausasMuerte(cmbCausaMuerte)
        End If
    End Sub

    Private Sub dgvLotes_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvLotes.DataError

    End Sub

    Private Sub dgvLotes_RowValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvLotes.RowValidating
        If Me.Estado = FormState.Nuevo Then
            Utilerias.RunControlException(Me, "ValidarGrid", New Object() {e})
        End If
    End Sub

    Private Sub dgvLotes_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvLotes.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosEnteros
        RemoveHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales

        If dgvLotes.CurrentCell.ColumnIndex = clmLote.Index Then
            RemoveHandler CType(e.Control, DataGridViewComboBoxEditingControl).SelectionChangeCommitted, AddressOf Utilerias.DataGridViewComboBoxEditingControl_SelectionChangeCommitted
            AddHandler CType(e.Control, DataGridViewComboBoxEditingControl).SelectionChangeCommitted, AddressOf Utilerias.DataGridViewComboBoxEditingControl_SelectionChangeCommitted
        ElseIf dgvLotes.CurrentCell.ColumnIndex = clmIdTipoGanado.Index Then
            RemoveHandler CType(e.Control, DataGridViewComboBoxEditingControl).SelectionChangeCommitted, AddressOf Utilerias.DataGridViewComboBoxEditingControl_SelectionChangeCommitted

            CType(e.Control, DataGridViewComboBoxEditingControl).DataSource = ActualizarTipoGanado(dgvLotes.CurrentCell.RowIndex)

            If dgvLotes.CurrentCell.Value IsNot Nothing Then
                CType(e.Control, DataGridViewComboBoxEditingControl).SelectedValue = dgvLotes.CurrentCell.Value
            End If
            AddHandler CType(e.Control, DataGridViewComboBoxEditingControl).SelectionChangeCommitted, AddressOf Utilerias.DataGridViewComboBoxEditingControl_SelectionChangeCommitted
        ElseIf dgvLotes.CurrentCell.ColumnIndex = clmCabezas.Index Then
            AddHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosEnteros
        ElseIf dgvLotes.CurrentCell.ColumnIndex = clmKilos.Index Then
            AddHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
        End If
    End Sub

    Private Sub dgvLotes_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dgvLotes.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then
            If dgvLotes.CurrentRow.Index <> dgvLotes.Rows.Count - 1 Then
                If MessageBox.Show("Seguro que desea eliminarlo", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    RemoveHandler dgvLotes.RowValidating, AddressOf dgvLotes_RowValidating
                    dgvLotes.Rows.RemoveAt(dgvLotes.CurrentRow.Index)
                    AddHandler dgvLotes.RowValidating, AddressOf dgvLotes_RowValidating
                End If
            End If
        End If
    End Sub

    Private Sub dgvDetalleLote_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleLote.CellContentClick
        If e.ColumnIndex = clmSeleccion.Index Then
            Dim Celda As DataGridViewCheckBoxCell = CType(dgvDetalleLote.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            Dim dsDetalles As dsSeleccionDetalleLote.SelDetalleLoteDataTable = CType(dgvLotes.CurrentRow.Tag, dsSeleccionDetalleLote.SelDetalleLoteDataTable)
            Dim KilosxCabeza As Decimal = 0D

            If Celda.EditedFormattedValue Then
                Dim dr() As DataRow = dsDetalles.Select("IdMceCatLotesDet = '" & dgvDetalleLote.Rows(e.RowIndex).Cells(clmIdMceCatLotesDet.Index).Value & "'")

                If Not dr.Length > 0 Then
                    dsDetalles.AddSelDetalleLoteRow(dgvDetalleLote.Rows(e.RowIndex).Cells(clmIdMceCatLotesDet.Index).Value _
                    , dgvDetalleLote.Rows(e.RowIndex).Cells(clmAreteTransporte.Index).Value _
                    , dgvDetalleLote.Rows(e.RowIndex).Cells(clmAreteSINIIGA.Index).Value _
                    , dgvDetalleLote.Rows(e.RowIndex).Cells(clmArete.Index).Value _
                    , dgvDetalleLote.Rows(e.RowIndex).Cells(clmDetalleKilos.Index).Value _
                    , dgvDetalleLote.Rows(e.RowIndex).Cells(clmDetalleCostoxKilo.Index).Value _
                    , CType(dgvDetalleLote.Rows(e.RowIndex).DataBoundItem, LoteDetClass).IdTipoGanado _
                    , dgvDetalleLote.Rows(e.RowIndex).Cells(clmTipoGanado.Index).FormattedValue.ToString() _
                    , 0D)
                End If
            Else
                Dim Where As String = "IdMceCatLotesDet ='" & dgvDetalleLote.Rows(e.RowIndex).Cells(clmIdMceCatLotesDet.Index).Value & "'"
                Dim dr() As DataRow = dsDetalles.Select(Where)

                dgvDetalleLote.Rows(e.RowIndex).Cells(clmDetalleKilos.Index).Value = 0D

                If dr.Length > 0 Then
                    dsDetalles.RemoveSelDetalleLoteRow(dr(0))
                End If
            End If

            If Not dgvLotes.CurrentRow.Cells(clmKilos.Index).ReadOnly AndAlso IsNumeric(dgvLotes.CurrentRow.Cells(clmKilos.Index).Value) AndAlso dgvLotes.CurrentRow.Cells(clmKilos.Index).Value > 0 Then
                Dim Kilos As Decimal = CType(dgvLotes.CurrentRow.Cells(clmKilos.Index).Value, Decimal)
                Dim Cabezas As Integer = dsDetalles.Rows.Count

                If Cabezas <> 0 Then
                    KilosxCabeza = Kilos / Cabezas
                End If

                For Each Arete As DataGridViewRow In dgvDetalleLote.Rows
                    If CType(Arete.Cells(clmSeleccion.Index), DataGridViewCheckBoxCell).EditingCellFormattedValue Then
                        Arete.Cells(clmDetalleKilos.Index).Value = KilosxCabeza
                        dgvDetalleLote_CellEndEdit(chkTodos, New DataGridViewCellEventArgs(clmDetalleKilos.Index, Arete.Index))
                    End If
                Next
            End If

            If sender.GetType IsNot GetType(CheckBox) Then
                ActualizarCheckBoxGeneral()
                RecalcularDetalleLotes()
                RecalcularMontosGenerales()
            End If
        End If
    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Cursor = Cursors.WaitCursor
        RemoveHandler chkTodos.CheckStateChanged, AddressOf chkTodos_CheckedChanged

        If Not sender.CheckState = CheckState.Checked Then
            sender.CheckState = CheckState.Unchecked
        End If
        AddHandler chkTodos.CheckStateChanged, AddressOf chkTodos_CheckedChanged

        For Each GridRow As DataGridViewRow In dgvDetalleLote.Rows
            Dim chkSeleccionado As DataGridViewCheckBoxCell = GridRow.Cells(clmSeleccion.Index)
            chkSeleccionado.EditingCellFormattedValue = sender.Checked
            chkSeleccionado.Value = sender.Checked
            dgvDetalleLote_CellContentClick(sender, New DataGridViewCellEventArgs(clmSeleccion.Index, GridRow.Index))
        Next
        RecalcularDetalleLotes()
        RecalcularMontosGenerales()
        dgvDetalleLote.Refresh()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub dgvDetalleLote_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleLote.CellEndEdit
        If e.ColumnIndex = clmDetalleKilos.Index Then
            If dgvLotes.CurrentRow IsNot Nothing Then
                If Not IsNumeric(dgvDetalleLote.Rows(e.RowIndex).Cells(clmDetalleKilos.Index).Value) _
                OrElse dgvDetalleLote.Rows(e.RowIndex).Cells(clmDetalleKilos.Index).Value = 0 Then
                    Dim dsDetalles As dsSeleccionDetalleLote.SelDetalleLoteDataTable = CType(dgvLotes.CurrentRow.Tag, dsSeleccionDetalleLote.SelDetalleLoteDataTable)
                    Dim Where As String = "IdMceCatLotesDet ='" & dgvDetalleLote.Rows(e.RowIndex).Cells(clmIdMceCatLotesDet.Index).Value & "'"
                    Dim dr() As DataRow = dsDetalles.Select(Where)

                    CType(dgvDetalleLote.Rows(e.RowIndex).Cells(clmSeleccion.Index), DataGridViewCheckBoxCell).EditingCellFormattedValue = False
                    dgvDetalleLote.Rows(e.RowIndex).Cells(clmSeleccion.Index).Value = False

                    If dr.Length > 0 Then
                        dsDetalles.RemoveSelDetalleLoteRow(dr(0))
                    End If
                    ActualizarCheckBoxGeneral()
                Else
                    If dgvLotes.CurrentRow.Tag IsNot Nothing Then
                        Dim dr() As DataRow = dgvLotes.CurrentRow.Tag.Select("IdMceCatLotesDet = '" & dgvDetalleLote.Rows(e.RowIndex).Cells(clmIdMceCatLotesDet.Index).Value.ToString & "'")

                        If Not dgvDetalleLote.Rows(e.RowIndex).Cells(clmSeleccion.Index).Value Then
                            CType(dgvDetalleLote.Rows(e.RowIndex).Cells(clmSeleccion.Index), DataGridViewCheckBoxCell).EditingCellFormattedValue = True
                            dgvDetalleLote.Rows(e.RowIndex).Cells(clmSeleccion.Index).Value = True
                        End If

                        If dr.Length > 0 Then
                            dr(0).Item("Kilos") = CDec(dgvDetalleLote.Rows(e.RowIndex).Cells(clmDetalleKilos.Index).Value)
                        Else
                            dgvLotes.CurrentRow.Tag.AddSelDetalleLoteRow(dgvDetalleLote.Rows(e.RowIndex).Cells(clmIdMceCatLotesDet.Index).Value _
                                                , dgvDetalleLote.Rows(e.RowIndex).Cells(clmAreteTransporte.Index).Value _
                                                , dgvDetalleLote.Rows(e.RowIndex).Cells(clmAreteSINIIGA.Index).Value _
                                                , dgvDetalleLote.Rows(e.RowIndex).Cells(clmArete.Index).Value _
                                                , dgvDetalleLote.Rows(e.RowIndex).Cells(clmDetalleKilos.Index).Value _
                                                , dgvDetalleLote.Rows(e.RowIndex).Cells(clmDetalleCostoxKilo.Index).Value _
                                                , CType(dgvDetalleLote.Rows(e.RowIndex).DataBoundItem, LoteDetClass).IdTipoGanado _
                                                , dgvDetalleLote.Rows(e.RowIndex).Cells(clmTipoGanado.Index).FormattedValue.ToString() _
                                                , 0D)
                            ActualizarCheckBoxGeneral()
                        End If
                    End If
                End If
                If sender.GetType() IsNot GetType(CheckBox) Then
                    RecalcularDetalleLotes(dgvLotes.CurrentRow, True)
                End If
            End If
            If sender.GetType() IsNot GetType(CheckBox) Then
                RecalcularMontosGenerales()
            End If
        End If
    End Sub

    Private Sub dgvDetalleLote_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvDetalleLote.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales

        If dgvDetalleLote.CurrentCell.ColumnIndex = clmDetalleKilos.Index Then
            AddHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
        End If
    End Sub

    Private Sub dgvLotes_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLotes.CellValueChanged
        If Estado = FormState.Nuevo Then
            Utilerias.RunControlException(Me, "ActualizarDetalleLote", New Object() {e})
        End If
    End Sub

    Private Sub dgvLotes_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLotes.RowEnter
        If Estado = FormState.Nuevo Then
            dgvDetalleLote.DataSource = Nothing

            RemoveHandler chkTodos.CheckStateChanged, AddressOf chkTodos_CheckedChanged
            chkTodos.Checked = False
            AddHandler chkTodos.CheckStateChanged, AddressOf chkTodos_CheckedChanged

            If IsNumeric(dgvLotes.Rows(e.RowIndex).Cells(clmLote.Index).Value) AndAlso IsNumeric(dgvLotes.Rows(e.RowIndex).Cells(clmIdTipoGanado.Index).Value) Then
                Dim Lote As LoteClass = CType(dgvLotes.Rows(e.RowIndex).Cells(clmLote.Index).Tag, LoteClass)
                dgvDetalleLote.DataSource = Lote.Aretes(LoteDetClass.EstatusLoteDetalle.VIGENTE, CType(dgvLotes.Rows(e.RowIndex).Cells(clmIdTipoGanado.Index).Value, Integer))
                ActualizarSeleccion(dgvLotes.Rows(e.RowIndex))
                ActualizarCheckBoxGeneral()
            End If
        ElseIf Estado = FormState.Buscar Then
            dgvDetalleLote.Rows.Clear()
            dgvDetalleLote.DataSource = Nothing

            For Each Detalle As SalidaGanadoDetalleClass In SalidaGanado.Aretes(CType(dgvLotes.Rows(e.RowIndex).Cells(clmLote.Index).Tag, Integer), CType(dgvLotes.Rows(e.RowIndex).Cells(clmIdTipoGanado.Index).Tag, Integer))
                dgvDetalleLote.Rows.Add(True, Detalle.IdMcecatLotesDet, Detalle.AreteTransporte, Detalle.AreteSiniiga, Detalle.Arete, Detalle.Kilos, Detalle.CostoxKilo, Detalle.McgcatTiposdeGanado.Descripcion)
            Next
        End If
    End Sub

    'Esto es en el caso de que no se requiera seleccionar el arete sino simplemente proporcionar la cantidad de cabezas
    Private Sub dgvLotes_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLotes.CellEndEdit
        If Estado = FormState.Nuevo Then
            Utilerias.RunControlException(Me, "FinDeEdicion", New Object() {e})
        End If
    End Sub

    Private Sub dgvDetalleLote_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvDetalleLote.Sorted
        If Estado = FormState.Nuevo Then
            ActualizarSeleccion(dgvLotes.CurrentRow)
        End If
    End Sub

#End Region

End Class