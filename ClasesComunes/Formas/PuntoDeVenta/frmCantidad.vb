Public Class frmCantidad
    Public lnCantidad As Decimal = 0D

    Private Sub frmPagoEfectivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Chr(13)
                BtnAceptar_Click(sender, New System.EventArgs())
            Case Chr(27)
                BtnCancelar_Click(sender, New System.EventArgs())
        End Select
    End Sub

    Private Sub VentaPgoEfectivo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.BtnAceptar.Enabled = False
        'txtCantidad.Text = lnCantidad.ToString("N3")
        txtCantidad.Focus()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim valor As Decimal
        If System.Decimal.TryParse(Me.txtCantidad.Text, valor) Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Abort
        Me.Close()
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not IsNumeric(Me.txtCantidad.Text & e.KeyChar) Then
            If e.KeyChar <> "." Or txtCantidad.Text.Contains(".") Then
                If Not e.KeyChar = Chr(Keys.Back) Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged
        If Not (IsNumeric(Me.txtCantidad.Text) Or txtCantidad.Text.Trim = ".") Then
            Me.txtCantidad.Text = ""
            Me.BtnAceptar.Enabled = False
        Else
            Dim lnCant As Decimal = 0
            If IsNumeric(Me.txtCantidad.Text) Then lnCant = CDec(txtCantidad.Text) Else lnCant = 0
            If (lnCant > 0) Then
                Me.BtnAceptar.Enabled = True
            Else
                Me.BtnAceptar.Enabled = False
            End If
        End If
    End Sub

End Class