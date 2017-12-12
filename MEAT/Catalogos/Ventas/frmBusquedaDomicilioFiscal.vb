Public Class frmBusquedaDomicilioFiscal

    Public Property RFC() As String
        Get
            Return ""
            'Return Me.txtRFC.Text
        End Get
        Set(ByVal value As String)
            'Me.txtRFC.Text = value
        End Set
    End Property

    Private Sub Buscar()
        'DomicilioFiscalC.Obtener(txtRFC.Text, Me.txtRazonSocial.Text, Me.txtDomicilio.Text, Me.txtColonia.Text, Me.txtCP.Text, ClasesNegocio.CondicionEnum.ACTIVOS)
    End Sub

    Private Sub txtRFC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = " " And e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ventana As New FrmNuevoDomicilio
        'ventana.RFC = RFC
        'ventana.TxtRFC.Enabled = False
        'ventana.TxtRazonSocial.Text = Me.txtRazonSocial.Text
        'ventana.TxtRazonSocial.Enabled = False

        If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
            Buscar()
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.DataGridView1.SelectedRows.Count = 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Buscar()
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Me.txtColonia.Clear()
        Me.txtCP.Clear()
        Me.txtDomicilio.Clear()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub
End Class