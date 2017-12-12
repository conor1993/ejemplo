Imports ClasesNegocio
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports TC = Integralab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses

Public Class FrmReportedeVendedores

#Region "Miembros"

#End Region

#Region "Metodos"

    Private Function Limpiar() As Boolean
        CmbVendedores.SelectedValue = -1
        CmbVendedores.SelectedText = "Seleccione el vendedor"
        chkPorFechas.Checked = False
        dtpFechaInicial.Value = Now
        dtpFechaFinal.Value = Now
        Return True
    End Function

    Private Function Imprimir() As Boolean
        Try
            If Me.Validate() Then
                Dim ventana As New ClasesNegocio.PreVisualizarForm
                Dim reporte As New ClasesNegocio.rptFacturasPorVendedor
                Dim facturas As New TC.VwVentasXfacturaTypedView
                Dim filtro As New OC.PredicateExpression

                filtro.Add(Not HC.VwVentasXfacturaFields.Sta = "CANCELADA")

                If Me.chkPorFechas.Checked Then
                    filtro.Add(New OC.FieldBetweenPredicate(HC.VwVentasXfacturaFields.Fecha, Me.dtpFechaInicial.Value.ToShortDateString, Me.dtpFechaFinal.Value.AddDays(1).ToShortDateString))
                End If

                If Not CmbVendedores.SelectedValue Is Nothing Then
                    filtro.Add(HC.VwVentasXfacturaFields.IdVendedor = CmbVendedores.SelectedValue)
                End If

                facturas.Fill(0, New OC.SortExpression(New OC.SortClause(HC.VwVentasXfacturaFields.Fecha, IIf(rbtAscendente.Checked, OC.SortOperator.Ascending, OC.SortOperator.Descending))), False, filtro)
                reporte.SetDataSource(CType(facturas, Object))
                reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                reporte.SetParameterValue(1, "Ventas/Reporte de Facturas por Vendedor")
                reporte.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)

                ventana.Reporte = reporte
                ventana.Text = "Reporte de Facturas por Vendedor"
                ventana.Icon = Icon
                ventana.StartPosition = FormStartPosition.CenterScreen
                ventana.WindowState = FormWindowState.Maximized

                ventana.ShowDialog()
            Else
                Return False
            End If
            Return True
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar las facturas", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Private Sub Salir()
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Me.Close()
    End Sub

#End Region

#Region "Eventos"

#Region "Forma"
    Private Sub FrmReportedeVendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbVendedores.ValueMember = "Codigo"
        CmbVendedores.DisplayMember = "NombreCompleto"
        CmbVendedores.DataSource = ComisionistaCollectionClass.CargarComisionistas()
        Limpiar()
    End Sub
#End Region

#Region "Menu"
    Private Sub Acciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar, mtb.ClickImprimir, mtb.ClickSalir
        Dim Resultado As Boolean = False

        Select Case e.Button.Text
            Case "Limpiar"
                Resultado = Limpiar()
            Case "Imprimir"
                Resultado = Imprimir()
            Case "Salir"
                Salir()
        End Select

        Cancelar = Not Resultado
    End Sub
#End Region

#Region "Fechas"
    Private Sub dtpFecha_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpFechaFinal.Validating, dtpFechaInicial.Validating
        If dtpFechaInicial.Value.Year > dtpFechaFinal.Value.Year Or dtpFechaInicial.Value.Month > dtpFechaFinal.Value.Month Or dtpFechaInicial.Value.Day > dtpFechaFinal.Value.Day Then
            MsgBox("La fecha inicial no debe ser mayor a la fecha final", MsgBoxStyle.Exclamation, "Aviso")
            e.Cancel = True
        End If
    End Sub
#End Region

#End Region
End Class