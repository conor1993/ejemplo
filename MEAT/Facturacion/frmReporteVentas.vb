Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TC = Integralab.ORM.TypedViewClasses

Public Class frmReporteVentas
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
        Me.dtFechaInicial.Enabled = Me.chkFecha.Checked
        Me.dtFechaFinal.Enabled = Me.chkFecha.Checked
    End Sub

    Private Sub frmReporteVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Icon = MdiParent.Icon
        Me.mtb.Buttons(1).Visible = False
        Me.mtb.Buttons(4).Visible = False
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim ventana As New ClasesNegocio.PreVisualizarForm
            Dim reporte As New ClasesNegocio.rptReporteVentasXFactura
            Dim facturas As New TC.VwVentasXfacturaTypedView
            Dim filtro As New OC.PredicateExpression

            If Me.chkFecha.Checked Then
                filtro.Add(New OC.FieldBetweenPredicate(HC.VwVentasXfacturaFields.Fecha, Me.dtFechaInicial.Value.ToShortDateString, Me.dtFechaFinal.Value.AddDays(1).ToShortDateString))
            End If

            Dim FilEstatus As OC.IPredicate = Nothing
            Dim Coleccion As New Collection()

            Coleccion.Add(chkVigentes)
            Coleccion.Add(chkCanceladas)
            Coleccion.Add(chkAbonadas)
            Coleccion.Add(chkPagadas)

            For Each Item As CheckBox In Coleccion
                If FilEstatus Is Nothing And Item.Checked Then
                    FilEstatus = HC.VwVentasXfacturaFields.Sta = Item.Tag
                ElseIf Item.Checked Then
                    FilEstatus = FilEstatus Or HC.VwVentasXfacturaFields.Sta = Item.Tag
                End If
            Next

            If Not FilEstatus Is Nothing Then
                filtro.Add(FilEstatus)
            End If

            facturas.Fill(0, New OC.SortExpression(New OC.SortClause(HC.VwVentasXfacturaFields.Fecha, IIf(rbtAscendente.Checked, OC.SortOperator.Ascending, OC.SortOperator.Descending))), False, filtro)
            reporte.SetDataSource(CType(facturas, Object))
            reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
            reporte.SetParameterValue(2, "Ventas/Reporte de Ventas por Factura")

            ventana.Reporte = reporte
            ventana.Text = "Reporte de Ventas por Factura"
            ventana.Icon = Icon
            ventana.StartPosition = FormStartPosition.CenterScreen
            ventana.WindowState = FormWindowState.Maximized

            ventana.ShowDialog()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar las facturas", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub chkEstatus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigentes.CheckedChanged, chkCanceladas.CheckedChanged, chkAbonadas.CheckedChanged, chkPagadas.CheckedChanged
        If (Not chkVigentes.Checked And Not chkCanceladas.Checked And Not chkAbonadas.Checked And Not chkPagadas.Checked) Then
            chkVigentes.Checked = True
            chkCanceladas.Checked = True
            chkAbonadas.Checked = True
            chkPagadas.Checked = True
        End If
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        chkVigentes.Checked = True
        chkCanceladas.Checked = True
        chkAbonadas.Checked = True
        chkPagadas.Checked = True
        chkFecha.Checked = False
        dtFechaInicial.Value = Now
        dtFechaFinal.Value = Now
    End Sub
End Class