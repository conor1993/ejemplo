Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses


Public Class FrmAperturaLoteCorte
    Private Sub MEAToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles MEAToolBar1.ButtonClick
        Select Case e.Button.Text
            Case "Guardar"
                If Not Guardar() Then
                    MessageBox.Show("No se pudo generar Lote de Corte", "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Se genero lote de corte con folio  : " & Me.txtLoteCorte.Text, "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Me.Limpiar()
            Case "Buscar"
                If Not Buscar() Then
                    MessageBox.Show("No se encuentran lotes de corte disponibles", "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case "Imprimir"
                If Not Imprimir() Then
                    MessageBox.Show("No se encuentran lotes de corte disponible para impresion", "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case "Salir"
                Me.Close()
        End Select
    End Sub
    Private Function Guardar() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
        Try
            Dim LoteCorte As New CortesClass
            LoteCorte.LoteSacrificio = Me.txtFolioSacrificio.Text
            LoteCorte.FechaCorte = Me.dtpFechaLoteCorte.Value
            LoteCorte.FechaFapsa = Me.dtpFechaSacrificio.Value
            LoteCorte.IdCliente = Me.txtCodCliente.Text
            LoteCorte.DiasCad = Me.txtDiasCaducidad.Text
            LoteCorte.FechaCad = Me.dtpFechaCaducidad.Value
            LoteCorte.Observaciones = Me.txtObservaciones.Text
            LoteCorte.Estatus = "A"
            LoteCorte.Func = "I"
            LoteCorte.NumOpc = 1
            If Not LoteCorte.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If
            Me.txtLoteCorte.Text = LoteCorte.LoteCorte
            Trans.Commit()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Trans.Rollback()
            Return False
        End Try


    End Function
    Private Function Limpiar() As Boolean
        Me.txtLoteCorte.Text = 0
        Me.txtFolioSacrificio.Text = ""
        Me.txtCodCliente.Text = 0
        Me.txtDiasCaducidad.Text = 0
        Me.txtNombre.Text = ""
        Me.txtObservaciones.Text = ""
        Me.dtpFechaCaducidad.Value = Now
        Me.dtpFechaLoteCorte.Value = Now
        Me.dtpFechaSacrificio.Value = Now
    End Function
    Private Function Buscar() As Boolean
        Dim TablaEmbarque As DataSet = Integralab.ORM.StoredProcedureCallerClasses.RetrievalProcedures.UspConMscloteCortesCab(1, "")
        'Dim Consultas As New FrmConsLoteCortes
        'Consultas.dgvLoteCortes.AutoGenerateColumns = False
        'Consultas.dgvLoteCortes.DataSource = TablaEmbarque.Tables(0)
        'Consultas.LoteCorte.DataPropertyName = "IdFolioLoteCorte"
        'Consultas.FechaCorte.DataPropertyName = "FechaCorte"
        'Consultas.Cliente.DataPropertyName = "Nom_Cliente"
        'Consultas.DiasCad.DataPropertyName = "DiasCad"
        'Consultas.Estatus.DataPropertyName = "Estatus"
        'If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    Me.txtLoteCorte.Text = Consultas.dgvLoteCortes.CurrentRow.Cells("IdFolioLoteCorte").Value
        '    Me.dtpFechaLoteCorte.Value = Consultas.dgvLoteCortes.CurrentRow.Cells("Fecha").Value
        '    Me.txtNombre.Text = Consultas.dgvLoteCortes.CurrentRow.Cells("Cliente").Value
        '    Me.txtDiasCaducidad.Text = Consultas.dgvLoteCortes.CurrentRow.Cells("DiasCad").Value
        '    Me.lblEstatus.Text = Consultas.dgvLoteCortes.CurrentRow.Cells("Estatus").Value
        'End If
        Me.txtLoteCorte.Focus()
    End Function
    Private Function Imprimir() As Boolean
    End Function

    Private Sub txtFolioSacrificio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolioSacrificio.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.dtpFechaSacrificio.Focus()
        End If
    End Sub

    Private Sub dtpFechaLoteCorte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaLoteCorte.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtFolioSacrificio.Focus()
        End If
    End Sub

    Private Sub dtpFechaSacrificio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaSacrificio.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtCodCliente.Focus()
        End If
    End Sub

    Private Sub txtCodCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodCliente.KeyPress
        If Not e.KeyChar = Chr(8) And Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            Me.txtCodCliente.Focus()
        End If
    End Sub


    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtDiasCaducidad.Focus()
        End If
    End Sub


    Private Sub txtDiasCaducidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiasCaducidad.KeyPress
        If e.KeyChar = Chr(13) Then
            'Me.dtpFechaCaducidad.Value = Me.dtpFechaCaducidad. + Me.txtDiasCaducidad.Text
            Me.txtObservaciones.Focus()
        End If
    End Sub

    Private Sub FrmAperturaLoteCorte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Limpiar()
    End Sub

    Private Sub txtDiasCaducidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiasCaducidad.TextChanged

    End Sub

    Private Sub txtCodCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodCliente.TextChanged

    End Sub
End Class