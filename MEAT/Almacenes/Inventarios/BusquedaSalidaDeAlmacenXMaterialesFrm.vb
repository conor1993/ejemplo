Public Class BusquedaSalidaDeAlmacenXMaterialesFrm

    Public MovAlm As New ClasesNegocio.MovimientosAlmacenClass


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.DgvMovimientos.SelectedRows.Count > 0 Then
            Dim movAlmC As New ClasesNegocio.MovAlmacenCollecionClass
            Dim Malm As ClasesNegocio.MovimientosAlmacenClass = Me.DgvMovimientos.SelectedRows(0).DataBoundItem
            movAlmC.Obtener(Malm.AlmacenId, Malm.FolioMovimiento, Malm.TipoMovimientoId)
            If movAlmC.Count = 1 Then
                Me.MovAlm = movAlmC(0)
            End If
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BusquedaSalidaDeAlmacenXMaterialesFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Limpiar()
            Me.MovAlmCol.Obtener(Now, "SALIDAS DE MATERIALES")
            Limpiar()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub Limpiar()
        Me.txtFolio.Clear()
        Me.DtpFechaInicio.Value = Now
        Me.dtpFechaFinal.Value = Now
        Me.RbtnTodos.Checked = True
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            If Me.txtFolio.Text <> "" Then
                If Me.RbtnTodos.Checked Then
                    Me.MovAlmCol.Obtener(Me.txtFolio.Text, ClasesNegocio.CondicionEstatusEnum.TODOS, "SALIDAS DE MATERIALES")
                ElseIf Me.RbtnActivo.Checked Then
                    Me.MovAlmCol.Obtener(Me.txtFolio.Text, ClasesNegocio.CondicionEstatusEnum.ACTIVO, "SALIDAS DE MATERIALES")
                Else
                    Me.MovAlmCol.Obtener(Me.txtFolio.Text, ClasesNegocio.CondicionEstatusEnum.INACTIVO, "SALIDAS DE MATERIALES")
                End If
            Else
                If Me.RbtnTodos.Checked Then
                    Me.MovAlmCol.Obtener(Me.DtpFechaInicio.Value, Me.dtpFechaFinal.Value, ClasesNegocio.CondicionEstatusEnum.TODOS, "SALIDAS DE MATERIALES")
                ElseIf Me.RbtnActivo.Checked Then
                    Me.MovAlmCol.Obtener(Me.DtpFechaInicio.Value, Me.dtpFechaFinal.Value, ClasesNegocio.CondicionEstatusEnum.ACTIVO, "SALIDAS DE MATERIALES")
                Else
                    Me.MovAlmCol.Obtener(Me.DtpFechaInicio.Value, Me.dtpFechaFinal.Value, ClasesNegocio.CondicionEstatusEnum.INACTIVO, "SALIDAS DE MATERIALES")
                End If

            End If

        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub
End Class