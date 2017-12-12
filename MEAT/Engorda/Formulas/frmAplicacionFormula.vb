Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio

Public Class frmAplicacionFormula

#Region "Miembros"
    Dim aplicacion As AplicacionFormulaClass
    Dim seleccionando As Boolean = False
    Dim configuracion As EC.ConfigGanEntity
    Dim cargando As Boolean = False
#End Region

#Region "Metodos"
    Private Sub Limpiar()
        Me.txtCabezas.Text = 0
        Me.txtNumCorrales.Text = 0
        Me.txtNumLotes.Text = 0
        Me.txtFolio.Clear()
        Me.txtEstimadoPorFormula.Text = 0D
        Me.txtTotalServidas.Text = 0D
        Me.dgDetalle.DataSource = Nothing
        Me.dgFormulas.DataSource = Nothing
        Me.dtFecha.Value = Now
        Me.cmbAlmacen.SelectedIndex = -1
        Me.cmbAlmacen.Text = "Seleccione un almacén"
        Me.chkSoloFormulas.Checked = True
    End Sub

    Private Sub Habilitar()
        Me.dtFecha.Enabled = True
        Me.dgDetalle.ReadOnly = False
        Me.LoteDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalServidasDataGridViewTextBoxColumn.ReadOnly = True
        Me.cmbAlmacen.Enabled = True
        Me.txtCodigoAlmacen.Enabled = True
        Me.chkSoloFormulas.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        Me.chkSoloFormulas.Enabled = False
        Me.dtFecha.Enabled = False
        Me.dgDetalle.ReadOnly = True
        Me.cmbAlmacen.Enabled = False
        Me.txtCodigoAlmacen.Enabled = False
    End Sub

    Private Sub ObtenerCorralesYFormulas()
        If cargando Then Exit Sub

        Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)

        Try
            Dim sqlComCorrales As New SqlClient.SqlCommand( _
                                                            "SELECT      MCECatCorralesCab.IdCorral, MCECatCorralesCab.NombreCorral " & _
                                                            "FROM       MCECatCorralesCab INNER JOIN " & _
                                                            "           MCECatCorralesDet ON MCECatCorralesCab.IdCorral = MCECatCorralesDet.IdCorral " & _
                                                            "WHERE      (MCECatCorralesCab.Estatus = 1) " & _
                                                            "GROUP BY MCECatCorralesCab.IdCorral, MCECatCorralesCab.NombreCorral " & _
                                                            "HAVING SUM(MCECatCorralesDet.ExistCabezas) > 0.0", _
                                                            sqlCon)
            Dim sqlComFormulas As New SqlClient.SqlCommand( _
                                      String.Format("SELECT     MCatCompProductos.PdIdProducto AS Codigo, " & _
                                                    "           MCatCompProductos.PdDescripcion AS Descripcion, " & _
                                                    "           Alm.AlmacenId " & _
                                                    "FROM       MCatCompProductos INNER JOIN " & _
                                                    "           MInvAlmacen AS Alm ON MCatCompProductos.PdIdProducto = " & _
                                                    "           Alm.ProductoId " & _
                                                    "WHERE      MCatCompProductos.PdEstatus = 1 {1} " & _
                                                    "GROUP BY   MCatCompProductos.PdIdProducto, " & _
                                                    "           MCatCompProductos.PdDescripcion, Alm.AlmacenId " & _
                                                    "HAVING     Alm.AlmacenId = {0} AND (SELECT   TOP 1 CantidadExistencia " & _
                                                    "                                   FROM    dbo.MInvAlmacen " & _
                                                    "                                   WHERE	dbo.MInvAlmacen.AlmacenId={0} AND " & _
                                                    "                                           dbo.MInvAlmacen.ProductoId = " & _
                                                    "                                           MCatCompProductos.PdIdProducto " & _
                                                    "                                   ORDER BY	dbo.MInvAlmacen.Año DESC, dbo.MInvAlmacen.Mes DESC)>0.0", _
                                                    CInt(Me.cmbAlmacen.SelectedValue), _
                                                    IIf(Me.chkSoloFormulas.Checked, "AND MCatCompProductos.PdMezcla=1", "")), _
                                                    sqlCon)


            Dim daCorrales As New SqlClient.SqlDataAdapter(sqlComCorrales)
            Dim daFormulas As New SqlClient.SqlDataAdapter(sqlComFormulas)
            Dim tbCorrales As New DataTable
            Dim tbFormulas As New DataTable

            sqlCon.Open()
            daCorrales.Fill(tbCorrales)
            daFormulas.Fill(tbFormulas)

            Me.FormulaDataGridViewTextBoxColumn.DataSource = tbFormulas
            Me.CorralDataGridViewTextBoxColumn.DataSource = tbCorrales
            Me.FormulaDataGridViewTextBoxColumn.ValueMember = "Codigo"
            Me.FormulaDataGridViewTextBoxColumn.DisplayMember = "Descripcion"
            'Me.listaFormulas.Clear()
            '' Me.listaCorrales.Clear()

            'Me.listaFormulas.Fill(0, New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, _
            '        SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), False, HC.ProductoFields.Estatus = 1)
            'Me.listaCorrales.Fill(0, New OC.SortExpression(New OC.SortClause(HC.McecatCorralesCabFields.NombreCorral, _
            'SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), False, HC.McecatCorralesCabFields.Estatus = 1)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    'Private Sub AplicacionFormulaDetalleC_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs)
    '    Try
    '        Dim nuevoDetalle As New ClasesNegocio.AplicacionFormulaDetalleClass

    '        e.NewObject = nuevoDetalle

    '        nuevoDetalle.AplicacionFormula = Me.aplicacion
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub
#End Region

