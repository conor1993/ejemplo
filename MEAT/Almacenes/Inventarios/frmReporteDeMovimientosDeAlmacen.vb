Imports CN = ClasesNegocio
Imports TC = Integralab.ORM.TypedViewClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses


Public Class frmReporteDeMovimientosDeAlmacen

    Dim InvAlm As New CN.AlmacenGeneral.InventarioAlmacenCollectionClass
    Dim almacen As New CN.AlmacenCollectionClass

#Region "Key Press"
    Private Sub cmbAlmacen_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbAlmacen.KeyPress
        If (Keys.Enter) Then
            cmbMovimiento.Focus()
        End If
    End Sub

    Private Sub cmbMovimiento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMovimiento.KeyPress
        If (Keys.Enter) Then
            dtpFechaInicial.Focus()
        End If
    End Sub


    Private Sub dtpFechaInicial_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaInicial.KeyPress
        If (Keys.Enter) Then
            dtpFechaFinal.Focus()
        End If
    End Sub
#End Region

#Region "Metodos"

    Private Sub Limpiar()
        Me.cmbAlmacen.SelectedIndex = -1
        Me.cmbAlmacen.Text = "Seleccione el Almacén"
        Me.cmbMovimiento.SelectedIndex = -1
        Me.cmbMovimiento.Text = "Seleccione el Movimiento"
        Me.dtpFechaFinal.Value = DateTime.Now
        Me.dtpFechaInicial.Value = DateTime.Now
    End Sub

    Private Sub Deshabilitar()
        Me.cmbAlmacen.Enabled = False
        Me.cmbMovimiento.Enabled = False
        Me.dtpFechaFinal.Enabled = False
        Me.dtpFechaInicial.Enabled = False
    End Sub

    Private Sub Habilitar()
        Me.cmbAlmacen.Enabled = True
        Me.cmbMovimiento.Enabled = True
        Me.dtpFechaFinal.Enabled = True
        Me.dtpFechaInicial.Enabled = True
    End Sub

#End Region

    Private Sub frmReporteDeMovimientosDeAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            almacen.Obtener()
            cmbAlmacen.DataSource = almacen
            cmbAlmacen.DisplayMember = "Descripcion"
            cmbAlmacen.ValueMember = "Codigo"

            movimiento.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            cmbMovimiento.DataSource = movimiento
            'cmbAlmacen.DisplayMember = "Descripcion"
            'cmbAlmacen.ValueMember = "Codigo"

            Limpiar()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir

        Try
            Dim Filtro As New OC.PredicateExpression
            Dim Consulta As New TC.VwReporteMovimientosProduccionTypedView

            Filtro.Add(New OC.FieldBetweenPredicate(HC.VwReporteMovimientosProduccionFields.FechaMovimiento, Me.dtpFechaInicial.Value.ToShortDateString, Me.dtpFechaFinal.Value.AddDays(1).ToShortDateString))

            If (Me.cmbAlmacen.SelectedIndex > -1) Then
                Filtro.Add(HC.VwReporteMovimientosProduccionFields.Codigo = cmbAlmacen.SelectedValue)
            End If

            If (Me.cmbMovimiento.SelectedIndex > -1) Then
                Filtro.Add(HC.VwReporteMovimientosProduccionFields.IdMovimiento = Me.cmbMovimiento.SelectedValue)
            End If

            Consulta.Fill(0, Nothing, True, Filtro)
            If Consulta.Count = 0 Then
                MsgBox("No existe informacion para este reporte", MsgBoxStyle.Information, "MEAT")
                Exit Sub
            End If
            Dim Ventana As New CN.PreVisualizarForm
            Dim Reporte As New CN.RptMovimientosProduccionAlmacen
            Reporte.SetDataSource(CType(Consulta, Object))
            Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
            Reporte.SetParameterValue(2, "Almacenes/Reportes/Produccion/Movimientos de Almacen")
            Ventana.Reporte = Reporte
            Ventana.Text = "Reporte de Movimientos de Almacén"
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
        If (dtpFechaInicial.Value > dtpFechaFinal.Value) Then
            dtpFechaFinal.Value = dtpFechaInicial.Value
        End If
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
    End Sub
End Class

