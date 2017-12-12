Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = IntegraLab.ORM.TypedViewClasses

Public Class frmReporteDevoluciones
    Dim ClientesV As New ClasesNegocio.ClientesIntroductoresColeccion

    Private Sub frmReporteDevoluciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ClientesV.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)
            Me.CmbClientes.ValueMember = "Codigo"
            Me.CmbClientes.DisplayMember = "Nombre"
            Me.CmbClientes.DataSource = ClientesV

            Dim TablaProductos As New DataSet

            Dim Productos As New ClasesNegocio.ProductosClass
            TablaProductos = Productos.Obtener(0, "", 0, 9)

            cmbProducto.ValueMember = "IdCorte"
            cmbProducto.DisplayMember = "Descripcion"
            cmbProducto.DataSource = TablaProductos.Tables(0)
            cmbProducto.SelectedIndex = -1

            Me.txtFolioEmbarque.Clear()
            chkVigentes.Checked = True
            chkCancelados.Checked = True
            Me.CmbClientes.SelectedIndex = -1
            Me.cmbProducto.SelectedIndex = -1
            Me.cmbProducto.Text = "Seleccione un Producto"
            Me.CmbClientes.Text = "Seleccione un Cliente"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
        Me.GroupBox1.Enabled = Me.chkFecha.Checked
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim vista As New TC.VwReporteDevolucionesTypedView
            Dim filtro As New OC.PredicateExpression

            filtro.Add(HC.VwReporteDevolucionesFields.Embarque Mod String.Format("%{0}%", Me.txtFolioEmbarque.Text.Trim))

            If Me.CmbClientes.SelectedIndex > -1 Then
                filtro.Add(HC.VwReporteDevolucionesFields.IdCliente = Me.CmbClientes.SelectedValue)
            End If

            If Me.cmbProducto.SelectedIndex > -1 Then
                filtro.Add(HC.VwReporteDevolucionesFields.IdProducto = Me.cmbProducto.SelectedValue)
            End If

            If Me.chkFecha.Checked Then
                filtro.Add(New OC.FieldBetweenPredicate(HC.VwReporteDevolucionesFields.FechaCaptura, Me.dtFechaInicial.Value.ToShortDateString, Me.dtmFechaFinal.Value.AddDays(1).ToShortDateString))
            End If

            If Not chkVigentes.Checked AndAlso chkCancelados.Checked Then
                filtro.Add(HC.VwReporteDevolucionesFields.Estatus = 0)
            ElseIf chkVigentes.Checked AndAlso Not chkCancelados.Checked Then
                filtro.Add(HC.VwReporteDevolucionesFields.Estatus = 1)
            End If

            vista.Fill(0, Nothing, True, filtro)

            Dim rep As New rptDevoluciones
            Dim vent As New ClasesNegocio.PreVisualizarForm

            vent.Text = "Reporte de Devoluciones"
            rep.SetDataSource(CType(vista, Object))
            rep.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            vent.Reporte = rep
            vent.StartPosition = FormStartPosition.CenterScreen
            vent.WindowState = FormWindowState.Maximized

            vent.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.txtFolioEmbarque.Clear()
        chkVigentes.Checked = True
        chkCancelados.Checked = True
        Me.CmbClientes.SelectedIndex = -1
        Me.cmbProducto.SelectedIndex = -1
        Me.cmbProducto.Text = "Seleccione un Producto"
        Me.CmbClientes.Text = "Seleccione un Cliente"
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub chkVigentes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigentes.CheckedChanged, chkCancelados.CheckedChanged
        If Not chkVigentes.Checked AndAlso Not chkCancelados.Checked Then
            chkVigentes.Checked = True
            chkCancelados.Checked = True
        End If
    End Sub

End Class