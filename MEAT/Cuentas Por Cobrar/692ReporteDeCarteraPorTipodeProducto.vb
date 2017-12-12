Imports System.Data.SqlClient
Imports CN = ClasesNegocio
Public Class _692ReporteDeCarteraPorTipodeProducto
    Private Sub Limpiar()
        'Me.txtCodigoCliente.Clear()
        'Me.cmbTipodeProducto.SelectedIndex = -1
        Me.dtFechaFinal.Value = Now
        Me.dtFechaInicial.Value = Now        
    End Sub
    Private Sub LlenaCombo()
        'With Me.cmbTipodeProducto
        '    .Items.Add(CN.TipoProductoEnum.CANAL)
        '    .Items.Add(CN.TipoProductoEnum.CORTE)
        '    .Items.Add(CN.TipoProductoEnum.PRODUCTO)
        'End With
    End Sub

    Private Sub Imprimir()
        Dim sqlCon As New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)

        Try
            Dim sqlCom As New SqlCommand("FacturasVentasPorCliente", sqlCon)
            Dim ds As New DataSet
            Dim ad As New SqlDataAdapter(sqlCom)
            Dim reporte As New rptCarteraporTipoProducto
            'Dim reporte1 As New rptFacturaVentasPorClienteTipoProducto
            Dim prev As New ClasesNegocio.PreVisualizarForm

            sqlCom.CommandType = CommandType.StoredProcedure

            With sqlCom.Parameters
                'las Opciones para usar el procedimiento son
                '0 para no realizar filtrado
                '3 para filtrar por tipo de producto
                '4 para filtrar por rango de fechas
                
                .Add("@Opcion", SqlDbType.SmallInt).Value = 6
                .Add("@idCliente", SqlDbType.Int).Value = 0
                .Add("@NoFactura", SqlDbType.Char, 20).Value = " "
                .Add("@FechaInicio", SqlDbType.DateTime).Value = Me.dtFechaInicial.Value.ToShortDateString
                .Add("@FechaFinal", SqlDbType.DateTime).Value = Me.dtFechaFinal.Value.AddDays(1).ToShortDateString
                .Add("@TipoProducto", SqlDbType.Int).Value = 0
                .Add("@IdVendedor", SqlDbType.Int).Value = 0
            End With

            sqlCon.Open()

            ad.Fill(ds)


            reporte.SetDataSource(ds.Tables(0))
            'reporte.Subreports(0).SetDataSource(ds.Tables(1))
            reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            reporte.SetParameterValue(1, "Cuentas por Cobrar/Reportes/Cartera por Tipo de Producto")
            reporte.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
            reporte.SetParameterValue(3, Me.dtFechaInicial.Value)
            reporte.SetParameterValue(4, Me.dtFechaFinal.Value)
            prev.Reporte = reporte



            prev.Text = "Reporte de Cartera por Cliente"
            prev.Icon = Icon
            prev.StartPosition = FormStartPosition.CenterScreen
            prev.WindowState = FormWindowState.Maximized
            'reporte.SaveAs("c:\tempRpt\Reporte", True)
            prev.ShowDialog()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al mostrar el reporte", MsgBoxStyle.Critical, "Error")
#End If
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub


    Private Sub chkFiltrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltrar.CheckedChanged
        Me.GroupBox1.Enabled = Me.chkFiltrar.Checked
    End Sub

    Private Sub _692ReporteDeCarteraPorTipodeProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LlenaCombo()
            Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles mtb.ButtonClick

    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Imprimir()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
End Class