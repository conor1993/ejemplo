Imports System.Data.SqlClient
Imports HC = IntegraLab.ORM.HelperClasses

'Joel Isaac Jimenez Carrillo
'12-07-2018

Public Class frmEstadoCuentasProvedores

#Region "Metodos/Eventos"


    Private Sub frmEstadoCuentasProvedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cargar provedores al combobox
        Dim query As String = "select PrRazSocial, PrIdProveedor from MCatCompProveedores"
        Dim tablaDatos As DataTable = cargarTablaDatos(query)
        cb_Provedores.DataSource = tablaDatos
        cb_Provedores.DisplayMember = "PrRazSocial"
        cb_Provedores.ValueMember = "PrIdProveedor"

    End Sub

    'Este procedimiento recibe una cadena como parametro(query) y regresa una tabla, se usara para todas las consutas de los grid y combobox
    Private Function cargarTablaDatos(ByVal query As String) As DataTable
        Dim tablaDatos As New DataTable
        Try
            Dim adaptador As New SqlDataAdapter
            Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
                adaptador.SelectCommand = New SqlCommand(query, connection)
                adaptador.Fill(tablaDatos)
                adaptador.Dispose()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al tratar de cargar llenar la tabla de la base de datos. Consulte al administrador del sistema " + ex.ToString(),
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dispose()
        End Try
        Return tablaDatos
    End Function

    'Carga las facturas usando como filtro el id del provedor (y fechas si esta chekeado)
    Private Sub buscarFacturas()
        Dim tablaFacturas As New DataTable
        Dim query As String
        'si el checkbox esta chekeado usa como filtro las fechas y proveedor, sino, solo proveedor
        If cb_RangoFechas.Checked = True Then
            query = "EXEC CargarFacturasProveedores '1', {0}, '{1}', '{2}'"
            query = String.Format(query, cb_Provedores.SelectedValue, dtp_FechaInicial.Value.ToString("dd-MM-yyyy"),
                                  dtp_FechaFinal.Value.ToString("dd-MM-yyyy"))
        Else
            query = "EXEC CargarFacturasProveedores '0', {0}, '', ''"
            query = String.Format(query, cb_Provedores.SelectedValue)
        End If
        'regresa la tabla para grid de facturas
        tablaFacturas = cargarTablaDatos(query)
        dgv_Facturas.AutoGenerateColumns = False
        dgv_Facturas.DataSource = tablaFacturas

        'Una vez cargado el grid facturas realiza esta operacion para conocer si ya pag0
        Try
            For Each filas As DataGridViewRow In dgv_Facturas.Rows
                If (filas.Cells("clmImporte").Value <> 0 And filas.Cells("clmPago").Value <> 0) Then
                    filas.Cells("clmSaldo").Value = filas.Cells("clmImporte").Value - filas.Cells("clmPago").Value
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("No se logro calcular los saldos correctamente. Consulte al administrador del sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'cada que hace una busqueda limpia las polizas de la busqueda anterior para evitar confucion
        dgv_Polizas.DataSource = Nothing
    End Sub

    'Carga las polizas de las facturas seleccionadas en el data grid
    Private Sub cargarPolizas()
        Dim query As String = "select DISTINCT CONVERT(VARCHAR(10), cpp.FechaPago, 103) AS 'Fecha de Pago', cp.NumeroPoliza AS 'No Poliza', cpp.Cheque AS 'No Cheque', cpd.Importe " +
            "from UsrCxpfacturasCab cfp inner join UsrCxppagosProveedores cpp on cfp.NoFactura = cpp.NoFactura " +
            "inner join usrContPolizas cp on  cp.Codigo = cfp.IdPoliza inner join usrContPolizasDetalle cpd on cpd.PolizaId = cp.Codigo " +
            "where cpd.OperacionCA = 'A' and cpp.NoFactura = '{0}' "
        query = String.Format(query, dgv_Facturas.CurrentRow.Cells("clmNoFactura").Value)
        Dim tablaPolizas As DataTable = cargarTablaDatos(query)
        dgv_Polizas.DataSource = tablaPolizas
    End Sub

    'Limpia el formulario
    Private Sub limpiar()
        dgv_Facturas.DataSource = Nothing
        dgv_Polizas.DataSource = Nothing
        dtp_FechaFinal.Value = Date.Now.ToString("dd/MM/yyyy")
        dtp_FechaInicial.Value = Date.Now.ToString("dd/MM/yyyy")
        If cb_RangoFechas.Checked = True Then
            dtp_FechaInicial.Enabled = False
            dtp_FechaFinal.Enabled = False
            cb_RangoFechas.Checked = False
        End If
    End Sub

    'reporte
    Private Sub imprimirReporte()
        Dim query As String = "select CONVERT(VARCHAR(10), cpp.FechaPago, 103) AS 'FechaPago', cp.NumeroPoliza AS 'NoPoliza', cpp.Cheque AS 'NoCheque', " +
            "cpd.OperacionCA, cfp.NoFactura, cfp.FechaFactura, cpd.Importe from UsrCxpfacturasCab cfp " +
            "inner join UsrCxppagosProveedores cpp on cfp.NoFactura = cpp.NoFactura " +
            "inner join usrContPolizas cp on  cp.Codigo = cfp.IdPoliza " +
            "inner join usrContPolizasDetalle cpd on cpd.PolizaId = cp.Codigo " +
            "inner join MCatCompProveedores mccp on mccp.PrIdProveedor = cpp.IdProveedor" +
            "where  cpp.NoFactura = '{0}' "
        query = String.Format(query, dgv_Facturas.CurrentRow.Cells("clmNoFactura").Value)
        Dim tablaReporte As DataTable = cargarTablaDatos(query)

        'Falta reporte
        'Try

        '    Dim Reporte As New rptCierreContable
        '    Reporte.SetDataSource(tablaReporte)
        '    Reporte.SetParameterValue("EmpresaNombre", Controlador.Empresa.Nombre)
        '    Reporte.SetParameterValue("Fecha", Date.Now.ToString("dd/MM/yyy"))
        '    Reporte.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnom)
        '    Dim Pre As New ClasesNegocio.PreVisualizarForm
        '    Pre.Reporte = Reporte
        '    Pre.ShowDialog()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        'End Try
    End Sub

    'Activa/Desactiva Fechas. Opcionales para la busqueda
    Private Sub cb_RangoFechas_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cb_RangoFechas.CheckedChanged
        If (cb_RangoFechas.Checked = True) Then
            dtp_FechaInicial.Enabled = True
            dtp_FechaFinal.Enabled = True
        Else
            dtp_FechaInicial.Enabled = False
            dtp_FechaFinal.Enabled = False
        End If
    End Sub

    Private Sub dgv_Facturas_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Facturas.CellClick
        cargarPolizas()
    End Sub

    Private Sub dgv_Facturas_KeyUp(sender As Object, e As KeyEventArgs) Handles dgv_Facturas.KeyUp
        cargarPolizas()
    End Sub

#End Region

#Region "Botones Toolbar"

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        limpiar()
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        buscarFacturas()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Dispose()
    End Sub

#End Region

End Class