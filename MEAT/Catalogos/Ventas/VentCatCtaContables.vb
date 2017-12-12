Public Class VentCatCtaContables
    Dim WithEvents ProveedorDcCol As New ClasesNegocio.ProvDtosContablesCollectionClass
    Private PDtoContable As New ClasesNegocio.ProvDtosContablesClass
    Private CteCta As New ClasesNegocio.ClienteCuentasClass
    Private ProvCta As New ClasesNegocio.ProvDtosContablesClass
    
    Public Property ClienteCuenta() As ClasesNegocio.ClienteCuentasClass
        Get
            Return CteCta
        End Get
        Set(ByVal value As ClasesNegocio.ClienteCuentasClass)
            CteCta = value
        End Set
    End Property

    Public Property ProveedorContable() As ClasesNegocio.ProvDtosContablesClass
        Get
            Return ProvCta
        End Get
        Set(ByVal value As ClasesNegocio.ProvDtosContablesClass)
            ProvCta = value
        End Set
    End Property

    Private Sub TxtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtCtaCtrl.Focus()
            If TxtCodigo.Text = "" Then
                MsgBox("Agregue Informacion al Codigo . . . ")
                TxtCodigo.Focus()
            End If
        End If
    End Sub

    Private Sub TxtCtaCtrl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCtaCtrl.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtCta1.Focus()
            If TxtCtaCtrl.Text = "" Then
                MsgBox("Agregue Informacion a la Cuenta de Control . . . ")
                TxtCtaCtrl.Focus()
            End If
        End If
    End Sub

    Private Sub TxtCta1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCta1.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtCta2.Focus()
            If TxtCta1.Text = "" Then
                MsgBox("Agregue Informacion a la Cuenta . . . ")
                TxtCta1.Focus()
            End If
        End If
        'Valida que el caracter ingresado sea numerico
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCta2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCta2.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtCta3.Focus()
            If TxtCta2.Text = "" Then
                MsgBox("Agregue Informacion a la Subcuenta . . . ")
                TxtCta2.Focus()
            End If
        End If
        'Valida que el caracter ingresado sea numerico
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCta3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCta3.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtCta4.Focus()
            If TxtCta3.Text = "" Then
                MsgBox("Agregue Informacion a la Subcuenta . . . ")
                TxtCta3.Focus()
            End If
        End If
        'Valida que el caracter ingresado sea numerico
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCta4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCta4.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtDescripcion.Focus()
            If TxtCta4.Text = "" Then
                MsgBox("Agregue Informacion a la SubSucuenta . . . ")
                TxtCta4.Focus()
            End If
        End If
        'Valida que el caracter ingresado sea numerico
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripcion.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            BtnAceptar.Focus()
            If TxtDescripcion.Text = "" Then
                MsgBox("Agregue Informacion a la Descripción . . . ")
                TxtDescripcion.Focus()
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        'CteCta = New ClasesNegocio.ClienteCuentasClass
        'CteCta.Descripcion = Me.TxtCtaCtrl.Text
        'Me.DialogResult = Windows.Forms.DialogResult.OK

        'ProvCta = New ClasesNegocio.ProvDtosContablesClass
        'ProvCta.CtaMay = Me.TxtCtaCtrl.Text
        'Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class