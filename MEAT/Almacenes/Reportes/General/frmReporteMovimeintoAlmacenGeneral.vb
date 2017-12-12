Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmReporteMovimeintoAlmacenGeneral

    Private Sub Limpiar()
        Me.cmbAlmacen.SelectedIndex = -1
        Me.cmbAlmacen.Text = "Seleccione un almacén"
        Me.cmbProducto.SelectedIndex = -1
        Me.cmbProducto.Text = "Seleccione un producto"
        Me.chkFiltrarFecha.Checked = False
        Me.chkAgruparProducto.Checked = False
    End Sub

    Private Sub frmReporteMovimeintoAlmacenGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.cmbAlmacen.OnActualizaCombo()
            Me.cmbProducto.OnActualizaCombo()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmbAlmacen_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.ActualizarCombo
        Try
            Me.cmbAlmacen.DataSource = CC.AlmacenCollection.GetMultiAsDataTable(Nothing, 0, _
                                New OC.SortExpression(New OC.SortClause(HC.AlmacenFields.Descripcion, _
                                SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Me.cmbAlmacen.DisplayMember = "Descripcion"
            Me.cmbAlmacen.ValueMember = "AlmacenId"
            Me.cmbAlmacen.SelectedIndex = -1
            Me.cmbAlmacen.Text = "Seleccione un almacén"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ComboBoxMejorado1_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProducto.ActualizarCombo
        Try
            Me.cmbProducto.DataSource = CC.ProductoCollection.GetMultiAsDataTable(Nothing, 0, _
                                        New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, _
                                        SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Me.cmbProducto.DisplayMember = "Descripcion"
            Me.cmbProducto.ValueMember = "Codigo"
            Me.cmbProducto.SelectedIndex = -1
            Me.cmbProducto.Text = "Seleccione un producto"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub chkFiltrarFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltrarFecha.CheckedChanged
        If Me.chkFiltrarFecha.Checked Then
            Me.dtpFechaFin.Value = Now
            Me.dtpFechaInicio.Value = Now
        End If
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim filtro As New OC.PredicateExpression

            If Not Me.cmbAlmacen.SelectedIndex = -1 Then _
                    filtro.Add(HC.InventarioMovimientoAlmacenFields.AlmacenId = _
                    CInt(Me.cmbAlmacen.SelectedValue))
            If Not Me.cmbProducto.SelectedIndex = -1 Then _
                    filtro.Add(HC.InventarioMovimientoAlmacenDetallesFields.ProductoId = _
                    CInt(Me.cmbProducto.SelectedValue))
            If Me.chkFiltrarFecha.Checked Then _
                    filtro.Add(New OC.FieldBetweenPredicate(HC.InventarioMovimientoAlmacenFields.FechaMovimiento, _
                    Me.dtpFechaInicio.Value.ToString("yyyy-MM-dd"), _
                    Me.dtpFechaFin.Value.AddDays(1).ToString("yyyy-MM-dd")))

            ClasesNegocio.AlmacenGeneral.MovimientoAlmacenCollectionClass.Imprimir(Controlador.Sesion.MiEmpresa.Empnom, _
                        Controlador.Sesion.MiUsuario.Usrnomcom, _
                        "Almacén/Reportes/General/Movimientos Almacén", Me.chkAgruparProducto.Checked, filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
End Class