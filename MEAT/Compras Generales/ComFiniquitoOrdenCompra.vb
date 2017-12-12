Imports ClasesNegocio
Imports Hc = IntegraLab.ORM.HelperClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ComFiniquitoOrdenCompra

    Dim Orden As ClasesNegocio.OrdenCompraClass

    Private Sub ComFiniquitoOrdenCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

            limpiar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CmbPlaza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(CType(sender, Control), True, True, False, True)
            cmbSucursal.Focus()
            If cmbPlaza.Text = "" Then
                MsgBox("Seleccione una Plaza")
                cmbPlaza.Focus()
            End If
        End If
    End Sub

#Region "Private"
    Private Sub limpiar()
        cmbPlaza.SelectedValue = "Seleccione Plaza"
        cmbSucursal.SelectedValue = "Seleccione Sucursal"
        txtCantidadSolicitada.Clear()
        txtCantidadEmitida.Clear()
        txtSubTotal.Clear()
        txtDescuento.Clear()
        txtTotal.Clear()
        txtIVA.Clear()
        'TxtCanSolS.Clear()
        'TxtCanES.Clear()
        'TxtSTot.Clear()
        'TxtDto.Clear()
        'TxtIvaS.Clear()
        'TxtTotalS.Clear()
        dgvDetalleOrdenCompra.DataSource = Nothing
        Me.VwCompFiniquitoOrdenCompraTypedView1.Clear()
        OrdenCompraC.Clear()
    End Sub

    Private Sub habilitar()
        cmbPlaza.Enabled = True
        cmbSucursal.Enabled = True
        txtCantidadSolicitada.Enabled = True
        txtCantidadEmitida.Enabled = True
        txtSubTotal.Enabled = True
        txtTotal.Enabled = True
        txtIVA.Enabled = True
        'TxtCanSolS.Enabled = True
        'TxtCanES.Enabled = True
        'TxtSTot.Enabled = True
        'TxtDto.Enabled = True
        'TxtIvaS.Enabled = True
        'TxtTotalS.Enabled = True
        Me.dgOrdenesCompra.Enabled = True
        dgvDetalleOrdenCompra.Enabled = True
        'DgListOrdServ.Enabled = True
        'DgDetOrdSer.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        cmbPlaza.Enabled = False
        cmbSucursal.Enabled = False
        txtCantidadSolicitada.Enabled = False
        txtCantidadEmitida.Enabled = False
        txtSubTotal.Enabled = False
        txtTotal.Enabled = False
        txtIVA.Enabled = False
        'TxtCanSolS.Enabled = False
        'TxtCanES.Enabled = False
        'TxtSTot.Enabled = False
        'TxtDto.Enabled = False
        'TxtIvaS.Enabled = False
        'TxtTotalS.Enabled = False
        Me.dgOrdenesCompra.Enabled = False
        dgvDetalleOrdenCompra.Enabled = False
        'DgListOrdServ.Enabled = False
        'DgDetOrdSer.Enabled = False
    End Sub

    Private Sub SumarCantidades()
        If Not Orden Is Nothing Then
            Dim cants, cante As Decimal

            For Each det As ClasesNegocio.OrdenCompraDetalleClass In Orden.Detalle
                cants += det.CantidadSolicitada
                cante += det.CantidadOrdenada
            Next

            txtCantidadSolicitada.Text = cants.ToString("N3")
            txtCantidadEmitida.Text = cante.ToString("N3")
        Else
            txtCantidadSolicitada.Text = 0.ToString("N3")
            txtCantidadEmitida.Text = 0.ToString("N3")
        End If
    End Sub
