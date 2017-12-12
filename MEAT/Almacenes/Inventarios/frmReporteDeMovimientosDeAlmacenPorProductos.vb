Imports CN = ClasesNegocio
Imports TC = Integralab.ORM.TypedViewClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses


Public Class frmReporteDeMovimientosDeAlmacenPorProductos
    Dim Producto As New CN.ProductosCollectionsClass
    Dim almacen As New CN.AlmacenCollectionClass

#Region "KeyPress"

    Private Sub txtProducto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProducto.KeyPress
        If (Keys.Enter) Then
            cmbProducto.Focus()
        End If
    End Sub

    Private Sub cmbProducto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbProducto.KeyPress
        If (Keys.Enter) Then
            txtAlmacen.Focus()
        End If
    End Sub

    Private Sub txtAlmacen_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAlmacen.KeyPress
        If (Keys.Enter) Then
            cmbAlmacen.Focus()
        End If
    End Sub

    Private Sub cmbAlmacen_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbAlmacen.KeyPress
        If (Keys.Enter) Then
            txtMovimiento.Focus()
        End If
    End Sub

    Private Sub txtMovimiento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMovimiento.KeyPress
        If (Keys.Enter) Then
            cmbMovimiento.Focus()
        End If
    End Sub

    Private Sub cmbMovimiento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMovimiento.KeyPress
        If (Keys.Enter) Then
            Me.dtpFechaInicial.Focus()
        End If
    End Sub

    Private Sub dtpFechaActual_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaInicial.KeyPress
        If (Keys.Enter) Then
            Me.dtpFechaFinal.Focus()
        End If
    End Sub

#End Region

#Region "Metodos"

    Private Sub Limpiar()
        Me.cmbProducto.SelectedIndex = -1
        Me.cmbProducto.Text = "Seleccione Producto"
        Me.cmbAlmacen.SelectedIndex = -1
        Me.cmbAlmacen.Text = "Seleccione el Almacén"
        Me.cmbMovimiento.SelectedIndex = -1
        Me.cmbMovimiento.Text = "Seleccione Tipo Movimiento"
        Me.txtAlmacen.Text = Nothing
        Me.txtMovimiento.Text = Nothing
        Me.txtProducto.Text = Nothing
        Me.dtpFechaInicial.Value = DateTime.Now
        Me.dtpFechaFinal.Value = DateTime.Now
    End Sub

    Private Sub Deshabilitar()
        Me.cmbProducto.Enabled = False
        Me.cmbAlmacen.Enabled = False
        Me.cmbMovimiento.Enabled = False
        Me.txtAlmacen.Enabled = False
        Me.txtMovimiento.Enabled = False
        Me.txtProducto.Enabled = False
        Me.dtpFechaInicial.Enabled = False
        Me.dtpFechaFinal.Enabled = False
    End Sub

    Private Sub Habilitar()
        Me.cmbProducto.Enabled = True
        Me.cmbMovimiento.Enabled = True
        Me.cmbAlmacen.Enabled = True
        Me.txtAlmacen.Enabled = True
        Me.txtMovimiento.Enabled = True
        Me.txtProducto.Enabled = True
        Me.dtpFechaInicial.Enabled = True
        Me.dtpFechaFinal.Enabled = True
    End Sub
#End Region

    Private Sub frmReporteDeMovimientosDeAlmacenPorProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Producto.Obtener(ClasesNegocio.CondicionEstatusEnum.TODOS, False)
            cmbProducto.DataSource = Producto
            cmbProducto.DisplayMember = "Descripcion"
            cmbProducto.ValueMember = "IdProducto"

            almacen.Obtener()
            cmbAlmacen.DataSource = almacen
            cmbAlmacen.DisplayMember = "Descripcion"
            cmbAlmacen.ValueMember = "Codigo"

            movimiento.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            cmbMovimiento.DataSource = movimiento
            'cmbAlmacen.DisplayMember = "Nombre"
            'cmbAlmacen.ValueMember = "Codigo"

            Me.Limpiar()

        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir

        Try
            Dim Filtro As New OC.PredicateExpression
            Dim Consulta As New TC.VwReporteMovimientosProduccionTypedView

            If (Me.cmbProducto.SelectedIndex > -1) Then
                Filtro.Add(HC.VwReporteMovimientosProduccionFields.IdProducto = cmbProducto.SelectedValue)

            End If

            If (Me.cmbAlmacen.SelectedIndex > -1) Then
                Filtro.Add(HC.VwReporteMovimientosProduccionFields.Codigo = Me.cmbAlmacen.SelectedValue)
            End If

            If (Me.cmbMovimiento.SelectedIndex > -1) Then
                Filtro.Add(HC.VwReporteMovimientosProduccionFields.IdMovimiento = Me.cmbMovimiento.SelectedValue)
            End If

            Filtro.Add(New OC.FieldBetweenPredicate(HC.VwReporteMovimientosProduccionFields.FechaMovimiento, Me.dtpFechaInicial.Value.ToShortDateString, Me.dtpFechaFinal.Value.AddDays(1).ToShortDateString))

            Consulta.Fill(0, Nothing, True, Filtro)
            Dim Ventana As New CN.PreVisualizarForm
            Dim Reporte As New CN.RptMovimientosDeAlmacenPorProductos
            Reporte.SetDataSource(CType(Consulta, Object))
            Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
            Reporte.SetParameterValue(2, "Almacenes/Reportes/Movimientos de Almacen por Productos")
            Ventana.Reporte = Reporte
            Ventana.Text = "Reporte de Movimientos de Almacén por Productos"
            Ventana.ShowDialog()


        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try

    End Sub

    Private Sub dtpFechaInicial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaInicial.ValueChanged
        If (dtpFechaInicial.Value > dtpFechaFinal.Value) Then
            dtpFechaInicial.Value = dtpFechaFinal.Value
        End If
    End Sub

    Private Sub dtpFechaFinal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaFinal.ValueChanged
        If (dtpFechaInicial.Value < dtpFechaFinal.Value) Then
            dtpFechaFinal.Value = dtpFechaFinal.Value
        End If
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub cmbMovimiento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMovimiento.SelectedIndexChanged

    End Sub
End Class