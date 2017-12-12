Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports CN = ClasesNegocio

Public Class FrmBuscarAlmacenes


    Private Sub FrmBuscarAlmacenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Buscar()
    End Sub

    Private Sub Buscar()
        Try
            Dim Almacenes As New CC.AlmacenCollection
            Dim Filtro As New OC.PredicateExpression

            ' Filtro.Add(HC.AlmacenFields.Estatus = 1)

            If Not Me.txtDescripcion.Text = "" Then
                Filtro.Add(HC.AlmacenFields.Descripcion Mod String.Format("%{0}%", Me.txtDescripcion.Text))
            End If

            If Not Me.chkTodoAlmacenes.Checked Then
                If Me.chkTerceros.Checked Then
                    Filtro.Add(HC.AlmacenFields.AlmacenId = 0)
                ElseIf Me.chkPropios.Checked Then
                    Filtro.Add(HC.AlmacenFields.AlmacenId = 1)
                End If
            End If

            If Not Me.chkTodosEstatus.Checked Then
                If Me.chkVigentes.Checked Then
                    Filtro.Add(HC.AlmacenFields.Estatus = 1)
                ElseIf Me.chkCancelados.Checked Then
                    Filtro.Add(HC.AlmacenFields.Estatus = 0)
                End If
            End If

            If Not Me.chkTodosTiposProductos.Checked Then
                If Me.chkGeneral.Checked Then
                    Filtro.Add(HC.AlmacenFields.TipoProducto = 1)
                End If
                If Me.chkFresco.Checked Then
                    Filtro.Add(HC.AlmacenFields.TipoProducto = 2)
                End If
                If Me.chkCongelado.Checked Then
                    Filtro.Add(HC.AlmacenFields.TipoProducto = 3)
                End If
                If Me.chkCongelado.Checked Then
                    Filtro.Add(HC.AlmacenFields.TipoProducto = 4)
                End If
            End If


            'Almacenes.GetMulti(Filtro, 0, Nothing)
            Dim Almacens As New CN.AlmacenCollectionClass()
            Almacens.Obtener(Filtro)
            If Almacens.Count > 0 Then
                Me.dgvAlmacenes.AutoGenerateColumns = False
                Me.dgvAlmacenes.DataSource = Almacens
                Me.dgvAlmacenes.Columns(0).DataPropertyName = "Codigo"
                Me.dgvAlmacenes.Columns(1).DataPropertyName = "Descripcion"
                Me.dgvAlmacenes.Columns(2).DataPropertyName = "DescripcionCorta"
                Me.dgvAlmacenes.Columns(3).DataPropertyName = "Letras"
                Me.dgvAlmacenes.Columns(4).DataPropertyName = "Plaza"

            End If

            'Vista.Fill(0, Nothing, True, Filtro)
            'Me.DgvCanales.AutoGenerateColumns = False
            'Me.DgvCanales.DataSource = Vista

            'If Vista.Rows.Count > 0 Then
            '    Me.DgvCanales.AutoGenerateColumns = False
            '    Me.DgvCanales.DataSource = Vista
            '    If Not Codigos Is Nothing Then

            '        Dim Tope As Integer = 0
            '        For i As Integer = 0 To Me.DgvCanales.Rows.Count - 1

            '            For j As Integer = 0 To Me.Codigos.Length - 1
            '                If Not DgvCanales.Rows(i).Cells(Me.clmFolioCanal.Index).Value = "" Then
            '                    If DgvCanales.Rows(i).Cells(Me.clmFolioCanal.Index).Value = Me.Codigos(j) Then
            '                        DgvCanales.Rows(i).Cells(Me.clmSeleccion.Index).Value = True
            '                        DgvCanales.Rows(i).Cells(Me.clmSeleccion.Index).ReadOnly = True
            '                        Tope += 1
            '                        Exit For
            '                    End If
            '                End If
            '            Next

            '            If Tope = Me.Codigos.Length Then
            '                Exit For
            '            End If
            '        Next
            '    End If
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    
    Private Sub mtb_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles mtb.ButtonClick

    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Buscar()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.dgvAlmacenes.DataSource = Nothing
        Me.txtDescripcion.Clear()
        Me.chkCancelados.Checked = False
        Me.chkCongelado.Checked = False
        Me.chkFresco.Checked = False
        Me.chkGeneral.Checked = False
        Me.chkPropios.Checked = False
        Me.chkTerceros.Checked = False
        Me.chkTodoAlmacenes.Checked = False
        Me.chkTodosEstatus.Checked = False
        Me.chkTodosTiposProductos.Checked = False
        Me.chkVenta.Checked = False
        Me.chkVigentes.Checked = False
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub dgvAlmacenes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAlmacenes.CellDoubleClick
        If e.RowIndex >= 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub dgvAlmacenes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvAlmacenes.DoubleClick
       
    End Sub
End Class