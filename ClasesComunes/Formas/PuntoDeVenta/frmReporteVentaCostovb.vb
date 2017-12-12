Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports ClasesNegocio
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class frmReporteVentaCostovb
    Dim Productos As CN.ProductoCollectionClass
    Dim bucket As New RelationCollection
    Dim finload As Boolean
    Private Sub frmReporteVentaCostovb_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Productos = New CN.ProductoCollectionClass
        'Productos.Obtener(FN)
        finload = False
        Dim lineas As New ClasesNegocio.LineaCollectionClass
        lineas.Obtener(CondicionEnum.ACTIVOS)
        Dim linea As New CN.LineaClass
        linea.Codigo = 0
        linea.DescripcionCorta = "< TODAS LAS FAMILIAS >"
        lineas.Add(linea)
        CmbFamilia.DataSource = lineas
        CmbFamilia.ValueMember = "Codigo"
        CmbFamilia.DisplayMember = "DescripcionCorta"
        CmbFamilia.SelectedValue = 0



        finload = True
        CmbFamilia_SelectedIndexChanged(New Object, Nothing)
    End Sub

    Private Sub chkFechas_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFechas.CheckedChanged
        If chkFechas.Checked Then
            gbFechas.Enabled = True
        Else
            gbFechas.Enabled = False
        End If
    End Sub

    Private Sub CmbFamilia_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmbFamilia.SelectedIndexChanged
        If CmbFamilia.SelectedIndex <> -1 And CmbFamilia.SelectedValue IsNot Nothing And finload Then
            'Dim prods As New CC.ProductoCollection

            'bucket.Add(EC.ProductoEntity.Relations.LineaEntityUsingPdIdLinea)
            '' bucket.Relations.Add(EC.ProductoEntity.Relations.LineaEntityUsingPdIdLinea, JoinHint.Inner)

            'prods.GetMulti(HC.ProductoFields.Estatus = 1 And HC.ProductoFields.PdEsKit = False And HC.LineaFields.Estatus = 1, 0, New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), bucket)

            'Dim prod As New EC.ProductoEntity
            'prod.Codigo = 0
            'prod.Descripcion = "TODOS"
            'prods.Add(prod)
            'CmbProducto.DataSource = prods
            'CmbProducto.DisplayMember = "Descripcion"
            'CmbProducto.ValueMember = "Codigo"
            'CmbProducto.SelectedValue = 0
            Dim prods As New CC.ProductoCollection

            bucket.Add(EC.ProductoEntity.Relations.LineaEntityUsingPdIdLinea)
            ' bucket.Relations.Add(EC.ProductoEntity.Relations.LineaEntityUsingPdIdLinea, JoinHint.Inner)

            If CmbFamilia.SelectedValue = 0 Then
                prods.GetMulti(HC.ProductoFields.Estatus = 1 And HC.ProductoFields.PdEsKit = False And HC.LineaFields.Estatus = 1, 0, New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), bucket)
            Else
                prods.GetMulti(HC.ProductoFields.Estatus = 1 And HC.ProductoFields.PdEsKit = False And HC.LineaFields.Estatus = 1 And HC.ProductoFields.PdIdLinea = CmbFamilia.SelectedValue, 0, New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), bucket)
            End If



            Dim dt As New DataTable()
            dt.Columns.Add("Codigo")
            dt.Columns.Add("Descripcion")
            dt.Rows.Add(0, "< TODOS LOS PRODUCTOS >")
            For Each row As EC.ProductoEntity In prods
                dt.Rows.Add(row.Codigo, row.Descripcion)
            Next
            CmbProducto.ValueMember = "Codigo"
            CmbProducto.DisplayMember = "Descripcion"
            CmbProducto.DataSource = dt

        End If
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Me.Close()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        limpiar()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim resultado As New DataSet()
            Dim cmd As SqlCommand = New SqlCommand("rptVentasCostosRendimiento", New SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString))
            cmd.CommandType = CommandType.StoredProcedure
            Dim consulta As String = "exec dbo.rptVentasCostosRendimiento "
            If CmbFamilia.SelectedValue = 0 Or CmbFamilia.SelectedValue Is Nothing Then
                cmd.Parameters.Add("@Familia", SqlDbType.Int).Value = Nothing
            Else
                cmd.Parameters.Add("@Familia", SqlDbType.Int).Value = CInt(CmbFamilia.SelectedValue)
            End If
            If CmbProducto.SelectedValue = 0 Or CmbProducto.SelectedValue Is Nothing Then
                cmd.Parameters.Add("@Producto", SqlDbType.Int).Value = Nothing
            Else
                cmd.Parameters.Add("@Producto", SqlDbType.Int).Value = CInt(CmbProducto.SelectedValue)
            End If
            If chkFechas.Checked Then
                'consulta = consulta & ",'" & dtpDesde.Value.Date & " 00:00:00" & "',"
                'consulta = consulta & "'" & dtpHasta.Value.Date & " 23:59:59" & "'
                'Dim fec As String = dtpDesde.Value.ToString("yyyyMMdd 00:00:00")
                'MsgBox(fec, MsgBoxStyle.Exclamation, "AVISO")
                cmd.Parameters.Add("@FechaDesde", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpDesde.Value.ToString("yyyy-MM-dd 00:00:00"))
                cmd.Parameters.Add("@FechaHasta", SqlDbType.Date).Value = Convert.ToDateTime(dtpHasta.Value.ToString("yyyy-MM-dd 23:59:59"))
            End If

            Dim adapter As New SqlDataAdapter(cmd)
            adapter.SelectCommand.CommandTimeout = 300

            Dim DS As DataSet
            adapter.Fill(resultado)
            cmd.Dispose()

            ''resultado = cmd.exe
            ''Dim CMD As New SqlCommand("dbo.rptVentasCostosRendimiento", New SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString))

            ''cmd.Parameters.Add("@FechaDesde", SqlDbType.DateTime).Value =
            'Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(consulta, _
            '        New SqlClient.SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
            '    ad.SelectCommand.Connection.Open()
            '    ad.Fill(resultado)
            '    ad.SelectCommand.Connection.Close()
            'End Using

            If resultado.Tables(0).Rows.Count <> 0 Then
                Dim rep As New rptVentasCostoRendimiento
                rep.SetDataSource(resultado.Tables(0))
                rep.SetParameterValue("Empresa", Controlador.Sesion.MiEmpresa.Empnom)
                ''rep.SetParameterValue("Fecha", Now())
                rep.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnom)
                If chkFechas.Checked Then
                    rep.SetParameterValue("FechaInicial", Convert.ToDateTime(dtpDesde.Value.ToString("yyyy-MM-dd 00:00:00")))
                    rep.SetParameterValue("FechaFinal", Convert.ToDateTime(dtpHasta.Value.ToString("yyyy-MM-dd 23:59:59")))
                Else
                    rep.SetParameterValue("FechaInicial", New Date(1900, 1, 1))
                    rep.SetParameterValue("FechaFinal", New Date(1900, 1, 1))
                End If

                ''rep.SetParameterValue("Formulario", "Invenario/Reportes/Reporte de Inventario Fisico")
                Dim Prev As New ClasesNegocio.PreVisualizarForm
                Prev.Reporte = rep
                Prev.Text = "Reporte de Inventario Fisico"
                Prev.ShowDialog()
            Else
                MsgBox("No se encontraron resultados.", MsgBoxStyle.Exclamation, "AVISO")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub limpiar()
        CmbFamilia.SelectedValue = 0
        CmbProducto.SelectedValue = 0
        chkFechas.Checked = False
        dtpDesde.Value = DateTime.Now
        dtpHasta.Value = DateTime.Now
    End Sub
End Class