Imports CN = ClasesNegocio
Imports TC = Integralab.ORM.TypedViewClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmReporteMovimientosdeAlmacenGral

    Dim almacen As New CN.AlmacenCollectionClass


    Private Sub frmReporteMovimientosdeAlmacenGral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            almacen.Obtener()
            cmbAlmacen.DataSource = almacen
            cmbAlmacen.DisplayMember = "Descripcion"
            cmbAlmacen.ValueMember = "Codigo"

            movimiento.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            cmbMovimiento.DataSource = movimiento
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error.", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

#Region "Keypress"

    Private Sub frmReporteMovimientosdeAlmacenGral_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbAlmacen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAlmacen.SelectedIndexChanged
        Try
            If Me.cmbAlmacen.SelectedIndex > -1 Then
                Me.txtCodAlmacen.Text = Me.cmbAlmacen.SelectedValue
            End If

        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error.", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub txtCodAlmacen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodAlmacen.KeyPress
        Try
            Me.cmbAlmacen.SelectedValue = Me.txtCodAlmacen.Text

        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("No se encuentra el Almacén.", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub cmbMovimiento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMovimiento.SelectedIndexChanged
        Try
            If (Me.cmbMovimiento.SelectedIndex > -1) Then
                Me.txtCodTipoMovimiento.Text = Me.cmbMovimiento.SelectedValue
            End If

        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error.", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub txtCodTipoMovimiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodTipoMovimiento.KeyPress
        Try
            Me.cmbMovimiento.SelectedValue = Me.txtCodTipoMovimiento.Text
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("No se encuentra el Tipo de Movimiento.", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub
#End Region

    Private Sub Limpiar()
        Me.cmbAlmacen.SelectedIndex = -1
        Me.cmbAlmacen.Text = "Seleccione el Almacén"
        Me.cmbMovimiento.SelectedIndex = -1
        Me.cmbMovimiento.Text = "Seleccione el Movimiento"
        Me.dtpFechaFinal.Value = DateTime.Now
        Me.dtpFechaInicial.Value = DateTime.Now
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

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir

        Try
            Dim Filtro As New OC.PredicateExpression
            Dim Consulta As New TC.VwMovimientosAlmacenGeneralTypedView

            If (Me.cmbAlmacen.SelectedIndex > -1) Then
                Filtro.Add(HC.VwMovimientosAlmacenGeneralFields.Codigo = cmbAlmacen.SelectedValue)
            End If

            Filtro.Add(New OC.FieldBetweenPredicate(HC.VwMovimientosAlmacenGeneralFields.FechaMovimiento, Me.dtpFechaInicial.Value.ToShortDateString, Me.dtpFechaFinal.Value.AddDays(1).ToShortDateString))

            'Filtro.Add(HC.VwReporteMovimientosProduccionFields.FechaMovimiento >= Me.dtpFechaInicial.Value)
            'Filtro.Add(HC.VwReporteMovimientosProduccionFields.FechaMovimiento <= Me.dtpFechaFinal.Value)

            If (Me.cmbMovimiento.SelectedIndex > -1) Then
                Filtro.Add(HC.VwMovimientosAlmacenGeneralFields.TipoMovimientoId = Me.cmbMovimiento.SelectedValue)
            End If


            Consulta.Fill(0, Nothing, True, Filtro)
            'Dim Ventana As New CN.PreVisualizarForm
            'Dim Reporte As New CN.RptMovimientosProduccionAlmacen
            'Reporte.SetDataSource(CType(Consulta, Object))
            'Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            'Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
            'Reporte.SetParameterValue(2, "Almacenes/Reportes/Movimientos de Almacen")
            'Ventana.Reporte = Reporte
            'Ventana.Text = "Reporte de Movimientos de Almacén"
            'Ventana.ShowDialog()


        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Me.Limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
    End Sub
End Class