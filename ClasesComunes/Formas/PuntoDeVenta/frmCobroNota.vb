Public Class frmCobroNota

    Public ImporteTotal As Decimal = 0D
    Public ImportePago As Decimal = 0D
    Public ImporteTarj As Decimal = 0D
    Public bandera As Boolean = False

    Public f8 As Boolean = False


    Public Property PresionoF8() As Boolean
        Get
            Return Me.f8
        End Get
        Set(ByVal Value As Boolean)
            Me.f8 = Value
        End Set
    End Property

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
        Me.lblTotal.Text = Me.ImporteTotal.ToString("N2")
        Me.txtEfectivo.Text = Me.ImporteTotal.ToString("N2")
        txtEfectivo.Focus()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim lnEfec, lnTarj As Decimal
        If IsNumeric(Me.txtEfectivo.Text) Then lnEfec = CDec(txtEfectivo.Text) Else lnEfec = 0
        If IsNumeric(Me.txtTarjeta.Text) Then lnTarj = CDec(txtTarjeta.Text) Else lnTarj = 0
        'If lnEfec > 0 Then
        If lnTarj > 0 Then
            If lnTarj > (CDec(lblTotal.Text) - lnEfec) Then
                'txtTarjeta.Text = (CDec(lblTotal.Text) - lnEfec).ToString("N2")
                If txtTarjeta.Focused Then
                    Me.txtEfectivo.Focus()
                Else
                    txtTarjeta.Focus()
                End If
                Exit Sub
            End If

        End If

        'End If

        If CDec(lblTotal.Text) <= lnEfec + lnTarj Then

            If f8 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Dim forma As New frmCobrarEmergente
                forma.Padre = Me
                If forma.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                End If
            End If

            

        Else
            If txtTarjeta.Focused Then
                Me.txtEfectivo.Focus()
            Else
                txtTarjeta.Focus()
            End If

        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Abort
        Me.Close()
    End Sub

    Private Sub txtEfectivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEfectivo.KeyPress
        If Not IsNumeric(Me.txtEfectivo.Text & e.KeyChar) Then
            'If Not e.KeyChar = Chr(Keys.Back) Then
            '    e.Handled = True
            'End If
            If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) And e.KeyChar <> "." Then
                e.Handled = True
            End If

            If e.KeyChar = "." And CType(sender, TextBox).Text.IndexOf(".") > -1 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtEfectivo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEfectivo.TextChanged
        If bandera = True Then Exit Sub
        If Not IsNumeric(Me.txtEfectivo.Text) Then
            Me.txtEfectivo.Text = ""
            Me.BtnAceptar.Enabled = False
        Else
            Dim lnEfec, lnTarj As Decimal
            If IsNumeric(Me.txtEfectivo.Text) Then lnEfec = CDec(txtEfectivo.Text) Else lnEfec = 0
            If IsNumeric(Me.txtTarjeta.Text) Then lnTarj = CDec(txtTarjeta.Text) Else lnTarj = 0
            If lnEfec = CDec(lblTotal.Text) Then
                txtTarjeta.Text = 0
                lnTarj = 0
            End If

            If (lnEfec + lnTarj >= Me.ImporteTotal) Then
                If lnTarj > 0 Then
                    Me.BtnAceptar.Enabled = False
                Else
                    Me.BtnAceptar.Enabled = True
                End If

                'Me.BtnAceptar.Enabled = True
                'Me.txtEfectivo.Text = txtEfectivo.Text.ToString("N2")
                lblCambio.Text = Format(lnEfec + lnTarj - CDec(lblTotal.Text), "N2")
            Else
                Me.BtnAceptar.Enabled = False
                lblCambio.Text = ""
            End If
        End If
    End Sub

    Private Sub txtTarjeta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTarjeta.KeyPress
        If Not IsNumeric(Me.txtTarjeta.Text & e.KeyChar) Then
            If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) And e.KeyChar <> "." Then
                e.Handled = True
            End If

            If e.KeyChar = "." And CType(sender, TextBox).Text.IndexOf(".") > -1 Then
                e.Handled = True
            End If

            'If Not e.KeyChar = Chr(Keys.Decimal) Then
            '    If Not e.KeyChar = Chr(Keys.Back) Then
            '        e.Handled = True
            '    End If
            'End If
            'If Not e.KeyChar = Chr(Keys.Back) And Not Char.IsDigit(e.KeyChar) Then
            '    e.Handled = True
            'End If
        End If
    End Sub

    Private Sub txtTarjeta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTarjeta.TextChanged
        If Not IsNumeric(Me.txtTarjeta.Text) Then
            'Me.txtTarjeta.Text = ""
            Me.BtnAceptar.Enabled = False
        Else
            Dim lnEfec, lnTarj As Decimal
            If IsNumeric(Me.txtEfectivo.Text) Then lnEfec = CDec(txtEfectivo.Text) Else lnEfec = 0
            If IsNumeric(Me.txtTarjeta.Text) Then lnTarj = CDec(txtTarjeta.Text) Else lnTarj = 0
            If (lnEfec + lnTarj >= Me.ImporteTotal) Then
                Me.BtnAceptar.Enabled = True
                lblCambio.Text = Format(lnEfec + lnTarj - CDec(lblTotal.Text), "N2")
            Else
                Me.BtnAceptar.Enabled = False
                lblCambio.Text = ""
            End If
        End If
    End Sub

    Private Sub txtTarjeta_Enter(sender As System.Object, e As System.EventArgs) Handles txtTarjeta.Enter
        Dim lnEfec, lnTarj As Decimal
        If IsNumeric(Me.txtEfectivo.Text) Then lnEfec = CDec(txtEfectivo.Text) Else lnEfec = 0
        If IsNumeric(Me.txtTarjeta.Text) Then lnTarj = CDec(txtTarjeta.Text) Else lnTarj = 0

        If (lnEfec) < CDec(lblTotal.Text) Then
            txtTarjeta.Text = CDec(lblTotal.Text) - lnEfec
        End If
        Me.txtTarjeta.SelectAll()

    End Sub

    Private Sub txtEfectivo_Leave(sender As System.Object, e As System.EventArgs) Handles txtEfectivo.Leave
        If Not Me.txtEfectivo.Text.Trim.Equals("") Then
            bandera = True
            Me.txtEfectivo.Text = CDec(txtEfectivo.Text).ToString("N2")
            bandera = False
        Else
            Me.txtEfectivo.Text = (0).ToString("N2")
        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class