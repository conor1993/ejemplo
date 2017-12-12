Imports System.Data.SqlClient

Public Class frmReporteFacturasPorCliente

#Region "Metodos"
    Private Sub ObtenerClientes()
        Dim sqlCon As New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)

        Try
            Dim cadena As String = "SELECT IdCliente, Nombre FROM MFacCatClientes WHERE (Estatus = 1) ORDER BY Nombre"
            Dim sqlCom As New SqlCommand(cadena, sqlCon)
            Dim tb As New DataTable
            Dim ad As New SqlDataAdapter(sqlCom)

            sqlCon.Open()
            ad.Fill(tb)
            Me.cmbCliente.DataSource = tb
            Me.cmbCliente.DisplayMember = "Nombre"
            Me.cmbCliente.ValueMember = "IdCliente"
            Me.cmbCliente.SelectedIndex = -1
            Me.cmbCliente.Text = "TODOS"
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar los clientes", MsgBoxStyle.Critical, "Error")
#End If
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub Limpiar()
        Me.txtCodigoCliente.Clear()
        Me.cmbCliente.SelectedIndex = -1
        Me.cmbCliente.Text = "TODOS"
        Me.txtNoFactura.Clear()
        Me.dtFechaFinal.Value = Now
        Me.dtFechaInicial.Value = Now
        'Me.chkFiltrar.Checked = False
        optClienteTipoProducto.Checked = True
    End Sub

    Private Sub Imprimir()
        Dim sqlCon As New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)

        Try
            Dim sqlCom As New SqlCommand("FacturasVentasPorCliente", sqlCon)
            Dim ds As New DataSet
            Dim ad As New SqlDataAdapter(sqlCom)
            Dim reporte As New rptFacturaVentasPorCliente
            Dim reporte1 As New rptFacturaVentasPorClienteTipoProducto
            Dim prev As New ClasesNegocio.PreVisualizarForm

            sqlCom.CommandType = CommandType.StoredProcedure

            With sqlCom.Parameters
                'las Opciones para usar el procedimiento son
                '0 para no realizar filtrado
                '1 para filtrar solo por NoFactura
                '2 para filtrar por cliente
                '3 para filtrar por cliente y rango de fechas
                '4 para filtrar por rango de fechas

                If Me.txtNoFactura.Text = "" Then
                    If Me.cmbCliente.SelectedIndex > -1 Then
                        If Me.chkFiltrar.Checked Then
                            .Add("@Opcion", SqlDbType.SmallInt).Value = 3
                            .Add("@idCliente", SqlDbType.Int).Value = Me.cmbCliente.SelectedValue
                            .Add("@NoFactura", SqlDbType.Char, 20).Value = " "
                            .Add("@FechaInicio", SqlDbType.DateTime).Value = Me.dtFechaInicial.Value.ToShortDateString
                            .Add("@FechaFinal", SqlDbType.DateTime).Value = Me.dtFechaFinal.Value.AddDays(1).ToShortDateString
                            .Add("@TipoProducto", SqlDbType.Int).Value = 0
                            .Add("@IdVendedor", SqlDbType.Int).Value = 0
                        Else
                            .Add("@Opcion", SqlDbType.SmallInt).Value = 2
                            .Add("@idCliente", SqlDbType.Int).Value = Me.cmbCliente.SelectedValue
                            .Add("@NoFactura", SqlDbType.Char, 20).Value = " "
                            .Add("@FechaInicio", SqlDbType.DateTime).Value = Me.dtFechaInicial.Value.ToShortDateString
                            .Add("@FechaFinal", SqlDbType.DateTime).Value = Me.dtFechaFinal.Value.AddDays(1).ToShortDateString
                            .Add("@TipoProducto", SqlDbType.Int).Value = 0
                            .Add("@IdVendedor", SqlDbType.Int).Value = 0
                        End If
                    Else
                        If Me.chkFiltrar.Checked Then
                            .Add("@Opcion", SqlDbType.SmallInt).Value = 4
                            .Add("@idCliente", SqlDbType.Int).Value = 0
                            .Add("@NoFactura", SqlDbType.Char, 20).Value = " "
                            .Add("@FechaInicio", SqlDbType.DateTime).Value = Me.dtFechaInicial.Value.ToShortDateString
                            .Add("@FechaFinal", SqlDbType.DateTime).Value = Me.dtFechaFinal.Value.AddDays(1).ToShortDateString
                            .Add("@TipoProducto", SqlDbType.Int).Value = 0
                            .Add("@IdVendedor", SqlDbType.Int).Value = 0
                        Else
                            .Add("@Opcion", SqlDbType.SmallInt).Value = 0
                            .Add("@idCliente", SqlDbType.Int).Value = 0
                            .Add("@NoFactura", SqlDbType.Char, 20).Value = " "
                            .Add("@FechaInicio", SqlDbType.DateTime).Value = Me.dtFechaInicial.Value.ToShortDateString
                            .Add("@FechaFinal", SqlDbType.DateTime).Value = Me.dtFechaFinal.Value.AddDays(1).ToShortDateString
                            .Add("@TipoProducto", SqlDbType.Int).Value = 0
                            .Add("@IdVendedor", SqlDbType.Int).Value = 0
                        End If
                    End If
                Else
                    .Add("@Opcion", SqlDbType.SmallInt).Value = 1
                    .Add("@idCliente", SqlDbType.Int).Value = 0
                    .Add("@NoFactura", SqlDbType.Char, 20).Value = Me.txtNoFactura.Text
                    .Add("@FechaInicio", SqlDbType.DateTime).Value = Me.dtFechaInicial.Value.ToShortDateString
                    .Add("@FechaFinal", SqlDbType.DateTime).Value = Me.dtFechaFinal.Value.AddDays(1).ToShortDateString
                    .Add("@TipoProducto", SqlDbType.Int).Value = 0
                    .Add("@IdVendedor", SqlDbType.Int).Value = 0
                End If
            End With

            sqlCon.Open()

            ad.Fill(ds)

            If Me.optTipoProductoCliente.Checked Then
                reporte1.SetDataSource(ds.Tables(0))
                'reporte1.Subreports(0).SetDataSource(ds.Tables(1))
                reporte1.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                reporte1.SetParameterValue(1, "Ventas/Reportes/Facturas Por Tipo de Producto Detallada")
                reporte1.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
                reporte1.SetParameterValue(3, Me.dtFechaInicial.Value)
                reporte1.SetParameterValue(4, Me.dtFechaFinal.Value)
                prev.Reporte = reporte1
            Else
                reporte.SetDataSource(ds.Tables(0))
                'reporte.Subreports(0).SetDataSource(ds.Tables(1))
                reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                reporte.SetParameterValue(1, "Ventas/Reportes/Facturas Por Cliente Detallada")
                reporte.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
                reporte.SetParameterValue(3, Me.dtFechaInicial.Value)
                reporte.SetParameterValue(4, Me.dtFechaFinal.Value)
                prev.Reporte = reporte
            End If


            prev.Text = "Reporte de Facturas por Cliente Detallada"
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
#End Region

    Private Sub chkFiltrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltrar.CheckedChanged
        Me.GroupBox1.Enabled = Me.chkFiltrar.Checked
    End Sub

    Private Sub frmReporteFacturasPorCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.ObtenerClientes()
            Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        Imprimir()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub cmbCliente_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.ActualizarCombo
        Me.ObtenerClientes()
    End Sub
End Class