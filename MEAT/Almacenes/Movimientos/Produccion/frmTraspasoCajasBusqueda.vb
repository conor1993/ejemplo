Imports CN = ClasesNegocio
Imports TC = Integralab.ORM.TypedViewClasses
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmTraspasoCajasBusqueda

#Region "Miembros"
    Dim busqueda As New TC.VwTraspasoDeCajasTypedView
#End Region

#Region "Metodos"
    Private Sub Limpiar()
        Me.txtFolioTraspaso.Clear()
        Me.cmbAlmacenDestino.SelectedIndex = -1
        Me.cmbAlmacenDestino.Text = "Seleccione un almacén..."
        Me.chkFiltrarFecha.Checked = False
        Me.chkCancelados.Checked = True
        Me.chkVigentes.Checked = True
    End Sub
#End Region

#Region "Eventos"
#Region "ChekBox"
    Private Sub chkVigentes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigentes.CheckedChanged
        If Not Me.chkCancelados.Checked AndAlso Not Me.chkVigentes.Checked Then
            Me.chkVigentes.Checked = True
            Me.chkCancelados.Checked = True
        End If
    End Sub

    Private Sub chkCancelados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCancelados.CheckedChanged
        If Not Me.chkCancelados.Checked AndAlso Not Me.chkVigentes.Checked Then
            Me.chkVigentes.Checked = True
            Me.chkCancelados.Checked = True
        End If
    End Sub

    Private Sub chkFiltrarFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltrarFecha.CheckedChanged
        If Me.chkFiltrarFecha.Checked Then
            Me.gbRangoFechas.Enabled = True
            Me.dtFechaFin.Value = Now
            Me.dtFechaInicial.Value = Now
        Else
            Me.gbRangoFechas.Enabled = False
        End If
    End Sub
#End Region

#Region "ToolBar"
    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim filtro As New OC.PredicateExpression

            If Me.txtFolioTraspaso.Text.Trim = "" Then
                If Me.chkFiltrarFecha.Checked Then
                    filtro.Add(New OC.FieldBetweenPredicate(HC.VwTraspasoDeCajasFields.FechaMovimiento, _
                                Me.dtFechaInicial.Value.ToShortDateString, _
                                Me.dtFechaFin.Value.AddDays(1).ToShortDateString))
                End If

                If Me.cmbAlmacenDestino.SelectedIndex > 0 Then
                    filtro.Add(HC.VwTraspasoDeCajasFields.IdAlmacenDestino = Me.cmbAlmacenDestino.SelectedValue)
                End If

                If Not (Me.chkVigentes.Checked = Me.chkCancelados.Checked) Then
                    If Me.chkVigentes.Checked Then filtro.Add(HC.VwTraspasoDeCajasFields.Estatus = 1)
                    If Me.chkCancelados.Checked Then filtro.Add(HC.VwTraspasoDeCajasFields.Estatus = 0)
                End If
            Else
                filtro.Add(HC.VwTraspasoDeCajasFields.FolioTransferencia = Me.txtFolioTraspaso.Text.Trim)
            End If

            Me.busqueda.Fill(0, Nothing, False, filtro)
            Me.DataGridView1.AutoGenerateColumns = False
            Me.DataGridView1.DataSource = Me.busqueda
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region

#Region "DateTimePiker"
    Private Sub dtFechaFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtFechaFin.ValueChanged
        Dim fechaI As String = Me.dtFechaInicial.Value.ToShortDateString
        Dim fechaF As String = Me.dtFechaFin.Value.ToShortDateString

        If Date.Compare(DateTime.Parse(fechaI), DateTime.Parse(fechaF)) > 0 Then
            Me.dtFechaFin.Value = Me.dtFechaInicial.Value
        End If
    End Sub

    Private Sub dtFechaInicial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtFechaInicial.ValueChanged
        Dim fechaI As String = Me.dtFechaInicial.Value.ToShortDateString
        Dim fechaF As String = Me.dtFechaFin.Value.ToShortDateString

        If Date.Compare(DateTime.Parse(fechaI), DateTime.Parse(fechaF)) > 0 Then
            Me.dtFechaFin.Value = Me.dtFechaInicial.Value
        End If
    End Sub
#End Region

#Region "Buttons"
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.DataGridView1.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

#End Region

End Class