#Region "Eventos"
#Region "CheckBox"
    Private Sub chkSoloFormulas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSoloFormulas.CheckedChanged
        If Me.cargando Then Exit Sub
        ObtenerCorralesYFormulas()
    End Sub
#End Region

#Region "ComboBox"
    Private Sub cmbAlmacen_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.ActualizarCombo
        Try
            cargando = True
            Me.cmbAlmacen.ValueMember = "AlmacenId"
            Me.cmbAlmacen.DataSource = CC.AlmacenCollection.GetMultiAsDataTable(HC.AlmacenFields.TipoAlmacen = _
                                Me.configuracion.IdTipoAlmacenFormula And _
                                HC.AlmacenFields.Estatus = 1, _
                                0, New OC.SortExpression(New OC.SortClause(HC.AlmacenFields.Descripcion, _
                                SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), Nothing)
            Me.cmbAlmacen.DisplayMember = "Descripcion"
            Me.cmbAlmacen.SelectedIndex = -1
            Me.cmbAlmacen.Text = "Seleccione un almacén"
            cargando = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmbAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.SelectedIndexChanged
        Try
            If Me.cmbAlmacen.SelectedIndex > -1 Then
                Me.dgDetalle.ReadOnly = False
                Me.LoteDataGridViewTextBoxColumn.ReadOnly = True
                Me.TotalServidasDataGridViewTextBoxColumn.ReadOnly = True
                Me.aplicacion.IdAlmacen = CInt(Me.cmbAlmacen.SelectedValue)
                Me.ObtenerCorralesYFormulas()
            Else
                Me.dgDetalle.ReadOnly = True
                Me.FormulaDataGridViewTextBoxColumn.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "Form"
    Private Sub frmAplicacionFormula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargando = True
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
            Me.Deshabilitar()
            cargando = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "ToolBar"
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Cursor = Cursors.WaitCursor

        Try
            If Me.aplicacion.Estatus = AplicacionFormulaClass.EstatusAplicacionFormula.CANCELADA Then
                MsgBox("La Aplicación ya esta cancelada", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            ElseIf Me.aplicacion.Estatus = AplicacionFormulaClass.EstatusAplicacionFormula.CONTABILIZADA Then
                MsgBox("La Aplicación ya esta contabilizada", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            ElseIf MessageBox.Show("¿Quiere Cancelar La Aplicación De Formula", "Aplicación Formula", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                Cancelar = True
                Exit Sub
            End If

            Me.aplicacion.FechaCancelacion = Now
            Me.aplicacion.IdUsuarioCancelacion = Controlador.Sesion.Usrndx

            If aplicacion.Borrar Then
                MsgBox("Se a cancelado la aplicación de formula", MsgBoxStyle.Information, "Aplicación Cancelada")
                Me.Limpiar()
                Me.Deshabilitar()
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

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim configuracionEngorda As New CC.ConfigGanCollection

            configuracionEngorda.GetMulti(Nothing, 1)

            If configuracionEngorda.Count = 0 Then
                MsgBox("Primero establesca una configuracón de engorda, Engorda/Configuración", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            Else
                configuracion = configuracionEngorda(0)
            End If

            Dim ventana As New frmBusquedaAplicacionFormula

            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.aplicacion = ventana.AplicacionFormula

                Me.txtFolio.Text = Me.aplicacion.FolioAplicacionFormula
                Me.dtFecha.Value = Me.aplicacion.FechaAplicacion
                Me.cmbAlmacen.OnActualizaCombo()
                Me.cmbAlmacen.SelectedValue = Me.aplicacion.IdAlmacen
                Me.aplicacion.CalcularFormulasAplicadas()
                Me.dgDetalle.AutoGenerateColumns = False
                Me.dgDetalle.DataSource = Me.aplicacion.Detalle
                Me.dgFormulas.AutoGenerateColumns = False
                Me.dgFormulas.DataSource = Me.aplicacion.FormulasAplicadas
                Me.txtTotalServidas.Text = Me.aplicacion.TotalServidas.ToString("N3")
                Me.txtEstimadoPorFormula.Text = (Me.aplicacion.TotalServidas / Me.aplicacion.Cabezas).ToString("N3")
                Me.txtCabezas.Text = Me.aplicacion.Cabezas
                Me.dgDetalle.ReadOnly = True
                Me.chkSoloFormulas.Checked = False
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Me.Limpiar()
        Me.Deshabilitar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar

    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Me.dgDetalle.Rows.Count > 1 Then
                Me.dgDetalle.Rows(0).Cells(0).Selected = True
            End If

            Me.aplicacion.IdAlmacen = Me.cmbAlmacen.SelectedValue

            Me.aplicacion.IdUsuarioAlta = Controlador.Sesion.Usrndx
            Me.aplicacion.FechaAplicacion = Me.dtFecha.Value

            If Me.aplicacion.Guardar Then
                MsgBox("Se realizo la aplicación de las formulas con el folio : " & _
                    Me.aplicacion.FolioAplicacionFormula, MsgBoxStyle.Information, "Aviso")
                Me.Limpiar()
                Me.Deshabilitar()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Try
            Dim configuracionEngorda As New CC.ConfigGanCollection

            configuracionEngorda.GetMulti(Nothing, 1)

            If configuracionEngorda.Count = 0 Then
                MsgBox("Primero establesca una configuracón de engorda, Engorda/Configuración", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            Else
                configuracion = configuracionEngorda(0)
            End If

            Me.aplicacion = New AplicacionFormulaClass
            Me.dgDetalle.AutoGenerateColumns = False
            Me.dgDetalle.DataSource = Me.aplicacion.Detalle
            Me.dgFormulas.AutoGenerateColumns = False
            Me.dgFormulas.DataSource = Me.aplicacion.FormulasAplicadas
            'Me.ObtenerCorralesYFormulas()
            Me.cmbAlmacen.OnActualizaCombo()
            Me.Habilitar()

            'AddHandler aplicacion.Detalle.AddingNew, AddressOf AplicacionFormulaDetalleC_AddingNew
            Me.dtFecha.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region

#Region "DataGridView"
    Private Sub dgDetalle_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDetalle.CellEndEdit
        Try
            Me.dgDetalle.Refresh()

            If e.ColumnIndex = Me.FormulaDataGridViewTextBoxColumn.Index OrElse e.ColumnIndex = Me.CorralDataGridViewTextBoxColumn.Index Then
                Dim encontroRepetida As Boolean = False

                For Each det As AplicacionFormulaDetalleClass In Me.aplicacion.Detalle
                    For Each det2 As AplicacionFormulaDetalleClass In Me.aplicacion.Detalle
                        If Not det.Equals(det2) AndAlso det.IdFormula = det2.IdFormula AndAlso _
                                det.IdCorral = det2.IdCorral Then
                            encontroRepetida = True
                            GoTo SALIRSICLO
                        End If
                    Next
                Next

SALIRSICLO:

                If encontroRepetida Then
                    MsgBox("No se debe repetir la misma formula en el mismo corral", MsgBoxStyle.Exclamation, "Aviso")
                    Me.dgDetalle.Rows.RemoveAt(e.RowIndex)
                    Me.dgDetalle.Refresh()
                    Me.dgDetalle.Rows(Me.dgDetalle.Rows.Count - 1).Cells(0).Selected = True
                ElseIf Me.dgDetalle.Rows.Count > 1 AndAlso Me.aplicacion.Detalle.Count >= 1 AndAlso _
                    Not Me.aplicacion.Detalle(0).Formula.IsNew Then
                    Me.aplicacion.CalcularFormulasAplicadas()
                    Me.txtTotalServidas.Text = Me.aplicacion.TotalServidas.ToString("N4")
                    Me.txtCabezas.Text = Me.aplicacion.Cabezas.ToString("N0")
                    Me.txtEstimadoPorFormula.Text = (Me.aplicacion.TotalServidas / Me.aplicacion.FormulasAplicadas.Count).ToString("N4")
                End If
            Else
                Me.aplicacion.CalcularFormulasAplicadas()
                Me.txtTotalServidas.Text = Me.aplicacion.TotalServidas.ToString("N4")
                Me.txtCabezas.Text = Me.aplicacion.Cabezas.ToString("N0")
                Me.txtEstimadoPorFormula.Text = (Me.aplicacion.TotalServidas / Me.aplicacion.FormulasAplicadas.Count).ToString("N4")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgDetalle_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDetalle.CellEnter
        Try
            If e.RowIndex = Me.dgDetalle.Rows.Count - 1 Then
                Me.txtCabezas.Text = 0
                Me.txtNumCorrales.Clear()
                Me.txtNumLotes.Clear()

                Exit Sub
            End If


            If e.ColumnIndex = Me.LoteAlmacenDataGridViewTextBoxColumn.Index Then
                Me.dgDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = _
                        Not Me.aplicacion.Detalle(e.RowIndex).Formula.SeManejaPorLotes
            End If

            Me.txtCabezas.Text = Me.aplicacion.Detalle(e.RowIndex).Cabezas
            Me.txtNumCorrales.Text = Me.aplicacion.Detalle(e.RowIndex).Corral.Descripcion
            Me.txtNumLotes.Text = Me.aplicacion.Detalle(e.RowIndex).Lote.Descripcion
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgDetalle_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgDetalle.DataError

    End Sub

    Private Sub dgDetalle_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDetalle.SelectionChanged
        If Me.seleccionando OrElse Me.dgDetalle.CurrentRow Is Nothing OrElse Me.aplicacion Is Nothing Then Exit Sub

        Try
            Dim filaSeleccionada As Integer = Me.dgDetalle.CurrentCell.RowIndex

            For i As Integer = 0 To Me.aplicacion.Detalle.Count - 1
                If i = filaSeleccionada Then Continue For

                Dim det As AplicacionFormulaDetalleClass = aplicacion.Detalle(i)

                If det.IdCorral = "" OrElse det.IdFormula = 0 OrElse _
                    (det.Formula.SeManejaPorLotes AndAlso det.LoteAlmacen = "") OrElse _
                    (det.CantidadServida1 = 0D AndAlso det.CantidadServida2 = 0D AndAlso _
                    det.CantidadServida3 = 0D AndAlso det.CantidadServida4 = 0D) Then
                    Me.seleccionando = True
                    Me.dgDetalle.Rows(i).Cells(Me.dgDetalle.CurrentCell.ColumnIndex).Selected = True
                    Me.seleccionando = False
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region
#End Region
End Class