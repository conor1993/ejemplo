Imports CN = ClasesNegocio

Public Class FrmReporteDeVentasPorProducto

    Dim Productos As New CN.ProductosCollectionsClass

    Private Sub FrmReporteDeVentasPorProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            tbEstados.StateBuscar = "001101101"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "010011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            Productos.Obtener(ClasesNegocio.CondicionEstatusEnum.TODOS)
            Me.cmbProducto.DisplayMember = "Descripcion"
            Me.cmbProducto.ValueMember = "IdProducto"
            Me.cmbProducto.DataSource = Productos

            Me.Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub

#Region "Métodos"

    Sub Habilitar()
        Me.cmbProducto.Enabled = True
        Me.dtpFechaFinal.Enabled = True
        Me.dtpFechaInicial.Enabled = True

    End Sub
    Sub Deshabilitar()
        Me.cmbProducto.Enabled = False
        Me.dtpFechaInicial.Enabled = False
        Me.dtpFechaFinal.Enabled = False

    End Sub
    Sub Limpiar()
        Me.cmbProducto.SelectedValue = -1
        Me.dtpFechaFinal.Value = DateTime.Now.ToShortDateString
        Me.dtpFechaInicial.Value = DateTime.Now.ToShortDateString

    End Sub
#End Region

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        Cursor = Cursors.WaitCursor

        Try
            If (Me.dtpFechaInicial.Value > Me.dtpFechaFinal.Value) Then
                MessageBox.Show("Rango de fechas no válido, intente de nuevo", "Error", MessageBoxButtons.OK)
                Me.dtpFechaFinal.Value = DateTime.Now.ToShortDateString
                Me.dtpFechaInicial.Value = DateTime.Now.ToShortDateString
                Me.dtpFechaInicial.Focus()
            Else
                Dim Reporte As New RptVentasPorProducto, dt As New DataTable, dt2 As New DataTable, producto As Integer = -1, QueryFormado1 As String = "", QueryFormado2 As String = ""

                Dim Query1 As String = "SELECT MSCCatProductos.IdProducto, MSCCatProductos.Descripcion, MSCCatProductos.Subproducto" & _
                    " ,SUM(FacturasClientesDetProductosTotales.KilosFacturados) AS Kilos" & _
                    " ,SUM(FacturasClientesDetProductosTotales.ImporteFacturado) AS Importe" & _
                    " FROM FacturasClientesCab INNER JOIN FacturasClientesDetProductosTotales ON FacturasClientesCab.NoFactura = FacturasClientesDetProductosTotales.NoFactura INNER JOIN" & _
                    " MSCCatProductos ON FacturasClientesDetProductosTotales.IdProducto = MSCCatProductos.IdProducto" & _
                    " WHERE FacturasClientesCab.FechaFactura BETWEEN @FechaIni AND @FechaFin and NOT FacturasClientesCab.Estatus = 'X'"
                Dim QueryGroup1 As String = " GROUP BY MSCCatProductos.IdProducto, MSCCatProductos.Descripcion, MSCCatProductos.Subproducto"
                Dim QueryWhere1 As String = " AND MSCCatProductos.IdProducto = @IdProducto"

                Dim Query2 As String = "SELECT IdProducto, count(IdFolioEtiqueta) AS Cajas, SUM(CantPzas) AS Piezas" & _
                    " FROM MFacEmbarquesDet INNER JOIN FacturasClientesCab on FacturasClientesCab.NoFactura = MFacEmbarquesDet.NoFactura" & _
                    " WHERE FacturasClientesCab.Estatus <> 'X' AND FacturasClientesCab.FechaFactura BETWEEN @FechaIni AND @FechaFin"
                Dim QueryGroup2 As String = " GROUP BY IdProducto", QueryWhere2 As String = " AND IdProducto = @IdProducto"

                Using ad As New SqlClient.SqlDataAdapter("", Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)
                    With ad.SelectCommand.Parameters
                        If (Me.cmbProducto.SelectedIndex > -1) Then
                            producto = Me.cmbProducto.SelectedValue
                        End If

                        .Add("@FechaIni", SqlDbType.DateTime).Value = Me.dtpFechaInicial.Value.Date
                        .Add("@FechaFin", SqlDbType.DateTime).Value = Me.dtpFechaFinal.Value.Date.AddDays(1).AddTicks(-1)

                        If producto = -1 Then
                            QueryFormado1 = Query1 & QueryGroup1
                            QueryFormado2 = Query2 & QueryGroup2
                        Else
                            .Add("@IdProducto", SqlDbType.Int).Value = producto
                            QueryFormado1 = Query1 & QueryWhere1 & QueryGroup1
                            QueryFormado2 = Query2 & QueryWhere2 & QueryGroup2
                        End If
                    End With

                    ad.SelectCommand.Connection.Open()
                    ad.SelectCommand.CommandText = QueryFormado1
                    ad.SelectCommand.Prepare()
                    ad.Fill(dt)

                    ad.SelectCommand.CommandText = QueryFormado2
                    ad.SelectCommand.Prepare()
                    ad.Fill(dt2)
                End Using

                dt.PrimaryKey = New DataColumn() {dt.Columns(0)}
                dt2.PrimaryKey = New DataColumn() {dt2.Columns(0)}
                dt.Merge(dt2)

                Reporte.SetDataSource(dt)
                Reporte.SetParameterValue("Empresa", Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue("FechaInicio", Me.dtpFechaInicial.Value.ToShortDateString)
                Reporte.SetParameterValue("Fechafin", Me.dtpFechaFinal.Value.ToShortDateString)
                Reporte.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnomcom)

                Dim visualizar As New CN.PreVisualizarForm

                visualizar.Reporte = Reporte
                visualizar.Text = "Reporte de Ventas Por Productos"
                visualizar.ShowDialog()
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al imprimir, intente de nuevo", MsgBoxStyle.Critical, "Error")
#End If
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

End Class