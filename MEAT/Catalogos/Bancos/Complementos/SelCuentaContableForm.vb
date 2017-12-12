Imports CN = ClasesNegocio
Public Class SelCuentaContableForm

    Property CuentasContables() As CN.CuentaContableCollectionClass
        Get
            Return Cuentas
        End Get
        Set(ByVal value As CN.CuentaContableCollectionClass)
            Cuentas = value
        End Set
    End Property

    Private _Cuenta As CN.CuentaContableClass
    Public Property CuentaContable() As CN.CuentaContableClass
        Get
            Return _Cuenta
        End Get
        Set(ByVal value As CN.CuentaContableClass)
            _Cuenta = value
        End Set
    End Property

    Private Sub SelCuentaContableForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb.DisplayMember = "NombreLargo"
        cmb.ValueMember = "NombreCuenta"
        cmb.DataSource = Cuentas
        RellenarNombre()
    End Sub

    Private Sub RellenarNombre()
        Dim Lista As New List(Of String)
        For Each Cta As CN.CuentaContableClass In Cuentas
            Lista.Add(Cta.NombreCuenta)
        Next
        txtNombre.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtNombre.AutoCompleteCustomSource.AddRange(Lista.ToArray)
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmb.SelectedIndex > -1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        cmb.SelectedValue = txtNombre.Text
    End Sub

    Private Sub cmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb.SelectedIndexChanged
        If cmb.SelectedIndex > -1 Then
            txtNombre.Text = cmb.SelectedValue
            _Cuenta = cmb.SelectedItem
        Else
            _Cuenta = Nothing
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

End Class