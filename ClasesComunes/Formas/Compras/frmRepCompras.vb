Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CN = ClasesNegocio
Imports System.Data.SqlClient

Public Class frmRepCompras
    Dim Proveedores As New CN.ProveedorCollectionClass()
    Private Sub Limpiar()
        'Me.cmbAlmacen.SelectedIndex = -1
        'Me.cmbAlmacen.Text = "Seleccione un almacén"
        'Me.cmbProducto.SelectedIndex = -1
        'Me.cmbProducto.Text = "Seleccione un producto"
        dtpFechaInicio.Value = System.DateTime.Today
        dtpFechaFin.Value = System.DateTime.Today
        rbTodas.Checked = True
        cmbProveedor.SelectedValue = "null"
        CheckFiltrar.Checked = False
        gbFechas.Enabled = False
    End Sub

    Private Sub frmReporteMovimeintoAlmacenGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFechaInicio.Value = System.DateTime.Today
        dtpFechaFin.Value = System.DateTime.Today
        ''LLENAR COMBO DE PROVEEDORES
        Proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        Dim dt As New DataTable()
        dt.Columns.Add("IDProveedor")
        dt.Columns.Add("RazonSocial")
        dt.Rows.Add("null", "< TODOS LOS PROVEEDORES >")
        For Each item As CN.ProveedorClass In Proveedores
            dt.Rows.Add(item.Codigo, item.RazonSocial)
        Next
        cmbProveedor.ValueMember = "IDProveedor"
        cmbProveedor.DataSource = dt
        cmbProveedor.DisplayMember = "RazonSocial"

        gbFechas.Enabled = False
        rbTodas.Checked = True
        'cmbProveedor.Text = "TODOS LOS PROVEEDORES"
        'Try
        '    Me.cmbAlmacen.OnActualizaCombo()
        '    Me.cmbProducto.OnActualizaCombo()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        'End Try
    End Sub

    'Private Sub cmbAlmacen_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.ActualizarCombo
    '    Try
    '        Me.cmbAlmacen.DataSource = CC.AlmacenCollection.GetMultiAsDataTable(Nothing, 0, _
    '                            New OC.SortExpression(New OC.SortClause(HC.AlmacenFields.Descripcion, _
    '                            SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
    '        Me.cmbAlmacen.DisplayMember = "Descripcion"
    '        Me.cmbAlmacen.ValueMember = "AlmacenId"
    '        Me.cmbAlmacen.SelectedIndex = -1
    '        Me.cmbAlmacen.Text = "Seleccione un almacén"
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub

    'Private Sub ComboBoxMejorado1_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProducto.ActualizarCombo
    '    Try
    '        Me.cmbProducto.DataSource = CC.ProductoCollection.GetMultiAsDataTable(Nothing, 0, _
    '                                    New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, _
    '                                    SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
    '        Me.cmbProducto.DisplayMember = "Descripcion"
    '        Me.cmbProducto.ValueMember = "Codigo"
    '        Me.cmbProducto.SelectedIndex = -1
    '        Me.cmbProducto.Text = "Seleccione un producto"
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            'Dim Notas As New Integralab.ORM.TypedListClasses.ListaNotasVentaTypedList
            'Dim filtro As New OC.PredicateExpression

            ''If Not Me.cmbAlmacen.SelectedIndex = -1 Then _
            ''        filtro.Add(HC.InventarioMovimientoAlmacenFields.AlmacenId = _
            ''        CInt(Me.cmbAlmacen.SelectedValue))
            ''If Not Me.cmbProducto.SelectedIndex = -1 Then _
            ''        filtro.Add(HC.InventarioMovimientoAlmacenDetallesFields.ProductoId = _
            ''        CInt(Me.cmbProducto.SelectedValue))
            'filtro.Add(New OC.FieldBetweenPredicate(HC.NotaVentaFields.FechaVenta, _
            '        Me.dtpFechaInicio.Value, _
            '        Me.dtpFechaFin.Value.AddDays(1).AddMilliseconds(-1)))

            'Notas.Fill(0, New OC.SortExpression(New OC.SortClause(HC.NotaVentaFields.Codigo, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), False, filtro)
            'Dim Rep As New crVentaDelDia
            'Rep.SetDataSource(CType(Notas, Object))

            'Rep.SetParameterValue("Empresa", Controlador.Empresa.Nombre)
            'Rep.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnom)
            'Rep.SetParameterValue("FechaIni", dtpFechaInicio.Value)
            'Rep.SetParameterValue("FechaFin", dtpFechaFin.Value)
            'Rep.SetParameterValue("Formulario", "Notas de Venta/Reportes/Venta del Día")
            'Rep.SetParameterValue("Resumido", chkSoloTotales.Checked)
            'Dim Prev As New ClasesNegocio.PreVisualizarForm

            'Prev.Reporte = Rep
            'Prev.Text = "Reporte de Ventas del Día"
            'Prev.ShowDialog()
            Dim result As Integer = Date.Compare(dtpFechaInicio.Value, dtpFechaFin.Value)
            If CheckFiltrar.Checked And (result > 0) Then
                MsgBox("La fecha inicial debe ser menor o igual a la fecha final.", MsgBoxStyle.Exclamation, "AVISO")
                Return
            End If

            'Dim resultado As New DataSet()
            'Dim parametros As String = ""
            'If cmbProveedor.SelectedValue <> "null" Then
            '    parametros &= cmbProveedor.SelectedValue
            'Else
            '    parametros &= "null"
            'End If

            'If rbPorPagar.Checked Then
            '    parametros = parametros & "," & "0"
            'ElseIf rbPagadas.Checked Then
            '    parametros = parametros & "," & "1"
            'Else
            '    parametros = parametros & "," & "null"
            'End If

            'If CheckFiltrar.Checked Then
            '    parametros = parametros & "," & "'" & dtpFechaInicio.Value.ToString("dd-MM-yyyy 00:00:00") & "'"
            '    parametros = parametros & "," & "'" & dtpFechaFin.Value.ToString("dd-MM-yyyy 23:59:59") & "'"
            'Else
            '    parametros = parametros & "," & "null"
            '    parametros = parametros & "," & "null"
            'End If


            'Dim consulta As String = "execute dbo.Usp_MCompReporteCompras " + parametros
            Dim cmd As New SqlClient.SqlCommand("dbo.Usp_MCompReporteCompras", New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString.ToString))
            Try
                cmd.CommandType = CommandType.StoredProcedure

                If cmbProveedor.SelectedValue <> "null" Then
                    cmd.Parameters.Add("@Idproveedor", SqlDbType.Int)
                    cmd.Parameters("@Idproveedor").Value = CInt(cmbProveedor.SelectedValue)
                    'Else
                    '    cmd.Parameters("@Idproveedor").Value = Nothing
                End If

                If rbPorPagar.Checked Then
                    cmd.Parameters.Add("@pagada", SqlDbType.Bit)
                    cmd.Parameters("@pagada").Value = 0
                ElseIf rbPagadas.Checked Then
                    cmd.Parameters.Add("@pagada", SqlDbType.Bit)
                    cmd.Parameters("@pagada").Value = 1
                    'Else
                    '    cmd.Parameters("@pagada").Value = Nothing
                End If
                
                If CheckFiltrar.Checked Then
                    cmd.Parameters.Add("@fechainicial", SqlDbType.DateTime)
                    cmd.Parameters.Add("@fechafinal", SqlDbType.DateTime)
                    cmd.Parameters("@fechainicial").Value = dtpFechaInicio.Text
                    cmd.Parameters("@fechafinal").Value = dtpFechaFin.Text
                    'Else
                    '    cmd.Parameters("@fechainicial").Value = Nothing
                    '    cmd.Parameters("@fechafinal").Value = Nothing
                End If
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.SelectCommand.CommandTimeout = 900

                'Fill the dataset'
                Dim DS As New DataSet
                adapter.Fill(DS)

                If DS.Tables(0).Rows.Count <> 0 Then
                    Dim rep As New crReporteCompras
                    rep.SetDataSource(DS.Tables(0))
                    rep.SetParameterValue("Empresa", Controlador.Sesion.MiEmpresa.Empnom)
                    rep.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnom)
                    rep.SetParameterValue("Formulario", "Compras Generales/Reportes/Compras del Día")
                    If rbPorPagar.Checked Then
                        rep.SetParameterValue("Tipo", "Pendientes de pagar")
                    ElseIf rbPagadas.Checked Then
                        rep.SetParameterValue("Tipo", "Pagadas")
                    Else
                        rep.SetParameterValue("Tipo", "Pendientes y pagadas")
                    End If

                    If CheckFiltrar.Checked Then
                        rep.SetParameterValue("FechaInicio", dtpFechaInicio.Value)
                        rep.SetParameterValue("FechaFin", dtpFechaFin.Value)
                    Else
                        rep.SetParameterValue("FechaInicio", New Date())
                        rep.SetParameterValue("FechaFin", New Date())
                    End If


                    Dim Prev As New ClasesNegocio.PreVisualizarForm

                    Prev.Reporte = rep

                    Prev.Text = "Reporte de Compras"
                    Prev.ShowDialog()
                Else
                    MsgBox("No se encontraron resultados.", MsgBoxStyle.Exclamation, "AVISO")
                    Return
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

            'Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(consulta, _
            '            New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
            '    ad.SelectCommand.Connection.Open()
            '    ad.Fill(resultado)
            '    ad.SelectCommand.Connection.Close()
            'End Using
            'If resultado.Tables(0).Rows.Count <> 0 Then
            '    Dim rep As New crReporteCompras
            '    rep.SetDataSource(resultado.Tables(0))
            '    rep.SetParameterValue("Empresa", Controlador.Sesion.MiEmpresa.Empnom)
            '    rep.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnom)
            '    rep.SetParameterValue("Formulario", "Compras Generales/Reportes/Compras del Día")
            '    If rbPorPagar.Checked Then
            '        rep.SetParameterValue("Tipo", "Pendientes de pagar")
            '    ElseIf rbPagadas.Checked Then
            '        rep.SetParameterValue("Tipo", "Pagadas")
            '    Else
            '        rep.SetParameterValue("Tipo", "Pendientes y pagadas")
            '    End If

            '    If CheckFiltrar.Checked Then
            '        rep.SetParameterValue("FechaInicio", dtpFechaInicio.Value)
            '        rep.SetParameterValue("FechaFin", dtpFechaFin.Value)
            '    Else
            '        rep.SetParameterValue("FechaInicio", New Date())
            '        rep.SetParameterValue("FechaFin", New Date())
            '    End If


            '    Dim Prev As New ClasesNegocio.PreVisualizarForm

            '    Prev.Reporte = rep

            '    Prev.Text = "Reporte de Compras"
            '    Prev.ShowDialog()
            'Else
            '    MsgBox("No se encontraron resultados.", MsgBoxStyle.Exclamation, "AVISO")
            '    Return
            'End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub cmbProveedor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbProveedor.SelectedIndexChanged

    End Sub

    Private Sub CheckFiltrar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckFiltrar.CheckedChanged
        If CheckFiltrar.Checked Then
            gbFechas.Enabled = True
        Else
            gbFechas.Enabled = False
        End If

    End Sub
End Class