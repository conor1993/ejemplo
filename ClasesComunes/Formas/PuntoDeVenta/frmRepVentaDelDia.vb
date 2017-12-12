Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class frmRepVentaDelDia
    Dim band As Boolean
    Dim bucket As New RelationCollection
    Private Sub Limpiar()
        'Me.cmbAlmacen.SelectedIndex = -1
        'Me.cmbAlmacen.Text = "Seleccione un almacén"
        'Me.cmbProducto.SelectedIndex = -1
        'Me.cmbProducto.Text = "Seleccione un producto"
        dtpFechaInicio.Value = System.DateTime.Today
        dtpFechaFin.Value = System.DateTime.Today
        Me.chkSoloTotales.Checked = False
        rbNota.Checked = True
        cmbFamilia.SelectedValue = 0
    End Sub

    Private Sub frmReporteMovimeintoAlmacenGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFechaInicio.Value = System.DateTime.Today
        dtpFechaFin.Value = System.DateTime.Today
        band = True
        Try
            Dim lineas As New ClasesNegocio.LineaCollectionClass
            lineas.Obtener(CondicionEnum.ACTIVOS)
            cmbFamilia.DisplayMember = "Descripcion"
            cmbFamilia.ValueMember = "Codigo"
            Dim linea As New ClasesNegocio.LineaClass
            linea.Codigo = 0
            linea.Descripcion = "< TODAS LAS LINEAS >"
            lineas.Add(linea)
            cmbFamilia.DataSource = lineas
            cmbFamilia.SelectedValue = 0

            cargarProductos(CInt(cmbFamilia.SelectedValue))


            band = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub cargarProductos(ByVal codlinea As Integer)
        Dim prods As New CC.ProductoCollection
        Dim prod As New EC.ProductoEntity
        ' prod.Codigo = 0
        prod.Descripcion = "< TODOS LOS PRODUCTOS >"
        bucket.Add(EC.ProductoEntity.Relations.LineaEntityUsingPdIdLinea)
        ' bucket.Relations.Add(EC.ProductoEntity.Relations.LineaEntityUsingPdIdLinea, JoinHint.Inner)

        If codlinea = 0 Then
            prods.GetMulti(HC.ProductoFields.Estatus = 1 And HC.ProductoFields.PdEsKit = False And HC.LineaFields.Estatus = 1, 0, New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), bucket)
        Else
            prods.GetMulti(HC.ProductoFields.Estatus = 1 And HC.ProductoFields.PdEsKit = False And HC.LineaFields.Estatus = 1 And HC.ProductoFields.PdIdLinea = codlinea, 0, New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), bucket)
        End If


        prods.Add(prod)

        cmbArticulo.DisplayMember = "Descripcion"
        cmbArticulo.ValueMember = "Codigo"
        cmbArticulo.DataSource = prods
        cmbArticulo.SelectedValue = 0

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
            If rbNota.Checked Then
                Dim Notas As New Integralab.ORM.TypedListClasses.ListaNotasVentaTypedList
                Dim filtro As New OC.PredicateExpression

                'If Not Me.cmbAlmacen.SelectedIndex = -1 Then _
                '        filtro.Add(HC.InventarioMovimientoAlmacenFields.AlmacenId = _
                '        CInt(Me.cmbAlmacen.SelectedValue))
                'If Not Me.cmbProducto.SelectedIndex = -1 Then _
                '        filtro.Add(HC.InventarioMovimientoAlmacenDetallesFields.ProductoId = _
                '        CInt(Me.cmbProducto.SelectedValue))
                filtro.Add(New OC.FieldBetweenPredicate(HC.NotaVentaFields.FechaVenta, _
                        Me.dtpFechaInicio.Value, _
                        Me.dtpFechaFin.Value.AddDays(1).AddMilliseconds(-1)) And HC.NotaVentaFields.Estatus = 1)

                Notas.Fill(0, New OC.SortExpression(New OC.SortClause(HC.NotaVentaFields.Codigo, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), False, filtro)
                Dim Rep As New crVentaDelDia
                Rep.SetDataSource(CType(Notas, Object))

                Rep.SetParameterValue("Empresa", Controlador.Empresa.Nombre)
                Rep.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnom)
                Rep.SetParameterValue("FechaIni", dtpFechaInicio.Value)
                Rep.SetParameterValue("FechaFin", dtpFechaFin.Value)
                Rep.SetParameterValue("Formulario", "Notas de Venta/Reportes/Venta del Día")
                Rep.SetParameterValue("Resumido", chkSoloTotales.Checked)
                Dim Prev As New ClasesNegocio.PreVisualizarForm

                Prev.Reporte = Rep
                Prev.Text = "Reporte de Ventas del Día"
                Prev.ShowDialog()
            ElseIf rbProducto.Checked = True Or rbFechaProducto.Checked = True Or rbProductoFecha.Checked = True Then

                'If chkFechaProducto.Checked = True And chkProductoFecha.Checked = True Then
                '    MessageBox.Show("En el agrupador se puede seleccionar uno a la vez", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    chkFechaProducto.Checked = False
                '    chkProductoFecha.Checked = False
                '    Return
                'End If

                Dim cmd As SqlCommand = New SqlCommand("UspRpt_VtaPorProducto", New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString))
                cmd.CommandType = CommandType.StoredProcedure
                Dim resultado As New DataSet()
                cmd.Parameters.Add("@FechaInicial", SqlDbType.DateTime).Value = dtpFechaInicio.Value.Date ''Convert.ToDateTime(dtpFechaInicio.Value.Date.ToString("dd/MM/yyyy 00:00:00"))
                cmd.Parameters.Add("@FechaFinal", SqlDbType.DateTime).Value = dtpFechaFin.Value.Date.AddDays(1).AddMilliseconds(-3) ''Convert.ToDateTime(dtpFechaFin.Value.Date.ToString("dd/MM/yyyy 23:59:59"))
                If cmbFamilia.SelectedValue <> 0 Then
                    cmd.Parameters.Add("@CodLinea", SqlDbType.Int).Value = Convert.ToInt32(cmbFamilia.SelectedValue)
                End If

                If cmbArticulo.SelectedValue <> 0 Then
                    cmd.Parameters.Add("@CodProducto", SqlDbType.Int).Value = Convert.ToInt32(cmbArticulo.SelectedValue)
                End If

                If Me.rbProducto.Checked = True Then
                    cmd.Parameters.Add("@Opc", SqlDbType.Int).Value = Convert.ToInt32(0)
                ElseIf rbFechaProducto.Checked = True Then
                    cmd.Parameters.Add("@Opc", SqlDbType.Int).Value = Convert.ToInt32(1)
                ElseIf rbProductoFecha.Checked = True Then
                    cmd.Parameters.Add("@Opc", SqlDbType.Int).Value = Convert.ToInt32(2)
                End If

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.SelectCommand.CommandTimeout = 300

                adapter.Fill(resultado)
                cmd.Dispose()

                If resultado.Tables(0).Rows.Count <> 0 Then

                    If Me.rbProducto.Checked = True Then
                        Dim rep As New rptVentaXProducto
                        rep.SetDataSource(resultado.Tables(0))
                        rep.SetParameterValue("Empresa", Controlador.Sesion.MiEmpresa.Empnom)
                        ''rep.SetParameterValue("Fecha", Now())
                        rep.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnom)
                        rep.SetParameterValue("FechaIni", Convert.ToDateTime(dtpFechaInicio.Value.Date.ToString("dd/MM/yyyy 00:00:00")))
                        rep.SetParameterValue("FechaFin", Convert.ToDateTime(dtpFechaFin.Value.Date.ToString("dd/MM/yyyy 23:59:59")))
                        ''rep.SetParameterValue("Formulario", "Invenario/Reportes/Reporte de Inventario Fisico")

                        Dim Prev As New ClasesNegocio.PreVisualizarForm
                        Prev.Reporte = rep
                        Prev.Text = "Reporte de Venta por Producto"
                        Prev.ShowDialog()
                    ElseIf rbFechaProducto.Checked = True Then
                        Dim rep As New rptVentaXProductoFechaProd
                        rep.SetDataSource(resultado.Tables(0))
                        rep.SetParameterValue("Empresa", Controlador.Sesion.MiEmpresa.Empnom)
                        ''rep.SetParameterValue("Fecha", Now())
                        rep.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnom)
                        rep.SetParameterValue("FechaIni", Convert.ToDateTime(dtpFechaInicio.Value.Date.ToString("dd/MM/yyyy 00:00:00")))
                        rep.SetParameterValue("FechaFin", Convert.ToDateTime(dtpFechaFin.Value.Date.ToString("dd/MM/yyyy 23:59:59")))
                        ''rep.SetParameterValue("Formulario", "Invenario/Reportes/Reporte de Inventario Fisico")

                        Dim Prev As New ClasesNegocio.PreVisualizarForm
                        Prev.Reporte = rep
                        Prev.Text = "Reporte de Venta por Producto"
                        Prev.ShowDialog()
                    ElseIf rbProductoFecha.Checked = True Then
                        Dim rep As New rptVentaXProductoProdFecha
                        rep.SetDataSource(resultado.Tables(0))
                        rep.SetParameterValue("Empresa", Controlador.Sesion.MiEmpresa.Empnom)
                        ''rep.SetParameterValue("Fecha", Now())
                        rep.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnom)
                        rep.SetParameterValue("FechaIni", Convert.ToDateTime(dtpFechaInicio.Value.Date.ToString("dd/MM/yyyy 00:00:00")))
                        rep.SetParameterValue("FechaFin", Convert.ToDateTime(dtpFechaFin.Value.Date.ToString("dd/MM/yyyy 23:59:59")))
                        ''rep.SetParameterValue("Formulario", "Invenario/Reportes/Reporte de Inventario Fisico")

                        Dim Prev As New ClasesNegocio.PreVisualizarForm
                        Prev.Reporte = rep
                        Prev.Text = "Reporte de Venta por Producto"
                        Prev.ShowDialog()
                    End If


                Else
                    MsgBox("No se encontraron resultados.", MsgBoxStyle.Exclamation, "AVISO")
                End If




            End If



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

    Private Sub cmbFamilia_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbFamilia.SelectedIndexChanged
        If band = False Then
            cargarProductos(CInt(cmbFamilia.SelectedValue))
        End If
    End Sub

    Private Sub rbNota_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbNota.CheckedChanged
        If rbNota.Checked Then
            gbPorProducto.Enabled = False
            chkSoloTotales.Enabled = True

            cmbFamilia.SelectedValue = 0
        Else
            gbPorProducto.Enabled = True
            chkSoloTotales.Enabled = False
            cmbFamilia.SelectedValue = 0
        End If

    End Sub

    Private Sub rbProducto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbProducto.CheckedChanged
        If rbProducto.Checked Then
            gbPorProducto.Enabled = True
            chkSoloTotales.Enabled = False

            cmbFamilia.SelectedValue = 0
        Else
            gbPorProducto.Enabled = False
            chkSoloTotales.Enabled = True

            cmbFamilia.SelectedValue = 0
        End If
    End Sub

   

    'Private Sub rbAgrupaFechaProducto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbAgrupaFechaProducto.CheckedChanged
    '    If rbAgrupaFechaProducto.Checked = False Then
    '        rbAgrupaFechaProducto.Checked = True
    '    End If
    'End Sub

    'Private Sub rbAgrupaProductoFecha_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbAgrupaProductoFecha.CheckedChanged
    '    If rbAgrupaProductoFecha.Checked = False Then
    '        rbAgrupaProductoFecha.Checked = True
    '    End If
    'End Sub

    
    Private Sub rbFechaProducto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbFechaProducto.CheckedChanged
        If rbFechaProducto.Checked Then
            gbPorProducto.Enabled = True
            chkSoloTotales.Enabled = False

            cmbFamilia.SelectedValue = 0
        Else
            gbPorProducto.Enabled = False
            chkSoloTotales.Enabled = True

            cmbFamilia.SelectedValue = 0
        End If
    End Sub

    Private Sub rbProductoFecha_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbProductoFecha.CheckedChanged
        If rbProductoFecha.Checked Then
            gbPorProducto.Enabled = True
            chkSoloTotales.Enabled = False

            cmbFamilia.SelectedValue = 0
        Else
            gbPorProducto.Enabled = False
            chkSoloTotales.Enabled = True

            cmbFamilia.SelectedValue = 0
        End If
    End Sub
End Class