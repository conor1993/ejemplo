Public Class frmNomSubcidio
    Dim ultimoValor As Decimal

    Private Sub frmNomSubcidio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SubcidioCollectionClass1.Obtener(Now.Year)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtAño_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtAño.ValueChanged
        Me.SubcidioCollectionClass1.Obtener(Short.Parse(Me.dtAño.Value.Year))
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Me.SubcidioCollectionClass1.Guardar(Short.Parse(Me.dtAño.Value.Year.ToString()))
        MsgBox(" El Subsidio ha sido guardado ", MsgBoxStyle.Information, "Aviso")
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.dtAño.Value = Now
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub dgLimites_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgLimites.CellBeginEdit
        Try
            ultimoValor = CDec(Me.dgLimites.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        Catch ex As Exception
            ultimoValor = 0D
        End Try
    End Sub

    Private Sub dgLimites_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLimites.CellEndEdit
        If e.RowIndex > -1 Then
            Dim num As Decimal

            If IsNumeric(Me.dgLimites.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                num = CDec(Me.dgLimites.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)

                If num < 0D Then
                    Me.dgLimites.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ultimoValor
                    Exit Sub
                End If
            Else
                Me.dgLimites.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ultimoValor
                Exit Sub
            End If

            If e.RowIndex > 0D Then
                If e.RowIndex < Me.dgLimites.Rows.Count - 2 Then
                    If e.ColumnIndex = Me.IngresoDeDataGridViewTextBoxColumn.Index Then
                        Dim numSup As Decimal
                        Dim numSupAnt As Decimal

                        Try
                            numSup = CDec(Me.dgLimites.Rows(e.RowIndex).Cells(Me.IngresoHastaDataGridViewTextBoxColumn.Index).Value)
                            numSupAnt = CDec(Me.dgLimites.Rows(e.RowIndex - 1).Cells(Me.IngresoHastaDataGridViewTextBoxColumn.Index).Value)
                        Catch ex As Exception
                            Me.dgLimites.Rows(e.RowIndex).Cells(Me.IngresoHastaDataGridViewTextBoxColumn.Index).Value = 0D
                            Me.dgLimites.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ultimoValor
                        End Try

                        If numSup > 0D Then
                            If numSup <= num Then
                                MsgBox("Debe ingresar una cantidad menor a la superior", MsgBoxStyle.Information, "Aviso")
                                Me.dgLimites.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ultimoValor
                            ElseIf num <= numSupAnt Then
                                MsgBox("Debe ingresar una cantidad mayor a la superior del rango anterior", MsgBoxStyle.Information, "Aviso")
                                Me.dgLimites.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ultimoValor
                            End If
                        End If
                    ElseIf e.ColumnIndex = Me.IngresoHastaDataGridViewTextBoxColumn.Index Then
                        Dim numInf As Decimal
                        Dim numInfDesp As Decimal

                        Try
                            numInf = CDec(Me.dgLimites.Rows(e.RowIndex).Cells(Me.IngresoDeDataGridViewTextBoxColumn.Index).Value)
                            numInfDesp = CDec(Me.dgLimites.Rows(e.RowIndex + 1).Cells(Me.IngresoDeDataGridViewTextBoxColumn.Index).Value)
                        Catch ex As Exception
                            Me.dgLimites.Rows(e.RowIndex).Cells(Me.IngresoDeDataGridViewTextBoxColumn.Index).Value = 0D

                        End Try

                        If num < numInf Then
                            MsgBox("Debe ingresar una cantidad mayor a la inferior", MsgBoxStyle.Information, "Aviso")
                            Me.dgLimites.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ultimoValor
                        ElseIf num > numInfDesp Then
                            MsgBox("Debe ingresar una cantidad menor a la inferior del siguiente rango", MsgBoxStyle.Information, "Aviso")
                            Me.dgLimites.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ultimoValor
                        End If
                    End If
                Else
                    If e.ColumnIndex = Me.IngresoDeDataGridViewTextBoxColumn.Index Then
                        Dim numSup As Decimal
                        Dim numSupAnt As Decimal

                        Try
                            numSup = CDec(Me.dgLimites.Rows(e.RowIndex).Cells(Me.IngresoHastaDataGridViewTextBoxColumn.Index).Value)
                            numSupAnt = CDec(Me.dgLimites.Rows(e.RowIndex - 1).Cells(Me.IngresoHastaDataGridViewTextBoxColumn.Index).Value)
                        Catch ex As Exception
                            Me.dgLimites.Rows(e.RowIndex).Cells(Me.IngresoHastaDataGridViewTextBoxColumn.Index).Value = 0D
                            Me.dgLimites.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ultimoValor
                        End Try

                        If numSup > 0D Then
                            If numSup <= num Then
                                MsgBox("Debe ingresar una cantidad menor a la superior", MsgBoxStyle.Information, "Aviso")
                                Me.dgLimites.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ultimoValor
                            ElseIf num <= numSupAnt Then
                                MsgBox("Debe ingresar una cantidad mayor a la superior del rango anterior", MsgBoxStyle.Information, "Aviso")
                                Me.dgLimites.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ultimoValor
                            End If
                        End If
                    ElseIf e.ColumnIndex = Me.IngresoHastaDataGridViewTextBoxColumn.Index Then
                        Dim numInf As Decimal

                        Try
                            numInf = CDec(Me.dgLimites.Rows(e.RowIndex).Cells(Me.IngresoDeDataGridViewTextBoxColumn.Index).Value)
                        Catch ex As Exception
                            Me.dgLimites.Rows(e.RowIndex).Cells(Me.IngresoDeDataGridViewTextBoxColumn.Index).Value = 0D

                        End Try

                        If num < numInf Then
                            MsgBox("Debe ingresar una cantidad mayor a la inferior", MsgBoxStyle.Information, "Aviso")
                            Me.dgLimites.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ultimoValor
                        End If
                    End If
                End If
            Else
                If e.ColumnIndex = Me.IngresoDeDataGridViewTextBoxColumn.Index Then
                    Dim numSup As Decimal = CDec(Me.dgLimites.Rows(e.RowIndex).Cells(Me.IngresoHastaDataGridViewTextBoxColumn.Index).Value)

                    If numSup > 0D Then
                        If numSup < num Then
                            MsgBox("Debe ingresar una cantidad menor a la superior", MsgBoxStyle.Information, "Aviso")
                            Me.dgLimites.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ultimoValor
                        End If
                    End If
                ElseIf e.ColumnIndex = Me.IngresoHastaDataGridViewTextBoxColumn.Index Then
                    Dim numInf As Decimal
                    Dim numInfDesp As Decimal

                    Try
                        numInf = CDec(Me.dgLimites.Rows(e.RowIndex).Cells(Me.IngresoDeDataGridViewTextBoxColumn.Index).Value)

                        If Me.dgLimites.Rows.Count - 2 > e.RowIndex Then
                            numInfDesp = CDec(Me.dgLimites.Rows(e.RowIndex + 1).Cells(Me.IngresoDeDataGridViewTextBoxColumn.Index).Value)
                        End If

                    Catch ex As Exception
                        Me.dgLimites.Rows(e.RowIndex).Cells(Me.IngresoDeDataGridViewTextBoxColumn.Index).Value = 0D

                    End Try

                    If num < numInf Then
                        MsgBox("Debe ingresar una cantidad mayor a la inferior", MsgBoxStyle.Information, "Aviso")
                        Me.dgLimites.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ultimoValor
                    ElseIf num > numInfDesp AndAlso Me.dgLimites.Rows.Count - 2 > e.RowIndex Then
                        MsgBox("Debe ingresar una cantidad menor a la inferior del siguiente rango", MsgBoxStyle.Information, "Aviso")
                        Me.dgLimites.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ultimoValor
                    End If
                End If
            End If
        End If
    End Sub
End Class