Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports ClasesNegocio

Public Class frmMedicamentosDeTrabajo
    Private seleccionando As Boolean = False

    Private Sub ObtenerProductos()
        Dim productos As New CC.ProductoCollection

        Controlador.Configuracion.ActualizarEngorda()

        If Controlador.Configuracion.Engorda.IdFamiliaMedicamento.HasValue Then
            Dim filtro As New OC.PredicateExpression

            filtro.Add(HC.ProductoFields.Estatus = 1)
            filtro.Add(HC.ProductoFields.PdIdLinea = Controlador.Configuracion.Engorda.IdFamiliaMedicamento.Value)
            filtro.Add(Not New OC.FieldCompareSetPredicate(HC.ProductoFields.Codigo, _
                        HC.CabMediReimFields.CveMedi, _
                        SD.LLBLGen.Pro.ORMSupportClasses.SetOperator.In, Nothing))

            productos.GetMulti(filtro, 0, New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, _
                                    SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Me.IdMedicamentoDataGridViewTextBoxColumn.DataSource = productos
            Me.IdMedicamentoDataGridViewTextBoxColumn.DisplayMember = "Descripcion"
            Me.IdMedicamentoDataGridViewTextBoxColumn.ValueMember = "Codigo"
        Else
            MsgBox("Debe establecer la Familia de Medicamentos en la configuración de engorda", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

    Private Sub frmMedicamentosDeTrabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.ObtenerProductos()
            Me.MedicamentoTrabajoC.Obtener()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickCancelar
        Me.MedicamentoTrabajoC.Obtener()
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickGuardar
        Try
            If MessageBox.Show("Al guardar si algun medicamento le falto datos no sera guardado. ¿Quiere Continuar?", _
                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            If Me.DataGridView1.Rows.Count > 1 Then
                Me.DataGridView1.Rows(0).Cells(Me.UnidadMedidaDataGridViewTextBoxColumn.Index).Selected = True
            End If

            For i As Integer = Me.MedicamentoTrabajoC.Count - 1 To 0 Step -1
                With Me.MedicamentoTrabajoC(i)
                    If .Nombre = String.Empty OrElse (Not .PorCabeza AndAlso Not .PorKilo) OrElse _
                        (.CantidadXCabeza = 0D AndAlso .CantidadXKilo = 0D) Then
                        Me.MedicamentoTrabajoC.RemoveAt(i)
                    End If
                End With
            Next

            Me.MedicamentoTrabajoC.Guardar()
            Me.MedicamentoTrabajoC.Obtener()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir
        Try
            Me.MedicamentoTrabajoC.Imprimir(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Try
            If e.RowIndex = Me.DataGridView1.Rows.Count - 1 Then Exit Sub

            Dim medicamentoEditado As MedicamentoTrabajoClass = Me.MedicamentoTrabajoC(e.RowIndex)

            For i As Integer = 0 To Me.MedicamentoTrabajoC.Count - 1
                If e.RowIndex = i Then Continue For

                If Me.MedicamentoTrabajoC(i).IdMedicamento = medicamentoEditado.IdMedicamento Then
                    Me.MedicamentoTrabajoC.RemoveAt(e.RowIndex)
                    MsgBox("No es permitido seleccionardos veces el mismo medicamento", MsgBoxStyle.Exclamation, "Aviso")
                    Exit For
                End If
            Next

            Me.DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        If seleccionando OrElse Me.DataGridView1.CurrentRow Is Nothing OrElse Me.DataGridView1.CurrentRow.Index = Me.DataGridView1.Rows.Count - 1 Then Exit Sub

        Try
            Dim filaSeleccionada As Integer = Me.DataGridView1.CurrentRow.Index
            Dim medicamentoSeleccionado As MedicamentoTrabajoClass = Me.MedicamentoTrabajoC(Me.DataGridView1.CurrentRow.Index)

            For i As Integer = 0 To Me.MedicamentoTrabajoC.Count - 1
                If i = filaSeleccionada Then Continue For

                Dim medicamentoValidando As MedicamentoTrabajoClass = Me.MedicamentoTrabajoC(i)

                With medicamentoValidando
                    If .Nombre = String.Empty OrElse (Not .PorCabeza AndAlso Not .PorKilo) OrElse _
                        (.CantidadXCabeza = 0D AndAlso .CantidadXKilo = 0D) Then
                        Me.seleccionando = True
                        Me.DataGridView1.Rows(i).Cells(Me.DataGridView1.CurrentCell.ColumnIndex).Selected = True
                        Me.seleccionando = False
                        Exit For
                    End If
                End With
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DataGridView1_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles DataGridView1.PreviewKeyDown
        Try
            If e.KeyCode = Keys.Delete AndAlso Me.DataGridView1.CurrentRow.Index < Me.DataGridView1.Rows.Count - 1 Then
                If MessageBox.Show("¿Quiere quitar este medicamento de la lista?", "Quitar Medicamento", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = _
                    Windows.Forms.DialogResult.Yes Then
                    Me.MedicamentoTrabajoC.RemoveAt(Me.DataGridView1.CurrentRow.Index)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub
End Class