#End Region

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        'Dim Vista As T
        Try
            'Me.Clear()
            Dim Filtro As New OC.PredicateExpression

            If Val(Me.cmbPlaza.SelectedValue) > 0 Then
                Filtro.Add(Hc.VwCompFiniquitoOrdenCompraFields.IdPlaza = Me.cmbPlaza.SelectedValue)
            End If

            If Me.cmbSucursal.SelectedIndex > 0 Then
                Filtro.Add(Hc.VwCompFiniquitoOrdenCompraFields.SucursalId = Me.cmbSucursal.SelectedValue)
            End If

            Me.VwCompFiniquitoOrdenCompraTypedView1.Clear()
            Me.VwCompFiniquitoOrdenCompraTypedView1.Fill(0, Nothing, True, Filtro)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickGuardar
        Dim Trans As New Hc.Transaction(IsolationLevel.ReadCommitted, "Finiquito")
        Dim ordn As ClasesNegocio.OrdenCompraClass
        Try


            If Me.dgOrdenesCompra.Rows.Count > 0 Then
                Me.dgOrdenesCompra.Rows(0).Cells(1).Selected = True

            Else
                'mensaje de validacion
            End If


            Cursor = Cursors.WaitCursor

            If Validar() Then

                'Me.dgOrdenesCompra.Rows(Me.dgOrdenesCompra.Rows.Count - 1).Cells(2).Selected = True

                'For Each ord As ClasesNegocio.OrdenCompraClass In OrdenCompraC
                '    If ord.Autorizada Then
                '        ord.FechaAutorizacion = Now
                '    End If
                'Next
                For i As Integer = 0 To Me.dgOrdenesCompra.Rows.Count - 1
                    With Me.dgOrdenesCompra.Rows(i)
                        If CBool(.Cells(Me.clmSeleccion.Index).Value) Then
                            ordn = New ClasesNegocio.OrdenCompraClass
                            'ordn.Folio = .Cells(Me.FolioDataGridViewTextBoxColumn.Index).Value

                            If ordn.Obtener(.Cells(Me.clmIdOrdenCompra.Index).Value.ToString) Then
                                ordn.Estatus = EstatusOrdenCompra.FINIQUITADO
                                ordn.Guardar(Trans)
                            End If
                        End If
                    End With
                Next

                'If OrdenCompraC.ObtenerColeccion.SaveMulti() > 0 Then
                Trans.Commit()
                MsgBox("Se ha finiquitado la orden de compra", MsgBoxStyle.Information, Controlador.Empresa.Nombre)
                'End If

                limpiar()
            Else
                MsgBox("Debe seleccionar una orden", MsgBoxStyle.Exclamation, "Aviso")
            End If
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Function Validar() As Boolean
        Dim variable As Boolean = False
        For i As Integer = 0 To Me.dgOrdenesCompra.Rows.Count - 1
            With Me.dgOrdenesCompra.Rows(i)
                If CBool(.Cells(Me.clmSeleccion.Index).Value) Then
                    variable = True
                    Exit For
                End If
            End With
        Next
        Return variable
    End Function

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickLimpiar
        limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
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

    Private Sub dgOrdenesCompra_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgOrdenesCompra.Click
        Try
            If Me.dgOrdenesCompra.SelectedRows.Count > 0 Then
                Dim IdOrdenCompra As Integer = Me.dgOrdenesCompra.SelectedRows(0).Cells(Me.clmIdOrdenCompra.Index).Value.ToString

                'Orden = New OrdenCompraClass(IdOrdenCompra)
                Orden.Obtener(IdOrdenCompra)
                Me.dgvDetalleOrdenCompra.AutoGenerateColumns = False
                Me.dgvDetalleOrdenCompra.DataSource = Orden.Detalle

                Me.txtImporte.Text = Orden.Importe.ToString("C2")
                Me.txtDescuento.Text = Orden.Descuento.ToString("C2")
                Me.txtSubTotal.Text = Orden.SubTotal.ToString("C2")
                txtIVA.Text = Orden.IVATotal.ToString("C2")
                txtTotal.Text = Orden.Total.ToString("C2")

                SumarCantidades()
            Else
                Orden = Nothing
                dgvDetalleOrdenCompra.DataSource = Nothing

                Me.txtImporte.Clear()
                Me.txtDescuento.Clear()
                Me.txtSubTotal.Clear()
                txtTotal.Clear()
                txtIVA.Clear()

                SumarCantidades()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    'Private Sub DataGridView1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgOrdenesCompra.KeyPress
    '    Try
    '        If e.KeyChar = Chr(13) Then
    '            If Me.dgOrdenesCompra.SelectedRows.Count > 0 Then
    '                Orden = DirectCast(Me.dgOrdenesCompra.SelectedRows(0).DataBoundItem, ClasesNegocio.OrdenCompraClass)

    '                Me.dgvDetalleOrdenCompra.DataSource = Orden.Detalle
    '                Me.txtImporte.Text = Orden.Importe.ToString("C2")
    '                Me.txtDescuento.Text = Orden.Descuento.ToString("C2")
    '                Me.txtSubTotal.Text = Orden.SubTotal.ToString("C2")
    '                txtTotal.Text = Orden.IVATotal.ToString("C2")
    '                txtIVA.Text = Orden.Total.ToString("C2")

    '                SumarCantidades()
    '            Else
    '                Orden = Nothing
    '                dgvDetalleOrdenCompra.DataSource = Nothing

    '                Me.txtImporte.Clear()
    '                Me.txtDescuento.Clear()
    '                Me.txtSubTotal.Clear()
    '                txtTotal.Clear()
    '                txtIVA.Clear()

    '                SumarCantidades()
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub

    Private Sub dgOrdenesCompra_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgOrdenesCompra.CellContentClick

    End Sub

    Private Sub cmbSucursal_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbSucursal.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.cmbPlaza_SelectedIndexChanged(Me, e)
                Me.cmbSucursal.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgOrdenesCompra_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgOrdenesCompra.RowEnter
        Try
            If Me.dgOrdenesCompra.SelectedRows.Count > 0 Then
                Dim IdOrdenCompra As Integer = Me.dgOrdenesCompra.SelectedRows(0).Cells(Me.clmIdOrdenCompra.Index).Value.ToString
                Orden = New OrdenCompraClass(IdOrdenCompra)

                Me.dgvDetalleOrdenCompra.AutoGenerateColumns = False
                Me.dgvDetalleOrdenCompra.DataSource = Orden.Detalle

                Me.txtImporte.Text = Orden.Importe.ToString("C2")
                Me.txtDescuento.Text = Orden.Descuento.ToString("C2")
                Me.txtSubTotal.Text = Orden.SubTotal.ToString("C2")
                txtIVA.Text = Orden.IVATotal.ToString("C2")
                txtTotal.Text = Orden.Total.ToString("C2")

                SumarCantidades()
            Else
                Orden = Nothing
                dgvDetalleOrdenCompra.DataSource = Nothing

                Me.txtImporte.Clear()
                Me.txtDescuento.Clear()
                Me.txtSubTotal.Clear()
                txtTotal.Clear()
                txtIVA.Clear()

                SumarCantidades()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class