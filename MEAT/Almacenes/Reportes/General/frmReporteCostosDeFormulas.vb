Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmReporteCostosDeFormulas

    Private Sub frmReporteCostosDeFormulas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '        SELECT		MCatCompProductosMezclas.PdPorcentaje AS Porcentaje, 
        '			MCatCompProductos.PdDescripcion AS Formula, 
        '			MCatCompProductos_1.PdDescripcion AS Ingrediente, 
        '			MCatCompUnidadMedida.UMDescCorta AS UnidadMedida, 
        '			@CantidadPreparar * (MCatCompProductosMezclas.PdPorcentaje / 100.00) AS Cantidad, 
        '			ISNULL((SELECT	TOP 1	CostoPromedio 
        '				FROM		dbo.MInvAlmacen
        '				WHERE		AlmacenId = @IdAlmacen 
        '							AND dbo.MInvAlmacen.ProductoId = MCatCompProductosMezclas.PdIdIngrediente
        '				ORDER BY	Año DESC, Mes DESC), 0.0) AS Costo
        'FROM        MCatCompProductosMezclas INNER JOIN
        '            MCatCompProductos ON MCatCompProductosMezclas.PdIdProducto = MCatCompProductos.PdIdProducto INNER JOIN
        '            MCatCompProductos AS MCatCompProductos_1 ON MCatCompProductosMezclas.PdIdIngrediente = MCatCompProductos_1.PdIdProducto INNER JOIN
        '            MCatCompUnidadMedida ON MCatCompProductos.PdIdUnidadMedida = MCatCompUnidadMedida.UMIdUnidadMedida INNER JOIN
        '			dbo.MInvAlmacen AS INV ON MCatCompProductos.PdIdProducto = INV.ProductoId AND INV.AlmacenId = @IdAlmacen
        'WHERE		MCatCompProductos.PdEstatus = 1 AND MCatCompProductos.PdMezcla = 1
        'GROUP BY	MCatCompProductosMezclas.PdPorcentaje, MCatCompProductos.PdDescripcion, 
        '			MCatCompProductos_1.PdDescripcion, MCatCompUnidadMedida.UMDescCorta, 
        '			MCatCompProductosMezclas.PdIdIngrediente
        Me.cmbAlmacen.OnActualizaCombo()
        Me.cmbMedicamento.OnActualizaCombo()
    End Sub

    Private Sub cmbMedicamento_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMedicamento.ActualizarCombo
        Try
            Dim rel As New OC.RelationCollection

            rel.Add(EC.InventarioAlmacenEntity.Relations.ProductoEntityUsingProductoId, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)

            Me.cmbMedicamento.DataSource = CC.ProductoCollection.GetMultiAsDataTable(HC.ProductoFields.EsMezcla = 1, 0, _
                                            New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, _
                                            SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), rel)
            Me.cmbMedicamento.DisplayMember = "Descripcion"
            Me.cmbMedicamento.ValueMember = "Codigo"
            Me.cmbMedicamento.SelectedIndex = -1
            Me.cmbMedicamento.Text = "Seleccione un medicamento"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Me.cmbAlmacen.SelectedIndex = -1
        Me.cmbAlmacen.Text = "Seleccione un almacén"
        Me.cmbMedicamento.SelectedIndex = -1
        Me.cmbMedicamento.Text = "Seleccione una formula"
        Me.txtCantidadPreparar.Text = 0D
    End Sub

    Private Sub cmbAlmacen_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.ActualizarCombo
        Try
            Me.cmbAlmacen.DataSource = CC.AlmacenCollection.GetMultiAsDataTable(Nothing, 0, _
                                New OC.SortExpression(New OC.SortClause(HC.AlmacenFields.Descripcion, _
                                SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Me.cmbAlmacen.DisplayMember = "Descripcion"
            Me.cmbAlmacen.ValueMember = "AlmacenId"
            Me.cmbAlmacen.SelectedIndex = -1
            Me.cmbAlmacen.Text = "Seleccione un almacén"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        If Me.cmbAlmacen.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un almacén", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        ElseIf Not IsNumeric(Me.txtCantidadPreparar.Text) OrElse CDec(Me.txtCantidadPreparar.Text) <= 0D Then
            MsgBox("Debe ingresar una cantidad a preparar mayor a 0", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor

        Dim sqlCon As SqlClient.SqlConnection = HC.DbUtils.CreateConnection

        Try
            Dim query As String

            query = String.Format("SELECT		MCatCompProductosMezclas.PdPorcentaje AS Porcentaje, " & _
                                  "             MCatCompProductos.PdDescripcion AS Formula, MCatCompProductos_1.PdDescripcion AS Ingrediente, " & _
                                  "			    MCatCompUnidadMedida.UMDescCorta AS UnidadMedida, " & _
                                  "  			@CantidadPreparar * (MCatCompProductosMezclas.PdPorcentaje / 100.00) AS Cantidad, " & _
                                  " 			ISNULL((SELECT	TOP 1	CostoPromedio " & _
                                  "                     FROM dbo.MInvAlmacen " & _
                                  " 				    WHERE		AlmacenId = @IdAlmacen " & _
                                  "							        AND dbo.MInvAlmacen.ProductoId = MCatCompProductosMezclas.PdIdIngrediente " & _
                                  "     				ORDER BY	Año DESC, Mes DESC), 0.0) AS Costo " & _
                                  "FROM        MCatCompProductosMezclas INNER JOIN " & _
                                  "            MCatCompProductos ON MCatCompProductosMezclas.PdIdProducto = MCatCompProductos.PdIdProducto INNER JOIN " & _
                                  "            MCatCompProductos AS MCatCompProductos_1 ON " & _
                                  "            MCatCompProductosMezclas.PdIdIngrediente = MCatCompProductos_1.PdIdProducto INNER JOIN " & _
                                  "            MCatCompUnidadMedida ON MCatCompProductos.PdIdUnidadMedida = MCatCompUnidadMedida.UMIdUnidadMedida INNER JOIN " & _
                                  "            dbo.MInvAlmacen AS INV ON MCatCompProductos.PdIdProducto = INV.ProductoId AND INV.AlmacenId = @IdAlmacen " & _
                                  "WHERE       (MCatCompProductos.PdEstatus = 1 And MCatCompProductos.PdMezcla = 1 {0}) " & _
                                  "GROUP BY	   MCatCompProductosMezclas.PdPorcentaje, MCatCompProductos.PdDescripcion, " & _
                                  "			   MCatCompProductos_1.PdDescripcion, MCatCompUnidadMedida.UMDescCorta, " & _
                                  "            MCatCompProductosMezclas.PdIdIngrediente", _
                                  IIf(Me.cmbMedicamento.SelectedIndex > -1, "AND MCatCompProductos.PdIdProducto = " & _
                                  CInt(Me.cmbMedicamento.SelectedValue), ""))

            Dim ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(query, sqlCon))
            Dim tb As New DataTable
            Dim ventana As New ClasesNegocio.PreVisualizarForm
            Dim reporte As New ClasesNegocio.rptCostosDeFormulas

            With ad.SelectCommand.Parameters
                .Add("@IdAlmacen", SqlDbType.Int).Value = CInt(Me.cmbAlmacen.SelectedValue)
                .Add("@CantidadPreparar", SqlDbType.Decimal).Value = CDec(Me.txtCantidadPreparar.Text)
            End With

            ad.Fill(tb)
            reporte.SetDataSource(tb)
            reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            reporte.SetParameterValue(1, "Manejo de Engorda/Reportes/Aplicacion de Formula/Costo De Formula")
            reporte.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
            ventana.Text = "Reporte Costos de Formulas"
            ventana.Reporte = reporte
            ventana.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
End Class