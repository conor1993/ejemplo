Public Class frmNomISR
    Dim ultimoValor As Decimal

    Private Sub frmNomISR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            'tbEstados.StateBuscar = "001101111"
            'tbEstados.StateLimpiar = ""
            'tbEstados.StateCancelar = "100100011"
            'tbEstados.StateNuevo = "011010001"
            'tbEstados.StateGuardar = "100100011"
            'tbEstados.StateBorrar = "100100011"
            'tbEstados.StateEditar = "001011001"
            'tbEstados.StateImprimir = ""
            'tbEstados.StateSalir = ""

            'Me.mtb.ToolBarButtonStatus = tbEstados
            'Me.mtb.sbCambiarEstadoBotones("Cancelar")

            LlenarLimites()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al abrir la ventana", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub LlenarLimites()
        Try
            Me.ISRc.Obtener(Me.dtAño.Value.Year)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtAño.ValueChanged
        LlenarLimites()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickGuardar
        Me.ISRc.Guardar(Me.dtAño.Value.Year)
        MsgBox(" El Subsidio ha sido guardado ", MsgBoxStyle.Information, "Aviso")
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
                    If e.ColumnIndex = Me.LimiteInferiorDataGridViewTextBoxColumn.Index Then
                        Dim numSup As Decimal
                        Dim numSupAnt As Decimal

                        Try
                            numSup = CDec(Me.dgLimites.Rows(e.RowIndex).Cells(Me.LimiteSuperiorDataGridViewTextBoxColumn.Index).Value)
                            numSupAnt = CDec(Me.dgLimites.Rows(e.RowIndex - 1).Cells(Me.LimiteSuperiorDataGridViewTextBoxColumn.Index).Value)
                        Catch ex As Exception
                            Me.dgLimites.Rows(e.RowIndex).Cells(Me.LimiteSuperiorDataGridViewTextBoxColumn.Index).Value = 0D
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
                    ElseIf e.ColumnIndex = Me.LimiteSuperiorDataGridViewTextBoxColumn.Index Then
                        Dim numInf As Decimal
                        Dim numInfDesp As Decimal

                        Try
                            numInf = CDec(Me.dgLimites.Rows(e.RowIndex).Cells(Me.LimiteInferiorDataGridViewTextBoxColumn.Index).Value)
                            numInfDesp = CDec(Me.dgLimites.Rows(e.RowIndex + 1).Cells(Me.LimiteInferiorDataGridViewTextBoxColumn.Index).Value)
                        Catch ex As Exception
                            Me.dgLimites.Rows(e.RowIndex).Cells(Me.LimiteInferiorDataGridViewTextBoxColumn.Index).Value = 0D

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
                    If e.ColumnIndex = Me.LimiteInferiorDataGridViewTextBoxColumn.Index Then
                        Dim numSup As Decimal
                        Dim numSupAnt As Decimal

                        Try
                            numSup = CDec(Me.dgLimites.Rows(e.RowIndex).Cells(Me.LimiteSuperiorDataGridViewTextBoxColumn.Index).Value)
                            numSupAnt = CDec(Me.dgLimites.Rows(e.RowIndex - 1).Cells(Me.LimiteSuperiorDataGridViewTextBoxColumn.Index).Value)
                        Catch ex As Exception
                            Me.dgLimites.Rows(e.RowIndex).Cells(Me.LimiteSuperiorDataGridViewTextBoxColumn.Index).Value = 0D
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
                    ElseIf e.ColumnIndex = Me.LimiteSuperiorDataGridViewTextBoxColumn.Index Then
                        Dim numInf As Decimal

                        Try
                            numInf = CDec(Me.dgLimites.Rows(e.RowIndex).Cells(Me.LimiteInferiorDataGridViewTextBoxColumn.Index).Value)
                        Catch ex As Exception
                            Me.dgLimites.Rows(e.RowIndex).Cells(Me.LimiteInferiorDataGridViewTextBoxColumn.Index).Value = 0D

                        End Try

                        If num < numInf Then
                            MsgBox("Debe ingresar una cantidad mayor a la inferior", MsgBoxStyle.Information, "Aviso")
                            Me.dgLimites.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ultimoValor
                        End If
                    End If
                End If
            Else
                If e.ColumnIndex = Me.LimiteInferiorDataGridViewTextBoxColumn.Index Then
                    Dim numSup As Decimal = CDec(Me.dgLimites.Rows(e.RowIndex).Cells(Me.LimiteSuperiorDataGridViewTextBoxColumn.Index).Value)

                    If numSup > 0D Then
                        If numSup < num Then
                            MsgBox("Debe ingresar una cantidad menor a la superior", MsgBoxStyle.Information, "Aviso")
                            Me.dgLimites.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ultimoValor
                        End If
                    End If
                ElseIf e.ColumnIndex = Me.LimiteSuperiorDataGridViewTextBoxColumn.Index Then
                    Dim numInf As Decimal
                    Dim numInfDesp As Decimal

                    Try
                        numInf = CDec(Me.dgLimites.Rows(e.RowIndex).Cells(Me.LimiteInferiorDataGridViewTextBoxColumn.Index).Value)
                        If Me.dgLimites.Rows.Count - 2 > e.RowIndex Then
                            numInfDesp = CDec(Me.dgLimites.Rows(e.RowIndex + 1).Cells(Me.LimiteInferiorDataGridViewTextBoxColumn.Index).Value)
                        End If

                    Catch ex As Exception
                        Me.dgLimites.Rows(e.RowIndex).Cells(Me.LimiteInferiorDataGridViewTextBoxColumn.Index).Value = 0D

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

    Private Sub dgLimites_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgLimites.DataError

    End Sub
End Class