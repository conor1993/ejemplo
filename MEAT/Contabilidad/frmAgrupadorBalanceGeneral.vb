Imports ClasesNegocio
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses

Public Class frmAgrupadorBalanceGeneral

#Region "Metodos"
    Private Sub Actualizar()
        dgvAgrupadoresBalanceGeneral.DataSource = Nothing
        dgvAgrupadoresBalanceGeneral.DataSource = CatAgrupadoresBalGralEdoResCollectionClass.CargarAgrupadoresBalanceGral()
    End Sub

    Private Function Validar() As Boolean
        If txtDescripcion.Text.Trim = String.Empty Then
            MsgBox("Por favor proporcione la descripcion", MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
            txtDescripcion.Focus()
            Return False
        ElseIf txtCodigo.Text.Trim = String.Empty And CC.CatAgrupadoresBalGralEdoResCollection.GetMultiAsDataTable(HC.CatAgrupadoresBalGralEdoResFields.Descripcion = txtDescripcion.Text, 0, Nothing).Rows.Count > 0 Then
            MsgBox("Ya hay un registro con esa descripcion, por favor especifique una descripcion distinta", MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
            txtDescripcion.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function Limpiar() As Boolean
        txtCodigo.ResetText()
        txtDescripcion.ResetText()
        rbnBalancegrl.Checked = True
        txtOrden.ResetText()
        rbnActivo.Checked = True
        txtDescripcion.Focus()
        Return False
    End Function

    Private Sub Modo(ByVal Edicion As EstatusEnum)
        Dim Resultado As Boolean = CType(IIf(Edicion = EstatusEnum.ACTIVO, True, False), Boolean)
        txtDescripcion.ReadOnly = Not Resultado
        rbnBalancegrl.Enabled = Resultado
        rbnEstadoResultados.Enabled = Resultado
        txtOrden.ReadOnly = Not Resultado
        dgvAgrupadoresBalanceGeneral.Enabled = Not Resultado
        grbTipo.Enabled = Resultado
    End Sub

    Private Function Cancelar() As Boolean
        Limpiar()
        Modo(EstatusEnum.INACTIVO)

        If dgvAgrupadoresBalanceGeneral.Rows.Count > 0 Then
            MEAToolBar1.sbCambiarEstadoBotones("Buscar")
        End If
        txtDescripcion.Focus()
        Return True
    End Function

    Private Function Nuevo() As Boolean
        Limpiar()
        Modo(EstatusEnum.ACTIVO)
        txtDescripcion.Focus()
        Return True
    End Function

    Private Function Guardar() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Registro de Agrupador")
        Dim Reordenar As Boolean = False

        If Validar() Then
            Try
                Dim AgrupadorBalanceGeneral As CatAgrupadoresBalGralEdoResClass

                If txtCodigo.Text.Trim <> String.Empty Then
                    AgrupadorBalanceGeneral = New CatAgrupadoresBalGralEdoResClass(Integer.Parse(txtCodigo.Text.Trim))
                    AgrupadorBalanceGeneral.Descripcion = txtDescripcion.Text.Trim
                    AgrupadorBalanceGeneral.EsBalanceGral = rbnBalancegrl.Checked
                    AgrupadorBalanceGeneral.Priodidad = Integer.Parse(txtOrden.Text)
                    AgrupadorBalanceGeneral.EsActivo = rbnActivo.Checked
                Else
                    AgrupadorBalanceGeneral = New CatAgrupadoresBalGralEdoResClass(txtDescripcion.Text.Trim, rbnBalancegrl.Checked, Integer.Parse(txtOrden.Text), rbnActivo.Checked)
                End If

                If txtOrden.Text.Trim <> String.Empty AndAlso dgvAgrupadoresBalanceGeneral.Rows.Count > 0 Then
                    Dim Agrupadores As New CC.CatAgrupadoresBalGralEdoResCollection
                    Agrupadores.GetMulti(HC.CatAgrupadoresBalGralEdoResFields.BalanceGral = rbnBalancegrl.Checked, 0, New OC.SortExpression(New OC.SortClause(HC.CatAgrupadoresBalGralEdoResFields.Prioridad, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))

                    For i As Integer = 0 To Agrupadores.Count - 1
                        If Not Reordenar Then
                            If AgrupadorBalanceGeneral.Entidad.IsNew OrElse _
                            (Agrupadores(i).Código <> Integer.Parse(txtCodigo.Text) And _
                            Agrupadores(i).Prioridad = Integer.Parse(txtOrden.Text)) Then
                                If MessageBox.Show("El Agrupador: " & txtDescripcion.Text.Trim & " sera incrustado en el orden del Agrupador: " & Agrupadores(i).Descripcion & "," & Chr(13) & " los Agrupadores posteriores tambien seran reordenados consecuentemente," & Chr(13) & " ¿Esta deacuerdo?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                    Reordenar = True
                                    Trans.Add(Agrupadores(i))
                                    Agrupadores(i).Prioridad = Integer.Parse(txtOrden.Text) + 1
                                    Agrupadores(i).Save()
                                Else
                                    Return False
                                End If
                            End If
                        Else
                            Trans.Add(Agrupadores(i))
                            Agrupadores(i).Prioridad = Agrupadores(i - 1).Prioridad + 1
                            Agrupadores(i).Save()
                        End If
                    Next
                End If

                If AgrupadorBalanceGeneral.Guardar(Trans) Then
                    Trans.Commit()
                    MsgBox("El registro se ha guardado satisfactoriamente", MsgBoxStyle.Information, Controlador.Sesion.MiEmpresa.Empnom)
                    Actualizar()
                    txtDescripcion.Focus()
                    Return Cancelar()
                End If
            Catch ex As Exception
                Trans.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
            End Try
        End If
    End Function

    Private Function Borrar() As Boolean
        Try
            If MessageBox.Show("El registro se eliminara, ¿esta seguro?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim AgrupadorBalanceGeneral As New CatAgrupadoresBalGralEdoResClass(Integer.Parse(txtCodigo.Text))

                If AgrupadorBalanceGeneral.Borrar() Then
                    MsgBox("El registro se ha eliminado satisfactoriamente", MsgBoxStyle.Information, Controlador.Sesion.MiEmpresa.Empnom)
                    Actualizar()
                    txtDescripcion.Focus()
                    Return Cancelar()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
        End Try
    End Function

    Private Function Editar() As Boolean
        Modo(EstatusEnum.ACTIVO)
        Return True
    End Function

    Private Function Imprimir() As Boolean
        Try
            CatAgrupadoresBalGralEdoResCollectionClass.Imprimir(Controlador.Sesion)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
        End Try
    End Function
#End Region

#Region "Eventos"
    Private Sub frmAgrupadorBalanceGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvAgrupadoresBalanceGeneral.AutoGenerateColumns = False

        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "000100011"
        MtbEstados.StateCancelar = "000100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "000100011"
        MtbEstados.StateBorrar = "000100011"
        MtbEstados.StateEditar = "001010001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        MEAToolBar1.ToolBarButtonStatus = MtbEstados
        MEAToolBar1.sbCambiarEstadoBotones("Cancelar")
        Limpiar()
        Modo(EstatusEnum.INACTIVO)
        Actualizar()
    End Sub

    Private Sub Acciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickLimpiar, MEAToolBar1.ClickCancelar, MEAToolBar1.ClickNuevo, MEAToolBar1.ClickGuardar, MEAToolBar1.ClickBorrar, MEAToolBar1.ClickEditar, MEAToolBar1.ClickImprimir, MEAToolBar1.ClickSalir
        Dim Resultado As Boolean

        Select Case e.Button.Text
            Case "Limpiar"
                Resultado = Limpiar()
            Case "Cancelar"
                Resultado = Me.Cancelar()
            Case "Nuevo"
                Resultado = Nuevo()
            Case "Guardar"
                Resultado = Guardar()
            Case "Borrar"
                Resultado = Borrar()
            Case "Editar"
                Resultado = Editar()
            Case "Imprimir"
                Resultado = Imprimir()
            Case "Salir"
                Me.AutoValidate = Windows.Forms.AutoValidate.Disable
                Me.Close()
        End Select

        Cancelar = Not Resultado
    End Sub

    Private Sub dgvAgrupadoresBalanceGeneral_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvAgrupadoresBalanceGeneral.CellFormatting
        If e.ColumnIndex = clmDescripcionBalanceGral.Index Then
            e.Value = IIf(CType(dgvAgrupadoresBalanceGeneral.Rows(e.RowIndex).Cells(clmBalanceGral.Index).Value, Boolean), "BALANCE GENERAL", "ESTADO DE RESULTADOS")
        End If
    End Sub

    Private Sub dgvAgrupadoresBalanceGeneral_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAgrupadoresBalanceGeneral.RowEnter
        txtCodigo.Text = dgvAgrupadoresBalanceGeneral.Rows(e.RowIndex).Cells(clmCodigo.Index).Value.ToString
        txtDescripcion.Text = dgvAgrupadoresBalanceGeneral.Rows(e.RowIndex).Cells(clmDescripcion.Index).Value.ToString
        txtOrden.Text = dgvAgrupadoresBalanceGeneral.Rows(e.RowIndex).Cells(clmPriodidad.Index).Value.ToString

        If CType(dgvAgrupadoresBalanceGeneral.Rows(e.RowIndex).Cells(clmBalanceGral.Index).Value, Boolean) Then
            rbnBalancegrl.Checked = True
        Else
            rbnEstadoResultados.Checked = True
        End If

        If CType(dgvAgrupadoresBalanceGeneral.Rows(e.RowIndex).DataBoundItem, EC.CatAgrupadoresBalGralEdoResEntity).EsActivo Then
            rbnActivo.Checked = True
        Else
            rbnPasivo.Checked = True
        End If
        MEAToolBar1.sbCambiarEstadoBotones("Buscar")
    End Sub

    Private Sub txtOrden_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOrden.KeyPress
        If Not IsNumeric(e.KeyChar) And Keys.Back <> Asc(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
#End Region

End Class